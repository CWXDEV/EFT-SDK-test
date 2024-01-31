using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Ballistics;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02002816 RID: 10262
public class GClass2988
{
	// Token: 0x170024A5 RID: 9381
	// (get) Token: 0x0600CD49 RID: 52553 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600CD4A RID: 52554 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2988.EBulletState BulletState
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170024A6 RID: 9382
	// (get) Token: 0x0600CD4B RID: 52555 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 CurrentPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024A7 RID: 9383
	// (get) Token: 0x0600CD4C RID: 52556 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 CurrentDirection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024A8 RID: 9384
	// (get) Token: 0x0600CD4D RID: 52557 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 CurrentVelocity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024A9 RID: 9385
	// (get) Token: 0x0600CD4E RID: 52558 RVA: 0x00002050 File Offset: 0x00000250
	public float VelocitySqrMagnitude
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024AA RID: 9386
	// (get) Token: 0x0600CD4F RID: 52559 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600CD50 RID: 52560 RVA: 0x00002050 File Offset: 0x00000250
	public float BallisticCoefficient
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170024AB RID: 9387
	// (get) Token: 0x0600CD51 RID: 52561 RVA: 0x00002050 File Offset: 0x00000250
	public float HitCosDirectionToNormal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024AC RID: 9388
	// (get) Token: 0x0600CD52 RID: 52562 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsFirstFragment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600CD53 RID: 52563 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Warmup()
	{
		throw null;
	}

	// Token: 0x0600CD54 RID: 52564 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void FillPool()
	{
		throw null;
	}

	// Token: 0x0600CD55 RID: 52565 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GClass2988 smethod_0()
	{
		throw null;
	}

	// Token: 0x0600CD56 RID: 52566 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1(GClass2988 shot)
	{
		throw null;
	}

	// Token: 0x0600CD57 RID: 52567 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600CD58 RID: 52568 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2988 Create(Item ammo, int fragmentIndex, int seed, Vector3 origin, Vector3 direction, float initialSpeed, float speed, float bulletMassGram, float bulletDiameterMilimeters, float damage, float penetrationPower, float penetrationChance, float ricochetChance, float fragmentationChance, float deviationChance, int minFragmentsCount, int maxFragmentsCount, [CanBeNull] BallisticCollider defaultBallisticCollider, [CanBeNull] GInterface354 randoms, float ballisticCoefficient, [CanBeNull] string player, [CanBeNull] Item weapon, int fireIndex, [CanBeNull] GClass2988 parent)
	{
		throw null;
	}

	// Token: 0x0600CD59 RID: 52569 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Release(GClass2988 shot)
	{
		throw null;
	}

	// Token: 0x0600CD5A RID: 52570 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1(Item ammo, int fragmentIndex, int seed, Vector3 origin, Vector3 direction, float initialSpeed, float speed, float bulletMassKg, float bulletDiameterM, float damage, float penetrationPower, float penetrationChance, float ricochetChance, float fragmentationChance, float deviationChance, int minFragmentsCount, int maxFragmentsCount, [CanBeNull] BallisticCollider defaultBallisticCollider, [CanBeNull] GInterface354 randoms, float ballisticCoefficient, [CanBeNull] string playerProfileID, [CanBeNull] Item weapon, int fireIndex, [CanBeNull] GClass2988 parent)
	{
		throw null;
	}

	// Token: 0x0600CD5B RID: 52571 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2(GInterface94 player, Item item)
	{
		throw null;
	}

