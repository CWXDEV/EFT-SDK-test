using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CFA RID: 7418
public sealed class GClass2009 : GClass2008
{
	// Token: 0x170017C5 RID: 6085
	// (get) Token: 0x060099DB RID: 39387 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ShowNotification
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017C6 RID: 6086
	// (get) Token: 0x060099DC RID: 39388 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A12C RID: 41260
	[JsonProperty("rating")]
	public float Rating;

	// Token: 0x0400A12D RID: 41261
	[JsonProperty("isRatingGrowing")]
	public bool IsRatingGrowing;
}
