using System;
using System.Runtime.CompilerServices;
using EFT.GlobalEvents;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001895 RID: 6293
	public class ForceMuteVoIPToggler : MonoBehaviour
	{
		// Token: 0x06008749 RID: 34633 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600874A RID: 34634 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(BaseEventFilter filter, GClass2885 passedEvent)
		{
			throw null;
		}

		// Token: 0x0600874B RID: 34635 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(BaseEventFilter filter, GClass2885 passedEvent)
		{
			throw null;
		}

		// Token: 0x04008DB6 RID: 36278
		[SerializeField]
		private BaseEventFilter _disableVoipEventFilter;

		// Token: 0x04008DB7 RID: 36279
		[SerializeField]
		private BaseEventFilter _enableVoipEventFilter;
	}
}
