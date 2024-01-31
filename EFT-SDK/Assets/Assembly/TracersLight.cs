using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B36 RID: 2870
public class TracersLight : MonoBehaviour
{
	// Token: 0x06003E1B RID: 15899 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003E1C RID: 15900 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003E1D RID: 15901 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003E1E RID: 15902 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GInterface355 ballisticsCalculator)
	{
		throw null;
	}

	// Token: 0x06003E1F RID: 15903 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GClass2988 shot)
	{
		throw null;
	}

	// Token: 0x06003E20 RID: 15904 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(GClass2988 shot, Vector3 p0, Vector3 p1)
	{
		throw null;
	}

	// Token: 0x06003E21 RID: 15905 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GClass2988 shot, Vector3 p0, Vector3 p1)
	{
		throw null;
	}

	// Token: 0x06003E22 RID: 15906 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06003E23 RID: 15907 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x0400452F RID: 17711
	[ColorUsage(true, true, 0f, 8f, 0.125f, 3f)]
	public Color Color;

	// Token: 0x04004530 RID: 17712
	[SerializeField]
	private float _maxFlyingTime;

	// Token: 0x04004531 RID: 17713
	[SerializeField]
	private AnimationCurve _sizeTimeCurve;

	// Token: 0x04004532 RID: 17714
	[SerializeField]
	private AnimationCurve _colorAlphaCurve;

	// Token: 0x04004533 RID: 17715
	[SerializeField]
	private float _grenadeFlyingMaxTime;

	// Token: 0x04004534 RID: 17716
	[SerializeField]
	private float _grenadeSizeCoef;

	// Token: 0x04004535 RID: 17717
	[SerializeField]
	private MeshFilter _tracersMF;

	// Token: 0x04004536 RID: 17718
	[SerializeField]
	private float _speedModifier;

	// Token: 0x04004537 RID: 17719
	[SerializeField]
	private float _grenadeSpeedModifier;

	// Token: 0x04004538 RID: 17720
	private List<GInterface355> list_0;

	// Token: 0x04004539 RID: 17721
	private List<TracersLight.Class584> list_1;

	// Token: 0x0400453A RID: 17722
	private bool bool_0;

	// Token: 0x0400453B RID: 17723
	private bool bool_1;

	// Token: 0x0400453C RID: 17724
	private static readonly float float_0;

	// Token: 0x02000B37 RID: 2871
	private class Class584
	{
		// Token: 0x0400453D RID: 17725
		public readonly Color BackCurrentTracerColor;

		// Token: 0x0400453E RID: 17726
		public readonly Color CurrentTracerColor;

		// Token: 0x0400453F RID: 17727
		public Vector3 Direction;

		// Token: 0x04004540 RID: 17728
		public readonly Vector3 PositionShift;

		// Token: 0x04004541 RID: 17729
		public readonly float SizePercent;

		// Token: 0x04004542 RID: 17730
		public readonly float Speed;
	}
}
