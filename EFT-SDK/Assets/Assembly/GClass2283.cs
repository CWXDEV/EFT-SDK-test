using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.NextObservedPlayer;

// Token: 0x02001F6F RID: 8047
public class GClass2283 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x17001B66 RID: 7014
	// (get) Token: 0x0600A692 RID: 42642 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A693 RID: 42643 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GInterface218 CreateInstance()
	{
		throw null;
	}

	// Token: 0x0600A694 RID: 42644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A695 RID: 42645 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A696 RID: 42646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A697 RID: 42647 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400ADE7 RID: 44519
	public int AmmoInChamber;

	// Token: 0x0400ADE8 RID: 44520
	public int ShellsInWeapon;

	// Token: 0x0400ADE9 RID: 44521
	public int WeaponLevel;

	// Token: 0x0400ADEA RID: 44522
	public bool InInventory;

	// Token: 0x0400ADEB RID: 44523
	public Weapon.EMalfunctionState MalfunctionState;

	// Token: 0x0400ADEC RID: 44524
	public int AmmoInStack;
}
