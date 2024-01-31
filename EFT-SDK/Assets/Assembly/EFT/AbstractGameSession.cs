using System;
using System.Runtime.CompilerServices;
using EFT.Counters;
using UnityEngine;
using UnityEngine.Networking;

namespace EFT
{
	// Token: 0x02001194 RID: 4500
	public abstract class AbstractGameSession : AbstractSession
	{
		// Token: 0x06005F92 RID: 24466 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static T Create<T>(Transform parent, string name, string profileId, string token) where T : AbstractGameSession
		{
			throw null;
		}

		// Token: 0x06005F93 RID: 24467 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override float GetNetworkSendInterval()
		{
			throw null;
		}

		// Token: 0x06005F94 RID: 24468 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetNetworkChannel()
		{
			throw null;
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdSpawn()
		{
			throw null;
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdRespawn()
		{
			throw null;
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdStartGame()
		{
			throw null;
		}

		// Token: 0x06005F98 RID: 24472 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdStartGameAfterTeleport()
		{
			throw null;
		}

		// Token: 0x06005F99 RID: 24473 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdRestartGameInitiate()
		{
			throw null;
		}

		// Token: 0x06005F9A RID: 24474 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdRestartGame()
		{
			throw null;
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdGameStarted()
		{
			throw null;
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdStopGame()
		{
			throw null;
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdSyncGameTime()
		{
			throw null;
		}

		// Token: 0x06005F9E RID: 24478 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdDevelopRequestBot(string profileId)
		{
			throw null;
		}

		// Token: 0x06005F9F RID: 24479 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdDevelopRequestBotZones()
		{
			throw null;
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdDevelopRequestBotGroups()
		{
			throw null;
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdDevelopRequestBotProfiles()
		{
			throw null;
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdDevelopmentSpawnBotRequest(EPlayerSide side)
		{
			throw null;
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdDevelopmentSpawnBotOnServer(EPlayerSide side, WildSpawnType profile, BotDifficulty difficulty)
		{
			throw null;
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdDevelopmentSpawnBotOnClient(EPlayerSide side, int instanceId)
		{
			throw null;
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdDisconnectAcceptedOnClient()
		{
			throw null;
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdWorldSpawnConfirm()
		{
			throw null;
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdSpawnConfirm(int playerId)
		{
			throw null;
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdReportVoipAbuse()
		{
			throw null;
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdPlayerEffectsPause(string playerProfileID, bool isPaused)
		{
			throw null;
		}

		// Token: 0x06005FAA RID: 24490 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdOnPlayerKeeperStatisticsChanged(string playerProfileID, CounterTag statisticsType, int valueToSet)
		{
			throw null;
		}

		// Token: 0x06005FAB RID: 24491 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdGetRadiotransmitterData(string playerProfileID)
		{
			throw null;
		}

		// Token: 0x06005FAC RID: 24492 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CmdGetTraderServicesData(string playerProfileID, string traderId)
		{
			throw null;
		}

		// Token: 0x06005FAD RID: 24493 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcGameSpawned()
		{
			throw null;
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcGameMatching(ushort activitiesCounter, ushort minCounter, int seconds)
		{
			throw null;
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcGameStarting(int seconds)
		{
			throw null;
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcGameStartingWithTeleport(Vector3 position, int exfiltrationId, string entryPoint)
		{
			throw null;
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcGameStarted(float pastTime, int sessionSeconds)
		{
			throw null;
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcGameRestarting()
		{
			throw null;
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcGameRestarted()
		{
			throw null;
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcGameStopping()
		{
			throw null;
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcGameStopped(ExitStatus exitStatus, int playTime)
		{
			throw null;
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcSyncGameTime(long time)
		{
			throw null;
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcDevelopSendBotData(byte[] data)
		{
			throw null;
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcDevelopSendBotDataZone(byte[] data)
		{
			throw null;
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcDevelopSendBotDataGroups(byte[] data)
		{
			throw null;
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcDevelopSendBotDataProfiles(byte[] data)
		{
			throw null;
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcDevelopmentSpawnBotResponse(EPlayerSide side, int instanceId)
		{
			throw null;
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcSoftStopNotification(int sessionSeconds)
		{
			throw null;
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcStartDisconnectionProcedure(int disconnectionCode, string additionalInfo, string technicalMessage)
		{
			throw null;
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcVoipAbuseNotification(string reporter)
		{
			throw null;
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcAirdropContainerData(byte[] data)
		{
			throw null;
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcMineDirectionExplosion(byte[] data)
		{
			throw null;
		}

		// Token: 0x06005FC1 RID: 24513 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcSuccessAirdropFlareEvent(bool canSendAirdrop)
		{
			throw null;
		}

		// Token: 0x06005FC2 RID: 24514 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcBufferZoneData(byte[] data)
		{
			throw null;
		}

		// Token: 0x06005FC3 RID: 24515 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcSendClientRadioTransmitterData(GStruct132 data)
		{
			throw null;
		}

		// Token: 0x06005FC4 RID: 24516 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcSendObserverRadioTransmitterData(GStruct132 data)
		{
			throw null;
		}

		// Token: 0x06005FC5 RID: 24517 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcSendTraderServicesData(byte[] packet)
		{
			throw null;
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcSyncLighthouseTraderZoneData(GStruct131 data)
		{
			throw null;
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RpcSendCompletedAchievementsData(GStruct218 data)
		{
			throw null;
		}

		// Token: 0x06005FC8 RID: 24520 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005FC9 RID: 24521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdSpawn(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdRespawn(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FCB RID: 24523 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdStartGame(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdStartGameAfterTeleport(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FCD RID: 24525 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdRestartGameInitiate(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdRestartGame(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdGameStarted(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdStopGame(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdSyncGameTime(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdDevelopRequestBot(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdDevelopRequestBotZones(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdDevelopRequestBotGroups(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FD5 RID: 24533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdDevelopRequestBotProfiles(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdDevelopmentSpawnBotRequest(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdDevelopmentSpawnBotOnServer(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdDevelopmentSpawnBotOnClient(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdDisconnectAcceptedOnClient(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FDA RID: 24538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdWorldSpawnConfirm(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdSpawnConfirm(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdReportVoipAbuse(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FDD RID: 24541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdPlayerEffectsPause(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FDE RID: 24542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdOnPlayerKeeperStatisticsChanged(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FDF RID: 24543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdGetRadiotransmitterData(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdGetTraderServicesData(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FE1 RID: 24545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdSpawn()
		{
			throw null;
		}

		// Token: 0x06005FE2 RID: 24546 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdRespawn()
		{
			throw null;
		}

		// Token: 0x06005FE3 RID: 24547 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdStartGame()
		{
			throw null;
		}

		// Token: 0x06005FE4 RID: 24548 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdStartGameAfterTeleport()
		{
			throw null;
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdRestartGameInitiate()
		{
			throw null;
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdRestartGame()
		{
			throw null;
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdGameStarted()
		{
			throw null;
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdStopGame()
		{
			throw null;
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdSyncGameTime()
		{
			throw null;
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdDevelopRequestBot(string profileId)
		{
			throw null;
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdDevelopRequestBotZones()
		{
			throw null;
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdDevelopRequestBotGroups()
		{
			throw null;
		}

		// Token: 0x06005FED RID: 24557 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdDevelopRequestBotProfiles()
		{
			throw null;
		}

		// Token: 0x06005FEE RID: 24558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdDevelopmentSpawnBotRequest(EPlayerSide side)
		{
			throw null;
		}

		// Token: 0x06005FEF RID: 24559 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdDevelopmentSpawnBotOnServer(EPlayerSide side, WildSpawnType profile, BotDifficulty difficulty)
		{
			throw null;
		}

		// Token: 0x06005FF0 RID: 24560 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdDevelopmentSpawnBotOnClient(EPlayerSide side, int instanceId)
		{
			throw null;
		}

		// Token: 0x06005FF1 RID: 24561 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdDisconnectAcceptedOnClient()
		{
			throw null;
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdWorldSpawnConfirm()
		{
			throw null;
		}

		// Token: 0x06005FF3 RID: 24563 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdSpawnConfirm(int playerId)
		{
			throw null;
		}

		// Token: 0x06005FF4 RID: 24564 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdReportVoipAbuse()
		{
			throw null;
		}

		// Token: 0x06005FF5 RID: 24565 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdPlayerEffectsPause(string playerProfileID, bool isPaused)
		{
			throw null;
		}

		// Token: 0x06005FF6 RID: 24566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdOnPlayerKeeperStatisticsChanged(string playerProfileID, CounterTag statisticsType, int valueToSet)
		{
			throw null;
		}

		// Token: 0x06005FF7 RID: 24567 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdGetRadiotransmitterData(string playerProfileID)
		{
			throw null;
		}

		// Token: 0x06005FF8 RID: 24568 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdGetTraderServicesData(string playerProfileID, string traderId)
		{
			throw null;
		}

		// Token: 0x06005FF9 RID: 24569 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcGameSpawned(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FFA RID: 24570 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcGameMatching(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FFB RID: 24571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcGameStarting(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FFC RID: 24572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcGameStartingWithTeleport(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FFD RID: 24573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcGameStarted(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FFE RID: 24574 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcGameRestarting(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06005FFF RID: 24575 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcGameRestarted(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006000 RID: 24576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcGameStopping(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006001 RID: 24577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcGameStopped(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006002 RID: 24578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcSyncGameTime(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006003 RID: 24579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcDevelopSendBotData(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006004 RID: 24580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcDevelopSendBotDataZone(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006005 RID: 24581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcDevelopSendBotDataGroups(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006006 RID: 24582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcDevelopSendBotDataProfiles(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006007 RID: 24583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcDevelopmentSpawnBotResponse(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006008 RID: 24584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcSoftStopNotification(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006009 RID: 24585 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcStartDisconnectionProcedure(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0600600A RID: 24586 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcVoipAbuseNotification(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0600600B RID: 24587 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcAirdropContainerData(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0600600C RID: 24588 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcMineDirectionExplosion(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0600600D RID: 24589 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcSuccessAirdropFlareEvent(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcBufferZoneData(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0600600F RID: 24591 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcSendClientRadioTransmitterData(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006010 RID: 24592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcSendObserverRadioTransmitterData(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcSendTraderServicesData(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006012 RID: 24594 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcSyncLighthouseTraderZoneData(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006013 RID: 24595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcSendCompletedAchievementsData(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06006014 RID: 24596 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcGameSpawned()
		{
			throw null;
		}

		// Token: 0x06006015 RID: 24597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcGameMatching(ushort activitiesCounter, ushort minCounter, int seconds)
		{
			throw null;
		}

		// Token: 0x06006016 RID: 24598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcGameStarting(int seconds)
		{
			throw null;
		}

		// Token: 0x06006017 RID: 24599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcGameStartingWithTeleport(Vector3 position, int exfiltrationId, string entryPoint)
		{
			throw null;
		}

		// Token: 0x06006018 RID: 24600 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcGameStarted(float pastTime, int sessionSeconds)
		{
			throw null;
		}

		// Token: 0x06006019 RID: 24601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcGameRestarting()
		{
			throw null;
		}

		// Token: 0x0600601A RID: 24602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcGameRestarted()
		{
			throw null;
		}

		// Token: 0x0600601B RID: 24603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcGameStopping()
		{
			throw null;
		}

		// Token: 0x0600601C RID: 24604 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcGameStopped(ExitStatus exitStatus, int playTime)
		{
			throw null;
		}

		// Token: 0x0600601D RID: 24605 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcSyncGameTime(long time)
		{
			throw null;
		}

		// Token: 0x0600601E RID: 24606 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcDevelopSendBotData(byte[] data)
		{
			throw null;
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcDevelopSendBotDataZone(byte[] data)
		{
			throw null;
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcDevelopSendBotDataGroups(byte[] data)
		{
			throw null;
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcDevelopSendBotDataProfiles(byte[] data)
		{
			throw null;
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcDevelopmentSpawnBotResponse(EPlayerSide side, int instanceId)
		{
			throw null;
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcSoftStopNotification(int sessionSeconds)
		{
			throw null;
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcStartDisconnectionProcedure(int disconnectionCode, string additionalInfo, string technicalMessage)
		{
			throw null;
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcVoipAbuseNotification(string reporter)
		{
			throw null;
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcAirdropContainerData(byte[] data)
		{
			throw null;
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcMineDirectionExplosion(byte[] data)
		{
			throw null;
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcSuccessAirdropFlareEvent(bool canSendAirdrop)
		{
			throw null;
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcBufferZoneData(byte[] data)
		{
			throw null;
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcSendClientRadioTransmitterData(GStruct132 data)
		{
			throw null;
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcSendObserverRadioTransmitterData(GStruct132 data)
		{
			throw null;
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcSendTraderServicesData(byte[] packet)
		{
			throw null;
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcSyncLighthouseTraderZoneData(GStruct131 data)
		{
			throw null;
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcSendCompletedAchievementsData(GStruct218 data)
		{
			throw null;
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			throw null;
		}

		// Token: 0x06006030 RID: 24624 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
			throw null;
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PreStartClient()
		{
			throw null;
		}

		// Token: 0x0400697F RID: 27007
		private static int int_0;

		// Token: 0x04006980 RID: 27008
		private static int int_1;

		// Token: 0x04006981 RID: 27009
		private static int int_2;

		// Token: 0x04006982 RID: 27010
		private static int int_3;

		// Token: 0x04006983 RID: 27011
		private static int int_4;

		// Token: 0x04006984 RID: 27012
		private static int int_5;

		// Token: 0x04006985 RID: 27013
		private static int int_6;

		// Token: 0x04006986 RID: 27014
		private static int int_7;

		// Token: 0x04006987 RID: 27015
		private static int int_8;

		// Token: 0x04006988 RID: 27016
		private static int int_9;

		// Token: 0x04006989 RID: 27017
		private static int int_10;

		// Token: 0x0400698A RID: 27018
		private static int int_11;

		// Token: 0x0400698B RID: 27019
		private static int int_12;

		// Token: 0x0400698C RID: 27020
		private static int int_13;

		// Token: 0x0400698D RID: 27021
		private static int int_14;

		// Token: 0x0400698E RID: 27022
		private static int int_15;

		// Token: 0x0400698F RID: 27023
		private static int int_16;

		// Token: 0x04006990 RID: 27024
		private static int int_17;

		// Token: 0x04006991 RID: 27025
		private static int int_18;

		// Token: 0x04006992 RID: 27026
		private static int int_19;

		// Token: 0x04006993 RID: 27027
		private static int int_20;

		// Token: 0x04006994 RID: 27028
		private static int int_21;

		// Token: 0x04006995 RID: 27029
		private static int int_22;

		// Token: 0x04006996 RID: 27030
		private static int int_23;

		// Token: 0x04006997 RID: 27031
		private static int int_24;

		// Token: 0x04006998 RID: 27032
		private static int int_25;

		// Token: 0x04006999 RID: 27033
		private static int int_26;

		// Token: 0x0400699A RID: 27034
		private static int int_27;

		// Token: 0x0400699B RID: 27035
		private static int int_28;

		// Token: 0x0400699C RID: 27036
		private static int int_29;

		// Token: 0x0400699D RID: 27037
		private static int int_30;

		// Token: 0x0400699E RID: 27038
		private static int int_31;

		// Token: 0x0400699F RID: 27039
		private static int int_32;

		// Token: 0x040069A0 RID: 27040
		private static int int_33;

		// Token: 0x040069A1 RID: 27041
		private static int int_34;

		// Token: 0x040069A2 RID: 27042
		private static int int_35;

		// Token: 0x040069A3 RID: 27043
		private static int int_36;

		// Token: 0x040069A4 RID: 27044
		private static int int_37;

		// Token: 0x040069A5 RID: 27045
		private static int int_38;

		// Token: 0x040069A6 RID: 27046
		private static int int_39;

		// Token: 0x040069A7 RID: 27047
		private static int int_40;

		// Token: 0x040069A8 RID: 27048
		private static int int_41;

		// Token: 0x040069A9 RID: 27049
		private static int int_42;

		// Token: 0x040069AA RID: 27050
		private static int int_43;

		// Token: 0x040069AB RID: 27051
		private static int int_44;

		// Token: 0x040069AC RID: 27052
		private static int int_45;

		// Token: 0x040069AD RID: 27053
		private static int int_46;

		// Token: 0x040069AE RID: 27054
		private static int int_47;

		// Token: 0x040069AF RID: 27055
		private static int int_48;

		// Token: 0x040069B0 RID: 27056
		private static int int_49;

		// Token: 0x040069B1 RID: 27057
		private static int int_50;

		// Token: 0x02001195 RID: 4501
		internal sealed class Class874 : MessageBase
		{
			// Token: 0x06006032 RID: 24626 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Deserialize(NetworkReader reader)
			{
				throw null;
			}

			// Token: 0x06006033 RID: 24627 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Serialize(NetworkWriter writer)
			{
				throw null;
			}

			// Token: 0x040069B2 RID: 27058
			internal string string_0;

			// Token: 0x040069B3 RID: 27059
			internal string string_1;

			// Token: 0x040069B4 RID: 27060
			internal bool bool_0;

			// Token: 0x040069B5 RID: 27061
			internal byte[] byte_0;

			// Token: 0x040069B6 RID: 27062
			internal int int_0;

			// Token: 0x040069B7 RID: 27063
			internal string string_2;
		}

		// Token: 0x02001196 RID: 4502
		internal class Class875 : MessageBase
		{
			// Token: 0x06006034 RID: 24628 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Deserialize(NetworkReader reader)
			{
				throw null;
			}

			// Token: 0x06006035 RID: 24629 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Serialize(NetworkWriter writer)
			{
				throw null;
			}

			// Token: 0x040069B8 RID: 27064
			public byte TracerId;

			// Token: 0x040069B9 RID: 27065
			public string[] Context;
		}

		// Token: 0x02001197 RID: 4503
		internal sealed class Class876 : AbstractGameSession.Class875
		{
			// Token: 0x06006036 RID: 24630 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Deserialize(NetworkReader reader)
			{
				throw null;
			}

			// Token: 0x06006037 RID: 24631 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Serialize(NetworkWriter writer)
			{
				throw null;
			}

			// Token: 0x040069BA RID: 27066
			public string Message;
		}

		// Token: 0x02001198 RID: 4504
		internal sealed class Class877 : AbstractGameSession.Class875
		{
			// Token: 0x06006038 RID: 24632 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Deserialize(NetworkReader reader)
			{
				throw null;
			}

			// Token: 0x06006039 RID: 24633 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Serialize(NetworkWriter writer)
			{
				throw null;
			}

			// Token: 0x040069BB RID: 27067
			public ETraceCode Code;
		}

		// Token: 0x02001199 RID: 4505
		internal sealed class Class878 : MessageBase
		{
			// Token: 0x0600603A RID: 24634 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Deserialize(NetworkReader reader)
			{
				throw null;
			}

			// Token: 0x0600603B RID: 24635 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Serialize(NetworkWriter writer)
			{
				throw null;
			}

			// Token: 0x040069BC RID: 27068
			internal bool bool_0;

			// Token: 0x040069BD RID: 27069
			internal bool bool_1;

			// Token: 0x040069BE RID: 27070
			internal GameDateTime gameDateTime_0;

			// Token: 0x040069BF RID: 27071
			internal byte[] byte_0;

			// Token: 0x040069C0 RID: 27072
			internal byte[] byte_1;

			// Token: 0x040069C1 RID: 27073
			internal byte[] byte_2;

			// Token: 0x040069C2 RID: 27074
			internal bool bool_2;

			// Token: 0x040069C3 RID: 27075
			internal bool bool_3;

			// Token: 0x040069C4 RID: 27076
			internal EMemberCategory ememberCategory_0;

			// Token: 0x040069C5 RID: 27077
			internal float float_0;

			// Token: 0x040069C6 RID: 27078
			internal byte[] byte_3;

			// Token: 0x040069C7 RID: 27079
			internal byte[] byte_4;

			// Token: 0x040069C8 RID: 27080
			internal Bounds bounds_0;

			// Token: 0x040069C9 RID: 27081
			internal ushort ushort_0;

			// Token: 0x040069CA RID: 27082
			internal ENetLogsLevel enetLogsLevel_0;

			// Token: 0x040069CB RID: 27083
			internal GClass549 gclass549_0;

			// Token: 0x040069CC RID: 27084
			internal bool bool_4;

			// Token: 0x040069CD RID: 27085
			internal GClass1735.Config config_0;

			// Token: 0x040069CE RID: 27086
			internal GClass1792 gclass1792_0;
		}

		// Token: 0x0200119A RID: 4506
		internal sealed class Class879 : MessageBase
		{
			// Token: 0x0600603C RID: 24636 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Deserialize(NetworkReader reader)
			{
				throw null;
			}

			// Token: 0x0600603D RID: 24637 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Serialize(NetworkWriter writer)
			{
				throw null;
			}

			// Token: 0x040069CF RID: 27087
			internal const int int_0 = 100500;

			// Token: 0x040069D0 RID: 27088
			internal const int int_1 = 100501;

			// Token: 0x040069D1 RID: 27089
			internal const int int_2 = 100502;

			// Token: 0x040069D2 RID: 27090
			internal const int int_3 = 100503;

			// Token: 0x040069D3 RID: 27091
			internal int int_4;
		}

		// Token: 0x0200119B RID: 4507
		internal sealed class Class880 : MessageBase
		{
			// Token: 0x0600603E RID: 24638 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Deserialize(NetworkReader reader)
			{
				throw null;
			}

			// Token: 0x0600603F RID: 24639 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Serialize(NetworkWriter writer)
			{
				throw null;
			}

			// Token: 0x040069D4 RID: 27092
			internal float float_0;
		}

		// Token: 0x0200119C RID: 4508
		internal sealed class Class881 : MessageBase
		{
			// Token: 0x06006040 RID: 24640 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Serialize(NetworkWriter writer)
			{
				throw null;
			}

			// Token: 0x06006041 RID: 24641 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Deserialize(NetworkReader reader)
			{
				throw null;
			}

			// Token: 0x040069D5 RID: 27093
			internal byte[] byte_0;
		}

		// Token: 0x0200119D RID: 4509
		internal sealed class Class882 : MessageBase
		{
			// Token: 0x06006042 RID: 24642 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Deserialize(NetworkReader reader)
			{
				throw null;
			}

			// Token: 0x06006043 RID: 24643 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Serialize(NetworkWriter writer)
			{
				throw null;
			}

			// Token: 0x040069D6 RID: 27094
			internal int int_0;

			// Token: 0x040069D7 RID: 27095
			internal byte[] byte_0;

			// Token: 0x040069D8 RID: 27096
			internal byte[] byte_1;
		}

		// Token: 0x0200119E RID: 4510
		internal sealed class Class883 : MessageBase
		{
			// Token: 0x06006044 RID: 24644 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Deserialize(NetworkReader reader)
			{
				throw null;
			}

			// Token: 0x06006045 RID: 24645 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Serialize(NetworkWriter writer)
			{
				throw null;
			}

			// Token: 0x040069D9 RID: 27097
			internal string string_0;

			// Token: 0x040069DA RID: 27098
			internal int int_0;

			// Token: 0x040069DB RID: 27099
			internal float float_0;
		}
	}
}
