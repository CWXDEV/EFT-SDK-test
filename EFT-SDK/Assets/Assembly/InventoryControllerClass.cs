using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02002465 RID: 9317
public class InventoryControllerClass : GClass2755, IContainer, GInterface311, GInterface313, IItemOwner
{
	// Token: 0x140002A0 RID: 672
	// (add) Token: 0x0600BB27 RID: 47911 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BB28 RID: 47912 RVA: 0x00002050 File Offset: 0x00000250
	public event Action CriticalInventoryErrorHappened
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140002A1 RID: 673
	// (add) Token: 0x0600BB29 RID: 47913 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BB2A RID: 47914 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<int> OnAmmoLoaded
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140002A2 RID: 674
	// (add) Token: 0x0600BB2B RID: 47915 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BB2C RID: 47916 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<int> OnAmmoUnloaded
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140002A3 RID: 675
	// (add) Token: 0x0600BB2D RID: 47917 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BB2E RID: 47918 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnMagazineCheck
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140002A4 RID: 676
	// (add) Token: 0x0600BB2F RID: 47919 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BB30 RID: 47920 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Weapon> ExamineMalfunctionEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1700215A RID: 8538
	// (get) Token: 0x0600BB31 RID: 47921 RVA: 0x00002050 File Offset: 0x00000250
	public virtual Item ItemInHands
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700215B RID: 8539
	// (get) Token: 0x0600BB32 RID: 47922 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2515 FastAccess
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700215C RID: 8540
	// (get) Token: 0x0600BB33 RID: 47923 RVA: 0x00002050 File Offset: 0x00000250
	public override bool CanSearch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700215D RID: 8541
	// (get) Token: 0x0600BB34 RID: 47924 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600BB35 RID: 47925 RVA: 0x00002050 File Offset: 0x00000250
	public Inventory Inventory
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700215E RID: 8542
	// (get) Token: 0x0600BB36 RID: 47926 RVA: 0x00002050 File Offset: 0x00000250
	public virtual GInterface312 Profile
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700215F RID: 8543
	// (get) Token: 0x0600BB37 RID: 47927 RVA: 0x00002050 File Offset: 0x00000250
	public override LootItemClass Root
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002160 RID: 8544
	// (get) Token: 0x0600BB38 RID: 47928 RVA: 0x00002050 File Offset: 0x00000250
	public Item[] ContainedItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002161 RID: 8545
	// (get) Token: 0x0600BB39 RID: 47929 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<LootItemClass> EquipmentItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002162 RID: 8546
	// (get) Token: 0x0600BB3A RID: 47930 RVA: 0x00002050 File Offset: 0x00000250
	public bool SortingTableActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BB3B RID: 47931 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_27(Inventory newInventory)
	{
		throw null;
	}

	// Token: 0x0600BB3C RID: 47932 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Item FindItem(string itemId)
	{
		throw null;
	}

	// Token: 0x0600BB3D RID: 47933 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GClass2765 FindQuestGridToPickUp(Item item)
	{
		throw null;
	}

	// Token: 0x0600BB3E RID: 47934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsInventoryBlocked()
	{
		throw null;
	}

	// Token: 0x0600BB3F RID: 47935 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsAllowedToSeeSlot(Slot slot, EquipmentSlot slotName)
	{
		throw null;
	}

	// Token: 0x0600BB40 RID: 47936 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsAllowedToSort(LootItemClass item)
	{
		throw null;
	}

	// Token: 0x0600BB41 RID: 47937 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HasCultistAmulet(out GClass2712 amulet)
	{
		throw null;
	}

	// Token: 0x0600BB42 RID: 47938 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsAtBindablePlace(Item item)
	{
		throw null;
	}

	// Token: 0x0600BB43 RID: 47939 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInAnimatedSlot(Item item)
	{
		throw null;
	}

	// Token: 0x0600BB44 RID: 47940 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsAtReachablePlace(Item item)
	{
		throw null;
	}

	// Token: 0x0600BB45 RID: 47941 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<bool> method_28(ETraderServiceType serviceType, AbstractQuestControllerClass questController, string subServiceId = null)
	{
		throw null;
	}

	// Token: 0x0600BB46 RID: 47942 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool IsRootAddressIsStash(ItemAddress location)
	{
		throw null;
	}

	// Token: 0x0600BB47 RID: 47943 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task<IResult> UnloadMagazine(MagazineClass magazine)
	{
		throw null;
	}

	// Token: 0x0600BB48 RID: 47944 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> UnloadAmmoInstantly<TContainer>(TContainer ammoContainer) where TContainer : Item, IAmmoContainer
	{
		throw null;
	}

