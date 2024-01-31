using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Diz.LanguageExtensions;
using EFT;
using EFT.InventoryLogic;
using EFT.Quests;
using JetBrains.Annotations;

// Token: 0x020024EE RID: 9454
public static class GClass2770
{
	// Token: 0x0600BDB9 RID: 48569 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task<GStruct414> QuickEmptyContainer(ContainerCollection container, IEnumerable<LootItemClass> targetItems, GClass2770.EMoveItemOrder order, InventoryControllerClass controller)
	{
		throw null;
	}

	// Token: 0x0600BDBA RID: 48570 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GInterface322> QuickFindAppropriatePlace(Item item, TraderControllerClass controller, IEnumerable<LootItemClass> targets, GClass2770.EMoveItemOrder order, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDBB RID: 48571 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_0(IEnumerable<GClass2495> gridsToPut, Item itemToMerge, out GClass2731 mergeableItem, int overrideCount = 0)
	{
		throw null;
	}

	// Token: 0x0600BDBC RID: 48572 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct415<bool> DestinationCheck(ItemAddress fromAddress, ItemAddress to, EOwnerType controllerType)
	{
		throw null;
	}

	// Token: 0x0600BDBD RID: 48573 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct415<bool> CheckMoveIgnoringTargetItem(Item item, GClass2763 to, TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BDBE RID: 48574 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GStruct415<GClass3345> smethod_1(Item item, ItemAddress to, TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BDBF RID: 48575 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IContainer smethod_2(ItemAddress to)
	{
		throw null;
	}

	// Token: 0x0600BDC0 RID: 48576 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_3(IContainer parent, IContainer child)
	{
		throw null;
	}

	// Token: 0x0600BDC1 RID: 48577 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2782> Move(Item item, ItemAddress to, TraderControllerClass itemController, bool simulate = false)
	{
		throw null;
	}

	// Token: 0x0600BDC2 RID: 48578 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GStruct371> AcceptQuest(GClass1246 quest, AbstractQuestControllerClass questController, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDC3 RID: 48579 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GStruct374> HandoverQuest(GClass1246 quest, Item[] items, ConditionItem itemCondition, TraderControllerClass itemController, AbstractQuestControllerClass questController, Profile profile, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDC4 RID: 48580 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GStruct373> FinishQuest(GClass1246 quest, TraderControllerClass itemController, AbstractQuestControllerClass questController, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDC5 RID: 48581 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GStruct372<TConditional>> FinishConditional<TConditional>(TConditional conditional, TraderControllerClass itemController, GClass3202<TConditional> conditionalController, bool simulate) where TConditional : GInterface381
	{
		throw null;
	}

	// Token: 0x0600BDC6 RID: 48582 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_4(InventoryControllerClass controller, Item item, [NotNull] in List<GClass2799> unbindResults, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDC7 RID: 48583 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_5(TraderControllerClass itemController, Item item, [NotNull] in List<GClass2799> unbindResults, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDC8 RID: 48584 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_6(InventoryControllerClass controller, Item item, [NotNull] in List<GClass2799> unbindResults, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDC9 RID: 48585 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_7(Item item, [NotNull] in List<GClass2803> setTagResults, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDCA RID: 48586 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_8(TagComponent tag, [NotNull] in List<GClass2803> setTagResults, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDCB RID: 48587 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GStruct415<GClass3345> smethod_9(Item item, ItemAddress to)
	{
		throw null;
	}

	// Token: 0x0600BDCC RID: 48588 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GStruct415<GClass3345> smethod_10(ItemAddress to)
	{
		throw null;
	}

	// Token: 0x0600BDCD RID: 48589 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_11(Item item, ItemAddress to, TraderControllerClass itemController, out GClass2770.GClass3339 limitError)
	{
		throw null;
	}

	// Token: 0x0600BDCE RID: 48590 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2778> Add(Item item, ItemAddress to, TraderControllerClass itemController, bool simulate = false)
	{
		throw null;
	}

	// Token: 0x0600BDCF RID: 48591 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2778> AddWithoutRestrictions(Item item, ItemAddress to, TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BDD0 RID: 48592 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckMissingParts(LootItemClass compoundItem, ItemAddress to, TraderControllerClass itemController, out Slot.GClass3312 error)
	{
		throw null;
	}

