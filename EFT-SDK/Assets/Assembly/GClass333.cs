using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x020001E4 RID: 484
public class GClass333
{
	// Token: 0x1700023F RID: 575
	// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass333 Instance
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTraceEnable()
	{
		throw null;
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDebugEnable()
	{
		throw null;
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogErrorEditor(string str)
	{
		throw null;
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogException(Exception e)
	{
		throw null;
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[Conditional("CONSOLE")]
	[Conditional("SERVER")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogError(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[Conditional("CONSOLE")]
	[Conditional("SERVER")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogWarn(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("SERVER")]
	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogInfo(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	[Conditional("SERVER")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogDebug(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[Conditional("CONSOLE")]
	[Conditional("SERVER")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogTrace(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x04000947 RID: 2375
	private readonly GClass333.Class330 class330_0;

	// Token: 0x04000948 RID: 2376
	[CompilerGenerated]
	private static readonly GClass333 gclass333_0;

	// Token: 0x020001E5 RID: 485
	private sealed class Class330 : LoggerClass
	{
	}
}
