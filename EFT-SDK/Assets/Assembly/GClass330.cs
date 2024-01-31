using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x020001DE RID: 478
public class GClass330
{
	// Token: 0x1700023B RID: 571
	// (get) Token: 0x0600089B RID: 2203 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass330 Instance
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTraceEnable()
	{
		throw null;
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDebugEnable()
	{
		throw null;
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogErrorEditor(string str)
	{
		throw null;
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogException(Exception e)
	{
		throw null;
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("SERVER")]
	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogError(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("SERVER")]
	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogWarn(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("SERVER")]
	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogInfo(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("SERVER")]
	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogDebug(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("SERVER")]
	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogTrace(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x0400093E RID: 2366
	private readonly GClass330.Class328 class328_0;

	// Token: 0x0400093F RID: 2367
	[CompilerGenerated]
	private static readonly GClass330 gclass330_0;

	// Token: 0x020001DF RID: 479
	private sealed class Class328 : LoggerClass
	{
	}
}
