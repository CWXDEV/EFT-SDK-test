using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200057B RID: 1403
public class GClass557
{
	// Token: 0x17000630 RID: 1584
	// (get) Token: 0x06002187 RID: 8583 RVA: 0x00002050 File Offset: 0x00000250
	public static TimeSpan EmptyResponseRepeatDelay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000631 RID: 1585
	// (get) Token: 0x06002188 RID: 8584 RVA: 0x00002050 File Offset: 0x00000250
	public static int EmptyResponseLimit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000632 RID: 1586
	// (get) Token: 0x06002189 RID: 8585 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600218A RID: 8586 RVA: 0x00002050 File Offset: 0x00000250
	public static string PhpSessionId
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000633 RID: 1587
	// (get) Token: 0x0600218B RID: 8587 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600218C RID: 8588 RVA: 0x00002050 File Offset: 0x00000250
	public static string AppVersion
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000634 RID: 1588
	// (get) Token: 0x0600218D RID: 8589 RVA: 0x00002050 File Offset: 0x00000250
	internal static Interface1 Interface1_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetSenderType(GClass557.EConnectionType type)
	{
		throw null;
	}

	// Token: 0x04002045 RID: 8261
	public const string SESSION_COOKIE_KEY = "PHPSESSID=";

	// Token: 0x04002046 RID: 8262
	public const string FAILED_TO_RECEIVE_DATA = "Failed to receive data";

	// Token: 0x04002047 RID: 8263
	public static readonly GClass557.GClass614 Logger;

	// Token: 0x04002048 RID: 8264
	public static long NextRequestIndex;

	// Token: 0x04002049 RID: 8265
	private static readonly Class274 class274_0;

	// Token: 0x0400204A RID: 8266
	private static readonly Class273 class273_0;

	// Token: 0x0400204B RID: 8267
	private static GClass557.EConnectionType econnectionType_0;

	// Token: 0x0400204C RID: 8268
	private static readonly Dictionary<GClass557.EConnectionType, Interface1> dictionary_0;

	// Token: 0x0400204D RID: 8269
	[CompilerGenerated]
	private static string string_0;

	// Token: 0x0400204E RID: 8270
	[CompilerGenerated]
	private static string string_1;

	// Token: 0x0200057C RID: 1404
	public sealed class GClass614 : LoggerClass
	{
	}

	// Token: 0x0200057D RID: 1405
	public enum EConnectionType
	{
		// Token: 0x04002050 RID: 8272
		Default,
		// Token: 0x04002051 RID: 8273
		HttpConnection
	}
}
