using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E29 RID: 11817
	public class GridItemView : ItemView, GInterface104, GInterface105, GInterface106, GInterface107, GInterface108, GInterface109, GInterface110, GInterface111, GInterface112, GInterface114, GInterface115, GInterface116
	{
		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x0600E8DB RID: 59611 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual string ValueFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x0600E8DC RID: 59612 RVA: 0x00002050 File Offset: 0x00000250
		private ItemClass GClass3180_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x0600E8DD RID: 59613 RVA: 0x00002050 File Offset: 0x00000250
		protected Image SecureIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x0600E8DE RID: 59614 RVA: 0x00002050 File Offset: 0x00000250
		protected Image LockedIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x0600E8DF RID: 59615 RVA: 0x00002050 File Offset: 0x00000250
		protected Image TogglableIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x0600E8E0 RID: 59616 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool IsInteractable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E8E1 RID: 59617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnBeingExaminedChanged(bool isBeingExamined)
		{
			throw null;
		}

		// Token: 0x0600E8E2 RID: 59618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GridItemView Create(Item item, GClass2809 sourceContext, ItemRotation rotation, TraderControllerClass itemController, IItemOwner itemOwner, [CanBeNull] FilterPanel filterPanel, [CanBeNull] GInterface376 container, [CanBeNull] ItemUiContext itemUiContext, InsuranceCompanyClass insurance, bool isSearched)
		{
			throw null;
		}

		// Token: 0x0600E8E3 RID: 59619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected GridItemView NewGridItemView(Item item, GClass2809 sourceContext, ItemRotation rotation, TraderControllerClass itemController, IItemOwner itemOwner, [CanBeNull] FilterPanel filterPanel, [CanBeNull] GInterface376 container, [CanBeNull] ItemUiContext itemUiContext, InsuranceCompanyClass insurance, bool isSearched = true)
		{
			throw null;
		}

		// Token: 0x0600E8E4 RID: 59620 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnClick(PointerEventData.InputButton button, Vector2 position, bool doubleClick)
		{
			throw null;
		}

		// Token: 0x0600E8E5 RID: 59621 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(bool selected)
		{
			throw null;
		}

		// Token: 0x0600E8E6 RID: 59622 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600E8E7 RID: 59623 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(InventoryError error)
		{
			throw null;
		}

		// Token: 0x0600E8E8 RID: 59624 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(GClass2821 dragItemContext)
		{
			throw null;
		}

		// Token: 0x0600E8E9 RID: 59625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x0600E8EA RID: 59626 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CheckAcceptHandler(GClass2821 dragItemContext)
		{
			throw null;
		}

		// Token: 0x0600E8EB RID: 59627 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(bool dragged)
		{
			throw null;
		}

		// Token: 0x0600E8EC RID: 59628 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E8ED RID: 59629 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E8EE RID: 59630 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ChangeInsuredStatus(ItemClass item)
		{
			throw null;
		}

		// Token: 0x0600E8EF RID: 59631 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(bool enable)
		{
			throw null;
		}

		// Token: 0x0600E8F0 RID: 59632 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ChangeRepairBuffStatus()
		{
			throw null;
		}

		// Token: 0x0600E8F1 RID: 59633 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_18(out BuffComponent buff)
		{
			throw null;
		}

		// Token: 0x0600E8F2 RID: 59634 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<BuffComponent> method_19()
		{
			throw null;
		}

		// Token: 0x0600E8F3 RID: 59635 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRefreshItem(GEventArgs22 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E8F4 RID: 59636 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20()
		{
			throw null;
		}

		// Token: 0x0600E8F5 RID: 59637 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_21()
		{
			throw null;
		}

		// Token: 0x0600E8F6 RID: 59638 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnItemAdded(GEventArgs2 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E8F7 RID: 59639 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnItemRemoved(GEventArgs3 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E8F8 RID: 59640 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMagazineChange(MagazineClass magazine)
		{
			throw null;
		}

		// Token: 0x0600E8F9 RID: 59641 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnInventoryMagazineCheck(MagazineClass magazine, float speed, bool status)
		{
			throw null;
		}

		// Token: 0x0600E8FA RID: 59642 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22([CanBeNull] ItemAddress location)
		{
			throw null;
		}

		// Token: 0x0600E8FB RID: 59643 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUnbindItem(GEventArgs13 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E8FC RID: 59644 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnBindItem(GEventArgs12 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E8FD RID: 59645 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrain(GEventArgs14 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E8FE RID: 59646 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_23(GEventArgs6 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E8FF RID: 59647 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLoadMagazine(GEventArgs7 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E900 RID: 59648 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUnloadMagazine(GEventArgs8 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E901 RID: 59649 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMerge(GEventArgs20 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E902 RID: 59650 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string GetErrorText()
		{
			throw null;
		}

		// Token: 0x0600E903 RID: 59651 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_24(GClass2629 armorPlate, GClass2507 armorSlot)
		{
			throw null;
		}

		// Token: 0x0600E904 RID: 59652 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ShowTooltip()
		{
			throw null;
		}

		// Token: 0x0600E905 RID: 59653 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void HideTooltip()
		{
			throw null;
		}

		// Token: 0x0600E906 RID: 59654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E907 RID: 59655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E908 RID: 59656 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateStaticInfo()
		{
			throw null;
		}

		// Token: 0x0600E909 RID: 59657 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static string GetStackColor(Item item)
		{
			throw null;
		}

		// Token: 0x0600E90A RID: 59658 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_25(ItemAddress itemAddress)
		{
			throw null;
		}

		// Token: 0x0600E90B RID: 59659 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_26(ItemAddress itemAddress)
		{
			throw null;
		}

		// Token: 0x0600E90C RID: 59660 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateInfo()
		{
			throw null;
		}

		// Token: 0x0600E90D RID: 59661 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_27(ItemAddress nextAddress)
		{
			throw null;
		}

		// Token: 0x0600E90E RID: 59662 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetCountValue()
		{
			throw null;
		}

		// Token: 0x0600E90F RID: 59663 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_28(Item item, out Weapon weapon)
		{
			throw null;
		}

		// Token: 0x0600E910 RID: 59664 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_29(Item item)
		{
			throw null;
		}

		// Token: 0x0600E911 RID: 59665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_30(Item item)
		{
			throw null;
		}

		// Token: 0x0600E912 RID: 59666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetItemValue(GridItemView.EItemValueFormat format, bool display, string color, object arg1, [CanBeNull] object arg2 = null, [CanBeNull] string color2 = null)
		{
			throw null;
		}

		// Token: 0x0600E913 RID: 59667 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_31()
		{
			throw null;
		}

		// Token: 0x0600E914 RID: 59668 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_32()
		{
			throw null;
		}

		// Token: 0x0600E915 RID: 59669 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_33()
		{
			throw null;
		}

		// Token: 0x0600E916 RID: 59670 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateInfoVisibility(bool isVisible)
		{
			throw null;
		}

		// Token: 0x0600E917 RID: 59671 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetItemBinding(EBoundItem? slotName)
		{
			throw null;
		}

		// Token: 0x0600E918 RID: 59672 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddCustomObjectToInfoPanel(RectTransform customObject, Vector2 anchoredPosition)
		{
			throw null;
		}

		// Token: 0x0600E919 RID: 59673 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Kill()
		{
			throw null;
		}

		// Token: 0x0400EDB4 RID: 60852
		private const float float_2 = 40f;

		// Token: 0x0400EDB5 RID: 60853
		private const float float_3 = 12f;

		// Token: 0x0400EDB6 RID: 60854
		private static Color color_0;

		// Token: 0x0400EDB7 RID: 60855
		private static Color color_1;

		// Token: 0x0400EDB8 RID: 60856
		[SerializeField]
		private Image _unsearchedBackground;

		// Token: 0x0400EDB9 RID: 60857
		[SerializeField]
		private Image _secureIcon;

		// Token: 0x0400EDBA RID: 60858
		[SerializeField]
		private Image _lockedIcon;

		// Token: 0x0400EDBB RID: 60859
		[SerializeField]
		private Image _togglableIcon;

		// Token: 0x0400EDBC RID: 60860
		[SerializeField]
		private Image _tagColor;

		// Token: 0x0400EDBD RID: 60861
		[SerializeField]
		private Image _missingLayout;

		// Token: 0x0400EDBE RID: 60862
		[SerializeField]
		protected ItemViewStats _itemViewStats;

		// Token: 0x0400EDBF RID: 60863
		[SerializeField]
		protected TextMeshProUGUI ItemInscription;

		// Token: 0x0400EDC0 RID: 60864
		[SerializeField]
		protected TextMeshProUGUI ItemValue;

		// Token: 0x0400EDC1 RID: 60865
		[SerializeField]
		protected TextMeshProUGUI Caption;

		// Token: 0x0400EDC2 RID: 60866
		[SerializeField]
		private TextMeshProUGUI TagName;

		// Token: 0x0400EDC3 RID: 60867
		[SerializeField]
		private BindPanel _bindPanel;

		// Token: 0x0400EDC4 RID: 60868
		[SerializeField]
		private RectTransform _infoPanel;

		// Token: 0x0400EDC5 RID: 60869
		[SerializeField]
		private GameObject _resizeRectPanelTemplate;

		// Token: 0x0400EDC6 RID: 60870
		[SerializeField]
		private PointerEventsProxy _valuePointerEventsProxy;

		// Token: 0x0400EDC7 RID: 60871
		public const float TOOLTIP_DELAY = 0.6f;

		// Token: 0x0400EDC8 RID: 60872
		private RectTransform rectTransform_1;

		// Token: 0x0400EDC9 RID: 60873
		private FilterPanel filterPanel_0;

		// Token: 0x0400EDCA RID: 60874
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400EDCB RID: 60875
		private bool bool_5;

		// Token: 0x0400EDCC RID: 60876
		private bool bool_6;

		// Token: 0x0400EDCD RID: 60877
		private bool bool_7;

		// Token: 0x0400EDCE RID: 60878
		private GClass2816 gclass2816_0;

		// Token: 0x02002E2A RID: 11818
		protected enum EItemValueFormat
		{
			// Token: 0x0400EDD0 RID: 60880
			OneValue,
			// Token: 0x0400EDD1 RID: 60881
			TwoValues,
			// Token: 0x0400EDD2 RID: 60882
			Other
		}

		// Token: 0x02002E2B RID: 11819
		[CompilerGenerated]
		private sealed class Class2881
		{
			// Token: 0x0600E91A RID: 59674 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600E91B RID: 59675 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600E91C RID: 59676 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0600E91D RID: 59677 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x0600E91E RID: 59678 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4()
			{
				throw null;
			}

			// Token: 0x0600E91F RID: 59679 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_5()
			{
				throw null;
			}

			// Token: 0x0600E920 RID: 59680 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_6()
			{
				throw null;
			}

			// Token: 0x0600E921 RID: 59681 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_7()
			{
				throw null;
			}

			// Token: 0x0400EDD3 RID: 60883
			public GridItemView gridItemView_0;

			// Token: 0x0400EDD4 RID: 60884
			public Weapon weapon;

			// Token: 0x0400EDD5 RID: 60885
			public GClass2816 selectableContext;

			// Token: 0x0400EDD6 RID: 60886
			public FilterPanel filterPanel;
		}

		// Token: 0x02002E2C RID: 11820
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2882
		{
			// Token: 0x0600E922 RID: 59682 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(BuffComponent subBuff)
			{
				throw null;
			}

			// Token: 0x0600E923 RID: 59683 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_1(Slot x)
			{
				throw null;
			}

			// Token: 0x0400EDD7 RID: 60887
			public static readonly GridItemView.Class2882 class2882_0;

			// Token: 0x0400EDD8 RID: 60888
			public static Func<BuffComponent, int> func_0;

			// Token: 0x0400EDD9 RID: 60889
			public static Func<Slot, Item> func_1;
		}

		// Token: 0x02002E2F RID: 11823
		[CompilerGenerated]
		private sealed class Class2884
		{
			// Token: 0x0600E92C RID: 59692 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400EDE3 RID: 60899
			public RectTransform customObject;
		}
	}
}
