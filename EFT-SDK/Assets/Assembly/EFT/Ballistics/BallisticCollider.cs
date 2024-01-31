using System;
using System.Runtime.CompilerServices;
using EFT.NetworkPackets;
using UnityEngine;

namespace EFT.Ballistics
{
	// Token: 0x02002809 RID: 10249
	public class BallisticCollider : BaseBallistic
	{
		// Token: 0x140002DD RID: 733
		// (add) Token: 0x0600CD0E RID: 52494 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600CD0F RID: 52495 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<DamageInfo> OnHitAction
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600CD10 RID: 52496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600CD11 RID: 52497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BallisticCollider Get(Vector3 pos)
		{
			throw null;
		}

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x0600CD12 RID: 52498 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CD13 RID: 52499 RVA: 0x00002050 File Offset: 0x00000250
		public MaterialType TypeOfMaterial
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600CD14 RID: 52500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual GClass1673 ApplyHit(DamageInfo damageInfo, GStruct389 shotID)
		{
			throw null;
		}

		// Token: 0x0600CD15 RID: 52501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsUnsetup()
		{
			throw null;
		}

		// Token: 0x0600CD16 RID: 52502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool Deflects(float _hitCosDirectionToNormal, GClass2988 shot, Vector3 hitPoint, Vector3 shotNormal, Vector3 shotDirection)
		{
			throw null;
		}

		// Token: 0x0600CD17 RID: 52503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool IsPenetrated(GClass2988 shot, Vector3 hitPoint)
		{
			throw null;
		}

		// Token: 0x0600CD18 RID: 52504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void TakeSettingsFrom(BaseBallistic collider)
		{
			throw null;
		}

		// Token: 0x0600CD19 RID: 52505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UnsubscribeHitAction()
		{
			throw null;
		}

		// Token: 0x0600CD1A RID: 52506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int FindPresetIndex()
		{
			throw null;
		}

		// Token: 0x0600CD1B RID: 52507 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int FindPresetIndex(BallisticCollider collider)
		{
			throw null;
		}

		// Token: 0x0400CD4A RID: 52554
		public const int OLD_PRESET_ID = -900;

		// Token: 0x0400CD4B RID: 52555
		[SerializeField]
		[HideInInspector]
		private int _presetId;

		// Token: 0x0400CD4C RID: 52556
		public int NetId;

		// Token: 0x0400CD4D RID: 52557
		public EHitType HitType;

		// Token: 0x0400CD4E RID: 52558
		[SerializeField]
		private MaterialType _typeOfMaterial;

		// Token: 0x0400CD4F RID: 52559
		[CompilerGenerated]
		private Action<DamageInfo> action_0;

		// Token: 0x0400CD50 RID: 52560
		public float PenetrationLevel;

		// Token: 0x0400CD51 RID: 52561
		[Range(0f, 1f)]
		public float PenetrationChance;

		// Token: 0x0400CD52 RID: 52562
		[Range(0f, 1f)]
		public float RicochetChance;

		// Token: 0x0400CD53 RID: 52563
		[Range(0f, 1f)]
		public float FragmentationChance;

		// Token: 0x0400CD54 RID: 52564
		[Range(0f, 1f)]
		public float TrajectoryDeviationChance;

		// Token: 0x0400CD55 RID: 52565
		[Range(0f, 1f)]
		public float TrajectoryDeviation;
	}
}
