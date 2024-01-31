using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using EFT.UI.Ragfair;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002A38 RID: 10808
	public sealed class ItemTooltip : SimpleTooltip
	{
		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x0600D6AF RID: 54959 RVA: 0x00002050 File Offset: 0x00000250
		public RagfairOfferItemView ItemView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D6B0 RID: 54960 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string text, float delay, Offer offer, Item item, InventoryControllerClass inventoryController, ItemUiContext itemUiContext, InsuranceCompanyClass insuranceCompany)
		{
			throw null;
		}

		// Token: 0x0600D6B1 RID: 54961 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D92E RID: 55598
		[SerializeField]
		private GameObject _itemObject;

		// Token: 0x0400D92F RID: 55599
		[SerializeField]
		private RagfairOfferItemView _itemView;
	}
}
