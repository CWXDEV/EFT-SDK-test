using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.Hideout
{
	// Token: 0x02001AF3 RID: 6899
	public sealed class ProduceView : ProduceViewBase<GClass1912, GClass1920>
	{
		// Token: 0x140001B1 RID: 433
		// (add) Token: 0x060091A5 RID: 37285 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060091A6 RID: 37286 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnUpdateFavoriteSchemesList
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x060091A7 RID: 37287 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool ShowItemsListWindow
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x060091A8 RID: 37288 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060091A9 RID: 37289 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17001625 RID: 5669
		// (set) Token: 0x060091AA RID: 37290 RVA: 0x00002050 File Offset: 0x00000250
		public bool AnyItemsReady
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060091AB RID: 37291 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060091AC RID: 37292 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool isClick = false)
		{
			throw null;
		}

		// Token: 0x060091AD RID: 37293 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ItemUiContext itemUiContext, InventoryControllerClass inventoryController, GClass1920 scheme, GClass1912 producer, Action<string> onStartProducing, Action<string> getProducedItems, bool availableFavorites)
		{
			throw null;
		}

		// Token: 0x060091AE RID: 37294 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateView()
		{
			throw null;
		}

		// Token: 0x060091AF RID: 37295 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060091B0 RID: 37296 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x060091B1 RID: 37297 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060091B2 RID: 37298 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060091B3 RID: 37299 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GClass1918 producingItem)
		{
			throw null;
		}

		// Token: 0x060091B4 RID: 37300 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x060091B6 RID: 37302 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x060091B7 RID: 37303 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x04009877 RID: 39031
		private const int int_0 = 1;

		// Token: 0x04009878 RID: 39032
		private static readonly string string_0;

		// Token: 0x04009879 RID: 39033
		[SerializeField]
		private CanvasGroup _viewCanvas;

		// Token: 0x0400987A RID: 39034
		[SerializeField]
		private HideoutProductionRequirementView _requiredItemTemplate;

		// Token: 0x0400987B RID: 39035
		[SerializeField]
		private Transform _requiredItemsContainer;

		// Token: 0x0400987C RID: 39036
		[SerializeField]
		private GameObject _expectedTimePanel;

		// Token: 0x0400987D RID: 39037
		[SerializeField]
		private TextMeshProUGUI _expectedTime;

		// Token: 0x0400987E RID: 39038
		[SerializeField]
		private GameObject _productionPercentagesPanel;

		// Token: 0x0400987F RID: 39039
		[SerializeField]
		private GameObject _productionBackground;

		// Token: 0x04009880 RID: 39040
		[SerializeField]
		private TextMeshProUGUI _productionPercentages;

		// Token: 0x04009881 RID: 39041
		[SerializeField]
		private HideoutItemViewFactory _resultItemIconViewFactory;

		// Token: 0x04009882 RID: 39042
		[SerializeField]
		private DefaultUIButton _startButton;

		// Token: 0x04009883 RID: 39043
		[SerializeField]
		private DefaultUIButton _getItemsButton;

		// Token: 0x04009884 RID: 39044
		[SerializeField]
		private ComplementaryButton _favoriteButton;

		// Token: 0x04009885 RID: 39045
		[SerializeField]
		private TextMeshProUGUI _productionStatus;

		// Token: 0x04009886 RID: 39046
		[SerializeField]
		private GameObject _loaderPanel;

		// Token: 0x04009887 RID: 39047
		private GClass3078<ItemRequirement, HideoutProductionRequirementView> gclass3078_0;

		// Token: 0x04009888 RID: 39048
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x04009889 RID: 39049
		private bool bool_1;

		// Token: 0x0400988A RID: 39050
		private bool bool_2;

		// Token: 0x0400988B RID: 39051
		private DateTime dateTime_0;

		// Token: 0x0400988C RID: 39052
		[CompilerGenerated]
		private Action action_2;

		// Token: 0x02001AF4 RID: 6900
		[CompilerGenerated]
		private sealed class Class1627
		{
			// Token: 0x060091B8 RID: 37304 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x060091B9 RID: 37305 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x060091BA RID: 37306 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x060091BB RID: 37307 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(ItemRequirement requirement, HideoutProductionRequirementView view)
			{
				throw null;
			}

			// Token: 0x0400988D RID: 39053
			public ProduceView produceView_0;

			// Token: 0x0400988E RID: 39054
			public IEnumerable<Item> allItems;
		}
	}
}
