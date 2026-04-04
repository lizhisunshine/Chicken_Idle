using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200003C RID: 60
public class TheEnding : MonoBehaviour, IDataPersistence
{
	// Token: 0x060001F1 RID: 497 RVA: 0x00052B14 File Offset: 0x00050D14
	private void Awake()
	{
		TheEnding.gameMusicFullVolume = 0.565f;
		TheEnding.endingMusicFillVolume = 0.8f;
		this.craftingTime = 3f;
		this.creditsBlackFrame.SetActive(false);
		base.StartCoroutine(this.Wait());
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x00052B4E File Offset: 0x00050D4E
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(0.8f);
		if (TheEnding.isEndingCompleted)
		{
			this.endingButton.SetActive(false);
		}
		yield break;
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00052B5D File Offset: 0x00050D5D
	private void Update()
	{
		if (!TheEnding.broken && TheEnding.bigRockBroken)
		{
			this.diamondCount = 0;
			Cursor.visible = true;
			TheEnding.broken = true;
			base.StartCoroutine(this.DiamondAnims());
		}
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x00052B8D File Offset: 0x00050D8D
	private IEnumerator DiamondAnims()
	{
		yield return new WaitForSeconds(0.45f);
		this.endingStuff.SetActive(true);
		this.cursorCollider.SetActive(false);
		Cursor.visible = true;
		this.blockScreen.SetActive(true);
		this.diamond1.gameObject.SetActive(true);
		this.diamond1.Play();
		base.StartCoroutine(this.FloatGameObject(this.diamond1.gameObject));
		yield return new WaitForSeconds(1.1f);
		this.diamond3.gameObject.SetActive(true);
		this.diamond3.Play();
		base.StartCoroutine(this.FloatGameObject(this.diamond3.gameObject));
		yield return new WaitForSeconds(1.1f);
		this.diamond2.gameObject.SetActive(true);
		this.diamond2.Play();
		base.StartCoroutine(this.FloatGameObject(this.diamond2.gameObject));
		yield return new WaitForSeconds(0.9f);
		this.craftButton.gameObject.SetActive(true);
		this.craftButton.Play();
		yield return new WaitForSeconds(0.233f);
		this.audioManager.Play("CardPop");
		this.blockScreen.SetActive(false);
		yield break;
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00052B9C File Offset: 0x00050D9C
	public IEnumerator FloatGameObject(GameObject objectToFloat)
	{
		this.audioManager.Play("EndingWoosh");
		yield return new WaitForSeconds(0.417f);
		this.diamondCount++;
		if (this.diamondCount == 1)
		{
			this.audioManager.Play("DiamodSound1");
		}
		if (this.diamondCount == 2)
		{
			this.audioManager.Play("DiamodSound2");
		}
		if (this.diamondCount == 3)
		{
			this.audioManager.Play("DiamodSound3");
		}
		Vector3 initialScale = objectToFloat.transform.localScale;
		Vector3 initialPosition = objectToFloat.transform.localPosition;
		float initialZRotation = objectToFloat.transform.localEulerAngles.z;
		float scaleOffset = Random.Range(0f, 6.2831855f);
		float posOffset = Random.Range(0f, 6.2831855f);
		float rotOffset = Random.Range(0f, 6.2831855f);
		while (!this.isCraftingStarted)
		{
			float time = Time.time;
			float num = Mathf.Lerp(1.85f, 2.05f, (Mathf.Sin(time + scaleOffset) + 1f) / 2f);
			objectToFloat.transform.localScale = new Vector3(num, num, num);
			float num2 = Mathf.Sin(time + posOffset) * 13f;
			float num3 = Mathf.Cos(time + posOffset) * 13f;
			objectToFloat.transform.localPosition = new Vector3(initialPosition.x + num2, initialPosition.y + num3, initialPosition.z);
			float z = initialZRotation + Mathf.Sin(time + rotOffset) * 5f;
			Vector3 localEulerAngles = objectToFloat.transform.localEulerAngles;
			objectToFloat.transform.localEulerAngles = new Vector3(localEulerAngles.x, localEulerAngles.y, z);
			yield return null;
		}
		objectToFloat.transform.localScale = initialScale;
		objectToFloat.transform.localPosition = initialPosition;
		objectToFloat.transform.localEulerAngles = new Vector3(objectToFloat.transform.localEulerAngles.x, objectToFloat.transform.localEulerAngles.y, initialZRotation);
		yield break;
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00052BB4 File Offset: 0x00050DB4
	public void PressCraftPickaxe()
	{
		this.audioManager.Play("Merge");
		Cursor.visible = true;
		SetRockScreen.isInMiningSession = false;
		TheAnvil.pickaxe14_crafted = true;
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
		this.isCraftingStarted = true;
		this.craftButton.gameObject.SetActive(false);
		this.craftingCoroutine = base.StartCoroutine(this.CraftingCoroutine());
		base.StartCoroutine(this.FadeInImage(this.craftingFrame.GetComponent<Image>()));
		base.StartCoroutine(this.MoveLocalPosXToZero(this.diamond1.gameObject));
		base.StartCoroutine(this.MoveLocalPosXToZero(this.diamond2.gameObject));
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00052C61 File Offset: 0x00050E61
	private IEnumerator CraftingCoroutine()
	{
		this.craftingCompleted = false;
		this.craftingFrame.SetActive(true);
		this.outLineCircle.SetActive(true);
		this.craftingText.text = LocalizationScript.crafting;
		this.craftingText.gameObject.SetActive(true);
		this.craftingCircle.gameObject.SetActive(true);
		float currentTime = 0f;
		float dotTimer = 0f;
		int dotCount = 0;
		while (currentTime < this.craftingTime)
		{
			currentTime += Time.deltaTime;
			float fillAmount = Mathf.Clamp01(currentTime / this.craftingTime);
			this.craftingCircle.fillAmount = fillAmount;
			dotTimer += Time.deltaTime;
			if (dotTimer >= 0.35f)
			{
				dotTimer = 0f;
				dotCount = (dotCount + 1) % 4;
				this.craftingText.text = LocalizationScript.crafting + new string('.', dotCount);
			}
			yield return null;
		}
		this.audioManager.Stop("Crafting...");
		this.craftingCompleted = true;
		this.OnCraftingComplete();
		yield break;
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x00052C70 File Offset: 0x00050E70
	private void OnCraftingComplete()
	{
		this.audioManager.Play("CraftingDone");
		this.audioManager.Play("FinishedCrafting");
		base.StartCoroutine(this.RollCredits());
		this.craftedParticle.gameObject.SetActive(true);
		this.craftedParticle.Play();
		this.diamond1.gameObject.SetActive(false);
		this.diamond2.gameObject.SetActive(false);
		this.diamond3.gameObject.SetActive(false);
		this.outLineCircle.SetActive(false);
		this.craftingText.gameObject.SetActive(false);
		this.craftingCircle.gameObject.SetActive(false);
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00052D27 File Offset: 0x00050F27
	public IEnumerator FadeInImage(Image image)
	{
		Color color = image.color;
		color.a = 0f;
		image.color = color;
		float duration = this.craftingTime;
		float currentTime = 0f;
		while (currentTime < duration)
		{
			currentTime += Time.deltaTime;
			float a = Mathf.Clamp01(currentTime / duration);
			color.a = a;
			image.color = color;
			yield return null;
		}
		color.a = 1f;
		image.color = color;
		yield break;
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00052D3D File Offset: 0x00050F3D
	public IEnumerator MoveLocalPosXToZero(GameObject obj)
	{
		Vector3 startPos = obj.transform.localPosition;
		Vector3 endPos = new Vector3(0f, startPos.y, startPos.z);
		float currentTime = 0f;
		while (currentTime < this.craftingTime)
		{
			currentTime += Time.deltaTime;
			float t = Mathf.Clamp01(currentTime / this.craftingTime);
			Vector3 localPosition = Vector3.Lerp(startPos, endPos, t);
			obj.transform.localPosition = localPosition;
			yield return null;
		}
		obj.transform.localPosition = endPos;
		yield break;
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00052D53 File Offset: 0x00050F53
	private IEnumerator RollCredits()
	{
		this.endingButton.SetActive(false);
		this.flags.transform.localPosition = new Vector2(-426f, -431f);
		this.mainMenuSettingsBtn.SetActive(false);
		this.youCraftedText.SetActive(false);
		this.diamondPickaxeIcon.SetActive(false);
		this.thankYouForPlayingText.SetActive(false);
		this.creditsBlackFrame.transform.localPosition = new Vector2(0f, -2248.18f);
		yield return new WaitForSeconds(1f);
		this.audioManager.Stop("CreditsMusic");
		this.audioManager.Play("CreditsMusic");
		base.StartCoroutine(this.SongVolume("CreditsMusic", false, 0.7f, 0f, 0.45f, false));
		yield return new WaitForSeconds(0.67f);
		this.creditsBlackFrame.SetActive(true);
		this.audioManager.Play("CardPop");
		this.youCraftedText.SetActive(true);
		yield return new WaitForSeconds(1.311f);
		this.diamondPickaxeIcon.SetActive(true);
		this.audioManager.Play("CardPop");
		yield return new WaitForSeconds(1.311f);
		this.thankYouForPlayingText.SetActive(true);
		this.audioManager.Play("CardPop");
		yield return new WaitForSeconds(2f);
		base.StartCoroutine(this.CreditsToll(this.creditsBlackFrame, 37f));
		yield break;
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00052D62 File Offset: 0x00050F62
	public IEnumerator CreditsToll(GameObject obj, float duration)
	{
		TheEnding.isEndingCompleted = true;
		this.anvilScript.SetDiamondPickaxeWhite();
		this.achScript.CheckAch();
		Vector3 startPos = obj.transform.localPosition;
		Vector3 endPos = new Vector3(startPos.x, 387f, startPos.z);
		float currentTime = 0f;
		while (currentTime < duration)
		{
			currentTime += Time.deltaTime;
			float t = Mathf.Clamp01(currentTime / duration);
			Vector3 localPosition = Vector3.Lerp(startPos, endPos, t);
			obj.transform.localPosition = localPosition;
			yield return null;
		}
		obj.transform.localPosition = endPos;
		yield break;
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00052D80 File Offset: 0x00050F80
	public void GoToMainMenu()
	{
		this.audioManager.Play("MainMenuMusic");
		this.audioManager.Stop("CreditsMusic");
		this.SoundVolumeSet("MainMenuMusic", false, 0f, TheEnding.gameMusicFullVolume, 0.65f, false);
		Cursor.visible = true;
		SetRockScreen.isInEnding = false;
		TheEnding.broken = false;
		TheEnding.bigRockBroken = false;
		this.isCraftingStarted = false;
		this.craftingCompleted = false;
		base.StopAllCoroutines();
		base.StartCoroutine(this.ScaleCircleCoroutine(true));
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00052E03 File Offset: 0x00051003
	private IEnumerator ScaleCircleCoroutine(bool scaleUp)
	{
		this.circleObject.SetActive(true);
		this.transitionBlock.SetActive(true);
		this.audioManager.Play("Transition");
		float scaleDuration = 0.4f;
		float num = scaleUp ? 0f : 26f;
		float num2 = scaleUp ? 26f : 0f;
		float elapsed = 0f;
		Vector3 initialScale = new Vector3(num, num, num);
		Vector3 targetScale = new Vector3(num2, num2, num2);
		this.circleObject.transform.localScale = initialScale;
		while (elapsed < scaleDuration)
		{
			elapsed += Time.deltaTime;
			float t = Mathf.Clamp01(elapsed / scaleDuration);
			this.circleObject.transform.localScale = Vector3.Lerp(initialScale, targetScale, t);
			yield return null;
		}
		if (scaleUp)
		{
			this.rockScreenScript.SetUiStuff();
			this.SetOff();
			yield return new WaitForSeconds(0.5f);
			base.StartCoroutine(this.ScaleCircleCoroutine(false));
		}
		this.circleObject.transform.localScale = targetScale;
		if (!scaleUp)
		{
			this.circleObject.SetActive(false);
			this.transitionBlock.SetActive(false);
		}
		yield break;
	}

	// Token: 0x060001FF RID: 511 RVA: 0x00052E19 File Offset: 0x00051019
	private IEnumerator SongVolume(string name, bool turnDown, float startVolume, float endVolume, float fadeTime, bool stopMusic)
	{
		float start = turnDown ? startVolume : endVolume;
		float end = turnDown ? endVolume : startVolume;
		float time = 0f;
		while (time < fadeTime)
		{
			time += Time.unscaledDeltaTime;
			float newVolume = Mathf.Lerp(start, end, time / fadeTime);
			this.audioManager.ChangeVolume(name, newVolume);
			yield return null;
		}
		this.audioManager.ChangeVolume(name, end);
		if (stopMusic)
		{
			this.audioManager.Stop(name);
		}
		yield break;
	}

	// Token: 0x06000200 RID: 512 RVA: 0x00052E55 File Offset: 0x00051055
	public void SoundVolumeSet(string name, bool turnDown, float startVolume, float endVolume, float fadeTime, bool stopMusic)
	{
		base.StartCoroutine(this.SongVolume(name, turnDown, startVolume, endVolume, fadeTime, stopMusic));
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00052E70 File Offset: 0x00051070
	public void SetOff()
	{
		Color color = this.craftingFrame.GetComponent<Image>().color;
		color.a = 0f;
		this.craftingFrame.GetComponent<Image>().color = color;
		this.craftingFrame.SetActive(false);
		this.outLineCircle.SetActive(false);
		this.craftingText.gameObject.SetActive(false);
		this.craftingCircle.gameObject.SetActive(false);
		this.youCraftedText.SetActive(false);
		this.diamondPickaxeIcon.SetActive(false);
		this.thankYouForPlayingText.SetActive(false);
		this.creditsBlackFrame.SetActive(false);
		this.endingStuff.SetActive(false);
		this.startScreen.SetActive(true);
		this.startScreenbackground.SetActive(true);
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00052F39 File Offset: 0x00051139
	public void LoadData(GameData data)
	{
		TheEnding.isEndingCompleted = data.isEndingCompleted;
	}

	// Token: 0x06000203 RID: 515 RVA: 0x00052F46 File Offset: 0x00051146
	public void SaveData(ref GameData data)
	{
		data.isEndingCompleted = TheEnding.isEndingCompleted;
	}

	// Token: 0x06000204 RID: 516 RVA: 0x00052F54 File Offset: 0x00051154
	public void CopyThis()
	{
	}

	// Token: 0x04000E18 RID: 3608
	public GameObject EndSessionBtn;

	// Token: 0x04000E19 RID: 3609
	public GameObject xpFrame;

	// Token: 0x04000E1A RID: 3610
	public GameObject timeFrame;

	// Token: 0x04000E1B RID: 3611
	public GameObject materialFrame;

	// Token: 0x04000E1C RID: 3612
	public GameObject potionsFrame;

	// Token: 0x04000E1D RID: 3613
	public SetRockScreen rockScreenScript;

	// Token: 0x04000E1E RID: 3614
	public MainMenu mainMenuScripT;

	// Token: 0x04000E1F RID: 3615
	public Achievements achScript;

	// Token: 0x04000E20 RID: 3616
	public TheAnvil anvilScript;

	// Token: 0x04000E21 RID: 3617
	public static bool bigRockBroken;

	// Token: 0x04000E22 RID: 3618
	public static bool broken;

	// Token: 0x04000E23 RID: 3619
	public Animation diamond1;

	// Token: 0x04000E24 RID: 3620
	public Animation diamond2;

	// Token: 0x04000E25 RID: 3621
	public Animation diamond3;

	// Token: 0x04000E26 RID: 3622
	public Animation craftButton;

	// Token: 0x04000E27 RID: 3623
	public GameObject blockScreen;

	// Token: 0x04000E28 RID: 3624
	public GameObject cursorCollider;

	// Token: 0x04000E29 RID: 3625
	public GameObject endingStuff;

	// Token: 0x04000E2A RID: 3626
	public float craftingTime;

	// Token: 0x04000E2B RID: 3627
	public static bool isEndingCompleted;

	// Token: 0x04000E2C RID: 3628
	public static float gameMusicFullVolume;

	// Token: 0x04000E2D RID: 3629
	public static float endingMusicFillVolume;

	// Token: 0x04000E2E RID: 3630
	public GameObject mainMenuSettingsBtn;

	// Token: 0x04000E2F RID: 3631
	public GameObject flags;

	// Token: 0x04000E30 RID: 3632
	public GameObject endingButton;

	// Token: 0x04000E31 RID: 3633
	private int diamondCount;

	// Token: 0x04000E32 RID: 3634
	public static bool craftingDone;

	// Token: 0x04000E33 RID: 3635
	public AudioManager audioManager;

	// Token: 0x04000E34 RID: 3636
	public GameObject craftingFrame;

	// Token: 0x04000E35 RID: 3637
	public GameObject outLineCircle;

	// Token: 0x04000E36 RID: 3638
	public Image craftingCircle;

	// Token: 0x04000E37 RID: 3639
	public TextMeshProUGUI craftingText;

	// Token: 0x04000E38 RID: 3640
	private bool craftingCompleted;

	// Token: 0x04000E39 RID: 3641
	public bool isCraftingStarted;

	// Token: 0x04000E3A RID: 3642
	private Coroutine craftingCoroutine;

	// Token: 0x04000E3B RID: 3643
	public ParticleSystem craftedParticle;

	// Token: 0x04000E3C RID: 3644
	public GameObject creditsBlackFrame;

	// Token: 0x04000E3D RID: 3645
	public GameObject youCraftedText;

	// Token: 0x04000E3E RID: 3646
	public GameObject diamondPickaxeIcon;

	// Token: 0x04000E3F RID: 3647
	public GameObject thankYouForPlayingText;

	// Token: 0x04000E40 RID: 3648
	public GameObject circleObject;

	// Token: 0x04000E41 RID: 3649
	public GameObject transitionBlock;

	// Token: 0x04000E42 RID: 3650
	public GameObject startScreen;

	// Token: 0x04000E43 RID: 3651
	public GameObject startScreenbackground;
}
