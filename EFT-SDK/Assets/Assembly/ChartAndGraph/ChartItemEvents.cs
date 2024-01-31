using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace ChartAndGraph
{
	// Token: 0x02003159 RID: 12633
	internal class ChartItemEvents : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, Interface20
	{
		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x0600F806 RID: 63494 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F807 RID: 63495 RVA: 0x00002050 File Offset: 0x00000250
		IInternalUse Interface20.Parent
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

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x0600F808 RID: 63496 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F809 RID: 63497 RVA: 0x00002050 File Offset: 0x00000250
		object Interface20.UserData
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

		// Token: 0x0600F80A RID: 63498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMouseEnter()
		{
			throw null;
		}

		// Token: 0x0600F80B RID: 63499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnMouseExit()
		{
			throw null;
		}

		// Token: 0x0600F80C RID: 63500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMouseDown()
		{
			throw null;
		}

		// Token: 0x0600F80D RID: 63501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnMouseUp()
		{
			throw null;
		}

		// Token: 0x0600F80E RID: 63502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([CanBeNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F80F RID: 63503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([CanBeNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F810 RID: 63504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown([CanBeNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F811 RID: 63505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUp([CanBeNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400FD19 RID: 64793
		[SerializeField]
		private ChartItemTextBlend _textBlend;

		// Token: 0x0400FD1A RID: 64794
		private bool bool_0;

		// Token: 0x0400FD1B RID: 64795
		private bool bool_1;

		// Token: 0x0400FD1C RID: 64796
		private IInternalUse iinternalUse_0;

		// Token: 0x0400FD1D RID: 64797
		private object object_0;

		// Token: 0x0200315A RID: 12634
		[Serializable]
		public class Event : UnityEvent<GameObject>
		{
		}
	}
}
