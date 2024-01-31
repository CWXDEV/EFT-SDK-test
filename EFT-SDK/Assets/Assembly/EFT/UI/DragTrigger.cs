using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002C36 RID: 11318
	public class DragTrigger : MonoBehaviour, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
	{
		// Token: 0x1400030D RID: 781
		// (add) Token: 0x0600DF03 RID: 57091 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DF04 RID: 57092 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<PointerEventData> onDrag
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

		// Token: 0x1400030E RID: 782
		// (add) Token: 0x0600DF05 RID: 57093 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DF06 RID: 57094 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<PointerEventData> onBeginDrag
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

		// Token: 0x1400030F RID: 783
		// (add) Token: 0x0600DF07 RID: 57095 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DF08 RID: 57096 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<PointerEventData> onEndDrag
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

		// Token: 0x0600DF09 RID: 57097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDrag([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DF0A RID: 57098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnBeginDrag([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DF0B RID: 57099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnEndDrag([NotNull] PointerEventData eventData)
		{
			throw null;
		}
	}
}
