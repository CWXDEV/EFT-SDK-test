using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Diz.Binding;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C17 RID: 11287
	[UsedImplicitly]
	public sealed class TransferItemsPanel : UIElement
	{
		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x0600DE78 RID: 56952 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface386 OnApplyTransfer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x0600DE79 RID: 56953 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DE7A RID: 56954 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x0600DE7B RID: 56955 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DE7C RID: 56956 RVA: 0x00002050 File Offset: 0x00000250
		private ItemUiContext ItemUiContext_0
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

		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x0600DE7D RID: 56957 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DE7E RID: 56958 RVA: 0x00002050 File Offset: 0x00000250
		public int SumItemsPrice
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

		// Token: 0x0600DE7F RID: 56959 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DE80 RID: 56960 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600DE81 RID: 56961 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GStruct414> TryToRemoveAllFromCurrentItem(bool force = false)
		{
			throw null;
		}

		// Token: 0x0600DE82 RID: 56962 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(StashClass item, GClass2809 itemContext, InventoryControllerClass inventoryController)
		{
			throw null;
		}

		// Token: 0x0600DE83 RID: 56963 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0600DE84 RID: 56964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600DE85 RID: 56965 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(EventArgs _)
		{
			throw null;
		}

		// Token: 0x0600DE86 RID: 56966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DE87 RID: 56967 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0400E353 RID: 58195
		private const string string_0 = "TransferItemsScreen/BtrContainerName";

		// Token: 0x0400E354 RID: 58196
		private const string string_1 = "TransferScreen/ErrorMovingNotification";

		// Token: 0x0400E355 RID: 58197
		private const string string_2 = "TransferScreen/PriceMessage";

		// Token: 0x0400E356 RID: 58198
		private const string string_3 = "TransferScreen/NotEnoughMoney";

		// Token: 0x0400E357 RID: 58199
		private const string string_4 = "TransferScreen/NothingToTransfer";

		// Token: 0x0400E358 RID: 58200
		private const string string_5 = "TransferScreen/NothingToRemove";

		// Token: 0x0400E359 RID: 58201
		[SerializeField]
		private TextMeshProUGUI _containerName;

		// Token: 0x0400E35A RID: 58202
		[SerializeField]
		private TextMeshProUGUI _totalPrice;

		// Token: 0x0400E35B RID: 58203
		[SerializeField]
		private SearchableItemView _simplePanel;

		// Token: 0x0400E35C RID: 58204
		[SerializeField]
		private GridView _itemsToHandover;

		// Token: 0x0400E35D RID: 58205
		[SerializeField]
		private DefaultUIButton _transferButton;

		// Token: 0x0400E35E RID: 58206
		[SerializeField]
		private DefaultUIButton _cancelButton;

		// Token: 0x0400E35F RID: 58207
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400E360 RID: 58208
		private StashClass gclass2698_0;

		// Token: 0x0400E361 RID: 58209
		private bool bool_0;

		// Token: 0x0400E362 RID: 58210
		private Task<GStruct414> task_0;

		// Token: 0x0400E363 RID: 58211
		private readonly BindableEvent bindableEvent_0;

		// Token: 0x0400E364 RID: 58212
		[CompilerGenerated]
		private GClass2809 gclass2809_0;

		// Token: 0x0400E365 RID: 58213
		[CompilerGenerated]
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400E366 RID: 58214
		[CompilerGenerated]
		private int int_0;

		// Token: 0x02002C19 RID: 11289
		[CompilerGenerated]
		private sealed class Class2685
		{
			// Token: 0x0600DE8A RID: 56970 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E36C RID: 58220
			public InventoryControllerClass itemOwner;

			// Token: 0x0400E36D RID: 58221
			public TransferItemsPanel transferItemsPanel_0;

			// Token: 0x0400E36E RID: 58222
			public IItemOwner rightController;
		}
	}
}
