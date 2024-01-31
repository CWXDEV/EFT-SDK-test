using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000F3 RID: 243
public static class GClass14
{
	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x0600053A RID: 1338 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600053B RID: 1339 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass14.EPauseReason PauseReason
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

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
	public static bool Paused
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x0600053D RID: 1341 RVA: 0x00002050 File Offset: 0x00000250
	private static GClass782.ProfilingSettings ProfilingSettings_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StartSpikeAnalyzer(float triggerTime)
	{
		throw null;
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StopSpikeAnalyzer(bool resetPauseState = true)
	{
		throw null;
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TryStartSpikeAnalyzer()
	{
		throw null;
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TryStopSpikeAnalyzer(bool resetPauseState = true)
	{
		throw null;
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TryPauseSpikeAnalyzer(GClass14.EPauseReason pauseReason)
	{
		throw null;
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TryResumeSpikeAnalyzer(GClass14.EPauseReason pauseReason)
	{
		throw null;
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitMarks()
	{
		throw null;
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MakeMark()
	{
		throw null;
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PrintMemoryUsage()
	{
		throw null;
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(string description, long newValue)
	{
		throw null;
	}

	// Token: 0x0400065A RID: 1626
	[CompilerGenerated]
	private static GClass14.EPauseReason epauseReason_0;

	// Token: 0x0400065B RID: 1627
	private static GClass15 gclass15_0;

	// Token: 0x0400065C RID: 1628
	private static Rigidbody2D rigidbody2D_0;

	// Token: 0x0400065D RID: 1629
	private static readonly Dictionary<string, long> dictionary_0;

	// Token: 0x020000F4 RID: 244
	[Flags]
	public enum EPauseReason : byte
	{
		// Token: 0x0400065F RID: 1631
		None = 0,
		// Token: 0x04000660 RID: 1632
		Inventory = 1,
		// Token: 0x04000661 RID: 1633
		Snapshot = 2,
		// Token: 0x04000662 RID: 1634
		AltTab = 4,
		// Token: 0x04000663 RID: 1635
		All = 7
	}

	// Token: 0x020000F5 RID: 245
	public enum DetectType
	{
		// Token: 0x04000665 RID: 1637
		Loop,
		// Token: 0x04000666 RID: 1638
		FixedUpdate,
		// Token: 0x04000667 RID: 1639
		SingleAVGFixedUpdate,
		// Token: 0x04000668 RID: 1640
		LoopWithoutFixedUpdate,
		// Token: 0x04000669 RID: 1641
		LoopWithSingleAVGFixedUpdateOnly
	}
}
