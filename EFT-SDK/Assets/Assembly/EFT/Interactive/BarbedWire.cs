using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x0200274F RID: 10063
	public class BarbedWire : DamageTrigger
	{
		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x0600C955 RID: 51541 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool IsStatic
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x0600C956 RID: 51542 RVA: 0x00002050 File Offset: 0x00000250
		public override string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C957 RID: 51543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ProceedDamage(GInterface94 player, BodyPartCollider bodyPart)
		{
			throw null;
		}

		// Token: 0x0600C958 RID: 51544 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void AddPenalty(GInterface94 player)
		{
			throw null;
		}

		// Token: 0x0600C959 RID: 51545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RemovePenalty(GInterface94 player)
		{
			throw null;
		}

		// Token: 0x0600C95A RID: 51546 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void PlaySound()
		{
			throw null;
		}

		// Token: 0x0400C977 RID: 51575
		private const float float_0 = 0.15f;

		// Token: 0x0400C978 RID: 51576
		private const float float_1 = 0.5f;

		// Token: 0x0400C979 RID: 51577
		private float float_2;

		// Token: 0x0400C97A RID: 51578
		[SerializeField]
		private SoundBank _soundBank;

		// Token: 0x0400C97B RID: 51579
		[CompilerGenerated]
		private readonly string string_1;
	}
}
