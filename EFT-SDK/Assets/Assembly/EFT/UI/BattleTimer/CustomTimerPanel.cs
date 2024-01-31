using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace EFT.UI.BattleTimer
{
	// Token: 0x02002D74 RID: 11636
	public sealed class CustomTimerPanel : TimerPanel
	{
		// Token: 0x0600E4D2 RID: 58578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTimerCaption(string text)
		{
			throw null;
		}

		// Token: 0x0400E9F0 RID: 59888
		[SerializeField]
		private TextMeshProUGUI _timerCaption;
	}
}
