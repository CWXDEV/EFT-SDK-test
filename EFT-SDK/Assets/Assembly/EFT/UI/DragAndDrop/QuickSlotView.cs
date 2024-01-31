using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E0B RID: 11787
	public abstract class QuickSlotView : UIInputNode, GInterface376
	{
		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x0600E7EC RID: 59372 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E7ED RID: 59373 RVA: 0x00002050 File Offset: 0x00000250
		private EBoundItem BoundIndex
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

		// Token: 0x0600E7EE RID: 59374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetBoundIndex(EBoundItem boundIndex)
		{
			throw null;
		}

		// Token: 0x0600E7EF RID: 59375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetItem(Item item, InventoryControllerClass controller, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600E7F0 RID: 59376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshSelection(Item itemInHands)
		{
			throw null;
		}

		// Token: 0x0600E7F1 RID: 59377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Hide()
		{
			throw null;
		}

		// Token: 0x0600E7F2 RID: 59378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetIconScale()
		{
			throw null;
		}

		// Token: 0x0600E7F3 RID: 59379 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RemoveItemView()
		{
			throw null;
		}

		// Token: 0x0600E7F4 RID: 59380 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Awake()
		{
			throw null;
		}

		// Token: 0x0600E7F5 RID: 59381 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600E7F6 RID: 59382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ShowInfoPanel([CanBeNull] Item item)
		{
			throw null;
		}

		// Token: 0x0600E7F7 RID: 59383 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HighlightItemViewPosition(GClass2821 itemContext, GClass2809 targetItemContext, bool preview)
		{
			throw null;
		}

		// Token: 0x0600E7F8 RID: 59384 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableHighlight()
		{
			throw null;
		}

		// Token: 0x0600E7F9 RID: 59385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchVisualSelection(bool selected)
		{
			throw null;
		}

		// Token: 0x0600E7FA RID: 59386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2 ShowArrow(bool show)
		{
			throw null;
		}

		// Token: 0x0600E7FB RID: 59387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowQuickdrawGlow(bool show, float duration)
		{
			throw null;
		}

		// Token: 0x0600E7FC RID: 59388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DragStarted()
		{
			throw null;
		}

		// Token: 0x0600E7FD RID: 59389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DragCancelled()
		{
			throw null;
		}

		// Token: 0x0600E7FE RID: 59390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task AcceptItem(GClass2821 itemContext, GClass2809 targetItemContext)
		{
			throw null;
		}

		// Token: 0x0600E7FF RID: 59391
		public abstract bool CanDrag(GClass2809 itemContext);

		// Token: 0x0600E800 RID: 59392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RemoveItemViewForced()
		{
			throw null;
		}

		// Token: 0x0600E801 RID: 59393
		public abstract bool CanAccept(GClass2821 itemContext, GClass2809 targetItemContext, out GStruct412 operation);

		// Token: 0x0600E802 RID: 59394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600E803 RID: 59395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600E804 RID: 59396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E805 RID: 59397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E806 RID: 59398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400ED0F RID: 60687
		public Func<EBoundItem, Item, bool> TryShowSelectorCommand;

		// Token: 0x0400ED10 RID: 60688
		[SerializeField]
		protected Image InstallPlace;

		// Token: 0x0400ED11 RID: 60689
		[SerializeField]
		protected CustomTextMeshProUGUI HotKey;

		// Token: 0x0400ED12 RID: 60690
		[SerializeField]
		protected CustomTextMeshProUGUI Caption;

		// Token: 0x0400ED13 RID: 60691
		[SerializeField]
		protected Image Border;

		// Token: 0x0400ED14 RID: 60692
		[SerializeField]
		protected Image Background;

		// Token: 0x0400ED15 RID: 60693
		[SerializeField]
		private Image _arrow;

		// Token: 0x0400ED16 RID: 60694
		protected InventoryControllerClass InventoryController;

		// Token: 0x0400ED17 RID: 60695
		protected ItemUiContext ItemUiContext;

		// Token: 0x0400ED18 RID: 60696
		protected ItemView ItemView;

		// Token: 0x0400ED19 RID: 60697
		protected Item Item;

		// Token: 0x0400ED1A RID: 60698
		[CompilerGenerated]
		private EBoundItem eboundItem_0;

		// Token: 0x0400ED1B RID: 60699
		private bool bool_0;

		// Token: 0x0400ED1C RID: 60700
		private bool bool_1;
	}
}
