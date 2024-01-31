using System;
using Newtonsoft.Json;

// Token: 0x02000FBD RID: 4029
public sealed class GClass1180
{
	// Token: 0x0400606B RID: 24683
	[JsonProperty("summoned")]
	public GClass1178[] Summoned;

	// Token: 0x0400606C RID: 24684
	[JsonProperty("leaved")]
	public string[] Leaved;

	// Token: 0x0400606D RID: 24685
	[JsonProperty("gameDate")]
	public string Date;

	// Token: 0x0400606E RID: 24686
	[JsonProperty("gameTime")]
	public string Time;

	// Token: 0x0400606F RID: 24687
	[JsonProperty("gameTimeAcceleration")]
	public float Acceleration;

	// Token: 0x04006070 RID: 24688
	[JsonProperty("halloweenEvent")]
	public GClass1183 HalloweenEvent;

	// Token: 0x04006071 RID: 24689
	[JsonProperty("winterEvent")]
	public GClass1184 WinterEvent;

	// Token: 0x04006072 RID: 24690
	[JsonProperty("event")]
	public GClass1185 AirdropEvent;

	// Token: 0x04006073 RID: 24691
	[JsonProperty("excludedBosses")]
	public string[] excludedBosses;
}
