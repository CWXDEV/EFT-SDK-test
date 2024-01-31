using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001634 RID: 5684
[StructLayout(LayoutKind.Auto)]
public struct GStruct221
{
	// Token: 0x06007B83 RID: 31619 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400807F RID: 32895
	[NonSerialized]
	public string RealConditionalId;

	// Token: 0x04008080 RID: 32896
	public int ConditionalIdHash;

	// Token: 0x04008081 RID: 32897
	public GStruct330<GStruct222> Conditions;
}