	// Token: 0x0600BDD1 RID: 48593 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GInterface324> DestroyOverLimitAndChangeLimits(Item item, int count, [CanBeNull] ItemAddress to, TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BDD2 RID: 48594 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<GStruct368> DestroyOverLimit(Item item, TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BDD3 RID: 48595 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GStruct413<GInterface324> smethod_12(Item item, int count, GInterface314 from, [CanBeNull] ItemAddress to, TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BDD4 RID: 48596 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GStruct413<GClass2778> smethod_13(Item item, ItemAddress to, TraderControllerClass itemController, bool simulate, bool ignoreRestrictions)
	{
		throw null;
	}

	// Token: 0x0600BDD5 RID: 48597 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2783> Resize_Helper(Item item, ItemAddress location, GClass2770.ResizeAction resizeAction, bool backwards, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDD6 RID: 48598 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_14(Item item, GStruct23 oldSize, GStruct23 newSize, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDD7 RID: 48599 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2779> Discard(Item item, TraderControllerClass itemController, bool simulate = false, bool ignoreRestrictions = false)
	{
		throw null;
	}

	// Token: 0x0600BDD8 RID: 48600 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2780 ChangeVersion(Item item, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDD9 RID: 48601 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2781> Remove(Item item, TraderControllerClass itemController, bool simulate = false, bool ignoreRestrictions = false)
	{
		throw null;
	}

	// Token: 0x0600BDDA RID: 48602 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2791> SplitMax(Item item, int count, ItemAddress to, TraderControllerClass itemController, GInterface319 idGenerator, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDDB RID: 48603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2791> SplitExact(Item item, int count, ItemAddress to, TraderControllerClass itemController, GInterface319 idGenerator, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDDC RID: 48604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2784> Merge(Item item, Item targetItem, TraderControllerClass itemController, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDDD RID: 48605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2792> TransferMax(Item item, Item targetItem, int count, TraderControllerClass itemController, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDDE RID: 48606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2792> TransferExact(Item item, int count, Item targetItem, TraderControllerClass itemController, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDDF RID: 48607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2793> Swap(Item item, ItemAddress toLocation, Item item1, ItemAddress toLocation1, TraderControllerClass itemController, bool simulate = false)
	{
		throw null;
	}

	// Token: 0x0600BDE0 RID: 48608 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2792> TransferMaxStackCount(Item source, Item target, int count, TraderControllerClass itemController, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDE1 RID: 48609 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GStruct415<GClass2788> smethod_15<T>(T item, int count, GInterface319 idGenerator, TraderControllerClass itemController) where T : Item
	{
		throw null;
	}

	// Token: 0x0600BDE2 RID: 48610 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2789> SplitToNowhere(Item item, int count, TraderControllerClass itemController, GInterface319 idGenerator, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDE3 RID: 48611 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int smethod_16(Item item)
	{
		throw null;
	}

	// Token: 0x0600BDE4 RID: 48612 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanFold(Item item, out FoldableComponent foldable)
	{
		throw null;
	}

	// Token: 0x0600BDE5 RID: 48613 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanRecode(Item item, out RecodableComponent recodable)
	{
		throw null;
	}

	// Token: 0x0600BDE6 RID: 48614 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2795> Fold(FoldableComponent foldable, bool folded, string visitorId, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDE7 RID: 48615 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2796> Recode(RecodableComponent recodable, bool encoded, string visitorId, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDE8 RID: 48616 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2879> PurchaseTraderService(BackendConfigSettingsClass.ServiceData serviceData, string subServiceId, AbstractQuestControllerClass questController, InventoryControllerClass inventoryController, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDE9 RID: 48617 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GInterface322> ApplySingleItemToAddress(Item item, GInterface319 idGenerator, TraderControllerClass itemController, ItemAddress to)
	{
		throw null;
	}

	// Token: 0x0600BDEA RID: 48618 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GInterface322> ApplyItemToRevolverDrum(Item item, GInterface319 idGenerator, TraderControllerClass itemController, ItemAddress to)
	{
		throw null;
	}

	// Token: 0x0600BDEB RID: 48619 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2804> Sort(LootItemClass sortingItem, InventoryControllerClass controller, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDEC RID: 48620 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetItemsToPlaces(GClass2495 grid, IEnumerable<GClass2503> itemsWithLocations)
	{
		throw null;
	}

	// Token: 0x0600BDED RID: 48621 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GInterface326> TransferOrMerge(Item item, Item targetItem, TraderControllerClass itemController, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDEE RID: 48622 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateAreaStashes(Dictionary<EAreaType, HideoutAreaStashInfo> addedHideoutAreaStashes, InventoryControllerClass inventoryController, ItemFactory itemFactory)
	{
		throw null;
	}

