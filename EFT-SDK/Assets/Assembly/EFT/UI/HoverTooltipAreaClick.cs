using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002B09 RID: 11017
	public sealed class HoverTooltipAreaClick : HoverTooltipArea, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x0600DAA8 RID: 55976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}
	}
}
