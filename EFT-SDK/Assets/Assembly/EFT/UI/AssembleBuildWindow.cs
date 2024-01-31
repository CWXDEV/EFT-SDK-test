using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x0200289E RID: 10398
	public sealed class AssembleBuildWindow : Window<GClass3085>
	{
		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x0600CFB7 RID: 53175 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool ShowOnTop
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x0600CFB8 RID: 53176 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool DragEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CFB9 RID: 53177 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600CFBA RID: 53178 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3085 Show(GClass2881 handbook, IReadOnlyCollection<Item> outOfCollectionItems, IReadOnlyCollection<Item> itemsInBuild, InventoryControllerClass inventoryController, InsuranceCompanyClass insuranceCompany, bool needShowIncludeItemsToggle, Action onIgnoreButtonClicked, Action<bool> onBuyButtonClicked)
		{
			throw null;
		}

		// Token: 0x0600CFBB RID: 53179 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(IReadOnlyCollection<Item> items)
		{
			throw null;
		}

		// Token: 0x0600CFBC RID: 53180 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600CFBD RID: 53181 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600CFBE RID: 53182 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool arg)
		{
			throw null;
		}

		// Token: 0x0400D076 RID: 53366
		[SerializeField]
		private TextMeshProUGUI _warningTitle;

		// Token: 0x0400D077 RID: 53367
		[SerializeField]
		private TextMeshProUGUI _warningDescription;

		// Token: 0x0400D078 RID: 53368
		[SerializeField]
		private AssembleModPanel _modPanel;

		// Token: 0x0400D079 RID: 53369
		[SerializeField]
		private RectTransform _modPanelContainer;

		// Token: 0x0400D07A RID: 53370
		[SerializeField]
		private Toggle _includePartsToggle;

		// Token: 0x0400D07B RID: 53371
		[SerializeField]
		private TextMeshProUGUI _includePartsLabel;

		// Token: 0x0400D07C RID: 53372
		[SerializeField]
		private DefaultUIButton _ignoreButton;

		// Token: 0x0400D07D RID: 53373
		[SerializeField]
		private DefaultUIButton _buyButton;

		// Token: 0x0400D07E RID: 53374
		private readonly GClass3357<Item> gclass3357_0;

		// Token: 0x0400D07F RID: 53375
		private Action<bool> action_1;

		// Token: 0x0400D080 RID: 53376
		private Action action_2;

		// Token: 0x0400D081 RID: 53377
		private bool bool_0;

		// Token: 0x0400D082 RID: 53378
		private IReadOnlyCollection<Item> ireadOnlyCollection_0;

		// Token: 0x0400D083 RID: 53379
		private IReadOnlyCollection<Item> ireadOnlyCollection_1;

		// Token: 0x0200289F RID: 10399
		[CompilerGenerated]
		private sealed class Class2358
		{
			// Token: 0x0600CFBF RID: 53183 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Item item, AssembleModPanel view)
			{
				throw null;
			}

			// Token: 0x0400D084 RID: 53380
			public GClass2881 handbook;

			// Token: 0x0400D085 RID: 53381
			public InventoryControllerClass inventoryController;

			// Token: 0x0400D086 RID: 53382
			public InsuranceCompanyClass insuranceCompany;
		}
	}
}