	// Token: 0x0600BDEF RID: 48623 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_17(TraderControllerClass inventoryController, LootItemClass oldStash, LootItemClass newStash)
	{
		throw null;
	}

	// Token: 0x0600BDF0 RID: 48624 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetItemsForAddress(ItemAddress itemAddress, GInterface313 inventoryController)
	{
		throw null;
	}

	// Token: 0x0600BDF1 RID: 48625 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GInterface321> EquipItemInSlot(Slot slot, Item item, InventoryControllerClass inventoryController, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDF2 RID: 48626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GStruct415<IEnumerable<GInterface322>> smethod_18(Item item, IEnumerable<LootItemClass> to, TraderControllerClass inventoryController, GClass2770.EMoveItemOrder moveItemOrder = GClass2770.EMoveItemOrder.ForcePush, bool simulate = false)
	{
		throw null;
	}

	// Token: 0x0600BDF3 RID: 48627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct415<IEnumerable<GInterface321>> TransferContent(LootItemClass presetItem, LootItemClass toItem, IEnumerable<LootItemClass> transferContainers, InventoryControllerClass inventoryController, [CanBeNull] List<Item> preAllocatedNotFoundItems, bool createFakeItems, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BDF4 RID: 48628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IEnumerable<Item> smethod_19(Item presetItem, IEnumerable<Item> foundItems)
	{
		throw null;
	}

	// Token: 0x0600BDF5 RID: 48629 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GStruct415<IEnumerable<GInterface321>> smethod_20(Item presetItem, IEnumerable<Item> foundItems, ItemAddress toAddress, IEnumerable<LootItemClass> transferContainers, InventoryControllerClass inventoryController, [CanBeNull] List<Item> preAllocatedNotFoundItems, bool createFakeItems)
	{
		throw null;
	}

	// Token: 0x0600BDF6 RID: 48630 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IEnumerable<Item> smethod_21(Item presetItem, GInterface313 inventoryController)
	{
		throw null;
	}

	// Token: 0x0600BDF7 RID: 48631 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GStruct415<IEnumerable<GInterface321>> smethod_22(Item itemToFind, ItemAddress toAddress, ref GClass2770.Struct747 struct747_0)
	{
		throw null;
	}

	// Token: 0x020024EF RID: 9455
	public sealed class GClass3326 : InventoryError
	{
		// Token: 0x0600BDF8 RID: 48632 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BDF9 RID: 48633 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400BFF4 RID: 49140
		public readonly Item Item;

		// Token: 0x0400BFF5 RID: 49141
		public readonly Weapon Weapon;
	}

	// Token: 0x020024F0 RID: 9456
	public sealed class GClass3327 : InventoryError
	{
		// Token: 0x0600BDFA RID: 48634 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BDFB RID: 48635 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400BFF6 RID: 49142
		public readonly Item Item;
	}

	// Token: 0x020024F1 RID: 9457
	public sealed class GClass3328 : InventoryError
	{
		// Token: 0x0600BDFC RID: 48636 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400BFF7 RID: 49143
		public readonly LockableComponent Lockable;
	}

	// Token: 0x020024F2 RID: 9458
	public sealed class GClass3329 : InventoryError
	{
		// Token: 0x0600BDFD RID: 48637 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BDFE RID: 48638 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400BFF8 RID: 49144
		public readonly ItemAddress Address;
	}

	// Token: 0x020024F3 RID: 9459
	public sealed class GClass3330 : InventoryError
	{
		// Token: 0x0600BDFF RID: 48639 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BE00 RID: 48640 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400BFF9 RID: 49145
		public readonly ItemAddress Address;
	}

	// Token: 0x020024F4 RID: 9460
	public sealed class GClass3331 : InventoryError
	{
		// Token: 0x0600BE01 RID: 48641 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BE02 RID: 48642 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400BFFA RID: 49146
		public readonly ItemAddress Address;
	}

	// Token: 0x020024F5 RID: 9461
	public sealed class GClass3332 : InventoryError
	{
		// Token: 0x0600BE03 RID: 48643 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BE04 RID: 48644 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400BFFB RID: 49147
		public readonly UnlootableComponent Unlootable;
	}

	// Token: 0x020024F6 RID: 9462
	public sealed class GClass3333 : InventoryError
	{
		// Token: 0x0600BE05 RID: 48645 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BE06 RID: 48646 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}
	}

