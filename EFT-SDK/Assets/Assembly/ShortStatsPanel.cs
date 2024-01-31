using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using UnityEngine;

// Token: 0x020009BC RID: 2492
public class ShortStatsPanel : MonoBehaviour
{
	// Token: 0x060037CA RID: 14282 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStats(float raids, float kills, float leaveRate, float survivalRate, float killsDeathRate, string onlineTime)
	{
		throw null;
	}

	// Token: 0x04003931 RID: 14641
	[SerializeField]
	private LocalizedText _raids;

	// Token: 0x04003932 RID: 14642
	[SerializeField]
	private LocalizedText _kills;

	// Token: 0x04003933 RID: 14643
	[SerializeField]
	private LocalizedText _leaveRate;

	// Token: 0x04003934 RID: 14644
	[SerializeField]
	private LocalizedText _survivalRate;

	// Token: 0x04003935 RID: 14645
	[SerializeField]
	private LocalizedText _killsDeathRate;

	// Token: 0x04003936 RID: 14646
	[SerializeField]
	private LocalizedText _onlineTime;
}
