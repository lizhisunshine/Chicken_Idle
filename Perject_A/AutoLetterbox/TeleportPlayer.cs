using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000C3 RID: 195
	public class TeleportPlayer : MonoBehaviour
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x00068DD5 File Offset: 0x00066FD5
		private void Start()
		{
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00068DD7 File Offset: 0x00066FD7
		private void Update()
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00068DDC File Offset: 0x00066FDC
		public void OnTriggerEnter2D(Collider2D coll)
		{
			DragonClass component = coll.gameObject.GetComponent<DragonClass>();
			if (component != null)
			{
				float num = component.transform.position.x - this.newX;
				component.transform.position = new Vector3(component.transform.position.x - num, component.transform.position.y, component.transform.position.z);
				for (int i = 0; i < this.parralaxObjects.Length; i++)
				{
					this.parralaxObjects[i].IgnoreNextFrame();
					this.parralaxObjects[i].transform.position = new Vector3(this.parralaxObjects[i].transform.position.x - num, this.parralaxObjects[i].transform.position.y, this.parralaxObjects[i].transform.position.z);
				}
			}
		}

		// Token: 0x040010A2 RID: 4258
		public float newX = -12.98f;

		// Token: 0x040010A3 RID: 4259
		public Parralax[] parralaxObjects;
	}
}
