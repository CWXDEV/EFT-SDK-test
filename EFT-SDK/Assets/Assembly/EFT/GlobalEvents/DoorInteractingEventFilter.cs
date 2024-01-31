using System;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using UnityEngine;

namespace EFT.GlobalEvents
{
	// Token: 0x02002636 RID: 9782
	public class DoorInteractingEventFilter : BaseEventFilter
	{
		// Token: 0x0600C23B RID: 49723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsFilterPassed(GClass2885 eventToFilter)
		{
			throw null;
		}

		// Token: 0x0400C401 RID: 50177
		[SerializeField]
		private Door _doorForTracking;

		// Token: 0x0400C402 RID: 50178
		[SerializeField]
		private bool _doorOpened;

		// Token: 0x0400C403 RID: 50179
		[SerializeField]
		private bool _doorClosed;
	}
}
