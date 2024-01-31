using System;
using System.Runtime.CompilerServices;
using EFT;
using Newtonsoft.Json;

// Token: 0x02001CDF RID: 7391
public sealed class GClass1987 : NotificationClass
{
	// Token: 0x1700179D RID: 6045
	// (get) Token: 0x060099B1 RID: 39345 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A109 RID: 41225
	[JsonProperty("aid")]
	public string AccountId;

	// Token: 0x0400A10A RID: 41226
	[JsonProperty("_id")]
	public string PlayerId;

	// Token: 0x0400A10B RID: 41227
	[JsonProperty("Info")]
	public GClass1205 Info;

	// Token: 0x0400A10C RID: 41228
	public bool IsReady;

	// Token: 0x0400A10D RID: 41229
	public PlayerVisualRepresentation PlayerVisualRepresentation;
}
