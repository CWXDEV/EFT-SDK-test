using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.HealthSystem;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002A33 RID: 10803
	public class InventoryScreenQuickAccessPanel : UIInputNode
	{
		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x0600D696 RID: 54934 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D697 RID: 54935 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsDisabled
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

		// Token: 0x0600D698 RID: 54936 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D699 RID: 54937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(InventoryControllerClass inventoryController, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600D69A RID: 54938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(InventoryControllerClass inventoryController, ItemUiContext itemUiContext, GamePlayerOwner owner, InsuranceCompanyClass insurance)
		{
			throw null;
		}

		// Token: 0x0600D69B RID: 54939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshSelection(Item itemInHands)
		{
			throw null;
		}

		// Token: 0x0600D69C RID: 54940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshBoundSlotSelectView(Item itemInHads)
		{
			throw null;
		}

		// Token: 0x0600D69D RID: 54941 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AnimatedShow(bool autohide)
		{
			throw null;
		}

		// Token: 0x0600D69E RID: 54942 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AnimatedHide(float delaySeconds = 0f)
		{
			throw null;
		}

		// Token: 0x0600D69F RID: 54943 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600D6A0 RID: 54944 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(Item item, out EBoundItem result)
		{
			throw null;
		}

		// Token: 0x0600D6A1 RID: 54945 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetItemSelected(EBoundItem slot, bool isSelected)
		{
			throw null;
		}

		// Token: 0x0600D6A2 RID: 54946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowQuickdrawGlowForPistols(bool show, float duration)
		{
			throw null;
		}

		// Token: 0x0600D6A3 RID: 54947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2(EBoundItem boundIndex, Item item)
		{
			throw null;
		}

		// Token: 0x0600D6A4 RID: 54948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_3(EBoundItem boundIndex, Item item, IHealthController healthController, List<EBodyPart> limbs)
		{
			throw null;
		}

		// Token: 0x0600D6A5 RID: 54949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(bool visible)
		{
			throw null;
		}

		// Token: 0x0600D6A6 RID: 54950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D6A7 RID: 54951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600D6A8 RID: 54952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600D6A9 RID: 54953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_5()
		{
			throw null;
		}

		// Token: 0x0600D6AA RID: 54954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_6(EBoundItem slot, InventoryControllerClass controller, IEnumerable<Item> ammo, Weapon weapon)
		{
			throw null;
		}

		// Token: 0x0400D914 RID: 55572
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400D915 RID: 55573
		[SerializeField]
		private InventoryScreenQuickAccessPanel.BoundSlotViewDictionary _boundSlots;

		// Token: 0x0400D916 RID: 55574
		[SerializeField]
		private InventoryScreenQuickAccessPanel.BoundItemViewDictionary _boundItems;

		// Token: 0x0400D917 RID: 55575
		[SerializeField]
		private HealingLimbSelector healingSelector;

		// Token: 0x0400D918 RID: 55576
		[SerializeField]
		private AmmoSelector ammoSelector;

		// Token: 0x0400D919 RID: 55577
		private BattleUIComponentAnimation battleUIComponentAnimation_0;

		// Token: 0x0400D91A RID: 55578
		private GamePlayerOwner gamePlayerOwner_0;

		// Token: 0x0400D91B RID: 55579
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x02002A34 RID: 10804
		[Serializable]
		public class BoundSlotViewDictionary : SerializableEnumDictionary<EBoundItem, BoundSlotView>
		{
		}

		// Token: 0x02002A35 RID: 10805
		[Serializable]
		public class BoundItemViewDictionary : SerializableEnumDictionary<EBoundItem, BoundItemView>
		{
		}
	}
}
