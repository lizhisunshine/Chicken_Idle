using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000005 RID: 5
public class IconPreview : MonoBehaviour
{
	// Token: 0x06000010 RID: 16 RVA: 0x000023F4 File Offset: 0x000005F4
	private void Awake()
	{
		for (int i = 0; i < this.icons.Length; i++)
		{
			this.icon = new GameObject("icon" + i.ToString());
			this.icon.transform.SetParent(base.gameObject.transform);
			this.icon.AddComponent<RectTransform>();
			this.icon.AddComponent<Image>();
			this.icon.GetComponent<Image>().sprite = this.icons[i];
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000247B File Offset: 0x0000067B
	private void Update()
	{
	}

	// Token: 0x04000023 RID: 35
	public Sprite[] icons;

	// Token: 0x04000024 RID: 36
	private GameObject icon;
}
