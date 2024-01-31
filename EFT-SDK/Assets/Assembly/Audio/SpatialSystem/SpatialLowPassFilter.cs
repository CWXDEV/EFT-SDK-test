using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D52 RID: 3410
	[RequireComponent(typeof(AudioLowPassFilter))]
	public sealed class SpatialLowPassFilter : AudioFilter
	{
		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600488F RID: 18575 RVA: 0x00002050 File Offset: 0x00000250
		private AudioLowPassFilter AudioLowPassFilter_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06004890 RID: 18576 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004891 RID: 18577 RVA: 0x00002050 File Offset: 0x00000250
		public float CutoffFrequency
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

		// Token: 0x06004892 RID: 18578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOcclusionCurves(AnimationCurve obstructionCurve, AnimationCurve propagationCurve)
		{
			throw null;
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ResetFilter()
		{
			throw null;
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetFilterParams(float value, bool applyImmediately = false, ESoundOcclusionType occlusionType = ESoundOcclusionType.FullOcclusion)
		{
			throw null;
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0()
		{
			throw null;
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighestFrequency(float frequency)
		{
			throw null;
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLowerFrequency(float frequency)
		{
			throw null;
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(float time)
		{
			throw null;
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x04005364 RID: 21348
		private const float float_1 = 10f;

		// Token: 0x04005365 RID: 21349
		private const float float_2 = 10f;

		// Token: 0x04005366 RID: 21350
		private const float float_3 = 22000f;

		// Token: 0x04005367 RID: 21351
		private float float_4;

		// Token: 0x04005368 RID: 21352
		private AudioLowPassFilter audioLowPassFilter_0;

		// Token: 0x04005369 RID: 21353
		private float float_5;

		// Token: 0x0400536A RID: 21354
		private AnimationCurve animationCurve_0;

		// Token: 0x0400536B RID: 21355
		private AnimationCurve animationCurve_1;

		// Token: 0x0400536C RID: 21356
		private AnimationCurve animationCurve_2;

		// Token: 0x0400536D RID: 21357
		private float float_6;

		// Token: 0x0400536E RID: 21358
		[CompilerGenerated]
		private float float_7;
	}
}
