using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

// Token: 0x02001781 RID: 6017
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct231
{
	// Token: 0x04008930 RID: 35120
	[JsonProperty("t")]
	public readonly string Text;

	// Token: 0x04008931 RID: 35121
	[JsonProperty("s")]
	public readonly double StartTime;

	// Token: 0x04008932 RID: 35122
	[JsonProperty("e")]
	public readonly double EndTime;
}
