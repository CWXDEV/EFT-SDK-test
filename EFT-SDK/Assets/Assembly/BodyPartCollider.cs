using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Ballistics;
using EFT.NextObservedPlayer;
using UnityEngine;

// Token: 0x020005B6 RID: 1462
public class BodyPartCollider : BallisticCollider
{
	// Token: 0x06002229 RID: 8745 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Bounds smethod_0(Collider collider)
	{
		throw null;
	}

	// Token: 0x1700064C RID: 1612
	// (get) Token: 0x0600222A RID: 8746 RVA: 0x00002050 File Offset: 0x00000250
	public IPlayer Player
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700064D RID: 1613
	// (get) Token: 0x0600222B RID: 8747 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700064E RID: 1614
	// (get) Token: 0x0600222C RID: 8748 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 RealCenter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600222D RID: 8749 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Awake()
	{
		throw null;
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUpPlayer(IPlayer iPlayer)
	{
		throw null;
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass1673 ApplyHit(DamageInfo damageInfo, GStruct389 shotID)
	{
		throw null;
	}

	// Token: 0x06002230 RID: 8752 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyEnvironmentalDamage(DamageInfo damageInfo)
	{
		throw null;
	}

	// Token: 0x06002231 RID: 8753 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyInstantKill(DamageInfo damageInfo)
	{
		throw null;
	}

	// Token: 0x06002232 RID: 8754 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ProceedBarb()
	{
		throw null;
	}

	// Token: 0x06002233 RID: 8755 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProceedFlame()
	{
		throw null;
	}

	// Token: 0x06002234 RID: 8756 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProceedPlatformImpact(float damage)
	{
		throw null;
	}

	// Token: 0x06002235 RID: 8757 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProceedInstantKill()
	{
		throw null;
	}

	// Token: 0x06002236 RID: 8758 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsPenetrated(GClass2988 shot, Vector3 hitPoint)
	{
		throw null;
	}

	// Token: 0x06002237 RID: 8759 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Deflects(float _hitCosDirectionToNormal, GClass2988 shot, Vector3 hitPoint, Vector3 shotNormal, Vector3 shotDirection)
	{
		throw null;
	}

	// Token: 0x06002238 RID: 8760 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsHitToArmor(Vector3 hitPoint, Vector3 shotNormal, Vector3 shotDirection)
	{
		throw null;
	}

	// Token: 0x06002239 RID: 8761 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetRandomPointToCastLocal(Vector3 lookFromPoint)
	{
		throw null;
	}

	// Token: 0x0400214B RID: 8523
	private const float SLICE_LENGTH_TO_RESET = 0.5f;

	// Token: 0x0400214C RID: 8524
	private const float SLICE_DAMAGE_PER_METER = 2f;

	// Token: 0x0400214D RID: 8525
	private const float MIN_SLICE_DAMAGE_TO_APPLY = 1f;

	// Token: 0x0400214E RID: 8526
	private const float FLAME_DAMAGE = 7.5f;

	// Token: 0x0400214F RID: 8527
	private const float FLAME_CALL_DELAY = 0.5f;

	// Token: 0x04002150 RID: 8528
	private const float PLATFORM_IMPACT_PERIOD = 1f;

	// Token: 0x04002151 RID: 8529
	private const float INSTANT_KILL_DAMAGE = 9999f;

	// Token: 0x04002152 RID: 8530
	private float _barbDamage;

	// Token: 0x04002153 RID: 8531
	private float _flameTimer;

	// Token: 0x04002154 RID: 8532
	private float _platformImpactTimer;

	// Token: 0x04002155 RID: 8533
	private Vector3 _lastBardCutPosition;

	// Token: 0x04002156 RID: 8534
	public EBodyPart BodyPartType;

	// Token: 0x04002157 RID: 8535
	public EBodyPartColliderType BodyPartColliderType;

	// Token: 0x04002158 RID: 8536
	public Collider Collider;

	// Token: 0x04002159 RID: 8537
	public BodyPartCollider.GInterface17 playerBridge;

	// Token: 0x0400215A RID: 8538
	public string PlayerProfileID;

	// Token: 0x0400215B RID: 8539
	private Func<Vector3> ColliderCenter;

	// Token: 0x020005B7 RID: 1463
	public interface GInterface17
	{
		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600223A RID: 8762
		IPlayer iPlayer { get; }

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600223B RID: 8763
		float RemoteTime { get; }

		// Token: 0x0600223C RID: 8764
		GClass1673 ApplyShot(DamageInfo damageInfo, EBodyPart bodyPart, EBodyPartColliderType bodyPartCollider, EArmorPlateCollider armorPlateCollider, GStruct389 shotId);

		// Token: 0x0600223D RID: 8765
		void ApplyDamageInfo(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType bodyPartCollider, float absorbed);

		// Token: 0x0600223E RID: 8766
		bool SetShotStatus(BodyPartCollider bodypart, GClass2988 shot, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection);

		// Token: 0x0600223F RID: 8767
		bool CheckArmorHitByDirection(BodyPartCollider bodypart, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection);

		// Token: 0x06002240 RID: 8768
		bool IsShotDeflectedByHeavyArmor(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, int shotSeed);
	}

	// Token: 0x020005B8 RID: 1464
	protected class PlayerBridge : BodyPartCollider.GInterface17
	{
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x00002050 File Offset: 0x00000250
		public IPlayer iPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x00002050 File Offset: 0x00000250
		public float RemoteTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass1673 ApplyShot(DamageInfo damageInfo, EBodyPart bodyPart, EBodyPartColliderType bodyPartCollider, EArmorPlateCollider armorPlateCollider, GStruct389 shotId)
		{
			throw null;
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyDamageInfo(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType bodyPartCollider, float absorbed)
		{
			throw null;
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetShotStatus(BodyPartCollider bodypart, GClass2988 shot, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection)
		{
			throw null;
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckArmorHitByDirection(BodyPartCollider bodypart, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection)
		{
			throw null;
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsShotDeflectedByHeavyArmor(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, int shotSeed)
		{
			throw null;
		}

		// Token: 0x0400215C RID: 8540
		private Player player_0;
	}

	// Token: 0x020005B9 RID: 1465
	protected class ObserverBridge : BodyPartCollider.GInterface17
	{
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x00002050 File Offset: 0x00000250
		public IPlayer iPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x00002050 File Offset: 0x00000250
		public float RemoteTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyDamageInfo(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType bodyPartColliderType, float absorbed)
		{
			throw null;
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckArmorHitByDirection(BodyPartCollider bodypart, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection)
		{
			throw null;
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass1673 ApplyShot(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, GStruct389 shotId)
		{
			throw null;
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetShotStatus(BodyPartCollider bodypart, GClass2988 shot, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection)
		{
			throw null;
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsShotDeflectedByHeavyArmor(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, int shotSeed)
		{
			throw null;
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x00002050 File Offset: 0x00000250
		private IEnumerable<GClass2307> IEnumerable_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400215D RID: 8541
		private ObservedPlayerView observedPlayerView_0;

		// Token: 0x0400215E RID: 8542
		private GClass2981 gclass2981_0;
	}
}
