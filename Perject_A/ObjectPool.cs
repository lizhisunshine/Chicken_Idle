using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200002F RID: 47
public class ObjectPool : MonoBehaviour
{
	// Token: 0x06000155 RID: 341 RVA: 0x0003D8FB File Offset: 0x0003BAFB
	private void Awake()
	{
		if (ObjectPool.instance == null)
		{
			ObjectPool.instance = this;
		}
	}

	// Token: 0x06000156 RID: 342 RVA: 0x0003D910 File Offset: 0x0003BB10
	private void Start()
	{
		for (int i = 0; i < this.textPoolSize; i++)
		{
			GameObject gameObject = Object.Instantiate<GameObject>(this.textPrefab);
			this.textPool.Enqueue(gameObject);
			gameObject.gameObject.SetActive(false);
			gameObject.transform.SetParent(this.textParent);
		}
		for (int j = 0; j < this.pickaxePoolSize; j++)
		{
			GameObject gameObject2 = Object.Instantiate<GameObject>(this.pickAxePrefab);
			this.pickaxePool.Enqueue(gameObject2);
			gameObject2.SetActive(false);
			gameObject2.transform.SetParent(this.pickaxeParent);
		}
		for (int k = 0; k < this.rockPoolSize; k++)
		{
			GameObject gameObject3 = Object.Instantiate<GameObject>(this.rockPrefab);
			this.rockPool.Enqueue(gameObject3);
			gameObject3.SetActive(false);
			gameObject3.transform.SetParent(this.rockParent);
		}
		for (int l = 0; l < this.rockParticlePoolSize; l++)
		{
			GameObject gameObject4 = Object.Instantiate<GameObject>(this.rockParticlePrefab);
			this.rockParticlePool.Enqueue(gameObject4);
			gameObject4.SetActive(false);
			gameObject4.transform.SetParent(this.rockParticleParent);
		}
		for (int m = 0; m < this.tilePoolSize; m++)
		{
			GameObject gameObject5 = Object.Instantiate<GameObject>(this.tilePrefab);
			this.tilePool.Enqueue(gameObject5);
			gameObject5.SetActive(false);
			gameObject5.transform.SetParent(this.tileParent);
		}
		for (int n = 0; n < this.mineMaterialPoolSize; n++)
		{
			GameObject gameObject6 = Object.Instantiate<GameObject>(this.mineMaterialPrefab);
			this.mineMaterialPool.Enqueue(gameObject6);
			gameObject6.SetActive(false);
			gameObject6.transform.SetParent(this.theMineMaterialParent);
		}
		for (int num = 0; num < this.beamOfLightPoolSize; num++)
		{
			GameObject gameObject7 = Object.Instantiate<GameObject>(this.beamOfLightPrefab);
			this.beamOfLightPool.Enqueue(gameObject7);
			gameObject7.SetActive(false);
			gameObject7.transform.SetParent(this.projectileParent);
			gameObject7.transform.position = new Vector3(0f, 0f, 0f);
		}
		for (int num2 = 0; num2 < this.electricityPoolSize; num2++)
		{
			GameObject gameObject8 = Object.Instantiate<GameObject>(this.electricitySplashPrefab);
			this.electricityPool.Enqueue(gameObject8);
			gameObject8.SetActive(false);
			gameObject8.transform.SetParent(this.projectileParent);
			gameObject8.transform.localScale = new Vector3(5.5f, 5.5f, 5.5f);
		}
		for (int num3 = 0; num3 < this.dynamitePoolSize; num3++)
		{
			GameObject gameObject9 = Object.Instantiate<GameObject>(this.dynamitePrefab);
			this.dynamitePool.Enqueue(gameObject9);
			gameObject9.SetActive(false);
			gameObject9.transform.SetParent(this.projectileParent);
			gameObject9.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
		}
		for (int num4 = 0; num4 < this.plazmaBallPoolSize; num4++)
		{
			GameObject gameObject10 = Object.Instantiate<GameObject>(this.plazmaBallPrefab);
			this.plazmaBallPool.Enqueue(gameObject10);
			gameObject10.SetActive(false);
			gameObject10.transform.SetParent(this.projectileParent);
			gameObject10.transform.position = new Vector3(0f, 0f, 0f);
		}
		for (int num5 = 0; num5 < this.circleColliderPoolSize; num5++)
		{
			GameObject gameObject11 = Object.Instantiate<GameObject>(this.circleColliderPrefab);
			this.circleColliderPool.Enqueue(gameObject11);
			gameObject11.SetActive(false);
			gameObject11.transform.SetParent(this.circleParent);
			gameObject11.transform.localScale = new Vector2(0.8f, 0.8f);
		}
	}

