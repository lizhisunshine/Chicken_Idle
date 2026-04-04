# 技能树架构文档：ScriptableObject + 事件中心

## 一、架构概述

本文档描述一种基于 ScriptableObject（以下简称 SO）和事件中心的技能树架构。
该架构将技能树的数据、逻辑、UI 三者完全解耦，新增技能节点只需创建 SO 文件填写数据，
不需要修改任何现有代码。

### 核心思想

- **数据层**：每个技能节点是一个 SO 文件，存储不变的配置数据（名字、价格、效果等）
- **运行时层**：每个节点有一个运行时状态对象，存储会变化的数据（购买次数）
- **管理层**：技能树管理器统一管理所有节点的购买逻辑
- **通信层**：通过事件中心广播技能购买事件，各系统自行订阅响应
- **UI 层**：每个 UI 节点持有对应的 SO 引用，通过事件驱动刷新显示

### 与原项目对比

| 对比项 | 原项目 | 新架构 |
|--------|--------|--------|
| 数据存储 | 硬编码在静态字段中 | ScriptableObject 文件 |
| 新增节点 | 需要修改多处代码 | 创建 SO 文件即可 |
| 效果触发 | 直接修改静态变量 | 事件中心广播 |
| 前置条件 | 手动 if 判断 | SO 数组自动检查 |
| UI 更新 | Update 每帧检查所有节点 | 事件驱动按需刷新 |
| 耦合度 | 极高 | 低 |
| 存档 | 每个节点单独写一行存档代码 | 循环自动收集 |

---

## 二、数据层：SkillNodeSO

### 2.1 脚本定义

```csharp
using UnityEngine;

// 资源类型枚举，对应游戏中的8种矿条
public enum ResourceType
{
    Gold,       // 金矿条
    Copper,     // 铜矿条
    Iron,       // 铁矿条
    Cobalt,     // 钴矿条
    Uranium,    // 铀矿条
    Ismium,     // Ismium矿条
    Iridium,    // 铱矿条
    Painite     // Painite矿条
}

// [CreateAssetMenu] 让你可以在 Unity 编辑器中右键创建该 SO 文件
// 路径为 Assets > Create > SkillTree > SkillNode
[CreateAssetMenu(menuName = "SkillTree/SkillNode")]
public class SkillNodeSO : ScriptableObject
{
    [Header("基本信息")]
    public string nodeName;         // 节点名称，同时用作存档的 key
    [TextArea]
    public string description;      // 节点描述，显示在 UI tooltip 中
    public Sprite icon;             // 节点图标

    [Header("购买配置")]
    public int maxPurchaseCount;    // 最大购买次数，达到后不能再购买
    public double basePrice;        // 基础价格，第一次购买时的价格
    public float priceMultiplier;   // 涨价倍数，每次购买后价格乘以此值
    // 举例：basePrice=100, priceMultiplier=2
    //   第1次购买：100
    //   第2次购买：200
    //   第3次购买：400

    [Header("消耗资源")]
    public ResourceType costResource; // 购买时消耗哪种资源

    [Header("前置条件")]
    public SkillNodeSO[] prerequisites; // 前置节点数组
    // 所有前置节点的 purchaseCount > 0 时，本节点才解锁
    // 如果数组为空，表示没有前置条件

    [Header("效果配置")]
    public string effectEventName;  // 购买时触发的事件名
    // 各系统通过匹配这个字符串来决定是否响应
    // 例如："spawnMoreRocks"、"improvedPickaxe"、"unlockCopper"

    public float effectValue;       // 效果数值
    // 对于数值叠加型：每次购买增加的数值
    // 对于解锁型：不使用此字段（设为0即可）

    public bool isUnlockType;       // 是否为解锁型技能
    // true = 购买一次后解锁某功能（如解锁铜矿生成）
    // false = 可多次购买，每次叠加数值
}
```

### 2.2 字段详解

