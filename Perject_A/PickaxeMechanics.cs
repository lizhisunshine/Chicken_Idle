using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000014 RID: 20
public class PickaxeMechanics : MonoBehaviour
{
	// Token: 0x0600005D RID: 93 RVA: 0x00005BBC File Offset: 0x00003DBC
	private void Awake()
	{
		this.pickaxe1 = base.transform.Find("pickaxe_MrRusty");
		this.pickaxe2 = base.transform.Find("pickaxe2");
		this.pickaxe3 = base.transform.Find("pickaxe3");
		this.pickaxe4 = base.transform.Find("pickaxe4");
		this.pickaxe5 = base.transform.Find("pickaxe5");
		this.pickaxe6 = base.transform.Find("pickaxe6");
		this.pickaxe7 = base.transform.Find("pickaxe7");
		this.pickaxe8 = base.transform.Find("pickaxe8");
		this.pickaxe9 = base.transform.Find("pickaxe9");
		this.pickaxe10 = base.transform.Find("pickaxe10");
		this.pickaxe11 = base.transform.Find("pickaxe11");
		this.pickaxe12 = base.transform.Find("pickaxe12");
		this.pickaxe13 = base.transform.Find("pickaxe13");
		this.pickaxe14 = base.transform.Find("pickaxe14");
		if (TheAnvil.isDLC)
		{
			this.pickaxe1_Skin1 = base.transform.Find("pickaxe_MrRusty_Skin1");
			this.pickaxe2_Skin1 = base.transform.Find("pickaxe2_Skin1");
			this.pickaxe3_Skin1 = base.transform.Find("pickaxe3_Skin1");
			this.pickaxe4_Skin1 = base.transform.Find("pickaxe4_Skin1");
			this.pickaxe5_Skin1 = base.transform.Find("pickaxe5_Skin1");
			this.pickaxe6_Skin1 = base.transform.Find("pickaxe6_Skin1");
			this.pickaxe7_Skin1 = base.transform.Find("pickaxe7_Skin1");
			this.pickaxe8_Skin1 = base.transform.Find("pickaxe8_Skin1");
			this.pickaxe9_Skin1 = base.transform.Find("pickaxe9_Skin1");
			this.pickaxe10_Skin1 = base.transform.Find("pickaxe10_Skin1");
			this.pickaxe11_Skin1 = base.transform.Find("pickaxe11_Skin1");
			this.pickaxe12_Skin1 = base.transform.Find("pickaxe12_Skin1");
			this.pickaxe13_Skin1 = base.transform.Find("pickaxe13_Skin1");
			this.pickaxe1_Skin2 = base.transform.Find("pickaxe_MrRusty_Skin2");
			this.pickaxe2_Skin2 = base.transform.Find("pickaxe2_Skin2");
			this.pickaxe3_Skin2 = base.transform.Find("pickaxe3_Skin2");
			this.pickaxe4_Skin2 = base.transform.Find("pickaxe4_Skin2");
			this.pickaxe5_Skin2 = base.transform.Find("pickaxe5_Skin2");
			this.pickaxe6_Skin2 = base.transform.Find("pickaxe6_Skin2");
			this.pickaxe7_Skin2 = base.transform.Find("pickaxe7_Skin2");
			this.pickaxe8_Skin2 = base.transform.Find("pickaxe8_Skin2");
			this.pickaxe9_Skin2 = base.transform.Find("pickaxe9_Skin2");
			this.pickaxe10_Skin2 = base.transform.Find("pickaxe10_Skin2");
			this.pickaxe11_Skin2 = base.transform.Find("pickaxe11_Skin2");
			this.pickaxe12_Skin2 = base.transform.Find("pickaxe12_Skin2");
			this.pickaxe13_Skin2 = base.transform.Find("pickaxe13_Skin2");
		}
		this.hammer = base.transform.Find("hammer");
		this.rightCollider = base.transform.Find("right");
		this.rightCollider2 = base.transform.Find("right2");
		this.leftCollider = base.transform.Find("left");
		this.leftCollider2 = base.transform.Find("left2");
		this.pickAxeIconSprite = this.pickaxe1.GetComponent<SpriteRenderer>();
		this.swingAnim = base.gameObject.GetComponent<Animation>();
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00005FD4 File Offset: 0x000041D4
	private void OnEnable()
	{
		if (this.equippedPickaxe != null)
		{
			this.equippedPickaxe.gameObject.SetActive(false);
		}
		if (TheAnvil.pickaxe1_equipped)
		{
			this.equippedPickaxe = this.pickaxe1;
		}
		if (TheAnvil.pickaxe2_equipped)
		{
			this.equippedPickaxe = this.pickaxe2;
		}
		if (TheAnvil.pickaxe3_equipped)
		{
			this.equippedPickaxe = this.pickaxe3;
		}
		if (TheAnvil.pickaxe4_equipped)
		{
			this.equippedPickaxe = this.pickaxe4;
		}
		if (TheAnvil.pickaxe5_equipped)
		{
			this.equippedPickaxe = this.pickaxe5;
		}
		if (TheAnvil.pickaxe6_equipped)
		{
			this.equippedPickaxe = this.pickaxe6;
		}
		if (TheAnvil.pickaxe7_equipped)
		{
			this.equippedPickaxe = this.pickaxe7;
		}
		if (TheAnvil.pickaxe8_equipped)
		{
			this.equippedPickaxe = this.pickaxe8;
		}
		if (TheAnvil.pickaxe9_equipped)
		{
			this.equippedPickaxe = this.pickaxe9;
		}
		if (TheAnvil.pickaxe10_equipped)
		{
			this.equippedPickaxe = this.pickaxe10;
		}
		if (TheAnvil.pickaxe11_equipped)
		{
			this.equippedPickaxe = this.pickaxe11;
		}
		if (TheAnvil.pickaxe12_equipped)
		{
			this.equippedPickaxe = this.pickaxe12;
		}
		if (TheAnvil.pickaxe13_equipped)
		{
			this.equippedPickaxe = this.pickaxe13;
		}
		if (TheAnvil.pickaxe14_equipped)
		{
			this.equippedPickaxe = this.pickaxe14;
		}
		if (TheAnvil.isDLC)
		{
			if (TheAnvil.pickaxe1_equipped)
			{
				if (TheAnvil.pickaxe1_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe1;
				}
				if (TheAnvil.pickaxe1_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe1_Skin1;
				}
				if (TheAnvil.pickaxe1_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe1_Skin2;
				}
			}
			if (TheAnvil.pickaxe2_equipped)
			{
				if (TheAnvil.pickaxe2_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe2;
				}
				if (TheAnvil.pickaxe2_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe2_Skin1;
				}
				if (TheAnvil.pickaxe2_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe2_Skin2;
				}
			}
			if (TheAnvil.pickaxe3_equipped)
			{
				if (TheAnvil.pickaxe3_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe3;
				}
				if (TheAnvil.pickaxe3_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe3_Skin1;
				}
				if (TheAnvil.pickaxe3_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe3_Skin2;
				}
			}
			if (TheAnvil.pickaxe4_equipped)
			{
				if (TheAnvil.pickaxe4_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe4;
				}
				if (TheAnvil.pickaxe4_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe4_Skin1;
				}
				if (TheAnvil.pickaxe4_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe4_Skin2;
				}
			}
			if (TheAnvil.pickaxe5_equipped)
			{
				if (TheAnvil.pickaxe5_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe5;
				}
				if (TheAnvil.pickaxe5_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe5_Skin1;
				}
				if (TheAnvil.pickaxe5_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe5_Skin2;
				}
			}
			if (TheAnvil.pickaxe6_equipped)
			{
				if (TheAnvil.pickaxe6_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe6;
				}
				if (TheAnvil.pickaxe6_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe6_Skin1;
				}
				if (TheAnvil.pickaxe6_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe6_Skin2;
				}
			}
			if (TheAnvil.pickaxe7_equipped)
			{
				if (TheAnvil.pickaxe7_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe7;
				}
				if (TheAnvil.pickaxe7_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe7_Skin1;
				}
				if (TheAnvil.pickaxe7_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe7_Skin2;
				}
			}
			if (TheAnvil.pickaxe8_equipped)
			{
				if (TheAnvil.pickaxe8_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe8;
				}
				if (TheAnvil.pickaxe8_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe8_Skin1;
				}
				if (TheAnvil.pickaxe8_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe8_Skin2;
				}
			}
			if (TheAnvil.pickaxe9_equipped)
			{
				if (TheAnvil.pickaxe9_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe9;
				}
				if (TheAnvil.pickaxe9_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe9_Skin1;
				}
				if (TheAnvil.pickaxe9_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe9_Skin2;
				}
			}
			if (TheAnvil.pickaxe10_equipped)
			{
				if (TheAnvil.pickaxe10_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe10;
				}
				if (TheAnvil.pickaxe10_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe10_Skin1;
				}
				if (TheAnvil.pickaxe10_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe10_Skin2;
				}
			}
			if (TheAnvil.pickaxe11_equipped)
			{
				if (TheAnvil.pickaxe11_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe11;
				}
				if (TheAnvil.pickaxe11_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe11_Skin1;
				}
				if (TheAnvil.pickaxe11_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe11_Skin2;
				}
			}
			if (TheAnvil.pickaxe12_equipped)
			{
				if (TheAnvil.pickaxe12_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe12;
				}
				if (TheAnvil.pickaxe12_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe12_Skin1;
				}
				if (TheAnvil.pickaxe12_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe12_Skin2;
				}
			}
			if (TheAnvil.pickaxe13_equipped)
			{
				if (TheAnvil.pickaxe13_skinsChosen == 0)
				{
					this.equippedPickaxe = this.pickaxe13;
				}
				if (TheAnvil.pickaxe13_skinsChosen == 1)
				{
					this.equippedPickaxe = this.pickaxe13_Skin1;
				}
				if (TheAnvil.pickaxe13_skinsChosen == 2)
				{
					this.equippedPickaxe = this.pickaxe13_Skin2;
				}
			}
		}
		this.equippedPickaxe.gameObject.SetActive(true);
		Color color = this.pickAxeIconSprite.color;
		color.a = 1f;
		this.pickAxeIconSprite.color = color;
		this.rightCollider.gameObject.SetActive(false);
		this.rightCollider2.gameObject.SetActive(false);
		this.leftCollider.gameObject.SetActive(false);
		this.leftCollider2.gameObject.SetActive(false);
		base.StartCoroutine(this.SpawnAndSwing());
		if (!LevelMechanics.itsHammerTime_chosen)
		{
			this.CheckPickaxe();
			return;
		}
		if ((float)Random.Range(0, 100) < LevelMechanics.hammerChance)
		{
			AllStats.hammersSpawned++;
			this.equippedPickaxe.gameObject.SetActive(false);
			this.hammer.gameObject.SetActive(true);
			this.rightCollider.gameObject.layer = 7;
			this.leftCollider.gameObject.layer = 7;
			this.rightCollider2.gameObject.layer = 7;
			this.leftCollider2.gameObject.layer = 7;
			return;
		}
		this.CheckPickaxe();
	}

	// Token: 0x0600005F RID: 95 RVA: 0x0000658E File Offset: 0x0000478E
	public void CheckPickaxe()
	{
		this.hammer.gameObject.SetActive(false);
		this.equippedPickaxe.gameObject.SetActive(true);
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000065B2 File Offset: 0x000047B2
	private IEnumerator SpawnAndSwing()
	{
		yield return new WaitForSeconds(0.02f);
		bool isRight = false;
		if (base.gameObject.layer == 6)
		{
			isRight = true;
			base.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 8f);
			this.swingAnim.Play("Swing");
		}
		else
		{
			base.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, -8f);
			this.swingAnim.Play("SwingLeft");
		}
		yield return new WaitForSeconds(0.25f);
		int num = Random.Range(0, 2);
		if (isRight)
		{
			if (num == 0)
			{
				this.rightCollider.gameObject.SetActive(true);
			}
			if (num == 1)
			{
				this.rightCollider2.gameObject.SetActive(true);
			}
		}
		else
		{
			if (num == 0)
			{
				this.leftCollider.gameObject.SetActive(true);
			}
			if (num == 1)
			{
				this.leftCollider2.gameObject.SetActive(true);
			}
		}
		yield return new WaitForSeconds(0.04f);
		this.SetIconAlpha(0f);
		base.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x000065C4 File Offset: 0x000047C4
	private void SetIconAlpha(float a)
	{
		Color color = this.pickAxeIconSprite.color;
		color.a = a;
		this.pickAxeIconSprite.color = color;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000065F1 File Offset: 0x000047F1
	private void OnDisable()
	{
		ObjectPool.instance.ReturnPickaxeFromPool(base.gameObject);
	}

	// Token: 0x040001BC RID: 444
	public Animation swingAnim;

	// Token: 0x040001BD RID: 445
	public Transform rightCollider;

	// Token: 0x040001BE RID: 446
	public Transform rightCollider2;

	// Token: 0x040001BF RID: 447
	public Transform leftCollider;

	// Token: 0x040001C0 RID: 448
	public Transform leftCollider2;

	// Token: 0x040001C1 RID: 449
	public SpriteRenderer pickAxeIconSprite;

	// Token: 0x040001C2 RID: 450
	public Transform pickaxe1;

	// Token: 0x040001C3 RID: 451
	public Transform pickaxe2;

	// Token: 0x040001C4 RID: 452
	public Transform pickaxe3;

	// Token: 0x040001C5 RID: 453
	public Transform pickaxe4;

	// Token: 0x040001C6 RID: 454
	public Transform pickaxe5;

	// Token: 0x040001C7 RID: 455
	public Transform pickaxe6;

	// Token: 0x040001C8 RID: 456
	public Transform pickaxe7;

	// Token: 0x040001C9 RID: 457
	public Transform pickaxe8;

	// Token: 0x040001CA RID: 458
	public Transform pickaxe9;

	// Token: 0x040001CB RID: 459
	public Transform pickaxe10;

	// Token: 0x040001CC RID: 460
	public Transform pickaxe11;

	// Token: 0x040001CD RID: 461
	public Transform pickaxe12;

	// Token: 0x040001CE RID: 462
	public Transform pickaxe13;

	// Token: 0x040001CF RID: 463
	public Transform pickaxe14;

	// Token: 0x040001D0 RID: 464
	public Transform pickaxe1_Skin1;

	// Token: 0x040001D1 RID: 465
	public Transform pickaxe2_Skin1;

	// Token: 0x040001D2 RID: 466
	public Transform pickaxe3_Skin1;

	// Token: 0x040001D3 RID: 467
	public Transform pickaxe4_Skin1;

	// Token: 0x040001D4 RID: 468
	public Transform pickaxe5_Skin1;

	// Token: 0x040001D5 RID: 469
	public Transform pickaxe6_Skin1;

	// Token: 0x040001D6 RID: 470
	public Transform pickaxe7_Skin1;

	// Token: 0x040001D7 RID: 471
	public Transform pickaxe8_Skin1;

	// Token: 0x040001D8 RID: 472
	public Transform pickaxe9_Skin1;

	// Token: 0x040001D9 RID: 473
	public Transform pickaxe10_Skin1;

	// Token: 0x040001DA RID: 474
	public Transform pickaxe11_Skin1;

	// Token: 0x040001DB RID: 475
	public Transform pickaxe12_Skin1;

	// Token: 0x040001DC RID: 476
	public Transform pickaxe13_Skin1;

	// Token: 0x040001DD RID: 477
	public Transform pickaxe1_Skin2;

	// Token: 0x040001DE RID: 478
	public Transform pickaxe2_Skin2;

	// Token: 0x040001DF RID: 479
	public Transform pickaxe3_Skin2;

	// Token: 0x040001E0 RID: 480
	public Transform pickaxe4_Skin2;

	// Token: 0x040001E1 RID: 481
	public Transform pickaxe5_Skin2;

	// Token: 0x040001E2 RID: 482
	public Transform pickaxe6_Skin2;

	// Token: 0x040001E3 RID: 483
	public Transform pickaxe7_Skin2;

	// Token: 0x040001E4 RID: 484
	public Transform pickaxe8_Skin2;

	// Token: 0x040001E5 RID: 485
	public Transform pickaxe9_Skin2;

	// Token: 0x040001E6 RID: 486
	public Transform pickaxe10_Skin2;

	// Token: 0x040001E7 RID: 487
	public Transform pickaxe11_Skin2;

	// Token: 0x040001E8 RID: 488
	public Transform pickaxe12_Skin2;

	// Token: 0x040001E9 RID: 489
	public Transform pickaxe13_Skin2;

	// Token: 0x040001EA RID: 490
	public Transform hammer;

	// Token: 0x040001EB RID: 491
	public Transform equippedPickaxe;
}