	// Token: 0x020024F7 RID: 9463
	public sealed class GClass3334 : InventoryError
	{
		// Token: 0x0600BE07 RID: 48647 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BE08 RID: 48648 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400BFFC RID: 49148
		private readonly Item item_0;

		// Token: 0x0400BFFD RID: 49149
		private readonly string string_0;
	}

	// Token: 0x020024F8 RID: 9464
	public sealed class GClass3335 : InventoryError
	{
		// Token: 0x0600BE09 RID: 48649 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BE0A RID: 48650 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400BFFE RID: 49150
		public readonly UnlootableComponent Unlootable;
	}

	// Token: 0x020024F9 RID: 9465
	public sealed class GClass3336 : InventoryError
	{
		// Token: 0x0600BE0B RID: 48651 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400BFFF RID: 49151
		public readonly Item Item;

		// Token: 0x0400C000 RID: 49152
		public readonly ItemAddress Location;

		// Token: 0x0400C001 RID: 49153
		public readonly int MaxAllowedCount;
	}

	// Token: 0x020024FA RID: 9466
	public sealed class GClass3337 : InventoryError
	{
		// Token: 0x0600BE0C RID: 48652 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BE0D RID: 48653 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400C002 RID: 49154
		public readonly Item Item;

		// Token: 0x0400C003 RID: 49155
		public readonly Item ConflictingItem;

		// Token: 0x0400C004 RID: 49156
		public readonly ItemAddress To;

		// Token: 0x0400C005 RID: 49157
		public readonly GStruct23 NewSize;
	}

	// Token: 0x020024FB RID: 9467
	public sealed class GClass3338 : InventoryError
	{
		// Token: 0x0600BE0E RID: 48654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BE0F RID: 48655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400C006 RID: 49158
		public readonly Item Item;

		// Token: 0x0400C007 RID: 49159
		public readonly ItemAddress To;
	}

	// Token: 0x020024FC RID: 9468
	public sealed class GClass3339 : InventoryError
	{
		// Token: 0x0600BE10 RID: 48656 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BE11 RID: 48657 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400C008 RID: 49160
		public readonly Item Item;

		// Token: 0x0400C009 RID: 49161
		public readonly int Limit;

		// Token: 0x0400C00A RID: 49162
		public readonly int AvailableCount;
	}

	// Token: 0x020024FD RID: 9469
	public sealed class GClass3340 : InventoryError
	{
		// Token: 0x0600BE12 RID: 48658 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600BE13 RID: 48659 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400C00B RID: 49163
		public readonly Item Item;
	}

	// Token: 0x020024FE RID: 9470
	[Flags]
	public enum EMoveItemOrder
	{
		// Token: 0x0400C00D RID: 49165
		TryMerge = 1,
		// Token: 0x0400C00E RID: 49166
		TryTransfer = 3,
		// Token: 0x0400C00F RID: 49167
		PrioritizeParent = 4,
		// Token: 0x0400C010 RID: 49168
		PrioritizeTargetsOrder = 8,
		// Token: 0x0400C011 RID: 49169
		IgnoreItemParent = 16,
		// Token: 0x0400C012 RID: 49170
		TryEquip = 32,
		// Token: 0x0400C013 RID: 49171
		MoveToAnotherSide = 9,
		// Token: 0x0400C014 RID: 49172
		UnloadAmmo = 15,
		// Token: 0x0400C015 RID: 49173
		Apply = 19,
		// Token: 0x0400C016 RID: 49174
		PickUp = 51,
		// Token: 0x0400C017 RID: 49175
		UnloadWeapon = 12,
		// Token: 0x0400C018 RID: 49176
		ForcePush = 25
	}

	// Token: 0x020024FF RID: 9471
	public enum ResizeAction
	{
		// Token: 0x0400C01A RID: 49178
		Addition,
		// Token: 0x0400C01B RID: 49179
		Removal,
		// Token: 0x0400C01C RID: 49180
		Fold,
		// Token: 0x0400C01D RID: 49181
		Unfold
	}

	// Token: 0x02002501 RID: 9473
	[CompilerGenerated]
	private sealed class Class2115
	{
		// Token: 0x0600BE16 RID: 48662 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GClass2495> method_0(LootItemClass compoundItem)
		{
			throw null;
		}

		// Token: 0x0600BE17 RID: 48663 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GStruct413<GInterface322> method_1(IEnumerable<GClass2495> gridsToPut)
		{
			throw null;
		}

		// Token: 0x0400C027 RID: 49191
		public Item item;

		// Token: 0x0400C028 RID: 49192
		public TraderControllerClass controller;

