using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;

// Token: 0x0200162A RID: 5674
[StructLayout(LayoutKind.Auto)]
public struct GStruct212 : GInterface141<GStruct212>
{
	// Token: 0x17001370 RID: 4976
	// (get) Token: 0x06007B67 RID: 31591 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007B68 RID: 31592 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface141<GStruct212> Nested
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

	// Token: 0x04008062 RID: 32866
	public bool IsEncoded;

	// Token: 0x04008063 RID: 32867
	public RadioTransmitterStatus Status;

	// Token: 0x04008064 RID: 32868
	public bool IsAgressor;

	// Token: 0x04008065 RID: 32869
	[CompilerGenerated]
	private GInterface141<GStruct212> ginterface141_0;
}
