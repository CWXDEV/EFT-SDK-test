using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02002F2A RID: 12074
public sealed class RagfairSettingsClass
{
	// Token: 0x170028D6 RID: 10454
	// (get) Token: 0x0600EE40 RID: 60992 RVA: 0x00002050 File Offset: 0x00000250
	public TimeSpan DefaultDuration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400F386 RID: 62342
	public bool enabled;

	// Token: 0x0400F387 RID: 62343
	public int minUserLevel;

	// Token: 0x0400F388 RID: 62344
	public float communityItemTax;

	// Token: 0x0400F389 RID: 62345
	public float communityRequirementTax;

	// Token: 0x0400F38A RID: 62346
	public float offerDurationTimeInHour;

	// Token: 0x0400F38B RID: 62347
	public float offerDurationTimeInHourAfterRemove;

	// Token: 0x0400F38C RID: 62348
	public int delaySinceOfferAdd;

	// Token: 0x0400F38D RID: 62349
	public float renewCommunityTax;

	// Token: 0x0400F38E RID: 62350
	public float renewPricePerHour;

	// Token: 0x0400F38F RID: 62351
	public bool isOnlyFoundInRaidAllowed;

	// Token: 0x0400F390 RID: 62352
	public RagfairSettingsClass.GClass3189[] maxActiveOfferCount;

	// Token: 0x0400F391 RID: 62353
	[JsonProperty("sellInOnePiece")]
	public int SellInOnePiece;

	// Token: 0x02002F2B RID: 12075
	public sealed class GClass3189
	{
		// Token: 0x0400F392 RID: 62354
		public float from;

		// Token: 0x0400F393 RID: 62355
		public float to;

		// Token: 0x0400F394 RID: 62356
		public int count;
	}
}
