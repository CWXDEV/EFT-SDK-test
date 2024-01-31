using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.Interactive;

// Token: 0x020011D3 RID: 4563
[StructLayout(LayoutKind.Auto)]
public struct GStruct121 : GInterface141<GStruct121>
{
	// Token: 0x17000F50 RID: 3920
	// (get) Token: 0x0600616D RID: 24941 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600616E RID: 24942 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface141<GStruct121> Nested
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

	// Token: 0x04006B4A RID: 27466
	public string PointName;

	// Token: 0x04006B4B RID: 27467
	public EExfiltrationStatus Command;

	// Token: 0x04006B4C RID: 27468
	public List<string> QueuedPlayers;

	// Token: 0x04006B4D RID: 27469
	[CompilerGenerated]
	private GInterface141<GStruct121> ginterface141_0;
}