	// Token: 0x0600BB49 RID: 47945 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnbindItem(EBoundItem boundItemIndex, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x0600BB4A RID: 47946 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct413<GClass2799> UnbindItemDirect(Item item, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BB4B RID: 47947 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanStartNewSearchOperation()
	{
		throw null;
	}

	// Token: 0x0600BB4C RID: 47948 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SearchContents(SearchableItemClass searchableItem, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x0600BB4D RID: 47949 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartSearchingAction(SearchableItemClass item)
	{
		throw null;
	}

	// Token: 0x0600BB4E RID: 47950 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StopSearchingAction(SearchableItemClass item)
	{
		throw null;
	}

	// Token: 0x0600BB4F RID: 47951 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetupItem(Item item, string zone, Vector3 position, Quaternion rotation, float setupTime, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x0600BB50 RID: 47952 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Forget(string itemId)
	{
		throw null;
	}

	// Token: 0x0600BB51 RID: 47953 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Examine(Item item, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x0600BB52 RID: 47954 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnAmmoLoadedCall(int count)
	{
		throw null;
	}

	// Token: 0x0600BB53 RID: 47955 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnAmmoUnloadedCall(int count)
	{
		throw null;
	}

	// Token: 0x0600BB54 RID: 47956 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnMagazineCheckCall()
	{
		throw null;
	}

	// Token: 0x0600BB55 RID: 47957 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CheckedChamber(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x0600BB56 RID: 47958 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CheckChamber(Weapon weapon, bool status)
	{
		throw null;
	}

	// Token: 0x0600BB57 RID: 47959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetStackMaxSizeFor(Item item)
	{
		throw null;
	}

	// Token: 0x0600BB58 RID: 47960 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsLimitedAtAddress(string templateId, ItemAddress address, out int limit)
	{
		throw null;
	}

	// Token: 0x0600BB59 RID: 47961 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsLimitedAtAddress(Item item, [CanBeNull] ItemAddress address, out int limit)
	{
		throw null;
	}

	// Token: 0x0600BB5A RID: 47962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CheckOverLimit(IEnumerable<Item> items, [CanBeNull] ItemAddress to, bool useItemCountInEquipment, out GClass2770.GClass3339 error)
	{
		throw null;
	}

	// Token: 0x0600BB5B RID: 47963 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_29(string templateId)
	{
		throw null;
	}

	// Token: 0x0600BB5C RID: 47964 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IResult CheckInRaidItemsRestrictions()
	{
		throw null;
	}

	// Token: 0x0600BB5D RID: 47965 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void NotifyMagazineChecked(string name)
	{
		throw null;
	}

	// Token: 0x0600BB5E RID: 47966 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_30(MagazineClass magazine, bool status, int skill, bool useOperation = true, bool notify = true)
	{
		throw null;
	}

	// Token: 0x0600BB5F RID: 47967 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public new bool Examined(Item item)
	{
		throw null;
	}

	// Token: 0x0600BB60 RID: 47968 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasKnownMalfunction(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x0600BB61 RID: 47969 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasKnownMalfType(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x0600BB62 RID: 47970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExamineMalfunction(Weapon weapon, bool clearRest = false)
	{
		throw null;
	}

	// Token: 0x0600BB63 RID: 47971 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExamineMalfunctionType(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x0600BB64 RID: 47972 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CallUnknownMalfunctionStartRepair(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x0600BB65 RID: 47973 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CallMalfunctionRepaired(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x0600BB66 RID: 47974 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ProcessFastWeaponSwitchAvailability()
	{
		throw null;
	}

	// Token: 0x0600BB67 RID: 47975 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckedMagazine(MagazineClass magazine)
	{
		throw null;
	}

	// Token: 0x0600BB68 RID: 47976 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InventoryCheckMagazine(MagazineClass magazine, bool notify)
	{
		throw null;
	}

	// Token: 0x0600BB69 RID: 47977 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Examined(string item)
	{
		throw null;
	}

	// Token: 0x0600BB6A RID: 47978 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSearchedRaiseEvents(Item item, GClass2765 gridItemAddress, bool silent = false)
	{
		throw null;
	}

	// Token: 0x0600BB6B RID: 47979 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StopSearching(string itemId)
	{
		throw null;
	}

	// Token: 0x0600BB6C RID: 47980 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StopSearching(LootItemClass item)
	{
		throw null;
	}

	// Token: 0x0600BB6D RID: 47981 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task<bool> TryPurchaseTraderService(ETraderServiceType serviceType, AbstractQuestControllerClass questController, string subServiceId = null)
	{
		throw null;
	}

	// Token: 0x0600BB6E RID: 47982 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetTraderServicesDataFromServer(string traderId)
	{
		throw null;
	}