	// Token: 0x170024AD RID: 9389
	// (get) Token: 0x0600CD5C RID: 52572 RVA: 0x00002050 File Offset: 0x00000250
	public virtual Vector3 HitPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024AE RID: 9390
	// (get) Token: 0x0600CD5D RID: 52573 RVA: 0x00002050 File Offset: 0x00000250
	public virtual Vector3 HitNormal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024AF RID: 9391
	// (get) Token: 0x0600CD5E RID: 52574 RVA: 0x00002050 File Offset: 0x00000250
	public virtual Collider HitCollider
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024B0 RID: 9392
	// (get) Token: 0x0600CD5F RID: 52575 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasAchievedTarget
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024B1 RID: 9393
	// (get) Token: 0x0600CD60 RID: 52576 RVA: 0x00002050 File Offset: 0x00000250
	public float GetTimeSinceShot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024B2 RID: 9394
	// (get) Token: 0x0600CD61 RID: 52577 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsFlyingOutOfTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024B3 RID: 9395
	// (get) Token: 0x0600CD62 RID: 52578 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsShotFinished
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024B4 RID: 9396
	// (get) Token: 0x0600CD63 RID: 52579 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsShotAndParentFinished
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024B5 RID: 9397
	// (get) Token: 0x0600CD64 RID: 52580 RVA: 0x00002050 File Offset: 0x00000250
	public bool AreAllFragmentsFinished
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024B6 RID: 9398
	// (get) Token: 0x0600CD65 RID: 52581 RVA: 0x00002050 File Offset: 0x00000250
	public float VelocityMagnitude
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024B7 RID: 9399
	// (get) Token: 0x0600CD66 RID: 52582 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsFirstHit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600CD67 RID: 52583 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Tick(float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600CD68 RID: 52584 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 method_3()
	{
		throw null;
	}

	// Token: 0x0600CD69 RID: 52585 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update(float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600CD6A RID: 52586 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(float deltaTime, Vector3 prevVector3, Vector3 prevVelocity)
	{
		throw null;
	}

	// Token: 0x0600CD6B RID: 52587 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x0600CD6C RID: 52588 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_6()
	{
		throw null;
	}

	// Token: 0x0600CD6D RID: 52589 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPlayerHitWhereCollidersIntersect(IPlayer player)
	{
		throw null;
	}

	// Token: 0x0600CD6E RID: 52590 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x0600CD6F RID: 52591 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_8()
	{
		throw null;
	}

	// Token: 0x0600CD70 RID: 52592 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_9()
	{
		throw null;
	}

	// Token: 0x0600CD71 RID: 52593 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_10()
	{
		throw null;
	}

	// Token: 0x0600CD72 RID: 52594 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_11()
	{
		throw null;
	}

	// Token: 0x0600CD73 RID: 52595 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_12()
	{
		throw null;
	}

	// Token: 0x0600CD74 RID: 52596 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int smethod_2(GClass2988 shot, int count = 0)
	{
		throw null;
	}

	// Token: 0x0600CD75 RID: 52597 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_13(Vector3 prevPosition, Vector3 nextPosition)
	{
		throw null;
	}

	// Token: 0x0600CD76 RID: 52598 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_14(Vector3 prevPosition, Vector3 nextPosition)
	{
		throw null;
	}

	// Token: 0x0600CD77 RID: 52599 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LinecastInBothSides(Vector3 start, Vector3 end, out RaycastHit bestHit, out bool isForwardHit, LayerMask forwardLayerMask, LayerMask backwardLayerMask, Func<RaycastHit, bool> isHitIgnoredTest)
	{
		throw null;
	}

	// Token: 0x0600CD78 RID: 52600 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsHitIgnored(GInterface94 player, RaycastHit hit, bool isFirstFragment)
	{
		throw null;
	}

	// Token: 0x0600CD79 RID: 52601 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_15(Vector3 prevPosition, Vector3 nextPosition, LayerMask forwardLayerMask, LayerMask backwardLayerMask, Func<RaycastHit, bool> isHitIgnoredTest)
	{
		throw null;
	}

	// Token: 0x0600CD7A RID: 52602 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_16(RaycastHit hit)
	{
		throw null;
	}

	// Token: 0x0600CD7B RID: 52603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private PlayerSpirit method_17(Vector3 prevPosition, Vector3 nextPosition, LayerMask layerMask)
	{
		throw null;
	}

	// Token: 0x0600CD7C RID: 52604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_18(float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600CD7D RID: 52605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float CalculateG1DragCoefficient(float velocity)
	{
		throw null;
	}

