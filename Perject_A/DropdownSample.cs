using System;
using TMPro;
using UnityEngine;

// Token: 0x0200003F RID: 63
public class DropdownSample : MonoBehaviour
{
	// Token: 0x06000212 RID: 530 RVA: 0x000532E0 File Offset: 0x000514E0
	public void OnButtonClick()
	{
		this.text.text = ((this.dropdownWithPlaceholder.value > -1) ? ("Selected values:\n" + this.dropdownWithoutPlaceholder.value.ToString() + " - " + this.dropdownWithPlaceholder.value.ToString()) : "Error: Please make a selection");
	}

	// Token: 0x04000E61 RID: 3681
	[SerializeField]
	private TextMeshProUGUI text;

	// Token: 0x04000E62 RID: 3682
	[SerializeField]
	private TMP_Dropdown dropdownWithoutPlaceholder;

	// Token: 0x04000E63 RID: 3683
	[SerializeField]
	private TMP_Dropdown dropdownWithPlaceholder;
}
