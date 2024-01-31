using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002BD4 RID: 11220
	public sealed class ClothingItem : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x0600DD35 RID: 56629 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DD36 RID: 56630 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsPurchased
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x0600DD37 RID: 56631 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DD38 RID: 56632 RVA: 0x00002050 File Offset: 0x00000250
		public ClothingItem.GClass3071 Offer
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600DD39 RID: 56633 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Action<ClothingItem> onEquip, Action<ClothingItem> onTestFit, string clothingName, ClothingItem.GClass3071 offer, Profile profile, Profile.TraderInfo traderInfo, GClass3359 questBook, GClass2495 stashGrid)
		{
			throw null;
		}

		// Token: 0x0600DD3A RID: 56634 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600DD3B RID: 56635 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLock(bool isLocked)
		{
			throw null;
		}

		// Token: 0x0600DD3C RID: 56636 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetState(ClothingItem.EClothingItemState state)
		{
			throw null;
		}

		// Token: 0x0600DD3D RID: 56637 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600DD3E RID: 56638 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DD3F RID: 56639 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DD40 RID: 56640 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400E195 RID: 57749
		[SerializeField]
		private Image _backgroud;

		// Token: 0x0400E196 RID: 57750
		[SerializeField]
		private TextMeshProUGUI _clothingName;

		// Token: 0x0400E197 RID: 57751
		[SerializeField]
		private Image _clothingIcon;

		// Token: 0x0400E198 RID: 57752
		[SerializeField]
		private Image _clothingIconBorder;

		// Token: 0x0400E199 RID: 57753
		[SerializeField]
		private ColorMap _backgroudColor;

		// Token: 0x0400E19A RID: 57754
		[SerializeField]
		private ColorMap _textColor;

		// Token: 0x0400E19B RID: 57755
		[SerializeField]
		private Transform _defaultState;

		// Token: 0x0400E19C RID: 57756
		[SerializeField]
		private Transform _hoveredState;

		// Token: 0x0400E19D RID: 57757
		[SerializeField]
		private ClothingRequirements _clothingRequirements;

		// Token: 0x0400E19E RID: 57758
		[SerializeField]
		private Dictionary<ClothingItem.EClothingItemState, GameObject[]> _clothingItemStates;

		// Token: 0x0400E19F RID: 57759
		private Action<ClothingItem> action_0;

		// Token: 0x0400E1A0 RID: 57760
		private Action<ClothingItem> action_1;

		// Token: 0x0400E1A1 RID: 57761
		private GClass2942 gclass2942_0;

		// Token: 0x0400E1A2 RID: 57762
		private ClothingItem.EClothingItemState eclothingItemState_0;

		// Token: 0x0400E1A3 RID: 57763
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400E1A4 RID: 57764
		[CompilerGenerated]
		private ClothingItem.GClass3071 gclass3071_0;

		// Token: 0x02002BD5 RID: 11221
		public enum EClothingItemState
		{
			// Token: 0x0400E1A6 RID: 57766
			Locked,
			// Token: 0x0400E1A7 RID: 57767
			PurchaseAvailable,
			// Token: 0x0400E1A8 RID: 57768
			Purchased,
			// Token: 0x0400E1A9 RID: 57769
			Selected,
			// Token: 0x0400E1AA RID: 57770
			TestFit
		}

		// Token: 0x02002BD6 RID: 11222
		public sealed class GClass3071
		{
			// Token: 0x0400E1AB RID: 57771
			public GClass2938 Offer;

			// Token: 0x0400E1AC RID: 57772
			public GClass2934 Suite;

			// Token: 0x0400E1AD RID: 57773
			public GClass2933 Clothing;
		}

		// Token: 0x02002BD7 RID: 11223
		public sealed class GClass3072 : IComparer<ClothingItem.GClass3071>
		{
			// Token: 0x0600DD41 RID: 56641 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Compare(ClothingItem.GClass3071 x, ClothingItem.GClass3071 y)
			{
				throw null;
			}

			// Token: 0x0400E1AE RID: 57774
			private readonly GClass1441 gclass1441_0;
		}

		// Token: 0x02002BD8 RID: 11224
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2665
		{
			// Token: 0x0600DD42 RID: 56642 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool _)
			{
				throw null;
			}

			// Token: 0x0400E1AF RID: 57775
			public static readonly ClothingItem.Class2665 class2665_0;

			// Token: 0x0400E1B0 RID: 57776
			public static Action<bool> action_0;
		}
	}
}
