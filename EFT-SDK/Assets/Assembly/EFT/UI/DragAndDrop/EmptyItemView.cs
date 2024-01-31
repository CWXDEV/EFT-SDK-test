using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E28 RID: 11816
	public sealed class EmptyItemView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
	{
		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x0600E8D4 RID: 59604 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E8D5 RID: 59605 RVA: 0x00002050 File Offset: 0x00000250
		public bool Interactable
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

		// Token: 0x0600E8D6 RID: 59606 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2817 itemContext)
		{
			throw null;
		}

		// Token: 0x0600E8D7 RID: 59607 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E8D8 RID: 59608 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E8D9 RID: 59609 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E8DA RID: 59610 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400EDB1 RID: 60849
		[SerializeField]
		private CanvasGroup _highlight;

		// Token: 0x0400EDB2 RID: 60850
		private GClass2817 gclass2817_0;

		// Token: 0x0400EDB3 RID: 60851
		private bool bool_0;
	}
}
