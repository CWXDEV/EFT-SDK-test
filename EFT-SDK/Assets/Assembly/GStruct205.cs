using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.InventoryLogic;

// Token: 0x02001623 RID: 5667
[StructLayout(LayoutKind.Auto)]
public struct GStruct205 : GInterface141<GStruct205>
{
	// Token: 0x1700136A RID: 4970
	// (get) Token: 0x06007B5B RID: 31579 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007B5C RID: 31580 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface141<GStruct205> Nested
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

	// Token: 0x0400804E RID: 32846
	public string ItemId;

	// Token: 0x0400804F RID: 32847
	public SearchedState State;

	// Token: 0x04008050 RID: 32848
	[CompilerGenerated]
	private GInterface141<GStruct205> ginterface141_0;
}
