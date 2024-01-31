using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Vehicle;
using UnityEngine;

namespace BezierSplineTools
{
	// Token: 0x02000EEB RID: 3819
	public class BezierSpline : MonoBehaviour
	{
		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06004FBC RID: 20412 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3[] Points
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06004FBD RID: 20413 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004FBE RID: 20414 RVA: 0x00002050 File Offset: 0x00000250
		public bool Loop
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06004FBF RID: 20415 RVA: 0x00002050 File Offset: 0x00000250
		public int ControlPointCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetControlPoint(int index)
		{
			throw null;
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float ClosestTimeOnBezier(Vector3 aP, float min, float step, float max)
		{
			throw null;
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetControlPoint(int index, Vector3 point)
		{
			throw null;
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BezierControlPointMode GetControlPointMode(int index)
		{
			throw null;
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetControlPointMode(int index, BezierControlPointMode mode)
		{
			throw null;
		}

		// Token: 0x06004FC5 RID: 20421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int index)
		{
			throw null;
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06004FC6 RID: 20422 RVA: 0x00002050 File Offset: 0x00000250
		public int CurveCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetPoint(float t)
		{
			throw null;
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetPointByOneSpeed(float t)
		{
			throw null;
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetVelocity(float t)
		{
			throw null;
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<Vector3, Vector3> GetPointAndDirection(float t)
		{
			throw null;
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetDirection(float t)
		{
			throw null;
		}

		// Token: 0x06004FCC RID: 20428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddCurve()
		{
			throw null;
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddCurveNearPoint(int pointIndex)
		{
			throw null;
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddCurveToStartLine()
		{
			throw null;
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddCurve(Vector3 position, bool toEnd)
		{
			throw null;
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreateCurvesLengthCache(float sensitivity)
		{
			throw null;
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_1(int index, float sensitivity, ref float deltaTime)
		{
			throw null;
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetLengthApproximately(float sensitivity)
		{
			throw null;
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_2(int index, float t)
		{
			throw null;
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetLengthFromChache()
		{
			throw null;
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(float t, out int index, out float curveTime)
		{
			throw null;
		}

		// Token: 0x06004FD7 RID: 20439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetPointForBackwardsHomogeneousMovement(float currentDistance, float targetDistance, float precision, ref float currentTime)
		{
			throw null;
		}

		// Token: 0x06004FD8 RID: 20440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetPointForHomogeneousMovement(float currentDistance, float targetDistance, float precision, ref float currentTime)
		{
			throw null;
		}

		// Token: 0x06004FD9 RID: 20441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetPointWithCurvesLengthCache(float t)
		{
			throw null;
		}

		// Token: 0x06004FDA RID: 20442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetVelocityWithCurvesLengthCache(float t)
		{
			throw null;
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetDirectionWithCurvesLengthCache(float t)
		{
			throw null;
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeletePoint(int index)
		{
			throw null;
		}

		// Token: 0x04005C99 RID: 23705
		public BezierSpline.GDelegate33 SplineSelectedEvent;

		// Token: 0x04005C9A RID: 23706
		public BezierSpline.GDelegate34 SplineDeselectedEvent;

		// Token: 0x04005C9B RID: 23707
		[SerializeField]
		private Vector3[] points;

		// Token: 0x04005C9C RID: 23708
		[SerializeField]
		private BezierControlPointMode[] modes;

		// Token: 0x04005C9D RID: 23709
		[SerializeField]
		private bool loop;

		// Token: 0x04005C9E RID: 23710
		private List<float> _curvesLengthCache;

		// Token: 0x04005C9F RID: 23711
		private float _totalCurvesLength;

		// Token: 0x02000EEC RID: 3820
		// (Invoke) Token: 0x06004FDD RID: 20445
		public delegate void GDelegate33(PathSpline spline);

		// Token: 0x02000EED RID: 3821
		// (Invoke) Token: 0x06004FE0 RID: 20448
		public delegate void GDelegate34(PathSpline spline);
	}
}
