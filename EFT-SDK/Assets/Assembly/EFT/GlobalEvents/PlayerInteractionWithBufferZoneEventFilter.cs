using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.GlobalEvents
{
	// Token: 0x02002639 RID: 9785
	public class PlayerInteractionWithBufferZoneEventFilter : BaseEventFilter
	{
		// Token: 0x0600C23E RID: 49726 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsFilterPassed(GClass2885 eventToFilter)
		{
			throw null;
		}

		// Token: 0x0400C406 RID: 50182
		[SerializeField]
		private GClass2906.EInteractState _neededState;
	}
}
