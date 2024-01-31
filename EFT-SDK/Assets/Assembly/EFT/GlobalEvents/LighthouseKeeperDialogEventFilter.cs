using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.GlobalEvents
{
	// Token: 0x02002638 RID: 9784
	public class LighthouseKeeperDialogEventFilter : BaseEventFilter
	{
		// Token: 0x0600C23D RID: 49725 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsFilterPassed(GClass2885 eventToFilter)
		{
			throw null;
		}

		// Token: 0x0400C405 RID: 50181
		[SerializeField]
		private GClass2910.EDialogState _neededDialogOption;
	}
}
