using System;
using System.Collections;
using TMPro;
using UnityEngine;

// Token: 0x02000040 RID: 64
public class EnvMapAnimator : MonoBehaviour
{
	// Token: 0x06000214 RID: 532 RVA: 0x0005334A File Offset: 0x0005154A
	private void Awake()
	{
		this.m_textMeshPro = base.GetComponent<TMP_Text>();
		this.m_material = this.m_textMeshPro.fontSharedMaterial;
	}

	// Token: 0x06000215 RID: 533 RVA: 0x00053369 File Offset: 0x00051569
	private IEnumerator Start()
	{
		Matrix4x4 matrix = default(Matrix4x4);
		for (;;)
		{
			matrix.SetTRS(Vector3.zero, Quaternion.Euler(Time.time * this.RotationSpeeds.x, Time.time * this.RotationSpeeds.y, Time.time * this.RotationSpeeds.z), Vector3.one);
			this.m_material.SetMatrix("_EnvMatrix", matrix);
			yield return null;
		}
		yield break;
	}

	// Token: 0x04000E64 RID: 3684
	public Vector3 RotationSpeeds;

	// Token: 0x04000E65 RID: 3685
	private TMP_Text m_textMeshPro;

	// Token: 0x04000E66 RID: 3686
	private Material m_material;
}
