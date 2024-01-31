using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BezierSplineTools;
using UnityEngine;

// Token: 0x02000937 RID: 2359
public class MgBelt : MonoBehaviour
{
	// Token: 0x1700091A RID: 2330
	// (get) Token: 0x0600354A RID: 13642 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003549 RID: 13641 RVA: 0x00002050 File Offset: 0x00000250
	public bool On
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

	// Token: 0x0600354B RID: 13643 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(bool isPhysicsEnabled)
	{
		throw null;
	}

	// Token: 0x0600354C RID: 13644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVisible(bool isVisible)
	{
		throw null;
	}

	// Token: 0x0600354D RID: 13645 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPivotPoint(Transform t)
	{
		throw null;
	}

	// Token: 0x0600354E RID: 13646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x0600354F RID: 13647 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06003550 RID: 13648 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddWave()
	{
		throw null;
	}

	// Token: 0x06003551 RID: 13649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayAll(int displayElements)
	{
		throw null;
	}

	// Token: 0x06003552 RID: 13650 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayDelta(int displayElements)
	{
		throw null;
	}

	// Token: 0x0400362E RID: 13870
	[SerializeField]
	private BezierCurve Curve1;

	// Token: 0x0400362F RID: 13871
	[SerializeField]
	private float _sleepCooldown;

	// Token: 0x04003630 RID: 13872
	public Rigidbody[] KeyElemetns;

	// Token: 0x04003631 RID: 13873
	public Collider[] KeyElementsColliders;

	// Token: 0x04003632 RID: 13874
	public List<Transform> Links;

	// Token: 0x04003633 RID: 13875
	public float WaveAmplitude;

	// Token: 0x04003634 RID: 13876
	public AnimationCurve AmplitudeCurve;

	// Token: 0x04003635 RID: 13877
	public AnimationCurve WeightCurve;

	// Token: 0x04003636 RID: 13878
	private readonly List<MgBelt.GClass807> list_0;

	// Token: 0x04003637 RID: 13879
	private float float_0;

	// Token: 0x04003638 RID: 13880
	private bool bool_0;

	// Token: 0x04003639 RID: 13881
	private bool bool_1;

	// Token: 0x0400363A RID: 13882
	private Transform transform_0;

	// Token: 0x0400363B RID: 13883
	private int int_0;

	// Token: 0x0400363C RID: 13884
	private bool bool_2;

	// Token: 0x0400363D RID: 13885
	private bool bool_3;

	// Token: 0x02000938 RID: 2360
	public class GClass807
	{
		// Token: 0x0400363E RID: 13886
		public float Shift;

		// Token: 0x0400363F RID: 13887
		public float Decay;

		// Token: 0x04003640 RID: 13888
		public const float Cap = 3f;
	}
}
