using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace JsonType
{
	// Token: 0x02000FE0 RID: 4064
	public class LocationWeatherTime
	{
		// Token: 0x06005548 RID: 21832 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static LocationWeatherTime CreateDefault()
		{
			throw null;
		}

		// Token: 0x040060F6 RID: 24822
		[JsonProperty("winterEventEnabled")]
		public bool WinterEventEnabled;

		// Token: 0x040060F7 RID: 24823
		[JsonProperty("weather")]
		public WeatherClass Weather;

		// Token: 0x040060F8 RID: 24824
		[JsonProperty("acceleration")]
		public float Acceleration;

		// Token: 0x040060F9 RID: 24825
		[JsonProperty("date")]
		public string Date;

		// Token: 0x040060FA RID: 24826
		[JsonProperty("time")]
		public string Time;
	}
}
