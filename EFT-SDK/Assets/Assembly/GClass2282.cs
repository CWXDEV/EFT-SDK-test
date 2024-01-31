using System;
using System.Runtime.CompilerServices;
using EFT.NextObservedPlayer;

// Token: 0x02001F6E RID: 8046
public class GClass2282 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x17001B65 RID: 7013
	// (get) Token: 0x0600A68C RID: 42636 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A68D RID: 42637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GInterface218 CreateInstance()
	{
		throw null;
	}

	// Token: 0x0600A68E RID: 42638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A68F RID: 42639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A690 RID: 42640 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A691 RID: 42641 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400ADDF RID: 44511
	public string AmmoToLoadTemplate;

	// Token: 0x0400ADE0 RID: 44512
	public bool InInventory;

	// Token: 0x0400ADE1 RID: 44513
	public bool MagInWeapon;

	// Token: 0x0400ADE2 RID: 44514
	public bool IsExternalMag;

	// Token: 0x0400ADE3 RID: 44515
	public int AmmoPackCount;

	// Token: 0x0400ADE4 RID: 44516
	public int MagFreeSpace;

	// Token: 0x0400ADE5 RID: 44517
	public bool InMisfireMalfunction;

	// Token: 0x0400ADE6 RID: 44518
	public bool HasAmmoInChamber;
}
