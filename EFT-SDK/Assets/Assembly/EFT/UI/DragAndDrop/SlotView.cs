using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E0F RID: 11791
	public class SlotView : UIElement, GInterface104, GInterface105, GInterface106, GInterface117, GInterface118, GInterface376
	{
		// Token: 0x14000346 RID: 838
		// (add) Token: 0x0600E81A RID: 59418 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E81B RID: 59419 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<GClass2821> OnItemHover
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

		// Token: 0x14000347 RID: 839
		// (add) Token: 0x0600E81C RID: 59420 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E81D RID: 59421 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnDragStarted
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

		// Token: 0x14000348 RID: 840
		// (add) Token: 0x0600E81E RID: 59422 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E81F RID: 59423 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnDragCancelled
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

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x0600E820 RID: 59424 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E821 RID: 59425 RVA: 0x00002050 File Offset: 0x00000250
		private GClass2809 ParentItemContext
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x0600E822 RID: 59426 RVA: 0x00002050 File Offset: 0x00000250
		public ItemView ContainedItemView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x0600E823 RID: 59427 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E824 RID: 59428 RVA: 0x00002050 File Offset: 0x00000250
		public Slot Slot
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

		// Token: 0x0600E825 RID: 59429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Start()
		{
			throw null;
		}

		// Token: 0x0600E826 RID: 59430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Show(Slot slot, GClass2809 parentItemContext, InventoryControllerClass inventoryController, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompanyClass insurance, bool canClickOnHeader = false)
		{
			throw null;
		}

		// Token: 0x0600E827 RID: 59431 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool selected)
		{
			throw null;
		}

		// Token: 0x0600E828 RID: 59432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual ItemView CreateItemViewKernel(Item item, IItemOwner itemOwner)
		{
			throw null;
		}

		// Token: 0x0600E829 RID: 59433 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetSlotBackImage([CanBeNull] Sprite sprite)
		{
			throw null;
		}

		// Token: 0x0600E82A RID: 59434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemAdded(GEventArgs2 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E82B RID: 59435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemRemoved(GEventArgs3 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E82C RID: 59436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetupItemView(Item item)
		{
			throw null;
		}

		// Token: 0x0600E82D RID: 59437 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600E82E RID: 59438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass2821 dragItemContext)
		{
			throw null;
		}

		// Token: 0x0600E82F RID: 59439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(InventoryError error)
		{
			throw null;
		}

		// Token: 0x0600E830 RID: 59440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_4()
		{
			throw null;
		}

		// Token: 0x0600E831 RID: 59441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Item item, IItemOwner itemOwner = null)
		{
			throw null;
		}

		// Token: 0x0600E832 RID: 59442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnAddToSlot(Item item, GEventArgs2 args)
		{
			throw null;
		}

		// Token: 0x0600E833 RID: 59443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600E834 RID: 59444 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnRemoveFromSlot(Item item, GEventArgs3 args)
		{
			throw null;
		}

		// Token: 0x0600E835 RID: 59445 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSetInHands(GEventArgs10 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E836 RID: 59446 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRemoveFromHands(GEventArgs11 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E837 RID: 59447 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ScaleItem(Vector2 size)
		{
			throw null;
		}

		// Token: 0x0600E838 RID: 59448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetSlotGraphics(bool fullSlot, bool selected)
		{
			throw null;
		}

		// Token: 0x0600E839 RID: 59449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanAccept(GClass2821 itemContext, GClass2809 targetItemContext, out GStruct412 operation)
		{
			throw null;
		}

		// Token: 0x0600E83A RID: 59450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HighlightItemViewPosition(GClass2821 itemContext, GClass2809 targetItemContext, bool preview)
		{
			throw null;
		}

		// Token: 0x0600E83B RID: 59451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Color smethod_0(GStruct412 possibleAction)
		{
			throw null;
		}

		// Token: 0x0600E83C RID: 59452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600E83D RID: 59453 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableHighlight()
		{
			throw null;
		}

		// Token: 0x0600E83E RID: 59454 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DragStarted()
		{
			throw null;
		}

		// Token: 0x0600E83F RID: 59455 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DragCancelled()
		{
			throw null;
		}

		// Token: 0x0600E840 RID: 59456 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task AcceptItem(GClass2821 itemContext, GClass2809 targetItemContext)
		{
			throw null;
		}

		// Token: 0x0600E841 RID: 59457 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanDrag(GClass2809 itemContext)
		{
			throw null;
		}

		// Token: 0x0600E842 RID: 59458 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E843 RID: 59459 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1(IResult result)
		{
			throw null;
		}

		// Token: 0x0600E844 RID: 59460 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600E845 RID: 59461 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600E846 RID: 59462 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600E847 RID: 59463 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600E848 RID: 59464 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x0400ED32 RID: 60722
		private static readonly WaitForEndOfFrame waitForEndOfFrame_0;

		// Token: 0x0400ED33 RID: 60723
		[SerializeField]
		protected Image FullBorder;

		// Token: 0x0400ED34 RID: 60724
		[SerializeField]
		protected GameObject SearchIcon;

		// Token: 0x0400ED35 RID: 60725
		[SerializeField]
		protected Image SlotBackImage;

		// Token: 0x0400ED36 RID: 60726
		[SerializeField]
		protected Image ActiveCamoraImage;

		// Token: 0x0400ED37 RID: 60727
		[SerializeField]
		private RectTransform _slotPlace;

		// Token: 0x0400ED38 RID: 60728
		[SerializeField]
		private Image _slotBackground;

		// Token: 0x0400ED39 RID: 60729
		[SerializeField]
		private Image _emptyBorder;

		// Token: 0x0400ED3A RID: 60730
		[SerializeField]
		private Image _selectedBorder;

		// Token: 0x0400ED3B RID: 60731
		[SerializeField]
		private Image _selectedCorner;

		// Token: 0x0400ED3C RID: 60732
		[SerializeField]
		private TextMeshProUGUI _headerText;

		// Token: 0x0400ED3D RID: 60733
		[SerializeField]
		private SlotViewHeader _slotHeader;

		// Token: 0x0400ED3E RID: 60734
		[CompilerGenerated]
		private Action<GClass2821> action_0;

		// Token: 0x0400ED3F RID: 60735
		[CompilerGenerated]
		private Action action_1;

		// Token: 0x0400ED40 RID: 60736
		[CompilerGenerated]
		private Action action_2;

		// Token: 0x0400ED41 RID: 60737
		private static readonly Color color_0;

		// Token: 0x0400ED42 RID: 60738
		private static readonly Color color_1;

		// Token: 0x0400ED43 RID: 60739
		private static readonly Color color_2;

		// Token: 0x0400ED44 RID: 60740
		private static readonly Color color_3;

		// Token: 0x0400ED45 RID: 60741
		internal ItemView itemView_0;

		// Token: 0x0400ED46 RID: 60742
		[CompilerGenerated]
		private GClass2809 gclass2809_0;

		// Token: 0x0400ED47 RID: 60743
		protected IItemOwner ItemOwner;

		// Token: 0x0400ED48 RID: 60744
		protected InventoryControllerClass InventoryController;

		// Token: 0x0400ED49 RID: 60745
		protected SkillManager Skills;

		// Token: 0x0400ED4A RID: 60746
		protected InsuranceCompanyClass InsuranceCompany;

		// Token: 0x0400ED4B RID: 60747
		protected Sprite CachedSprite;

		// Token: 0x0400ED4C RID: 60748
		protected ItemUiContext ItemUiContext;

		// Token: 0x0400ED4D RID: 60749
		protected bool HighlightedGlobally;

		// Token: 0x0400ED4E RID: 60750
		private Color color_4;

		// Token: 0x0400ED4F RID: 60751
		private Color color_5;

		// Token: 0x0400ED50 RID: 60752
		private Color color_6;

		// Token: 0x0400ED51 RID: 60753
		private bool bool_0;

		// Token: 0x0400ED52 RID: 60754
		private Action action_3;

		// Token: 0x0400ED53 RID: 60755
		private GClass3085 gclass3085_0;

		// Token: 0x0400ED54 RID: 60756
		[CompilerGenerated]
		private Slot slot_0;

		// Token: 0x02002E11 RID: 11793
		[CompilerGenerated]
		private sealed class Class2878
		{
			// Token: 0x0600E84D RID: 59469 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(int count)
			{
				throw null;
			}

			// Token: 0x0600E84E RID: 59470 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(int count)
			{
				throw null;
			}

			// Token: 0x0400ED58 RID: 60760
			public SlotView slotView_0;
		}
	}
}
