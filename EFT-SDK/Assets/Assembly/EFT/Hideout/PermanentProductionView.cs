using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001AE5 RID: 6885
	[UsedImplicitly]
	public sealed class PermanentProductionView : ProduceViewBase<GClass1914, GClass1920>
	{
		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x060090DA RID: 37082 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool ShowItemsListWindow
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060090DB RID: 37083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ItemUiContext itemUiContext, InventoryControllerClass inventoryController, GClass1920 scheme, GClass1914 producer, Action<string> getItems)
		{
			throw null;
		}

		// Token: 0x060090DC RID: 37084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(FuelSelectionCell sender, Item selectedItem)
		{
			throw null;
		}

		// Token: 0x060090DD RID: 37085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateView()
		{
			throw null;
		}

		// Token: 0x060090DE RID: 37086 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060090DF RID: 37087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass1918 producingItem)
		{
			throw null;
		}

		// Token: 0x060090E0 RID: 37088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Item item, int index)
		{
			throw null;
		}

		// Token: 0x060090E1 RID: 37089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060090E2 RID: 37090 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400981F RID: 38943
		private const string string_0 = "<color=#c5c3b2><b>{0}</b></color>/{1}";

		// Token: 0x04009820 RID: 38944
		[SerializeField]
		private HideoutItemViewFactory _resultItemIconView;

		// Token: 0x04009821 RID: 38945
		[SerializeField]
		private GameObject _productionPercentagesPanel;

		// Token: 0x04009822 RID: 38946
		[SerializeField]
		private TextMeshProUGUI _productionPercentages;

		// Token: 0x04009823 RID: 38947
		[SerializeField]
		private DefaultUIButton _getItemsButton;

		// Token: 0x04009824 RID: 38948
		[SerializeField]
		private TextMeshProUGUI _productionStatus;

		// Token: 0x04009825 RID: 38949
		[SerializeField]
		private FuelSelectionCell _resourceContainerTemplate;

		// Token: 0x04009826 RID: 38950
		[SerializeField]
		private Transform _resourceCellsContainer;

		// Token: 0x04009827 RID: 38951
		[SerializeField]
		private GameObject _loaderPanel;

		// Token: 0x04009828 RID: 38952
		private FuelSelectionCell[] fuelSelectionCell_0;

		// Token: 0x02001AE6 RID: 6886
		[CompilerGenerated]
		private sealed class Class1622
		{
			// Token: 0x060090E3 RID: 37091 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Item selectedItem)
			{
				throw null;
			}

			// Token: 0x060090E4 RID: 37092 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x04009829 RID: 38953
			public FuelSelectionCell selectionView;

			// Token: 0x0400982A RID: 38954
			public PermanentProductionView permanentProductionView_0;
		}

		// Token: 0x02001AE7 RID: 6887
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1623
		{
			// Token: 0x060090E5 RID: 37093 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item itemToTest)
			{
				throw null;
			}

			// Token: 0x0400982B RID: 38955
			public static readonly PermanentProductionView.Class1623 class1623_0;

			// Token: 0x0400982C RID: 38956
			public static Func<Item, bool> func_0;
		}
	}
}
