using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI;
using EFT.UI.DragAndDrop;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001AEB RID: 6891
	[UsedImplicitly]
	public sealed class HideoutItemViewFactory : UIElement
	{
		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x060090FE RID: 37118 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060090FF RID: 37119 RVA: 0x00002050 File Offset: 0x00000250
		private ItemView ItemView_0
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

		// Token: 0x06009100 RID: 37120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Item item, InventoryControllerClass inventoryController, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x170015FA RID: 5626
		// (set) Token: 0x06009101 RID: 37121 RVA: 0x00002050 File Offset: 0x00000250
		public bool FulfilledStatus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06009102 RID: 37122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBorderColor(in Color color)
		{
			throw null;
		}

		// Token: 0x06009103 RID: 37123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCounterText(string text)
		{
			throw null;
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowInfo(bool showCounter, bool showFulfilledStatus)
		{
			throw null;
		}

		// Token: 0x06009105 RID: 37125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetError(InventoryError error)
		{
			throw null;
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GridLayoutGroup.Axis layoutType)
		{
			throw null;
		}

		// Token: 0x06009107 RID: 37127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x04009838 RID: 38968
		[SerializeField]
		private TextMeshProUGUI _counterField;

		// Token: 0x04009839 RID: 38969
		[SerializeField]
		private GameObject _counterContainer;

		// Token: 0x0400983A RID: 38970
		[SerializeField]
		private RequirementFulfilledStatus _fulfilledStatus;

		// Token: 0x0400983B RID: 38971
		[SerializeField]
		private GameObject _fulfilledStatusContainer;

		// Token: 0x0400983C RID: 38972
		[SerializeField]
		private HorizontalOrVerticalLayoutGroup _horizontalLayout;

		// Token: 0x0400983D RID: 38973
		[SerializeField]
		private HorizontalOrVerticalLayoutGroup _verticalLayout;

		// Token: 0x0400983E RID: 38974
		[SerializeField]
		private Transform _itemViewContainer;

		// Token: 0x0400983F RID: 38975
		[SerializeField]
		private GameObject _infoContainer;

		// Token: 0x04009840 RID: 38976
		[SerializeField]
		private bool _showCounter;

		// Token: 0x04009841 RID: 38977
		[SerializeField]
		private bool _showFulfilledStatus;

		// Token: 0x04009842 RID: 38978
		[SerializeField]
		private GridLayoutGroup.Axis _layout;

		// Token: 0x04009843 RID: 38979
		[SerializeField]
		private HoverTooltipArea _hoverTooltipArea;

		// Token: 0x04009844 RID: 38980
		[SerializeField]
		private GameObject _errorBlock;

		// Token: 0x04009845 RID: 38981
		[CompilerGenerated]
		private ItemView itemView_0;
	}
}
