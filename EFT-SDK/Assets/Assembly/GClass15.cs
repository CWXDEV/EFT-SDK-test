using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine.Profiling;

// Token: 0x020000F6 RID: 246
public sealed class GClass15 : IDisposable
{
	// Token: 0x06000548 RID: 1352 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GClass15.Class92[] smethod_0(IReadOnlyList<GStruct2> configs)
	{
		throw null;
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_0(int fileNumber)
	{
		throw null;
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static long smethod_1(GClass15.Class92[] recorders)
	{
		throw null;
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Pause()
	{
		throw null;
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Resume()
	{
		throw null;
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(object state)
	{
		throw null;
	}

	// Token: 0x0400066A RID: 1642
	private readonly GClass15.Class92[] class92_0;

	// Token: 0x0400066B RID: 1643
	private readonly GClass15.Class92[] class92_1;

	// Token: 0x0400066C RID: 1644
	private readonly Recorder recorder_0;

	// Token: 0x0400066D RID: 1645
	private readonly float float_0;

	// Token: 0x0400066E RID: 1646
	private readonly string string_0;

	// Token: 0x0400066F RID: 1647
	private readonly string string_1;

	// Token: 0x04000670 RID: 1648
	private readonly WaitCallback waitCallback_0;

	// Token: 0x04000671 RID: 1649
	private int int_0;

	// Token: 0x04000672 RID: 1650
	private GClass15.Struct5 struct5_0;

	// Token: 0x04000673 RID: 1651
	private string string_2;

	// Token: 0x020000F7 RID: 247
	private sealed class Class92
	{
		// Token: 0x06000551 RID: 1361 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long method_0()
		{
			throw null;
		}

		// Token: 0x04000674 RID: 1652
		private readonly Recorder recorder_0;

		// Token: 0x04000675 RID: 1653
		private readonly bool bool_0;
	}

	// Token: 0x020000F8 RID: 248
	[StructLayout(LayoutKind.Auto)]
	public struct Struct5
	{
		// Token: 0x04000676 RID: 1654
		public string path;

		// Token: 0x04000677 RID: 1655
		public float time;

		// Token: 0x04000678 RID: 1656
		public int profilerFrame;

		// Token: 0x04000679 RID: 1657
		public int gameFrame;
	}
}
