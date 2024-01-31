using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000AE RID: 174
[Serializable]
public class TOD_CycleParameters
{
	// Token: 0x17000134 RID: 308
	// (get) Token: 0x0600036A RID: 874 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600036B RID: 875 RVA: 0x00002050 File Offset: 0x00000250
	public DateTime DateTime
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

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
	public long Ticks
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

	// Token: 0x040003BB RID: 955
	[Tooltip("Current hour of the day.")]
	[Range(0f, 24f)]
	public float Hour;

	// Token: 0x040003BC RID: 956
	[Range(0f, 31f)]
	[Tooltip("Current day of the month.")]
	public int Day;

	// Token: 0x040003BD RID: 957
	[Range(0f, 11f)]
	[Tooltip("Current month of the year.")]
	public int Month;

	// Token: 0x040003BE RID: 958
	public int Year;
}
