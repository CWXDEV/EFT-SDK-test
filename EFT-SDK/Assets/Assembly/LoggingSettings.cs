using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000698 RID: 1688
public class LoggingSettings : ScriptableObject
{
	// Token: 0x170006EB RID: 1771
	// (get) Token: 0x06002662 RID: 9826 RVA: 0x00002050 File Offset: 0x00000250
	public static LoggingSettings Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04002579 RID: 9593
	private static LoggingSettings loggingSettings_0;

	// Token: 0x0400257A RID: 9594
	public bool AILogging;
}
