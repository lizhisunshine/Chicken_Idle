using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000034 RID: 52
public class ScreenShake : MonoBehaviour
{
	// Token: 0x0600018E RID: 398 RVA: 0x0003F5CC File Offset: 0x0003D7CC
	private void Awake()
	{
		this.shakeDuration = 0.1f;
		this.shakeMagnitude = 0.2f;
		this.originalPos = new Vector3(-254f, 170f, 0f);
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0003F5FE File Offset: 0x0003D7FE
	public void ShakeTheScreen()
	{
	}

	// Token: 0x06000190 RID: 400 RVA: 0x0003F600 File Offset: 0x0003D800
	private IEnumerator Shake()
	{
		float elapsed = 0f;
		while (elapsed < this.shakeDuration)
		{
			float x = Random.Range(-2.5f, 2.5f) * this.shakeMagnitude;
			float y = Random.Range(-2.5f, 2.5f) * this.shakeMagnitude;
			this.background.transform.localPosition = this.originalPos + new Vector3(x, y, 0f);
			elapsed += Time.deltaTime;
			yield return null;
		}
		this.background.transform.localPosition = this.originalPos;
		yield break;
	}

	// Token: 0x04000941 RID: 2369
	public GameObject background;

	// Token: 0x04000942 RID: 2370
	public float shakeDuration;

	// Token: 0x04000943 RID: 2371
	public float shakeMagnitude;

	// Token: 0x04000944 RID: 2372
	private Vector3 originalPos;
}
