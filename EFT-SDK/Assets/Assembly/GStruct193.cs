using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001547 RID: 5447
[StructLayout(LayoutKind.Auto)]
public struct GStruct193
{
	// Token: 0x0600747E RID: 29822 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize(GInterface77 serializer, ref GStruct193 reloadWithAmmoPacket)
	{
		throw null;
	}

	// Token: 0x0600747F RID: 29823 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x04007B0F RID: 31503
	private const int int_0 = 63;

	// Token: 0x04007B10 RID: 31504
	private const int int_1 = 3;

	// Token: 0x04007B11 RID: 31505
	public bool Reload;

	// Token: 0x04007B12 RID: 31506
	public bool FastReload;

	// Token: 0x04007B13 RID: 31507
	public GStruct193.EReloadWithAmmoStatus ReloadWithAmmoStatus;

	// Token: 0x04007B14 RID: 31508
	public int AmmoLoadedToMag;

	// Token: 0x04007B15 RID: 31509
	public string[] AmmoIds;

	// Token: 0x04007B16 RID: 31510
	public int[] ShellsIds;

	// Token: 0x02001548 RID: 5448
	public enum EReloadWithAmmoStatus
	{
		// Token: 0x04007B18 RID: 31512
		None,
		// Token: 0x04007B19 RID: 31513
		StartReload,
		// Token: 0x04007B1A RID: 31514
		EndReload,
		// Token: 0x04007B1B RID: 31515
		AbortReload
	}
}
