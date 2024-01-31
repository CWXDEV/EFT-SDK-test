using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D51 RID: 3409
	[RequireComponent(typeof(AudioHighPassFilter))]
	public class SpatialHighPassFilter : AudioFilter
	{
		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06004882 RID: 18562 RVA: 0x00002050 File Offset: 0x00000250
		private AudioHighPassFilter AudioHighPassFilter_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06004883 RID: 18563 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004884 RID: 18564 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x06004885 RID: 18565 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ResetFilter()
		{
			throw null;
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFilterCurve(AnimationCurve filterCurve)
		{
			throw null;
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMaxCutoffFrequency(float frequency)
		{
			throw null;
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetFilterParams(float value, bool applyImmediately = false, ESoundOcclusionType occlusionType = ESoundOcclusionType.FullOcclusion)
		{
			throw null;
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0()
		{
			throw null;
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(float time)
		{
			throw null;
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0400535C RID: 21340
		private const float float_1 = 10f;

		// Token: 0x0400535D RID: 21341
		private const float float_2 = 10f;

		// Token: 0x0400535E RID: 21342
		private const float float_3 = 1f;

		// Token: 0x0400535F RID: 21343
		private AudioHighPassFilter audioHighPassFilter_0;

		// Token: 0x04005360 RID: 21344
		private float float_4;

		// Token: 0x04005361 RID: 21345
		private AnimationCurve animationCurve_0;

		// Token: 0x04005362 RID: 21346
		private float float_5;

		// Token: 0x04005363 RID: 21347
		[CompilerGenerated]
		private float float_6;
	}
}