	// Token: 0x06000157 RID: 343 RVA: 0x0003DCD5 File Offset: 0x0003BED5
	public GameObject GetTextFromPool()
	{
		if (this.textPool.Count > 0)
		{
			GameObject gameObject = this.textPool.Dequeue();
			gameObject.gameObject.SetActive(true);
			return gameObject;
		}
		return Object.Instantiate<GameObject>(this.textPrefab);
	}

	// Token: 0x06000158 RID: 344 RVA: 0x0003DD08 File Offset: 0x0003BF08
	public void ReturnTextFromPool(GameObject text)
	{
		this.textPool.Enqueue(text);
		text.gameObject.SetActive(false);
	}

	// Token: 0x06000159 RID: 345 RVA: 0x0003DD22 File Offset: 0x0003BF22
	public GameObject GetPickaxeFromPool()
	{
		if (this.pickaxePool.Count > 0)
		{
			GameObject gameObject = this.pickaxePool.Dequeue();
			gameObject.SetActive(true);
			return gameObject;
		}
		return Object.Instantiate<GameObject>(this.pickAxePrefab);
	}

	// Token: 0x0600015A RID: 346 RVA: 0x0003DD50 File Offset: 0x0003BF50
	public void ReturnPickaxeFromPool(GameObject pickaxe)
	{
		this.pickaxePool.Enqueue(pickaxe);
		pickaxe.SetActive(false);
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0003DD65 File Offset: 0x0003BF65
	public GameObject GetRockFromPool()
	{
		if (this.rockPool.Count > 0)
		{
			GameObject gameObject = this.rockPool.Dequeue();
			gameObject.SetActive(true);
			return gameObject;
		}
		return Object.Instantiate<GameObject>(this.rockPrefab);
	}

	// Token: 0x0600015C RID: 348 RVA: 0x0003DD93 File Offset: 0x0003BF93
	public void ReturnRockFromPool(GameObject rock)
	{
		this.rockPool.Enqueue(rock);
		rock.SetActive(false);
	}

	// Token: 0x0600015D RID: 349 RVA: 0x0003DDA8 File Offset: 0x0003BFA8
	public GameObject GetRockParticleFromPool()
	{
		if (this.rockParticlePool.Count > 0)
		{
			GameObject gameObject = this.rockParticlePool.Dequeue();
			gameObject.SetActive(true);
			return gameObject;
		}
		return Object.Instantiate<GameObject>(this.rockParticlePrefab);
	}

	// Token: 0x0600015E RID: 350 RVA: 0x0003DDD6 File Offset: 0x0003BFD6
	public void ReturnRockParticleToPool(GameObject rockParticle)
	{
		this.rockParticlePool.Enqueue(rockParticle);
		rockParticle.SetActive(false);
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0003DDEB File Offset: 0x0003BFEB
	public GameObject GetTileFromPool()
	{
		if (this.tilePool.Count > 0)
		{
			GameObject gameObject = this.tilePool.Dequeue();
			gameObject.SetActive(true);
			return gameObject;
		}
		return Object.Instantiate<GameObject>(this.tilePrefab);
	}

	// Token: 0x06000160 RID: 352 RVA: 0x0003DE19 File Offset: 0x0003C019
	public void ReturnTileFromPool(GameObject tile)
	{
		this.tilePool.Enqueue(tile);
		tile.SetActive(false);
	}

	// Token: 0x06000161 RID: 353 RVA: 0x0003DE2E File Offset: 0x0003C02E
	public GameObject GetTheMineMaterialFromPool()
	{
		if (this.mineMaterialPool.Count > 0)
		{
			GameObject gameObject = this.mineMaterialPool.Dequeue();
			gameObject.SetActive(true);
			return gameObject;
		}
		return Object.Instantiate<GameObject>(this.mineMaterialPrefab);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0003DE5C File Offset: 0x0003C05C
	public void ReturnTheMineMaterialFromPool(GameObject theMine)
	{
		this.mineMaterialPool.Enqueue(theMine);
		theMine.SetActive(false);
	}

	// Token: 0x06000163 RID: 355 RVA: 0x0003DE71 File Offset: 0x0003C071
	public GameObject GetBeamOfLightFromPool()
	{
		if (this.beamOfLightPool.Count > 0)
		{
			GameObject gameObject = this.beamOfLightPool.Dequeue();
			gameObject.SetActive(true);
			return gameObject;
		}
		return Object.Instantiate<GameObject>(this.beamOfLightPrefab);
	}

	// Token: 0x06000164 RID: 356 RVA: 0x0003DE9F File Offset: 0x0003C09F
	public void ReturnBeamOfLight(GameObject beamOfLight)
	{
		this.beamOfLightPool.Enqueue(beamOfLight);
		beamOfLight.SetActive(false);
	}

	// Token: 0x06000165 RID: 357 RVA: 0x0003DEB4 File Offset: 0x0003C0B4
	public GameObject GetElectricitySplashFromPool()
	{
		if (this.electricityPool.Count > 0)
		{
			GameObject gameObject = this.electricityPool.Dequeue();
			gameObject.SetActive(true);
			return gameObject;
		}
		return Object.Instantiate<GameObject>(this.electricitySplashPrefab);
	}

	// Token: 0x06000166 RID: 358 RVA: 0x0003DEE2 File Offset: 0x0003C0E2
	public void ReturnElectricitySplashFromPool(GameObject electricity)
	{
		this.electricityPool.Enqueue(electricity);
		electricity.SetActive(false);
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0003DEF7 File Offset: 0x0003C0F7
	public GameObject GetDynamiteFromPool()
	{
		if (this.dynamitePool.Count > 0)
		{
			GameObject gameObject = this.dynamitePool.Dequeue();
			gameObject.SetActive(true);
			return gameObject;
		}
		return Object.Instantiate<GameObject>(this.dynamitePrefab);
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0003DF25 File Offset: 0x0003C125
	public void ReturnDynamiteFromPool(GameObject dynamite)
	{
		this.dynamitePool.Enqueue(dynamite);
		dynamite.SetActive(false);
	}

	// Token: 0x06000169 RID: 361 RVA: 0x0003DF3A File Offset: 0x0003C13A
	public GameObject GetPlazmaBallFromPool()
	{
		if (this.plazmaBallPool.Count > 0)
		{
			GameObject gameObject = this.plazmaBallPool.Dequeue();
			gameObject.SetActive(true);
			return gameObject;
		}
		return Object.Instantiate<GameObject>(this.plazmaBallPrefab);
	}

	// Token: 0x0600016A RID: 362 RVA: 0x0003DF68 File Offset: 0x0003C168
	public void ReturnPlazmaBallToPool(GameObject plazmaBall)
	{
		this.plazmaBallPool.Enqueue(plazmaBall);
		plazmaBall.SetActive(false);
	}

	// Token: 0x0600016B RID: 363 RVA: 0x0003DF7D File Offset: 0x0003C17D
	public GameObject GetColliderCircleFromPool()
	{
		if (this.circleColliderPool.Count > 0)
		{
			GameObject gameObject = this.circleColliderPool.Dequeue();
			gameObject.SetActive(true);
			return gameObject;
		}
		return Object.Instantiate<GameObject>(this.circleColliderPrefab);
	}

	// Token: 0x0600016C RID: 364 RVA: 0x0003DFAB File Offset: 0x0003C1AB
	public void ReturnCircleColliderFromPool(GameObject circleCollider)
	{
		this.circleColliderPool.Enqueue(circleCollider);
		circleCollider.SetActive(false);
	}

	// Token: 0x04000700 RID: 1792
	public static ObjectPool instance;

	// Token: 0x04000701 RID: 1793
	[SerializeField]
	private GameObject textPrefab;

	// Token: 0x04000702 RID: 1794
	private Queue<GameObject> textPool = new Queue<GameObject>();

	// Token: 0x04000703 RID: 1795
	[SerializeField]
	private int textPoolSize = 50;

	// Token: 0x04000704 RID: 1796
	[SerializeField]
	private GameObject pickAxePrefab;

	// Token: 0x04000705 RID: 1797
	private Queue<GameObject> pickaxePool = new Queue<GameObject>();

	// Token: 0x04000706 RID: 1798
	[SerializeField]
	private int pickaxePoolSize = 50;

	// Token: 0x04000707 RID: 1799
	[SerializeField]
	private GameObject rockPrefab;

	// Token: 0x04000708 RID: 1800
	private Queue<GameObject> rockPool = new Queue<GameObject>();

	// Token: 0x04000709 RID: 1801
	[SerializeField]
	private int rockPoolSize = 50;

	// Token: 0x0400070A RID: 1802
	[SerializeField]
	private GameObject tilePrefab;

	// Token: 0x0400070B RID: 1803
	private Queue<GameObject> tilePool = new Queue<GameObject>();

	// Token: 0x0400070C RID: 1804
	[SerializeField]
	private int tilePoolSize = 150;

	// Token: 0x0400070D RID: 1805
	[SerializeField]
	private GameObject rockParticlePrefab;

	// Token: 0x0400070E RID: 1806
	private Queue<GameObject> rockParticlePool = new Queue<GameObject>();

	// Token: 0x0400070F RID: 1807
	[SerializeField]
	private int rockParticlePoolSize = 25;

	// Token: 0x04000710 RID: 1808
	[SerializeField]
	private GameObject beamOfLightPrefab;

	// Token: 0x04000711 RID: 1809
	private Queue<GameObject> beamOfLightPool = new Queue<GameObject>();

	// Token: 0x04000712 RID: 1810
	[SerializeField]
	private int beamOfLightPoolSize = 5;

	// Token: 0x04000713 RID: 1811
	[SerializeField]
	private GameObject plazmaBallPrefab;

	// Token: 0x04000714 RID: 1812
	private Queue<GameObject> plazmaBallPool = new Queue<GameObject>();

	// Token: 0x04000715 RID: 1813
	[SerializeField]
	private int plazmaBallPoolSize = 10;

	// Token: 0x04000716 RID: 1814
	[SerializeField]
	private GameObject mineMaterialPrefab;

	// Token: 0x04000717 RID: 1815
	private Queue<GameObject> mineMaterialPool = new Queue<GameObject>();

	// Token: 0x04000718 RID: 1816
	[SerializeField]
	private int mineMaterialPoolSize = 35;

	// Token: 0x04000719 RID: 1817
	[SerializeField]
	private GameObject circleColliderPrefab;

	// Token: 0x0400071A RID: 1818
	private Queue<GameObject> circleColliderPool = new Queue<GameObject>();

	// Token: 0x0400071B RID: 1819
	[SerializeField]
	private int circleColliderPoolSize = 10;

	// Token: 0x0400071C RID: 1820
	[SerializeField]
	private GameObject electricitySplashPrefab;

	// Token: 0x0400071D RID: 1821
	private Queue<GameObject> electricityPool = new Queue<GameObject>();

	// Token: 0x0400071E RID: 1822
	[SerializeField]
	private int electricityPoolSize = 35;

	// Token: 0x0400071F RID: 1823
	[SerializeField]
	private GameObject dynamitePrefab;

	// Token: 0x04000720 RID: 1824
	private Queue<GameObject> dynamitePool = new Queue<GameObject>();

	// Token: 0x04000721 RID: 1825
	[SerializeField]
	private int dynamitePoolSize = 40;

	// Token: 0x04000722 RID: 1826
	public Transform pickaxeParent;

	// Token: 0x04000723 RID: 1827
	public Transform rockParent;

	// Token: 0x04000724 RID: 1828
	public Transform tileParent;

	// Token: 0x04000725 RID: 1829
	public Transform rockParticleParent;

	// Token: 0x04000726 RID: 1830
	public Transform textParent;

	// Token: 0x04000727 RID: 1831
	public Transform theMineMaterialParent;

	// Token: 0x04000728 RID: 1832
	public Transform circleParent;

	// Token: 0x04000729 RID: 1833
	public Transform projectileParent;
}
