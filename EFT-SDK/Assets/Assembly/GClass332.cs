using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x020001E1 RID: 481
public class GClass332
{
	// Token: 0x1700023D RID: 573
	// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass332 Instance
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTraceEnable()
	{
		throw null;
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogCalculatePathFail(Vector3 from, Vector3 to)
	{
		throw null;
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogErrorEditor(string str)
	{
		throw null;
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogCalculatePath(Vector3 from, Vector3 to, NavMeshPathStatus status, int length)
	{
		throw null;
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogException(Exception e)
	{
		throw null;
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	[Conditional("SERVER")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogError(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[Conditional("SERVER")]
	[Conditional("CONSOLE")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogWarn(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[Conditional("SERVER")]
	[Conditional("CONSOLE")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogInfo(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("SERVER")]
	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogDebug(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[Conditional("CONSOLE")]
	[Conditional("SERVER")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogTrace(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x04000944 RID: 2372
	private readonly GClass332.Class329 class329_0;

	// Token: 0x04000945 RID: 2373
	[CompilerGenerated]
	private static readonly GClass332 gclass332_0;

	// Token: 0x020001E2 RID: 482
	private sealed class Class329 : LoggerClass
	{
	}
}
