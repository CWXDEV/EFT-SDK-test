using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ChatShared;
using Comfort.Common;
using EFT.HealthSystem;
using EFT.Hideout;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Builds;
using EFT.UI.DragAndDrop;
using EFT.UI.Insurance;
using EFT.UI.Ragfair;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002A39 RID: 10809
	[UsedImplicitly]
	public sealed class ItemUiContext : UIInputNode
	{
		// Token: 0x140002ED RID: 749
		// (add) Token: 0x0600D6B2 RID: 54962 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D6B3 RID: 54963 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Weapon> OnShowWeaponBuilds
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

		// Token: 0x0600D6B4 RID: 54964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GStruct414> ApplyMagPreset(GClass2089 preset, IReadOnlyCollection<MagazineClass> magazines)
		{
			throw null;
		}

		// Token: 0x0600D6B5 RID: 54965 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Inspect(GClass2809 itemContext, GClass3021<EItemInfoButton> contextInteractions)
		{
			throw null;
		}

		// Token: 0x0600D6B6 RID: 54966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, int> FindCompatibleAmmo(MagazineClass magazine)
		{
			throw null;
		}

		// Token: 0x0600D6B7 RID: 54967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task LoadAmmoByType(MagazineClass magazine, string ammoTemplateId, Action callback = null)
		{
			throw null;
		}

		// Token: 0x0600D6B8 RID: 54968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckMagazine(MagazineClass magazine)
		{
			throw null;
		}

		// Token: 0x0600D6B9 RID: 54969 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TopUpItem(Item targetItem)
		{
			throw null;
		}

		// Token: 0x0600D6BA RID: 54970 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> UnpackItem(Item targetItem)
		{
			throw null;
		}

		// Token: 0x0600D6BB RID: 54971 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasSourcesForTopUp(Item targetItem)
		{
			throw null;
		}

		// Token: 0x0600D6BC RID: 54972 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Examine(Item item, Action callback = null)
		{
			throw null;
		}

		// Token: 0x0600D6BD RID: 54973 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExternalRagfairSearch(GClass3195 ragfairSearch)
		{
			throw null;
		}

		// Token: 0x0600D6BE RID: 54974 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsInWishList(string templateId)
		{
			throw null;
		}

		// Token: 0x0600D6BF RID: 54975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddToWishList(Item item, Action callback)
		{
			throw null;
		}

		// Token: 0x0600D6C0 RID: 54976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveFromWishList(Item item, Action callback)
		{
			throw null;
		}

		// Token: 0x0600D6C1 RID: 54977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddToFavorites(Item item, Action callback)
		{
			throw null;
		}

		// Token: 0x0600D6C2 RID: 54978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveFromFavorites(Item item, Action callback)
		{
			throw null;
		}

		// Token: 0x0600D6C3 RID: 54979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsInFavoritesList(Item item)
		{
			throw null;
		}

		// Token: 0x0600D6C4 RID: 54980 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EditWeaponBuild(Weapon weapon)
		{
			throw null;
		}

		// Token: 0x0600D6C5 RID: 54981 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Insure(ItemClass item)
		{
			throw null;
		}

		// Token: 0x0600D6C6 RID: 54982 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Uncover(ItemClass item)
		{
			throw null;
		}

		// Token: 0x0600D6C7 RID: 54983 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ModWeapon(Item item)
		{
			throw null;
		}

		// Token: 0x0600D6C8 RID: 54984 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EditTag(GClass2809 itemContext, TagComponent tagComponent)
		{
			throw null;
		}

		// Token: 0x0600D6C9 RID: 54985 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetTag(TagComponent tagComponent)
		{
			throw null;
		}

		// Token: 0x0600D6CA RID: 54986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> ToggleItem(TogglableComponent togglable)
		{
			throw null;
		}

		// Token: 0x0600D6CB RID: 54987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task ThrowItem(Item item)
		{
			throw null;
		}

		// Token: 0x0600D6CC RID: 54988 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Item item, EBoundItem bindIndex)
		{
			throw null;
		}

		// Token: 0x0600D6CD RID: 54989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInsuranceWindow(GClass2809 itemContext)
		{
			throw null;
		}

		// Token: 0x0600D6CE RID: 54990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenRepairWindow(GClass2087 repairController, GClass2809 itemContext)
		{
			throw null;
		}

		// Token: 0x0600D6CF RID: 54991 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UseItem(Item item)
		{
			throw null;
		}

		// Token: 0x0600D6D0 RID: 54992 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UseAll(Item item)
		{
			throw null;
		}

		// Token: 0x0600D6D1 RID: 54993 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HealAll(MedsClass meds)
		{
			throw null;
		}

		// Token: 0x0600D6D2 RID: 54994 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Uninstall(GClass2809 itemContext, bool putInStash = false)
		{
			throw null;
		}

		// Token: 0x0600D6D3 RID: 54995 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(IHealthController healthController, FoodClass foodDrink)
		{
			throw null;
		}

		// Token: 0x0600D6D4 RID: 54996 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task EquipItem(Item item)
		{
			throw null;
		}

		// Token: 0x0600D6D5 RID: 54997 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FoldItem(Item item)
		{
			throw null;
		}

		// Token: 0x0600D6D6 RID: 54998 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecodeItem(Item item)
		{
			throw null;
		}

		// Token: 0x0600D6D7 RID: 54999 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenItem(LootItemClass item, GClass2809 itemContext, bool searchButtonDisplay = true)
		{
			throw null;
		}

		// Token: 0x0600D6D8 RID: 55000 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass2809 itemContext, Action<GridWindow, Action, Action> showAction)
		{
			throw null;
		}

		// Token: 0x0600D6D9 RID: 55001 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_3(Weapon weapon)
		{
			throw null;
		}

		// Token: 0x0600D6DA RID: 55002 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task UnloadWeapon(Weapon weapon)
		{
			throw null;
		}

		// Token: 0x0600D6DB RID: 55003 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReloadWeapon(Weapon weapon, IEnumerable<LootItemClass> collections)
		{
			throw null;
		}

		// Token: 0x0600D6DC RID: 55004 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task LoadWeapon(Weapon weapon, LootItemClass[] collections)
		{
			throw null;
		}

		// Token: 0x0600D6DD RID: 55005 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task InstallMod(GClass2809 itemContext, LootItemClass[] collections)
		{
			throw null;
		}

		// Token: 0x0600D6DE RID: 55006 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task UnloadAmmo(Item item)
		{
			throw null;
		}

		// Token: 0x0600D6DF RID: 55007 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Disassemble(GClass2809 itemContext)
		{
			throw null;
		}

		// Token: 0x0600D6E0 RID: 55008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<GStruct412> method_4(GClass2809 itemContext, bool simulate)
		{
			throw null;
		}

		// Token: 0x0600D6E1 RID: 55009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task QuickEquip(Item item)
		{
			throw null;
		}

		// Token: 0x0600D6E2 RID: 55010 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<IResult> RunWithSound(TraderControllerClass itemController, Item item, GStruct412 operationResult, [CanBeNull] Callback callback = null)
		{
			throw null;
		}

		// Token: 0x0600D6E3 RID: 55011 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PlayOperationSound(Item item, GInterface321 operationResult)
		{
			throw null;
		}

		// Token: 0x0600D6E4 RID: 55012 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct412 QuickFindAppropriatePlace(GClass2809 itemContext, TraderControllerClass controller, bool forcePutInStash = false, bool displayWarnings = true, bool simulate = true)
		{
			throw null;
		}

		// Token: 0x0600D6E5 RID: 55013 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task QuickMoveFromSortingTable(GClass2759 controller)
		{
			throw null;
		}

		// Token: 0x0600D6E6 RID: 55014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct412 QuickMoveToSortingTable(Item item, bool simulate = true)
		{
			throw null;
		}

		// Token: 0x0600D6E7 RID: 55015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private MagazineClass method_5(Slot magazineSlot, IEnumerable<LootItemClass> collections)
		{
			throw null;
		}

		// Token: 0x0600D6E8 RID: 55016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3021<EItemInfoButton> GetItemContextInteractions(GClass2809 itemContext, Action closeAction)
		{
			throw null;
		}

		// Token: 0x0600D6E9 RID: 55017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ItemView CreateSlotItemView(Item item, GClass2809 sourceContext, TraderControllerClass inventoryController, IItemOwner itemOwner, SkillManager skills)
		{
			throw null;
		}

		// Token: 0x0600D6EA RID: 55018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ItemView CreateItemView(Item item, GClass2809 sourceContext, ItemRotation rotation, TraderControllerClass itemController, IItemOwner itemOwner, FilterPanel filterPanel, GInterface376 container, bool slotView, bool canSelect, bool searched)
		{
			throw null;
		}

		// Token: 0x140002EE RID: 750
		// (add) Token: 0x0600D6EB RID: 55019 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D6EC RID: 55020 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<IEnumerable<string>> OnContextMenuRedraw
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

		// Token: 0x140002EF RID: 751
		// (add) Token: 0x0600D6ED RID: 55021 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D6EE RID: 55022 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<IEnumerable<string>> OnContextMenuClose
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

		// Token: 0x140002F0 RID: 752
		// (add) Token: 0x0600D6EF RID: 55023 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D6F0 RID: 55024 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<IEffect> OnEffectsChange
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

		// Token: 0x140002F1 RID: 753
		// (add) Token: 0x0600D6F1 RID: 55025 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D6F2 RID: 55026 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool> OnInventoryLocked
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

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x0600D6F3 RID: 55027 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D6F4 RID: 55028 RVA: 0x00002050 File Offset: 0x00000250
		public static ItemUiContext Instance
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

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x0600D6F5 RID: 55029 RVA: 0x00002050 File Offset: 0x00000250
		public RectTransform ContextMenuArea
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x0600D6F6 RID: 55030 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D6F7 RID: 55031 RVA: 0x00002050 File Offset: 0x00000250
		public GClass3052 ContextInteractionsSwitcher
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

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x0600D6F8 RID: 55032 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D6F9 RID: 55033 RVA: 0x00002050 File Offset: 0x00000250
		public ISession Session
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

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x0600D6FA RID: 55034 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D6FB RID: 55035 RVA: 0x00002050 File Offset: 0x00000250
		public EItemUiContextType ContextType
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

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x0600D6FC RID: 55036 RVA: 0x00002050 File Offset: 0x00000250
		public bool SortAvailable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x0600D6FD RID: 55037 RVA: 0x00002050 File Offset: 0x00000250
		public SplitDialog SplitDialog
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x0600D6FE RID: 55038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D6FF RID: 55039 RVA: 0x00002050 File Offset: 0x00000250
		private GClass2809 GClass2809_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x0600D700 RID: 55040 RVA: 0x00002050 File Offset: 0x00000250
		public SimpleContextMenu ContextMenu
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x0600D701 RID: 55041 RVA: 0x00002050 File Offset: 0x00000250
		public WeaponPreviewPool WeaponPreviewPool
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x0600D702 RID: 55042 RVA: 0x00002050 File Offset: 0x00000250
		public SimpleTooltip Tooltip
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x0600D703 RID: 55043 RVA: 0x00002050 File Offset: 0x00000250
		public ItemTooltip ItemTooltip
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x0600D704 RID: 55044 RVA: 0x00002050 File Offset: 0x00000250
		public PriceTooltip PriceTooltip
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x0600D705 RID: 55045 RVA: 0x00002050 File Offset: 0x00000250
		public ItemsListWindow ItemsListWindow
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x0600D706 RID: 55046 RVA: 0x00002050 File Offset: 0x00000250
		public SkillTooltip SkillTooltip
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x0600D707 RID: 55047 RVA: 0x00002050 File Offset: 0x00000250
		public MasteringTooltip MasteringTooltip
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x0600D708 RID: 55048 RVA: 0x00002050 File Offset: 0x00000250
		public MultiLineTooltip MultiLineTooltip
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x0600D709 RID: 55049 RVA: 0x00002050 File Offset: 0x00000250
		public TaskRewardsTooltip TaskRewardsTooltip
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x0600D70A RID: 55050 RVA: 0x00002050 File Offset: 0x00000250
		public TaskConditionsTooltip TaskConditionsTooltip
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x0600D70B RID: 55051 RVA: 0x00002050 File Offset: 0x00000250
		public AchievementGlobalProgressTooltip AchievementGlobalProgressTooltip
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x0600D70C RID: 55052 RVA: 0x00002050 File Offset: 0x00000250
		public HandoverExchangeableItemsWindow HandoverItemsWindow
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x0600D70D RID: 55053 RVA: 0x00002050 File Offset: 0x00000250
		public HandoverQuestItemsWindow HandoverQuestItemsWindow
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x0600D70E RID: 55054 RVA: 0x00002050 File Offset: 0x00000250
		public bool MessageWindowActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x0600D70F RID: 55055 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x0600D710 RID: 55056 RVA: 0x00002050 File Offset: 0x00000250
		private LootItemClass[] GClass2625_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D711 RID: 55057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Init(ItemUiContext instance)
		{
			throw null;
		}

		// Token: 0x0600D712 RID: 55058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600D713 RID: 55059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Configure(InventoryControllerClass inventoryController, Profile profile, ISession backEndSession, InsuranceCompanyClass insurance, [CanBeNull] RagFairClass ragfair, [CanBeNull] TraderClass trader, IHealthController healthController, [CanBeNull] LootItemClass[] rightPanelItems, EItemUiContextType contextType, ECursorResult contextCursor)
		{
			throw null;
		}

		// Token: 0x0600D714 RID: 55060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RedrawContextMenus(IEnumerable<string> templateIds)
		{
			throw null;
		}

		// Token: 0x0600D715 RID: 55061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowContextMenu(GClass2809 itemContext, Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600D716 RID: 55062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSpecificationPanel(ItemSpecificationPanel panel, GClass2809 itemContext, GClass3021<EItemInfoButton> contextInteractions)
		{
			throw null;
		}

		// Token: 0x0600D717 RID: 55063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> ShowMessageWindow(out GClass3087 windowContext, string description, string caption = null, bool forceShow = false)
		{
			throw null;
		}

		// Token: 0x0600D718 RID: 55064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3087 ShowMessageWindow(string description, [CanBeNull] Action acceptAction, Action cancelAction = null, string caption = null, float time = 0f, bool forceShow = false, TextAlignmentOptions alignment = TextAlignmentOptions.Center)
		{
			throw null;
		}

		// Token: 0x0600D719 RID: 55065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3087 ShowInviteInGroupWindow(GClass1210 groupInvite)
		{
			throw null;
		}

		// Token: 0x0600D71A RID: 55066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3087 ShowInviteInRaidWindow(ISession session, RaidSettings raidSettings, GClass2760 inventoryController, GClass1206 player)
		{
			throw null;
		}

		// Token: 0x0600D71B RID: 55067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CaptchaHandler ShowCaptchaHandler()
		{
			throw null;
		}

		// Token: 0x0600D71C RID: 55068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3085 ShowMissingItemsWindow(IReadOnlyCollection<Item> outOfCollectionItems, IReadOnlyCollection<Item> itemsInBuild, bool canUseAllItems, Action onIgnoreClicked, Action<bool> onBuyClicked)
		{
			throw null;
		}

		// Token: 0x0600D71D RID: 55069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3085 ShowMagPresetsWindow(GClass2819 itemContext, MongoID? presetId = null)
		{
			throw null;
		}

		// Token: 0x0600D71E RID: 55070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3089 ShowEditBuildNameWindow(string savedName, string caption, string placeholderText)
		{
			throw null;
		}

		// Token: 0x0600D71F RID: 55071 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> ShowScrolledMessageWindow(out GClass3087 windowContext, string description, string caption = null, bool forceShow = false)
		{
			throw null;
		}

		// Token: 0x0600D720 RID: 55072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3087 ShowScrolledMessageWindow(string description, [CanBeNull] Action acceptAction, Action cancelAction = null, string caption = null, float time = 0f, bool forceShow = false)
		{
			throw null;
		}

		// Token: 0x0600D721 RID: 55073 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GClass3087 method_7(MessageWindow windowTemplate, string description, [CanBeNull] Action acceptAction, Action cancelAction = null, string caption = null, float time = 0f, bool forceShow = false)
		{
			throw null;
		}

		// Token: 0x0600D722 RID: 55074 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterView(GClass2809 itemContext)
		{
			throw null;
		}

		// Token: 0x0600D723 RID: 55075 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600D724 RID: 55076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnregisterView(GClass2809 itemContext)
		{
			throw null;
		}

		// Token: 0x0600D725 RID: 55077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600D726 RID: 55078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(GEventArgs1 activeEvent)
		{
			throw null;
		}

		// Token: 0x0600D727 RID: 55079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600D728 RID: 55080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(bool locked)
		{
			throw null;
		}

		// Token: 0x0600D729 RID: 55081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12<T>(GClass2809 itemContext, T template, Action<T, Action, Action> show) where T : Window<GClass3085>, IShowable
		{
			throw null;
		}

		// Token: 0x0600D72A RID: 55082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(ItemUiContext.Class2500 data)
		{
			throw null;
		}

		// Token: 0x0600D72B RID: 55083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3087 ShowChangeQuestConfirm(GStruct396 arguments)
		{
			throw null;
		}

		// Token: 0x0600D72C RID: 55084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3085 ShowPlayersInviteWindow(string profileId, GClass3357<UpdatableChatMember> friendsList, GClass3166 matchmakerPlayersController)
		{
			throw null;
		}

		// Token: 0x0600D72D RID: 55085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3085 ShowEquipItemWindow(Slot slot, Vector3 position)
		{
			throw null;
		}

		// Token: 0x0600D72E RID: 55086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowClothingConfirmation(string suiteName, Profile profile, Profile.TraderInfo trader, GClass3359 quests, GClass2939 requirements, GClass2495 stashGrid, Action unlockAction)
		{
			throw null;
		}

		// Token: 0x0600D72F RID: 55087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(InputNode window, ItemUiContext.Class2500 windowData)
		{
			throw null;
		}

		// Token: 0x0600D730 RID: 55088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ItemUiContext.Class2500 method_15<T>(Window<T> window) where T : GClass3085, new()
		{
			throw null;
		}

		// Token: 0x0600D731 RID: 55089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private T method_16<T>(Window<T> window, T context) where T : GClass3085, new()
		{
			throw null;
		}

		// Token: 0x0600D732 RID: 55090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D733 RID: 55091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600D734 RID: 55092 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600D735 RID: 55093 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterCurrentItemContext(GClass2809 itemContext)
		{
			throw null;
		}

		// Token: 0x0600D736 RID: 55094 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnregisterCurrentItemContext(GClass2809 itemContext)
		{
			throw null;
		}

		// Token: 0x0600D737 RID: 55095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<ValueTuple<Item, bool>> SelectItem(IEnumerable<Item> availableItems, Func<Item, string> getDetails, bool showEmptyCell, SelectingItemView itemTemplate, RectTransform elementPosition, Vector2 offset, EContextPriorDirection direction = EContextPriorDirection.BottomRightToLeft)
		{
			throw null;
		}

		// Token: 0x0600D738 RID: 55096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseSelectItemMenu()
		{
			throw null;
		}

		// Token: 0x0600D739 RID: 55097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseAllWindows()
		{
			throw null;
		}

		// Token: 0x0600D73A RID: 55098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17()
		{
			throw null;
		}

		// Token: 0x0600D73B RID: 55099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D73C RID: 55100 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_18(Mod x)
		{
			throw null;
		}

		// Token: 0x0400D930 RID: 55600
		private const string string_0 = "MagPreset/LoadingComplete";

		// Token: 0x0400D931 RID: 55601
		[CompilerGenerated]
		private Action<Weapon> action_0;

		// Token: 0x0400D932 RID: 55602
		[SerializeField]
		private RectTransform _contextMenuArea;

		// Token: 0x0400D933 RID: 55603
		[SerializeField]
		private SimpleTooltip _simpleTooltip;

		// Token: 0x0400D934 RID: 55604
		[SerializeField]
		private ItemTooltip _itemTooltip;

		// Token: 0x0400D935 RID: 55605
		[SerializeField]
		private PriceTooltip _priceTooltip;

		// Token: 0x0400D936 RID: 55606
		[SerializeField]
		private SkillTooltip _skillTooltip;

		// Token: 0x0400D937 RID: 55607
		[SerializeField]
		private MasteringTooltip _masteringTooltip;

		// Token: 0x0400D938 RID: 55608
		[SerializeField]
		private MultiLineTooltip _multiLineTooltip;

		// Token: 0x0400D939 RID: 55609
		[SerializeField]
		private TaskRewardsTooltip _taskRewardsTooltip;

		// Token: 0x0400D93A RID: 55610
		[SerializeField]
		private TaskConditionsTooltip _taskConditionsTooltip;

		// Token: 0x0400D93B RID: 55611
		[SerializeField]
		private AchievementGlobalProgressTooltip _achievementGlobalProgressTooltip;

		// Token: 0x0400D93C RID: 55612
		[SerializeField]
		private RectTransform _infoWindowsContainer;

		// Token: 0x0400D93D RID: 55613
		[SerializeField]
		private SelectItemContextMenu _selectItemMenu;

		// Token: 0x0400D93E RID: 55614
		[SerializeField]
		private RepairWindow _repairWindowTemplate;

		// Token: 0x0400D93F RID: 55615
		[SerializeField]
		private InsuranceWindow _insuranceWindowTemplate;

		// Token: 0x0400D940 RID: 55616
		[SerializeField]
		private ItemsListWindow _itemsListWindow;

		// Token: 0x0400D941 RID: 55617
		[SerializeField]
		private SplitDialog _splitDialogTemplate;

		// Token: 0x0400D942 RID: 55618
		[SerializeField]
		private InfoWindow _infoWindowTemplate;

		// Token: 0x0400D943 RID: 55619
		[SerializeField]
		private MessageWindow _messageWindow;

		// Token: 0x0400D944 RID: 55620
		[SerializeField]
		private MessageWindow _scrolledMessageWindow;

		// Token: 0x0400D945 RID: 55621
		[SerializeField]
		private GroupInviteWindow _groupInviteWindow;

		// Token: 0x0400D946 RID: 55622
		[SerializeField]
		private RaidInviteWindow _raidInviteWindow;

		// Token: 0x0400D947 RID: 55623
		[SerializeField]
		private AcceptQuestChangeWindow _acceptQuestChangeWindow;

		// Token: 0x0400D948 RID: 55624
		[SerializeField]
		private PlayersInviteWindow _playersInviteWindow;

		// Token: 0x0400D949 RID: 55625
		[SerializeField]
		private HandoverExchangeableItemsWindow _handoverItemsWindow;

		// Token: 0x0400D94A RID: 55626
		[SerializeField]
		private AssembleBuildWindow _missingBuildItemsWindow;

		// Token: 0x0400D94B RID: 55627
		[SerializeField]
		private EditBuildNameWindow _editBuildNameWindow;

		// Token: 0x0400D94C RID: 55628
		[SerializeField]
		private MagPresetsWindow _magPresetWindow;

		// Token: 0x0400D94D RID: 55629
		[SerializeField]
		private WeaponPreviewPool _weaponPreviewPool;

		// Token: 0x0400D94E RID: 55630
		[SerializeField]
		private SimpleContextMenu _contextMenu;

		// Token: 0x0400D94F RID: 55631
		[SerializeField]
		private GridWindow _gridWindowTemplate;

		// Token: 0x0400D950 RID: 55632
		[SerializeField]
		private EditTagWindow _editTagWindowTemplate;

		// Token: 0x0400D951 RID: 55633
		[SerializeField]
		private ClothingConfirmationWindow _clothingConfirmation;

		// Token: 0x0400D952 RID: 55634
		[SerializeField]
		private CaptchaHandler _captchaHandler;

		// Token: 0x0400D953 RID: 55635
		[SerializeField]
		private EquipItemWindow _equipItemWindow;

		// Token: 0x0400D954 RID: 55636
		[SerializeField]
		private HandoverQuestItemsWindow _handoverQuestItemsWindow;

		// Token: 0x0400D955 RID: 55637
		[CompilerGenerated]
		private Action<IEnumerable<string>> action_1;

		// Token: 0x0400D956 RID: 55638
		[CompilerGenerated]
		private Action<IEnumerable<string>> action_2;

		// Token: 0x0400D957 RID: 55639
		[CompilerGenerated]
		private Action<IEffect> action_3;

		// Token: 0x0400D958 RID: 55640
		[CompilerGenerated]
		private Action<bool> action_4;

		// Token: 0x0400D959 RID: 55641
		[SerializeField]
		public Transform DragLayer;

		// Token: 0x0400D95A RID: 55642
		private readonly HashSet<GClass2809> hashSet_1;

		// Token: 0x0400D95B RID: 55643
		private GClass2821 gclass2821_0;

		// Token: 0x0400D95C RID: 55644
		private readonly Dictionary<ECommand, EBoundItem> dictionary_0;

		// Token: 0x0400D95D RID: 55645
		private readonly List<ItemUiContext.Class2500> list_0;

		// Token: 0x0400D95E RID: 55646
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400D95F RID: 55647
		private Profile profile_0;

		// Token: 0x0400D960 RID: 55648
		private IHealthController ihealthController_0;

		// Token: 0x0400D961 RID: 55649
		private LootItemClass[] gclass2625_0;

		// Token: 0x0400D962 RID: 55650
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400D963 RID: 55651
		private RagFairClass gclass3190_0;

		// Token: 0x0400D964 RID: 55652
		private TraderClass gclass2046_0;

		// Token: 0x0400D965 RID: 55653
		private SplitDialog splitDialog_0;

		// Token: 0x0400D966 RID: 55654
		private ECursorResult ecursorResult_0;

		// Token: 0x0400D967 RID: 55655
		private GClass3021<EItemInfoButton> gclass3021_0;

		// Token: 0x0400D968 RID: 55656
		[CompilerGenerated]
		private static ItemUiContext itemUiContext_0;

		// Token: 0x0400D969 RID: 55657
		[CompilerGenerated]
		private GClass3052 gclass3052_0;

		// Token: 0x0400D96A RID: 55658
		[CompilerGenerated]
		private ISession ginterface145_0;

		// Token: 0x0400D96B RID: 55659
		[CompilerGenerated]
		private EItemUiContextType eitemUiContextType_0;

		// Token: 0x0400D96C RID: 55660
		[CompilerGenerated]
		private GClass2809 gclass2809_0;

		// Token: 0x0400D96D RID: 55661
		private bool bool_0;

		// Token: 0x02002A3A RID: 10810
		private sealed class Class2500
		{
			// Token: 0x0400D96E RID: 55662
			private static int int_0;

			// Token: 0x0400D96F RID: 55663
			public readonly Item Item;

			// Token: 0x0400D970 RID: 55664
			public readonly UIInputNode Window;

			// Token: 0x0400D971 RID: 55665
			public readonly Type WindowType;

			// Token: 0x0400D972 RID: 55666
			public readonly int Index;

			// Token: 0x0400D973 RID: 55667
			public readonly bool Single;
		}

		// Token: 0x02002A3C RID: 10812
		[CompilerGenerated]
		private sealed class Class2501
		{
			// Token: 0x0600D73F RID: 55103 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(InfoWindow window, Action setPriority, Action onClosed)
			{
				throw null;
			}

			// Token: 0x0400D97C RID: 55676
			public GClass2809 itemContext;

			// Token: 0x0400D97D RID: 55677
			public ItemUiContext itemUiContext_0;

			// Token: 0x0400D97E RID: 55678
			public GClass3021<EItemInfoButton> contextInteractions;
		}

		// Token: 0x02002A3D RID: 10813
		[CompilerGenerated]
		private sealed class Class2502
		{
			// Token: 0x0600D740 RID: 55104 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task<bool> method_0(LootItemClass container)
			{
				throw null;
			}

			// Token: 0x0600D741 RID: 55105 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(BulletClass ammoStack)
			{
				throw null;
			}

			// Token: 0x0400D97F RID: 55679
			public List<BulletClass> ammo;

			// Token: 0x0400D980 RID: 55680
			public string ammoTemplateId;

			// Token: 0x0400D981 RID: 55681
			public MagazineClass magazine;

			// Token: 0x0400D982 RID: 55682
			public ItemUiContext itemUiContext_0;

			// Token: 0x02002A3E RID: 10814
			[StructLayout(LayoutKind.Auto)]
			public struct Struct869 : IAsyncStateMachine
			{
				// Token: 0x0600D742 RID: 55106 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x0600D743 RID: 55107 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x0400D983 RID: 55683
				public int int_0;

				// Token: 0x0400D984 RID: 55684
				public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

				// Token: 0x0400D985 RID: 55685
				public LootItemClass container;

				// Token: 0x0400D986 RID: 55686
				public ItemUiContext.Class2502 class2502_0;

				// Token: 0x0400D987 RID: 55687
				private List<BulletClass>.Enumerator enumerator_0;

				// Token: 0x0400D988 RID: 55688
				private BulletClass gclass2732_0;

				// Token: 0x0400D989 RID: 55689
				private int int_1;

				// Token: 0x0400D98A RID: 55690
				private TaskAwaiter<IResult> taskAwaiter_0;
			}
		}

		// Token: 0x02002A3F RID: 10815
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2503
		{
			// Token: 0x0600D744 RID: 55108 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BulletClass item)
			{
				throw null;
			}

			// Token: 0x0600D745 RID: 55109 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_1(BulletClass item)
			{
				throw null;
			}

			// Token: 0x0600D746 RID: 55110 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_2(Item x, Item y)
			{
				throw null;
			}

			// Token: 0x0600D747 RID: 55111 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(GClass2765 g)
			{
				throw null;
			}

			// Token: 0x0600D748 RID: 55112 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_4(GClass2765 g)
			{
				throw null;
			}

			// Token: 0x0600D749 RID: 55113 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Slot> method_5(Weapon weapon)
			{
				throw null;
			}

			// Token: 0x0600D74A RID: 55114 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_6(MagazineClass mag)
			{
				throw null;
			}

			// Token: 0x0400D98B RID: 55691
			public static readonly ItemUiContext.Class2503 class2503_0;

			// Token: 0x0400D98C RID: 55692
			public static Func<BulletClass, bool> func_0;

			// Token: 0x0400D98D RID: 55693
			public static Func<BulletClass, int> func_1;

			// Token: 0x0400D98E RID: 55694
			public static Comparison<Item> comparison_0;

			// Token: 0x0400D98F RID: 55695
			public static Func<GClass2765, bool> func_2;

			// Token: 0x0400D990 RID: 55696
			public static Func<GClass2765, int> func_3;

			// Token: 0x0400D991 RID: 55697
			public static Func<Weapon, IEnumerable<Slot>> func_4;

			// Token: 0x0400D992 RID: 55698
			public static Func<MagazineClass, int> func_5;
		}

		// Token: 0x02002A41 RID: 10817
		[CompilerGenerated]
		private sealed class Class2504
		{
			// Token: 0x0600D74D RID: 55117 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0()
			{
				throw null;
			}

			// Token: 0x0600D74E RID: 55118 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_1(Item container)
			{
				throw null;
			}

			// Token: 0x0600D74F RID: 55119 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(Item x)
			{
				throw null;
			}

			// Token: 0x0600D750 RID: 55120 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(GEventArgs22 args)
			{
				throw null;
			}

			// Token: 0x0600D751 RID: 55121 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4(GEventArgs3 args)
			{
				throw null;
			}

			// Token: 0x0400D99B RID: 55707
			public Item targetItem;

			// Token: 0x0400D99C RID: 55708
			public List<Item> sourcesBuffer;

			// Token: 0x0400D99D RID: 55709
			public Item currentSource;

			// Token: 0x0400D99E RID: 55710
			public ItemUiContext itemUiContext_0;

			// Token: 0x0400D99F RID: 55711
			public bool inventoryChanged;

			// Token: 0x02002A42 RID: 10818
			[StructLayout(LayoutKind.Auto)]
			public struct Struct871 : IAsyncStateMachine
			{
				// Token: 0x0600D752 RID: 55122 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x0600D753 RID: 55123 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x0400D9A0 RID: 55712
				public int int_0;

				// Token: 0x0400D9A1 RID: 55713
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x0400D9A2 RID: 55714
				public Item container;

				// Token: 0x0400D9A3 RID: 55715
				public ItemUiContext.Class2504 class2504_0;

				// Token: 0x0400D9A4 RID: 55716
				private int int_1;

				// Token: 0x0400D9A5 RID: 55717
				private TaskAwaiter<IResult> taskAwaiter_0;
			}
		}

		// Token: 0x02002A45 RID: 10821
		[CompilerGenerated]
		private sealed class Class2505
		{
			// Token: 0x0600D758 RID: 55128 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item container)
			{
				throw null;
			}

			// Token: 0x0600D759 RID: 55129 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Item x)
			{
				throw null;
			}

			// Token: 0x0400D9B1 RID: 55729
			public List<Item> itemsBuffer;

			// Token: 0x0400D9B2 RID: 55730
			public Item targetItem;
		}

		// Token: 0x02002A46 RID: 10822
		[CompilerGenerated]
		private sealed class Class2506
		{
			// Token: 0x0600D75A RID: 55130 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IResult result)
			{
				throw null;
			}

			// Token: 0x0400D9B3 RID: 55731
			public Item item;

			// Token: 0x0400D9B4 RID: 55732
			public Action callback;
		}

		// Token: 0x02002A47 RID: 10823
		[CompilerGenerated]
		private sealed class Class2507
		{
			// Token: 0x0600D75B RID: 55131 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(EditTagWindow window, Action onSelect, Action onClose)
			{
				throw null;
			}

			// Token: 0x0600D75C RID: 55132 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(string tagName, int tagColor)
			{
				throw null;
			}

			// Token: 0x0400D9B5 RID: 55733
			public TagComponent tagComponent;

			// Token: 0x0400D9B6 RID: 55734
			public ItemUiContext itemUiContext_0;

			// Token: 0x0400D9B7 RID: 55735
			public Action<string, int> action_0;
		}

		// Token: 0x02002A49 RID: 10825
		[CompilerGenerated]
		private sealed class Class2508
		{
			// Token: 0x0600D75F RID: 55135 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(InsuranceWindow window, Action setPriority, Action onClosed)
			{
				throw null;
			}

			// Token: 0x0400D9BE RID: 55742
			public GClass2809 itemContext;

			// Token: 0x0400D9BF RID: 55743
			public ItemUiContext itemUiContext_0;
		}

		// Token: 0x02002A4A RID: 10826
		[CompilerGenerated]
		private sealed class Class2509
		{
			// Token: 0x0600D760 RID: 55136 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(RepairWindow window, Action setPriority, Action onClosed)
			{
				throw null;
			}

			// Token: 0x0400D9C0 RID: 55744
			public GClass2087 repairController;

			// Token: 0x0400D9C1 RID: 55745
			public GClass2809 itemContext;

			// Token: 0x0400D9C2 RID: 55746
			public ItemUiContext itemUiContext_0;
		}

		// Token: 0x02002A4C RID: 10828
		[CompilerGenerated]
		private sealed class Class2510
		{
			// Token: 0x0600D763 RID: 55139 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(int amount)
			{
				throw null;
			}

			// Token: 0x0600D764 RID: 55140 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400D9C9 RID: 55753
			public ItemUiContext itemUiContext_0;

			// Token: 0x0400D9CA RID: 55754
			public IHealthController healthController;

			// Token: 0x0400D9CB RID: 55755
			public FoodClass foodDrink;

			// Token: 0x0400D9CC RID: 55756
			public int maxValue;
		}

		// Token: 0x02002A4E RID: 10830
		[CompilerGenerated]
		private sealed class Class2511
		{
			// Token: 0x0600D767 RID: 55143 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GridWindow window, Action setPriority, Action onClosed)
			{
				throw null;
			}

			// Token: 0x0400D9D2 RID: 55762
			public LootItemClass item;

			// Token: 0x0400D9D3 RID: 55763
			public GClass2809 itemContext;

			// Token: 0x0400D9D4 RID: 55764
			public ItemUiContext itemUiContext_0;

			// Token: 0x0400D9D5 RID: 55765
			public bool searchButtonDisplay;
		}

		// Token: 0x02002A50 RID: 10832
		[CompilerGenerated]
		private sealed class Class2512
		{
			// Token: 0x0600D76A RID: 55146 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IResult result)
			{
				throw null;
			}

			// Token: 0x0400D9DC RID: 55772
			public ItemUiContext itemUiContext_0;

			// Token: 0x0400D9DD RID: 55773
			public MagazineClass foundMagazine;

			// Token: 0x0400D9DE RID: 55774
			public Slot magazineSlot;
		}

		// Token: 0x02002A51 RID: 10833
		[CompilerGenerated]
		private sealed class Class2513
		{
			// Token: 0x0600D76B RID: 55147 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass2765 method_0(GClass2495 grid)
			{
				throw null;
			}

			// Token: 0x0400D9DF RID: 55775
			public MagazineClass currentMagazine;
		}

		// Token: 0x02002A53 RID: 10835
		[CompilerGenerated]
		private sealed class Class2514
		{
			// Token: 0x0600D76E RID: 55150 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Weapon weapon)
			{
				throw null;
			}

			// Token: 0x0600D76F RID: 55151 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Slot slot)
			{
				throw null;
			}

			// Token: 0x0400D9E6 RID: 55782
			public ItemUiContext itemUiContext_0;

			// Token: 0x0400D9E7 RID: 55783
			public Mod mod;

			// Token: 0x0400D9E8 RID: 55784
			public Func<Slot, bool> func_0;
		}

		// Token: 0x02002A5A RID: 10842
		[CompilerGenerated]
		private sealed class Class2515
		{
			// Token: 0x0600D77C RID: 55164 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(MagazineClass mag)
			{
				throw null;
			}

			// Token: 0x0400DA0D RID: 55821
			public ItemUiContext itemUiContext_0;

			// Token: 0x0400DA0E RID: 55822
			public Slot magazineSlot;
		}

		// Token: 0x02002A5B RID: 10843
		[CompilerGenerated]
		private sealed class Class2516
		{
			// Token: 0x0600D77D RID: 55165 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D77E RID: 55166 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400DA0F RID: 55823
			public TaskCompletionSource<bool> taskSource;
		}

		// Token: 0x02002A5C RID: 10844
		[CompilerGenerated]
		private sealed class Class2517
		{
			// Token: 0x0600D77F RID: 55167 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D780 RID: 55168 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400DA10 RID: 55824
			public TaskCompletionSource<bool> taskSource;
		}

		// Token: 0x02002A5D RID: 10845
		[CompilerGenerated]
		private sealed class Class2518<T> where T : Window<GClass3085>, IShowable
		{
			// Token: 0x0600D781 RID: 55169 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D782 RID: 55170 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400DA11 RID: 55825
			public ItemUiContext itemUiContext_0;

			// Token: 0x0400DA12 RID: 55826
			public ItemUiContext.Class2500 windowData;

			// Token: 0x0400DA13 RID: 55827
			public T window;
		}

		// Token: 0x02002A5E RID: 10846
		[CompilerGenerated]
		private sealed class Class2519<T> where T : GClass3085, new()
		{
			// Token: 0x0600D783 RID: 55171 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D784 RID: 55172 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400DA14 RID: 55828
			public ItemUiContext itemUiContext_0;

			// Token: 0x0400DA15 RID: 55829
			public ItemUiContext.Class2500 windowData;

			// Token: 0x0400DA16 RID: 55830
			public Window<T> window;

			// Token: 0x0400DA17 RID: 55831
			public T context;
		}
	}
}
