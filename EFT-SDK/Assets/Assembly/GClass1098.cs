using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F21 RID: 3873
public static class GClass1098
{
	// Token: 0x06005146 RID: 20806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TValue DiscreteInterpolationFunction<TValue>(in GStruct94 startTimeInfo, in GStruct94 endTimeInfo, in TValue startValue, in TValue endValue, float relativeTime)
	{
		throw null;
	}

	// Token: 0x06005147 RID: 20807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1098.ERangeType GetDiscreteBounds(in GStruct94 startTimeInfo, in GStruct94 endTimeInfo, float relativeTime)
	{
		throw null;
	}

	// Token: 0x06005148 RID: 20808 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TValue ImpulseInterpolationFunction<TValue>(in GStruct94 startTimeInfo, in GStruct94 endTimeInfo, in TValue startValue, in TValue endValue, float relativeTime, TValue valueBetweenIndexes)
	{
		throw null;
	}

	// Token: 0x06005149 RID: 20809 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1098.ERangeType GetImpulseBounds(in GStruct94 startTimeInfo, in GStruct94 endTimeInfo, float relativeTime)
	{
		throw null;
	}

	// Token: 0x02000F22 RID: 3874
	public enum ERangeType
	{
		// Token: 0x04005D58 RID: 23896
		Start,
		// Token: 0x04005D59 RID: 23897
		End,
		// Token: 0x04005D5A RID: 23898
		Between
	}
}
