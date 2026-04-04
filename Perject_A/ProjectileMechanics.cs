using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000015 RID: 21
public class ProjectileMechanics : MonoBehaviour
{
	// Token: 0x06000064 RID: 100 RVA: 0x0000660C File Offset: 0x0000480C
	private void Awake()
	{
		GameObject gameObject = GameObject.Find("AudioManager");
		this.audioManager = gameObject.GetComponent<AudioManager>();
		GameObject gameObject2 = GameObject.Find("SpawnProjectiles");
		this.spawnProjectileScript = gameObject2.GetComponent<SpawnProjectiles>();
		GameObject gameObject3 = GameObject.Find("SetRockScreen");
		this.setRockScreenScript = gameObject3.GetComponent<SetRockScreen>();
		if (this.isBeamOfLight)
		{
			this.beamParticle_s = base.transform.Find("Lazer_blue");
			this.beamParticle_ph = base.transform.Find("Lazer_red");
			this.beam_s = this.beamParticle_s.GetComponent<ParticleSystem>();
			this.beam_ph = this.beamParticle_ph.GetComponent<ParticleSystem>();
			this.collider2d = base.gameObject.GetComponent<Collider2D>();
		}
		if (this.isElectricity)
		{
			this.electricityChild = base.transform.Find("Electricity_Splash_5");
			this.colliderChild = base.transform.Find("ColliderSplash");
			this.electricityParticle = this.electricityChild.GetComponent<ParticleSystem>();
		}
		if (this.isPlazmaBall)
		{
			this.plazmaObject = base.transform.Find("PlazmaBallParticle");
			this.plazmaParticle = this.plazmaObject.GetComponent<ParticleSystem>();
			this.rb = base.gameObject.GetComponent<Rigidbody2D>();
		}
		if (this.isDynamite)
		{
			this.collider2d = base.gameObject.GetComponent<Collider2D>();
			this.dynamiteIcon = base.transform.Find("DynamiteIcon");
			this.dynamiteParticleChild = base.transform.Find("DynamiteParticle");
			this.dynamiteParticle = this.dynamiteParticleChild.GetComponent<ParticleSystem>();
			this.smallExplosion1Child = base.transform.Find("smallExplosion1");
			this.smallExplosion1 = this.smallExplosion1Child.GetComponent<ParticleSystem>();
			this.smallExplosion2Child = base.transform.Find("smallExplosion2");
			this.smallExplosion2 = this.smallExplosion2Child.GetComponent<ParticleSystem>();
		}
	}

	// Token: 0x06000065 RID: 101 RVA: 0x000067F1 File Offset: 0x000049F1
	public void Update()
	{
		if (this.isPlazmaBall && !SetRockScreen.isInMiningSession && this.isPlazmaOn)
		{
			base.StartCoroutine(this.ScaleObject(base.gameObject));
			this.isPlazmaOn = false;
		}
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00006824 File Offset: 0x00004A24
	private void OnEnable()
	{
		this.isBeam_ph = false;
		if (this.isBeamOfLight)
		{
			this.beamParticle_s.gameObject.SetActive(false);
			this.beamParticle_ph.gameObject.SetActive(false);
			this.collider2d.enabled = false;
		}
		else if (this.isPlazmaBall)
		{
			this.isPlazmaOn = true;
			this.plazmaObject.gameObject.SetActive(true);
			this.plazmaParticle.Play();
			base.StartCoroutine(this.MoveParticle());
		}
		else if (this.isElectricity)
		{
			base.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, (float)Random.Range(0, -360));
			this.electricityParticle.Play();
		}
		else if (this.isDynamite)
		{
			this.smallExplosion1Child.gameObject.SetActive(false);
			this.smallExplosion2Child.gameObject.SetActive(false);
			this.dynamiteIcon.gameObject.SetActive(true);
			float num = 23f * SkillTree.explosionSize;
			this.dynamiteParticleChild.transform.localScale = new Vector3(num, num, num);
			this.dynamiteParticleChild.gameObject.SetActive(false);
		}
		base.StartCoroutine(this.SetBack());
	}

