using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001AE4 RID: 6884
	public sealed class FarmingView : ProduceViewBase<GClass1915, GClass1920>
	{
		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x060090CD RID: 37069 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool ShowItemsListWindow
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060090CE RID: 37070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ItemUiContext itemUiContext, InventoryControllerClass inventoryController, GClass1920 scheme, GClass1915 producer, Action<string> getProducedItems)
		{
			throw null;
		}

		// Token: 0x060090CF RID: 37071 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateView()
		{
			throw null;
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x060090D1 RID: 37073 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060090D2 RID: 37074 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x060090D3 RID: 37075 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060090D4 RID: 37076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x060090D5 RID: 37077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x060090D6 RID: 37078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060090D7 RID: 37079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(GClass1918 producingItem)
		{
			throw null;
		}

		// Token: 0x060090D8 RID: 37080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060090D9 RID: 37081 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0400980A RID: 38922
		private const float float_0 = 0.5f;

		// Token: 0x0400980B RID: 38923
		private const string string_0 = "<color=#c5c3b2>{0}</color>\n({1})";

		// Token: 0x0400980C RID: 38924
		private const string string_1 = "<color=#c5c3b2><b>{0}</b></color>/{1}";

		// Token: 0x0400980D RID: 38925
		private static readonly string string_2;

		// Token: 0x0400980E RID: 38926
		[SerializeField]
		private HideoutItemViewFactory _stashItemIconViewFactory;

		// Token: 0x0400980F RID: 38927
		[SerializeField]
		private HideoutItemViewFactory _installedIconViewFactory;

		// Token: 0x04009810 RID: 38928
		[SerializeField]
		private HideoutItemViewFactory _resultItemIconViewFactory;

		// Token: 0x04009811 RID: 38929
		[SerializeField]
		private GameObject _productionPercentagesPanel;

		// Token: 0x04009812 RID: 38930
		[SerializeField]
		private TextMeshProUGUI _productionPercentages;

		// Token: 0x04009813 RID: 38931
		[SerializeField]
		private DefaultUIButton _getItemsButton;

		// Token: 0x04009814 RID: 38932
		[SerializeField]
		private TextMeshProUGUI _productionStatus;

		// Token: 0x04009815 RID: 38933
		[SerializeField]
		private GameObject _statusContainer;

		// Token: 0x04009816 RID: 38934
		[SerializeField]
		private Button _setAllButton;

		// Token: 0x04009817 RID: 38935
		[SerializeField]
		private Button _setOneButton;

		// Token: 0x04009818 RID: 38936
		[SerializeField]
		private Button _removeButton;

		// Token: 0x04009819 RID: 38937
		[SerializeField]
		private CanvasGroup[] _addButtonsCanvases;

		// Token: 0x0400981A RID: 38938
		[SerializeField]
		private CanvasGroup[] _removeButtonsCanvases;

		// Token: 0x0400981B RID: 38939
		[SerializeField]
		private GameObject _loaderPanel;

		// Token: 0x0400981C RID: 38940
		[SerializeField]
		private new Dictionary<EProductionState, List<GameObject>> _stateActiveObjects;

		// Token: 0x0400981D RID: 38941
		private bool bool_1;

		// Token: 0x0400981E RID: 38942
		private DateTime dateTime_0;
	}
}
