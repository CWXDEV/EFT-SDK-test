using System;
using EFT;
using Newtonsoft.Json;

// Token: 0x02002E7C RID: 11900
public class GClass3172
{
	// Token: 0x0400EFCB RID: 61387
	[JsonProperty("requestId")]
	public string RequestId;

	// Token: 0x0400EFCC RID: 61388
	[JsonProperty("retryAfter")]
	public int RetryAfter;

	// Token: 0x0400EFCD RID: 61389
	[JsonProperty("status")]
	public EBackendErrorCode Error;
}
