using System;
using Newtonsoft.Json;

namespace JsonType
{
	// Token: 0x02001000 RID: 4096
	[Serializable]
	public struct KeepAliveResponse
	{
		// Token: 0x040061DF RID: 25055
		[JsonProperty("utc_time")]
		public double UtcTime;
	}
}
