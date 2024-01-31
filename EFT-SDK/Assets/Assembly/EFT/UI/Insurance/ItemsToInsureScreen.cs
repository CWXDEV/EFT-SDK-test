using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Binding;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Insurance
{
	// Token: 0x02002EE1 RID: 12001
	[UsedImplicitly]
	public sealed class ItemsToInsureScreen : UIElement, GInterface104, GInterface105, GInterface106, GInterface112
	{
		// Token: 0x1400034E RID: 846
		// (add) Token: 0x0600ECE9 RID: 60649 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600ECEA RID: 60650 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool> OnInsuranceAvailableChanged
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

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x0600ECEB RID: 60651 RVA: 0x00002050 File Offset: 0x00000250
		private InsuranceCompanyClass.GStruct401 GStruct401_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600ECEC RID: 60652 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600ECED RID: 60653 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Profile profile, InventoryControllerClass controller, EquipmentClass equipment, InsuranceCompanyClass insurance, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600ECEE RID: 60654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemAdded(GEventArgs2 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600ECEF RID: 60655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemRemoved(GEventArgs3 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600ECF0 RID: 60656 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(ItemClass obj)
		{
			throw null;
		}

		// Token: 0x0600ECF1 RID: 60657 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRefreshItem(GEventArgs22 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600ECF2 RID: 60658 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600ECF3 RID: 60659 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600ECF4 RID: 60660 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool arg)
		{
			throw null;
		}

		// Token: 0x0600ECF5 RID: 60661 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2(Item item)
		{
			throw null;
		}

		// Token: 0x0600ECF6 RID: 60662 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600ECF7 RID: 60663 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(bool available)
		{
			throw null;
		}

		// Token: 0x0400F1EF RID: 61935
		[CompilerGenerated]
		private Action<bool> action_0;

		// Token: 0x0400F1F0 RID: 61936
		[SerializeField]
		private ComplexStashPanel _itemsPanel;

		// Token: 0x0400F1F1 RID: 61937
		[SerializeField]
		private ItemToInsurePanel _itemToInsurePanel;

		// Token: 0x0400F1F2 RID: 61938
		[SerializeField]
		private RectTransform _itemsToInsureContainer;

		// Token: 0x0400F1F3 RID: 61939
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0400F1F4 RID: 61940
		[SerializeField]
		private TextMeshProUGUI _itemsToInsureCount;

		// Token: 0x0400F1F5 RID: 61941
		[SerializeField]
		private InsurerParametersPanel _insurerParametersPanel;

		// Token: 0x0400F1F6 RID: 61942
		[SerializeField]
		private Button _insureAllButton;

		// Token: 0x0400F1F7 RID: 61943
		[SerializeField]
		private UpdatableToggle _insureAllToggle;

		// Token: 0x0400F1F8 RID: 61944
		[NonSerialized]
		public BindableEvent OnTraderChanged;

		// Token: 0x0400F1F9 RID: 61945
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400F1FA RID: 61946
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400F1FB RID: 61947
		private GClass3079<ItemClass, ItemToInsurePanel> gclass3079_0;

		// Token: 0x02002EE2 RID: 12002
		[CompilerGenerated]
		private sealed class Class2956
		{
			// Token: 0x0600ECF8 RID: 60664 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(ItemClass[] result)
			{
				throw null;
			}

			// Token: 0x0600ECF9 RID: 60665 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600ECFA RID: 60666 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(ItemToInsurePanel arg)
			{
				throw null;
			}

			// Token: 0x0600ECFB RID: 60667 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(ItemClass item, ItemToInsurePanel view)
			{
				throw null;
			}

			// Token: 0x0400F1FC RID: 61948
			public ItemsToInsureScreen itemsToInsureScreen_0;

			// Token: 0x0400F1FD RID: 61949
			public List<ItemClass> allEquipmentItems;

			// Token: 0x0400F1FE RID: 61950
			public Action<ItemToInsurePanel> action_0;
		}

		// Token: 0x02002EE3 RID: 12003
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2957
		{
			// Token: 0x0600ECFC RID: 60668 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item item)
			{
				throw null;
			}

			// Token: 0x0400F1FF RID: 61951
			public static readonly ItemsToInsureScreen.Class2957 class2957_0;

			// Token: 0x0400F200 RID: 61952
			public static Func<Item, bool> func_0;
		}
	}
}
