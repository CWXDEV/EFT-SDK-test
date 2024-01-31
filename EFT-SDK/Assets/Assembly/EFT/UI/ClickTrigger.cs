using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002C33 RID: 11315
	public sealed class ClickTrigger : MonoBehaviour, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x0600DEFF RID: 57087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Action<PointerEventData> onClick)
		{
			throw null;
		}

		// Token: 0x0600DF00 RID: 57088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400E3DE RID: 58334
		private Action<PointerEventData> action_0;
	}
}