**nodeName**
- 作用：节点的唯一标识符
- 存档时用它作为 key，所以一旦确定不要修改
- 建议使用英文命名，如 "spawnMoreRocks_1"

**maxPurchaseCount**
- 作用：限制购买次数
- 解锁型技能设为 1
- 数值叠加型根据设计需求设置，如 3、5 等

**basePrice 和 priceMultiplier**
- 两者配合实现涨价机制
- 当前价格公式：basePrice × priceMultiplier^purchaseCount
- 如果不需要涨价，priceMultiplier 设为 1

**prerequisites**
- 在 Inspector 中直接拖入其他 SO 文件
- 运行时自动检查所有前置节点是否已购买
- 支持多个前置条件（全部满足才解锁）

**effectEventName**
- 这是连接数据层和逻辑层的桥梁
- 各系统订阅事件后，通过匹配这个字符串决定是否响应
- 同一个 effectEventName 可以被多个系统响应

---

## 三、运行时层：SkillNodeRuntime

### 3.1 脚本定义

```csharp
using System;
using System.Linq;

// 这个类不是 MonoBehaviour，不挂在 GameObject 上
// 它是纯 C# 类，由 SkillTreeManager 创建和管理
// 每个 SkillNodeSO 对应一个 SkillNodeRuntime 实例
public class SkillNodeRuntime
{
    public SkillNodeSO data;        // 引用对应的 SO 配置数据
    public int purchaseCount;       // 当前购买次数（运行时会变化）

    // 当前价格，随购买次数自动涨价
    // 使用 Math.Pow 计算指数增长
    public double CurrentPrice =>
        data.basePrice * Math.Pow(data.priceMultiplier, purchaseCount);

    // 是否已达购买上限
    public bool IsMaxed =>
        purchaseCount >= data.maxPurchaseCount;

    // 前置节点是否都已购买
    // 遍历所有前置节点，检查它们的 purchaseCount 是否 > 0
    // 如果 prerequisites 为空数组，All() 返回 true，即无前置条件
    public bool IsUnlocked =>
        data.prerequisites.All(p =>
            SkillTreeManager.instance.GetNode(p).purchaseCount > 0);

    // 是否有足够资源购买
    public bool CanAfford(double currentResource) =>
        currentResource >= CurrentPrice;

    // 综合判断：是否可以购买
    // 三个条件同时满足：未达上限 + 已解锁 + 资源足够
    public bool CanPurchase(double currentResource) =>
        !IsMaxed && IsUnlocked && CanAfford(currentResource);
}
```

### 3.2 为什么需要运行时层

SO 是资产文件，存储的是不变的配置数据。运行时会变化的数据（purchaseCount）
不应该存在 SO 里，否则：
- 编辑器模式下修改会永久保存到资产文件
- 多个存档会互相干扰
- 重置游戏时需要手动恢复 SO 的原始值

SkillNodeRuntime 将可变状态和不变配置分离，SO 永远保持原始数据，
运行时状态由管理器统一创建和管理。

### 3.3 计算属性的好处

CurrentPrice、IsMaxed、IsUnlocked 都是计算属性（getter），
不存储值，每次访问时实时计算。好处是：
- 不需要在购买后手动更新这些值
- 不会出现数据不一致的问题
- purchaseCount 变了，所有依赖它的属性自动更新

---

## 四、通信层：事件中心

### 4.1 事件定义

```csharp
using System;

public class EventCenter
{
    // 技能购买事件
    // 参数1：SkillNodeSO - 被购买的节点数据
    // 参数2：int - 当前购买次数（购买后的值）
    //
    // 使用 C# 的 event + Action 实现观察者模式
    // 任何脚本都可以订阅（+=）或取消订阅（-=）
    public static event Action<SkillNodeSO, int> OnSkillPurchased;

    // 触发事件的方法
    // 只有 SkillTreeManager 会调用这个方法
    // ?. 是空条件运算符，如果没有订阅者不会报错
    public static void TriggerSkillPurchased(SkillNodeSO node, int count)
        => OnSkillPurchased?.Invoke(node, count);
}
```

