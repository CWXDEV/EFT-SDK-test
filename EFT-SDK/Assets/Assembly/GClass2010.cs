using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CFB RID: 7419
public sealed class GClass2010 : GClass2008
{
	// Token: 0x170017C7 RID: 6087
	// (get) Token: 0x060099DD RID: 39389 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A12E RID: 41262
	[JsonProperty("offerId")]
	public string OfferId;

	// Token: 0x0400A12F RID: 41263
	[JsonProperty("count")]
	public int Count;

	// Token: 0x0400A130 RID: 41264
	[JsonProperty("handbookId")]
	public string HandbookId;
}
