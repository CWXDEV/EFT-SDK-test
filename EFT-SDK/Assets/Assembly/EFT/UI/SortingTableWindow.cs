using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A14 RID: 10772
	[UsedImplicitly]
	public sealed class SortingTableWindow : Window<GClass3085>, GInterface104, GInterface105, GInterface106
	{
		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x0600D622 RID: 54818 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsVisible
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D623 RID: 54819 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D624 RID: 54820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2809 itemContext, SortingTableClass sortingTable, ISession session, GClass2759 inventoryController, ItemUiContext uiContext, Action onClosed, Action afterClosed)
		{
			throw null;
		}

		// Token: 0x0600D625 RID: 54821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D626 RID: 54822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(string messageFormat, Action callback)
		{
			throw null;
		}

		// Token: 0x0600D627 RID: 54823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_4(IEnumerable<Item> sellingItems, Action callback)
		{
			throw null;
		}

		// Token: 0x0600D628 RID: 54824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_5()
		{
			throw null;
		}

		// Token: 0x0600D629 RID: 54825 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemAdded(GEventArgs2 obj)
		{
			throw null;
		}

		// Token: 0x0600D62A RID: 54826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemRemoved(GEventArgs3 obj)
		{
			throw null;
		}

		// Token: 0x0600D62B RID: 54827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600D62C RID: 54828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600D62D RID: 54829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600D62E RID: 54830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> TryClose()
		{
			throw null;
		}

		// Token: 0x0600D62F RID: 54831 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D630 RID: 54832 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600D631 RID: 54833 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600D632 RID: 54834 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_11()
		{
			throw null;
		}

		// Token: 0x0600D633 RID: 54835 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_12()
		{
			throw null;
		}

		// Token: 0x0400D868 RID: 55400
		private const string string_0 = "SortingTable/SellFromSortingTableConfirmation{0}";

		// Token: 0x0400D869 RID: 55401
		public const string MOVE_FROM_SORTING_TABLE_ERROR = "SortingTable/TransferFromSortingTableError";

		// Token: 0x0400D86A RID: 55402
		private const int int_0 = 7;

		// Token: 0x0400D86B RID: 55403
		[SerializeField]
		private GridView _grid;

		// Token: 0x0400D86C RID: 55404
		[SerializeField]
		private Button _sellAllButton;

		// Token: 0x0400D86D RID: 55405
		[SerializeField]
		private CanvasGroup _sellButtonCanvasGroup;

		// Token: 0x0400D86E RID: 55406
		[SerializeField]
		private GameObject _blockScreen;

		// Token: 0x0400D86F RID: 55407
		private GClass2044 gclass2044_0;

		// Token: 0x0400D870 RID: 55408
		private SortingTableClass gclass2699_0;

		// Token: 0x0400D871 RID: 55409
		private GClass2759 gclass2759_0;

		// Token: 0x0400D872 RID: 55410
		private IItemOwner iitemOwner_0;

		// Token: 0x0400D873 RID: 55411
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400D874 RID: 55412
		private GClass2809 gclass2809_0;

		// Token: 0x0400D875 RID: 55413
		private Action action_1;

		// Token: 0x0400D876 RID: 55414
		private bool bool_0;

		// Token: 0x0400D877 RID: 55415
		private bool bool_1;

		// Token: 0x0400D878 RID: 55416
		private Task<bool> task_1;
	}
}