### 4.2 事件中心的作用

事件中心是技能树和各游戏系统之间的唯一通信渠道。

购买技能时的数据流：
```
玩家点击购买按钮
  → SkillTreeManager.TryPurchase()
  → 扣除资源，purchaseCount++
  → EventCenter.TriggerSkillPurchased(node, count)
  → 所有订阅者收到通知
      → RockSpawnSystem：增加岩石生成数量
      → PickaxeSystem：增加镐子伤害
      → SkillNodeUI：刷新显示
      → ...
```

各系统之间互不知道对方的存在，只和事件中心交互。
新增一个系统只需要订阅事件，不需要修改任何现有代码。

### 4.3 如果你的项目已有事件中心

如果你的项目已经有自己的事件中心实现，只需要在其中注册一个
技能购买事件即可，不需要单独创建上面的 EventCenter 类。
关键是保证事件能传递 SkillNodeSO 和 purchaseCount 两个参数。

---

## 五、管理层：SkillTreeManager

### 5.1 脚本定义

```csharp
using System.Collections.Generic;
using UnityEngine;

public class SkillTreeManager : MonoBehaviour
{
    public static SkillTreeManager instance;

    [Header("所有技能节点")]
    public SkillNodeSO[] allNodes; // 在 Inspector 中拖入所有节点 SO

    // 运行时状态字典：SO → Runtime
    private Dictionary<SkillNodeSO, SkillNodeRuntime> runtimeNodes = new();

    private void Awake()
    {
        instance = this;

        // 为每个 SO 创建对应的运行时状态
        foreach (var node in allNodes)
            runtimeNodes[node] = new SkillNodeRuntime { data = node };
    }

    // 获取某个节点的运行时状态
    // 被 SkillNodeRuntime.IsUnlocked 和 UI 脚本调用
    public SkillNodeRuntime GetNode(SkillNodeSO node) => runtimeNodes[node];

    // 尝试购买技能
    // 参数 resource 用 ref 传递，购买成功后直接扣除
    // 返回 true 表示购买成功，false 表示条件不满足
    public bool TryPurchase(SkillNodeSO node, ref double resource)
    {
        var runtime = runtimeNodes[node];

        // 综合检查：未达上限 + 已解锁 + 资源足够
        if (!runtime.CanPurchase(resource)) return false;

        // 扣除资源（当前价格，已涨价后的）
        resource -= runtime.CurrentPrice;

        // 购买次数 +1
        runtime.purchaseCount++;

        // 通过事件中心广播，让各系统自行响应
        EventCenter.TriggerSkillPurchased(node, runtime.purchaseCount);

        return true;
    }
}
```

### 5.2 TryPurchase 的设计

使用 ref 参数直接修改资源值，调用方不需要自己扣资源：

```csharp
// 调用示例（UI 按钮点击时）
SkillTreeManager.instance.TryPurchase(nodeData, ref PlayerData.goldBars);
// 如果购买成功，goldBars 已经被扣除了
```

返回 bool 让调用方知道是否成功，可以据此播放不同音效：

```csharp
if (SkillTreeManager.instance.TryPurchase(nodeData, ref resource))
    audioManager.Play("Purchase_Success");
else
    audioManager.Play("Purchase_Failed");
```

### 5.3 资源类型的处理

TryPurchase 接收的是 ref double，调用方需要根据 SO 的 costResource
字段传入对应的资源变量：

