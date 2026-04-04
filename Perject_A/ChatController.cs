using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200003E RID: 62
public class ChatController : MonoBehaviour
{
	// Token: 0x0600020E RID: 526 RVA: 0x00053195 File Offset: 0x00051395
	private void OnEnable()
	{
		this.ChatInputField.onSubmit.AddListener(new UnityAction<string>(this.AddToChatOutput));
	}

	// Token: 0x0600020F RID: 527 RVA: 0x000531B3 File Offset: 0x000513B3
	private void OnDisable()
	{
		this.ChatInputField.onSubmit.RemoveListener(new UnityAction<string>(this.AddToChatOutput));
	}

	// Token: 0x06000210 RID: 528 RVA: 0x000531D4 File Offset: 0x000513D4
	private void AddToChatOutput(string newText)
	{
		this.ChatInputField.text = string.Empty;
		DateTime now = DateTime.Now;
		string text = string.Concat(new string[]
		{
			"[<#FFFF80>",
			now.Hour.ToString("d2"),
			":",
			now.Minute.ToString("d2"),
			":",
			now.Second.ToString("d2"),
			"</color>] ",
			newText
		});
		if (this.ChatDisplayOutput != null)
		{
			if (this.ChatDisplayOutput.text == string.Empty)
			{
				this.ChatDisplayOutput.text = text;
			}
			else
			{
				TMP_Text chatDisplayOutput = this.ChatDisplayOutput;
				chatDisplayOutput.text = chatDisplayOutput.text + "\n" + text;
			}
		}
		this.ChatInputField.ActivateInputField();
		this.ChatScrollbar.value = 0f;
	}

	// Token: 0x04000E5E RID: 3678
	public TMP_InputField ChatInputField;

	// Token: 0x04000E5F RID: 3679
	public TMP_Text ChatDisplayOutput;

	// Token: 0x04000E60 RID: 3680
	public Scrollbar ChatScrollbar;
}
