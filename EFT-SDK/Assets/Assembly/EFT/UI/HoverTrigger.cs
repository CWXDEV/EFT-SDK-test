using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002C3A RID: 11322
	public sealed class HoverTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x14000310 RID: 784
		// (add) Token: 0x0600DF20 RID: 57120 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DF21 RID: 57121 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<PointerEventData> OnHoverStart
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

		// Token: 0x14000311 RID: 785
		// (add) Token: 0x0600DF22 RID: 57122 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DF23 RID: 57123 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<PointerEventData> OnHoverEnd
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

		// Token: 0x0600DF24 RID: 57124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init([CanBeNull] Action<PointerEventData> onHoverStart, [CanBeNull] Action<PointerEventData> onHoverEnd)
		{
			throw null;
		}

		// Token: 0x0600DF25 RID: 57125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DF26 RID: 57126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400E3FB RID: 58363
		[CompilerGenerated]
		private Action<PointerEventData> action_0;

		// Token: 0x0400E3FC RID: 58364
		[CompilerGenerated]
		private Action<PointerEventData> action_1;
	}
}