```csharp
// 根据 costResource 选择传入哪个资源
public void OnClickPurchase()
{
    ref double resource = ref GetResourceRef(nodeData.costResource);
    SkillTreeManager.instance.TryPurchase(nodeData, ref resource);
}

// 辅助方法：根据资源类型返回对应的资源引用
// 注意：ref 返回需要 C# 7.0+
private ref double GetResourceRef(ResourceType type)
{
    switch (type)
    {
        case ResourceType.Gold:    return ref PlayerData.goldBars;
        case ResourceType.Copper:  return ref PlayerData.copperBars;
        case ResourceType.Iron:    return ref PlayerData.ironBars;
        case ResourceType.Cobalt:  return ref PlayerData.cobaltBars;
        case ResourceType.Uranium: return ref PlayerData.uraniumBars;
        case ResourceType.Ismium:  return ref PlayerData.ismiumBars;
        case ResourceType.Iridium: return ref PlayerData.iridiumBars;
        case ResourceType.Painite: return ref PlayerData.painiteBars;
        default: throw new System.ArgumentException("Unknown resource type");
    }
}
```

---

## 六、效果响应层：各系统订阅事件

### 6.1 A类：纯数值叠加型

购买后给某个数值加一个固定值。占所有技能的 90% 以上。

```csharp
// 岩石生成系统
public class RockSpawnSystem : MonoBehaviour
{
    public int totalRocksToSpawn = 25; // 初始值

    private void OnEnable()
    {
        EventCenter.OnSkillPurchased += OnSkillPurchased;
    }

    private void OnDisable()
    {
        EventCenter.OnSkillPurchased -= OnSkillPurchased;
    }

    private void OnSkillPurchased(SkillNodeSO node, int count)
    {
        // 通过 effectEventName 匹配，只响应自己关心的技能
        switch (node.effectEventName)
        {
            case "spawnMoreRocks":
                totalRocksToSpawn += (int)node.effectValue;
                break;
            case "chanceToSpawnRockWhenMined":
                chanceToSpawnRock += node.effectValue;
                break;
            // 其他岩石相关技能...
        }
    }
}
```

A类技能完整列表：

| effectEventName | effectValue 含义 | 影响的变量 |
|-----------------|-----------------|-----------|
| moreXP | 每次增加的 XP 系数 | xpFromRock |
| spawnMoreRocks | 每次增加的岩石数 | totalRocksToSpawn |
| moreMeterialsFromRock | 每次增加的材料数 | materialsFromChunkRocks / materialsFromFullRocks |
| marterialsWorthMore | 每次增加的价值系数 | materialsTotalWorth |
| goldChunkChance | 每次增加的概率 | goldRockChance |
| fullGoldChance | 每次增加的概率 | fullGoldRockChance |
| copperChunkChance | 每次增加的概率 | copperRockChance |
| fullCopperChance | 每次增加的概率 | fullCopperRockChance |
| ironChunkChance | 每次增加的概率 | ironRockChance |
| fullIronChance | 每次增加的概率 | fullIronRockChance |
| cobaltChunkChance | 每次增加的概率 | cobaltRockChance |
| fullCobaltChance | 每次增加的概率 | fullCobaltRockChance |
| uraniumChunkChance | 每次增加的概率 | uraniumRockChance |
| fullUraniumChance | 每次增加的概率 | fullUraniumRockChance |
| ismiumChunkChance | 每次增加的概率 | ismiumRockChance |
| fullIsmiumChance | 每次增加的概率 | fullIsmiumRockChance |
| iridiumChunkChance | 每次增加的概率 | iridiumRockChance |
| fullIridiumChance | 每次增加的概率 | fullIridiumRockChance |
| painiteChunkChance | 每次增加的概率 | painiteRockChance |
| fullPainiteChance | 每次增加的概率 | fullPainiteRockChance |
| improvedPickaxe | 每次增加的镐子强度 | improvedPickaxeStrength |
| biggerMiningArea | 每次增加的挖矿范围 | miningAreaSize |
| moreTime | 每次增加的挖矿时间(秒) | mineSessionTime |
| doubleXpGoldChance | 每次增加的双倍概率 | doubleXpAndGoldChance |
| lightningDamage | 每次增加的闪电伤害 | lightningDamage |
| lightningSize | 每次增加的闪电范围 | lightningSize |
| lightningChanceS | 每次增加的闪电每秒触发概率 | lightningTriggerChanceS |
| lightningChancePH | 每次增加的闪电镐子触发概率 | lightningTriggerChancePH |
| dynamiteChance | 每次增加的炸药触发概率 | dynamiteStickChance |
| dynamiteExplosionSize | 每次增加的爆炸范围 | explosionSize |
| dynamiteDamage | 每次增加的爆炸伤害 | explosionDamagage |
| plazmaBallChance | 每次增加的等离子球生成概率 | plazmaBallChance |
| plazmaBallDamage | 每次增加的等离子球伤害 | plazmaBallTotalDamage |
| plazmaBallSize | 每次增加的等离子球大小 | plazmaBallTotalSize |
| pickaxeDoubleDamage | 每次增加的镐子双倍伤害概率 | doubleDamageChance |
| instaMineChance | 每次增加的秒杀概率 | instaMineChance |
| talentPointsPerLevel | 每次增加的天赋点/等级 | extraTalentPointPerLevel |
| increaseAllRockChance | 所有矿种概率统一增加 | 所有 rockChance |

