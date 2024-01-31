using System;
using System.Runtime.CompilerServices;
using BezierSplineTools;
using UnityEngine;

namespace EFT.Animals
{
	// Token: 0x02002FBF RID: 12223
	[RequireComponent(typeof(Bird))]
	public class BirdCurveBrain : UpdateInEditorSystemComponent<BirdCurveBrain>
	{
		// Token: 0x0600F153 RID: 61779 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Awake()
		{
			throw null;
		}

		// Token: 0x0600F154 RID: 61780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RecalculateSpeed(Vector3 direction)
		{
			throw null;
		}

		// Token: 0x0600F155 RID: 61781 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ManualUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600F156 RID: 61782 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(BezierSpline spline)
		{
			throw null;
		}

		// Token: 0x0400F772 RID: 63346
		[SerializeField]
		protected BezierSpline _spline;

		// Token: 0x0400F773 RID: 63347
		[SerializeField]
		protected float _baseSpeed;

		// Token: 0x0400F774 RID: 63348
		[SerializeField]
		protected float _gForceMult;

		// Token: 0x0400F775 RID: 63349
		protected Vector3 _gForce;

		// Token: 0x0400F776 RID: 63350
		protected Bird _bird;

		// Token: 0x0400F777 RID: 63351
		protected float _splineLength;

		// Token: 0x0400F778 RID: 63352
		protected float _currentSpeed;

		// Token: 0x0400F779 RID: 63353
		protected float _currentDuration;

		// Token: 0x0400F77A RID: 63354
		protected float _currentSplineTime;
	}
}
