using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Game.Spawning;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT
{
	// Token: 0x020012CD RID: 4813
	public class BotsController : GInterface3, IZones
	{
		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x060063D7 RID: 25559 RVA: 0x00002050 File Offset: 0x00000250
		public static WildSpawnType[] AllTypes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x060063D8 RID: 25560 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063D9 RID: 25561 RVA: 0x00002050 File Offset: 0x00000250
		public AITaskManager AiTaskManager
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

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x060063DA RID: 25562 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063DB RID: 25563 RVA: 0x00002050 File Offset: 0x00000250
		public BotsEventsController EventsController
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

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x060063DC RID: 25564 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063DD RID: 25565 RVA: 0x00002050 File Offset: 0x00000250
		public IBotGame BotGame
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

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x060063DE RID: 25566 RVA: 0x00002050 File Offset: 0x00000250
		public AICoversData CoversData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x060063DF RID: 25567 RVA: 0x00002050 File Offset: 0x00000250
		public GameDateTime GameDateTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x060063E0 RID: 25568 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsEnable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x060063E1 RID: 25569 RVA: 0x00002050 File Offset: 0x00000250
		public int AliveAndLoadingBotsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x060063E2 RID: 25570 RVA: 0x00002050 File Offset: 0x00000250
		public int AliveLoadingDelayedBotsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x060063E3 RID: 25571 RVA: 0x00002050 File Offset: 0x00000250
		public BotSpawner BotSpawner
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x060063E4 RID: 25572 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063E5 RID: 25573 RVA: 0x00002050 File Offset: 0x00000250
		public IPlayersCollection Players
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

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x060063E6 RID: 25574 RVA: 0x00002050 File Offset: 0x00000250
		public BotTradersServices BotTradersServices
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(IBotGame botGame, IBotCreator botCreator, BotZone[] botZones, ISpawnSystem spawnSystem, BotLocationModifier botLocationModifier, bool botEnable, bool freeForAll, bool enableWaveControl, bool online, bool haveSectants, [NotNull] IPlayersCollection players, string openZones)
		{
			throw null;
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disable()
		{
			throw null;
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BotZoneGroupsDictionary Groups()
		{
			throw null;
		}

		// Token: 0x060063EB RID: 25579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Dictionary<PatrolPoint, BotZone> method_1(BotZone[] zones)
		{
			throw null;
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Vector3 explosionPosition, string playerProfileID, bool isSmoke, float smokeRadius, float smokeLifeTime)
		{
			throw null;
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Grenade grenade, Vector3 position, Vector3 force, float mass)
		{
			throw null;
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Player player)
		{
			throw null;
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(Player player)
		{
			throw null;
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(List<Player> passengers)
		{
			throw null;
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(Player player)
		{
			throw null;
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		Vector3? IZones.GetBossPosition(BotZone zone, Vector3? closestBossPos)
		{
			throw null;
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		ISpawnPoint[] IZones.ZoneSpawnPoints(string zoneName)
		{
			throw null;
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerable<string> IZones.ZoneNames(bool canBeSnipe)
		{
			throw null;
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		ISpawnPoint[] IZones.AllZonesSpawnPoints(bool canBeSnipe)
		{
			throw null;
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ActivateBotsByWave(BotWaveDataClass wave)
		{
			throw null;
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ActivateBotsByWave(BossLocationSpawn wave)
		{
			throw null;
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ActivateBotsWithoutWave(int count, IGetProfileData data)
		{
			throw null;
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(IPlayer killer, IPlayer target)
		{
			throw null;
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(DamageInfo damageInfo, Player target)
		{
			throw null;
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddEnemyToAllGroupsInBotZone(IPlayer aggressor, IPlayer groupOwner, IPlayer target)
		{
			throw null;
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddEnemyToAllGroups(IPlayer aggressor, IPlayer groupOwner, IPlayer target)
		{
			throw null;
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BotZone GetClosestZone(Vector3 position, out float dist)
		{
			throw null;
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SpawnBotDebugClient(EPlayerSide side, bool canBeSnipe, DebugBotProfileChooser profile = DebugBotProfileChooser.Random, bool forcedSpawn = false)
		{
			throw null;
		}

		// Token: 0x06006402 RID: 25602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x06006403 RID: 25603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SpawnBotDebugServerLocalFiles(EPlayerSide side, bool canBeSnipe, int count, DebugBotProfileChooser profile = DebugBotProfileChooser.Random, bool forcedSpawn = false)
		{
			throw null;
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SpawnBotDebugServer(EPlayerSide side, bool canBeSnipe, WildSpawnType profile = WildSpawnType.assault, BotDifficulty botDifficulty = BotDifficulty.normal, bool forcedSpawn = false)
		{
			throw null;
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyInfo(Player player)
		{
			throw null;
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddActivePLayer(Player player)
		{
			throw null;
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BotOwner ClosestBotToPoint(Vector3 p)
		{
			throw null;
		}

		// Token: 0x06006408 RID: 25608 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSettings(int maxCount, BotPresetClass[] botPresets, GClass525[] botScatterings)
		{
			throw null;
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BotsController FindBotControllerEditorOnly()
		{
			throw null;
		}

		// Token: 0x0600640A RID: 25610 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DebugUpdateSettingsToAllBots()
		{
			throw null;
		}

		// Token: 0x0600640B RID: 25611 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DebugChangeParameter(string cls, string prm, object val)
		{
			throw null;
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SpawnBossDebug()
		{
			throw null;
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetGameDateTime(int hour)
		{
			throw null;
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Player> GetAllBossPlayers()
		{
			throw null;
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BotDied(BotOwner botOwner)
		{
			throw null;
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DebugSpawnServerAnyway()
		{
			throw null;
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAllPlayersPursuitDebug()
		{
			throw null;
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DebugLogsAboultRemoveEnemies()
		{
			throw null;
		}

		// Token: 0x06006413 RID: 25619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string FullBotsCountInfo()
		{
			throw null;
		}

		// Token: 0x04007047 RID: 28743
		public GClass2928 OnlineDependenceSettings;

		// Token: 0x04007048 RID: 28744
		private static WildSpawnType[] _allTypes;

		// Token: 0x04007049 RID: 28745
		public readonly BotsClass Bots;

		// Token: 0x0400704A RID: 28746
		private bool _botEnabled;

		// Token: 0x0400704B RID: 28747
		private BotSpawner _botSpawner;

		// Token: 0x0400704C RID: 28748
		public AICoreControllerClass AICoreController;

		// Token: 0x0400704E RID: 28750
		public AIStationaryController StationaryWeapons;

		// Token: 0x04007050 RID: 28752
		private GClass345 _connections;

		// Token: 0x04007051 RID: 28753
		private AICoversData _coversData;

		// Token: 0x04007053 RID: 28755
		public ZoneLeaveControllerClass ZonesLeaveController;

		// Token: 0x04007054 RID: 28756
		public Dictionary<GameObject, GClass523> AILayerLookObjetcs;

		// Token: 0x04007055 RID: 28757
		private int _maxCount;

		// Token: 0x04007056 RID: 28758
		public BotLocationModifier BotLocationModifier;

		// Token: 0x04007057 RID: 28759
		public GClass546 CutController;

		// Token: 0x04007058 RID: 28760
		private GClass583 _spawnControlScenario;

		// Token: 0x04007059 RID: 28761
		private BotPresetClass[] _botPresets;

		// Token: 0x0400705A RID: 28762
		private GClass525[] _botScatterings;

		// Token: 0x0400705C RID: 28764
		private BotTradersServices _botTradersServices;

		// Token: 0x020012CE RID: 4814
		[CompilerGenerated]
		[Serializable]
		private sealed class Class922
		{
			// Token: 0x06006414 RID: 25620 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(BotZone zone)
			{
				throw null;
			}

			// Token: 0x06006415 RID: 25621 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<ISpawnPoint> method_1(BotZone zone)
			{
				throw null;
			}

			// Token: 0x0400705D RID: 28765
			public static readonly BotsController.Class922 class922_0;

			// Token: 0x0400705E RID: 28766
			public static Func<BotZone, string> func_0;

			// Token: 0x0400705F RID: 28767
			public static Func<BotZone, IEnumerable<ISpawnPoint>> func_1;
		}
	}
}