### 6.2 B类：解锁开关型

购买一次后设一个 bool 为 true，解锁某个功能。

```csharp
// 矿种解锁系统
public class OreUnlockSystem : MonoBehaviour
{
    public bool copperUnlocked = false;
    public bool ironUnlocked = false;
    // ...

    private void OnEnable()
    {
        EventCenter.OnSkillPurchased += OnSkillPurchased;
    }

    private void OnDisable()
    {
        EventCenter.OnSkillPurchased -= OnSkillPurchased;
    }

    private void OnSkillPurchased(SkillNodeSO node, int count)
    {
        if (!node.isUnlockType) return; // 不是解锁型，跳过

        switch (node.effectEventName)
        {
            case "unlockCopper":
                copperUnlocked = true;
                // 可以在这里激活铜矿相关的 UI 元素
                break;
            case "unlockIron":
                ironUnlocked = true;
                break;
            // ...
        }
    }
}
```

B类技能完整列表：

| effectEventName | 解锁的功能 |
|-----------------|-----------|
| unlockCopper | 铜矿生成 |
| unlockIron | 铁矿生成 |
| unlockCobalt | 钴矿生成 |
| unlockUranium | 铀矿生成 |
| unlockIsmium | Ismium 生成 |
| unlockIridium | 铱矿生成 |
| unlockPainite | Painite 生成 |
| unlockCircleShoot | 圆形射击 |
| unlockAreaPulse | 挖矿区域脉动 |
| unlockLightningSplash | 闪电溅射 |
| unlockLightningSpawnRock | 闪电生成岩石 |
| unlockLightningExplosion | 闪电触发爆炸 |
| unlockLightningAddTime | 闪电加时间 |
| unlockLightningChain | 闪电连锁 |
| unlockDynamiteSplit | 炸药分裂 |
| unlockExplosionSpawnRock | 爆炸生成岩石 |
| unlockExplosionAddTime | 爆炸加时间 |
| unlockExplosionLightning | 爆炸触发闪电 |
| unlockPlazmaExplosion | 等离子球爆炸 |
| unlockPlazmaSplit | 等离子球分裂 |
| unlockPlazmaPickaxe | 等离子球生成镐子 |
| unlockProjectileDoubleDamage | 弹射物双倍伤害 |
| unlockProjectileTriggerBoost | 弹射物触发概率提升 |
| unlockCraft2Material | 双倍冶炼 |
| unlockFinalUpgrade | 终极升级 |

### 6.3 D类：复合型（需要特殊处理）

购买后修改时间间隔，需要重启对应的协程。

