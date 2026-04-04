using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace LayerLab.GUIScripts
{
	// Token: 0x02000062 RID: 98
	public class PanelControl : MonoBehaviour
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0005742E File Offset: 0x0005562E
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00057436 File Offset: 0x00055636
		private bool IsOtherMode { get; set; }

		// Token: 0x060002B7 RID: 695 RVA: 0x00057440 File Offset: 0x00055640
		private void OnValidate()
		{
			GameObject gameObject = GameObject.Find("Panels");
			if (gameObject)
			{
				this.panelTransformDefault = gameObject.transform;
			}
			this.buttonPrev = base.transform.GetChild(0).GetComponent<Button>();
			this.buttonNext = base.transform.GetChild(2).GetComponent<Button>();
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0005749A File Offset: 0x0005569A
		private void Reset()
		{
			this.OnValidate();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000574A4 File Offset: 0x000556A4
		private void Start()
		{
			this._textTitle = base.transform.GetComponentInChildren<TextMeshProUGUI>();
			this.buttonPrev.onClick.AddListener(new UnityAction(this.Click_Prev));
			this.buttonNext.onClick.AddListener(new UnityAction(this.Click_Next));
			foreach (object obj in this.panelTransformDefault)
			{
				Transform transform = (Transform)obj;
				this.defaultPanels.Add(transform.gameObject);
				transform.gameObject.SetActive(false);
			}
			this.defaultPanels[this._page].SetActive(true);
			if (this.panelTransformOther == null)
			{
				return;
			}
			foreach (object obj2 in this.panelTransformOther)
			{
				Transform transform2 = (Transform)obj2;
				this.otherPanels.Add(transform2.gameObject);
				transform2.gameObject.SetActive(false);
			}
			if (this.otherPanels.Count > 0)
			{
				this.otherPanels[this._page].SetActive(true);
			}
			this._isReady = true;
			this.CheckControl();
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00057614 File Offset: 0x00055814
		private void Update()
		{
			if (this.defaultPanels.Count <= 0 || !this._isReady)
			{
				return;
			}
			if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				this.Click_Prev();
				return;
			}
			if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				this.Click_Next();
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00057654 File Offset: 0x00055854
		private void Click_Prev()
		{
			if (this._page <= 0)
			{
				return;
			}
			this.defaultPanels[this._page].SetActive(false);
			if (this.otherPanels.Count > 0)
			{
				this.otherPanels[this._page].SetActive(false);
			}
			this._page--;
			this.defaultPanels[this._page].SetActive(true);
			if (this.otherPanels.Count > 0)
			{
				this.otherPanels[this._page].SetActive(true);
			}
			if (!this.IsOtherMode)
			{
				this._textTitle.text = this.defaultPanels[this._page].name;
			}
			else if (this.otherPanels.Count > 0)
			{
				this._textTitle.text = this.otherPanels[this._page].name;
			}
			this.CheckControl();
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00057754 File Offset: 0x00055954
		private void Click_Next()
		{
			if (this._page >= this.defaultPanels.Count - 1)
			{
				return;
			}
			this.defaultPanels[this._page].SetActive(false);
			if (this.otherPanels.Count > 0)
			{
				this.otherPanels[this._page].SetActive(false);
			}
			this._page++;
			this.defaultPanels[this._page].SetActive(true);
			if (this.otherPanels.Count > 0)
			{
				this.otherPanels[this._page].SetActive(true);
			}
			this.CheckControl();
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00057803 File Offset: 0x00055A03
		private void SetArrowActive()
		{
			this.buttonPrev.gameObject.SetActive(this._page > 0);
			this.buttonNext.gameObject.SetActive(this._page < this.defaultPanels.Count - 1);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00057844 File Offset: 0x00055A44
		private void CheckControl()
		{
			if (!this.IsOtherMode)
			{
				this._textTitle.text = this.defaultPanels[this._page].name.Replace("_", " ");
			}
			else if (this.otherPanels.Count > 0)
			{
				this._textTitle.text = this.otherPanels[this._page].name.Replace("_", " ");
			}
			this.SetArrowActive();
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000578CF File Offset: 0x00055ACF
		public void Click_Mode()
		{
			this.IsOtherMode = !this.IsOtherMode;
			this.SetMode();
			this.CheckControl();
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000578EC File Offset: 0x00055AEC
		private void SetMode()
		{
			this.panelTransformDefault.gameObject.SetActive(!this.IsOtherMode);
			if (this.otherPanels.Count > 0)
			{
				this.panelTransformOther.gameObject.SetActive(this.IsOtherMode);
			}
		}

		// Token: 0x04000F28 RID: 3880
		private int _page;

		// Token: 0x04000F29 RID: 3881
		private bool _isReady;

		// Token: 0x04000F2A RID: 3882
		private TextMeshProUGUI _textTitle;

		// Token: 0x04000F2B RID: 3883
		[SerializeField]
		private List<GameObject> defaultPanels = new List<GameObject>();

		// Token: 0x04000F2C RID: 3884
		[SerializeField]
		private List<GameObject> otherPanels = new List<GameObject>();

		// Token: 0x04000F2D RID: 3885
		[SerializeField]
		private Transform panelTransformDefault;

		// Token: 0x04000F2E RID: 3886
		[SerializeField]
		private Transform panelTransformOther;

		// Token: 0x04000F2F RID: 3887
		[SerializeField]
		private Button buttonPrev;

		// Token: 0x04000F30 RID: 3888
		[SerializeField]
		private Button buttonNext;
	}
}
