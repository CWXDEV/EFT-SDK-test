using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Comfort.Common;
using Dissonance.Networking.Client;
using EFT.BufferZone;
using EFT.Interactive;
using EFT.NextObservedPlayer;
using EFT.UI;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Networking;

namespace EFT
{
	// Token: 0x02001873 RID: 6259
	internal sealed class NetworkGame : AbstractGame, IClientHearingTable, GInterface101, Interface9
	{
		// Token: 0x06008640 RID: 34368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IClientHearingTable.IsHeard()
		{
			throw null;
		}

		// Token: 0x06008641 RID: 34369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IClientHearingTable.ReportAbuse()
		{
			throw null;
		}

		// Token: 0x06008642 RID: 34370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NetworkGame smethod_0(ISession session, ProfileStatusClass profileStatus, RaidSettings raidSettings, Profile savageProfile, InsuranceCompanyClass insurance, GInterface155 inputTree, CommonUI commonUI, PreloaderUI preloaderUI, GameUI gameUI, GClass2136 metricsEvents, GClass2125 metricsCollector, EUpdateQueue updateQueue, TimeSpan sessionTime, Action runCallback, Callback<ExitStatus, TimeSpan, MetricsClass> callback)
		{
			throw null;
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06008643 RID: 34371 RVA: 0x00002050 File Offset: 0x00000250
		private Profile Profile_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06008644 RID: 34372 RVA: 0x00002050 File Offset: 0x00000250
		public override float LastServerTimeStamp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06008645 RID: 34373 RVA: 0x00002050 File Offset: 0x00000250
		public override int LastServerFrameId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06008646 RID: 34374 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008647 RID: 34375 RVA: 0x00002050 File Offset: 0x00000250
		public GameDateTime GameDateTime
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

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06008648 RID: 34376 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008649 RID: 34377 RVA: 0x00002050 File Offset: 0x00000250
		public ulong LocalIndex
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x0600864A RID: 34378 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600864B RID: 34379 RVA: 0x00002050 File Offset: 0x00000250
		public float LocalTime
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

		// Token: 0x1400018C RID: 396
		// (add) Token: 0x0600864C RID: 34380 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600864D RID: 34381 RVA: 0x00002050 File Offset: 0x00000250
		public event Action UpdateByUnity
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600864E RID: 34382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BotUnspawn(BotOwner bot)
		{
			throw null;
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600864F RID: 34383 RVA: 0x00002050 File Offset: 0x00000250
		public string LocationId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06008650 RID: 34384 RVA: 0x00002050 File Offset: 0x00000250
		public override string LocationObjectId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06008651 RID: 34385 RVA: 0x00002050 File Offset: 0x00000250
		protected override string ProfileId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06008652 RID: 34386 RVA: 0x00002050 File Offset: 0x00000250
		protected override GameUI GameUi
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008653 RID: 34387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}

		// Token: 0x06008654 RID: 34388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1()
		{
			throw null;
		}

		// Token: 0x06008655 RID: 34389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		Task Interface9.Run(Interface10 session, bool canRespawn, GameDateTime gameDateTime, IDictionary<string, int> interactables, ResourceKey[] prefabs, string[] customizations, WeatherClass[] weathers, bool isWinter, float fixedDeltaTime, bool speedLimitsEnabled, GClass1735.Config speedLimits, bool encryptionEnabled, bool decryptionEnabled, GClass1792 voipSettings)
		{
			throw null;
		}

		// Token: 0x06008656 RID: 34390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.Stop()
		{
			throw null;
		}

		// Token: 0x06008657 RID: 34391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.Abort(string error)
		{
			throw null;
		}

		// Token: 0x06008658 RID: 34392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x06008659 RID: 34393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600865A RID: 34394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600865B RID: 34395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600865C RID: 34396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600865D RID: 34397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600865E RID: 34398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		Task Interface9.WorldSpawn(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x0600865F RID: 34399 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.WorldUnspawn(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x06008660 RID: 34400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.SubWorldSpawnLoot(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x06008661 RID: 34401 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.SubWorldSpawnSearchLoot(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x06008662 RID: 34402 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.SubWorldUnspawn(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x06008663 RID: 34403 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.PlayerSpawn(NetworkReader reader, Callback<int> callback)
		{
			throw null;
		}

		// Token: 0x06008664 RID: 34404 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.PlayerUnspawn(NetworkReader reader, Callback<int> callback)
		{
			throw null;
		}

		// Token: 0x06008665 RID: 34405 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.ObserverSpawn(NetworkReader reader, Callback<int> callback)
		{
			throw null;
		}

		// Token: 0x06008666 RID: 34406 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_6(ObservedPlayerView player, NetworkReader reader, Callback<int> callback)
		{
			throw null;
		}

		// Token: 0x06008667 RID: 34407 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_7(int playerId)
		{
			throw null;
		}

		// Token: 0x06008668 RID: 34408 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.ObserverUnspawn(NetworkReader reader, Callback<int> callback)
		{
			throw null;
		}

		// Token: 0x06008669 RID: 34409 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.DeathInventorySync(NetworkMessage message)
		{
			throw null;
		}

		// Token: 0x0600866A RID: 34410 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(ExfiltrationPoint point, EExfiltrationStatus prevStatus)
		{
			throw null;
		}

		// Token: 0x0600866B RID: 34411 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(IPlayer observedPlayer)
		{
			throw null;
		}

		// Token: 0x0600866C RID: 34412 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(NetworkMessage networkMessage)
		{
			throw null;
		}

		// Token: 0x0600866D RID: 34413 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(byte channelId, GInterface76 reader)
		{
			throw null;
		}

		// Token: 0x0600866E RID: 34414 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IPlayer method_12(byte channelId)
		{
			throw null;
		}

		// Token: 0x0600866F RID: 34415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.Spawn()
		{
			throw null;
		}

		// Token: 0x06008670 RID: 34416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		Task Interface9.GameSpawned()
		{
			throw null;
		}

		// Token: 0x06008671 RID: 34417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.GameMatching(ushort activitiesCounter, ushort minCounter, int seconds)
		{
			throw null;
		}

		// Token: 0x06008672 RID: 34418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.GameStarting(int seconds)
		{
			throw null;
		}

		// Token: 0x06008673 RID: 34419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.GameStartingWithTeleport(Vector3 position, int exfiltrationId, string entryPoint)
		{
			throw null;
		}

		// Token: 0x06008675 RID: 34421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.GameStarted(float pastTime, int sessionSeconds)
		{
			throw null;
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.GameRestarted()
		{
			throw null;
		}

		// Token: 0x06008677 RID: 34423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15()
		{
			throw null;
		}

		// Token: 0x06008679 RID: 34425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_16()
		{
			throw null;
		}

		// Token: 0x0600867A RID: 34426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.GameRestarting()
		{
			throw null;
		}

		// Token: 0x0600867B RID: 34427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.GetRadioTransmitterData(string profileID)
		{
			throw null;
		}

		// Token: 0x0600867C RID: 34428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.GetTraderServicesData(string profileID, string traderId)
		{
			throw null;
		}

		// Token: 0x0600867D RID: 34429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.GameStopping()
		{
			throw null;
		}

		// Token: 0x0600867E RID: 34430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.GameStopped(ExitStatus exitStatus, TimeSpan playTime)
		{
			throw null;
		}

		// Token: 0x0600867F RID: 34431 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.SoftStopNotification(TimeSpan sessionTime)
		{
			throw null;
		}

		// Token: 0x06008680 RID: 34432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.DevelopSetBotData(byte[] data)
		{
			throw null;
		}

		// Token: 0x06008681 RID: 34433 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.DevelopSetBotDataZones(byte[] data)
		{
			throw null;
		}

		// Token: 0x06008682 RID: 34434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void Interface9.DevelopSetBotDataGroups(byte[] data)
		{
			throw null;
		}

		// Token: 0x06008683 RID: 34435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(Result<ExitStatus, TimeSpan>? result)
		{
			throw null;
		}

		// Token: 0x06008684 RID: 34436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_18()
		{
			throw null;
		}

		// Token: 0x06008685 RID: 34437 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19()
		{
			throw null;
		}

		// Token: 0x06008686 RID: 34438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private MetricsClass method_20()
		{
			throw null;
		}

		// Token: 0x06008687 RID: 34439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21()
		{
			throw null;
		}

		// Token: 0x06008688 RID: 34440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_22(float stopTime, float seconds)
		{
			throw null;
		}

		// Token: 0x06008689 RID: 34441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDisconnectStatusAccepted(GStruct115 disconnectionReason)
		{
			throw null;
		}

		// Token: 0x0600868A RID: 34442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VoipAbuseNotification(string reporterId)
		{
			throw null;
		}

		// Token: 0x0600868B RID: 34443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ParseMineExplosionData(byte[] data)
		{
			throw null;
		}

		// Token: 0x0600868C RID: 34444 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ParseAirdropContainerData(byte[] data)
		{
			throw null;
		}

		// Token: 0x0600868D RID: 34445 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AirdropFlareSuccessEvent(bool canSpawnAirdrop)
		{
			throw null;
		}

		// Token: 0x0600868E RID: 34446 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ParseBufferZoneData(byte[] data)
		{
			throw null;
		}

		// Token: 0x0600868F RID: 34447 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecieveClientRadioTransmitterData(GStruct132 data)
		{
			throw null;
		}

		// Token: 0x06008690 RID: 34448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecieveObserverRadioTransmitterData(GStruct132 data)
		{
			throw null;
		}

		// Token: 0x06008691 RID: 34449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTraderServicesData(byte[] packet)
		{
			throw null;
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecieveLighthouseTraderZoneData(GStruct131 data)
		{
			throw null;
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveCompletedAchievementsData(GStruct218 data)
		{
			throw null;
		}

		// Token: 0x06008694 RID: 34452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_23(float stopTime, float seconds)
		{
			throw null;
		}

		// Token: 0x06008695 RID: 34453 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_24()
		{
			throw null;
		}

		// Token: 0x06008696 RID: 34454 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_25(string error)
		{
			throw null;
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06008697 RID: 34455 RVA: 0x00002050 File Offset: 0x00000250
		public bool CoopEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008698 RID: 34456 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task ApplyCoopSetting()
		{
			throw null;
		}

		// Token: 0x06008699 RID: 34457 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_26(Player player)
		{
			throw null;
		}

		// Token: 0x0600869A RID: 34458 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_27()
		{
			throw null;
		}

		// Token: 0x0600869B RID: 34459 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_28(Player x)
		{
			throw null;
		}

		// Token: 0x0600869C RID: 34460 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_29()
		{
			throw null;
		}

		// Token: 0x0600869D RID: 34461 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_30(EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x0600869E RID: 34462 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_31()
		{
			throw null;
		}

		// Token: 0x04008CDA RID: 36058
		private const float float_1 = 2f;

		// Token: 0x04008CDB RID: 36059
		private ProfileStatusClass gclass1744_0;

		// Token: 0x04008CDC RID: 36060
		private Profile profile_0;

		// Token: 0x04008CDD RID: 36061
		private Profile profile_1;

		// Token: 0x04008CDE RID: 36062
		private GInterface155 ginterface155_0;

		// Token: 0x04008CDF RID: 36063
		private CommonUI commonUI_0;

		// Token: 0x04008CE0 RID: 36064
		private PreloaderUI preloaderUI_0;

		// Token: 0x04008CE1 RID: 36065
		private GameUI gameUI_0;

		// Token: 0x04008CE2 RID: 36066
		private Action action_0;

		// Token: 0x04008CE3 RID: 36067
		private Callback<ExitStatus, TimeSpan, MetricsClass> callback_0;

		// Token: 0x04008CE4 RID: 36068
		private Coroutine coroutine_0;

		// Token: 0x04008CE5 RID: 36069
		private LocationSettingsClass.Location location_0;

		// Token: 0x04008CE6 RID: 36070
		private Interface10 interface10_0;

		// Token: 0x04008CE7 RID: 36071
		private bool bool_2;

		// Token: 0x04008CE8 RID: 36072
		private ClientPlayer clientPlayer_0;

		// Token: 0x04008CE9 RID: 36073
		private GamePlayerOwner gamePlayerOwner_0;

		// Token: 0x04008CEA RID: 36074
		private readonly Dictionary<int, IPlayer> dictionary_0;

		// Token: 0x04008CEB RID: 36075
		private readonly Dictionary<byte, IPlayer> dictionary_1;

		// Token: 0x04008CEC RID: 36076
		private readonly Dictionary<byte, GClass1650> dictionary_2;

		// Token: 0x04008CED RID: 36077
		protected GClass1635 gclass1635_0;

		// Token: 0x04008CEE RID: 36078
		protected GClass2359 gclass2359_0;

		// Token: 0x04008CEF RID: 36079
		private ESideType esideType_0;

		// Token: 0x04008CF0 RID: 36080
		private ERaidMode eraidMode_0;

		// Token: 0x04008CF1 RID: 36081
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x04008CF2 RID: 36082
		private ISession ginterface145_0;

		// Token: 0x04008CF3 RID: 36083
		private GClass2125 gclass2125_0;

		// Token: 0x04008CF4 RID: 36084
		private GClass2136 gclass2136_0;

		// Token: 0x04008CF5 RID: 36085
		private GClass2143 gclass2143_0;

		// Token: 0x04008CF6 RID: 36086
		private BufferZoneDataReciever bufferZoneDataReciever_0;

		// Token: 0x04008CF7 RID: 36087
		[CanBeNull]
		private GClass23 gclass23_0;

		// Token: 0x04008CF8 RID: 36088
		[CanBeNull]
		private GClass2379 gclass2379_0;

		// Token: 0x04008CF9 RID: 36089
		private GClass2914 gclass2914_0;

		// Token: 0x04008CFA RID: 36090
		[CompilerGenerated]
		private GameDateTime gameDateTime_0;

		// Token: 0x04008CFB RID: 36091
		[CompilerGenerated]
		private ulong ulong_0;

		// Token: 0x04008CFC RID: 36092
		[CompilerGenerated]
		private float float_2;

		// Token: 0x04008CFD RID: 36093
		[CompilerGenerated]
		private Action action_1;

		// Token: 0x04008CFE RID: 36094
		private GStruct115 gstruct115_0;

		// Token: 0x04008CFF RID: 36095
		private readonly CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x04008D00 RID: 36096
		private Result<ExitStatus, TimeSpan>? nullable_0;

		// Token: 0x04008D01 RID: 36097
		private bool bool_3;

		// Token: 0x04008D02 RID: 36098
		private bool bool_4;

		// Token: 0x04008D03 RID: 36099
		private float float_3;

		// Token: 0x04008D04 RID: 36100
		private GClass1792 gclass1792_0;

		// Token: 0x04008D05 RID: 36101
		private float float_4;

		// Token: 0x04008D06 RID: 36102
		private uint uint_0;

		// Token: 0x04008D07 RID: 36103
		private DateTime dateTime_0;

		// Token: 0x04008D08 RID: 36104
		private DateTime dateTime_1;

		// Token: 0x04008D09 RID: 36105
		private DateTime dateTime_2;

		// Token: 0x04008D0A RID: 36106
		private string string_0;

		// Token: 0x04008D0B RID: 36107
		private GInterface76 ginterface76_0;

		// Token: 0x04008D0C RID: 36108
		private RaidSettings raidSettings_0;

		// Token: 0x02001874 RID: 6260
		private class Class1372
		{
		}

		// Token: 0x02001875 RID: 6261
		[CompilerGenerated]
		private sealed class Class1373
		{
			// Token: 0x0600869F RID: 34463 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass2933 method_0(string x)
			{
				throw null;
			}

			// Token: 0x060086A0 RID: 34464 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ResourceKey method_1(GClass2933 x)
			{
				throw null;
			}

			// Token: 0x060086A1 RID: 34465 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(GStruct117 p)
			{
				throw null;
			}

			// Token: 0x04008D0D RID: 36109
			public GClass1441 customizationSolver;

			// Token: 0x04008D0E RID: 36110
			public NetworkGame networkGame_0;
		}

		// Token: 0x02001876 RID: 6262
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1374
		{
			// Token: 0x060086A2 RID: 34466 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass2933 x)
			{
				throw null;
			}

			// Token: 0x060086A3 RID: 34467 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ResourceKey method_1(GClass2933 x)
			{
				throw null;
			}

			// Token: 0x060086A4 RID: 34468 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(ResourceKey x)
			{
				throw null;
			}

			// Token: 0x060086A5 RID: 34469 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(SmallPhysicsObject x)
			{
				throw null;
			}

			// Token: 0x04008D0F RID: 36111
			public static readonly NetworkGame.Class1374 class1374_0;

			// Token: 0x04008D10 RID: 36112
			public static Func<GClass2933, bool> func_0;

			// Token: 0x04008D11 RID: 36113
			public static Func<GClass2933, ResourceKey> func_1;

			// Token: 0x04008D12 RID: 36114
			public static Func<ResourceKey, bool> func_2;

			// Token: 0x04008D13 RID: 36115
			public static Action<SmallPhysicsObject> action_0;
		}

		// Token: 0x02001878 RID: 6264
		[CompilerGenerated]
		private sealed class Class1375
		{
			// Token: 0x060086A8 RID: 34472 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(byte channel, in ArraySegment<byte> segment)
			{
				throw null;
			}

			// Token: 0x060086A9 RID: 34473 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(IResult result)
			{
				throw null;
			}

			// Token: 0x04008D2E RID: 36142
			public NetworkGame networkGame_0;

			// Token: 0x04008D2F RID: 36143
			public Callback<int> callback;

			// Token: 0x04008D30 RID: 36144
			public int id;
		}

		// Token: 0x0200187A RID: 6266
		[CompilerGenerated]
		private sealed class Class1376
		{
			// Token: 0x060086AC RID: 34476 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(IPlayer value)
			{
				throw null;
			}

			// Token: 0x04008D37 RID: 36151
			public byte channelId;
		}

		// Token: 0x0200187C RID: 6268
		[CompilerGenerated]
		private sealed class Class1377
		{
			// Token: 0x060086AF RID: 34479 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008D3C RID: 36156
			public ExfiltrationPoint point;

			// Token: 0x04008D3D RID: 36157
			public NetworkGame networkGame_0;
		}

		// Token: 0x0200187D RID: 6269
		[CompilerGenerated]
		private sealed class Class1378
		{
			// Token: 0x060086B0 RID: 34480 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008D3E RID: 36158
			public ReconnectionScreen.GClass3129 reconnectionScreenController;

			// Token: 0x04008D3F RID: 36159
			public NetworkGame networkGame_0;
		}

		// Token: 0x02001881 RID: 6273
		[CompilerGenerated]
		private sealed class Class1382
		{
			// Token: 0x060086C0 RID: 34496 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(MineDirectional mine)
			{
				throw null;
			}

			// Token: 0x04008D51 RID: 36177
			public Vector3 minePosition;
		}

		// Token: 0x02001883 RID: 6275
		[CompilerGenerated]
		private sealed class Class1384
		{
			// Token: 0x060086C5 RID: 34501 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008D57 RID: 36183
			public bool complete;

			// Token: 0x04008D58 RID: 36184
			public NetworkGame networkGame_0;
		}

		// Token: 0x02001885 RID: 6277
		[CompilerGenerated]
		private sealed class Class1386
		{
			// Token: 0x060086CB RID: 34507 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008D5F RID: 36191
			public bool complete;
		}
	}
}
