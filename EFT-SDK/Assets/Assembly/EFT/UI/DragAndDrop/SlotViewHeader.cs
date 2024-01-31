using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E13 RID: 11795
	public sealed class SlotViewHeader : ButtonFeedback
	{
		// Token: 0x14000349 RID: 841
		// (add) Token: 0x0600E851 RID: 59473 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E852 RID: 59474 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool> OnSelected
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

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x0600E853 RID: 59475 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E854 RID: 59476 RVA: 0x00002050 File Offset: 0x00000250
		public override bool Interactable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600E855 RID: 59477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(InventoryControllerClass inventoryController, Slot slot, bool canBeSelected)
		{
			throw null;
		}

		// Token: 0x0600E856 RID: 59478 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected(bool selected, bool sendCallback = true)
		{
			throw null;
		}

		// Token: 0x0600E857 RID: 59479 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool selected)
		{
			throw null;
		}

		// Token: 0x0600E858 RID: 59480 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E859 RID: 59481 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E85A RID: 59482 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400ED60 RID: 60768
		[CompilerGenerated]
		private Action<bool> action_0;

		// Token: 0x0400ED61 RID: 60769
		[SerializeField]
		private Image _arrow;

		// Token: 0x0400ED62 RID: 60770
		[SerializeField]
		private GameObject _backgroundSelected;

		// Token: 0x0400ED63 RID: 60771
		[SerializeField]
		private GameObject _backgroundIdle;

		// Token: 0x0400ED64 RID: 60772
		[SerializeField]
		private Sprite _arrowSelected;

		// Token: 0x0400ED65 RID: 60773
		[SerializeField]
		private Sprite _arrowIdle;

		// Token: 0x0400ED66 RID: 60774
		[SerializeField]
		private TextMeshProUGUI _headerText;

		// Token: 0x0400ED67 RID: 60775
		[SerializeField]
		private Color _idleColor;

		// Token: 0x0400ED68 RID: 60776
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x0400ED69 RID: 60777
		private bool bool_0;
	}
}
