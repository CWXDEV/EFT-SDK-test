using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.InventoryLogic;

// Token: 0x02001538 RID: 5432
[StructLayout(LayoutKind.Auto)]
public struct GStruct179
{
	// Token: 0x0600745E RID: 29790 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DeserializeDiffUsing(GInterface76 reader, ref GStruct179 fireModePacket)
	{
		throw null;
	}

	// Token: 0x0600745F RID: 29791 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SerializeDiffUsing(GInterface79 writer, GStruct179 fireModePacket)
	{
		throw null;
	}

	// Token: 0x06007460 RID: 29792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x04007AC7 RID: 31431
	public bool ChangeFireMode;

	// Token: 0x04007AC8 RID: 31432
	public Weapon.EFireMode FireMode;
}
