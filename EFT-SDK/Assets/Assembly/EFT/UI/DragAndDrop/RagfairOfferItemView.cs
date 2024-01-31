using System;
using System.Runtime.CompilerServices;
using Diz.Binding;
using EFT.InventoryLogic;
using EFT.UI.Ragfair;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E3F RID: 11839
	public sealed class RagfairOfferItemView : StaticGridItemView
	{
		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x0600E9C0 RID: 59840 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E9C1 RID: 59841 RVA: 0x00002050 File Offset: 0x00000250
		public override ItemRotation ItemRotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x0600E9C2 RID: 59842 RVA: 0x00002050 File Offset: 0x00000250
		protected override IBindable<float> Transparency
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x0600E9C3 RID: 59843 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E9C4 RID: 59844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GridItemView Create(Item item, ItemRotation rotation, TraderControllerClass itemController, IItemOwner itemOwner, ItemUiContext itemUiContext, InsuranceCompanyClass insurance)
		{
			throw null;
		}

		// Token: 0x0600E9C5 RID: 59845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Offer offer, Item item, ItemRotation rotation, bool expanded, TraderControllerClass itemController, IItemOwner itemOwner, ItemUiContext itemUiContext, InsuranceCompanyClass insurance)
		{
			throw null;
		}

		// Token: 0x0600E9C6 RID: 59846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnBeingExaminedChanged(bool isBeingExamined)
		{
			throw null;
		}

		// Token: 0x0600E9C7 RID: 59847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override string GetErrorText()
		{
			throw null;
		}

		// Token: 0x0600E9C8 RID: 59848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_34()
		{
			throw null;
		}

		// Token: 0x0600E9C9 RID: 59849 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateScale()
		{
			throw null;
		}

		// Token: 0x0600E9CA RID: 59850 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetItemValue(GridItemView.EItemValueFormat format, bool display, string color, object arg1, object arg2 = null, string color2 = null)
		{
			throw null;
		}

		// Token: 0x0600E9CB RID: 59851 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateInfo()
		{
			throw null;
		}

		// Token: 0x0600E9CC RID: 59852 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnClick(PointerEventData.InputButton button, Vector2 position, bool doubleClick)
		{
			throw null;
		}

		// Token: 0x0400EE4B RID: 61003
		private const float float_4 = 10f;

		// Token: 0x0400EE4C RID: 61004
		private const int int_0 = 330;

		// Token: 0x0400EE4D RID: 61005
		private const int int_1 = 125;

		// Token: 0x0400EE4E RID: 61006
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0400EE4F RID: 61007
		[SerializeField]
		private DurabilitySlider _durabilitySlider;

		// Token: 0x0400EE50 RID: 61008
		private ItemAttributeClass gclass2745_0;

		// Token: 0x0400EE51 RID: 61009
		private bool bool_8;

		// Token: 0x0400EE52 RID: 61010
		private Offer offer_0;

		// Token: 0x02002E40 RID: 11840
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2891
		{
			// Token: 0x0600E9CD RID: 59853 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemAttributeClass x)
			{
				throw null;
			}

			// Token: 0x0400EE53 RID: 61011
			public static readonly RagfairOfferItemView.Class2891 class2891_0;

			// Token: 0x0400EE54 RID: 61012
			public static Predicate<ItemAttributeClass> predicate_0;
		}
	}
}
