using System;
using Newtonsoft.Json;

namespace EFT.Quests
{
	// Token: 0x02002FF5 RID: 12277
	public class ConditionLaunchFlare : Condition
	{
		// Token: 0x0400F81B RID: 63515
		[JsonProperty("target")]
		public string zoneID;
	}
}
