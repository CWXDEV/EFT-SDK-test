using System;
using EFT;
using EFT.Counters;
using UnityEngine.Networking;

// Token: 0x0200186F RID: 6255
internal interface Interface10
{
	// Token: 0x170014A2 RID: 5282
	// (get) Token: 0x0600861A RID: 34330
	NetworkClient NetworkClient { get; }

	// Token: 0x170014A3 RID: 5283
	// (get) Token: 0x0600861B RID: 34331
	NetworkConnection Connection { get; }

	// Token: 0x170014A4 RID: 5284
	// (get) Token: 0x0600861C RID: 34332
	bool ObserveOnly { get; }

	// Token: 0x170014A5 RID: 5285
	// (get) Token: 0x0600861D RID: 34333
	bool HasAuthority { get; }

	// Token: 0x0600861E RID: 34334
	void Spawn();

	// Token: 0x0600861F RID: 34335
	void Respawn();

	// Token: 0x06008620 RID: 34336
	void StartGame();

	// Token: 0x06008621 RID: 34337
	void StartGameAfterTeleport();

	// Token: 0x06008622 RID: 34338
	void RestartGameInitiate();

	// Token: 0x06008623 RID: 34339
	void RestartGame();

	// Token: 0x06008624 RID: 34340
	void GameStarted();

	// Token: 0x06008625 RID: 34341
	void StopGame();

	// Token: 0x06008626 RID: 34342
	void RequestBotDevelopData(string profileId);

	// Token: 0x06008627 RID: 34343
	void RequestBotDevelopDataZones();

	// Token: 0x06008628 RID: 34344
	void RequestBotDevelopDataGroups();

	// Token: 0x06008629 RID: 34345
	void RequestBotDevelopDataProfiles();

	// Token: 0x0600862A RID: 34346
	void ReportVoipAbuse();

	// Token: 0x0600862B RID: 34347
	void PlayerEffectsPause(string playerProfileID, bool isPaused);

	// Token: 0x0600862C RID: 34348
	void CmdGetRadiotransmitterData(string playerProfileID);

	// Token: 0x0600862D RID: 34349
	void CmdGetTraderServicesData(string playerProfileID, string traderId);

	// Token: 0x0600862E RID: 34350
	void OnPlayerKeeperStatisticsChanged(string playerProfileID, CounterTag statisticsType, int valueToSet);

	// Token: 0x0600862F RID: 34351
	void DevelopmentSpawn(EPlayerSide side, WildSpawnType profile, BotDifficulty difficulty);
}
