using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NLog.Config;
using NLog.Targets;

// Token: 0x02000692 RID: 1682
[Serializable]
public class LoggingRuleConfig
{
	// Token: 0x0600264A RID: 9802 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Apply(LoggingRule loggingRule)
	{
		throw null;
	}

	// Token: 0x0600264B RID: 9803 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string smethod_0<T>(IEnumerable<T> enumerable, string separator = "")
	{
		throw null;
	}

	// Token: 0x04002567 RID: 9575
	public string LogPattern;

	// Token: 0x04002568 RID: 9576
	public LoggingLevelConfig[] LoggingLevelConfigs;

	// Token: 0x04002569 RID: 9577
	public string Targets;

	// Token: 0x0400256A RID: 9578
	public bool IsFinal;

	// Token: 0x02000693 RID: 1683
	[CompilerGenerated]
	[Serializable]
	private sealed class Class359
	{
		// Token: 0x0600264C RID: 9804 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(Target x)
		{
			throw null;
		}

		// Token: 0x0400256B RID: 9579
		public static readonly LoggingRuleConfig.Class359 class359_0;

		// Token: 0x0400256C RID: 9580
		public static Func<Target, string> func_0;
	}

	// Token: 0x02000694 RID: 1684
	[CompilerGenerated]
	[Serializable]
	private sealed class Class360<T>
	{
		// Token: 0x0600264D RID: 9805 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(object x)
		{
			throw null;
		}

		// Token: 0x0400256D RID: 9581
		public static readonly LoggingRuleConfig.Class360<T> class360_0;

		// Token: 0x0400256E RID: 9582
		public static Func<object, string> func_0;
	}
}
