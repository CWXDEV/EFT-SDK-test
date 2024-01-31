using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.NextObservedPlayer;

// Token: 0x02001F71 RID: 8049
public class GClass2285 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x17001B68 RID: 7016
	// (get) Token: 0x0600A69E RID: 42654 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A69F RID: 42655 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GInterface218 CreateInstance()
	{
		throw null;
	}

	// Token: 0x0600A6A0 RID: 42656 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A6A1 RID: 42657 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A6A2 RID: 42658 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A6A3 RID: 42659 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400ADF1 RID: 44529
	public Weapon.EMalfunctionState MalfunctionState;

	// Token: 0x0400ADF2 RID: 44530
	public string AmmoToFire;

	// Token: 0x0400ADF3 RID: 44531
	public string MalfunctionedAmmo;

	// Token: 0x0400ADF4 RID: 44532
	public string AmmoToLoadAfterRepair;

	// Token: 0x0400ADF5 RID: 44533
	public int AmmoInMag;
}
