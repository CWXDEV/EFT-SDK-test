using System;
using System.Runtime.CompilerServices;
using EFT.MovingPlatforms;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x0200278D RID: 10125
	public sealed class PlatformImpactTrigger : DamageTrigger
	{
		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x0600CAC4 RID: 51908 RVA: 0x00002050 File Offset: 0x00000250
		public override string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x0600CAC5 RID: 51909 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool IsStatic
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CAC6 RID: 51910 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ProceedDamage(GInterface94 player, BodyPartCollider bodyPart)
		{
			throw null;
		}

		// Token: 0x0600CAC7 RID: 51911 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void AddPenalty(GInterface94 player)
		{
			throw null;
		}

		// Token: 0x0600CAC8 RID: 51912 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RemovePenalty(GInterface94 player)
		{
			throw null;
		}

		// Token: 0x0600CAC9 RID: 51913 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void PlaySound()
		{
			throw null;
		}

		// Token: 0x0400CADF RID: 51935
		[SerializeField]
		private Locomotive Locomotive;

		// Token: 0x0400CAE0 RID: 51936
		[SerializeField]
		private AnimationCurve DamagePerSpeed;

		// Token: 0x0400CAE1 RID: 51937
		[CompilerGenerated]
		private readonly string string_1;
	}
}
