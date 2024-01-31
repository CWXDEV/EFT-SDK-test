using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using EFT.UI;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.Hideout
{
	// Token: 0x02001B21 RID: 6945
	public sealed class ScavCaseView : ProduceViewBase<GClass1916, GClass1921>
	{
		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06009298 RID: 37528 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool ShowItemsListWindow
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06009299 RID: 37529 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600929A RID: 37530 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001661 RID: 5729
		// (set) Token: 0x0600929B RID: 37531 RVA: 0x00002050 File Offset: 0x00000250
		public bool AnyItemsReady
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600929C RID: 37532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600929D RID: 37533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new void Show(ItemUiContext itemUiContext, InventoryControllerClass inventoryController, GClass1921 scheme, GClass1916 producer, Action<string> onStartProducing, Action<string> getProducedItems)
		{
			throw null;
		}

		// Token: 0x0600929E RID: 37534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GClass3093 method_1(GClass1919 scheme)
		{
			throw null;
		}

		// Token: 0x0600929F RID: 37535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateView()
		{
			throw null;
		}

		// Token: 0x060092A0 RID: 37536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060092A1 RID: 37537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_3()
		{
			throw null;
		}

		// Token: 0x060092A2 RID: 37538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060092A3 RID: 37539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060092A4 RID: 37540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GClass1918 producingItem)
		{
			throw null;
		}

		// Token: 0x060092A5 RID: 37541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060092A6 RID: 37542 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x060092A7 RID: 37543 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x060092A8 RID: 37544 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x060092A9 RID: 37545 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x04009946 RID: 39238
		private const float float_0 = 0.5f;

		// Token: 0x04009947 RID: 39239
		private static readonly string string_0;

		// Token: 0x04009948 RID: 39240
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04009949 RID: 39241
		[SerializeField]
		private HideoutProductionRequirementView _requiredItemTemplate;

		// Token: 0x0400994A RID: 39242
		[SerializeField]
		private Transform _requiredItemsContainer;

		// Token: 0x0400994B RID: 39243
		[SerializeField]
		private GameObject _expectedTimePanel;

		// Token: 0x0400994C RID: 39244
		[SerializeField]
		private TextMeshProUGUI _expectedTime;

		// Token: 0x0400994D RID: 39245
		[SerializeField]
		private GameObject _productionPercentagesPanel;

		// Token: 0x0400994E RID: 39246
		[SerializeField]
		private GameObject _productionBackground;

		// Token: 0x0400994F RID: 39247
		[SerializeField]
		private TextMeshProUGUI _productionPercentages;

		// Token: 0x04009950 RID: 39248
		[SerializeField]
		private GameObject _resultItemImage;

		// Token: 0x04009951 RID: 39249
		[SerializeField]
		private DefaultUIButton _startButton;

		// Token: 0x04009952 RID: 39250
		[SerializeField]
		private DefaultUIButton _getItemsButton;

		// Token: 0x04009953 RID: 39251
		[SerializeField]
		private TextMeshProUGUI _productionStatus;

		// Token: 0x04009954 RID: 39252
		[SerializeField]
		private GameObject _loaderPanel;

		// Token: 0x04009955 RID: 39253
		[SerializeField]
		private GameObject _timerPanel;

		// Token: 0x04009956 RID: 39254
		private GClass3078<ItemRequirement, HideoutProductionRequirementView> gclass3078_0;

		// Token: 0x04009957 RID: 39255
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x04009958 RID: 39256
		private MultiLineTooltip multiLineTooltip_0;

		// Token: 0x04009959 RID: 39257
		private GClass3093 gclass3093_0;

		// Token: 0x0400995A RID: 39258
		private bool bool_1;

		// Token: 0x0400995B RID: 39259
		private bool bool_2;

		// Token: 0x0400995C RID: 39260
		private DateTime dateTime_0;

		// Token: 0x02001B22 RID: 6946
		[CompilerGenerated]
		private sealed class Class1642
		{
			// Token: 0x060092AA RID: 37546 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x060092AB RID: 37547 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(ItemRequirement requirement, HideoutProductionRequirementView view)
			{
				throw null;
			}

			// Token: 0x0400995D RID: 39261
			public ScavCaseView scavCaseView_0;

			// Token: 0x0400995E RID: 39262
			public ItemUiContext itemUiContext;

			// Token: 0x0400995F RID: 39263
			public InventoryControllerClass inventoryController;

			// Token: 0x04009960 RID: 39264
			public List<Item> allItems;
		}

		// Token: 0x02001B23 RID: 6947
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1643
		{
			// Token: 0x060092AC RID: 37548 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ItemRequirement method_0(KeyValuePair<ItemRequirement, HideoutProductionRequirementView> _)
			{
				throw null;
			}

			// Token: 0x04009961 RID: 39265
			public static readonly ScavCaseView.Class1643 class1643_0;

			// Token: 0x04009962 RID: 39266
			public static Func<KeyValuePair<ItemRequirement, HideoutProductionRequirementView>, ItemRequirement> func_0;
		}
	}
}
