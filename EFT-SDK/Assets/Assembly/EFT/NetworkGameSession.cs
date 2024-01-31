using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.Counters;
using UnityEngine;
using UnityEngine.Networking;

namespace EFT
{
	// Token: 0x02001888 RID: 6280
	internal sealed class NetworkGameSession : AbstractGameSession, Class1371.Interface8, Interface10
	{
		// Token: 0x060086D3 RID: 34515 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NetworkGameSession smethod_0(NetworkGame game, string profileId, string token, LoggerClass logger, Action onConnected = null)
		{
			throw null;
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x060086D4 RID: 34516 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060086D5 RID: 34517 RVA: 0x00002050 File Offset: 0x00000250
		public bool ObserveOnly
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x060086D6 RID: 34518 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060086D7 RID: 34519 RVA: 0x00002050 File Offset: 0x00000250
		public byte[] OpenEncryptionKey
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x060086D8 RID: 34520 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060086D9 RID: 34521 RVA: 0x00002050 File Offset: 0x00000250
		public int OpenEncryptionKeyLength
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x060086DA RID: 34522 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060086DB RID: 34523 RVA: 0x00002050 File Offset: 0x00000250
		public NetworkClient NetworkClient
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x060086DC RID: 34524 RVA: 0x00002050 File Offset: 0x00000250
		public static double AverageRangeTrend
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x060086DD RID: 34525 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060086DE RID: 34526 RVA: 0x00002050 File Offset: 0x00000250
		public static double RTT
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x060086DF RID: 34527 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060086E0 RID: 34528 RVA: 0x00002050 File Offset: 0x00000250
		public static bool ClientServerConnectionLags
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x060086E1 RID: 34529 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060086E2 RID: 34530 RVA: 0x00002050 File Offset: 0x00000250
		public static int LossPercent
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x060086E3 RID: 34531 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasAuthority
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060086E4 RID: 34532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(HostTopology hostTopology, string address, int port)
		{
			throw null;
		}

		// Token: 0x060086E5 RID: 34533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(HostTopology hostTopology, string address, int port, int latency, float packetLoss)
		{
			throw null;
		}

		// Token: 0x060086E6 RID: 34534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Class1371.Interface8.OnConnect(NetworkConnection connection)
		{
			throw null;
		}

		// Token: 0x060086E7 RID: 34535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Class1371.Interface8.OnDisconnect(NetworkConnection connection)
		{
			throw null;
		}

		// Token: 0x060086E8 RID: 34536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060086E9 RID: 34537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x060086EA RID: 34538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_6(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x060086EB RID: 34539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x060086EC RID: 34540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x060086ED RID: 34541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_9(AbstractGameSession.Class878 response)
		{
			throw null;
		}

		// Token: 0x060086EE RID: 34542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(string serverIp)
		{
			throw null;
		}

		// Token: 0x060086F1 RID: 34545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(NetworkMessage netMsg)
		{
			throw null;
		}

		// Token: 0x060086F2 RID: 34546 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x060086F3 RID: 34547 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_13(int id, byte[] prefabsData, byte[] customizationsData)
		{
			throw null;
		}

		// Token: 0x060086F4 RID: 34548 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(int id, float progressValue)
		{
			throw null;
		}

		// Token: 0x060086F5 RID: 34549 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStartAuthority()
		{
			throw null;
		}

		// Token: 0x060086F6 RID: 34550 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.Spawn()
		{
			throw null;
		}

		// Token: 0x060086F7 RID: 34551 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x060086F8 RID: 34552 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_16(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x060086F9 RID: 34553 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.Respawn()
		{
			throw null;
		}

		// Token: 0x060086FA RID: 34554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.RequestBotDevelopData(string profileId)
		{
			throw null;
		}

		// Token: 0x060086FB RID: 34555 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.RequestBotDevelopDataZones()
		{
			throw null;
		}

		// Token: 0x060086FC RID: 34556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.RequestBotDevelopDataGroups()
		{
			throw null;
		}

		// Token: 0x060086FD RID: 34557 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.RequestBotDevelopDataProfiles()
		{
			throw null;
		}

		// Token: 0x060086FE RID: 34558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.StartGame()
		{
			throw null;
		}

		// Token: 0x060086FF RID: 34559 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.StartGameAfterTeleport()
		{
			throw null;
		}

		// Token: 0x06008700 RID: 34560 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.RestartGameInitiate()
		{
			throw null;
		}

		// Token: 0x06008701 RID: 34561 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.RestartGame()
		{
			throw null;
		}

		// Token: 0x06008702 RID: 34562 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.StopGame()
		{
			throw null;
		}

		// Token: 0x06008703 RID: 34563 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.GameStarted()
		{
			throw null;
		}

		// Token: 0x06008704 RID: 34564 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.ReportVoipAbuse()
		{
			throw null;
		}

		// Token: 0x06008705 RID: 34565 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.PlayerEffectsPause(string playerProfileID, bool isPaused)
		{
			throw null;
		}

		// Token: 0x06008706 RID: 34566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(GClass2904 invokedEvent)
		{
			throw null;
		}

		// Token: 0x06008707 RID: 34567 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(GClass2889 invokedEvent)
		{
			throw null;
		}

		// Token: 0x06008708 RID: 34568 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.OnPlayerKeeperStatisticsChanged(string playerProfileID, CounterTag statisticsType, int valueToSet)
		{
			throw null;
		}

		// Token: 0x06008709 RID: 34569 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19(GClass2899 invokedEvent)
		{
			throw null;
		}

		// Token: 0x0600870A RID: 34570 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.CmdGetRadiotransmitterData(string playerProfileID)
		{
			throw null;
		}

		// Token: 0x0600870B RID: 34571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.CmdGetTraderServicesData(string playerProfileID, string traderId)
		{
			throw null;
		}

		// Token: 0x0600870C RID: 34572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface10.DevelopmentSpawn(EPlayerSide side, WildSpawnType profile, BotDifficulty difficulty)
		{
			throw null;
		}

		// Token: 0x0600870D RID: 34573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GameObject method_20(Vector3 position, NetworkHash128 id)
		{
			throw null;
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1(GameObject sessionObject)
		{
			throw null;
		}

		// Token: 0x0600870F RID: 34575 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21(NetworkConnection connection, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06008710 RID: 34576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x06008711 RID: 34577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_23(NetworkConnection connection, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06008712 RID: 34578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_24(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x06008713 RID: 34579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcGameSpawned()
		{
			throw null;
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcGameMatching(ushort activitiesCounter, ushort minCounter, int seconds)
		{
			throw null;
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcGameStarting(int seconds)
		{
			throw null;
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcGameStartingWithTeleport(Vector3 position, int exfiltrationId, string entryPoint)
		{
			throw null;
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcGameStarted(float pastTime, int sessionSeconds)
		{
			throw null;
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcGameRestarting()
		{
			throw null;
		}

		// Token: 0x06008719 RID: 34585 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcDevelopSendBotData(byte[] data)
		{
			throw null;
		}

		// Token: 0x0600871A RID: 34586 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcDevelopSendBotDataZone(byte[] data)
		{
			throw null;
		}

		// Token: 0x0600871B RID: 34587 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcDevelopSendBotDataGroups(byte[] data)
		{
			throw null;
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcGameRestarted()
		{
			throw null;
		}

		// Token: 0x0600871D RID: 34589 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcGameStopping()
		{
			throw null;
		}

		// Token: 0x0600871E RID: 34590 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcGameStopped(ExitStatus exitStatus, int playSeconds)
		{
			throw null;
		}

		// Token: 0x0600871F RID: 34591 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcSyncGameTime(long game)
		{
			throw null;
		}

		// Token: 0x06008720 RID: 34592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcDevelopmentSpawnBotResponse(EPlayerSide side, int instanceId)
		{
			throw null;
		}

		// Token: 0x06008721 RID: 34593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcSoftStopNotification(int sessionSeconds)
		{
			throw null;
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcVoipAbuseNotification(string reporterId)
		{
			throw null;
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcAirdropContainerData(byte[] data)
		{
			throw null;
		}

		// Token: 0x06008724 RID: 34596 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcSuccessAirdropFlareEvent(bool canSendAirdrop)
		{
			throw null;
		}

		// Token: 0x06008725 RID: 34597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcMineDirectionExplosion(byte[] data)
		{
			throw null;
		}

		// Token: 0x06008726 RID: 34598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcBufferZoneData(byte[] data)
		{
			throw null;
		}

		// Token: 0x06008727 RID: 34599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcSendClientRadioTransmitterData(GStruct132 data)
		{
			throw null;
		}

		// Token: 0x06008728 RID: 34600 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcSendObserverRadioTransmitterData(GStruct132 data)
		{
			throw null;
		}

		// Token: 0x06008729 RID: 34601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcSendTraderServicesData(byte[] packet)
		{
			throw null;
		}

		// Token: 0x0600872A RID: 34602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcSyncLighthouseTraderZoneData(GStruct131 data)
		{
			throw null;
		}

		// Token: 0x0600872B RID: 34603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcSendCompletedAchievementsData(GStruct218 data)
		{
			throw null;
		}

		// Token: 0x0600872C RID: 34604 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x0600872D RID: 34605 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RpcStartDisconnectionProcedure(int disconnectionCode, string additionalInfo, string technicalMessage)
		{
			throw null;
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_25(Result<int> result)
		{
			throw null;
		}

		// Token: 0x06008731 RID: 34609 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_26(Result<int> result)
		{
			throw null;
		}

		// Token: 0x06008732 RID: 34610 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_27(Result<int> result)
		{
			throw null;
		}

		// Token: 0x06008733 RID: 34611 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_28(Result<int> result)
		{
			throw null;
		}

		// Token: 0x06008734 RID: 34612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_29()
		{
			throw null;
		}

		// Token: 0x06008735 RID: 34613 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			throw null;
		}

		// Token: 0x06008736 RID: 34614 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
			throw null;
		}

		// Token: 0x06008737 RID: 34615 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PreStartClient()
		{
			throw null;
		}

		// Token: 0x04008D6A RID: 36202
		private LoggerClass gclass611_0;

		// Token: 0x04008D6B RID: 36203
		private static float float_0;

		// Token: 0x04008D6C RID: 36204
		private const string string_2 = "anticheat";

		// Token: 0x04008D6D RID: 36205
		private const string string_3 = "resources";

		// Token: 0x04008D6E RID: 36206
		private GClass1638 gclass1638_0;

		// Token: 0x04008D6F RID: 36207
		private readonly GClass763 gclass763_0;

		// Token: 0x04008D70 RID: 36208
		private Class1371 class1371_0;

		// Token: 0x04008D71 RID: 36209
		private Interface9 interface9_0;

		// Token: 0x04008D72 RID: 36210
		private readonly List<int> list_0;

		// Token: 0x04008D73 RID: 36211
		private DateTime dateTime_0;

		// Token: 0x04008D74 RID: 36212
		private readonly TimeSpan timeSpan_0;

		// Token: 0x04008D75 RID: 36213
		private readonly Dictionary<int, NetworkWriter> dictionary_0;

		// Token: 0x04008D76 RID: 36214
		private NetworkGameSession.Class345 class345_0;

		// Token: 0x04008D77 RID: 36215
		private Action action_0;

		// Token: 0x04008D78 RID: 36216
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04008D79 RID: 36217
		[CompilerGenerated]
		private byte[] byte_0;

		// Token: 0x04008D7A RID: 36218
		[CompilerGenerated]
		private int int_51;

		// Token: 0x04008D7B RID: 36219
		[CompilerGenerated]
		private NetworkClient networkClient_0;

		// Token: 0x04008D7C RID: 36220
		private Dictionary<int, List<ValueTuple<int, byte[]>>> dictionary_1;

		// Token: 0x04008D7D RID: 36221
		private static readonly GClass739 gclass739_0;

		// Token: 0x04008D7E RID: 36222
		private static readonly GClass703 gclass703_0;

		// Token: 0x04008D7F RID: 36223
		private static double double_0;

		// Token: 0x04008D80 RID: 36224
		private static float float_1;

		// Token: 0x04008D81 RID: 36225
		[CompilerGenerated]
		private static int int_52;

		// Token: 0x02001889 RID: 6281
		private sealed class Class344 : LoggerClass
		{
		}

		// Token: 0x0200188A RID: 6282
		private sealed class Class345 : LoggerClass
		{
		}

		// Token: 0x0200188B RID: 6283
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1388
		{
			// Token: 0x06008738 RID: 34616 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x06008739 RID: 34617 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_1(GStruct117 p)
			{
				throw null;
			}

			// Token: 0x04008D82 RID: 36226
			public static readonly NetworkGameSession.Class1388 class1388_0;

			// Token: 0x04008D83 RID: 36227
			public static Action action_0;

			// Token: 0x04008D84 RID: 36228
			public static Func<GStruct117, float> func_0;
		}

		// Token: 0x0200188E RID: 6286
		[CompilerGenerated]
		private sealed class Class1389
		{
			// Token: 0x0600873E RID: 34622 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008D90 RID: 36240
			public NetworkGameSession networkGameSession_0;

			// Token: 0x04008D91 RID: 36241
			public AbstractGameSession.Class878 response;
		}

		// Token: 0x02001890 RID: 6288
		[CompilerGenerated]
		private sealed class Class1390
		{
			// Token: 0x06008741 RID: 34625 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ResourceKey[] method_0()
			{
				throw null;
			}

			// Token: 0x06008742 RID: 34626 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(float p)
			{
				throw null;
			}

			// Token: 0x04008DA2 RID: 36258
			public byte[] prefabsData;

			// Token: 0x04008DA3 RID: 36259
			public byte[] customizationsData;

			// Token: 0x04008DA4 RID: 36260
			public NetworkGameSession networkGameSession_0;

			// Token: 0x04008DA5 RID: 36261
			public int id;

			// Token: 0x04008DA6 RID: 36262
			public float time;
		}

		// Token: 0x02001891 RID: 6289
		[CompilerGenerated]
		private sealed class Class1391
		{
			// Token: 0x06008743 RID: 34627 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ResourceKey method_0(string x)
			{
				throw null;
			}

			// Token: 0x04008DA7 RID: 36263
			public GClass1441 solver;
		}
	}
}
