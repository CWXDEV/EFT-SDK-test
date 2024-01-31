using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Ballistics;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x02002813 RID: 10259
public struct DamageInfo
{
	// Token: 0x170024A3 RID: 9379
	// (get) Token: 0x0600CD46 RID: 52550 RVA: 0x00002050 File Offset: 0x00000250
	public bool Blunt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024A4 RID: 9380
	// (get) Token: 0x0600CD47 RID: 52551 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveOwner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600CD48 RID: 52552 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DamageInfo GetOverDamage(EBodyPart sourceBodyPart)
	{
		throw null;
	}

	// Token: 0x0400CDA9 RID: 52649
	public EDamageType DamageType;

	// Token: 0x0400CDAA RID: 52650
	public float Damage;

	// Token: 0x0400CDAB RID: 52651
	public float PenetrationPower;

	// Token: 0x0400CDAC RID: 52652
	public Collider HitCollider;

	// Token: 0x0400CDAD RID: 52653
	public Vector3 Direction;

	// Token: 0x0400CDAE RID: 52654
	public Vector3 HitPoint;

	// Token: 0x0400CDAF RID: 52655
	public Vector3 MasterOrigin;

	// Token: 0x0400CDB0 RID: 52656
	public Vector3 HitNormal;

	// Token: 0x0400CDB1 RID: 52657
	public BallisticCollider HittedBallisticCollider;

	// Token: 0x0400CDB2 RID: 52658
	public GInterface94 Player;

	// Token: 0x0400CDB3 RID: 52659
	public Item Weapon;

	// Token: 0x0400CDB4 RID: 52660
	public int FireIndex;

	// Token: 0x0400CDB5 RID: 52661
	public float ArmorDamage;

	// Token: 0x0400CDB6 RID: 52662
	public bool IsForwardHit;

	// Token: 0x0400CDB7 RID: 52663
	public float HeavyBleedingDelta;

	// Token: 0x0400CDB8 RID: 52664
	public float LightBleedingDelta;

	// Token: 0x0400CDB9 RID: 52665
	public bool BleedBlock;

	// Token: 0x0400CDBA RID: 52666
	public string DeflectedBy;

	// Token: 0x0400CDBB RID: 52667
	public string BlockedBy;

	// Token: 0x0400CDBC RID: 52668
	public float StaminaBurnRate;

	// Token: 0x0400CDBD RID: 52669
	public float DidBodyDamage;

	// Token: 0x0400CDBE RID: 52670
	public float DidArmorDamage;

	// Token: 0x0400CDBF RID: 52671
	public string SourceId;

	// Token: 0x0400CDC0 RID: 52672
	public EBodyPart? OverDamageFrom;

	// Token: 0x0400CDC1 RID: 52673
	public EBodyPartColliderType BodyPartColliderType;
}
