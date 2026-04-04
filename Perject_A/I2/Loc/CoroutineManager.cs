using System;
using System.Collections;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200009D RID: 157
	public class CoroutineManager : MonoBehaviour
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00064A20 File Offset: 0x00062C20
		private static CoroutineManager pInstance
		{
			get
			{
				if (CoroutineManager.mInstance == null)
				{
					GameObject gameObject = new GameObject("_Coroutiner");
					gameObject.hideFlags = HideFlags.HideAndDontSave;
					CoroutineManager.mInstance = gameObject.AddComponent<CoroutineManager>();
					if (Application.isPlaying)
					{
						Object.DontDestroyOnLoad(gameObject);
					}
				}
				return CoroutineManager.mInstance;
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00064A6A File Offset: 0x00062C6A
		private void Awake()
		{
			if (Application.isPlaying)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00064A7E File Offset: 0x00062C7E
		public static Coroutine Start(IEnumerator coroutine)
		{
			return CoroutineManager.pInstance.StartCoroutine(coroutine);
		}

		// Token: 0x04000FFE RID: 4094
		private static CoroutineManager mInstance;
	}
}
