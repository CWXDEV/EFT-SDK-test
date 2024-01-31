using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Systems.Effects
{
	// Token: 0x02000C34 RID: 3124
	public sealed class FlareShotEffectAnimator : MonoBehaviour
	{
		// Token: 0x17000AE9 RID: 2793
		// (set) Token: 0x06004413 RID: 17427 RVA: 0x00002050 File Offset: 0x00000250
		public float LightIntensity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06004414 RID: 17428 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004415 RID: 17429 RVA: 0x00002050 File Offset: 0x00000250
		public float Frequency
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x04004D95 RID: 19861
		private static readonly int int_0;

		// Token: 0x04004D96 RID: 19862
		[SerializeField]
		private AnimationCurve _fadeCurve;

		// Token: 0x04004D97 RID: 19863
		[SerializeField]
		private ParticleSystem _flareParticleSystem;

		// Token: 0x04004D98 RID: 19864
		[SerializeField]
		private ParticleSystem _smokeParticleSystem;

		// Token: 0x04004D99 RID: 19865
		[SerializeField]
		private CullingLightObject _cullingLightObject;

		// Token: 0x04004D9A RID: 19866
		[SerializeField]
		private float _lightIntensity;

		// Token: 0x04004D9B RID: 19867
		private float float_0;

		// Token: 0x04004D9C RID: 19868
		private Material material_0;

		// Token: 0x04004D9D RID: 19869
		[CompilerGenerated]
		private float float_1;
	}
}
