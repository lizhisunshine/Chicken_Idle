using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;

    //对象池字典
    [SerializeField] private Dictionary<GameObject,ObjectPool<GameObject>> poolsDic = new();
    [SerializeField] private Dictionary<GameObject,GameObject> prefabsLookUp = new();
    [SerializeField] public  GameObject[] prefabs = new GameObject[10];
    [SerializeField] private GameObject[] parents = new GameObject[10];
    public void Awake()
    {
        instance = this;

        //岩石池
        CreatPool(prefabs[0], 50, 1000, parents[0].transform);
        //稿子池
        CreatPool(prefabs[1], 50, 1000, parents[1].transform);
        //文字弹出池
        CreatPool(prefabs[2], 50, 1000, parents[2].transform);
        //地板瓦片池
        CreatPool(prefabs[3], 150, 1000, parents[3].transform);
        //炸药池
        CreatPool(prefabs[4], 40, 1000, parents[4].transform);
        //电力特效池
        CreatPool(prefabs[5], 35, 1000, parents[5].transform);
        //矿场材料池
        CreatPool(prefabs[6], 35, 1000, parents[6].transform);
        //等离子球池
        CreatPool(prefabs[7], 10, 1000, parents[7].transform);
        //圆形碰撞体池
        CreatPool(prefabs[8], 10, 1000, parents[8].transform);
        //光束池
        CreatPool(prefabs[9], 5, 1000, parents[9].transform);
    }

    /// <summary>
    /// 创建对象池方法
    /// </summary>
    /// <param name="prefab">该池存储的对象</param>
    /// <param name="defaultSize">池的默认大小</param>
    /// <param name="maxSize">池的大小上限</param>
    /// <param name="parent">该池中物体的父物体</param>
    /// <param name="resetAction">放回的时候执行的额外行动</param>
    public void CreatPool(
        GameObject prefab,
        int defaultSize,
        int maxSize = 10000,
        Transform parent = null,
        Action<GameObject> resetAction = null)
    {
        if (poolsDic.ContainsKey(prefab)) return;

        ObjectPool<GameObject> pool = new ObjectPool<GameObject>(
        //创建池
        createFunc: () =>
        {
            GameObject obj = Instantiate(prefab, parent);
            prefabsLookUp[obj] = prefab;
            return obj;
        },
        //从池中取出时
        actionOnGet: obj =>
        {            
            //obj.SetActive(true);
        },
        //归还池中时
        actionOnRelease: obj =>
        {
            resetAction?.Invoke(obj); // 差异化放回,可以不填
            obj.SetActive(false);
        },
        // 池满时销毁对象
        actionOnDestroy: obj =>
        {
            prefabsLookUp.Remove(obj);
            Destroy(obj);
        },
        collectionCheck: false,
        defaultCapacity: defaultSize,
        maxSize: maxSize
        );
        poolsDic[prefab] = pool;

        // 预热，提前创建好对象
        GameObject[] prewarmed = new GameObject[defaultSize];
        for (int i = 0; i < defaultSize; i++)
            prewarmed[i] = pool.Get();

        // 再全部归还
        for (int i = 0; i < defaultSize; i++)
            pool.Release(prewarmed[i]);
    }

    public GameObject Get(GameObject prefab)
    {
        GameObject obj = poolsDic[prefab].Get();
        obj.SetActive(true);
        //return poolsDic[prefab].Get();
        return obj;
    }

    public GameObject Get(GameObject prefab, Vector3 position)
    {
        GameObject obj = poolsDic[prefab].Get();
        obj.transform.position = position;
        obj.SetActive(true);
        return obj;
    }

    public GameObject Get(GameObject prefab, Vector3 position,Vector3 rotation)
    {
        GameObject obj = poolsDic[prefab].Get();
        obj.transform.position = position;
        obj.transform.eulerAngles = rotation;
        obj.SetActive(true);
        return obj;
    }

    public GameObject Get(E_OreType oreType, GameObject prefab, Vector3 position, Vector3 rotation)
    {
        GameObject obj = poolsDic[prefab].Get();
        obj.GetComponent<OreResoureces>().oreType = oreType;
        obj.transform.position = position;
        obj.transform.eulerAngles = rotation;
        obj.SetActive(true);
        return obj;
    }

    public void Release(GameObject obj)
    {
        if (prefabsLookUp.TryGetValue(obj, out var prefab))
            poolsDic[prefab].Release(obj);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