```csharp
// 弹射物生成系统
public class ProjectileSpawnSystem : MonoBehaviour
{
    private Coroutine pickaxeCoroutine;
    private float pickaxeInterval = 1.2f;

    private void OnEnable()
    {
        EventCenter.OnSkillPurchased += OnSkillPurchased;
    }

    private void OnDisable()
    {
        EventCenter.OnSkillPurchased -= OnSkillPurchased;
    }

    private void OnSkillPurchased(SkillNodeSO node, int count)
    {
        switch (node.effectEventName)
        {
            case "spawnPickaxeInterval":
                // 减少间隔
                pickaxeInterval -= node.effectValue;
                // 重启协程以应用新间隔
                if (pickaxeCoroutine != null)
                    StopCoroutine(pickaxeCoroutine);
                pickaxeCoroutine = StartCoroutine(PickaxeTimer());
                break;

            case "spawnRockInterval":
                // 类似处理...
                break;

            case "plazmaBallTime":
                // 增加等离子球持续时间
                plazmaBallDuration += node.effectValue;
                break;
        }
    }

    private IEnumerator PickaxeTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(pickaxeInterval);
            // 生成镐子逻辑...
        }
    }
}
```

D类技能完整列表：

| effectEventName | effectValue 含义 | 特殊处理 |
|-----------------|-----------------|---------|
| spawnRockEveryXRock | 减少的间隔岩石数 | 修改计数器阈值 |
| spawnRockInterval | 减少的秒数 | 重启岩石生成协程 |
| spawnPickaxeInterval | 减少的秒数 | 重启镐子生成协程 |
| plazmaBallTime | 增加的持续秒数 | 修改等离子球持续时间 |

---

## 七、UI 层：SkillNodeUI

### 7.1 脚本定义

```csharp
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// 挂在每个技能节点的 UI 按钮上
public class SkillNodeUI : MonoBehaviour
{
    [Header("数据引用")]
    public SkillNodeSO nodeData;    // 在 Inspector 中拖入对应的 SO

    [Header("UI 组件")]
    public GameObject plusButton;    // 加号按钮（可购买时显示）
    public TextMeshProUGUI countText;   // 购买次数文字 "3/5"
    public TextMeshProUGUI priceText;   // 价格文字
    public Image iconImage;         // 节点图标

    private SkillNodeRuntime runtime; // 运行时状态引用

    private void Start()
    {
        // 从管理器获取运行时状态
        runtime = SkillTreeManager.instance.GetNode(nodeData);

        // 订阅事件，任何技能购买后都刷新自身
        // 因为其他技能的购买可能影响本节点的解锁状态
        EventCenter.OnSkillPurchased += OnAnySkillPurchased;

        // 设置图标
        if (iconImage != null && nodeData.icon != null)
            iconImage.sprite = nodeData.icon;

        // 初始刷新
        RefreshUI();
    }

    private void OnDestroy()
    {
        // 取消订阅，防止内存泄漏
        EventCenter.OnSkillPurchased -= OnAnySkillPurchased;
    }

    // 按钮点击事件（在 Inspector 中绑定到 Button.OnClick）
    public void OnClickPurchase()
    {
        // 根据 costResource 获取对应资源的引用
        // 这里简化处理，实际项目中可以用 ResourceManager 统一管理
        double resource = GetCurrentResource();
        if (SkillTreeManager.instance.TryPurchase(nodeData, ref resource))
        {
            SetCurrentResource(resource); // 更新资源
            // 购买成功的音效、动画等
        }
    }

    // 任何技能购买后触发
    private void OnAnySkillPurchased(SkillNodeSO node, int count)
    {
        RefreshUI();
    }

    // 刷新 UI 显示
    private void RefreshUI()
    {
        double resource = GetCurrentResource();

        // 加号按钮：可购买时显示
        plusButton.SetActive(runtime.CanPurchase(resource));

        // 购买次数
        countText.text = $"{runtime.purchaseCount}/{nodeData.maxPurchaseCount}";

        // 价格（已涨价后的）
        priceText.text = FormatNumbers.FormatPoints(runtime.CurrentPrice);

        // 价格颜色：资源足够绿色，不足红色
        priceText.color = runtime.CanAfford(resource) ? Color.green : Color.red;
    }

    // 获取当前资源值（根据 costResource 类型）
    private double GetCurrentResource()
    {
        switch (nodeData.costResource)
        {
            case ResourceType.Gold:    return PlayerData.goldBars;
            case ResourceType.Copper:  return PlayerData.copperBars;
            case ResourceType.Iron:    return PlayerData.ironBars;
            case ResourceType.Cobalt:  return PlayerData.cobaltBars;
            case ResourceType.Uranium: return PlayerData.uraniumBars;
            case ResourceType.Ismium:  return PlayerData.ismiumBars;
            case ResourceType.Iridium: return PlayerData.iridiumBars;
            case ResourceType.Painite: return PlayerData.painiteBars;
            default: return 0;
        }
    }

    // 设置资源值
    private void SetCurrentResource(double value)
    {
        switch (nodeData.costResource)
        {
            case ResourceType.Gold:    PlayerData.goldBars = value; break;
            case ResourceType.Copper:  PlayerData.copperBars = value; break;
            case ResourceType.Iron:    PlayerData.ironBars = value; break;
            case ResourceType.Cobalt:  PlayerData.cobaltBars = value; break;
            case ResourceType.Uranium: PlayerData.uraniumBars = value; break;
            case ResourceType.Ismium:  PlayerData.ismiumBars = value; break;
            case ResourceType.Iridium: PlayerData.iridiumBars = value; break;
            case ResourceType.Painite: PlayerData.painiteBars = value; break;
        }
    }
}
```

