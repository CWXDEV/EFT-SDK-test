using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x0200272A RID: 10026
	[Serializable]
	public class ExitTriggerSettings
	{
		// Token: 0x0600C8C5 RID: 51397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Load(GClass1222 settings, ExfiltrationPoint point)
		{
			throw null;
		}

		// Token: 0x0400C8E9 RID: 51433
		public string Name;

		// Token: 0x0400C8EA RID: 51434
		public EExfiltrationType ExfiltrationType;

		// Token: 0x0400C8EB RID: 51435
		public float ExfiltrationTime;

		// Token: 0x0400C8EC RID: 51436
		public int PlayersCount;

		// Token: 0x0400C8ED RID: 51437
		[Header("Presence settings")]
		public float Chance;

		// Token: 0x0400C8EE RID: 51438
		public float MinTime;

		// Token: 0x0400C8EF RID: 51439
		public float MaxTime;

		// Token: 0x0400C8F0 RID: 51440
		public int StartTime;

		// Token: 0x0400C8F1 RID: 51441
		public string EntryPoints;

		// Token: 0x0400C8F2 RID: 51442
		public bool EventAvailable;
	}
}
