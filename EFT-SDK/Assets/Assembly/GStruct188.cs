using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001542 RID: 5442
[StructLayout(LayoutKind.Auto)]
public struct GStruct188
{
	// Token: 0x06007471 RID: 29809 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GInterface79 writer)
	{
		throw null;
	}

	// Token: 0x06007472 RID: 29810 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GInterface76 reader)
	{
		throw null;
	}

	// Token: 0x06007473 RID: 29811 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DeserializeDiffUsing(GInterface76 reader, ref GStruct188 reloadMagPacket, GStruct188 reloadMagPacket1)
	{
		throw null;
	}

	// Token: 0x06007474 RID: 29812 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SerializeDiffUsing(GInterface79 writer, GStruct188 reloadMagPacket, GStruct188 reloadMagPacket1)
	{
		throw null;
	}

	// Token: 0x06007475 RID: 29813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x04007B00 RID: 31488
	public bool Reload;

	// Token: 0x04007B01 RID: 31489
	public string MagId;

	// Token: 0x04007B02 RID: 31490
	public byte[] LocationDescription;
}
