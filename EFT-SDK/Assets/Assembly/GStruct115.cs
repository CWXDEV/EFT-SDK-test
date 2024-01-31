using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;

// Token: 0x020011A9 RID: 4521
[StructLayout(LayoutKind.Auto)]
public struct GStruct115
{
	// Token: 0x06006061 RID: 24673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x04006A42 RID: 27202
	public EDisconnectionCode DisconnectionCode;

	// Token: 0x04006A43 RID: 27203
	public string AdditionalInfo;

	// Token: 0x04006A44 RID: 27204
	public string OriginalTechnicalMessage;
}
