using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x020024B4 RID: 9396
public static class GClass2751
{
	// Token: 0x0600BC23 RID: 48163 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetIndexOfItemType(this Item i)
	{
		throw null;
	}

	// Token: 0x0600BC24 RID: 48164 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> GetComponents<T>(this IEnumerable<Item> items) where T : class, IItemComponent
	{
		throw null;
	}

	// Token: 0x0600BC25 RID: 48165 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetAllItems(this Item topLevelItem)
	{
		throw null;
	}

	// Token: 0x0600BC26 RID: 48166 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetAllItemsFromCollection(this ContainerCollection topLevelCollection)
	{
		throw null;
	}

	// Token: 0x0600BC27 RID: 48167 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetAllItemsFromGridItemCollectionNonAlloc(this GClass2500 gridItemCollection, List<Item> preAllocatedList)
	{
		throw null;
	}

	// Token: 0x0600BC28 RID: 48168 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IEnumerable<Item> smethod_0(this Item topLevelItem, [CanBeNull] Predicate<ContainerCollection> goInsideItemPredicate, [CanBeNull] Predicate<IContainer> goInsideContainerPredicate)
	{
		throw null;
	}

	// Token: 0x0600BC29 RID: 48169 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetAllItems(this Item topLevelItem, Predicate<IContainer> goDeeperPredicate)
	{
		throw null;
	}

	// Token: 0x0600BC2A RID: 48170 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetAllItems(this Item topLevelItem, Predicate<ContainerCollection> goDeeperPredicate)
	{
		throw null;
	}

	// Token: 0x0600BC2B RID: 48171 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetAllItemsFromCollections(this IEnumerable<ContainerCollection> topLevelCollections)
	{
		throw null;
	}

	// Token: 0x0600BC2C RID: 48172 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetMergedItemContent(this Item thisItem)
	{
		throw null;
	}

	// Token: 0x0600BC2D RID: 48173 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetNotMergedItems(this Item thisItem)
	{
		throw null;
	}

	// Token: 0x0600BC2E RID: 48174 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetAllItemsNonAlloc<T>(this Item thisItem, [NotNull] List<T> preAllocatedList, bool onlyMerged = false, bool includeParent = true) where T : Item
	{
		throw null;
	}

	// Token: 0x0600BC2F RID: 48175 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetTopLevelItemsFromCollection(this ContainerCollection topLevelCollection)
	{
		throw null;
	}

	// Token: 0x0600BC30 RID: 48176 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetAllAssembledItems<T>(this Item thisItem, [NotNull] List<T> preAllocatedList) where T : Item
	{
		throw null;
	}

	// Token: 0x0600BC31 RID: 48177 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IReadOnlyList<Item> GetFirstLevelItems(this Item rootItem)
	{
		throw null;
	}

	// Token: 0x0600BC32 RID: 48178 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsEmpty(this Item item)
	{
		throw null;
	}

	// Token: 0x0600BC33 RID: 48179 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsNotEmpty(this Item item)
	{
		throw null;
	}

	// Token: 0x0600BC34 RID: 48180 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetAllAssembledItemsNonAlloc(this Item thisItem, [NotNull] List<Item> preAllocatedList)
	{
		throw null;
	}

	// Token: 0x0600BC35 RID: 48181 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetItemComponentsInChildrenNonAlloc<T>(this Item thisItem, [NotNull] List<T> preAllocatedList, bool onlyMerged = true) where T : GClass2750
	{
		throw null;
	}

	// Token: 0x0600BC36 RID: 48182 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> GetItemComponentsInChildren<T>(this Item thisItem, bool onlyMerged = true) where T : class, IItemComponent
	{
		throw null;
	}

	// Token: 0x0600BC37 RID: 48183 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckForLockable(this Item item)
	{
		throw null;
	}

	// Token: 0x0600BC38 RID: 48184 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item GetRootItem(this ItemAddress itemAddress)
	{
		throw null;
	}

	// Token: 0x0600BC39 RID: 48185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsChildOf(this ItemAddress itemAddress, Item rootItem, bool notMergedWithThisItem)
	{
		throw null;
	}

	// Token: 0x0600BC3A RID: 48186 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item GetRootItem(this Item item)
	{
		throw null;
	}

	// Token: 0x0600BC3B RID: 48187 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item GetNotMergedParent(this Item item)
	{
		throw null;
	}

	// Token: 0x0600BC3C RID: 48188 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item GetRootMergedItem(this Item item)
	{
		throw null;
	}

