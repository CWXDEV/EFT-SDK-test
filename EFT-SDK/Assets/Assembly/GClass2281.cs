using System;
using System.Runtime.CompilerServices;
using EFT.NextObservedPlayer;

// Token: 0x02001F6D RID: 8045
public class GClass2281 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x17001B64 RID: 7012
	// (get) Token: 0x0600A686 RID: 42630 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A687 RID: 42631 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GInterface218 CreateInstance()
	{
		throw null;
	}

	// Token: 0x0600A688 RID: 42632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A689 RID: 42633 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A68A RID: 42634 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A68B RID: 42635 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400ADCF RID: 44495
	public int AmmoInChamberCurrent;

	// Token: 0x0400ADD0 RID: 44496
	public int AmmoInChamberResult;

	// Token: 0x0400ADD1 RID: 44497
	public bool NeedToAddAmmoInChamber;

	// Token: 0x0400ADD2 RID: 44498
	public int ShellsInWeapon;

	// Token: 0x0400ADD3 RID: 44499
	public int WeaponLevel;

	// Token: 0x0400ADD4 RID: 44500
	public bool InInventory;

	// Token: 0x0400ADD5 RID: 44501
	public bool MagInWeapon;

	// Token: 0x0400ADD6 RID: 44502
	public int AmmoInMag;

	// Token: 0x0400ADD7 RID: 44503
	public bool Malfunction;

	// Token: 0x0400ADD8 RID: 44504
	public bool MagOutFromInventory;

	// Token: 0x0400ADD9 RID: 44505
	public string SlotModeID;

	// Token: 0x0400ADDA RID: 44506
	public GStruct103 NextMag;

	// Token: 0x0400ADDB RID: 44507
	public bool IsQuickReload;

	// Token: 0x0400ADDC RID: 44508
	public int OldMagAnimIndex;

	// Token: 0x0400ADDD RID: 44509
	public int NewMagAnimIndex;

	// Token: 0x0400ADDE RID: 44510
	public bool InMisfireMalfunction;
}
