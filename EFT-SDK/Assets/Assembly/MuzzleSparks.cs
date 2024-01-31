using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AD7 RID: 2775
public class MuzzleSparks : MonoBehaviour
{
	// Token: 0x06003C8C RID: 15500 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003C8D RID: 15501 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003C8E RID: 15502 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003C8F RID: 15503 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Emit(GInterface41 emitter)
	{
		throw null;
	}

	// Token: 0x06003C90 RID: 15504 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static float smethod_0(float val)
	{
		throw null;
	}

	// Token: 0x0400426A RID: 17002
	public float StartPos;

	// Token: 0x0400426B RID: 17003
	public float EmitterRadius;

	// Token: 0x0400426C RID: 17004
	public float ConusSize;

	// Token: 0x0400426D RID: 17005
	public int CountMin;

	// Token: 0x0400426E RID: 17006
	public int CountRange;

	// Token: 0x0400426F RID: 17007
	public MuzzleSparks.CurveValue LifetimeCurve;

	// Token: 0x04004270 RID: 17008
	public MuzzleSparks.CurveValue SpeedCurve;

	// Token: 0x04004271 RID: 17009
	public MuzzleSparks.CurveValue GravityCurve;

	// Token: 0x04004272 RID: 17010
	public MuzzleSparks.CurveValue DragCurve;

	// Token: 0x04004273 RID: 17011
	public MuzzleSparks.ByteCurveValue EmissionCurve;

	// Token: 0x04004274 RID: 17012
	public MuzzleSparks.ByteCurveValue SizeCurve;

	// Token: 0x04004275 RID: 17013
	public MuzzleSparks.ByteCurveValue TurbulenceAmplitudeCurve;

	// Token: 0x04004276 RID: 17014
	public MuzzleSparks.ByteCurveValue TurbulenceFrequencyCurve;

	// Token: 0x04004277 RID: 17015
	public float EmissionTimeShift;

	// Token: 0x04004278 RID: 17016
	private Transform transform_0;

	// Token: 0x04004279 RID: 17017
	private const int int_0 = 128;

	// Token: 0x0400427A RID: 17018
	private const float float_0 = 0.0078125f;

	// Token: 0x02000AD8 RID: 2776
	[Serializable]
	public class CurveValue
	{
		// Token: 0x06003C91 RID: 15505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecalcVals()
		{
			throw null;
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecalcVals(Func<float, float> func)
		{
			throw null;
		}

		// Token: 0x0400427B RID: 17019
		public AnimationCurve Curve;

		// Token: 0x0400427C RID: 17020
		public float Value;

		// Token: 0x0400427D RID: 17021
		public float[] Values;
	}

	// Token: 0x02000AD9 RID: 2777
	[Serializable]
	public class ByteCurveValue
	{
		// Token: 0x06003C93 RID: 15507 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecalcVals()
		{
			throw null;
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecalcVals(Func<float, float> func)
		{
			throw null;
		}

		// Token: 0x0400427E RID: 17022
		public AnimationCurve Curve;

		// Token: 0x0400427F RID: 17023
		public byte Value;

		// Token: 0x04004280 RID: 17024
		public byte[] Values;
	}
}
