using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.GlobalEvents
{
	// Token: 0x02002637 RID: 9783
	public class InteractWithKeeperZoneEventFilter : BaseEventFilter
	{
		// Token: 0x0600C23C RID: 49724 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsFilterPassed(GClass2885 eventToFilter)
		{
			throw null;
		}

		// Token: 0x0400C404 RID: 50180
		[SerializeField]
		private GClass2898.EInteractState _neededState;
	}
}
