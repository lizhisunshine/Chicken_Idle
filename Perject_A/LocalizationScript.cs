using System;
using System.Collections;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200002C RID: 44
public class LocalizationScript : MonoBehaviour
{
	// Token: 0x06000129 RID: 297 RVA: 0x000172BC File Offset: 0x000154BC
	private void Awake()
	{
		LocalizationScript.languageChosen = PlayerPrefs.GetInt("language");
		if (!PlayerPrefs.HasKey("language"))
		{
			string name = new RegionInfo(CultureInfo.CurrentCulture.Name).Name;
			this.SetLanguageByRegion(name);
			return;
		}
		this.ChooseLanguage(false);
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00017308 File Offset: 0x00015508
	private void SetLanguageByRegion(string regionName)
	{
		uint num = <PrivateImplementationDetails>.ComputeStringHash(regionName);
		if (num > 1022431543U)
		{
			if (num <= 1726547088U)
			{
				if (num != 1023417281U)
				{
					if (num != 1710461017U)
					{
						if (num != 1726547088U)
						{
							goto IL_271;
						}
						if (!(regionName == "IT"))
						{
							goto IL_271;
						}
						LocalizationScript.languageChosen = 3;
						this.ChooseLanguage(false);
						return;
					}
					else if (!(regionName == "US"))
					{
						goto IL_271;
					}
				}
				else
				{
					if (!(regionName == "PT"))
					{
						goto IL_271;
					}
					goto IL_244;
				}
			}
			else if (num <= 1993561969U)
			{
				if (num != 1745149088U)
				{
					if (num != 1993561969U)
					{
						goto IL_271;
					}
					if (!(regionName == "FR"))
					{
						goto IL_271;
					}
					LocalizationScript.languageChosen = 2;
					this.ChooseLanguage(false);
					return;
				}
				else
				{
					if (!(regionName == "RU"))
					{
						goto IL_271;
					}
					LocalizationScript.languageChosen = 10;
					this.ChooseLanguage(false);
					return;
				}
			}
			else if (num != 2010780873U)
			{
				if (num != 2161779444U)
				{
					goto IL_271;
				}
				if (!(regionName == "CN"))
				{
					goto IL_271;
				}
				LocalizationScript.languageChosen = 11;
				this.ChooseLanguage(false);
				return;
			}
			else if (!(regionName == "CA"))
			{
				goto IL_271;
			}
			LocalizationScript.languageChosen = 1;
			this.ChooseLanguage(false);
			return;
		}
		if (num <= 786264949U)
		{
			if (num != 620754425U)
			{
				if (num != 634133545U)
				{
					if (num != 786264949U)
					{
						goto IL_271;
					}
					if (!(regionName == "BR"))
					{
						goto IL_271;
					}
				}
				else
				{
					if (!(regionName == "ES"))
					{
						goto IL_271;
					}
					LocalizationScript.languageChosen = 5;
					this.ChooseLanguage(false);
					return;
				}
			}
			else
			{
				if (!(regionName == "PL"))
				{
					goto IL_271;
				}
				LocalizationScript.languageChosen = 8;
				this.ChooseLanguage(false);
				return;
			}
		}
		else if (num != 888063496U)
		{
			if (num != 1003388258U)
			{
				if (num != 1022431543U)
				{
					goto IL_271;
				}
				if (!(regionName == "JP"))
				{
					goto IL_271;
				}
				LocalizationScript.languageChosen = 6;
				this.ChooseLanguage(false);
				return;
			}
			else
			{
				if (!(regionName == "DE"))
				{
					goto IL_271;
				}
				LocalizationScript.languageChosen = 4;
				this.ChooseLanguage(false);
				return;
			}
		}
		else
		{
			if (!(regionName == "KR"))
			{
				goto IL_271;
			}
			LocalizationScript.languageChosen = 7;
			this.ChooseLanguage(false);
			return;
		}
		IL_244:
		LocalizationScript.languageChosen = 9;
		this.ChooseLanguage(false);
		return;
		IL_271:
		LocalizationScript.languageChosen = 1;
		this.ChooseLanguage(false);
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00017594 File Offset: 0x00015794
	public void ChooseLanguage(bool changeLanguage)
	{
		this.englishFlag.SetActive(false);
		this.frenchFlag.SetActive(false);
		this.italianFlag.SetActive(false);
		this.germanFlag.SetActive(false);
		this.spanishFlag.SetActive(false);
		this.japaneseFlag.SetActive(false);
		this.koreanFlag.SetActive(false);
		this.polishFlag.SetActive(false);
		this.portugeseFlag.SetActive(false);
		this.russianFlag.SetActive(false);
		this.simplefiedChineseFlag.SetActive(false);
		LocalizationScript.isEnglish = false;
		LocalizationScript.isFrench = false;
		LocalizationScript.isItalian = false;
		LocalizationScript.isGerman = false;
		LocalizationScript.isSpanish = false;
		LocalizationScript.isJapanese = false;
		LocalizationScript.isKorean = false;
		LocalizationScript.isPolish = false;
		LocalizationScript.isPortugese = false;
		LocalizationScript.isRussian = false;
		LocalizationScript.isSimplefiedChinese = false;
		if (changeLanguage)
		{
			LocalizationScript.languageChosen++;
			this.audioManager.Play("UI_Click1");
		}
		if (LocalizationScript.languageChosen == 1)
		{
			LocalizationScript.isEnglish = true;
			this.englishFlag.SetActive(true);
			this.englishFlag.GetComponent<Button>().onClick.Invoke();
			PlayerPrefs.SetInt("language", LocalizationScript.languageChosen);
		}
		if (LocalizationScript.languageChosen == 2)
		{
			LocalizationScript.isFrench = true;
			this.frenchFlag.SetActive(true);
			this.frenchFlag.GetComponent<Button>().onClick.Invoke();
			PlayerPrefs.SetInt("language", LocalizationScript.languageChosen);
		}
		if (LocalizationScript.languageChosen == 3)
		{
			LocalizationScript.isItalian = true;
			this.italianFlag.SetActive(true);
			this.italianFlag.GetComponent<Button>().onClick.Invoke();
			PlayerPrefs.SetInt("language", LocalizationScript.languageChosen);
		}
		if (LocalizationScript.languageChosen == 4)
		{
			LocalizationScript.isGerman = true;
			this.germanFlag.SetActive(true);
			this.germanFlag.GetComponent<Button>().onClick.Invoke();
			PlayerPrefs.SetInt("language", LocalizationScript.languageChosen);
		}
		if (LocalizationScript.languageChosen == 5)
		{
			LocalizationScript.isSpanish = true;
			this.spanishFlag.SetActive(true);
			this.spanishFlag.GetComponent<Button>().onClick.Invoke();
			PlayerPrefs.SetInt("language", LocalizationScript.languageChosen);
		}
		if (LocalizationScript.languageChosen == 6)
		{
			LocalizationScript.isJapanese = true;
			this.japaneseFlag.SetActive(true);
			this.japaneseFlag.GetComponent<Button>().onClick.Invoke();
			PlayerPrefs.SetInt("language", LocalizationScript.languageChosen);
		}
		if (LocalizationScript.languageChosen == 7)
		{
			LocalizationScript.isKorean = true;
			this.koreanFlag.SetActive(true);
			this.koreanFlag.GetComponent<Button>().onClick.Invoke();
			PlayerPrefs.SetInt("language", LocalizationScript.languageChosen);
		}
		if (LocalizationScript.languageChosen == 8)
		{
			LocalizationScript.isPolish = true;
			this.polishFlag.SetActive(true);
			this.polishFlag.GetComponent<Button>().onClick.Invoke();
			PlayerPrefs.SetInt("language", LocalizationScript.languageChosen);
		}
		if (LocalizationScript.languageChosen == 9)
		{
			LocalizationScript.isPortugese = true;
			this.portugeseFlag.SetActive(true);
			this.portugeseFlag.GetComponent<Button>().onClick.Invoke();
			PlayerPrefs.SetInt("language", LocalizationScript.languageChosen);
		}
		if (LocalizationScript.languageChosen == 10)
		{
			LocalizationScript.isRussian = true;
			this.russianFlag.SetActive(true);
			this.russianFlag.GetComponent<Button>().onClick.Invoke();
			PlayerPrefs.SetInt("language", LocalizationScript.languageChosen);
		}
		if (LocalizationScript.languageChosen == 11)
		{
			LocalizationScript.isSimplefiedChinese = true;
			this.simplefiedChineseFlag.SetActive(true);
			this.simplefiedChineseFlag.GetComponent<Button>().onClick.Invoke();
			PlayerPrefs.SetInt("language", LocalizationScript.languageChosen);
		}
		if (LocalizationScript.languageChosen == 12)
		{
			LocalizationScript.languageChosen = 1;
			LocalizationScript.isEnglish = true;
			this.englishFlag.SetActive(true);
			this.englishFlag.GetComponent<Button>().onClick.Invoke();
			PlayerPrefs.SetInt("language", LocalizationScript.languageChosen);
		}
		this.NoChangeStrings();
		this.levelScript.SetSignText();
		this.levelScript.SetTalentTexts();
		for (int i = 0; i < 21; i++)
		{
			this.TalentTexts(i);
		}
		this.SetOtherTexts();
		this.TutText();
		this.EndingTexts();
		this.StatsText();
		this.TalentCardsLeftText();
		this.TheMineTexts(true);
		this.TheMineTexts(false);
		this.theAnvilScript.CheckSkin();
		this.theAnvilScript.CheckPickaxes();
		this.theAnvilScript.CheckPickaxeName();
		base.StartCoroutine(this.Waititn());
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00017A02 File Offset: 0x00015C02
	private IEnumerator Waititn()
	{
		yield return new WaitForSeconds(1f);
		this.TutText();
		yield break;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00017A14 File Offset: 0x00015C14
	public void SetSkillTreeTexts(string upgradeName, int upgradeType, double upgradePrice, int purchaseCount, int totalPurchaseCount)
	{
		LocalizationScript.currentHoverPrice = upgradePrice;
		if (LocalizationScript.currentHoverPrice % 1.0 != 0.0)
		{
			if (LocalizationScript.currentHoverPrice % 1.0 >= 0.5)
			{
				LocalizationScript.currentHoverPrice = Math.Ceiling(LocalizationScript.currentHoverPrice);
			}
			else
			{
				LocalizationScript.currentHoverPrice = Math.Floor(LocalizationScript.currentHoverPrice);
			}
		}
		LocalizationScript.currentPurchaseCount = purchaseCount;
		LocalizationScript.currentTotalPurchaseCount = totalPurchaseCount;
		this.SkillTreeText(upgradeName, upgradeType, LocalizationScript.currentHoverPrice, purchaseCount, totalPurchaseCount);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00017A9C File Offset: 0x00015C9C
	public void NoChangeStrings()
	{
		if (LocalizationScript.isEnglish)
		{
			this.tooltipAnim.text = "Tooltip Animation";
			this.off.text = "OFF";
			this.on.text = "ON";
			LocalizationScript.closeString = "CLOSE";
			this.purchaseText.text = "PURCHASE";
			this.cost.text = "Cost:";
			this.artifactBuffTooltip.text = "Artifact buff:";
			LocalizationScript.pickaxe1_name = "Mr. Rusty";
			LocalizationScript.pickaxe2_name = "Sir. Goldy";
			LocalizationScript.pickaxe3_name = "Royale-Pick";
			LocalizationScript.pickaxe4_name = "Old Reliable";
			LocalizationScript.pickaxe5_name = "The Opulaxe";
			LocalizationScript.pickaxe6_name = "Stonesplitter";
			LocalizationScript.pickaxe7_name = "Dagger-Pick";
			LocalizationScript.pickaxe8_name = "Uranium Fever";
			LocalizationScript.pickaxe9_name = "Forgeborn ";
			LocalizationScript.pickaxe10_name = "Crimson Sovereign";
			LocalizationScript.pickaxe11_name = "The Gemcutter";
			LocalizationScript.pickaxe12_name = "Kings Companion";
			LocalizationScript.pickaxe13_name = "The Crusher";
			LocalizationScript.pickaxe14_name = "Diamond Pickaxe";
			LocalizationScript.rolled = "Rolled:";
			LocalizationScript.oresTripled = "Ores multiplied X5!";
			LocalizationScript.price = "Price:";
			LocalizationScript.talentLevel = "Talent level:";
			LocalizationScript.durability = "Durability";
			LocalizationScript.levelUp = "LEVEL UP!";
			LocalizationScript.skin = "SKIN ";
			LocalizationScript.artifactFound = "Artifact found!";
			LocalizationScript.horn = "Ox Horn";
			LocalizationScript.device = "Ancient Device";
			LocalizationScript.bone = "Fossilized Bone";
			LocalizationScript.meteorite = "Meteorite Ore";
			LocalizationScript.book = "Magic Book";
			LocalizationScript.sack = "Sack of Gold";
			LocalizationScript.goldRing = "Gold Ring";
			LocalizationScript.royalRing = "Royal Ring";
			LocalizationScript.dice = "Ancient Dice";
			LocalizationScript.cheese = "Holy Cheese";
			LocalizationScript.wolf = "Wolf Claw";
			LocalizationScript.axe = "Warrior's Axe";
			LocalizationScript.runestone = "Runestone";
			LocalizationScript.skull = "Warrior's Skull";
			LocalizationScript.crafting = "Crafting";
		}
		if (LocalizationScript.isFrench)
		{
			this.tooltipAnim.text = "Animation des info-bulles";
			this.off.text = "DÉSACTIVÉ";
			this.on.text = "ACTIVÉ";
			LocalizationScript.closeString = "FERMER";
			this.purchaseText.text = "ACHETER";
			this.cost.text = "Cost:";
			this.artifactBuffTooltip.text = "Bonus de l'artéfact :";
			LocalizationScript.pickaxe1_name = "Mr. Rouillé";
			LocalizationScript.pickaxe2_name = "Sir Doré";
			LocalizationScript.pickaxe3_name = "Royale-Pick";
			LocalizationScript.pickaxe4_name = "Vieux Fiable";
			LocalizationScript.pickaxe5_name = "L’Opulaxe";
			LocalizationScript.pickaxe6_name = "Brise-Pierre";
			LocalizationScript.pickaxe7_name = "Dague-Pic";
			LocalizationScript.pickaxe8_name = "Fièvre d’Uranium";
			LocalizationScript.pickaxe9_name = "Forge-né";
			LocalizationScript.pickaxe10_name = "Souverain Cramoisi";
			LocalizationScript.pickaxe11_name = "Le Tailleur de Gemmes";
			LocalizationScript.pickaxe12_name = "Compagnon du Roi";
			LocalizationScript.pickaxe13_name = "Le Broyeur";
			LocalizationScript.pickaxe14_name = "Pioche en Diamant";
			LocalizationScript.rolled = "Lancé :";
			LocalizationScript.oresTripled = "Minerais multipliés par 5\u00a0!";
			LocalizationScript.price = "Prix :";
			LocalizationScript.talentLevel = "Niveau de talent :";
			LocalizationScript.durability = "Durabilité";
			LocalizationScript.levelUp = "NIVEAU SUPÉRIEUR !";
			LocalizationScript.skin = "SKIN ";
			LocalizationScript.artifactFound = "Artefact trouvé !";
			LocalizationScript.horn = "Corne de Bœuf";
			LocalizationScript.device = "Ancien Dispositif";
			LocalizationScript.bone = "Os Fossilisé";
			LocalizationScript.meteorite = "Minerai de Météorite";
			LocalizationScript.book = "Livre Magique";
			LocalizationScript.sack = "Sac d’Or";
			LocalizationScript.goldRing = "Anneau d’Or";
			LocalizationScript.royalRing = "Anneau Royal";
			LocalizationScript.dice = "Dés Anciens";
			LocalizationScript.cheese = "Fromage Sacré";
			LocalizationScript.wolf = "Griffe de Loup";
			LocalizationScript.axe = "Hache de Guerrier";
			LocalizationScript.runestone = "Rune";
			LocalizationScript.skull = "Crâne de Guerrier";
			LocalizationScript.crafting = "Fabrication";
		}
		if (LocalizationScript.isItalian)
		{
			this.tooltipAnim.text = "Animazione tooltip";
			this.off.text = "SPENTO";
			this.on.text = "ACCESO";
			LocalizationScript.closeString = "CHIUDI";
			this.purchaseText.text = "ACQUISTA";
			this.cost.text = "Costo:";
			this.artifactBuffTooltip.text = "Bonus dell'artefatto:";
			LocalizationScript.pickaxe1_name = "Mr. Arrugginito";
			LocalizationScript.pickaxe2_name = "Sir Dorato";
			LocalizationScript.pickaxe3_name = "Royale-Pick";
			LocalizationScript.pickaxe4_name = "Vecchio Fedele";
			LocalizationScript.pickaxe5_name = "L’Opulazza";
			LocalizationScript.pickaxe6_name = "Spaccapietre";
			LocalizationScript.pickaxe7_name = "Pico-Pugnale";
			LocalizationScript.pickaxe8_name = "Febbre da Uranio";
			LocalizationScript.pickaxe9_name = "Forgiato";
			LocalizationScript.pickaxe10_name = "Sovrano Cremisi";
			LocalizationScript.pickaxe11_name = "Tagliagemme";
			LocalizationScript.pickaxe12_name = "Compagno del Re";
			LocalizationScript.pickaxe13_name = "Il Frantumatore";
			LocalizationScript.pickaxe14_name = "Piccone di Diamante";
			LocalizationScript.rolled = "Lanciato:";
			LocalizationScript.oresTripled = "Minerali moltiplicati per 5!";
			LocalizationScript.price = "Prezzo:";
			LocalizationScript.talentLevel = "Livello talento:";
			LocalizationScript.durability = "Durabilità";
			LocalizationScript.levelUp = "LIVELLO SUPERIORE!";
			LocalizationScript.skin = "SKIN ";
			LocalizationScript.artifactFound = "Artefatto trovato!";
			LocalizationScript.horn = "Corno di Bue";
			LocalizationScript.device = "Dispositivo Antico";
			LocalizationScript.bone = "Osso Fossilizzato";
			LocalizationScript.meteorite = "Minerale di Meteorite";
			LocalizationScript.book = "Libro Magico";
			LocalizationScript.sack = "Sacco d’Oro";
			LocalizationScript.goldRing = "Anello d’Oro";
			LocalizationScript.royalRing = "Anello Reale";
			LocalizationScript.dice = "Dadi Antichi";
			LocalizationScript.cheese = "Formaggio Sacro";
			LocalizationScript.wolf = "Artiglio di Lupo";
			LocalizationScript.axe = "Ascia del Guerriero";
			LocalizationScript.runestone = "Pietra Runica";
			LocalizationScript.skull = "Teschio del Guerriero";
			LocalizationScript.crafting = "Creazione";
		}
		if (LocalizationScript.isGerman)
		{
			this.tooltipAnim.text = "Tooltip-Animation";
			this.off.text = "AUS";
			this.on.text = "AN";
			LocalizationScript.closeString = "SCHLIESSEN";
			this.purchaseText.text = "KAUFEN";
			this.cost.text = "Kosten:";
			this.artifactBuffTooltip.text = "Artefakt-Bonus:";
			LocalizationScript.pickaxe1_name = "Mr. Rostig";
			LocalizationScript.pickaxe2_name = "Sir Goldig";
			LocalizationScript.pickaxe3_name = "Royale-Pick";
			LocalizationScript.pickaxe4_name = "Alter Zuverlässiger";
			LocalizationScript.pickaxe5_name = "Die Opulaxe";
			LocalizationScript.pickaxe6_name = "Steinspalter";
			LocalizationScript.pickaxe7_name = "Dolch-Pick";
			LocalizationScript.pickaxe8_name = "Uran-Fieber";
			LocalizationScript.pickaxe9_name = "Schmiedgeboren";
			LocalizationScript.pickaxe10_name = "Purpurner Souverän";
			LocalizationScript.pickaxe11_name = "Der Edelsteinschneider";
			LocalizationScript.pickaxe12_name = "Königsgefährte";
			LocalizationScript.pickaxe13_name = "Der Zermalmer";
			LocalizationScript.pickaxe14_name = "Diamantspitzhacke";
			LocalizationScript.rolled = "Gewürfelt:";
			LocalizationScript.oresTripled = "Erze mit 5X multipliziert!";
			LocalizationScript.price = "Preis:";
			LocalizationScript.talentLevel = "Talentstufe:";
			LocalizationScript.durability = "Haltbarkeit";
			LocalizationScript.levelUp = "LEVEL AUF!";
			LocalizationScript.skin = "SKIN ";
			LocalizationScript.artifactFound = "Artefakt gefunden!";
			LocalizationScript.horn = "Ochsenhorn";
			LocalizationScript.device = "Antikes Gerät";
			LocalizationScript.bone = "Fossilisierter Knochen";
			LocalizationScript.meteorite = "Meteoriterz";
			LocalizationScript.book = "Magisches Buch";
			LocalizationScript.sack = "Goldsack";
			LocalizationScript.goldRing = "Goldring";
			LocalizationScript.royalRing = "Königsring";
			LocalizationScript.dice = "Antike Würfel";
			LocalizationScript.cheese = "Heiliger Käse";
			LocalizationScript.wolf = "Wolfsklaue";
			LocalizationScript.axe = "Kriegeraxt";
			LocalizationScript.runestone = "Runenstein";
			LocalizationScript.skull = "Kriegerschädel";
			LocalizationScript.crafting = "Herstellung";
		}
		if (LocalizationScript.isSpanish)
		{
			this.tooltipAnim.text = "Animación de tooltip";
			this.off.text = "APAGADO";
			this.on.text = "ENCENDIDO";
			LocalizationScript.closeString = "CERRAR";
			this.purchaseText.text = "COMPRAR";
			this.cost.text = "Costo:";
			this.artifactBuffTooltip.text = "Mejora del artefacto:";
			LocalizationScript.pickaxe1_name = "Sr. Oxidado";
			LocalizationScript.pickaxe2_name = "Sir Dorado";
			LocalizationScript.pickaxe3_name = "Royale-Pick";
			LocalizationScript.pickaxe4_name = "Viejo Fiel";
			LocalizationScript.pickaxe5_name = "La Opulacha";
			LocalizationScript.pickaxe6_name = "Partedor de Piedra";
			LocalizationScript.pickaxe7_name = "Pico-Daga";
			LocalizationScript.pickaxe8_name = "Fiebre de Uranio";
			LocalizationScript.pickaxe9_name = "Forjado";
			LocalizationScript.pickaxe10_name = "Soberano Carmesí";
			LocalizationScript.pickaxe11_name = "El Tallador de Gemas";
			LocalizationScript.pickaxe12_name = "Compañero del Rey";
			LocalizationScript.pickaxe13_name = "El Triturador";
			LocalizationScript.pickaxe14_name = "Pico de Diamante";
			LocalizationScript.rolled = "Lanzado:";
			LocalizationScript.oresTripled = "¡Minerales multiplicados por 5!";
			LocalizationScript.price = "Precio:";
			LocalizationScript.talentLevel = "Nivel de talento:";
			LocalizationScript.durability = "Durabilidad";
			LocalizationScript.levelUp = "¡SUBIR DE NIVEL!";
			LocalizationScript.skin = "SKIN ";
			LocalizationScript.artifactFound = "¡Artefacto encontrado!";
			LocalizationScript.horn = "Cuerno de Buey";
			LocalizationScript.device = "Dispositivo Antiguo";
			LocalizationScript.bone = "Hueso Fosilizado";
			LocalizationScript.meteorite = "Mineral de Meteorito";
			LocalizationScript.book = "Libro Mágico";
			LocalizationScript.sack = "Saco de Oro";
			LocalizationScript.goldRing = "Anillo de Oro";
			LocalizationScript.royalRing = "Anillo Real";
			LocalizationScript.dice = "Dados Antiguos";
			LocalizationScript.cheese = "Queso Sagrado";
			LocalizationScript.wolf = "Garra de Lobo";
			LocalizationScript.axe = "Hacha del Guerrero";
			LocalizationScript.runestone = "Piedra Rúnica";
			LocalizationScript.skull = "Calavera de Guerrero";
			LocalizationScript.crafting = "Fabricación";
		}
		if (LocalizationScript.isJapanese)
		{
			this.tooltipAnim.text = "ツールチップアニメーション";
			this.off.text = "オフ";
			this.on.text = "オン";
			LocalizationScript.closeString = "閉じる";
			this.purchaseText.text = "購入";
			this.cost.text = "コスト：";
			this.artifactBuffTooltip.text = "アーティファクト効果:";
			LocalizationScript.pickaxe1_name = "ミスターラスティ";
			LocalizationScript.pickaxe2_name = "サー・ゴールディ";
			LocalizationScript.pickaxe3_name = "ロイヤルピック";
			LocalizationScript.pickaxe4_name = "オールドリライアブル";
			LocalizationScript.pickaxe5_name = "オプラックス";
			LocalizationScript.pickaxe6_name = "ストーンスプリッター";
			LocalizationScript.pickaxe7_name = "ダガーピック";
			LocalizationScript.pickaxe8_name = "ウラン熱";
			LocalizationScript.pickaxe9_name = "フォージボーン";
			LocalizationScript.pickaxe10_name = "クリムゾン・ソブリン";
			LocalizationScript.pickaxe11_name = "ジェムカッター";
			LocalizationScript.pickaxe12_name = "キングズコンパニオン";
			LocalizationScript.pickaxe13_name = "ザ・クラッシャー";
			LocalizationScript.pickaxe14_name = "ダイヤモンドピッケル";
			LocalizationScript.rolled = "結果：";
			LocalizationScript.oresTripled = "鉱石が5倍！";
			LocalizationScript.price = "価格：";
			LocalizationScript.talentLevel = "才能レベル：";
			LocalizationScript.durability = "耐久度";
			LocalizationScript.levelUp = "レベルアップ！";
			LocalizationScript.skin = "スキン ";
			LocalizationScript.artifactFound = "アーティファクト発見！";
			LocalizationScript.horn = "牛の角";
			LocalizationScript.device = "古代の装置";
			LocalizationScript.bone = "化石化した骨";
			LocalizationScript.meteorite = "隕石鉱石";
			LocalizationScript.book = "魔法の書";
			LocalizationScript.sack = "金の袋";
			LocalizationScript.goldRing = "金の指輪";
			LocalizationScript.royalRing = "王家の指輪";
			LocalizationScript.dice = "古代のサイコロ";
			LocalizationScript.cheese = "神聖なチーズ";
			LocalizationScript.wolf = "狼の爪";
			LocalizationScript.axe = "戦士の斧";
			LocalizationScript.runestone = "ルーン石";
			LocalizationScript.skull = "戦士の頭蓋骨";
			LocalizationScript.crafting = "クラフト";
		}
		if (LocalizationScript.isKorean)
		{
			this.tooltipAnim.text = "툴팁 애니메이션";
			this.off.text = "꺼짐";
			this.on.text = "켜짐";
			LocalizationScript.closeString = "닫기";
			this.purchaseText.text = "구매";
			this.cost.text = "비용:";
			this.artifactBuffTooltip.text = "아티팩트 버프:";
			LocalizationScript.pickaxe1_name = "미스터 러스티";
			LocalizationScript.pickaxe2_name = "서 골디";
			LocalizationScript.pickaxe3_name = "로얄-픽";
			LocalizationScript.pickaxe4_name = "올드 리라이어블";
			LocalizationScript.pickaxe5_name = "오풀랙스";
			LocalizationScript.pickaxe6_name = "스톤스플리터";
			LocalizationScript.pickaxe7_name = "대거-픽";
			LocalizationScript.pickaxe8_name = "우라늄 열풍";
			LocalizationScript.pickaxe9_name = "포지본";
			LocalizationScript.pickaxe10_name = "크림슨 소버린";
			LocalizationScript.pickaxe11_name = "젬커터";
			LocalizationScript.pickaxe12_name = "왕의 동료";
			LocalizationScript.pickaxe13_name = "더 크러셔";
			LocalizationScript.pickaxe14_name = "다이아몬드 곡괭이";
			LocalizationScript.rolled = "굴림:";
			LocalizationScript.oresTripled = "광물이 5배로 증가!";
			LocalizationScript.price = "가격:";
			LocalizationScript.talentLevel = "특성 레벨:";
			LocalizationScript.durability = "내구도";
			LocalizationScript.levelUp = "레벨 업!";
			LocalizationScript.skin = "스킨 ";
			LocalizationScript.artifactFound = "유물 발견!";
			LocalizationScript.horn = "황소 뿔";
			LocalizationScript.device = "고대 장치";
			LocalizationScript.bone = "화석화된 뼈";
			LocalizationScript.meteorite = "운석 광석";
			LocalizationScript.book = "마법서";
			LocalizationScript.sack = "금 주머니";
			LocalizationScript.goldRing = "금 반지";
			LocalizationScript.royalRing = "왕의 반지";
			LocalizationScript.dice = "고대 주사위";
			LocalizationScript.cheese = "성스러운 치즈";
			LocalizationScript.wolf = "늑대 발톱";
			LocalizationScript.axe = "전사의 도끼";
			LocalizationScript.runestone = "룬스톤";
			LocalizationScript.skull = "전사의 해골";
			LocalizationScript.crafting = "제작";
		}
		if (LocalizationScript.isPolish)
		{
			this.tooltipAnim.text = "Animacja podpowiedzi";
			this.off.text = "WYŁ.";
			this.on.text = "WŁ.";
			LocalizationScript.closeString = "ZAMKNIJ";
			this.purchaseText.text = "KUP";
			this.cost.text = "Koszt:";
			this.artifactBuffTooltip.text = "Premia artefaktu:";
			LocalizationScript.pickaxe1_name = "Pan Zardziały";
			LocalizationScript.pickaxe2_name = "Sir Złoty";
			LocalizationScript.pickaxe3_name = "Royale-Pick";
			LocalizationScript.pickaxe4_name = "Stary Pewniak";
			LocalizationScript.pickaxe5_name = "Opulaks";
			LocalizationScript.pickaxe6_name = "Rozłupacz Kamieni";
			LocalizationScript.pickaxe7_name = "Sztyletowy Kilof";
			LocalizationScript.pickaxe8_name = "Uranowa Gorączka";
			LocalizationScript.pickaxe9_name = "Kuźniowy";
			LocalizationScript.pickaxe10_name = "Karmazynowy Suweren";
			LocalizationScript.pickaxe11_name = "Szlifierz Klejnotów";
			LocalizationScript.pickaxe12_name = "Królewski Towarzysz";
			LocalizationScript.pickaxe13_name = "Krusher";
			LocalizationScript.pickaxe14_name = "Diamentowy Kilof";
			LocalizationScript.rolled = "Wyrzucono:";
			LocalizationScript.oresTripled = "Rudy pomnożone x5!";
			LocalizationScript.price = "Cena:";
			LocalizationScript.talentLevel = "Poziom talentu:";
			LocalizationScript.durability = "Trwałość";
			LocalizationScript.levelUp = "POZIOM W GÓRĘ!";
			LocalizationScript.skin = "SKÓRKA ";
			LocalizationScript.artifactFound = "Znaleziono artefakt!";
			LocalizationScript.horn = "Róg Wołu";
			LocalizationScript.device = "Starożytne Urządzenie";
			LocalizationScript.bone = "Skamieniała Kość";
			LocalizationScript.meteorite = "Ruda Meteorytowa";
			LocalizationScript.book = "Magiczna Księga";
			LocalizationScript.sack = "Worek Złota";
			LocalizationScript.goldRing = "Złoty Pierścień";
			LocalizationScript.royalRing = "Królewski Pierścień";
			LocalizationScript.dice = "Starożytne Kości";
			LocalizationScript.cheese = "Święty Ser";
			LocalizationScript.wolf = "Wilczy Pazur";
			LocalizationScript.axe = "Topór Wojownika";
			LocalizationScript.runestone = "Kamień Runiczny";
			LocalizationScript.skull = "Czaszka Wojownika";
			LocalizationScript.crafting = "Rzemiosło";
		}
		if (LocalizationScript.isPortugese)
		{
			this.tooltipAnim.text = "Animação de tooltip";
			this.off.text = "DESLIGADO";
			this.on.text = "LIGADO";
			LocalizationScript.closeString = "FECHAR";
			this.purchaseText.text = "COMPRAR";
			this.cost.text = "Custo:";
			this.artifactBuffTooltip.text = "Bônus do artefato:";
			LocalizationScript.pickaxe1_name = "Sr. Enferrujado";
			LocalizationScript.pickaxe2_name = "Sir Dourado";
			LocalizationScript.pickaxe3_name = "Royale-Pick";
			LocalizationScript.pickaxe4_name = "Velho Fiel";
			LocalizationScript.pickaxe5_name = "Opulacha";
			LocalizationScript.pickaxe6_name = "Quebra-Pedra";
			LocalizationScript.pickaxe7_name = "Picareta-Adaga";
			LocalizationScript.pickaxe8_name = "Febre de Urânio";
			LocalizationScript.pickaxe9_name = "Forjado";
			LocalizationScript.pickaxe10_name = "Soberano Carmesim";
			LocalizationScript.pickaxe11_name = "Cortador de Gemas";
			LocalizationScript.pickaxe12_name = "Companheiro do Rei";
			LocalizationScript.pickaxe13_name = "O Triturador";
			LocalizationScript.pickaxe14_name = "Picareta de Diamante";
			LocalizationScript.rolled = "Rolado:";
			LocalizationScript.oresTripled = "Minérios multiplicados por 5!";
			LocalizationScript.price = "Preço:";
			LocalizationScript.talentLevel = "Nível de talento:";
			LocalizationScript.durability = "Durabilidade";
			LocalizationScript.levelUp = "NÍVEL UP!";
			LocalizationScript.skin = "SKIN ";
			LocalizationScript.artifactFound = "Artefato encontrado!";
			LocalizationScript.horn = "Chifre de Boi";
			LocalizationScript.device = "Dispositivo Antigo";
			LocalizationScript.bone = "Osso Fossilizado";
			LocalizationScript.meteorite = "Minério de Meteorito";
			LocalizationScript.book = "Livro Mágico";
			LocalizationScript.sack = "Saco de Ouro";
			LocalizationScript.goldRing = "Anel de Ouro";
			LocalizationScript.royalRing = "Anel Real";
			LocalizationScript.dice = "Dados Antigos";
			LocalizationScript.cheese = "Queijo Sagrado";
			LocalizationScript.wolf = "Garra de Lobo";
			LocalizationScript.axe = "Machado do Guerreiro";
			LocalizationScript.runestone = "Pedra Rúnica";
			LocalizationScript.skull = "Crânio do Guerreiro";
			LocalizationScript.crafting = "Criação";
		}
		if (LocalizationScript.isRussian)
		{
			this.tooltipAnim.text = "Анимация подсказок";
			this.off.text = "ВЫКЛ.";
			this.on.text = "ВКЛ.";
			LocalizationScript.closeString = "ЗАКРЫТЬ";
			this.purchaseText.text = "КУПИТЬ";
			this.cost.text = "Стоимость:";
			this.artifactBuffTooltip.text = "Бонус артефакта:";
			LocalizationScript.pickaxe1_name = "Мистер Ржавый";
			LocalizationScript.pickaxe2_name = "Сэр Золотой";
			LocalizationScript.pickaxe3_name = "Роял-Пик";
			LocalizationScript.pickaxe4_name = "Старый Надёжный";
			LocalizationScript.pickaxe5_name = "Опулакс";
			LocalizationScript.pickaxe6_name = "Камнерез";
			LocalizationScript.pickaxe7_name = "Кинжал-Пик";
			LocalizationScript.pickaxe8_name = "Урановая Лихорадка";
			LocalizationScript.pickaxe9_name = "Кузнечный";
			LocalizationScript.pickaxe10_name = "Багровый Суверен";
			LocalizationScript.pickaxe11_name = "Гравёр Камней";
			LocalizationScript.pickaxe12_name = "Королевский Спутник";
			LocalizationScript.pickaxe13_name = "Дробитель";
			LocalizationScript.pickaxe14_name = "Алмазная Кирка";
			LocalizationScript.rolled = "Выпало:";
			LocalizationScript.oresTripled = "Руда умножена на 5!";
			LocalizationScript.price = "Цена:";
			LocalizationScript.talentLevel = "Уровень таланта:";
			LocalizationScript.durability = "Прочность";
			LocalizationScript.levelUp = "НОВЫЙ УРОВЕНЬ!";
			LocalizationScript.skin = "СКИН ";
			LocalizationScript.artifactFound = "Артефакт найден!";
			LocalizationScript.horn = "Бычий Рог";
			LocalizationScript.device = "Древнее Устройство";
			LocalizationScript.bone = "Окаменелая Кость";
			LocalizationScript.meteorite = "Метеоритная Руда";
			LocalizationScript.book = "Магическая Книга";
			LocalizationScript.sack = "Мешок Золота";
			LocalizationScript.goldRing = "Золотое Кольцо";
			LocalizationScript.royalRing = "Королевское Кольцо";
			LocalizationScript.dice = "Древние Кости";
			LocalizationScript.cheese = "Святой Сыр";
			LocalizationScript.wolf = "Волчий Коготь";
			LocalizationScript.axe = "Топор Воина";
			LocalizationScript.runestone = "Рунический Камень";
			LocalizationScript.skull = "Череп Воина";
			LocalizationScript.crafting = "Крафт";
		}
		if (LocalizationScript.isSimplefiedChinese)
		{
			this.tooltipAnim.text = "提示动画";
			this.off.text = "关";
			this.on.text = "开";
			LocalizationScript.closeString = "关闭";
			this.purchaseText.text = "购买";
			this.cost.text = "花费：";
			this.artifactBuffTooltip.text = "神器增益：";
			LocalizationScript.pickaxe1_name = "锈先生";
			LocalizationScript.pickaxe2_name = "金爵士";
			LocalizationScript.pickaxe3_name = "皇家镐";
			LocalizationScript.pickaxe4_name = "老可靠";
			LocalizationScript.pickaxe5_name = "富贵镐";
			LocalizationScript.pickaxe6_name = "裂石者";
			LocalizationScript.pickaxe7_name = "匕首镐";
			LocalizationScript.pickaxe8_name = "铀狂热";
			LocalizationScript.pickaxe9_name = "铸造之子";
			LocalizationScript.pickaxe10_name = "猩红君主";
			LocalizationScript.pickaxe11_name = "宝石切割者";
			LocalizationScript.pickaxe12_name = "国王伙伴";
			LocalizationScript.pickaxe13_name = "破碎者";
			LocalizationScript.pickaxe14_name = "钻石镐";
			LocalizationScript.rolled = "掷出：";
			LocalizationScript.oresTripled = "矿石×5倍！";
			LocalizationScript.price = "价格：";
			LocalizationScript.talentLevel = "天赋等级：";
			LocalizationScript.durability = "耐久度";
			LocalizationScript.levelUp = "升级！";
			LocalizationScript.skin = "皮肤 ";
			LocalizationScript.artifactFound = "发现遗物！";
			LocalizationScript.horn = "牛角";
			LocalizationScript.device = "古代装置";
			LocalizationScript.bone = "化石骨";
			LocalizationScript.meteorite = "陨石矿";
			LocalizationScript.book = "魔法书";
			LocalizationScript.sack = "金币袋";
			LocalizationScript.goldRing = "金戒指";
			LocalizationScript.royalRing = "皇家戒指";
			LocalizationScript.dice = "古代骰子";
			LocalizationScript.cheese = "神圣奶酪";
			LocalizationScript.wolf = "狼爪";
			LocalizationScript.axe = "战士之斧";
			LocalizationScript.runestone = "符石";
			LocalizationScript.skull = "战士之颅";
			LocalizationScript.crafting = "锻造";
		}
		this.skillTreeClose.text = LocalizationScript.closeString;
		this.talentClose.text = LocalizationScript.closeString;
		this.talentLevelClose.text = LocalizationScript.closeString;
		this.theMineInfoClose.text = LocalizationScript.closeString;
		this.artifactClose.text = LocalizationScript.closeString;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00018FDC File Offset: 0x000171DC
	public void SetOtherTexts()
	{
		LocalizationScript.musicCreditName1 = "XtremeFreddy";
		if (LocalizationScript.isEnglish)
		{
			this.COMPLETION.text = "COMPLETION!";
			this.allSkillTree.text = "All skill tree upgrades purchased!";
			this.byHaving.text = "By having purchased all of the skill tree upgrades, you have unlocked the ENDLESS UPGRADES.";
			this.theseUpgrades.text = "The endless upgrades are located at the top of the skill tree. ";
			this.theseUpgradesCanBe.text = "These upgrades can be continuously purchased and is aimed at players who want to continue to play the game after it's completion!";
			LocalizationScript.yes = "YES";
			LocalizationScript.no = "NO";
			this.coolText.text = "COOL";
			LocalizationScript.holdToCraft = "Hold to craft";
			LocalizationScript.clickToEquip = "Click to equip";
			this.mainMenu.text = "MAIN MENU";
			this.exitGame.text = "EXIT GAME";
			this.fullscreen.text = "Fullscreen";
			this.resetGame.text = "RESET GAME";
			this.areYouSureText.text = "Are you sure you want to reset the entire game?";
			this.thisIsNotText.text = "THIS IS NOT A PRESTIGE MECHANIC!";
			this.pressYesText.text = "Pressing YES will reset the entire game to the beginning.";
			this.resetYes.text = LocalizationScript.yes;
			this.resetNo.text = LocalizationScript.no;
			this.mineTheBigRock.text = "Mine the big rock!";
			this.keepOnMining_MainMenu.text = "Keep on Mining!";
			this.revealTalentCards.text = "REVEAL TALENT CARDS";
			this.choose1.text = "CHOOSE 1";
			this.allCardsChosen.text = "ALL TALENT\nCARDS CHOSEN";
			this.equipped.text = "Equipped";
			this.mineTime1.text = "Mine Time:";
			this.mineTime2.text = "Mine Time:";
			this.minePower1.text = "Mine Power:";
			this.minePower2.text = "Mine Power:";
			this.mine2X1.text = "2X Power Chance:";
			this.mine2X2.text = "2X Power Chance:";
			this.mineSize1.text = "Mining Area Size:";
			this.mineSize2.text = "Mining Area Size:";
			this.unlockTheMine.text = "UNLOCK THE MINE";
			this.playText.text = "Play";
			this.settingsText.text = "Settings";
			this.credits.text = "Credits";
			this.creditsText.text = "Credits";
			this.exitGameText.text = "Exit Game";
			this.gameBy.text = "Game by: EagleEye Games";
			this.musicBy.text = "Music by: " + LocalizationScript.musicCreditName1;
			this.customArtBy.text = "Custom art by: Artisgamemobile";
			this.skillTree.text = "Skill tree";
			this.talents.text = "Talents";
			this.theAnvil.text = "The anvil";
			this.theMine.text = "The mine";
			this.artifacts.text = "Artifacts";
			this.endSession.text = "END SESSION";
			this.miningSessionDone.text = "Mining session done!";
			this.oresGathered.text = "Ores Gathered";
			this.barsCrafted.text = "Bars Crafted";
			this.totalBars.text = "Total Bars";
			this.xpGathered.text = "XP Gathered";
			this.upgrade.text = "UPGRADE!";
			this.keepOnMining_endFrame.text = "KEEP ON MINING!";
			LocalizationScript.startMining = "START MINING!";
			LocalizationScript.outOfTime = "OUT OF TIME!";
			this.theMineTooltipText.text = "The \"Ore Value\" skill tree upgrades also effect the mined bars from The Mine!";
		}
		if (LocalizationScript.isFrench)
		{
			this.COMPLETION.text = "ACHÈVEMENT !";
			this.allSkillTree.text = "Toutes les améliorations de l'arbre de compétences ont été achetées !";
			this.byHaving.text = "En ayant acheté toutes les améliorations de l'arbre de compétences, vous avez débloqué les AMÉLIORATIONS SANS FIN.";
			this.theseUpgrades.text = "Les améliorations sans fin se trouvent en haut de l'arbre de compétences.";
			this.theseUpgradesCanBe.text = "Ces améliorations peuvent être achetées en continu et sont destinées aux joueurs qui souhaitent continuer à jouer après avoir terminé le jeu.";
			LocalizationScript.startMining = "COMMENCEZ À MINER !";
			LocalizationScript.outOfTime = "PLUS DE TEMPS !";
			LocalizationScript.yes = "OUI";
			LocalizationScript.no = "NON";
			this.coolText.text = "COOL";
			LocalizationScript.holdToCraft = "Maintenir pour fabriquer";
			LocalizationScript.clickToEquip = "Cliquer pour équiper";
			this.mainMenu.text = "MENU PRINCIPAL";
			this.exitGame.text = "QUITTER LE JEU";
			this.fullscreen.text = "Plein écran";
			this.resetGame.text = "RÉINITIALISER LE JEU";
			this.areYouSureText.text = "Êtes-vous sûr de vouloir réinitialiser le jeu en entier ?";
			this.thisIsNotText.text = "CECI N'EST PAS UNE MÉCANIQUE DE PRESTIGE !";
			this.pressYesText.text = "Appuyer sur OUI réinitialisera entièrement le jeu.";
			this.resetYes.text = LocalizationScript.yes;
			this.resetNo.text = LocalizationScript.no;
			this.mineTheBigRock.text = "Minez le gros rocher !";
			this.keepOnMining_MainMenu.text = "ALLER MINER !";
			this.revealTalentCards.text = "RÉVÉLER CARTES DE TALENT";
			this.choose1.text = "CHOISISSEZ 1";
			this.allCardsChosen.text = "TOUTES LES CARTES\nDE TALENT SONT CHOISIES";
			this.equipped.text = "Équipé";
			this.mineTime1.text = "<size=31>Temps de minage :";
			this.mineTime2.text = "<size=31>Temps de minage :";
			this.minePower1.text = "<size=31>Puissance de minage :";
			this.minePower2.text = "<size=31>Puissance de minage :";
			this.mine2X1.text = "<size=31>Chance de Puissance 2X :";
			this.mine2X2.text = "<size=31>Chance de Puissance 2X :";
			this.mineSize1.text = "<size=31>Taille de la zone :";
			this.mineSize2.text = "<size=31>Taille de la zone :";
			this.unlockTheMine.text = "DÉBLOQUER LA MINE";
			this.playText.text = "Jouer";
			this.settingsText.text = "Paramètres";
			this.credits.text = "Crédits";
			this.creditsText.text = "Crédits";
			this.exitGameText.text = "Quitter le jeu";
			this.gameBy.text = "Jeu par : EagleEye Games";
			this.musicBy.text = "Musique par : " + LocalizationScript.musicCreditName1;
			this.customArtBy.text = "Art personnalisé par : Artisgamemobile";
			this.skillTree.text = "Arbre de compétences";
			this.talents.text = "Talents";
			this.theAnvil.text = "L'enclume";
			this.theMine.text = "La mine";
			this.artifacts.text = "Artefacts";
			this.endSession.text = "TERMINER SESSION";
			this.miningSessionDone.text = "Session de minage terminée !";
			this.oresGathered.text = "Minerais collectés";
			this.barsCrafted.text = "Lingots créés";
			this.totalBars.text = "Lingots totaux";
			this.xpGathered.text = "XP collectée";
			this.upgrade.text = "AMÉLIORER !";
			this.keepOnMining_endFrame.text = "ALLER MINER !";
			this.theMineTooltipText.text = "Les améliorations de l'arbre de compétences « Valeur du minerai » affectent également les lingots extraits de la Mine !";
		}
		if (LocalizationScript.isItalian)
		{
			this.COMPLETION.text = "COMPLETAMENTO!";
			this.allSkillTree.text = "Tutti i potenziamenti dell'albero abilità sono stati acquistati!";
			this.byHaving.text = "Avendo acquistato tutti i potenziamenti dell'albero abilità, hai sbloccato i POTENZIAMENTI INFINITI.";
			this.theseUpgrades.text = "I potenziamenti infiniti si trovano nella parte superiore dell'albero abilità.";
			this.theseUpgradesCanBe.text = "Questi potenziamenti possono essere acquistati continuamente e sono pensati per i giocatori che vogliono continuare a giocare dopo aver completato il gioco.";
			LocalizationScript.startMining = "INIZIA A MINARE!";
			LocalizationScript.outOfTime = "TEMPO SCADUTO!";
			LocalizationScript.yes = "SÌ";
			LocalizationScript.no = "NO";
			this.coolText.text = "COOL";
			LocalizationScript.holdToCraft = "Tieni premuto per forgiare";
			LocalizationScript.clickToEquip = "Clicca per equipaggiare";
			this.mainMenu.text = "MENU PRINCIPALE";
			this.exitGame.text = "ESCI DAL GIOCO";
			this.fullscreen.text = "Schermo intero";
			this.resetGame.text = "RESETTA IL GIOCO";
			this.areYouSureText.text = "Sei sicuro di voler resettare l'intero gioco?";
			this.thisIsNotText.text = "QUESTO NON È UN MECCANISMO DI PRESTIGIO!";
			this.pressYesText.text = "Premere SÌ reimposterà l'intero gioco dall'inizio.";
			this.resetYes.text = LocalizationScript.yes;
			this.resetNo.text = LocalizationScript.no;
			this.mineTheBigRock.text = "Scava la roccia gigante!";
			this.keepOnMining_MainMenu.text = "VAI A MINARE!";
			this.revealTalentCards.text = "RIVELA CARTE TALENTO";
			this.choose1.text = "SCEGLI 1";
			this.allCardsChosen.text = "TUTTE LE CARTE\nTALENTO SCELTE";
			this.equipped.text = "Equipaggiato";
			this.mineTime1.text = "<size=31>Tempo di scavo:";
			this.mineTime2.text = "<size=31>Tempo di scavo:";
			this.minePower1.text = "<size=31>Potenza di scavo:";
			this.minePower2.text = "<size=31>Potenza di scavo:";
			this.mine2X1.text = "<size=31>Probabilità Potenza 2X:";
			this.mine2X2.text = "<size=31>Probabilità Potenza 2X:";
			this.mineSize1.text = "<size=31>Dimensione area:";
			this.mineSize2.text = "<size=31>Dimensione area:";
			this.unlockTheMine.text = "SBLOCCA LA MINIERA";
			this.playText.text = "Gioca";
			this.settingsText.text = "Impostazioni";
			this.credits.text = "Crediti";
			this.creditsText.text = "Crediti";
			this.exitGameText.text = "Esci dal gioco";
			this.gameBy.text = "Gioco di: EagleEye Games";
			this.musicBy.text = "Musica di: " + LocalizationScript.musicCreditName1;
			this.customArtBy.text = "Arte personalizzata di: Artisgamemobile";
			this.skillTree.text = "Albero abilità";
			this.talents.text = "Talenti";
			this.theAnvil.text = "L'incudine";
			this.theMine.text = "La miniera";
			this.artifacts.text = "Artefatti";
			this.endSession.text = "FINE SESSIONE";
			this.miningSessionDone.text = "Sessione di scavo conclusa!";
			this.oresGathered.text = "Minerali raccolti";
			this.barsCrafted.text = "Lingotti forgiati";
			this.totalBars.text = "Lingotti totali";
			this.xpGathered.text = "XP raccolta";
			this.upgrade.text = "AGGIORNA!";
			this.keepOnMining_endFrame.text = "VAI A MINARE!";
			this.theMineTooltipText.text = "Gli upgrade dell’albero abilità \"Valore del Minerale\" influenzano anche i lingotti estratti dalla Miniera!";
		}
		if (LocalizationScript.isGerman)
		{
			this.COMPLETION.text = "VOLLENDUNG!";
			this.allSkillTree.text = "Alle Verbesserungen des Fertigkeitsbaums wurden gekauft!";
			this.byHaving.text = "Durch den Kauf aller Verbesserungen des Fertigkeitsbaums hast du die ENDLOSEN UPGRADES freigeschaltet.";
			this.theseUpgrades.text = "Die endlosen Upgrades befinden sich oben im Fertigkeitsbaum.";
			this.theseUpgradesCanBe.text = "Diese Upgrades können unbegrenzt gekauft werden und richten sich an Spieler, die nach Abschluss des Spiels weiterspielen möchten.";
			LocalizationScript.startMining = "STARTE ABBAU!";
			LocalizationScript.outOfTime = "ZEIT ABGELAUFEN!";
			LocalizationScript.yes = "JA";
			LocalizationScript.no = "NEIN";
			this.coolText.text = "COOL";
			LocalizationScript.holdToCraft = "Halten zum Schmieden";
			LocalizationScript.clickToEquip = "Klicken zum Ausrüsten";
			this.mainMenu.text = "HAUPTMENÜ";
			this.exitGame.text = "SPIEL BEENDEN";
			this.fullscreen.text = "Vollbild";
			this.resetGame.text = "SPIEL ZURÜCKSETZEN";
			this.areYouSureText.text = "Bist du sicher, dass du das ganze Spiel zurücksetzen willst?";
			this.thisIsNotText.text = "DAS IST KEIN PRESTIGE-MECHANISMUS!";
			this.pressYesText.text = "Wenn du JA drückst, wird das gesamte Spiel neu gestartet.";
			this.resetYes.text = LocalizationScript.yes;
			this.resetNo.text = LocalizationScript.no;
			this.mineTheBigRock.text = "Abbau des großen Felsens!";
			this.keepOnMining_MainMenu.text = "AB IN DIE MINE!";
			this.revealTalentCards.text = "TALENTKARTEN AUFDECKEN";
			this.choose1.text = "WÄHLE 1";
			this.allCardsChosen.text = "ALLE TALENTKARTEN\nGEWÄHLT";
			this.equipped.text = "Ausgerüstet";
			this.mineTime1.text = "Abbauzeit:";
			this.mineTime2.text = "Abbauzeit:";
			this.minePower1.text = "Abbaukraft:";
			this.minePower2.text = "Abbaukraft:";
			this.mine2X1.text = "2X Kraft Chance:";
			this.mine2X2.text = "2X Kraft Chance:";
			this.mineSize1.text = "Abbaugebietsgröße:";
			this.mineSize2.text = "Abbaugebietsgröße:";
			this.unlockTheMine.text = "MINE FREISCHALTEN";
			this.playText.text = "Spielen";
			this.settingsText.text = "Einstellungen";
			this.credits.text = "Credits";
			this.creditsText.text = "Credits";
			this.exitGameText.text = "Spiel beenden";
			this.gameBy.text = "Spiel von: EagleEye Games";
			this.musicBy.text = "Musik von: " + LocalizationScript.musicCreditName1;
			this.customArtBy.text = "Individuelle Kunst von: Artisgamemobile";
			this.skillTree.text = "Fähigkeitsbaum";
			this.talents.text = "Talente";
			this.theAnvil.text = "Der Amboss";
			this.theMine.text = "Die Mine";
			this.artifacts.text = "Artefakte";
			this.endSession.text = "SESSION BEENDEN";
			this.miningSessionDone.text = "Miningsession abgeschlossen!";
			this.oresGathered.text = "Erze gesammelt";
			this.barsCrafted.text = "Barren geschmiedet";
			this.totalBars.text = "Gesamtbarren";
			this.xpGathered.text = "XP gesammelt";
			this.upgrade.text = "AUFRÜSTEN!";
			this.keepOnMining_endFrame.text = "AB IN DIE MINE!";
			this.theMineTooltipText.text = "Die Fertigkeitsbaum-Upgrades \"Erz-Wert\" wirken sich auch auf die in der Mine abgebauten Barren aus!";
		}
		if (LocalizationScript.isSpanish)
		{
			this.COMPLETION.text = "¡COMPLETADO!";
			this.allSkillTree.text = "¡Todas las mejoras del árbol de habilidades han sido compradas!";
			this.byHaving.text = "Al haber comprado todas las mejoras del árbol de habilidades, has desbloqueado las MEJORAS INFINITAS.";
			this.theseUpgrades.text = "Las mejoras infinitas están ubicadas en la parte superior del árbol de habilidades.";
			this.theseUpgradesCanBe.text = "Estas mejoras se pueden comprar continuamente y están pensadas para los jugadores que quieren seguir jugando después de completar el juego.";
			LocalizationScript.startMining = "¡COMIENZA A MINAR!";
			LocalizationScript.outOfTime = "¡SIN TIEMPO!";
			LocalizationScript.yes = "SÍ";
			LocalizationScript.no = "NO";
			this.coolText.text = "GUAY";
			LocalizationScript.holdToCraft = "Mantén para forjar";
			LocalizationScript.clickToEquip = "Haz clic para equipar";
			this.mainMenu.text = "MENÚ PRINCIPAL";
			this.exitGame.text = "SALIR DEL JUEGO";
			this.fullscreen.text = "Pantalla completa";
			this.resetGame.text = "REINICIAR JUEGO";
			this.areYouSureText.text = "¿Estás seguro de que quieres reiniciar todo el juego?";
			this.thisIsNotText.text = "¡ESTO NO ES UN MECÁNICO DE PRESTIGIO!";
			this.pressYesText.text = "Presionar SÍ reiniciará todo el juego desde el principio.";
			this.resetYes.text = LocalizationScript.yes;
			this.resetNo.text = LocalizationScript.no;
			this.mineTheBigRock.text = "¡Mina la gran roca!";
			this.keepOnMining_MainMenu.text = "¡A MINAR!";
			this.revealTalentCards.text = "REVELAR CARTAS DE TALENTO";
			this.choose1.text = "ELIGE 1";
			this.allCardsChosen.text = "TODAS LAS\nCARTAS ELEGIDAS";
			this.equipped.text = "Equipado";
			this.mineTime1.text = "<size=27>Tiempo de minería:";
			this.mineTime2.text = "<size=27>Tiempo de minería:";
			this.minePower1.text = "<size=27>Poder de minería:";
			this.minePower2.text = "<size=27>Poder de minería:";
			this.mine2X1.text = "<size=27>Probabilidad de 2X Poder:";
			this.mine2X2.text = "<size=27>Probabilidad de 2X Poder:";
			this.mineSize1.text = "<size=27>Tamaño del área de minería:";
			this.mineSize2.text = "<size=27>Tamaño del área de minería:";
			this.unlockTheMine.text = "DESBLOQUEAR LA MINA";
			this.playText.text = "Jugar";
			this.settingsText.text = "Configuración";
			this.credits.text = "Créditos";
			this.creditsText.text = "Créditos";
			this.exitGameText.text = "Salir del juego";
			this.gameBy.text = "Juego de: EagleEye Games";
			this.musicBy.text = "Música por: " + LocalizationScript.musicCreditName1;
			this.customArtBy.text = "Arte personalizado por: Artisgamemobile";
			this.skillTree.text = "Árbol de habilidades";
			this.talents.text = "Talentos";
			this.theAnvil.text = "El yunque";
			this.theMine.text = "La mina";
			this.artifacts.text = "Artefactos";
			this.endSession.text = "TERMINAR SESIÓN";
			this.miningSessionDone.text = "¡Sesión de minería terminada!";
			this.oresGathered.text = "Minerales recolectados";
			this.barsCrafted.text = "Lingotes forjados";
			this.totalBars.text = "Lingotes totales";
			this.xpGathered.text = "XP recolectada";
			this.upgrade.text = "MEJORAR!";
			this.keepOnMining_endFrame.text = "¡A MINAR!";
			this.theMineTooltipText.text = "Las mejoras del árbol de habilidades \"Valor del Mineral\" también afectan a los lingotes extraídos de la Mina.";
		}
		if (LocalizationScript.isJapanese)
		{
			this.COMPLETION.text = "完成！";
			this.allSkillTree.text = "すべてのスキルツリーアップグレードを購入しました！";
			this.byHaving.text = "すべてのスキルツリーアップグレードを購入すると、無限アップグレードがアンロックされます。";
			this.theseUpgrades.text = "無限アップグレードはスキルツリーの一番上にあります。";
			this.theseUpgradesCanBe.text = "これらのアップグレードは何度でも購入でき、ゲームクリア後もプレイを続けたいプレイヤー向けです。";
			LocalizationScript.startMining = "採掘開始！";
			LocalizationScript.outOfTime = "時間切れ！";
			LocalizationScript.yes = "はい";
			LocalizationScript.no = "いいえ";
			this.coolText.text = "クール";
			LocalizationScript.holdToCraft = "長押しでクラフト";
			LocalizationScript.clickToEquip = "クリックで装備";
			this.mainMenu.text = "メインメニュー";
			this.exitGame.text = "ゲーム終了";
			this.fullscreen.text = "フルスクリーン";
			this.resetGame.text = "ゲームをリセット";
			this.areYouSureText.text = "本当にゲーム全体をリセットしますか？";
			this.thisIsNotText.text = "これはプレステージ要素ではありません！";
			this.pressYesText.text = "「はい」を押すとゲームが最初からリセットされます。";
			this.resetYes.text = LocalizationScript.yes;
			this.resetNo.text = LocalizationScript.no;
			this.mineTheBigRock.text = "巨大な岩を採掘！";
			this.keepOnMining_MainMenu.text = "採掘開始！";
			this.revealTalentCards.text = "タレントカードを公開";
			this.choose1.text = "1枚選択";
			this.allCardsChosen.text = "すべてのカードを選択済み";
			this.equipped.text = "装備中";
			this.mineTime1.text = "採掘時間:";
			this.mineTime2.text = "採掘時間:";
			this.minePower1.text = "採掘パワー:";
			this.minePower2.text = "採掘パワー:";
			this.mine2X1.text = "2Xパワー確率:";
			this.mine2X2.text = "2Xパワー確率:";
			this.mineSize1.text = "採掘エリアサイズ:";
			this.mineSize2.text = "採掘エリアサイズ:";
			this.unlockTheMine.text = "マインをアンロック";
			this.playText.text = "プレイ";
			this.settingsText.text = "設定";
			this.credits.text = "クレジット";
			this.creditsText.text = "クレジット";
			this.exitGameText.text = "ゲーム終了";
			this.gameBy.text = "制作: EagleEye Games";
			this.musicBy.text = "音楽: " + LocalizationScript.musicCreditName1;
			this.customArtBy.text = "カスタムアート: Artisgamemobile";
			this.skillTree.text = "スキルツリー";
			this.talents.text = "タレント";
			this.theAnvil.text = "金床";
			this.theMine.text = "鉱山";
			this.artifacts.text = "アーティファクト";
			this.endSession.text = "セッション終了";
			this.miningSessionDone.text = "採掘セッション完了！";
			this.oresGathered.text = "鉱石獲得";
			this.barsCrafted.text = "インゴット作成";
			this.totalBars.text = "合計インゴット";
			this.xpGathered.text = "XP獲得";
			this.upgrade.text = "アップグレード！";
			this.keepOnMining_endFrame.text = "採掘開始！";
			this.theMineTooltipText.text = "「鉱石の価値」スキルツリーのアップグレードは、鉱山で得られるインゴットにも影響します！";
		}
		if (LocalizationScript.isKorean)
		{
			this.COMPLETION.text = "완료!";
			this.allSkillTree.text = "모든 스킬 트리 업그레이드를 구매했습니다!";
			this.byHaving.text = "모든 스킬 트리 업그레이드를 구매하면 무한 업그레이드가 잠금 해제됩니다.";
			this.theseUpgrades.text = "무한 업그레이드는 스킬 트리의 맨 위에 있습니다.";
			this.theseUpgradesCanBe.text = "이 업그레이드는 계속해서 구매할 수 있으며, 게임 완료 후에도 계속 플레이하고 싶은 플레이어를 위한 것입니다.";
			LocalizationScript.startMining = "채굴 시작!";
			LocalizationScript.outOfTime = "시간 종료!";
			LocalizationScript.yes = "예";
			LocalizationScript.no = "아니오";
			this.coolText.text = "OK";
			LocalizationScript.holdToCraft = "길게 눌러 제작";
			LocalizationScript.clickToEquip = "클릭하여 장착";
			this.mainMenu.text = "메인 메뉴";
			this.exitGame.text = "게임 종료";
			this.fullscreen.text = "전체 화면";
			this.resetGame.text = "게임 초기화";
			this.areYouSureText.text = "정말로 게임을 초기화하시겠습니까?";
			this.thisIsNotText.text = "이것은 프레스티지 시스템이 아닙니다!";
			this.pressYesText.text = "예를 누르면 게임이 처음부터 초기화됩니다.";
			this.resetYes.text = LocalizationScript.yes;
			this.resetNo.text = LocalizationScript.no;
			this.mineTheBigRock.text = "큰 바위를 채굴하세요!";
			this.keepOnMining_MainMenu.text = "채굴하러 가자!";
			this.revealTalentCards.text = "탈렌트 카드 공개";
			this.choose1.text = "1개 선택";
			this.allCardsChosen.text = "모든 탈렌트 카드 선택됨";
			this.equipped.text = "장착됨";
			this.mineTime1.text = "채굴 시간:";
			this.mineTime2.text = "채굴 시간:";
			this.minePower1.text = "채굴 파워:";
			this.minePower2.text = "채굴 파워:";
			this.mine2X1.text = "2X 파워 확률:";
			this.mine2X2.text = "2X 파워 확률:";
			this.mineSize1.text = "채굴 영역 크기:";
			this.mineSize2.text = "채굴 영역 크기:";
			this.unlockTheMine.text = "마인 열기";
			this.playText.text = "플레이";
			this.settingsText.text = "설정";
			this.credits.text = "크레딧";
			this.creditsText.text = "크레딧";
			this.exitGameText.text = "게임 종료";
			this.gameBy.text = "제작: EagleEye Games";
			this.musicBy.text = "음악: " + LocalizationScript.musicCreditName1;
			this.customArtBy.text = "커스텀 아트: Artisgamemobile";
			this.skillTree.text = "스킬 트리";
			this.talents.text = "탈렌트";
			this.theAnvil.text = "모루";
			this.theMine.text = "광산";
			this.artifacts.text = "유물";
			this.endSession.text = "세션 종료";
			this.miningSessionDone.text = "채굴 세션 완료!";
			this.oresGathered.text = "채굴된 광석";
			this.barsCrafted.text = "제작된 바";
			this.totalBars.text = "총 바 수";
			this.xpGathered.text = "획득 XP";
			this.upgrade.text = "업그레이드!";
			this.keepOnMining_endFrame.text = "채굴하러 가자!";
			this.theMineTooltipText.text = "\"광석 가치\" 스킬 트리 업그레이드는 광산에서 채굴한 바에도 적용됩니다!";
		}
		if (LocalizationScript.isPolish)
		{
			this.COMPLETION.text = "UKOŃCZENIE!";
			this.allSkillTree.text = "Wszystkie ulepszenia drzewa umiejętności zostały zakupione!";
			this.byHaving.text = "Po zakupieniu wszystkich ulepszeń drzewa umiejętności odblokowałeś NIESKOŃCZONE ULEPSZENIA.";
			this.theseUpgrades.text = "Nieskończone ulepszenia znajdują się na górze drzewa umiejętności.";
			this.theseUpgradesCanBe.text = "Ulepszenia te można kupować bez końca i są przeznaczone dla graczy, którzy chcą kontynuować grę po jej ukończeniu.";
			LocalizationScript.startMining = "ZACZNIJ KOPAĆ!";
			LocalizationScript.outOfTime = "KONIEC CZASU!";
			LocalizationScript.yes = "TAK";
			LocalizationScript.no = "NIE";
			this.coolText.text = "FAJNE";
			LocalizationScript.holdToCraft = "Przytrzymaj, aby stworzyć";
			LocalizationScript.clickToEquip = "Kliknij, aby wyposażyć";
			this.mainMenu.text = "MENU GŁÓWNE";
			this.exitGame.text = "WYJDŹ Z GRY";
			this.fullscreen.text = "Pełny ekran";
			this.resetGame.text = "RESETUJ GRĘ";
			this.areYouSureText.text = "Czy na pewno chcesz zresetować całą grę?";
			this.thisIsNotText.text = "TO NIE JEST MECHANIKA PRESTIŻU!";
			this.pressYesText.text = "Kliknięcie TAK zresetuje całą grę od początku.";
			this.resetYes.text = LocalizationScript.yes;
			this.resetNo.text = LocalizationScript.no;
			this.mineTheBigRock.text = "Wydobądź wielką skałę!";
			this.keepOnMining_MainMenu.text = "IDŹ KOPAĆ!";
			this.revealTalentCards.text = "ODKRYJ KARTY TALENTÓW";
			this.choose1.text = "WYBIERZ 1";
			this.allCardsChosen.text = "WSZYSTKIE KARTY\nTALENTÓW WYBRANE";
			this.equipped.text = "Wyposażono";
			this.mineTime1.text = "Czas wydobycia:";
			this.mineTime2.text = "Czas wydobycia:";
			this.minePower1.text = "Moc wydobycia:";
			this.minePower2.text = "Moc wydobycia:";
			this.mine2X1.text = "Szansa na 2X Moc:";
			this.mine2X2.text = "Szansa na 2X Moc:";
			this.mineSize1.text = "Rozmiar obszaru:";
			this.mineSize2.text = "Rozmiar obszaru:";
			this.unlockTheMine.text = "ODKRYJ KOPALNIĘ";
			this.playText.text = "Graj";
			this.settingsText.text = "Ustawienia";
			this.credits.text = "Twórcy";
			this.creditsText.text = "Twórcy";
			this.exitGameText.text = "Wyjdź z gry";
			this.gameBy.text = "Gra od: EagleEye Games";
			this.musicBy.text = "Muzyka: " + LocalizationScript.musicCreditName1;
			this.customArtBy.text = "Grafika: Artisgamemobile";
			this.skillTree.text = "Drzewko umiejętności";
			this.talents.text = "Talenty";
			this.theAnvil.text = "Kowadło";
			this.theMine.text = "Kopalnia";
			this.artifacts.text = "Artefakty";
			this.endSession.text = "ZAKOŃCZ SESJĘ";
			this.miningSessionDone.text = "Sesja wydobycia zakończona!";
			this.oresGathered.text = "Zebrane rudy";
			this.barsCrafted.text = "Wykute sztabki";
			this.totalBars.text = "Łączna liczba sztabek";
			this.xpGathered.text = "Zebrane XP";
			this.upgrade.text = "ULEPSZ!";
			this.keepOnMining_endFrame.text = "IDŹ KOPAĆ!";
			this.theMineTooltipText.text = "Ulepszenia z drzewa umiejętności „Wartość Rudy” wpływają także na sztabki wydobyte w Kopalni!";
		}
		if (LocalizationScript.isPortugese)
		{
			this.COMPLETION.text = "CONCLUSÃO!";
			this.allSkillTree.text = "Todas as melhorias da árvore de habilidades foram compradas!";
			this.byHaving.text = "Ao comprar todas as melhorias da árvore de habilidades, você desbloqueou as MELHORIAS INFINITAS.";
			this.theseUpgrades.text = "As melhorias infinitas estão localizadas no topo da árvore de habilidades.";
			this.theseUpgradesCanBe.text = "Essas melhorias podem ser compradas continuamente e são destinadas a jogadores que desejam continuar jogando após a conclusão do jogo.";
			LocalizationScript.startMining = "COMECE A MINERAR!";
			LocalizationScript.outOfTime = "TEMPO ESGOTADO!";
			LocalizationScript.yes = "SIM";
			LocalizationScript.no = "NÃO";
			this.coolText.text = "LEGAL";
			LocalizationScript.holdToCraft = "Segure para forjar";
			LocalizationScript.clickToEquip = "Clique para equipar";
			this.mainMenu.text = "MENU PRINCIPAL";
			this.exitGame.text = "SAIR DO JOGO";
			this.fullscreen.text = "Tela cheia";
			this.resetGame.text = "REINICIAR JOGO";
			this.areYouSureText.text = "Tem certeza que deseja reiniciar todo o jogo?";
			this.thisIsNotText.text = "ISSO NÃO É UMA MECÂNICA DE PRESTÍGIO!";
			this.pressYesText.text = "Clicar em SIM reiniciará o jogo do início.";
			this.resetYes.text = LocalizationScript.yes;
			this.resetNo.text = LocalizationScript.no;
			this.mineTheBigRock.text = "Mine a grande rocha!";
			this.keepOnMining_MainMenu.text = "VÁ MINERAR!";
			this.revealTalentCards.text = "REVELAR CARTAS DE TALENTO";
			this.choose1.text = "ESCOLHA 1";
			this.allCardsChosen.text = "TODAS AS CARTAS\nESCOLHIDAS";
			this.equipped.text = "Equipado";
			this.mineTime1.text = "Tempo de mineração:";
			this.mineTime2.text = "Tempo de mineração:";
			this.minePower1.text = "Poder de mineração:";
			this.minePower2.text = "Poder de mineração:";
			this.mine2X1.text = "Chance de 2X Poder:";
			this.mine2X2.text = "Chance de 2X Poder:";
			this.mineSize1.text = "Tamanho da área:";
			this.mineSize2.text = "Tamanho da área:";
			this.unlockTheMine.text = "DESBLOQUEAR A MINA";
			this.playText.text = "Jogar";
			this.settingsText.text = "Configurações";
			this.credits.text = "Créditos";
			this.creditsText.text = "Créditos";
			this.exitGameText.text = "Sair do jogo";
			this.gameBy.text = "Jogo por: EagleEye Games";
			this.musicBy.text = "Música por: " + LocalizationScript.musicCreditName1;
			this.customArtBy.text = "Arte customizada por: Artisgamemobile";
			this.skillTree.text = "Árvore de habilidades";
			this.talents.text = "Talentos";
			this.theAnvil.text = "A bigorna";
			this.theMine.text = "A mina";
			this.artifacts.text = "Artefatos";
			this.endSession.text = "ENCERRAR SESSÃO";
			this.miningSessionDone.text = "Sessão de mineração concluída!";
			this.oresGathered.text = "Minérios coletados";
			this.barsCrafted.text = "Barras forjadas";
			this.totalBars.text = "Total de barras";
			this.xpGathered.text = "XP coletado";
			this.upgrade.text = "UPGRADE!";
			this.keepOnMining_endFrame.text = "VÁ MINERAR!";
			this.theMineTooltipText.text = "As melhorias da árvore de habilidades \"Valor do Minério\" também afetam as barras extraídas da Mina!";
		}
		if (LocalizationScript.isRussian)
		{
			this.COMPLETION.text = "ЗАВЕРШЕНИЕ!";
			this.allSkillTree.text = "Все улучшения древа навыков были приобретены!";
			this.byHaving.text = "Приобретя все улучшения древа навыков, вы открыли БЕСКОНЕЧНЫЕ УЛУЧШЕНИЯ.";
			this.theseUpgrades.text = "Бесконечные улучшения находятся в верхней части древа навыков.";
			this.theseUpgradesCanBe.text = "Эти улучшения можно покупать бесконечно, и они предназначены для игроков, которые хотят продолжать играть после завершения игры.";
			LocalizationScript.startMining = "НАЧАТЬ ДОБЫЧУ!";
			LocalizationScript.outOfTime = "ВРЕМЯ ВЫШЛО!";
			LocalizationScript.yes = "ДА";
			LocalizationScript.no = "НЕТ";
			this.coolText.text = "КРУТО";
			LocalizationScript.holdToCraft = "Удерживайте, чтобы создать";
			LocalizationScript.clickToEquip = "Кликните, чтобы экипировать";
			this.mainMenu.text = "ГЛАВНОЕ МЕНЮ";
			this.exitGame.text = "ВЫХОД ИЗ ИГРЫ";
			this.fullscreen.text = "Полный экран";
			this.resetGame.text = "СБРОСИТЬ ИГРУ";
			this.areYouSureText.text = "Вы уверены, что хотите сбросить всю игру?";
			this.thisIsNotText.text = "ЭТО НЕ ПРЕСТИЖ-МЕХАНИКА!";
			this.pressYesText.text = "Нажав ДА, вы сбросите игру полностью.";
			this.resetYes.text = LocalizationScript.yes;
			this.resetNo.text = LocalizationScript.no;
			this.mineTheBigRock.text = "Добыть большой камень!";
			this.keepOnMining_MainMenu.text = "ВПЕРЁД ДОБЫВАТЬ!";
			this.revealTalentCards.text = "ПОКАЗАТЬ КАРТЫ ТАЛАНТОВ";
			this.choose1.text = "ВЫБРАТЬ 1";
			this.allCardsChosen.text = "ВСЕ КАРТЫ\nТАЛАНТОВ ВЫБРАНЫ";
			this.equipped.text = "Экипировано";
			this.mineTime1.text = "Время добычи:";
			this.mineTime2.text = "Время добычи:";
			this.minePower1.text = "Сила добычи:";
			this.minePower2.text = "Сила добычи:";
			this.mine2X1.text = "Шанс 2X силы:";
			this.mine2X2.text = "Шанс 2X силы:";
			this.mineSize1.text = "Размер области:";
			this.mineSize2.text = "Размер области:";
			this.unlockTheMine.text = "РАЗБЛОКИРОВАТЬ ШАХТУ";
			this.playText.text = "Играть";
			this.settingsText.text = "Настройки";
			this.credits.text = "Авторы";
			this.creditsText.text = "Авторы";
			this.exitGameText.text = "Выйти из игры";
			this.gameBy.text = "Игра от: EagleEye Games";
			this.musicBy.text = "Музыка: " + LocalizationScript.musicCreditName1;
			this.customArtBy.text = "Кастом арт: Artisgamemobile";
			this.skillTree.text = "Дерево навыков";
			this.talents.text = "Таланты";
			this.theAnvil.text = "Наковальня";
			this.theMine.text = "Шахта";
			this.artifacts.text = "Артефакты";
			this.endSession.text = "ЗАВЕРШИТЬ СЕССИЮ";
			this.miningSessionDone.text = "Сессия добычи завершена!";
			this.oresGathered.text = "Собрано руды";
			this.barsCrafted.text = "Слитков изготовлено";
			this.totalBars.text = "Всего слитков";
			this.xpGathered.text = "Собрано XP";
			this.upgrade.text = "УЛУЧШИТЬ!";
			this.keepOnMining_endFrame.text = "ВПЕРЁД ДОБЫВАТЬ!";
			this.theMineTooltipText.text = "Улучшения в древе навыков «Ценность руды» также влияют на слитки, добытые в Шахте!";
		}
		if (LocalizationScript.isSimplefiedChinese)
		{
			this.COMPLETION.text = "完成！";
			this.allSkillTree.text = "所有技能树升级已购买！";
			this.byHaving.text = "购买所有技能树升级后，你将解锁无限升级。";
			this.theseUpgrades.text = "无限升级位于技能树的最上方。";
			this.theseUpgradesCanBe.text = "这些升级可以无限购买，适合在通关后仍想继续游戏的玩家。";
			LocalizationScript.startMining = "开始挖矿！";
			LocalizationScript.outOfTime = "时间耗尽！";
			LocalizationScript.yes = "是";
			LocalizationScript.no = "否";
			this.coolText.text = "好的";
			LocalizationScript.holdToCraft = "按住以锻造";
			LocalizationScript.clickToEquip = "点击装备";
			this.mainMenu.text = "主菜单";
			this.exitGame.text = "退出游戏";
			this.fullscreen.text = "全屏";
			this.resetGame.text = "重置游戏";
			this.areYouSureText.text = "你确定要重置整个游戏吗？";
			this.thisIsNotText.text = "这不是一个声望系统！";
			this.pressYesText.text = "点击“是”会将整个游戏重置到最初状态。";
			this.resetYes.text = LocalizationScript.yes;
			this.resetNo.text = LocalizationScript.no;
			this.mineTheBigRock.text = "开采大岩石！";
			this.keepOnMining_MainMenu.text = "开始挖矿！";
			this.revealTalentCards.text = "揭示天赋卡";
			this.choose1.text = "选择 1 张";
			this.allCardsChosen.text = "所有天赋卡已选择";
			this.equipped.text = "已装备";
			this.mineTime1.text = "采矿时间:";
			this.mineTime2.text = "采矿时间:";
			this.minePower1.text = "采矿力量:";
			this.minePower2.text = "采矿力量:";
			this.mine2X1.text = "2X 力量几率:";
			this.mine2X2.text = "2X 力量几率:";
			this.mineSize1.text = "采矿区域大小:";
			this.mineSize2.text = "采矿区域大小:";
			this.unlockTheMine.text = "解锁矿井";
			this.playText.text = "开始游戏";
			this.settingsText.text = "设置";
			this.credits.text = "制作人员";
			this.creditsText.text = "制作人员";
			this.exitGameText.text = "退出游戏";
			this.gameBy.text = "游戏制作: EagleEye Games";
			this.musicBy.text = "音乐: " + LocalizationScript.musicCreditName1;
			this.customArtBy.text = "美术: Artisgamemobile";
			this.skillTree.text = "技能树";
			this.talents.text = "天赋";
			this.theAnvil.text = "铁砧";
			this.theMine.text = "矿井";
			this.artifacts.text = "神器";
			this.endSession.text = "结束挖矿";
			this.miningSessionDone.text = "挖矿已完成！";
			this.oresGathered.text = "已收集矿石";
			this.barsCrafted.text = "已锻造锭";
			this.totalBars.text = "锭总数";
			this.xpGathered.text = "已获得XP";
			this.upgrade.text = "升级！";
			this.keepOnMining_endFrame.text = "开始挖矿！";
			this.theMineTooltipText.text = "“矿石价值”技能树的升级同样会影响矿井中获得的锭！";
		}
		this.levelUpSessionDone.text = LocalizationScript.levelUp;
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0001B734 File Offset: 0x00019934
	public void TutText()
	{
		if (LocalizationScript.isEnglish)
		{
			LocalizationScript.ok = "OK";
			this.artifactsTut.text = "Artifacts!";
			this.hereYouCanView.text = "Here you can view all found artifacts.";
			this.artifactsHave.text = "Artifacts have a small chance to be attached to a rock.";
			this.everyArtifact.text = "Every artifact will provide you with a passive buff.";
			this.theMineTut.text = "The Mine!";
			this.onceYouHave.text = "Once you have purchased The Mine, it will automatically mine rocks for you.";
			this.theMineWill.text = "The Mine will mine bars instead of ores.";
			this.thePercentage.text = "The percentages above the total bars frames to the left displays the chance The Mine has to mine that type of material.";
			this.theAnvilTut.text = "The Anvil!";
			this.hereYouCan.text = "Here you can craft new pickaxes!";
			this.eachPickaxe.text = "Each pickaxe needs a specific type of material to be crafted.";
			this.eachNew.text = "Each new pickaxe has different pickaxe stats. The pickaxe stats can also be increased via the Skill Tree upgrades.";
			this.oreAndBars.text = "Material ores and bars!";
			this.youWill.text = "You will receive ores from mining rocks.";
			this.thereAre.text = "There are 3 types of rocks that can spawn. Normal rocks, chunk rocks and full material rocks.";
			this.normalRocks.text = "Normal rocks will always drop 1 gold ore. Chunk rocks drop 3 and full material rocks drop 7.";
			this.oresWillBe.text = "Ores will automatically be crafted into bars. It takes 3 ores to craft 1 bar. If you have 1 or 2 extra ores left over, you will craft 1 extra bar. Example: 10 mined ores will craft 4 bars.";
			this.welcomeTo.text = "Welcome to Keep on Mining!";
			this.theGameIsSimple.text = "The game is simple. Once a mining session starts, hover over rocks to mine them.";
			this.onceThe.text = "Once the top right timer reaches 0, the mining session ends.";
			if (!MobileAndTesting.isMobile)
			{
				this.aCircle.text = "A circle will follow your cursor, this is the mining area. Rocks inside the mining area will spawn pickaxes that mine for you.";
			}
			else
			{
				this.aCircle.text = "A circle will follow your where you tap the screen, this is the mining area. Rocks inside the mining area will spawn pickaxes that mine for you.";
			}
			this.levelAndTalent.text = "Level up and talent cards!";
			this.everyMined.text = "Every mined rock will provide you with XP.";
			this.youWillReceive.text = "You will receive 1 talent point when leveling up.";
			this.youCanSpend.text = "You can spend your talent points to reveal the talent cards. You can choose 1 out of 3 talent cards.";
			if (!MobileAndTesting.isMobile)
			{
				this.talentCardsProvide.text = "Talent cards provide you with cool and permanent buffs. Once a talent card is chosen, your talent level will increase, this increases the rock durability by 2. You can hover over the talent level text to see the current rock durability.";
			}
			else
			{
				this.talentCardsProvide.text = "Talent cards provide you with cool and permanent buffs. Once a talent card is chosen, your talent level will increase, this increases the rock durability by 2. You can tap the talent level text to see the current rock durability.";
			}
		}
		if (LocalizationScript.isFrench)
		{
			LocalizationScript.ok = "OK";
			this.artifactsTut.text = "Artefacts !";
			this.hereYouCanView.text = "Ici, vous pouvez voir tous les artefacts trouvés.";
			this.artifactsHave.text = "Les artefacts ont une petite chance d'être attachés à une roche.";
			this.everyArtifact.text = "Chaque artefact vous donne un bonus passif.";
			this.theMineTut.text = "La Mine !";
			this.onceYouHave.text = "Une fois que vous avez acheté la Mine, elle extraira automatiquement des roches pour vous.";
			this.theMineWill.text = "La Mine extraira des lingots au lieu de minerais.";
			this.thePercentage.text = "Les pourcentages au-dessus des cadres de lingots à gauche indiquent la chance qu’a la Mine d’extraire ce matériau.";
			this.theAnvilTut.text = "L'Enclume !";
			this.hereYouCan.text = "Ici, vous pouvez forger de nouvelles pioches !";
			this.eachPickaxe.text = "Chaque pioche nécessite un matériau spécifique pour être forgée.";
			this.eachNew.text = "Chaque nouvelle pioche a des stats différentes. Les stats peuvent être améliorées via l'Arbre de Compétences.";
			this.oreAndBars.text = "Minerais et lingots !";
			this.youWill.text = "Vous recevrez des minerais en extrayant des roches.";
			this.thereAre.text = "Il existe 3 types de roches : normales, morceaux et roches pleines.";
			this.normalRocks.text = "Les roches normales donnent toujours 1 minerai d'or. Les morceaux en donnent 3 et les roches pleines en donnent 7.";
			this.oresWillBe.text = "Les minerais seront automatiquement transformés en lingots. 3 minerais = 1 lingot. Avec 1 ou 2 minerais restants, vous fabriquez 1 lingot de plus. Exemple : 10 minerais donnent 4 lingots.";
			this.welcomeTo.text = "Bienvenue dans Keep on Mining!";
			this.theGameIsSimple.text = "Le jeu est simple. Une fois la session lancée, survolez les roches pour les extraire.";
			if (!MobileAndTesting.isMobile)
			{
				this.aCircle.text = "Un cercle suit votre curseur : c’est votre zone de minage. Les roches à l’intérieur génèrent des pioches.";
			}
			else
			{
				this.aCircle.text = "Un cercle suivra l’endroit où vous touchez l’écran, c’est la zone de minage. Les roches à l’intérieur de cette zone feront apparaître des pioches qui mineront pour vous.";
			}
			this.onceThe.text = "Une fois le chrono en haut à droite à 0, la session se termine.";
			this.levelAndTalent.text = "Montez de niveau et cartes de talent !";
			this.everyMined.text = "Chaque roche extraite vous donne de l’XP.";
			this.youWillReceive.text = "Vous recevez 1 point de talent à chaque niveau.";
			this.youCanSpend.text = "Vous pouvez utiliser vos points pour révéler des cartes talent et en choisir 1 sur 3.";
			this.talentCardsProvide.text = "Les cartes talent donnent des bonus permanents. Chaque carte augmente votre niveau de talent, ce qui augmente la durabilité des roches de 2. Survolez le niveau de talent pour voir la durabilité actuelle.";
		}
		if (LocalizationScript.isItalian)
		{
			LocalizationScript.ok = "OK";
			this.artifactsTut.text = "Artefatti!";
			this.hereYouCanView.text = "Qui puoi vedere tutti gli artefatti trovati.";
			this.artifactsHave.text = "Gli artefatti hanno una piccola possibilità di essere attaccati a una roccia.";
			this.everyArtifact.text = "Ogni artefatto fornisce un bonus passivo.";
			this.theMineTut.text = "La Miniera!";
			this.onceYouHave.text = "Quando acquisti la Miniera, minerà automaticamente rocce per te.";
			this.theMineWill.text = "La Miniera estrae lingotti invece di minerali.";
			this.thePercentage.text = "Le percentuali sopra i riquadri dei lingotti a sinistra mostrano la possibilità della Miniera di estrarre quel materiale.";
			this.theAnvilTut.text = "L'Incudine!";
			this.hereYouCan.text = "Qui puoi forgiare nuove picconi!";
			this.eachPickaxe.text = "Ogni piccone richiede un materiale specifico per essere creato.";
			this.eachNew.text = "Ogni nuovo piccone ha statistiche diverse. Le statistiche possono essere aumentate tramite l'Albero Abilità.";
			this.oreAndBars.text = "Minerali e lingotti!";
			this.youWill.text = "Ricevi minerali estraendo rocce.";
			this.thereAre.text = "Ci sono 3 tipi di rocce: normali, a pezzi e piene di materiale.";
			this.normalRocks.text = "Le rocce normali danno sempre 1 minerale d'oro. Le rocce a pezzi ne danno 3 e quelle piene ne danno 7.";
			this.oresWillBe.text = "I minerali vengono trasformati in lingotti. 3 minerali = 1 lingotto. Con 1 o 2 minerali extra si crea 1 lingotto aggiuntivo. Esempio: 10 minerali = 4 lingotti.";
			this.welcomeTo.text = "Benvenuto in Keep on Mining!";
			this.theGameIsSimple.text = "Il gioco è semplice. All'inizio di una sessione, passa sopra le rocce per estrarle.";
			if (!MobileAndTesting.isMobile)
			{
				this.aCircle.text = "Un cerchio segue il cursore: è la tua area di miniera. Le rocce all’interno generano picconi.";
			}
			else
			{
				this.aCircle.text = "Un cerchio seguirà il punto in cui tocchi lo schermo, questa è l’area di estrazione. Le rocce all’interno dell’area faranno comparire picconi che mineranno per te.";
			}
			this.onceThe.text = "Quando il timer in alto a destra arriva a 0, la sessione termina.";
			this.levelAndTalent.text = "Livelli e carte talento!";
			this.everyMined.text = "Ogni roccia estratta ti dà XP.";
			this.youWillReceive.text = "Ricevi 1 punto talento a ogni livello.";
			this.youCanSpend.text = "Puoi spendere i punti talento per rivelare carte talento e sceglierne 1 su 3.";
			this.talentCardsProvide.text = "Le carte talento danno bonus permanenti. Ogni carta aumenta il livello talento, aumentando la durevolezza delle rocce di 2. Passa sopra il livello per vedere la durevolezza.";
		}
		if (LocalizationScript.isGerman)
		{
			LocalizationScript.ok = "OK";
			this.artifactsTut.text = "Artefakte!";
			this.hereYouCanView.text = "Hier kannst du alle gefundenen Artefakte ansehen.";
			this.artifactsHave.text = "Artefakte können mit einer kleinen Chance an einem Felsen sein.";
			this.everyArtifact.text = "Jedes Artefakt gibt dir einen passiven Bonus.";
			this.theMineTut.text = "Die Mine!";
			this.onceYouHave.text = "Sobald du die Mine gekauft hast, baut sie automatisch für dich ab.";
			this.theMineWill.text = "Die Mine fördert Barren anstelle von Erzen.";
			this.thePercentage.text = "Die Prozentsätze über den Barren-Frames links zeigen die Chance der Mine, dieses Material zu fördern.";
			this.theAnvilTut.text = "Der Amboss!";
			this.hereYouCan.text = "Hier kannst du neue Spitzhacken schmieden!";
			this.eachPickaxe.text = "Jede Spitzhacke benötigt ein spezielles Material.";
			this.eachNew.text = "Jede neue Spitzhacke hat eigene Werte. Diese können über den Skilltree verbessert werden.";
			this.oreAndBars.text = "Erze und Barren!";
			this.youWill.text = "Du erhältst Erze beim Abbau von Felsen.";
			this.thereAre.text = "Es gibt 3 Arten von Felsen: normal, Brocken und voll.";
			this.normalRocks.text = "Normale Felsen geben immer 1 Gold-Erz. Brocken geben 3, volle Felsen 7.";
			this.oresWillBe.text = "Erze werden automatisch zu Barren verarbeitet. 3 Erze = 1 Barren. Hast du 1-2 übrig, wird 1 extra Barren erstellt. Beispiel: 10 Erze = 4 Barren.";
			this.welcomeTo.text = "Willkommen bei Keep on Mining!";
			this.theGameIsSimple.text = "Das Spiel ist einfach: Bewege den Mauszeiger über Felsen, um sie abzubauen.";
			if (!MobileAndTesting.isMobile)
			{
				this.aCircle.text = "Ein Kreis folgt deinem Cursor – das ist dein Abbaugebiet. Felsen darin spawnen Spitzhacken.";
			}
			else
			{
				this.aCircle.text = "Ein Kreis folgt der Stelle, an der du den Bildschirm berührst – dies ist das Abbaugebiet. Felsen innerhalb dieses Bereichs lassen Spitzhacken erscheinen, die für dich abbauen.";
			}
			this.onceThe.text = "Wenn der Timer oben rechts bei 0 ist, endet die Session.";
			this.levelAndTalent.text = "Level und Talentkarten!";
			this.everyMined.text = "Jeder abgebaute Felsen gibt dir XP.";
			this.youWillReceive.text = "Pro Level erhältst du 1 Talentpunkt.";
			this.youCanSpend.text = "Du kannst Punkte ausgeben, um Talentkarten aufzudecken und 1 von 3 zu wählen.";
			this.talentCardsProvide.text = "Talentkarten geben dauerhafte Boni. Jede Karte erhöht dein Talentlevel, was die Haltbarkeit der Felsen um 2 erhöht. Fahre über den Talentlevel, um es zu sehen.";
		}
		if (LocalizationScript.isSpanish)
		{
			LocalizationScript.ok = "OK";
			this.artifactsTut.text = "¡Artefactos!";
			this.hereYouCanView.text = "Aquí puedes ver todos los artefactos encontrados.";
			this.artifactsHave.text = "Los artefactos tienen una pequeña probabilidad de estar dentro de una roca.";
			this.everyArtifact.text = "Cada artefacto te dará una mejora pasiva.";
			this.theMineTut.text = "¡La Mina!";
			this.onceYouHave.text = "Cuando compras la Mina, minará automáticamente rocas por ti.";
			this.theMineWill.text = "La Mina extrae lingotes en lugar de minerales.";
			this.thePercentage.text = "Los porcentajes sobre los cuadros de lingotes a la izquierda muestran la probabilidad de la Mina de minar ese material.";
			this.theAnvilTut.text = "¡El Yunque!";
			this.hereYouCan.text = "Aquí puedes forjar nuevas picas.";
			this.eachPickaxe.text = "Cada pica necesita un tipo de material específico para forjarse.";
			this.eachNew.text = "Cada nueva pica tiene estadísticas distintas. Puedes mejorarlas desde el Árbol de Habilidades.";
			this.oreAndBars.text = "¡Minerales y lingotes!";
			this.youWill.text = "Recibirás minerales al minar rocas.";
			this.thereAre.text = "Hay 3 tipos de rocas: normales, rocas con fragmentos y rocas completamente de material.";
			this.normalRocks.text = "Las rocas normales siempre dan 1 mineral de oro. Las de fragmentos dan 3 y las completas dan 7.";
			this.oresWillBe.text = "Los minerales se convierten automáticamente en lingotes. 3 minerales = 1 lingote. Si tienes 1 o 2 minerales de sobra, obtendrás 1 lingote extra. Ejemplo: 10 minerales = 4 lingotes.";
			this.welcomeTo.text = "¡Bienvenido a Keep on Mining!";
			this.theGameIsSimple.text = "El juego es sencillo. Cuando empiece la sesión, pasa el cursor sobre las rocas para minarlas.";
			if (!MobileAndTesting.isMobile)
			{
				this.aCircle.text = "Un círculo sigue tu cursor: esa es tu área de minado. Las rocas dentro del área generan picas.";
			}
			else
			{
				this.aCircle.text = "Un círculo seguirá el lugar donde toques la pantalla, esta es el área de minería. Las rocas dentro del área generarán picos que minarán por ti.";
			}
			this.onceThe.text = "Cuando el temporizador llegue a 0, la sesión de minería termina.";
			this.levelAndTalent.text = "¡Sube de nivel y cartas de talento!";
			this.everyMined.text = "Cada roca minada te da XP.";
			this.youWillReceive.text = "Recibirás 1 punto de talento al subir de nivel.";
			this.youCanSpend.text = "Puedes usar puntos para revelar cartas de talento y elegir 1 de 3.";
			this.talentCardsProvide.text = "Las cartas de talento dan mejoras permanentes. Cada carta aumenta tu nivel de talento, subiendo la durabilidad de las rocas en 2. Pasa el cursor sobre el nivel para ver la durabilidad.";
		}
		if (LocalizationScript.isJapanese)
		{
			LocalizationScript.ok = "OK";
			this.artifactsTut.text = "アーティファクト！";
			this.hereYouCanView.text = "ここでは見つけたアーティファクトを確認できます。";
			this.artifactsHave.text = "アーティファクトは岩にくっついている可能性があります。";
			this.everyArtifact.text = "すべてのアーティファクトはパッシブ効果を提供します。";
			this.theMineTut.text = "マイン！";
			this.onceYouHave.text = "マインを購入すると、自動的に岩を採掘してくれます。";
			this.theMineWill.text = "マインは鉱石ではなくバーを採掘します。";
			this.thePercentage.text = "左側のバー合計の上に表示されているパーセンテージは、マインがその素材を採掘する確率です。";
			this.theAnvilTut.text = "金床！";
			this.hereYouCan.text = "ここでは新しいピッケルを作れます！";
			this.eachPickaxe.text = "各ピッケルには特定の素材が必要です。";
			this.eachNew.text = "新しいピッケルには異なるステータスがあります。スキルツリーで強化可能です。";
			this.oreAndBars.text = "鉱石とバー！";
			this.youWill.text = "岩を採掘すると鉱石を獲得できます。";
			this.thereAre.text = "3種類の岩が出現します：通常の岩、塊の岩、完全素材の岩です。";
			this.normalRocks.text = "通常の岩は必ず金鉱石を1つ落とします。塊の岩は3つ、完全素材の岩は7つ落とします。";
			this.oresWillBe.text = "鉱石は自動でバーに精製されます。3つの鉱石で1バーが作られます。1～2個余っていても1バー作られます。例：鉱石10個 → バー4個。";
			this.welcomeTo.text = "Keep on Mining! へようこそ！";
			this.theGameIsSimple.text = "ゲームはシンプルです。採掘セッションが始まったら、カーソルを岩に当てて採掘します。";
			if (!MobileAndTesting.isMobile)
			{
				this.aCircle.text = "カーソルの周りに円が表示されます。これが採掘エリアです。エリア内の岩は自動でピッケルが採掘してくれます。";
			}
			else
			{
				this.aCircle.text = "画面をタップした場所に円が追従します。これが採掘エリアです。採掘エリア内の岩からは、あなたの代わりに採掘するツルハシが出現します。";
			}
			this.onceThe.text = "右上のタイマーが0になると採掘セッションは終了です。";
			this.levelAndTalent.text = "レベルアップとタレントカード！";
			this.everyMined.text = "岩を採掘するとXPがもらえます。";
			this.youWillReceive.text = "レベルアップすると1ポイントのタレントポイントを獲得できます。";
			this.youCanSpend.text = "タレントポイントを使ってカードを開き、3枚から1枚を選びます。";
			this.talentCardsProvide.text = "タレントカードは強力で恒久的な効果を与えます。選択するとタレントレベルが上がり、岩の耐久度が2増加します。タレントレベルにカーソルを当てると現在の耐久度が見れます。";
		}
		if (LocalizationScript.isKorean)
		{
			LocalizationScript.ok = "OK";
			this.artifactsTut.text = "유물!";
			this.hereYouCanView.text = "여기서 발견한 모든 유물을 확인할 수 있습니다.";
			this.artifactsHave.text = "유물은 바위에 붙어 있을 확률이 작게 있습니다.";
			this.everyArtifact.text = "모든 유물은 영구적인 버프를 제공합니다.";
			this.theMineTut.text = "마인!";
			this.onceYouHave.text = "마인을 구매하면 자동으로 바위를 채굴합니다.";
			this.theMineWill.text = "마인은 광석 대신 바를 채굴합니다.";
			this.thePercentage.text = "왼쪽의 바 총량 위에 있는 확률은 마인이 해당 자원을 채굴할 확률입니다.";
			this.theAnvilTut.text = "모루!";
			this.hereYouCan.text = "여기서 새로운 곡괭이를 제작할 수 있습니다!";
			this.eachPickaxe.text = "각 곡괭이는 제작에 필요한 특정 자원이 있습니다.";
			this.eachNew.text = "새 곡괭이는 각기 다른 스탯을 가지고 있으며, 스킬 트리 업그레이드로 강화할 수 있습니다.";
			this.oreAndBars.text = "광석과 바!";
			this.youWill.text = "바위를 채굴하면 광석을 획득합니다.";
			this.thereAre.text = "바위는 일반 바위, 덩어리 바위, 완전 자원 바위의 3종류가 있습니다.";
			this.normalRocks.text = "일반 바위는 항상 금광석 1개를 줍니다. 덩어리 바위는 3개, 완전 자원 바위는 7개를 줍니다.";
			this.oresWillBe.text = "광석은 자동으로 바가 됩니다. 3개의 광석이 1개의 바로 제작됩니다. 1~2개의 잉여 광석이 있으면 1개의 추가 바가 만들어집니다. 예: 광석 10개 → 바 4개.";
			this.welcomeTo.text = "Keep on Mining!에 오신 것을 환영합니다!";
			this.theGameIsSimple.text = "게임은 간단합니다. 채굴 세션이 시작되면 커서를 바위 위에 올려 채굴하세요.";
			if (!MobileAndTesting.isMobile)
			{
				this.aCircle.text = "커서를 따라 원이 움직입니다. 이 원이 채굴 구역이며, 구역 안의 바위는 곡괭이가 자동으로 채굴합니다.";
			}
			else
			{
				this.aCircle.text = "화면을 터치한 곳을 따라 원이 이동하며, 이것이 채굴 구역입니다. 채굴 구역 안의 바위에서는 곡괭이가 생성되어 대신 채굴해 줍니다.";
			}
			this.onceThe.text = "우측 상단의 타이머가 0이 되면 채굴 세션이 종료됩니다.";
			this.levelAndTalent.text = "레벨업과 탈렌트 카드!";
			this.everyMined.text = "채굴한 바위마다 XP를 얻습니다.";
			this.youWillReceive.text = "레벨업 시 1개의 탈렌트 포인트를 획득합니다.";
			this.youCanSpend.text = "탈렌트 포인트로 카드를 열어 3장 중 1장을 선택할 수 있습니다.";
			this.talentCardsProvide.text = "탈렌트 카드는 강력하고 영구적인 버프를 제공합니다. 선택하면 탈렌트 레벨이 오르고, 바위 내구도가 2 증가합니다. 탈렌트 레벨에 마우스를 올리면 현재 내구도를 볼 수 있습니다.";
		}
		if (LocalizationScript.isPolish)
		{
			LocalizationScript.ok = "OK";
			this.artifactsTut.text = "Artefakty!";
			this.hereYouCanView.text = "Tutaj możesz zobaczyć wszystkie znalezione artefakty.";
			this.artifactsHave.text = "Artefakty mają małą szansę być w środku skały.";
			this.everyArtifact.text = "Każdy artefakt daje pasywny bonus.";
			this.theMineTut.text = "Kopalnia!";
			this.onceYouHave.text = "Po zakupie Kopalnia automatycznie wydobywa skały za ciebie.";
			this.theMineWill.text = "Kopalnia wydobywa sztabki zamiast rud.";
			this.thePercentage.text = "Procenty nad ramkami sztabek po lewej pokazują szansę Kopalni na wydobycie danego materiału.";
			this.theAnvilTut.text = "Kowadło!";
			this.hereYouCan.text = "Tutaj możesz tworzyć nowe kilofy!";
			this.eachPickaxe.text = "Każdy kilof wymaga konkretnego materiału do stworzenia.";
			this.eachNew.text = "Każdy nowy kilof ma inne statystyki. Statystyki możesz zwiększyć w Drzewku Umiejętności.";
			this.oreAndBars.text = "Rudy i sztabki!";
			this.youWill.text = "Otrzymujesz rudy z wydobywania skał.";
			this.thereAre.text = "Są 3 typy skał: normalne, kawałkowe i pełne skały materiałowe.";
			this.normalRocks.text = "Normalne skały zawsze dają 1 rudę złota. Kawałkowe dają 3, a pełne 7.";
			this.oresWillBe.text = "Rudy automatycznie przerabiane są na sztabki. 3 rudy = 1 sztabka. Jeśli zostanie 1–2 rudy, powstanie dodatkowa sztabka. Przykład: 10 rud = 4 sztabki.";
			this.welcomeTo.text = "Witamy w Keep on Mining!";
			this.theGameIsSimple.text = "Gra jest prosta. Gdy sesja się zacznie, najedź kursorem na skały, by je wydobywać.";
			if (!MobileAndTesting.isMobile)
			{
				this.aCircle.text = "Kółko podąża za kursorem – to strefa wydobycia. Skały w środku będą wydobywane przez kilofy.";
			}
			else
			{
				this.aCircle.text = "Okrąg będzie podążał za miejscem, w którym dotkniesz ekranu – to jest obszar wydobycia. Skały wewnątrz tego obszaru wygenerują kilofy, które będą dla ciebie kopać.";
			}
			this.onceThe.text = "Gdy licznik w prawym górnym rogu dojdzie do zera, sesja się kończy.";
			this.levelAndTalent.text = "Poziomy i karty talentów!";
			this.everyMined.text = "Każda wydobyta skała daje XP.";
			this.youWillReceive.text = "Po awansie dostajesz 1 punkt talentu.";
			this.youCanSpend.text = "Punkty talentu wydajesz, by odkryć karty i wybrać 1 z 3.";
			this.talentCardsProvide.text = "Karty talentów dają trwałe bonusy. Każda karta podnosi twój poziom talentu, zwiększając wytrzymałość skał o 2. Najedź na poziom talentu, by sprawdzić wytrzymałość.";
		}
		if (LocalizationScript.isPortugese)
		{
			LocalizationScript.ok = "OK";
			this.artifactsTut.text = "Artefatos!";
			this.hereYouCanView.text = "Aqui você pode ver todos os artefatos encontrados.";
			this.artifactsHave.text = "Os artefatos têm uma pequena chance de estar dentro de uma rocha.";
			this.everyArtifact.text = "Cada artefato fornece um bônus passivo.";
			this.theMineTut.text = "A Mina!";
			this.onceYouHave.text = "Quando você compra a Mina, ela minerará rochas automaticamente para você.";
			this.theMineWill.text = "A Mina minera barras em vez de minérios.";
			this.thePercentage.text = "As porcentagens acima dos quadros de barras à esquerda mostram a chance da Mina minerar cada tipo de material.";
			this.theAnvilTut.text = "A Bigorna!";
			this.hereYouCan.text = "Aqui você pode forjar novas picaretas!";
			this.eachPickaxe.text = "Cada picareta precisa de um tipo específico de material para ser forjada.";
			this.eachNew.text = "Cada nova picareta tem estatísticas diferentes. As estatísticas podem ser melhoradas pela Árvore de Habilidades.";
			this.oreAndBars.text = "Minérios e barras!";
			this.youWill.text = "Você recebe minérios ao minerar rochas.";
			this.thereAre.text = "Existem 3 tipos de rochas: normais, com fragmentos e rochas totalmente de material.";
			this.normalRocks.text = "Rochas normais sempre soltam 1 minério de ouro. Rochas com fragmentos soltam 3 e rochas completas soltam 7.";
			this.oresWillBe.text = "Os minérios são automaticamente forjados em barras. 3 minérios = 1 barra. Se você tiver 1 ou 2 extras, ainda forja 1 barra a mais. Exemplo: 10 minérios = 4 barras.";
			this.welcomeTo.text = "Bem-vindo ao Keep on Mining!";
			this.theGameIsSimple.text = "O jogo é simples. Quando a sessão começar, passe o cursor sobre as rochas para minerar.";
			if (!MobileAndTesting.isMobile)
			{
				this.aCircle.text = "Um círculo seguirá o cursor — essa é sua área de mineração. Rochas dentro dela geram picaretas automaticamente.";
			}
			else
			{
				this.aCircle.text = "Um círculo seguirá o local onde você tocar na tela, esta é a área de mineração. As rochas dentro da área farão surgir picaretas que mineram para você.";
			}
			this.onceThe.text = "Quando o cronômetro no canto superior direito chegar a 0, a sessão termina.";
			this.levelAndTalent.text = "Suba de nível e use cartas de talento!";
			this.everyMined.text = "Cada rocha minerada fornece XP.";
			this.youWillReceive.text = "Você recebe 1 ponto de talento ao subir de nível.";
			this.youCanSpend.text = "Você pode gastar pontos para revelar cartas de talento e escolher 1 entre 3.";
			this.talentCardsProvide.text = "As cartas de talento dão bônus permanentes. Cada carta aumenta seu nível de talento, o que aumenta a durabilidade das rochas em 2. Passe o cursor sobre o nível de talento para ver a durabilidade atual.";
		}
		if (LocalizationScript.isRussian)
		{
			LocalizationScript.ok = "OK";
			this.artifactsTut.text = "Артефакты!";
			this.hereYouCanView.text = "Здесь вы можете просмотреть все найденные артефакты.";
			this.artifactsHave.text = "Артефакты могут быть с небольшой вероятностью внутри камня.";
			this.everyArtifact.text = "Каждый артефакт даёт вам пассивный бонус.";
			this.theMineTut.text = "Шахта!";
			this.onceYouHave.text = "После покупки Шахта будет автоматически добывать камни за вас.";
			this.theMineWill.text = "Шахта добывает слитки вместо руды.";
			this.thePercentage.text = "Проценты над рамками слитков слева показывают шанс Шахты добыть этот материал.";
			this.theAnvilTut.text = "Наковальня!";
			this.hereYouCan.text = "Здесь можно создавать новые кирки!";
			this.eachPickaxe.text = "Каждая кирка требует особый материал для создания.";
			this.eachNew.text = "Каждая новая кирка имеет свои характеристики. Их можно улучшать через Дерево Умений.";
			this.oreAndBars.text = "Руда и слитки!";
			this.youWill.text = "Вы получаете руду, добывая камни.";
			this.thereAre.text = "Существует 3 типа камней: обычные, с включениями и полностью из материала.";
			this.normalRocks.text = "Обычные камни всегда дают 1 золотую руду. Камни с включениями — 3, полностью из материала — 7.";
			this.oresWillBe.text = "Руда автоматически переплавляется в слитки. 3 руды = 1 слиток. Если остаётся 1–2 руды, создается ещё 1 слиток. Пример: 10 руды = 4 слитка.";
			this.welcomeTo.text = "Добро пожаловать в Keep on Mining!";
			this.theGameIsSimple.text = "Игра проста. Когда начинается сессия, наведите курсор на камни, чтобы их добывать.";
			if (!MobileAndTesting.isMobile)
			{
				this.aCircle.text = "Вокруг курсора будет круг — это область добычи. Камни внутри круга автоматически добываются кирками.";
			}
			else
			{
				this.aCircle.text = "Круг будет следовать за местом, где вы коснулись экрана — это зона добычи. Камни внутри этой зоны будут создавать кирки, которые добывают за вас.";
			}
			this.onceThe.text = "Когда таймер в правом верхнем углу дойдет до нуля, сессия завершается.";
			this.levelAndTalent.text = "Уровень и карты талантов!";
			this.everyMined.text = "Каждый добытый камень даёт XP.";
			this.youWillReceive.text = "При повышении уровня вы получаете 1 очко таланта.";
			this.youCanSpend.text = "Вы можете потратить очки, чтобы открыть карты и выбрать 1 из 3.";
			this.talentCardsProvide.text = "Карты талантов дают постоянные бонусы. Каждая карта увеличивает уровень таланта и прочность камней на 2. Наведите курсор на уровень таланта, чтобы увидеть прочность.";
		}
		if (LocalizationScript.isSimplefiedChinese)
		{
			LocalizationScript.ok = "好的";
			this.artifactsTut.text = "神器！";
			this.hereYouCanView.text = "你可以在这里查看所有已找到的神器。";
			this.artifactsHave.text = "神器有小概率附着在石头上。";
			this.everyArtifact.text = "每个神器都会提供一个被动增益效果。";
			this.theMineTut.text = "矿井！";
			this.onceYouHave.text = "购买矿井后，它会自动为你开采石头。";
			this.theMineWill.text = "矿井直接开采锭而不是矿石。";
			this.thePercentage.text = "左侧总锭数量框上方的百分比显示矿井开采该材料的概率。";
			this.theAnvilTut.text = "铁砧！";
			this.hereYouCan.text = "你可以在这里打造新的镐！";
			this.eachPickaxe.text = "每把镐需要特定材料才能打造。";
			this.eachNew.text = "每把新镐都有不同的属性，可通过技能树升级进一步提升。";
			this.oreAndBars.text = "矿石与锭！";
			this.youWill.text = "采矿石时，你会获得矿石。";
			this.thereAre.text = "游戏中有三种石头：普通石、矿块石和纯矿石。";
			this.normalRocks.text = "普通石头总是掉落1个金矿石，矿块石掉落3个，纯矿石掉落7个。";
			this.oresWillBe.text = "矿石会自动锻造成锭。3个矿石 = 1个锭。如果余下1–2个矿石，也会额外锻造1个锭。示例：10个矿石 = 4个锭。";
			this.welcomeTo.text = "欢迎来到 Keep on Mining!";
			this.theGameIsSimple.text = "玩法很简单。矿工开始后，将鼠标悬停在石头上即可开采。";
			if (!MobileAndTesting.isMobile)
			{
				this.aCircle.text = "光标周围有一个圆圈，这是采矿范围。范围内的石头会自动生成镐来帮你开采。";
			}
			else
			{
				this.aCircle.text = "一个圆圈会跟随你点击屏幕的位置，这就是采矿区域。采矿区域内的岩石会生成镐子来为你挖矿。";
			}
			this.onceThe.text = "右上角的计时器归零时，采矿阶段结束。";
			this.levelAndTalent.text = "升级与天赋卡！";
			this.everyMined.text = "每采矿石可获得 XP。";
			this.youWillReceive.text = "每次升级可获得1点天赋点数。";
			this.youCanSpend.text = "你可以使用天赋点数解锁天赋卡，并从3张卡中选择1张。";
			this.talentCardsProvide.text = "天赋卡提供永久性增益。选择后，天赋等级会提升，石头耐久度增加2点。将鼠标悬停在天赋等级上可查看当前耐久度。";
		}
		this.okArtifacts.text = LocalizationScript.ok;
		this.okTheMine.text = LocalizationScript.ok;
		this.okTheAnvil.text = LocalizationScript.ok;
		this.okTalent.text = LocalizationScript.ok;
		this.okWelcomeTo.text = LocalizationScript.ok;
		this.ok_materialOres.text = LocalizationScript.ok;
		this.ok_EndlessOpoUP.text = LocalizationScript.ok;
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0001CB9C File Offset: 0x0001AD9C
	public void EndingTexts()
	{
		if (LocalizationScript.isEnglish)
		{
			this.craftPickaxe.text = "Craft Pickaxe";
			this.youCraftedDiamond.text = "<wave>You crafted the Diamond Pickaxe!</wave>";
			this.thankYOuForPlaying.text = "<wave>Thank you for playing:</wave>";
			this.developedByEnd.text = "Developed by: EagleEye Games";
			this.musicByEnd.text = "Music by: " + LocalizationScript.musicCreditName1;
			this.customArtByEnd.text = "Custom art by: Artisgamemobile";
			this.againThankYou.text = "Again, thank you for playing Keep on Mining!";
			this.aSteamReview.text = "A steam review with your thoughts of the game would be much appreciated :)";
			this.alsoJoin.text = "Also join our Discord and check out more games from EagleEye Games!! :)\n(The icons can be clicked)";
			this.whatWouldDoNext.text = "What would you like to do next?";
			this.exitGameCredits.text = "Exit Game";
			this.keepOnMiningCredits.text = "Keep on Mining!";
		}
		if (LocalizationScript.isFrench)
		{
			this.craftPickaxe.text = "Forger une pioche";
			this.youCraftedDiamond.text = "<wave>Vous avez forgé la Pioche en diamant !</wave>";
			this.thankYOuForPlaying.text = "<wave>Merci d'avoir joué :</wave>";
			this.developedByEnd.text = "Développé par : EagleEye Games";
			this.musicByEnd.text = "Musique par : " + LocalizationScript.musicCreditName1;
			this.customArtByEnd.text = "Art personnalisé par : Artisgamemobile";
			this.againThankYou.text = "Encore merci d'avoir joué à Keep on Mining!";
			this.aSteamReview.text = "Un avis Steam avec vos impressions serait grandement apprécié :)";
			this.alsoJoin.text = "Rejoignez aussi notre Discord et découvrez d'autres jeux de EagleEye Games !! :)\n(Les icônes sont cliquables)";
			this.whatWouldDoNext.text = "Que souhaitez-vous faire ensuite ?";
			this.exitGameCredits.text = "Quitter le jeu";
			this.keepOnMiningCredits.text = "ALLER MINER !";
		}
		if (LocalizationScript.isItalian)
		{
			this.craftPickaxe.text = "Crea una piccone";
			this.youCraftedDiamond.text = "<wave>Hai creato il Piccone di Diamante!</wave>";
			this.thankYOuForPlaying.text = "<wave>Grazie per aver giocato:</wave>";
			this.developedByEnd.text = "Sviluppato da: EagleEye Games";
			this.musicByEnd.text = "Musica di: " + LocalizationScript.musicCreditName1;
			this.customArtByEnd.text = "Arte personalizzata di: Artisgamemobile";
			this.againThankYou.text = "Ancora una volta, grazie per aver giocato a Keep on Mining!";
			this.aSteamReview.text = "Una recensione su Steam con le tue opinioni sarebbe molto apprezzata :)";
			this.alsoJoin.text = "Unisciti anche al nostro Discord e scopri altri giochi di EagleEye Games!! :)\n(Le icone sono cliccabili)";
			this.whatWouldDoNext.text = "Cosa vuoi fare ora?";
			this.exitGameCredits.text = "Esci dal gioco";
			this.keepOnMiningCredits.text = "VAI A MINARE!";
		}
		if (LocalizationScript.isGerman)
		{
			this.craftPickaxe.text = "Spitzhacke schmieden";
			this.youCraftedDiamond.text = "<wave>Du hast die Diamant-Spitzhacke geschmiedet!</wave>";
			this.thankYOuForPlaying.text = "<wave>Danke fürs Spielen:</wave>";
			this.developedByEnd.text = "Entwickelt von: EagleEye Games";
			this.musicByEnd.text = "Musik von: " + LocalizationScript.musicCreditName1;
			this.customArtByEnd.text = "Individuelle Kunst von: Artisgamemobile";
			this.againThankYou.text = "Nochmals vielen Dank, dass du Keep on Mining! gespielt hast!";
			this.aSteamReview.text = "Eine Steam-Rezension mit deinen Gedanken zum Spiel wäre sehr willkommen :)";
			this.alsoJoin.text = "Tritt auch unserem Discord bei und entdecke weitere Spiele von EagleEye Games!! :)\n(Die Symbole sind anklickbar)";
			this.whatWouldDoNext.text = "Was möchtest du als Nächstes tun?";
			this.exitGameCredits.text = "Spiel beenden";
			this.keepOnMiningCredits.text = "AB IN DIE MINE!";
		}
		if (LocalizationScript.isSpanish)
		{
			this.craftPickaxe.text = "Forjar pico";
			this.youCraftedDiamond.text = "<wave>¡Has forjado el Pico de Diamante!</wave>";
			this.thankYOuForPlaying.text = "<wave>Gracias por jugar:</wave>";
			this.developedByEnd.text = "Desarrollado por: EagleEye Games";
			this.musicByEnd.text = "Música por: " + LocalizationScript.musicCreditName1;
			this.customArtByEnd.text = "Arte personalizado por: Artisgamemobile";
			this.againThankYou.text = "Una vez más, gracias por jugar a Keep on Mining!";
			this.aSteamReview.text = "Una reseña en Steam con tu opinión sería muy apreciada :)";
			this.alsoJoin.text = "Únete a nuestro Discord y descubre más juegos de EagleEye Games!! :)\n(Los iconos son clicables)";
			this.whatWouldDoNext.text = "¿Qué te gustaría hacer ahora?";
			this.exitGameCredits.text = "Salir del juego";
			this.keepOnMiningCredits.text = "¡A MINAR!";
		}
		if (LocalizationScript.isJapanese)
		{
			this.craftPickaxe.text = "ピッケルを作る";
			this.youCraftedDiamond.text = "<wave>ダイヤモンドピッケルを作りました！</wave>";
			this.thankYOuForPlaying.text = "<wave>プレイしてくれてありがとう：</wave>";
			this.developedByEnd.text = "開発: EagleEye Games";
			this.musicByEnd.text = "音楽: " + LocalizationScript.musicCreditName1;
			this.customArtByEnd.text = "カスタムアート: Artisgamemobile";
			this.againThankYou.text = "改めて、Keep on Mining! をプレイしてくれてありがとう！";
			this.aSteamReview.text = "Steamで感想を書いていただけるととても嬉しいです :)";
			this.alsoJoin.text = "ぜひDiscordに参加して、他のEagleEye Gamesのゲームもチェックしてください！！ :)\n（アイコンはクリックできます）";
			this.whatWouldDoNext.text = "次は何をしますか？";
			this.exitGameCredits.text = "ゲーム終了";
			this.keepOnMiningCredits.text = "採掘開始！";
		}
		if (LocalizationScript.isKorean)
		{
			this.craftPickaxe.text = "곡괭이 제작";
			this.youCraftedDiamond.text = "<wave>다이아몬드 곡괭이를 제작했습니다!</wave>";
			this.thankYOuForPlaying.text = "<wave>플레이해 주셔서 감사합니다:</wave>";
			this.developedByEnd.text = "개발: EagleEye Games";
			this.musicByEnd.text = "음악: " + LocalizationScript.musicCreditName1;
			this.customArtByEnd.text = "커스텀 아트: Artisgamemobile";
			this.againThankYou.text = "다시 한 번, Keep on Mining! 을 플레이해 주셔서 감사합니다!";
			this.aSteamReview.text = "Steam 리뷰로 게임에 대한 생각을 남겨주시면 큰 힘이 됩니다 :)";
			this.alsoJoin.text = "Discord에도 참여하고 EagleEye Games의 다른 게임도 확인해 보세요!! :)\n(아이콘은 클릭할 수 있습니다)";
			this.whatWouldDoNext.text = "이제 무엇을 하시겠습니까?";
			this.exitGameCredits.text = "게임 종료";
			this.keepOnMiningCredits.text = "채굴하러 가자!";
		}
		if (LocalizationScript.isPolish)
		{
			this.craftPickaxe.text = "Stwórz kilof";
			this.youCraftedDiamond.text = "<wave>Stworzyłeś Diamentowy Kilof!</wave>";
			this.thankYOuForPlaying.text = "<wave>Dzięki za grę:</wave>";
			this.developedByEnd.text = "Twórca: EagleEye Games";
			this.musicByEnd.text = "Muzyka: " + LocalizationScript.musicCreditName1;
			this.customArtByEnd.text = "Grafika: Artisgamemobile";
			this.againThankYou.text = "Jeszcze raz dzięki za grę w Keep on Mining!";
			this.aSteamReview.text = "Recenzja na Steamie z twoją opinią byłaby super mile widziana :)";
			this.alsoJoin.text = "Dołącz też na naszego Discorda i sprawdź inne gry od EagleEye Games!! :)\n(Ikony są klikalne)";
			this.whatWouldDoNext.text = "Co chcesz zrobić teraz?";
			this.exitGameCredits.text = "Wyjdź z gry";
			this.keepOnMiningCredits.text = "IDŹ KOPAĆ!";
		}
		if (LocalizationScript.isPortugese)
		{
			this.craftPickaxe.text = "Forjar Picareta";
			this.youCraftedDiamond.text = "<wave>Você forjou a Picareta de Diamante!</wave>";
			this.thankYOuForPlaying.text = "<wave>Obrigado por jogar:</wave>";
			this.developedByEnd.text = "Desenvolvido por: EagleEye Games";
			this.musicByEnd.text = "Música por: " + LocalizationScript.musicCreditName1;
			this.customArtByEnd.text = "Arte customizada por: Artisgamemobile";
			this.againThankYou.text = "Mais uma vez, obrigado por jogar Keep on Mining!";
			this.aSteamReview.text = "Uma avaliação na Steam com sua opinião sobre o jogo seria muito bem-vinda :)";
			this.alsoJoin.text = "Junte-se também ao nosso Discord e conheça mais jogos da EagleEye Games!! :)\n(Os ícones são clicáveis)";
			this.whatWouldDoNext.text = "O que você quer fazer agora?";
			this.exitGameCredits.text = "Sair do jogo";
			this.keepOnMiningCredits.text = "VÁ MINERAR!";
		}
		if (LocalizationScript.isRussian)
		{
			this.craftPickaxe.text = "Создать кирку";
			this.youCraftedDiamond.text = "<wave>Вы создали Алмазную Кирку!</wave>";
			this.thankYOuForPlaying.text = "<wave>Спасибо за игру:</wave>";
			this.developedByEnd.text = "Разработано: EagleEye Games";
			this.musicByEnd.text = "Музыка: " + LocalizationScript.musicCreditName1;
			this.customArtByEnd.text = "Кастом арт: Artisgamemobile";
			this.againThankYou.text = "Снова спасибо, что играли в Keep on Mining!";
			this.aSteamReview.text = "Будем очень признательны за отзыв в Steam с вашими впечатлениями :)";
			this.alsoJoin.text = "Также присоединяйтесь к нашему Discord и смотрите другие игры от EagleEye Games!! :)\n(Иконки можно кликать)";
			this.whatWouldDoNext.text = "Что хотите сделать дальше?";
			this.exitGameCredits.text = "Выйти из игры";
			this.keepOnMiningCredits.text = "ВПЕРЁД ДОБЫВАТЬ!";
		}
		if (LocalizationScript.isSimplefiedChinese)
		{
			this.craftPickaxe.text = "锻造镐";
			this.youCraftedDiamond.text = "<wave>你锻造了钻石镐！</wave>";
			this.thankYOuForPlaying.text = "<wave>感谢游玩：</wave>";
			this.developedByEnd.text = "开发者: EagleEye Games";
			this.musicByEnd.text = "音乐: " + LocalizationScript.musicCreditName1;
			this.customArtByEnd.text = "美术: Artisgamemobile";
			this.againThankYou.text = "再次感谢你游玩 Keep on Mining!";
			this.aSteamReview.text = "如果能在Steam上留下你的评论，我们会非常感激 :)";
			this.alsoJoin.text = "欢迎加入我们的Discord并探索更多 EagleEye Games 的游戏！！ :)\n（图标可点击）";
			this.whatWouldDoNext.text = "接下来你想做什么？";
			this.exitGameCredits.text = "退出游戏";
			this.keepOnMiningCredits.text = "开始挖矿！";
		}
	}

	// Token: 0x06000132 RID: 306 RVA: 0x0001D4C8 File Offset: 0x0001B6C8
	public void StatsText()
	{
		if (LocalizationScript.isEnglish)
		{
			this.talentStats.text = "Talent Stats";
			this.globalStats.text = "Global Stats";
			this.rocksMinedStats.text = "Rocks Mined Stats";
			this.potionsDrank.text = "Potions drank:";
			this.chestsOpened.text = "Regular chests opened:";
			this.goldenChestsOpened.text = "Golden chests opened:";
			this.theMine2XTriggered.text = "The Mine 2X speed triggers:";
			this.theMineDoubleTriggered.text = "The Mine double ore triggers:";
			this.inflateBurstTriggered.text = "Inflate Burst triggers:";
			this.hammersSpawned.text = "Hammers spawned:";
			this.midasTouchSessions.text = "Midas touch sessions:";
			this.zeusTriggers.text = "Zeus triggers:";
			this.energiDrinksDrank.text = "Energy drinks drank:";
			this.flowersSpawned.text = "Flowers spawned:";
			this.campfiresSpawned.text = "Campfires spawned:";
			this.d100Rolls.text = "D100, total 1, 10 or 100 rolls:";
			this.miningSessions.text = "Mining sessions:";
			this.timeSpentMining.text = "Time spent mining:";
			this.totalRocksSpawned.text = "Total rocks spawned:";
			this.totalRocksMined.text = "Total rocks mined:";
			this.pickaxeSpawned.text = "Pickaxes spawned:";
			this.pickaxeHits.text = "Pickaxe hits:";
			this.oresMined.text = "Ores mined:";
			this.barsBrafted.text = "Bars crafted:";
			this.bardMinedTheMine.text = "Bars mined (The Mine)";
			this.xpGained.text = "XP gained:";
			this.totalLevelUps.text = "Total level ups:";
			this.doubleXpGained.text = "Double XP gained:";
			this.doubleOredGained.text = "Double ores gained:";
			this.X2pickaxePowerHits.text = "2X pickaxe power hits:";
			this.instaMineHits.text = "Insta mine pickaxe hits:";
			this.lightningStrikes.text = "Lightning strikes:";
			this.dynamiteExplosions.text = "Dynamite explosions:";
			this.plazmaBallsSpawned.text = "Plazma balls spawned:";
			this.goldChunkRocks.text = "Golden chunk rocks:";
			this.fullGoldRocks.text = "Full gold rocks:";
			this.copperChunkMined.text = "Copper chunk rocks:";
			this.fullCopperMined.text = "Full copper rocks:";
			this.ironChunkMined.text = "Iron chunk rocks:";
			this.fullIronMined.text = "Full iron rocks:";
			this.cobaltChunkMined.text = "Cobalt chunk rocks:";
			this.fullCobaltMined.text = "Full cobalt rocks:";
			this.uraniumChunkMined.text = "Uranium chunk rocks:";
			this.fullUraniumMined.text = "Full uranium rocks:";
			this.ismiumChunkMined.text = "Ismium chunk rocks:";
			this.fullIsmiumMined.text = "Full ismium rocks:";
			this.iridiumChunkMined.text = "Iridium chunk rocks:";
			this.fullIridiumMined.text = "Full iridium rocks:";
			this.painiteChunkMined.text = "Painite chunk rocks:";
			this.fullPainiteMined.text = "Full painite rocks:";
		}
		if (LocalizationScript.isFrench)
		{
			this.talentStats.text = "Stats de talent";
			this.globalStats.text = "Stats globales";
			this.rocksMinedStats.text = "Stats de roches minées";
			this.potionsDrank.text = "Potions bues :";
			this.chestsOpened.text = "Coffres normaux ouverts :";
			this.goldenChestsOpened.text = "Coffres dorés ouverts :";
			this.theMine2XTriggered.text = "Déclenchements 2X vitesse (La Mine) :";
			this.theMineDoubleTriggered.text = "Déclenchements double minerai (La Mine) :";
			this.inflateBurstTriggered.text = "Déclenchements d’Inflate Burst :";
			this.hammersSpawned.text = "Marteaux apparus :";
			this.midasTouchSessions.text = "Sessions Midas Touch :";
			this.zeusTriggers.text = "Déclenchements de Zeus :";
			this.energiDrinksDrank.text = "Boissons énergétiques bues :";
			this.flowersSpawned.text = "Fleurs apparues :";
			this.campfiresSpawned.text = "Feux de camp apparus :";
			this.d100Rolls.text = "D100, total de lancers de 1, 10 ou 100 :";
			this.miningSessions.text = "Sessions de minage :";
			this.timeSpentMining.text = "Temps passé à miner :";
			this.totalRocksSpawned.text = "Total de roches apparues :";
			this.totalRocksMined.text = "Total de roches minées :";
			this.pickaxeSpawned.text = "Pioches apparues :";
			this.pickaxeHits.text = "Coups de pioche :";
			this.oresMined.text = "Minerais minés :";
			this.barsBrafted.text = "Lingots forgés :";
			this.bardMinedTheMine.text = "Lingots minés (La Mine) :";
			this.xpGained.text = "XP gagnée :";
			this.totalLevelUps.text = "Total de niveaux gagnés :";
			this.doubleXpGained.text = "XP doublée gagnée :";
			this.doubleOredGained.text = "Minerais doublés gagnés :";
			this.X2pickaxePowerHits.text = "Coups de pioche 2X puissance :";
			this.instaMineHits.text = "Coups de pioche Insta Mine :";
			this.lightningStrikes.text = "Foudres frappées :";
			this.dynamiteExplosions.text = "Explosions de dynamite :";
			this.plazmaBallsSpawned.text = "Boules de plasma apparues :";
			this.goldChunkRocks.text = "Roches dorées (morceaux) :";
			this.fullGoldRocks.text = "Roches dorées complètes :";
			this.copperChunkMined.text = "Roches de cuivre (morceaux) :";
			this.fullCopperMined.text = "Roches de cuivre complètes :";
			this.ironChunkMined.text = "Roches de fer (morceaux) :";
			this.fullIronMined.text = "Roches de fer complètes :";
			this.cobaltChunkMined.text = "Roches de cobalt (morceaux) :";
			this.fullCobaltMined.text = "Roches de cobalt complètes :";
			this.uraniumChunkMined.text = "Roches d’uranium (morceaux) :";
			this.fullUraniumMined.text = "Roches d’uranium complètes :";
			this.ismiumChunkMined.text = "Roches d’ismium (morceaux) :";
			this.fullIsmiumMined.text = "Roches d’ismium complètes :";
			this.iridiumChunkMined.text = "Roches d’iridium (morceaux) :";
			this.fullIridiumMined.text = "Roches d’iridium complètes :";
			this.painiteChunkMined.text = "Roches de painite (morceaux) :";
			this.fullPainiteMined.text = "Roches de painite complètes :";
		}
		if (LocalizationScript.isItalian)
		{
			this.talentStats.text = "Statistiche Talento";
			this.globalStats.text = "Statistiche Globali";
			this.rocksMinedStats.text = "Statistiche Rocce Estratte";
			this.potionsDrank.text = "Pozioni bevute:";
			this.chestsOpened.text = "Forzieri normali aperti:";
			this.goldenChestsOpened.text = "Forzieri dorati aperti:";
			this.theMine2XTriggered.text = "Attivazioni velocità 2X (La Miniera):";
			this.theMineDoubleTriggered.text = "Attivazioni doppio minerale (La Miniera):";
			this.inflateBurstTriggered.text = "Attivazioni Inflate Burst:";
			this.hammersSpawned.text = "Martelli generati:";
			this.midasTouchSessions.text = "Sessioni Midas Touch:";
			this.zeusTriggers.text = "Attivazioni di Zeus:";
			this.energiDrinksDrank.text = "Energy drink bevuti:";
			this.flowersSpawned.text = "Fiori generati:";
			this.campfiresSpawned.text = "Falò accesi:";
			this.d100Rolls.text = "D100, totale tiri di 1, 10 o 100:";
			this.miningSessions.text = "Sessioni di miniera:";
			this.timeSpentMining.text = "Tempo trascorso a minare:";
			this.totalRocksSpawned.text = "Totale rocce generate:";
			this.totalRocksMined.text = "Totale rocce minate:";
			this.pickaxeSpawned.text = "Picconi generati:";
			this.pickaxeHits.text = "Colpi di piccone:";
			this.oresMined.text = "Minerali estratti:";
			this.barsBrafted.text = "Lingotti forgiati:";
			this.bardMinedTheMine.text = "Lingotti estratti (La Miniera):";
			this.xpGained.text = "XP guadagnata:";
			this.totalLevelUps.text = "Totale livelli saliti:";
			this.doubleXpGained.text = "XP doppi guadagnati:";
			this.doubleOredGained.text = "Minerali doppi guadagnati:";
			this.X2pickaxePowerHits.text = "Colpi di piccone 2X potenza:";
			this.instaMineHits.text = "Colpi di piccone Insta Mine:";
			this.lightningStrikes.text = "Fulmini colpiti:";
			this.dynamiteExplosions.text = "Esplosioni di dinamite:";
			this.plazmaBallsSpawned.text = "Sfere di plasma generate:";
			this.goldChunkRocks.text = "Rocce dorate (frammenti):";
			this.fullGoldRocks.text = "Rocce dorate complete:";
			this.copperChunkMined.text = "Rocce di rame (frammenti):";
			this.fullCopperMined.text = "Rocce di rame complete:";
			this.ironChunkMined.text = "Rocce di ferro (frammenti):";
			this.fullIronMined.text = "Rocce di ferro complete:";
			this.cobaltChunkMined.text = "Rocce di cobalto (frammenti):";
			this.fullCobaltMined.text = "Rocce di cobalto complete:";
			this.uraniumChunkMined.text = "Rocce di uranio (frammenti):";
			this.fullUraniumMined.text = "Rocce di uranio complete:";
			this.ismiumChunkMined.text = "Rocce di ismio (frammenti):";
			this.fullIsmiumMined.text = "Rocce di ismio complete:";
			this.iridiumChunkMined.text = "Rocce di iridio (frammenti):";
			this.fullIridiumMined.text = "Rocce di iridio complete:";
			this.painiteChunkMined.text = "Rocce di painite (frammenti):";
			this.fullPainiteMined.text = "Rocce di painite complete:";
		}
		if (LocalizationScript.isGerman)
		{
			this.talentStats.text = "Talent-Statistiken";
			this.globalStats.text = "Globale Statistiken";
			this.rocksMinedStats.text = "Statistiken Abgebaute Steine";
			this.potionsDrank.text = "Getrunkene Tränke:";
			this.chestsOpened.text = "Geöffnete normale Truhen:";
			this.goldenChestsOpened.text = "Geöffnete goldene Truhen:";
			this.theMine2XTriggered.text = "Die Mine 2X Geschwindigkeit ausgelöst:";
			this.theMineDoubleTriggered.text = "Die Mine Doppel-Erz ausgelöst:";
			this.inflateBurstTriggered.text = "Inflate Burst ausgelöst:";
			this.hammersSpawned.text = "Gespawnte Hämmer:";
			this.midasTouchSessions.text = "Midas-Touch-Sitzungen:";
			this.zeusTriggers.text = "Zeus-Auslöser:";
			this.energiDrinksDrank.text = "Getrunkene Energy Drinks:";
			this.flowersSpawned.text = "Gespawnte Blumen:";
			this.campfiresSpawned.text = "Gespawnte Lagerfeuer:";
			this.d100Rolls.text = "D100, gesamt Würfe mit 1, 10 oder 100:";
			this.miningSessions.text = "Mining-Sitzungen:";
			this.timeSpentMining.text = "Gesamte Mining-Zeit:";
			this.totalRocksSpawned.text = "Gesamt gespawnte Steine:";
			this.totalRocksMined.text = "Gesamt abgebaut:";
			this.pickaxeSpawned.text = "Gespawnte Spitzhacken:";
			this.pickaxeHits.text = "Spitzhacken-Treffer:";
			this.oresMined.text = "Abgebaute Erze:";
			this.barsBrafted.text = "Geschmiedete Barren:";
			this.bardMinedTheMine.text = "Barren abgebaut (Die Mine):";
			this.xpGained.text = "Erhaltene XP:";
			this.totalLevelUps.text = "Gesamt Level-Ups:";
			this.doubleXpGained.text = "Doppelte XP erhalten:";
			this.doubleOredGained.text = "Doppelte Erze erhalten:";
			this.X2pickaxePowerHits.text = "2X Spitzhacken-Power Treffer:";
			this.instaMineHits.text = "Insta-Mine Spitzhacken-Treffer:";
			this.lightningStrikes.text = "Blitzeinschläge:";
			this.dynamiteExplosions.text = "Dynamit-Explosionen:";
			this.plazmaBallsSpawned.text = "Gespawnte Plasmabälle:";
			this.goldChunkRocks.text = "Goldene Brocken-Steine:";
			this.fullGoldRocks.text = "Volle Gold-Steine:";
			this.copperChunkMined.text = "Kupfer Brocken-Steine:";
			this.fullCopperMined.text = "Volle Kupfer-Steine:";
			this.ironChunkMined.text = "Eisen Brocken-Steine:";
			this.fullIronMined.text = "Volle Eisen-Steine:";
			this.cobaltChunkMined.text = "Kobalt Brocken-Steine:";
			this.fullCobaltMined.text = "Volle Kobalt-Steine:";
			this.uraniumChunkMined.text = "Uran Brocken-Steine:";
			this.fullUraniumMined.text = "Volle Uran-Steine:";
			this.ismiumChunkMined.text = "Ismium Brocken-Steine:";
			this.fullIsmiumMined.text = "Volle Ismium-Steine:";
			this.iridiumChunkMined.text = "Iridium Brocken-Steine:";
			this.fullIridiumMined.text = "Volle Iridium-Steine:";
			this.painiteChunkMined.text = "Painit Brocken-Steine:";
			this.fullPainiteMined.text = "Volle Painit-Steine:";
		}
		if (LocalizationScript.isSpanish)
		{
			this.talentStats.text = "Estadísticas de Talento";
			this.globalStats.text = "Estadísticas Globales";
			this.rocksMinedStats.text = "Estadísticas de Rocas Minadas";
			this.potionsDrank.text = "Pociones bebidas:";
			this.chestsOpened.text = "Cofres normales abiertos:";
			this.goldenChestsOpened.text = "Cofres dorados abiertos:";
			this.theMine2XTriggered.text = "Activaciones 2X velocidad (La Mina):";
			this.theMineDoubleTriggered.text = "Activaciones doble mineral (La Mina):";
			this.inflateBurstTriggered.text = "Activaciones de Inflate Burst:";
			this.hammersSpawned.text = "Martillos generados:";
			this.midasTouchSessions.text = "Sesiones de Toque de Midas:";
			this.zeusTriggers.text = "Activaciones de Zeus:";
			this.energiDrinksDrank.text = "Bebidas energéticas tomadas:";
			this.flowersSpawned.text = "Flores generadas:";
			this.campfiresSpawned.text = "Hogueras encendidas:";
			this.d100Rolls.text = "D100, total de tiradas de 1, 10 o 100:";
			this.miningSessions.text = "Sesiones de minería:";
			this.timeSpentMining.text = "Tiempo total minando:";
			this.totalRocksSpawned.text = "Total de rocas generadas:";
			this.totalRocksMined.text = "Total de rocas minadas:";
			this.pickaxeSpawned.text = "Picos generados:";
			this.pickaxeHits.text = "Golpes de pico:";
			this.oresMined.text = "Minerales extraídos:";
			this.barsBrafted.text = "Lingotes forjados:";
			this.bardMinedTheMine.text = "Lingotes extraídos (La Mina):";
			this.xpGained.text = "XP ganada:";
			this.totalLevelUps.text = "Total de niveles subidos:";
			this.doubleXpGained.text = "XP doble ganada:";
			this.doubleOredGained.text = "Minerales dobles ganados:";
			this.X2pickaxePowerHits.text = "Golpes de pico con 2X potencia:";
			this.instaMineHits.text = "Golpes de pico Insta Mine:";
			this.lightningStrikes.text = "Rayos invocados:";
			this.dynamiteExplosions.text = "Explosiones de dinamita:";
			this.plazmaBallsSpawned.text = "Bolas de plasma generadas:";
			this.goldChunkRocks.text = "Rocas de oro fragmentadas:";
			this.fullGoldRocks.text = "Rocas de oro completas:";
			this.copperChunkMined.text = "Rocas de cobre fragmentadas:";
			this.fullCopperMined.text = "Rocas de cobre completas:";
			this.ironChunkMined.text = "Rocas de hierro fragmentadas:";
			this.fullIronMined.text = "Rocas de hierro completas:";
			this.cobaltChunkMined.text = "Rocas de cobalto fragmentadas:";
			this.fullCobaltMined.text = "Rocas de cobalto completas:";
			this.uraniumChunkMined.text = "Rocas de uranio fragmentadas:";
			this.fullUraniumMined.text = "Rocas de uranio completas:";
			this.ismiumChunkMined.text = "Rocas de ismio fragmentadas:";
			this.fullIsmiumMined.text = "Rocas de ismio completas:";
			this.iridiumChunkMined.text = "Rocas de iridio fragmentadas:";
			this.fullIridiumMined.text = "Rocas de iridio completas:";
			this.painiteChunkMined.text = "Rocas de painita fragmentadas:";
			this.fullPainiteMined.text = "Rocas de painita completas:";
		}
		if (LocalizationScript.isJapanese)
		{
			this.talentStats.text = "タレント統計";
			this.globalStats.text = "グローバル統計";
			this.rocksMinedStats.text = "採掘した岩 統計";
			this.potionsDrank.text = "飲んだポーション：";
			this.chestsOpened.text = "開けた通常の宝箱：";
			this.goldenChestsOpened.text = "開けたゴールデン宝箱：";
			this.theMine2XTriggered.text = "マイン2倍速発動回数：";
			this.theMineDoubleTriggered.text = "マイン二重鉱石発動回数：";
			this.inflateBurstTriggered.text = "インフレバースト発動回数：";
			this.hammersSpawned.text = "出現したハンマー：";
			this.midasTouchSessions.text = "マイダスタッチセッション：";
			this.zeusTriggers.text = "ゼウス発動回数：";
			this.energiDrinksDrank.text = "飲んだエナジードリンク：";
			this.flowersSpawned.text = "出現した花：";
			this.campfiresSpawned.text = "出現した焚き火：";
			this.d100Rolls.text = "D100：1、10、100が出た回数：";
			this.miningSessions.text = "採掘セッション数：";
			this.timeSpentMining.text = "採掘時間：";
			this.totalRocksSpawned.text = "出現した岩の総数：";
			this.totalRocksMined.text = "採掘した岩の総数：";
			this.pickaxeSpawned.text = "出現したピッケル：";
			this.pickaxeHits.text = "ピッケルヒット数：";
			this.oresMined.text = "採掘した鉱石：";
			this.barsBrafted.text = "作成したインゴット：";
			this.bardMinedTheMine.text = "採掘したインゴット（マイン）：";
			this.xpGained.text = "獲得XP：";
			this.totalLevelUps.text = "総レベルアップ数：";
			this.doubleXpGained.text = "獲得した2倍XP：";
			this.doubleOredGained.text = "獲得した2倍鉱石：";
			this.X2pickaxePowerHits.text = "2倍威力ピッケルヒット数：";
			this.instaMineHits.text = "即採掘ピッケルヒット数：";
			this.lightningStrikes.text = "雷の発動回数：";
			this.dynamiteExplosions.text = "ダイナマイト爆発回数：";
			this.plazmaBallsSpawned.text = "出現したプラズマボール：";
			this.goldChunkRocks.text = "金鉱石チャンク：";
			this.fullGoldRocks.text = "フル金鉱石：";
			this.copperChunkMined.text = "銅鉱石チャンク：";
			this.fullCopperMined.text = "フル銅鉱石：";
			this.ironChunkMined.text = "鉄鉱石チャンク：";
			this.fullIronMined.text = "フル鉄鉱石：";
			this.cobaltChunkMined.text = "コバルト鉱石チャンク：";
			this.fullCobaltMined.text = "フルコバルト鉱石：";
			this.uraniumChunkMined.text = "ウラン鉱石チャンク：";
			this.fullUraniumMined.text = "フルウラン鉱石：";
			this.ismiumChunkMined.text = "イスミウム鉱石チャンク：";
			this.fullIsmiumMined.text = "フルイスミウム鉱石：";
			this.iridiumChunkMined.text = "イリジウム鉱石チャンク：";
			this.fullIridiumMined.text = "フルイリジウム鉱石：";
			this.painiteChunkMined.text = "ペイナイト鉱石チャンク：";
			this.fullPainiteMined.text = "フルペイナイト鉱石：";
		}
		if (LocalizationScript.isKorean)
		{
			this.talentStats.text = "특성 통계";
			this.globalStats.text = "전체 통계";
			this.rocksMinedStats.text = "채굴된 바위 통계";
			this.potionsDrank.text = "마신 물약:";
			this.chestsOpened.text = "연 일반 상자 개수:";
			this.goldenChestsOpened.text = "연 황금 상자 개수:";
			this.theMine2XTriggered.text = "마인 2배 속도 발동:";
			this.theMineDoubleTriggered.text = "마인 2배 광물 발동:";
			this.inflateBurstTriggered.text = "인플레이트 버스트 발동:";
			this.hammersSpawned.text = "생성된 망치:";
			this.midasTouchSessions.text = "마이다스 터치 세션:";
			this.zeusTriggers.text = "제우스 발동:";
			this.energiDrinksDrank.text = "마신 에너지 음료:";
			this.flowersSpawned.text = "생성된 꽃:";
			this.campfiresSpawned.text = "생성된 캠프파이어:";
			this.d100Rolls.text = "D100: 1, 10 또는 100 나온 횟수:";
			this.miningSessions.text = "채굴 세션:";
			this.timeSpentMining.text = "채굴한 시간:";
			this.totalRocksSpawned.text = "총 생성된 바위:";
			this.totalRocksMined.text = "총 채굴한 바위:";
			this.pickaxeSpawned.text = "생성된 곡괭이:";
			this.pickaxeHits.text = "곡괭이 히트 수:";
			this.oresMined.text = "채굴한 광석:";
			this.barsBrafted.text = "제작한 바:";
			this.bardMinedTheMine.text = "채굴한 바 (마인):";
			this.xpGained.text = "획득한 XP:";
			this.totalLevelUps.text = "총 레벨 업:";
			this.doubleXpGained.text = "획득한 2배 XP:";
			this.doubleOredGained.text = "획득한 2배 광석:";
			this.X2pickaxePowerHits.text = "2배 곡괭이 파워 히트:";
			this.instaMineHits.text = "인스턴트 채굴 곡괭이 히트:";
			this.lightningStrikes.text = "번개 발동:";
			this.dynamiteExplosions.text = "다이너마이트 폭발:";
			this.plazmaBallsSpawned.text = "생성된 플라즈마 볼:";
			this.goldChunkRocks.text = "금 광석 청크:";
			this.fullGoldRocks.text = "풀 금 광석:";
			this.copperChunkMined.text = "구리 광석 청크:";
			this.fullCopperMined.text = "풀 구리 광석:";
			this.ironChunkMined.text = "철 광석 청크:";
			this.fullIronMined.text = "풀 철 광석:";
			this.cobaltChunkMined.text = "코발트 광석 청크:";
			this.fullCobaltMined.text = "풀 코발트 광석:";
			this.uraniumChunkMined.text = "우라늄 광석 청크:";
			this.fullUraniumMined.text = "풀 우라늄 광석:";
			this.ismiumChunkMined.text = "이스미움 광석 청크:";
			this.fullIsmiumMined.text = "풀 이스미움 광석:";
			this.iridiumChunkMined.text = "이리듐 광석 청크:";
			this.fullIridiumMined.text = "풀 이리듐 광석:";
			this.painiteChunkMined.text = "페이나이트 광석 청크:";
			this.fullPainiteMined.text = "풀 페이나이트 광석:";
		}
		if (LocalizationScript.isPolish)
		{
			this.talentStats.text = "Statystyki Talentu";
			this.globalStats.text = "Statystyki Globalne";
			this.rocksMinedStats.text = "Statystyki Wydobycia Skał";
			this.potionsDrank.text = "Wypite mikstury:";
			this.chestsOpened.text = "Otwarte zwykłe skrzynie:";
			this.goldenChestsOpened.text = "Otwarte złote skrzynie:";
			this.theMine2XTriggered.text = "Kopalnia 2X prędkość (uruchomienia):";
			this.theMineDoubleTriggered.text = "Kopalnia podwójna ruda (uruchomienia):";
			this.inflateBurstTriggered.text = "Uruchomienia Inflate Burst:";
			this.hammersSpawned.text = "Zespawnowane młoty:";
			this.midasTouchSessions.text = "Sesje Midas Touch:";
			this.zeusTriggers.text = "Wyzwolenia Zeusa:";
			this.energiDrinksDrank.text = "Wypite energy drinki:";
			this.flowersSpawned.text = "Zespawnowane kwiaty:";
			this.campfiresSpawned.text = "Zespawnowane ogniska:";
			this.d100Rolls.text = "D100 — liczba trafień 1, 10 lub 100:";
			this.miningSessions.text = "Sesje kopania:";
			this.timeSpentMining.text = "Czas spędzony na kopaniu:";
			this.totalRocksSpawned.text = "Łączna liczba zespawnowanych skał:";
			this.totalRocksMined.text = "Łączna liczba wykopanych skał:";
			this.pickaxeSpawned.text = "Zespawnowane kilofy:";
			this.pickaxeHits.text = "Uderzenia kilofa:";
			this.oresMined.text = "Wykopane rudy:";
			this.barsBrafted.text = "Wytopione sztabki:";
			this.bardMinedTheMine.text = "Sztabki z kopalni:";
			this.xpGained.text = "Zdobyte XP:";
			this.totalLevelUps.text = "Łączne awanse poziomów:";
			this.doubleXpGained.text = "Zdobyte podwójne XP:";
			this.doubleOredGained.text = "Zdobyte podwójne rudy:";
			this.X2pickaxePowerHits.text = "Uderzenia kilofa z mocą 2X:";
			this.instaMineHits.text = "Insta-mine uderzenia kilofa:";
			this.lightningStrikes.text = "Wyładowania pioruna:";
			this.dynamiteExplosions.text = "Eksplozje dynamitu:";
			this.plazmaBallsSpawned.text = "Zespawnowane kule plazmy:";
			this.goldChunkRocks.text = "Złote skały (kawałki):";
			this.fullGoldRocks.text = "Pełne złote skały:";
			this.copperChunkMined.text = "Miedziane skały (kawałki):";
			this.fullCopperMined.text = "Pełne miedziane skały:";
			this.ironChunkMined.text = "Żelazne skały (kawałki):";
			this.fullIronMined.text = "Pełne żelazne skały:";
			this.cobaltChunkMined.text = "Kobaltowe skały (kawałki):";
			this.fullCobaltMined.text = "Pełne kobaltowe skały:";
			this.uraniumChunkMined.text = "Uranowe skały (kawałki):";
			this.fullUraniumMined.text = "Pełne uranowe skały:";
			this.ismiumChunkMined.text = "Ismium skały (kawałki):";
			this.fullIsmiumMined.text = "Pełne ismium skały:";
			this.iridiumChunkMined.text = "Irydowe skały (kawałki):";
			this.fullIridiumMined.text = "Pełne irydowe skały:";
			this.painiteChunkMined.text = "Painitowe skały (kawałki):";
			this.fullPainiteMined.text = "Pełne painitowe skały:";
		}
		if (LocalizationScript.isPortugese)
		{
			this.talentStats.text = "Estatísticas de Talento";
			this.globalStats.text = "Estatísticas Globais";
			this.rocksMinedStats.text = "Estatísticas de Rochas Mineradas";
			this.potionsDrank.text = "Poções bebibas:";
			this.chestsOpened.text = "Baús normais abertos:";
			this.goldenChestsOpened.text = "Baús dourados abertos:";
			this.theMine2XTriggered.text = "Ativações 2X velocidade (A Mina):";
			this.theMineDoubleTriggered.text = "Ativações dobro de minério (A Mina):";
			this.inflateBurstTriggered.text = "Ativações de Inflate Burst:";
			this.hammersSpawned.text = "Martelos gerados:";
			this.midasTouchSessions.text = "Sessões Midas Touch:";
			this.zeusTriggers.text = "Ativações de Zeus:";
			this.energiDrinksDrank.text = "Energéticos bebidos:";
			this.flowersSpawned.text = "Flores geradas:";
			this.campfiresSpawned.text = "Fogueiras geradas:";
			this.d100Rolls.text = "D100, total de rolagens de 1, 10 ou 100:";
			this.miningSessions.text = "Sessões de mineração:";
			this.timeSpentMining.text = "Tempo minerando:";
			this.totalRocksSpawned.text = "Total de rochas geradas:";
			this.totalRocksMined.text = "Total de rochas mineradas:";
			this.pickaxeSpawned.text = "Picaretas geradas:";
			this.pickaxeHits.text = "Golpes de picareta:";
			this.oresMined.text = "Minérios minerados:";
			this.barsBrafted.text = "Barras forjadas:";
			this.bardMinedTheMine.text = "Barras mineradas (A Mina):";
			this.xpGained.text = "XP ganho:";
			this.totalLevelUps.text = "Total de níveis ganhos:";
			this.doubleXpGained.text = "XP dobrado ganho:";
			this.doubleOredGained.text = "Minérios dobrados ganhos:";
			this.X2pickaxePowerHits.text = "Golpes de picareta 2X poder:";
			this.instaMineHits.text = "Golpes Insta Mine:";
			this.lightningStrikes.text = "Raio invocados:";
			this.dynamiteExplosions.text = "Explosões de dinamite:";
			this.plazmaBallsSpawned.text = "Bolas de plasma geradas:";
			this.goldChunkRocks.text = "Rocha de ouro (pedaços):";
			this.fullGoldRocks.text = "Rocha de ouro completa:";
			this.copperChunkMined.text = "Rocha de cobre (pedaços):";
			this.fullCopperMined.text = "Rocha de cobre completa:";
			this.ironChunkMined.text = "Rocha de ferro (pedaços):";
			this.fullIronMined.text = "Rocha de ferro completa:";
			this.cobaltChunkMined.text = "Rocha de cobalto (pedaços):";
			this.fullCobaltMined.text = "Rocha de cobalto completa:";
			this.uraniumChunkMined.text = "Rocha de urânio (pedaços):";
			this.fullUraniumMined.text = "Rocha de urânio completa:";
			this.ismiumChunkMined.text = "Rocha de ismium (pedaços):";
			this.fullIsmiumMined.text = "Rocha de ismium completa:";
			this.iridiumChunkMined.text = "Rocha de irídio (pedaços):";
			this.fullIridiumMined.text = "Rocha de irídio completa:";
			this.painiteChunkMined.text = "Rocha de painita (pedaços):";
			this.fullPainiteMined.text = "Rocha de painita completa:";
		}
		if (LocalizationScript.isRussian)
		{
			this.talentStats.text = "Статистика Талантов";
			this.globalStats.text = "Глобальная Статистика";
			this.rocksMinedStats.text = "Статистика Добытых Камней";
			this.potionsDrank.text = "Выпито зелий:";
			this.chestsOpened.text = "Открыто обычных сундуков:";
			this.goldenChestsOpened.text = "Открыто золотых сундуков:";
			this.theMine2XTriggered.text = "Шахта: ускорение 2X активировано:";
			this.theMineDoubleTriggered.text = "Шахта: двойная руда активирована:";
			this.inflateBurstTriggered.text = "Inflate Burst сработало:";
			this.hammersSpawned.text = "Сгенерировано молотов:";
			this.midasTouchSessions.text = "Сессии Midas Touch:";
			this.zeusTriggers.text = "Активации Зевса:";
			this.energiDrinksDrank.text = "Выпито энергетиков:";
			this.flowersSpawned.text = "Сгенерировано цветов:";
			this.campfiresSpawned.text = "Разожжено костров:";
			this.d100Rolls.text = "D100: всего выпадений 1, 10 или 100:";
			this.miningSessions.text = "Сессии добычи:";
			this.timeSpentMining.text = "Время добычи:";
			this.totalRocksSpawned.text = "Всего сгенерировано камней:";
			this.totalRocksMined.text = "Всего добыто камней:";
			this.pickaxeSpawned.text = "Сгенерировано кирок:";
			this.pickaxeHits.text = "Удары киркой:";
			this.oresMined.text = "Добыто руды:";
			this.barsBrafted.text = "Переплавлено слитков:";
			this.bardMinedTheMine.text = "Добыто слитков (Шахта):";
			this.xpGained.text = "Получено XP:";
			this.totalLevelUps.text = "Всего уровней:";
			this.doubleXpGained.text = "Получено двойного XP:";
			this.doubleOredGained.text = "Добыто двойной руды:";
			this.X2pickaxePowerHits.text = "Удары киркой с 2X силой:";
			this.instaMineHits.text = "Insta Mine удары киркой:";
			this.lightningStrikes.text = "Удары молнии:";
			this.dynamiteExplosions.text = "Взрывы динамита:";
			this.plazmaBallsSpawned.text = "Сгенерировано плазменных шаров:";
			this.goldChunkRocks.text = "Куски золотой руды:";
			this.fullGoldRocks.text = "Полная золотая руда:";
			this.copperChunkMined.text = "Куски медной руды:";
			this.fullCopperMined.text = "Полная медная руда:";
			this.ironChunkMined.text = "Куски железной руды:";
			this.fullIronMined.text = "Полная железная руда:";
			this.cobaltChunkMined.text = "Куски кобальтовой руды:";
			this.fullCobaltMined.text = "Полная кобальтовая руда:";
			this.uraniumChunkMined.text = "Куски урановой руды:";
			this.fullUraniumMined.text = "Полная урановая руда:";
			this.ismiumChunkMined.text = "Куски измиевой руды:";
			this.fullIsmiumMined.text = "Полная измиевая руда:";
			this.iridiumChunkMined.text = "Куски иридиевой руды:";
			this.fullIridiumMined.text = "Полная иридиевая руда:";
			this.painiteChunkMined.text = "Куски пейнита:";
			this.fullPainiteMined.text = "Полный пейнит:";
		}
		if (LocalizationScript.isSimplefiedChinese)
		{
			this.talentStats.text = "天赋统计";
			this.globalStats.text = "全局统计";
			this.rocksMinedStats.text = "挖矿统计";
			this.potionsDrank.text = "已喝药水：";
			this.chestsOpened.text = "已开普通宝箱：";
			this.goldenChestsOpened.text = "已开黄金宝箱：";
			this.theMine2XTriggered.text = "矿井2倍速触发次数：";
			this.theMineDoubleTriggered.text = "矿井双倍矿石触发次数：";
			this.inflateBurstTriggered.text = "膨胀爆发触发次数：";
			this.hammersSpawned.text = "生成的锤子数：";
			this.midasTouchSessions.text = "点金之触会话：";
			this.zeusTriggers.text = "宙斯触发次数：";
			this.energiDrinksDrank.text = "已喝能量饮料：";
			this.flowersSpawned.text = "生成的花朵数：";
			this.campfiresSpawned.text = "生成的篝火数：";
			this.d100Rolls.text = "D100，掷出1、10或100的总次数：";
			this.miningSessions.text = "挖矿会话：";
			this.timeSpentMining.text = "挖矿总时长：";
			this.totalRocksSpawned.text = "生成的岩石总数：";
			this.totalRocksMined.text = "已挖岩石总数：";
			this.pickaxeSpawned.text = "生成的镐数：";
			this.pickaxeHits.text = "镐击次数：";
			this.oresMined.text = "已挖矿石：";
			this.barsBrafted.text = "已锻造锭数：";
			this.bardMinedTheMine.text = "已开采锭（矿井）：";
			this.xpGained.text = "获得的XP：";
			this.totalLevelUps.text = "总升级次数：";
			this.doubleXpGained.text = "获得的双倍XP：";
			this.doubleOredGained.text = "获得的双倍矿石：";
			this.X2pickaxePowerHits.text = "2倍威力镐击次数：";
			this.instaMineHits.text = "瞬挖镐击次数：";
			this.lightningStrikes.text = "闪电击中次数：";
			this.dynamiteExplosions.text = "炸药爆炸次数：";
			this.plazmaBallsSpawned.text = "生成的等离子球：";
			this.goldChunkRocks.text = "金矿石块：";
			this.fullGoldRocks.text = "完整金矿石：";
			this.copperChunkMined.text = "铜矿石块：";
			this.fullCopperMined.text = "完整铜矿石：";
			this.ironChunkMined.text = "铁矿石块：";
			this.fullIronMined.text = "完整铁矿石：";
			this.cobaltChunkMined.text = "钴矿石块：";
			this.fullCobaltMined.text = "完整钴矿石：";
			this.uraniumChunkMined.text = "铀矿石块：";
			this.fullUraniumMined.text = "完整铀矿石：";
			this.ismiumChunkMined.text = "伊斯密矿石块：";
			this.fullIsmiumMined.text = "完整伊斯密矿石：";
			this.iridiumChunkMined.text = "铱矿石块：";
			this.fullIridiumMined.text = "完整铱矿石：";
			this.painiteChunkMined.text = "帕因石块：";
			this.fullPainiteMined.text = "完整帕因石：";
		}
	}

	// Token: 0x06000133 RID: 307 RVA: 0x0001F7A4 File Offset: 0x0001D9A4
	public void SkillTreeText(string upgradeName, int upgradeType, double upgradePrice, int purchaseCount, int totalPurchaseCount)
	{
		bool flag = false;
		if (purchaseCount >= totalPurchaseCount)
		{
			flag = true;
		}
		if (upgradeType == 1)
		{
			if (LocalizationScript.isEnglish)
			{
				this.skillTreeName_text.text = "More Rocks";
			}
			if (LocalizationScript.isFrench)
			{
				this.skillTreeName_text.text = "Plus de Roches";
			}
			if (LocalizationScript.isItalian)
			{
				this.skillTreeName_text.text = "Più Rocce";
			}
			if (LocalizationScript.isGerman)
			{
				this.skillTreeName_text.text = "Mehr Steine";
			}
			if (LocalizationScript.isSpanish)
			{
				this.skillTreeName_text.text = "Más Rocas";
			}
			if (LocalizationScript.isJapanese)
			{
				this.skillTreeName_text.text = "岩を増やす";
			}
			if (LocalizationScript.isKorean)
			{
				this.skillTreeName_text.text = "암석 추가";
			}
			if (LocalizationScript.isPolish)
			{
				this.skillTreeName_text.text = "Więcej Skał";
			}
			if (LocalizationScript.isPortugese)
			{
				this.skillTreeName_text.text = "Mais Rochas";
			}
			if (LocalizationScript.isRussian)
			{
				this.skillTreeName_text.text = "Больше Камней";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.skillTreeName_text.text = "更多岩石";
			}
			if (upgradeName == "Rock1")
			{
				LocalizationScript.rockSpawnIncrease = 4;
			}
			else if (upgradeName == "Rock2")
			{
				LocalizationScript.rockSpawnIncrease = 5;
			}
			else if (upgradeName == "Rock3")
			{
				LocalizationScript.rockSpawnIncrease = 7;
			}
			else if (upgradeName == "Rock4")
			{
				LocalizationScript.rockSpawnIncrease = 8;
			}
			else if (upgradeName == "Rock5")
			{
				LocalizationScript.rockSpawnIncrease = 9;
			}
			else if (upgradeName == "Rock6")
			{
				LocalizationScript.rockSpawnIncrease = 9;
			}
			else if (upgradeName == "Rock7")
			{
				LocalizationScript.rockSpawnIncrease = 12;
			}
			else if (upgradeName == "Rock8")
			{
				LocalizationScript.rockSpawnIncrease = 15;
			}
			else if (upgradeName == "Rock9")
			{
				LocalizationScript.rockSpawnIncrease = 16;
			}
			float num = (float)(SkillTree.totalRocksToSpawn + LocalizationScript.rockSpawnIncrease);
			if (flag)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeDesc_text.text = string.Format("Total rock spawn count:\n{0}", SkillTree.totalRocksToSpawn);
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeDesc_text.text = string.Format("Nombre total de roches générées :\n{0}", SkillTree.totalRocksToSpawn);
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeDesc_text.text = string.Format("Conteggio totale rocce generate:\n{0}", SkillTree.totalRocksToSpawn);
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeDesc_text.text = string.Format("Gesamtzahl der gespawnten Steine:\n{0}", SkillTree.totalRocksToSpawn);
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeDesc_text.text = string.Format("Total de rocas generadas:\n{0}", SkillTree.totalRocksToSpawn);
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeDesc_text.text = string.Format("岩の総出現数：\n{0}", SkillTree.totalRocksToSpawn);
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeDesc_text.text = string.Format("암석 총 생성 수:\n{0}", SkillTree.totalRocksToSpawn);
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeDesc_text.text = string.Format("Łączna liczba skał:\n{0}", SkillTree.totalRocksToSpawn);
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeDesc_text.text = string.Format("Total de rochas geradas:\n{0}", SkillTree.totalRocksToSpawn);
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeDesc_text.text = string.Format("Общее количество камней:\n{0}", SkillTree.totalRocksToSpawn);
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeDesc_text.text = string.Format("岩石生成总数：\n{0}", SkillTree.totalRocksToSpawn);
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeDesc_text.text = string.Format("More rocks spawn at the beginning of a mining session:\n{0}->{1}", SkillTree.totalRocksToSpawn, num);
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeDesc_text.text = string.Format("Plus de roches apparaissent au début d'une session de minage :\n{0}->{1}", SkillTree.totalRocksToSpawn, num);
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeDesc_text.text = string.Format("Più rocce compaiono all'inizio di una sessione di scavo:\n{0}->{1}", SkillTree.totalRocksToSpawn, num);
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeDesc_text.text = string.Format("Mehr Steine erscheinen zu Beginn einer Mining-Session:\n{0}->{1}", SkillTree.totalRocksToSpawn, num);
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeDesc_text.text = string.Format("Más rocas aparecen al inicio de una sesión de minería:\n{0}->{1}", SkillTree.totalRocksToSpawn, num);
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeDesc_text.text = string.Format("採掘セッション開始時に岩が多く出現します：\n{0}->{1}", SkillTree.totalRocksToSpawn, num);
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeDesc_text.text = string.Format("채굴 세션 시작 시 더 많은 암석이 생성됩니다:\n{0}->{1}", SkillTree.totalRocksToSpawn, num);
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeDesc_text.text = string.Format("Więcej skał pojawia się na początku sesji wydobywczej:\n{0}->{1}", SkillTree.totalRocksToSpawn, num);
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeDesc_text.text = string.Format("Mais rochas surgem no início de uma sessão de mineração:\n{0}->{1}", SkillTree.totalRocksToSpawn, num);
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeDesc_text.text = string.Format("Больше камней появляется в начале добычи:\n{0}->{1}", SkillTree.totalRocksToSpawn, num);
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeDesc_text.text = string.Format("在采矿开始时会生成更多岩石：\n{0}->{1}", SkillTree.totalRocksToSpawn, num);
				}
			}
		}
		else if (upgradeType == 2)
		{
			if (upgradeName == "XP1")
			{
				LocalizationScript.xpIncrease = 0.02f;
			}
			else if (upgradeName == "XP2")
			{
				LocalizationScript.xpIncrease = 0.08f;
			}
			else if (upgradeName == "XP3")
			{
				LocalizationScript.xpIncrease = 0.36f;
			}
			else if (upgradeName == "XP4")
			{
				LocalizationScript.xpIncrease = 0.24f;
			}
			else if (upgradeName == "XP5")
			{
				LocalizationScript.xpIncrease = 0.54f;
			}
			else if (upgradeName == "XP6")
			{
				LocalizationScript.xpIncrease = 0.8f;
			}
			else if (upgradeName == "XP7")
			{
				LocalizationScript.xpIncrease = 1.1f;
			}
			else if (upgradeName == "XP8")
			{
				LocalizationScript.xpIncrease = 2.5f;
			}
			else if (upgradeName == "EndlessXP1")
			{
				LocalizationScript.xpIncrease = 1.05f;
			}
			else if (upgradeName == "EndlessXP2")
			{
				LocalizationScript.xpIncrease = 1.05f;
			}
			bool flag2 = false;
			if (upgradeName == "Talent1")
			{
				flag2 = true;
				LocalizationScript.moreTalentPointsReduce = 2;
				if (SkillTree.talentPointsPerXlevel_1_purchaseCount >= 1)
				{
					flag = true;
					LocalizationScript.moreTalentPointsReduce = 0;
				}
			}
			else if (upgradeName == "Talent2")
			{
				flag2 = true;
				LocalizationScript.moreTalentPointsReduce = 2;
				if (SkillTree.talentPointsPerXlevel_2_purchaseCount >= 1)
				{
					flag = true;
					LocalizationScript.moreTalentPointsReduce = 0;
				}
			}
			else if (upgradeName == "Talent3")
			{
				flag2 = true;
				LocalizationScript.moreTalentPointsReduce = 1;
				if (SkillTree.talentPointsPerXlevel_3_purchaseCount >= 1)
				{
					flag = true;
					LocalizationScript.moreTalentPointsReduce = 0;
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More XP";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de XP";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più XP";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr XP";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más XP";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "XP増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "XP 증가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej XP";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais XP";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше XP";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多XP";
				}
				float num2 = LevelMechanics.xpFromRock + LocalizationScript.xpIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total XP from rocks:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0");
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "XP total des roches :\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0");
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "XP totale dalle rocce:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0");
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamt-XP von Steinen:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0");
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "XP total de rocas:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0");
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "岩からの総XP：\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0");
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "암석에서 획득한 총 XP:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0");
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączne XP ze skał:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0");
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "XP total das rochas:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0");
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий XP с камней:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0");
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "来自岩石的总XP：\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0");
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Increase XP received from mined rocks:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0") + "->" + (num2 * 100f).ToString("F0");
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Augmente l'XP reçu des roches extraites :\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0") + "->" + (num2 * 100f).ToString("F0");
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Aumenta l'XP ottenuta dalle rocce estratte:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0") + "->" + (num2 * 100f).ToString("F0");
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Erhöht XP von abgebauten Steinen:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0") + "->" + (num2 * 100f).ToString("F0");
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Aumenta la XP obtenida de rocas extraídas:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0") + "->" + (num2 * 100f).ToString("F0");
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "採掘した岩から得られるXPが増加：\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0") + "->" + (num2 * 100f).ToString("F0");
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "채굴된 암석에서 얻는 XP 증가:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0") + "->" + (num2 * 100f).ToString("F0");
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Zwiększa XP z wydobytych skał:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0") + "->" + (num2 * 100f).ToString("F0");
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Aumenta o XP recebido de rochas mineradas:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0") + "->" + (num2 * 100f).ToString("F0");
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Увеличивает XP за добытые камни:\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0") + "->" + (num2 * 100f).ToString("F0");
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "提高采矿岩石获得的XP：\n" + (LevelMechanics.xpFromRock * 100f).ToString("F0") + "->" + (num2 * 100f).ToString("F0");
					}
				}
			}
			if (flag2)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Talent Points";
					this.skillTreeDesc_text.text = string.Format("Receive 1 extra talent point per {0} levels", SkillTree.extraTalentPointPerLevel - LocalizationScript.moreTalentPointsReduce);
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Points de Talent";
					this.skillTreeDesc_text.text = string.Format("Recevez 1 point de talent supplémentaire tous les {0} niveaux", SkillTree.extraTalentPointPerLevel - LocalizationScript.moreTalentPointsReduce);
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Punti Talento";
					this.skillTreeDesc_text.text = string.Format("Ricevi 1 punto talento extra ogni {0} livelli", SkillTree.extraTalentPointPerLevel - LocalizationScript.moreTalentPointsReduce);
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Talentpunkte";
					this.skillTreeDesc_text.text = string.Format("Erhalte 1 zusätzlichen Talentpunkt alle {0} Level", SkillTree.extraTalentPointPerLevel - LocalizationScript.moreTalentPointsReduce);
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Puntos de Talento";
					this.skillTreeDesc_text.text = string.Format("Recibe 1 punto de talento extra cada {0} niveles", SkillTree.extraTalentPointPerLevel - LocalizationScript.moreTalentPointsReduce);
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "才能ポイント増加";
					this.skillTreeDesc_text.text = string.Format("{0}レベルごとに追加で才能ポイントを1つ獲得", SkillTree.extraTalentPointPerLevel - LocalizationScript.moreTalentPointsReduce);
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "특성 포인트 증가";
					this.skillTreeDesc_text.text = string.Format("{0}레벨마다 추가 특성 포인트 1개 획득", SkillTree.extraTalentPointPerLevel - LocalizationScript.moreTalentPointsReduce);
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Punktów Talentu";
					this.skillTreeDesc_text.text = string.Format("Otrzymujesz 1 dodatkowy punkt talentu co {0} poziomów", SkillTree.extraTalentPointPerLevel - LocalizationScript.moreTalentPointsReduce);
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Pontos de Talento";
					this.skillTreeDesc_text.text = string.Format("Receba 1 ponto de talento extra a cada {0} níveis", SkillTree.extraTalentPointPerLevel - LocalizationScript.moreTalentPointsReduce);
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Очков Таланта";
					this.skillTreeDesc_text.text = string.Format("Получайте 1 дополнительное очко таланта каждые {0} уровней", SkillTree.extraTalentPointPerLevel - LocalizationScript.moreTalentPointsReduce);
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多天赋点数";
					this.skillTreeDesc_text.text = string.Format("每{0}级额外获得1个天赋点", SkillTree.extraTalentPointPerLevel - LocalizationScript.moreTalentPointsReduce);
				}
			}
		}
		else if (upgradeType == 3)
		{
			bool flag3 = false;
			if (upgradeName == "GoldChunk1")
			{
				flag3 = true;
				LocalizationScript.goldRockChanceIncrease = 0.4f;
			}
			else if (upgradeName == "GoldChunk2")
			{
				flag3 = true;
				LocalizationScript.goldRockChanceIncrease = 0.4f;
			}
			else if (upgradeName == "GoldChunk3")
			{
				flag3 = true;
				LocalizationScript.goldRockChanceIncrease = 0.5f;
			}
			else if (upgradeName == "GoldChunk4")
			{
				flag3 = true;
				LocalizationScript.goldRockChanceIncrease = 0.5f;
			}
			else if (upgradeName == "GoldChunk5")
			{
				flag3 = true;
				LocalizationScript.goldRockChanceIncrease = 0.6f;
			}
			else if (upgradeName == "FullGold1")
			{
				LocalizationScript.fullGoldRockChanceIncrease = 0.5f;
			}
			else if (upgradeName == "FullGold2")
			{
				LocalizationScript.fullGoldRockChanceIncrease = 0.6f;
			}
			else if (upgradeName == "FullGold3")
			{
				LocalizationScript.fullGoldRockChanceIncrease = 0.8f;
			}
			if (flag3)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Gold Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches Dorées";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce d'Oro";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Gold-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Oro";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "金の岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "금 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Złotych Skał";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Ouro";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Золотых Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多金矿石";
				}
				float num3 = SkillTree.goldRockChance + LocalizationScript.goldRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total gold chunk rock spawn chance:\n" + SkillTree.goldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches à morceaux d'or :\n" + SkillTree.goldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce a pezzi d'oro:\n" + SkillTree.goldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für Goldbrocken-Steine:\n" + SkillTree.goldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de trozos de oro:\n" + SkillTree.goldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "金チャンク岩の出現確率合計：\n" + SkillTree.goldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "금 조각 암석 총 생성 확률:\n" + SkillTree.goldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się złotych brył:\n" + SkillTree.goldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de pedaços de ouro:\n" + SkillTree.goldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления золотых глыб:\n" + SkillTree.goldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "金块岩生成总概率：\n" + SkillTree.goldRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the gold chunk rock spawn chance:\n",
							SkillTree.goldRockChance.ToString("F2"),
							"%->",
							num3.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches à morceaux d'or :\n",
							SkillTree.goldRockChance.ToString("F2"),
							"%->",
							num3.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce a pezzi d'oro:\n",
							SkillTree.goldRockChance.ToString("F2"),
							"%->",
							num3.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für Goldbrocken-Steine:\n",
							SkillTree.goldRockChance.ToString("F2"),
							"%->",
							num3.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de trozos de oro:\n",
							SkillTree.goldRockChance.ToString("F2"),
							"%->",
							num3.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"金チャンク岩の出現確率を増加：\n",
							SkillTree.goldRockChance.ToString("F2"),
							"%->",
							num3.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"금 조각 암석 생성 확률 증가:\n",
							SkillTree.goldRockChance.ToString("F2"),
							"%->",
							num3.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się złotych brył:\n",
							SkillTree.goldRockChance.ToString("F2"),
							"%->",
							num3.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de pedaços de ouro:\n",
							SkillTree.goldRockChance.ToString("F2"),
							"%->",
							num3.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления золотых глыб:\n",
							SkillTree.goldRockChance.ToString("F2"),
							"%->",
							num3.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升金块岩生成概率：\n",
							SkillTree.goldRockChance.ToString("F2"),
							"%->",
							num3.ToString("F2"),
							"%"
						});
					}
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Full Gold Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches d'Or Complètes";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce d'Oro Piene";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Ganze Gold-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Oro Completas";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "金フル岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "전체 금 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Pełnych Złotych Skał";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Ouro Inteiras";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Полных Золотых Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多完整金矿石";
				}
				float num4 = SkillTree.fullGoldRockChance + LocalizationScript.fullGoldRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total full gold rock spawn chance:\n" + SkillTree.fullGoldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches d'or complètes :\n" + SkillTree.fullGoldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce d'oro piene:\n" + SkillTree.fullGoldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für ganze Gold-Steine:\n" + SkillTree.fullGoldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de oro completas:\n" + SkillTree.fullGoldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "金フル岩の出現確率合計：\n" + SkillTree.fullGoldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "전체 금 암석 총 생성 확률:\n" + SkillTree.fullGoldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się pełnych złotych skał:\n" + SkillTree.fullGoldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de ouro inteiras:\n" + SkillTree.fullGoldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления полных золотых камней:\n" + SkillTree.fullGoldRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "完整金矿石生成总概率：\n" + SkillTree.fullGoldRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the full gold rock spawn chance:\n",
							SkillTree.fullGoldRockChance.ToString("F2"),
							"%->",
							num4.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches d'or complètes :\n",
							SkillTree.fullGoldRockChance.ToString("F2"),
							"%->",
							num4.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce d'oro piene:\n",
							SkillTree.fullGoldRockChance.ToString("F2"),
							"%->",
							num4.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für ganze Gold-Steine:\n",
							SkillTree.fullGoldRockChance.ToString("F2"),
							"%->",
							num4.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de oro completas:\n",
							SkillTree.fullGoldRockChance.ToString("F2"),
							"%->",
							num4.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"金フル岩の出現確率を増加：\n",
							SkillTree.fullGoldRockChance.ToString("F2"),
							"%->",
							num4.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"전체 금 암석 생성 확률 증가:\n",
							SkillTree.fullGoldRockChance.ToString("F2"),
							"%->",
							num4.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się pełnych złotych skał:\n",
							SkillTree.fullGoldRockChance.ToString("F2"),
							"%->",
							num4.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de ouro inteiras:\n",
							SkillTree.fullGoldRockChance.ToString("F2"),
							"%->",
							num4.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления полных золотых камней:\n",
							SkillTree.fullGoldRockChance.ToString("F2"),
							"%->",
							num4.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升完整金矿石生成概率：\n",
							SkillTree.fullGoldRockChance.ToString("F2"),
							"%->",
							num4.ToString("F2"),
							"%"
						});
					}
				}
			}
		}
		else if (upgradeType == 4)
		{
			bool flag4 = false;
			bool flag5 = false;
			if (upgradeName == "CopperSpawn")
			{
				flag4 = true;
			}
			else if (upgradeName == "CopperChunk1")
			{
				flag5 = true;
				LocalizationScript.copperRockChanceIncrease = 0.3f;
			}
			else if (upgradeName == "CopperChunk2")
			{
				flag5 = true;
				LocalizationScript.copperRockChanceIncrease = 0.3f;
			}
			else if (upgradeName == "CopperChunk3")
			{
				flag5 = true;
				LocalizationScript.copperRockChanceIncrease = 0.4f;
			}
			else if (upgradeName == "FullCopper1")
			{
				flag5 = false;
				LocalizationScript.fullCopperRockChanceIncrease = 0.2f;
			}
			else if (upgradeName == "FullCopper2")
			{
				flag5 = false;
				LocalizationScript.fullCopperRockChanceIncrease = 0.2f;
			}
			else if (upgradeName == "FullCopper3")
			{
				flag5 = false;
				LocalizationScript.fullCopperRockChanceIncrease = 0.3f;
			}
			if (flag4)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Spawn Copper Rocks";
					this.skillTreeDesc_text.text = "Copper rocks will now start spawning!";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Apparition des Roches de Cuivre";
					this.skillTreeDesc_text.text = "Les roches de cuivre commenceront maintenant à apparaître !";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Genera Rocce di Rame";
					this.skillTreeDesc_text.text = "Le rocce di rame inizieranno a comparire!";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Kupfer-Steine erscheinen";
					this.skillTreeDesc_text.text = "Kupfer-Steine erscheinen jetzt!";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Generar Rocas de Cobre";
					this.skillTreeDesc_text.text = "¡Ahora comenzarán a aparecer rocas de cobre!";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "銅岩を生成";
					this.skillTreeDesc_text.text = "これから銅の岩が出現します！";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "구리 암석 생성";
					this.skillTreeDesc_text.text = "이제 구리 암석이 생성됩니다!";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Generuj Skały Miedzi";
					this.skillTreeDesc_text.text = "Skały miedzi zaczną się teraz pojawiać!";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Gerar Rochas de Cobre";
					this.skillTreeDesc_text.text = "As rochas de cobre começarão a aparecer!";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Появление Медных Камней";
					this.skillTreeDesc_text.text = "Медные камни теперь будут появляться!";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "生成铜矿石";
					this.skillTreeDesc_text.text = "铜矿石现在会开始生成！";
				}
			}
			else if (flag5)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Copper Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches de Cuivre";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Rame";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Kupfer-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Cobre";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "銅岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "구리 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Skał Miedzi";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Cobre";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Медных Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多铜矿石";
				}
				float num5 = SkillTree.copperRockChance + LocalizationScript.copperRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total copper chunk rock spawn chance:\n" + SkillTree.copperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches à morceaux de cuivre :\n" + SkillTree.copperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce a pezzi di rame:\n" + SkillTree.copperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für Kupferbrocken-Steine:\n" + SkillTree.copperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de trozos de cobre:\n" + SkillTree.copperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "銅チャンク岩の出現確率合計：\n" + SkillTree.copperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "구리 조각 암석 총 생성 확률:\n" + SkillTree.copperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się miedzianych brył:\n" + SkillTree.copperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de pedaços de cobre:\n" + SkillTree.copperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления медных глыб:\n" + SkillTree.copperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "铜块岩生成总概率：\n" + SkillTree.copperRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the copper chunk rock spawn chance:\n",
							SkillTree.copperRockChance.ToString("F2"),
							"% -> ",
							num5.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches à morceaux de cuivre :\n",
							SkillTree.copperRockChance.ToString("F2"),
							"% -> ",
							num5.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce a pezzi di rame:\n",
							SkillTree.copperRockChance.ToString("F2"),
							"% -> ",
							num5.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für Kupferbrocken-Steine:\n",
							SkillTree.copperRockChance.ToString("F2"),
							"% -> ",
							num5.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de trozos de cobre:\n",
							SkillTree.copperRockChance.ToString("F2"),
							"% -> ",
							num5.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"銅チャンク岩の出現確率を増加：\n",
							SkillTree.copperRockChance.ToString("F2"),
							"% -> ",
							num5.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"구리 조각 암석 생성 확률 증가:\n",
							SkillTree.copperRockChance.ToString("F2"),
							"% -> ",
							num5.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się miedzianych brył:\n",
							SkillTree.copperRockChance.ToString("F2"),
							"% -> ",
							num5.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de pedaços de cobre:\n",
							SkillTree.copperRockChance.ToString("F2"),
							"% -> ",
							num5.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления медных глыб:\n",
							SkillTree.copperRockChance.ToString("F2"),
							"% -> ",
							num5.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升铜块岩生成概率：\n",
							SkillTree.copperRockChance.ToString("F2"),
							"% -> ",
							num5.ToString("F2"),
							"%"
						});
					}
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Full Copper Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches de Cuivre Complètes";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Rame Piene";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Ganze Kupfer-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Cobre Completas";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "銅フル岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "전체 구리 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Pełnych Skał Miedzi";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Cobre Inteiras";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Полных Медных Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多完整铜矿石";
				}
				float num6 = SkillTree.fullCopperRockChance + LocalizationScript.fullCopperRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total full copper rock spawn chance:\n" + SkillTree.fullCopperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches de cuivre complètes :\n" + SkillTree.fullCopperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce di rame piene:\n" + SkillTree.fullCopperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für ganze Kupfer-Steine:\n" + SkillTree.fullCopperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de cobre completas:\n" + SkillTree.fullCopperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "銅フル岩の出現確率合計：\n" + SkillTree.fullCopperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "전체 구리 암석 총 생성 확률:\n" + SkillTree.fullCopperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się pełnych skał miedzi:\n" + SkillTree.fullCopperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de cobre inteiras:\n" + SkillTree.fullCopperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления полных медных камней:\n" + SkillTree.fullCopperRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "完整铜矿石生成总概率：\n" + SkillTree.fullCopperRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the full copper rock spawn chance:\n",
							SkillTree.fullCopperRockChance.ToString("F2"),
							"% -> ",
							num6.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches de cuivre complètes :\n",
							SkillTree.fullCopperRockChance.ToString("F2"),
							"% -> ",
							num6.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce di rame piene:\n",
							SkillTree.fullCopperRockChance.ToString("F2"),
							"% -> ",
							num6.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für ganze Kupfer-Steine:\n",
							SkillTree.fullCopperRockChance.ToString("F2"),
							"% -> ",
							num6.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de cobre completas:\n",
							SkillTree.fullCopperRockChance.ToString("F2"),
							"% -> ",
							num6.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"銅フル岩の出現確率を増加：\n",
							SkillTree.fullCopperRockChance.ToString("F2"),
							"% -> ",
							num6.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"전체 구리 암석 생성 확률 증가:\n",
							SkillTree.fullCopperRockChance.ToString("F2"),
							"% -> ",
							num6.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się pełnych skał miedzi:\n",
							SkillTree.fullCopperRockChance.ToString("F2"),
							"% -> ",
							num6.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de cobre inteiras:\n",
							SkillTree.fullCopperRockChance.ToString("F2"),
							"% -> ",
							num6.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления полных медных камней:\n",
							SkillTree.fullCopperRockChance.ToString("F2"),
							"% -> ",
							num6.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升完整铜矿石生成概率：\n",
							SkillTree.fullCopperRockChance.ToString("F2"),
							"% -> ",
							num6.ToString("F2"),
							"%"
						});
					}
				}
			}
		}
		else if (upgradeType == 5)
		{
			bool flag6 = false;
			bool flag7 = false;
			if (upgradeName == "IronSpawn")
			{
				flag6 = true;
			}
			else if (upgradeName == "IronChunk1")
			{
				flag7 = true;
				LocalizationScript.ironRockChanceIncrease = 0.2f;
			}
			else if (upgradeName == "IronChunk2")
			{
				flag7 = true;
				LocalizationScript.ironRockChanceIncrease = 0.3f;
			}
			else if (upgradeName == "FullIron1")
			{
				flag7 = false;
				LocalizationScript.fullIronRockChanceIncrease = 0.2f;
			}
			else if (upgradeName == "FullIron2")
			{
				flag7 = false;
				LocalizationScript.fullIronRockChanceIncrease = 0.2f;
			}
			if (flag6)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Spawn Iron Rocks";
					this.skillTreeDesc_text.text = "Iron rocks will now start spawning!";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Apparition des Roches de Fer";
					this.skillTreeDesc_text.text = "Les roches de fer commenceront maintenant à apparaître !";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Genera Rocce di Ferro";
					this.skillTreeDesc_text.text = "Le rocce di ferro inizieranno a comparire!";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Eisen-Steine erscheinen";
					this.skillTreeDesc_text.text = "Eisen-Steine erscheinen jetzt!";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Generar Rocas de Hierro";
					this.skillTreeDesc_text.text = "¡Ahora comenzarán a aparecer rocas de hierro!";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "鉄岩を生成";
					this.skillTreeDesc_text.text = "これから鉄の岩が出現します！";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "철 암석 생성";
					this.skillTreeDesc_text.text = "이제 철 암석이 생성됩니다!";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Generuj Skały Żelaza";
					this.skillTreeDesc_text.text = "Skały żelaza zaczną się teraz pojawiać!";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Gerar Rochas de Ferro";
					this.skillTreeDesc_text.text = "As rochas de ferro começarão a aparecer!";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Появление Железных Камней";
					this.skillTreeDesc_text.text = "Железные камни теперь будут появляться!";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "生成铁矿石";
					this.skillTreeDesc_text.text = "铁矿石现在会开始生成！";
				}
			}
			else if (flag7)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Iron Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches de Fer";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Ferro";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Eisen-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Hierro";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "鉄岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "철 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Skał Żelaza";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Ferro";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Железных Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多铁矿石";
				}
				float num7 = SkillTree.ironRockChance + LocalizationScript.ironRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total iron chunk rock spawn chance:\n" + SkillTree.ironRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches à morceaux de fer :\n" + SkillTree.ironRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce a pezzi di ferro:\n" + SkillTree.ironRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für Eisenbrocken-Steine:\n" + SkillTree.ironRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de trozos de hierro:\n" + SkillTree.ironRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "鉄チャンク岩の出現確率合計：\n" + SkillTree.ironRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "철 조각 암석 총 생성 확률:\n" + SkillTree.ironRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się brył żelaza:\n" + SkillTree.ironRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de pedaços de ferro:\n" + SkillTree.ironRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления железных глыб:\n" + SkillTree.ironRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "铁块岩生成总概率：\n" + SkillTree.ironRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the iron chunk rock spawn chance:\n",
							SkillTree.ironRockChance.ToString("F2"),
							"% -> ",
							num7.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches à morceaux de fer :\n",
							SkillTree.ironRockChance.ToString("F2"),
							"% -> ",
							num7.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce a pezzi di ferro:\n",
							SkillTree.ironRockChance.ToString("F2"),
							"% -> ",
							num7.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für Eisenbrocken-Steine:\n",
							SkillTree.ironRockChance.ToString("F2"),
							"% -> ",
							num7.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de trozos de hierro:\n",
							SkillTree.ironRockChance.ToString("F2"),
							"% -> ",
							num7.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"鉄チャンク岩の出現確率を増加：\n",
							SkillTree.ironRockChance.ToString("F2"),
							"% -> ",
							num7.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"철 조각 암석 생성 확률 증가:\n",
							SkillTree.ironRockChance.ToString("F2"),
							"% -> ",
							num7.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się brył żelaza:\n",
							SkillTree.ironRockChance.ToString("F2"),
							"% -> ",
							num7.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de pedaços de ferro:\n",
							SkillTree.ironRockChance.ToString("F2"),
							"% -> ",
							num7.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления железных глыб:\n",
							SkillTree.ironRockChance.ToString("F2"),
							"% -> ",
							num7.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升铁块岩生成概率：\n",
							SkillTree.ironRockChance.ToString("F2"),
							"% -> ",
							num7.ToString("F2"),
							"%"
						});
					}
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Full Iron Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches de Fer Complètes";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Ferro Piene";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Ganze Eisen-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Hierro Completas";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "鉄フル岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "전체 철 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Pełnych Skał Żelaza";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Ferro Inteiras";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Полных Железных Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多完整铁矿石";
				}
				float num8 = SkillTree.fullIronRockChance + LocalizationScript.fullIronRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total full iron rock spawn chance:\n" + SkillTree.fullIronRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches de fer complètes :\n" + SkillTree.fullIronRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce di ferro piene:\n" + SkillTree.fullIronRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für ganze Eisen-Steine:\n" + SkillTree.fullIronRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de hierro completas:\n" + SkillTree.fullIronRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "鉄フル岩の出現確率合計：\n" + SkillTree.fullIronRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "전체 철 암석 총 생성 확률:\n" + SkillTree.fullIronRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się pełnych skał żelaza:\n" + SkillTree.fullIronRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de ferro inteiras:\n" + SkillTree.fullIronRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления полных железных камней:\n" + SkillTree.fullIronRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "完整铁矿石生成总概率：\n" + SkillTree.fullIronRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the full iron rock spawn chance:\n",
							SkillTree.fullIronRockChance.ToString("F2"),
							"% -> ",
							num8.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches de fer complètes :\n",
							SkillTree.fullIronRockChance.ToString("F2"),
							"% -> ",
							num8.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce di ferro piene:\n",
							SkillTree.fullIronRockChance.ToString("F2"),
							"% -> ",
							num8.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für ganze Eisen-Steine:\n",
							SkillTree.fullIronRockChance.ToString("F2"),
							"% -> ",
							num8.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de hierro completas:\n",
							SkillTree.fullIronRockChance.ToString("F2"),
							"% -> ",
							num8.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"鉄フル岩の出現確率を増加：\n",
							SkillTree.fullIronRockChance.ToString("F2"),
							"% -> ",
							num8.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"전체 철 암석 생성 확률 증가:\n",
							SkillTree.fullIronRockChance.ToString("F2"),
							"% -> ",
							num8.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się pełnych skał żelaza:\n",
							SkillTree.fullIronRockChance.ToString("F2"),
							"% -> ",
							num8.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de ferro inteiras:\n",
							SkillTree.fullIronRockChance.ToString("F2"),
							"% -> ",
							num8.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления полных железных камней:\n",
							SkillTree.fullIronRockChance.ToString("F2"),
							"% -> ",
							num8.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升完整铁矿石生成概率：\n",
							SkillTree.fullIronRockChance.ToString("F2"),
							"% -> ",
							num8.ToString("F2"),
							"%"
						});
					}
				}
			}
		}
		else if (upgradeType == 6)
		{
			bool flag8 = false;
			bool flag9 = false;
			if (upgradeName == "CobaltSpawn")
			{
				flag8 = true;
			}
			else if (upgradeName == "CobaltChunk1")
			{
				flag9 = true;
				LocalizationScript.cobaltRockChanceIncrease = 0.2f;
			}
			else if (upgradeName == "CobaltFull1")
			{
				flag9 = false;
				LocalizationScript.fullCobaltRockChanceIncrease = 0.2f;
			}
			if (flag8)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Spawn Cobalt Rocks";
					this.skillTreeDesc_text.text = "Cobalt rocks will now start spawning!";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Apparition des Roches de Cobalt";
					this.skillTreeDesc_text.text = "Les roches de cobalt commenceront maintenant à apparaître !";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Genera Rocce di Cobalto";
					this.skillTreeDesc_text.text = "Le rocce di cobalto inizieranno a comparire!";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Kobalt-Steine erscheinen";
					this.skillTreeDesc_text.text = "Kobalt-Steine erscheinen jetzt!";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Generar Rocas de Cobalto";
					this.skillTreeDesc_text.text = "¡Ahora comenzarán a aparecer rocas de cobalto!";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "コバルト岩を生成";
					this.skillTreeDesc_text.text = "これからコバルトの岩が出現します！";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "코발트 암석 생성";
					this.skillTreeDesc_text.text = "이제 코발트 암석이 생성됩니다!";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Generuj Skały Kobaltu";
					this.skillTreeDesc_text.text = "Skały kobaltu zaczną się teraz pojawiać!";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Gerar Rochas de Cobalto";
					this.skillTreeDesc_text.text = "As rochas de cobalto começarão a aparecer!";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Появление Кобальтовых Камней";
					this.skillTreeDesc_text.text = "Кобальтовые камни теперь будут появляться!";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "生成钴矿石";
					this.skillTreeDesc_text.text = "钴矿石现在会开始生成！";
				}
			}
			else if (flag9)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Cobalt Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches de Cobalt";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Cobalto";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Kobalt-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Cobalto";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "コバルト岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "코발트 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Skał Kobaltu";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Cobalto";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Кобальтовых Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多钴矿石";
				}
				float num9 = SkillTree.cobaltRockChance + LocalizationScript.cobaltRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total cobalt chunk rock spawn chance:\n" + SkillTree.cobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches à morceaux de cobalt :\n" + SkillTree.cobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce a pezzi di cobalto:\n" + SkillTree.cobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für Kobaltbrocken-Steine:\n" + SkillTree.cobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de trozos de cobalto:\n" + SkillTree.cobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "コバルトチャンク岩の出現確率合計：\n" + SkillTree.cobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "코발트 조각 암석 총 생성 확률:\n" + SkillTree.cobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się brył kobaltu:\n" + SkillTree.cobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de pedaços de cobalto:\n" + SkillTree.cobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления кобальтовых глыб:\n" + SkillTree.cobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "钴块岩生成总概率：\n" + SkillTree.cobaltRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the cobalt chunk rock spawn chance:\n",
							SkillTree.cobaltRockChance.ToString("F2"),
							"% -> ",
							num9.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches à morceaux de cobalt :\n",
							SkillTree.cobaltRockChance.ToString("F2"),
							"% -> ",
							num9.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce a pezzi di cobalto:\n",
							SkillTree.cobaltRockChance.ToString("F2"),
							"% -> ",
							num9.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für Kobaltbrocken-Steine:\n",
							SkillTree.cobaltRockChance.ToString("F2"),
							"% -> ",
							num9.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de trozos de cobalto:\n",
							SkillTree.cobaltRockChance.ToString("F2"),
							"% -> ",
							num9.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"コバルトチャンク岩の出現確率を増加：\n",
							SkillTree.cobaltRockChance.ToString("F2"),
							"% -> ",
							num9.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"코발트 조각 암석 생성 확률 증가:\n",
							SkillTree.cobaltRockChance.ToString("F2"),
							"% -> ",
							num9.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się brył kobaltu:\n",
							SkillTree.cobaltRockChance.ToString("F2"),
							"% -> ",
							num9.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de pedaços de cobalto:\n",
							SkillTree.cobaltRockChance.ToString("F2"),
							"% -> ",
							num9.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления кобальтовых глыб:\n",
							SkillTree.cobaltRockChance.ToString("F2"),
							"% -> ",
							num9.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升钴块岩生成概率：\n",
							SkillTree.cobaltRockChance.ToString("F2"),
							"% -> ",
							num9.ToString("F2"),
							"%"
						});
					}
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Full Cobalt Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches de Cobalt Complètes";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Cobalto Piene";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Ganze Kobalt-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Cobalto Completas";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "コバルトフル岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "전체 코발트 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Pełnych Skał Kobaltu";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Cobalto Inteiras";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Полных Кобальтовых Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多完整钴矿石";
				}
				float num10 = SkillTree.fullCobaltRockChance + LocalizationScript.fullCobaltRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total full cobalt rock spawn chance:\n" + SkillTree.fullCobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches de cobalt complètes :\n" + SkillTree.fullCobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce di cobalto piene:\n" + SkillTree.fullCobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für ganze Kobalt-Steine:\n" + SkillTree.fullCobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de cobalto completas:\n" + SkillTree.fullCobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "コバルトフル岩の出現確率合計：\n" + SkillTree.fullCobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "전체 코발트 암석 총 생성 확률:\n" + SkillTree.fullCobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się pełnych skał kobaltu:\n" + SkillTree.fullCobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de cobalto inteiras:\n" + SkillTree.fullCobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления полных кобальтовых камней:\n" + SkillTree.fullCobaltRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "完整钴矿石生成总概率：\n" + SkillTree.fullCobaltRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the full cobalt rock spawn chance:\n",
							SkillTree.fullCobaltRockChance.ToString("F2"),
							"% -> ",
							num10.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches de cobalt complètes :\n",
							SkillTree.fullCobaltRockChance.ToString("F2"),
							"% -> ",
							num10.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce di cobalto piene:\n",
							SkillTree.fullCobaltRockChance.ToString("F2"),
							"% -> ",
							num10.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für ganze Kobalt-Steine:\n",
							SkillTree.fullCobaltRockChance.ToString("F2"),
							"% -> ",
							num10.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de cobalto completas:\n",
							SkillTree.fullCobaltRockChance.ToString("F2"),
							"% -> ",
							num10.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"コバルトフル岩の出現確率を増加：\n",
							SkillTree.fullCobaltRockChance.ToString("F2"),
							"% -> ",
							num10.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"전체 코발트 암석 생성 확률 증가:\n",
							SkillTree.fullCobaltRockChance.ToString("F2"),
							"% -> ",
							num10.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się pełnych skał kobaltu:\n",
							SkillTree.fullCobaltRockChance.ToString("F2"),
							"% -> ",
							num10.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de cobalto inteiras:\n",
							SkillTree.fullCobaltRockChance.ToString("F2"),
							"% -> ",
							num10.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления полных кобальтовых камней:\n",
							SkillTree.fullCobaltRockChance.ToString("F2"),
							"% -> ",
							num10.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升完整钴矿石生成概率：\n",
							SkillTree.fullCobaltRockChance.ToString("F2"),
							"% -> ",
							num10.ToString("F2"),
							"%"
						});
					}
				}
			}
		}
		else if (upgradeType == 7)
		{
			bool flag10 = false;
			bool flag11 = false;
			if (upgradeName == "UraniumSpawn")
			{
				flag10 = true;
			}
			else if (upgradeName == "UraniumChunk1")
			{
				flag11 = true;
				LocalizationScript.uraniumRockChanceIncrease = 0.1f;
			}
			else if (upgradeName == "FullUranium1")
			{
				flag11 = false;
				LocalizationScript.fullUraniumRockChanceIncrease = 0.1f;
			}
			if (flag10)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Spawn Uranium Rocks";
					this.skillTreeDesc_text.text = "Uranium rocks will now start spawning!";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Apparition des Roches d'Uranium";
					this.skillTreeDesc_text.text = "Les roches d'uranium commenceront maintenant à apparaître !";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Genera Rocce di Uranio";
					this.skillTreeDesc_text.text = "Le rocce di uranio inizieranno a comparire!";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Uran-Steine erscheinen";
					this.skillTreeDesc_text.text = "Uran-Steine erscheinen jetzt!";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Generar Rocas de Uranio";
					this.skillTreeDesc_text.text = "¡Ahora comenzarán a aparecer rocas de uranio!";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ウラン岩を生成";
					this.skillTreeDesc_text.text = "これからウランの岩が出現します！";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "우라늄 암석 생성";
					this.skillTreeDesc_text.text = "이제 우라늄 암석이 생성됩니다!";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Generuj Skały Uranu";
					this.skillTreeDesc_text.text = "Skały uranu zaczną się teraz pojawiać!";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Gerar Rochas de Urânio";
					this.skillTreeDesc_text.text = "As rochas de urânio começarão a aparecer!";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Появление Урановых Камней";
					this.skillTreeDesc_text.text = "Урановые камни теперь будут появляться!";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "生成铀矿石";
					this.skillTreeDesc_text.text = "铀矿石现在会开始生成！";
				}
			}
			else if (flag11)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Uranium Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches d'Uranium";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Uranio";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Uran-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Uranio";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ウラン岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "우라늄 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Skał Uranu";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Urânio";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Урановых Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多铀矿石";
				}
				float num11 = SkillTree.uraniumRockChance + LocalizationScript.uraniumRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total uranium chunk rock spawn chance:\n" + SkillTree.uraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches à morceaux d'uranium :\n" + SkillTree.uraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce a pezzi di uranio:\n" + SkillTree.uraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für Uranbrocken-Steine:\n" + SkillTree.uraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de trozos de uranio:\n" + SkillTree.uraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "ウランチャンク岩の出現確率合計：\n" + SkillTree.uraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "우라늄 조각 암석 총 생성 확률:\n" + SkillTree.uraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się brył uranu:\n" + SkillTree.uraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de pedaços de urânio:\n" + SkillTree.uraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления урановых глыб:\n" + SkillTree.uraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "铀块岩生成总概率：\n" + SkillTree.uraniumRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the uranium chunk rock spawn chance:\n",
							SkillTree.uraniumRockChance.ToString("F2"),
							"% -> ",
							num11.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches à morceaux d'uranium :\n",
							SkillTree.uraniumRockChance.ToString("F2"),
							"% -> ",
							num11.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce a pezzi di uranio:\n",
							SkillTree.uraniumRockChance.ToString("F2"),
							"% -> ",
							num11.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für Uranbrocken-Steine:\n",
							SkillTree.uraniumRockChance.ToString("F2"),
							"% -> ",
							num11.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de trozos de uranio:\n",
							SkillTree.uraniumRockChance.ToString("F2"),
							"% -> ",
							num11.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"ウランチャンク岩の出現確率を増加：\n",
							SkillTree.uraniumRockChance.ToString("F2"),
							"% -> ",
							num11.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"우라늄 조각 암석 생성 확률 증가:\n",
							SkillTree.uraniumRockChance.ToString("F2"),
							"% -> ",
							num11.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się brył uranu:\n",
							SkillTree.uraniumRockChance.ToString("F2"),
							"% -> ",
							num11.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de pedaços de urânio:\n",
							SkillTree.uraniumRockChance.ToString("F2"),
							"% -> ",
							num11.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления урановых глыб:\n",
							SkillTree.uraniumRockChance.ToString("F2"),
							"% -> ",
							num11.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升铀块岩生成概率：\n",
							SkillTree.uraniumRockChance.ToString("F2"),
							"% -> ",
							num11.ToString("F2"),
							"%"
						});
					}
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Full Uranium Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches d'Uranium Complètes";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Uranio Piene";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Ganze Uran-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Uranio Completas";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ウランフル岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "전체 우라늄 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Pełnych Skał Uranu";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Urânio Inteiras";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Полных Урановых Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多完整铀矿石";
				}
				float num12 = SkillTree.fullUraniumRockChance + LocalizationScript.fullUraniumRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total full uranium rock spawn chance:\n" + SkillTree.fullUraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches d'uranium complètes :\n" + SkillTree.fullUraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce di uranio piene:\n" + SkillTree.fullUraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für ganze Uran-Steine:\n" + SkillTree.fullUraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de uranio completas:\n" + SkillTree.fullUraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "ウランフル岩の出現確率合計：\n" + SkillTree.fullUraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "전체 우라늄 암석 총 생성 확률:\n" + SkillTree.fullUraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się pełnych skał uranu:\n" + SkillTree.fullUraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de urânio inteiras:\n" + SkillTree.fullUraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления полных урановых камней:\n" + SkillTree.fullUraniumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "完整铀矿石生成总概率：\n" + SkillTree.fullUraniumRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the full uranium rock spawn chance:\n",
							SkillTree.fullUraniumRockChance.ToString("F2"),
							"% -> ",
							num12.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches d'uranium complètes :\n",
							SkillTree.fullUraniumRockChance.ToString("F2"),
							"% -> ",
							num12.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce di uranio piene:\n",
							SkillTree.fullUraniumRockChance.ToString("F2"),
							"% -> ",
							num12.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für ganze Uran-Steine:\n",
							SkillTree.fullUraniumRockChance.ToString("F2"),
							"% -> ",
							num12.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de uranio completas:\n",
							SkillTree.fullUraniumRockChance.ToString("F2"),
							"% -> ",
							num12.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"ウランフル岩の出現確率を増加：\n",
							SkillTree.fullUraniumRockChance.ToString("F2"),
							"% -> ",
							num12.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"전체 우라늄 암석 생성 확률 증가:\n",
							SkillTree.fullUraniumRockChance.ToString("F2"),
							"% -> ",
							num12.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się pełnych skał uranu:\n",
							SkillTree.fullUraniumRockChance.ToString("F2"),
							"% -> ",
							num12.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de urânio inteiras:\n",
							SkillTree.fullUraniumRockChance.ToString("F2"),
							"% -> ",
							num12.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления полных урановых камней:\n",
							SkillTree.fullUraniumRockChance.ToString("F2"),
							"% -> ",
							num12.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升完整铀矿石生成概率：\n",
							SkillTree.fullUraniumRockChance.ToString("F2"),
							"% -> ",
							num12.ToString("F2"),
							"%"
						});
					}
				}
			}
		}
		else if (upgradeType == 8)
		{
			bool flag12 = false;
			bool flag13 = false;
			if (upgradeName == "IsmiumSpawn")
			{
				flag12 = true;
			}
			else if (upgradeName == "IsmiumChunk1")
			{
				flag13 = true;
				LocalizationScript.ismiumRockChanceIncrease = 0.09f;
			}
			else if (upgradeName == "FullIsmium1")
			{
				flag13 = false;
				LocalizationScript.fullIsmiumRockChanceIncrease = 0.08f;
			}
			if (flag12)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Spawn Ismium Rocks";
					this.skillTreeDesc_text.text = "Ismium rocks will now start spawning!";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Apparition des Roches d'Ismium";
					this.skillTreeDesc_text.text = "Les roches d'ismium commenceront maintenant à apparaître !";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Genera Rocce di Ismio";
					this.skillTreeDesc_text.text = "Le rocce di ismio inizieranno a comparire!";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Ismium-Steine erscheinen";
					this.skillTreeDesc_text.text = "Ismium-Steine erscheinen jetzt!";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Generar Rocas de Ismio";
					this.skillTreeDesc_text.text = "¡Ahora comenzarán a aparecer rocas de ismio!";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "イズミウム岩を生成";
					this.skillTreeDesc_text.text = "これからイズミウムの岩が出現します！";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "이스미움 암석 생성";
					this.skillTreeDesc_text.text = "이제 이스미움 암석이 생성됩니다!";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Generuj Skały Ismium";
					this.skillTreeDesc_text.text = "Skały ismium zaczną się teraz pojawiać!";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Gerar Rochas de Ismium";
					this.skillTreeDesc_text.text = "As rochas de ismium começarão a aparecer!";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Появление Исмиумовых Камней";
					this.skillTreeDesc_text.text = "Исмиумовые камни теперь будут появляться!";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "生成铱锇矿石";
					this.skillTreeDesc_text.text = "铱锇矿石现在会开始生成！";
				}
			}
			else if (flag13)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Ismium Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches d'Ismium";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Ismio";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Ismium-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Ismio";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "イズミウム岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "이스미움 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Skał Ismium";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Ismium";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Исмиумовых Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多铱锇矿石";
				}
				float num13 = SkillTree.ismiumRockChance + LocalizationScript.ismiumRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total ismium chunk rock spawn chance:\n" + SkillTree.ismiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches à morceaux d'ismium :\n" + SkillTree.ismiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce a pezzi di ismio:\n" + SkillTree.ismiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für Ismiumbrocken-Steine:\n" + SkillTree.ismiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de trozos de ismio:\n" + SkillTree.ismiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "イズミウムチャンク岩の出現確率合計：\n" + SkillTree.ismiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "이스미움 조각 암석 총 생성 확률:\n" + SkillTree.ismiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się brył ismium:\n" + SkillTree.ismiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de pedaços de ismium:\n" + SkillTree.ismiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления исмиумовых глыб:\n" + SkillTree.ismiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "铱锇块矿石生成总概率：\n" + SkillTree.ismiumRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the ismium chunk rock spawn chance:\n",
							SkillTree.ismiumRockChance.ToString("F2"),
							"% -> ",
							num13.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches à morceaux d'ismium :\n",
							SkillTree.ismiumRockChance.ToString("F2"),
							"% -> ",
							num13.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce a pezzi di ismio:\n",
							SkillTree.ismiumRockChance.ToString("F2"),
							"% -> ",
							num13.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für Ismiumbrocken-Steine:\n",
							SkillTree.ismiumRockChance.ToString("F2"),
							"% -> ",
							num13.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de trozos de ismio:\n",
							SkillTree.ismiumRockChance.ToString("F2"),
							"% -> ",
							num13.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"イズミウムチャンク岩の出現確率を増加：\n",
							SkillTree.ismiumRockChance.ToString("F2"),
							"% -> ",
							num13.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"이스미움 조각 암석 생성 확률 증가:\n",
							SkillTree.ismiumRockChance.ToString("F2"),
							"% -> ",
							num13.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się brył ismium:\n",
							SkillTree.ismiumRockChance.ToString("F2"),
							"% -> ",
							num13.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de pedaços de ismium:\n",
							SkillTree.ismiumRockChance.ToString("F2"),
							"% -> ",
							num13.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления исмиумовых глыб:\n",
							SkillTree.ismiumRockChance.ToString("F2"),
							"% -> ",
							num13.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升铱锇块矿石生成概率：\n",
							SkillTree.ismiumRockChance.ToString("F2"),
							"% -> ",
							num13.ToString("F2"),
							"%"
						});
					}
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Full Ismium Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches d'Ismium Complètes";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Ismio Piene";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Ganze Ismium-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Ismio Completas";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "イズミウムフル岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "전체 이스미움 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Pełnych Skał Ismium";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Ismium Inteiras";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Полных Исмиумовых Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多完整铱锇矿石";
				}
				float num14 = SkillTree.fullIsmiumRockChance + LocalizationScript.fullIsmiumRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total full ismium rock spawn chance:\n" + SkillTree.fullIsmiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches d'ismium complètes :\n" + SkillTree.fullIsmiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce di ismio piene:\n" + SkillTree.fullIsmiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für ganze Ismium-Steine:\n" + SkillTree.fullIsmiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de ismio completas:\n" + SkillTree.fullIsmiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "イズミウムフル岩の出現確率合計：\n" + SkillTree.fullIsmiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "전체 이스미움 암석 총 생성 확률:\n" + SkillTree.fullIsmiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się pełnych skał ismium:\n" + SkillTree.fullIsmiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de ismium inteiras:\n" + SkillTree.fullIsmiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления полных исмиумовых камней:\n" + SkillTree.fullIsmiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "完整铱锇矿石生成总概率：\n" + SkillTree.fullIsmiumRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the full ismium rock spawn chance:\n",
							SkillTree.fullIsmiumRockChance.ToString("F2"),
							"% -> ",
							num14.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches d'ismium complètes :\n",
							SkillTree.fullIsmiumRockChance.ToString("F2"),
							"% -> ",
							num14.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce di ismio piene:\n",
							SkillTree.fullIsmiumRockChance.ToString("F2"),
							"% -> ",
							num14.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für ganze Ismium-Steine:\n",
							SkillTree.fullIsmiumRockChance.ToString("F2"),
							"% -> ",
							num14.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de ismio completas:\n",
							SkillTree.fullIsmiumRockChance.ToString("F2"),
							"% -> ",
							num14.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"イズミウムフル岩の出現確率を増加：\n",
							SkillTree.fullIsmiumRockChance.ToString("F2"),
							"% -> ",
							num14.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"전체 이스미움 암석 생성 확률 증가:\n",
							SkillTree.fullIsmiumRockChance.ToString("F2"),
							"% -> ",
							num14.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się pełnych skał ismium:\n",
							SkillTree.fullIsmiumRockChance.ToString("F2"),
							"% -> ",
							num14.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de ismium inteiras:\n",
							SkillTree.fullIsmiumRockChance.ToString("F2"),
							"% -> ",
							num14.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления полных исмиумовых камней:\n",
							SkillTree.fullIsmiumRockChance.ToString("F2"),
							"% -> ",
							num14.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升完整铱锇矿石生成概率：\n",
							SkillTree.fullIsmiumRockChance.ToString("F2"),
							"% -> ",
							num14.ToString("F2"),
							"%"
						});
					}
				}
			}
		}
		else if (upgradeType == 9)
		{
			bool flag14 = false;
			bool flag15 = false;
			if (upgradeName == "IridiumSpawn")
			{
				flag14 = true;
			}
			else if (upgradeName == "IridiumChunk1")
			{
				flag15 = true;
				LocalizationScript.iridiumRockChanceIncrease = 0.08f;
			}
			else if (upgradeName == "IridiumFull1")
			{
				flag15 = false;
				LocalizationScript.fullIridiumRockChanceIncrease = 0.07f;
			}
			if (flag14)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Spawn Iridium Rocks";
					this.skillTreeDesc_text.text = "Iridium rocks will now start spawning!";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Apparition des Roches d'Iridium";
					this.skillTreeDesc_text.text = "Les roches d'iridium commenceront maintenant à apparaître !";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Genera Rocce di Iridio";
					this.skillTreeDesc_text.text = "Le rocce di iridio inizieranno a comparire!";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Iridium-Steine erscheinen";
					this.skillTreeDesc_text.text = "Iridium-Steine erscheinen jetzt!";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Generar Rocas de Iridio";
					this.skillTreeDesc_text.text = "¡Ahora comenzarán a aparecer rocas de iridio!";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "イリジウム岩を生成";
					this.skillTreeDesc_text.text = "これからイリジウムの岩が出現します！";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "이리듐 암석 생성";
					this.skillTreeDesc_text.text = "이제 이리듐 암석이 생성됩니다!";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Generuj Skały Irydowe";
					this.skillTreeDesc_text.text = "Skały irydowe zaczną się teraz pojawiać!";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Gerar Rochas de Irídio";
					this.skillTreeDesc_text.text = "As rochas de irídio começarão a aparecer!";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Появление Иридиевых Камней";
					this.skillTreeDesc_text.text = "Иридиевые камни теперь будут появляться!";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "生成铱矿石";
					this.skillTreeDesc_text.text = "铱矿石现在会开始生成！";
				}
			}
			else if (flag15)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Iridium Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches d'Iridium";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Iridio";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Iridium-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Iridio";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "イリジウム岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "이리듐 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Skał Irydowych";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Irídio";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Иридиевых Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多铱矿石";
				}
				float num15 = SkillTree.iridiumRockChance + LocalizationScript.iridiumRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total iridium chunk rock spawn chance:\n" + SkillTree.iridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches à morceaux d'iridium :\n" + SkillTree.iridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce a pezzi di iridio:\n" + SkillTree.iridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für Iridiumbrocken-Steine:\n" + SkillTree.iridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de trozos de iridio:\n" + SkillTree.iridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "イリジウムチャンク岩の出現確率合計：\n" + SkillTree.iridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "이리듐 조각 암석 총 생성 확률:\n" + SkillTree.iridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się brył irydu:\n" + SkillTree.iridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de pedaços de irídio:\n" + SkillTree.iridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления иридиевых глыб:\n" + SkillTree.iridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "铱块矿石生成总概率：\n" + SkillTree.iridiumRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the iridium chunk rock spawn chance:\n",
							SkillTree.iridiumRockChance.ToString("F2"),
							"% -> ",
							num15.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches à morceaux d'iridium :\n",
							SkillTree.iridiumRockChance.ToString("F2"),
							"% -> ",
							num15.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce a pezzi di iridio:\n",
							SkillTree.iridiumRockChance.ToString("F2"),
							"% -> ",
							num15.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für Iridiumbrocken-Steine:\n",
							SkillTree.iridiumRockChance.ToString("F2"),
							"% -> ",
							num15.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de trozos de iridio:\n",
							SkillTree.iridiumRockChance.ToString("F2"),
							"% -> ",
							num15.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"イリジウムチャンク岩の出現確率を増加：\n",
							SkillTree.iridiumRockChance.ToString("F2"),
							"% -> ",
							num15.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"이리듐 조각 암석 생성 확률 증가:\n",
							SkillTree.iridiumRockChance.ToString("F2"),
							"% -> ",
							num15.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się brył irydu:\n",
							SkillTree.iridiumRockChance.ToString("F2"),
							"% -> ",
							num15.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de pedaços de irídio:\n",
							SkillTree.iridiumRockChance.ToString("F2"),
							"% -> ",
							num15.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления иридиевых глыб:\n",
							SkillTree.iridiumRockChance.ToString("F2"),
							"% -> ",
							num15.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升铱块矿石生成概率：\n",
							SkillTree.iridiumRockChance.ToString("F2"),
							"% -> ",
							num15.ToString("F2"),
							"%"
						});
					}
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Full Iridium Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches d'Iridium Complètes";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Iridio Piene";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Ganze Iridium-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Iridio Completas";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "イリジウムフル岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "전체 이리듐 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Pełnych Skał Irydowych";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Irídio Inteiras";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Полных Иридиевых Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多完整铱矿石";
				}
				float num16 = SkillTree.fullIridiumRockChance + LocalizationScript.fullIridiumRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total full iridium rock spawn chance:\n" + SkillTree.fullIridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches d'iridium complètes :\n" + SkillTree.fullIridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce di iridio piene:\n" + SkillTree.fullIridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für ganze Iridium-Steine:\n" + SkillTree.fullIridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de iridio completas:\n" + SkillTree.fullIridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "イリジウムフル岩の出現確率合計：\n" + SkillTree.fullIridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "전체 이리듐 암석 총 생성 확률:\n" + SkillTree.fullIridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się pełnych skał irydu:\n" + SkillTree.fullIridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de irídio inteiras:\n" + SkillTree.fullIridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления полных иридиевых камней:\n" + SkillTree.fullIridiumRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "完整铱矿石生成总概率：\n" + SkillTree.fullIridiumRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the full iridium rock spawn chance:\n",
							SkillTree.fullIridiumRockChance.ToString("F2"),
							"% -> ",
							num16.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches d'iridium complètes :\n",
							SkillTree.fullIridiumRockChance.ToString("F2"),
							"% -> ",
							num16.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce di iridio piene:\n",
							SkillTree.fullIridiumRockChance.ToString("F2"),
							"% -> ",
							num16.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für ganze Iridium-Steine:\n",
							SkillTree.fullIridiumRockChance.ToString("F2"),
							"% -> ",
							num16.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de iridio completas:\n",
							SkillTree.fullIridiumRockChance.ToString("F2"),
							"% -> ",
							num16.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"イリジウムフル岩の出現確率を増加：\n",
							SkillTree.fullIridiumRockChance.ToString("F2"),
							"% -> ",
							num16.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"전체 이리듐 암석 생성 확률 증가:\n",
							SkillTree.fullIridiumRockChance.ToString("F2"),
							"% -> ",
							num16.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się pełnych skał irydu:\n",
							SkillTree.fullIridiumRockChance.ToString("F2"),
							"% -> ",
							num16.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de irídio inteiras:\n",
							SkillTree.fullIridiumRockChance.ToString("F2"),
							"% -> ",
							num16.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления полных иридиевых камней:\n",
							SkillTree.fullIridiumRockChance.ToString("F2"),
							"% -> ",
							num16.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升完整铱矿石生成概率：\n",
							SkillTree.fullIridiumRockChance.ToString("F2"),
							"% -> ",
							num16.ToString("F2"),
							"%"
						});
					}
				}
			}
		}
		else if (upgradeType == 10)
		{
			bool flag16 = false;
			bool flag17 = false;
			if (upgradeName == "PainiteSpawn")
			{
				flag16 = true;
			}
			else if (upgradeName == "PainiteChunk1")
			{
				flag17 = true;
				LocalizationScript.painiteRockChanceIncrease = 0.06f;
			}
			else if (upgradeName == "FullPainite1")
			{
				flag17 = false;
				LocalizationScript.fullPainiteRockChanceIncrease = 0.05f;
			}
			if (flag16)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Spawn Painite Rocks";
					this.skillTreeDesc_text.text = "Painite rocks will now start spawning!";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Apparition des Roches de Painite";
					this.skillTreeDesc_text.text = "Les roches de painite commenceront maintenant à apparaître !";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Genera Rocce di Painite";
					this.skillTreeDesc_text.text = "Le rocce di painite inizieranno a comparire!";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Painit-Steine erscheinen";
					this.skillTreeDesc_text.text = "Painit-Steine erscheinen jetzt!";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Generar Rocas de Painita";
					this.skillTreeDesc_text.text = "¡Ahora comenzarán a aparecer rocas de painita!";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ペイン石岩を生成";
					this.skillTreeDesc_text.text = "これからペイン石の岩が出現します！";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "페인石 암석 생성";
					this.skillTreeDesc_text.text = "이제 페인石 암석이 생성됩니다!";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Generuj Skały Painitu";
					this.skillTreeDesc_text.text = "Skały painitu zaczną się teraz pojawiać!";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Gerar Rochas de Painita";
					this.skillTreeDesc_text.text = "As rochas de painita começarão a aparecer!";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Появление Пайнитовых Камней";
					this.skillTreeDesc_text.text = "Пайнитовые камни теперь будут появляться!";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "生成电气石矿石";
					this.skillTreeDesc_text.text = "电气石矿石现在会开始生成！";
				}
			}
			else if (flag17)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Painite Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches de Painite";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Painite";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Painit-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Painita";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ペイン石岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "페인石 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Skał Painitu";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Painita";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Пайнитовых Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多电气石矿石";
				}
				float num17 = SkillTree.painiteRockChance + LocalizationScript.painiteRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total painite chunk rock spawn chance:\n" + SkillTree.painiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches à morceaux de painite :\n" + SkillTree.painiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce a pezzi di painite:\n" + SkillTree.painiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für Painitbrocken-Steine:\n" + SkillTree.painiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de trozos de painita:\n" + SkillTree.painiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "ペイン石チャンク岩の出現確率合計：\n" + SkillTree.painiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "페인石 조각 암석 총 생성 확률:\n" + SkillTree.painiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się brył painitu:\n" + SkillTree.painiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de pedaços de painita:\n" + SkillTree.painiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления пайнитовых глыб:\n" + SkillTree.painiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "电气石块矿石生成总概率：\n" + SkillTree.painiteRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the painite chunk rock spawn chance:\n",
							SkillTree.painiteRockChance.ToString("F2"),
							"% -> ",
							num17.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches à morceaux de painite :\n",
							SkillTree.painiteRockChance.ToString("F2"),
							"% -> ",
							num17.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce a pezzi di painite:\n",
							SkillTree.painiteRockChance.ToString("F2"),
							"% -> ",
							num17.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für Painitbrocken-Steine:\n",
							SkillTree.painiteRockChance.ToString("F2"),
							"% -> ",
							num17.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de trozos de painita:\n",
							SkillTree.painiteRockChance.ToString("F2"),
							"% -> ",
							num17.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"ペイン石チャンク岩の出現確率を増加：\n",
							SkillTree.painiteRockChance.ToString("F2"),
							"% -> ",
							num17.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"페인石 조각 암석 생성 확률 증가:\n",
							SkillTree.painiteRockChance.ToString("F2"),
							"% -> ",
							num17.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się brył painitu:\n",
							SkillTree.painiteRockChance.ToString("F2"),
							"% -> ",
							num17.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de pedaços de painita:\n",
							SkillTree.painiteRockChance.ToString("F2"),
							"% -> ",
							num17.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления пайнитовых глыб:\n",
							SkillTree.painiteRockChance.ToString("F2"),
							"% -> ",
							num17.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升电气石块矿石生成概率：\n",
							SkillTree.painiteRockChance.ToString("F2"),
							"% -> ",
							num17.ToString("F2"),
							"%"
						});
					}
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Full Painite Rocks";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches de Painite Complètes";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Painite Piene";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Ganze Painit-Steine";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Painita Completas";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ペイン石フル岩増加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "전체 페인石 암석 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Pełnych Skał Painitu";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Painita Inteiras";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Полных Пайнитовых Камней";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多完整电气石矿石";
				}
				float num18 = SkillTree.fullPainiteRockChance + LocalizationScript.fullPainiteRockChanceIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total full painite rock spawn chance:\n" + SkillTree.fullPainiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition totale des roches de painite complètes :\n" + SkillTree.fullPainiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di spawn di rocce di painite piene:\n" + SkillTree.fullPainiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance für ganze Painit-Steine:\n" + SkillTree.fullPainiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de aparición de rocas de painita completas:\n" + SkillTree.fullPainiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "ペイン石フル岩の出現確率合計：\n" + SkillTree.fullPainiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "전체 페인石 암석 총 생성 확률:\n" + SkillTree.fullPainiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się pełnych skał painitu:\n" + SkillTree.fullPainiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de surgimento de rochas de painita inteiras:\n" + SkillTree.fullPainiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс появления полных пайнитовых камней:\n" + SkillTree.fullPainiteRockChance.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "完整电气石矿石生成总概率：\n" + SkillTree.fullPainiteRockChance.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the full painite rock spawn chance:\n",
							SkillTree.fullPainiteRockChance.ToString("F2"),
							"% -> ",
							num18.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la chance d'apparition des roches de painite complètes :\n",
							SkillTree.fullPainiteRockChance.ToString("F2"),
							"% -> ",
							num18.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilità di spawn di rocce di painite piene:\n",
							SkillTree.fullPainiteRockChance.ToString("F2"),
							"% -> ",
							num18.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Spawn-Chance für ganze Painit-Steine:\n",
							SkillTree.fullPainiteRockChance.ToString("F2"),
							"% -> ",
							num18.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la probabilidad de aparición de rocas de painita completas:\n",
							SkillTree.fullPainiteRockChance.ToString("F2"),
							"% -> ",
							num18.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"ペイン石フル岩の出現確率を増加：\n",
							SkillTree.fullPainiteRockChance.ToString("F2"),
							"% -> ",
							num18.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"전체 페인石 암석 생성 확률 증가:\n",
							SkillTree.fullPainiteRockChance.ToString("F2"),
							"% -> ",
							num18.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa szansę na pojawienie się pełnych skał painitu:\n",
							SkillTree.fullPainiteRockChance.ToString("F2"),
							"% -> ",
							num18.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta a chance de surgimento de rochas de painita inteiras:\n",
							SkillTree.fullPainiteRockChance.ToString("F2"),
							"% -> ",
							num18.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает шанс появления полных пайнитовых камней:\n",
							SkillTree.fullPainiteRockChance.ToString("F2"),
							"% -> ",
							num18.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升完整电气石矿石生成概率：\n",
							SkillTree.fullPainiteRockChance.ToString("F2"),
							"% -> ",
							num18.ToString("F2"),
							"%"
						});
					}
				}
			}
		}
		else if (upgradeType == 11)
		{
			bool flag18 = false;
			bool flag19 = false;
			if (upgradeName == "LightningChanceS1")
			{
				LocalizationScript.lightningTriggerChanceS_Increase = 10f;
				flag18 = true;
			}
			else if (upgradeName == "LightningChanceS2")
			{
				LocalizationScript.lightningTriggerChanceS_Increase = 10f;
				flag18 = true;
			}
			else if (upgradeName == "LightningChancePH1")
			{
				LocalizationScript.lightningTriggerChancePH_Increase = 0.07f;
				flag19 = true;
			}
			else if (upgradeName == "LightningChancePH2")
			{
				LocalizationScript.lightningTriggerChancePH_Increase = 0.08f;
				flag19 = true;
			}
			float num19 = SkillTree.lightningTriggerChanceS + LocalizationScript.lightningTriggerChanceS_Increase;
			float num20 = SkillTree.lightningTriggerChancePH + LocalizationScript.lightningTriggerChancePH_Increase;
			if (flag18)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Lightning Beam!";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Rayon Fulgurant !";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Raggio Fulmineo!";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Blitzstrahl!";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Rayo Relámpago!";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ライトニングビーム！";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "번개 빔!";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Promień Błyskawicy!";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Raio Relâmpago!";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Луч Молнии!";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "闪电光束！";
				}
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total chance to spawn a lightning beam every second:\n" + SkillTree.lightningTriggerChanceS.ToString("F0") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance totale de générer un rayon fulgurant chaque seconde :\n" + SkillTree.lightningTriggerChanceS.ToString("F0") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di generare un raggio fulmineo ogni secondo:\n" + SkillTree.lightningTriggerChanceS.ToString("F0") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance, jede Sekunde einen Blitzstrahl zu erzeugen:\n" + SkillTree.lightningTriggerChanceS.ToString("F0") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de generar un rayo relámpago cada segundo:\n" + SkillTree.lightningTriggerChanceS.ToString("F0") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "毎秒ライトニングビームが発生する総確率：\n" + SkillTree.lightningTriggerChanceS.ToString("F0") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "매초 번개 빔이 생성될 총 확률:\n" + SkillTree.lightningTriggerChanceS.ToString("F0") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na wywołanie promienia błyskawicy co sekundę:\n" + SkillTree.lightningTriggerChanceS.ToString("F0") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de gerar um raio relâmpago a cada segundo:\n" + SkillTree.lightningTriggerChanceS.ToString("F0") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс вызвать луч молнии каждую секунду:\n" + SkillTree.lightningTriggerChanceS.ToString("F0") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "每秒触发闪电光束的总概率：\n" + SkillTree.lightningTriggerChanceS.ToString("F0") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=23>Every second, chance to spawn a lightning beam at a random rock.\n",
							SkillTree.lightningTriggerChanceS.ToString("F0"),
							"% -> ",
							num19.ToString("F0"),
							"% The beam deals 3X your pickaxe power"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=23>Chaque seconde, chance de générer un rayon fulgurant sur une roche aléatoire.\n",
							SkillTree.lightningTriggerChanceS.ToString("F0"),
							"% -> ",
							num19.ToString("F0"),
							"% Le rayon inflige 3X la puissance de votre pioche"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=23>Ogni secondo, possibilità di generare un raggio fulmineo su una roccia casuale.\n",
							SkillTree.lightningTriggerChanceS.ToString("F0"),
							"% -> ",
							num19.ToString("F0"),
							"% Il raggio infligge 3X la potenza del tuo piccone"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=23>Jede Sekunde Chance, einen Blitzstrahl auf einen zufälligen Stein zu erzeugen.\n",
							SkillTree.lightningTriggerChanceS.ToString("F0"),
							"% -> ",
							num19.ToString("F0"),
							"% Der Strahl verursacht 3X deine Spitzhackenstärke"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=23>Cada segundo, probabilidad de generar un rayo relámpago en una roca aleatoria.\n",
							SkillTree.lightningTriggerChanceS.ToString("F0"),
							"% -> ",
							num19.ToString("F0"),
							"% El rayo inflige 3X la potencia de tu pico"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=24>毎秒、ランダムな岩にライトニングビームを発生させる確率。\n",
							SkillTree.lightningTriggerChanceS.ToString("F0"),
							"% -> ",
							num19.ToString("F0"),
							"% ビームはピッケルのパワーの3倍のダメージを与える"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"매초 무작위 암석에 번개 빔이 생성될 확률.\n",
							SkillTree.lightningTriggerChanceS.ToString("F0"),
							"% -> ",
							num19.ToString("F0"),
							"% 빔은 곡괭이 파워의 3배 피해를 입힘"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=24>Co sekundę szansa na pojawienie się promienia błyskawicy na losowej skale.\n",
							SkillTree.lightningTriggerChanceS.ToString("F0"),
							"% -> ",
							num19.ToString("F0"),
							"% Promień zadaje 3X moc kilofa"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=24>A cada segundo, chance de gerar um raio relâmpago em uma rocha aleatória.\n",
							SkillTree.lightningTriggerChanceS.ToString("F0"),
							"% -> ",
							num19.ToString("F0"),
							"% O raio causa 3X o poder da sua picareta"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=24>Каждую секунду шанс вызвать луч молнии на случайном камне.\n",
							SkillTree.lightningTriggerChanceS.ToString("F0"),
							"% -> ",
							num19.ToString("F0"),
							"% Луч наносит 3X силу вашей кирки"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"每秒有机会在随机岩石上生成闪电光束。\n",
							SkillTree.lightningTriggerChanceS.ToString("F0"),
							"% -> ",
							num19.ToString("F0"),
							"% 光束造成相当于你镐子威力3倍的伤害"
						});
					}
				}
			}
			if (flag19)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Pickaxe Lightning!";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Foudre de Pioche !";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Fulmine del Piccone!";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Spitzhacken-Blitz!";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Rayo del Pico!";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ピッケルライトニング！";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "곡괭이 번개!";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Błyskawica Kilofa!";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Relâmpago da Picareta!";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Молния Кирки!";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "镐子闪电！";
				}
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total chance to spawn a lightning beam every pickaxe hit:\n" + SkillTree.lightningTriggerChancePH.ToString("F1") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance totale de générer un rayon fulgurant à chaque coup de pioche :\n" + SkillTree.lightningTriggerChancePH.ToString("F1") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di generare un raggio fulmineo a ogni colpo di piccone:\n" + SkillTree.lightningTriggerChancePH.ToString("F1") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance, bei jedem Spitzhacken-Schlag einen Blitzstrahl zu erzeugen:\n" + SkillTree.lightningTriggerChancePH.ToString("F1") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de generar un rayo relámpago con cada golpe de pico:\n" + SkillTree.lightningTriggerChancePH.ToString("F1") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "ピッケルの一振りごとにライトニングビームが発生する総確率：\n" + SkillTree.lightningTriggerChancePH.ToString("F1") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "곡괭이 타격마다 번개 빔이 생성될 총 확률:\n" + SkillTree.lightningTriggerChancePH.ToString("F1") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na wywołanie promienia błyskawicy przy każdym uderzeniu kilofa:\n" + SkillTree.lightningTriggerChancePH.ToString("F1") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de gerar um raio relâmpago a cada golpe de picareta:\n" + SkillTree.lightningTriggerChancePH.ToString("F1") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс вызвать луч молнии при каждом ударе киркой:\n" + SkillTree.lightningTriggerChancePH.ToString("F1") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "每次镐子敲击时生成闪电光束的总概率：\n" + SkillTree.lightningTriggerChancePH.ToString("F1") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Every pickaxe hit, chance to spawn a lightning beam at a close rock\n",
							SkillTree.lightningTriggerChancePH.ToString("F2"),
							"% -> ",
							num20.ToString("F2"),
							"% The beam deals 2X your pickaxe power"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=22>À chaque coup de pioche, chance de générer un rayon fulgurant sur une roche proche\n",
							SkillTree.lightningTriggerChancePH.ToString("F2"),
							"% -> ",
							num20.ToString("F2"),
							"% Le rayon inflige 2X la puissance de votre pioche"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=22>A ogni colpo di piccone, possibilità di generare un raggio fulmineo su una roccia vicina\n",
							SkillTree.lightningTriggerChancePH.ToString("F2"),
							"% -> ",
							num20.ToString("F2"),
							"% Il raggio infligge 2X la potenza del tuo piccone"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=22>Bei jedem Spitzhacken-Schlag Chance, einen Blitzstrahl auf einen nahen Stein zu erzeugen\n",
							SkillTree.lightningTriggerChancePH.ToString("F2"),
							"% -> ",
							num20.ToString("F2"),
							"% Der Strahl verursacht 2X deine Spitzhackenstärke"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=22>Con cada golpe de pico, probabilidad de generar un rayo relámpago en una roca cercana\n",
							SkillTree.lightningTriggerChancePH.ToString("F2"),
							"% -> ",
							num20.ToString("F2"),
							"% El rayo inflige 2X la potencia de tu pico"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=23>ピッケルの一振りごとに近くの岩にライトニングビームが発生する確率\n",
							SkillTree.lightningTriggerChancePH.ToString("F2"),
							"% -> ",
							num20.ToString("F2"),
							"% ビームはピッケルのパワーの2倍のダメージを与える"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"곡괭이 타격마다 근처 암석에 번개 빔이 생성될 확률\n",
							SkillTree.lightningTriggerChancePH.ToString("F2"),
							"% -> ",
							num20.ToString("F2"),
							"% 빔은 곡괭이 파워의 2배 피해를 입힘"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=23>Przy każdym uderzeniu kilofa szansa na wywołanie promienia błyskawicy na pobliskiej skale\n",
							SkillTree.lightningTriggerChancePH.ToString("F2"),
							"% -> ",
							num20.ToString("F2"),
							"% Promień zadaje 2X moc kilofa"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=23>A cada golpe de picareta, chance de gerar um raio relâmpago em uma rocha próxima\n",
							SkillTree.lightningTriggerChancePH.ToString("F2"),
							"% -> ",
							num20.ToString("F2"),
							"% O raio causa 2X o poder da sua picareta"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=23>При каждом ударе киркой шанс вызвать луч молнии на ближайшем камне\n",
							SkillTree.lightningTriggerChancePH.ToString("F2"),
							"% -> ",
							num20.ToString("F2"),
							"% Луч наносит 2X силу вашей кирки"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"每次镐子敲击时，有机会在附近岩石上生成闪电光束\n",
							SkillTree.lightningTriggerChancePH.ToString("F2"),
							"% -> ",
							num20.ToString("F2"),
							"% 光束造成相当于你镐子威力2倍的伤害"
						});
					}
				}
			}
			else if (upgradeName == "LightningSpawnAnotherChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Lightning = Lightning";
					this.skillTreeDesc_text.text = SkillTree.triggerAnotherLighntingChance.ToString("F0") + "% chance to spawn another lightning beam after each lightning beam hit";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Foudre = Foudre";
					this.skillTreeDesc_text.text = SkillTree.triggerAnotherLighntingChance.ToString("F0") + "% de chance de générer un autre rayon fulgurant après chaque impact de rayon";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Fulmine = Fulmine";
					this.skillTreeDesc_text.text = SkillTree.triggerAnotherLighntingChance.ToString("F0") + "% di possibilità di generare un altro raggio fulmineo dopo ogni colpo di raggio";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Blitz = Blitz";
					this.skillTreeDesc_text.text = SkillTree.triggerAnotherLighntingChance.ToString("F0") + "% Chance, nach jedem Blitzstrahl-Treffer einen weiteren zu erzeugen";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Rayo = Rayo";
					this.skillTreeDesc_text.text = SkillTree.triggerAnotherLighntingChance.ToString("F0") + "% de probabilidad de generar otro rayo relámpago después de cada impacto de rayo";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ライトニング = ライトニング";
					this.skillTreeDesc_text.text = "ライトニングビーム命中後、" + SkillTree.triggerAnotherLighntingChance.ToString("F0") + "%の確率で別のビームを発生";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "번개 = 번개";
					this.skillTreeDesc_text.text = "번개 빔이 적중할 때마다 " + SkillTree.triggerAnotherLighntingChance.ToString("F0") + "% 확률로 추가 번개 빔 생성";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Błyskawica = Błyskawica";
					this.skillTreeDesc_text.text = SkillTree.triggerAnotherLighntingChance.ToString("F0") + "% szansy na wygenerowanie kolejnego promienia po każdym trafieniu promieniem";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Relâmpago = Relâmpago";
					this.skillTreeDesc_text.text = SkillTree.triggerAnotherLighntingChance.ToString("F0") + "% de chance de gerar outro raio após cada impacto de raio";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Молния = Молния";
					this.skillTreeDesc_text.text = SkillTree.triggerAnotherLighntingChance.ToString("F0") + "% шанс вызвать ещё один луч молнии после каждого попадания луча";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "闪电 = 闪电";
					this.skillTreeDesc_text.text = "每次闪电光束命中后有 " + SkillTree.triggerAnotherLighntingChance.ToString("F0") + "% 的几率再生成一道闪电光束";
				}
			}
			else if (upgradeName == "LightningSplash")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Electricity Sparks";
					this.skillTreeDesc_text.text = string.Format("Every lightning beam has a {0}% chance to spawn 3-5 electricity sparks.\nEach spark deals {1}% of the lightning beam's power", SkillTree.lightningSplashChance.ToString("F0"), SkillTree.lightningSparkDamage);
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Étincelles Électriques";
					this.skillTreeDesc_text.text = string.Format("Chaque rayon fulgurant a {0}% de chance de générer 3 à 5 étincelles électriques.\nChaque étincelle inflige {1}% de la puissance du rayon", SkillTree.lightningSplashChance.ToString("F0"), SkillTree.lightningSparkDamage);
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Scintille Elettriche";
					this.skillTreeDesc_text.text = string.Format("Ogni raggio fulmineo ha il {0}% di probabilità di generare 3-5 scintille elettriche.\nOgni scintilla infligge il {1}% della potenza del raggio", SkillTree.lightningSplashChance.ToString("F0"), SkillTree.lightningSparkDamage);
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Elektrische Funken";
					this.skillTreeDesc_text.text = string.Format("Jeder Blitzstrahl hat eine Chance von {0}%, 3–5 elektrische Funken zu erzeugen.\nJeder Funke verursacht {1}% der Strahlstärke", SkillTree.lightningSplashChance.ToString("F0"), SkillTree.lightningSparkDamage);
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Chispas Eléctricas";
					this.skillTreeDesc_text.text = string.Format("Cada rayo relámpago tiene un {0}% de probabilidad de generar de 3 a 5 chispas eléctricas.\nCada chispa inflige el {1}% de la potencia del rayo", SkillTree.lightningSplashChance.ToString("F0"), SkillTree.lightningSparkDamage);
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "エレクトリックスパーク";
					this.skillTreeDesc_text.text = string.Format("ライトニングビームごとに{0}%の確率で3〜5個の電気スパークを生成。\n各スパークはビームパワーの{1}%のダメージを与える", SkillTree.lightningSplashChance.ToString("F0"), SkillTree.lightningSparkDamage);
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "전기 스파크";
					this.skillTreeDesc_text.text = string.Format("번개 빔마다 {0}% 확률로 3~5개의 전기 스파크 생성.\n각 스파크는 빔 파워의 {1}% 피해를 입힘", SkillTree.lightningSplashChance.ToString("F0"), SkillTree.lightningSparkDamage);
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Iskry Elektryczne";
					this.skillTreeDesc_text.text = string.Format("Każdy promień błyskawicy ma {0}% szansy na wygenerowanie 3–5 iskr elektrycznych.\nKażda iskra zadaje {1}% mocy promienia", SkillTree.lightningSplashChance.ToString("F0"), SkillTree.lightningSparkDamage);
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Faíscas Elétricas";
					this.skillTreeDesc_text.text = string.Format("Cada raio relâmpago tem {0}% de chance de gerar 3 a 5 faíscas elétricas.\nCada faísca causa {1}% do poder do raio", SkillTree.lightningSplashChance.ToString("F0"), SkillTree.lightningSparkDamage);
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Электрические Искры";
					this.skillTreeDesc_text.text = string.Format("Каждый луч молнии имеет {0}% шанс породить 3–5 электрических искр.\nКаждая искра наносит {1}% силы луча", SkillTree.lightningSplashChance.ToString("F0"), SkillTree.lightningSparkDamage);
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "电火花";
					this.skillTreeDesc_text.text = string.Format("每道闪电光束有 {0}% 的几率生成 3-5 个电火花。\n每个火花造成光束威力的 {1}% 伤害", SkillTree.lightningSplashChance.ToString("F0"), SkillTree.lightningSparkDamage);
				}
			}
			else if (upgradeName == "LightningSpawnRockChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Lightning = Rocks";
					this.skillTreeDesc_text.text = "Every lightning beam hit has a " + SkillTree.lightningSpawnRockChance.ToString("F0") + "% chance to spawn a rock.";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Foudre = Roches";
					this.skillTreeDesc_text.text = "Chaque impact de rayon fulgurant a " + SkillTree.lightningSpawnRockChance.ToString("F0") + "% de chance de générer une roche.";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Fulmine = Rocce";
					this.skillTreeDesc_text.text = "Ogni colpo di raggio fulmineo ha il " + SkillTree.lightningSpawnRockChance.ToString("F0") + "% di probabilità di generare una roccia.";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Blitz = Steine";
					this.skillTreeDesc_text.text = "Jeder Blitzstrahl-Treffer hat eine Chance von " + SkillTree.lightningSpawnRockChance.ToString("F0") + "%, einen Stein zu erzeugen.";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Rayo = Rocas";
					this.skillTreeDesc_text.text = "Cada impacto de rayo relámpago tiene un " + SkillTree.lightningSpawnRockChance.ToString("F0") + "% de probabilidad de generar una roca.";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ライトニング = 岩";
					this.skillTreeDesc_text.text = "ライトニングビーム命中ごとに" + SkillTree.lightningSpawnRockChance.ToString("F0") + "%の確率で岩を生成。";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "번개 = 암석";
					this.skillTreeDesc_text.text = "번개 빔이 적중할 때마다 " + SkillTree.lightningSpawnRockChance.ToString("F0") + "% 확률로 암석 생성.";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Błyskawica = Skały";
					this.skillTreeDesc_text.text = "Każde trafienie promieniem błyskawicy ma " + SkillTree.lightningSpawnRockChance.ToString("F0") + "% szansy na wygenerowanie skały.";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Relâmpago = Rochas";
					this.skillTreeDesc_text.text = "Cada impacto de raio relâmpago tem " + SkillTree.lightningSpawnRockChance.ToString("F0") + "% de chance de gerar uma rocha.";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Молния = Камни";
					this.skillTreeDesc_text.text = "Каждое попадание луча молнии имеет " + SkillTree.lightningSpawnRockChance.ToString("F0") + "% шанс породить камень.";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "闪电 = 岩石";
					this.skillTreeDesc_text.text = "每次闪电光束命中有 " + SkillTree.lightningSpawnRockChance.ToString("F0") + "% 的几率生成一块岩石。";
				}
			}
			else if (upgradeName == "LightningExplosionChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Lightning Explosion";
					this.skillTreeDesc_text.text = "Every lightning beam hit has a " + SkillTree.lightningSpawnExplosionChance.ToString("F0") + "% chance to trigger a dynamite explosion";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Explosion Fulgurante";
					this.skillTreeDesc_text.text = "<size=19>Chaque impact de rayon fulgurant a " + SkillTree.lightningSpawnExplosionChance.ToString("F0") + "% de chance de déclencher une explosion de dynamite";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Esplosione Fulminea";
					this.skillTreeDesc_text.text = "<size=21>Ogni colpo di raggio fulmineo ha il " + SkillTree.lightningSpawnExplosionChance.ToString("F0") + "% di probabilità di attivare un'esplosione di dinamite";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Blitzexplosion";
					this.skillTreeDesc_text.text = "<size=22>Jeder Blitzstrahl-Treffer hat eine Chance von " + SkillTree.lightningSpawnExplosionChance.ToString("F0") + "%, eine Dynamitexplosion auszulösen";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Explosión Relámpago";
					this.skillTreeDesc_text.text = "<size=22>Cada impacto de rayo relámpago tiene un " + SkillTree.lightningSpawnExplosionChance.ToString("F0") + "% de probabilidad de activar una explosión de dinamita";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ライトニングエクスプロージョン";
					this.skillTreeDesc_text.text = "ライトニングビーム命中ごとに" + SkillTree.lightningSpawnExplosionChance.ToString("F0") + "%の確率でダイナマイト爆発を発生させる";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "번개 폭발";
					this.skillTreeDesc_text.text = "번개 빔이 적중할 때마다 " + SkillTree.lightningSpawnExplosionChance.ToString("F0") + "% 확률로 다이너마이트 폭발 발생";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Eksplozja Błyskawicy";
					this.skillTreeDesc_text.text = "<size=22>Każde trafienie promieniem błyskawicy ma " + SkillTree.lightningSpawnExplosionChance.ToString("F0") + "% szansy na wywołanie eksplozji dynamitu";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Explosão Relâmpago";
					this.skillTreeDesc_text.text = "<size=22>Cada impacto de raio relâmpago tem " + SkillTree.lightningSpawnExplosionChance.ToString("F0") + "% de chance de ativar uma explosão de dinamite";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Молниеносный Взрыв";
					this.skillTreeDesc_text.text = "Каждое попадание луча молнии имеет " + SkillTree.lightningSpawnExplosionChance.ToString("F0") + "% шанс вызвать взрыв динамита";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "闪电爆炸";
					this.skillTreeDesc_text.text = "每次闪电光束命中有 " + SkillTree.lightningSpawnExplosionChance.ToString("F0") + "% 的几率触发炸药爆炸";
				}
			}
			else if (upgradeName == "LightningAddTimeChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Lightning = Time";
					this.skillTreeDesc_text.text = "Every lightning beam hit has a " + SkillTree.lightningAddTimeChance.ToString("F1") + "% chance to add 1 second to the timer";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Foudre = Temps";
					this.skillTreeDesc_text.text = "<size=22>Chaque impact de rayon fulgurant a " + SkillTree.lightningAddTimeChance.ToString("F1") + "% de chance d'ajouter 1 seconde au minuteur";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Fulmine = Tempo";
					this.skillTreeDesc_text.text = "<size=22>Ogni colpo di raggio fulmineo ha il " + SkillTree.lightningAddTimeChance.ToString("F1") + "% di probabilità di aggiungere 1 secondo al timer";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Blitz = Zeit";
					this.skillTreeDesc_text.text = "<size=22>Jeder Blitzstrahl-Treffer hat eine Chance von " + SkillTree.lightningAddTimeChance.ToString("F1") + "%, 1 Sekunde zum Timer hinzuzufügen";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Rayo = Tiempo";
					this.skillTreeDesc_text.text = "<size=22>Cada impacto de rayo relámpago tiene un " + SkillTree.lightningAddTimeChance.ToString("F1") + "% de probabilidad de añadir 1 segundo al temporizador";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ライトニング = タイム";
					this.skillTreeDesc_text.text = "ライトニングビーム命中ごとに" + SkillTree.lightningAddTimeChance.ToString("F1") + "%の確率でタイマーに1秒追加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "번개 = 시간";
					this.skillTreeDesc_text.text = "번개 빔이 적중할 때마다 " + SkillTree.lightningAddTimeChance.ToString("F1") + "% 확률로 타이머에 1초 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Błyskawica = Czas";
					this.skillTreeDesc_text.text = "<size=22>Każde trafienie promieniem błyskawicy ma " + SkillTree.lightningAddTimeChance.ToString("F1") + "% szansy na dodanie 1 sekundy do timera";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Relâmpago = Tempo";
					this.skillTreeDesc_text.text = "<size=22>Cada impacto de raio relâmpago tem " + SkillTree.lightningAddTimeChance.ToString("F1") + "% de chance de adicionar 1 segundo ao cronômetro";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Молния = Время";
					this.skillTreeDesc_text.text = "<size=23>Каждое попадание луча молнии имеет " + SkillTree.lightningAddTimeChance.ToString("F1") + "% шанс добавить 1 секунду к таймеру";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "闪电 = 时间";
					this.skillTreeDesc_text.text = "每次闪电光束命中有 " + SkillTree.lightningAddTimeChance.ToString("F1") + "% 的几率为计时器增加 1 秒";
				}
			}
			else if (upgradeName == "LightningDamage")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Lightning Damage";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Dégâts de Foudre";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Danno Fulmineo";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Blitzschaden";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Daño de Rayo";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ライトニングダメージ";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "번개 피해";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Obrażenia Błyskawicy";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Dano de Relâmpago";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Урон Молнии";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "闪电伤害";
				}
				LocalizationScript.lightningDamageIncrease = 0.2f;
				float num21 = SkillTree.lightningDamage + 1f + LocalizationScript.lightningDamageIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total lightning beam damage:\n" + ((SkillTree.lightningDamage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Dégâts totaux du rayon fulgurant :\n" + ((SkillTree.lightningDamage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Danno totale del raggio fulmineo:\n" + ((SkillTree.lightningDamage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamter Blitzstrahl-Schaden:\n" + ((SkillTree.lightningDamage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Daño total del rayo relámpago:\n" + ((SkillTree.lightningDamage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "ライトニングビームの総ダメージ：\n" + ((SkillTree.lightningDamage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "번개 빔 총 피해량:\n" + ((SkillTree.lightningDamage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączne obrażenia promienia błyskawicy:\n" + ((SkillTree.lightningDamage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Dano total do raio relâmpago:\n" + ((SkillTree.lightningDamage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий урон луча молнии:\n" + ((SkillTree.lightningDamage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "闪电光束总伤害：\n" + ((SkillTree.lightningDamage + 1f) * 100f).ToString("F0") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the lightning beam damage:\n",
							((SkillTree.lightningDamage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num21 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente les dégâts du rayon fulgurant :\n",
							((SkillTree.lightningDamage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num21 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta il danno del raggio fulmineo:\n",
							((SkillTree.lightningDamage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num21 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht den Blitzstrahl-Schaden:\n",
							((SkillTree.lightningDamage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num21 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta el daño del rayo relámpago:\n",
							((SkillTree.lightningDamage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num21 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"ライトニングビームのダメージを増加：\n",
							((SkillTree.lightningDamage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num21 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"번개 빔 피해량 증가:\n",
							((SkillTree.lightningDamage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num21 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa obrażenia promienia błyskawicy:\n",
							((SkillTree.lightningDamage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num21 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta o dano do raio relâmpago:\n",
							((SkillTree.lightningDamage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num21 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает урон луча молнии:\n",
							((SkillTree.lightningDamage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num21 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升闪电光束伤害：\n",
							((SkillTree.lightningDamage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num21 * 100f).ToString("F0"),
							"%"
						});
					}
				}
			}
			else if (upgradeName == "LightningSize")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Lightning Size";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Taille de la Foudre";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Dimensione Fulminea";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Blitzgröße";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Tamaño del Rayo";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ライトニングサイズ";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "번개 크기";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Rozmiar Błyskawicy";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Tamanho do Relâmpago";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Размер Молнии";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "闪电大小";
				}
				LocalizationScript.lightningSizeIncrease = 0.25f;
				float num22 = SkillTree.lightningSize + LocalizationScript.lightningSizeIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total lightning beam size:\n" + (SkillTree.lightningSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Taille totale du rayon fulgurant :\n" + (SkillTree.lightningSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Dimensione totale del raggio fulmineo:\n" + (SkillTree.lightningSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtgröße des Blitzstrahls:\n" + (SkillTree.lightningSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Tamaño total del rayo relámpago:\n" + (SkillTree.lightningSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "ライトニングビームのサイズ合計：\n" + (SkillTree.lightningSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "번개 빔 총 크기:\n" + (SkillTree.lightningSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączny rozmiar promienia błyskawicy:\n" + (SkillTree.lightningSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Tamanho total do raio relâmpago:\n" + (SkillTree.lightningSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий размер луча молнии:\n" + (SkillTree.lightningSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "闪电光束总大小：\n" + (SkillTree.lightningSize * 100f).ToString("F0") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the lightning beam size:\n",
							(SkillTree.lightningSize * 100f).ToString("F0"),
							"% -> ",
							(num22 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la taille du rayon fulgurant :\n",
							(SkillTree.lightningSize * 100f).ToString("F0"),
							"% -> ",
							(num22 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la dimensione del raggio fulmineo:\n",
							(SkillTree.lightningSize * 100f).ToString("F0"),
							"% -> ",
							(num22 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Größe des Blitzstrahls:\n",
							(SkillTree.lightningSize * 100f).ToString("F0"),
							"% -> ",
							(num22 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta el tamaño del rayo relámpago:\n",
							(SkillTree.lightningSize * 100f).ToString("F0"),
							"% -> ",
							(num22 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"ライトニングビームのサイズを増加：\n",
							(SkillTree.lightningSize * 100f).ToString("F0"),
							"% -> ",
							(num22 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"번개 빔 크기 증가:\n",
							(SkillTree.lightningSize * 100f).ToString("F0"),
							"% -> ",
							(num22 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa rozmiar promienia błyskawicy:\n",
							(SkillTree.lightningSize * 100f).ToString("F0"),
							"% -> ",
							(num22 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta o tamanho do raio relâmpago:\n",
							(SkillTree.lightningSize * 100f).ToString("F0"),
							"% -> ",
							(num22 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает размер луча молнии:\n",
							(SkillTree.lightningSize * 100f).ToString("F0"),
							"% -> ",
							(num22 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升闪电光束大小：\n",
							(SkillTree.lightningSize * 100f).ToString("F0"),
							"% -> ",
							(num22 * 100f).ToString("F0"),
							"%"
						});
					}
				}
			}
		}
		else if (upgradeType == 12)
		{
			bool flag20 = false;
			if (upgradeName == "DynamiteStickChance1")
			{
				LocalizationScript.dynamiteStickChanceIncrease = 0.1f;
				flag20 = true;
			}
			if (upgradeName == "DynamiteStickChance2")
			{
				flag20 = true;
				LocalizationScript.dynamiteStickChanceIncrease = 0.2f;
			}
			float num23 = SkillTree.dynamiteStickChance + LocalizationScript.dynamiteStickChanceIncrease;
			if (flag20)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Sticky Dynamite";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Dynamite Collante";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Dinamite Appiccicosa";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Klebe-Dynamit";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Dinamita Pegajosa";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "スティッキーダイナマイト";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "끈적한 다이너마이트";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Lepka Dynamit";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Dinamite Grudenta";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Липкий Динамит";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "粘性炸药";
				}
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total dynamite stick chance:\n" + SkillTree.dynamiteStickChance.ToString("F1") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance totale de coller une dynamite :\n" + SkillTree.dynamiteStickChance.ToString("F1") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di attaccare una dinamite:\n" + SkillTree.dynamiteStickChance.ToString("F1") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance, Dynamit zu heften:\n" + SkillTree.dynamiteStickChance.ToString("F1") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de pegar dinamita:\n" + SkillTree.dynamiteStickChance.ToString("F1") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "ダイナマイトがくっつく総確率：\n" + SkillTree.dynamiteStickChance.ToString("F1") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "다이너마이트 붙는 총 확률:\n" + SkillTree.dynamiteStickChance.ToString("F1") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na przyklejenie dynamitu:\n" + SkillTree.dynamiteStickChance.ToString("F1") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de grudar dinamite:\n" + SkillTree.dynamiteStickChance.ToString("F1") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс прикрепить динамит:\n" + SkillTree.dynamiteStickChance.ToString("F1") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "粘附炸药总概率：\n" + SkillTree.dynamiteStickChance.ToString("F1") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Every pickaxe hit has a chance to stick a dynamite.\n",
							SkillTree.dynamiteStickChance.ToString("F1"),
							"% -> ",
							num23.ToString("F1"),
							"%. The dynamite explosion deals 1.2X your pickaxe power."
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Chaque coup de pioche a une chance de coller une dynamite.\n",
							SkillTree.dynamiteStickChance.ToString("F1"),
							"% -> ",
							num23.ToString("F1"),
							"%. L'explosion inflige 1,2X les dégâts de votre pioche."
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Ogni colpo di piccone ha una probabilità di attaccare una dinamite.\n",
							SkillTree.dynamiteStickChance.ToString("F1"),
							"% -> ",
							num23.ToString("F1"),
							"%. L'esplosione infligge 1,2X il danno del tuo piccone."
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Jeder Spitzhacken-Schlag hat eine Chance, Dynamit zu heften.\n",
							SkillTree.dynamiteStickChance.ToString("F1"),
							"% -> ",
							num23.ToString("F1"),
							"%. Die Explosion verursacht 1,2X deinen Spitzhackenschaden."
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Cada golpe de pico tiene una probabilidad de pegar dinamita.\n",
							SkillTree.dynamiteStickChance.ToString("F1"),
							"% -> ",
							num23.ToString("F1"),
							"%. La explosión inflige 1,2X el daño de tu pico."
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"ピッケルの一振りごとにダイナマイトがくっつく確率がある。\n",
							SkillTree.dynamiteStickChance.ToString("F1"),
							"% -> ",
							num23.ToString("F1"),
							"% 爆発はピッケルダメージの1.2倍を与える。"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"곡괭이 타격마다 다이너마이트가 붙을 확률이 있음.\n",
							SkillTree.dynamiteStickChance.ToString("F1"),
							"% -> ",
							num23.ToString("F1"),
							"% 폭발은 곡괭이 피해의 1.2배를 입힘."
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Każde uderzenie kilofa ma szansę przykleić dynamit.\n",
							SkillTree.dynamiteStickChance.ToString("F1"),
							"% -> ",
							num23.ToString("F1"),
							"% Eksplozja zadaje 1,2X obrażeń twojego kilofa."
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Cada golpe de picareta tem chance de grudar uma dinamite.\n",
							SkillTree.dynamiteStickChance.ToString("F1"),
							"% -> ",
							num23.ToString("F1"),
							"% A explosão causa 1,2X o dano da sua picareta."
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Каждый удар киркой может прикрепить динамит.\n",
							SkillTree.dynamiteStickChance.ToString("F1"),
							"% -> ",
							num23.ToString("F1"),
							"% Взрыв наносит 1,2X урона вашей кирки."
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"每次镐子敲击都有几率粘附炸药。\n",
							SkillTree.dynamiteStickChance.ToString("F1"),
							"% -> ",
							num23.ToString("F1"),
							"% 爆炸造成你镐子伤害的 1.2 倍。"
						});
					}
				}
			}
			else if (upgradeName == "DynamiteSpawn2SmallChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Explosion = Explosion";
					this.skillTreeDesc_text.text = "Every dynamite explosion has a " + SkillTree.spawn2DynamiteChance.ToString("F0") + "% chance to spawn 2 small explosions.\nThe small explosion deals 33% of the big explosion power.";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Explosion = Explosion";
					this.skillTreeDesc_text.text = "<size=23>Chaque explosion de dynamite a " + SkillTree.spawn2DynamiteChance.ToString("F0") + "% de chance de générer 2 petites explosions.\nChaque petite explosion inflige 33% de la puissance de la grande explosion.";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Esplosione = Esplosione";
					this.skillTreeDesc_text.text = "<size=23>Ogni esplosione di dinamite ha il " + SkillTree.spawn2DynamiteChance.ToString("F0") + "% di probabilità di generare 2 piccole esplosioni.\nOgni piccola esplosione infligge il 33% della potenza dell'esplosione grande.";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Explosion = Explosion";
					this.skillTreeDesc_text.text = "<size=22>Jede Dynamitexplosion hat eine Chance von " + SkillTree.spawn2DynamiteChance.ToString("F0") + "%, 2 kleine Explosionen zu erzeugen.\nJede kleine Explosion verursacht 33% der Kraft der großen Explosion.";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Explosión = Explosión";
					this.skillTreeDesc_text.text = "<size=18>Cada explosión de dinamita tiene un " + SkillTree.spawn2DynamiteChance.ToString("F0") + "% de probabilidad de generar 2 explosiones pequeñas.\nCada explosión pequeña inflige el 33% de la potencia de la explosión grande.";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "エクスプロージョン = エクスプロージョン";
					this.skillTreeDesc_text.text = "ダイナマイト爆発ごとに" + SkillTree.spawn2DynamiteChance.ToString("F0") + "%の確率で小さな爆発が2つ発生。\n小爆発は大爆発パワーの33%のダメージを与える。";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "폭발 = 폭발";
					this.skillTreeDesc_text.text = "다이너마이트 폭발마다 " + SkillTree.spawn2DynamiteChance.ToString("F0") + "% 확률로 작은 폭발 2개 생성.\n작은 폭발은 큰 폭발 파워의 33% 피해를 입힘.";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Eksplozja = Eksplozja";
					this.skillTreeDesc_text.text = "<size=22>Każda eksplozja dynamitu ma " + SkillTree.spawn2DynamiteChance.ToString("F0") + "% szansy na stworzenie 2 małych eksplozji.\nMała eksplozja zadaje 33% mocy dużej eksplozji.";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Explosão = Explosão";
					this.skillTreeDesc_text.text = "<size=22>Cada explosão de dinamite tem " + SkillTree.spawn2DynamiteChance.ToString("F0") + "% de chance de gerar 2 pequenas explosões.\nCada pequena explosão causa 33% do poder da grande explosão.";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Взрыв = Взрыв";
					this.skillTreeDesc_text.text = "<size=23>Каждый взрыв динамита имеет " + SkillTree.spawn2DynamiteChance.ToString("F0") + "% шанс породить 2 маленьких взрыва.\nМаленький взрыв наносит 33% силы большого взрыва.";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "爆炸 = 爆炸";
					this.skillTreeDesc_text.text = "每次炸药爆炸有 " + SkillTree.spawn2DynamiteChance.ToString("F0") + "% 的几率生成 2 次小爆炸。\n小爆炸造成大爆炸威力的 33%。";
				}
			}
			else if (upgradeName == "DynamiteSpawnRockChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Explosion = Rock";
					this.skillTreeDesc_text.text = "Every dynamite explosion has a " + SkillTree.chanceToSpawnRockFromExplosion.ToString("F0") + "% chance to spawn a rock";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Explosion = Roche";
					this.skillTreeDesc_text.text = "Chaque explosion de dynamite a " + SkillTree.chanceToSpawnRockFromExplosion.ToString("F0") + "% de chance de générer une roche";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Esplosione = Roccia";
					this.skillTreeDesc_text.text = "Ogni esplosione di dinamite ha il " + SkillTree.chanceToSpawnRockFromExplosion.ToString("F0") + "% di probabilità di generare una roccia";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Explosion = Stein";
					this.skillTreeDesc_text.text = "Jede Dynamitexplosion hat eine Chance von " + SkillTree.chanceToSpawnRockFromExplosion.ToString("F0") + "% einen Stein zu erzeugen";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Explosión = Roca";
					this.skillTreeDesc_text.text = "Cada explosión de dinamita tiene un " + SkillTree.chanceToSpawnRockFromExplosion.ToString("F0") + "% de probabilidad de generar una roca";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "エクスプロージョン = 岩";
					this.skillTreeDesc_text.text = "ダイナマイト爆発ごとに" + SkillTree.chanceToSpawnRockFromExplosion.ToString("F0") + "%の確率で岩を生成";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "폭발 = 암석";
					this.skillTreeDesc_text.text = "다이너마이트 폭발마다 " + SkillTree.chanceToSpawnRockFromExplosion.ToString("F0") + "% 확률로 암석 생성";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Eksplozja = Skała";
					this.skillTreeDesc_text.text = "Każda eksplozja dynamitu ma " + SkillTree.chanceToSpawnRockFromExplosion.ToString("F0") + "% szansy na wygenerowanie skały";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Explosão = Rocha";
					this.skillTreeDesc_text.text = "Cada explosão de dinamite tem " + SkillTree.chanceToSpawnRockFromExplosion.ToString("F0") + "% de chance de gerar uma rocha";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Взрыв = Камень";
					this.skillTreeDesc_text.text = "Каждый взрыв динамита имеет " + SkillTree.chanceToSpawnRockFromExplosion.ToString("F0") + "% шанс породить камень";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "爆炸 = 岩石";
					this.skillTreeDesc_text.text = "每次炸药爆炸有 " + SkillTree.chanceToSpawnRockFromExplosion.ToString("F0") + "% 的几率生成岩石";
				}
			}
			else if (upgradeName == "DynamiteAddTimeChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Explosion = Time";
					this.skillTreeDesc_text.text = "Every dynamite explosion has a " + SkillTree.explosionAdd1SecondChance.ToString("F2") + "% chance to add 1 second to the timer";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Explosion = Temps";
					this.skillTreeDesc_text.text = "Chaque explosion de dynamite a " + SkillTree.explosionAdd1SecondChance.ToString("F2") + "% de chance d'ajouter 1 seconde au minuteur";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Esplosione = Tempo";
					this.skillTreeDesc_text.text = "Ogni esplosione di dinamite ha il " + SkillTree.explosionAdd1SecondChance.ToString("F2") + "% di probabilità di aggiungere 1 secondo al timer";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Explosion = Zeit";
					this.skillTreeDesc_text.text = "Jede Dynamitexplosion hat eine Chance von " + SkillTree.explosionAdd1SecondChance.ToString("F2") + "%, 1 Sekunde zum Timer hinzuzufügen";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Explosión = Tiempo";
					this.skillTreeDesc_text.text = "Cada explosión de dinamita tiene un " + SkillTree.explosionAdd1SecondChance.ToString("F2") + "% de probabilidad de añadir 1 segundo al temporizador";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "エクスプロージョン = タイム";
					this.skillTreeDesc_text.text = "ダイナマイト爆発ごとに" + SkillTree.explosionAdd1SecondChance.ToString("F2") + "%の確率でタイマーに1秒追加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "폭발 = 시간";
					this.skillTreeDesc_text.text = "다이너마이트 폭발마다 " + SkillTree.explosionAdd1SecondChance.ToString("F2") + "% 확률로 타이머에 1초 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Eksplozja = Czas";
					this.skillTreeDesc_text.text = "Każda eksplozja dynamitu ma " + SkillTree.explosionAdd1SecondChance.ToString("F2") + "% szansy na dodanie 1 sekundy do timera";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Explosão = Tempo";
					this.skillTreeDesc_text.text = "Cada explosão de dinamite tem " + SkillTree.explosionAdd1SecondChance.ToString("F2") + "% de chance de adicionar 1 segundo ao cronômetro";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Взрыв = Время";
					this.skillTreeDesc_text.text = "Каждый взрыв динамита имеет " + SkillTree.explosionAdd1SecondChance.ToString("F2") + "% шанс добавить 1 секунду к таймеру";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "爆炸 = 时间";
					this.skillTreeDesc_text.text = "每次炸药爆炸有 " + SkillTree.explosionAdd1SecondChance.ToString("F2") + "% 的几率为计时器增加 1 秒";
				}
			}
			else if (upgradeName == "DynamiteSpawnLightningChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Explosion = Lightning";
					this.skillTreeDesc_text.text = "Every dynamite explosion has a " + SkillTree.explosionChanceToSpawnLightning.ToString("F0") + "% chance to spawn a lightning beam";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Explosion = Foudre";
					this.skillTreeDesc_text.text = "Chaque explosion de dynamite a " + SkillTree.explosionChanceToSpawnLightning.ToString("F0") + "% de chance de générer un rayon fulgurant";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Esplosione = Fulmine";
					this.skillTreeDesc_text.text = "Ogni esplosione di dinamite ha il " + SkillTree.explosionChanceToSpawnLightning.ToString("F0") + "% di probabilità di generare un raggio fulmineo";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Explosion = Blitz";
					this.skillTreeDesc_text.text = "Jede Dynamitexplosion hat eine Chance von " + SkillTree.explosionChanceToSpawnLightning.ToString("F0") + "%, einen Blitzstrahl zu erzeugen";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Explosión = Rayo";
					this.skillTreeDesc_text.text = "Cada explosión de dinamita tiene un " + SkillTree.explosionChanceToSpawnLightning.ToString("F0") + "% de probabilidad de generar un rayo relámpago";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "エクスプロージョン = ライトニング";
					this.skillTreeDesc_text.text = "ダイナマイト爆発ごとに" + SkillTree.explosionChanceToSpawnLightning.ToString("F0") + "%の確率でライトニングビームを生成";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "폭발 = 번개";
					this.skillTreeDesc_text.text = "다이너마이트 폭발마다 " + SkillTree.explosionChanceToSpawnLightning.ToString("F0") + "% 확률로 번개 빔 생성";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Eksplozja = Błyskawica";
					this.skillTreeDesc_text.text = "Każda eksplozja dynamitu ma " + SkillTree.explosionChanceToSpawnLightning.ToString("F0") + "% szansy na wygenerowanie promienia błyskawicy";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Explosão = Relâmpago";
					this.skillTreeDesc_text.text = "Cada explosão de dinamite tem " + SkillTree.explosionChanceToSpawnLightning.ToString("F0") + "% de chance de gerar um raio relâmpago";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Взрыв = Молния";
					this.skillTreeDesc_text.text = "Каждый взрыв динамита имеет " + SkillTree.explosionChanceToSpawnLightning.ToString("F0") + "% шанс породить луч молнии";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "爆炸 = 闪电";
					this.skillTreeDesc_text.text = "每次炸药爆炸有 " + SkillTree.explosionChanceToSpawnLightning.ToString("F0") + "% 的几率生成闪电光束";
				}
			}
			else if (upgradeName == "DynamiteDamage")
			{
				LocalizationScript.explosionDamagageIncrease = 0.25f;
				float num24 = SkillTree.explosionDamagage + LocalizationScript.explosionDamagageIncrease + 1f;
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Dynamite Damage";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Dégâts de Dynamite";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Danno Dinamite";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Dynamitschaden";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Daño de Dinamita";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ダイナマイトダメージ";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "다이너마이트 피해";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Obrażenia Dynamitu";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Dano de Dinamite";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Урон Динамита";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "炸药伤害";
				}
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total dynamite damage:\n" + ((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Dégâts totaux de dynamite :\n" + ((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Danno totale da dinamite:\n" + ((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtschaden durch Dynamit:\n" + ((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Daño total de dinamita:\n" + ((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "ダイナマイトの総ダメージ：\n" + ((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "다이너마이트 총 피해량:\n" + ((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączne obrażenia dynamitu:\n" + ((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Dano total da dinamite:\n" + ((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий урон динамита:\n" + ((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "炸药总伤害：\n" + ((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the dynamite damage\n",
							((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num24 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente les dégâts de la dynamite\n",
							((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num24 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta il danno della dinamite\n",
							((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num24 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht den Dynamitschaden\n",
							((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num24 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta el daño de la dinamita\n",
							((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num24 * 100f).ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"ダイナマイトのダメージを増加\n",
							((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num24 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"다이너마이트 피해량 증가\n",
							((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num24 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa obrażenia dynamitu\n",
							((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num24 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta o dano da dinamite\n",
							((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num24 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает урон динамита\n",
							((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num24 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升炸药伤害\n",
							((SkillTree.explosionDamagage + 1f) * 100f).ToString("F0"),
							"% -> ",
							(num24 * 100f).ToString("F0"),
							"%"
						});
					}
				}
			}
			else if (upgradeName == "DynamiteSize")
			{
				LocalizationScript.explosionSizeIncrease = 0.2f;
				float num25 = SkillTree.explosionSize + LocalizationScript.explosionSizeIncrease;
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Dynamite Explosion Size";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "<size=28>Taille de l'Explosion de Dynamite";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Dimensione Esplosione Dinamite";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Dynamit-Explosionsgröße";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Tamaño de la Explosión de Dinamita";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ダイナマイト爆発サイズ";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "다이너마이트 폭발 크기";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Rozmiar Eksplozji Dynamitu";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Tamanho da Explosão de Dinamite";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Размер Взрыва Динамита";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "炸药爆炸范围";
				}
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total dynamite explosion size:\n" + (SkillTree.explosionSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Taille totale de l'explosion de dynamite :\n" + (SkillTree.explosionSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Dimensione totale esplosione dinamite:\n" + (SkillTree.explosionSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtgröße der Dynamitexplosion:\n" + (SkillTree.explosionSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Tamaño total de la explosión de dinamita:\n" + (SkillTree.explosionSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "ダイナマイトの爆発サイズ合計：\n" + (SkillTree.explosionSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "다이너마이트 폭발 총 크기:\n" + (SkillTree.explosionSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączny rozmiar eksplozji dynamitu:\n" + (SkillTree.explosionSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Tamanho total da explosão de dinamite:\n" + (SkillTree.explosionSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий размер взрыва динамита:\n" + (SkillTree.explosionSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "炸药爆炸总范围：\n" + (SkillTree.explosionSize * 100f).ToString("F0") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the dynamite explosion size\n",
							(SkillTree.explosionSize * 100f).ToString("F0"),
							"% -> ",
							(num25 * 100f).ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la taille de l'explosion de dynamite\n",
							(SkillTree.explosionSize * 100f).ToString("F0"),
							"% -> ",
							(num25 * 100f).ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la dimensione dell'esplosione di dinamite\n",
							(SkillTree.explosionSize * 100f).ToString("F0"),
							"% -> ",
							(num25 * 100f).ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Größe der Dynamitexplosion\n",
							(SkillTree.explosionSize * 100f).ToString("F0"),
							"% -> ",
							(num25 * 100f).ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta el tamaño de la explosión de dinamita\n",
							(SkillTree.explosionSize * 100f).ToString("F0"),
							"% -> ",
							(num25 * 100f).ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"ダイナマイトの爆発サイズを増加\n",
							(SkillTree.explosionSize * 100f).ToString("F0"),
							"% -> ",
							(num25 * 100f).ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"다이너마이트 폭발 크기 증가\n",
							(SkillTree.explosionSize * 100f).ToString("F0"),
							"% -> ",
							(num25 * 100f).ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa rozmiar eksplozji dynamitu\n",
							(SkillTree.explosionSize * 100f).ToString("F0"),
							"% -> ",
							(num25 * 100f).ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta o tamanho da explosão de dinamite\n",
							(SkillTree.explosionSize * 100f).ToString("F0"),
							"% -> ",
							(num25 * 100f).ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает размер взрыва динамита\n",
							(SkillTree.explosionSize * 100f).ToString("F0"),
							"% -> ",
							(num25 * 100f).ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"提升炸药爆炸范围\n",
							(SkillTree.explosionSize * 100f).ToString("F0"),
							"% -> ",
							(num25 * 100f).ToString("F1"),
							"%"
						});
					}
				}
			}
		}
		else if (upgradeType == 13)
		{
			bool flag21 = false;
			if (upgradeName == "PlazmaBallChance1")
			{
				LocalizationScript.plazmaBallChanceIncrease = 4f;
				flag21 = true;
			}
			else if (upgradeName == "PlazmaBallChance2")
			{
				LocalizationScript.plazmaBallChanceIncrease = 5f;
				flag21 = true;
			}
			float num26 = SkillTree.plazmaBallChance + LocalizationScript.plazmaBallChanceIncrease;
			if (flag21)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Plazma Balls";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Boules de Plazma";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Sfere di Plazma";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Plazma-Kugeln";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Bolas de Plazma";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "プラズマボール";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "플라즈마 볼";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Kule Plazmy";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Bolas de Plazma";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Плазменные Шары";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "等离子球";
				}
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Plazma ball spawn chance:\n" + SkillTree.plazmaBallChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance d'apparition de boule de plazma :\n" + SkillTree.plazmaBallChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità di generare una sfera di plazma:\n" + SkillTree.plazmaBallChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Plazma-Kugel Spawn-Chance:\n" + SkillTree.plazmaBallChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad de aparición de bola de plazma:\n" + SkillTree.plazmaBallChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "プラズマボール出現確率：\n" + SkillTree.plazmaBallChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "플라즈마 볼 생성 확률:\n" + SkillTree.plazmaBallChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Szansa na pojawienie się kuli plazmy:\n" + SkillTree.plazmaBallChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance de surgimento da bola de plazma:\n" + SkillTree.plazmaBallChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Шанс появления шара плазмы:\n" + SkillTree.plazmaBallChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "等离子球生成概率：\n" + SkillTree.plazmaBallChance.ToString("F0") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Format("Every second, chance to spawn a plazma ball that moves across the screen.\n{0}% -> {1}%. The ball lasts {2} seconds and deals 0.75X your pickaxe power", SkillTree.plazmaBallChance.ToString("F0"), num26.ToString("F0"), SkillTree.plazmaBallTimer);
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Format("<size=22>Chaque seconde, chance de générer une boule de plazma qui traverse l'écran.\n{0}% -> {1}%. La boule dure {2} secondes et inflige 0,75X la puissance de votre pioche", SkillTree.plazmaBallChance.ToString("F0"), num26.ToString("F0"), SkillTree.plazmaBallTimer);
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Format("<size=22>Ogni secondo, possibilità di generare una sfera di plazma che attraversa lo schermo.\n{0}% -> {1}%. La sfera dura {2} secondi e infligge 0,75X la potenza del tuo piccone", SkillTree.plazmaBallChance.ToString("F0"), num26.ToString("F0"), SkillTree.plazmaBallTimer);
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Format("<size=22>Jede Sekunde Chance, eine Plazma-Kugel zu erzeugen, die über den Bildschirm fliegt.\n{0}% -> {1}%. Die Kugel hält {2} Sekunden und verursacht 0,75X deine Spitzhackenstärke", SkillTree.plazmaBallChance.ToString("F0"), num26.ToString("F0"), SkillTree.plazmaBallTimer);
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Format("<size=22>Cada segundo, probabilidad de generar una bola de plazma que cruza la pantalla.\n{0}% -> {1}%. La bola dura {2} segundos y causa 0,75X la potencia de tu pico", SkillTree.plazmaBallChance.ToString("F0"), num26.ToString("F0"), SkillTree.plazmaBallTimer);
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Format("毎秒、画面を横切るプラズマボールが発生する確率。\n{0}% -> {1}%。ボールは{2}秒間持続し、ピッケルパワーの0.75倍のダメージを与える", SkillTree.plazmaBallChance.ToString("F0"), num26.ToString("F0"), SkillTree.plazmaBallTimer);
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Format("매초 화면을 가로지르는 플라즈마 볼 생성 확률.\n{0}% -> {1}% 볼은 {2}초 동안 유지되며 곡괭이 파워의 0.75배 피해를 입힘", SkillTree.plazmaBallChance.ToString("F0"), num26.ToString("F0"), SkillTree.plazmaBallTimer);
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Format("<size=22>Co sekundę szansa na wygenerowanie kuli plazmy, która przelatuje przez ekran.\n{0}% -> {1}% Kula trwa {2} sekund i zadaje 0,75X mocy twojego kilofa", SkillTree.plazmaBallChance.ToString("F0"), num26.ToString("F0"), SkillTree.plazmaBallTimer);
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Format("<size=22>A cada segundo, chance de gerar uma bola de plazma que atravessa a tela.\n{0}% -> {1}% A bola dura {2} segundos e causa 0,75X o poder da sua picareta", SkillTree.plazmaBallChance.ToString("F0"), num26.ToString("F0"), SkillTree.plazmaBallTimer);
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Format("<size=22>Каждую секунду шанс породить шар плазмы, движущийся по экрану.\n{0}% -> {1}% Шар существует {2} секунд и наносит 0,75X урона вашей кирки", SkillTree.plazmaBallChance.ToString("F0"), num26.ToString("F0"), SkillTree.plazmaBallTimer);
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Format("每秒有几率生成一个横穿屏幕的等离子球。\n{0}% -> {1}% 球持续 {2} 秒，造成你镐子威力的 0.75 倍伤害", SkillTree.plazmaBallChance.ToString("F0"), num26.ToString("F0"), SkillTree.plazmaBallTimer);
					}
				}
			}
			else if (upgradeName == "PlazmaBallTime")
			{
				LocalizationScript.plazmaBallTimerIncrease = 1f;
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Plazma Ball Time";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Durée de la Boule de Plazma";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Durata Sfera di Plazma";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Plazma-Kugel Zeit";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Tiempo de Bola de Plazma";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "プラズマボール時間";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "플라즈마 볼 지속시간";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Czas Kuli Plazmy";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Duração da Bola de Plazma";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Время Шара Плазмы";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "等离子球持续时间";
				}
				float num27 = SkillTree.plazmaBallTimer + LocalizationScript.plazmaBallTimerIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Plazma ball on screen time:\n" + SkillTree.plazmaBallTimer.ToString("F0") + "s";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Durée d'affichage de la boule de plazma :\n" + SkillTree.plazmaBallTimer.ToString("F0") + "s";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Tempo sullo schermo della sfera di plazma:\n" + SkillTree.plazmaBallTimer.ToString("F0") + "s";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Anzeigedauer der Plazma-Kugel:\n" + SkillTree.plazmaBallTimer.ToString("F0") + "s";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Tiempo en pantalla de la bola de plazma:\n" + SkillTree.plazmaBallTimer.ToString("F0") + "s";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "プラズマボール画面時間：\n" + SkillTree.plazmaBallTimer.ToString("F0") + "秒";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "플라즈마 볼 화면 지속 시간:\n" + SkillTree.plazmaBallTimer.ToString("F0") + "초";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Czas widoczności kuli plazmy:\n" + SkillTree.plazmaBallTimer.ToString("F0") + "s";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Tempo na tela da bola de plazma:\n" + SkillTree.plazmaBallTimer.ToString("F0") + "s";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Время шара плазмы на экране:\n" + SkillTree.plazmaBallTimer.ToString("F0") + "с";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "等离子球在屏幕上的时间：\n" + SkillTree.plazmaBallTimer.ToString("F0") + "秒";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase how long the plazma ball is on screen\n",
							SkillTree.plazmaBallTimer.ToString("F0"),
							"s -> ",
							num27.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la durée d'affichage de la boule de plazma\n",
							SkillTree.plazmaBallTimer.ToString("F0"),
							"s -> ",
							num27.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la durata della sfera di plazma sullo schermo\n",
							SkillTree.plazmaBallTimer.ToString("F0"),
							"s -> ",
							num27.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Verlängert die Zeit, in der die Plazma-Kugel auf dem Bildschirm ist\n",
							SkillTree.plazmaBallTimer.ToString("F0"),
							"s -> ",
							num27.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta el tiempo que la bola de plazma permanece en pantalla\n",
							SkillTree.plazmaBallTimer.ToString("F0"),
							"s -> ",
							num27.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"プラズマボールが画面に残る時間を延長\n",
							SkillTree.plazmaBallTimer.ToString("F0"),
							"秒 -> ",
							num27.ToString("F0"),
							"秒"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"플라즈마 볼 화면 유지 시간 증가\n",
							SkillTree.plazmaBallTimer.ToString("F0"),
							"초 -> ",
							num27.ToString("F0"),
							"초"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Wydłuża czas, w którym kula plazmy jest widoczna\n",
							SkillTree.plazmaBallTimer.ToString("F0"),
							"s -> ",
							num27.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta o tempo em que a bola de plazma fica na tela\n",
							SkillTree.plazmaBallTimer.ToString("F0"),
							"s -> ",
							num27.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает время нахождения шара плазмы на экране\n",
							SkillTree.plazmaBallTimer.ToString("F0"),
							"с -> ",
							num27.ToString("F0"),
							"с"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"延长等离子球在屏幕上的时间\n",
							SkillTree.plazmaBallTimer.ToString("F0"),
							"秒 -> ",
							num27.ToString("F0"),
							"秒"
						});
					}
				}
			}
			else if (upgradeName == "PlazmaBallSize")
			{
				LocalizationScript.plazmaBallTotalSizeIncrease = 0.2f;
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Plazma Ball Size";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Taille de la Boule de Plazma";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Dimensione Sfera di Plazma";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Plazma-Kugel Größe";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Tamaño de Bola de Plazma";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "プラズマボールサイズ";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "플라즈마 볼 크기";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Rozmiar Kuli Plazmy";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Tamanho da Bola de Plazma";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Размер Шара Плазмы";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "等离子球大小";
				}
				float num28 = SkillTree.plazmaBallTotalSize + LocalizationScript.plazmaBallTotalSizeIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total plazma ball size increase:\n" + (SkillTree.plazmaBallTotalSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Augmentation totale de la taille de la boule de plazma :\n" + (SkillTree.plazmaBallTotalSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Aumento totale dimensione sfera di plazma:\n" + (SkillTree.plazmaBallTotalSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamte Plazma-Kugel Größensteigerung:\n" + (SkillTree.plazmaBallTotalSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Aumento total de tamaño de bola de plazma:\n" + (SkillTree.plazmaBallTotalSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "プラズマボールのサイズ合計増加：\n" + (SkillTree.plazmaBallTotalSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "플라즈마 볼 총 크기 증가:\n" + (SkillTree.plazmaBallTotalSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączny wzrost rozmiaru kuli plazmy:\n" + (SkillTree.plazmaBallTotalSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Aumento total do tamanho da bola de plazma:\n" + (SkillTree.plazmaBallTotalSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общее увеличение размера шара плазмы:\n" + (SkillTree.plazmaBallTotalSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "等离子球总大小增幅：\n" + (SkillTree.plazmaBallTotalSize * 100f).ToString("F0") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the size of the plazma ball:\n",
							(SkillTree.plazmaBallTotalSize * 100f).ToString("F0"),
							"% -> ",
							(num28 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la taille de la boule de plazma :\n",
							(SkillTree.plazmaBallTotalSize * 100f).ToString("F0"),
							"% -> ",
							(num28 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la dimensione della sfera di plazma:\n",
							(SkillTree.plazmaBallTotalSize * 100f).ToString("F0"),
							"% -> ",
							(num28 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Größe der Plazma-Kugel:\n",
							(SkillTree.plazmaBallTotalSize * 100f).ToString("F0"),
							"% -> ",
							(num28 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta el tamaño de la bola de plazma:\n",
							(SkillTree.plazmaBallTotalSize * 100f).ToString("F0"),
							"% -> ",
							(num28 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"プラズマボールのサイズを増加：\n",
							(SkillTree.plazmaBallTotalSize * 100f).ToString("F0"),
							"% -> ",
							(num28 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"플라즈마 볼 크기 증가:\n",
							(SkillTree.plazmaBallTotalSize * 100f).ToString("F0"),
							"% -> ",
							(num28 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa rozmiar kuli plazmy:\n",
							(SkillTree.plazmaBallTotalSize * 100f).ToString("F0"),
							"% -> ",
							(num28 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta o tamanho da bola de plazma:\n",
							(SkillTree.plazmaBallTotalSize * 100f).ToString("F0"),
							"% -> ",
							(num28 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает размер шара плазмы:\n",
							(SkillTree.plazmaBallTotalSize * 100f).ToString("F0"),
							"% -> ",
							(num28 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"增加等离子球的大小：\n",
							(SkillTree.plazmaBallTotalSize * 100f).ToString("F0"),
							"% -> ",
							(num28 * 100f).ToString("F0"),
							"%"
						});
					}
				}
			}
			else if (upgradeName == "PlazmaBallDamage")
			{
				LocalizationScript.plazmaBallTotalDamageIncrease = 0.2f;
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Plazma Ball Damage";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Dégâts de Boule de Plazma";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Danno Sfera di Plazma";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Plazma-Kugel Schaden";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Daño de Bola de Plazma";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "プラズマボールダメージ";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "플라즈마 볼 피해";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Obrażenia Kuli Plazmy";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Dano da Bola de Plazma";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Урон Шара Плазмы";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "等离子球伤害";
				}
				float num29 = SkillTree.plazmaBallTotalDamage + LocalizationScript.plazmaBallTotalDamageIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total plazma ball damage:\n" + (SkillTree.plazmaBallTotalDamage * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Dégâts totaux de la boule de plazma :\n" + (SkillTree.plazmaBallTotalDamage * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Danno totale della sfera di plazma:\n" + (SkillTree.plazmaBallTotalDamage * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamter Plazma-Kugel-Schaden:\n" + (SkillTree.plazmaBallTotalDamage * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Daño total de la bola de plazma:\n" + (SkillTree.plazmaBallTotalDamage * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "プラズマボールの総ダメージ：\n" + (SkillTree.plazmaBallTotalDamage * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "플라즈마 볼 총 피해량:\n" + (SkillTree.plazmaBallTotalDamage * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączne obrażenia kuli plazmy:\n" + (SkillTree.plazmaBallTotalDamage * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Dano total da bola de plazma:\n" + (SkillTree.plazmaBallTotalDamage * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий урон шара плазмы:\n" + (SkillTree.plazmaBallTotalDamage * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "等离子球总伤害：\n" + (SkillTree.plazmaBallTotalDamage * 100f).ToString("F0") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the plazma ball damage: \n",
							(SkillTree.plazmaBallTotalDamage * 100f).ToString("F0"),
							"% -> ",
							(num29 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente les dégâts de la boule de plazma : \n",
							(SkillTree.plazmaBallTotalDamage * 100f).ToString("F0"),
							"% -> ",
							(num29 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta i danni della sfera di plazma: \n",
							(SkillTree.plazmaBallTotalDamage * 100f).ToString("F0"),
							"% -> ",
							(num29 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht den Schaden der Plazma-Kugel: \n",
							(SkillTree.plazmaBallTotalDamage * 100f).ToString("F0"),
							"% -> ",
							(num29 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta el daño de la bola de plazma: \n",
							(SkillTree.plazmaBallTotalDamage * 100f).ToString("F0"),
							"% -> ",
							(num29 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"プラズマボールのダメージを増加: \n",
							(SkillTree.plazmaBallTotalDamage * 100f).ToString("F0"),
							"% -> ",
							(num29 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"플라즈마 볼 피해량 증가: \n",
							(SkillTree.plazmaBallTotalDamage * 100f).ToString("F0"),
							"% -> ",
							(num29 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa obrażenia kuli plazmy: \n",
							(SkillTree.plazmaBallTotalDamage * 100f).ToString("F0"),
							"% -> ",
							(num29 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta o dano da bola de plazma: \n",
							(SkillTree.plazmaBallTotalDamage * 100f).ToString("F0"),
							"% -> ",
							(num29 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает урон шара плазмы: \n",
							(SkillTree.plazmaBallTotalDamage * 100f).ToString("F0"),
							"% -> ",
							(num29 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"增加等离子球伤害：\n",
							(SkillTree.plazmaBallTotalDamage * 100f).ToString("F0"),
							"% -> ",
							(num29 * 100f).ToString("F0"),
							"%"
						});
					}
				}
			}
			else if (upgradeName == "PlazmaBallExplosionChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Plazma Ball Explosion";
					this.skillTreeDesc_text.text = SkillTree.plazmaballExplosionChance.ToString("F0") + "% chance to cause a dynamite explosion when a plazma ball despawns";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Explosion Boule de Plazma";
					this.skillTreeDesc_text.text = "<size=17>" + SkillTree.plazmaballExplosionChance.ToString("F0") + "% de chance de déclencher une explosion de dynamite quand une boule de plazma disparaît";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Esplosione Sfera di Plazma";
					this.skillTreeDesc_text.text = "<size=20>" + SkillTree.plazmaballExplosionChance.ToString("F0") + "% di probabilità di causare un'esplosione di dinamite quando una sfera di plazma scompare";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Plazma-Kugel Explosion";
					this.skillTreeDesc_text.text = "<size=22>" + SkillTree.plazmaballExplosionChance.ToString("F0") + "% Chance auf eine Dynamitexplosion, wenn eine Plazma-Kugel verschwindet";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Explosión Bola de Plazma";
					this.skillTreeDesc_text.text = "<size=21>" + SkillTree.plazmaballExplosionChance.ToString("F0") + "% de probabilidad de provocar una explosión de dinamita cuando una bola de plazma desaparece";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "プラズマボール爆発";
					this.skillTreeDesc_text.text = "プラズマボールが消えるときに" + SkillTree.plazmaballExplosionChance.ToString("F0") + "%の確率でダイナマイト爆発を起こす";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "플라즈마 볼 폭발";
					this.skillTreeDesc_text.text = "플라즈마 볼이 사라질 때 " + SkillTree.plazmaballExplosionChance.ToString("F0") + "% 확률로 다이너마이트 폭발 발생";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Eksplozja Kuli Plazmy";
					this.skillTreeDesc_text.text = "<size=21>" + SkillTree.plazmaballExplosionChance.ToString("F0") + "% szansy na wywołanie eksplozji dynamitu, gdy kula plazmy znika";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Explosão Bola de Plazma";
					this.skillTreeDesc_text.text = "<size=21>" + SkillTree.plazmaballExplosionChance.ToString("F0") + "% de chance de causar uma explosão de dinamite quando uma bola de plazma desaparece";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Взрыв Шара Плазмы";
					this.skillTreeDesc_text.text = SkillTree.plazmaballExplosionChance.ToString("F0") + "% шанс вызвать взрыв динамита при исчезновении шара плазмы";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "等离子球爆炸";
					this.skillTreeDesc_text.text = "等离子球消失时有 " + SkillTree.plazmaballExplosionChance.ToString("F0") + "% 的几率引发炸药爆炸";
				}
			}
			else if (upgradeName == "PlazmbaBallSpawnSmallChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Tiny Plazma Balls";
					this.skillTreeDesc_text.text = "The plazma ball has a " + SkillTree.plazmaBallSpawnSmallBallChance.ToString("F0") + "% chance to spawn a small ball\nevery second that it is on screen. It has the same stats as the big plazma ball.";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Mini Boules de Plazma";
					this.skillTreeDesc_text.text = "<size=19>La boule de plazma a " + SkillTree.plazmaBallSpawnSmallBallChance.ToString("F0") + "% de chance d'engendrer une petite boule\nchaque seconde où elle est à l'écran. Elle a les mêmes stats que la grande boule de plazma.";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Mini Sfere di Plazma";
					this.skillTreeDesc_text.text = "<size=19>La sfera di plazma ha il " + SkillTree.plazmaBallSpawnSmallBallChance.ToString("F0") + "% di probabilità di generare una sfera piccola\nogni secondo in cui è sullo schermo. Ha le stesse statistiche della grande sfera di plazma.";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mini Plazma-Kugeln";
					this.skillTreeDesc_text.text = "<size=16>Die Plazma-Kugel hat eine Chance von " + SkillTree.plazmaBallSpawnSmallBallChance.ToString("F0") + "% jede Sekunde,\nwährend sie auf dem Bildschirm ist, eine kleine Kugel zu erzeugen. Diese hat dieselben Werte wie die große Plazma-Kugel.";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Mini Bolas de Plazma";
					this.skillTreeDesc_text.text = "<size=19>La bola de plazma tiene un " + SkillTree.plazmaBallSpawnSmallBallChance.ToString("F0") + "% de probabilidad de generar una bola pequeña\ncada segundo que esté en pantalla. Tiene las mismas estadísticas que la bola de plazma grande.";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ミニプラズマボール";
					this.skillTreeDesc_text.text = "プラズマボールは画面に出ている間、毎秒" + SkillTree.plazmaBallSpawnSmallBallChance.ToString("F0") + "%の確率で\n小さなボールを生成する。同じステータスを持つ。";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "작은 플라즈마 볼";
					this.skillTreeDesc_text.text = "플라즈마 볼은 화면에 있는 동안 매초 " + SkillTree.plazmaBallSpawnSmallBallChance.ToString("F0") + "% 확률로\n작은 볼을 생성합니다. 작은 볼은 큰 플라즈마 볼과 동일한 스탯을 가집니다.";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Małe Kule Plazmy";
					this.skillTreeDesc_text.text = "<size=20>Kula plazmy ma " + SkillTree.plazmaBallSpawnSmallBallChance.ToString("F0") + "% szansy na wygenerowanie małej kuli\nco sekundę, gdy jest widoczna. Ma takie same statystyki jak duża kula plazmy.";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mini Bolas de Plazma";
					this.skillTreeDesc_text.text = "<size=21>A bola de plazma tem " + SkillTree.plazmaBallSpawnSmallBallChance.ToString("F0") + "% de chance de gerar uma bola pequena\na cada segundo em que estiver na tela. A bola pequena tem os mesmos atributos da grande.";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Маленькие Шары Плазмы";
					this.skillTreeDesc_text.text = "<size=20>Шар плазмы имеет " + SkillTree.plazmaBallSpawnSmallBallChance.ToString("F0") + "% шанс создать маленький шар\nкаждую секунду, пока он на экране. Маленький шар имеет те же характеристики, что и большой.";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "小型等离子球";
					this.skillTreeDesc_text.text = "等离子球在屏幕上每秒有 " + SkillTree.plazmaBallSpawnSmallBallChance.ToString("F0") + "% 的几率生成一个小球。\n小球与大等离子球拥有相同的属性。";
				}
			}
			else if (upgradeName == "PlazmaBallChanceToSpawnPickaxe")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Tiny Plazma Pickaxe";
					this.skillTreeDesc_text.text = SkillTree.plazmaBallChanceToSpawnPickaxe.ToString("F0") + "% chance to spawn a pickaxe every time the plazma ball hits a rock";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Pioche de Plazma Mini";
					this.skillTreeDesc_text.text = "<size=18>" + SkillTree.plazmaBallChanceToSpawnPickaxe.ToString("F0") + "% de chance de générer une pioche chaque fois qu'une boule de plazma touche un rocher";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Piccone Plazma Mini";
					this.skillTreeDesc_text.text = "<size=18>" + SkillTree.plazmaBallChanceToSpawnPickaxe.ToString("F0") + "% di probabilità di generare un piccone ogni volta che la sfera di plazma colpisce una roccia";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mini Plazma-Spitzhacke";
					this.skillTreeDesc_text.text = "<size=20>" + SkillTree.plazmaBallChanceToSpawnPickaxe.ToString("F0") + "% Chance, eine Spitzhacke zu erzeugen, wenn die Plazma-Kugel einen Stein trifft";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Pico de Plazma Mini";
					this.skillTreeDesc_text.text = "<size=20>" + SkillTree.plazmaBallChanceToSpawnPickaxe.ToString("F0") + "% de probabilidad de generar un pico cada vez que la bola de plazma golpea una roca";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ミニプラズマピッケル";
					this.skillTreeDesc_text.text = "プラズマボールが岩に当たるたびに" + SkillTree.plazmaBallChanceToSpawnPickaxe.ToString("F0") + "%の確率でピッケルを生成";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "작은 플라즈마 곡괭이";
					this.skillTreeDesc_text.text = "플라즈마 볼이 바위를 칠 때마다 " + SkillTree.plazmaBallChanceToSpawnPickaxe.ToString("F0") + "% 확률로 곡괭이 생성";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Mini Kilof Plazmy";
					this.skillTreeDesc_text.text = "<size=22>" + SkillTree.plazmaBallChanceToSpawnPickaxe.ToString("F0") + "% szansy na stworzenie kilofa, gdy kula plazmy uderzy w skałę";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Picareta Plazma Mini";
					this.skillTreeDesc_text.text = "<size=22>" + SkillTree.plazmaBallChanceToSpawnPickaxe.ToString("F0") + "% de chance de gerar uma picareta toda vez que a bola de plazma acerta uma rocha";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Маленький Кирка Плазмы";
					this.skillTreeDesc_text.text = "<size=22>" + SkillTree.plazmaBallChanceToSpawnPickaxe.ToString("F0") + "% шанс создать кирку каждый раз, когда шар плазмы ударяет камень";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "小型等离子镐";
					this.skillTreeDesc_text.text = "等离子球每次击中岩石时有 " + SkillTree.plazmaBallChanceToSpawnPickaxe.ToString("F0") + "% 的几率生成一把镐子";
				}
			}
		}
		else if (upgradeType == 14)
		{
			if (upgradeName == "MaterialsPerRock1")
			{
				LocalizationScript.materialsFromChunkRocksIncrease = 1;
				LocalizationScript.materialsFromFullRocksIncrease = 1;
			}
			else if (upgradeName == "MaterialsPerRock2")
			{
				LocalizationScript.materialsFromChunkRocksIncrease = 1;
				LocalizationScript.materialsFromFullRocksIncrease = 1;
			}
			else if (upgradeName == "MaterialsPerRock3")
			{
				LocalizationScript.materialsFromChunkRocksIncrease = 1;
				LocalizationScript.materialsFromFullRocksIncrease = 1;
			}
			else if (upgradeName == "MaterialsPerRock4")
			{
				LocalizationScript.materialsFromChunkRocksIncrease = 1;
				LocalizationScript.materialsFromFullRocksIncrease = 2;
			}
			else if (upgradeName == "MaterialsPerRock5")
			{
				LocalizationScript.materialsFromChunkRocksIncrease = 1;
				LocalizationScript.materialsFromFullRocksIncrease = 2;
			}
			int num30 = SkillTree.materialsFromChunkRocks + LocalizationScript.materialsFromChunkRocksIncrease;
			int num31 = SkillTree.materialsFromFullRocks + LocalizationScript.materialsFromFullRocksIncrease;
			if (LocalizationScript.isEnglish)
			{
				this.skillTreeName_text.text = "More Ores From Rocks";
			}
			if (LocalizationScript.isFrench)
			{
				this.skillTreeName_text.text = "Plus de Minerais des Roches";
			}
			if (LocalizationScript.isItalian)
			{
				this.skillTreeName_text.text = "Più Minerali dalle Rocce";
			}
			if (LocalizationScript.isGerman)
			{
				this.skillTreeName_text.text = "Mehr Erze aus Steinen";
			}
			if (LocalizationScript.isSpanish)
			{
				this.skillTreeName_text.text = "Más Minerales de las Rocas";
			}
			if (LocalizationScript.isJapanese)
			{
				this.skillTreeName_text.text = "岩から鉱石増加";
			}
			if (LocalizationScript.isKorean)
			{
				this.skillTreeName_text.text = "암석에서 광석 추가 획득";
			}
			if (LocalizationScript.isPolish)
			{
				this.skillTreeName_text.text = "Więcej Rudy ze Skał";
			}
			if (LocalizationScript.isPortugese)
			{
				this.skillTreeName_text.text = "Mais Minérios das Rochas";
			}
			if (LocalizationScript.isRussian)
			{
				this.skillTreeName_text.text = "Больше Руды из Камней";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.skillTreeName_text.text = "岩石产出更多矿石";
			}
			if (flag)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeDesc_text.text = string.Format("Ores mined from chunk rocks: {0}\nOres mined from full material rocks: {1}", SkillTree.materialsFromChunkRocks, SkillTree.materialsFromFullRocks);
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeDesc_text.text = string.Format("Minerais extraits des roches riches : {0}\nMinerais extraits des roches pleines : {1}", SkillTree.materialsFromChunkRocks, SkillTree.materialsFromFullRocks);
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeDesc_text.text = string.Format("Minerali estratti dalle rocce a blocchi: {0}\nMinerali estratti dalle rocce piene: {1}", SkillTree.materialsFromChunkRocks, SkillTree.materialsFromFullRocks);
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeDesc_text.text = string.Format("Erze aus Brockensteinen: {0}\nErze aus vollen Materialsteinen: {1}", SkillTree.materialsFromChunkRocks, SkillTree.materialsFromFullRocks);
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeDesc_text.text = string.Format("Minerales extraídos de rocas con vetas: {0}\nMinerales extraídos de rocas completas: {1}", SkillTree.materialsFromChunkRocks, SkillTree.materialsFromFullRocks);
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeDesc_text.text = string.Format("塊状岩から採掘される鉱石: {0}\nフル鉱石岩から採掘される鉱石: {1}", SkillTree.materialsFromChunkRocks, SkillTree.materialsFromFullRocks);
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeDesc_text.text = string.Format("덩어리 암석에서 채굴된 광석: {0}\n전체 암석에서 채굴된 광석: {1}", SkillTree.materialsFromChunkRocks, SkillTree.materialsFromFullRocks);
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeDesc_text.text = string.Format("Ruda z blokowych skał: {0}\nRuda z pełnych skał: {1}", SkillTree.materialsFromChunkRocks, SkillTree.materialsFromFullRocks);
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeDesc_text.text = string.Format("Minérios extraídos de rochas com blocos: {0}\nMinérios extraídos de rochas completas: {1}", SkillTree.materialsFromChunkRocks, SkillTree.materialsFromFullRocks);
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeDesc_text.text = string.Format("Руда из кусковых камней: {0}\nРуда из цельных камней: {1}", SkillTree.materialsFromChunkRocks, SkillTree.materialsFromFullRocks);
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeDesc_text.text = string.Format("从块状岩石中采集的矿石: {0}\n从整块矿石岩石中采集的矿石: {1}", SkillTree.materialsFromChunkRocks, SkillTree.materialsFromFullRocks);
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeDesc_text.text = string.Format("Ores mined from chunk rocks: {0} -> {1}\nOres mined from full material rocks: {2} -> {3}", new object[]
					{
						SkillTree.materialsFromChunkRocks,
						num30,
						SkillTree.materialsFromFullRocks,
						num31
					});
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeDesc_text.text = string.Format("Minerais extraits des roches riches : {0} -> {1}\nMinerais extraits des roches pleines : {2} -> {3}", new object[]
					{
						SkillTree.materialsFromChunkRocks,
						num30,
						SkillTree.materialsFromFullRocks,
						num31
					});
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeDesc_text.text = string.Format("Minerali estratti dalle rocce a blocchi: {0} -> {1}\nMinerali estratti dalle rocce piene: {2} -> {3}", new object[]
					{
						SkillTree.materialsFromChunkRocks,
						num30,
						SkillTree.materialsFromFullRocks,
						num31
					});
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeDesc_text.text = string.Format("Erze aus Brockensteinen: {0} -> {1}\nErze aus vollen Materialsteinen: {2} -> {3}", new object[]
					{
						SkillTree.materialsFromChunkRocks,
						num30,
						SkillTree.materialsFromFullRocks,
						num31
					});
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeDesc_text.text = string.Format("Minerales extraídos de rocas con vetas: {0} -> {1}\nMinerales extraídos de rocas completas: {2} -> {3}", new object[]
					{
						SkillTree.materialsFromChunkRocks,
						num30,
						SkillTree.materialsFromFullRocks,
						num31
					});
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeDesc_text.text = string.Format("塊状岩から採掘される鉱石: {0} -> {1}\nフル鉱石岩から採掘される鉱石: {2} -> {3}", new object[]
					{
						SkillTree.materialsFromChunkRocks,
						num30,
						SkillTree.materialsFromFullRocks,
						num31
					});
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeDesc_text.text = string.Format("덩어리 암석에서 채굴된 광석: {0} -> {1}\n전체 암석에서 채굴된 광석: {2} -> {3}", new object[]
					{
						SkillTree.materialsFromChunkRocks,
						num30,
						SkillTree.materialsFromFullRocks,
						num31
					});
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeDesc_text.text = string.Format("Ruda z blokowych skał: {0} -> {1}\nRuda z pełnych skał: {2} -> {3}", new object[]
					{
						SkillTree.materialsFromChunkRocks,
						num30,
						SkillTree.materialsFromFullRocks,
						num31
					});
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeDesc_text.text = string.Format("Minérios extraídos de rochas com blocos: {0} -> {1}\nMinérios extraídos de rochas completas: {2} -> {3}", new object[]
					{
						SkillTree.materialsFromChunkRocks,
						num30,
						SkillTree.materialsFromFullRocks,
						num31
					});
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeDesc_text.text = string.Format("Руда из кусковых камней: {0} -> {1}\nРуда из цельных камней: {2} -> {3}", new object[]
					{
						SkillTree.materialsFromChunkRocks,
						num30,
						SkillTree.materialsFromFullRocks,
						num31
					});
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeDesc_text.text = string.Format("从块状岩石中采集的矿石: {0} -> {1}\n从整块矿石岩石中采集的矿石: {2} -> {3}", new object[]
					{
						SkillTree.materialsFromChunkRocks,
						num30,
						SkillTree.materialsFromFullRocks,
						num31
					});
				}
			}
		}
		else if (upgradeType == 15)
		{
			if (upgradeName == "MaterialsWorthMore1")
			{
				LocalizationScript.materialsWorthIncrease = 1f;
			}
			else if (upgradeName == "MaterialsWorthMore2")
			{
				LocalizationScript.materialsWorthIncrease = 2f;
			}
			else if (upgradeName == "MaterialsWorthMore3")
			{
				LocalizationScript.materialsWorthIncrease = 3f;
			}
			else if (upgradeName == "MaterialsWorthMore4")
			{
				LocalizationScript.materialsWorthIncrease = 9f;
			}
			else if (upgradeName == "MaterialsWorthMore5")
			{
				LocalizationScript.materialsWorthIncrease = 12f;
			}
			else if (upgradeName == "MaterialsWorthMore6")
			{
				LocalizationScript.materialsWorthIncrease = 4f;
			}
			else if (upgradeName == "MaterialsWorthMore7")
			{
				LocalizationScript.materialsWorthIncrease = 6f;
			}
			else if (upgradeName == "MaterialsWorthMore8")
			{
				LocalizationScript.materialsWorthIncrease = 18f;
			}
			else if (upgradeName == "EndlessGold1")
			{
				LocalizationScript.materialsWorthIncrease = 12f;
			}
			else if (upgradeName == "EndlessGold2")
			{
				LocalizationScript.materialsWorthIncrease = 12f;
			}
			float num32 = SkillTree.materialsTotalWorth + LocalizationScript.materialsWorthIncrease;
			if (LocalizationScript.isEnglish)
			{
				this.skillTreeName_text.text = "Ore Value";
			}
			if (LocalizationScript.isFrench)
			{
				this.skillTreeName_text.text = "Valeur du Minerai";
			}
			if (LocalizationScript.isItalian)
			{
				this.skillTreeName_text.text = "Valore del Minerale";
			}
			if (LocalizationScript.isGerman)
			{
				this.skillTreeName_text.text = "Erzwert";
			}
			if (LocalizationScript.isSpanish)
			{
				this.skillTreeName_text.text = "Valor del Mineral";
			}
			if (LocalizationScript.isJapanese)
			{
				this.skillTreeName_text.text = "鉱石価値";
			}
			if (LocalizationScript.isKorean)
			{
				this.skillTreeName_text.text = "광석 가치";
			}
			if (LocalizationScript.isPolish)
			{
				this.skillTreeName_text.text = "Wartość Rudy";
			}
			if (LocalizationScript.isPortugese)
			{
				this.skillTreeName_text.text = "Valor do Minério";
			}
			if (LocalizationScript.isRussian)
			{
				this.skillTreeName_text.text = "Ценность Руды";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.skillTreeName_text.text = "矿石价值";
			}
			if (flag)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeDesc_text.text = "Total value of mined ores:\n" + (SkillTree.materialsTotalWorth * 100f).ToString("F0") + "%";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeDesc_text.text = "Valeur totale des minerais extraits :\n" + (SkillTree.materialsTotalWorth * 100f).ToString("F0") + "%";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeDesc_text.text = "Valore totale dei minerali estratti:\n" + (SkillTree.materialsTotalWorth * 100f).ToString("F0") + "%";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeDesc_text.text = "Gesamtwert der abgebauten Erze:\n" + (SkillTree.materialsTotalWorth * 100f).ToString("F0") + "%";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeDesc_text.text = "Valor total de los minerales extraídos:\n" + (SkillTree.materialsTotalWorth * 100f).ToString("F0") + "%";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeDesc_text.text = "採掘した鉱石の総価値：\n" + (SkillTree.materialsTotalWorth * 100f).ToString("F0") + "%";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeDesc_text.text = "채굴된 광석의 총 가치:\n" + (SkillTree.materialsTotalWorth * 100f).ToString("F0") + "%";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeDesc_text.text = "Łączna wartość wydobytej rudy:\n" + (SkillTree.materialsTotalWorth * 100f).ToString("F0") + "%";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeDesc_text.text = "Valor total dos minérios extraídos:\n" + (SkillTree.materialsTotalWorth * 100f).ToString("F0") + "%";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeDesc_text.text = "Общая ценность добытой руды:\n" + (SkillTree.materialsTotalWorth * 100f).ToString("F0") + "%";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeDesc_text.text = "采集矿石的总价值：\n" + (SkillTree.materialsTotalWorth * 100f).ToString("F0") + "%";
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Increase the value of every mined ore:\n",
						(SkillTree.materialsTotalWorth * 100f).ToString("F0"),
						"% -> ",
						(num32 * 100f).ToString("F0"),
						"%"
					});
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Augmente la valeur de chaque minerai extrait :\n",
						(SkillTree.materialsTotalWorth * 100f).ToString("F0"),
						"% -> ",
						(num32 * 100f).ToString("F0"),
						"%"
					});
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Aumenta il valore di ogni minerale estratto:\n",
						(SkillTree.materialsTotalWorth * 100f).ToString("F0"),
						"% -> ",
						(num32 * 100f).ToString("F0"),
						"%"
					});
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Erhöht den Wert jedes abgebauten Erzes:\n",
						(SkillTree.materialsTotalWorth * 100f).ToString("F0"),
						"% -> ",
						(num32 * 100f).ToString("F0"),
						"%"
					});
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Aumenta el valor de cada mineral extraído:\n",
						(SkillTree.materialsTotalWorth * 100f).ToString("F0"),
						"% -> ",
						(num32 * 100f).ToString("F0"),
						"%"
					});
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"採掘した鉱石の価値を増加：\n",
						(SkillTree.materialsTotalWorth * 100f).ToString("F0"),
						"% -> ",
						(num32 * 100f).ToString("F0"),
						"%"
					});
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"채굴된 광석의 가치 증가:\n",
						(SkillTree.materialsTotalWorth * 100f).ToString("F0"),
						"% -> ",
						(num32 * 100f).ToString("F0"),
						"%"
					});
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Zwiększa wartość każdej wydobytej rudy:\n",
						(SkillTree.materialsTotalWorth * 100f).ToString("F0"),
						"% -> ",
						(num32 * 100f).ToString("F0"),
						"%"
					});
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Aumenta o valor de cada minério extraído:\n",
						(SkillTree.materialsTotalWorth * 100f).ToString("F0"),
						"% -> ",
						(num32 * 100f).ToString("F0"),
						"%"
					});
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Увеличивает ценность каждой добытой руды:\n",
						(SkillTree.materialsTotalWorth * 100f).ToString("F0"),
						"% -> ",
						(num32 * 100f).ToString("F0"),
						"%"
					});
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"提升每块采集矿石的价值：\n",
						(SkillTree.materialsTotalWorth * 100f).ToString("F0"),
						"% -> ",
						(num32 * 100f).ToString("F0"),
						"%"
					});
				}
			}
		}
		else if (upgradeType == 16)
		{
			if (upgradeName == "ImprovedPickaxe1")
			{
				LocalizationScript.improvedPickaxeIncrease = 0.031f;
			}
			else if (upgradeName == "ImprovedPickaxe2")
			{
				LocalizationScript.improvedPickaxeIncrease = 0.034f;
			}
			else if (upgradeName == "ImprovedPickaxe3")
			{
				LocalizationScript.improvedPickaxeIncrease = 0.04f;
			}
			else if (upgradeName == "ImprovedPickaxe4")
			{
				LocalizationScript.improvedPickaxeIncrease = 0.045f;
			}
			else if (upgradeName == "ImprovedPickaxe5")
			{
				LocalizationScript.improvedPickaxeIncrease = 0.054f;
			}
			else if (upgradeName == "ImprovedPickaxe6")
			{
				LocalizationScript.improvedPickaxeIncrease = 0.063f;
			}
			else if (upgradeName == "EndlessPickaxe1")
			{
				LocalizationScript.improvedPickaxeIncrease = 0.001f;
			}
			else if (upgradeName == "EndlessPickaxe2")
			{
				LocalizationScript.improvedPickaxeIncrease = 0.001f;
			}
			if (LocalizationScript.isEnglish)
			{
				this.skillTreeName_text.text = "Improved Pickaxe";
			}
			if (LocalizationScript.isFrench)
			{
				this.skillTreeName_text.text = "Pioche Améliorée";
			}
			if (LocalizationScript.isItalian)
			{
				this.skillTreeName_text.text = "Piccone Potenziato";
			}
			if (LocalizationScript.isGerman)
			{
				this.skillTreeName_text.text = "Verbesserte Spitzhacke";
			}
			if (LocalizationScript.isSpanish)
			{
				this.skillTreeName_text.text = "Pico Mejorado";
			}
			if (LocalizationScript.isJapanese)
			{
				this.skillTreeName_text.text = "改良ピッケル";
			}
			if (LocalizationScript.isKorean)
			{
				this.skillTreeName_text.text = "개선된 곡괭이";
			}
			if (LocalizationScript.isPolish)
			{
				this.skillTreeName_text.text = "Ulepszony Kilof";
			}
			if (LocalizationScript.isPortugese)
			{
				this.skillTreeName_text.text = "Picareta Aprimorada";
			}
			if (LocalizationScript.isRussian)
			{
				this.skillTreeName_text.text = "Улучшенная Кирка";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.skillTreeName_text.text = "强化镐子";
			}
			float num33 = SkillTree.improvedPickaxeStrength + LocalizationScript.improvedPickaxeIncrease;
			if (flag)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeDesc_text.text = "Total pickaxe stat increase:\n" + (SkillTree.improvedPickaxeStrength * 100f).ToString("F1") + "%";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeDesc_text.text = "Augmentation totale des stats de la pioche :\n" + (SkillTree.improvedPickaxeStrength * 100f).ToString("F1") + "%";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeDesc_text.text = "Aumento totale delle statistiche del piccone:\n" + (SkillTree.improvedPickaxeStrength * 100f).ToString("F1") + "%";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeDesc_text.text = "Gesamte Spitzhacken-Wert-Steigerung:\n" + (SkillTree.improvedPickaxeStrength * 100f).ToString("F1") + "%";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeDesc_text.text = "Aumento total de estadísticas del pico:\n" + (SkillTree.improvedPickaxeStrength * 100f).ToString("F1") + "%";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeDesc_text.text = "ピッケルのステータス合計増加：\n" + (SkillTree.improvedPickaxeStrength * 100f).ToString("F1") + "%";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeDesc_text.text = "곡괭이 스탯 총 증가량:\n" + (SkillTree.improvedPickaxeStrength * 100f).ToString("F1") + "%";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeDesc_text.text = "Łączny wzrost statystyk kilofa:\n" + (SkillTree.improvedPickaxeStrength * 100f).ToString("F1") + "%";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeDesc_text.text = "Aumento total de atributos da picareta:\n" + (SkillTree.improvedPickaxeStrength * 100f).ToString("F1") + "%";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeDesc_text.text = "Общее увеличение характеристик кирки:\n" + (SkillTree.improvedPickaxeStrength * 100f).ToString("F1") + "%";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeDesc_text.text = "镐子属性总提升：\n" + (SkillTree.improvedPickaxeStrength * 100f).ToString("F1") + "%";
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Increase all pickaxe stats:\n",
						(SkillTree.improvedPickaxeStrength * 100f).ToString("F1"),
						"% -> ",
						(num33 * 100f).ToString("F1"),
						"%"
					});
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Augmente toutes les stats de la pioche :\n",
						(SkillTree.improvedPickaxeStrength * 100f).ToString("F1"),
						"% -> ",
						(num33 * 100f).ToString("F1"),
						"%"
					});
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Aumenta tutte le statistiche del piccone:\n",
						(SkillTree.improvedPickaxeStrength * 100f).ToString("F1"),
						"% -> ",
						(num33 * 100f).ToString("F1"),
						"%"
					});
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Erhöht alle Spitzhacken-Werte:\n",
						(SkillTree.improvedPickaxeStrength * 100f).ToString("F1"),
						"% -> ",
						(num33 * 100f).ToString("F1"),
						"%"
					});
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Aumenta todas las estadísticas del pico:\n",
						(SkillTree.improvedPickaxeStrength * 100f).ToString("F1"),
						"% -> ",
						(num33 * 100f).ToString("F1"),
						"%"
					});
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"全てのピッケルのステータスを強化：\n",
						(SkillTree.improvedPickaxeStrength * 100f).ToString("F1"),
						"% -> ",
						(num33 * 100f).ToString("F1"),
						"%"
					});
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"모든 곡괭이 스탯 강화:\n",
						(SkillTree.improvedPickaxeStrength * 100f).ToString("F1"),
						"% -> ",
						(num33 * 100f).ToString("F1"),
						"%"
					});
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Zwiększa wszystkie statystyki kilofa:\n",
						(SkillTree.improvedPickaxeStrength * 100f).ToString("F1"),
						"% -> ",
						(num33 * 100f).ToString("F1"),
						"%"
					});
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Aumenta todos os atributos da picareta:\n",
						(SkillTree.improvedPickaxeStrength * 100f).ToString("F1"),
						"% -> ",
						(num33 * 100f).ToString("F1"),
						"%"
					});
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Увеличивает все характеристики кирки:\n",
						(SkillTree.improvedPickaxeStrength * 100f).ToString("F1"),
						"% -> ",
						(num33 * 100f).ToString("F1"),
						"%"
					});
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"提升所有镐子属性：\n",
						(SkillTree.improvedPickaxeStrength * 100f).ToString("F1"),
						"% -> ",
						(num33 * 100f).ToString("F1"),
						"%"
					});
				}
			}
		}
		else if (upgradeType == 17)
		{
			bool flag22 = false;
			if (upgradeName == "BiggerMiningErea1")
			{
				LocalizationScript.miningAreaIncrease = 0.02f;
			}
			else if (upgradeName == "BiggerMiningErea2")
			{
				LocalizationScript.miningAreaIncrease = 0.02f;
			}
			else if (upgradeName == "BiggerMiningErea3")
			{
				LocalizationScript.miningAreaIncrease = 0.02f;
			}
			else if (upgradeName == "BiggerMiningErea4")
			{
				LocalizationScript.miningAreaIncrease = 0.02f;
			}
			else if (upgradeName == "ShootCircle")
			{
				flag22 = true;
			}
			else if (upgradeName == "IncreaseAndDecreaseCircle")
			{
				flag22 = true;
			}
			if (flag22)
			{
				if (upgradeName == "ShootCircle")
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeName_text.text = "Circle Shots";
						this.skillTreeDesc_text.text = string.Format("Every second, a small circle has a {0}% chance to shoot in a random direction.\nRocks inside this circle will be mined.", SkillTree.circleShootChance);
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeName_text.text = "Tirs Circulaires";
						this.skillTreeDesc_text.text = string.Format("<size=21>Chaque seconde, un petit cercle a {0}% de chance de tirer dans une direction aléatoire.\nLes roches à l'intérieur seront minées.", SkillTree.circleShootChance);
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeName_text.text = "Colpi Circolari";
						this.skillTreeDesc_text.text = string.Format("<size=21>Ogni secondo, un piccolo cerchio ha il {0}% di probabilità di sparare in una direzione casuale.\nLe rocce all'interno saranno estratte.", SkillTree.circleShootChance);
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeName_text.text = "Kreis-Schüsse";
						this.skillTreeDesc_text.text = string.Format("<size=21>Jede Sekunde hat ein kleiner Kreis eine Chance von {0}%, in eine zufällige Richtung zu schießen.\nSteine im Kreis werden abgebaut.", SkillTree.circleShootChance);
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeName_text.text = "Disparos Circulares";
						this.skillTreeDesc_text.text = string.Format("<size=21>Cada segundo, un pequeño círculo tiene un {0}% de probabilidad de disparar en una dirección aleatoria.\nLas rocas dentro del círculo serán minadas.", SkillTree.circleShootChance);
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeName_text.text = "サークルショット";
						this.skillTreeDesc_text.text = string.Format("毎秒、小さなサークルが{0}%の確率でランダム方向に発射します。\nサークル内の岩は採掘されます。", SkillTree.circleShootChance);
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeName_text.text = "서클 샷";
						this.skillTreeDesc_text.text = string.Format("매초 작은 원이 {0}% 확률로 랜덤 방향으로 발사됩니다.\n원 안의 바위는 채굴됩니다.", SkillTree.circleShootChance);
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeName_text.text = "Strzały Okręgu";
						this.skillTreeDesc_text.text = string.Format("Co sekundę mały okrąg ma {0}% szansy na strzał w losowym kierunku.\nSkały w środku zostaną wydobyte.", SkillTree.circleShootChance);
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeName_text.text = "Disparos em Círculo";
						this.skillTreeDesc_text.text = string.Format("<size=22>A cada segundo, um pequeno círculo tem {0}% de chance de disparar em uma direção aleatória.\nPedras dentro dele serão mineradas.", SkillTree.circleShootChance);
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeName_text.text = "Круговые Выстрелы";
						this.skillTreeDesc_text.text = string.Format("<size=23>Каждую секунду маленький круг имеет {0}% шанс выстрелить в случайном направлении.\nКамни внутри будут добыты.", SkillTree.circleShootChance);
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeName_text.text = "圆形射击";
						this.skillTreeDesc_text.text = string.Format("每秒小圆圈有 {0}% 的几率向随机方向发射。\n圆圈内的岩石会被开采。", SkillTree.circleShootChance);
					}
				}
				else if (upgradeName == "IncreaseAndDecreaseCircle")
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeName_text.text = "In and Out";
						this.skillTreeDesc_text.text = "The mining area will increase and decrease in size:\n110%-95%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeName_text.text = "Va-et-vient";
						this.skillTreeDesc_text.text = "La zone de minage va s'agrandir et rétrécir :\n110%-95%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeName_text.text = "Dentro e Fuori";
						this.skillTreeDesc_text.text = "L'area di scavo si espanderà e si ridurrà di dimensione:\n110%-95%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeName_text.text = "Rein und Raus";
						this.skillTreeDesc_text.text = "Das Abbaugebiet wird sich vergrößern und verkleinern:\n110%-95%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeName_text.text = "Dentro y Fuera";
						this.skillTreeDesc_text.text = "El área de minado aumentará y disminuirá de tamaño:\n110%-95%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeName_text.text = "イン＆アウト";
						this.skillTreeDesc_text.text = "採掘エリアが拡大・縮小します：\n110%-95%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeName_text.text = "인 앤 아웃";
						this.skillTreeDesc_text.text = "채굴 범위가 커졌다 작아졌다 합니다:\n110%-95%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeName_text.text = "W Tę i Z Powrotem";
						this.skillTreeDesc_text.text = "Obszar wydobycia będzie się powiększać i zmniejszać:\n110%-95%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeName_text.text = "Dentro e Fora";
						this.skillTreeDesc_text.text = "A área de mineração vai aumentar e diminuir de tamanho:\n110%-95%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeName_text.text = "Туда и Обратно";
						this.skillTreeDesc_text.text = "Зона добычи будет увеличиваться и уменьшаться:\n110%-95%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeName_text.text = "收缩扩张";
						this.skillTreeDesc_text.text = "采矿范围会放大和缩小：\n110%-95%";
					}
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Bigger Mining Area";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Zone de Minage Agrandie";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Area di Scavo Maggiore";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Größeres Abbaugebiet";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Área de Minado Mayor";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "採掘エリア拡大";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "채굴 범위 확장";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Większy Obszar Wydobycia";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Área de Mineração Maior";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Увеличить Зону Добычи";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更大采矿范围";
				}
				float num34 = SkillTree.miningAreaSize + LocalizationScript.miningAreaIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total mining area size increase:\n" + (SkillTree.miningAreaSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Augmentation totale de la zone de minage :\n" + (SkillTree.miningAreaSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Aumento totale dell'area di scavo:\n" + (SkillTree.miningAreaSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtsteigerung der Abbaugebietsgröße:\n" + (SkillTree.miningAreaSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Aumento total del área de minado:\n" + (SkillTree.miningAreaSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "採掘エリアの総拡大率：\n" + (SkillTree.miningAreaSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "채굴 범위 총 증가량:\n" + (SkillTree.miningAreaSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączne zwiększenie obszaru wydobycia:\n" + (SkillTree.miningAreaSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Aumento total da área de mineração:\n" + (SkillTree.miningAreaSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общее увеличение зоны добычи:\n" + (SkillTree.miningAreaSize * 100f).ToString("F0") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "采矿范围总增幅：\n" + (SkillTree.miningAreaSize * 100f).ToString("F0") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the mining area size:\n",
							(SkillTree.miningAreaSize * 100f).ToString("F0"),
							"% -> ",
							(num34 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la taille de la zone de minage :\n",
							(SkillTree.miningAreaSize * 100f).ToString("F0"),
							"% -> ",
							(num34 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta l'area di scavo:\n",
							(SkillTree.miningAreaSize * 100f).ToString("F0"),
							"% -> ",
							(num34 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Größe des Abbaugebiets:\n",
							(SkillTree.miningAreaSize * 100f).ToString("F0"),
							"% -> ",
							(num34 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta el tamaño del área de minado:\n",
							(SkillTree.miningAreaSize * 100f).ToString("F0"),
							"% -> ",
							(num34 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"採掘エリアのサイズを拡大：\n",
							(SkillTree.miningAreaSize * 100f).ToString("F0"),
							"% -> ",
							(num34 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"채굴 범위 크기 증가:\n",
							(SkillTree.miningAreaSize * 100f).ToString("F0"),
							"% -> ",
							(num34 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Zwiększa obszar wydobycia:\n",
							(SkillTree.miningAreaSize * 100f).ToString("F0"),
							"% -> ",
							(num34 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta o tamanho da área de mineração:\n",
							(SkillTree.miningAreaSize * 100f).ToString("F0"),
							"% -> ",
							(num34 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает размер зоны добычи:\n",
							(SkillTree.miningAreaSize * 100f).ToString("F0"),
							"% -> ",
							(num34 * 100f).ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"扩大采矿范围：\n",
							(SkillTree.miningAreaSize * 100f).ToString("F0"),
							"% -> ",
							(num34 * 100f).ToString("F0"),
							"%"
						});
					}
				}
			}
		}
		else if (upgradeType == 18)
		{
			bool flag23 = false;
			bool flag24 = false;
			bool flag25 = false;
			if (upgradeName == "EveryXRockSpawnRock1")
			{
				flag23 = true;
				LocalizationScript.spawnEveryRockIncrease = 1f;
				if (purchaseCount >= totalPurchaseCount)
				{
					flag = true;
					LocalizationScript.spawnEveryRockIncrease = 0f;
				}
			}
			else if (upgradeName == "EveryXRockSpawnRock2")
			{
				flag23 = true;
				LocalizationScript.spawnEveryRockIncrease = 1f;
				if (purchaseCount >= totalPurchaseCount)
				{
					flag = true;
					LocalizationScript.spawnEveryRockIncrease = 0f;
				}
			}
			else if (upgradeName == "EveryXRockSpawnRock3")
			{
				flag23 = true;
				LocalizationScript.spawnEveryRockIncrease = 1f;
				if (purchaseCount >= totalPurchaseCount)
				{
					flag = true;
					LocalizationScript.spawnEveryRockIncrease = 0f;
				}
			}
			else if (upgradeName == "SpawnRockEveryXSecond1")
			{
				flag24 = true;
				LocalizationScript.spawnEverySecondIncrease = 0.7f;
				if (purchaseCount >= totalPurchaseCount)
				{
					flag = true;
					LocalizationScript.spawnEverySecondIncrease = 0f;
				}
			}
			else if (upgradeName == "SpawnRockEveryXSecond2")
			{
				flag24 = true;
				LocalizationScript.spawnEverySecondIncrease = 0.7f;
				if (purchaseCount >= totalPurchaseCount)
				{
					flag = true;
					LocalizationScript.spawnEverySecondIncrease = 0f;
				}
			}
			else if (upgradeName == "SpawnRockEveryXSecond3")
			{
				flag24 = true;
				LocalizationScript.spawnEverySecondIncrease = 0.4f;
				if (purchaseCount >= totalPurchaseCount)
				{
					flag = true;
					LocalizationScript.spawnEverySecondIncrease = 0f;
				}
			}
			else if (upgradeName == "ChanceToSpawnRockWhenMined1")
			{
				flag25 = true;
				LocalizationScript.spawnWhenMinedIncrease = 2f;
			}
			else if (upgradeName == "ChanceToSpawnRockWhenMined2")
			{
				flag25 = true;
				LocalizationScript.spawnWhenMinedIncrease = 3f;
			}
			else if (upgradeName == "ChanceToSpawnRockWhenMined3")
			{
				flag25 = true;
				LocalizationScript.spawnWhenMinedIncrease = 3f;
			}
			else if (upgradeName == "ChanceToSpawnRockWhenMined4")
			{
				flag25 = true;
				LocalizationScript.spawnWhenMinedIncrease = 4f;
			}
			else if (upgradeName == "ChanceToSpawnRockWhenMined5")
			{
				flag25 = true;
				LocalizationScript.spawnWhenMinedIncrease = 5f;
			}
			else if (upgradeName == "ChanceToSpawnRockWhenMined6")
			{
				flag25 = true;
				LocalizationScript.spawnWhenMinedIncrease = 4f;
			}
			if (flag23)
			{
				float num35 = SkillTree.spawnRockEveryXRock - LocalizationScript.spawnEveryRockIncrease;
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Rocks Into More Rocks";
					this.skillTreeDesc_text.text = string.Format("Spawn 1 rock for every {0} rocks mined", num35);
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Roches en Plus de Roches";
					this.skillTreeDesc_text.text = string.Format("Fait apparaître 1 roche pour chaque {0} roches extraites", num35);
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Rocce in Altre Rocce";
					this.skillTreeDesc_text.text = string.Format("Genera 1 roccia ogni {0} rocce estratte", num35);
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Steine zu Mehr Steinen";
					this.skillTreeDesc_text.text = string.Format("Spawnt 1 Stein für je {0} abgebaute Steine", num35);
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Rocas en Más Rocas";
					this.skillTreeDesc_text.text = string.Format("Genera 1 roca por cada {0} rocas extraídas", num35);
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "岩からさらに岩";
					this.skillTreeDesc_text.text = string.Format("採掘した{0}個の岩ごとに1個の岩を生成", num35);
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "바위에서 더 많은 바위";
					this.skillTreeDesc_text.text = string.Format("{0}개의 바위를 캘 때마다 1개의 바위 생성", num35);
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Skały w Więcej Skał";
					this.skillTreeDesc_text.text = string.Format("Tworzy 1 skałę za każde wydobyte {0} skał", num35);
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Rochas em Mais Rochas";
					this.skillTreeDesc_text.text = string.Format("Gera 1 rocha a cada {0} rochas mineradas", num35);
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Камни в Ещё Камни";
					this.skillTreeDesc_text.text = string.Format("Создаёт 1 камень за каждые {0} добытых камней", num35);
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "岩石变更多岩石";
					this.skillTreeDesc_text.text = string.Format("每开采 {0} 块岩石生成 1 块新岩石", num35);
				}
			}
			else if (flag24)
			{
				float num35 = SkillTree.spawnXRockEveryXSecond - LocalizationScript.spawnEverySecondIncrease;
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Wait For More Rocks";
					this.skillTreeDesc_text.text = "Spawn 1 rock every " + num35.ToString("F1") + " second";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Attendre Plus de Roches";
					this.skillTreeDesc_text.text = "Fait apparaître 1 roche toutes les " + num35.ToString("F1") + " secondes";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Aspetta Altre Rocce";
					this.skillTreeDesc_text.text = "Genera 1 roccia ogni " + num35.ToString("F1") + " secondi";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Warten auf Mehr Steine";
					this.skillTreeDesc_text.text = "Spawnt 1 Stein alle " + num35.ToString("F1") + " Sekunden";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Esperar Más Rocas";
					this.skillTreeDesc_text.text = "Genera 1 roca cada " + num35.ToString("F1") + " segundos";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "待って岩を増やす";
					this.skillTreeDesc_text.text = "毎" + num35.ToString("F1") + "秒ごとに1個の岩を生成";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "기다려서 바위 생성";
					this.skillTreeDesc_text.text = num35.ToString("F1") + "초마다 바위 1개 생성";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Czekaj na Więcej Skał";
					this.skillTreeDesc_text.text = "Tworzy 1 skałę co " + num35.ToString("F1") + " sekundy";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Esperar por Mais Rochas";
					this.skillTreeDesc_text.text = "Gera 1 rocha a cada " + num35.ToString("F1") + " segundo";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Ждать Больше Камней";
					this.skillTreeDesc_text.text = "Создаёт 1 камень каждые " + num35.ToString("F1") + " секунды";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "等待生成更多岩石";
					this.skillTreeDesc_text.text = "每 " + num35.ToString("F1") + " 秒生成 1 块岩石";
				}
			}
			else if (flag25)
			{
				float num35 = SkillTree.chanceToSpawnRockWhenMined + LocalizationScript.spawnWhenMinedIncrease;
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Rock Spawn Chance";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Chance d'Apparition de Roche";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Probabilità Generazione Roccia";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Stein-Spawn-Chance";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Probabilidad de Aparición de Roca";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "岩出現確率";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "바위 생성 확률";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Szansa Pojawienia Skały";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Chance de Surgimento de Rocha";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Шанс Спавна Камня";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "岩石生成概率";
				}
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total spawn 1 rock when a rock is mined chance:\n" + SkillTree.chanceToSpawnRockWhenMined.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance totale de générer 1 roche quand une roche est extraite :\n" + SkillTree.chanceToSpawnRockWhenMined.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di generare 1 roccia quando una roccia viene estratta:\n" + SkillTree.chanceToSpawnRockWhenMined.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance, 1 Stein zu spawnen, wenn ein Stein abgebaut wird:\n" + SkillTree.chanceToSpawnRockWhenMined.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de generar 1 roca cuando se extrae una roca:\n" + SkillTree.chanceToSpawnRockWhenMined.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "岩を採掘した時に岩が1個生成される総確率：\n" + SkillTree.chanceToSpawnRockWhenMined.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "바위를 캘 때 바위 1개 생성 총 확률:\n" + SkillTree.chanceToSpawnRockWhenMined.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na pojawienie się 1 skały po wydobyciu skały:\n" + SkillTree.chanceToSpawnRockWhenMined.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de gerar 1 rocha ao minerar uma rocha:\n" + SkillTree.chanceToSpawnRockWhenMined.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс заспавнить 1 камень при добыче камня:\n" + SkillTree.chanceToSpawnRockWhenMined.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "开采岩石时生成 1 块新岩石的总概率：\n" + SkillTree.chanceToSpawnRockWhenMined.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Chance to spawn 1 rock when a rock is mined:\n",
							SkillTree.chanceToSpawnRockWhenMined.ToString("F1"),
							"% -> ",
							num35.ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Chance de générer 1 roche quand une roche est extraite :\n",
							SkillTree.chanceToSpawnRockWhenMined.ToString("F1"),
							"% -> ",
							num35.ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Probabilità di generare 1 roccia quando una roccia viene estratta:\n",
							SkillTree.chanceToSpawnRockWhenMined.ToString("F1"),
							"% -> ",
							num35.ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Chance, 1 Stein zu spawnen, wenn ein Stein abgebaut wird:\n",
							SkillTree.chanceToSpawnRockWhenMined.ToString("F1"),
							"% -> ",
							num35.ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Probabilidad de generar 1 roca cuando se extrae una roca:\n",
							SkillTree.chanceToSpawnRockWhenMined.ToString("F1"),
							"% -> ",
							num35.ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"岩を採掘した時に岩が1個生成される確率：\n",
							SkillTree.chanceToSpawnRockWhenMined.ToString("F1"),
							"% -> ",
							num35.ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"바위를 캘 때 바위 1개 생성 확률:\n",
							SkillTree.chanceToSpawnRockWhenMined.ToString("F1"),
							"% -> ",
							num35.ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Szansa na pojawienie się 1 skały po wydobyciu skały:\n",
							SkillTree.chanceToSpawnRockWhenMined.ToString("F1"),
							"% -> ",
							num35.ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Chance de gerar 1 rocha ao minerar uma rocha:\n",
							SkillTree.chanceToSpawnRockWhenMined.ToString("F1"),
							"% -> ",
							num35.ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Шанс заспавнить 1 камень при добыче камня:\n",
							SkillTree.chanceToSpawnRockWhenMined.ToString("F1"),
							"% -> ",
							num35.ToString("F1"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"开采岩石时生成 1 块新岩石的几率：\n",
							SkillTree.chanceToSpawnRockWhenMined.ToString("F1"),
							"% -> ",
							num35.ToString("F1"),
							"%"
						});
					}
				}
			}
		}
		else if (upgradeType == 19)
		{
			bool flag26 = false;
			bool flag27 = false;
			if (upgradeName == "ChanceToMineRandomRock1")
			{
				flag26 = true;
				LocalizationScript.chanceToMineRandomRockIncrease = 1f;
			}
			else if (upgradeName == "ChanceToMineRandomRock2")
			{
				flag26 = true;
				LocalizationScript.chanceToMineRandomRockIncrease = 1f;
			}
			else if (upgradeName == "ChanceToMineRandomRock3")
			{
				flag26 = true;
				LocalizationScript.chanceToMineRandomRockIncrease = 2f;
			}
			else if (upgradeName == "ChanceToMineRandomRock4")
			{
				flag26 = true;
				LocalizationScript.chanceToMineRandomRockIncrease = 3f;
			}
			else if (upgradeName == "SpawnPickaxeEverySecond1")
			{
				flag27 = true;
				LocalizationScript.spawnPickaxeEverySecondIncrease = 0.2f;
			}
			else if (upgradeName == "SpawnPickaxeEverySecond2")
			{
				flag27 = true;
				LocalizationScript.spawnPickaxeEverySecondIncrease = 0.3f;
			}
			else if (upgradeName == "SpawnPickaxeEverySecond3")
			{
				flag27 = true;
				LocalizationScript.spawnPickaxeEverySecondIncrease = 0.3f;
			}
			if (flag26)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Mine Random Rock";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Miner Roche Aléatoire";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Scava Roccia Casuale";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Zufälligen Stein Abbauen";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Minar Roca Aleatoria";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ランダム岩採掘";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "랜덤 바위 채굴";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Wydobądź Losową Skałę";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Minerar Rocha Aleatória";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Добыть Случайный Камень";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "开采随机岩石";
				}
				float num36 = SkillTree.chanceToMineRandomRock + LocalizationScript.chanceToMineRandomRockIncrease;
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total pickaxe spawn chance:\n" + SkillTree.chanceToMineRandomRock.ToString("F2") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance totale de génération de pioche :\n" + SkillTree.chanceToMineRandomRock.ToString("F2") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità totale di generare una piccone:\n" + SkillTree.chanceToMineRandomRock.ToString("F2") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamtchance, eine Spitzhacke zu spawnen:\n" + SkillTree.chanceToMineRandomRock.ToString("F2") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad total de generar un pico:\n" + SkillTree.chanceToMineRandomRock.ToString("F2") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "ピッケル生成の総確率：\n" + SkillTree.chanceToMineRandomRock.ToString("F2") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "총 곡괭이 생성 확률:\n" + SkillTree.chanceToMineRandomRock.ToString("F2") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączna szansa na stworzenie kilofa:\n" + SkillTree.chanceToMineRandomRock.ToString("F2") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance total de gerar picareta:\n" + SkillTree.chanceToMineRandomRock.ToString("F2") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общий шанс создания кирки:\n" + SkillTree.chanceToMineRandomRock.ToString("F2") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "镐子生成总概率：\n" + SkillTree.chanceToMineRandomRock.ToString("F2") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Every pickaxe hit has a chance to spawn a pickaxe and mine a random rock:\n",
							SkillTree.chanceToMineRandomRock.ToString("F2"),
							"% -> ",
							num36.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=19>Chaque coup de pioche a une chance de générer une pioche et miner une roche aléatoire :\n",
							SkillTree.chanceToMineRandomRock.ToString("F2"),
							"% -> ",
							num36.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=19>Ogni colpo di piccone ha una probabilità di generare un piccone e scavare una roccia casuale:\n",
							SkillTree.chanceToMineRandomRock.ToString("F2"),
							"% -> ",
							num36.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=18>Jeder Schlag mit der Spitzhacke hat eine Chance, eine Spitzhacke zu spawnen und einen zufälligen Stein abzubauen:\n",
							SkillTree.chanceToMineRandomRock.ToString("F2"),
							"% -> ",
							num36.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=22>Cada golpe de pico tiene una probabilidad de generar un pico y minar una roca aleatoria:\n",
							SkillTree.chanceToMineRandomRock.ToString("F2"),
							"% -> ",
							num36.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"ピッケルのヒットごとにピッケルを生成しランダムな岩を採掘する確率：\n",
							SkillTree.chanceToMineRandomRock.ToString("F2"),
							"% -> ",
							num36.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"곡괭이 타격 시 곡괭이를 생성하고 랜덤 바위를 채굴할 확률:\n",
							SkillTree.chanceToMineRandomRock.ToString("F2"),
							"% -> ",
							num36.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=22>Każde uderzenie kilofa ma szansę na stworzenie kilofa i wydobycie losowej skały:\n",
							SkillTree.chanceToMineRandomRock.ToString("F2"),
							"% -> ",
							num36.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=22>Cada golpe de picareta tem chance de gerar uma picareta e minerar uma rocha aleatória:\n",
							SkillTree.chanceToMineRandomRock.ToString("F2"),
							"% -> ",
							num36.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"<size=23>Каждый удар киркой даёт шанс создать кирку и добыть случайный камень:\n",
							SkillTree.chanceToMineRandomRock.ToString("F2"),
							"% -> ",
							num36.ToString("F2"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"每次镐击都有几率生成一把镐子并开采随机岩石：\n",
							SkillTree.chanceToMineRandomRock.ToString("F2"),
							"% -> ",
							num36.ToString("F2"),
							"%"
						});
					}
				}
			}
			else if (flag27)
			{
				float num37 = SkillTree.spawnPickaxeEverySecond - LocalizationScript.spawnPickaxeEverySecondIncrease;
				if (flag)
				{
					num37 = SkillTree.spawnPickaxeEverySecond;
				}
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Auto Mining";
					this.skillTreeDesc_text.text = "Mine a random rock every:\n" + num37.ToString("F2") + " sec";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Minage Automatique";
					this.skillTreeDesc_text.text = "Mine une roche aléatoire toutes les :\n" + num37.ToString("F2") + " sec";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Estrazione Automatica";
					this.skillTreeDesc_text.text = "Estrai una roccia casuale ogni:\n" + num37.ToString("F2") + " sec";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Automatischer Abbau";
					this.skillTreeDesc_text.text = "Baut alle " + num37.ToString("F2") + " Sekunden einen zufälligen Stein ab";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Minería Automática";
					this.skillTreeDesc_text.text = "Mina una roca aleatoria cada:\n" + num37.ToString("F2") + " seg";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "自動採掘";
					this.skillTreeDesc_text.text = "ランダムな岩を自動採掘：\n" + num37.ToString("F2") + "秒ごと";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "자동 채굴";
					this.skillTreeDesc_text.text = "랜덤 바위를 자동 채굴:\n" + num37.ToString("F2") + "초마다";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Automatyczne Wydobycie";
					this.skillTreeDesc_text.text = "Wydobywa losową skałę co:\n" + num37.ToString("F2") + " sek";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mineração Automática";
					this.skillTreeDesc_text.text = "Minerar uma rocha aleatória a cada:\n" + num37.ToString("F2") + " seg";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Авто-Добыча";
					this.skillTreeDesc_text.text = "Добывает случайный камень каждые:\n" + num37.ToString("F2") + " сек";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "自动采矿";
					this.skillTreeDesc_text.text = "每隔 " + num37.ToString("F2") + " 秒自动开采一块随机岩石";
				}
			}
		}
		else if (upgradeType == 20)
		{
			bool flag28 = false;
			bool flag29 = false;
			bool flag30 = false;
			if (upgradeName == "MoreTime1")
			{
				flag28 = true;
				LocalizationScript.moreTimeIncrease = 1;
			}
			else if (upgradeName == "MoreTime2")
			{
				flag28 = true;
				LocalizationScript.moreTimeIncrease = 1;
			}
			else if (upgradeName == "MoreTime3")
			{
				flag28 = true;
				LocalizationScript.moreTimeIncrease = 1;
			}
			else if (upgradeName == "MoreTime4")
			{
				flag28 = true;
				LocalizationScript.moreTimeIncrease = 1;
			}
			else if (upgradeName == "ChanceAdd1SecondEverySecond")
			{
				flag29 = true;
			}
			else if (upgradeName == "ChanceAdd1SecondEveryRockMined")
			{
				flag30 = true;
			}
			if (flag28)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Time";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Temps";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Tempo";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Zeit";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Tiempo";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "時間延長";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "더 많은 시간";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Czasu";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Tempo";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Времени";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多时间";
				}
				float num38 = (float)(SkillTree.mineSessionTime + LocalizationScript.moreTimeIncrease);
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Total mining session time:\n" + SkillTree.mineSessionTime.ToString("F0") + "s";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Durée totale de la session de minage :\n" + SkillTree.mineSessionTime.ToString("F0") + "s";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Durata totale della sessione di scavo:\n" + SkillTree.mineSessionTime.ToString("F0") + "s";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Gesamte Abbauzeit pro Session:\n" + SkillTree.mineSessionTime.ToString("F0") + "s";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Duración total de la sesión de minería:\n" + SkillTree.mineSessionTime.ToString("F0") + "s";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "採掘セッションの総時間：\n" + SkillTree.mineSessionTime.ToString("F0") + "秒";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "채굴 세션 총 시간:\n" + SkillTree.mineSessionTime.ToString("F0") + "초";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Łączny czas sesji wydobycia:\n" + SkillTree.mineSessionTime.ToString("F0") + "s";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Tempo total da sessão de mineração:\n" + SkillTree.mineSessionTime.ToString("F0") + "s";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Общее время сессии добычи:\n" + SkillTree.mineSessionTime.ToString("F0") + "с";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "采矿总时长：\n" + SkillTree.mineSessionTime.ToString("F0") + "秒";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Increase the mining session time:\n",
							SkillTree.mineSessionTime.ToString("F0"),
							"s -> ",
							num38.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Augmente la durée de la session de minage :\n",
							SkillTree.mineSessionTime.ToString("F0"),
							"s -> ",
							num38.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la durata della sessione di scavo:\n",
							SkillTree.mineSessionTime.ToString("F0"),
							"s -> ",
							num38.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Erhöht die Abbauzeit pro Session:\n",
							SkillTree.mineSessionTime.ToString("F0"),
							"s -> ",
							num38.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta la duración de la sesión de minería:\n",
							SkillTree.mineSessionTime.ToString("F0"),
							"s -> ",
							num38.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"採掘セッション時間を延長：\n",
							SkillTree.mineSessionTime.ToString("F0"),
							"秒 -> ",
							num38.ToString("F0"),
							"秒"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"채굴 세션 시간을 증가:\n",
							SkillTree.mineSessionTime.ToString("F0"),
							"초 -> ",
							num38.ToString("F0"),
							"초"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Wydłuża czas sesji wydobycia:\n",
							SkillTree.mineSessionTime.ToString("F0"),
							"s -> ",
							num38.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Aumenta o tempo da sessão de mineração:\n",
							SkillTree.mineSessionTime.ToString("F0"),
							"s -> ",
							num38.ToString("F0"),
							"s"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Увеличивает время сессии добычи:\n",
							SkillTree.mineSessionTime.ToString("F0"),
							"с -> ",
							num38.ToString("F0"),
							"с"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"延长采矿时长：\n",
							SkillTree.mineSessionTime.ToString("F0"),
							"秒 -> ",
							num38.ToString("F0"),
							"秒"
						});
					}
				}
			}
			else if (flag29)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "1S=1S";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEverySec.ToString("F0") + "% chance to add 1 second to the timer every second";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "1S=1S";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEverySec.ToString("F0") + "% de chance d'ajouter 1 seconde au chrono chaque seconde";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "1S=1S";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEverySec.ToString("F0") + "% di probabilità di aggiungere 1 secondo al timer ogni secondo";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "1S=1S";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEverySec.ToString("F0") + "% Chance, jede Sekunde 1 Sekunde zum Timer hinzuzufügen";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "1S=1S";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEverySec.ToString("F0") + "% de probabilidad de añadir 1 segundo al temporizador cada segundo";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "1S=1S";
					this.skillTreeDesc_text.text = "毎秒" + SkillTree.chanceToAdd1SecEverySec.ToString("F0") + "%の確率でタイマーに1秒追加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "1S=1S";
					this.skillTreeDesc_text.text = "매초 " + SkillTree.chanceToAdd1SecEverySec.ToString("F0") + "% 확률로 타이머에 1초 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "1S=1S";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEverySec.ToString("F0") + "% szansy na dodanie 1 sekundy do licznika co sekundę";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "1S=1S";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEverySec.ToString("F0") + "% de chance de adicionar 1 segundo ao cronômetro a cada segundo";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "1S=1S";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEverySec.ToString("F0") + "% шанс добавить 1 секунду к таймеру каждую секунду";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "1S=1S";
					this.skillTreeDesc_text.text = "每秒有 " + SkillTree.chanceToAdd1SecEverySec.ToString("F0") + "% 的几率为计时器增加 1 秒";
				}
			}
			else if (flag30)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Mined Rock = Time";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEveryRockMined.ToString("F3") + "% chance to add 1 second to the timer when a rock is mined";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Roche Minée = Temps";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEveryRockMined.ToString("F3") + "% de chance d'ajouter 1 seconde au chrono quand une roche est extraite";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Roccia Scavata = Tempo";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEveryRockMined.ToString("F3") + "% di probabilità di aggiungere 1 secondo al timer quando si estrae una roccia";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Abgebauter Stein = Zeit";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEveryRockMined.ToString("F3") + "% Chance, beim Abbau eines Steins 1 Sekunde zum Timer hinzuzufügen";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Roca Minada = Tiempo";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEveryRockMined.ToString("F3") + "% de probabilidad de añadir 1 segundo al temporizador al minar una roca";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "採掘岩 = 時間";
					this.skillTreeDesc_text.text = "岩を採掘すると" + SkillTree.chanceToAdd1SecEveryRockMined.ToString("F3") + "%の確率でタイマーに1秒追加";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "채굴한 바위 = 시간";
					this.skillTreeDesc_text.text = "바위를 캘 때 " + SkillTree.chanceToAdd1SecEveryRockMined.ToString("F3") + "% 확률로 타이머에 1초 추가";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Wydobyta Skała = Czas";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEveryRockMined.ToString("F3") + "% szansy na dodanie 1 sekundy do licznika po wydobyciu skały";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Rocha Minerada = Tempo";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEveryRockMined.ToString("F3") + "% de chance de adicionar 1 segundo ao cronômetro ao minerar uma rocha";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Добытый Камень = Время";
					this.skillTreeDesc_text.text = SkillTree.chanceToAdd1SecEveryRockMined.ToString("F3") + "% шанс добавить 1 секунду к таймеру при добыче камня";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "采矿岩石 = 时间";
					this.skillTreeDesc_text.text = "每开采一块岩石有 " + SkillTree.chanceToAdd1SecEveryRockMined.ToString("F3") + "% 的几率为计时器增加 1 秒";
				}
			}
		}
		else if (upgradeType == 21)
		{
			if (upgradeName == "DoubleXpAndMaterial1")
			{
				LocalizationScript.doubleXpAndGoldChanceIncrease = 1f;
			}
			else if (upgradeName == "DoubleXpAndMaterial2")
			{
				LocalizationScript.doubleXpAndGoldChanceIncrease = 2f;
			}
			else if (upgradeName == "DoubleXpAndMaterial3")
			{
				LocalizationScript.doubleXpAndGoldChanceIncrease = 3f;
			}
			else if (upgradeName == "DoubleXpAndMaterial4")
			{
				LocalizationScript.doubleXpAndGoldChanceIncrease = 4f;
			}
			else if (upgradeName == "DoubleXpAndMaterial5")
			{
				LocalizationScript.doubleXpAndGoldChanceIncrease = 5f;
			}
			else if (upgradeName == "DoubleEndless1")
			{
				LocalizationScript.doubleXpAndGoldChanceIncrease = 0.5f;
			}
			else if (upgradeName == "DoubleEndless2")
			{
				LocalizationScript.doubleXpAndGoldChanceIncrease = 0.5f;
			}
			float num39 = SkillTree.doubleXpAndGoldChance + LocalizationScript.doubleXpAndGoldChanceIncrease;
			if (LocalizationScript.isEnglish)
			{
				this.skillTreeName_text.text = "Double Double!";
			}
			if (LocalizationScript.isFrench)
			{
				this.skillTreeName_text.text = "Double Double !";
			}
			if (LocalizationScript.isItalian)
			{
				this.skillTreeName_text.text = "Doppio Doppio!";
			}
			if (LocalizationScript.isGerman)
			{
				this.skillTreeName_text.text = "Doppel Doppel!";
			}
			if (LocalizationScript.isSpanish)
			{
				this.skillTreeName_text.text = "Doble Doble!";
			}
			if (LocalizationScript.isJapanese)
			{
				this.skillTreeName_text.text = "ダブルダブル！";
			}
			if (LocalizationScript.isKorean)
			{
				this.skillTreeName_text.text = "더블 더블!";
			}
			if (LocalizationScript.isPolish)
			{
				this.skillTreeName_text.text = "Podwójne Podwójne!";
			}
			if (LocalizationScript.isPortugese)
			{
				this.skillTreeName_text.text = "Duplo Duplo!";
			}
			if (LocalizationScript.isRussian)
			{
				this.skillTreeName_text.text = "Двойной Двойной!";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.skillTreeName_text.text = "双倍双倍！";
			}
			if (flag)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeDesc_text.text = "Total double ore and XP chance:\n" + SkillTree.doubleXpAndGoldChance.ToString("F2") + "%";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeDesc_text.text = "Chance totale de doubler minerais et XP :\n" + SkillTree.doubleXpAndGoldChance.ToString("F2") + "%";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeDesc_text.text = "Probabilità totale di raddoppiare minerali e XP:\n" + SkillTree.doubleXpAndGoldChance.ToString("F2") + "%";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeDesc_text.text = "Gesamtchance auf doppeltes Erz und XP:\n" + SkillTree.doubleXpAndGoldChance.ToString("F2") + "%";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeDesc_text.text = "Probabilidad total de duplicar minerales y XP:\n" + SkillTree.doubleXpAndGoldChance.ToString("F2") + "%";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeDesc_text.text = "鉱石とXPを2倍にする総確率：\n" + SkillTree.doubleXpAndGoldChance.ToString("F2") + "%";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeDesc_text.text = "광석과 XP 두 배 총 확률:\n" + SkillTree.doubleXpAndGoldChance.ToString("F2") + "%";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeDesc_text.text = "Łączna szansa na podwojenie rudy i XP:\n" + SkillTree.doubleXpAndGoldChance.ToString("F2") + "%";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeDesc_text.text = "Chance total de dobrar minério e XP:\n" + SkillTree.doubleXpAndGoldChance.ToString("F2") + "%";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeDesc_text.text = "Общий шанс удвоить руду и XP:\n" + SkillTree.doubleXpAndGoldChance.ToString("F2") + "%";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeDesc_text.text = "双倍矿石与 XP 的总几率：\n" + SkillTree.doubleXpAndGoldChance.ToString("F2") + "%";
				}
			}
			else
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Chance to double the value of ores and XP:\n",
						SkillTree.doubleXpAndGoldChance.ToString("F2"),
						"% -> ",
						num39.ToString("F2"),
						"%"
					});
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Chance de doubler la valeur des minerais et de l'XP :\n",
						SkillTree.doubleXpAndGoldChance.ToString("F2"),
						"% -> ",
						num39.ToString("F2"),
						"%"
					});
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Probabilità di raddoppiare il valore di minerali e XP:\n",
						SkillTree.doubleXpAndGoldChance.ToString("F2"),
						"% -> ",
						num39.ToString("F2"),
						"%"
					});
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Chance, den Wert von Erzen und XP zu verdoppeln:\n",
						SkillTree.doubleXpAndGoldChance.ToString("F2"),
						"% -> ",
						num39.ToString("F2"),
						"%"
					});
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Probabilidad de duplicar el valor de minerales y XP:\n",
						SkillTree.doubleXpAndGoldChance.ToString("F2"),
						"% -> ",
						num39.ToString("F2"),
						"%"
					});
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"鉱石とXPの価値を2倍にする確率：\n",
						SkillTree.doubleXpAndGoldChance.ToString("F2"),
						"% -> ",
						num39.ToString("F2"),
						"%"
					});
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"광석과 XP 가치를 두 배로 만들 확률:\n",
						SkillTree.doubleXpAndGoldChance.ToString("F2"),
						"% -> ",
						num39.ToString("F2"),
						"%"
					});
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Szansa na podwojenie wartości rudy i XP:\n",
						SkillTree.doubleXpAndGoldChance.ToString("F2"),
						"% -> ",
						num39.ToString("F2"),
						"%"
					});
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Chance de dobrar o valor dos minérios e XP:\n",
						SkillTree.doubleXpAndGoldChance.ToString("F2"),
						"% -> ",
						num39.ToString("F2"),
						"%"
					});
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"Шанс удвоить ценность руды и XP:\n",
						SkillTree.doubleXpAndGoldChance.ToString("F2"),
						"% -> ",
						num39.ToString("F2"),
						"%"
					});
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeDesc_text.text = string.Concat(new string[]
					{
						"双倍矿石与 XP 的几率：\n",
						SkillTree.doubleXpAndGoldChance.ToString("F2"),
						"% -> ",
						num39.ToString("F2"),
						"%"
					});
				}
			}
		}
		else if (upgradeType == 22)
		{
			bool flag31 = false;
			bool flag32 = false;
			if (upgradeName == "DoubleDamageChance1")
			{
				flag31 = true;
				LocalizationScript.doubleDamageChanceIncrease = 1f;
			}
			if (upgradeName == "DoubleDamageChance2")
			{
				flag31 = true;
				LocalizationScript.doubleDamageChanceIncrease = 2f;
			}
			if (upgradeName == "InstaMine1")
			{
				flag32 = true;
				LocalizationScript.instaMineChanceIncrease = 1f;
			}
			if (upgradeName == "InstaMine2")
			{
				flag32 = true;
				LocalizationScript.instaMineChanceIncrease = 1f;
			}
			float num40 = SkillTree.doubleDamageChance + LocalizationScript.doubleDamageChanceIncrease;
			float num41 = SkillTree.instaMineChance + LocalizationScript.instaMineChanceIncrease;
			if (flag31)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Double Pickaxe Power";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Double Puissance Pioche";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Doppia Potenza Piccone";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Doppelte Spitzhacken-Power";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Doble Poder de Pico";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ピッケルパワー2倍";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "곡괭이 파워 2배";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Podwójna Moc Kilofa";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Poder Duplo da Picareta";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Двойная Сила Кирки";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "双倍镐子威力";
				}
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Double pickaxe power chance:\n" + SkillTree.doubleDamageChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance de doubler la puissance de la pioche :\n" + SkillTree.doubleDamageChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità di raddoppiare la potenza del piccone:\n" + SkillTree.doubleDamageChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Chance auf doppelte Spitzhacken-Power:\n" + SkillTree.doubleDamageChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad de duplicar el poder del pico:\n" + SkillTree.doubleDamageChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "ピッケルパワーを2倍にする確率：\n" + SkillTree.doubleDamageChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "곡괭이 파워 2배 확률:\n" + SkillTree.doubleDamageChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Szansa na podwójną moc kilofa:\n" + SkillTree.doubleDamageChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance de dobrar o poder da picareta:\n" + SkillTree.doubleDamageChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Шанс удвоить силу кирки:\n" + SkillTree.doubleDamageChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "镐子威力翻倍几率：\n" + SkillTree.doubleDamageChance.ToString("F0") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Double pickaxe power chance:\n",
							SkillTree.doubleDamageChance.ToString("F0"),
							"% -> ",
							num40.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Chance de doubler la puissance de la pioche :\n",
							SkillTree.doubleDamageChance.ToString("F0"),
							"% -> ",
							num40.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Probabilità di raddoppiare la potenza del piccone:\n",
							SkillTree.doubleDamageChance.ToString("F0"),
							"% -> ",
							num40.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Chance auf doppelte Spitzhacken-Power:\n",
							SkillTree.doubleDamageChance.ToString("F0"),
							"% -> ",
							num40.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Probabilidad de duplicar el poder del pico:\n",
							SkillTree.doubleDamageChance.ToString("F0"),
							"% -> ",
							num40.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"ピッケルパワーを2倍にする確率：\n",
							SkillTree.doubleDamageChance.ToString("F0"),
							"% -> ",
							num40.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"곡괭이 파워 2배 확률:\n",
							SkillTree.doubleDamageChance.ToString("F0"),
							"% -> ",
							num40.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Szansa na podwójną moc kilofa:\n",
							SkillTree.doubleDamageChance.ToString("F0"),
							"% -> ",
							num40.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Chance de dobrar o poder da picareta:\n",
							SkillTree.doubleDamageChance.ToString("F0"),
							"% -> ",
							num40.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Шанс удвоить силу кирки:\n",
							SkillTree.doubleDamageChance.ToString("F0"),
							"% -> ",
							num40.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"镐子威力翻倍几率：\n",
							SkillTree.doubleDamageChance.ToString("F0"),
							"% -> ",
							num40.ToString("F0"),
							"%"
						});
					}
				}
			}
			else if (flag32)
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Insta Mine!";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Mine Instantanée !";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Scavo Istantaneo!";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Sofort Abbauen!";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Minado Instantáneo!";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "即採掘！";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "즉시 채굴!";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Natychmiastowe Wydobycie!";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mineração Instantânea!";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Мгновенная Добыча!";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "秒采！";
				}
				if (flag)
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = "Insta mine rock chance:\n" + SkillTree.instaMineChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = "Chance de mine instantanée :\n" + SkillTree.instaMineChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = "Probabilità di scavo istantaneo:\n" + SkillTree.instaMineChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = "Sofortabbau-Chance:\n" + SkillTree.instaMineChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = "Probabilidad de minado instantáneo:\n" + SkillTree.instaMineChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = "即採掘確率：\n" + SkillTree.instaMineChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = "즉시 채굴 확률:\n" + SkillTree.instaMineChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = "Szansa na natychmiastowe wydobycie:\n" + SkillTree.instaMineChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = "Chance de mineração instantânea:\n" + SkillTree.instaMineChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = "Шанс мгновенной добычи:\n" + SkillTree.instaMineChance.ToString("F0") + "%";
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = "秒采几率：\n" + SkillTree.instaMineChance.ToString("F0") + "%";
					}
				}
				else
				{
					if (LocalizationScript.isEnglish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Chance to instantly mine a rock:\n",
							SkillTree.instaMineChance.ToString("F0"),
							"% -> ",
							num41.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isFrench)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Chance de miner une roche instantanément :\n",
							SkillTree.instaMineChance.ToString("F0"),
							"% -> ",
							num41.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isItalian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Probabilità di estrarre istantaneamente una roccia:\n",
							SkillTree.instaMineChance.ToString("F0"),
							"% -> ",
							num41.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isGerman)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Chance, einen Stein sofort abzubauen:\n",
							SkillTree.instaMineChance.ToString("F0"),
							"% -> ",
							num41.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSpanish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Probabilidad de minar una roca instantáneamente:\n",
							SkillTree.instaMineChance.ToString("F0"),
							"% -> ",
							num41.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isJapanese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"岩を即座に採掘する確率：\n",
							SkillTree.instaMineChance.ToString("F0"),
							"% -> ",
							num41.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isKorean)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"바위를 즉시 채굴할 확률:\n",
							SkillTree.instaMineChance.ToString("F0"),
							"% -> ",
							num41.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPolish)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Szansa na natychmiastowe wydobycie skały:\n",
							SkillTree.instaMineChance.ToString("F0"),
							"% -> ",
							num41.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isPortugese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Chance de minerar uma rocha instantaneamente:\n",
							SkillTree.instaMineChance.ToString("F0"),
							"% -> ",
							num41.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isRussian)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"Шанс мгновенно добыть камень:\n",
							SkillTree.instaMineChance.ToString("F0"),
							"% -> ",
							num41.ToString("F0"),
							"%"
						});
					}
					if (LocalizationScript.isSimplefiedChinese)
					{
						this.skillTreeDesc_text.text = string.Concat(new string[]
						{
							"瞬间开采岩石的几率：\n",
							SkillTree.instaMineChance.ToString("F0"),
							"% -> ",
							num41.ToString("F0"),
							"%"
						});
					}
				}
			}
			else if (upgradeName == "AllProjectleDoubleDamageChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Double Trouble";
					this.skillTreeDesc_text.text = "Lightning, dynamite and plazma ball double damage chance:\n" + SkillTree.allProjectileDoubleDamageIncrease.ToString("F0") + "%";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Double Problème";
					this.skillTreeDesc_text.text = "Chance de double dégâts pour foudre, dynamite et boule de plazma :\n" + SkillTree.allProjectileDoubleDamageIncrease.ToString("F0") + "%";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Doppio Problema";
					this.skillTreeDesc_text.text = "Probabilità di danno doppio per fulmine, dinamite e sfera di plazma:\n" + SkillTree.allProjectileDoubleDamageIncrease.ToString("F0") + "%";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Doppelt Ärger";
					this.skillTreeDesc_text.text = "Chance auf doppelten Schaden für Blitz, Dynamit und Plasmakugel:\n" + SkillTree.allProjectileDoubleDamageIncrease.ToString("F0") + "%";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Doble Problema";
					this.skillTreeDesc_text.text = "Probabilidad de daño doble para rayo, dinamita y bola de plazma:\n" + SkillTree.allProjectileDoubleDamageIncrease.ToString("F0") + "%";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "ダブルトラブル";
					this.skillTreeDesc_text.text = "雷・ダイナマイト・プラズマボールのダメージ2倍確率：\n" + SkillTree.allProjectileDoubleDamageIncrease.ToString("F0") + "%";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "더블 트러블";
					this.skillTreeDesc_text.text = "번개, 다이너마이트, 플라즈마 볼 2배 피해 확률:\n" + SkillTree.allProjectileDoubleDamageIncrease.ToString("F0") + "%";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Podwójne Kłopoty";
					this.skillTreeDesc_text.text = "Szansa na podwójne obrażenia od błyskawicy, dynamitu i kuli plazmy:\n" + SkillTree.allProjectileDoubleDamageIncrease.ToString("F0") + "%";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Duplo Problema";
					this.skillTreeDesc_text.text = "Chance de dano dobrado para raio, dinamite e bola de plazma:\n" + SkillTree.allProjectileDoubleDamageIncrease.ToString("F0") + "%";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Двойные Проблемы";
					this.skillTreeDesc_text.text = "Шанс двойного урона от молнии, динамита и плазменного шара:\n" + SkillTree.allProjectileDoubleDamageIncrease.ToString("F0") + "%";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "双倍麻烦";
					this.skillTreeDesc_text.text = "闪电、炸药和等离子球双倍伤害几率：\n" + SkillTree.allProjectileDoubleDamageIncrease.ToString("F0") + "%";
				}
			}
			else if (upgradeName == "IncreaseAllProjectileChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Trigger Chance";
					this.skillTreeDesc_text.text = "Lightning, dynamite and plazma ball trigger chance increase:\n+" + SkillTree.allProjcetileTriggerChance.ToString("F0") + "% of their current trigger chance";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Chance de Déclenchement";
					this.skillTreeDesc_text.text = "<size=19>Augmente la chance de déclenchement de la foudre, de la dynamite et de la boule de plazma :\n+" + SkillTree.allProjcetileTriggerChance.ToString("F0") + "% de leur chance actuelle";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Probabilità di Attivazione";
					this.skillTreeDesc_text.text = "Aumenta la probabilità di attivazione di fulmine, dinamite e sfera di plazma:\n+" + SkillTree.allProjcetileTriggerChance.ToString("F0") + "% del valore attuale";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Auslöser-Chance";
					this.skillTreeDesc_text.text = "Erhöht die Auslöse-Chance für Blitz, Dynamit und Plasmakugel:\n+" + SkillTree.allProjcetileTriggerChance.ToString("F0") + "% ihres aktuellen Werts";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Probabilidad de Activación";
					this.skillTreeDesc_text.text = "Aumenta la probabilidad de activación de rayo, dinamita y bola de plazma:\n+" + SkillTree.allProjcetileTriggerChance.ToString("F0") + "% de su valor actual";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "発動確率";
					this.skillTreeDesc_text.text = "雷・ダイナマイト・プラズマボールの発動確率を増加：\n現在の確率の+" + SkillTree.allProjcetileTriggerChance.ToString("F0") + "%";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "트리거 확률";
					this.skillTreeDesc_text.text = "번개, 다이너마이트, 플라즈마 볼 발동 확률 증가:\n현재 확률의 +" + SkillTree.allProjcetileTriggerChance.ToString("F0") + "%";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Szansa Aktywacji";
					this.skillTreeDesc_text.text = "Zwiększa szansę na aktywację błyskawicy, dynamitu i kuli plazmy:\n+" + SkillTree.allProjcetileTriggerChance.ToString("F0") + "% ich aktualnej szansy";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Chance de Acionamento";
					this.skillTreeDesc_text.text = "Aumenta a chance de acionar raio, dinamite e bola de plazma:\n+" + SkillTree.allProjcetileTriggerChance.ToString("F0") + "% da chance atual";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Шанс Срабатывания";
					this.skillTreeDesc_text.text = "Увеличивает шанс срабатывания молнии, динамита и плазменного шара:\n+" + SkillTree.allProjcetileTriggerChance.ToString("F0") + "% от текущего значения";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "触发概率";
					this.skillTreeDesc_text.text = "增加闪电、炸药和等离子球的触发概率：\n+" + SkillTree.allProjcetileTriggerChance.ToString("F0") + "% 当前触发几率";
				}
			}
			else if (upgradeName == "IncreaseAllRockSpawnChance")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "More Material Rocks";
					this.skillTreeDesc_text.text = "Increase all material rock spawn chance by:\n" + SkillTree.allRockSpawnChanceIncrease.ToString("F0") + "% of their current spawn chance";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Plus de Roches Matériaux";
					this.skillTreeDesc_text.text = "Augmente la chance d'apparition de toutes les roches matériaux de :\n" + SkillTree.allRockSpawnChanceIncrease.ToString("F0") + "% de leur chance actuelle";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Più Rocce di Materiale";
					this.skillTreeDesc_text.text = "Aumenta la probabilità di apparizione di tutte le rocce di materiale di:\n" + SkillTree.allRockSpawnChanceIncrease.ToString("F0") + "% del loro valore attuale";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Materialsteine";
					this.skillTreeDesc_text.text = "Erhöht die Spawn-Chance aller Materialsteine um:\n" + SkillTree.allRockSpawnChanceIncrease.ToString("F0") + "% ihres aktuellen Werts";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Más Rocas de Material";
					this.skillTreeDesc_text.text = "Aumenta la probabilidad de aparición de todas las rocas de material en:\n" + SkillTree.allRockSpawnChanceIncrease.ToString("F0") + "% de su valor actual";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "素材岩増加";
					this.skillTreeDesc_text.text = "すべての素材岩の出現確率を増加：\n現在の確率の" + SkillTree.allRockSpawnChanceIncrease.ToString("F0") + "%";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "자원 암석 증가";
					this.skillTreeDesc_text.text = "모든 자원 암석의 생성 확률 증가:\n현재 확률의 " + SkillTree.allRockSpawnChanceIncrease.ToString("F0") + "%";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Skał Materiałowych";
					this.skillTreeDesc_text.text = "Zwiększa szansę pojawienia się wszystkich skał materiałowych o:\n" + SkillTree.allRockSpawnChanceIncrease.ToString("F0") + "% ich aktualnej wartości";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Mais Rochas de Materiais";
					this.skillTreeDesc_text.text = "Aumenta a chance de surgimento de todas as rochas de material em:\n" + SkillTree.allRockSpawnChanceIncrease.ToString("F0") + "% do valor atual";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Больше Материальных Камней";
					this.skillTreeDesc_text.text = "Увеличивает шанс появления всех материальных камней на:\n" + SkillTree.allRockSpawnChanceIncrease.ToString("F0") + "% от текущего значения";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多材料岩石";
					this.skillTreeDesc_text.text = "提升所有材料岩石的生成概率：\n" + SkillTree.allRockSpawnChanceIncrease.ToString("F0") + "% 当前生成概率";
				}
			}
			else if (upgradeName == "2GoldBarsCraft")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Craft More!";
					this.skillTreeDesc_text.text = "It now only takes 2 ores to craft a bar!";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Fabriquez Plus !";
					this.skillTreeDesc_text.text = "Il ne faut maintenant que 2 minerais pour fabriquer un lingot !";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Crea di Più!";
					this.skillTreeDesc_text.text = "Ora servono solo 2 minerali per forgiare una barra!";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Mehr Herstellen!";
					this.skillTreeDesc_text.text = "Es werden jetzt nur 2 Erze benötigt, um einen Barren zu schmieden!";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "¡Fabricar Más!";
					this.skillTreeDesc_text.text = "¡Ahora solo necesitas 2 minerales para crear una barra!";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "もっとクラフト！";
					this.skillTreeDesc_text.text = "今ではインゴットを作るのに鉱石2つだけ！";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "더 많이 제작!";
					this.skillTreeDesc_text.text = "이제 광석 2개만으로 바를 제작할 수 있습니다!";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Więcej Wytwarzania!";
					this.skillTreeDesc_text.text = "Teraz wystarczą tylko 2 rudy, aby stworzyć sztabkę!";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Produza Mais!";
					this.skillTreeDesc_text.text = "Agora só precisa de 2 minérios para forjar uma barra!";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Крафти Больше!";
					this.skillTreeDesc_text.text = "Теперь нужно всего 2 руды, чтобы создать слиток!";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "更多锻造！";
					this.skillTreeDesc_text.text = "现在只需 2 个矿石就能锻造一个锭！";
				}
			}
			else if (upgradeName == "FinalUpgrade")
			{
				if (LocalizationScript.isEnglish)
				{
					this.skillTreeName_text.text = "Big Rock";
					this.skillTreeDesc_text.text = "You can now mine the big rock.";
				}
				if (LocalizationScript.isFrench)
				{
					this.skillTreeName_text.text = "Gros Rocher";
					this.skillTreeDesc_text.text = "Vous pouvez maintenant miner le gros rocher.";
				}
				if (LocalizationScript.isItalian)
				{
					this.skillTreeName_text.text = "Grande Roccia";
					this.skillTreeDesc_text.text = "Ora puoi scavare la grande roccia.";
				}
				if (LocalizationScript.isGerman)
				{
					this.skillTreeName_text.text = "Großer Felsen";
					this.skillTreeDesc_text.text = "Du kannst jetzt den großen Felsen abbauen.";
				}
				if (LocalizationScript.isSpanish)
				{
					this.skillTreeName_text.text = "Roca Grande";
					this.skillTreeDesc_text.text = "Ahora puedes minar la gran roca.";
				}
				if (LocalizationScript.isJapanese)
				{
					this.skillTreeName_text.text = "巨大な岩";
					this.skillTreeDesc_text.text = "大きな岩を採掘できるようになりました。";
				}
				if (LocalizationScript.isKorean)
				{
					this.skillTreeName_text.text = "큰 바위";
					this.skillTreeDesc_text.text = "이제 큰 바위를 채굴할 수 있습니다.";
				}
				if (LocalizationScript.isPolish)
				{
					this.skillTreeName_text.text = "Wielka Skała";
					this.skillTreeDesc_text.text = "Możesz teraz wydobywać wielką skałę.";
				}
				if (LocalizationScript.isPortugese)
				{
					this.skillTreeName_text.text = "Grande Rocha";
					this.skillTreeDesc_text.text = "Agora você pode minerar a grande rocha.";
				}
				if (LocalizationScript.isRussian)
				{
					this.skillTreeName_text.text = "Большой Камень";
					this.skillTreeDesc_text.text = "Теперь можно добывать большой камень.";
				}
				if (LocalizationScript.isSimplefiedChinese)
				{
					this.skillTreeName_text.text = "巨岩";
					this.skillTreeDesc_text.text = "现在你可以开采大岩石了。";
				}
			}
		}
		LocalizationScript.currentSkillTreePrice = upgradePrice;
		this.skillTreePrice_text.text = LocalizationScript.price + " " + FormatNumbers.FormatPoints(LocalizationScript.currentSkillTreePrice);
		if (LocalizationScript.isEnglish)
		{
			this.skillTreePurchased_text.text = string.Format("Purchased: {0}/{1}", purchaseCount, totalPurchaseCount);
		}
		if (LocalizationScript.isFrench)
		{
			this.skillTreePurchased_text.text = string.Format("Acheté : {0}/{1}", purchaseCount, totalPurchaseCount);
		}
		if (LocalizationScript.isItalian)
		{
			this.skillTreePurchased_text.text = string.Format("Acquistato: {0}/{1}", purchaseCount, totalPurchaseCount);
		}
		if (LocalizationScript.isGerman)
		{
			this.skillTreePurchased_text.text = string.Format("Gekauft: {0}/{1}", purchaseCount, totalPurchaseCount);
		}
		if (LocalizationScript.isSpanish)
		{
			this.skillTreePurchased_text.text = string.Format("Comprado: {0}/{1}", purchaseCount, totalPurchaseCount);
		}
		if (LocalizationScript.isJapanese)
		{
			this.skillTreePurchased_text.text = string.Format("購入済み: {0}/{1}", purchaseCount, totalPurchaseCount);
		}
		if (LocalizationScript.isKorean)
		{
			this.skillTreePurchased_text.text = string.Format("구매됨: {0}/{1}", purchaseCount, totalPurchaseCount);
		}
		if (LocalizationScript.isPolish)
		{
			this.skillTreePurchased_text.text = string.Format("Zakupiono: {0}/{1}", purchaseCount, totalPurchaseCount);
		}
		if (LocalizationScript.isPortugese)
		{
			this.skillTreePurchased_text.text = string.Format("Comprado: {0}/{1}", purchaseCount, totalPurchaseCount);
		}
		if (LocalizationScript.isRussian)
		{
			this.skillTreePurchased_text.text = string.Format("Куплено: {0}/{1}", purchaseCount, totalPurchaseCount);
		}
		if (LocalizationScript.isSimplefiedChinese)
		{
			this.skillTreePurchased_text.text = string.Format("已购买: {0}/{1}", purchaseCount, totalPurchaseCount);
		}
		if (flag)
		{
			this.skillTreePrice_text.gameObject.SetActive(false);
			this.skillTreePurchased_text.gameObject.transform.localScale = new Vector2(1.2f, 1.2f);
			this.skillTreePurchased_text.gameObject.transform.localPosition = new Vector2(0f, -64f);
			return;
		}
		this.skillTreePrice_text.gameObject.SetActive(true);
		this.skillTreePurchased_text.gameObject.transform.localScale = new Vector2(0.8f, 0.8f);
		this.skillTreePurchased_text.gameObject.transform.localPosition = new Vector2(0f, -85f);
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00036F2C File Offset: 0x0003512C
	public void ArtifactsTooltipText(int artifactNumber)
	{
		this.horn_tooltipImage.SetActive(false);
		this.ancientDevice_tooltipImage.SetActive(false);
		this.bone_tooltipImage.SetActive(false);
		this.meteorieOre_tooltipImage.SetActive(false);
		this.book_tooltipImage.SetActive(false);
		this.goldStack_tooltipImage.SetActive(false);
		this.goldRing_tooltipImage.SetActive(false);
		this.purpleRing_tooltipImage.SetActive(false);
		this.ancientDice_tooltipImage.SetActive(false);
		this.cheese_tooltipImage.SetActive(false);
		this.wolfClaw_tooltipImage.SetActive(false);
		this.axe_tooltipImage.SetActive(false);
		this.rune_tooltipImage.SetActive(false);
		this.skull_tooltipImage.SetActive(false);
		if (artifactNumber == 1)
		{
			float num = Artifacts.hornRockDecrease;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num *= 1f + LevelMechanics.archeologistIncreaseDISPLAY + Artifacts.runeImproveAll;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num *= 1f + LevelMechanics.archeologistIncreaseDISPLAY;
				}
				if (Artifacts.rune_found)
				{
					num *= 1f + Artifacts.runeImproveAll;
				}
			}
			this.artifactTooltipName = LocalizationScript.horn;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = string.Format("Reduces the durability of all rocks by {0}%", num * 100f);
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = string.Format("Réduit la durabilité de toutes les roches de {0}%", num * 100f);
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = string.Format("Riduce la durabilità di tutte le rocce del {0}%", num * 100f);
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = string.Format("Reduziert die Haltbarkeit aller Steine um {0}%", num * 100f);
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = string.Format("Reduce la durabilidad de todas las rocas en {0}%", num * 100f);
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = string.Format("すべての岩の耐久度を{0}%減少させる", num * 100f);
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = string.Format("모든 바위의 내구도를 {0}% 감소시킴", num * 100f);
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = string.Format("Zmniejsza wytrzymałość wszystkich skał o {0}%", num * 100f);
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = string.Format("Reduz o durabilidade de todas as rochas em {0}%", num * 100f);
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = string.Format("Уменьшает прочность всех камней на {0}%", num * 100f);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = string.Format("减少所有岩石的耐久度 {0}%", num * 100f);
			}
			this.horn_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 2)
		{
			float num2 = Artifacts.ancientDeviceTimeReduction;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num2 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY + Artifacts.runeImproveAll;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num2 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY;
				}
				if (Artifacts.rune_found)
				{
					num2 *= 1f + Artifacts.runeImproveAll;
				}
			}
			this.artifactTooltipName = LocalizationScript.device;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = string.Format("Improved The Mine. It now mines {0}% faster", num2 * 100f);
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = string.Format("Améliore La Mine. Elle extrait maintenant {0}% plus vite", num2 * 100f);
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = string.Format("Migliora La Miniera. Ora estrae il {0}% più velocemente", num2 * 100f);
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = string.Format("Verbessert Die Mine. Sie baut jetzt {0}% schneller ab", num2 * 100f);
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = string.Format("Mejora La Mina. Ahora mina un {0}% más rápido", num2 * 100f);
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = string.Format("ザ・マインを強化。採掘速度が{0}%アップ", num2 * 100f);
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = string.Format("광산이 강화됨. 이제 {0}% 더 빨리 채굴함", num2 * 100f);
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = string.Format("Ulepsza Kopalnię. Teraz wydobywa o {0}% szybciej", num2 * 100f);
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = string.Format("Aprimora A Mina. Agora minera {0}% mais rápido", num2 * 100f);
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = string.Format("Улучшает Шахту. Теперь добывает на {0}% быстрее", num2 * 100f);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = string.Format("强化了矿井，开采速度提高 {0}%", num2 * 100f);
			}
			this.ancientDevice_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 3)
		{
			float num3 = Artifacts.bonePickaxeIncrease;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num3 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY + Artifacts.runeImproveAll;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num3 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY;
				}
				if (Artifacts.rune_found)
				{
					num3 *= 1f + Artifacts.runeImproveAll;
				}
			}
			this.artifactTooltipName = LocalizationScript.bone;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = string.Format("Improves all pickaxe stats by {0}%", num3 * 100f);
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = string.Format("Améliore toutes les stats de la pioche de {0}%", num3 * 100f);
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = string.Format("Migliora tutte le statistiche del piccone del {0}%", num3 * 100f);
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = string.Format("Verbessert alle Spitzhacken-Werte um {0}%", num3 * 100f);
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = string.Format("Mejora todas las estadísticas del pico en {0}%", num3 * 100f);
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = string.Format("すべてのピッケルのステータスを{0}%強化", num3 * 100f);
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = string.Format("모든 곡괭이 능력치를 {0}% 향상시킴", num3 * 100f);
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = string.Format("Zwiększa wszystkie statystyki kilofa o {0}%", num3 * 100f);
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = string.Format("Melhora todas as estatísticas da picareta em {0}%", num3 * 100f);
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = string.Format("Улучшает все характеристики кирки на {0}%", num3 * 100f);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = string.Format("所有镐子属性提高 {0}%", num3 * 100f);
			}
			this.bone_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 4)
		{
			float num4 = Artifacts.meteoriteRockSpawnIncrease;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num4 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY + Artifacts.runeImproveAll;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num4 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY;
				}
				if (Artifacts.rune_found)
				{
					num4 *= 1f + Artifacts.runeImproveAll;
				}
			}
			this.artifactTooltipName = LocalizationScript.meteorite;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = string.Format("Increases the spawn chance of all full material rocks by {0}% of their current chance", num4 * 100f);
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = string.Format("Augmente la chance d'apparition de toutes les roches complètes de {0}% de leur chance actuelle", num4 * 100f);
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = string.Format("Aumenta la probabilità di generazione di tutte le rocce piene del {0}% del loro valore attuale", num4 * 100f);
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = string.Format("Erhöht die Spawn-Chance aller vollen Materialsteine um {0}% ihres aktuellen Werts", num4 * 100f);
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = string.Format("Aumenta la probabilidad de aparición de todas las rocas completas en un {0}% de su valor actual", num4 * 100f);
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = string.Format("すべてのフル素材岩の出現確率を現在の確率の{0}%増加させる", num4 * 100f);
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = string.Format("모든 완전 자원 암석의 생성 확률을 현재 확률의 {0}%만큼 증가시킴", num4 * 100f);
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = string.Format("Zwiększa szansę pojawienia się wszystkich pełnych skał materiałowych o {0}% ich aktualnej szansy", num4 * 100f);
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = string.Format("Aumenta a chance de surgimento de todas as rochas completas em {0}% da chance atual", num4 * 100f);
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = string.Format("Увеличивает шанс появления всех полных материальных камней на {0}% от текущего значения", num4 * 100f);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = string.Format("所有完整材料岩石的生成概率提高其当前概率的 {0}%", num4 * 100f);
			}
			this.meteorieOre_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 5)
		{
			this.artifactTooltipName = LocalizationScript.book;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = "Gives 1 extra talent point per 5 levels";
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = "Donne 1 point de talent supplémentaire tous les 5 niveaux";
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = "Dà 1 punto talento extra ogni 5 livelli";
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = "Gibt 1 zusätzlichen Talentpunkt alle 5 Level";
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = "Otorga 1 punto de talento extra cada 5 niveles";
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = "5レベルごとに追加で才能ポイントを1獲得";
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = "5레벨마다 추가 재능 포인트 1개 제공";
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = "Daje 1 dodatkowy punkt talentu co 5 poziomów";
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = "Concede 1 ponto de talento extra a cada 5 níveis";
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = "Дает 1 дополнительный очко таланта за каждые 5 уровней";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = "每升 5 级额外获得 1 点天赋点";
			}
			this.book_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 6)
		{
			int num5 = 25;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num5 = 22;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num5 = 23;
				}
				if (Artifacts.rune_found)
				{
					num5 = 24;
				}
			}
			this.artifactTooltipName = LocalizationScript.sack;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = string.Format("Every {0} mined ore will be worth double", num5);
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = string.Format("Chaque {0} matériau extrait vaudra le double", num5);
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = string.Format("Ogni {0} materiale estratto varrà il doppio", num5);
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = string.Format("Jedes {0}. abgebautes Material ist doppelt so viel wert", num5);
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = string.Format("Cada {0} material extraído valdrá el doble", num5);
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = string.Format("採掘した素材{0}個ごとに価値が2倍になる", num5);
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = string.Format("채굴한 자원 {0}개마다 가치가 2배가 됨", num5);
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = string.Format("Co {0} wydobyty materiał jest wart dwa razy więcej", num5);
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = string.Format("Cada {0} material minerado valerá o dobro", num5);
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = string.Format("Каждый {0}-й добытый материал будет стоить вдвое дороже", num5);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = string.Format("每开采 {0} 个材料，其价值翻倍", num5);
			}
			this.goldStack_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 7)
		{
			float num6 = Artifacts.goldRingCraftChance;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num6 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY + Artifacts.runeImproveAll;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num6 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY;
				}
				if (Artifacts.rune_found)
				{
					num6 *= 1f + Artifacts.runeImproveAll;
				}
			}
			this.artifactTooltipName = LocalizationScript.goldRing;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = "At the end of a mining session, every ore mined has a " + num6.ToString("F1") + "% chance of only using 1 ore to craft a bar";
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = "À la fin d'une session, chaque minerai extrait a " + num6.ToString("F1") + "% de chance de n'utiliser qu'1 minerai pour fabriquer un lingot";
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = "Alla fine di una sessione, ogni minerale estratto ha il " + num6.ToString("F1") + "% di probabilità di usare solo 1 minerale per forgiare una barra";
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = "Am Ende einer Sitzung hat jedes Erz " + num6.ToString("F1") + "% Chance, nur 1 Erz für einen Barren zu verbrauchen";
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = "Al final de una sesión, cada mineral extraído tiene un " + num6.ToString("F1") + "% de probabilidad de usar solo 1 mineral para forjar una barra";
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = "採掘セッション終了時、採掘した鉱石ごとに" + num6.ToString("F1") + "%の確率で鉱石1つだけでインゴットを作れる";
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = "채굴 세션 종료 시, 채굴한 광석마다 " + num6.ToString("F1") + "% 확률로 광석 1개만으로 바를 제작함";
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = "Na końcu sesji każdy wydobyty minerał ma " + num6.ToString("F1") + "% szansy, że do stworzenia sztabki użyje się tylko 1 minerału";
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = "No final de uma sessão, cada minério minerado tem " + num6.ToString("F1") + "% de chance de usar apenas 1 minério para forjar uma barra";
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = "В конце сессии каждая добытая руда имеет " + num6.ToString("F1") + "% шанс использовать только 1 руду для создания слитка";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = "采矿结束时，每个矿石有 " + num6.ToString("F1") + "% 的几率只用 1 个矿石锻造一个锭";
			}
			this.goldRing_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 8)
		{
			float num7 = Artifacts.purpleRingChance;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num7 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY + Artifacts.runeImproveAll;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num7 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY;
				}
				if (Artifacts.rune_found)
				{
					num7 *= 1f + Artifacts.runeImproveAll;
				}
			}
			this.artifactTooltipName = LocalizationScript.royalRing;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = string.Format("{0}% chance to receive double XP from mined rocks", num7);
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = string.Format("{0}% de chance de recevoir le double d'XP des roches extraites", num7);
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = string.Format("{0}% di probabilità di ricevere XP doppia dalle rocce estratte", num7);
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = string.Format("{0}% Chance, doppelte XP aus abgebauten Steinen zu erhalten", num7);
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = string.Format("{0}% de probabilidad de recibir XP doble de las rocas extraídas", num7);
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = string.Format("採掘した岩から{0}%の確率でXPが2倍になる", num7);
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = string.Format("채굴한 바위에서 {0}% 확률로 XP 2배 획득", num7);
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = string.Format("{0}% szansy na podwójne XP z wydobytych skał", num7);
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = string.Format("{0}% de chance de receber XP em dobro das rochas mineradas", num7);
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = string.Format("{0}% шанс получить двойной XP с добытых камней", num7);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = string.Format("从采矿岩石中获得双倍 XP 的几率：{0}%", num7);
			}
			this.purpleRing_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 9)
		{
			float num8 = Artifacts.diceTime;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num8 *= 1f - LevelMechanics.archeologistIncreaseDISPLAY - Artifacts.runeImproveAll;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num8 *= 1f - LevelMechanics.archeologistIncreaseDISPLAY;
				}
				if (Artifacts.rune_found)
				{
					num8 *= 1f - Artifacts.runeImproveAll;
				}
			}
			this.artifactTooltipName = LocalizationScript.dice;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = string.Format("Spawn 1 rock every {0} second", num8);
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = string.Format("Fait apparaître 1 roche toutes les {0} secondes", num8);
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = string.Format("Genera 1 roccia ogni {0} secondi", num8);
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = string.Format("Spawnt alle {0} Sekunden 1 Stein", num8);
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = string.Format("Genera 1 roca cada {0} segundo", num8);
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = string.Format("{0}秒ごとに岩を1個生成する", num8);
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = string.Format("{0}초마다 바위 1개 생성", num8);
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = string.Format("Generuje 1 skałę co {0} sekund", num8);
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = string.Format("Gera 1 rocha a cada {0} segundo", num8);
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = string.Format("Создает 1 камень каждые {0} секунд", num8);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = string.Format("每 {0} 秒生成 1 块岩石", num8);
			}
			this.ancientDice_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 10)
		{
			float num9 = Artifacts.cheeseChance;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num9 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY + Artifacts.runeImproveAll;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num9 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY;
				}
				if (Artifacts.rune_found)
				{
					num9 *= 1f + Artifacts.runeImproveAll;
				}
			}
			this.artifactTooltipName = LocalizationScript.cheese;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = "Every pickaxe hit has a " + num9.ToString("F2") + "% chance to drop 1 ore";
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = "Chaque coup de pioche a " + num9.ToString("F2") + "% de chance de faire tomber 1 minerai";
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = "Ogni colpo di piccone ha il " + num9.ToString("F2") + "% di probabilità di far cadere 1 minerale";
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = "Jeder Schlag mit der Spitzhacke hat eine Chance von " + num9.ToString("F2") + "%, 1 Erz fallen zu lassen";
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = "Cada golpe de pico tiene un " + num9.ToString("F2") + "% de probabilidad de soltar 1 mineral";
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = "ピッケルのヒットごとに" + num9.ToString("F2") + "%の確率で鉱石1個をドロップ";
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = "곡괭이 타격 시 " + num9.ToString("F2") + "% 확률로 광석 1개 드랍";
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = "Każde uderzenie kilofa ma " + num9.ToString("F2") + "% szansy na upuszczenie 1 rudy";
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = "Cada golpe de picareta tem " + num9.ToString("F2") + "% de chance de soltar 1 minério";
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = "Каждый удар киркой даёт " + num9.ToString("F2") + "% шанс сбросить 1 руду";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = "每次镐击有 " + num9.ToString("F2") + "% 的几率掉落 1 个矿石";
			}
			this.cheese_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 11)
		{
			float num10 = Artifacts.clawChance;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num10 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY + Artifacts.runeImproveAll;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num10 *= 1f + LevelMechanics.archeologistIncreaseDISPLAY;
				}
				if (Artifacts.rune_found)
				{
					num10 *= 1f + Artifacts.runeImproveAll;
				}
			}
			this.artifactTooltipName = LocalizationScript.wolf;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = string.Format("Increase the pickaxe power by {0}%", num10 * 100f);
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = string.Format("Augmente la puissance de la pioche de {0}%", num10 * 100f);
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = string.Format("Aumenta la potenza del piccone del {0}%", num10 * 100f);
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = string.Format("Erhöht die Spitzhacken-Power um {0}%", num10 * 100f);
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = string.Format("Aumenta el poder del pico en {0}%", num10 * 100f);
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = string.Format("ピッケルのパワーを{0}%増加させる", num10 * 100f);
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = string.Format("곡괭이 파워 {0}% 증가", num10 * 100f);
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = string.Format("Zwiększa moc kilofa o {0}%", num10 * 100f);
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = string.Format("Aumenta o poder da picareta em {0}%", num10 * 100f);
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = string.Format("Увеличивает силу кирки на {0}%", num10 * 100f);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = string.Format("镐子威力提升 {0}%", num10 * 100f);
			}
			this.wolfClaw_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 12)
		{
			float num11 = 2f * (1f + Artifacts.runeImproveAll + LevelMechanics.archeologistIncrease);
			float num12 = 1f * (1f + Artifacts.runeImproveAll + LevelMechanics.archeologistIncrease);
			this.artifactTooltipName = LocalizationScript.axe;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = string.Format("{0}% chance to deal double pickaxe power and {1}% chance to insta mine rocks", num11, num12);
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = string.Format("{0}% de chance d'infliger le double de puissance de pioche et {1}% de chance de miner instantanément les roches", num11, num12);
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = string.Format("{0}% di probabilità di infliggere doppia potenza con il piccone e {1}% di probabilità di scavare istantaneamente le rocce", num11, num12);
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = string.Format("{0}% Chance auf doppelte Spitzhacken-Power und {1}% Chance, Steine sofort abzubauen", num11, num12);
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = string.Format("{0}% de probabilidad de hacer doble poder de pico y {1}% de probabilidad de minar instantáneamente rocas", num11, num12);
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = string.Format("{0}%の確率でピッケルパワー2倍、さらに{1}%の確率で岩を即採掘", num11, num12);
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = string.Format("{0}% 확률로 곡괭이 파워 2배, {1}% 확률로 바위 즉시 채굴", num11, num12);
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = string.Format("{0}% szansy na podwójną moc kilofa i {1}% szansy na natychmiastowe wydobycie skał", num11, num12);
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = string.Format("{0}% de chance de dar poder duplo da picareta e {1}% de chance de minerar rochas instantaneamente", num11, num12);
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = string.Format("{0}% шанс нанести двойной урон киркой и {1}% шанс мгновенно добыть камни", num11, num12);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = string.Format("有 {0}% 几率造成双倍镐子威力，并有 {1}% 几率瞬间开采岩石", num11, num12);
			}
			this.axe_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 13)
		{
			this.artifactTooltipName = LocalizationScript.runestone;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = string.Format("Improves the stats of all artifacts by {0}% of their current stats", Artifacts.runeIncrease_forDisplay);
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = string.Format("Améliore les stats de tous les artefacts de {0}% de leurs stats actuelles", Artifacts.runeIncrease_forDisplay);
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = string.Format("Migliora le statistiche di tutti gli artefatti del {0}% delle loro statistiche attuali", Artifacts.runeIncrease_forDisplay);
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = string.Format("Verbessert die Werte aller Artefakte um {0}% ihrer aktuellen Werte", Artifacts.runeIncrease_forDisplay);
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = string.Format("Mejora las estadísticas de todos los artefactos en un {0}% de sus estadísticas actuales", Artifacts.runeIncrease_forDisplay);
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = string.Format("すべてのアーティファクトのステータスを現在の{0}%分強化", Artifacts.runeIncrease_forDisplay);
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = string.Format("모든 유물의 스탯을 현재 스탯의 {0}%만큼 향상", Artifacts.runeIncrease_forDisplay);
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = string.Format("Zwiększa statystyki wszystkich artefaktów o {0}% ich obecnych statystyk", Artifacts.runeIncrease_forDisplay);
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = string.Format("Melhora as estatísticas de todos os artefatos em {0}% de seus valores atuais", Artifacts.runeIncrease_forDisplay);
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = string.Format("Улучшает характеристики всех артефактов на {0}% от их текущих значений", Artifacts.runeIncrease_forDisplay);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = string.Format("提升所有神器属性 {0}%（基于当前属性）", Artifacts.runeIncrease_forDisplay);
			}
			this.rune_tooltipImage.SetActive(true);
		}
		if (artifactNumber == 14)
		{
			int num13 = 10;
			if (LevelMechanics.archaeologist_chosen)
			{
				num13 = 11;
			}
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num13 = 11;
			}
			this.artifactTooltipName = LocalizationScript.skull;
			if (LocalizationScript.isEnglish)
			{
				this.artifactDescName = string.Format("{0} more rocks spawn at the beginning of a mining session", num13);
			}
			if (LocalizationScript.isFrench)
			{
				this.artifactDescName = string.Format("{0} roches supplémentaires apparaissent au début d'une session de minage", num13);
			}
			if (LocalizationScript.isItalian)
			{
				this.artifactDescName = string.Format("{0} rocce in più compaiono all'inizio di una sessione di scavo", num13);
			}
			if (LocalizationScript.isGerman)
			{
				this.artifactDescName = string.Format("Zu Beginn einer Session erscheinen {0} zusätzliche Steine", num13);
			}
			if (LocalizationScript.isSpanish)
			{
				this.artifactDescName = string.Format("Aparecen {0} rocas más al inicio de una sesión de minería", num13);
			}
			if (LocalizationScript.isJapanese)
			{
				this.artifactDescName = string.Format("採掘セッション開始時に{0}個の岩が追加で出現する", num13);
			}
			if (LocalizationScript.isKorean)
			{
				this.artifactDescName = string.Format("채굴 세션 시작 시 바위 {0}개 추가 생성", num13);
			}
			if (LocalizationScript.isPolish)
			{
				this.artifactDescName = string.Format("Na początku sesji pojawia się {0} dodatkowych skał", num13);
			}
			if (LocalizationScript.isPortugese)
			{
				this.artifactDescName = string.Format("No início de uma sessão, surgem mais {0} rochas", num13);
			}
			if (LocalizationScript.isRussian)
			{
				this.artifactDescName = string.Format("В начале сессии появляется на {0} камней больше", num13);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.artifactDescName = string.Format("采矿开始时额外生成 {0} 块岩石", num13);
			}
			this.skull_tooltipImage.SetActive(true);
		}
		this.artifactName_text.text = this.artifactTooltipName;
		this.artifactDesc_text.text = this.artifactDescName;
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00038938 File Offset: 0x00036B38
	public void PotionText(string potionName)
	{
		if (potionName == "materialIncrease")
		{
			if (LocalizationScript.isEnglish)
			{
				this.potionTooltipName.text = "Ore Potion";
				this.potionTooltipDesc.text = "Ores are worth " + (SetRockScreen.potionMaterialWorthMore_increase * 100f).ToString("F0") + "% more";
			}
			if (LocalizationScript.isFrench)
			{
				this.potionTooltipName.text = "Potion de Minerai";
				this.potionTooltipDesc.text = "Les minerais valent " + (SetRockScreen.potionMaterialWorthMore_increase * 100f).ToString("F0") + "% de plus";
			}
			if (LocalizationScript.isItalian)
			{
				this.potionTooltipName.text = "Pozione del Minerale";
				this.potionTooltipDesc.text = "I minerali valgono il " + (SetRockScreen.potionMaterialWorthMore_increase * 100f).ToString("F0") + "% in più";
			}
			if (LocalizationScript.isGerman)
			{
				this.potionTooltipName.text = "Erztrank";
				this.potionTooltipDesc.text = "Erze sind " + (SetRockScreen.potionMaterialWorthMore_increase * 100f).ToString("F0") + "% mehr wert";
			}
			if (LocalizationScript.isSpanish)
			{
				this.potionTooltipName.text = "Poción de Mineral";
				this.potionTooltipDesc.text = "Los minerales valen " + (SetRockScreen.potionMaterialWorthMore_increase * 100f).ToString("F0") + "% más";
			}
			if (LocalizationScript.isJapanese)
			{
				this.potionTooltipName.text = "鉱石ポーション";
				this.potionTooltipDesc.text = "鉱石の価値が" + (SetRockScreen.potionMaterialWorthMore_increase * 100f).ToString("F0") + "%増加する";
			}
			if (LocalizationScript.isKorean)
			{
				this.potionTooltipName.text = "광석 포션";
				this.potionTooltipDesc.text = "광석 가치가 " + (SetRockScreen.potionMaterialWorthMore_increase * 100f).ToString("F0") + "% 증가";
			}
			if (LocalizationScript.isPolish)
			{
				this.potionTooltipName.text = "Mikstura Rudy";
				this.potionTooltipDesc.text = "Rudy są warte o " + (SetRockScreen.potionMaterialWorthMore_increase * 100f).ToString("F0") + "% więcej";
			}
			if (LocalizationScript.isPortugese)
			{
				this.potionTooltipName.text = "Poção de Minério";
				this.potionTooltipDesc.text = "Os minérios valem " + (SetRockScreen.potionMaterialWorthMore_increase * 100f).ToString("F0") + "% mais";
			}
			if (LocalizationScript.isRussian)
			{
				this.potionTooltipName.text = "Зелье Руды";
				this.potionTooltipDesc.text = "Руда стоит на " + (SetRockScreen.potionMaterialWorthMore_increase * 100f).ToString("F0") + "% дороже";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.potionTooltipName.text = "矿石药水";
				this.potionTooltipDesc.text = "矿石价值提升 " + (SetRockScreen.potionMaterialWorthMore_increase * 100f).ToString("F0") + "%";
			}
		}
		if (potionName == "pickaxeIncrease")
		{
			if (LocalizationScript.isEnglish)
			{
				this.potionTooltipName.text = "Pickaxe Potion";
				this.potionTooltipDesc.text = "Pickaxe stats are increased by " + (SetRockScreen.potionPickaxeStats_increase * 100f).ToString("F0") + "%";
			}
			if (LocalizationScript.isFrench)
			{
				this.potionTooltipName.text = "Potion de Pioche";
				this.potionTooltipDesc.text = "Les stats de la pioche sont augmentées de " + (SetRockScreen.potionPickaxeStats_increase * 100f).ToString("F0") + "%";
			}
			if (LocalizationScript.isItalian)
			{
				this.potionTooltipName.text = "Pozione del Piccone";
				this.potionTooltipDesc.text = "Le statistiche del piccone sono aumentate del " + (SetRockScreen.potionPickaxeStats_increase * 100f).ToString("F0") + "%";
			}
			if (LocalizationScript.isGerman)
			{
				this.potionTooltipName.text = "Spitzhacken-Trank";
				this.potionTooltipDesc.text = "Spitzhacken-Werte steigen um " + (SetRockScreen.potionPickaxeStats_increase * 100f).ToString("F0") + "%";
			}
			if (LocalizationScript.isSpanish)
			{
				this.potionTooltipName.text = "Poción de Pico";
				this.potionTooltipDesc.text = "Las estadísticas del pico aumentan un " + (SetRockScreen.potionPickaxeStats_increase * 100f).ToString("F0") + "%";
			}
			if (LocalizationScript.isJapanese)
			{
				this.potionTooltipName.text = "ピッケルポーション";
				this.potionTooltipDesc.text = "ピッケルのステータスが" + (SetRockScreen.potionPickaxeStats_increase * 100f).ToString("F0") + "%増加する";
			}
			if (LocalizationScript.isKorean)
			{
				this.potionTooltipName.text = "곡괭이 포션";
				this.potionTooltipDesc.text = "곡괭이 스탯이 " + (SetRockScreen.potionPickaxeStats_increase * 100f).ToString("F0") + "% 증가";
			}
			if (LocalizationScript.isPolish)
			{
				this.potionTooltipName.text = "Mikstura Kilofa";
				this.potionTooltipDesc.text = "Statystyki kilofa zwiększone o " + (SetRockScreen.potionPickaxeStats_increase * 100f).ToString("F0") + "%";
			}
			if (LocalizationScript.isPortugese)
			{
				this.potionTooltipName.text = "Poção de Picareta";
				this.potionTooltipDesc.text = "Os atributos da picareta aumentam em " + (SetRockScreen.potionPickaxeStats_increase * 100f).ToString("F0") + "%";
			}
			if (LocalizationScript.isRussian)
			{
				this.potionTooltipName.text = "Зелье Кирки";
				this.potionTooltipDesc.text = "Характеристики кирки увеличены на " + (SetRockScreen.potionPickaxeStats_increase * 100f).ToString("F0") + "%";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.potionTooltipName.text = "镐子药水";
				this.potionTooltipDesc.text = "镐子属性提高 " + (SetRockScreen.potionPickaxeStats_increase * 100f).ToString("F0") + "%";
			}
		}
		if (potionName == "xpIncrease")
		{
			if (LocalizationScript.isEnglish)
			{
				this.potionTooltipName.text = "XP Potion";
				this.potionTooltipDesc.text = "Rocks give " + (SetRockScreen.potionXp_increase * 100f).ToString("F0") + "% more XP";
			}
			if (LocalizationScript.isFrench)
			{
				this.potionTooltipName.text = "Potion d'XP";
				this.potionTooltipDesc.text = "Les roches donnent " + (SetRockScreen.potionXp_increase * 100f).ToString("F0") + "% d'XP en plus";
			}
			if (LocalizationScript.isItalian)
			{
				this.potionTooltipName.text = "Pozione XP";
				this.potionTooltipDesc.text = "Le rocce danno il " + (SetRockScreen.potionXp_increase * 100f).ToString("F0") + "% di XP in più";
			}
			if (LocalizationScript.isGerman)
			{
				this.potionTooltipName.text = "XP-Trank";
				this.potionTooltipDesc.text = "Steine geben " + (SetRockScreen.potionXp_increase * 100f).ToString("F0") + "% mehr XP";
			}
			if (LocalizationScript.isSpanish)
			{
				this.potionTooltipName.text = "Poción de XP";
				this.potionTooltipDesc.text = "Las rocas dan " + (SetRockScreen.potionXp_increase * 100f).ToString("F0") + "% más XP";
			}
			if (LocalizationScript.isJapanese)
			{
				this.potionTooltipName.text = "XPポーション";
				this.potionTooltipDesc.text = "岩が与えるXPが" + (SetRockScreen.potionXp_increase * 100f).ToString("F0") + "%増加する";
			}
			if (LocalizationScript.isKorean)
			{
				this.potionTooltipName.text = "XP 포션";
				this.potionTooltipDesc.text = "바위가 " + (SetRockScreen.potionXp_increase * 100f).ToString("F0") + "% 더 많은 XP 제공";
			}
			if (LocalizationScript.isPolish)
			{
				this.potionTooltipName.text = "Mikstura XP";
				this.potionTooltipDesc.text = "Skały dają o " + (SetRockScreen.potionXp_increase * 100f).ToString("F0") + "% więcej XP";
			}
			if (LocalizationScript.isPortugese)
			{
				this.potionTooltipName.text = "Poção de XP";
				this.potionTooltipDesc.text = "As rochas dão " + (SetRockScreen.potionXp_increase * 100f).ToString("F0") + "% mais XP";
			}
			if (LocalizationScript.isRussian)
			{
				this.potionTooltipName.text = "Зелье XP";
				this.potionTooltipDesc.text = "Камни дают на " + (SetRockScreen.potionXp_increase * 100f).ToString("F0") + "% больше XP";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.potionTooltipName.text = "XP药水";
				this.potionTooltipDesc.text = "岩石提供的XP提高 " + (SetRockScreen.potionXp_increase * 100f).ToString("F0") + "%";
			}
		}
		if (potionName == "doubleXpAndMaterialIncrease")
		{
			if (LocalizationScript.isEnglish)
			{
				this.potionTooltipName.text = "Double Chance Potion";
				this.potionTooltipDesc.text = string.Format("{0}% higher chance for ores and XP to give double", SetRockScreen.potionDoubleChance_increase);
			}
			if (LocalizationScript.isFrench)
			{
				this.potionTooltipName.text = "Potion Double Chance";
				this.potionTooltipDesc.text = string.Format("{0}% de chance en plus pour que minerais et XP doublent", SetRockScreen.potionDoubleChance_increase);
			}
			if (LocalizationScript.isItalian)
			{
				this.potionTooltipName.text = "Pozione Doppia Probabilità";
				this.potionTooltipDesc.text = string.Format("{0}% di probabilità in più che minerali e XP raddoppino", SetRockScreen.potionDoubleChance_increase);
			}
			if (LocalizationScript.isGerman)
			{
				this.potionTooltipName.text = "Doppel-Chance-Trank";
				this.potionTooltipDesc.text = string.Format("{0}% höhere Chance, dass Erze und XP doppelt zählen", SetRockScreen.potionDoubleChance_increase);
			}
			if (LocalizationScript.isSpanish)
			{
				this.potionTooltipName.text = "Poción Doble Oportunidad";
				this.potionTooltipDesc.text = string.Format("{0}% más de probabilidad de que minerales y XP se dupliquen", SetRockScreen.potionDoubleChance_increase);
			}
			if (LocalizationScript.isJapanese)
			{
				this.potionTooltipName.text = "ダブルチャンスポーション";
				this.potionTooltipDesc.text = string.Format("鉱石とXPが2倍になる確率が{0}%増加", SetRockScreen.potionDoubleChance_increase);
			}
			if (LocalizationScript.isKorean)
			{
				this.potionTooltipName.text = "더블 찬스 포션";
				this.potionTooltipDesc.text = string.Format("광석과 XP가 2배가 될 확률이 {0}% 증가", SetRockScreen.potionDoubleChance_increase);
			}
			if (LocalizationScript.isPolish)
			{
				this.potionTooltipName.text = "Mikstura Podwójnej Szansy";
				this.potionTooltipDesc.text = string.Format("{0}% większa szansa na podwojenie rudy i XP", SetRockScreen.potionDoubleChance_increase);
			}
			if (LocalizationScript.isPortugese)
			{
				this.potionTooltipName.text = "Poção de Chance Dupla";
				this.potionTooltipDesc.text = string.Format("{0}% mais chance de minérios e XP dobrarem", SetRockScreen.potionDoubleChance_increase);
			}
			if (LocalizationScript.isRussian)
			{
				this.potionTooltipName.text = "Зелье Двойного Шанса";
				this.potionTooltipDesc.text = string.Format("Шанс, что руда и XP удвоятся, увеличен на {0}%", SetRockScreen.potionDoubleChance_increase);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.potionTooltipName.text = "双倍机会药水";
				this.potionTooltipDesc.text = string.Format("矿石和XP双倍的几率提高 {0}%", SetRockScreen.potionDoubleChance_increase);
			}
		}
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00039540 File Offset: 0x00037740
	public void TalentTexts(int talentNumber)
	{
		if (talentNumber == 1)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Potion Drinker";
				this.talentDescString = "At the beginning of a mining session, you will drink 1 out of 4 possible potions. The potion contains a buff that lasts the entire mining session";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Buveur de Potions";
				this.talentDescString = "Au début d'une session de minage, vous buvez 1 des 4 potions possibles. La potion donne un bonus qui dure toute la session";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Bevitore di Pozioni";
				this.talentDescString = "All'inizio di una sessione di scavo, bevi 1 delle 4 pozioni disponibili. La pozione dà un potenziamento che dura per tutta la sessione";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Tranktrinker";
				this.talentDescString = "Zu Beginn einer Abbau-Session trinkst du 1 von 4 möglichen Tränken. Der Trank verleiht einen Buff für die gesamte Session";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Bebedor de Pociones";
				this.talentDescString = "Al inicio de una sesión de minería, bebes 1 de las 4 pociones posibles. La poción otorga un beneficio durante toda la sesión";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "ポーションドリンカー";
				this.talentDescString = "採掘セッションの開始時に、4種類のポーションのうち1つを飲みます。そのポーションの効果はセッション中ずっと続きます";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "포션 드링커";
				this.talentDescString = "채굴 세션 시작 시 4가지 포션 중 하나를 마십니다. 포션의 효과는 세션 내내 지속됩니다";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Pijak Mikstur";
				this.talentDescString = "Na początku sesji wydobycia wypijasz 1 z 4 możliwych mikstur. Mikstura daje wzmocnienie na całą sesję";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Bebedor de Poções";
				this.talentDescString = "No início de uma sessão de mineração, você bebe 1 de 4 poções possíveis. A poção concede um bônus que dura toda a sessão";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Пьющий Зелья";
				this.talentDescString = "В начале сессии добычи вы выпиваете 1 из 4 возможных зелий. Зелье даёт бафф на всю сессию";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "药水饮用者";
				this.talentDescString = "在采矿开始时，你会喝下 4 种可能药水中的一种，药水效果会持续整个采矿阶段";
			}
			this.card_potionDrinkerNAME.text = this.talentNameString;
			this.card_potionDrinker.text = this.talentDescString;
		}
		if (talentNumber == 2)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Potion Chugger";
				this.talentDescString = "At the beginning of a mining session, you will drink all 4 potions!";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Buveur Frénétique";
				this.talentDescString = "Au début d'une session de minage, vous buvez les 4 potions !";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Bevitore Vorace";
				this.talentDescString = "All'inizio di una sessione di scavo, bevi tutte e 4 le pozioni!";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Trank-Schlucker";
				this.talentDescString = "Zu Beginn einer Abbau-Session trinkst du alle 4 Tränke!";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Beber Pociones";
				this.talentDescString = "Al inicio de una sesión de minería, bebes las 4 pociones!";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "ポーションガブ飲み";
				this.talentDescString = "採掘セッション開始時に4種類すべてのポーションを飲みます！";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "포션 폭음자";
				this.talentDescString = "채굴 세션 시작 시 4가지 포션을 전부 마십니다!";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Łykacz Mikstur";
				this.talentDescString = "Na początku sesji wydobycia wypijasz wszystkie 4 mikstury!";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Beber Tudo";
				this.talentDescString = "No início de uma sessão de mineração, você bebe todas as 4 poções!";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Зельевар-Глотатель";
				this.talentDescString = "В начале сессии добычи вы выпиваете все 4 зелья!";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "药水狂饮者";
				this.talentDescString = "在采矿开始时，你会喝下全部 4 种药水！";
			}
			this.card_potionChuggerNAME.text = this.talentNameString;
			this.card_potionChugger.text = this.talentDescString;
		}
		if (talentNumber == 3)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Rock? No, it's a chest!";
				this.talentDescString = string.Format("Every rock has a {0}% chance to be replaced with a treasure chest that contains {1} random ores.", LevelMechanics.rockSpawnChance, LevelMechanics.totalChestMaterials);
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Roche ? Non, un coffre !";
				this.talentDescString = string.Format("Chaque roche a {0}% de chance d'être remplacée par un coffre au trésor contenant {1} minerais aléatoires.", LevelMechanics.rockSpawnChance, LevelMechanics.totalChestMaterials);
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Roccia? No, è un forziere!";
				this.talentDescString = string.Format("Ogni roccia ha il {0}% di probabilità di essere sostituita da un forziere contenente {1} minerali casuali.", LevelMechanics.rockSpawnChance, LevelMechanics.totalChestMaterials);
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Stein? Nein, eine Truhe!";
				this.talentDescString = string.Format("Jeder Stein hat eine Chance von {0}%, durch eine Schatztruhe ersetzt zu werden, die {1} zufällige Erze enthält.", LevelMechanics.rockSpawnChance, LevelMechanics.totalChestMaterials);
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "¿Roca? ¡No, es un cofre!";
				this.talentDescString = string.Format("Cada roca tiene un {0}% de probabilidad de ser reemplazada por un cofre del tesoro con {1} minerales aleatorios.", LevelMechanics.rockSpawnChance, LevelMechanics.totalChestMaterials);
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "岩？いいえ、宝箱！";
				this.talentDescString = string.Format("すべての岩には{0}%の確率で{1}個のランダムな鉱石が入った宝箱に置き換わるチャンスがある。", LevelMechanics.rockSpawnChance, LevelMechanics.totalChestMaterials);
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "바위? 아니, 보물상자!";
				this.talentDescString = string.Format("모든 바위는 {0}% 확률로 {1}개의 랜덤 광석이 들어있는 보물상자로 대체됩니다.", LevelMechanics.rockSpawnChance, LevelMechanics.totalChestMaterials);
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Skała? Nie, to skrzynia!";
				this.talentDescString = string.Format("Każda skała ma {0}% szansy na zamianę w skrzynię skarbów zawierającą {1} losowych rud.", LevelMechanics.rockSpawnChance, LevelMechanics.totalChestMaterials);
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Rocha? Não, é um baú!";
				this.talentDescString = string.Format("Cada rocha tem {0}% de chance de ser substituída por um baú do tesouro com {1} minérios aleatórios.", LevelMechanics.rockSpawnChance, LevelMechanics.totalChestMaterials);
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Камень? Нет, это сундук!";
				this.talentDescString = string.Format("Каждый камень имеет {0}% шанс быть заменённым сундуком с {1} случайными рудами.", LevelMechanics.rockSpawnChance, LevelMechanics.totalChestMaterials);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "岩石？不，是宝箱！";
				this.talentDescString = string.Format("每块岩石有 {0}% 几率变成一个宝箱，内含 {1} 个随机矿石。", LevelMechanics.rockSpawnChance, LevelMechanics.totalChestMaterials);
			}
			this.card_chestsNAME.text = this.talentNameString;
			this.card_chests.text = this.talentDescString;
		}
		if (talentNumber == 4)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Gilded Chest";
				this.talentDescString = string.Format("At the start of a mining session, there is a 50% chance to spawn a golden treasure chest that contains {0} random ores.", LevelMechanics.totalGoldenChestMaterials);
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Coffre Doré";
				this.talentDescString = string.Format("Au début d'une session de minage, il y a 50% de chance de faire apparaître un coffre au trésor doré contenant {0} minerais aléatoires.", LevelMechanics.totalGoldenChestMaterials);
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Forziere Dorato";
				this.talentDescString = string.Format("All'inizio di una sessione di scavo, c'è il 50% di probabilità di generare un forziere dorato contenente {0} minerali casuali.", LevelMechanics.totalGoldenChestMaterials);
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Vergoldete Truhe";
				this.talentDescString = string.Format("Zu Beginn einer Abbau-Session gibt es eine 50% Chance, eine goldene Schatztruhe mit {0} zufälligen Erzen zu spawnen.", LevelMechanics.totalGoldenChestMaterials);
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Cofre Dorado";
				this.talentDescString = string.Format("Al inicio de una sesión de minería, hay un 50% de probabilidad de aparecer un cofre del tesoro dorado con {0} minerales aleatorios.", LevelMechanics.totalGoldenChestMaterials);
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "黄金の宝箱";
				this.talentDescString = string.Format("採掘セッション開始時に、{0}個のランダム鉱石が入った黄金の宝箱が50%の確率で出現する。", LevelMechanics.totalGoldenChestMaterials);
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "황금 상자";
				this.talentDescString = string.Format("채굴 세션 시작 시 50% 확률로 {0}개의 랜덤 광석이 들어있는 황금 보물상자가 생성됩니다.", LevelMechanics.totalGoldenChestMaterials);
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Złota Skrzynia";
				this.talentDescString = string.Format("Na początku sesji wydobycia jest 50% szansy na pojawienie się złotej skrzyni z {0} losowymi rudami.", LevelMechanics.totalGoldenChestMaterials);
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Baú Dourado";
				this.talentDescString = string.Format("No início de uma sessão de mineração, há 50% de chance de surgir um baú do tesouro dourado com {0} minérios aleatórios.", LevelMechanics.totalGoldenChestMaterials);
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Золотой Сундук";
				this.talentDescString = string.Format("В начале сессии добычи есть 50% шанс появления золотого сундука с {0} случайными рудами.", LevelMechanics.totalGoldenChestMaterials);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "镀金宝箱";
				this.talentDescString = string.Format("采矿开始时，有 50% 几率生成一个包含 {0} 个随机矿石的金色宝箱。", LevelMechanics.totalGoldenChestMaterials);
			}
			this.card_goldenChestsNAME.text = this.talentNameString;
			this.card_goldenChests.text = this.talentDescString;
		}
		if (talentNumber == 5)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Skilled Miners";
				this.talentDescString = string.Format("The Mine has a {0}% chance to mine twice as fast and a {1}% chance to mine 2X bars.", LevelMechanics.skilledMinersFastChance, LevelMechanics.skilledMinersDoubleChance);
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Mineurs Experts";
				this.talentDescString = string.Format("La Mine a {0}% de chance de miner deux fois plus vite et {1}% de chance de produire 2X lingots.", LevelMechanics.skilledMinersFastChance, LevelMechanics.skilledMinersDoubleChance);
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Minatori Esperti";
				this.talentDescString = string.Format("La Miniera ha il {0}% di probabilità di estrarre il doppio più veloce e il {1}% di probabilità di produrre 2X barre.", LevelMechanics.skilledMinersFastChance, LevelMechanics.skilledMinersDoubleChance);
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Erfahrene Bergleute";
				this.talentDescString = string.Format("Die Mine hat eine Chance von {0}%, doppelt so schnell zu arbeiten, und {1}% Chance, doppelt so viele Barren zu fördern.", LevelMechanics.skilledMinersFastChance, LevelMechanics.skilledMinersDoubleChance);
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Mineros Expertos";
				this.talentDescString = string.Format("La Mina tiene un {0}% de probabilidad de minar el doble de rápido y un {1}% de probabilidad de producir 2X barras.", LevelMechanics.skilledMinersFastChance, LevelMechanics.skilledMinersDoubleChance);
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "熟練の鉱夫";
				this.talentDescString = string.Format("ザ・マインは{0}%の確率で採掘速度が2倍になり、{1}%の確率で2倍のインゴットを採掘する。", LevelMechanics.skilledMinersFastChance, LevelMechanics.skilledMinersDoubleChance);
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "숙련된 광부들";
				this.talentDescString = string.Format("광산은 {0}% 확률로 2배 속도로 채굴하며, {1}% 확률로 2배 바를 생산합니다.", LevelMechanics.skilledMinersFastChance, LevelMechanics.skilledMinersDoubleChance);
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Wykwalifikowani Górnicy";
				this.talentDescString = string.Format("Kopalnia ma {0}% szansy na dwukrotnie szybsze wydobycie i {1}% szansy na wydobycie 2X sztabek.", LevelMechanics.skilledMinersFastChance, LevelMechanics.skilledMinersDoubleChance);
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Mineiros Habilidosos";
				this.talentDescString = string.Format("A Mina tem {0}% de chance de minerar duas vezes mais rápido e {1}% de chance de gerar 2X barras.", LevelMechanics.skilledMinersFastChance, LevelMechanics.skilledMinersDoubleChance);
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Опытные Шахтёры";
				this.talentDescString = string.Format("Шахта имеет {0}% шанс работать в 2 раза быстрее и {1}% шанс добывать 2X слитков.", LevelMechanics.skilledMinersFastChance, LevelMechanics.skilledMinersDoubleChance);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "熟练矿工";
				this.talentDescString = string.Format("矿井有 {0}% 几率采矿速度翻倍，且有 {1}% 几率产出双倍锭。", LevelMechanics.skilledMinersFastChance, LevelMechanics.skilledMinersDoubleChance);
			}
			this.card_skilledMinersNAME.text = this.talentNameString;
			this.card_skilledMiners.text = this.talentDescString;
		}
		if (talentNumber == 6)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "It's a Sign!";
				this.talentDescString = "A sign with a written buff will appear next to The Mine. The buff changes every 5 minutes.";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "C'est un Signe !";
				this.talentDescString = "Un panneau avec un bonus écrit apparaît à côté de La Mine. Le bonus change toutes les 5 minutes.";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "È un Segno!";
				this.talentDescString = "Un cartello con un potenziamento scritto appare accanto alla Miniera. Il bonus cambia ogni 5 minuti.";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Ein Zeichen!";
				this.talentDescString = "Ein Schild mit einem geschriebenen Buff erscheint neben der Mine. Der Buff wechselt alle 5 Minuten.";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "¡Es una Señal!";
				this.talentDescString = "Un cartel con un beneficio escrito aparecerá junto a La Mina. El beneficio cambia cada 5 minutos.";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "これはサインだ！";
				this.talentDescString = "ザ・マインの隣にバフが書かれた看板が出現します。バフは5分ごとに変わります。";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "이건 신호다!";
				this.talentDescString = "광산 옆에 버프가 적힌 표지판이 나타납니다. 버프는 5분마다 변경됩니다.";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "To Znak!";
				this.talentDescString = "Obok Kopalni pojawi się znak z zapisanym buffem. Buff zmienia się co 5 minut.";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "É um Sinal!";
				this.talentDescString = "Um sinal com um buff escrito aparecerá ao lado da Mina. O buff muda a cada 5 minutos.";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Это Знак!";
				this.talentDescString = "Рядом с Шахтой появится табличка с баффом. Бафф меняется каждые 5 минут.";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "这是一个标志！";
				this.talentDescString = "矿井旁会出现一个写有增益的牌子，增益每 5 分钟更换一次。";
			}
			this.card_itsASignNAME.text = this.talentNameString;
			this.card_itsASign.text = this.talentDescString;
		}
		if (talentNumber == 7)
		{
			float num = 1f - LevelMechanics.blacksmithDecreaseDISPLAY;
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Efficient Blacksmith";
				this.talentDescString = "Crafting a pickaxe takes " + (num * 100f).ToString("F0") + "% less bars.";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Forgeron Efficace";
				this.talentDescString = "Fabriquer une pioche nécessite " + (num * 100f).ToString("F0") + "% de barres en moins.";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Fabbro Efficiente";
				this.talentDescString = "Forgiare un piccone richiede il " + (num * 100f).ToString("F0") + "% di barre in meno.";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Effizienter Schmied";
				this.talentDescString = "Das Schmieden einer Spitzhacke benötigt " + (num * 100f).ToString("F0") + "% weniger Barren.";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Herrero Eficiente";
				this.talentDescString = "Fabricar un pico requiere " + (num * 100f).ToString("F0") + "% menos barras.";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "効率の良い鍛冶屋";
				this.talentDescString = "ピッケルの作成に必要なインゴットが" + (num * 100f).ToString("F0") + "%少なくなる。";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "효율적인 대장장이";
				this.talentDescString = "곡괭이 제작 시 바 소모량이 " + (num * 100f).ToString("F0") + "% 감소.";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Wydajny Kowal";
				this.talentDescString = "Tworzenie kilofa zużywa o " + (num * 100f).ToString("F0") + "% mniej sztabek.";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Ferreiro Eficiente";
				this.talentDescString = "Forjar uma picareta usa " + (num * 100f).ToString("F0") + "% menos barras.";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Эффективный Кузнец";
				this.talentDescString = "Создание кирки требует на " + (num * 100f).ToString("F0") + "% меньше слитков.";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "高效铁匠";
				this.talentDescString = "打造镐子所需锭数减少 " + (num * 100f).ToString("F0") + "% 。";
			}
			this.card_efficientBlacksmithNAME.text = this.talentNameString;
			this.card_efficientBlacksmith.text = this.talentDescString;
		}
		if (talentNumber == 8)
		{
			float num2 = (1f - LevelMechanics.steamSaleDiscount) * 100f;
			if (num2 == 0f)
			{
				num2 = 7f;
			}
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Steam Sale";
				this.talentDescString = "Reduces the price of all skill tree upgrades by " + num2.ToString("F0") + "%.";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Promo Steam";
				this.talentDescString = "Réduit le prix de toutes les améliorations de l'arbre de compétences de " + num2.ToString("F0") + "%.";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Sconto Steam";
				this.talentDescString = "Riduce il costo di tutti i potenziamenti dell'albero abilità del " + num2.ToString("F0") + "%.";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Steam-Sale";
				this.talentDescString = "Reduziert die Kosten aller Skilltree-Upgrades um " + num2.ToString("F0") + "%.";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Oferta Steam";
				this.talentDescString = "Reduce el precio de todas las mejoras del árbol de habilidades en un " + num2.ToString("F0") + "%.";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "スチームセール";
				this.talentDescString = "スキルツリーのすべてのアップグレード価格を" + num2.ToString("F0") + "%割引する。";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "스팀 세일";
				this.talentDescString = "스킬 트리 업그레이드 가격이 " + num2.ToString("F0") + "% 감소합니다.";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Wyprzedaż Steam";
				this.talentDescString = "Obniża cenę wszystkich ulepszeń w drzewku umiejętności o " + num2.ToString("F0") + "%.";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Promoção Steam";
				this.talentDescString = "Reduz o preço de todos os upgrades da árvore de habilidades em " + num2.ToString("F0") + "%.";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Распродажа Steam";
				this.talentDescString = "Снижает цену всех улучшений дерева навыков на " + num2.ToString("F0") + "%.";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "Steam 大促销";
				this.talentDescString = "所有技能树升级价格降低 " + num2.ToString("F0") + "%。";
			}
			this.card_steamSaleNAME.text = this.talentNameString;
			this.card_steamSale.text = this.talentDescString;
		}
		if (talentNumber == 9)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Inflate Burst";
				this.talentDescString = string.Format("Every second, the mining area has a {0}% chance of increasing in size by {1}% for {2} seconds.", LevelMechanics.bigMiningAreaChance, LevelMechanics.inflationBurstIncrease * 100f, LevelMechanics.bigMiningAreaTime);
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Explosion d'Expansion";
				this.talentDescString = string.Format("Chaque seconde, la zone de minage a {0}% de chance de s'agrandir de {1}% pendant {2} secondes.", LevelMechanics.bigMiningAreaChance, LevelMechanics.inflationBurstIncrease * 100f, LevelMechanics.bigMiningAreaTime);
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Scoppio di Espansione";
				this.talentDescString = string.Format("Ogni secondo, l'area di scavo ha il {0}% di probabilità di aumentare di dimensione del {1}% per {2} secondi.", LevelMechanics.bigMiningAreaChance, LevelMechanics.inflationBurstIncrease * 100f, LevelMechanics.bigMiningAreaTime);
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Größen-Explosion";
				this.talentDescString = string.Format("Jede Sekunde hat der Minenbereich eine Chance von {0}%, sich um {1}% zu vergrößern für {2} Sekunden.", LevelMechanics.bigMiningAreaChance, LevelMechanics.inflationBurstIncrease * 100f, LevelMechanics.bigMiningAreaTime);
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Explosión de Expansión";
				this.talentDescString = string.Format("Cada segundo, el área de minería tiene un {0}% de probabilidad de aumentar su tamaño en un {1}% durante {2} segundos.", LevelMechanics.bigMiningAreaChance, LevelMechanics.inflationBurstIncrease * 100f, LevelMechanics.bigMiningAreaTime);
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "バースト拡張";
				this.talentDescString = string.Format("毎秒、採掘エリアは{0}%の確率で{1}%拡大し、{2}秒間持続する。", LevelMechanics.bigMiningAreaChance, LevelMechanics.inflationBurstIncrease * 100f, LevelMechanics.bigMiningAreaTime);
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "확장 폭발";
				this.talentDescString = string.Format("매초 광구는 {0}% 확률로 {1}% 커지며 {2}초 동안 유지됩니다.", LevelMechanics.bigMiningAreaChance, LevelMechanics.inflationBurstIncrease * 100f, LevelMechanics.bigMiningAreaTime);
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Impuls Rozszerzenia";
				this.talentDescString = string.Format("Co sekundę obszar wydobycia ma {0}% szansy na powiększenie się o {1}% na {2} sekund.", LevelMechanics.bigMiningAreaChance, LevelMechanics.inflationBurstIncrease * 100f, LevelMechanics.bigMiningAreaTime);
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Explosão de Expansão";
				this.talentDescString = string.Format("A cada segundo, a área de mineração tem {0}% de chance de aumentar {1}% de tamanho por {2} segundos.", LevelMechanics.bigMiningAreaChance, LevelMechanics.inflationBurstIncrease * 100f, LevelMechanics.bigMiningAreaTime);
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Взрыв Расширения";
				this.talentDescString = string.Format("Каждую секунду зона добычи имеет {0}% шанс увеличиться на {1}% на {2} секунд.", LevelMechanics.bigMiningAreaChance, LevelMechanics.inflationBurstIncrease * 100f, LevelMechanics.bigMiningAreaTime);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "膨胀爆发";
				this.talentDescString = string.Format("每秒采矿区域有 {0}% 概率增大 {1}% ，持续 {2} 秒。", LevelMechanics.bigMiningAreaChance, LevelMechanics.inflationBurstIncrease * 100f, LevelMechanics.bigMiningAreaTime);
			}
			this.card_inflationBurstNAME.text = this.talentNameString;
			this.card_inflationBurst.text = this.talentDescString;
		}
		if (talentNumber == 10)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "It's Hammer Time!";
				this.talentDescString = string.Format("Every pickaxe has a {0}% chance to turn into a hammer. Rocks hit with the hammer will be insta mined and the mined ores will be worth double.", LevelMechanics.hammerChance);
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "C'est l'Heure du Marteau !";
				this.talentDescString = string.Format("Chaque pioche a {0}% de chance de se transformer en marteau. Les roches frappées avec le marteau seront instantanément minées et vaudront le double.", LevelMechanics.hammerChance);
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "È Tempo di Martello!";
				this.talentDescString = string.Format("Ogni piccone ha il {0}% di probabilità di trasformarsi in un martello. Le rocce colpite con il martello saranno scavate istantaneamente e i minerali varranno il doppio.", LevelMechanics.hammerChance);
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Hammerzeit!";
				this.talentDescString = string.Format("Jede Spitzhacke hat eine Chance von {0}%, sich in einen Hammer zu verwandeln. Steine, die mit dem Hammer getroffen werden, werden sofort abgebaut und sind doppelt so viel wert.", LevelMechanics.hammerChance);
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "¡Hora del Martillo!";
				this.talentDescString = string.Format("Cada pico tiene un {0}% de probabilidad de convertirse en martillo. Las rocas golpeadas con el martillo se minarán al instante y valdrán el doble.", LevelMechanics.hammerChance);
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "ハンマータイム！";
				this.talentDescString = string.Format("すべてのピッケルは{0}%の確率でハンマーに変化する。ハンマーで叩かれた岩は即座に採掘され、鉱石の価値は2倍になる。", LevelMechanics.hammerChance);
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "망치 타임!";
				this.talentDescString = string.Format("모든 곡괭이는 {0}% 확률로 망치로 변합니다. 망치로 맞은 바위는 즉시 채굴되며, 채굴된 광석은 2배 가치가 됩니다.", LevelMechanics.hammerChance);
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Czas na Młot!";
				this.talentDescString = string.Format("Każdy kilof ma {0}% szansy na zamianę w młot. Skały uderzone młotem są natychmiast wydobywane, a rudy warte są dwa razy więcej.", LevelMechanics.hammerChance);
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Hora do Martelo!";
				this.talentDescString = string.Format("Cada picareta tem {0}% de chance de virar um martelo. Rochas atingidas com o martelo serão mineradas instantaneamente e os minérios valerão o dobro.", LevelMechanics.hammerChance);
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Время Молота!";
				this.talentDescString = string.Format("Каждая кирка имеет {0}% шанс превратиться в молот. Камни, ударенные молотом, будут мгновенно добыты, а руды будут стоить вдвое дороже.", LevelMechanics.hammerChance);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "锤子时间！";
				this.talentDescString = string.Format("每把镐子有 {0}% 概率变成锤子，用锤子敲击的岩石会被瞬间开采，且矿石价值翻倍。", LevelMechanics.hammerChance);
			}
			this.card_itsHammerTimeNAME.text = this.talentNameString;
			this.card_itsHammerTime.text = this.talentDescString;
		}
		if (talentNumber == 11)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Midas Touch";
				if (!MobileAndTesting.isMobile)
				{
					this.talentDescString = string.Format("At the start of every mining session, your cursor has a {0}% chance to turn gold. This causes each pickaxe hit to have a {1}% chance to spawn an ore.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
				else
				{
					this.talentDescString = string.Format("At the start of every mining session, your mining area has a {0}% chance to turn gold. This causes each pickaxe hit to have a {1}% chance to spawn an ore.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Toucher de Midas";
				if (!MobileAndTesting.isMobile)
				{
					this.talentDescString = string.Format("Au début de chaque session de minage, votre curseur a {0}% de chance de devenir doré. Chaque coup de pioche aura alors {1}% de chance de générer un minerai.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
				else
				{
					this.talentDescString = string.Format("Au début de chaque session de minage, votre zone de minage a {0}% de chance de devenir dorée. Cela fait que chaque coup de pioche a {1}% de chance de faire apparaître un minerai.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Tocco di Mida";
				if (!MobileAndTesting.isMobile)
				{
					this.talentDescString = string.Format("All'inizio di ogni sessione di scavo, il cursore ha il {0}% di probabilità di diventare dorato. Questo fa sì che ogni colpo di piccone abbia il {1}% di probabilità di generare un minerale.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
				else
				{
					this.talentDescString = string.Format("All'inizio di ogni sessione di estrazione, la tua area di estrazione ha una probabilità del {0}% di diventare dorata. Questo fa sì che ogni colpo di piccone abbia una probabilità del {1}% di generare un minerale.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Midas' Berührung";
				if (!MobileAndTesting.isMobile)
				{
					this.talentDescString = string.Format("Zu Beginn jeder Abbau-Session hat dein Cursor eine Chance von {0}%, goldfarben zu werden. Dadurch hat jeder Spitzhackenschlag eine Chance von {1}%, Erz zu spawnen.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
				else
				{
					this.talentDescString = string.Format("Zu Beginn jeder Minensitzung hat dein Abbaugebiet eine Chance von {0}%, golden zu werden. Dadurch hat jeder Spitzhackenhieb eine Chance von {1}%, ein Erz zu erzeugen.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Toque de Midas";
				if (!MobileAndTesting.isMobile)
				{
					this.talentDescString = string.Format("Al inicio de cada sesión de minería, tu cursor tiene un {0}% de probabilidad de volverse dorado. Esto hace que cada golpe de pico tenga un {1}% de probabilidad de generar un mineral.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
				else
				{
					this.talentDescString = string.Format("Al comienzo de cada sesión de minería, tu área de minería tiene un {0}% de probabilidad de volverse dorada. Esto hace que cada golpe de pico tenga un {1}% de probabilidad de generar un mineral.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "ミダスタッチ";
				if (!MobileAndTesting.isMobile)
				{
					this.talentDescString = string.Format("採掘セッション開始時に、カーソルが{0}%の確率で黄金になる。これにより、ピッケルのヒットごとに{1}%の確率で鉱石が生成される。", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
				else
				{
					this.talentDescString = string.Format("採掘セッションの開始時に、採掘エリアが{0}%の確率で黄金に変わります。これにより、ツルハシの一撃ごとに{1}%の確率で鉱石が出現します。", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "마이더스 터치";
				if (!MobileAndTesting.isMobile)
				{
					this.talentDescString = string.Format("채굴 세션 시작 시 커서가 {0}% 확률로 금색으로 변합니다. 그 상태에서는 곡괭이 타격마다 {1}% 확률로 광석이 생성됩니다.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
				else
				{
					this.talentDescString = string.Format("각 채굴 세션이 시작될 때, 채굴 구역이 {0}% 확률로 황금으로 변합니다. 이렇게 되면 곡괭이 타격마다 {1}% 확률로 광석이 생성됩니다.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Dotyk Midasa";
				if (!MobileAndTesting.isMobile)
				{
					this.talentDescString = string.Format("Na początku każdej sesji wydobycia twój kursor ma {0}% szansy na zamianę w złoty. Każde uderzenie kilofa ma wtedy {1}% szansy na pojawienie się rudy.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
				else
				{
					this.talentDescString = string.Format("Na początku każdej sesji wydobywczej twoja strefa wydobycia ma {0}% szans na zamianę w złotą. Powoduje to, że każde uderzenie kilofa ma {1}% szans na wydobycie rudy.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Toque de Midas";
				if (!MobileAndTesting.isMobile)
				{
					this.talentDescString = string.Format("No início de cada sessão de mineração, seu cursor tem {0}% de chance de ficar dourado. Isso faz cada golpe de picareta ter {1}% de chance de gerar um minério.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
				else
				{
					this.talentDescString = string.Format("No início de cada sessão de mineração, sua área de mineração tem {0}% de chance de se tornar dourada. Isso faz com que cada golpe da picareta tenha {1}% de chance de gerar um minério.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Прикосновение Мидаса";
				if (!MobileAndTesting.isMobile)
				{
					this.talentDescString = string.Format("В начале каждой сессии добычи твой курсор имеет {0}% шанс стать золотым. Это даёт каждому удару кирки {1}% шанс создать руду.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
				else
				{
					this.talentDescString = string.Format("В начале каждой сессии добычи ваша зона добычи имеет {0}% шанс стать золотой. Это приводит к тому, что каждый удар киркой имеет {1}% шанс породить руду.", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "点金之触";
				if (!MobileAndTesting.isMobile)
				{
					this.talentDescString = string.Format("每次采矿开始时，光标有 {0}% 概率变为金色。此时每次镐击有 {1}% 概率生成一块矿石。", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
				else
				{
					this.talentDescString = string.Format("在每次采矿会话开始时，你的采矿区域有 {0}% 的几率变成黄金。这会使每次镐子的攻击有 {1}% 的几率生成一块矿石。", LevelMechanics.midasTouchChance, LevelMechanics.midasTouchSpawnChance);
				}
			}
			this.card_midasTouchNAME.text = this.talentNameString;
			this.card_midasTouch.text = this.talentDescString;
		}
		if (talentNumber == 12)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Zeus Wrath";
				this.talentDescString = string.Format("Every second, there is a {0}% chance to spawn {1} lightning beams that target random rocks.", LevelMechanics.zeusChance, LevelMechanics.zeusLightningAmount);
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Colère de Zeus";
				this.talentDescString = string.Format("Chaque seconde, il y a {0}% de chance de faire apparaître {1} éclairs qui frappent des roches au hasard.", LevelMechanics.zeusChance, LevelMechanics.zeusLightningAmount);
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Ira di Zeus";
				this.talentDescString = string.Format("Ogni secondo, c'è il {0}% di probabilità di generare {1} fulmini che colpiscono rocce casuali.", LevelMechanics.zeusChance, LevelMechanics.zeusLightningAmount);
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Zornsblitz des Zeus";
				this.talentDescString = string.Format("Jede Sekunde besteht eine Chance von {0}%, {1} Blitze zu erzeugen, die zufällige Steine treffen.", LevelMechanics.zeusChance, LevelMechanics.zeusLightningAmount);
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Ira de Zeus";
				this.talentDescString = string.Format("Cada segundo hay un {0}% de probabilidad de invocar {1} rayos que impactan rocas aleatorias.", LevelMechanics.zeusChance, LevelMechanics.zeusLightningAmount);
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "ゼウスの怒り";
				this.talentDescString = string.Format("毎秒、{0}%の確率で{1}本の稲妻がランダムな岩を攻撃する。", LevelMechanics.zeusChance, LevelMechanics.zeusLightningAmount);
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "제우스의 분노";
				this.talentDescString = string.Format("매초 {0}% 확률로 무작위 바위를 목표로 {1}개의 번개가 떨어집니다.", LevelMechanics.zeusChance, LevelMechanics.zeusLightningAmount);
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Gniew Zeusa";
				this.talentDescString = string.Format("Co sekundę jest {0}% szansy na przywołanie {1} piorunów, które uderzają w losowe skały.", LevelMechanics.zeusChance, LevelMechanics.zeusLightningAmount);
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Ira de Zeus";
				this.talentDescString = string.Format("A cada segundo, há {0}% de chance de gerar {1} raios que atingem rochas aleatórias.", LevelMechanics.zeusChance, LevelMechanics.zeusLightningAmount);
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Гнев Зевса";
				this.talentDescString = string.Format("Каждую секунду есть {0}% шанс вызвать {1} молний, которые поражают случайные камни.", LevelMechanics.zeusChance, LevelMechanics.zeusLightningAmount);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "宙斯之怒";
				this.talentDescString = string.Format("每秒有 {0}% 的几率召唤 {1} 道闪电击中随机岩石。", LevelMechanics.zeusChance, LevelMechanics.zeusLightningAmount);
			}
			this.card_zeusWrathNAME.text = this.talentNameString;
			this.card_zeusWrath.text = this.talentDescString;
		}
		if (talentNumber == 13)
		{
			float num3 = LevelMechanics.shapeShifterSizeIncreaseDISPLAY * 100f;
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Shape Shifter";
				this.talentDescString = "Increase the mining area by " + num3.ToString("F0") + "%. Every mining session, the mining area will either be a circle, square, or hexagon. The square and hexagon shapes cover more area than the circle.";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Changeur de Forme";
				this.talentDescString = "Augmente la zone de minage de " + num3.ToString("F0") + "%. À chaque session, la zone de minage sera un cercle, un carré ou un hexagone.";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Mutamento di Forma";
				this.talentDescString = "Aumenta l'area di scavo del " + num3.ToString("F0") + "%. Ad ogni sessione, l'area sarà un cerchio, un quadrato o un esagono.";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Formwandler";
				this.talentDescString = "Erhöht den Minenbereich um " + num3.ToString("F0") + "%. Bei jeder Session ist die Form entweder ein Kreis, Quadrat oder Hexagon.";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Cambiaformas";
				this.talentDescString = "Aumenta el área de minería en un " + num3.ToString("F0") + "%. En cada sesión, el área será un círculo, un cuadrado o un hexágono.";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "シェイプシフター";
				this.talentDescString = "採掘エリアを" + num3.ToString("F0") + "%拡大する。毎回、エリアの形は円形、四角形、または六角形になる。";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "형태 변환자";
				this.talentDescString = "채굴 영역 크기를 " + num3.ToString("F0") + "% 증가시킵니다. 세션마다 채굴 영역은 원형, 사각형 또는 육각형이 됩니다.";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Zmieniacz Kształtu";
				this.talentDescString = "Zwiększa obszar wydobycia o " + num3.ToString("F0") + "%. W każdej sesji obszar będzie miał kształt koła, kwadratu lub sześciokąta.";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Muda-Forma";
				this.talentDescString = "Aumenta a área de mineração em " + num3.ToString("F0") + "%. A cada sessão, a área será um círculo, quadrado ou hexágono.";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Меняющий Форму";
				this.talentDescString = "Увеличивает область добычи на " + num3.ToString("F0") + "%. В каждой сессии форма будет круг, квадрат или шестиугольник.";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "形态变换者";
				this.talentDescString = "采矿区域扩大 " + num3.ToString("F0") + "%。每次采矿时，区域形状将在圆形、方形或六边形之间变化。";
			}
			this.card_shapeShifterNAME.text = this.talentNameString;
			this.card_shapeShifter.text = this.talentDescString;
		}
		if (talentNumber == 14)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "X Marks The Spot";
				this.talentDescString = "Higher chance to find artifacts!";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "X Marque l'Endroit";
				this.talentDescString = "Plus de chance de trouver des artefacts !";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "X Segna il Punto";
				this.talentDescString = "Probabilità più alta di trovare artefatti!";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "X Markiert den Schatz";
				this.talentDescString = "Höhere Chance, Artefakte zu finden!";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "X Marca el Lugar";
				this.talentDescString = "Mayor probabilidad de encontrar artefactos!";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "Xが場所を示す";
				this.talentDescString = "アーティファクトが見つかる確率が上昇！";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "X 표시된 장소";
				this.talentDescString = "유물을 찾을 확률이 증가합니다!";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "X Oznacza Miejsce";
				this.talentDescString = "Większa szansa na znalezienie artefaktów!";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "X Marca o Local";
				this.talentDescString = "Mais chance de encontrar artefatos!";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "X Отмечает Место";
				this.talentDescString = "Больше шанс найти артефакты!";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "X标记之处";
				this.talentDescString = "更高几率找到神器！";
			}
			this.card_xMarksTheSpotNAME.text = this.talentNameString;
			this.card_xMarksTheSpot.text = this.talentDescString;
		}
		if (talentNumber == 15)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Explorer";
				this.talentDescString = "Greater chance to find artifacts!";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Explorateur";
				this.talentDescString = "Encore plus de chance de trouver des artefacts !";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Esploratore";
				this.talentDescString = "Probabilità ancora maggiore di trovare artefatti!";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Entdecker";
				this.talentDescString = "Noch höhere Chance, Artefakte zu finden!";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Explorador";
				this.talentDescString = "Mayor probabilidad de encontrar artefactos!";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "エクスプローラー";
				this.talentDescString = "さらにアーティファクトが見つかる確率が上昇！";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "탐험가";
				this.talentDescString = "유물을 찾을 확률이 더욱 증가합니다!";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Odkrywca";
				this.talentDescString = "Jeszcze większa szansa na znalezienie artefaktów!";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Explorador";
				this.talentDescString = "Ainda mais chance de encontrar artefatos!";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Исследователь";
				this.talentDescString = "Ещё больше шанс найти артефакты!";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "探险家";
				this.talentDescString = "找到神器的几率更高！";
			}
			this.card_explorerNAME.text = this.talentNameString;
			this.card_explorer.text = this.talentDescString;
		}
		if (talentNumber == 16)
		{
			float num4 = LevelMechanics.archeologistIncreaseDISPLAY * 100f;
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Archaeologist";
				this.talentDescString = string.Format("The stats from all artifacts are improved by {0}%.", num4);
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Archéologue";
				this.talentDescString = string.Format("Les stats de tous les artefacts sont améliorées de {0}%.", num4);
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Archeologo";
				this.talentDescString = string.Format("Le statistiche di tutti gli artefatti sono aumentate del {0}%.", num4);
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Archäologe";
				this.talentDescString = string.Format("Die Werte aller Artefakte werden um {0}% verbessert.", num4);
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Arqueólogo";
				this.talentDescString = string.Format("Las estadísticas de todos los artefactos se mejoran en un {0}%.", num4);
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "考古学者";
				this.talentDescString = string.Format("すべてのアーティファクトのステータスが{0}%向上する。", num4);
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "고고학자";
				this.talentDescString = string.Format("모든 유물의 스탯이 {0}% 향상됩니다.", num4);
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Archeolog";
				this.talentDescString = string.Format("Statystyki wszystkich artefaktów są zwiększone o {0}%.", num4);
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Arqueólogo";
				this.talentDescString = string.Format("As estatísticas de todos os artefatos são melhoradas em {0}%.", num4);
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Археолог";
				this.talentDescString = string.Format("Характеристики всех артефактов улучшаются на {0}%.", num4);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "考古学家";
				this.talentDescString = string.Format("所有神器属性提高 {0}%。", num4);
			}
			this.card_archaeologistNAME.text = this.talentNameString;
			this.card_archaeologist.text = this.talentDescString;
		}
		if (talentNumber == 17)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Energy Drinker";
				this.talentDescString = string.Format("Every second, you have a {0}% chance to drink an energy drink, which doubles your mining speed for {1} seconds.", LevelMechanics.energiDrinkChance, LevelMechanics.energiDrinkTime);
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Buveur d'Énergie";
				this.talentDescString = string.Format("Chaque seconde, vous avez {0}% de chance de boire une boisson énergétique, doublant votre vitesse de minage pendant {1} secondes.", LevelMechanics.energiDrinkChance, LevelMechanics.energiDrinkTime);
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Bevitore di Energia";
				this.talentDescString = string.Format("Ogni secondo hai il {0}% di probabilità di bere una bevanda energetica che raddoppia la tua velocità di scavo per {1} secondi.", LevelMechanics.energiDrinkChance, LevelMechanics.energiDrinkTime);
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Energie-Trinker";
				this.talentDescString = string.Format("Jede Sekunde hast du eine Chance von {0}%, einen Energydrink zu trinken, der deine Abbaugeschwindigkeit für {1} Sekunden verdoppelt.", LevelMechanics.energiDrinkChance, LevelMechanics.energiDrinkTime);
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Bebedor de Energía";
				this.talentDescString = string.Format("Cada segundo tienes un {0}% de probabilidad de beber una bebida energética, duplicando tu velocidad de minería durante {1} segundos.", LevelMechanics.energiDrinkChance, LevelMechanics.energiDrinkTime);
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "エナジードリンカー";
				this.talentDescString = string.Format("毎秒、{0}%の確率でエナジードリンクを飲み、{1}秒間採掘速度が2倍になる。", LevelMechanics.energiDrinkChance, LevelMechanics.energiDrinkTime);
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "에너지 드링커";
				this.talentDescString = string.Format("매초 {0}% 확률로 에너지 드링크를 마셔서 {1}초 동안 채굴 속도가 2배로 증가합니다.", LevelMechanics.energiDrinkChance, LevelMechanics.energiDrinkTime);
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Pijak Energii";
				this.talentDescString = string.Format("Co sekundę masz {0}% szansy na wypicie napoju energetycznego, co podwaja prędkość wydobycia na {1} sekund.", LevelMechanics.energiDrinkChance, LevelMechanics.energiDrinkTime);
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Bebedor de Energia";
				this.talentDescString = string.Format("A cada segundo, você tem {0}% de chance de beber um energético que dobra sua velocidade de mineração por {1} segundos.", LevelMechanics.energiDrinkChance, LevelMechanics.energiDrinkTime);
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Пьющий Энергетик";
				this.talentDescString = string.Format("Каждую секунду у вас есть {0}% шанс выпить энергетик, который удвоит скорость добычи на {1} секунд.", LevelMechanics.energiDrinkChance, LevelMechanics.energiDrinkTime);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "能量饮料狂人";
				this.talentDescString = string.Format("每秒有 {0}% 概率喝下能量饮料，采矿速度翻倍，持续 {1} 秒。", LevelMechanics.energiDrinkChance, LevelMechanics.energiDrinkTime);
			}
			this.card_energyDrinkerNAME.text = this.talentNameString;
			this.card_energyDrinker.text = this.talentDescString;
		}
		if (talentNumber == 18)
		{
			float num5 = LevelMechanics.flowerIncrease * 100f;
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Spring Season";
				this.talentDescString = "At the start of a mining session, 2–17 flowers will appear. Each flower provides a " + num5.ToString("F1") + "% XP increase.";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Saison du Printemps";
				this.talentDescString = "Au début d'une session de minage, 2 à 17 fleurs apparaissent. Chaque fleur augmente l'XP de " + num5.ToString("F1") + "% .";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Stagione di Primavera";
				this.talentDescString = "All'inizio di una sessione di scavo, appariranno da 2 a 17 fiori. Ogni fiore fornisce un aumento XP del " + num5.ToString("F1") + "% .";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Frühlingssaison";
				this.talentDescString = "Zu Beginn einer Abbau-Session erscheinen 2–17 Blumen. Jede Blume erhöht die XP um " + num5.ToString("F1") + "% .";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Temporada de Primavera";
				this.talentDescString = "Al inicio de una sesión de minería, aparecerán de 2 a 17 flores. Cada flor otorga un " + num5.ToString("F1") + "% más de XP.";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "春の季節";
				this.talentDescString = "採掘セッション開始時に2～17本の花が出現する。花1本ごとにXPが" + num5.ToString("F1") + "%増加する。";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "봄 시즌";
				this.talentDescString = "채굴 세션 시작 시 2~17개의 꽃이 나타납니다. 꽃 하나마다 XP가 " + num5.ToString("F1") + "% 증가합니다.";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Sezon Wiosenny";
				this.talentDescString = "Na początku sesji wydobycia pojawi się od 2 do 17 kwiatów. Każdy kwiat zwiększa XP o " + num5.ToString("F1") + "% .";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Estação da Primavera";
				this.talentDescString = "No início de uma sessão de mineração, aparecerão de 2 a 17 flores. Cada flor aumenta o XP em " + num5.ToString("F1") + "% .";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Весенний Сезон";
				this.talentDescString = "В начале сессии добычи появляется от 2 до 17 цветов. Каждый цветок увеличивает XP на " + num5.ToString("F1") + "% .";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "春季";
				this.talentDescString = "采矿开始时会出现 2–17 朵花。每朵花提供 " + num5.ToString("F1") + "% 的 XP 加成。";
			}
			this.card_springSeasonNAME.text = this.talentNameString;
			this.card_springSeason.text = this.talentDescString;
		}
		if (talentNumber == 19)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "Camper";
				this.talentDescString = "At the start of a mining session, a campfire will spawn. The fire insta mines rocks.";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "Campeur";
				this.talentDescString = "Au début d'une session de minage, un feu de camp apparaît. Le feu mine instantanément les roches.";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "Campeggiatore";
				this.talentDescString = "All'inizio di una sessione di scavo, compare un falò. Il fuoco estrae istantaneamente le rocce.";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "Camper";
				this.talentDescString = "Zu Beginn einer Abbau-Session erscheint ein Lagerfeuer. Das Feuer baut Steine sofort ab.";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "Campista";
				this.talentDescString = "Al inicio de una sesión de minería, aparece una fogata. El fuego mina rocas al instante.";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "キャンパー";
				this.talentDescString = "採掘セッション開始時に焚き火が出現する。火は岩を即座に採掘する。";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "캠퍼";
				this.talentDescString = "채굴 세션 시작 시 모닥불이 생성됩니다. 불은 바위를 즉시 채굴합니다.";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "Obozowicz";
				this.talentDescString = "Na początku sesji wydobycia pojawi się ognisko. Ogień natychmiast wydobywa skały.";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "Campista";
				this.talentDescString = "No início de uma sessão de mineração, surge uma fogueira. O fogo minera rochas instantaneamente.";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "Кемпер";
				this.talentDescString = "В начале сессии добычи появляется костёр. Огонь мгновенно добывает камни.";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "露营者";
				this.talentDescString = "采矿开始时会出现一个篝火。火焰会瞬间开采岩石。";
			}
			this.card_camperNAME.text = this.talentNameString;
			this.card_camper.text = this.talentDescString;
		}
		if (talentNumber == 20)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentNameString = "D100";
				this.talentDescString = "At the end of a mining session, a D100 will roll and if it hits 1, 10 or 100, all ores mined during that session are multiplied by 5X";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentNameString = "D100";
				this.talentDescString = "À la fin d'une session de minage, un D100 sera lancé. Si le résultat est 1, 10 ou 100, tous les minerais extraits pendant cette session seront multipliés par 5.";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentNameString = "D100";
				this.talentDescString = "Alla fine di una sessione di miniera, verrà lanciato un D100 e se esce 1, 10 o 100, tutti i minerali estratti durante quella sessione saranno moltiplicati per 5.";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentNameString = "D100";
				this.talentDescString = "Am Ende einer Minensitzung wird ein D100 geworfen. Bei einem Wurf von 1, 10 oder 100 werden alle in dieser Sitzung abgebauten Erze mit 5X multipliziert.";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentNameString = "D100";
				this.talentDescString = "Al final de una sesión de minería, se lanzará un D100 y si sale 1, 10 o 100, todos los minerales extraídos en esa sesión se multiplicarán por 5.";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentNameString = "D100";
				this.talentDescString = "採掘セッション終了時にD100が振られ、1、10、または100が出た場合、そのセッション中に採掘したすべての鉱石が5倍になります。";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentNameString = "D100";
				this.talentDescString = "채굴 세션이 끝날 때 D100을 굴리고, 1, 10 또는 100이 나오면 그 세션 동안 채굴한 모든 광물이 5배가 됩니다.";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentNameString = "D100";
				this.talentDescString = "Na koniec sesji wydobywczej rzucony zostanie D100. Jeśli wypadnie 1, 10 lub 100, wszystkie rudy wydobyte w tej sesji zostaną pomnożone razy 5.";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentNameString = "D100";
				this.talentDescString = "No final de uma sessão de mineração, um D100 será lançado e, se cair 1, 10 ou 100, todos os minérios extraídos nessa sessão serão multiplicados por 5.";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentNameString = "D100";
				this.talentDescString = "В конце сеанса добычи бросается D100. Если выпадает 1, 10 или 100, все добытые в этом сеансе руды умножаются на 5.";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentNameString = "D100";
				this.talentDescString = "在采矿会话结束时，掷一个D100，如果掷出1、10或100，该会话中获得的所有矿石将乘以5倍。";
			}
			this.card_d100NAME.text = this.talentNameString;
			this.card_d100.text = this.talentDescString;
		}
		this.talentName_tooltip.text = this.talentNameString;
		this.talentDesc_tooltip.text = this.talentDescString;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x0003C0EC File Offset: 0x0003A2EC
	public void TheMineTexts(bool isMineSpeed)
	{
		float miningTime = TheMine.miningTime;
		float num = TheMine.miningTime / 18f;
		float num2 = TheMine.miningTime - num;
		int barsMined = TheMine.barsMined;
		int num3 = TheMine.barsMined + TheMine.bersMinedIncrease;
		if (isMineSpeed)
		{
			if (LocalizationScript.isEnglish)
			{
				this.timeToMine.text = "Mining time: " + miningTime.ToString("F2") + " sec";
				this.timeToMineUpgraded.text = "Upgraded: " + num2.ToString("F2") + " sec";
			}
			if (LocalizationScript.isFrench)
			{
				this.timeToMine.text = "Temps de minage : " + miningTime.ToString("F2") + " sec";
				this.timeToMineUpgraded.text = "Amélioré : " + num2.ToString("F2") + " sec";
			}
			if (LocalizationScript.isItalian)
			{
				this.timeToMine.text = "Tempo di scavo: " + miningTime.ToString("F2") + " sec";
				this.timeToMineUpgraded.text = "Potenz.: " + num2.ToString("F2") + " sec";
			}
			if (LocalizationScript.isGerman)
			{
				this.timeToMine.text = "Abbauzeit: " + miningTime.ToString("F2") + " Sek.";
				this.timeToMineUpgraded.text = "Verbessert: " + num2.ToString("F2") + " Sek.";
			}
			if (LocalizationScript.isSpanish)
			{
				this.timeToMine.text = "Tiempo de minería: " + miningTime.ToString("F2") + " seg";
				this.timeToMineUpgraded.text = "Mejorado: " + num2.ToString("F2") + " seg";
			}
			if (LocalizationScript.isJapanese)
			{
				this.timeToMine.text = "採掘時間: " + miningTime.ToString("F2") + "秒";
				this.timeToMineUpgraded.text = "アップグレード: " + num2.ToString("F2") + "秒";
			}
			if (LocalizationScript.isKorean)
			{
				this.timeToMine.text = "채굴 시간: " + miningTime.ToString("F2") + "초";
				this.timeToMineUpgraded.text = "업그레이드됨: " + num2.ToString("F2") + "초";
			}
			if (LocalizationScript.isPolish)
			{
				this.timeToMine.text = "Czas wydobycia: " + miningTime.ToString("F2") + " sek";
				this.timeToMineUpgraded.text = "Ulepszone: " + num2.ToString("F2") + " sek";
			}
			if (LocalizationScript.isPortugese)
			{
				this.timeToMine.text = "Tempo de mineração: " + miningTime.ToString("F2") + " seg";
				this.timeToMineUpgraded.text = "Aprimorado: " + num2.ToString("F2") + " seg";
			}
			if (LocalizationScript.isRussian)
			{
				this.timeToMine.text = "Время добычи: " + miningTime.ToString("F2") + " сек";
				this.timeToMineUpgraded.text = "Улучшено: " + num2.ToString("F2") + " сек";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.timeToMine.text = "采矿时间：" + miningTime.ToString("F2") + " 秒";
				this.timeToMineUpgraded.text = "升级后：" + num2.ToString("F2") + " 秒";
				return;
			}
		}
		else
		{
			if (LocalizationScript.isEnglish)
			{
				this.materialsMined.text = string.Format("Bars mined: {0}", barsMined);
				this.materialsMinedUpgraded.text = string.Format("Upgraded: {0}", num3);
			}
			if (LocalizationScript.isFrench)
			{
				this.materialsMined.text = string.Format("Lingots minés : {0}", barsMined);
				this.materialsMinedUpgraded.text = string.Format("Amélioré : {0}", num3);
			}
			if (LocalizationScript.isItalian)
			{
				this.materialsMined.text = string.Format("Lingotti estratti: {0}", barsMined);
				this.materialsMinedUpgraded.text = string.Format("Potenziato: {0}", num3);
			}
			if (LocalizationScript.isGerman)
			{
				this.materialsMined.text = string.Format("Barren abgebaut: {0}", barsMined);
				this.materialsMinedUpgraded.text = string.Format("Verbessert: {0}", num3);
			}
			if (LocalizationScript.isSpanish)
			{
				this.materialsMined.text = string.Format("Lingotes minados: {0}", barsMined);
				this.materialsMinedUpgraded.text = string.Format("Mejorado: {0}", num3);
			}
			if (LocalizationScript.isJapanese)
			{
				this.materialsMined.text = string.Format("採掘バー数: {0}", barsMined);
				this.materialsMinedUpgraded.text = string.Format("アップグレード: {0}", num3);
			}
			if (LocalizationScript.isKorean)
			{
				this.materialsMined.text = string.Format("채굴된 바: {0}", barsMined);
				this.materialsMinedUpgraded.text = string.Format("업그레이드됨: {0}", num3);
			}
			if (LocalizationScript.isPolish)
			{
				this.materialsMined.text = string.Format("Wydobyte sztabki: {0}", barsMined);
				this.materialsMinedUpgraded.text = string.Format("Ulepszone: {0}", num3);
			}
			if (LocalizationScript.isPortugese)
			{
				this.materialsMined.text = string.Format("Barras mineradas: {0}", barsMined);
				this.materialsMinedUpgraded.text = string.Format("Aprimorado: {0}", num3);
			}
			if (LocalizationScript.isRussian)
			{
				this.materialsMined.text = string.Format("Добыто слитков: {0}", barsMined);
				this.materialsMinedUpgraded.text = string.Format("Улучшено: {0}", num3);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.materialsMined.text = string.Format("开采锭数：{0}", barsMined);
				this.materialsMinedUpgraded.text = string.Format("升级后：{0}", num3);
			}
		}
	}

	// Token: 0x06000138 RID: 312 RVA: 0x0003C76C File Offset: 0x0003A96C
	public void TalentCardsLeftText()
	{
		if (LevelMechanics.cardsLeft == 2)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentCardsLeftString = "There are only 2 more talent cards remaining!";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentCardsLeftString = "Il ne reste plus que 2 cartes de talent !";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentCardsLeftString = "Rimangono solo 2 carte talento!";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentCardsLeftString = "Es sind nur noch 2 Talentkarten übrig!";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentCardsLeftString = "¡Solo quedan 2 cartas de talento!";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentCardsLeftString = "残りのタレントカードはあと2枚です！";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentCardsLeftString = "남은 탈렌트 카드가 2장뿐입니다!";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentCardsLeftString = "Pozostały tylko 2 karty talentów!";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentCardsLeftString = "Restam apenas 2 cartas de talento!";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentCardsLeftString = "Осталось всего 2 карты талантов!";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentCardsLeftString = "只剩下 2 张天赋卡了！";
			}
		}
		if (LevelMechanics.cardsLeft == 1)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentCardsLeftString = "There is only 1 more talent card remaining!";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentCardsLeftString = "Il ne reste plus qu'une seule carte de talent !";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentCardsLeftString = "Rimane solo 1 carta talento!";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentCardsLeftString = "Es ist nur noch 1 Talentkarte übrig!";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentCardsLeftString = "¡Solo queda 1 carta de talento!";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentCardsLeftString = "残りのタレントカードはあと1枚です！";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentCardsLeftString = "남은 탈렌트 카드가 1장뿐입니다!";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentCardsLeftString = "Pozostała tylko 1 karta talentów!";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentCardsLeftString = "Resta apenas 1 carta de talento!";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentCardsLeftString = "Осталась всего 1 карта талантов!";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentCardsLeftString = "只剩下 1 张天赋卡了！";
			}
		}
		if (LevelMechanics.cardsLeft == 0)
		{
			if (LocalizationScript.isEnglish)
			{
				this.talentCardsLeftString = "You have chosen all the talent cards, no more remain!";
			}
			if (LocalizationScript.isFrench)
			{
				this.talentCardsLeftString = "Vous avez choisi toutes les cartes de talent, il n'en reste plus !";
			}
			if (LocalizationScript.isItalian)
			{
				this.talentCardsLeftString = "Hai scelto tutte le carte talento, non ne restano più!";
			}
			if (LocalizationScript.isGerman)
			{
				this.talentCardsLeftString = "Du hast alle Talentkarten gewählt, es bleiben keine mehr übrig!";
			}
			if (LocalizationScript.isSpanish)
			{
				this.talentCardsLeftString = "¡Has elegido todas las cartas de talento, no queda ninguna más!";
			}
			if (LocalizationScript.isJapanese)
			{
				this.talentCardsLeftString = "すべてのタレントカードを選びました。もう残っていません！";
			}
			if (LocalizationScript.isKorean)
			{
				this.talentCardsLeftString = "모든 탈렌트 카드를 선택했습니다. 더 이상 남지 않았습니다!";
			}
			if (LocalizationScript.isPolish)
			{
				this.talentCardsLeftString = "Wybrałeś wszystkie karty talentów, żadnych już nie ma!";
			}
			if (LocalizationScript.isPortugese)
			{
				this.talentCardsLeftString = "Você escolheu todas as cartas de talento, não resta mais nenhuma!";
			}
			if (LocalizationScript.isRussian)
			{
				this.talentCardsLeftString = "Вы выбрали все карты талантов, больше не осталось!";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.talentCardsLeftString = "你已选择了所有天赋卡，已无更多可选！";
			}
		}
		this.talentLeft1.text = this.talentCardsLeftString.ToString();
		this.talentLeft2.text = this.talentCardsLeftString.ToString();
		this.talentLeft3.text = this.talentCardsLeftString.ToString();
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0003CA2D File Offset: 0x0003AC2D
	private void OnApplicationQuit()
	{
	}

	// Token: 0x04000535 RID: 1333
	public LevelMechanics levelScript;

	// Token: 0x04000536 RID: 1334
	public TheAnvil theAnvilScript;

	// Token: 0x04000537 RID: 1335
	public static string languageName;

	// Token: 0x04000538 RID: 1336
	public TextMeshProUGUI skillTreeName_text;

	// Token: 0x04000539 RID: 1337
	public TextMeshProUGUI skillTreeDesc_text;

	// Token: 0x0400053A RID: 1338
	public TextMeshProUGUI skillTreePrice_text;

	// Token: 0x0400053B RID: 1339
	public TextMeshProUGUI skillTreePurchased_text;

	// Token: 0x0400053C RID: 1340
	public AudioManager audioManager;

	// Token: 0x0400053D RID: 1341
	public static bool isEnglish;

	// Token: 0x0400053E RID: 1342
	public static bool isFrench;

	// Token: 0x0400053F RID: 1343
	public static bool isItalian;

	// Token: 0x04000540 RID: 1344
	public static bool isGerman;

	// Token: 0x04000541 RID: 1345
	public static bool isSpanish;

	// Token: 0x04000542 RID: 1346
	public static bool isJapanese;

	// Token: 0x04000543 RID: 1347
	public static bool isKorean;

	// Token: 0x04000544 RID: 1348
	public static bool isPolish;

	// Token: 0x04000545 RID: 1349
	public static bool isPortugese;

	// Token: 0x04000546 RID: 1350
	public static bool isRussian;

	// Token: 0x04000547 RID: 1351
	public static bool isSimplefiedChinese;

	// Token: 0x04000548 RID: 1352
	public static int languageChosen;

	// Token: 0x04000549 RID: 1353
	public GameObject englishFlag;

	// Token: 0x0400054A RID: 1354
	public GameObject frenchFlag;

	// Token: 0x0400054B RID: 1355
	public GameObject italianFlag;

	// Token: 0x0400054C RID: 1356
	public GameObject germanFlag;

	// Token: 0x0400054D RID: 1357
	public GameObject spanishFlag;

	// Token: 0x0400054E RID: 1358
	public GameObject japaneseFlag;

	// Token: 0x0400054F RID: 1359
	public GameObject koreanFlag;

	// Token: 0x04000550 RID: 1360
	public GameObject polishFlag;

	// Token: 0x04000551 RID: 1361
	public GameObject portugeseFlag;

	// Token: 0x04000552 RID: 1362
	public GameObject russianFlag;

	// Token: 0x04000553 RID: 1363
	public GameObject simplefiedChineseFlag;

	// Token: 0x04000554 RID: 1364
	public static double currentHoverPrice;

	// Token: 0x04000555 RID: 1365
	public static int currentPurchaseCount;

	// Token: 0x04000556 RID: 1366
	public static int currentTotalPurchaseCount;

	// Token: 0x04000557 RID: 1367
	public static string pickaxe1_name;

	// Token: 0x04000558 RID: 1368
	public static string pickaxe2_name;

	// Token: 0x04000559 RID: 1369
	public static string pickaxe3_name;

	// Token: 0x0400055A RID: 1370
	public static string pickaxe4_name;

	// Token: 0x0400055B RID: 1371
	public static string pickaxe5_name;

	// Token: 0x0400055C RID: 1372
	public static string pickaxe6_name;

	// Token: 0x0400055D RID: 1373
	public static string pickaxe7_name;

	// Token: 0x0400055E RID: 1374
	public static string pickaxe8_name;

	// Token: 0x0400055F RID: 1375
	public static string pickaxe9_name;

	// Token: 0x04000560 RID: 1376
	public static string pickaxe10_name;

	// Token: 0x04000561 RID: 1377
	public static string pickaxe11_name;

	// Token: 0x04000562 RID: 1378
	public static string pickaxe12_name;

	// Token: 0x04000563 RID: 1379
	public static string pickaxe13_name;

	// Token: 0x04000564 RID: 1380
	public static string pickaxe14_name;

	// Token: 0x04000565 RID: 1381
	public static string rolled;

	// Token: 0x04000566 RID: 1382
	public static string oresTripled;

	// Token: 0x04000567 RID: 1383
	public static string price;

	// Token: 0x04000568 RID: 1384
	public static string talentLevel;

	// Token: 0x04000569 RID: 1385
	public static string durability;

	// Token: 0x0400056A RID: 1386
	public static string levelUp;

	// Token: 0x0400056B RID: 1387
	public static string skin;

	// Token: 0x0400056C RID: 1388
	public static string artifactFound;

	// Token: 0x0400056D RID: 1389
	public static string horn;

	// Token: 0x0400056E RID: 1390
	public static string device;

	// Token: 0x0400056F RID: 1391
	public static string bone;

	// Token: 0x04000570 RID: 1392
	public static string meteorite;

	// Token: 0x04000571 RID: 1393
	public static string book;

	// Token: 0x04000572 RID: 1394
	public static string sack;

	// Token: 0x04000573 RID: 1395
	public static string goldRing;

	// Token: 0x04000574 RID: 1396
	public static string royalRing;

	// Token: 0x04000575 RID: 1397
	public static string dice;

	// Token: 0x04000576 RID: 1398
	public static string cheese;

	// Token: 0x04000577 RID: 1399
	public static string wolf;

	// Token: 0x04000578 RID: 1400
	public static string axe;

	// Token: 0x04000579 RID: 1401
	public static string runestone;

	// Token: 0x0400057A RID: 1402
	public static string skull;

	// Token: 0x0400057B RID: 1403
	public static string crafting;

	// Token: 0x0400057C RID: 1404
	public TextMeshProUGUI cost;

	// Token: 0x0400057D RID: 1405
	public TextMeshProUGUI artifactBuffTooltip;

	// Token: 0x0400057E RID: 1406
	public static string closeString;

	// Token: 0x0400057F RID: 1407
	public TextMeshProUGUI purchaseText;

	// Token: 0x04000580 RID: 1408
	public TextMeshProUGUI skillTreeClose;

	// Token: 0x04000581 RID: 1409
	public TextMeshProUGUI talentClose;

	// Token: 0x04000582 RID: 1410
	public TextMeshProUGUI talentLevelClose;

	// Token: 0x04000583 RID: 1411
	public TextMeshProUGUI theMineInfoClose;

	// Token: 0x04000584 RID: 1412
	public TextMeshProUGUI artifactClose;

	// Token: 0x04000585 RID: 1413
	public TextMeshProUGUI tooltipAnim;

	// Token: 0x04000586 RID: 1414
	public TextMeshProUGUI off;

	// Token: 0x04000587 RID: 1415
	public TextMeshProUGUI on;

	// Token: 0x04000588 RID: 1416
	public static string holdToCraft;

	// Token: 0x04000589 RID: 1417
	public static string clickToEquip;

	// Token: 0x0400058A RID: 1418
	public static string yes;

	// Token: 0x0400058B RID: 1419
	public static string no;

	// Token: 0x0400058C RID: 1420
	public TextMeshProUGUI mainMenu;

	// Token: 0x0400058D RID: 1421
	public TextMeshProUGUI exitGame;

	// Token: 0x0400058E RID: 1422
	public TextMeshProUGUI fullscreen;

	// Token: 0x0400058F RID: 1423
	public TextMeshProUGUI resetGame;

	// Token: 0x04000590 RID: 1424
	public TextMeshProUGUI areYouSureText;

	// Token: 0x04000591 RID: 1425
	public TextMeshProUGUI thisIsNotText;

	// Token: 0x04000592 RID: 1426
	public TextMeshProUGUI pressYesText;

	// Token: 0x04000593 RID: 1427
	public TextMeshProUGUI resetYes;

	// Token: 0x04000594 RID: 1428
	public TextMeshProUGUI resetNo;

	// Token: 0x04000595 RID: 1429
	public TextMeshProUGUI mineTheBigRock;

	// Token: 0x04000596 RID: 1430
	public TextMeshProUGUI keepOnMining_MainMenu;

	// Token: 0x04000597 RID: 1431
	public TextMeshProUGUI revealTalentCards;

	// Token: 0x04000598 RID: 1432
	public TextMeshProUGUI choose1;

	// Token: 0x04000599 RID: 1433
	public TextMeshProUGUI allCardsChosen;

	// Token: 0x0400059A RID: 1434
	public TextMeshProUGUI equipped;

	// Token: 0x0400059B RID: 1435
	public TextMeshProUGUI mineTime1;

	// Token: 0x0400059C RID: 1436
	public TextMeshProUGUI mineTime2;

	// Token: 0x0400059D RID: 1437
	public TextMeshProUGUI minePower1;

	// Token: 0x0400059E RID: 1438
	public TextMeshProUGUI minePower2;

	// Token: 0x0400059F RID: 1439
	public TextMeshProUGUI mine2X1;

	// Token: 0x040005A0 RID: 1440
	public TextMeshProUGUI mine2X2;

	// Token: 0x040005A1 RID: 1441
	public TextMeshProUGUI mineSize1;

	// Token: 0x040005A2 RID: 1442
	public TextMeshProUGUI mineSize2;

	// Token: 0x040005A3 RID: 1443
	public TextMeshProUGUI unlockTheMine;

	// Token: 0x040005A4 RID: 1444
	public TextMeshProUGUI playText;

	// Token: 0x040005A5 RID: 1445
	public TextMeshProUGUI settingsText;

	// Token: 0x040005A6 RID: 1446
	public TextMeshProUGUI creditsText;

	// Token: 0x040005A7 RID: 1447
	public TextMeshProUGUI exitGameText;

	// Token: 0x040005A8 RID: 1448
	public static string musicCreditName1;

	// Token: 0x040005A9 RID: 1449
	public TextMeshProUGUI credits;

	// Token: 0x040005AA RID: 1450
	public TextMeshProUGUI gameBy;

	// Token: 0x040005AB RID: 1451
	public TextMeshProUGUI musicBy;

	// Token: 0x040005AC RID: 1452
	public TextMeshProUGUI customArtBy;

	// Token: 0x040005AD RID: 1453
	public TextMeshProUGUI skillTree;

	// Token: 0x040005AE RID: 1454
	public TextMeshProUGUI talents;

	// Token: 0x040005AF RID: 1455
	public TextMeshProUGUI theAnvil;

	// Token: 0x040005B0 RID: 1456
	public TextMeshProUGUI theMine;

	// Token: 0x040005B1 RID: 1457
	public TextMeshProUGUI artifacts;

	// Token: 0x040005B2 RID: 1458
	public TextMeshProUGUI endSession;

	// Token: 0x040005B3 RID: 1459
	public TextMeshProUGUI miningSessionDone;

	// Token: 0x040005B4 RID: 1460
	public TextMeshProUGUI oresGathered;

	// Token: 0x040005B5 RID: 1461
	public TextMeshProUGUI barsCrafted;

	// Token: 0x040005B6 RID: 1462
	public TextMeshProUGUI totalBars;

	// Token: 0x040005B7 RID: 1463
	public TextMeshProUGUI xpGathered;

	// Token: 0x040005B8 RID: 1464
	public TextMeshProUGUI levelUpSessionDone;

	// Token: 0x040005B9 RID: 1465
	public TextMeshProUGUI upgrade;

	// Token: 0x040005BA RID: 1466
	public TextMeshProUGUI keepOnMining_endFrame;

	// Token: 0x040005BB RID: 1467
	public static string startMining;

	// Token: 0x040005BC RID: 1468
	public static string outOfTime;

	// Token: 0x040005BD RID: 1469
	public TextMeshProUGUI coolText;

	// Token: 0x040005BE RID: 1470
	public TextMeshProUGUI theMineTooltipText;

	// Token: 0x040005BF RID: 1471
	public TextMeshProUGUI COMPLETION;

	// Token: 0x040005C0 RID: 1472
	public TextMeshProUGUI allSkillTree;

	// Token: 0x040005C1 RID: 1473
	public TextMeshProUGUI byHaving;

	// Token: 0x040005C2 RID: 1474
	public TextMeshProUGUI theseUpgrades;

	// Token: 0x040005C3 RID: 1475
	public TextMeshProUGUI theseUpgradesCanBe;

	// Token: 0x040005C4 RID: 1476
	public TextMeshProUGUI ok_EndlessOpoUP;

	// Token: 0x040005C5 RID: 1477
	public TextMeshProUGUI oreAndBars;

	// Token: 0x040005C6 RID: 1478
	public TextMeshProUGUI youWill;

	// Token: 0x040005C7 RID: 1479
	public TextMeshProUGUI thereAre;

	// Token: 0x040005C8 RID: 1480
	public TextMeshProUGUI normalRocks;

	// Token: 0x040005C9 RID: 1481
	public TextMeshProUGUI oresWillBe;

	// Token: 0x040005CA RID: 1482
	public static string ok;

	// Token: 0x040005CB RID: 1483
	public TextMeshProUGUI welcomeTo;

	// Token: 0x040005CC RID: 1484
	public TextMeshProUGUI theGameIsSimple;

	// Token: 0x040005CD RID: 1485
	public TextMeshProUGUI aCircle;

	// Token: 0x040005CE RID: 1486
	public TextMeshProUGUI onceThe;

	// Token: 0x040005CF RID: 1487
	public TextMeshProUGUI levelAndTalent;

	// Token: 0x040005D0 RID: 1488
	public TextMeshProUGUI everyMined;

	// Token: 0x040005D1 RID: 1489
	public TextMeshProUGUI youWillReceive;

	// Token: 0x040005D2 RID: 1490
	public TextMeshProUGUI youCanSpend;

	// Token: 0x040005D3 RID: 1491
	public TextMeshProUGUI talentCardsProvide;

	// Token: 0x040005D4 RID: 1492
	public TextMeshProUGUI theAnvilTut;

	// Token: 0x040005D5 RID: 1493
	public TextMeshProUGUI hereYouCan;

	// Token: 0x040005D6 RID: 1494
	public TextMeshProUGUI eachPickaxe;

	// Token: 0x040005D7 RID: 1495
	public TextMeshProUGUI eachNew;

	// Token: 0x040005D8 RID: 1496
	public TextMeshProUGUI theMineTut;

	// Token: 0x040005D9 RID: 1497
	public TextMeshProUGUI onceYouHave;

	// Token: 0x040005DA RID: 1498
	public TextMeshProUGUI theMineWill;

	// Token: 0x040005DB RID: 1499
	public TextMeshProUGUI thePercentage;

	// Token: 0x040005DC RID: 1500
	public TextMeshProUGUI artifactsTut;

	// Token: 0x040005DD RID: 1501
	public TextMeshProUGUI hereYouCanView;

	// Token: 0x040005DE RID: 1502
	public TextMeshProUGUI artifactsHave;

	// Token: 0x040005DF RID: 1503
	public TextMeshProUGUI everyArtifact;

	// Token: 0x040005E0 RID: 1504
	public TextMeshProUGUI ok_materialOres;

	// Token: 0x040005E1 RID: 1505
	public TextMeshProUGUI okWelcomeTo;

	// Token: 0x040005E2 RID: 1506
	public TextMeshProUGUI okTalent;

	// Token: 0x040005E3 RID: 1507
	public TextMeshProUGUI okTheAnvil;

	// Token: 0x040005E4 RID: 1508
	public TextMeshProUGUI okTheMine;

	// Token: 0x040005E5 RID: 1509
	public TextMeshProUGUI okArtifacts;

	// Token: 0x040005E6 RID: 1510
	public TextMeshProUGUI craftPickaxe;

	// Token: 0x040005E7 RID: 1511
	public TextMeshProUGUI youCraftedDiamond;

	// Token: 0x040005E8 RID: 1512
	public TextMeshProUGUI thankYOuForPlaying;

	// Token: 0x040005E9 RID: 1513
	public TextMeshProUGUI developedByEnd;

	// Token: 0x040005EA RID: 1514
	public TextMeshProUGUI musicByEnd;

	// Token: 0x040005EB RID: 1515
	public TextMeshProUGUI customArtByEnd;

	// Token: 0x040005EC RID: 1516
	public TextMeshProUGUI againThankYou;

	// Token: 0x040005ED RID: 1517
	public TextMeshProUGUI aSteamReview;

	// Token: 0x040005EE RID: 1518
	public TextMeshProUGUI alsoJoin;

	// Token: 0x040005EF RID: 1519
	public TextMeshProUGUI whatWouldDoNext;

	// Token: 0x040005F0 RID: 1520
	public TextMeshProUGUI exitGameCredits;

	// Token: 0x040005F1 RID: 1521
	public TextMeshProUGUI keepOnMiningCredits;

	// Token: 0x040005F2 RID: 1522
	public TextMeshProUGUI potionsDrank;

	// Token: 0x040005F3 RID: 1523
	public TextMeshProUGUI chestsOpened;

	// Token: 0x040005F4 RID: 1524
	public TextMeshProUGUI goldenChestsOpened;

	// Token: 0x040005F5 RID: 1525
	public TextMeshProUGUI theMine2XTriggered;

	// Token: 0x040005F6 RID: 1526
	public TextMeshProUGUI theMineDoubleTriggered;

	// Token: 0x040005F7 RID: 1527
	public TextMeshProUGUI inflateBurstTriggered;

	// Token: 0x040005F8 RID: 1528
	public TextMeshProUGUI hammersSpawned;

	// Token: 0x040005F9 RID: 1529
	public TextMeshProUGUI midasTouchSessions;

	// Token: 0x040005FA RID: 1530
	public TextMeshProUGUI zeusTriggers;

	// Token: 0x040005FB RID: 1531
	public TextMeshProUGUI energiDrinksDrank;

	// Token: 0x040005FC RID: 1532
	public TextMeshProUGUI flowersSpawned;

	// Token: 0x040005FD RID: 1533
	public TextMeshProUGUI campfiresSpawned;

	// Token: 0x040005FE RID: 1534
	public TextMeshProUGUI d100Rolls;

	// Token: 0x040005FF RID: 1535
	public TextMeshProUGUI miningSessions;

	// Token: 0x04000600 RID: 1536
	public TextMeshProUGUI timeSpentMining;

	// Token: 0x04000601 RID: 1537
	public TextMeshProUGUI totalRocksSpawned;

	// Token: 0x04000602 RID: 1538
	public TextMeshProUGUI totalRocksMined;

	// Token: 0x04000603 RID: 1539
	public TextMeshProUGUI pickaxeSpawned;

	// Token: 0x04000604 RID: 1540
	public TextMeshProUGUI pickaxeHits;

	// Token: 0x04000605 RID: 1541
	public TextMeshProUGUI oresMined;

	// Token: 0x04000606 RID: 1542
	public TextMeshProUGUI barsBrafted;

	// Token: 0x04000607 RID: 1543
	public TextMeshProUGUI bardMinedTheMine;

	// Token: 0x04000608 RID: 1544
	public TextMeshProUGUI xpGained;

	// Token: 0x04000609 RID: 1545
	public TextMeshProUGUI totalLevelUps;

	// Token: 0x0400060A RID: 1546
	public TextMeshProUGUI doubleOredGained;

	// Token: 0x0400060B RID: 1547
	public TextMeshProUGUI doubleXpGained;

	// Token: 0x0400060C RID: 1548
	public TextMeshProUGUI X2pickaxePowerHits;

	// Token: 0x0400060D RID: 1549
	public TextMeshProUGUI instaMineHits;

	// Token: 0x0400060E RID: 1550
	public TextMeshProUGUI lightningStrikes;

	// Token: 0x0400060F RID: 1551
	public TextMeshProUGUI dynamiteExplosions;

	// Token: 0x04000610 RID: 1552
	public TextMeshProUGUI plazmaBallsSpawned;

	// Token: 0x04000611 RID: 1553
	public TextMeshProUGUI goldChunkRocks;

	// Token: 0x04000612 RID: 1554
	public TextMeshProUGUI fullGoldRocks;

	// Token: 0x04000613 RID: 1555
	public TextMeshProUGUI copperChunkMined;

	// Token: 0x04000614 RID: 1556
	public TextMeshProUGUI fullCopperMined;

	// Token: 0x04000615 RID: 1557
	public TextMeshProUGUI ironChunkMined;

	// Token: 0x04000616 RID: 1558
	public TextMeshProUGUI fullIronMined;

	// Token: 0x04000617 RID: 1559
	public TextMeshProUGUI cobaltChunkMined;

	// Token: 0x04000618 RID: 1560
	public TextMeshProUGUI fullCobaltMined;

	// Token: 0x04000619 RID: 1561
	public TextMeshProUGUI uraniumChunkMined;

	// Token: 0x0400061A RID: 1562
	public TextMeshProUGUI fullUraniumMined;

	// Token: 0x0400061B RID: 1563
	public TextMeshProUGUI ismiumChunkMined;

	// Token: 0x0400061C RID: 1564
	public TextMeshProUGUI fullIsmiumMined;

	// Token: 0x0400061D RID: 1565
	public TextMeshProUGUI iridiumChunkMined;

	// Token: 0x0400061E RID: 1566
	public TextMeshProUGUI fullIridiumMined;

	// Token: 0x0400061F RID: 1567
	public TextMeshProUGUI painiteChunkMined;

	// Token: 0x04000620 RID: 1568
	public TextMeshProUGUI fullPainiteMined;

	// Token: 0x04000621 RID: 1569
	public TextMeshProUGUI talentStats;

	// Token: 0x04000622 RID: 1570
	public TextMeshProUGUI globalStats;

	// Token: 0x04000623 RID: 1571
	public TextMeshProUGUI rocksMinedStats;

	// Token: 0x04000624 RID: 1572
	public static int rockSpawnIncrease;

	// Token: 0x04000625 RID: 1573
	public static float xpIncrease;

	// Token: 0x04000626 RID: 1574
	public static int moreTalentPointsReduce;

	// Token: 0x04000627 RID: 1575
	public static float goldRockChanceIncrease;

	// Token: 0x04000628 RID: 1576
	public static float fullGoldRockChanceIncrease;

	// Token: 0x04000629 RID: 1577
	public static float copperRockChanceIncrease;

	// Token: 0x0400062A RID: 1578
	public static float fullCopperRockChanceIncrease;

	// Token: 0x0400062B RID: 1579
	public static float ironRockChanceIncrease;

	// Token: 0x0400062C RID: 1580
	public static float fullIronRockChanceIncrease;

	// Token: 0x0400062D RID: 1581
	public static float cobaltRockChanceIncrease;

	// Token: 0x0400062E RID: 1582
	public static float fullCobaltRockChanceIncrease;

	// Token: 0x0400062F RID: 1583
	public static float uraniumRockChanceIncrease;

	// Token: 0x04000630 RID: 1584
	public static float fullUraniumRockChanceIncrease;

	// Token: 0x04000631 RID: 1585
	public static float ismiumRockChanceIncrease;

	// Token: 0x04000632 RID: 1586
	public static float fullIsmiumRockChanceIncrease;

	// Token: 0x04000633 RID: 1587
	public static float iridiumRockChanceIncrease;

	// Token: 0x04000634 RID: 1588
	public static float fullIridiumRockChanceIncrease;

	// Token: 0x04000635 RID: 1589
	public static float painiteRockChanceIncrease;

	// Token: 0x04000636 RID: 1590
	public static float fullPainiteRockChanceIncrease;

	// Token: 0x04000637 RID: 1591
	public static float improvedPickaxeIncrease;

	// Token: 0x04000638 RID: 1592
	public static float miningAreaIncrease;

	// Token: 0x04000639 RID: 1593
	public static float spawnEveryRockIncrease;

	// Token: 0x0400063A RID: 1594
	public static float spawnEverySecondIncrease;

	// Token: 0x0400063B RID: 1595
	public static float spawnWhenMinedIncrease;

	// Token: 0x0400063C RID: 1596
	public static int materialsFromChunkRocksIncrease;

	// Token: 0x0400063D RID: 1597
	public static int materialsFromFullRocksIncrease;

	// Token: 0x0400063E RID: 1598
	public static float materialsWorthIncrease;

	// Token: 0x0400063F RID: 1599
	public static float chanceToMineRandomRockIncrease;

	// Token: 0x04000640 RID: 1600
	public static float spawnPickaxeEverySecondIncrease;

	// Token: 0x04000641 RID: 1601
	public static int moreTimeIncrease;

	// Token: 0x04000642 RID: 1602
	public static float doubleXpAndGoldChanceIncrease;

	// Token: 0x04000643 RID: 1603
	public static float lightningTriggerChanceS_Increase;

	// Token: 0x04000644 RID: 1604
	public static float lightningTriggerChancePH_Increase;

	// Token: 0x04000645 RID: 1605
	public static float lightningDamageIncrease;

	// Token: 0x04000646 RID: 1606
	public static float lightningSizeIncrease;

	// Token: 0x04000647 RID: 1607
	public static float dynamiteStickChanceIncrease;

	// Token: 0x04000648 RID: 1608
	public static float explosionSizeIncrease;

	// Token: 0x04000649 RID: 1609
	public static float explosionDamagageIncrease;

	// Token: 0x0400064A RID: 1610
	public static float plazmaBallChanceIncrease;

	// Token: 0x0400064B RID: 1611
	public static float plazmaBallTimerIncrease;

	// Token: 0x0400064C RID: 1612
	public static float plazmaBallTotalSizeIncrease;

	// Token: 0x0400064D RID: 1613
	public static float plazmaBallTotalDamageIncrease;

	// Token: 0x0400064E RID: 1614
	public static float doubleDamageChanceIncrease;

	// Token: 0x0400064F RID: 1615
	public static float instaMineChanceIncrease;

	// Token: 0x04000650 RID: 1616
	public static double currentSkillTreePrice;

	// Token: 0x04000651 RID: 1617
	public string artifactTooltipName;

	// Token: 0x04000652 RID: 1618
	public string artifactDescName;

	// Token: 0x04000653 RID: 1619
	public TextMeshProUGUI artifactName_text;

	// Token: 0x04000654 RID: 1620
	public TextMeshProUGUI artifactDesc_text;

	// Token: 0x04000655 RID: 1621
	public GameObject horn_tooltipImage;

	// Token: 0x04000656 RID: 1622
	public GameObject ancientDevice_tooltipImage;

	// Token: 0x04000657 RID: 1623
	public GameObject bone_tooltipImage;

	// Token: 0x04000658 RID: 1624
	public GameObject meteorieOre_tooltipImage;

	// Token: 0x04000659 RID: 1625
	public GameObject book_tooltipImage;

	// Token: 0x0400065A RID: 1626
	public GameObject goldStack_tooltipImage;

	// Token: 0x0400065B RID: 1627
	public GameObject goldRing_tooltipImage;

	// Token: 0x0400065C RID: 1628
	public GameObject purpleRing_tooltipImage;

	// Token: 0x0400065D RID: 1629
	public GameObject ancientDice_tooltipImage;

	// Token: 0x0400065E RID: 1630
	public GameObject cheese_tooltipImage;

	// Token: 0x0400065F RID: 1631
	public GameObject wolfClaw_tooltipImage;

	// Token: 0x04000660 RID: 1632
	public GameObject axe_tooltipImage;

	// Token: 0x04000661 RID: 1633
	public GameObject rune_tooltipImage;

	// Token: 0x04000662 RID: 1634
	public GameObject skull_tooltipImage;

	// Token: 0x04000663 RID: 1635
	public TextMeshProUGUI potionTooltipName;

	// Token: 0x04000664 RID: 1636
	public TextMeshProUGUI potionTooltipDesc;

	// Token: 0x04000665 RID: 1637
	public string talentNameString;

	// Token: 0x04000666 RID: 1638
	public string talentDescString;

	// Token: 0x04000667 RID: 1639
	public TextMeshProUGUI talentName_tooltip;

	// Token: 0x04000668 RID: 1640
	public TextMeshProUGUI talentDesc_tooltip;

	// Token: 0x04000669 RID: 1641
	public TextMeshProUGUI card_potionDrinker;

	// Token: 0x0400066A RID: 1642
	public TextMeshProUGUI card_potionDrinkerNAME;

	// Token: 0x0400066B RID: 1643
	public TextMeshProUGUI card_potionChugger;

	// Token: 0x0400066C RID: 1644
	public TextMeshProUGUI card_potionChuggerNAME;

	// Token: 0x0400066D RID: 1645
	public TextMeshProUGUI card_chests;

	// Token: 0x0400066E RID: 1646
	public TextMeshProUGUI card_chestsNAME;

	// Token: 0x0400066F RID: 1647
	public TextMeshProUGUI card_goldenChests;

	// Token: 0x04000670 RID: 1648
	public TextMeshProUGUI card_goldenChestsNAME;

	// Token: 0x04000671 RID: 1649
	public TextMeshProUGUI card_skilledMiners;

	// Token: 0x04000672 RID: 1650
	public TextMeshProUGUI card_skilledMinersNAME;

	// Token: 0x04000673 RID: 1651
	public TextMeshProUGUI card_itsASign;

	// Token: 0x04000674 RID: 1652
	public TextMeshProUGUI card_itsASignNAME;

	// Token: 0x04000675 RID: 1653
	public TextMeshProUGUI card_efficientBlacksmith;

	// Token: 0x04000676 RID: 1654
	public TextMeshProUGUI card_efficientBlacksmithNAME;

	// Token: 0x04000677 RID: 1655
	public TextMeshProUGUI card_steamSale;

	// Token: 0x04000678 RID: 1656
	public TextMeshProUGUI card_steamSaleNAME;

	// Token: 0x04000679 RID: 1657
	public TextMeshProUGUI card_inflationBurst;

	// Token: 0x0400067A RID: 1658
	public TextMeshProUGUI card_inflationBurstNAME;

	// Token: 0x0400067B RID: 1659
	public TextMeshProUGUI card_itsHammerTime;

	// Token: 0x0400067C RID: 1660
	public TextMeshProUGUI card_itsHammerTimeNAME;

	// Token: 0x0400067D RID: 1661
	public TextMeshProUGUI card_midasTouch;

	// Token: 0x0400067E RID: 1662
	public TextMeshProUGUI card_midasTouchNAME;

	// Token: 0x0400067F RID: 1663
	public TextMeshProUGUI card_zeusWrath;

	// Token: 0x04000680 RID: 1664
	public TextMeshProUGUI card_zeusWrathNAME;

	// Token: 0x04000681 RID: 1665
	public TextMeshProUGUI card_shapeShifter;

	// Token: 0x04000682 RID: 1666
	public TextMeshProUGUI card_shapeShifterNAME;

	// Token: 0x04000683 RID: 1667
	public TextMeshProUGUI card_xMarksTheSpot;

	// Token: 0x04000684 RID: 1668
	public TextMeshProUGUI card_xMarksTheSpotNAME;

	// Token: 0x04000685 RID: 1669
	public TextMeshProUGUI card_explorer;

	// Token: 0x04000686 RID: 1670
	public TextMeshProUGUI card_explorerNAME;

	// Token: 0x04000687 RID: 1671
	public TextMeshProUGUI card_archaeologist;

	// Token: 0x04000688 RID: 1672
	public TextMeshProUGUI card_archaeologistNAME;

	// Token: 0x04000689 RID: 1673
	public TextMeshProUGUI card_energyDrinker;

	// Token: 0x0400068A RID: 1674
	public TextMeshProUGUI card_energyDrinkerNAME;

	// Token: 0x0400068B RID: 1675
	public TextMeshProUGUI card_springSeason;

	// Token: 0x0400068C RID: 1676
	public TextMeshProUGUI card_springSeasonNAME;

	// Token: 0x0400068D RID: 1677
	public TextMeshProUGUI card_camper;

	// Token: 0x0400068E RID: 1678
	public TextMeshProUGUI card_camperNAME;

	// Token: 0x0400068F RID: 1679
	public TextMeshProUGUI card_d100;

	// Token: 0x04000690 RID: 1680
	public TextMeshProUGUI card_d100NAME;

	// Token: 0x04000691 RID: 1681
	public TextMeshProUGUI timeToMine;

	// Token: 0x04000692 RID: 1682
	public TextMeshProUGUI timeToMineUpgraded;

	// Token: 0x04000693 RID: 1683
	public TextMeshProUGUI materialsMined;

	// Token: 0x04000694 RID: 1684
	public TextMeshProUGUI materialsMinedUpgraded;

	// Token: 0x04000695 RID: 1685
	public string talentCardsLeftString;

	// Token: 0x04000696 RID: 1686
	public TextMeshProUGUI talentLeft1;

	// Token: 0x04000697 RID: 1687
	public TextMeshProUGUI talentLeft2;

	// Token: 0x04000698 RID: 1688
	public TextMeshProUGUI talentLeft3;
}
