using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI;
using UnityEngine;

namespace EFT.HandBook
{
	// Token: 0x02002615 RID: 9749
	public sealed class HandbookItemPreview : UIElement
	{
		// Token: 0x0600C191 RID: 49553 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600C192 RID: 49554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChooseEntity(Item item)
		{
			throw null;
		}

		// Token: 0x0600C193 RID: 49555 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearEntity()
		{
			throw null;
		}

		// Token: 0x0400C3B4 RID: 50100
		[SerializeField]
		private ItemSpecificationPanel _itemSpecificationPanel;

		// Token: 0x0400C3B5 RID: 50101
		private ItemUiContext itemUiContext_0;
	}
}