	// Token: 0x0600CD7E RID: 52606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CalculateStartVelocity(float currentPosition, float startPosition, out float startVelocity, float time)
	{
		throw null;
	}

	// Token: 0x0600CD7F RID: 52607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float TimeToZeroLevel(float startVelocity, float speedRetardation)
	{
		throw null;
	}

	// Token: 0x0600CD80 RID: 52608 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float TimeToLevel(float deltaHeight, float startVelocity)
	{
		throw null;
	}

	// Token: 0x0600CD81 RID: 52609 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<float, float> SquareRoots(float a, float b, float c)
	{
		throw null;
	}

	// Token: 0x0600CD82 RID: 52610 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmos()
	{
		throw null;
	}

	// Token: 0x0600CD83 RID: 52611 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_19()
	{
		throw null;
	}

	// Token: 0x0600CD84 RID: 52612 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_20(bool isHeavyArmorRicochet = false)
	{
		throw null;
	}

	// Token: 0x0600CD85 RID: 52613 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_21()
	{
		throw null;
	}

	// Token: 0x0600CD86 RID: 52614 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAllFragmentsRecursively(GClass2988[] shots)
	{
		throw null;
	}

	// Token: 0x0600CD87 RID: 52615 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddClientHitPosition(GClass1673 playerHitInfo)
	{
		throw null;
	}

	// Token: 0x0400CDC8 RID: 52680
	[CompilerGenerated]
	private GClass2988.EBulletState ebulletState_0;

	// Token: 0x0400CDC9 RID: 52681
	public const float AIR_DENSITY = 1.2f;

	// Token: 0x0400CDCA RID: 52682
	public const float MIN_PENETRATION_POWER = 0f;

	// Token: 0x0400CDCB RID: 52683
	public const float MAX_PENETRATION_POWER = 100f;

	// Token: 0x0400CDCC RID: 52684
	private const float float_0 = 0.00033f;

	// Token: 0x0400CDCD RID: 52685
	private const float float_1 = 0.002f;

	// Token: 0x0400CDCE RID: 52686
	public const float AERODYNAMIC_COEFFICIENT = 0.0014223f;

	// Token: 0x0400CDCF RID: 52687
	public const float TRAJECTORY_STEP = 0.01f;

	// Token: 0x0400CDD0 RID: 52688
	public const int MAX_RICOCHET_COUNT = 2;

	// Token: 0x0400CDD1 RID: 52689
	public const float MIN_RICOCHET_ANGLE = 85f;

	// Token: 0x0400CDD2 RID: 52690
	public const float MAX_RICOCHET_ANGLE = 160f;

	// Token: 0x0400CDD3 RID: 52691
	public Item Ammo;

	// Token: 0x0400CDD4 RID: 52692
	public float AmmoLifeTime;

	// Token: 0x0400CDD5 RID: 52693
	public int FragmentIndex;

	// Token: 0x0400CDD6 RID: 52694
	public int RandomSeed;

	// Token: 0x0400CDD7 RID: 52695
	public float ArmorDamage;

	// Token: 0x0400CDD8 RID: 52696
	public readonly List<Vector3> PositionHistory;

	// Token: 0x0400CDD9 RID: 52697
	public Vector3 MasterOrigin;

	// Token: 0x0400CDDA RID: 52698
	public Vector3 Direction;

	// Token: 0x0400CDDB RID: 52699
	public float InitialSpeed;

	// Token: 0x0400CDDC RID: 52700
	public float Speed;

	// Token: 0x0400CDDD RID: 52701
	public float DamageDegradationCoefficient;

	// Token: 0x0400CDDE RID: 52702
	public float Damage;

	// Token: 0x0400CDDF RID: 52703
	public float PenetrationPower;

	// Token: 0x0400CDE0 RID: 52704
	public float BulletMassGram;

	// Token: 0x0400CDE1 RID: 52705
	public float BulletDiameterMilimeters;

	// Token: 0x0400CDE2 RID: 52706
	public float PenetrationChance;

	// Token: 0x0400CDE3 RID: 52707
	public float RicochetChance;

