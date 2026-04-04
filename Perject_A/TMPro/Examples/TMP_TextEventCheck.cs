using System;
using UnityEngine;
using UnityEngine.Events;

namespace TMPro.Examples
{
	// Token: 0x02000056 RID: 86
	public class TMP_TextEventCheck : MonoBehaviour
	{
		// Token: 0x0600026F RID: 623 RVA: 0x00055968 File Offset: 0x00053B68
		private void OnEnable()
		{
			if (this.TextEventHandler != null)
			{
				this.m_TextComponent = this.TextEventHandler.GetComponent<TMP_Text>();
				this.TextEventHandler.onCharacterSelection.AddListener(new UnityAction<char, int>(this.OnCharacterSelection));
				this.TextEventHandler.onSpriteSelection.AddListener(new UnityAction<char, int>(this.OnSpriteSelection));
				this.TextEventHandler.onWordSelection.AddListener(new UnityAction<string, int, int>(this.OnWordSelection));
				this.TextEventHandler.onLineSelection.AddListener(new UnityAction<string, int, int>(this.OnLineSelection));
				this.TextEventHandler.onLinkSelection.AddListener(new UnityAction<string, string, int>(this.OnLinkSelection));
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00055A24 File Offset: 0x00053C24
		private void OnDisable()
		{
			if (this.TextEventHandler != null)
			{
				this.TextEventHandler.onCharacterSelection.RemoveListener(new UnityAction<char, int>(this.OnCharacterSelection));
				this.TextEventHandler.onSpriteSelection.RemoveListener(new UnityAction<char, int>(this.OnSpriteSelection));
				this.TextEventHandler.onWordSelection.RemoveListener(new UnityAction<string, int, int>(this.OnWordSelection));
				this.TextEventHandler.onLineSelection.RemoveListener(new UnityAction<string, int, int>(this.OnLineSelection));
				this.TextEventHandler.onLinkSelection.RemoveListener(new UnityAction<string, string, int>(this.OnLinkSelection));
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00055ACE File Offset: 0x00053CCE
		private void OnCharacterSelection(char c, int index)
		{
			Debug.Log(string.Concat(new string[]
			{
				"Character [",
				c.ToString(),
				"] at Index: ",
				index.ToString(),
				" has been selected."
			}));
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00055B0C File Offset: 0x00053D0C
		private void OnSpriteSelection(char c, int index)
		{
			Debug.Log(string.Concat(new string[]
			{
				"Sprite [",
				c.ToString(),
				"] at Index: ",
				index.ToString(),
				" has been selected."
			}));
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00055B4C File Offset: 0x00053D4C
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
			Debug.Log(string.Concat(new string[]
			{
				"Word [",
				word,
				"] with first character index of ",
				firstCharacterIndex.ToString(),
				" and length of ",
				length.ToString(),
				" has been selected."
			}));
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00055BA4 File Offset: 0x00053DA4
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
			Debug.Log(string.Concat(new string[]
			{
				"Line [",
				lineText,
				"] with first character index of ",
				firstCharacterIndex.ToString(),
				" and length of ",
				length.ToString(),
				" has been selected."
			}));
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00055BFC File Offset: 0x00053DFC
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
			if (this.m_TextComponent != null)
			{
				TMP_LinkInfo[] linkInfo = this.m_TextComponent.textInfo.linkInfo;
			}
			Debug.Log(string.Concat(new string[]
			{
				"Link Index: ",
				linkIndex.ToString(),
				" with ID [",
				linkID,
				"] and Text \"",
				linkText,
				"\" has been selected."
			}));
		}

		// Token: 0x04000EED RID: 3821
		public TMP_TextEventHandler TextEventHandler;

		// Token: 0x04000EEE RID: 3822
		private TMP_Text m_TextComponent;
	}
}
