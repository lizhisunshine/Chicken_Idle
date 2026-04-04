using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class MineMaterialMechanics : MonoBehaviour
{
	// Token: 0x06000057 RID: 87 RVA: 0x000054B8 File Offset: 0x000036B8
	private void Awake()
	{
		GameObject gameObject = GameObject.Find("OverlappingSounds");
		this.overlappingScript = gameObject.GetComponent<OverlappingSounds>();
		if (this.isMinePopUp)
		{
			this.goldBar = base.transform.Find("goldBar");
			this.copperBar = base.transform.Find("copperBar");
			this.ironBar = base.transform.Find("ironBar");
			this.cobaltBar = base.transform.Find("cobaltBar");
			this.uraniumBar = base.transform.Find("uraniumBar");
			this.ismiumBar = base.transform.Find("ismiumBar");
			this.iridiumBar = base.transform.Find("iridiumBar");
			this.painiteBar = base.transform.Find("painiteBar");
		}
		else
		{
			this.goldOre = base.transform.Find("GoldOre");
			this.copperOre = base.transform.Find("CopperOre");
			this.ironOre = base.transform.Find("IronOre");
			this.cobaltOre = base.transform.Find("CobaltOre");
			this.uraniumOre = base.transform.Find("UraniumOre");
			this.ismiumOre = base.transform.Find("IsmiumOre");
			this.iridiumOre = base.transform.Find("IridiumOre");
			this.painiteOre = base.transform.Find("PainiteOre");
			this.goldOreFrame = GameObject.Find("GoldIcon_frame");
		}
		GameObject gameObject2 = GameObject.Find("GoldAndOreMechanics");
		this.goldScript = gameObject2.GetComponent<GoldAndOreMechanics>();
		this.totalGoldFrame = GameObject.Find("TotalGoldFrame");
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00005684 File Offset: 0x00003884
	public void SetOff()
	{
		if (this.isRocksMaterialPopUp)
		{
			this.goldOre.gameObject.SetActive(false);
			this.copperOre.gameObject.SetActive(false);
			this.ironOre.gameObject.SetActive(false);
			this.cobaltOre.gameObject.SetActive(false);
			this.uraniumOre.gameObject.SetActive(false);
			this.ismiumOre.gameObject.SetActive(false);
			this.iridiumOre.gameObject.SetActive(false);
			this.painiteOre.gameObject.SetActive(false);
			this.isGoldOre = false;
			this.isCopperOre = false;
			this.isIronOre = false;
			this.isCobaltOre = false;
			this.isUraniumOre = false;
			this.isIsmiumOre = false;
			this.isIridumOre = false;
			this.isPainiteOre = false;
		}
		if (this.isMinePopUp)
		{
			this.goldBar.gameObject.SetActive(false);
			this.copperBar.gameObject.SetActive(false);
			this.ironBar.gameObject.SetActive(false);
			this.cobaltBar.gameObject.SetActive(false);
			this.uraniumBar.gameObject.SetActive(false);
			this.ismiumBar.gameObject.SetActive(false);
			this.iridiumBar.gameObject.SetActive(false);
			this.painiteBar.gameObject.SetActive(false);
			this.isGoldBar = false;
			this.isCopperBar = false;
			this.isIronBar = false;
			this.isCobaltBar = false;
			this.isUraniumBar = false;
			this.isIsmiumBar = false;
			this.isIridumBar = false;
			this.isPainiteBar = false;
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00005828 File Offset: 0x00003A28
	private void OnEnable()
	{
		if (SkillTree.spawnCopper_purchased && !this.foundCopper)
		{
			this.totalCopperFrame = GameObject.Find("TotalCopperFrame");
			this.foundCopper = true;
		}
		if (SkillTree.spawnIron_purchased && !this.foundIron)
		{
			this.totalIronFrame = GameObject.Find("TotalIronFrame");
			this.foundIron = true;
		}
		if (SkillTree.cobaltSpawn_purchased && !this.foundCobalt)
		{
			this.totalCobaltFrame = GameObject.Find("TotalCobaltFrame");
			this.foundCobalt = true;
		}
		if (SkillTree.uraniumSpawn_purchased && !this.foundUranium)
		{
			this.totalUraniumFrame = GameObject.Find("TotalUraniumFrame");
			this.foundUranium = true;
		}
		if (SkillTree.ismiumSpawn_purchased && !this.foundIsmium)
		{
			this.totalIsmiumFrame = GameObject.Find("TotalIsmiumFrame");
			this.foundIsmium = true;
		}
		if (SkillTree.iridiumSpawn_purchased && !this.foundIridium)
		{
			this.totalIridiumFrame = GameObject.Find("TotalIriduimFrame");
			this.foundIridium = true;
		}
		if (SkillTree.painiteSpawn_purchased && !this.foundPainite)
		{
			this.totalPainiteFrame = GameObject.Find("TotalPianiteFrame");
			this.foundPainite = true;
		}
		this.isReturned = false;
		this.isDisabled = false;
		if (this.isRocksMaterialPopUp)
		{
			MineMaterialMechanics.totalTextsOnScreen++;
			if (SkillTree.spawnCopper_purchased && !this.foundCopperOreFrame)
			{
				this.copperOreFrame = GameObject.Find("CopperIcon_frame");
				this.foundCopperOreFrame = true;
			}
			if (SkillTree.spawnIron_purchased && !this.foundIronOreFrame)
			{
				this.ironOreFrame = GameObject.Find("IronIcon_frame");
				this.foundIronOreFrame = true;
			}
			if (SkillTree.cobaltSpawn_purchased && !this.foundCobaltOreFrame)
			{
				this.cobaltOreFrame = GameObject.Find("CobaltIcon_frame");
				this.foundCobaltOreFrame = true;
			}
			if (SkillTree.uraniumSpawn_purchased && !this.foundUraniumOreFrame)
			{
				this.uraniumOreFrame = GameObject.Find("UraniumIcon_frame");
				this.foundUraniumOreFrame = true;
			}
			if (SkillTree.ismiumSpawn_purchased && !this.foundIsmiumOreFrame)
			{
				this.ismiumOreFrame = GameObject.Find("IsmiumIcon_frame");
				this.foundIsmiumOreFrame = true;
			}
			if (SkillTree.iridiumSpawn_purchased && !this.foundIridiumOreFrame)
			{
				this.iridiumOreFrame = GameObject.Find("IridiumIcon_frame");
				this.foundIridiumOreFrame = true;
			}
			if (SkillTree.painiteSpawn_purchased && !this.foundPainiteOreFrame)
			{
				this.painiteOreFrame = GameObject.Find("PainiteIcon_frame");
				this.foundPainiteOreFrame = true;
			}
		}
		else if (this.isMinePopUp)
		{
			base.gameObject.transform.localScale = new Vector2(0f, 0f);
		}
		this.SetOff();
		base.StartCoroutine(this.PopUpText());
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00005AAF File Offset: 0x00003CAF
	private IEnumerator PopUpText()
	{
		float seconds = Random.Range(0.03f, 0.04f);
		yield return new WaitForSeconds(seconds);
		if (this.isRocksMaterialPopUp)
		{
			if (base.gameObject.transform.localScale.x > 0.9f)
			{
				this.painiteOre.gameObject.SetActive(true);
				this.isPainiteOre = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.8f)
			{
				this.iridiumOre.gameObject.SetActive(true);
				this.isIridumOre = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.7f)
			{
				this.ismiumOre.gameObject.SetActive(true);
				this.isIsmiumOre = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.6f)
			{
				this.uraniumOre.gameObject.SetActive(true);
				this.isUraniumOre = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.5f)
			{
				this.cobaltOre.gameObject.SetActive(true);
				this.isCobaltOre = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.4f)
			{
				this.ironOre.gameObject.SetActive(true);
				this.isIronOre = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.3f)
			{
				this.copperOre.gameObject.SetActive(true);
				this.isCopperOre = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.2f)
			{
				this.goldOre.gameObject.SetActive(true);
				this.isGoldOre = true;
			}
		}
		if (this.isMinePopUp)
		{
			if (base.gameObject.transform.localScale.x > 0.9f)
			{
				this.painiteBar.gameObject.SetActive(true);
				this.isPainiteBar = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.8f)
			{
				this.iridiumBar.gameObject.SetActive(true);
				this.isIridumBar = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.7f)
			{
				this.ismiumBar.gameObject.SetActive(true);
				this.isIsmiumBar = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.6f)
			{
				this.uraniumBar.gameObject.SetActive(true);
				this.isUraniumBar = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.5f)
			{
				this.cobaltBar.gameObject.SetActive(true);
				this.isCobaltBar = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.4f)
			{
				this.ironBar.gameObject.SetActive(true);
				this.isIronBar = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.3f)
			{
				this.copperBar.gameObject.SetActive(true);
				this.isCopperBar = true;
			}
			else if (base.gameObject.transform.localScale.x > 0.2f)
			{
				this.goldBar.gameObject.SetActive(true);
				this.isGoldBar = true;
			}
		}
		float scaleStartTime = Time.time;
		float scaleEndTime = scaleStartTime + 0.25f;
		float randomTexTSize = 0f;
		if (this.isRocksMaterialPopUp)
		{
			randomTexTSize = Random.Range(0.14f, 0.225f);
		}
		if (this.isMinePopUp)
		{
			scaleEndTime = scaleStartTime + 0.4f;
			randomTexTSize = Random.Range(0.55f, 0.8f);
		}
		while (Time.time < scaleEndTime)
		{
			if (!SetRockScreen.isInMiningSession && this.isRocksMaterialPopUp && SetRockScreen.timeLeft < 5f)
			{
				scaleEndTime = 0.02f;
			}
			float t = (Time.time - scaleStartTime) / (scaleEndTime - scaleStartTime);
			base.gameObject.transform.localScale = Vector3.Lerp(Vector3.zero, new Vector3(randomTexTSize, randomTexTSize, randomTexTSize), t);
			yield return null;
		}
		float seconds2;
		if (!SetRockScreen.isInMiningSession && this.isRocksMaterialPopUp)
		{
			seconds2 = Random.Range(0.005f, 0.007f);
		}
		else if (SetRockScreen.timeLeft < 1f && this.isRocksMaterialPopUp)
		{
			seconds2 = Random.Range(0.01f, 0.02f);
		}
		else if (SetRockScreen.timeLeft < 2f && this.isRocksMaterialPopUp)
		{
			seconds2 = Random.Range(0.09f, 0.15f);
		}
		else if (SetRockScreen.timeLeft < 3f && this.isRocksMaterialPopUp)
		{
			seconds2 = Random.Range(0.1f, 0.45f);
		}
		else
		{
			seconds2 = Random.Range(0.1f, 0.52f);
		}
		yield return new WaitForSeconds(seconds2);
		float moveDuration = Random.Range(0.25f, 0.4f);
		if (SetRockScreen.timeLeft < 1f && this.isRocksMaterialPopUp)
		{
			moveDuration = Random.Range(0.02f, 0.03f);
		}
		else if (SetRockScreen.timeLeft < 2f && this.isRocksMaterialPopUp)
		{
			moveDuration = Random.Range(0.1f, 0.16f);
		}
		else if (SetRockScreen.timeLeft < 3f && this.isRocksMaterialPopUp)
		{
			moveDuration = Random.Range(0.14f, 0.2f);
		}
		if (!SetRockScreen.isInMiningSession)
		{
			moveDuration = 0.006f;
			if (this.isMinePopUp)
			{
				moveDuration = Random.Range(0.25f, 0.4f);
			}
		}
		Vector3 startPosition = base.gameObject.transform.position;
		Vector3 endPosition = new Vector3(0f, 0f, 0f);
		if (this.isMinePopUp)
		{
			if (this.isGoldBar)
			{
				endPosition = this.totalGoldFrame.transform.position;
			}
			else if (this.isCopperBar)
			{
				endPosition = this.totalCopperFrame.transform.position;
			}
			else if (this.isIronBar)
			{
				endPosition = this.totalIronFrame.transform.position;
			}
			else if (this.isCobaltBar)
			{
				endPosition = this.totalCobaltFrame.transform.position;
			}
			else if (this.isUraniumBar)
			{
				endPosition = this.totalUraniumFrame.transform.position;
			}
			else if (this.isIsmiumBar)
			{
				endPosition = this.totalIsmiumFrame.transform.position;
			}
			else if (this.isIridumBar)
			{
				endPosition = this.totalIridiumFrame.transform.position;
			}
			else if (this.isPainiteBar)
			{
				endPosition = this.totalPainiteFrame.transform.position;
			}
		}
		if (this.isRocksMaterialPopUp)
		{
			if (this.isGoldOre)
			{
				endPosition = this.goldOreFrame.transform.position;
			}
			else if (this.isCopperOre)
			{
				endPosition = this.copperOreFrame.transform.position;
			}
			else if (this.isIronOre)
			{
				endPosition = this.ironOreFrame.transform.position;
			}
			else if (this.isCobaltOre)
			{
				endPosition = this.cobaltOreFrame.transform.position;
			}
			else if (this.isUraniumOre)
			{
				endPosition = this.uraniumOreFrame.transform.position;
			}
			else if (this.isIsmiumOre)
			{
				endPosition = this.ismiumOreFrame.transform.position;
			}
			else if (this.isIridumOre)
			{
				endPosition = this.iridiumOreFrame.transform.position;
			}
			else if (this.isPainiteOre)
			{
				endPosition = this.painiteOreFrame.transform.position;
			}
		}
		float moveStartTime = Time.time;
		while (Time.time < moveStartTime + moveDuration)
		{
			if (!SetRockScreen.isInMiningSession && !this.isMinePopUp)
			{
				if (SetRockScreen.timeLeft > 5f)
				{
					moveDuration = Random.Range(0.25f, 0.4f);
				}
				else
				{
					moveDuration = 0.015f;
				}
			}
			float t2 = (Time.time - moveStartTime) / moveDuration;
			base.gameObject.transform.position = Vector3.Lerp(startPosition, endPosition, t2);
			yield return null;
		}
		if (!this.isReturned)
		{
			this.isReturned = true;
			float time = Time.time;
			this.overlappingScript.PlaySoundMaterialCollect(1, time);
			base.gameObject.transform.position = endPosition;
			if (this.isRocksMaterialPopUp)
			{
				if (!SetRockScreen.oresPopedUp)
				{
					if (this.isGoldOre)
					{
						this.goldScript.GiveMaterialOre(1, 1);
						this.goldScript.ScaleGoldAnim(1);
					}
					else if (this.isCopperOre)
					{
						this.goldScript.GiveMaterialOre(2, 1);
						this.goldScript.ScaleGoldAnim(2);
					}
					else if (this.isIronOre)
					{
						this.goldScript.GiveMaterialOre(3, 1);
						this.goldScript.ScaleGoldAnim(3);
					}
					else if (this.isCobaltOre)
					{
						this.goldScript.GiveMaterialOre(4, 1);
						this.goldScript.ScaleGoldAnim(4);
					}
					else if (this.isUraniumOre)
					{
						this.goldScript.GiveMaterialOre(5, 1);
						this.goldScript.ScaleGoldAnim(5);
					}
					else if (this.isIsmiumOre)
					{
						this.goldScript.GiveMaterialOre(6, 1);
						this.goldScript.ScaleGoldAnim(6);
					}
					else if (this.isIridumOre)
					{
						this.goldScript.GiveMaterialOre(7, 1);
						this.goldScript.ScaleGoldAnim(7);
					}
					else if (this.isPainiteOre)
					{
						this.goldScript.GiveMaterialOre(8, 1);
						this.goldScript.ScaleGoldAnim(8);
					}
				}
				MineMaterialMechanics.totalTextsOnScreen--;
				ObjectPool.instance.ReturnTextFromPool(base.gameObject);
			}
			if (this.isMinePopUp)
			{
				if (this.isGoldBar)
				{
					this.goldScript.GiveGoldBar(1, 1);
				}
				else if (this.isCopperBar)
				{
					this.goldScript.GiveGoldBar(1, 2);
				}
				else if (this.isIronBar)
				{
					this.goldScript.GiveGoldBar(1, 3);
				}
				else if (this.isCobaltBar)
				{
					this.goldScript.GiveGoldBar(1, 4);
				}
				else if (this.isUraniumBar)
				{
					this.goldScript.GiveGoldBar(1, 5);
				}
				else if (this.isIsmiumBar)
				{
					this.goldScript.GiveGoldBar(1, 6);
				}
				else if (this.isIridumBar)
				{
					this.goldScript.GiveGoldBar(1, 7);
				}
				else if (this.isPainiteBar)
				{
					this.goldScript.GiveGoldBar(1, 8);
				}
				ObjectPool.instance.ReturnTheMineMaterialFromPool(base.gameObject);
			}
		}
		yield break;
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00005AC0 File Offset: 0x00003CC0
	private void OnDisable()
	{
		if (this.isMinePopUp && !MainMenu.isInTheMine)
		{
			if (this.isGoldBar)
			{
				this.goldScript.GiveGoldBar(1, 1);
			}
			else if (this.isCopperBar)
			{
				this.goldScript.GiveGoldBar(1, 2);
			}
			else if (this.isIronBar)
			{
				this.goldScript.GiveGoldBar(1, 3);
			}
			else if (this.isCobaltBar)
			{
				this.goldScript.GiveGoldBar(1, 4);
			}
			else if (this.isUraniumBar)
			{
				this.goldScript.GiveGoldBar(1, 5);
			}
			else if (this.isIsmiumBar)
			{
				this.goldScript.GiveGoldBar(1, 6);
			}
			else if (this.isIridumBar)
			{
				this.goldScript.GiveGoldBar(1, 7);
			}
			else if (this.isPainiteBar)
			{
				this.goldScript.GiveGoldBar(1, 8);
			}
		}
		if (!this.isDisabled)
		{
			this.isDisabled = true;
			base.StopAllCoroutines();
		}
	}

	// Token: 0x04000177 RID: 375
	public GoldAndOreMechanics goldScript;

	// Token: 0x04000178 RID: 376
	public bool isMinePopUp;

	// Token: 0x04000179 RID: 377
	public bool isRocksMaterialPopUp;

	// Token: 0x0400017A RID: 378
	private Transform goldBar;

	// Token: 0x0400017B RID: 379
	private Transform copperBar;

	// Token: 0x0400017C RID: 380
	private Transform ironBar;

	// Token: 0x0400017D RID: 381
	private Transform cobaltBar;

	// Token: 0x0400017E RID: 382
	private Transform uraniumBar;

	// Token: 0x0400017F RID: 383
	private Transform ismiumBar;

	// Token: 0x04000180 RID: 384
	private Transform iridiumBar;

	// Token: 0x04000181 RID: 385
	private Transform painiteBar;

	// Token: 0x04000182 RID: 386
	public Transform goldOre;

	// Token: 0x04000183 RID: 387
	public Transform copperOre;

	// Token: 0x04000184 RID: 388
	public Transform ironOre;

	// Token: 0x04000185 RID: 389
	public Transform cobaltOre;

	// Token: 0x04000186 RID: 390
	public Transform uraniumOre;

	// Token: 0x04000187 RID: 391
	public Transform ismiumOre;

	// Token: 0x04000188 RID: 392
	public Transform iridiumOre;

	// Token: 0x04000189 RID: 393
	public Transform painiteOre;

	// Token: 0x0400018A RID: 394
	public GameObject goldOreFrame;

	// Token: 0x0400018B RID: 395
	public GameObject copperOreFrame;

	// Token: 0x0400018C RID: 396
	public GameObject ironOreFrame;

	// Token: 0x0400018D RID: 397
	public GameObject cobaltOreFrame;

	// Token: 0x0400018E RID: 398
	public GameObject uraniumOreFrame;

	// Token: 0x0400018F RID: 399
	public GameObject ismiumOreFrame;

	// Token: 0x04000190 RID: 400
	public GameObject iridiumOreFrame;

	// Token: 0x04000191 RID: 401
	public GameObject painiteOreFrame;

	// Token: 0x04000192 RID: 402
	public GameObject totalGoldFrame;

	// Token: 0x04000193 RID: 403
	public GameObject totalCopperFrame;

	// Token: 0x04000194 RID: 404
	public GameObject totalIronFrame;

	// Token: 0x04000195 RID: 405
	public GameObject totalCobaltFrame;

	// Token: 0x04000196 RID: 406
	public GameObject totalUraniumFrame;

	// Token: 0x04000197 RID: 407
	public GameObject totalIsmiumFrame;

	// Token: 0x04000198 RID: 408
	public GameObject totalIridiumFrame;

	// Token: 0x04000199 RID: 409
	public GameObject totalPainiteFrame;

	// Token: 0x0400019A RID: 410
	public static int totalTextsOnScreen;

	// Token: 0x0400019B RID: 411
	private bool isReturned;

	// Token: 0x0400019C RID: 412
	private bool isGoldOre;

	// Token: 0x0400019D RID: 413
	private bool isCopperOre;

	// Token: 0x0400019E RID: 414
	private bool isIronOre;

	// Token: 0x0400019F RID: 415
	private bool isCobaltOre;

	// Token: 0x040001A0 RID: 416
	private bool isUraniumOre;

	// Token: 0x040001A1 RID: 417
	private bool isIsmiumOre;

	// Token: 0x040001A2 RID: 418
	private bool isIridumOre;

	// Token: 0x040001A3 RID: 419
	private bool isPainiteOre;

	// Token: 0x040001A4 RID: 420
	private bool isGoldBar;

	// Token: 0x040001A5 RID: 421
	private bool isCopperBar;

	// Token: 0x040001A6 RID: 422
	private bool isIronBar;

	// Token: 0x040001A7 RID: 423
	private bool isCobaltBar;

	// Token: 0x040001A8 RID: 424
	private bool isUraniumBar;

	// Token: 0x040001A9 RID: 425
	private bool isIsmiumBar;

	// Token: 0x040001AA RID: 426
	private bool isIridumBar;

	// Token: 0x040001AB RID: 427
	private bool isPainiteBar;

	// Token: 0x040001AC RID: 428
	public OverlappingSounds overlappingScript;

	// Token: 0x040001AD RID: 429
	private bool foundCopperOreFrame;

	// Token: 0x040001AE RID: 430
	private bool foundIronOreFrame;

	// Token: 0x040001AF RID: 431
	private bool foundCobaltOreFrame;

	// Token: 0x040001B0 RID: 432
	private bool foundUraniumOreFrame;

	// Token: 0x040001B1 RID: 433
	private bool foundIsmiumOreFrame;

	// Token: 0x040001B2 RID: 434
	private bool foundIridiumOreFrame;

	// Token: 0x040001B3 RID: 435
	private bool foundPainiteOreFrame;

	// Token: 0x040001B4 RID: 436
	private bool foundCopper;

	// Token: 0x040001B5 RID: 437
	private bool foundIron;

	// Token: 0x040001B6 RID: 438
	private bool foundCobalt;

	// Token: 0x040001B7 RID: 439
	private bool foundUranium;

	// Token: 0x040001B8 RID: 440
	private bool foundIsmium;

	// Token: 0x040001B9 RID: 441
	private bool foundIridium;

	// Token: 0x040001BA RID: 442
	private bool foundPainite;

	// Token: 0x040001BB RID: 443
	private bool isDisabled;
}