### 7.2 UI 刷新机制

原项目在 Update() 里每帧检查所有节点的状态，非常浪费。
新架构用事件驱动：只有技能被购买时才刷新 UI。

但有一个问题：资源数量变化时（比如挖矿获得矿石），
加号按钮的显示状态也应该更新。解决方案：

```csharp
// 在事件中心添加资源变化事件
public static event Action OnResourceChanged;

// 资源变化时触发
public static void TriggerResourceChanged()
    => OnResourceChanged?.Invoke();

// SkillNodeUI 同时订阅资源变化事件
private void Start()
{
    EventCenter.OnSkillPurchased += OnAnySkillPurchased;
    EventCenter.OnResourceChanged += RefreshUI;
    RefreshUI();
}
```

---

## 八、存档系统集成

### 8.1 存档数据结构

```csharp
using System;
using System.Collections.Generic;

[Serializable]
public class SkillTreeSaveData
{
    // 用两个平行列表存储，nodeName 作为 key
    public List<string> nodeNames = new();
    public List<int> purchaseCounts = new();
}
```

### 8.2 存档方法

```csharp
// 在 SkillTreeManager 中添加
public SkillTreeSaveData GetSaveData()
{
    var data = new SkillTreeSaveData();
    foreach (var pair in runtimeNodes)
    {
        // 只存储购买过的节点，减少存档体积
        if (pair.Value.purchaseCount > 0)
        {
            data.nodeNames.Add(pair.Key.nodeName);
            data.purchaseCounts.Add(pair.Value.purchaseCount);
        }
    }
    return data;
}
```

### 8.3 读档方法

```csharp
public void LoadSaveData(SkillTreeSaveData data)
{
    // 先重置所有节点
    foreach (var pair in runtimeNodes)
        pair.Value.purchaseCount = 0;

    // 恢复存档数据
    for (int i = 0; i < data.nodeNames.Count; i++)
    {
        // 通过 nodeName 找到对应的 SO
        var node = System.Array.Find(allNodes, n => n.nodeName == data.nodeNames[i]);
        if (node != null)
        {
            runtimeNodes[node].purchaseCount = data.purchaseCounts[i];

            // 重新触发事件，让各系统恢复效果
            // 需要触发 purchaseCount 次，因为有些效果是累加的
            for (int j = 0; j < data.purchaseCounts[i]; j++)
                EventCenter.TriggerSkillPurchased(node, j + 1);
        }
    }
}
```

