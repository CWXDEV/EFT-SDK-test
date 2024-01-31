using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x020024E3 RID: 9443
public sealed class GClass2763 : ItemAddress
{
	// Token: 0x170021C1 RID: 8641
	// (get) Token: 0x0600BD94 RID: 48532 RVA: 0x00002050 File Offset: 0x00000250
	public override Item Item
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021C2 RID: 8642
	// (get) Token: 0x0600BD95 RID: 48533 RVA: 0x00002050 File Offset: 0x00000250
	public override string ContainerName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BD96 RID: 48534 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GStruct415<int> GetMaxAddCount(Item item, string visitorId)
	{
		throw null;
	}

	// Token: 0x0600BD97 RID: 48535 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsSpecialSlotAddress()
	{
		throw null;
	}

	// Token: 0x0600BD98 RID: 48536 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RaiseAddEvent(Item item, CommandStatus status, string profileId, bool silent = false)
	{
		throw null;
	}

	// Token: 0x0600BD99 RID: 48537 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RaiseRemoveEvent(Item item, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BD9A RID: 48538 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GStruct415<int> Add(Item item, string[] visitorIds, bool simulate = false)
	{
		throw null;
	}

	// Token: 0x0600BD9B RID: 48539 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GStruct415<int> AddWithoutRestrictions(Item item, string[] visitorIds)
	{
		throw null;
	}

	// Token: 0x0600BD9C RID: 48540 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GStruct415<GStruct369> Remove(Item item, string visitorId, bool simulate = false)
	{
		throw null;
	}

	// Token: 0x0600BD9D RID: 48541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400BFE3 RID: 49123
	public readonly Slot Slot;

	// Token: 0x020024E4 RID: 9444
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2113
	{
		// Token: 0x0600BD9E RID: 48542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GStruct369 method_0(bool _)
		{
			throw null;
		}

		// Token: 0x0400BFE4 RID: 49124
		public static readonly GClass2763.Class2113 class2113_0;

		// Token: 0x0400BFE5 RID: 49125
		public static Func<bool, GStruct369> func_0;
	}
}