		// Token: 0x0400C029 RID: 49193
		public Error noActionsError;

		// Token: 0x0400C02A RID: 49194
		public Error noSpaceError;

		// Token: 0x0400C02B RID: 49195
		public GClass2770.EMoveItemOrder order;

		// Token: 0x0400C02C RID: 49196
		public bool simulate;
	}

	// Token: 0x02002502 RID: 9474
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2116
	{
		// Token: 0x0600BE18 RID: 48664 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2495 grid)
		{
			throw null;
		}

		// Token: 0x0600BE19 RID: 48665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Item> method_1(GClass2495 x)
		{
			throw null;
		}

		// Token: 0x0600BE1A RID: 48666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(GClass2731 x)
		{
			throw null;
		}

		// Token: 0x0600BE1B RID: 48667 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Item> method_3(IContainer x)
		{
			throw null;
		}

		// Token: 0x0600BE1C RID: 48668 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_4(Mod x)
		{
			throw null;
		}

		// Token: 0x0600BE1D RID: 48669 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_5(Mod x)
		{
			throw null;
		}

		// Token: 0x0600BE1E RID: 48670 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_6(Slot slot)
		{
			throw null;
		}

		// Token: 0x0600BE1F RID: 48671 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Item> method_7(Slot slot)
		{
			throw null;
		}

		// Token: 0x0600BE20 RID: 48672 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_8(Item item)
		{
			throw null;
		}

		// Token: 0x0600BE21 RID: 48673 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_9(Item item)
		{
			throw null;
		}

		// Token: 0x0600BE22 RID: 48674 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_10(Item stackItem)
		{
			throw null;
		}

		// Token: 0x0600BE23 RID: 48675 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_11(Item item)
		{
			throw null;
		}

		// Token: 0x0600BE24 RID: 48676 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_12(ContainerCollection x)
		{
			throw null;
		}

		// Token: 0x0600BE25 RID: 48677 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_13(IContainer container)
		{
			throw null;
		}

		// Token: 0x0600BE26 RID: 48678 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_14(ContainerCollection x)
		{
			throw null;
		}

		// Token: 0x0600BE29 RID: 48681 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_17(Item item)
		{
			throw null;
		}

		// Token: 0x0600BE2A RID: 48682 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_18(IItemComponent component)
		{
			throw null;
		}

		// Token: 0x0400C02D RID: 49197
		public static readonly GClass2770.Class2116 class2116_0;

		// Token: 0x0400C02E RID: 49198
		public static Func<GClass2495, bool> func_0;

		// Token: 0x0400C02F RID: 49199
		public static Func<GClass2495, IEnumerable<Item>> func_1;

		// Token: 0x0400C030 RID: 49200
		public static Func<GClass2731, bool> func_2;

		// Token: 0x0400C031 RID: 49201
		public static Func<IContainer, IEnumerable<Item>> func_3;

		// Token: 0x0400C032 RID: 49202
		public static Func<Mod, bool> func_4;

		// Token: 0x0400C033 RID: 49203
		public static Func<Mod, bool> func_5;

		// Token: 0x0400C034 RID: 49204
		public static Func<Slot, bool> func_6;

		// Token: 0x0400C035 RID: 49205
		public static Func<Slot, IEnumerable<Item>> func_7;

		// Token: 0x0400C036 RID: 49206
		public static Func<Item, bool> func_8;

		// Token: 0x0400C037 RID: 49207
		public static Func<Item, string> func_9;

		// Token: 0x0400C038 RID: 49208
		public static Func<Item, int> func_10;

		// Token: 0x0400C039 RID: 49209
		public static Func<Item, float> func_11;

		// Token: 0x0400C03A RID: 49210
		public static Func<IContainer, int> func_12;

		// Token: 0x0400C03B RID: 49211
		public static Func<ContainerCollection, int> func_13;

		// Token: 0x0400C03C RID: 49212
		public static Func<IContainer, int> func_14;

		// Token: 0x0400C03D RID: 49213
		public static Func<ContainerCollection, int> func_15;

		// Token: 0x0400C03E RID: 49214
		public static Func<Item, int> func_16;

		// Token: 0x0400C03F RID: 49215
		public static Func<IItemComponent, bool> func_17;

		// Token: 0x0400C040 RID: 49216
		public static Func<Item, bool> func_18;
	}

	// Token: 0x02002503 RID: 9475
	[CompilerGenerated]
	private sealed class Class2117
	{
		// Token: 0x0600BE2B RID: 48683 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2731 x)
		{
			throw null;
		}

