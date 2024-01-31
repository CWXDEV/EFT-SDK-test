using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AF0 RID: 2800
public class SimpleSparksAdapter : Emitter
{
	// Token: 0x06003CFC RID: 15612 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003CFD RID: 15613 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003CFE RID: 15614 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static float smethod_0(float val)
	{
		throw null;
	}

	// Token: 0x06003CFF RID: 15615 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Emit(Vector3 pos, Vector3 vel)
	{
		throw null;
	}

	// Token: 0x04004305 RID: 17157
	public SimpleSparksRenderer SimpleSparksObject;

	// Token: 0x04004306 RID: 17158
	public SimpleSparksAdapter.CurveValue LifetimeCurve;

	// Token: 0x04004307 RID: 17159
	public SimpleSparksAdapter.CurveValue SpeedCurve;

	// Token: 0x04004308 RID: 17160
	public SimpleSparksAdapter.CurveValue GravityCurve;

	// Token: 0x04004309 RID: 17161
	public SimpleSparksAdapter.CurveValue DragCurve;

	// Token: 0x0400430A RID: 17162
	public SimpleSparksAdapter.ByteCurveValue EmissionCurve;

	// Token: 0x0400430B RID: 17163
	public SimpleSparksAdapter.ByteCurveValue SizeCurve;

	// Token: 0x0400430C RID: 17164
	public SimpleSparksAdapter.ByteCurveValue TurbulenceAmplitudeCurve;

	// Token: 0x0400430D RID: 17165
	public SimpleSparksAdapter.ByteCurveValue TurbulenceFrequencyCurve;

	// Token: 0x0400430E RID: 17166
	public float EmissionTimeShift;

	// Token: 0x0400430F RID: 17167
	private const int int_0 = 128;

	// Token: 0x04004310 RID: 17168
	private const float float_0 = 0.0078125f;

	// Token: 0x02000AF1 RID: 2801
	[Serializable]
	public class CurveValue
	{
		// Token: 0x06003D00 RID: 15616 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecalcVals()
		{
			throw null;
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecalcVals(Func<float, float> func)
		{
			throw null;
		}

		// Token: 0x04004311 RID: 17169
		public AnimationCurve Curve;

		// Token: 0x04004312 RID: 17170
		public float Value;

		// Token: 0x04004313 RID: 17171
		public float[] Values;
	}

	// Token: 0x02000AF2 RID: 2802
	[Serializable]
	public class ByteCurveValue
	{
		// Token: 0x06003D02 RID: 15618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecalcVals()
		{
			throw null;
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecalcVals(Func<float, float> func)
		{
			throw null;
		}

		// Token: 0x04004314 RID: 17172
		public AnimationCurve Curve;

		// Token: 0x04004315 RID: 17173
		public byte Value;

		// Token: 0x04004316 RID: 17174
		public byte[] Values;
	}
}
