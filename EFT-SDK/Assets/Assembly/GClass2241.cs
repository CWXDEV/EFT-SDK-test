using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using EFT.NextObservedPlayer;

// Token: 0x02001F44 RID: 8004
public class GClass2241 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x17001B3A RID: 6970
	// (get) Token: 0x0600A592 RID: 42386 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A593 RID: 42387 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GInterface218 CreateInstance()
	{
		throw null;
	}

	// Token: 0x0600A594 RID: 42388 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A595 RID: 42389 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A596 RID: 42390 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A597 RID: 42391 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400AD49 RID: 44361
	public static GClass2241 EmptyHandsCommand;

	// Token: 0x0400AD4A RID: 44362
	public EHandsControllerType HandControllerType;

	// Token: 0x0400AD4B RID: 44363
	public GStruct103 Item;

	// Token: 0x0400AD4C RID: 44364
	public bool FastHide;

	// Token: 0x0400AD4D RID: 44365
	public Weapon.EMalfunctionState MalfunctionState;

	// Token: 0x0400AD4E RID: 44366
	public string MalfunctionedAmmo;

	// Token: 0x0400AD4F RID: 44367
	public bool Armed;

	// Token: 0x0400AD50 RID: 44368
	public int AmmoInChamber;

	// Token: 0x0400AD51 RID: 44369
	public float DrawAnimationSpeedMultiplier;
}
