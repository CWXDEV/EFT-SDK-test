using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E42 RID: 11842
	public class SelectableItemView : BaseSelectableItemView
	{
		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x0600E9D0 RID: 59856 RVA: 0x00002050 File Offset: 0x00000250
		protected Image SelectedMarkBack
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E9D2 RID: 59858 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected SelectableItemView NewSelectableItemView(Item item, GClass2816 sourceContext, ItemRotation rotation, TraderControllerClass itemController, IItemOwner itemOwner, FilterPanel filterPanel, GInterface376 container, ItemUiContext itemUiContext, InsuranceCompanyClass insurance)
		{
			throw null;
		}

		// Token: 0x0600E9D3 RID: 59859 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetItemSelected(bool selected)
		{
			throw null;
		}

		// Token: 0x0600E9D4 RID: 59860 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E9D5 RID: 59861 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnClick(PointerEventData.InputButton button, Vector2 position, bool doubleClick)
		{
			throw null;
		}

		// Token: 0x0600E9D6 RID: 59862 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetAvailability(bool available, string tooltip)
		{
			throw null;
		}

		// Token: 0x0600E9D7 RID: 59863 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateScale()
		{
			throw null;
		}

		// Token: 0x0400EE55 RID: 61013
		[SerializeField]
		private Image _selectedMarkBack;

		// Token: 0x0400EE56 RID: 61014
		[SerializeField]
		private GameObject _unavailableBorder;

		// Token: 0x0400EE57 RID: 61015
		private bool bool_8;

		// Token: 0x0400EE58 RID: 61016
		private string string_0;
	}
}
