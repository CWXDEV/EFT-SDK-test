using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000566 RID: 1382
[StructLayout(LayoutKind.Auto)]
public struct LegacyParamsStruct
{
	// Token: 0x17000620 RID: 1568
	// (get) Token: 0x0600213B RID: 8507 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600213C RID: 8508 RVA: 0x00002050 File Offset: 0x00000250
	public object Params
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

	// Token: 0x17000621 RID: 1569
	// (get) Token: 0x0600213D RID: 8509 RVA: 0x00002050 File Offset: 0x00000250
	public static int DefaultTimeoutSeconds
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000622 RID: 1570
	// (get) Token: 0x0600213E RID: 8510 RVA: 0x00002050 File Offset: 0x00000250
	public static byte? NoRetries
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000623 RID: 1571
	// (get) Token: 0x0600213F RID: 8511 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002140 RID: 8512 RVA: 0x00002050 File Offset: 0x00000250
	public static int FirstCycleDelaySeconds
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

	// Token: 0x17000624 RID: 1572
	// (get) Token: 0x06002141 RID: 8513 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002142 RID: 8514 RVA: 0x00002050 File Offset: 0x00000250
	public static int SecondCycleDelaySeconds
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

	// Token: 0x17000625 RID: 1573
	// (get) Token: 0x06002143 RID: 8515 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002144 RID: 8516 RVA: 0x00002050 File Offset: 0x00000250
	public static int NextCycleDelaySeconds
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

	// Token: 0x17000626 RID: 1574
	// (get) Token: 0x06002145 RID: 8517 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002146 RID: 8518 RVA: 0x00002050 File Offset: 0x00000250
	public static int AdditionalRandomDelaySeconds
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

	// Token: 0x17000627 RID: 1575
	// (get) Token: 0x06002147 RID: 8519 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002148 RID: 8520 RVA: 0x00002050 File Offset: 0x00000250
	public static byte DefaultRetries
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

	// Token: 0x17000628 RID: 1576
	// (get) Token: 0x06002149 RID: 8521 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600214A RID: 8522 RVA: 0x00002050 File Offset: 0x00000250
	public static byte MaximumRetries
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

	// Token: 0x04001FD8 RID: 8152
	public string Url;

	// Token: 0x04001FD9 RID: 8153
	public bool UseCache;

	// Token: 0x04001FDA RID: 8154
	public object DefaultObjectInCaseOfCache;

	// Token: 0x04001FDB RID: 8155
	public string CacheId;

	// Token: 0x04001FDC RID: 8156
	public bool ParseInBackground;

	// Token: 0x04001FDD RID: 8157
	public int TimeoutSeconds;

	// Token: 0x04001FDE RID: 8158
	public byte? Retries;

	// Token: 0x04001FDF RID: 8159
	public ERequestHandlingMode HandlingMode;

	// Token: 0x04001FE0 RID: 8160
	public bool RequireResponse;

	// Token: 0x04001FE1 RID: 8161
	[CompilerGenerated]
	private object object_0;

	// Token: 0x04001FE2 RID: 8162
	[CompilerGenerated]
	private static readonly int int_0;

	// Token: 0x04001FE3 RID: 8163
	[CompilerGenerated]
	private static int int_1;

	// Token: 0x04001FE4 RID: 8164
	[CompilerGenerated]
	private static int int_2;

	// Token: 0x04001FE5 RID: 8165
	[CompilerGenerated]
	private static int int_3;

	// Token: 0x04001FE6 RID: 8166
	[CompilerGenerated]
	private static int int_4;

	// Token: 0x04001FE7 RID: 8167
	[CompilerGenerated]
	private static byte byte_0;

	// Token: 0x04001FE8 RID: 8168
	[CompilerGenerated]
	private static byte byte_1;
}
