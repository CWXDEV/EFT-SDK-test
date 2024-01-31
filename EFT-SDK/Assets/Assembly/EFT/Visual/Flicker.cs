using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x02001A17 RID: 6679
	[ExecuteInEditMode]
	public class Flicker : MonoBehaviour, GInterface27
	{
		// Token: 0x06008DBB RID: 36283 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnEnable()
		{
			throw null;
		}

		// Token: 0x06008DBD RID: 36285 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDisable()
		{
			throw null;
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06008DBF RID: 36287 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCurve(AnimationCurve curve)
		{
			throw null;
		}

		// Token: 0x06008DC0 RID: 36288 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ManualUpdate()
		{
			throw null;
		}

		// Token: 0x04009416 RID: 37910
		[SerializeField]
		protected float Frequency;

		// Token: 0x04009417 RID: 37911
		[SerializeField]
		protected float Intensity;

		// Token: 0x04009418 RID: 37912
		[SerializeField]
		protected float IntensityShift;

		// Token: 0x04009419 RID: 37913
		[SerializeField]
		protected float TimeShift;

		// Token: 0x0400941A RID: 37914
		[SerializeField]
		protected AnimationCurve Curve;

		// Token: 0x0400941B RID: 37915
		[SerializeField]
		protected Flicker.ECurveType Generate;

		// Token: 0x0400941C RID: 37916
		[SerializeField]
		protected bool RandomTimeShift;

		// Token: 0x0400941D RID: 37917
		[SerializeField]
		protected bool FullRandomCurve;

		// Token: 0x0400941E RID: 37918
		public float CullingCoef;

		// Token: 0x0400941F RID: 37919
		protected float RandomSeed;

		// Token: 0x02001A18 RID: 6680
		protected enum ECurveType
		{
			// Token: 0x04009421 RID: 37921
			SelectTypeForGenerate,
			// Token: 0x04009422 RID: 37922
			Random,
			// Token: 0x04009423 RID: 37923
			Sin,
			// Token: 0x04009424 RID: 37924
			Triangle,
			// Token: 0x04009425 RID: 37925
			Saw,
			// Token: 0x04009426 RID: 37926
			Square
		}
	}
}
