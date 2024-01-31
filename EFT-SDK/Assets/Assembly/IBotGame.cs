using System;
using EFT;
using EFT.Weather;

// Token: 0x02000612 RID: 1554
public interface IBotGame
{
	// Token: 0x1700067D RID: 1661
	// (get) Token: 0x06002384 RID: 9092
	GameStatus Status { get; }

	// Token: 0x1700067E RID: 1662
	// (get) Token: 0x06002385 RID: 9093
	GameDateTime GameDateTime { get; }

	// Token: 0x1700067F RID: 1663
	// (get) Token: 0x06002386 RID: 9094
	BotsController BotsController { get; }

	// Token: 0x17000680 RID: 1664
	// (get) Token: 0x06002387 RID: 9095
	IWeatherCurve WeatherCurve { get; }

	// Token: 0x14000056 RID: 86
	// (add) Token: 0x06002388 RID: 9096
	// (remove) Token: 0x06002389 RID: 9097
	event Action UpdateByUnity;

	// Token: 0x0600238A RID: 9098
	void BotUnspawn(BotOwner bot);
}
