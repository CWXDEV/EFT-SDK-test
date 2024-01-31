using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x0200186E RID: 6254
internal interface Interface9
{
	// Token: 0x060085F0 RID: 34288
	Task Run(Interface10 session, bool canRestart, GameDateTime gameDateTime, IDictionary<string, int> interactables, ResourceKey[] prefabs, string[] customizations, WeatherClass[] weathers, bool isWinter, float fixedDeltaTime, bool speedLimitsEnabled, GClass1735.Config speedLimits, bool encryptionEnabled, bool decryptionEnabled, GClass1792 voipSettings = null);

	// Token: 0x170014A0 RID: 5280
	// (get) Token: 0x060085F1 RID: 34289
	GameDateTime GameDateTime { get; }

	// Token: 0x170014A1 RID: 5281
	// (get) Token: 0x060085F2 RID: 34290
	string LocationId { get; }

	// Token: 0x060085F3 RID: 34291
	void Stop();

	// Token: 0x060085F4 RID: 34292
	void Abort(string error);

	// Token: 0x060085F5 RID: 34293
	Task WorldSpawn(NetworkMessage message);

	// Token: 0x060085F6 RID: 34294
	void WorldUnspawn(NetworkMessage message);

	// Token: 0x060085F7 RID: 34295
	void SubWorldSpawnLoot(NetworkMessage message);

	// Token: 0x060085F8 RID: 34296
	void SubWorldSpawnSearchLoot(NetworkMessage message);

	// Token: 0x060085F9 RID: 34297
	void SubWorldUnspawn(NetworkMessage message);

	// Token: 0x060085FA RID: 34298
	void PlayerSpawn(NetworkReader reader, Callback<int> callback);

	// Token: 0x060085FB RID: 34299
	void PlayerUnspawn(NetworkReader reader, Callback<int> callback);

	// Token: 0x060085FC RID: 34300
	void ObserverSpawn(NetworkReader reader, Callback<int> callback);

	// Token: 0x060085FD RID: 34301
	void ObserverUnspawn(NetworkReader reader, Callback<int> callback);

	// Token: 0x060085FE RID: 34302
	void DeathInventorySync(NetworkMessage message);

	// Token: 0x060085FF RID: 34303
	void Spawn();

	// Token: 0x06008600 RID: 34304
	Task GameSpawned();

	// Token: 0x06008601 RID: 34305
	void GameMatching(ushort activitiesCounter, ushort minCounter, int seconds);

	// Token: 0x06008602 RID: 34306
	void GameStarting(int seconds);

	// Token: 0x06008603 RID: 34307
	void GameStartingWithTeleport(Vector3 position, int exfiltrationId, string entryPoint);

	// Token: 0x06008604 RID: 34308
	void GameStarted(float pastTime, int sessionSeconds);

	// Token: 0x06008605 RID: 34309
	void GameRestarting();

	// Token: 0x06008606 RID: 34310
	void GameRestarted();

	// Token: 0x06008607 RID: 34311
	void GameStopping();

	// Token: 0x06008608 RID: 34312
	void GameStopped(ExitStatus exitStatus, TimeSpan playTime);

	// Token: 0x06008609 RID: 34313
	void SoftStopNotification(TimeSpan sessionTime);

	// Token: 0x0600860A RID: 34314
	void GetRadioTransmitterData(string profileID);

	// Token: 0x0600860B RID: 34315
	void GetTraderServicesData(string profileID, string traderId);

	// Token: 0x0600860C RID: 34316
	void DevelopSetBotData(byte[] data);

	// Token: 0x0600860D RID: 34317
	void DevelopSetBotDataZones(byte[] data);

	// Token: 0x0600860E RID: 34318
	void DevelopSetBotDataGroups(byte[] data);

	// Token: 0x0600860F RID: 34319
	void OnDisconnectStatusAccepted(GStruct115 disconnectionReason);

	// Token: 0x06008610 RID: 34320
	void VoipAbuseNotification(string reporterId);

	// Token: 0x06008611 RID: 34321
	void ParseMineExplosionData(byte[] data);

	// Token: 0x06008612 RID: 34322
	void ParseAirdropContainerData(byte[] data);

	// Token: 0x06008613 RID: 34323
	void AirdropFlareSuccessEvent(bool canSendAirdrop);

	// Token: 0x06008614 RID: 34324
	void ParseBufferZoneData(byte[] data);

	// Token: 0x06008615 RID: 34325
	void RecieveClientRadioTransmitterData(GStruct132 data);

	// Token: 0x06008616 RID: 34326
	void RecieveObserverRadioTransmitterData(GStruct132 data);

	// Token: 0x06008617 RID: 34327
	void ReceiveTraderServicesData(byte[] packet);

	// Token: 0x06008618 RID: 34328
	void RecieveLighthouseTraderZoneData(GStruct131 data);

	// Token: 0x06008619 RID: 34329
	void ReceiveCompletedAchievementsData(GStruct218 data);
}
