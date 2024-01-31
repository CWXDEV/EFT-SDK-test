using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E20 RID: 11808
	public abstract class BaseSelectableItemView : StaticGridItemView
	{
		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x0600E8A2 RID: 59554 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E8A3 RID: 59555 RVA: 0x00002050 File Offset: 0x00000250
		private GClass2816 SelectableContext
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

		// Token: 0x0600E8A4 RID: 59556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void NewBaseSelectableItemView(Item item, GClass2816 sourceItemContext, ItemRotation rotation, TraderControllerClass itemController, IItemOwner itemOwner, FilterPanel filterPanel, GInterface376 container, ItemUiContext itemUiContext, InsuranceCompanyClass insurance)
		{
			throw null;
		}

		// Token: 0x0600E8A5 RID: 59557
		protected abstract void SetAvailability(bool available, string tooltip);

		// Token: 0x0600E8A6 RID: 59558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetItemSelected(bool selected)
		{
			throw null;
		}

		// Token: 0x0600E8A7 RID: 59559 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnClick(PointerEventData.InputButton button, Vector2 position, bool doubleClick)
		{
			throw null;
		}

		// Token: 0x0600E8A8 RID: 59560 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateRemoveError(bool ignoreMalfunctions = true)
		{
			throw null;
		}

		// Token: 0x0600E8A9 RID: 59561 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Kill()
		{
			throw null;
		}

		// Token: 0x0600E8AA RID: 59562 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_34()
		{
			throw null;
		}

		// Token: 0x0400ED8C RID: 60812
		[SerializeField]
		private GameObject _selectedMark;

		// Token: 0x0400ED8D RID: 60813
		[SerializeField]
		private GameObject _selectedBackground;

		// Token: 0x0400ED8E RID: 60814
		[CompilerGenerated]
		private GClass2816 gclass2816_1;
	}
}
