using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001638 RID: 5688
[StructLayout(LayoutKind.Auto)]
public struct GStruct225 : GInterface141<GStruct225>
{
	// Token: 0x17001376 RID: 4982
	// (get) Token: 0x06007B87 RID: 31623 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007B88 RID: 31624 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface141<GStruct225> Nested
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

	// Token: 0x04008090 RID: 32912
	public uint CallbackId;

	// Token: 0x04008091 RID: 32913
	public string Error;

	// Token: 0x04008092 RID: 32914
	public int InventoryHashSum;

	// Token: 0x04008093 RID: 32915
	public byte BadBeforeExecuting;

	// Token: 0x04008094 RID: 32916
	[CompilerGenerated]
	private GInterface141<GStruct225> ginterface141_0;
}
