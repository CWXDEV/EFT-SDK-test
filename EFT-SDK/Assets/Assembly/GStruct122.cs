using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.Interactive;

// Token: 0x020011D4 RID: 4564
[StructLayout(LayoutKind.Auto)]
public struct GStruct122 : GInterface141<GStruct122>
{
	// Token: 0x17000F51 RID: 3921
	// (get) Token: 0x0600616F RID: 24943 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06006170 RID: 24944 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface141<GStruct122> Nested
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

	// Token: 0x04006B4E RID: 27470
	public int NetId;

	// Token: 0x04006B4F RID: 27471
	public Turnable.EState State;

	// Token: 0x04006B50 RID: 27472
	[CompilerGenerated]
	private GInterface141<GStruct122> ginterface141_0;
}