	// Token: 0x06000067 RID: 103 RVA: 0x0000696D File Offset: 0x00004B6D
	private IEnumerator SpawnSmallBall()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
			if ((float)Random.Range(0, 100) < SkillTree.plazmaBallSpawnSmallBallChance)
			{
				GameObject plazmaBallFromPool = ObjectPool.instance.GetPlazmaBallFromPool();
				plazmaBallFromPool.transform.localScale = new Vector3(base.gameObject.transform.localScale.x / 2f, base.gameObject.transform.localScale.y / 2f, base.gameObject.transform.localScale.z / 2f);
				plazmaBallFromPool.transform.position = base.gameObject.transform.position;
			}
		}
		yield break;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x0000697C File Offset: 0x00004B7C
	private IEnumerator MoveParticle()
	{
		yield return new WaitForSeconds(0.2f);
		if (SkillTree.plazmaBallSpawnSmallChance_purchased && base.gameObject.transform.localScale.x > 0.79f)
		{
			base.StartCoroutine(this.SpawnSmallBall());
		}
		if (base.gameObject.transform.localScale.x > 0.79f)
		{
			Vector2 a = new Vector2(Random.Range(-0.55f, 0.55f), Random.Range(-0.55f, 0.55f));
			Vector2 b = base.transform.position;
			Vector2 normalized = (a - b).normalized;
			this.rb.linearVelocity = normalized * 0.6f;
		}
		else
		{
			Vector2 normalized2 = Random.insideUnitCircle.normalized;
			this.rb.linearVelocity = normalized2 * 0.35f;
		}
		yield break;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x0000698B File Offset: 0x00004B8B
	private IEnumerator SetBack()
	{
		if (this.isBeamOfLight)
		{
			yield return new WaitForSeconds(0.05f);
			if (base.gameObject.tag == "Beam_S")
			{
				this.beamParticle_s.gameObject.SetActive(true);
				this.beam_s.Play();
				this.isBeam_s = true;
			}
			else
			{
				this.beamParticle_ph.gameObject.SetActive(true);
				this.beam_ph.Play();
				this.isBeam_ph = true;
			}
		}
		float time = 1f;
		if (this.isBeamOfLight)
		{
			yield return new WaitForSeconds(0.1f);
			this.collider2d.enabled = true;
			if (SkillTree.lightningBeamExplosion_purchased && (float)Random.Range(0, 100) < SkillTree.lightningSpawnExplosionChance && SpawnProjectiles.totalDynamitesOnScreen < 35)
			{
				SpawnProjectiles.totalDynamitesOnScreen++;
				GameObject dynamiteFromPool = ObjectPool.instance.GetDynamiteFromPool();
				dynamiteFromPool.tag = "OnlyExplosion";
				dynamiteFromPool.transform.position = base.gameObject.transform.position;
			}
			if (SkillTree.lightningBeamSpawnAnotherOneChance_purchased && (float)Random.Range(0, 100) < SkillTree.triggerAnotherLighntingChance)
			{
				if (this.isBeam_s)
				{
					this.spawnProjectileScript.SelectRandomActiveRock(2);
				}
				if (this.isBeam_ph)
				{
					this.spawnProjectileScript.SelectRandomActiveRock(4);
				}
			}
			if (SkillTree.lightningBeamAddTime_purchased && Random.Range(0f, 100f) < SkillTree.lightningAddTimeChance)
			{
				SetRockScreen.currentTime -= 1f;
			}
			if (SkillTree.lightningBeamSpawnRock_purchased && (float)Random.Range(0, 100) < SkillTree.lightningSpawnRockChance)
			{
				SetRockScreen.tileWaveNumber = Random.Range(0, 14);
				this.setRockScreenScript.SpawnRockCount(1);
			}
			if (SkillTree.lightningSplashes_purchased && (float)Random.Range(0, 100) < SkillTree.lightningSplashChance)
			{
				for (int i = 0; i < Random.Range(3, 6); i++)
				{
					ObjectPool.instance.GetElectricitySplashFromPool().transform.position = new Vector3(base.gameObject.transform.position.x, base.gameObject.transform.position.y, 1f);
				}
			}
			time = 1.5f;
		}
		else if (this.isPlazmaBall)
		{
			time = SkillTree.plazmaBallTimer;
		}
		else if (this.isElectricity)
		{
			time = 1f;
		}
		else if (this.isDynamite)
		{
			yield return new WaitForSeconds(0.05f);
			if (base.gameObject.tag == "Dynamite")
			{
				this.dynamiteIcon.gameObject.SetActive(true);
				yield return new WaitForSeconds(0.35f);
			}
			else
			{
				this.dynamiteIcon.gameObject.SetActive(false);
			}
			this.dynamiteIcon.gameObject.SetActive(false);
			this.dynamiteParticleChild.gameObject.SetActive(true);
			this.dynamiteParticle.Play();
			this.audioManager.Play("Dynamite");
			time = 1f;
			if (SkillTree.dynamiteExplosionSpawnRock_purchased && (float)Random.Range(0, 100) < SkillTree.chanceToSpawnRockFromExplosion)
			{
				SetRockScreen.tileWaveNumber = Random.Range(0, 14);
				this.setRockScreenScript.SpawnRockCount(1);
			}
			if (SkillTree.dynamiteExplosionAddTimeChance_purchased && Random.Range(0f, 100f) < SkillTree.explosionAdd1SecondChance)
			{
				SetRockScreen.currentTime -= 1f;
			}
			if (SkillTree.dynamiteExplosionSpawnLightning_purchased && (float)Random.Range(0, 100) < SkillTree.explosionChanceToSpawnLightning)
			{
				int num = Random.Range(1, 3);
				if (num == 1)
				{
					this.spawnProjectileScript.SelectRandomActiveRock(2);
				}
				if (num == 2)
				{
					this.spawnProjectileScript.SelectRandomActiveRock(4);
				}
			}
			if (SkillTree.dynamiteChance_2_purchased && (float)Random.Range(0, 100) < SkillTree.spawn2DynamiteChance)
			{
				yield return new WaitForSeconds(0.3f);
				this.smallExplosion1Child.gameObject.SetActive(true);
				this.smallExplosion2Child.gameObject.SetActive(true);
				this.smallExplosion1.Play();
				this.smallExplosion2.Play();
				this.audioManager.Play("Dynamite");
			}
		}
		yield return new WaitForSeconds(time);
		if (this.isBeamOfLight)
		{
			ObjectPool.instance.ReturnBeamOfLight(base.gameObject);
			SpawnProjectiles.totalBeamsOnScreen--;
		}
		else if (this.isPlazmaBall)
		{
			base.StartCoroutine(this.ScaleObject(base.gameObject));
		}
		else if (this.isElectricity)
		{
			ObjectPool.instance.ReturnElectricitySplashFromPool(base.gameObject);
		}
		else if (this.isDynamite)
		{
			ObjectPool.instance.ReturnDynamiteFromPool(base.gameObject);
			SpawnProjectiles.totalDynamitesOnScreen--;
		}
		yield break;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x0000699A File Offset: 0x00004B9A
	private IEnumerator ScaleObject(GameObject objectToScale)
	{
		float duration = 0.2f;
		float elapsedTime = 0f;
		Vector3 startScale = objectToScale.transform.localScale;
		Vector3 endScale = Vector3.zero;
		while (elapsedTime < duration)
		{
			objectToScale.transform.localScale = Vector3.Lerp(startScale, endScale, elapsedTime / duration);
			elapsedTime += Time.deltaTime;
			yield return null;
		}
		objectToScale.transform.localScale = endScale;
		if (this.isPlazmaBall)
		{
			if (SkillTree.plazmaBallExplosionChance_purchased && (float)Random.Range(0, 100) < SkillTree.plazmaballExplosionChance && SpawnProjectiles.totalDynamitesOnScreen < 35)
			{
				SpawnProjectiles.totalDynamitesOnScreen++;
				GameObject dynamiteFromPool = ObjectPool.instance.GetDynamiteFromPool();
				dynamiteFromPool.tag = "OnlyExplosion";
				dynamiteFromPool.transform.position = base.gameObject.transform.position;
			}
			ObjectPool.instance.ReturnPlazmaBallToPool(objectToScale);
		}
		yield break;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x000069B0 File Offset: 0x00004BB0
	private void OnDisable()
	{
		base.StopAllCoroutines();
	}

	// Token: 0x040001EC RID: 492
	public SpawnProjectiles spawnProjectileScript;

	// Token: 0x040001ED RID: 493
	public SetRockScreen setRockScreenScript;

	// Token: 0x040001EE RID: 494
	private bool isBeam_s;

	// Token: 0x040001EF RID: 495
	private bool isBeam_ph;

	// Token: 0x040001F0 RID: 496
	public bool isBeamOfLight;

	// Token: 0x040001F1 RID: 497
	public bool isElectricity;

	// Token: 0x040001F2 RID: 498
	public bool isPlazmaBall;

	// Token: 0x040001F3 RID: 499
	public bool isDynamite;

	// Token: 0x040001F4 RID: 500
	public ParticleSystem beam_s;

	// Token: 0x040001F5 RID: 501
	public ParticleSystem beam_ph;

	// Token: 0x040001F6 RID: 502
	public ParticleSystem electricityParticle;

	// Token: 0x040001F7 RID: 503
	public ParticleSystem dynamiteParticle;

	// Token: 0x040001F8 RID: 504
	public Transform beamParticle_s;

	// Token: 0x040001F9 RID: 505
	public Transform beamParticle_ph;

	// Token: 0x040001FA RID: 506
	public Transform electricityChild;

	// Token: 0x040001FB RID: 507
	public Transform colliderChild;

	// Token: 0x040001FC RID: 508
	public Transform dynamiteIcon;

	// Token: 0x040001FD RID: 509
	public Transform dynamiteParticleChild;

	// Token: 0x040001FE RID: 510
	public ParticleSystem plazmaParticle;

	// Token: 0x040001FF RID: 511
	public Transform plazmaObject;

	// Token: 0x04000200 RID: 512
	private Rigidbody2D rb;

	// Token: 0x04000201 RID: 513
	private Collider2D collider2d;

	// Token: 0x04000202 RID: 514
	private Transform smallExplosion1Child;

	// Token: 0x04000203 RID: 515
	private Transform smallExplosion2Child;

	// Token: 0x04000204 RID: 516
	public ParticleSystem smallExplosion1;

	// Token: 0x04000205 RID: 517
	public ParticleSystem smallExplosion2;

	// Token: 0x04000206 RID: 518
	public AudioManager audioManager;

	// Token: 0x04000207 RID: 519
	private bool isPlazmaOn;
}
