using System;
using System.Runtime.CompilerServices;
using EFT.NextObservedPlayer;

// Token: 0x02001F46 RID: 8006
public class GClass2243 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x17001B3C RID: 6972
	// (get) Token: 0x0600A59E RID: 42398 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A59F RID: 42399 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GInterface218 CreateInstance()
	{
		throw null;
	}

	// Token: 0x0600A5A0 RID: 42400 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A5A1 RID: 42401 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A5A2 RID: 42402 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A5A3 RID: 42403 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400AD53 RID: 44371
	public string StationaryWeaponId;

	// Token: 0x0400AD54 RID: 44372
	public GStruct168.EStationaryCommand StationaryCommand;

	// Token: 0x0400AD55 RID: 44373
	public int AmmoInMagCount;

	// Token: 0x0400AD56 RID: 44374
	public string MagazineSlotModeID;

	// Token: 0x0400AD57 RID: 44375
	public GStruct103 Magazine;

	// Token: 0x0400AD58 RID: 44376
	public string ChamberSlotModeID;

	// Token: 0x0400AD59 RID: 44377
	public GStruct103 ChamberAmmo;
}
