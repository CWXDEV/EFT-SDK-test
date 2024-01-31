using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using EFT.UI;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B83 RID: 7043
	[UsedImplicitly]
	public sealed class FuelSupplyPanel : AbstractPanel<List<HideoutControllerClass>>
	{
		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x0600942F RID: 37935 RVA: 0x00002050 File Offset: 0x00000250
		private GInterface163 GInterface163_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06009430 RID: 37936 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task ShowContents()
		{
			throw null;
		}

		// Token: 0x06009431 RID: 37937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0(GInterface163 consumer)
		{
			throw null;
		}

		// Token: 0x06009432 RID: 37938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(ItemSelectionCell itemView, Item item)
		{
			throw null;
		}

		// Token: 0x06009433 RID: 37939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(ItemSelectionCell sender, Item selectedItem)
		{
			throw null;
		}

		// Token: 0x06009434 RID: 37940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInfo()
		{
			throw null;
		}

		// Token: 0x06009435 RID: 37941 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Item item, int index)
		{
			throw null;
		}

		// Token: 0x06009436 RID: 37942 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x04009B00 RID: 39680
		[SerializeField]
		private GameObject _header;

		// Token: 0x04009B01 RID: 39681
		[SerializeField]
		private Transform _fuelTankListContainer;

		// Token: 0x04009B02 RID: 39682
		[SerializeField]
		private FuelSelectionCell _fuelTankTemplate;

		// Token: 0x04009B03 RID: 39683
		private GClass1924 gclass1924_0;

		// Token: 0x04009B04 RID: 39684
		private bool bool_0;

		// Token: 0x04009B05 RID: 39685
		private readonly Dictionary<ItemSelectionCell, GClass2700> dictionary_0;

		// Token: 0x04009B06 RID: 39686
		private ItemSelectionCell[] itemSelectionCell_0;

		// Token: 0x02001B85 RID: 7045
		[CompilerGenerated]
		private sealed class Class1666
		{
			// Token: 0x06009439 RID: 37945 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item itemToTest)
			{
				throw null;
			}

			// Token: 0x0600943A RID: 37946 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Item selectedItem)
			{
				throw null;
			}

			// Token: 0x0600943B RID: 37947 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x04009B0C RID: 39692
			public FuelSelectionCell selector;

			// Token: 0x04009B0D RID: 39693
			public FuelSupplyPanel fuelSupplyPanel_0;
		}
	}
}
