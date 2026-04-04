using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200001F RID: 31
public class Tooltip : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x060000C1 RID: 193 RVA: 0x0000F368 File Offset: 0x0000D568
	public void OnPointerEnter(PointerEventData eventData)
	{
		Tooltip.hoveringEndless = 0;
		Tooltip.upgradeType = this.upgradeTypeSet;
		float num = base.gameObject.transform.position.x;
		float num2 = 0f;
		if (this.isSkillTreeBtn)
		{
			if (MobileAndTesting.isMobile)
			{
				SkillTree.pressedPurchaseMobile = false;
			}
			this.goldIcon.SetActive(false);
			this.copperIcon.SetActive(false);
			this.ironIcon.SetActive(false);
			this.cobaltIcon.SetActive(false);
			this.uraniumIcon.SetActive(false);
			this.ismiumIcon.SetActive(false);
			this.iridiumIcon.SetActive(false);
			this.painiteIcon.SetActive(false);
			this.oreDarkIcon.SetActive(false);
			Tooltip.goldPriceST = false;
			Tooltip.copperPriceST = false;
			Tooltip.ironPriceST = false;
			Tooltip.cobaltPriceST = false;
			Tooltip.uraniumPriceST = false;
			Tooltip.ismiumPriceST = false;
			Tooltip.iridiumPriceST = false;
			Tooltip.painitePriceST = false;
			if (this.goldPrice)
			{
				this.goldIcon.SetActive(true);
				Tooltip.goldPriceST = this.goldPrice;
			}
			if (this.copperPrice)
			{
				this.copperIcon.SetActive(true);
				Tooltip.copperPriceST = this.copperPrice;
			}
			if (this.ironPrice)
			{
				this.ironIcon.SetActive(true);
				Tooltip.ironPriceST = this.ironPrice;
			}
			if (this.cobaltPrice)
			{
				this.cobaltIcon.SetActive(true);
				Tooltip.cobaltPriceST = this.cobaltPrice;
			}
			if (this.uraniumPrice)
			{
				this.uraniumIcon.SetActive(true);
				Tooltip.uraniumPriceST = this.uraniumPrice;
			}
			if (this.ismiumPrice)
			{
				this.ismiumIcon.SetActive(true);
				Tooltip.ismiumPriceST = this.ismiumPrice;
			}
			if (this.iridiumPrice)
			{
				this.iridiumIcon.SetActive(true);
				Tooltip.iridiumPriceST = this.iridiumPrice;
			}
			if (this.painitePrice)
			{
				this.painiteIcon.SetActive(true);
				Tooltip.painitePriceST = this.painitePrice;
			}
			if (Tooltip.copperPriceST && !SkillTree.spawnCopper_purchased)
			{
				this.oreDarkIcon.SetActive(true);
			}
			if (Tooltip.ironPriceST && !SkillTree.spawnIron_purchased)
			{
				this.oreDarkIcon.SetActive(true);
			}
			if (Tooltip.cobaltPriceST && !SkillTree.cobaltSpawn_purchased)
			{
				this.oreDarkIcon.SetActive(true);
			}
			if (Tooltip.uraniumPriceST && !SkillTree.uraniumSpawn_purchased)
			{
				this.oreDarkIcon.SetActive(true);
			}
			if (Tooltip.ismiumPriceST && !SkillTree.ismiumSpawn_purchased)
			{
				this.oreDarkIcon.SetActive(true);
			}
			if (Tooltip.iridiumPriceST && !SkillTree.iridiumSpawn_purchased)
			{
				this.oreDarkIcon.SetActive(true);
			}
			if (Tooltip.painitePriceST && !SkillTree.painiteSpawn_purchased)
			{
				this.oreDarkIcon.SetActive(true);
			}
			Tooltip.currentPos = base.gameObject.transform.position;
			this.scale1 = 1.5f;
			this.scale2 = 1.5f;
			this.scale3 = 1.7f;
			this.scale4 = 1.8f;
			this.scale5 = 2f;
			if (this.isFinalUpgrade)
			{
				Tooltip.isFinalUpgradeHover = true;
				this.scale1 *= 1.12f;
				this.scale2 *= 1.23f;
				this.scale3 *= 1.4f;
				this.scale4 *= 1.7f;
				this.scale5 *= 1.9f;
			}
			else
			{
				Tooltip.isFinalUpgradeHover = false;
			}
			if (SkillTreeDrag.scaleX < 0.75f)
			{
				num2 = base.gameObject.transform.position.y + this.scale1;
			}
			else if (SkillTreeDrag.scaleX < 1f)
			{
				num2 = base.gameObject.transform.position.y + this.scale2;
			}
			else if (SkillTreeDrag.scaleX < 1.8f)
			{
				num2 = base.gameObject.transform.position.y + this.scale3;
			}
			else if ((double)SkillTreeDrag.scaleX < 2.5)
			{
				num2 = base.gameObject.transform.position.y + this.scale4;
			}
			else if (SkillTreeDrag.scaleX < 3f)
			{
				num2 = base.gameObject.transform.position.y + this.scale5;
			}
			if (!MobileAndTesting.isMobile)
			{
				this.skillTreeTooltip.transform.position = new Vector2(num, num2);
			}
			if (Tooltip.upgradeType == 1)
			{
				if (base.gameObject.name == "treeUpgrade_moreRocks_1(firstUpgrade)")
				{
					Tooltip.upgradeName = "Rock1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnMoreRocks_1_price, SkillTree.spawnMoreRocks_1_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_moreRocks_2")
				{
					Tooltip.upgradeName = "Rock2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnMoreRocks_2_price, SkillTree.spawnMoreRocks_2_purchaseCount, 4);
				}
				else if (base.gameObject.name == "treeUpgrade_moreRocks_3")
				{
					Tooltip.upgradeName = "Rock3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnMoreRocks_3_price, SkillTree.spawnMoreRocks_3_purchaseCount, 4);
				}
				else if (base.gameObject.name == "treeUpgrade_moreRocks_4")
				{
					Tooltip.upgradeName = "Rock4";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnMoreRocks_4_price, SkillTree.spawnMoreRocks_4_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_moreRocks_5")
				{
					Tooltip.upgradeName = "Rock5";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnMoreRocks_5_price, SkillTree.spawnMoreRocks_5_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_moreRocks_6")
				{
					Tooltip.upgradeName = "Rock6";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnMoreRocks_6_price, SkillTree.spawnMoreRocks_6_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_moreRocks_7")
				{
					Tooltip.upgradeName = "Rock7";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnMoreRocks_7_price, SkillTree.spawnMoreRocks_7_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_moreRocks_8")
				{
					Tooltip.upgradeName = "Rock8";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnMoreRocks_8_price, SkillTree.spawnMoreRocks_8_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_moreRocks_9")
				{
					Tooltip.upgradeName = "Rock9";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnMoreRocks_9_price, SkillTree.spawnMoreRocks_9_purchaseCount, 3);
				}
			}
			else if (Tooltip.upgradeType == 2)
			{
				if (base.gameObject.name == "treeUpgrade_moreXP_1")
				{
					Tooltip.upgradeName = "XP1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreXP_1_price, SkillTree.moreXP_1_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_moreXP_2")
				{
					Tooltip.upgradeName = "XP2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreXP_2_price, SkillTree.moreXP_2_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_moreXP_3")
				{
					Tooltip.upgradeName = "XP3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreXP_3_price, SkillTree.moreXP_3_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_moreXP_4")
				{
					Tooltip.upgradeName = "XP4";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreXP_4_price, SkillTree.moreXP_4_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_moreXP_5")
				{
					Tooltip.upgradeName = "XP5";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreXP_5_price, SkillTree.moreXP_5_purchaseCount, 4);
				}
				else if (base.gameObject.name == "treeUpgrade_moreXP_6")
				{
					Tooltip.upgradeName = "XP6";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreXP_6_price, SkillTree.moreXP_6_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_moreXP_7")
				{
					Tooltip.upgradeName = "XP7";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreXP_7_price, SkillTree.moreXP_7_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_moreXP_8")
				{
					Tooltip.upgradeName = "XP8";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreXP_8_price, SkillTree.moreXP_8_purchaseCount, 2);
				}
				else if (base.gameObject.name == "treeUpgrade_endlessIron")
				{
					Tooltip.hoveringEndless = 3;
					Tooltip.upgradeName = "EndlessXP1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.endlessIron_price, SkillTree.endlessIron_purchaseCount, 9999);
				}
				else if (base.gameObject.name == "treeUpgrade_endlessIsmium")
				{
					Tooltip.hoveringEndless = 6;
					Tooltip.upgradeName = "EndlessXP2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.endlessIsmium_price, SkillTree.endlessIsmium_purchaseCount, 9999);
				}
				else if (base.gameObject.name == "treeUpgrade_XtalentPointPerXLevel_1")
				{
					Tooltip.upgradeName = "Talent1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.talentPointsPerXlevel_1_price, SkillTree.talentPointsPerXlevel_1_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_XtalentPointPerXLevel_2")
				{
					Tooltip.upgradeName = "Talent2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.talentPointsPerXlevel_2_price, SkillTree.talentPointsPerXlevel_2_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_XtalentPointPerXLevel_3")
				{
					Tooltip.upgradeName = "Talent3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.talentPointsPerXlevel_3_price, SkillTree.talentPointsPerXlevel_3_purchaseCount, 1);
				}
			}
			else if (Tooltip.upgradeType == 3)
			{
				if (base.gameObject.name == "treeUpgrade_moreGoldRockChance_1")
				{
					Tooltip.upgradeName = "GoldChunk1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.goldChunk_1_price, SkillTree.goldChunk_1_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_moreGoldRockChance_2")
				{
					Tooltip.upgradeName = "GoldChunk2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.goldChunk_2_price, SkillTree.goldChunk_2_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_moreGoldRockChance_3")
				{
					Tooltip.upgradeName = "GoldChunk3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.goldChunk_3_price, SkillTree.goldChunk_3_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_moreGoldRockChance_4")
				{
					Tooltip.upgradeName = "GoldChunk4";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.goldChunk_4_price, SkillTree.goldChunk_4_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_moreGoldRockChance_5")
				{
					Tooltip.upgradeName = "GoldChunk5";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.goldChunk_5__price, SkillTree.goldChunk_5_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_fullGoldChance_1")
				{
					Tooltip.upgradeName = "FullGold1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullGold_1_price, SkillTree.fullGold_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_fullGoldChance_2")
				{
					Tooltip.upgradeName = "FullGold2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullGold_2_price, SkillTree.fullGold_2_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_fullGoldChance_3")
				{
					Tooltip.upgradeName = "FullGold3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullGold_3_price, SkillTree.fullGold_3_purchaseCount, 3);
				}
			}
			else if (Tooltip.upgradeType == 4)
			{
				if (base.gameObject.name == "treeUpgrade_copperSPAWN")
				{
					Tooltip.upgradeName = "CopperSpawn";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnCopper_price, SkillTree.spawnCopper_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_copperHigherSpawnChance_1")
				{
					Tooltip.upgradeName = "CopperChunk1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.copperChunk_1_price, SkillTree.copperChunk_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_copperHigherSpawnChance_2")
				{
					Tooltip.upgradeName = "CopperChunk2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.copperChunk_2_price, SkillTree.copperChunk_2_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_copperHigherSpawnChance_3")
				{
					Tooltip.upgradeName = "CopperChunk3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.copperChunk_3_price, SkillTree.copperChunk_3_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_fullCopperSpawnChance_1")
				{
					Tooltip.upgradeName = "FullCopper1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullCopper_1_price, SkillTree.fullCopper_1_purchaseCount, 2);
				}
				else if (base.gameObject.name == "treeUpgrade_fullCopperSpawnChance_2")
				{
					Tooltip.upgradeName = "FullCopper2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullCopper_2_price, SkillTree.fullCopper_2_purchaseCount, 2);
				}
				else if (base.gameObject.name == "treeUpgrade_fullCopperSpawnChance_3")
				{
					Tooltip.upgradeName = "FullCopper3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullCopper_3_price, SkillTree.fullCopper_3_purchaseCount, 2);
				}
			}
			else if (Tooltip.upgradeType == 5)
			{
				if (base.gameObject.name == "treeUpgrade_spawnIRON")
				{
					Tooltip.upgradeName = "IronSpawn";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnIron_price, SkillTree.spawnIron_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_ironHigherSpawnChance_1")
				{
					Tooltip.upgradeName = "IronChunk1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.ironChunk_1_price, SkillTree.ironChunk_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_ironHigherSpawnChance_2")
				{
					Tooltip.upgradeName = "IronChunk2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.ironChunk_2_price, SkillTree.ironChunk_2_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_fullIronChance_1")
				{
					Tooltip.upgradeName = "FullIron1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullIron_1_price, SkillTree.fullIron_1_purchaseCount, 2);
				}
				else if (base.gameObject.name == "treeUpgrade_fullIronChance_2")
				{
					Tooltip.upgradeName = "FullIron2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullIron_2_price, SkillTree.fullIron_2_purchaseCount, 2);
				}
			}
			else if (Tooltip.upgradeType == 6)
			{
				if (base.gameObject.name == "treeUpgrade_spawnCOBALT")
				{
					Tooltip.upgradeName = "CobaltSpawn";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.cobaltSpawn_price, SkillTree.cobaltSpawn_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_cobaltHigherSpawnChance_1")
				{
					Tooltip.upgradeName = "CobaltChunk1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.cobaltChunk_1_price, SkillTree.cobaltChunk_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_cobaltFullChance_1")
				{
					Tooltip.upgradeName = "CobaltFull1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullCobalt_1_price, SkillTree.fullCobalt_1_purchaseCount, 2);
				}
			}
			else if (Tooltip.upgradeType == 7)
			{
				if (base.gameObject.name == "treeUpgrade_spawnURANIUM")
				{
					Tooltip.upgradeName = "UraniumSpawn";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.uraniumSpawn_price, SkillTree.uraniumSpawn_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_uraniumHigherChance_1")
				{
					Tooltip.upgradeName = "UraniumChunk1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.uraniumChunk_1_price, SkillTree.uraniumChunk_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_uraniumFullChance_1")
				{
					Tooltip.upgradeName = "FullUranium1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullUranium_1_price, SkillTree.fullUranium_1_purchaseCount, 2);
				}
			}
			else if (Tooltip.upgradeType == 8)
			{
				if (base.gameObject.name == "treeUpgrade_spawnISMIUM")
				{
					Tooltip.upgradeName = "IsmiumSpawn";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.ismiumSpawn_price, SkillTree.ismiumSpawn_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_ismiumHigherChance_1")
				{
					Tooltip.upgradeName = "IsmiumChunk1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.ismiumChunk_1_price, SkillTree.ismiumChunk_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_ismiumFullChance_1")
				{
					Tooltip.upgradeName = "FullIsmium1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullIsmium_1_price, SkillTree.fullIsmium_1_purchaseCount, 2);
				}
			}
			else if (Tooltip.upgradeType == 9)
			{
				if (base.gameObject.name == "treeUpgrade_spawnIRIDIUM")
				{
					Tooltip.upgradeName = "IridiumSpawn";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.iridiumSpawn_price, SkillTree.iridiumSpawn_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_irituimHigherChance_1")
				{
					Tooltip.upgradeName = "IridiumChunk1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.iridiumChunk_1_price, SkillTree.iridiumChunk_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_iriduimFullChance_1")
				{
					Tooltip.upgradeName = "IridiumFull1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullIridium_1_price, SkillTree.fullIridium_1_purchaseCount, 2);
				}
			}
			else if (Tooltip.upgradeType == 10)
			{
				if (base.gameObject.name == "treeUpgrade_spawnPAINITE")
				{
					Tooltip.upgradeName = "PainiteSpawn";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.painiteSpawn_price, SkillTree.painiteSpawn_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_pianiteHigherChance_1")
				{
					Tooltip.upgradeName = "PainiteChunk1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.painiteChunk_1_price, SkillTree.painiteChunk_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_pianiteFullChance_1")
				{
					Tooltip.upgradeName = "FullPainite1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.fullPainite_1_price, SkillTree.fullPainite_1_purchaseCount, 2);
				}
			}
			else if (Tooltip.upgradeType == 11)
			{
				if (base.gameObject.name == "treeUpgrade_lightningChanceEverySecond_1")
				{
					Tooltip.upgradeName = "LightningChanceS1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.lightningBeamChanceS_1_price, SkillTree.lightningBeamChanceS_1_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_lightningChanceEverySecond_2")
				{
					Tooltip.upgradeName = "LightningChanceS2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.lightningBeamChanceS_2_price, SkillTree.lightningBeamChanceS_2_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_lightningChancePerPickaxeHit_1")
				{
					Tooltip.upgradeName = "LightningChancePH1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.lightningBeamChancePH_1_price, SkillTree.lightningBeamChancePH_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_lightningChancePerPickaxeHit_2")
				{
					Tooltip.upgradeName = "LightningChancePH2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.lightningBeamChancePH_2_price, SkillTree.lightningBeamChancePH_2_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_lightningChanceToSpawnAnotherOne")
				{
					Tooltip.upgradeName = "LightningSpawnAnotherChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.lightningBeamSpawnAnotherOneChance_price, SkillTree.lightningBeamSpawnAnotherOneChance_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_moreLightningDamage")
				{
					Tooltip.upgradeName = "LightningDamage";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.lightningBeamDamage_price, SkillTree.lightningBeamDamage_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_lightningSize_1")
				{
					Tooltip.upgradeName = "LightningSize";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.lightningBeamSize_price, SkillTree.lightningBeamSize_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_lightningSplashesSpawn_1")
				{
					Tooltip.upgradeName = "LightningSplash";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.lightningSplashes_price, SkillTree.lightningSplashes_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_lightningSpawnRockChance")
				{
					Tooltip.upgradeName = "LightningSpawnRockChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.lightningBeamSpawnRock_price, SkillTree.lightningBeamSpawnRock_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_lightningChanceToSpawnExplostion")
				{
					Tooltip.upgradeName = "LightningExplosionChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.lightningBeamExplosion_price, SkillTree.lightningBeamExplosion_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_lightningStrikeAddsTime_1")
				{
					Tooltip.upgradeName = "LightningAddTimeChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.lightningBeamAddTime_price, SkillTree.lightningBeamAddTime_purchaseCount, 1);
				}
			}
			else if (Tooltip.upgradeType == 12)
			{
				if (base.gameObject.name == "treeUpgrade_chanceToStickDynamite_1")
				{
					Tooltip.upgradeName = "DynamiteStickChance1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.dynamiteChance_1_price, SkillTree.dynamiteChance_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToStickDynamite_2")
				{
					Tooltip.upgradeName = "DynamiteStickChance2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.dynamiteChance_2_price, SkillTree.dynamiteChance_2_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToSpawn2Dynamites")
				{
					Tooltip.upgradeName = "DynamiteSpawn2SmallChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.dynamiteSpawn2SmallChance_price, SkillTree.dynamiteSpawn2SmallChance_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_dynamiteSize_1")
				{
					Tooltip.upgradeName = "DynamiteSize";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.dynamiteExplosionSize_price, SkillTree.dynamiteExplosionSize_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_dynamiteDamage_1")
				{
					Tooltip.upgradeName = "DynamiteDamage";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.dynamiteDamage_price, SkillTree.dynamiteDamage_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_explosionChanceToSpawnRock_1")
				{
					Tooltip.upgradeName = "DynamiteSpawnRockChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.dynamiteExplosionSpawnRock_price, SkillTree.dynamiteExplosionSpawnRock_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_dynamiteExplosionAddsTime_1")
				{
					Tooltip.upgradeName = "DynamiteAddTimeChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.dynamiteExplosionAddTimeChance_price, SkillTree.dynamiteExplosionAddTimeChance_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_explostionChanceToSpawnLightning")
				{
					Tooltip.upgradeName = "DynamiteSpawnLightningChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.dynamiteExplosionSpawnLightning_price, SkillTree.dynamiteExplosionSpawnLightning_purchaseCount, 1);
				}
			}
			else if (Tooltip.upgradeType == 13)
			{
				if (base.gameObject.name == "treeUpgrade_plazmaBallSpawnChance_1")
				{
					Tooltip.upgradeName = "PlazmaBallChance1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.plazmaBallSpawn_1_price, SkillTree.plazmaBallSpawn_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_plazmaBallSpawnChance_2")
				{
					Tooltip.upgradeName = "PlazmaBallChance2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.plazmaBallSpawn_2_price, SkillTree.plazmaBallSpawn_2_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_plazmaBallTime_1")
				{
					Tooltip.upgradeName = "PlazmaBallTime";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.plazmaBallTime_price, SkillTree.plazmaBallTime_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_plazmaBallSize_1")
				{
					Tooltip.upgradeName = "PlazmaBallSize";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.plazmaBallSize_price, SkillTree.plazmaBallSize_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_plazmaBallEndExplosionChance")
				{
					Tooltip.upgradeName = "PlazmaBallExplosionChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.plazmaBallExplosionChance_price, SkillTree.plazmaBallExplosionChance_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_plazmaBallSpawnSmallChance_1")
				{
					Tooltip.upgradeName = "PlazmbaBallSpawnSmallChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.plazmaBallSpawnSmallChance_price, SkillTree.plazmaBallSpawnSmallChance_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_plazmaBallDamage")
				{
					Tooltip.upgradeName = "PlazmaBallDamage";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.plazmaBallDamage_price, SkillTree.plazmaBallDamage_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_plazmaChanceToSpawnPickaxe")
				{
					Tooltip.upgradeName = "PlazmaBallChanceToSpawnPickaxe";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.plazmaBallSpawnPickaxeChance_price, SkillTree.plazmaBallSpawnPickaxeChance_purchaseCount, 1);
				}
			}
			else if (Tooltip.upgradeType == 14)
			{
				if (base.gameObject.name == "treeUpgrade_moreMaterialsFromRocks_1")
				{
					Tooltip.upgradeName = "MaterialsPerRock1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreMeterialsFromRock_1_price, SkillTree.moreMeterialsFromRock_1_purchaseCount, 2);
				}
				else if (base.gameObject.name == "treeUpgrade_moreMaterialsFromRocks_2")
				{
					Tooltip.upgradeName = "MaterialsPerRock2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreMeterialsFromRock_2_price, SkillTree.moreMeterialsFromRock_2_purchaseCount, 2);
				}
				else if (base.gameObject.name == "treeUpgrade_moreMaterialsFromRocks_3")
				{
					Tooltip.upgradeName = "MaterialsPerRock3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreMeterialsFromRock_3_price, SkillTree.moreMeterialsFromRock_3_purchaseCount, 2);
				}
				else if (base.gameObject.name == "treeUpgrade_moreMaterialsFromRocks_4")
				{
					Tooltip.upgradeName = "MaterialsPerRock4";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreMeterialsFromRock_4_price, SkillTree.moreMeterialsFromRock_4_purchaseCount, 2);
				}
				else if (base.gameObject.name == "treeUpgrade_moreMaterialsFromRocks_5")
				{
					Tooltip.upgradeName = "MaterialsPerRock5";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreMeterialsFromRock_5_price, SkillTree.moreMeterialsFromRock_5_purchaseCount, 2);
				}
			}
			else if (Tooltip.upgradeType == 15)
			{
				if (base.gameObject.name == "treeUpgrade_materialsWorthMore_1")
				{
					Tooltip.upgradeName = "MaterialsWorthMore1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.marterialsWorthMore_1_price, SkillTree.marterialsWorthMore_1_purchaseCount, 4);
				}
				else if (base.gameObject.name == "treeUpgrade_materialsWorthMore_2")
				{
					Tooltip.upgradeName = "MaterialsWorthMore2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.marterialsWorthMore_2_price, SkillTree.marterialsWorthMore_2_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_materialsWorthMore_3")
				{
					Tooltip.upgradeName = "MaterialsWorthMore3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.marterialsWorthMore_3_price, SkillTree.marterialsWorthMore_3_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_materialsWorthMore_4")
				{
					Tooltip.upgradeName = "MaterialsWorthMore4";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.marterialsWorthMore_4_price, SkillTree.marterialsWorthMore_4_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_materialsWorthMore_5")
				{
					Tooltip.upgradeName = "MaterialsWorthMore5";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.marterialsWorthMore_5_price, SkillTree.marterialsWorthMore_5_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_materialsWorthMore_6")
				{
					Tooltip.upgradeName = "MaterialsWorthMore6";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.marterialsWorthMore_6_price, SkillTree.marterialsWorthMore_6_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_materialsWorthMore_7")
				{
					Tooltip.upgradeName = "MaterialsWorthMore7";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.marterialsWorthMore_7_price, SkillTree.marterialsWorthMore_7_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_materialsWorthMore_8")
				{
					Tooltip.upgradeName = "MaterialsWorthMore8";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.marterialsWorthMore_8_price, SkillTree.marterialsWorthMore_8_purchaseCount, 5);
				}
				if (base.gameObject.name == "treeUpgrade_endlessGold")
				{
					Tooltip.hoveringEndless = 1;
					Tooltip.upgradeName = "EndlessGold1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.endlessGold_price, SkillTree.endlessGold_purchaseCount, 9999);
				}
				if (base.gameObject.name == "treeUpgrade_endlessPainite")
				{
					Tooltip.hoveringEndless = 8;
					Tooltip.upgradeName = "EndlessGold2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.endlessPainite_price, SkillTree.endlessPainite_purchaseCount, 9999);
				}
			}
			else if (Tooltip.upgradeType == 16)
			{
				if (base.gameObject.name == "treeUpgrade_improvedPickaxesStats_1")
				{
					Tooltip.upgradeName = "ImprovedPickaxe1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.improvedPickaxe_1_price, SkillTree.improvedPickaxe_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_improvedPickaxesStats_2")
				{
					Tooltip.upgradeName = "ImprovedPickaxe2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.improvedPickaxe_2_price, SkillTree.improvedPickaxe_2_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_improvedPickaxesStats_3")
				{
					Tooltip.upgradeName = "ImprovedPickaxe3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.improvedPickaxe_3_price, SkillTree.improvedPickaxe_3_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_improvedPickaxesStats_4")
				{
					Tooltip.upgradeName = "ImprovedPickaxe4";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.improvedPickaxe_4_price, SkillTree.improvedPickaxe_4_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_improvedPickaxesStats_5")
				{
					Tooltip.upgradeName = "ImprovedPickaxe5";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.improvedPickaxe_5_price, SkillTree.improvedPickaxe_5_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_improvedPickaxesStats_6")
				{
					Tooltip.upgradeName = "ImprovedPickaxe6";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.improvedPickaxe_6_price, SkillTree.improvedPickaxe_6_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_endlessCobalt")
				{
					Tooltip.hoveringEndless = 4;
					Tooltip.upgradeName = "EndlessPickaxe1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.endlessCobalt_price, SkillTree.endlessCobalt_purchaseCount, 9999);
				}
				else if (base.gameObject.name == "treeUpgrade_endlessUranium")
				{
					Tooltip.hoveringEndless = 5;
					Tooltip.upgradeName = "EndlessPickaxe2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.endlessUranium_price, SkillTree.endlessUranium_purchaseCount, 9999);
				}
			}
			else if (Tooltip.upgradeType == 17)
			{
				if (base.gameObject.name == "treeUpgrade_biggerMiningErea_1")
				{
					Tooltip.upgradeName = "BiggerMiningErea1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.biggerMiningErea_1_price, SkillTree.biggerMiningErea_1_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_biggerMiningErea_2")
				{
					Tooltip.upgradeName = "BiggerMiningErea2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.biggerMiningErea_2_price, SkillTree.biggerMiningErea_2_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_biggerMiningErea_3")
				{
					Tooltip.upgradeName = "BiggerMiningErea3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.biggerMiningErea_3_price, SkillTree.biggerMiningErea_3_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_biggerMiningErea_4")
				{
					Tooltip.upgradeName = "BiggerMiningErea4";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.biggerMiningErea_4_price, SkillTree.biggerMiningErea_4_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToShootCircleEverySecons_1")
				{
					Tooltip.upgradeName = "ShootCircle";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.shootCircleChance_price, SkillTree.shootCircleChance_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_increaseAndDecrease_1")
				{
					Tooltip.upgradeName = "IncreaseAndDecreaseCircle";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.increaseAndDecreaseMinignErea_price, SkillTree.increaseAndDecreaseMinignErea_purchaseCount, 1);
				}
			}
			else if (Tooltip.upgradeType == 18)
			{
				if (base.gameObject.name == "treeUpgrade_everyXrocksMineWillSpawnRock_1")
				{
					Tooltip.upgradeName = "EveryXRockSpawnRock1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnRockEveryXrock_1_price, SkillTree.spawnRockEveryXrock_1_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_everyXrocksMineWillSpawnRock_2")
				{
					Tooltip.upgradeName = "EveryXRockSpawnRock2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnRockEveryXrock_2_price, SkillTree.spawnRockEveryXrock_2_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_everyXrocksMineWillSpawnRock_3")
				{
					Tooltip.upgradeName = "EveryXRockSpawnRock3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnRockEveryXrock_3_price, SkillTree.spawnRockEveryXrock_3_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_spawnRockEveryXSecond_1")
				{
					Tooltip.upgradeName = "SpawnRockEveryXSecond1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnXRockEveryXSecond_1_price, SkillTree.spawnXRockEveryXSecond_1_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_spawnRockEveryXSecond_2")
				{
					Tooltip.upgradeName = "SpawnRockEveryXSecond2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnXRockEveryXSecond_2_price, SkillTree.spawnXRockEveryXSecond_2_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_spawnRockEveryXSecond_3")
				{
					Tooltip.upgradeName = "SpawnRockEveryXSecond3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnXRockEveryXSecond_3_price, SkillTree.spawnXRockEveryXSecond_3_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToSpawnRockWhenMined_1")
				{
					Tooltip.upgradeName = "ChanceToSpawnRockWhenMined1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.chanceToSpawnRockWhenMined_1_price, SkillTree.chanceToSpawnRockWhenMined_1_purchaseCount, 6);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToSpawnRockWhenMined_2")
				{
					Tooltip.upgradeName = "ChanceToSpawnRockWhenMined2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.chanceToSpawnRockWhenMined_2_price, SkillTree.chanceToSpawnRockWhenMined_2_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToSpawnRockWhenMined_3")
				{
					Tooltip.upgradeName = "ChanceToSpawnRockWhenMined3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.chanceToSpawnRockWhenMined_3_price, SkillTree.chanceToSpawnRockWhenMined_3_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToSpawnRockWhenMined_4")
				{
					Tooltip.upgradeName = "ChanceToSpawnRockWhenMined4";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.chanceToSpawnRockWhenMined_4_price, SkillTree.chanceToSpawnRockWhenMined_4_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToSpawnRockWhenMined_5")
				{
					Tooltip.upgradeName = "ChanceToSpawnRockWhenMined5";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.chanceToSpawnRockWhenMined_5_price, SkillTree.chanceToSpawnRockWhenMined_5_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToSpawnRockWhenMined_6")
				{
					Tooltip.upgradeName = "ChanceToSpawnRockWhenMined6";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.chanceToSpawnRockWhenMined_6_price, SkillTree.chanceToSpawnRockWhenMined_6_purchaseCount, 1);
				}
			}
			else if (Tooltip.upgradeType == 19)
			{
				if (base.gameObject.name == "treeUpgrade_chanceToMineRandomRock_1")
				{
					Tooltip.upgradeName = "ChanceToMineRandomRock1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.chanceToMineRandomRock_1_price, SkillTree.chanceToMineRandomRock_1_purchaseCount, 4);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToMineRandomRock_2")
				{
					Tooltip.upgradeName = "ChanceToMineRandomRock2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.chanceToMineRandomRock_2_price, SkillTree.chanceToMineRandomRock_2_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToMineRandomRock_3")
				{
					Tooltip.upgradeName = "ChanceToMineRandomRock3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.chanceToMineRandomRock_3_price, SkillTree.chanceToMineRandomRock_3_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToMineRandomRock_4")
				{
					Tooltip.upgradeName = "ChanceToMineRandomRock4";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.chanceToMineRandomRock_4_price, SkillTree.chanceToMineRandomRock_4_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_spawnPickaxeEverySecond_1")
				{
					Tooltip.upgradeName = "SpawnPickaxeEverySecond1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnPickaxeEverySecond_1_price, SkillTree.spawnPickaxeEverySecond_1_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_spawnPickaxeEverySecond_2")
				{
					Tooltip.upgradeName = "SpawnPickaxeEverySecond2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnPickaxeEverySecond_2_price, SkillTree.spawnPickaxeEverySecond_2_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_spawnPickaxeEverySecond_3")
				{
					Tooltip.upgradeName = "SpawnPickaxeEverySecond3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.spawnPickaxeEverySecond_3_price, SkillTree.spawnPickaxeEverySecond_3_purchaseCount, 1);
				}
			}
			else if (Tooltip.upgradeType == 20)
			{
				if (base.gameObject.name == "treeUpgrade_moreTime_1")
				{
					Tooltip.upgradeName = "MoreTime1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreTime_1_price, SkillTree.moreTime_1_purchaseCount, 5);
				}
				else if (base.gameObject.name == "treeUpgrade_moreTime_2")
				{
					Tooltip.upgradeName = "MoreTime2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreTime_2_price, SkillTree.moreTime_2_purchaseCount, 4);
				}
				else if (base.gameObject.name == "treeUpgrade_moreTime_3")
				{
					Tooltip.upgradeName = "MoreTime3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreTime_3_price, SkillTree.moreTime_3_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_moreTime_4")
				{
					Tooltip.upgradeName = "MoreTime4";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.moreTime_4_price, SkillTree.moreTime_4_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceToAdd1SecondEverySecond")
				{
					Tooltip.upgradeName = "ChanceAdd1SecondEverySecond";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.chanceToAdd1SecondEverySecond_price, SkillTree.chanceToAdd1SecondEverySecond_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceAdd1SecondEveryRockMined")
				{
					Tooltip.upgradeName = "ChanceAdd1SecondEveryRockMined";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.chanceAdd1SecondEveryRockMined_price, SkillTree.chanceAdd1SecondEveryRockMined_purchaseCount, 1);
				}
			}
			else if (Tooltip.upgradeType == 21)
			{
				if (base.gameObject.name == "treeUpgrade_chanceForDoubleXpAndGold_1")
				{
					Tooltip.upgradeName = "DoubleXpAndMaterial1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.doubleXpGoldChance_1_price, SkillTree.doubleXpGoldChance_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceForDoubleXpAndGold_2")
				{
					Tooltip.upgradeName = "DoubleXpAndMaterial2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.doubleXpGoldChance_2_price, SkillTree.doubleXpGoldChance_2_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceForDoubleXpAndGold_3")
				{
					Tooltip.upgradeName = "DoubleXpAndMaterial3";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.doubleXpGoldChance_3_price, SkillTree.doubleXpGoldChance_3_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceForDoubleXpAndGold_4")
				{
					Tooltip.upgradeName = "DoubleXpAndMaterial4";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.doubleXpGoldChance_4_price, SkillTree.doubleXpGoldChance_4_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_chanceForDoubleXpAndGold_5")
				{
					Tooltip.upgradeName = "DoubleXpAndMaterial5";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.doubleXpGoldChance_5_price, SkillTree.doubleXpGoldChance_5_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_endlessCopper")
				{
					Tooltip.hoveringEndless = 2;
					Tooltip.upgradeName = "DoubleEndless1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.endlessCopper_price, SkillTree.endlessCopper_purchaseCount, 9999);
				}
				else if (base.gameObject.name == "treeUpgrade_endlessIridium")
				{
					Tooltip.hoveringEndless = 7;
					Tooltip.upgradeName = "DoubleEndless2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.endlessIridium_price, SkillTree.endlessIridium_purchaseCount, 9999);
				}
			}
			else if (Tooltip.upgradeType == 22)
			{
				if (base.gameObject.name == "treeUpgrade_allProjectileDoubleDamageChance_1")
				{
					Tooltip.upgradeName = "AllProjectleDoubleDamageChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.allProjectileDoubleDamageChance_price, SkillTree.allProjectileDoubleDamageChance_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_increaseAllProjectileChances_1")
				{
					Tooltip.upgradeName = "IncreaseAllProjectileChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.allProjectileTriggerChance_price, SkillTree.allProjectileTriggerChance_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_doubleDamageChance_1")
				{
					Tooltip.upgradeName = "DoubleDamageChance1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.pickaxeDoubleDamageChance_1_price, SkillTree.pickaxeDoubleDamageChance_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_doubleDamageChance_2")
				{
					Tooltip.upgradeName = "DoubleDamageChance2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.pickaxeDoubleDamageChance_2_price, SkillTree.pickaxeDoubleDamageChance_2_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_intaMineChance_1")
				{
					Tooltip.upgradeName = "InstaMine1";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.intaMineChance_1_price, SkillTree.intaMineChance_1_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_intaMineChance_2")
				{
					Tooltip.upgradeName = "InstaMine2";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.intaMineChance_2_price, SkillTree.intaMineChance_2_purchaseCount, 3);
				}
				else if (base.gameObject.name == "treeUpgrade_increaseSpawnChanceALLROCKS")
				{
					Tooltip.upgradeName = "IncreaseAllRockSpawnChance";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.increaseSpawnChanceAllRocks_price, SkillTree.increaseSpawnChanceAllRocks_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_2GoldBarsCraft")
				{
					Tooltip.upgradeName = "2GoldBarsCraft";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.craft2Material_price, SkillTree.craft2Material_purchaseCount, 1);
				}
				else if (base.gameObject.name == "treeUpgrade_finalUpgrade_newMiningLocation")
				{
					Tooltip.upgradeName = "FinalUpgrade";
					this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, SkillTree.finalUpgrade_price, SkillTree.finalUpgrade_purchaseCount, 1);
				}
			}
			if (!MobileAndTesting.isMobile)
			{
				Tooltip.skillTreeToolTipPos = base.gameObject.transform.position;
				if (this.skillTreeTooltip != null)
				{
					this.skillTreeTooltip.SetActive(true);
				}
			}
		}
		if (this.isTheMineBtn)
		{
			num2 = base.gameObject.transform.position.y + 1.7f;
			if (this.isMineTimeBtn)
			{
				this.locScript.TheMineTexts(true);
				if (!MobileAndTesting.isMobile)
				{
					this.theMineTimeTooltip.transform.position = new Vector2(num, num2);
					if (this.theMineTimeTooltip != null)
					{
						this.theMineTimeTooltip.SetActive(true);
					}
				}
			}
			if (this.isMineOreBtn)
			{
				this.locScript.TheMineTexts(false);
				if (!MobileAndTesting.isMobile)
				{
					this.theMineOreTooltip.transform.position = new Vector2(num, num2);
					if (this.theMineOreTooltip != null)
					{
						this.theMineOreTooltip.SetActive(true);
					}
				}
			}
		}
		if (this.isArtifact)
		{
			foreach (object obj in base.transform)
			{
				Transform transform = (Transform)obj;
				if (transform.name.Contains("Excl") && transform.gameObject.activeSelf)
				{
					transform.gameObject.SetActive(false);
				}
			}
			this.locScript.ArtifactsTooltipText(this.artifactNumber);
			if (!MobileAndTesting.isMobile)
			{
				num2 = base.gameObject.transform.position.y + 1.6f;
				this.artifactTooltip.transform.position = new Vector2(num, num2);
				this.artifactTooltip.SetActive(true);
			}
		}
		if (this.isPotion)
		{
			num = base.gameObject.transform.position.x - 2.72f;
			num2 = base.gameObject.transform.position.y - 0.5f;
			this.potionTooltip.transform.position = new Vector2(num, num2);
			this.potionTooltip.SetActive(true);
			this.potions1.SetActive(false);
			this.potions2.SetActive(false);
			this.potion3.SetActive(false);
			this.potion4.SetActive(false);
			if (base.gameObject.name == "Potion_GoldIncrease")
			{
				this.locScript.PotionText("materialIncrease");
				this.potions1.SetActive(true);
			}
			if (base.gameObject.name == "Potion_PickaxeStats")
			{
				this.locScript.PotionText("pickaxeIncrease");
				this.potions2.SetActive(true);
			}
			if (base.gameObject.name == "Potion_XPIncrease")
			{
				this.locScript.PotionText("xpIncrease");
				this.potion3.SetActive(true);
			}
			if (base.gameObject.name == "Potion_DoubleXpAndGoldIncrease")
			{
				this.locScript.PotionText("doubleXpAndMaterialIncrease");
				this.potion4.SetActive(true);
			}
		}
		if (this.isLeftTalent)
		{
			num2 = base.gameObject.transform.position.y;
			if (base.gameObject.transform.localPosition.y < -390f)
			{
				num2 += 0.9f;
			}
			this.locScript.TalentTexts(this.talentNumber);
			if (!MobileAndTesting.isMobile)
			{
				this.talentTooltp.transform.position = new Vector2(num + 2.9f, num2);
				this.talentTooltp.SetActive(true);
			}
		}
		if (this.isTalentLevelText && !MobileAndTesting.isMobile)
		{
			num2 = base.gameObject.transform.position.y;
			this.talentLevelTooltip.transform.position = new Vector2(num, num2 - 1.1f);
			this.talentLevelTooltip.SetActive(true);
		}
		if (this.isFlower && !MobileAndTesting.isMobile)
		{
			num2 = base.gameObject.transform.position.y + 1.1f;
			num = base.gameObject.transform.position.x + 1.4f;
			this.flowerBuffText.text = string.Format("+{0}%XP", (float)SetRockScreen.flowersOnScreen * (LevelMechanics.flowerIncrease * 100f));
			this.flowerTooltip.transform.position = new Vector2(num, num2);
			this.flowerTooltip.SetActive(true);
		}
		if (this.isTheMineInfo && !MobileAndTesting.isMobile)
		{
			num2 = base.gameObject.transform.position.y - 0.65f;
			num = base.gameObject.transform.position.x - 3.3f;
			this.infoTooltip.transform.position = new Vector2(num, num2);
			this.infoTooltip.SetActive(true);
		}
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00012894 File Offset: 0x00010A94
	public void OnPointerExit(PointerEventData eventData)
	{
		if (this.isSkillTreeBtn && !MobileAndTesting.isMobile && this.skillTreeTooltip != null)
		{
			this.skillTreeTooltip.SetActive(false);
		}
		if (this.isTheMineBtn && !MobileAndTesting.isMobile)
		{
			this.theMineTimeTooltip.SetActive(false);
			this.theMineOreTooltip.SetActive(false);
		}
		if (this.isArtifact && !MobileAndTesting.isMobile)
		{
			this.artifactTooltip.SetActive(false);
		}
		if (this.isPotion)
		{
			this.potionTooltip.SetActive(false);
		}
		if (this.isLeftTalent && !MobileAndTesting.isMobile)
		{
			this.talentTooltp.SetActive(false);
		}
		if (this.isTalentLevelText && !MobileAndTesting.isMobile)
		{
			this.talentLevelTooltip.SetActive(false);
		}
		if (this.isFlower && !MobileAndTesting.isMobile)
		{
			this.flowerTooltip.SetActive(false);
		}
		if (this.isTheMineInfo && !MobileAndTesting.isMobile)
		{
			this.infoTooltip.SetActive(false);
		}
	}

	// Token: 0x040003EB RID: 1003
	public bool isSkillTreeBtn;

	// Token: 0x040003EC RID: 1004
	public bool isTheMineBtn;

	// Token: 0x040003ED RID: 1005
	public bool isMineTimeBtn;

	// Token: 0x040003EE RID: 1006
	public bool isMineOreBtn;

	// Token: 0x040003EF RID: 1007
	public bool isPotion;

	// Token: 0x040003F0 RID: 1008
	public bool isTalentLevelText;

	// Token: 0x040003F1 RID: 1009
	public bool isFlower;

	// Token: 0x040003F2 RID: 1010
	public bool isLeftTalent;

	// Token: 0x040003F3 RID: 1011
	public int talentNumber;

	// Token: 0x040003F4 RID: 1012
	public bool isArtifact;

	// Token: 0x040003F5 RID: 1013
	public int artifactNumber;

	// Token: 0x040003F6 RID: 1014
	public bool isTheMineInfo;

	// Token: 0x040003F7 RID: 1015
	public GameObject skillTreeTooltip;

	// Token: 0x040003F8 RID: 1016
	public GameObject theMineTimeTooltip;

	// Token: 0x040003F9 RID: 1017
	public GameObject theMineOreTooltip;

	// Token: 0x040003FA RID: 1018
	public GameObject artifactTooltip;

	// Token: 0x040003FB RID: 1019
	public GameObject potionTooltip;

	// Token: 0x040003FC RID: 1020
	public GameObject talentTooltp;

	// Token: 0x040003FD RID: 1021
	public GameObject talentLevelTooltip;

	// Token: 0x040003FE RID: 1022
	public GameObject flowerTooltip;

	// Token: 0x040003FF RID: 1023
	public GameObject infoTooltip;

	// Token: 0x04000400 RID: 1024
	public TextMeshProUGUI flowerBuffText;

	// Token: 0x04000401 RID: 1025
	public static Vector2 skillTreeToolTipPos;

	// Token: 0x04000402 RID: 1026
	public LocalizationScript locScript;

	// Token: 0x04000403 RID: 1027
	public static string upgradeName;

	// Token: 0x04000404 RID: 1028
	public static int upgradeType;

	// Token: 0x04000405 RID: 1029
	public int upgradeTypeSet;

	// Token: 0x04000406 RID: 1030
	public static int currentPurchaseCount;

	// Token: 0x04000407 RID: 1031
	public float scale1;

	// Token: 0x04000408 RID: 1032
	public float scale2;

	// Token: 0x04000409 RID: 1033
	public float scale3;

	// Token: 0x0400040A RID: 1034
	public float scale4;

	// Token: 0x0400040B RID: 1035
	public float scale5;

	// Token: 0x0400040C RID: 1036
	public bool goldPrice;

	// Token: 0x0400040D RID: 1037
	public bool copperPrice;

	// Token: 0x0400040E RID: 1038
	public bool ironPrice;

	// Token: 0x0400040F RID: 1039
	public bool cobaltPrice;

	// Token: 0x04000410 RID: 1040
	public bool uraniumPrice;

	// Token: 0x04000411 RID: 1041
	public bool ismiumPrice;

	// Token: 0x04000412 RID: 1042
	public bool iridiumPrice;

	// Token: 0x04000413 RID: 1043
	public bool painitePrice;

	// Token: 0x04000414 RID: 1044
	public static bool goldPriceST;

	// Token: 0x04000415 RID: 1045
	public static bool copperPriceST;

	// Token: 0x04000416 RID: 1046
	public static bool ironPriceST;

	// Token: 0x04000417 RID: 1047
	public static bool cobaltPriceST;

	// Token: 0x04000418 RID: 1048
	public static bool uraniumPriceST;

	// Token: 0x04000419 RID: 1049
	public static bool ismiumPriceST;

	// Token: 0x0400041A RID: 1050
	public static bool iridiumPriceST;

	// Token: 0x0400041B RID: 1051
	public static bool painitePriceST;

	// Token: 0x0400041C RID: 1052
	public GameObject goldIcon;

	// Token: 0x0400041D RID: 1053
	public GameObject copperIcon;

	// Token: 0x0400041E RID: 1054
	public GameObject ironIcon;

	// Token: 0x0400041F RID: 1055
	public GameObject cobaltIcon;

	// Token: 0x04000420 RID: 1056
	public GameObject uraniumIcon;

	// Token: 0x04000421 RID: 1057
	public GameObject ismiumIcon;

	// Token: 0x04000422 RID: 1058
	public GameObject iridiumIcon;

	// Token: 0x04000423 RID: 1059
	public GameObject painiteIcon;

	// Token: 0x04000424 RID: 1060
	public GameObject oreDarkIcon;

	// Token: 0x04000425 RID: 1061
	public static Vector2 currentPos;

	// Token: 0x04000426 RID: 1062
	public bool isFinalUpgrade;

	// Token: 0x04000427 RID: 1063
	public static bool isFinalUpgradeHover;

	// Token: 0x04000428 RID: 1064
	public GameObject potions1;

	// Token: 0x04000429 RID: 1065
	public GameObject potions2;

	// Token: 0x0400042A RID: 1066
	public GameObject potion3;

	// Token: 0x0400042B RID: 1067
	public GameObject potion4;

	// Token: 0x0400042C RID: 1068
	public static int hoveringEndless;
}
