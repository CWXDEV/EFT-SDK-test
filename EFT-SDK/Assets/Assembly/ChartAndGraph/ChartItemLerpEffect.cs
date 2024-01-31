using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x0200315C RID: 12636
	public abstract class ChartItemLerpEffect : ChartItemEffect
	{
		// Token: 0x0600F81B RID: 63515 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x0600F81C RID: 63516 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GrowAndShrink()
		{
			throw null;
		}

		// Token: 0x0600F81D RID: 63517 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckAnimationEnded(float time, AnimationCurve curve)
		{
			throw null;
		}

		// Token: 0x0600F81E RID: 63518 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(AnimationCurve curve)
		{
			throw null;
		}

		// Token: 0x0600F81F RID: 63519
		protected abstract void ApplyLerp(float value);

		// Token: 0x0600F820 RID: 63520
		protected abstract float GetStartValue();

		// Token: 0x0600F821 RID: 63521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600F822 RID: 63522 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void TriggerOut(bool deactivateOnEnd)
		{
			throw null;
		}

		// Token: 0x0600F823 RID: 63523 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void TriggerIn(bool deactivateOnEnd)
		{
			throw null;
		}

		// Token: 0x0600F824 RID: 63524 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Grow()
		{
			throw null;
		}

		// Token: 0x0600F825 RID: 63525 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Shrink()
		{
			throw null;
		}

		// Token: 0x0400FD2C RID: 64812
		private const int int_1 = 0;

		// Token: 0x0400FD2D RID: 64813
		private const int int_2 = 1;

		// Token: 0x0400FD2E RID: 64814
		private const int int_3 = 2;

		// Token: 0x0400FD2F RID: 64815
		private const int int_4 = 3;

		// Token: 0x0400FD30 RID: 64816
		public float TimeScale;

		// Token: 0x0400FD31 RID: 64817
		public AnimationCurve GrowEaseFunction;

		// Token: 0x0400FD32 RID: 64818
		public AnimationCurve ShrinkEaseFunction;

		// Token: 0x0400FD33 RID: 64819
		private float float_0;

		// Token: 0x0400FD34 RID: 64820
		private float float_1;

		// Token: 0x0400FD35 RID: 64821
		private int int_5;

		// Token: 0x0400FD36 RID: 64822
		private bool bool_0;
	}
}
