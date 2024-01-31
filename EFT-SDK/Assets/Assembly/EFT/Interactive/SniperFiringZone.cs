using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002796 RID: 10134
	public class SniperFiringZone : BorderZone
	{
		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x0600CADE RID: 51934 RVA: 0x00002050 File Offset: 0x00000250
		public BulletClass Ammo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x0600CADF RID: 51935 RVA: 0x00002050 File Offset: 0x00000250
		public float BulletSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x0600CAE0 RID: 51936 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CAE1 RID: 51937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600CAE2 RID: 51938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_3(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600CAE3 RID: 51939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerator FireCoroutine(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600CAE4 RID: 51940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Shoot(IPlayer player, bool isInTriggerZone, bool first, bool lethal)
		{
			throw null;
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x0600CAE5 RID: 51941 RVA: 0x00002050 File Offset: 0x00000250
		public override float Delay
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CAE6 RID: 51942 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_4(BodyPartCollider x)
		{
			throw null;
		}

		// Token: 0x0600CAE7 RID: 51943 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_5(BodyPartCollider x)
		{
			throw null;
		}

		// Token: 0x0400CAF3 RID: 51955
		protected const float IMITATOR_NOTIFICATION_DELAY = 2f;

		// Token: 0x0400CAF4 RID: 51956
		[SerializeField]
		private float _shotFrequency;

		// Token: 0x0400CAF5 RID: 51957
		[SerializeField]
		private float _triggerZoneHitProbability;

		// Token: 0x0400CAF6 RID: 51958
		[SerializeField]
		private float _bufferZoneHitProbability;

		// Token: 0x0400CAF7 RID: 51959
		[SerializeField]
		private float _firstShotHitProbability;

		// Token: 0x0400CAF8 RID: 51960
		[SerializeField]
		private int _becomeLethalIfShotsCountExceed;

		// Token: 0x0400CAF9 RID: 51961
		[SerializeField]
		private string _ammoTemplate;

		// Token: 0x0400CAFA RID: 51962
		[SerializeField]
		private List<EBodyPart> _triggerZoneTarget;

		// Token: 0x0400CAFB RID: 51963
		[SerializeField]
		private List<EBodyPart> _bufferZoneTarget;

		// Token: 0x0400CAFC RID: 51964
		[SerializeField]
		private PlayersWithImmuneToSniperFireCollector _playersWithImmuneToFire;

		// Token: 0x0400CAFD RID: 51965
		private BulletClass gclass2732_0;

		// Token: 0x02002798 RID: 10136
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2288
		{
			// Token: 0x0600CAEC RID: 51948 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BodyPartCollider x)
			{
				throw null;
			}

			// Token: 0x0400CB06 RID: 51974
			public static readonly SniperFiringZone.Class2288 class2288_0;

			// Token: 0x0400CB07 RID: 51975
			public static Func<BodyPartCollider, bool> func_0;
		}
	}
}
