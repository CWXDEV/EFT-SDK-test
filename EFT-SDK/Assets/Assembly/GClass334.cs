using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x020001E6 RID: 486
public class GClass334
{
	// Token: 0x17000240 RID: 576
	// (get) Token: 0x060008BE RID: 2238 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass333 Instance
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTraceEnable()
	{
		throw null;
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDebugEnable()
	{
		throw null;
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogErrorEditor(string str)
	{
		throw null;
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogException(Exception e)
	{
		throw null;
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("SERVER")]
	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogError(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[Conditional("CONSOLE")]
	[Conditional("SERVER")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogWarn(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[Conditional("CONSOLE")]
	[Conditional("SERVER")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogInfo(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("SERVER")]
	[Conditional("DEBUG")]
	[Conditional("CONSOLE")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogDebug(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("SERVER")]
	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogTrace(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x04000949 RID: 2377
	private readonly GClass334.Class331 class331_0;

	// Token: 0x0400094A RID: 2378
	[CompilerGenerated]
	private static readonly GClass333 gclass333_0;

	// Token: 0x020001E7 RID: 487
	private sealed class Class331 : LoggerClass
	{
	}
}