### 8.4 与现有存档系统集成

如果项目使用了类似原项目的 IDataPersistence 接口：

```csharp
// SkillTreeManager 实现 IDataPersistence
public class SkillTreeManager : MonoBehaviour, IDataPersistence
{
    public void SaveData(ref GameData data)
    {
        data.skillTreeData = GetSaveData();
    }

    public void LoadData(GameData data)
    {
        if (data.skillTreeData != null)
            LoadSaveData(data.skillTreeData);
    }
}

// GameData 中添加字段
[Serializable]
public class GameData
{
    public SkillTreeSaveData skillTreeData;
    // 其他存档数据...
}
```

### 8.5 与原项目存档方式对比

原项目为每个节点单独写存档代码：
```csharp
// 原项目：每个节点一行，几百行重复代码
data.moreXP_1_purchased = SkillTree.moreXP_1_purchased;
data.moreXP_1_purchaseCount = SkillTree.moreXP_1_purchaseCount;
data.moreXP_2_purchased = SkillTree.moreXP_2_purchased;
data.moreXP_2_purchaseCount = SkillTree.moreXP_2_purchaseCount;
// ... 几百行
```

新架构用循环自动收集，新增节点不需要改存档代码。

---

## 九、新增技能节点的完整流程

### 步骤1：创建 SO 文件
在 Unity 编辑器中：Assets > Create > SkillTree > SkillNode
填写所有字段。

### 步骤2：拖入管理器
将新创建的 SO 文件拖入 SkillTreeManager 的 allNodes 数组。

### 步骤3：创建 UI 节点
在技能树 UI 面板中创建一个新的按钮，挂上 SkillNodeUI 脚本，
将 SO 文件拖入 nodeData 字段。

### 步骤4：确认效果响应
如果 effectEventName 已经被某个系统处理（如 "spawnMoreRocks"），
不需要写任何代码。

如果是全新的效果类型，在对应系统的 OnSkillPurchased 中添加
一个 case 分支即可。

### 完成
不需要修改存档代码、不需要修改管理器代码、不需要修改 UI 刷新逻辑。

---

## 十、注意事项

### 10.1 effectEventName 命名规范
建议使用 camelCase，按功能分组：
- 岩石相关：spawnMoreRocks, chanceToSpawnRock, ...
- 矿种概率：goldChunkChance, fullGoldChance, ...
- 镐子相关：improvedPickaxe, biggerMiningArea, ...
- 闪电相关：lightningDamage, lightningSize, lightningChanceS, ...
- 炸药相关：dynamiteChance, dynamiteDamage, ...
- 等离子球：plazmaBallChance, plazmaBallDamage, ...
- 解锁类：unlockCopper, unlockIron, ...

### 10.2 事件订阅的生命周期
- 在 OnEnable 中订阅，OnDisable 中取消订阅
- 或在 Start 中订阅，OnDestroy 中取消订阅
- 不取消订阅会导致内存泄漏和空引用异常

### 10.3 读档时的事件触发
读档时需要重新触发事件让各系统恢复效果。
如果某些效果不适合重复触发（如解锁型），
可以在事件响应中加判断：

```csharp
case "unlockCopper":
    if (!copperUnlocked) // 防止重复解锁
    {
        copperUnlocked = true;
        // 激活 UI 等
    }
    break;
```

### 10.4 性能考虑
- 事件广播是 O(n)，n 是订阅者数量，通常很少
- 比原项目 Update 每帧检查所有节点高效得多
- SO 文件在内存中只有一份，不会因为节点数量增加而显著增加内存
