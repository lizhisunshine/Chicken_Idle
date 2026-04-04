using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200001C RID: 28
public class TheAnvil : MonoBehaviour, IDataPersistence
{
	// Token: 0x06000098 RID: 152 RVA: 0x00009238 File Offset: 0x00007438
	private void Awake()
	{
		TheAnvil.isDLC = true;
		if (TheAnvil.isDLC)
		{
			this.skinLeftBTN.SetActive(true);
			this.skinRightBTN.SetActive(true);
			this.skinText.gameObject.SetActive(true);
			this.allSkinsFrame.transform.localPosition = new Vector2(0f, -7f);
			return;
		}
		this.SetSkinsOff(true);
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000092A8 File Offset: 0x000074A8
	public void SetSkinsOff(bool all)
	{
		if (all)
		{
			this.pickaxe1_skins[0].SetActive(false);
			this.pickaxe1_skins[1].SetActive(false);
			this.pickaxe1_skins[2].SetActive(false);
			this.pickaxe2_skins[0].SetActive(false);
			this.pickaxe2_skins[1].SetActive(false);
			this.pickaxe2_skins[2].SetActive(false);
			this.pickaxe3_skins[0].SetActive(false);
			this.pickaxe3_skins[1].SetActive(false);
			this.pickaxe3_skins[2].SetActive(false);
			this.pickaxe4_skins[0].SetActive(false);
			this.pickaxe4_skins[1].SetActive(false);
			this.pickaxe4_skins[2].SetActive(false);
			this.pickaxe5_skins[0].SetActive(false);
			this.pickaxe5_skins[1].SetActive(false);
			this.pickaxe5_skins[2].SetActive(false);
			this.pickaxe6_skins[0].SetActive(false);
			this.pickaxe6_skins[1].SetActive(false);
			this.pickaxe6_skins[2].SetActive(false);
			this.pickaxe7_skins[0].SetActive(false);
			this.pickaxe7_skins[1].SetActive(false);
			this.pickaxe7_skins[2].SetActive(false);
			this.pickaxe8_skins[0].SetActive(false);
			this.pickaxe8_skins[1].SetActive(false);
			this.pickaxe8_skins[2].SetActive(false);
			this.pickaxe9_skins[0].SetActive(false);
			this.pickaxe9_skins[1].SetActive(false);
			this.pickaxe9_skins[2].SetActive(false);
			this.pickaxe10_skins[0].SetActive(false);
			this.pickaxe10_skins[1].SetActive(false);
			this.pickaxe10_skins[2].SetActive(false);
			this.pickaxe11_skins[0].SetActive(false);
			this.pickaxe11_skins[1].SetActive(false);
			this.pickaxe11_skins[2].SetActive(false);
			this.pickaxe12_skins[0].SetActive(false);
			this.pickaxe12_skins[1].SetActive(false);
			this.pickaxe12_skins[2].SetActive(false);
			this.pickaxe13_skins[0].SetActive(false);
			this.pickaxe13_skins[1].SetActive(false);
			this.pickaxe13_skins[2].SetActive(false);
		}
		else
		{
			this.pickaxe1_skins[1].SetActive(false);
			this.pickaxe1_skins[2].SetActive(false);
			this.pickaxe2_skins[1].SetActive(false);
			this.pickaxe2_skins[2].SetActive(false);
			this.pickaxe3_skins[1].SetActive(false);
			this.pickaxe3_skins[2].SetActive(false);
			this.pickaxe4_skins[1].SetActive(false);
			this.pickaxe4_skins[2].SetActive(false);
			this.pickaxe5_skins[1].SetActive(false);
			this.pickaxe5_skins[2].SetActive(false);
			this.pickaxe6_skins[1].SetActive(false);
			this.pickaxe6_skins[2].SetActive(false);
			this.pickaxe7_skins[1].SetActive(false);
			this.pickaxe7_skins[2].SetActive(false);
			this.pickaxe8_skins[1].SetActive(false);
			this.pickaxe8_skins[2].SetActive(false);
			this.pickaxe9_skins[1].SetActive(false);
			this.pickaxe9_skins[2].SetActive(false);
			this.pickaxe10_skins[1].SetActive(false);
			this.pickaxe10_skins[2].SetActive(false);
			this.pickaxe11_skins[1].SetActive(false);
			this.pickaxe11_skins[2].SetActive(false);
			this.pickaxe12_skins[1].SetActive(false);
			this.pickaxe12_skins[2].SetActive(false);
			this.pickaxe13_skins[1].SetActive(false);
			this.pickaxe13_skins[2].SetActive(false);
		}
		this.skinLeftBTN.SetActive(false);
		this.skinRightBTN.SetActive(false);
		this.skinText.gameObject.SetActive(false);
		this.allSkinsFrame.transform.localPosition = new Vector2(0f, 0f);
	}

	// Token: 0x0600009A RID: 154 RVA: 0x0000969C File Offset: 0x0000789C
	public void SelectSkins(bool right)
	{
		if (this.playSound)
		{
			this.audioManager.Play("UI_Click1");
		}
		if (TheAnvil.pickaxe1_equipped)
		{
			if (this.pickaxe1_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe1_skinsChosen = 0;
				return;
			}
			if (this.pickaxe1_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe1_skinsChosen = 1;
			}
			else if (this.pickaxe1_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe1_skinsChosen = 2;
			}
			else if (this.pickaxe1_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe1_skinsChosen = 0;
			}
			else if (this.pickaxe1_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe1_skinsChosen = 1;
			}
			else if (this.pickaxe1_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe1_skinsChosen = 2;
				return;
			}
		}
		if (TheAnvil.pickaxe2_equipped)
		{
			if (this.pickaxe2_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe2_skinsChosen = 0;
				return;
			}
			if (this.pickaxe2_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe2_skinsChosen = 1;
			}
			else if (this.pickaxe2_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe2_skinsChosen = 2;
			}
			else if (this.pickaxe2_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe2_skinsChosen = 0;
			}
			else if (this.pickaxe2_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe2_skinsChosen = 1;
			}
			else if (this.pickaxe2_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe2_skinsChosen = 2;
				return;
			}
		}
		if (TheAnvil.pickaxe3_equipped)
		{
			if (this.pickaxe3_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe3_skinsChosen = 0;
				return;
			}
			if (this.pickaxe3_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe3_skinsChosen = 1;
			}
			else if (this.pickaxe3_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe3_skinsChosen = 2;
			}
			else if (this.pickaxe3_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe3_skinsChosen = 0;
			}
			else if (this.pickaxe3_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe3_skinsChosen = 1;
			}
			else if (this.pickaxe3_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe3_skinsChosen = 2;
				return;
			}
		}
		if (TheAnvil.pickaxe4_equipped)
		{
			if (this.pickaxe4_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe4_skinsChosen = 0;
				return;
			}
			if (this.pickaxe4_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe4_skinsChosen = 1;
			}
			else if (this.pickaxe4_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe4_skinsChosen = 2;
			}
			else if (this.pickaxe4_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe4_skinsChosen = 0;
			}
			else if (this.pickaxe4_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe4_skinsChosen = 1;
			}
			else if (this.pickaxe4_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe4_skinsChosen = 2;
				return;
			}
		}
		if (TheAnvil.pickaxe5_equipped)
		{
			if (this.pickaxe5_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe5_skinsChosen = 0;
				return;
			}
			if (this.pickaxe5_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe5_skinsChosen = 1;
			}
			else if (this.pickaxe5_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe5_skinsChosen = 2;
			}
			else if (this.pickaxe5_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe5_skinsChosen = 0;
			}
			else if (this.pickaxe5_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe5_skinsChosen = 1;
			}
			else if (this.pickaxe5_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe5_skinsChosen = 2;
				return;
			}
		}
		if (TheAnvil.pickaxe6_equipped)
		{
			if (this.pickaxe6_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe6_skinsChosen = 0;
				return;
			}
			if (this.pickaxe6_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe6_skinsChosen = 1;
			}
			else if (this.pickaxe6_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe6_skinsChosen = 2;
			}
			else if (this.pickaxe6_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe6_skinsChosen = 0;
			}
			else if (this.pickaxe6_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe6_skinsChosen = 1;
			}
			else if (this.pickaxe6_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe6_skinsChosen = 2;
				return;
			}
		}
		if (TheAnvil.pickaxe7_equipped)
		{
			if (this.pickaxe7_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe7_skinsChosen = 0;
				return;
			}
			if (this.pickaxe7_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe7_skinsChosen = 1;
			}
			else if (this.pickaxe7_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe7_skinsChosen = 2;
			}
			else if (this.pickaxe7_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe7_skinsChosen = 0;
			}
			else if (this.pickaxe7_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe7_skinsChosen = 1;
			}
			else if (this.pickaxe7_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe7_skinsChosen = 2;
				return;
			}
		}
		if (TheAnvil.pickaxe8_equipped)
		{
			if (this.pickaxe8_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe8_skinsChosen = 0;
				return;
			}
			if (this.pickaxe8_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe8_skinsChosen = 1;
			}
			else if (this.pickaxe8_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe8_skinsChosen = 2;
			}
			else if (this.pickaxe8_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe8_skinsChosen = 0;
			}
			else if (this.pickaxe8_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe8_skinsChosen = 1;
			}
			else if (this.pickaxe8_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe8_skinsChosen = 2;
				return;
			}
		}
		if (TheAnvil.pickaxe9_equipped)
		{
			if (this.pickaxe9_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe9_skinsChosen = 0;
				return;
			}
			if (this.pickaxe9_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe9_skinsChosen = 1;
			}
			else if (this.pickaxe9_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe9_skinsChosen = 2;
			}
			else if (this.pickaxe9_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe9_skinsChosen = 0;
			}
			else if (this.pickaxe9_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe9_skinsChosen = 1;
			}
			else if (this.pickaxe9_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe9_skinsChosen = 2;
				return;
			}
		}
		if (TheAnvil.pickaxe10_equipped)
		{
			if (this.pickaxe10_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe10_skinsChosen = 0;
				return;
			}
			if (this.pickaxe10_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe10_skinsChosen = 1;
			}
			else if (this.pickaxe10_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe10_skinsChosen = 2;
			}
			else if (this.pickaxe10_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe10_skinsChosen = 0;
			}
			else if (this.pickaxe10_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe10_skinsChosen = 1;
			}
			else if (this.pickaxe10_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe10_skinsChosen = 2;
				return;
			}
		}
		if (TheAnvil.pickaxe11_equipped)
		{
			if (this.pickaxe11_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe11_skinsChosen = 0;
				return;
			}
			if (this.pickaxe11_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe11_skinsChosen = 1;
			}
			else if (this.pickaxe11_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe11_skinsChosen = 2;
			}
			else if (this.pickaxe11_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe11_skinsChosen = 0;
			}
			else if (this.pickaxe11_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe11_skinsChosen = 1;
			}
			else if (this.pickaxe11_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe11_skinsChosen = 2;
				return;
			}
		}
		if (TheAnvil.pickaxe12_equipped)
		{
			if (this.pickaxe12_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe12_skinsChosen = 0;
				return;
			}
			if (this.pickaxe12_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe12_skinsChosen = 1;
			}
			else if (this.pickaxe12_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe12_skinsChosen = 2;
			}
			else if (this.pickaxe12_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe12_skinsChosen = 0;
			}
			else if (this.pickaxe12_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe12_skinsChosen = 1;
			}
			else if (this.pickaxe12_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe12_skinsChosen = 2;
				return;
			}
		}
		if (TheAnvil.pickaxe13_equipped)
		{
			if (this.pickaxe13_skins[0].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe13_skinsChosen = 0;
				return;
			}
			if (this.pickaxe13_skins[0].activeInHierarchy && right)
			{
				TheAnvil.pickaxe13_skinsChosen = 1;
			}
			else if (this.pickaxe13_skins[1].activeInHierarchy && right)
			{
				TheAnvil.pickaxe13_skinsChosen = 2;
			}
			else if (this.pickaxe13_skins[1].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe13_skinsChosen = 0;
			}
			else if (this.pickaxe13_skins[2].activeInHierarchy && !right)
			{
				TheAnvil.pickaxe13_skinsChosen = 1;
			}
			else if (this.pickaxe13_skins[2].activeInHierarchy && right)
			{
				TheAnvil.pickaxe13_skinsChosen = 2;
				return;
			}
		}
		this.CheckSkin();
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00009F1C File Offset: 0x0000811C
	public void CheckSkin()
	{
		this.pickaxe1_skins[0].SetActive(false);
		this.pickaxe1_skins[1].SetActive(false);
		this.pickaxe1_skins[2].SetActive(false);
		this.pickaxe2_skins[0].SetActive(false);
		this.pickaxe2_skins[1].SetActive(false);
		this.pickaxe2_skins[2].SetActive(false);
		this.pickaxe3_skins[0].SetActive(false);
		this.pickaxe3_skins[1].SetActive(false);
		this.pickaxe3_skins[2].SetActive(false);
		this.pickaxe4_skins[0].SetActive(false);
		this.pickaxe4_skins[1].SetActive(false);
		this.pickaxe4_skins[2].SetActive(false);
		this.pickaxe5_skins[0].SetActive(false);
		this.pickaxe5_skins[1].SetActive(false);
		this.pickaxe5_skins[2].SetActive(false);
		this.pickaxe6_skins[0].SetActive(false);
		this.pickaxe6_skins[1].SetActive(false);
		this.pickaxe6_skins[2].SetActive(false);
		this.pickaxe7_skins[0].SetActive(false);
		this.pickaxe7_skins[1].SetActive(false);
		this.pickaxe7_skins[2].SetActive(false);
		this.pickaxe8_skins[0].SetActive(false);
		this.pickaxe8_skins[1].SetActive(false);
		this.pickaxe8_skins[2].SetActive(false);
		this.pickaxe9_skins[0].SetActive(false);
		this.pickaxe9_skins[1].SetActive(false);
		this.pickaxe9_skins[2].SetActive(false);
		this.pickaxe10_skins[0].SetActive(false);
		this.pickaxe10_skins[1].SetActive(false);
		this.pickaxe10_skins[2].SetActive(false);
		this.pickaxe11_skins[0].SetActive(false);
		this.pickaxe11_skins[1].SetActive(false);
		this.pickaxe11_skins[2].SetActive(false);
		this.pickaxe12_skins[0].SetActive(false);
		this.pickaxe12_skins[1].SetActive(false);
		this.pickaxe12_skins[2].SetActive(false);
		this.pickaxe13_skins[0].SetActive(false);
		this.pickaxe13_skins[1].SetActive(false);
		this.pickaxe13_skins[2].SetActive(false);
		if (TheAnvil.pickaxe1_equipped)
		{
			this.pickaxe1_skins[TheAnvil.pickaxe1_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe1_skinsChosen + 1).ToString();
		}
		if (TheAnvil.pickaxe2_equipped)
		{
			this.pickaxe2_skins[TheAnvil.pickaxe2_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe2_skinsChosen + 1).ToString();
		}
		if (TheAnvil.pickaxe3_equipped)
		{
			this.pickaxe3_skins[TheAnvil.pickaxe3_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe3_skinsChosen + 1).ToString();
		}
		if (TheAnvil.pickaxe4_equipped)
		{
			this.pickaxe4_skins[TheAnvil.pickaxe4_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe4_skinsChosen + 1).ToString();
		}
		if (TheAnvil.pickaxe5_equipped)
		{
			this.pickaxe5_skins[TheAnvil.pickaxe5_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe5_skinsChosen + 1).ToString();
		}
		if (TheAnvil.pickaxe6_equipped)
		{
			this.pickaxe6_skins[TheAnvil.pickaxe6_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe6_skinsChosen + 1).ToString();
		}
		if (TheAnvil.pickaxe7_equipped)
		{
			this.pickaxe7_skins[TheAnvil.pickaxe7_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe7_skinsChosen + 1).ToString();
		}
		if (TheAnvil.pickaxe8_equipped)
		{
			this.pickaxe8_skins[TheAnvil.pickaxe8_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe8_skinsChosen + 1).ToString();
		}
		if (TheAnvil.pickaxe9_equipped)
		{
			this.pickaxe9_skins[TheAnvil.pickaxe9_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe9_skinsChosen + 1).ToString();
		}
		if (TheAnvil.pickaxe10_equipped)
		{
			this.pickaxe10_skins[TheAnvil.pickaxe10_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe10_skinsChosen + 1).ToString();
		}
		if (TheAnvil.pickaxe11_equipped)
		{
			this.pickaxe11_skins[TheAnvil.pickaxe11_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe11_skinsChosen + 1).ToString();
		}
		if (TheAnvil.pickaxe12_equipped)
		{
			this.pickaxe12_skins[TheAnvil.pickaxe12_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe12_skinsChosen + 1).ToString();
		}
		if (TheAnvil.pickaxe13_equipped)
		{
			this.pickaxe13_skins[TheAnvil.pickaxe13_skinsChosen].SetActive(true);
			this.skinText.text = LocalizationScript.skin + (TheAnvil.pickaxe13_skinsChosen + 1).ToString();
		}
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000A464 File Offset: 0x00008664
	private void Start()
	{
		base.StartCoroutine(this.Wait());
	}

	// Token: 0x0600009D RID: 157 RVA: 0x0000A473 File Offset: 0x00008673
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(0.2f);
		if (MobileAndTesting.isMobile)
		{
			this.pcCursorImage.SetActive(false);
			this.mobileCircleBtn.SetActive(true);
			TheAnvil.isDLC = false;
			this.SetSkinsOff(true);
		}
		else
		{
			this.pcCursorImage.SetActive(true);
			this.mobileCircleBtn.SetActive(false);
		}
		TheAnvil.pickaxe2_goldPrice = 65.0;
		TheAnvil.pickaxe3_goldPrice = 370.0;
		TheAnvil.pickaxe3_copperPrice = 140.0;
		TheAnvil.pickaxe4_copperPrice = 650.0;
		TheAnvil.pickaxe4_ironPrice = 400.0;
		TheAnvil.pickaxe5_goldPrice = 4000.0;
		TheAnvil.pickaxe5_ironPrice = 1800.0;
		TheAnvil.pickaxe6_goldPrice = 10000.0;
		TheAnvil.pickaxe6_cobaltPrice = 3000.0;
		TheAnvil.pickaxe7_goldPrice = 25000.0;
		TheAnvil.pickaxe7_copperPrice = 6000.0;
		TheAnvil.pickaxe7_ironPrice = 5000.0;
		TheAnvil.pickaxe8_cobaltPrice = 12000.0;
		TheAnvil.pickaxe8_uraniumPrice = 8000.0;
		TheAnvil.pickaxe9_goldPrice = 300000.0;
		TheAnvil.pickaxe9_uraniumPrice = 40000.0;
		TheAnvil.pickaxe9_ismiumPrice = 25000.0;
		TheAnvil.pickaxe10_goldPrice = 750000.0;
		TheAnvil.pickaxe10_copperPrice = 550000.0;
		TheAnvil.pickaxe10_iridiumPrice = 40000.0;
		TheAnvil.pickaxe11_cobaltPrice = 1000000.0;
		TheAnvil.pickaxe11_uraniumPrice = 650000.0;
		TheAnvil.pickaxe11_ismiumPrice = 235000.0;
		TheAnvil.pickaxe12_goldPrice = 9000000.0;
		TheAnvil.pickaxe12_iridiumPrice = 700000.0;
		TheAnvil.pickaxe13_goldPrice = 30000000.0;
		TheAnvil.pickaxe13_ironPrice = 10000000.0;
		TheAnvil.pickaxe13_painitePrice = 700000.0;
		TheAnvil.collTime = 0.04f;
		if (TheAnvil.pickaxe1_crafted)
		{
			this.SetImageToWhite(this.pickaxe1_topImage);
			this.SetImageToWhite(this.pickaxe1_craftImage);
		}
		if (TheAnvil.pickaxe2_crafted)
		{
			this.SetImageToWhite(this.pickaxe2_topImage);
			this.SetImageToWhite(this.pickaxe2_craftImage);
		}
		if (TheAnvil.pickaxe3_crafted)
		{
			this.SetImageToWhite(this.pickaxe3_topImage);
			this.SetImageToWhite(this.pickaxe3_craftImage);
		}
		if (TheAnvil.pickaxe4_crafted)
		{
			this.SetImageToWhite(this.pickaxe4_topImage);
			this.SetImageToWhite(this.pickaxe4_craftImage);
		}
		if (TheAnvil.pickaxe5_crafted)
		{
			this.SetImageToWhite(this.pickaxe5_topImage);
			this.SetImageToWhite(this.pickaxe5_craftImage);
		}
		if (TheAnvil.pickaxe6_crafted)
		{
			this.SetImageToWhite(this.pickaxe6_topImage);
			this.SetImageToWhite(this.pickaxe6_craftImage);
		}
		if (TheAnvil.pickaxe7_crafted)
		{
			this.SetImageToWhite(this.pickaxe7_topImage);
			this.SetImageToWhite(this.pickaxe7_craftImage);
		}
		if (TheAnvil.pickaxe8_crafted)
		{
			this.SetImageToWhite(this.pickaxe8_topImage);
			this.SetImageToWhite(this.pickaxe8_craftImage);
		}
		if (TheAnvil.pickaxe9_crafted)
		{
			this.SetImageToWhite(this.pickaxe9_topImage);
			this.SetImageToWhite(this.pickaxe9_craftImage);
		}
		if (TheAnvil.pickaxe10_crafted)
		{
			this.SetImageToWhite(this.pickaxe10_topImage);
			this.SetImageToWhite(this.pickaxe10_craftImage);
		}
		if (TheAnvil.pickaxe11_crafted)
		{
			this.SetImageToWhite(this.pickaxe11_topImage);
			this.SetImageToWhite(this.pickaxe11_craftImage);
		}
		if (TheAnvil.pickaxe12_crafted)
		{
			this.SetImageToWhite(this.pickaxe12_topImage);
			this.SetImageToWhite(this.pickaxe12_craftImage);
		}
		if (TheAnvil.pickaxe13_crafted)
		{
			this.SetImageToWhite(this.pickaxe13_topImage);
			this.SetImageToWhite(this.pickaxe13_craftImage);
		}
		if (TheAnvil.pickaxe14_crafted)
		{
			this.SetImageToWhite(this.pickaxe14_topImage);
			this.SetImageToWhite(this.pickaxe14_craftImage);
		}
		TheAnvil.pickaxe1_mineTime = 0.34f;
		TheAnvil.pickaxe1_minePower = 2.5f;
		TheAnvil.pickaxe1_2XChance = 1.1f;
		TheAnvil.pickaxe1_miningAreaSize = 1.21f;
		TheAnvil.pickaxe2_mineTime = 0.33f;
		TheAnvil.pickaxe2_minePower = 2.9f;
		TheAnvil.pickaxe2_2XChance = 1.4f;
		TheAnvil.pickaxe2_miningAreaSize = 1.3f;
		TheAnvil.pickaxe3_mineTime = 0.32f;
		TheAnvil.pickaxe3_minePower = 3.3f;
		TheAnvil.pickaxe3_2XChance = 1.9f;
		TheAnvil.pickaxe3_miningAreaSize = 1.4f;
		TheAnvil.pickaxe4_mineTime = 0.31f;
		TheAnvil.pickaxe4_minePower = 3.7f;
		TheAnvil.pickaxe4_2XChance = 2.1f;
		TheAnvil.pickaxe4_miningAreaSize = 1.43f;
		TheAnvil.pickaxe5_mineTime = 0.3f;
		TheAnvil.pickaxe5_minePower = 3.9f;
		TheAnvil.pickaxe5_2XChance = 2.3f;
		TheAnvil.pickaxe5_miningAreaSize = 1.47f;
		TheAnvil.pickaxe6_mineTime = 0.3f;
		TheAnvil.pickaxe6_minePower = 4.3f;
		TheAnvil.pickaxe6_2XChance = 2.6f;
		TheAnvil.pickaxe6_miningAreaSize = 1.5f;
		TheAnvil.pickaxe7_mineTime = 0.285f;
		TheAnvil.pickaxe7_minePower = 4.7f;
		TheAnvil.pickaxe7_2XChance = 2.9f;
		TheAnvil.pickaxe7_miningAreaSize = 1.52f;
		TheAnvil.pickaxe8_mineTime = 0.28f;
		TheAnvil.pickaxe8_minePower = 5f;
		TheAnvil.pickaxe8_2XChance = 3.1f;
		TheAnvil.pickaxe8_miningAreaSize = 1.6f;
		TheAnvil.pickaxe9_mineTime = 0.27f;
		TheAnvil.pickaxe9_minePower = 5.2f;
		TheAnvil.pickaxe9_2XChance = 3.8f;
		TheAnvil.pickaxe9_miningAreaSize = 1.6f;
		TheAnvil.pickaxe10_mineTime = 0.26f;
		TheAnvil.pickaxe10_minePower = 5.6f;
		TheAnvil.pickaxe10_2XChance = 4.1f;
		TheAnvil.pickaxe10_miningAreaSize = 1.67f;
		TheAnvil.pickaxe11_mineTime = 0.25f;
		TheAnvil.pickaxe11_minePower = 6.1f;
		TheAnvil.pickaxe11_2XChance = 4.6f;
		TheAnvil.pickaxe11_miningAreaSize = 1.7f;
		TheAnvil.pickaxe12_mineTime = 0.24f;
		TheAnvil.pickaxe12_minePower = 6.6f;
		TheAnvil.pickaxe12_2XChance = 5.1f;
		TheAnvil.pickaxe12_miningAreaSize = 1.7f;
		TheAnvil.pickaxe13_mineTime = 0.23f;
		TheAnvil.pickaxe13_minePower = 7.4f;
		TheAnvil.pickaxe13_2XChance = 5.7f;
		TheAnvil.pickaxe13_miningAreaSize = 1.76f;
		TheAnvil.pickaxe14_mineTime = 0.2f;
		TheAnvil.pickaxe14_minePower = 8f;
		TheAnvil.pickaxe14_2XChance = 6.5f;
		TheAnvil.pickaxe14_miningAreaSize = 1.8f;
		this.CheckPickaxes();
		if (TheAnvil.pickaxe1_equipped)
		{
			this.EquipPickaxe(0);
			this.pickaxeNumber = 0;
		}
		if (TheAnvil.pickaxe2_equipped)
		{
			this.EquipPickaxe(1);
			this.pickaxeNumber = 0;
			this.PickaxeSlection(true);
		}
		if (TheAnvil.pickaxe3_equipped)
		{
			this.EquipPickaxe(2);
			this.pickaxeNumber = 1;
			this.PickaxeSlection(true);
		}
		if (TheAnvil.pickaxe4_equipped)
		{
			this.EquipPickaxe(3);
			this.pickaxeNumber = 2;
			this.PickaxeSlection(true);
		}
		if (TheAnvil.pickaxe5_equipped)
		{
			this.EquipPickaxe(4);
			this.pickaxeNumber = 3;
			this.PickaxeSlection(true);
		}
		if (TheAnvil.pickaxe6_equipped)
		{
			this.EquipPickaxe(5);
			this.pickaxeNumber = 4;
			this.PickaxeSlection(true);
		}
		if (TheAnvil.pickaxe7_equipped)
		{
			this.EquipPickaxe(6);
			this.pickaxeNumber = 5;
			this.PickaxeSlection(true);
		}
		if (TheAnvil.pickaxe8_equipped)
		{
			this.EquipPickaxe(7);
			this.pickaxeNumber = 6;
			this.PickaxeSlection(true);
		}
		if (TheAnvil.pickaxe9_equipped)
		{
			this.EquipPickaxe(8);
			this.pickaxeNumber = 7;
			this.PickaxeSlection(true);
		}
		if (TheAnvil.pickaxe10_equipped)
		{
			this.EquipPickaxe(9);
			this.pickaxeNumber = 8;
			this.PickaxeSlection(true);
		}
		if (TheAnvil.pickaxe11_equipped)
		{
			this.EquipPickaxe(10);
			this.pickaxeNumber = 9;
			this.PickaxeSlection(true);
		}
		if (TheAnvil.pickaxe12_equipped)
		{
			this.EquipPickaxe(11);
			this.pickaxeNumber = 10;
			this.PickaxeSlection(true);
		}
		if (TheAnvil.pickaxe13_equipped)
		{
			this.EquipPickaxe(12);
			this.pickaxeNumber = 11;
			this.PickaxeSlection(true);
		}
		if (TheAnvil.pickaxe14_equipped)
		{
			this.EquipPickaxe(13);
			this.pickaxeNumber = 12;
			this.PickaxeSlection(true);
		}
		this.playSound = true;
		yield break;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0000A484 File Offset: 0x00008684
	private void Update()
	{
		if (this.pickaxeNumber == 1)
		{
			if (GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe2_goldPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.goldPriceText.color = Color.green;
			}
			else
			{
				this.goldPriceText.color = Color.red;
			}
			this.goldPriceText.text = (TheAnvil.pickaxe2_goldPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
		}
		if (this.pickaxeNumber == 2)
		{
			if (GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe3_goldPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.goldPriceText.color = Color.green;
			}
			else
			{
				this.goldPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalCopperBars >= TheAnvil.pickaxe3_copperPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.copperPriceText.color = Color.green;
			}
			else
			{
				this.copperPriceText.color = Color.red;
			}
			this.goldPriceText.text = (TheAnvil.pickaxe3_goldPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
			this.copperPriceText.text = (TheAnvil.pickaxe3_copperPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
		}
		if (this.pickaxeNumber == 3)
		{
			if (GoldAndOreMechanics.totalCopperBars >= TheAnvil.pickaxe4_copperPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.copperPriceText.color = Color.green;
			}
			else
			{
				this.copperPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalIronBars >= TheAnvil.pickaxe4_ironPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.ironPriceText.color = Color.green;
			}
			else
			{
				this.ironPriceText.color = Color.red;
			}
			this.copperPriceText.text = (TheAnvil.pickaxe4_copperPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
			this.ironPriceText.text = (TheAnvil.pickaxe4_ironPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
		}
		if (this.pickaxeNumber == 4)
		{
			if (GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe5_goldPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.goldPriceText.color = Color.green;
			}
			else
			{
				this.goldPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalIronBars >= TheAnvil.pickaxe5_ironPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.ironPriceText.color = Color.green;
			}
			else
			{
				this.ironPriceText.color = Color.red;
			}
			this.goldPriceText.text = (TheAnvil.pickaxe5_goldPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
			this.ironPriceText.text = (TheAnvil.pickaxe5_ironPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
		}
		if (this.pickaxeNumber == 5)
		{
			if (GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe6_goldPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.goldPriceText.color = Color.green;
			}
			else
			{
				this.goldPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalCobaltBars >= TheAnvil.pickaxe6_cobaltPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.cobaltPriceText.color = Color.green;
			}
			else
			{
				this.cobaltPriceText.color = Color.red;
			}
			this.goldPriceText.text = (TheAnvil.pickaxe6_goldPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
			this.cobaltPriceText.text = (TheAnvil.pickaxe6_cobaltPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
		}
		if (this.pickaxeNumber == 6)
		{
			if (GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe7_goldPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.goldPriceText.color = Color.green;
			}
			else
			{
				this.goldPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalCopperBars >= TheAnvil.pickaxe7_copperPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.copperPriceText.color = Color.green;
			}
			else
			{
				this.copperPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalIronBars >= TheAnvil.pickaxe7_ironPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.ironPriceText.color = Color.green;
			}
			else
			{
				this.ironPriceText.color = Color.red;
			}
			this.goldPriceText.text = (TheAnvil.pickaxe7_goldPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
			this.copperPriceText.text = (TheAnvil.pickaxe7_copperPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
			this.ironPriceText.text = (TheAnvil.pickaxe7_ironPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
		}
		if (this.pickaxeNumber == 7)
		{
			if (GoldAndOreMechanics.totalCobaltBars >= TheAnvil.pickaxe8_cobaltPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.cobaltPriceText.color = Color.green;
			}
			else
			{
				this.cobaltPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalUraniumBars >= TheAnvil.pickaxe8_uraniumPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.uraniumPriceText.color = Color.green;
			}
			else
			{
				this.uraniumPriceText.color = Color.red;
			}
			this.cobaltPriceText.text = (TheAnvil.pickaxe8_cobaltPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
			this.uraniumPriceText.text = (TheAnvil.pickaxe8_uraniumPrice * (double)LevelMechanics.blacksmithDecrease).ToString("F0");
		}
		if (this.pickaxeNumber == 8)
		{
			if (GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe9_goldPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.goldPriceText.color = Color.green;
			}
			else
			{
				this.goldPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalUraniumBars >= TheAnvil.pickaxe9_uraniumPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.uraniumPriceText.color = Color.green;
			}
			else
			{
				this.uraniumPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalIsmiumBar >= TheAnvil.pickaxe9_ismiumPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.ismiumPriceText.color = Color.green;
			}
			else
			{
				this.ismiumPriceText.color = Color.red;
			}
			this.goldPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe9_goldPrice * (double)LevelMechanics.blacksmithDecrease);
			this.uraniumPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe9_uraniumPrice * (double)LevelMechanics.blacksmithDecrease);
			this.ismiumPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe9_ismiumPrice * (double)LevelMechanics.blacksmithDecrease);
		}
		if (this.pickaxeNumber == 9)
		{
			if (GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe10_goldPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.goldPriceText.color = Color.green;
			}
			else
			{
				this.goldPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalCopperBars >= TheAnvil.pickaxe10_copperPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.copperPriceText.color = Color.green;
			}
			else
			{
				this.copperPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalIridiumBars >= TheAnvil.pickaxe10_iridiumPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.iridiumPriceText.color = Color.green;
			}
			else
			{
				this.iridiumPriceText.color = Color.red;
			}
			this.goldPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe10_goldPrice * (double)LevelMechanics.blacksmithDecrease);
			this.copperPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe10_copperPrice * (double)LevelMechanics.blacksmithDecrease);
			this.iridiumPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe10_iridiumPrice * (double)LevelMechanics.blacksmithDecrease);
		}
		if (this.pickaxeNumber == 10)
		{
			if (GoldAndOreMechanics.totalCobaltBars >= TheAnvil.pickaxe11_cobaltPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.cobaltPriceText.color = Color.green;
			}
			else
			{
				this.cobaltPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalUraniumBars >= TheAnvil.pickaxe11_uraniumPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.uraniumPriceText.color = Color.green;
			}
			else
			{
				this.uraniumPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalIsmiumBar >= TheAnvil.pickaxe11_ismiumPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.ismiumPriceText.color = Color.green;
			}
			else
			{
				this.ismiumPriceText.color = Color.red;
			}
			this.cobaltPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe11_cobaltPrice * (double)LevelMechanics.blacksmithDecrease);
			this.uraniumPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe11_uraniumPrice * (double)LevelMechanics.blacksmithDecrease);
			this.ismiumPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe11_ismiumPrice * (double)LevelMechanics.blacksmithDecrease);
		}
		if (this.pickaxeNumber == 11)
		{
			if (GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe12_goldPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.goldPriceText.color = Color.green;
			}
			else
			{
				this.goldPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalIridiumBars >= TheAnvil.pickaxe12_iridiumPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.iridiumPriceText.color = Color.green;
			}
			else
			{
				this.iridiumPriceText.color = Color.red;
			}
			this.goldPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe12_goldPrice * (double)LevelMechanics.blacksmithDecrease);
			this.iridiumPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe12_iridiumPrice * (double)LevelMechanics.blacksmithDecrease);
		}
		if (this.pickaxeNumber == 12)
		{
			if (GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe13_goldPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.goldPriceText.color = Color.green;
			}
			else
			{
				this.goldPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalIronBars >= TheAnvil.pickaxe13_ironPrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.ironPriceText.color = Color.green;
			}
			else
			{
				this.ironPriceText.color = Color.red;
			}
			if (GoldAndOreMechanics.totalPainiteBars >= TheAnvil.pickaxe13_painitePrice * (double)LevelMechanics.blacksmithDecrease)
			{
				this.painitePriceText.color = Color.green;
			}
			else
			{
				this.painitePriceText.color = Color.red;
			}
			this.goldPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe13_goldPrice * (double)LevelMechanics.blacksmithDecrease);
			this.ironPriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe13_ironPrice * (double)LevelMechanics.blacksmithDecrease);
			this.painitePriceText.text = FormatNumbers.FormatPoints(TheAnvil.pickaxe13_painitePrice * (double)LevelMechanics.blacksmithDecrease);
		}
		if (MainMenu.isInTheAnvil)
		{
			if (Input.GetMouseButton(1) || CraftMobileButton.isPressing)
			{
				bool flag = false;
				float blacksmithDecrease = LevelMechanics.blacksmithDecrease;
				if (this.pickaxeNumber == 1 && !TheAnvil.pickaxe2_crafted && GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe2_goldPrice * (double)blacksmithDecrease)
				{
					flag = true;
				}
				if (this.pickaxeNumber == 2 && !TheAnvil.pickaxe3_crafted && GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe3_goldPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalCopperBars >= TheAnvil.pickaxe3_copperPrice * (double)blacksmithDecrease)
				{
					flag = true;
				}
				if (this.pickaxeNumber == 3 && !TheAnvil.pickaxe4_crafted && GoldAndOreMechanics.totalCopperBars >= TheAnvil.pickaxe4_copperPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalIronBars >= TheAnvil.pickaxe4_ironPrice * (double)blacksmithDecrease)
				{
					flag = true;
				}
				if (this.pickaxeNumber == 4 && !TheAnvil.pickaxe5_crafted && GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe5_goldPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalIronBars >= TheAnvil.pickaxe5_ironPrice * (double)blacksmithDecrease)
				{
					flag = true;
				}
				if (this.pickaxeNumber == 5 && !TheAnvil.pickaxe6_crafted && GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe6_goldPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalCobaltBars >= TheAnvil.pickaxe6_cobaltPrice * (double)blacksmithDecrease)
				{
					flag = true;
				}
				if (this.pickaxeNumber == 6 && !TheAnvil.pickaxe7_crafted && GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe7_goldPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalCopperBars >= TheAnvil.pickaxe7_copperPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalIronBars >= TheAnvil.pickaxe7_ironPrice * (double)blacksmithDecrease)
				{
					flag = true;
				}
				if (this.pickaxeNumber == 7 && !TheAnvil.pickaxe8_crafted && GoldAndOreMechanics.totalCobaltBars >= TheAnvil.pickaxe8_cobaltPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalUraniumBars >= TheAnvil.pickaxe8_uraniumPrice * (double)blacksmithDecrease)
				{
					flag = true;
				}
				if (this.pickaxeNumber == 8 && !TheAnvil.pickaxe9_crafted && GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe9_goldPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalUraniumBars >= TheAnvil.pickaxe9_uraniumPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalIsmiumBar >= TheAnvil.pickaxe9_ismiumPrice * (double)blacksmithDecrease)
				{
					flag = true;
				}
				if (this.pickaxeNumber == 9 && !TheAnvil.pickaxe10_crafted && GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe10_goldPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalCopperBars >= TheAnvil.pickaxe10_copperPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalIridiumBars >= TheAnvil.pickaxe10_iridiumPrice * (double)blacksmithDecrease)
				{
					flag = true;
				}
				if (this.pickaxeNumber == 10 && !TheAnvil.pickaxe11_crafted && GoldAndOreMechanics.totalCobaltBars >= TheAnvil.pickaxe11_cobaltPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalUraniumBars >= TheAnvil.pickaxe11_uraniumPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalIsmiumBar >= TheAnvil.pickaxe11_ismiumPrice * (double)blacksmithDecrease)
				{
					flag = true;
				}
				if (this.pickaxeNumber == 11 && !TheAnvil.pickaxe12_crafted && GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe12_goldPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalIridiumBars >= TheAnvil.pickaxe12_iridiumPrice * (double)blacksmithDecrease)
				{
					flag = true;
				}
				if (this.pickaxeNumber == 12 && !TheAnvil.pickaxe13_crafted && GoldAndOreMechanics.totalGoldBars >= TheAnvil.pickaxe13_goldPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalIronBars >= TheAnvil.pickaxe13_ironPrice * (double)blacksmithDecrease && GoldAndOreMechanics.totalPainiteBars >= TheAnvil.pickaxe13_painitePrice * (double)blacksmithDecrease)
				{
					flag = true;
				}
				if (flag)
				{
					if (!this.isCrafting)
					{
						this.craftingText.text = LocalizationScript.crafting;
						this.audioManager.Play("Crafting...");
						this.isPlayingCrafting = true;
						this.isCrafting = true;
						this.currentTime = 0f;
						this.dotTimer = 0f;
						this.dotCount = 0;
						this.craftingCompleted = false;
						this.craftingFrame.SetActive(true);
					}
					if (!this.craftingCompleted)
					{
						this.currentTime += Time.deltaTime;
						float num = Mathf.Clamp01(this.currentTime / this.craftingTime);
						this.outLineCircle.SetActive(true);
						this.craftingText.gameObject.SetActive(true);
						this.craftingCircle.gameObject.SetActive(true);
						this.craftingCircle.fillAmount = num;
						if (num >= 1f && !this.craftingCompleted)
						{
							this.audioManager.Stop("Crafting...");
							this.craftingCompleted = true;
							this.OnCraftingComplete();
						}
						this.dotTimer += Time.deltaTime;
						if (this.dotTimer >= 0.35f)
						{
							this.dotTimer = 0f;
							this.dotCount = (this.dotCount + 1) % 4;
							this.craftingText.text = LocalizationScript.crafting + new string('.', this.dotCount);
						}
					}
				}
			}
			else if (this.isCrafting && !TheAnvil.isInCraftingDone)
			{
				this.audioManager.Stop("Crafting...");
				this.isCrafting = false;
				this.craftingFrame.SetActive(false);
				this.craftingCircle.fillAmount = 0f;
			}
			if (Input.GetMouseButtonDown(1) || CraftMobileButton.isPressing)
			{
				if (this.pickaxeNumber == 0 && TheAnvil.pickaxe1_crafted && !TheAnvil.pickaxe1_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 1 && TheAnvil.pickaxe2_crafted && !TheAnvil.pickaxe2_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 2 && TheAnvil.pickaxe3_crafted && !TheAnvil.pickaxe3_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 3 && TheAnvil.pickaxe4_crafted && !TheAnvil.pickaxe4_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 4 && TheAnvil.pickaxe5_crafted && !TheAnvil.pickaxe5_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 5 && TheAnvil.pickaxe6_crafted && !TheAnvil.pickaxe6_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 6 && TheAnvil.pickaxe7_crafted && !TheAnvil.pickaxe7_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 7 && TheAnvil.pickaxe8_crafted && !TheAnvil.pickaxe8_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 8 && TheAnvil.pickaxe9_crafted && !TheAnvil.pickaxe9_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 9 && TheAnvil.pickaxe10_crafted && !TheAnvil.pickaxe10_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 10 && TheAnvil.pickaxe11_crafted && !TheAnvil.pickaxe11_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 11 && TheAnvil.pickaxe12_crafted && !TheAnvil.pickaxe12_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 12 && TheAnvil.pickaxe13_crafted && !TheAnvil.pickaxe13_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
				if (this.pickaxeNumber == 13 && TheAnvil.pickaxe14_crafted && !TheAnvil.pickaxe14_equipped)
				{
					this.EquipPickaxe(this.pickaxeNumber);
				}
			}
		}
	}

	// Token: 0x0600009F RID: 159 RVA: 0x0000B4B8 File Offset: 0x000096B8
	private void OnCraftingComplete()
	{
		this.audioManager.Play("CraftingDone");
		this.audioManager.Play("FinishedCrafting");
		TheAnvil.craftedOnePickaxe = true;
		if (this.pickaxeNumber == 1)
		{
			TheAnvil.pickaxe2_crafted = true;
			this.SetImageToWhite(this.pickaxe2_topImage);
			this.SetImageToWhite(this.pickaxe2_craftImage);
		}
		if (this.pickaxeNumber == 2)
		{
			TheAnvil.pickaxe3_crafted = true;
			this.SetImageToWhite(this.pickaxe3_topImage);
			this.SetImageToWhite(this.pickaxe3_craftImage);
		}
		if (this.pickaxeNumber == 3)
		{
			TheAnvil.pickaxe4_crafted = true;
			this.SetImageToWhite(this.pickaxe4_topImage);
			this.SetImageToWhite(this.pickaxe4_craftImage);
		}
		if (this.pickaxeNumber == 4)
		{
			TheAnvil.pickaxe5_crafted = true;
			this.SetImageToWhite(this.pickaxe5_topImage);
			this.SetImageToWhite(this.pickaxe5_craftImage);
		}
		if (this.pickaxeNumber == 5)
		{
			TheAnvil.pickaxe6_crafted = true;
			this.SetImageToWhite(this.pickaxe6_topImage);
			this.SetImageToWhite(this.pickaxe6_craftImage);
		}
		if (this.pickaxeNumber == 6)
		{
			TheAnvil.pickaxe7_crafted = true;
			this.SetImageToWhite(this.pickaxe7_topImage);
			this.SetImageToWhite(this.pickaxe7_craftImage);
		}
		if (this.pickaxeNumber == 7)
		{
			TheAnvil.pickaxe8_crafted = true;
			this.SetImageToWhite(this.pickaxe8_topImage);
			this.SetImageToWhite(this.pickaxe8_craftImage);
		}
		if (this.pickaxeNumber == 8)
		{
			TheAnvil.pickaxe9_crafted = true;
			this.SetImageToWhite(this.pickaxe9_topImage);
			this.SetImageToWhite(this.pickaxe9_craftImage);
		}
		if (this.pickaxeNumber == 9)
		{
			TheAnvil.pickaxe10_crafted = true;
			this.SetImageToWhite(this.pickaxe10_topImage);
			this.SetImageToWhite(this.pickaxe10_craftImage);
		}
		if (this.pickaxeNumber == 10)
		{
			TheAnvil.pickaxe11_crafted = true;
			this.SetImageToWhite(this.pickaxe11_topImage);
			this.SetImageToWhite(this.pickaxe11_craftImage);
		}
		if (this.pickaxeNumber == 11)
		{
			TheAnvil.pickaxe12_crafted = true;
			this.SetImageToWhite(this.pickaxe12_topImage);
			this.SetImageToWhite(this.pickaxe12_craftImage);
		}
		if (this.pickaxeNumber == 12)
		{
			TheAnvil.pickaxe13_crafted = true;
			this.SetImageToWhite(this.pickaxe13_topImage);
			this.SetImageToWhite(this.pickaxe13_craftImage);
		}
		TheAnvil.totalPickaxesCrafted++;
		this.achScript.CheckAch();
		if (this.pickaxeNumber == 1)
		{
			GoldAndOreMechanics.totalGoldBars -= TheAnvil.pickaxe2_goldPrice * (double)LevelMechanics.blacksmithDecrease;
		}
		if (this.pickaxeNumber == 2)
		{
			GoldAndOreMechanics.totalGoldBars -= TheAnvil.pickaxe3_goldPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalCopperBars -= TheAnvil.pickaxe3_copperPrice * (double)LevelMechanics.blacksmithDecrease;
		}
		if (this.pickaxeNumber == 3)
		{
			GoldAndOreMechanics.totalCopperBars -= TheAnvil.pickaxe4_copperPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalIronBars -= TheAnvil.pickaxe4_ironPrice * (double)LevelMechanics.blacksmithDecrease;
		}
		if (this.pickaxeNumber == 4)
		{
			GoldAndOreMechanics.totalGoldBars -= TheAnvil.pickaxe5_goldPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalIronBars -= TheAnvil.pickaxe5_ironPrice * (double)LevelMechanics.blacksmithDecrease;
		}
		if (this.pickaxeNumber == 5)
		{
			GoldAndOreMechanics.totalGoldBars -= TheAnvil.pickaxe6_goldPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalCobaltBars -= TheAnvil.pickaxe6_cobaltPrice * (double)LevelMechanics.blacksmithDecrease;
		}
		if (this.pickaxeNumber == 6)
		{
			GoldAndOreMechanics.totalGoldBars -= TheAnvil.pickaxe7_goldPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalCopperBars -= TheAnvil.pickaxe7_copperPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalIronBars -= TheAnvil.pickaxe7_ironPrice * (double)LevelMechanics.blacksmithDecrease;
		}
		if (this.pickaxeNumber == 7)
		{
			GoldAndOreMechanics.totalCobaltBars -= TheAnvil.pickaxe8_cobaltPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalUraniumBars -= TheAnvil.pickaxe8_uraniumPrice * (double)LevelMechanics.blacksmithDecrease;
		}
		if (this.pickaxeNumber == 8)
		{
			GoldAndOreMechanics.totalGoldBars -= TheAnvil.pickaxe9_goldPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalUraniumBars -= TheAnvil.pickaxe9_uraniumPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalIsmiumBar -= TheAnvil.pickaxe9_ismiumPrice * (double)LevelMechanics.blacksmithDecrease;
		}
		if (this.pickaxeNumber == 9)
		{
			GoldAndOreMechanics.totalGoldBars -= TheAnvil.pickaxe10_goldPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalCopperBars -= TheAnvil.pickaxe10_copperPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalIridiumBars -= TheAnvil.pickaxe10_iridiumPrice * (double)LevelMechanics.blacksmithDecrease;
		}
		if (this.pickaxeNumber == 10)
		{
			GoldAndOreMechanics.totalCobaltBars -= TheAnvil.pickaxe11_cobaltPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalUraniumBars -= TheAnvil.pickaxe11_uraniumPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalIsmiumBar -= TheAnvil.pickaxe11_ismiumPrice * (double)LevelMechanics.blacksmithDecrease;
		}
		if (this.pickaxeNumber == 11)
		{
			GoldAndOreMechanics.totalGoldBars -= TheAnvil.pickaxe12_goldPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalIridiumBars -= TheAnvil.pickaxe12_iridiumPrice * (double)LevelMechanics.blacksmithDecrease;
		}
		if (this.pickaxeNumber == 12)
		{
			GoldAndOreMechanics.totalGoldBars -= TheAnvil.pickaxe13_goldPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalIronBars -= TheAnvil.pickaxe13_ironPrice * (double)LevelMechanics.blacksmithDecrease;
			GoldAndOreMechanics.totalPainiteBars -= TheAnvil.pickaxe13_painitePrice * (double)LevelMechanics.blacksmithDecrease;
		}
		this.goldAndOreScript.SetTotalResourcesText();
		this.CheckPickaxes();
		this.craftingCircle.gameObject.SetActive(false);
		this.outLineCircle.SetActive(false);
		this.craftingText.gameObject.SetActive(false);
		TheAnvil.isInCraftingDone = true;
		base.StartCoroutine(this.SetFinishedCraftingPopUp());
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x0000BA20 File Offset: 0x00009C20
	private IEnumerator SetFinishedCraftingPopUp()
	{
		if (this.pickaxeNumber == 1)
		{
			this.pickaxeParticle.textureSheetAnimation.SetSprite(0, this.pickaxe2Sprite);
		}
		if (this.pickaxeNumber == 2)
		{
			this.pickaxeParticle.textureSheetAnimation.SetSprite(0, this.pickaxe3Sprite);
		}
		if (this.pickaxeNumber == 3)
		{
			this.pickaxeParticle.textureSheetAnimation.SetSprite(0, this.pickaxe4Sprite);
		}
		if (this.pickaxeNumber == 4)
		{
			this.pickaxeParticle.textureSheetAnimation.SetSprite(0, this.pickaxe5Sprite);
		}
		if (this.pickaxeNumber == 5)
		{
			this.pickaxeParticle.textureSheetAnimation.SetSprite(0, this.pickaxe6Sprite);
		}
		if (this.pickaxeNumber == 6)
		{
			this.pickaxeParticle.textureSheetAnimation.SetSprite(0, this.pickaxe7Sprite);
		}
		if (this.pickaxeNumber == 7)
		{
			this.pickaxeParticle.textureSheetAnimation.SetSprite(0, this.pickaxe8Sprite);
		}
		if (this.pickaxeNumber == 8)
		{
			this.pickaxeParticle.textureSheetAnimation.SetSprite(0, this.pickaxe9Sprite);
		}
		if (this.pickaxeNumber == 9)
		{
			this.pickaxeParticle.textureSheetAnimation.SetSprite(0, this.pickaxe10Sprite);
		}
		if (this.pickaxeNumber == 10)
		{
			this.pickaxeParticle.textureSheetAnimation.SetSprite(0, this.pickaxe11Sprite);
		}
		if (this.pickaxeNumber == 11)
		{
			this.pickaxeParticle.textureSheetAnimation.SetSprite(0, this.pickaxe12Sprite);
		}
		if (this.pickaxeNumber == 12)
		{
			this.pickaxeParticle.textureSheetAnimation.SetSprite(0, this.pickaxe13Sprite);
		}
		this.craftedParticle.Play();
		yield return new WaitForSeconds(2.35f);
		bool flag = false;
		if (TheAnvil.pickaxe1_equipped)
		{
			flag = true;
		}
		if (TheAnvil.pickaxe2_equipped)
		{
			flag = true;
		}
		if (TheAnvil.pickaxe3_equipped && this.pickaxeNumber > 2)
		{
			flag = true;
		}
		if (TheAnvil.pickaxe4_equipped && this.pickaxeNumber > 3)
		{
			flag = true;
		}
		if (TheAnvil.pickaxe5_equipped && this.pickaxeNumber > 4)
		{
			flag = true;
		}
		if (TheAnvil.pickaxe6_equipped && this.pickaxeNumber > 5)
		{
			flag = true;
		}
		if (TheAnvil.pickaxe7_equipped && this.pickaxeNumber > 6)
		{
			flag = true;
		}
		if (TheAnvil.pickaxe8_equipped && this.pickaxeNumber > 7)
		{
			flag = true;
		}
		if (TheAnvil.pickaxe9_equipped && this.pickaxeNumber > 8)
		{
			flag = true;
		}
		if (TheAnvil.pickaxe10_equipped && this.pickaxeNumber > 9)
		{
			flag = true;
		}
		if (TheAnvil.pickaxe11_equipped && this.pickaxeNumber > 10)
		{
			flag = true;
		}
		if (TheAnvil.pickaxe12_equipped && this.pickaxeNumber > 11)
		{
			flag = true;
		}
		if (flag)
		{
			this.EquipPickaxe(this.pickaxeNumber);
		}
		this.craftingFrame.SetActive(false);
		TheAnvil.isInCraftingDone = false;
		yield break;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x0000BA30 File Offset: 0x00009C30
	public void EquipPickaxe(int pickaxeNumber)
	{
		if (this.playSound)
		{
			this.audioManager.Play("Equip");
		}
		TheAnvil.pickaxe1_equipped = false;
		TheAnvil.pickaxe2_equipped = false;
		TheAnvil.pickaxe3_equipped = false;
		TheAnvil.pickaxe4_equipped = false;
		TheAnvil.pickaxe5_equipped = false;
		TheAnvil.pickaxe6_equipped = false;
		TheAnvil.pickaxe7_equipped = false;
		TheAnvil.pickaxe8_equipped = false;
		TheAnvil.pickaxe9_equipped = false;
		TheAnvil.pickaxe10_equipped = false;
		TheAnvil.pickaxe11_equipped = false;
		TheAnvil.pickaxe12_equipped = false;
		TheAnvil.pickaxe13_equipped = false;
		TheAnvil.pickaxe14_equipped = false;
		this.pickaxe1_frameIcon.SetActive(false);
		this.pickaxe2_frameIcon.SetActive(false);
		this.pickaxe3_frameIcon.SetActive(false);
		this.pickaxe4_frameIcon.SetActive(false);
		this.pickaxe5_frameIcon.SetActive(false);
		this.pickaxe6_frameIcon.SetActive(false);
		this.pickaxe7_frameIcon.SetActive(false);
		this.pickaxe8_frameIcon.SetActive(false);
		this.pickaxe9_frameIcon.SetActive(false);
		this.pickaxe10_frameIcon.SetActive(false);
		this.pickaxe11_frameIcon.SetActive(false);
		this.pickaxe12_frameIcon.SetActive(false);
		this.pickaxe13_frameIcon.SetActive(false);
		this.pickaxe14_frameIcon.SetActive(false);
		if (pickaxeNumber == 0)
		{
			TheAnvil.pickaxe1_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe1_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe1_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe1_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe1_miningAreaSize;
			this.pickaxe1_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 1)
		{
			TheAnvil.pickaxe2_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe2_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe2_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe2_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe2_miningAreaSize;
			this.pickaxe2_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 2)
		{
			TheAnvil.pickaxe3_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe3_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe3_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe3_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe3_miningAreaSize;
			this.pickaxe3_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 3)
		{
			TheAnvil.pickaxe4_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe4_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe4_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe4_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe4_miningAreaSize;
			this.pickaxe4_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 4)
		{
			TheAnvil.pickaxe5_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe5_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe5_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe5_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe5_miningAreaSize;
			this.pickaxe5_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 5)
		{
			TheAnvil.pickaxe6_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe6_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe6_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe6_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe6_miningAreaSize;
			this.pickaxe6_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 6)
		{
			TheAnvil.pickaxe7_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe7_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe7_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe7_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe7_miningAreaSize;
			this.pickaxe7_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 7)
		{
			TheAnvil.pickaxe8_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe8_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe8_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe8_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe8_miningAreaSize;
			this.pickaxe8_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 8)
		{
			TheAnvil.pickaxe9_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe9_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe9_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe9_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe9_miningAreaSize;
			this.pickaxe9_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 9)
		{
			TheAnvil.pickaxe10_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe10_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe10_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe10_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe10_miningAreaSize;
			this.pickaxe10_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 10)
		{
			TheAnvil.pickaxe11_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe11_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe11_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe11_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe11_miningAreaSize;
			this.pickaxe11_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 11)
		{
			TheAnvil.pickaxe12_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe12_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe12_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe12_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe12_miningAreaSize;
			this.pickaxe12_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 12)
		{
			TheAnvil.pickaxe13_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe13_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe13_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe13_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe13_miningAreaSize;
			this.pickaxe13_frameIcon.SetActive(true);
		}
		if (pickaxeNumber == 13)
		{
			TheAnvil.pickaxe14_equipped = true;
			TheAnvil.equippedMineTime = TheAnvil.pickaxe14_mineTime + TheAnvil.collTime;
			TheAnvil.equippedMinePower = TheAnvil.pickaxe14_minePower;
			TheAnvil.equipped2XChance = TheAnvil.pickaxe14_2XChance;
			TheAnvil.equippedMiningArea = TheAnvil.pickaxe14_miningAreaSize;
			this.pickaxe14_frameIcon.SetActive(true);
		}
		if (TheAnvil.isDLC)
		{
			this.CheckSkin();
		}
		this.DisplayEquippedAndSetStats(TheAnvil.equippedMineTime, TheAnvil.equippedMinePower, TheAnvil.equipped2XChance, TheAnvil.equippedMiningArea);
		this.CheckPickaxes();
		if (TheAnvil.pickaxe14_equipped)
		{
			this.skinLeftBTN.SetActive(false);
			this.skinRightBTN.SetActive(false);
			this.skinText.gameObject.SetActive(false);
			this.allSkinsFrame.transform.localPosition = new Vector2(0f, 0f);
		}
		else
		{
			this.skinLeftBTN.SetActive(true);
			this.skinRightBTN.SetActive(true);
			this.skinText.gameObject.SetActive(true);
			this.allSkinsFrame.transform.localPosition = new Vector2(0f, -7f);
		}
		if (!TheAnvil.isDLC)
		{
			this.SetSkinsOff(false);
		}
		this.achScript.CheckAch();
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x0000BFF8 File Offset: 0x0000A1F8
	public void DisplayEquippedAndSetStats(float mineTime, float minePower, float doubleChance, float miningErea)
	{
		TheAnvil.currentMineTime = mineTime / (1f + SkillTree.reducePickaxeMineTime + SetRockScreen.potionPickaxeStats_increase);
		float num;
		if (Artifacts.wolfClaw_found)
		{
			num = Artifacts.clawChance * (1f + Artifacts.runeImproveAll + LevelMechanics.archeologistIncrease);
		}
		else
		{
			num = 0f;
		}
		TheAnvil.currentMinePower = minePower * (SkillTree.improvedPickaxeStrength + num + SetRockScreen.potionPickaxeStats_increase);
		TheAnvil.current2XPowerChance = doubleChance * (SkillTree.improvedPickaxeStrength + SetRockScreen.potionPickaxeStats_increase);
		TheAnvil.currentMiningErea = miningErea * (SkillTree.improvedPickaxeStrength + SetRockScreen.potionPickaxeStats_increase + LevelMechanics.shapeShifterSizeIncrease);
		this.currentMineTime_text.text = TheAnvil.currentMineTime.ToString("F2") + "s";
		this.currentMinePower_text.text = TheAnvil.currentMinePower.ToString("F2");
		this.current2XPowerChance_text.text = TheAnvil.current2XPowerChance.ToString("F2") + "%";
		this.SetHandColliderSize(TheAnvil.currentMiningErea);
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
	public void SetHandColliderSize(float size)
	{
		size *= SkillTree.miningAreaSize;
		this.currentMiningErea_text.text = size.ToString("F2");
		TheAnvil.currentColliderSize = size;
		this.handCollider.transform.localScale = new Vector2(size, size);
		this.squareCollider.transform.localScale = new Vector2(size, size);
		this.hexagonCollider.transform.localScale = new Vector2(size, size);
		if (SkillTree.increaseAndDecreaseMinignErea_purchased)
		{
			if (this.scaleUpAndDownCoroutine == null)
			{
				this.scaleUpAndDownCoroutine = base.StartCoroutine(this.ScaleHandColliderUpAndDown());
				return;
			}
			base.StopCoroutine(this.scaleUpAndDownCoroutine);
			this.scaleUpAndDownCoroutine = base.StartCoroutine(this.ScaleHandColliderUpAndDown());
		}
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x0000C1B7 File Offset: 0x0000A3B7
	private IEnumerator ScaleHandColliderUpAndDown()
	{
		float maxSize = TheAnvil.currentColliderSize * 1.1f;
		float minSize = TheAnvil.currentColliderSize * 0.95f;
		float duration = 2f;
		for (;;)
		{
			float elapsedTime = 0f;
			Vector3 startScale = Vector3.one * TheAnvil.currentColliderSize;
			Vector3 targetScale = Vector3.one * maxSize;
			while (elapsedTime < duration)
			{
				if (LevelMechanics.isDoubleAreaSize)
				{
					float d = 1f + LevelMechanics.inflationBurstIncrease;
					this.handCollider.transform.localScale = Vector3.Lerp(startScale * d, targetScale * d, elapsedTime / duration);
					this.squareCollider.transform.localScale = Vector3.Lerp(startScale * d, targetScale * d, elapsedTime / duration);
					this.hexagonCollider.transform.localScale = Vector3.Lerp(startScale * d, targetScale * d, elapsedTime / duration);
				}
				else
				{
					this.handCollider.transform.localScale = Vector3.Lerp(startScale, targetScale, elapsedTime / duration);
					this.squareCollider.transform.localScale = Vector3.Lerp(startScale, targetScale, elapsedTime / duration);
					this.hexagonCollider.transform.localScale = Vector3.Lerp(startScale, targetScale, elapsedTime / duration);
				}
				elapsedTime += Time.deltaTime;
				yield return null;
			}
			this.handCollider.transform.localScale = targetScale;
			elapsedTime = 0f;
			startScale = targetScale;
			targetScale = Vector3.one * minSize;
			while (elapsedTime < duration)
			{
				float d2 = 1f + LevelMechanics.inflationBurstIncrease;
				if (LevelMechanics.isDoubleAreaSize)
				{
					this.handCollider.transform.localScale = Vector3.Lerp(startScale * d2, targetScale * d2, elapsedTime / duration);
					this.squareCollider.transform.localScale = Vector3.Lerp(startScale * d2, targetScale * d2, elapsedTime / duration);
					this.hexagonCollider.transform.localScale = Vector3.Lerp(startScale * d2, targetScale * d2, elapsedTime / duration);
				}
				else
				{
					this.handCollider.transform.localScale = Vector3.Lerp(startScale, targetScale, elapsedTime / duration);
					this.squareCollider.transform.localScale = Vector3.Lerp(startScale, targetScale, elapsedTime / duration);
					this.hexagonCollider.transform.localScale = Vector3.Lerp(startScale, targetScale, elapsedTime / duration);
				}
				elapsedTime += Time.deltaTime;
				yield return null;
			}
			this.handCollider.transform.localScale = targetScale;
			TheAnvil.currentColliderSize = minSize;
			startScale = default(Vector3);
			targetScale = default(Vector3);
		}
		yield break;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
	public void PickaxeSlection(bool moveRight)
	{
		this.diamondPickaxeQuestionMark.SetActive(false);
		if (this.playSound)
		{
			this.audioManager.Play("UI_Click1");
		}
		for (int i = 0; i < this.pickaxes.Length; i++)
		{
			this.pickaxes[i].SetActive(false);
		}
		if (moveRight)
		{
			this.pickaxeNumber++;
		}
		else
		{
			this.pickaxeNumber--;
		}
		if (this.pickaxeNumber < 0)
		{
			this.pickaxeNumber = 0;
		}
		if (this.pickaxeNumber > 13)
		{
			this.pickaxeNumber = 13;
		}
		this.pickaxes[this.pickaxeNumber].SetActive(true);
		this.pickaxes[this.pickaxeNumber].transform.localScale = new Vector2(1.25f, 1.25f);
		this.pickaxes[this.pickaxeNumber].transform.localPosition = this.middlePickaxePos.transform.localPosition;
		if (this.pickaxeNumber < 13)
		{
			this.pickaxes[this.pickaxeNumber + 1].SetActive(true);
			this.pickaxes[this.pickaxeNumber + 1].transform.localScale = new Vector2(0.75f, 0.75f);
			this.pickaxes[this.pickaxeNumber + 1].transform.localPosition = this.rightPickaxePos.transform.localPosition;
		}
		if (this.pickaxeNumber > 0)
		{
			this.pickaxes[this.pickaxeNumber - 1].SetActive(true);
			this.pickaxes[this.pickaxeNumber - 1].transform.localScale = new Vector2(0.75f, 0.75f);
			this.pickaxes[this.pickaxeNumber - 1].transform.localPosition = this.leftPickaxePos.transform.localPosition;
		}
		this.pickaxe1_craftImage.gameObject.SetActive(false);
		this.pickaxe2_craftImage.gameObject.SetActive(false);
		this.pickaxe3_craftImage.gameObject.SetActive(false);
		this.pickaxe4_craftImage.gameObject.SetActive(false);
		this.pickaxe5_craftImage.gameObject.SetActive(false);
		this.pickaxe6_craftImage.gameObject.SetActive(false);
		this.pickaxe7_craftImage.gameObject.SetActive(false);
		this.pickaxe8_craftImage.gameObject.SetActive(false);
		this.pickaxe9_craftImage.gameObject.SetActive(false);
		this.pickaxe10_craftImage.gameObject.SetActive(false);
		this.pickaxe11_craftImage.gameObject.SetActive(false);
		this.pickaxe12_craftImage.gameObject.SetActive(false);
		this.pickaxe13_craftImage.gameObject.SetActive(false);
		this.pickaxe14_craftImage.gameObject.SetActive(false);
		if (this.pickaxeNumber == 0)
		{
			this.pickaxe1_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 1)
		{
			this.pickaxe2_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 2)
		{
			this.pickaxe3_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 3)
		{
			this.pickaxe4_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 4)
		{
			this.pickaxe5_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 5)
		{
			this.pickaxe6_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 6)
		{
			this.pickaxe7_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 7)
		{
			this.pickaxe8_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 8)
		{
			this.pickaxe9_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 9)
		{
			this.pickaxe10_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 10)
		{
			this.pickaxe11_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 11)
		{
			this.pickaxe12_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 12)
		{
			this.pickaxe13_craftImage.gameObject.SetActive(true);
		}
		if (this.pickaxeNumber == 13)
		{
			if (TheAnvil.pickaxe14_equipped)
			{
				this.skinLeftBTN.SetActive(false);
				this.skinRightBTN.SetActive(false);
				this.skinText.gameObject.SetActive(false);
				this.allSkinsFrame.transform.localPosition = new Vector2(0f, 0f);
			}
			this.pickaxe14_craftImage.gameObject.SetActive(true);
			this.diamondPickaxeQuestionMark.SetActive(true);
			if (TheAnvil.pickaxe14_crafted)
			{
				this.SetImageToWhite(this.pickaxe14_topImage);
				this.SetImageToWhite(this.pickaxe14_craftImage);
				this.diamondPickaxeQuestionMark.SetActive(false);
			}
		}
		else if (!TheAnvil.pickaxe14_equipped)
		{
			this.skinLeftBTN.SetActive(true);
			this.skinRightBTN.SetActive(true);
			this.skinText.gameObject.SetActive(true);
			this.allSkinsFrame.transform.localPosition = new Vector2(0f, -7f);
		}
		this.CheckPickaxes();
		if (!TheAnvil.isDLC)
		{
			this.SetSkinsOff(false);
		}
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x0000C704 File Offset: 0x0000A904
	public void CheckPickaxeName()
	{
		if (TheAnvil.pickaxe1_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe1_name;
		}
		if (TheAnvil.pickaxe2_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe2_name;
		}
		if (TheAnvil.pickaxe3_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe3_name;
		}
		if (TheAnvil.pickaxe4_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe4_name;
		}
		if (TheAnvil.pickaxe5_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe5_name;
		}
		if (TheAnvil.pickaxe6_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe6_name;
		}
		if (TheAnvil.pickaxe7_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe7_name;
		}
		if (TheAnvil.pickaxe8_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe8_name;
		}
		if (TheAnvil.pickaxe9_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe9_name;
		}
		if (TheAnvil.pickaxe10_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe10_name;
		}
		if (TheAnvil.pickaxe11_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe11_name;
		}
		if (TheAnvil.pickaxe12_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe12_name;
		}
		if (TheAnvil.pickaxe13_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe13_name;
		}
		if (TheAnvil.pickaxe14_equipped)
		{
			this.equippedPickaxeName.text = LocalizationScript.pickaxe14_name;
		}
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x0000C854 File Offset: 0x0000AA54
	public void CheckPickaxes()
	{
		this.pickaxeStatsParent.SetActive(false);
		this.pickaxePriceParent.SetActive(false);
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		if (this.pickaxeNumber == 0 && TheAnvil.pickaxe1_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe1_name;
		}
		if (this.pickaxeNumber == 1 && TheAnvil.pickaxe2_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe2_name;
		}
		if (this.pickaxeNumber == 2 && TheAnvil.pickaxe3_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe3_name;
		}
		if (this.pickaxeNumber == 3 && TheAnvil.pickaxe4_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe4_name;
		}
		if (this.pickaxeNumber == 4 && TheAnvil.pickaxe5_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe5_name;
		}
		if (this.pickaxeNumber == 5 && TheAnvil.pickaxe6_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe6_name;
		}
		if (this.pickaxeNumber == 6 && TheAnvil.pickaxe7_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe7_name;
		}
		if (this.pickaxeNumber == 7 && TheAnvil.pickaxe8_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe8_name;
		}
		if (this.pickaxeNumber == 8 && TheAnvil.pickaxe9_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe9_name;
		}
		if (this.pickaxeNumber == 9 && TheAnvil.pickaxe10_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe10_name;
		}
		if (this.pickaxeNumber == 10 && TheAnvil.pickaxe11_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe11_name;
		}
		if (this.pickaxeNumber == 11 && TheAnvil.pickaxe12_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe12_name;
		}
		if (this.pickaxeNumber == 12 && TheAnvil.pickaxe13_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe13_name;
		}
		if (this.pickaxeNumber == 13 && TheAnvil.pickaxe14_equipped)
		{
			flag3 = true;
			this.equippedPickaxeName.text = LocalizationScript.pickaxe14_name;
		}
		if (this.pickaxeNumber == 0 && TheAnvil.pickaxe1_crafted && !TheAnvil.pickaxe1_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 1 && TheAnvil.pickaxe2_crafted && !TheAnvil.pickaxe2_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 2 && TheAnvil.pickaxe3_crafted && !TheAnvil.pickaxe3_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 3 && TheAnvil.pickaxe4_crafted && !TheAnvil.pickaxe4_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 4 && TheAnvil.pickaxe5_crafted && !TheAnvil.pickaxe5_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 5 && TheAnvil.pickaxe6_crafted && !TheAnvil.pickaxe6_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 6 && TheAnvil.pickaxe7_crafted && !TheAnvil.pickaxe7_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 7 && TheAnvil.pickaxe8_crafted && !TheAnvil.pickaxe8_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 8 && TheAnvil.pickaxe9_crafted && !TheAnvil.pickaxe9_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 9 && TheAnvil.pickaxe10_crafted && !TheAnvil.pickaxe10_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 10 && TheAnvil.pickaxe11_crafted && !TheAnvil.pickaxe11_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 11 && TheAnvil.pickaxe12_crafted && !TheAnvil.pickaxe12_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 12 && TheAnvil.pickaxe13_crafted && !TheAnvil.pickaxe13_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 13 && TheAnvil.pickaxe14_crafted && !TheAnvil.pickaxe14_equipped)
		{
			flag4 = true;
			flag2 = true;
		}
		if (this.pickaxeNumber == 1 && !TheAnvil.pickaxe2_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 2 && !TheAnvil.pickaxe3_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 3 && !TheAnvil.pickaxe4_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 4 && !TheAnvil.pickaxe5_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 5 && !TheAnvil.pickaxe6_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 6 && !TheAnvil.pickaxe7_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 7 && !TheAnvil.pickaxe8_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 8 && !TheAnvil.pickaxe9_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 9 && !TheAnvil.pickaxe10_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 10 && !TheAnvil.pickaxe11_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 11 && !TheAnvil.pickaxe12_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 12 && !TheAnvil.pickaxe13_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 13 && !TheAnvil.pickaxe14_crafted)
		{
			flag = true;
			this.topPickaxeName.text = "?????????";
		}
		if (this.pickaxeNumber == 0 && TheAnvil.pickaxe1_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe1_name;
		}
		if (this.pickaxeNumber == 1 && TheAnvil.pickaxe2_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe2_name;
		}
		if (this.pickaxeNumber == 2 && TheAnvil.pickaxe3_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe3_name;
		}
		if (this.pickaxeNumber == 3 && TheAnvil.pickaxe4_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe4_name;
		}
		if (this.pickaxeNumber == 4 && TheAnvil.pickaxe5_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe5_name;
		}
		if (this.pickaxeNumber == 5 && TheAnvil.pickaxe6_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe6_name;
		}
		if (this.pickaxeNumber == 6 && TheAnvil.pickaxe7_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe7_name;
		}
		if (this.pickaxeNumber == 7 && TheAnvil.pickaxe8_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe8_name;
		}
		if (this.pickaxeNumber == 8 && TheAnvil.pickaxe9_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe9_name;
		}
		if (this.pickaxeNumber == 9 && TheAnvil.pickaxe10_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe10_name;
		}
		if (this.pickaxeNumber == 10 && TheAnvil.pickaxe11_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe11_name;
		}
		if (this.pickaxeNumber == 11 && TheAnvil.pickaxe12_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe12_name;
		}
		if (this.pickaxeNumber == 12 && TheAnvil.pickaxe13_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe13_name;
		}
		if (this.pickaxeNumber == 13 && TheAnvil.pickaxe14_crafted)
		{
			this.topPickaxeName.text = LocalizationScript.pickaxe14_name;
		}
		if (this.pickaxeNumber == 0)
		{
			this.ComparePickaxeStats(0, TheAnvil.pickaxe1_mineTime + TheAnvil.collTime, TheAnvil.pickaxe1_minePower, TheAnvil.pickaxe1_2XChance, TheAnvil.pickaxe1_miningAreaSize);
		}
		if (this.pickaxeNumber == 1)
		{
			this.ComparePickaxeStats(1, TheAnvil.pickaxe2_mineTime + TheAnvil.collTime, TheAnvil.pickaxe2_minePower, TheAnvil.pickaxe2_2XChance, TheAnvil.pickaxe2_miningAreaSize);
		}
		if (this.pickaxeNumber == 2)
		{
			this.ComparePickaxeStats(2, TheAnvil.pickaxe3_mineTime + TheAnvil.collTime, TheAnvil.pickaxe3_minePower, TheAnvil.pickaxe3_2XChance, TheAnvil.pickaxe3_miningAreaSize);
		}
		if (this.pickaxeNumber == 3)
		{
			this.ComparePickaxeStats(3, TheAnvil.pickaxe4_mineTime + TheAnvil.collTime, TheAnvil.pickaxe4_minePower, TheAnvil.pickaxe4_2XChance, TheAnvil.pickaxe4_miningAreaSize);
		}
		if (this.pickaxeNumber == 4)
		{
			this.ComparePickaxeStats(4, TheAnvil.pickaxe5_mineTime + TheAnvil.collTime, TheAnvil.pickaxe5_minePower, TheAnvil.pickaxe5_2XChance, TheAnvil.pickaxe5_miningAreaSize);
		}
		if (this.pickaxeNumber == 5)
		{
			this.ComparePickaxeStats(5, TheAnvil.pickaxe6_mineTime + TheAnvil.collTime, TheAnvil.pickaxe6_minePower, TheAnvil.pickaxe6_2XChance, TheAnvil.pickaxe6_miningAreaSize);
		}
		if (this.pickaxeNumber == 6)
		{
			this.ComparePickaxeStats(6, TheAnvil.pickaxe7_mineTime + TheAnvil.collTime, TheAnvil.pickaxe7_minePower, TheAnvil.pickaxe7_2XChance, TheAnvil.pickaxe7_miningAreaSize);
		}
		if (this.pickaxeNumber == 7)
		{
			this.ComparePickaxeStats(7, TheAnvil.pickaxe8_mineTime + TheAnvil.collTime, TheAnvil.pickaxe8_minePower, TheAnvil.pickaxe8_2XChance, TheAnvil.pickaxe8_miningAreaSize);
		}
		if (this.pickaxeNumber == 8)
		{
			this.ComparePickaxeStats(8, TheAnvil.pickaxe9_mineTime + TheAnvil.collTime, TheAnvil.pickaxe9_minePower, TheAnvil.pickaxe9_2XChance, TheAnvil.pickaxe9_miningAreaSize);
		}
		if (this.pickaxeNumber == 9)
		{
			this.ComparePickaxeStats(9, TheAnvil.pickaxe10_mineTime + TheAnvil.collTime, TheAnvil.pickaxe10_minePower, TheAnvil.pickaxe10_2XChance, TheAnvil.pickaxe10_miningAreaSize);
		}
		if (this.pickaxeNumber == 10)
		{
			this.ComparePickaxeStats(10, TheAnvil.pickaxe11_mineTime + TheAnvil.collTime, TheAnvil.pickaxe11_minePower, TheAnvil.pickaxe11_2XChance, TheAnvil.pickaxe11_miningAreaSize);
		}
		if (this.pickaxeNumber == 11)
		{
			this.ComparePickaxeStats(11, TheAnvil.pickaxe12_mineTime + TheAnvil.collTime, TheAnvil.pickaxe12_minePower, TheAnvil.pickaxe12_2XChance, TheAnvil.pickaxe12_miningAreaSize);
		}
		if (this.pickaxeNumber == 12)
		{
			this.ComparePickaxeStats(12, TheAnvil.pickaxe13_mineTime + TheAnvil.collTime, TheAnvil.pickaxe13_minePower, TheAnvil.pickaxe13_2XChance, TheAnvil.pickaxe13_miningAreaSize);
		}
		if (this.pickaxeNumber == 13)
		{
			this.ComparePickaxeStats(13, TheAnvil.pickaxe14_mineTime + TheAnvil.collTime, TheAnvil.pickaxe14_minePower, TheAnvil.pickaxe14_2XChance, TheAnvil.pickaxe14_miningAreaSize);
		}
		if (flag3)
		{
			this.darkPickaxeParent.SetActive(false);
			this.pickaxeStatsParent.SetActive(true);
			this.pickaxePriceParent.SetActive(false);
		}
		else if (flag4)
		{
			this.darkPickaxeParent.SetActive(true);
			this.pickaxeStatsParent.SetActive(true);
			this.pickaxePriceParent.SetActive(false);
		}
		if (flag2)
		{
			this.darkPickaxeParent.SetActive(true);
			this.holdToCraftText.text = LocalizationScript.clickToEquip;
			this.pickaxeStatsParent.SetActive(true);
			this.pickaxePriceParent.SetActive(false);
		}
		if (flag)
		{
			this.darkPickaxeParent.SetActive(true);
			int num = 0;
			GameObject gameObject = this.goldCraftPrice.gameObject;
			GameObject gameObject2 = this.copperCraftPrice.gameObject;
			GameObject gameObject3 = this.ironCraftPRice.gameObject;
			if (this.pickaxeNumber == 1)
			{
				num = 1;
				gameObject = this.goldCraftPrice.gameObject;
			}
			if (this.pickaxeNumber == 2)
			{
				num = 2;
				gameObject = this.goldCraftPrice.gameObject;
				gameObject2 = this.copperCraftPrice.gameObject;
			}
			if (this.pickaxeNumber == 3)
			{
				num = 2;
				gameObject = this.copperCraftPrice.gameObject;
				gameObject2 = this.ironCraftPRice.gameObject;
			}
			if (this.pickaxeNumber == 4)
			{
				num = 2;
				gameObject = this.goldCraftPrice.gameObject;
				gameObject2 = this.ironCraftPRice.gameObject;
			}
			if (this.pickaxeNumber == 5)
			{
				num = 2;
				gameObject = this.goldCraftPrice.gameObject;
				gameObject2 = this.cobaltCraftPrice.gameObject;
			}
			if (this.pickaxeNumber == 6)
			{
				num = 3;
				gameObject = this.goldCraftPrice.gameObject;
				gameObject2 = this.ironCraftPRice.gameObject;
				gameObject3 = this.copperCraftPrice.gameObject;
			}
			if (this.pickaxeNumber == 7)
			{
				num = 2;
				gameObject = this.cobaltCraftPrice.gameObject;
				gameObject2 = this.uraniumCraftPrice.gameObject;
			}
			if (this.pickaxeNumber == 8)
			{
				num = 3;
				gameObject = this.goldCraftPrice.gameObject;
				gameObject2 = this.uraniumCraftPrice.gameObject;
				gameObject3 = this.ismiumCraftPrice.gameObject;
			}
			if (this.pickaxeNumber == 9)
			{
				num = 3;
				gameObject = this.goldCraftPrice.gameObject;
				gameObject2 = this.copperCraftPrice.gameObject;
				gameObject3 = this.iridiumCraftPrice.gameObject;
			}
			if (this.pickaxeNumber == 10)
			{
				num = 3;
				gameObject = this.cobaltCraftPrice.gameObject;
				gameObject2 = this.uraniumCraftPrice.gameObject;
				gameObject3 = this.ismiumCraftPrice.gameObject;
			}
			if (this.pickaxeNumber == 11)
			{
				num = 2;
				gameObject = this.goldCraftPrice.gameObject;
				gameObject2 = this.iridiumCraftPrice.gameObject;
			}
			if (this.pickaxeNumber == 12)
			{
				num = 3;
				gameObject = this.goldCraftPrice.gameObject;
				gameObject2 = this.ironCraftPRice.gameObject;
				gameObject3 = this.painiteCraftPrice.gameObject;
			}
			int num2 = this.pickaxeNumber;
			gameObject.SetActive(false);
			gameObject2.SetActive(false);
			gameObject3.SetActive(false);
			this.goldCraftPrice.gameObject.SetActive(false);
			this.copperCraftPrice.gameObject.SetActive(false);
			this.ironCraftPRice.gameObject.SetActive(false);
			this.cobaltCraftPrice.gameObject.SetActive(false);
			this.uraniumCraftPrice.gameObject.SetActive(false);
			this.ismiumCraftPrice.gameObject.SetActive(false);
			this.iridiumCraftPrice.gameObject.SetActive(false);
			this.painiteCraftPrice.gameObject.SetActive(false);
			if (num == 1)
			{
				gameObject.SetActive(true);
				gameObject.transform.localScale = new Vector2(1.3f, 1.3f);
				gameObject.transform.localPosition = new Vector2(-18f, -47f);
			}
			if (num == 2)
			{
				gameObject.SetActive(true);
				gameObject2.SetActive(true);
				gameObject.transform.localScale = new Vector2(0.93f, 0.93f);
				gameObject.transform.localPosition = new Vector2(-14f, -36f);
				gameObject2.transform.localScale = new Vector2(0.93f, 0.93f);
				gameObject2.transform.localPosition = new Vector2(-14f, -82f);
			}
			if (num == 3)
			{
				gameObject.SetActive(true);
				gameObject2.SetActive(true);
				gameObject3.SetActive(true);
				gameObject.transform.localScale = new Vector2(0.7f, 0.7f);
				gameObject.transform.localPosition = new Vector2(-11f, -31f);
				gameObject2.transform.localScale = new Vector2(0.7f, 0.7f);
				gameObject2.transform.localPosition = new Vector2(-11f, -66f);
				gameObject3.transform.localScale = new Vector2(0.7f, 0.7f);
				gameObject3.transform.localPosition = new Vector2(-11f, -102f);
			}
			this.holdToCraftText.text = LocalizationScript.holdToCraft;
			this.pickaxeStatsParent.SetActive(false);
			this.pickaxePriceParent.SetActive(true);
		}
		if (!SkillTree.spawnCopper_purchased)
		{
			this.copperBar.SetActive(false);
			this.copperQuestionmark.SetActive(true);
		}
		else
		{
			this.copperBar.SetActive(true);
			this.copperQuestionmark.SetActive(false);
		}
		if (!SkillTree.spawnIron_purchased)
		{
			this.ironBar.SetActive(false);
			this.ironQuestionmark.SetActive(true);
		}
		else
		{
			this.ironBar.SetActive(true);
			this.ironQuestionmark.SetActive(false);
		}
		if (!SkillTree.cobaltSpawn_purchased)
		{
			this.cobaltBar.SetActive(false);
			this.cobaltQuestionmark.SetActive(true);
		}
		else
		{
			this.cobaltBar.SetActive(true);
			this.cobaltQuestionmark.SetActive(false);
		}
		if (!SkillTree.uraniumSpawn_purchased)
		{
			this.uraniumBar.SetActive(false);
			this.uraniumQuestionmark.SetActive(true);
		}
		else
		{
			this.uraniumBar.SetActive(true);
			this.uraniumQuestionmark.SetActive(false);
		}
		if (!SkillTree.ismiumSpawn_purchased)
		{
			this.ismiumBar.SetActive(false);
			this.ismiumQuestionmark.SetActive(true);
		}
		else
		{
			this.ismiumBar.SetActive(true);
			this.ismiumQuestionmark.SetActive(false);
		}
		if (!SkillTree.iridiumSpawn_purchased)
		{
			this.iridiumBar.SetActive(false);
			this.iridiumQuestionmark.SetActive(true);
		}
		else
		{
			this.iridiumBar.SetActive(true);
			this.iridiumQuestionmark.SetActive(false);
		}
		if (!SkillTree.painiteSpawn_purchased)
		{
			this.painiteBar.SetActive(false);
			this.painiteQuestionmark.SetActive(true);
			return;
		}
		this.painiteBar.SetActive(true);
		this.painiteQuestionmark.SetActive(false);
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
	public void ComparePickaxeStats(int number, float mineTime, float minePower, float doubleChance, float miningErea)
	{
		this.red1.SetActive(false);
		this.green1.SetActive(false);
		this.white1.SetActive(false);
		this.red2.SetActive(false);
		this.green2.SetActive(false);
		this.white2.SetActive(false);
		this.red3.SetActive(false);
		this.green3.SetActive(false);
		this.white3.SetActive(false);
		this.red4.SetActive(false);
		this.green4.SetActive(false);
		this.white4.SetActive(false);
		float num = mineTime / (1f + SkillTree.reducePickaxeMineTime);
		float num2;
		if (Artifacts.wolfClaw_found)
		{
			num2 = Artifacts.clawChance * (1f + Artifacts.runeImproveAll + LevelMechanics.archeologistIncrease);
		}
		else
		{
			num2 = 0f;
		}
		float num3 = minePower * (SkillTree.improvedPickaxeStrength + num2 + SetRockScreen.potionPickaxeStats_increase);
		float num4 = doubleChance * (SkillTree.improvedPickaxeStrength + SetRockScreen.potionPickaxeStats_increase);
		float num5 = miningErea * (SkillTree.improvedPickaxeStrength + SetRockScreen.potionPickaxeStats_increase + LevelMechanics.shapeShifterSizeIncrease);
		num5 *= SkillTree.miningAreaSize;
		this.mineTime_displayText.text = num.ToString("F2") + "s";
		this.minePower_displayText.text = num3.ToString("F2");
		this.doublePowerChance_displayText.text = num4.ToString("F2") + "%";
		this.miningArea_displayText.text = (num5.ToString("F2") ?? "");
		bool flag = false;
		if (number == 0 && TheAnvil.pickaxe1_equipped)
		{
			flag = true;
		}
		if (number == 1 && TheAnvil.pickaxe2_equipped)
		{
			flag = true;
		}
		if (number == 2 && TheAnvil.pickaxe3_equipped)
		{
			flag = true;
		}
		if (number == 3 && TheAnvil.pickaxe4_equipped)
		{
			flag = true;
		}
		if (number == 4 && TheAnvil.pickaxe5_equipped)
		{
			flag = true;
		}
		if (number == 5 && TheAnvil.pickaxe6_equipped)
		{
			flag = true;
		}
		if (number == 6 && TheAnvil.pickaxe7_equipped)
		{
			flag = true;
		}
		if (number == 7 && TheAnvil.pickaxe8_equipped)
		{
			flag = true;
		}
		if (number == 8 && TheAnvil.pickaxe9_equipped)
		{
			flag = true;
		}
		if (number == 9 && TheAnvil.pickaxe10_equipped)
		{
			flag = true;
		}
		if (number == 10 && TheAnvil.pickaxe11_equipped)
		{
			flag = true;
		}
		if (number == 11 && TheAnvil.pickaxe12_equipped)
		{
			flag = true;
		}
		if (number == 12 && TheAnvil.pickaxe13_equipped)
		{
			flag = true;
		}
		if (number == 13 && TheAnvil.pickaxe14_equipped)
		{
			flag = true;
		}
		if (flag)
		{
			this.white1.SetActive(true);
			this.white2.SetActive(true);
			this.white3.SetActive(true);
			this.white4.SetActive(true);
			return;
		}
		if (mineTime < TheAnvil.equippedMineTime)
		{
			this.green1.SetActive(true);
		}
		else if (mineTime == TheAnvil.equippedMineTime)
		{
			this.white1.SetActive(true);
		}
		else
		{
			this.red1.SetActive(true);
		}
		if (minePower > TheAnvil.equippedMinePower)
		{
			this.green2.SetActive(true);
		}
		else if (minePower == TheAnvil.equippedMinePower)
		{
			this.white2.SetActive(true);
		}
		else
		{
			this.red2.SetActive(true);
		}
		if (doubleChance > TheAnvil.equipped2XChance)
		{
			this.green3.SetActive(true);
		}
		else if (doubleChance == TheAnvil.equipped2XChance)
		{
			this.white3.SetActive(true);
		}
		else
		{
			this.red3.SetActive(true);
		}
		if (miningErea > TheAnvil.equippedMiningArea)
		{
			this.green4.SetActive(true);
			return;
		}
		if (miningErea == TheAnvil.equippedMiningArea)
		{
			this.white4.SetActive(true);
			return;
		}
		this.red4.SetActive(true);
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x0000DC2C File Offset: 0x0000BE2C
	public void SetImageToWhite(Image image)
	{
		if (image != null)
		{
			image.color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		}
	}

	// Token: 0x060000AA RID: 170 RVA: 0x0000DC5B File Offset: 0x0000BE5B
	public void SetImageToDark(Image image)
	{
		if (image != null)
		{
			image.color = new Color32(0, 0, 0, 215);
		}
	}

	// Token: 0x060000AB RID: 171 RVA: 0x0000DC7E File Offset: 0x0000BE7E
	public void SetDiamondPickaxeWhite()
	{
		this.SetImageToWhite(this.pickaxe14_topImage);
		this.SetImageToWhite(this.pickaxe14_craftImage);
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0000DC98 File Offset: 0x0000BE98
	public void LoadData(GameData data)
	{
		TheAnvil.totalPickaxesCrafted = data.totalPickaxesCrafted;
		TheAnvil.pickaxe1_skinsChosen = data.pickaxe1_skinsChosen;
		TheAnvil.pickaxe2_skinsChosen = data.pickaxe2_skinsChosen;
		TheAnvil.pickaxe3_skinsChosen = data.pickaxe3_skinsChosen;
		TheAnvil.pickaxe4_skinsChosen = data.pickaxe4_skinsChosen;
		TheAnvil.pickaxe5_skinsChosen = data.pickaxe5_skinsChosen;
		TheAnvil.pickaxe6_skinsChosen = data.pickaxe6_skinsChosen;
		TheAnvil.pickaxe7_skinsChosen = data.pickaxe7_skinsChosen;
		TheAnvil.pickaxe8_skinsChosen = data.pickaxe8_skinsChosen;
		TheAnvil.pickaxe9_skinsChosen = data.pickaxe9_skinsChosen;
		TheAnvil.pickaxe10_skinsChosen = data.pickaxe10_skinsChosen;
		TheAnvil.pickaxe11_skinsChosen = data.pickaxe11_skinsChosen;
		TheAnvil.pickaxe12_skinsChosen = data.pickaxe12_skinsChosen;
		TheAnvil.pickaxe13_skinsChosen = data.pickaxe13_skinsChosen;
		TheAnvil.isTheAnvilUnlocked = data.isTheAnvilUnlocked;
		TheAnvil.pickaxe1_crafted = data.pickaxe1_crafted;
		TheAnvil.pickaxe2_crafted = data.pickaxe2_crafted;
		TheAnvil.pickaxe3_crafted = data.pickaxe3_crafted;
		TheAnvil.pickaxe4_crafted = data.pickaxe4_crafted;
		TheAnvil.pickaxe5_crafted = data.pickaxe5_crafted;
		TheAnvil.pickaxe6_crafted = data.pickaxe6_crafted;
		TheAnvil.pickaxe7_crafted = data.pickaxe7_crafted;
		TheAnvil.pickaxe8_crafted = data.pickaxe8_crafted;
		TheAnvil.pickaxe9_crafted = data.pickaxe9_crafted;
		TheAnvil.pickaxe10_crafted = data.pickaxe10_crafted;
		TheAnvil.pickaxe11_crafted = data.pickaxe11_crafted;
		TheAnvil.pickaxe12_crafted = data.pickaxe12_crafted;
		TheAnvil.pickaxe13_crafted = data.pickaxe13_crafted;
		TheAnvil.pickaxe14_crafted = data.pickaxe14_crafted;
		TheAnvil.pickaxe1_equipped = data.pickaxe1_equipped;
		TheAnvil.pickaxe2_equipped = data.pickaxe2_equipped;
		TheAnvil.pickaxe3_equipped = data.pickaxe3_equipped;
		TheAnvil.pickaxe4_equipped = data.pickaxe4_equipped;
		TheAnvil.pickaxe5_equipped = data.pickaxe5_equipped;
		TheAnvil.pickaxe6_equipped = data.pickaxe6_equipped;
		TheAnvil.pickaxe7_equipped = data.pickaxe7_equipped;
		TheAnvil.pickaxe8_equipped = data.pickaxe8_equipped;
		TheAnvil.pickaxe9_equipped = data.pickaxe9_equipped;
		TheAnvil.pickaxe10_equipped = data.pickaxe10_equipped;
		TheAnvil.pickaxe11_equipped = data.pickaxe11_equipped;
		TheAnvil.pickaxe12_equipped = data.pickaxe12_equipped;
		TheAnvil.pickaxe13_equipped = data.pickaxe13_equipped;
		TheAnvil.pickaxe14_equipped = data.pickaxe14_equipped;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x0000DE80 File Offset: 0x0000C080
	public void SaveData(ref GameData data)
	{
		data.totalPickaxesCrafted = TheAnvil.totalPickaxesCrafted;
		data.pickaxe1_skinsChosen = TheAnvil.pickaxe1_skinsChosen;
		data.pickaxe2_skinsChosen = TheAnvil.pickaxe2_skinsChosen;
		data.pickaxe3_skinsChosen = TheAnvil.pickaxe3_skinsChosen;
		data.pickaxe4_skinsChosen = TheAnvil.pickaxe4_skinsChosen;
		data.pickaxe5_skinsChosen = TheAnvil.pickaxe5_skinsChosen;
		data.pickaxe6_skinsChosen = TheAnvil.pickaxe6_skinsChosen;
		data.pickaxe7_skinsChosen = TheAnvil.pickaxe7_skinsChosen;
		data.pickaxe8_skinsChosen = TheAnvil.pickaxe8_skinsChosen;
		data.pickaxe9_skinsChosen = TheAnvil.pickaxe9_skinsChosen;
		data.pickaxe10_skinsChosen = TheAnvil.pickaxe10_skinsChosen;
		data.pickaxe11_skinsChosen = TheAnvil.pickaxe11_skinsChosen;
		data.pickaxe12_skinsChosen = TheAnvil.pickaxe12_skinsChosen;
		data.pickaxe13_skinsChosen = TheAnvil.pickaxe13_skinsChosen;
		data.isTheAnvilUnlocked = TheAnvil.isTheAnvilUnlocked;
		data.pickaxe1_crafted = TheAnvil.pickaxe1_crafted;
		data.pickaxe2_crafted = TheAnvil.pickaxe2_crafted;
		data.pickaxe3_crafted = TheAnvil.pickaxe3_crafted;
		data.pickaxe4_crafted = TheAnvil.pickaxe4_crafted;
		data.pickaxe5_crafted = TheAnvil.pickaxe5_crafted;
		data.pickaxe6_crafted = TheAnvil.pickaxe6_crafted;
		data.pickaxe7_crafted = TheAnvil.pickaxe7_crafted;
		data.pickaxe8_crafted = TheAnvil.pickaxe8_crafted;
		data.pickaxe9_crafted = TheAnvil.pickaxe9_crafted;
		data.pickaxe10_crafted = TheAnvil.pickaxe10_crafted;
		data.pickaxe11_crafted = TheAnvil.pickaxe11_crafted;
		data.pickaxe12_crafted = TheAnvil.pickaxe12_crafted;
		data.pickaxe13_crafted = TheAnvil.pickaxe13_crafted;
		data.pickaxe14_crafted = TheAnvil.pickaxe14_crafted;
		data.pickaxe1_equipped = TheAnvil.pickaxe1_equipped;
		data.pickaxe2_equipped = TheAnvil.pickaxe2_equipped;
		data.pickaxe3_equipped = TheAnvil.pickaxe3_equipped;
		data.pickaxe4_equipped = TheAnvil.pickaxe4_equipped;
		data.pickaxe5_equipped = TheAnvil.pickaxe5_equipped;
		data.pickaxe6_equipped = TheAnvil.pickaxe6_equipped;
		data.pickaxe7_equipped = TheAnvil.pickaxe7_equipped;
		data.pickaxe8_equipped = TheAnvil.pickaxe8_equipped;
		data.pickaxe9_equipped = TheAnvil.pickaxe9_equipped;
		data.pickaxe10_equipped = TheAnvil.pickaxe10_equipped;
		data.pickaxe11_equipped = TheAnvil.pickaxe11_equipped;
		data.pickaxe12_equipped = TheAnvil.pickaxe12_equipped;
		data.pickaxe13_equipped = TheAnvil.pickaxe13_equipped;
		data.pickaxe14_equipped = TheAnvil.pickaxe14_equipped;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x0000E094 File Offset: 0x0000C294
	public void ResetAnvil()
	{
		TheAnvil.totalPickaxesCrafted = 0;
		this.pickaxe1_skins[0].SetActive(false);
		this.pickaxe1_skins[1].SetActive(false);
		this.pickaxe1_skins[2].SetActive(false);
		this.pickaxe2_skins[0].SetActive(false);
		this.pickaxe2_skins[1].SetActive(false);
		this.pickaxe2_skins[2].SetActive(false);
		this.pickaxe3_skins[0].SetActive(false);
		this.pickaxe3_skins[1].SetActive(false);
		this.pickaxe3_skins[2].SetActive(false);
		this.pickaxe4_skins[0].SetActive(false);
		this.pickaxe4_skins[1].SetActive(false);
		this.pickaxe4_skins[2].SetActive(false);
		this.pickaxe5_skins[0].SetActive(false);
		this.pickaxe5_skins[1].SetActive(false);
		this.pickaxe5_skins[2].SetActive(false);
		this.pickaxe6_skins[0].SetActive(false);
		this.pickaxe6_skins[1].SetActive(false);
		this.pickaxe6_skins[2].SetActive(false);
		this.pickaxe7_skins[0].SetActive(false);
		this.pickaxe7_skins[1].SetActive(false);
		this.pickaxe7_skins[2].SetActive(false);
		this.pickaxe8_skins[0].SetActive(false);
		this.pickaxe8_skins[1].SetActive(false);
		this.pickaxe8_skins[2].SetActive(false);
		this.pickaxe9_skins[0].SetActive(false);
		this.pickaxe9_skins[1].SetActive(false);
		this.pickaxe9_skins[2].SetActive(false);
		this.pickaxe10_skins[0].SetActive(false);
		this.pickaxe10_skins[1].SetActive(false);
		this.pickaxe10_skins[2].SetActive(false);
		this.pickaxe11_skins[0].SetActive(false);
		this.pickaxe11_skins[1].SetActive(false);
		this.pickaxe11_skins[2].SetActive(false);
		this.pickaxe12_skins[0].SetActive(false);
		this.pickaxe12_skins[1].SetActive(false);
		this.pickaxe12_skins[2].SetActive(false);
		this.pickaxe13_skins[0].SetActive(false);
		this.pickaxe13_skins[1].SetActive(false);
		this.pickaxe13_skins[2].SetActive(false);
		TheAnvil.pickaxe1_skinsChosen = 0;
		TheAnvil.pickaxe2_skinsChosen = 0;
		TheAnvil.pickaxe3_skinsChosen = 0;
		TheAnvil.pickaxe4_skinsChosen = 0;
		TheAnvil.pickaxe5_skinsChosen = 0;
		TheAnvil.pickaxe6_skinsChosen = 0;
		TheAnvil.pickaxe7_skinsChosen = 0;
		TheAnvil.pickaxe8_skinsChosen = 0;
		TheAnvil.pickaxe9_skinsChosen = 0;
		TheAnvil.pickaxe10_skinsChosen = 0;
		TheAnvil.pickaxe11_skinsChosen = 0;
		TheAnvil.pickaxe12_skinsChosen = 0;
		TheAnvil.pickaxe13_skinsChosen = 0;
		TheAnvil.isTheAnvilUnlocked = false;
		TheAnvil.pickaxe1_crafted = true;
		TheAnvil.pickaxe2_crafted = false;
		TheAnvil.pickaxe3_crafted = false;
		TheAnvil.pickaxe4_crafted = false;
		TheAnvil.pickaxe5_crafted = false;
		TheAnvil.pickaxe6_crafted = false;
		TheAnvil.pickaxe7_crafted = false;
		TheAnvil.pickaxe8_crafted = false;
		TheAnvil.pickaxe9_crafted = false;
		TheAnvil.pickaxe10_crafted = false;
		TheAnvil.pickaxe11_crafted = false;
		TheAnvil.pickaxe12_crafted = false;
		TheAnvil.pickaxe13_crafted = false;
		TheAnvil.pickaxe14_crafted = false;
		TheAnvil.pickaxe1_equipped = true;
		TheAnvil.pickaxe2_equipped = false;
		TheAnvil.pickaxe3_equipped = false;
		TheAnvil.pickaxe4_equipped = false;
		TheAnvil.pickaxe5_equipped = false;
		TheAnvil.pickaxe6_equipped = false;
		TheAnvil.pickaxe7_equipped = false;
		TheAnvil.pickaxe8_equipped = false;
		TheAnvil.pickaxe9_equipped = false;
		TheAnvil.pickaxe10_equipped = false;
		TheAnvil.pickaxe11_equipped = false;
		TheAnvil.pickaxe12_equipped = false;
		TheAnvil.pickaxe13_equipped = false;
		TheAnvil.pickaxe14_equipped = false;
		this.playSound = false;
		base.StopAllCoroutines();
		this.EquipPickaxe(0);
		this.SetImageToDark(this.pickaxe2_topImage);
		this.SetImageToDark(this.pickaxe2_craftImage);
		this.SetImageToDark(this.pickaxe3_topImage);
		this.SetImageToDark(this.pickaxe3_craftImage);
		this.SetImageToDark(this.pickaxe4_topImage);
		this.SetImageToDark(this.pickaxe4_craftImage);
		this.SetImageToDark(this.pickaxe5_topImage);
		this.SetImageToDark(this.pickaxe5_craftImage);
		this.SetImageToDark(this.pickaxe6_topImage);
		this.SetImageToDark(this.pickaxe6_craftImage);
		this.SetImageToDark(this.pickaxe7_topImage);
		this.SetImageToDark(this.pickaxe7_craftImage);
		this.SetImageToDark(this.pickaxe8_topImage);
		this.SetImageToDark(this.pickaxe8_craftImage);
		this.SetImageToDark(this.pickaxe9_topImage);
		this.SetImageToDark(this.pickaxe9_craftImage);
		this.SetImageToDark(this.pickaxe10_topImage);
		this.SetImageToDark(this.pickaxe10_craftImage);
		this.SetImageToDark(this.pickaxe11_topImage);
		this.SetImageToDark(this.pickaxe11_craftImage);
		this.SetImageToDark(this.pickaxe12_topImage);
		this.SetImageToDark(this.pickaxe12_craftImage);
		this.SetImageToDark(this.pickaxe13_topImage);
		this.SetImageToDark(this.pickaxe13_craftImage);
		this.SetImageToDark(this.pickaxe14_topImage);
		this.SetImageToDark(this.pickaxe14_craftImage);
		this.CheckPickaxes();
		this.pickaxeNumber = 1;
		this.PickaxeSlection(false);
		this.playSound = true;
	}

	// Token: 0x0400028E RID: 654
	public AudioManager audioManager;

	// Token: 0x0400028F RID: 655
	public GoldAndOreMechanics goldAndOreScript;

	// Token: 0x04000290 RID: 656
	public Achievements achScript;

	// Token: 0x04000291 RID: 657
	public GameObject copperBar;

	// Token: 0x04000292 RID: 658
	public GameObject ironBar;

	// Token: 0x04000293 RID: 659
	public GameObject cobaltBar;

	// Token: 0x04000294 RID: 660
	public GameObject uraniumBar;

	// Token: 0x04000295 RID: 661
	public GameObject ismiumBar;

	// Token: 0x04000296 RID: 662
	public GameObject iridiumBar;

	// Token: 0x04000297 RID: 663
	public GameObject painiteBar;

	// Token: 0x04000298 RID: 664
	public GameObject copperQuestionmark;

	// Token: 0x04000299 RID: 665
	public GameObject ironQuestionmark;

	// Token: 0x0400029A RID: 666
	public GameObject cobaltQuestionmark;

	// Token: 0x0400029B RID: 667
	public GameObject uraniumQuestionmark;

	// Token: 0x0400029C RID: 668
	public GameObject ismiumQuestionmark;

	// Token: 0x0400029D RID: 669
	public GameObject iridiumQuestionmark;

	// Token: 0x0400029E RID: 670
	public GameObject painiteQuestionmark;

	// Token: 0x0400029F RID: 671
	public TextMeshProUGUI topPickaxeName;

	// Token: 0x040002A0 RID: 672
	public TextMeshProUGUI equippedPickaxeName;

	// Token: 0x040002A1 RID: 673
	public TextMeshProUGUI goldPriceText;

	// Token: 0x040002A2 RID: 674
	public TextMeshProUGUI copperPriceText;

	// Token: 0x040002A3 RID: 675
	public TextMeshProUGUI ironPriceText;

	// Token: 0x040002A4 RID: 676
	public TextMeshProUGUI cobaltPriceText;

	// Token: 0x040002A5 RID: 677
	public TextMeshProUGUI uraniumPriceText;

	// Token: 0x040002A6 RID: 678
	public TextMeshProUGUI ismiumPriceText;

	// Token: 0x040002A7 RID: 679
	public TextMeshProUGUI iridiumPriceText;

	// Token: 0x040002A8 RID: 680
	public TextMeshProUGUI painitePriceText;

	// Token: 0x040002A9 RID: 681
	public static bool isOnlyFirstPickaxe;

	// Token: 0x040002AA RID: 682
	public static float currentMineTime;

	// Token: 0x040002AB RID: 683
	public static float currentMinePower;

	// Token: 0x040002AC RID: 684
	public static float current2XPowerChance;

	// Token: 0x040002AD RID: 685
	public static float currentMiningErea;

	// Token: 0x040002AE RID: 686
	public static bool isTheAnvilUnlocked;

	// Token: 0x040002AF RID: 687
	public static bool pickaxe1_crafted;

	// Token: 0x040002B0 RID: 688
	public static bool pickaxe2_crafted;

	// Token: 0x040002B1 RID: 689
	public static bool pickaxe3_crafted;

	// Token: 0x040002B2 RID: 690
	public static bool pickaxe4_crafted;

	// Token: 0x040002B3 RID: 691
	public static bool pickaxe5_crafted;

	// Token: 0x040002B4 RID: 692
	public static bool pickaxe6_crafted;

	// Token: 0x040002B5 RID: 693
	public static bool pickaxe7_crafted;

	// Token: 0x040002B6 RID: 694
	public static bool pickaxe8_crafted;

	// Token: 0x040002B7 RID: 695
	public static bool pickaxe9_crafted;

	// Token: 0x040002B8 RID: 696
	public static bool pickaxe10_crafted;

	// Token: 0x040002B9 RID: 697
	public static bool pickaxe11_crafted;

	// Token: 0x040002BA RID: 698
	public static bool pickaxe12_crafted;

	// Token: 0x040002BB RID: 699
	public static bool pickaxe13_crafted;

	// Token: 0x040002BC RID: 700
	public static bool pickaxe14_crafted;

	// Token: 0x040002BD RID: 701
	public static bool pickaxe1_equipped;

	// Token: 0x040002BE RID: 702
	public static bool pickaxe2_equipped;

	// Token: 0x040002BF RID: 703
	public static bool pickaxe3_equipped;

	// Token: 0x040002C0 RID: 704
	public static bool pickaxe4_equipped;

	// Token: 0x040002C1 RID: 705
	public static bool pickaxe5_equipped;

	// Token: 0x040002C2 RID: 706
	public static bool pickaxe6_equipped;

	// Token: 0x040002C3 RID: 707
	public static bool pickaxe7_equipped;

	// Token: 0x040002C4 RID: 708
	public static bool pickaxe8_equipped;

	// Token: 0x040002C5 RID: 709
	public static bool pickaxe9_equipped;

	// Token: 0x040002C6 RID: 710
	public static bool pickaxe10_equipped;

	// Token: 0x040002C7 RID: 711
	public static bool pickaxe11_equipped;

	// Token: 0x040002C8 RID: 712
	public static bool pickaxe12_equipped;

	// Token: 0x040002C9 RID: 713
	public static bool pickaxe13_equipped;

	// Token: 0x040002CA RID: 714
	public static bool pickaxe14_equipped;

	// Token: 0x040002CB RID: 715
	public static float pickaxe1_mineTime;

	// Token: 0x040002CC RID: 716
	public static float pickaxe1_minePower;

	// Token: 0x040002CD RID: 717
	public static float pickaxe1_2XChance;

	// Token: 0x040002CE RID: 718
	public static float pickaxe1_miningAreaSize;

	// Token: 0x040002CF RID: 719
	public static float pickaxe2_mineTime;

	// Token: 0x040002D0 RID: 720
	public static float pickaxe2_minePower;

	// Token: 0x040002D1 RID: 721
	public static float pickaxe2_2XChance;

	// Token: 0x040002D2 RID: 722
	public static float pickaxe2_miningAreaSize;

	// Token: 0x040002D3 RID: 723
	public static float pickaxe3_mineTime;

	// Token: 0x040002D4 RID: 724
	public static float pickaxe3_minePower;

	// Token: 0x040002D5 RID: 725
	public static float pickaxe3_2XChance;

	// Token: 0x040002D6 RID: 726
	public static float pickaxe3_miningAreaSize;

	// Token: 0x040002D7 RID: 727
	public static float pickaxe4_mineTime;

	// Token: 0x040002D8 RID: 728
	public static float pickaxe4_minePower;

	// Token: 0x040002D9 RID: 729
	public static float pickaxe4_2XChance;

	// Token: 0x040002DA RID: 730
	public static float pickaxe4_miningAreaSize;

	// Token: 0x040002DB RID: 731
	public static float pickaxe5_mineTime;

	// Token: 0x040002DC RID: 732
	public static float pickaxe5_minePower;

	// Token: 0x040002DD RID: 733
	public static float pickaxe5_2XChance;

	// Token: 0x040002DE RID: 734
	public static float pickaxe5_miningAreaSize;

	// Token: 0x040002DF RID: 735
	public static float pickaxe6_mineTime;

	// Token: 0x040002E0 RID: 736
	public static float pickaxe6_minePower;

	// Token: 0x040002E1 RID: 737
	public static float pickaxe6_2XChance;

	// Token: 0x040002E2 RID: 738
	public static float pickaxe6_miningAreaSize;

	// Token: 0x040002E3 RID: 739
	public static float pickaxe7_mineTime;

	// Token: 0x040002E4 RID: 740
	public static float pickaxe7_minePower;

	// Token: 0x040002E5 RID: 741
	public static float pickaxe7_2XChance;

	// Token: 0x040002E6 RID: 742
	public static float pickaxe7_miningAreaSize;

	// Token: 0x040002E7 RID: 743
	public static float pickaxe8_mineTime;

	// Token: 0x040002E8 RID: 744
	public static float pickaxe8_minePower;

	// Token: 0x040002E9 RID: 745
	public static float pickaxe8_2XChance;

	// Token: 0x040002EA RID: 746
	public static float pickaxe8_miningAreaSize;

	// Token: 0x040002EB RID: 747
	public static float pickaxe9_mineTime;

	// Token: 0x040002EC RID: 748
	public static float pickaxe9_minePower;

	// Token: 0x040002ED RID: 749
	public static float pickaxe9_2XChance;

	// Token: 0x040002EE RID: 750
	public static float pickaxe9_miningAreaSize;

	// Token: 0x040002EF RID: 751
	public static float pickaxe10_mineTime;

	// Token: 0x040002F0 RID: 752
	public static float pickaxe10_minePower;

	// Token: 0x040002F1 RID: 753
	public static float pickaxe10_2XChance;

	// Token: 0x040002F2 RID: 754
	public static float pickaxe10_miningAreaSize;

	// Token: 0x040002F3 RID: 755
	public static float pickaxe11_mineTime;

	// Token: 0x040002F4 RID: 756
	public static float pickaxe11_minePower;

	// Token: 0x040002F5 RID: 757
	public static float pickaxe11_2XChance;

	// Token: 0x040002F6 RID: 758
	public static float pickaxe11_miningAreaSize;

	// Token: 0x040002F7 RID: 759
	public static float pickaxe12_mineTime;

	// Token: 0x040002F8 RID: 760
	public static float pickaxe12_minePower;

	// Token: 0x040002F9 RID: 761
	public static float pickaxe12_2XChance;

	// Token: 0x040002FA RID: 762
	public static float pickaxe12_miningAreaSize;

	// Token: 0x040002FB RID: 763
	public static float pickaxe13_mineTime;

	// Token: 0x040002FC RID: 764
	public static float pickaxe13_minePower;

	// Token: 0x040002FD RID: 765
	public static float pickaxe13_2XChance;

	// Token: 0x040002FE RID: 766
	public static float pickaxe13_miningAreaSize;

	// Token: 0x040002FF RID: 767
	public static float pickaxe14_mineTime;

	// Token: 0x04000300 RID: 768
	public static float pickaxe14_minePower;

	// Token: 0x04000301 RID: 769
	public static float pickaxe14_2XChance;

	// Token: 0x04000302 RID: 770
	public static float pickaxe14_miningAreaSize;

	// Token: 0x04000303 RID: 771
	public static double pickaxe2_goldPrice;

	// Token: 0x04000304 RID: 772
	public static double pickaxe3_goldPrice;

	// Token: 0x04000305 RID: 773
	public static double pickaxe3_copperPrice;

	// Token: 0x04000306 RID: 774
	public static double pickaxe4_copperPrice;

	// Token: 0x04000307 RID: 775
	public static double pickaxe4_ironPrice;

	// Token: 0x04000308 RID: 776
	public static double pickaxe5_goldPrice;

	// Token: 0x04000309 RID: 777
	public static double pickaxe5_ironPrice;

	// Token: 0x0400030A RID: 778
	public static double pickaxe6_goldPrice;

	// Token: 0x0400030B RID: 779
	public static double pickaxe6_cobaltPrice;

	// Token: 0x0400030C RID: 780
	public static double pickaxe7_goldPrice;

	// Token: 0x0400030D RID: 781
	public static double pickaxe7_copperPrice;

	// Token: 0x0400030E RID: 782
	public static double pickaxe7_ironPrice;

	// Token: 0x0400030F RID: 783
	public static double pickaxe8_cobaltPrice;

	// Token: 0x04000310 RID: 784
	public static double pickaxe8_uraniumPrice;

	// Token: 0x04000311 RID: 785
	public static double pickaxe9_goldPrice;

	// Token: 0x04000312 RID: 786
	public static double pickaxe9_uraniumPrice;

	// Token: 0x04000313 RID: 787
	public static double pickaxe9_ismiumPrice;

	// Token: 0x04000314 RID: 788
	public static double pickaxe10_goldPrice;

	// Token: 0x04000315 RID: 789
	public static double pickaxe10_copperPrice;

	// Token: 0x04000316 RID: 790
	public static double pickaxe10_iridiumPrice;

	// Token: 0x04000317 RID: 791
	public static double pickaxe11_cobaltPrice;

	// Token: 0x04000318 RID: 792
	public static double pickaxe11_uraniumPrice;

	// Token: 0x04000319 RID: 793
	public static double pickaxe11_ismiumPrice;

	// Token: 0x0400031A RID: 794
	public static double pickaxe12_goldPrice;

	// Token: 0x0400031B RID: 795
	public static double pickaxe12_iridiumPrice;

	// Token: 0x0400031C RID: 796
	public static double pickaxe13_goldPrice;

	// Token: 0x0400031D RID: 797
	public static double pickaxe13_ironPrice;

	// Token: 0x0400031E RID: 798
	public static double pickaxe13_painitePrice;

	// Token: 0x0400031F RID: 799
	public static float equippedMineTime;

	// Token: 0x04000320 RID: 800
	public static float equippedMinePower;

	// Token: 0x04000321 RID: 801
	public static float equipped2XChance;

	// Token: 0x04000322 RID: 802
	public static float equippedMiningArea;

	// Token: 0x04000323 RID: 803
	public static float collTime;

	// Token: 0x04000324 RID: 804
	private bool playSound;

	// Token: 0x04000325 RID: 805
	public static bool isDLC;

	// Token: 0x04000326 RID: 806
	public GameObject allSkinsFrame;

	// Token: 0x04000327 RID: 807
	public GameObject skinLeftBTN;

	// Token: 0x04000328 RID: 808
	public GameObject skinRightBTN;

	// Token: 0x04000329 RID: 809
	public TextMeshProUGUI skinText;

	// Token: 0x0400032A RID: 810
	public static int totalPickaxesCrafted;

	// Token: 0x0400032B RID: 811
	public static bool craftedOnePickaxe;

	// Token: 0x0400032C RID: 812
	public GameObject mobileCircleBtn;

	// Token: 0x0400032D RID: 813
	public GameObject pcCursorImage;

	// Token: 0x0400032E RID: 814
	public GameObject[] pickaxe1_skins;

	// Token: 0x0400032F RID: 815
	public GameObject[] pickaxe2_skins;

	// Token: 0x04000330 RID: 816
	public GameObject[] pickaxe3_skins;

	// Token: 0x04000331 RID: 817
	public GameObject[] pickaxe4_skins;

	// Token: 0x04000332 RID: 818
	public GameObject[] pickaxe5_skins;

	// Token: 0x04000333 RID: 819
	public GameObject[] pickaxe6_skins;

	// Token: 0x04000334 RID: 820
	public GameObject[] pickaxe7_skins;

	// Token: 0x04000335 RID: 821
	public GameObject[] pickaxe8_skins;

	// Token: 0x04000336 RID: 822
	public GameObject[] pickaxe9_skins;

	// Token: 0x04000337 RID: 823
	public GameObject[] pickaxe10_skins;

	// Token: 0x04000338 RID: 824
	public GameObject[] pickaxe11_skins;

	// Token: 0x04000339 RID: 825
	public GameObject[] pickaxe12_skins;

	// Token: 0x0400033A RID: 826
	public GameObject[] pickaxe13_skins;

	// Token: 0x0400033B RID: 827
	public static int pickaxe1_skinsChosen;

	// Token: 0x0400033C RID: 828
	public static int pickaxe2_skinsChosen;

	// Token: 0x0400033D RID: 829
	public static int pickaxe3_skinsChosen;

	// Token: 0x0400033E RID: 830
	public static int pickaxe4_skinsChosen;

	// Token: 0x0400033F RID: 831
	public static int pickaxe5_skinsChosen;

	// Token: 0x04000340 RID: 832
	public static int pickaxe6_skinsChosen;

	// Token: 0x04000341 RID: 833
	public static int pickaxe7_skinsChosen;

	// Token: 0x04000342 RID: 834
	public static int pickaxe8_skinsChosen;

	// Token: 0x04000343 RID: 835
	public static int pickaxe9_skinsChosen;

	// Token: 0x04000344 RID: 836
	public static int pickaxe10_skinsChosen;

	// Token: 0x04000345 RID: 837
	public static int pickaxe11_skinsChosen;

	// Token: 0x04000346 RID: 838
	public static int pickaxe12_skinsChosen;

	// Token: 0x04000347 RID: 839
	public static int pickaxe13_skinsChosen;

	// Token: 0x04000348 RID: 840
	public GameObject craftingFrame;

	// Token: 0x04000349 RID: 841
	public GameObject outLineCircle;

	// Token: 0x0400034A RID: 842
	public Image craftingCircle;

	// Token: 0x0400034B RID: 843
	public TextMeshProUGUI craftingText;

	// Token: 0x0400034C RID: 844
	private float craftingTime = 2.4f;

	// Token: 0x0400034D RID: 845
	private float currentTime;

	// Token: 0x0400034E RID: 846
	private bool isCrafting;

	// Token: 0x0400034F RID: 847
	private bool craftingCompleted;

	// Token: 0x04000350 RID: 848
	private float dotTimer;

	// Token: 0x04000351 RID: 849
	private int dotCount;

	// Token: 0x04000352 RID: 850
	public bool isPlayingCrafting;

	// Token: 0x04000353 RID: 851
	public static bool isInCraftingDone;

	// Token: 0x04000354 RID: 852
	public GameObject pickaxe1PopUp;

	// Token: 0x04000355 RID: 853
	public ParticleSystem craftedParticle;

	// Token: 0x04000356 RID: 854
	public ParticleSystem pickaxeParticle;

	// Token: 0x04000357 RID: 855
	public Sprite pickaxe2Sprite;

	// Token: 0x04000358 RID: 856
	public Sprite pickaxe3Sprite;

	// Token: 0x04000359 RID: 857
	public Sprite pickaxe4Sprite;

	// Token: 0x0400035A RID: 858
	public Sprite pickaxe5Sprite;

	// Token: 0x0400035B RID: 859
	public Sprite pickaxe6Sprite;

	// Token: 0x0400035C RID: 860
	public Sprite pickaxe7Sprite;

	// Token: 0x0400035D RID: 861
	public Sprite pickaxe8Sprite;

	// Token: 0x0400035E RID: 862
	public Sprite pickaxe9Sprite;

	// Token: 0x0400035F RID: 863
	public Sprite pickaxe10Sprite;

	// Token: 0x04000360 RID: 864
	public Sprite pickaxe11Sprite;

	// Token: 0x04000361 RID: 865
	public Sprite pickaxe12Sprite;

	// Token: 0x04000362 RID: 866
	public Sprite pickaxe13Sprite;

	// Token: 0x04000363 RID: 867
	public TextMeshProUGUI currentMineTime_text;

	// Token: 0x04000364 RID: 868
	public TextMeshProUGUI currentMinePower_text;

	// Token: 0x04000365 RID: 869
	public TextMeshProUGUI current2XPowerChance_text;

	// Token: 0x04000366 RID: 870
	public TextMeshProUGUI currentMiningErea_text;

	// Token: 0x04000367 RID: 871
	public GameObject handCollider;

	// Token: 0x04000368 RID: 872
	public GameObject squareCollider;

	// Token: 0x04000369 RID: 873
	public GameObject hexagonCollider;

	// Token: 0x0400036A RID: 874
	public static float currentColliderSize;

	// Token: 0x0400036B RID: 875
	public Coroutine scaleUpAndDownCoroutine;

	// Token: 0x0400036C RID: 876
	public GameObject[] pickaxes;

	// Token: 0x0400036D RID: 877
	public int pickaxeNumber;

	// Token: 0x0400036E RID: 878
	public Transform leftPickaxePos;

	// Token: 0x0400036F RID: 879
	public Transform middlePickaxePos;

	// Token: 0x04000370 RID: 880
	public Transform rightPickaxePos;

	// Token: 0x04000371 RID: 881
	public GameObject diamondPickaxeQuestionMark;

	// Token: 0x04000372 RID: 882
	public TextMeshProUGUI goldCraftPrice;

	// Token: 0x04000373 RID: 883
	public TextMeshProUGUI copperCraftPrice;

	// Token: 0x04000374 RID: 884
	public TextMeshProUGUI ironCraftPRice;

	// Token: 0x04000375 RID: 885
	public TextMeshProUGUI cobaltCraftPrice;

	// Token: 0x04000376 RID: 886
	public TextMeshProUGUI uraniumCraftPrice;

	// Token: 0x04000377 RID: 887
	public TextMeshProUGUI ismiumCraftPrice;

	// Token: 0x04000378 RID: 888
	public TextMeshProUGUI iridiumCraftPrice;

	// Token: 0x04000379 RID: 889
	public TextMeshProUGUI painiteCraftPrice;

	// Token: 0x0400037A RID: 890
	public TextMeshProUGUI holdToCraftText;

	// Token: 0x0400037B RID: 891
	public GameObject darkPickaxeParent;

	// Token: 0x0400037C RID: 892
	public GameObject pickaxeStatsParent;

	// Token: 0x0400037D RID: 893
	public GameObject pickaxePriceParent;

	// Token: 0x0400037E RID: 894
	public TextMeshProUGUI mineTime_displayText;

	// Token: 0x0400037F RID: 895
	public TextMeshProUGUI minePower_displayText;

	// Token: 0x04000380 RID: 896
	public TextMeshProUGUI doublePowerChance_displayText;

	// Token: 0x04000381 RID: 897
	public TextMeshProUGUI miningArea_displayText;

	// Token: 0x04000382 RID: 898
	public GameObject red1;

	// Token: 0x04000383 RID: 899
	public GameObject green1;

	// Token: 0x04000384 RID: 900
	public GameObject white1;

	// Token: 0x04000385 RID: 901
	public GameObject red2;

	// Token: 0x04000386 RID: 902
	public GameObject green2;

	// Token: 0x04000387 RID: 903
	public GameObject white2;

	// Token: 0x04000388 RID: 904
	public GameObject red3;

	// Token: 0x04000389 RID: 905
	public GameObject green3;

	// Token: 0x0400038A RID: 906
	public GameObject white3;

	// Token: 0x0400038B RID: 907
	public GameObject red4;

	// Token: 0x0400038C RID: 908
	public GameObject green4;

	// Token: 0x0400038D RID: 909
	public GameObject white4;

	// Token: 0x0400038E RID: 910
	public GameObject pickaxe1_frameIcon;

	// Token: 0x0400038F RID: 911
	public GameObject pickaxe2_frameIcon;

	// Token: 0x04000390 RID: 912
	public GameObject pickaxe3_frameIcon;

	// Token: 0x04000391 RID: 913
	public GameObject pickaxe4_frameIcon;

	// Token: 0x04000392 RID: 914
	public GameObject pickaxe5_frameIcon;

	// Token: 0x04000393 RID: 915
	public GameObject pickaxe6_frameIcon;

	// Token: 0x04000394 RID: 916
	public GameObject pickaxe7_frameIcon;

	// Token: 0x04000395 RID: 917
	public GameObject pickaxe8_frameIcon;

	// Token: 0x04000396 RID: 918
	public GameObject pickaxe9_frameIcon;

	// Token: 0x04000397 RID: 919
	public GameObject pickaxe10_frameIcon;

	// Token: 0x04000398 RID: 920
	public GameObject pickaxe11_frameIcon;

	// Token: 0x04000399 RID: 921
	public GameObject pickaxe12_frameIcon;

	// Token: 0x0400039A RID: 922
	public GameObject pickaxe13_frameIcon;

	// Token: 0x0400039B RID: 923
	public GameObject pickaxe14_frameIcon;

	// Token: 0x0400039C RID: 924
	public Image pickaxe1_topImage;

	// Token: 0x0400039D RID: 925
	public Image pickaxe2_topImage;

	// Token: 0x0400039E RID: 926
	public Image pickaxe3_topImage;

	// Token: 0x0400039F RID: 927
	public Image pickaxe4_topImage;

	// Token: 0x040003A0 RID: 928
	public Image pickaxe5_topImage;

	// Token: 0x040003A1 RID: 929
	public Image pickaxe6_topImage;

	// Token: 0x040003A2 RID: 930
	public Image pickaxe7_topImage;

	// Token: 0x040003A3 RID: 931
	public Image pickaxe8_topImage;

	// Token: 0x040003A4 RID: 932
	public Image pickaxe9_topImage;

	// Token: 0x040003A5 RID: 933
	public Image pickaxe10_topImage;

	// Token: 0x040003A6 RID: 934
	public Image pickaxe11_topImage;

	// Token: 0x040003A7 RID: 935
	public Image pickaxe12_topImage;

	// Token: 0x040003A8 RID: 936
	public Image pickaxe13_topImage;

	// Token: 0x040003A9 RID: 937
	public Image pickaxe14_topImage;

	// Token: 0x040003AA RID: 938
	public Image pickaxe1_craftImage;

	// Token: 0x040003AB RID: 939
	public Image pickaxe2_craftImage;

	// Token: 0x040003AC RID: 940
	public Image pickaxe3_craftImage;

	// Token: 0x040003AD RID: 941
	public Image pickaxe4_craftImage;

	// Token: 0x040003AE RID: 942
	public Image pickaxe5_craftImage;

	// Token: 0x040003AF RID: 943
	public Image pickaxe6_craftImage;

	// Token: 0x040003B0 RID: 944
	public Image pickaxe7_craftImage;

	// Token: 0x040003B1 RID: 945
	public Image pickaxe8_craftImage;

	// Token: 0x040003B2 RID: 946
	public Image pickaxe9_craftImage;

	// Token: 0x040003B3 RID: 947
	public Image pickaxe10_craftImage;

	// Token: 0x040003B4 RID: 948
	public Image pickaxe11_craftImage;

	// Token: 0x040003B5 RID: 949
	public Image pickaxe12_craftImage;

	// Token: 0x040003B6 RID: 950
	public Image pickaxe13_craftImage;

	// Token: 0x040003B7 RID: 951
	public Image pickaxe14_craftImage;
}
