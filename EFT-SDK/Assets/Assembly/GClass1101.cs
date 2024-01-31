using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F25 RID: 3877
public sealed class GClass1101<T> : GInterface68<T>
{
	// Token: 0x0600514D RID: 20813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Interpolate(in GStruct94 startTimeInfo, in GStruct94 endTimeInfo, in T startValue, in T endValue, float relativeTime)
	{
		throw null;
	}

	// Token: 0x04005D5C RID: 23900
	private readonly GClass1101<T>.GDelegate35 gdelegate35_0;

	// Token: 0x02000F26 RID: 3878
	// (Invoke) Token: 0x0600514E RID: 20814
	public delegate T GDelegate35(in T startValue, in T endValue, float relativeTime);
}