	// Token: 0x0600BB6F RID: 47983 RVA: 0x00002050 File Offset: 0x00000250
	[Obsolete("Use GetReachableItemsOfTypeNonAlloc instead")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<TItem> GetReachableItemsOfType<TItem>(Func<TItem, bool> predicate = null) where TItem : Item
	{
		throw null;
	}

	// Token: 0x0600BB70 RID: 47984 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetReachableItemsOfTypeNonAlloc<TItem>([NotNull] IList<TItem> preAllocatedList, Func<TItem, bool> predicate = null) where TItem : Item
	{
		throw null;
	}

	// Token: 0x0600BB71 RID: 47985 RVA: 0x00002050 File Offset: 0x00000250
	[Obsolete("Use GetAcceptableItemsNonAlloc instead")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<TItem> GetAcceptableItems<TItem>([NotNull] EquipmentSlot[] equipmentSlots, Func<TItem, bool> predicate = null) where TItem : Item
	{
		throw null;
	}

	// Token: 0x0600BB72 RID: 47986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetAcceptableItemsNonAlloc<TItem>([NotNull] EquipmentSlot[] equipmentSlots, [NotNull] IList<TItem> preAllocatedList, Func<TItem, bool> predicate = null) where TItem : Item
	{
		throw null;
	}

	// Token: 0x0600BB73 RID: 47987 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	int IContainer.GetHashSum()
	{
		throw null;
	}

	// Token: 0x0600BB74 RID: 47988 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetExamined(bool value)
	{
		throw null;
	}

	// Token: 0x0600BB75 RID: 47989 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseCriticalError()
	{
		throw null;
	}

	// Token: 0x0600BB76 RID: 47990 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvent(GEventArgs10 args)
	{
		throw null;
	}

	// Token: 0x0600BB77 RID: 47991 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvent(GEventArgs11 args)
	{
		throw null;
	}

	// Token: 0x0600BB78 RID: 47992 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvent(GEventArgs4 args)
	{
		throw null;
	}

	// Token: 0x0600BB79 RID: 47993 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvent(GEventArgs5 args)
	{
		throw null;
	}

	// Token: 0x0600BB7A RID: 47994 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RaiseBindItemEvent(GEventArgs12 args)
	{
		throw null;
	}

	// Token: 0x0600BB7B RID: 47995 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RaiseUnbindItemEvent(GEventArgs13 args)
	{
		throw null;
	}

	// Token: 0x0600BB7C RID: 47996 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public new void RaiseInsureItemsEvent(GEventArgs21 args)
	{
		throw null;
	}

	// Token: 0x0400BDA7 RID: 48551
	private static readonly EquipmentSlot[] equipmentSlot_0;

	// Token: 0x0400BDA8 RID: 48552
	private static readonly EquipmentSlot[] equipmentSlot_1;

	// Token: 0x0400BDA9 RID: 48553
	private static readonly EquipmentSlot[] equipmentSlot_2;

	// Token: 0x0400BDAA RID: 48554
	[CompilerGenerated]
	private Action action_13;

	// Token: 0x0400BDAB RID: 48555
	[CompilerGenerated]
	private Action<int> action_14;

	// Token: 0x0400BDAC RID: 48556
	[CompilerGenerated]
	private Action<int> action_15;

	// Token: 0x0400BDAD RID: 48557
	[CompilerGenerated]
	private Action action_16;

	// Token: 0x0400BDAE RID: 48558
	[CompilerGenerated]
	private Action<Weapon> action_17;

	// Token: 0x0400BDAF RID: 48559
	private readonly Dictionary<string, int> dictionary_0;

	// Token: 0x0400BDB0 RID: 48560
	private bool bool_2;

	// Token: 0x0400BDB1 RID: 48561
	private bool bool_3;

	// Token: 0x0400BDB2 RID: 48562
	public readonly GClass3357<GClass2865> SearchOperations;

	// Token: 0x0400BDB3 RID: 48563
	[CompilerGenerated]
	private Inventory inventory_0;

	// Token: 0x0400BDB4 RID: 48564
	[CompilerGenerated]
	private readonly GInterface312 ginterface312_0;

	// Token: 0x02002466 RID: 9318
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2061
	{
		// Token: 0x0600BB7D RID: 47997 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_0(Slot x)
		{
			throw null;
		}

		// Token: 0x0600BB7E RID: 47998 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(BackendConfigSettingsClass.GClass1366 restriction)
		{
			throw null;
		}

		// Token: 0x0600BB7F RID: 47999 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_2(BackendConfigSettingsClass.GClass1366 restriction)
		{
			throw null;
		}

		// Token: 0x0600BB80 RID: 48000 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_3(Item selecting)
		{
			throw null;
		}

		// Token: 0x0600BB81 RID: 48001 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_4(Item x)
		{
			throw null;
		}

		// Token: 0x0600BB82 RID: 48002 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_5(Item x)
		{
			throw null;
		}

		// Token: 0x0400BDB5 RID: 48565
		public static readonly InventoryControllerClass.Class2061 class2061_0;

		// Token: 0x0400BDB6 RID: 48566
		public static Func<Slot, Item> func_0;

		// Token: 0x0400BDB7 RID: 48567
		public static Func<BackendConfigSettingsClass.GClass1366, string> func_1;

		// Token: 0x0400BDB8 RID: 48568
		public static Func<BackendConfigSettingsClass.GClass1366, int> func_2;

		// Token: 0x0400BDB9 RID: 48569
		public static Func<Item, string> func_3;

		// Token: 0x0400BDBA RID: 48570
		public static Func<Item, int> func_4;

		// Token: 0x0400BDBB RID: 48571
		public static Func<Item, int> func_5;
	}

	// Token: 0x02002468 RID: 9320
	[CompilerGenerated]
	private sealed class Class2063
	{
		// Token: 0x0600BB88 RID: 48008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Slot method_0(EquipmentSlot slotType)
		{
			throw null;
		}

		// Token: 0x0600BB89 RID: 48009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Slot slot)
		{
			throw null;
		}

		// Token: 0x0400BDC2 RID: 48578
		public InventoryControllerClass gclass2757_0;

		// Token: 0x0400BDC3 RID: 48579
		public Slot parentSlot;
	}

	// Token: 0x0200246B RID: 9323
	[CompilerGenerated]
	private sealed class Class2064
	{
		// Token: 0x0600BB8E RID: 48014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<EBoundItem, Item> x)
		{
			throw null;
		}

		// Token: 0x0400BDD5 RID: 48597
		public Item item;
	}

	// Token: 0x0200246C RID: 9324
	[CompilerGenerated]
	private sealed class Class2065
	{
		// Token: 0x0600BB8F RID: 48015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult error)
		{
			throw null;
		}

		// Token: 0x0400BDD6 RID: 48598
		public InventoryControllerClass gclass2757_0;

		// Token: 0x0400BDD7 RID: 48599
		public GClass2865 searchContentOperation;

		// Token: 0x0400BDD8 RID: 48600
		public SearchableItemClass searchableItem;

		// Token: 0x0400BDD9 RID: 48601
		public Callback callback;
	}

	// Token: 0x0200246D RID: 9325
	[CompilerGenerated]
	private sealed class Class2066
	{
		// Token: 0x0600BB90 RID: 48016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult examineResult)
		{
			throw null;
		}

		// Token: 0x0600BB91 RID: 48017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(IResult result)
		{
			throw null;
		}

		// Token: 0x0400BDDA RID: 48602
		public InventoryControllerClass gclass2757_0;

		// Token: 0x0400BDDB RID: 48603
		public GClass2853 operation;

		// Token: 0x0400BDDC RID: 48604
		public Callback callback;

		// Token: 0x0400BDDD RID: 48605
		public Callback callback_0;
	}

	// Token: 0x0200246E RID: 9326
	[CompilerGenerated]
	private sealed class Class2067
	{
		// Token: 0x0600BB92 RID: 48018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item x)
		{
			throw null;
		}

		// Token: 0x0400BDDE RID: 48606
		public string templateId;
	}

	// Token: 0x0200246F RID: 9327
	[CompilerGenerated]
	private sealed class Class2068
	{
		// Token: 0x0600BB93 RID: 48019 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult arg)
		{
			throw null;
		}

		// Token: 0x0400BDDF RID: 48607
		public MagazineClass magazine;

		// Token: 0x0400BDE0 RID: 48608
		public bool status;
	}

	// Token: 0x02002470 RID: 9328
	[CompilerGenerated]
	private sealed class Class2069
	{
		// Token: 0x0600BB94 RID: 48020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2865 x)
		{
			throw null;
		}

		// Token: 0x0400BDE1 RID: 48609
		public string itemId;
	}

	// Token: 0x02002471 RID: 9329
	[CompilerGenerated]
	private sealed class Class2070<T> where T : Item
	{
		// Token: 0x0600BB95 RID: 48021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item i)
		{
			throw null;
		}

		// Token: 0x0400BDE2 RID: 48610
		public string[] gridItemIds;
	}

	// Token: 0x02002472 RID: 9330
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2071<TItem> where TItem : Item
	{
		// Token: 0x0600BB96 RID: 48022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(Item i)
		{
			throw null;
		}

		// Token: 0x0400BDE3 RID: 48611
		public static readonly InventoryControllerClass.Class2071<TItem> class2071_0;

		// Token: 0x0400BDE4 RID: 48612
		public static Func<Item, string> func_0;
	}
}
