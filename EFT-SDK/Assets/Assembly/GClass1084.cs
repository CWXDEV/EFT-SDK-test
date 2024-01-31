using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F06 RID: 3846
public static class GClass1084
{
	// Token: 0x06005074 RID: 20596 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double Timescale(double drift, double catchupSpeed, double slowdownSpeed, double catchupNegativeThreshold, double catchupPositiveThreshold)
	{
		throw null;
	}

	// Token: 0x06005075 RID: 20597 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double DynamicAdjustment(double sendInterval, double jitterStandardDeviation, double dynamicAdjustmentTolerance)
	{
		throw null;
	}

	// Token: 0x06005076 RID: 20598 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool InsertIfNotExists<T>(SortedList<double, T> buffer, T snapshot) where T : GInterface67
	{
		throw null;
	}

	// Token: 0x06005077 RID: 20599 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InsertAndAdjust<T>(SortedList<double, T> buffer, T snapshot, ref double localTimeline, ref double localTimescale, float sendInterval, double bufferTime, double catchupSpeed, double slowdownSpeed, ref GStruct89 driftEma, float catchupNegativeThreshold, float catchupPositiveThreshold, ref GStruct89 deliveryTimeEma) where T : GInterface67
	{
		throw null;
	}

	// Token: 0x06005078 RID: 20600 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Sample<T>(SortedList<double, T> buffer, double localTimeline, out int from, out int to, out double t) where T : GInterface67
	{
		throw null;
	}

	// Token: 0x06005079 RID: 20601 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StepTime(double deltaTime, ref double localTimeline, double localTimescale)
	{
		throw null;
	}

	// Token: 0x0600507A RID: 20602 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StepInterpolation<T>(SortedList<double, T> buffer, double localTimeline, out T fromSnapshot, out T toSnapshot, out double t) where T : GInterface67
	{
		throw null;
	}

	// Token: 0x0600507B RID: 20603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Step<T>(SortedList<double, T> buffer, double deltaTime, ref double localTimeline, double localTimescale, out T fromSnapshot, out T toSnapshot, out double t) where T : GInterface67
	{
		throw null;
	}
}
