using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A61 RID: 10849
	public sealed class ItemsListWindow : UIElement
	{
		// Token: 0x0600D787 RID: 55175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D788 RID: 55176 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IEnumerable<Item> newItems, GClass2881 handbook, InventoryControllerClass inventoryController, ItemUiContext itemUiContext, InsuranceCompanyClass insuranceCompany)
		{
			throw null;
		}

		// Token: 0x0400DA2C RID: 55852
		private const string string_0 = "LOOT FROM SCAVS";

		// Token: 0x0400DA2D RID: 55853
		private const string string_1 = "Scavs has brought you:";

		// Token: 0x0400DA2E RID: 55854
		[SerializeField]
		private CustomTextMeshProUGUI _captionLabel;

		// Token: 0x0400DA2F RID: 55855
		[SerializeField]
		private Button _closeButton;

		// Token: 0x0400DA30 RID: 55856
		[SerializeField]
		private AssembleModPanel _assemblePanelTemplate;

		// Token: 0x0400DA31 RID: 55857
		[SerializeField]
		private RectTransform _assemblePanelContainer;

		// Token: 0x0400DA32 RID: 55858
		[SerializeField]
		private CustomTextMeshProUGUI _messageLabel;

		// Token: 0x0400DA33 RID: 55859
		[SerializeField]
		private DefaultUIButton _receiveButtonSpawner;

		// Token: 0x02002A62 RID: 10850
		[CompilerGenerated]
		private sealed class Class2520
		{
			// Token: 0x0600D789 RID: 55177 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal AssembleModPanel method_0(Item arg)
			{
				throw null;
			}

			// Token: 0x0600D78A RID: 55178 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Transform method_1(Item arg)
			{
				throw null;
			}

			// Token: 0x0600D78B RID: 55179 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(Item item, AssembleModPanel panel)
			{
				throw null;
			}

			// Token: 0x0400DA34 RID: 55860
			public ItemsListWindow itemsListWindow_0;

			// Token: 0x0400DA35 RID: 55861
			public GClass2881 handbook;

			// Token: 0x0400DA36 RID: 55862
			public InventoryControllerClass inventoryController;

			// Token: 0x0400DA37 RID: 55863
			public ItemUiContext itemUiContext;

			// Token: 0x0400DA38 RID: 55864
			public InsuranceCompanyClass insuranceCompany;
		}
	}
}
