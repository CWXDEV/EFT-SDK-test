using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x0200315B RID: 12635
	internal class ChartItemGrowEffect : ChartItemEffect
	{
		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x0600F812 RID: 63506 RVA: 0x00002050 File Offset: 0x00000250
		internal override Quaternion Quaternion_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F813 RID: 63507 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GrowAndShrink()
		{
			throw null;
		}

		// Token: 0x0600F814 RID: 63508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckAnimationEnded(float time, AnimationCurve curve)
		{
			throw null;
		}

		// Token: 0x0600F815 RID: 63509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(AnimationCurve curve)
		{
			throw null;
		}

		// Token: 0x0600F816 RID: 63510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600F817 RID: 63511 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void TriggerOut(bool deactivateOnEnd)
		{
			throw null;
		}

		// Token: 0x0600F818 RID: 63512 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void TriggerIn(bool deactivateOnEnd)
		{
			throw null;
		}

		// Token: 0x0600F819 RID: 63513 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Grow()
		{
			throw null;
		}

		// Token: 0x0600F81A RID: 63514 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Shrink()
		{
			throw null;
		}

		// Token: 0x0400FD1E RID: 64798
		private const int int_1 = 0;

		// Token: 0x0400FD1F RID: 64799
		private const int int_2 = 1;

		// Token: 0x0400FD20 RID: 64800
		private const int int_3 = 2;

		// Token: 0x0400FD21 RID: 64801
		private const int int_4 = 3;

		// Token: 0x0400FD22 RID: 64802
		public float GrowMultiplier;

		// Token: 0x0400FD23 RID: 64803
		public bool VerticalOnly;

		// Token: 0x0400FD24 RID: 64804
		public float TimeScale;

		// Token: 0x0400FD25 RID: 64805
		public AnimationCurve GrowEaseFunction;

		// Token: 0x0400FD26 RID: 64806
		public AnimationCurve ShrinkEaseFunction;

		// Token: 0x0400FD27 RID: 64807
		private float float_0;

		// Token: 0x0400FD28 RID: 64808
		private float float_1;

		// Token: 0x0400FD29 RID: 64809
		private float float_2;

		// Token: 0x0400FD2A RID: 64810
		private int int_5;

		// Token: 0x0400FD2B RID: 64811
		private bool bool_0;
	}
}
