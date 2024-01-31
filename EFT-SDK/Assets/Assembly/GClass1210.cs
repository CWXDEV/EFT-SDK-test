using System;
using Newtonsoft.Json;

// Token: 0x02000FE5 RID: 4069
public class GClass1210
{
	// Token: 0x0400611E RID: 24862
	[JsonProperty("_id")]
	public string Id;

	// Token: 0x0400611F RID: 24863
	[JsonProperty("requestId")]
	public string RequestId;

	// Token: 0x04006120 RID: 24864
	[JsonProperty("from")]
	public string From;

	// Token: 0x04006121 RID: 24865
	[JsonProperty("to")]
	public string To;

	// Token: 0x04006122 RID: 24866
	[JsonProperty("profile")]
	public GClass1206 FromProfile;

	// Token: 0x04006123 RID: 24867
	[JsonProperty("members")]
	public GClass1206[] Members;
}
