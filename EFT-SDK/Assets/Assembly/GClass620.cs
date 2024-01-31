using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020011A1 RID: 4513
public sealed class GClass620 : LoggerClass
{
	// Token: 0x06006056 RID: 24662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Setup(LoggerMode mode, bool logApplicationMessages = true)
	{
		throw null;
	}

	// Token: 0x06006057 RID: 24663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Release()
	{
		throw null;
	}

	// Token: 0x06006058 RID: 24664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LogFormat(LogType logType, string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x040069FB RID: 27131
	private const string string_0 = "CI";

	// Token: 0x040069FC RID: 27132
	private readonly string[] string_1;

	// Token: 0x040069FD RID: 27133
	private static Dictionary<LogType, StackTraceLogType> dictionary_0;

	// Token: 0x040069FE RID: 27134
	private static Dictionary<LogType, StackTraceLogType> dictionary_1;
}
