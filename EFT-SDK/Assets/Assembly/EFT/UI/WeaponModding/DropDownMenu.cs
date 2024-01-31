using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using UnityEngine;

namespace EFT.UI.WeaponModding
{
	// Token: 0x02002D18 RID: 11544
	public sealed class DropDownMenu : UIElement
	{
		// Token: 0x14000329 RID: 809
		// (add) Token: 0x0600E2F8 RID: 58104 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E2F9 RID: 58105 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<ModdingScreenSlotView> OnMenuOpen
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

		// Token: 0x1400032A RID: 810
		// (add) Token: 0x0600E2FA RID: 58106 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E2FB RID: 58107 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<ModdingScreenSlotView> OnMenuClosed
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

		// Token: 0x170027B0 RID: 10160
		// (get) Token: 0x0600E2FC RID: 58108 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E2FD RID: 58109 RVA: 0x00002050 File Offset: 0x00000250
		public bool Open
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

		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x0600E2FE RID: 58110 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E2FF RID: 58111 RVA: 0x00002050 File Offset: 0x00000250
		public GClass2817 ItemContext
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

		// Token: 0x0600E300 RID: 58112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2817 itemContext, ModdingScreenSlotView slotView, TraderControllerClass itemController)
		{
			throw null;
		}

		// Token: 0x0600E301 RID: 58113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GClass2816 sourceContext, Item item, TraderControllerClass itemController, RectTransform container)
		{
			throw null;
		}

		// Token: 0x0600E302 RID: 58114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600E303 RID: 58115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600E304 RID: 58116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400E7BE RID: 59326
		[SerializeField]
		private RectTransform _noneItemContainer;

		// Token: 0x0400E7BF RID: 59327
		[SerializeField]
		private EmptyItemView _emptyItemViewTemplate;

		// Token: 0x0400E7C0 RID: 59328
		[SerializeField]
		private RectTransform _itemsContainer;

		// Token: 0x0400E7C1 RID: 59329
		[CompilerGenerated]
		private Action<ModdingScreenSlotView> action_0;

		// Token: 0x0400E7C2 RID: 59330
		[CompilerGenerated]
		private Action<ModdingScreenSlotView> action_1;

		// Token: 0x0400E7C3 RID: 59331
		private ModdingScreenSlotView moddingScreenSlotView_0;

		// Token: 0x0400E7C4 RID: 59332
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400E7C5 RID: 59333
		private readonly List<Item> list_0;

		// Token: 0x0400E7C6 RID: 59334
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400E7C7 RID: 59335
		[CompilerGenerated]
		private GClass2817 gclass2817_0;

		// Token: 0x02002D19 RID: 11545
		[CompilerGenerated]
		private sealed class Class2759
		{
			// Token: 0x0600E305 RID: 58117 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E7C8 RID: 59336
			public ItemView itemView;
		}
	}
}
