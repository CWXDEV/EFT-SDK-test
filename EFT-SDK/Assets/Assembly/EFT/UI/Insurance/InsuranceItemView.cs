using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Insurance
{
	// Token: 0x02002ED1 RID: 11985
	public sealed class InsuranceItemView : GridItemView
	{
		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x0600EC83 RID: 60547 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x0600EC84 RID: 60548 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EC85 RID: 60549 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static InsuranceItemView Create(Item item, GClass2809 sourceContext, ItemRotation rotation, TraderControllerClass itemController, IItemOwner itemOwner, [CanBeNull] FilterPanel filterPanel, [CanBeNull] GInterface376 container, ItemUiContext itemUiContext, InsuranceCompanyClass insurance)
		{
			throw null;
		}

		// Token: 0x0600EC86 RID: 60550 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private InsuranceItemView method_34(ItemClass insuredItem, GClass2809 sourceContext, ItemRotation rotation, IItemOwner itemOwner, TraderControllerClass itemController, [CanBeNull] FilterPanel filterPanel, [CanBeNull] GInterface376 container, ItemUiContext itemUiContext, InsuranceCompanyClass insurance)
		{
			throw null;
		}

		// Token: 0x0600EC87 RID: 60551 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override GClass2809 CreateNewItemContext(GClass2809 sourceContext)
		{
			throw null;
		}

		// Token: 0x0600EC88 RID: 60552 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_35(ItemClass item)
		{
			throw null;
		}

		// Token: 0x0600EC89 RID: 60553 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EC8A RID: 60554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EC8B RID: 60555 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnClick(PointerEventData.InputButton button, Vector2 position, bool doubleClick)
		{
			throw null;
		}

		// Token: 0x0400F17D RID: 61821
		[SerializeField]
		private Image _itemToInsureBorder;

		// Token: 0x0400F17E RID: 61822
		private InsuranceCompanyClass gclass3179_1;

		// Token: 0x0400F17F RID: 61823
		private ItemClass gclass3180_0;
	}
}
