using System;
using System.Collections.Generic;
using EFT.Hideout;

namespace EFT
{
	// Token: 0x02001601 RID: 5633
	[Serializable]
	public class HideoutInfo
	{
		// Token: 0x04007F9C RID: 32668
		public Dictionary<string, ProductionData> Production;

		// Token: 0x04007F9D RID: 32669
		public Dictionary<string, GClass1910> Improvements;

		// Token: 0x04007F9E RID: 32670
		public AreaInfo[] Areas;

		// Token: 0x04007F9F RID: 32671
		public HideoutCounters HideoutCounters;

		// Token: 0x04007FA0 RID: 32672
		public int Seed;
	}
}
