using System;
using System.Runtime.CompilerServices;
using EFT.NextObservedPlayer;

// Token: 0x02001F61 RID: 8033
public class GClass2269 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x17001B58 RID: 7000
	// (get) Token: 0x0600A63E RID: 42558 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A63F RID: 42559 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GInterface218 CreateInstance()
	{
		throw null;
	}

	// Token: 0x0600A640 RID: 42560 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A641 RID: 42561 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A642 RID: 42562 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A643 RID: 42563 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400AD95 RID: 44437
	public bool InMisfireMalfunction;

	// Token: 0x0400AD96 RID: 44438
	public int MagTypeCurrent;

	// Token: 0x0400AD97 RID: 44439
	public int MagTypeNew;

	// Token: 0x0400AD98 RID: 44440
	public int AmmoInChamberCurrent;

	// Token: 0x0400AD99 RID: 44441
	public int AmmoInChamberResult;

	// Token: 0x0400AD9A RID: 44442
	public int AmmoInMag;

	// Token: 0x0400AD9B RID: 44443
	public bool NeedToAddAmmoInChamber;

	// Token: 0x0400AD9C RID: 44444
	public int ShellsInWeapon;

	// Token: 0x0400AD9D RID: 44445
	public int WeaponLevel;

	// Token: 0x0400AD9E RID: 44446
	public bool Boltcatch;

	// Token: 0x0400AD9F RID: 44447
	public bool ForceEmptyChamber;

	// Token: 0x0400ADA0 RID: 44448
	public string WeaponItemID;

	// Token: 0x0400ADA1 RID: 44449
	public string SlotModeID;

	// Token: 0x0400ADA2 RID: 44450
	public GStruct103 Items;
}
