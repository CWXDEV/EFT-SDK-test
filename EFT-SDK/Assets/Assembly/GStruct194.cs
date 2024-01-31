using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200154A RID: 5450
[StructLayout(LayoutKind.Auto)]
public struct GStruct194
{
	// Token: 0x06007481 RID: 29825 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GInterface79 writer)
	{
		throw null;
	}

	// Token: 0x06007482 RID: 29826 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GInterface76 reader)
	{
		throw null;
	}

	// Token: 0x04007B1C RID: 31516
	public GStruct194.ETag Tag;

	// Token: 0x04007B1D RID: 31517
	public GStruct195 CommandPacket;

	// Token: 0x04007B1E RID: 31518
	public GStruct326 StatusPacket;

	// Token: 0x0200154B RID: 5451
	public enum ETag
	{
		// Token: 0x04007B20 RID: 31520
		Command = 1,
		// Token: 0x04007B21 RID: 31521
		Status
	}
}
