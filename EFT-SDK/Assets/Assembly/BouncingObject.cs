using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020006A2 RID: 1698
public class BouncingObject : MonoBehaviour
{
	// Token: 0x170006F1 RID: 1777
	// (get) Token: 0x06002681 RID: 9857 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002682 RID: 9858 RVA: 0x00002050 File Offset: 0x00000250
	public bool Finished
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

	// Token: 0x170006F2 RID: 1778
	// (get) Token: 0x06002683 RID: 9859 RVA: 0x00002050 File Offset: 0x00000250
	public float VelocitySqrMagnitude
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002684 RID: 9860 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Vector3 beginPoint, Vector3 velocity, float radius, float playMult, LayerMask castMask, int maxCastCount, float deltaTimeStep, float randomReboundSpread, float bounceSpeedMult, bool showDebug)
	{
		throw null;
	}

	// Token: 0x06002685 RID: 9861 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private BouncingObject.Struct64 method_0(int index, Vector3 beginPoint, Vector3 velocity)
	{
		throw null;
	}

	// Token: 0x06002686 RID: 9862 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("UNITY_EDITOR")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(BouncingObject.Struct64 jump, float time)
	{
		throw null;
	}

	// Token: 0x06002687 RID: 9863 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(float time)
	{
		throw null;
	}

	// Token: 0x06002688 RID: 9864 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update()
	{
		throw null;
	}

	// Token: 0x06002689 RID: 9865 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(Vector3 point, Vector3 direction, float maxDistance, out RaycastHit hit)
	{
		throw null;
	}

	// Token: 0x0600268A RID: 9866 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDone()
	{
		throw null;
	}

	// Token: 0x0600268B RID: 9867 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnBounce(Collider collider)
	{
		throw null;
	}

	// Token: 0x0600268C RID: 9868 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x04002599 RID: 9625
	private float float_0;

	// Token: 0x0400259A RID: 9626
	private LayerMask layerMask_0;

	// Token: 0x0400259B RID: 9627
	private RaycastHit[] raycastHit_0;

	// Token: 0x0400259C RID: 9628
	private int int_0;

	// Token: 0x0400259D RID: 9629
	private BouncingObject.Struct64 struct64_0;

	// Token: 0x0400259E RID: 9630
	private float float_1;

	// Token: 0x0400259F RID: 9631
	private float float_2;

	// Token: 0x040025A0 RID: 9632
	private float float_3;

	// Token: 0x040025A1 RID: 9633
	private float float_4;

	// Token: 0x040025A2 RID: 9634
	private int int_1;

	// Token: 0x040025A3 RID: 9635
	private const int int_2 = 3;

	// Token: 0x040025A4 RID: 9636
	private bool bool_0;

	// Token: 0x040025A5 RID: 9637
	private Vector3 vector3_0;

	// Token: 0x040025A6 RID: 9638
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x040025A7 RID: 9639
	private Vector3 vector3_1;

	// Token: 0x020006A3 RID: 1699
	[StructLayout(LayoutKind.Auto)]
	public struct Struct64
	{
		// Token: 0x0600268D RID: 9869 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(int index, Vector3 beginPoint, Vector3 startVelocity, Vector3 acceleration)
		{
			throw null;
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUseBezier(float bezierStartTime, Vector3 startPoint, Vector3 endPoint, float distance)
		{
			throw null;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUseBezier(float bezierStartTime, Vector3 startPoint, Vector3 bezierRaisePoint, Vector3 endPoint)
		{
			throw null;
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 CalculateVelocity(float time)
		{
			throw null;
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 CalculatePoint(float time, Vector3 currentVelocity)
		{
			throw null;
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Update(ref float deltaTime)
		{
			throw null;
		}

		// Token: 0x040025A8 RID: 9640
		public int index;

		// Token: 0x040025A9 RID: 9641
		public Vector3 beginPoint;

		// Token: 0x040025AA RID: 9642
		public Vector3 startVelocity;

		// Token: 0x040025AB RID: 9643
		public Vector3 acceleration;

		// Token: 0x040025AC RID: 9644
		public float endTime;

		// Token: 0x040025AD RID: 9645
		public float currentTime;

		// Token: 0x040025AE RID: 9646
		public Vector3 currentPoint;

		// Token: 0x040025AF RID: 9647
		public Vector3 currentVelocity;

		// Token: 0x040025B0 RID: 9648
		public Vector3 nextJumpDirection;

		// Token: 0x040025B1 RID: 9649
		public bool useBezier;

		// Token: 0x040025B2 RID: 9650
		public Vector3 bezierRaisePoint;

		// Token: 0x040025B3 RID: 9651
		public float bezierStartTime;

		// Token: 0x040025B4 RID: 9652
		public Vector3 bezierStartPoint;

		// Token: 0x040025B5 RID: 9653
		public Vector3 bezierEndPoint;

		// Token: 0x040025B6 RID: 9654
		public Collider hitCollider;

		// Token: 0x040025B7 RID: 9655
		private const float float_0 = 0.3f;
	}
}