	// Token: 0x0400CDE4 RID: 52708
	public float FragmentationChance;

	// Token: 0x0400CDE5 RID: 52709
	public float DeviationChance;

	// Token: 0x0400CDE6 RID: 52710
	public string BlockedBy;

	// Token: 0x0400CDE7 RID: 52711
	public string DeflectedBy;

	// Token: 0x0400CDE8 RID: 52712
	public string HitArmorItemID;

	// Token: 0x0400CDE9 RID: 52713
	public int MinFragmentsCount;

	// Token: 0x0400CDEA RID: 52714
	public int MaxFragmentsCount;

	// Token: 0x0400CDEB RID: 52715
	public float TimeSinceShot;

	// Token: 0x0400CDEC RID: 52716
	public Vector3 StartPosition;

	// Token: 0x0400CDED RID: 52717
	public Vector3 StartVelocity;

	// Token: 0x0400CDEE RID: 52718
	public GClass2989 TrajectoryInfo;

	// Token: 0x0400CDEF RID: 52719
	private Vector3 vector3_0;

	// Token: 0x0400CDF0 RID: 52720
	private Vector3 vector3_1;

	// Token: 0x0400CDF1 RID: 52721
	[CompilerGenerated]
	private float float_2;

	// Token: 0x0400CDF2 RID: 52722
	public BallisticCollider HittedBallisticCollider;

	// Token: 0x0400CDF3 RID: 52723
	[CanBeNull]
	private BallisticCollider ballisticCollider_0;

	// Token: 0x0400CDF4 RID: 52724
	public GInterface354 Randoms;

	// Token: 0x0400CDF5 RID: 52725
	private RaycastHit raycastHit_0;

	// Token: 0x0400CDF6 RID: 52726
	public bool IsForwardHit;

	// Token: 0x0400CDF7 RID: 52727
	public bool AvoidAdditionalDamage;

	// Token: 0x0400CDF8 RID: 52728
	private float float_3;

	// Token: 0x0400CDF9 RID: 52729
	public readonly List<GClass2988> Fragments;

	// Token: 0x0400CDFA RID: 52730
	public GInterface94 Player;

	// Token: 0x0400CDFB RID: 52731
	public string PlayerProfileID;

	// Token: 0x0400CDFC RID: 52732
	public Item Weapon;

	// Token: 0x0400CDFD RID: 52733
	public int FireIndex;

	// Token: 0x0400CDFE RID: 52734
	public GClass2988 Parent;

	// Token: 0x0400CDFF RID: 52735
	private IPlayer iplayer_0;

	// Token: 0x0400CE00 RID: 52736
	private EArmorPlateCollider earmorPlateCollider_0;

	// Token: 0x0400CE01 RID: 52737
	private Func<RaycastHit, bool> func_0;

	// Token: 0x0400CE02 RID: 52738
	private readonly Collider[] collider_0;

	// Token: 0x0400CE03 RID: 52739
	public bool ShotProcessed;

	// Token: 0x0400CE04 RID: 52740
	private const int int_0 = 200;

	// Token: 0x0400CE05 RID: 52741
	private static Stack<GClass2988> stack_0;

	// Token: 0x0400CE06 RID: 52742
	private Vector3 vector3_2;

	// Token: 0x0400CE07 RID: 52743
	private static readonly List<GStruct392> list_0;

	// Token: 0x0400CE08 RID: 52744
	public float TimeLeftSinceFrameStart;

	// Token: 0x0400CE09 RID: 52745
	private static RaycastHit[] raycastHit_1;

	// Token: 0x02002817 RID: 10263
	public enum EBulletState
	{
		// Token: 0x0400CE0B RID: 52747
		Flying,
		// Token: 0x0400CE0C RID: 52748
		DeviationHit,
		// Token: 0x0400CE0D RID: 52749
		RicochetHit,
		// Token: 0x0400CE0E RID: 52750
		FragmentationHit,
		// Token: 0x0400CE0F RID: 52751
		StopHit
	}
}
