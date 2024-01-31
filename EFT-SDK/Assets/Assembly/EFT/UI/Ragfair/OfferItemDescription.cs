using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F9A RID: 12186
	public sealed class OfferItemDescription : UIElement
	{
		// Token: 0x0600F062 RID: 61538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2881 handbook, Offer offer, bool expanded, InventoryControllerClass inventoryController, ItemUiContext itemUiContext, InsuranceCompanyClass insuranceCompany)
		{
			throw null;
		}

		// Token: 0x0600F063 RID: 61539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GEventArgs6 args)
		{
			throw null;
		}

		// Token: 0x0600F064 RID: 61540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600F065 RID: 61541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600F066 RID: 61542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600F067 RID: 61543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600F068 RID: 61544 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GEventArgs6 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600F069 RID: 61545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateItemStackCountLabel()
		{
			throw null;
		}

		// Token: 0x0600F06A RID: 61546 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600F06B RID: 61547 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PointerEventsProxy method_7(EItemAttributeId iconType, float value, float maxValue, string textColor)
		{
			throw null;
		}

		// Token: 0x0600F06C RID: 61548 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600F06D RID: 61549 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600F06E RID: 61550 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400F600 RID: 62976
		[SerializeField]
		private HoverTrigger _hoverTrigger;

		// Token: 0x0400F601 RID: 62977
		[SerializeField]
		private TextMeshProUGUI _offerItemName;

		// Token: 0x0400F602 RID: 62978
		[SerializeField]
		private TextMeshProUGUI _offerStackCount;

		// Token: 0x0400F603 RID: 62979
		[SerializeField]
		private TextMeshProUGUI _offersCount;

		// Token: 0x0400F604 RID: 62980
		[SerializeField]
		private TextMeshProUGUI _itemCategory;

		// Token: 0x0400F605 RID: 62981
		[SerializeField]
		private InteractionButtonsContainer _offerContextMenu;

		// Token: 0x0400F606 RID: 62982
		[SerializeField]
		private RagfairOfferItemView _offerItemView;

		// Token: 0x0400F607 RID: 62983
		[SerializeField]
		private Transform _resourceCountersContainer;

		// Token: 0x0400F608 RID: 62984
		[SerializeField]
		private OfferViewResourceCounter _resourceCounterTemplate;

		// Token: 0x0400F609 RID: 62985
		private const int int_0 = 10;

		// Token: 0x0400F60A RID: 62986
		private Offer offer_0;

		// Token: 0x0400F60B RID: 62987
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400F60C RID: 62988
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400F60D RID: 62989
		private GClass2884 gclass2884_0;

		// Token: 0x0400F60E RID: 62990
		private GClass3021<EItemInfoButton> gclass3021_0;

		// Token: 0x0400F60F RID: 62991
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400F610 RID: 62992
		private bool bool_0;

		// Token: 0x0400F611 RID: 62993
		private List<OfferViewResourceCounter> list_0;

		// Token: 0x02002F9B RID: 12187
		[CompilerGenerated]
		private sealed class Class3036
		{
			// Token: 0x0600F06F RID: 61551 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600F070 RID: 61552 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(PointerEventData arg)
			{
				throw null;
			}

			// Token: 0x0600F071 RID: 61553 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(PointerEventData arg)
			{
				throw null;
			}

			// Token: 0x0400F612 RID: 62994
			public OfferItemDescription offerItemDescription_0;

			// Token: 0x0400F613 RID: 62995
			public Offer offer;
		}

		// Token: 0x02002F9C RID: 12188
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3037
		{
			// Token: 0x0600F072 RID: 61554 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600F073 RID: 61555 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(string x)
			{
				throw null;
			}

			// Token: 0x0600F074 RID: 61556 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_2(RepairableComponent x)
			{
				throw null;
			}

			// Token: 0x0600F075 RID: 61557 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_3(RepairableComponent x)
			{
				throw null;
			}

			// Token: 0x0400F614 RID: 62996
			public static readonly OfferItemDescription.Class3037 class3037_0;

			// Token: 0x0400F615 RID: 62997
			public static Action action_0;

			// Token: 0x0400F616 RID: 62998
			public static Func<string, string> func_0;

			// Token: 0x0400F617 RID: 62999
			public static Func<RepairableComponent, float> func_1;

			// Token: 0x0400F618 RID: 63000
			public static Func<RepairableComponent, float> func_2;
		}
	}
}
