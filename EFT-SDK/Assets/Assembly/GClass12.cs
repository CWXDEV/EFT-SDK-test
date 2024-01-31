using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Profiling;

// Token: 0x020000F0 RID: 240
public sealed class GClass12 : IDisposable
{
	// Token: 0x14000006 RID: 6
	// (add) Token: 0x06000524 RID: 1316 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnUpdate
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
	public event Action BeforeNewFileCreated
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
	public int CurrentFrameCounter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass12 Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600052C RID: 1324 RVA: 0x00002050 File Offset: 0x00000250
	public bool Started
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

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600052E RID: 1326 RVA: 0x00002050 File Offset: 0x00000250
	public bool Paused
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

	// Token: 0x0600052F RID: 1327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartProfiling(Func<int, string> fileNameGetter, int framesPerFile, int maxFilesCount, bool paused, params ProfilerArea[] profilerAreas)
	{
		throw null;
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopProfiling()
	{
		throw null;
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EnableAreas(params ProfilerArea[] profilerAreas)
	{
		throw null;
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KeepCurrentFile()
	{
		throw null;
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(object state)
	{
		throw null;
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PruneAllFiles()
	{
		throw null;
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_1()
	{
		throw null;
	}

	// Token: 0x04000649 RID: 1609
	private static GClass12 gclass12_0;

	// Token: 0x0400064A RID: 1610
	private readonly Queue<string> queue_0;

	// Token: 0x0400064B RID: 1611
	private readonly WaitCallback waitCallback_0;

	// Token: 0x0400064C RID: 1612
	private readonly CustomSampler customSampler_0;

	// Token: 0x0400064D RID: 1613
	private Func<int, string> func_0;

	// Token: 0x0400064E RID: 1614
	private int int_0;

	// Token: 0x0400064F RID: 1615
	private int int_1;

	// Token: 0x04000650 RID: 1616
	private int int_2;

	// Token: 0x04000651 RID: 1617
	private int int_3;

	// Token: 0x04000652 RID: 1618
	private bool bool_0;

	// Token: 0x04000653 RID: 1619
	private bool bool_1;

	// Token: 0x04000654 RID: 1620
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x04000655 RID: 1621
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x04000656 RID: 1622
	public const string UpdateSamplerName = "EmbeddedProfiler.Update";

	// Token: 0x04000657 RID: 1623
	[CompilerGenerated]
	private bool bool_2;
}
