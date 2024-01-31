using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using Diz.LanguageExtensions;
using EFT;
using EFT.InventoryLogic;
using EFT.NextObservedPlayer;

// Token: 0x02002031 RID: 8241
public class GClass2758 : InventoryControllerClass, IDisposable
{
	// Token: 0x17001BDC RID: 7132
	// (get) Token: 0x0600AA8B RID: 43659 RVA: 0x00002050 File Offset: 0x00000250
	public new GClass2376 Profile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600AA8C RID: 43660 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(ObservedPlayerView view)
	{
		throw null;
	}

	// Token: 0x0600AA8D RID: 43661 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute(GInterface218 commandMessage)
	{
		throw null;
	}

	// Token: 0x0600AA8E RID: 43662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OutProcess(Item item, ItemAddress from, ItemAddress to, GInterface336 operation, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600AA8F RID: 43663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExecuteInventoryOperation(GClass1529 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AA90 RID: 43664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_31(GClass2223 command)
	{
		throw null;
	}

	// Token: 0x0600AA91 RID: 43665 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_32(GClass2255 commandMessage)
	{
		throw null;
	}

	// Token: 0x0600AA92 RID: 43666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_33(GClass2234 commandMessage)
	{
		throw null;
	}

	// Token: 0x0600AA93 RID: 43667 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_34(Callback callback)
	{
		throw null;
	}

	// Token: 0x0600AA94 RID: 43668 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct410 method_35(GClass1529 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AA95 RID: 43669 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GStruct415<ItemAddress> smethod_1(GClass1522 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AA96 RID: 43670 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct415<ValueTuple<Item, GameWorld.GStruct116>> method_36(string itemId, bool checkDistance = true, bool checkOwnership = true)
	{
		throw null;
	}

	// Token: 0x0600AA97 RID: 43671 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct415<Item> method_37(string itemId, bool checkDistance = true, bool checkOwnership = true)
	{
		throw null;
	}

	// Token: 0x0600AA98 RID: 43672 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct415<IEnumerable<GStruct368>> method_38(IEnumerable<GClass1528> itemsData)
	{
		throw null;
	}

	// Token: 0x0600AA99 RID: 43673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOwnerCandidateValid(string itemId, IItemOwner ownerCandidate, out Error error)
	{
		throw null;
	}

	// Token: 0x0600AA9A RID: 43674 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct410 method_39(GClass1564 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AA9B RID: 43675 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct411<GClass2864> method_40(GClass1534 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AA9C RID: 43676 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct411<GClass2872> method_41(GClass1546 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AA9D RID: 43677 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct411<GClass2835> method_42(GClass1542 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AA9E RID: 43678 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct411<GClass2868> method_43(GClass1544 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AA9F RID: 43679 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct411<GClass2860> method_44(GClass1545 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AAA0 RID: 43680 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct411<GClass2867> ToShotOperation(GClass1551 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AAA1 RID: 43681 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct411<GClass2837> method_45(GClass1548 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AAA2 RID: 43682 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct411<GClass2866> ToSetupItemOperation(GClass1552 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AAA3 RID: 43683 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct411<GClass2869> ToStationaryOperation(GClass1562 descriptor)
	{
		throw null;
	}

	// Token: 0x0600AAA4 RID: 43684 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400B17E RID: 45438
	private IPlayer iplayer_0;

	// Token: 0x0400B17F RID: 45439
	private GClass2376 gclass2376_0;

	// Token: 0x0400B180 RID: 45440
	private GClass2372 gclass2372_0;

	// Token: 0x02002032 RID: 8242
	[CompilerGenerated]
	private sealed class Class1857
	{
		// Token: 0x0600AAA5 RID: 43685 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult executeResult)
		{
			throw null;
		}

		// Token: 0x0400B181 RID: 45441
		public GClass2758 gclass2758_0;

		// Token: 0x0400B182 RID: 45442
		public GStruct410 operation;
	}

	// Token: 0x02002033 RID: 8243
	[CompilerGenerated]
	private sealed class Class1858
	{
		// Token: 0x0600AAA6 RID: 43686 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Item item)
		{
			throw null;
		}

		// Token: 0x0400B183 RID: 45443
		public TaskCompletionSource weaponOut;
	}
}
