using System;
using System.Collections;
using TMPro;
using UnityEngine;

// Token: 0x0200001B RID: 27
public class TextMechanics : MonoBehaviour
{
	// Token: 0x06000092 RID: 146 RVA: 0x00009178 File Offset: 0x00007378
	private void Awake()
	{
		GameObject gameObject = GameObject.Find("GoldAndOreMechanics");
		this.goldScript = gameObject.GetComponent<GoldAndOreMechanics>();
		this.text = base.gameObject.GetComponent<TextMeshProUGUI>();
		this.goldCountFrame = GameObject.Find("GoldAmountDisplay");
	}

	// Token: 0x06000093 RID: 147 RVA: 0x000091BD File Offset: 0x000073BD
	private void OnEnable()
	{
		base.gameObject.transform.localScale = new Vector2(0f, 0f);
		base.StartCoroutine(this.PopUpText());
	}

	// Token: 0x06000094 RID: 148 RVA: 0x000091F0 File Offset: 0x000073F0
	private IEnumerator PopUpText()
	{
		float seconds = Random.Range(0.03f, 0.05f);
		yield return new WaitForSeconds(seconds);
		float scaleStartTime = Time.time;
		float scaleEndTime = scaleStartTime + 0.25f;
		float randomTexTSize = Random.Range(0.18f, 0.25f);
		while (Time.time < scaleEndTime)
		{
			float t = (Time.time - scaleStartTime) / (scaleEndTime - scaleStartTime);
			this.text.transform.localScale = Vector3.Lerp(Vector3.zero, new Vector3(randomTexTSize, randomTexTSize, randomTexTSize), t);
			yield return null;
		}
		float time = Random.Range(0.1f, 0.6f);
		yield return new WaitForSecondsRealtime(time);
		float moveDuration = Random.Range(0.3f, 0.4f);
		if (SetRockScreen.timeLeft < 1.5f)
		{
			moveDuration = Random.Range(0.09f, 0.15f);
		}
		Vector3 startPosition = this.text.transform.position;
		Vector3 endPosition = this.goldCountFrame.transform.position;
		float moveStartTime = Time.time;
		while (Time.time < moveStartTime + moveDuration)
		{
			float t2 = (Time.time - moveStartTime) / moveDuration;
			this.text.transform.position = Vector3.Lerp(startPosition, endPosition, t2);
			yield return null;
		}
		this.text.transform.position = endPosition;
		ObjectPool.instance.ReturnTextFromPool(base.gameObject);
		yield break;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x000091FF File Offset: 0x000073FF
	private void OnDisable()
	{
		base.gameObject.transform.localScale = new Vector2(0f, 0f);
		base.StopAllCoroutines();
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000922B File Offset: 0x0000742B
	public void KeepJustInCase()
	{
	}

	// Token: 0x0400028A RID: 650
	private TextMeshProUGUI text;

	// Token: 0x0400028B RID: 651
	public GoldAndOreMechanics goldScript;

	// Token: 0x0400028C RID: 652
	public bool isMineMaterial;

	// Token: 0x0400028D RID: 653
	public GameObject goldCountFrame;
}
