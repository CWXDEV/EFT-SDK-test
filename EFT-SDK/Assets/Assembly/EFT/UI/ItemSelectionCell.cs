using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HandBook;
using EFT.Hideout;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020029B0 RID: 10672
	public class ItemSelectionCell : UIElement
	{
		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x0600D458 RID: 54360 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual EContextPriorDirection Direction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x0600D459 RID: 54361 RVA: 0x00002050 File Offset: 0x00000250
		private IEnumerable<Item> IEnumerable_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025A6 RID: 9638
		// (set) Token: 0x0600D45A RID: 54362 RVA: 0x00002050 File Offset: 0x00000250
		protected IEnumerable<string> SelectingItems
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x0600D45B RID: 54363 RVA: 0x00002050 File Offset: 0x00000250
		protected Button DropdownButton
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D45C RID: 54364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600D45D RID: 54365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show([CanBeNull] Item currentSelectedItem, ItemSelectionCell.GInterface361 selectionHandler)
		{
			throw null;
		}

		// Token: 0x0600D45E RID: 54366 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show([CanBeNull] Item currentSelectedItem, Func<Item, bool> selectionChecker, Action<Item> selectionHandler)
		{
			throw null;
		}

		// Token: 0x0600D45F RID: 54367 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetItem(Item item)
		{
			throw null;
		}

		// Token: 0x0600D460 RID: 54368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Item item)
		{
			throw null;
		}

		// Token: 0x0600D461 RID: 54369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1([CanBeNull] Item item)
		{
			throw null;
		}

		// Token: 0x0600D462 RID: 54370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D463 RID: 54371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string GetDetails(Item item)
		{
			throw null;
		}

		// Token: 0x0600D464 RID: 54372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool isOpen)
		{
			throw null;
		}

		// Token: 0x0600D465 RID: 54373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600D466 RID: 54374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D467 RID: 54375 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<Item> method_4()
		{
			throw null;
		}

		// Token: 0x0400D69F RID: 54943
		[SerializeField]
		private IEnumerable<string> _selectingItems;

		// Token: 0x0400D6A0 RID: 54944
		[SerializeField]
		private EntityIcon _selectedItemIcon;

		// Token: 0x0400D6A1 RID: 54945
		[SerializeField]
		private GameObject _emptyIcon;

		// Token: 0x0400D6A2 RID: 54946
		[SerializeField]
		private Button _dropdownButton;

		// Token: 0x0400D6A3 RID: 54947
		[SerializeField]
		private Sprite _closeButtonIcon;

		// Token: 0x0400D6A4 RID: 54948
		[SerializeField]
		private Sprite _openButtonIcon;

		// Token: 0x0400D6A5 RID: 54949
		[SerializeField]
		private SelectingItemView _itemViewPrefab;

		// Token: 0x0400D6A6 RID: 54950
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0400D6A7 RID: 54951
		[SerializeField]
		private RectTransform _mainTransform;

		// Token: 0x0400D6A8 RID: 54952
		[SerializeField]
		private bool _showEmptyCell;

		// Token: 0x0400D6A9 RID: 54953
		[SerializeField]
		private Vector2 _contextMenuOffset;

		// Token: 0x0400D6AA RID: 54954
		protected Item CurrentItem;

		// Token: 0x0400D6AB RID: 54955
		private Func<Item, bool> func_0;

		// Token: 0x0400D6AC RID: 54956
		private Action<Item> action_0;

		// Token: 0x0400D6AD RID: 54957
		private Func<IEnumerable<Item>> func_1;

		// Token: 0x0400D6AE RID: 54958
		private bool bool_0;

		// Token: 0x0400D6AF RID: 54959
		private bool bool_1;

		// Token: 0x0400D6B0 RID: 54960
		private ItemUiContext itemUiContext_0;

		// Token: 0x020029B1 RID: 10673
		public interface GInterface361
		{
			// Token: 0x0600D468 RID: 54376
			bool CanSelect(Item item);

			// Token: 0x0600D469 RID: 54377
			void ItemSelectionHandler(Item selectedItem);

			// Token: 0x0600D46A RID: 54378
			IEnumerable<Item> GetAvailableItems();
		}

		// Token: 0x020029B2 RID: 10674
		// (Invoke) Token: 0x0600D46B RID: 54379
		public delegate bool GDelegate74(Item selectedItem, bool selected);

		// Token: 0x020029B3 RID: 10675
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2453
		{
			// Token: 0x0600D46E RID: 54382 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item item)
			{
				throw null;
			}

			// Token: 0x0400D6B1 RID: 54961
			public static readonly ItemSelectionCell.Class2453 class2453_0;

			// Token: 0x0400D6B2 RID: 54962
			public static Func<Item, bool> func_0;
		}
	}
}
