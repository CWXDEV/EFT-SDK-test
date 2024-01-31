using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B83 RID: 11139
	public class BarterSchemePanel : UIElement
	{
		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x0600DBEB RID: 56299 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		private Item Item_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x0600DBEC RID: 56300 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x0600DBED RID: 56301 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x0600DBEE RID: 56302 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DBEF RID: 56303 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DBF0 RID: 56304 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(TraderAssortmentControllerClass traderAssortment, GInterface313 itemController, GClass2495 userStashGrid)
		{
			throw null;
		}

		// Token: 0x0600DBF1 RID: 56305 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600DBF2 RID: 56306 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GEventArgs6 examineArgs)
		{
			throw null;
		}

		// Token: 0x0600DBF3 RID: 56307 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Item selectedItem)
		{
			throw null;
		}

		// Token: 0x0600DBF4 RID: 56308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600DBF5 RID: 56309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(bool state)
		{
			throw null;
		}

		// Token: 0x0600DBF6 RID: 56310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600DBF7 RID: 56311 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DBF8 RID: 56312 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(string x)
		{
			throw null;
		}

		// Token: 0x0600DBF9 RID: 56313 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600DBFA RID: 56314 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600DBFB RID: 56315 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600DBFC RID: 56316 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600DBFD RID: 56317 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(GClass2045 anItem, TradingRequisitePanel view)
		{
			throw null;
		}

		// Token: 0x0400DFE7 RID: 57319
		[SerializeField]
		private DefaultUIButton _autoButton;

		// Token: 0x0400DFE8 RID: 57320
		[SerializeField]
		private CustomTextMeshProInputField _quantity;

		// Token: 0x0400DFE9 RID: 57321
		[SerializeField]
		private CustomTextMeshProUGUI _purchaseCaption;

		// Token: 0x0400DFEA RID: 57322
		[SerializeField]
		private ItemOnGrid _itemOnDisplay;

		// Token: 0x0400DFEB RID: 57323
		[SerializeField]
		private GameObject _validSchemeWarning;

		// Token: 0x0400DFEC RID: 57324
		[SerializeField]
		private CustomTextMeshProUGUI _buyRestrictionLabel;

		// Token: 0x0400DFED RID: 57325
		[SerializeField]
		private GameObject _buyRestrictionWarning;

		// Token: 0x0400DFEE RID: 57326
		[SerializeField]
		private TradingRequisitePanel _requisiteTemplate;

		// Token: 0x0400DFEF RID: 57327
		[SerializeField]
		private Transform _requisitesContainer;

		// Token: 0x0400DFF0 RID: 57328
		[SerializeField]
		private ScrollRect _mainPart;

		// Token: 0x0400DFF1 RID: 57329
		[SerializeField]
		private GameObject _noItemsSelectedPanel;

		// Token: 0x0400DFF2 RID: 57330
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400DFF3 RID: 57331
		[SerializeField]
		private UpdatableToggle _autoFillRequirements;

		// Token: 0x0400DFF4 RID: 57332
		private UpdatableToggle updatableToggle_0;

		// Token: 0x0400DFF5 RID: 57333
		private GInterface313 ginterface313_0;

		// Token: 0x0400DFF6 RID: 57334
		private GClass3078<GClass2045, TradingRequisitePanel> gclass3078_0;

		// Token: 0x0400DFF7 RID: 57335
		private TraderAssortmentControllerClass gclass2043_0;

		// Token: 0x0400DFF8 RID: 57336
		private GClass2495 gclass2495_0;

		// Token: 0x02002B84 RID: 11140
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2637
		{
			// Token: 0x0600DBFE RID: 56318 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool arg)
			{
				throw null;
			}

			// Token: 0x0600DBFF RID: 56319 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Item> method_1(KeyValuePair<Item, LocationInGrid> x)
			{
				throw null;
			}

			// Token: 0x0600DC00 RID: 56320 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(Item item)
			{
				throw null;
			}

			// Token: 0x0400DFF9 RID: 57337
			public static readonly BarterSchemePanel.Class2637 class2637_0;

			// Token: 0x0400DFFA RID: 57338
			public static UnityAction<bool> unityAction_0;

			// Token: 0x0400DFFB RID: 57339
			public static Func<KeyValuePair<Item, LocationInGrid>, IEnumerable<Item>> func_0;

			// Token: 0x0400DFFC RID: 57340
			public static Func<Item, bool> func_1;
		}
	}
}
