using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NLog.Config;
using UnityEngine;

// Token: 0x02000695 RID: 1685
[CreateAssetMenu]
public class LogConfigurationScriptableObject : ScriptableObject
{
	// Token: 0x0600264E RID: 9806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LoggingConfiguration MergeWith(LoggingConfiguration configuration)
	{
		throw null;
	}

	// Token: 0x0600264F RID: 9807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset(LoggingConfiguration configuration)
	{
		throw null;
	}

	// Token: 0x0400256F RID: 9583
	public List<LoggingRuleConfig> RuleConfigs;
}
