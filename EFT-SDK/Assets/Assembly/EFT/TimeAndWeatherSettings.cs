using System;
using EFT.Weather;
using Newtonsoft.Json;

namespace EFT
{
	// Token: 0x02001302 RID: 4866
	[Serializable]
	public struct TimeAndWeatherSettings
	{
		// Token: 0x04007146 RID: 28998
		[JsonProperty("isRandomTime")]
		public bool IsRandomTime;

		// Token: 0x04007147 RID: 28999
		[JsonProperty("isRandomWeather")]
		public bool IsRandomWeather;

		// Token: 0x04007148 RID: 29000
		[JsonProperty("cloudinessType")]
		public ECloudinessType CloudinessType;

		// Token: 0x04007149 RID: 29001
		[JsonProperty("rainType")]
		public ERainType RainType;

		// Token: 0x0400714A RID: 29002
		[JsonProperty("windType")]
		public EWindSpeed WindType;

		// Token: 0x0400714B RID: 29003
		[JsonProperty("fogType")]
		public EFogType FogType;

		// Token: 0x0400714C RID: 29004
		[JsonProperty("timeFlowType")]
		public ETimeFlowType TimeFlowType;

		// Token: 0x0400714D RID: 29005
		[JsonProperty("hourOfDay")]
		public int HourOfDay;
	}
}