		// Token: 0x0600BE2C RID: 48684 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GClass2731 x)
		{
			throw null;
		}

		// Token: 0x0600BE2D RID: 48685 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(GClass2731 x)
		{
			throw null;
		}

		// Token: 0x0600BE2E RID: 48686 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(GClass2731 item)
		{
			throw null;
		}

		// Token: 0x0400C041 RID: 49217
		public Item itemToMerge;

		// Token: 0x0400C042 RID: 49218
		public int overrideCount;
	}

	// Token: 0x02002504 RID: 9476
	[CompilerGenerated]
	private sealed class Class2118
	{
		// Token: 0x0600BE2F RID: 48687 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<EBoundItem, Item> x)
		{
			throw null;
		}

		// Token: 0x0400C043 RID: 49219
		public Item item;
	}

	// Token: 0x02002505 RID: 9477
	[CompilerGenerated]
	private sealed class Class2119
	{
		// Token: 0x0600BE30 RID: 48688 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ContainerCollection containerCollection)
		{
			throw null;
		}

		// Token: 0x0400C044 RID: 49220
		public LootItemClass oldStash;
	}

	// Token: 0x02002506 RID: 9478
	[CompilerGenerated]
	private sealed class Class2120
	{
		// Token: 0x0600BE31 RID: 48689 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2495 newGrid)
		{
			throw null;
		}

		// Token: 0x0600BE32 RID: 48690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Slot newSlot)
		{
			throw null;
		}
	}

	// Token: 0x02002507 RID: 9479
	[CompilerGenerated]
	private sealed class Class2121
	{
		// Token: 0x0600BE33 RID: 48691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item item)
		{
			throw null;
		}

		// Token: 0x0400C045 RID: 49221
		public ItemAddress itemAddress;
	}

	// Token: 0x02002508 RID: 9480
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct747
	{
		// Token: 0x0400C046 RID: 49222
		public InventoryControllerClass inventoryController;

		// Token: 0x0400C047 RID: 49223
		public bool createFakeItems;

		// Token: 0x0400C048 RID: 49224
		public List<Item> preAllocatedNotFoundItems;

		// Token: 0x0400C049 RID: 49225
		public List<GInterface321> operationResults;

		// Token: 0x0400C04A RID: 49226
		public IEnumerable<LootItemClass> transferContainers;
	}

	// Token: 0x02002509 RID: 9481
	[CompilerGenerated]
	private sealed class Class2122
	{
		// Token: 0x0600BE34 RID: 48692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(IContainer foundGrid)
		{
			throw null;
		}

		// Token: 0x0400C04B RID: 49227
		public IAmmoContainer ammoContainer;

		// Token: 0x0400C04C RID: 49228
		public Func<IContainer, bool> func_0;
	}

	// Token: 0x0200250A RID: 9482
	[CompilerGenerated]
	private sealed class Class2123
	{
		// Token: 0x0600BE35 RID: 48693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Slot foundSlot)
		{
			throw null;
		}

		// Token: 0x0400C04D RID: 49229
		public Slot presetSlot;
	}

	// Token: 0x0200250B RID: 9483
	[CompilerGenerated]
	private sealed class Class2124
	{
		// Token: 0x0600BE36 RID: 48694 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2495 foundGrid)
		{
			throw null;
		}

		// Token: 0x0400C04E RID: 49230
		public GClass2495 presetGrid;

		// Token: 0x0400C04F RID: 49231
		public Func<GClass2495, bool> func_0;
	}

	// Token: 0x0200250C RID: 9484
	[CompilerGenerated]
	private sealed class Class2125
	{
		// Token: 0x0600BE37 RID: 48695 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ContainerCollection x)
		{
			throw null;
		}

		// Token: 0x0600BE38 RID: 48696 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(ContainerCollection x)
		{
			throw null;
		}

		// Token: 0x0600BE39 RID: 48697 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(Item itemStack)
		{
			throw null;
		}

		// Token: 0x0400C050 RID: 49232
		public Item presetItem;
	}

	// Token: 0x0200250D RID: 9485
	[CompilerGenerated]
	private sealed class Class2126
	{
		// Token: 0x0600BE3A RID: 48698 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item availableItem)
		{
			throw null;
		}

		// Token: 0x0600BE3B RID: 48699 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Item availableItem)
		{
			throw null;
		}

		// Token: 0x0400C051 RID: 49233
		public Item presetItem;
	}
}
