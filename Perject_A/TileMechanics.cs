using System;
using UnityEngine;

// Token: 0x0200001E RID: 30
public class TileMechanics : MonoBehaviour
{
	// Token: 0x060000BF RID: 191 RVA: 0x0000F2B0 File Offset: 0x0000D4B0
	private void Awake()
	{
		this.grassParent = base.transform.Find("FullGrass");
		SetRockScreen.grassLayer++;
		SetRockScreen.startTileZPos -= 0.1f;
		float z = base.gameObject.transform.localPosition.z;
		float x = base.gameObject.transform.localPosition.x;
		float y = base.gameObject.transform.localPosition.y;
		base.gameObject.transform.localPosition = new Vector3(x, y, z);
		base.gameObject.GetComponent<SpriteRenderer>().sortingOrder = SetRockScreen.grassLayer;
	}

	// Token: 0x040003EA RID: 1002
	public Transform grassParent;
}
