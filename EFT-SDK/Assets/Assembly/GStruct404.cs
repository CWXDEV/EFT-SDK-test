using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

// Token: 0x02003057 RID: 12375
[StructLayout(LayoutKind.Auto)]
public struct GStruct404
{
	// Token: 0x0400F973 RID: 63859
	[JsonProperty("changeCost")]
	public GStruct405[] ChangeCosts;

	// Token: 0x0400F974 RID: 63860
	[JsonProperty("changeStandingCost")]
	public double ChangeStandingCost;
}
