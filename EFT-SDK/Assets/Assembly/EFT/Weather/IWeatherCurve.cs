using System;
using UnityEngine;

namespace EFT.Weather
{
	// Token: 0x02001DDA RID: 7642
	public interface IWeatherCurve
	{
		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x06009D64 RID: 40292
		Vector2 Wind { get; }

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x06009D65 RID: 40293
		Vector2 TopWind { get; }

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x06009D66 RID: 40294
		float Rain { get; }

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x06009D67 RID: 40295
		float Cloudiness { get; }

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x06009D68 RID: 40296
		float Fog { get; }

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x06009D69 RID: 40297
		float Temperature { get; }

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x06009D6A RID: 40298
		float LightningThunderProbability { get; }
	}
}