	// Token: 0x0600BC3D RID: 48189 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<ItemAddress> GetAllParentLocations(this Item item, bool onlyMerged = false)
	{
		throw null;
	}

	// Token: 0x0600BC3E RID: 48190 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<ItemAddress> GetAllParentLocations(this ItemAddress location, bool onlyMerged = false)
	{
		throw null;
	}

	// Token: 0x0600BC3F RID: 48191 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetAllParentItems(this ItemAddress location, bool onlyMerged = false)
	{
		throw null;
	}

	// Token: 0x0600BC40 RID: 48192 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetAllParentItemsAndSelf(this Item item, bool onlyMerged = false)
	{
		throw null;
	}

	// Token: 0x0600BC41 RID: 48193 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetAllParentItems(this Item item, bool onlyMerged = false)
	{
		throw null;
	}

	// Token: 0x0600BC42 RID: 48194 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsEquipmentAddress(this Inventory inventory, ItemAddress to)
	{
		throw null;
	}

	// Token: 0x0600BC43 RID: 48195 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T CloneVisibleItem<T>(this T originalItem) where T : Item
	{
		throw null;
	}

	// Token: 0x0600BC44 RID: 48196 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T CloneItem<T>(this T originalItem, GInterface319 idGenerator = null) where T : Item
	{
		throw null;
	}

	// Token: 0x0600BC45 RID: 48197 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T CloneItemWithSameId<T>(this T originalItem) where T : Item
	{
		throw null;
	}

	// Token: 0x0600BC46 RID: 48198 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T CloneBodyItem<T>(this T originalItem) where T : Item
	{
		throw null;
	}

	// Token: 0x0600BC47 RID: 48199 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<string> GetPrefabPathsWithChildren(this Item item)
	{
		throw null;
	}

	// Token: 0x0600BC48 RID: 48200 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DependencyGraph<IEasyBundle>.GClass3388 GetAllBundleTokens(this Item item)
	{
		throw null;
	}

	// Token: 0x0600BC49 RID: 48201 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetTruncatedWeightString(this Item item)
	{
		throw null;
	}

	// Token: 0x0600BC4A RID: 48202 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetRandomAnimationVariant(this Item item)
	{
		throw null;
	}

	// Token: 0x0600BC4B RID: 48203 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsChildOf(this Item item, Item possibleParent)
	{
		throw null;
	}

	// Token: 0x0600BC4C RID: 48204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ParentRecursiveCheck(this Item item, [NotNull] Item containerItem)
	{
		throw null;
	}

	// Token: 0x0600BC4D RID: 48205 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Contains(this LootItemClass container, Item item)
	{
		throw null;
	}

	// Token: 0x0600BC4E RID: 48206 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IncompatibleByMalfunction(this Weapon weapon, Item mod)
	{
		throw null;
	}

	// Token: 0x0600BC4F RID: 48207 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T smethod_1<T>(T originalItem, GInterface319 idGenerator = null, bool skipInvisibleContent = false, bool resetSpawnedInSession = false) where T : Item
	{
		throw null;
	}

	// Token: 0x020024B5 RID: 9397
	private sealed class Class2083 : GInterface319
	{
		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x0600BC50 RID: 48208 RVA: 0x00002050 File Offset: 0x00000250
		public MongoID NextId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600BC51 RID: 48209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RollBack()
		{
			throw null;
		}

		// Token: 0x0400BEFF RID: 48895
		public static GClass2751.Class2083 Instance;
	}

	// Token: 0x020024BD RID: 9405
	[CompilerGenerated]
	private sealed class Class2091
	{
		// Token: 0x0600BC83 RID: 48259 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ContainerCollection containerCollection)
		{
			throw null;
		}

		// Token: 0x0400BF38 RID: 48952
		public Item rootItem;
	}

	// Token: 0x020024C2 RID: 9410
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2096
	{
		// Token: 0x0600BC99 RID: 48281 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(Item x)
		{
			throw null;
		}

		// Token: 0x0400BF56 RID: 48982
		public static readonly GClass2751.Class2096 class2096_0;

		// Token: 0x0400BF57 RID: 48983
		public static Func<Item, string> func_0;
	}

	// Token: 0x020024C3 RID: 9411
	[CompilerGenerated]
	private sealed class Class2097
	{
		// Token: 0x0600BC9A RID: 48282 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item parentItem)
		{
			throw null;
		}

		// Token: 0x0400BF58 RID: 48984
		public LootItemClass container;
	}
}
