using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.NextObservedPlayer;

// Token: 0x02001F5F RID: 8031
public class GClass2267 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x17001B56 RID: 6998
	// (get) Token: 0x0600A632 RID: 42546 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A633 RID: 42547 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GInterface218 CreateInstance()
	{
		throw null;
	}

	// Token: 0x0600A634 RID: 42548 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A635 RID: 42549 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A636 RID: 42550 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A637 RID: 42551 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400AD8D RID: 44429
	public bool CheckAmmo;

	// Token: 0x0400AD8E RID: 44430
	public bool CheckChamber;

	// Token: 0x0400AD8F RID: 44431
	public bool Look;

	// Token: 0x0400AD90 RID: 44432
	public Weapon.EMalfunctionState MalfunctionState;

	// Token: 0x0400AD91 RID: 44433
	public bool CheckFireMode;

	// Token: 0x0400AD92 RID: 44434
	public bool InInventory;
}
