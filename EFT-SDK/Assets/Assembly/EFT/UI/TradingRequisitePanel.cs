using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002C08 RID: 11272
	public sealed class TradingRequisitePanel : ItemOnGrid, IEventSystemHandler, IPointerClickHandler, GInterface376
	{
		// Token: 0x0600DE2B RID: 56875 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DE2C RID: 56876 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DE2D RID: 56877 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2045 requisite, TraderAssortmentControllerClass trader)
		{
			throw null;
		}

		// Token: 0x0600DE2E RID: 56878 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600DE2F RID: 56879 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HighlightItemViewPosition(GClass2821 itemContext, GClass2809 targetItemContext, bool preview)
		{
			throw null;
		}

		// Token: 0x0600DE30 RID: 56880 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableHighlight()
		{
			throw null;
		}

		// Token: 0x0600DE31 RID: 56881 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DragStarted()
		{
			throw null;
		}

		// Token: 0x0600DE32 RID: 56882 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DragCancelled()
		{
			throw null;
		}

		// Token: 0x0600DE33 RID: 56883 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanAccept(GClass2821 itemContext, GClass2809 targetItemContext, out GStruct412 operation)
		{
			throw null;
		}

		// Token: 0x0600DE34 RID: 56884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanDrag(GClass2809 itemContext)
		{
			throw null;
		}

		// Token: 0x0600DE35 RID: 56885 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task AcceptItem(GClass2821 itemContext, GClass2809 targetItemContext)
		{
			throw null;
		}

		// Token: 0x0600DE36 RID: 56886 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DE37 RID: 56887 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0600DE38 RID: 56888 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0400E2FF RID: 58111
		[SerializeField]
		private CustomTextMeshProUGUI _count;

		// Token: 0x0400E300 RID: 58112
		[SerializeField]
		private CustomTextMeshProUGUI _dogtagLevel;

		// Token: 0x0400E301 RID: 58113
		[SerializeField]
		private CustomTextMeshProUGUI _dogtagSide;

		// Token: 0x0400E302 RID: 58114
		[SerializeField]
		private GameObject _yesCheck;

		// Token: 0x0400E303 RID: 58115
		[SerializeField]
		private GameObject _noCheck;

		// Token: 0x0400E304 RID: 58116
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400E305 RID: 58117
		private GClass2045 gclass2045_0;

		// Token: 0x0400E306 RID: 58118
		private TraderAssortmentControllerClass gclass2043_0;

		// Token: 0x0400E307 RID: 58119
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400E308 RID: 58120
		private GClass2809 gclass2809_0;
	}
}
