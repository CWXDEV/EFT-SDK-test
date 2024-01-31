using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;

// Token: 0x0200162F RID: 5679
[StructLayout(LayoutKind.Auto)]
public struct GStruct216 : GInterface141<GStruct216>
{
	// Token: 0x17001372 RID: 4978
	// (get) Token: 0x06007B7B RID: 31611 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007B7C RID: 31612 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface141<GStruct216> Nested
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

	// Token: 0x04008073 RID: 32883
	public NetworkPlayer.ClientShot[] ClientShots;

	// Token: 0x04008074 RID: 32884
	[CompilerGenerated]
	private GInterface141<GStruct216> ginterface141_0;
}
