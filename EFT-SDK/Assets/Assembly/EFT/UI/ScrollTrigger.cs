using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002C49 RID: 11337
	public sealed class ScrollTrigger : MonoBehaviour, IEventSystemHandler, IScrollHandler
	{
		// Token: 0x14000312 RID: 786
		// (add) Token: 0x0600DF75 RID: 57205 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DF76 RID: 57206 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<PointerEventData> OnOnScroll
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

		// Token: 0x0600DF77 RID: 57207 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400E43A RID: 58426
		[CompilerGenerated]
		private Action<PointerEventData> action_0;
	}
}
