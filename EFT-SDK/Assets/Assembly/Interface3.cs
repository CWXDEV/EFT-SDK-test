using System;

// Token: 0x02000BF7 RID: 3063
internal interface Interface3
{
	// Token: 0x17000AC9 RID: 2761
	// (get) Token: 0x0600428B RID: 17035
	WeatherObstacle WinterWeatherObstacle { get; }

	// Token: 0x0600428C RID: 17036
	void Setup();

	// Token: 0x0600428D RID: 17037
	void SetupOnReconnect();
}
