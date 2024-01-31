using System;
using System.Runtime.CompilerServices;
using Diz.Binding;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E3E RID: 11838
	public sealed class RagfairNewOfferItemView : GridItemView
	{
		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x0600E9B1 RID: 59825 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x0600E9B2 RID: 59826 RVA: 0x00002050 File Offset: 0x00000250
		protected override IBindable<float> Transparency
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x0600E9B3 RID: 59827 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E9B4 RID: 59828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RagfairNewOfferItemView Create(Item item, GClass2822 sourceContext, ItemRotation rotation, TraderControllerClass itemController, IItemOwner itemOwner, [CanBeNull] FilterPanel filterPanel, [CanBeNull] GInterface376 container, ItemUiContext itemUiContext, InsuranceCompanyClass insurance, bool canSelect)
		{
			throw null;
		}

		// Token: 0x0600E9B5 RID: 59829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private RagfairNewOfferItemView method_34(Item item, GClass2822 sourceContext, ItemRotation rotation, TraderControllerClass itemController, IItemOwner itemOwner, [CanBeNull] FilterPanel filterPanel, [CanBeNull] GInterface376 container, ItemUiContext itemUiContext, InsuranceCompanyClass insurance, bool canSelect)
		{
			throw null;
		}

		// Token: 0x0600E9B6 RID: 59830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnItemAdded(GEventArgs2 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E9B7 RID: 59831 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnItemRemoved(GEventArgs3 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E9B8 RID: 59832 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_35(bool isMaxCellsCount, Item templateItem)
		{
			throw null;
		}

		// Token: 0x0600E9B9 RID: 59833 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_36(Item item, bool selected)
		{
			throw null;
		}

		// Token: 0x0600E9BA RID: 59834 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_37(bool selected)
		{
			throw null;
		}

		// Token: 0x0600E9BB RID: 59835 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_38()
		{
			throw null;
		}

		// Token: 0x0600E9BC RID: 59836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnClick(PointerEventData.InputButton button, Vector2 position, bool doubleClick)
		{
			throw null;
		}

		// Token: 0x0600E9BD RID: 59837 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnEndDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E9BE RID: 59838 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Kill()
		{
			throw null;
		}

		// Token: 0x0600E9BF RID: 59839 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_39(float baseTransparent, bool canBeOffered, bool maxCountReached)
		{
			throw null;
		}

		// Token: 0x0400EE44 RID: 60996
		[SerializeField]
		private GameObject _selectedMark;

		// Token: 0x0400EE45 RID: 60997
		[SerializeField]
		private GameObject _selectedBackground;

		// Token: 0x0400EE46 RID: 60998
		private bool bool_8;

		// Token: 0x0400EE47 RID: 60999
		private bool bool_9;

		// Token: 0x0400EE48 RID: 61000
		private readonly BindableState<bool> gclass3370_12;

		// Token: 0x0400EE49 RID: 61001
		private readonly BindableState<bool> gclass3370_13;

		// Token: 0x0400EE4A RID: 61002
		private GClass3069 gclass3069_0;
	}
}
