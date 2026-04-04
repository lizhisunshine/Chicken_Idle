using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	// Token: 0x020000A7 RID: 167
	public class ResourceManager : MonoBehaviour
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00065598 File Offset: 0x00063798
		public static ResourceManager pInstance
		{
			get
			{
				bool flag = ResourceManager.mInstance == null;
				if (ResourceManager.mInstance == null)
				{
					ResourceManager.mInstance = (ResourceManager)Object.FindObjectOfType(typeof(ResourceManager));
				}
				if (ResourceManager.mInstance == null)
				{
					GameObject gameObject = new GameObject("I2ResourceManager", new Type[]
					{
						typeof(ResourceManager)
					});
					gameObject.hideFlags |= HideFlags.HideAndDontSave;
					ResourceManager.mInstance = gameObject.GetComponent<ResourceManager>();
					SceneManager.sceneLoaded += ResourceManager.MyOnLevelWasLoaded;
				}
				if (flag && Application.isPlaying)
				{
					Object.DontDestroyOnLoad(ResourceManager.mInstance.gameObject);
				}
				return ResourceManager.mInstance;
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00065649 File Offset: 0x00063849
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
			ResourceManager.pInstance.CleanResourceCache(false);
			LocalizationManager.UpdateSources();
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0006565C File Offset: 0x0006385C
		public T GetAsset<T>(string Name) where T : Object
		{
			T t = this.FindAsset(Name) as T;
			if (t != null)
			{
				return t;
			}
			return this.LoadFromResources<T>(Name);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00065694 File Offset: 0x00063894
		private Object FindAsset(string Name)
		{
			if (this.Assets != null)
			{
				int i = 0;
				int num = this.Assets.Length;
				while (i < num)
				{
					if (this.Assets[i] != null && this.Assets[i].name == Name)
					{
						return this.Assets[i];
					}
					i++;
				}
			}
			return null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000656ED File Offset: 0x000638ED
		public bool HasAsset(Object Obj)
		{
			return this.Assets != null && Array.IndexOf<Object>(this.Assets, Obj) >= 0;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0006570C File Offset: 0x0006390C
		public T LoadFromResources<T>(string Path) where T : Object
		{
			T t;
			try
			{
				Object @object;
				if (string.IsNullOrEmpty(Path))
				{
					t = default(T);
					t = t;
				}
				else if (this.mResourcesCache.TryGetValue(Path, out @object) && @object != null)
				{
					t = (@object as T);
				}
				else
				{
					T t2 = default(T);
					if (Path.EndsWith("]", StringComparison.OrdinalIgnoreCase))
					{
						int num = Path.LastIndexOf("[", StringComparison.OrdinalIgnoreCase);
						int length = Path.Length - num - 2;
						string value = Path.Substring(num + 1, length);
						Path = Path.Substring(0, num);
						T[] array = Resources.LoadAll<T>(Path);
						int i = 0;
						int num2 = array.Length;
						while (i < num2)
						{
							if (array[i].name.Equals(value))
							{
								t2 = array[i];
								break;
							}
							i++;
						}
					}
					else
					{
						t2 = (Resources.Load(Path, typeof(T)) as T);
					}
					if (t2 == null)
					{
						t2 = this.LoadFromBundle<T>(Path);
					}
					if (t2 != null)
					{
						this.mResourcesCache[Path] = t2;
					}
					t = t2;
				}
			}
			catch (Exception ex)
			{
				Debug.LogErrorFormat("Unable to load {0} '{1}'\nERROR: {2}", new object[]
				{
					typeof(T),
					Path,
					ex.ToString()
				});
				t = default(T);
			}
			return t;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00065898 File Offset: 0x00063A98
		public T LoadFromBundle<T>(string path) where T : Object
		{
			int i = 0;
			int count = this.mBundleManagers.Count;
			while (i < count)
			{
				if (this.mBundleManagers[i] != null)
				{
					T t = this.mBundleManagers[i].LoadFromBundle(path, typeof(T)) as T;
					if (t != null)
					{
						return t;
					}
				}
				i++;
			}
			return default(T);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0006590B File Offset: 0x00063B0B
		public void CleanResourceCache(bool unloadResources = false)
		{
			this.mResourcesCache.Clear();
			if (unloadResources)
			{
				Resources.UnloadUnusedAssets();
			}
			base.CancelInvoke();
		}

		// Token: 0x0400100A RID: 4106
		private static ResourceManager mInstance;

		// Token: 0x0400100B RID: 4107
		public List<IResourceManager_Bundles> mBundleManagers = new List<IResourceManager_Bundles>();

		// Token: 0x0400100C RID: 4108
		public Object[] Assets;

		// Token: 0x0400100D RID: 4109
		private readonly Dictionary<string, Object> mResourcesCache = new Dictionary<string, Object>(StringComparer.Ordinal);
	}
}
