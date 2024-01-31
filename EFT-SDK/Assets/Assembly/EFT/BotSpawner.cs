using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.Game.Spawning;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT
{
	// Token: 0x020012E4 RID: 4836
	public abstract class BotSpawner : GInterface19
	{
		// Token: 0x14000115 RID: 277
		// (add) Token: 0x06006443 RID: 25667 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006444 RID: 25668 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<BotOwner> OnBotCreated
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

		// Token: 0x14000116 RID: 278
		// (add) Token: 0x06006445 RID: 25669 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006446 RID: 25670 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<BotOwner> OnBotRemoved
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

		// Token: 0x14000117 RID: 279
		// (add) Token: 0x06006447 RID: 25671 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006448 RID: 25672 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<GClass1468> OnSpawnedWave
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

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06006449 RID: 25673 RVA: 0x00002050 File Offset: 0x00000250
		public int MaxBots
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600644A RID: 25674 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanSpawnRole(IGetProfileData data)
		{
			throw null;
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlockedRoles(string[] resultExcludedBosses)
		{
			throw null;
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private BotZone[] method_0(string openZones, BotZone[] botZones)
		{
			throw null;
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x0600644D RID: 25677 RVA: 0x00002050 File Offset: 0x00000250
		public BotZoneGroupsDictionary Groups
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x0600644E RID: 25678 RVA: 0x00002050 File Offset: 0x00000250
		public IBotGame BotGame
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x0600644F RID: 25679 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsProfilesLoaded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06006450 RID: 25680 RVA: 0x00002050 File Offset: 0x00000250
		public int AllBotsWithLoaded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06006451 RID: 25681 RVA: 0x00002050 File Offset: 0x00000250
		public int AliveAndLoadingBotsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06006452 RID: 25682 RVA: 0x00002050 File Offset: 0x00000250
		public int AllBotsWithDelayed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06006453 RID: 25683 RVA: 0x00002050 File Offset: 0x00000250
		public int BotsDelayed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06006454 RID: 25684 RVA: 0x00002050 File Offset: 0x00000250
		public int PlayersCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06006455 RID: 25685 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Player> GetAllBossPLayers()
		{
			throw null;
		}

		// Token: 0x06006456 RID: 25686 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Player GetPlayer(int index)
		{
			throw null;
		}

		// Token: 0x06006457 RID: 25687 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BotZone GetRandomBotZone(bool canBeSnipe)
		{
			throw null;
		}

		// Token: 0x06006458 RID: 25688 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActorDataStruct BotDebugData(IPlayer currentPlayer, string profileId)
		{
			throw null;
		}

		// Token: 0x06006459 RID: 25689 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct11 DebugSpawnsData()
		{
			throw null;
		}

		// Token: 0x0600645A RID: 25690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_1(EPlayerSide side, BotZone zone, DebugBotProfileChooser profileType = DebugBotProfileChooser.Random, bool ignoreConditions = false)
		{
			throw null;
		}

		// Token: 0x0600645B RID: 25691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_2(EPlayerSide side, BotZone zone, int count, DebugBotProfileChooser profileType = DebugBotProfileChooser.Random, bool ignoreConditions = false)
		{
			throw null;
		}

		// Token: 0x0600645C RID: 25692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_3(EPlayerSide side, BotZone zone, WildSpawnType profileType = WildSpawnType.assault, BotDifficulty botDifficulty = BotDifficulty.normal, bool forcedSpawn = false)
		{
			throw null;
		}

		// Token: 0x0600645D RID: 25693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<BotOwner> method_4(BotOwner owner)
		{
			throw null;
		}

		// Token: 0x0600645E RID: 25694 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BotsGroup GetGroupAndSetEnemies(BotOwner bot, BotZone zone)
		{
			throw null;
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ActivateBotsByWave(BossLocationSpawn wave)
		{
			throw null;
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task ActivateBotsWithoutWave(int count, IGetProfileData data)
		{
			throw null;
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task ActivateBotsByWave(BotWaveDataClass wave)
		{
			throw null;
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckOnMax(int wantSpawn, out int toDelay, out int toSpawn, bool calcOnlySimpleBots = false)
		{
			throw null;
		}

		// Token: 0x06006463 RID: 25699
		protected abstract GClass580 TrySpawnFreeInner(GClass588 data, bool newWave);

		// Token: 0x06006464 RID: 25700 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TrySpawnFreeAndDelay(GClass588 data, bool newWave)
		{
			throw null;
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BotZone GetClosestZone(Vector3 position, out float dist)
		{
			throw null;
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected BotZone GetClosestZone(Vector3 position, Dictionary<PatrolPoint, BotZone> testingZones, out float dist)
		{
			throw null;
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(IPlayer person)
		{
			throw null;
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SpawnBotBTR()
		{
			throw null;
		}

		// Token: 0x06006469 RID: 25705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass580 TryToSpawnInZoneInner(BotZone botZone, GClass588 data, int count, bool withCheckMinMax, bool newWave, List<ISpawnPoint> pointsToSpawn = null, bool forcedSpawn = false)
		{
			throw null;
		}

		// Token: 0x0600646A RID: 25706 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TryToSpawnInZoneAndDelay(BotZone botZone, GClass588 data, bool withCheckMinMax, bool newWave, List<ISpawnPoint> pointsToSpawn = null, bool forcedSpawn = false)
		{
			throw null;
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SpawnBotsInZoneOnPositions(List<ISpawnPoint> openedPositions, BotZone botZone, GClass588 data, Action<BotOwner> callback = null)
		{
			throw null;
		}

		// Token: 0x0600646C RID: 25708 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_6(List<ISpawnPoint> spawnPoints, BotZone botZone, GClass588 data, Action<BotOwner> callback, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600646D RID: 25709 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(GClass580 delayedBotsInfo)
		{
			throw null;
		}

		// Token: 0x0600646E RID: 25710 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_8(GClass580 v1, GClass580 v2)
		{
			throw null;
		}

		// Token: 0x0600646F RID: 25711 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task DebugSpawnAnyway()
		{
			throw null;
		}

		// Token: 0x06006470 RID: 25712 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(BotZone zone, GClass588 data, Action<BotOwner> callback, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06006471 RID: 25713 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(BotOwner bot, GClass588 data, Action<BotOwner> callback, bool shallBeGroup, Stopwatch stopWatch)
		{
			throw null;
		}

		// Token: 0x06006472 RID: 25714 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(BotOwner bot)
		{
			throw null;
		}

		// Token: 0x06006473 RID: 25715 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BotOwner> GetAllBotsNearTarget(Vector3 t, float dist)
		{
			throw null;
		}

		// Token: 0x06006474 RID: 25716 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BotOwner ClosestBotToPoint(Vector3 t)
		{
			throw null;
		}

		// Token: 0x06006475 RID: 25717 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BotZone GetZoneByName(string name)
		{
			throw null;
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<BotZone> SpawnZones(bool canBeSnipe)
		{
			throw null;
		}

		// Token: 0x06006478 RID: 25720 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BotDied(BotOwner bot)
		{
			throw null;
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeletePlayer(Player player)
		{
			throw null;
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPlayer(Player player)
		{
			throw null;
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(AIData aiData)
		{
			throw null;
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMaxBots(int maxCount)
		{
			throw null;
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAllPlayersPursuitDebug()
		{
			throw null;
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DebugLogsAboultRemoveEnemies()
		{
			throw null;
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CancellationToken GetCancelToken()
		{
			throw null;
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FillProfilesData(GClass340 resultCache)
		{
			throw null;
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string FullBotsCountInfo()
		{
			throw null;
		}

		// Token: 0x040070B9 RID: 28857
		private bool _gameEnd;

		// Token: 0x040070BA RID: 28858
		private readonly bool _freeForAll;

		// Token: 0x040070BB RID: 28859
		private readonly IBotCreator _botCreator;

		// Token: 0x040070BC RID: 28860
		public readonly BossSpawnerClass BossSpawner;

		// Token: 0x040070BD RID: 28861
		protected readonly BotsClass _bots;

		// Token: 0x040070BE RID: 28862
		protected BotZone[] _allBotZones;

		// Token: 0x040070BF RID: 28863
		protected BotZone[] _openedZones;

		// Token: 0x040070C0 RID: 28864
		protected Dictionary<PatrolPoint, BotZone> _zonesPatrols;

		// Token: 0x040070C1 RID: 28865
		protected Dictionary<PatrolPoint, BotZone> _zonesPatrolsSnipe;

		// Token: 0x040070C2 RID: 28866
		private readonly DeadBodiesController _deadBodiesController;

		// Token: 0x040070C3 RID: 28867
		protected readonly GClass581 _delayedSpawnBotsInfo;

		// Token: 0x040070C4 RID: 28868
		private readonly IBotGame _game;

		// Token: 0x040070C5 RID: 28869
		private readonly BotZoneGroupsDictionary _groups;

		// Token: 0x040070C6 RID: 28870
		private ISpawnSystem _spawnSystem;

		// Token: 0x040070C7 RID: 28871
		private int _allBotsCount;

		// Token: 0x040070C8 RID: 28872
		private int _followersBotsCount;

		// Token: 0x040070C9 RID: 28873
		private int _bossBotsCount;

		// Token: 0x040070CA RID: 28874
		private int _inSpawnProcess;

		// Token: 0x040070CB RID: 28875
		protected readonly List<Player> _allPlayers;

		// Token: 0x040070CC RID: 28876
		private int _maxBots;

		// Token: 0x040070CD RID: 28877
		private HashSet<string> _deletedPlayers;

		// Token: 0x040070CE RID: 28878
		private HashSet<string> _addedPlayers;

		// Token: 0x040070CF RID: 28879
		private readonly HashSet<WildSpawnType> _blockedRoles;

		// Token: 0x040070D0 RID: 28880
		private CancellationTokenSource _cancellationTokenSource;

		// Token: 0x020012E5 RID: 4837
		[CompilerGenerated]
		[Serializable]
		private sealed class Class929
		{
			// Token: 0x06006482 RID: 25730 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Player x)
			{
				throw null;
			}

			// Token: 0x040070D1 RID: 28881
			public static readonly BotSpawner.Class929 class929_0;

			// Token: 0x040070D2 RID: 28882
			public static Func<Player, bool> func_0;
		}

		// Token: 0x020012E6 RID: 4838
		[CompilerGenerated]
		private sealed class Class930
		{
			// Token: 0x06006483 RID: 25731 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BotZone x)
			{
				throw null;
			}

			// Token: 0x040070D3 RID: 28883
			public bool canBeSnipe;
		}

		// Token: 0x020012E7 RID: 4839
		[CompilerGenerated]
		private sealed class Class931
		{
			// Token: 0x06006484 RID: 25732 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BotOwner x)
			{
				throw null;
			}

			// Token: 0x06006485 RID: 25733 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Player x)
			{
				throw null;
			}

			// Token: 0x040070D4 RID: 28884
			public string profileId;
		}

		// Token: 0x020012EC RID: 4844
		[CompilerGenerated]
		private sealed class Class932
		{
			// Token: 0x0600648E RID: 25742 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BotZone zone)
			{
				throw null;
			}

			// Token: 0x040070F0 RID: 28912
			public BotWaveDataClass wave;
		}

		// Token: 0x020012F1 RID: 4849
		[CompilerGenerated]
		private sealed class Class933
		{
			// Token: 0x06006497 RID: 25751 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(BotOwner bot)
			{
				throw null;
			}

			// Token: 0x0400710D RID: 28941
			public BotSpawner botSpawner_0;

			// Token: 0x0400710E RID: 28942
			public GClass588 data;

			// Token: 0x0400710F RID: 28943
			public Action<BotOwner> callback;

			// Token: 0x04007110 RID: 28944
			public bool shallBeGroup;

			// Token: 0x04007111 RID: 28945
			public Stopwatch stopWatch;
		}

		// Token: 0x020012F2 RID: 4850
		[CompilerGenerated]
		private sealed class Class934
		{
			// Token: 0x06006498 RID: 25752 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BotZone x)
			{
				throw null;
			}

			// Token: 0x04007112 RID: 28946
			public string name;
		}

		// Token: 0x020012F3 RID: 4851
		[CompilerGenerated]
		private sealed class Class935
		{
			// Token: 0x06006499 RID: 25753 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BotZone x)
			{
				throw null;
			}

			// Token: 0x04007113 RID: 28947
			public bool canBeSnipe;
		}
	}
}
