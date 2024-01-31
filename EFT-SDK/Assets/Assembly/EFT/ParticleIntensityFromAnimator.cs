using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x020018A7 RID: 6311
	public class ParticleIntensityFromAnimator : MonoBehaviour
	{
		// Token: 0x060087A5 RID: 34725 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060087A6 RID: 34726 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x04008E04 RID: 36356
		[SerializeField]
		private Animator _animator;

		// Token: 0x04008E05 RID: 36357
		[SerializeField]
		private ParticleSystem _targetParticle;

		// Token: 0x04008E06 RID: 36358
		[SerializeField]
		private string _animatorParam;

		// Token: 0x04008E07 RID: 36359
		[SerializeField]
		private Vector2 _minMaxParamValues;

		// Token: 0x04008E08 RID: 36360
		[SerializeField]
		private Vector2 _minMaxEmissionValue;

		// Token: 0x04008E09 RID: 36361
		private float float_0;

		// Token: 0x04008E0A RID: 36362
		private Vector2 vector2_0;

		// Token: 0x04008E0B RID: 36363
		private Vector2 vector2_1;

		// Token: 0x04008E0C RID: 36364
		private float float_1;

		// Token: 0x04008E0D RID: 36365
		private float float_2;
	}
}
