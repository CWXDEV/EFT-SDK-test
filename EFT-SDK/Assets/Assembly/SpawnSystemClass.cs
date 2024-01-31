using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Game.Spawning;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020026B1 RID: 9905
internal sealed class SpawnSystemClass : ISpawnSystem
{
	// Token: 0x17002304 RID: 8964
	// (get) Token: 0x0600C448 RID: 50248 RVA: 0x00002050 File Offset: 0x00000250
	LoggerClass ISpawnSystem.Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C449 RID: 50249 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	ISpawnPoint ISpawnSystem.SelectSpawnPoint(ESpawnCategory category, EPlayerSide side, string groupId, string teamId, IPlayer person, string infiltration)
	{
		throw null;
	}

	// Token: 0x0600C44A RID: 50250 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	ISpawnPoint ISpawnSystem.SelectPlayerSavageSpawn(ESpawnCategory category, string groupId, string teamId, IPlayer person, string zoneName)
	{
		throw null;
	}

	// Token: 0x0600C44B RID: 50251 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	ISpawnPoint[] ISpawnSystem.SelectAISpawnPoints(ESpawnCategory category, GClass588 profileData, BotZone zone, int maxCount, Vector3? closestBossPos, ActionIfNotEnoughPoints mode)
	{
		throw null;
	}

	// Token: 0x0600C44C RID: 50252 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<ISpawnPoint> method_0([NotNull] GClass588 profileData, [NotNull] BotZone zone, int maxCount, float time, Vector3? closestBossPos = null, ActionIfNotEnoughPoints mode = ActionIfNotEnoughPoints.ReturnNothing)
	{
		throw null;
	}

	// Token: 0x0600C44D RID: 50253 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ISpawnSystem.ValidateSpawnPosition(ref Vector3 position, BotZone zone, IPlayer person, GClass588 data)
	{
		throw null;
	}

	// Token: 0x0600C44E RID: 50254 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ISpawnSystem.CheckFarthestFromOtherPlayers(IPlayer player)
	{
		throw null;
	}

	// Token: 0x0600C44F RID: 50255 RVA: 0x00002050 File Offset: 0x00000250
	[NotNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(SpawnSystemClass.Class2220 filteredPoints, int maxCount, [NotNull] BotZone zone, [NotNull] IZones zones, [CanBeNull] Vector3? closestBossPos)
	{
		throw null;
	}

	// Token: 0x0600C450 RID: 50256 RVA: 0x00002050 File Offset: 0x00000250
	[NotNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1(SpawnSystemClass.Class2220 filteredPoints, [NotNull] BotZone zone, [NotNull] IZones zones, [CanBeNull] Vector3? closestBossPos)
	{
		throw null;
	}

	// Token: 0x0600C451 RID: 50257 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ISpawnPoint smethod_2([NotNull] IReadOnlyCollection<ISpawnPoint> zoneSpawnPoints, [NotNull] IReadOnlyCollection<ISpawnPoint> allSpawnPoints, [NotNull] IGetProfileData profileData, [NotNull] IReadOnlyCollection<IPlayer> groupPlayers, [NotNull] IReadOnlyCollection<IPlayer> noneGroupPlayers, [NotNull] IReadOnlyCollection<IPlayer> carePlayers, float distanceSqr, float time)
	{
		throw null;
	}

	// Token: 0x0600C452 RID: 50258 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0600C453 RID: 50259 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Validate()
	{
		throw null;
	}

	// Token: 0x0400C5FE RID: 50686
	private static SpawnSystemClass.Class353 class353_0;

	// Token: 0x0400C5FF RID: 50687
	private readonly GStruct379 gstruct379_0;

	// Token: 0x0400C600 RID: 50688
	private readonly Func<float> func_0;

	// Token: 0x0400C601 RID: 50689
	private readonly IPlayersCollection iplayersCollection_0;

	// Token: 0x0400C602 RID: 50690
	private IZones ginterface344_0;

	// Token: 0x0400C603 RID: 50691
	private ISpawnPoints ginterface345_0;

	// Token: 0x0400C604 RID: 50692
	private readonly SpawnSystemClass.Class2220 class2220_0;

	// Token: 0x020026B2 RID: 9906
	internal sealed class Class2219 : IPositionPoint, ISpawnPoint, ISpawnPointCollider
	{
		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x0600C454 RID: 50260 RVA: 0x00002050 File Offset: 0x00000250
		public string Id
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x0600C455 RID: 50261 RVA: 0x00002050 File Offset: 0x00000250
		public string Name
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x0600C456 RID: 50262 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Position
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x0600C457 RID: 50263 RVA: 0x00002050 File Offset: 0x00000250
		public Quaternion Rotation
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x0600C458 RID: 50264 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerSideMask Sides
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x0600C459 RID: 50265 RVA: 0x00002050 File Offset: 0x00000250
		public ESpawnCategoryMask Categories
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x0600C45A RID: 50266 RVA: 0x00002050 File Offset: 0x00000250
		public string Infiltration
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x0600C45B RID: 50267 RVA: 0x00002050 File Offset: 0x00000250
		public string BotZoneName
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x0600C45C RID: 50268 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsSnipeZone
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x0600C45D RID: 50269 RVA: 0x00002050 File Offset: 0x00000250
		public float DelayToCanSpawnSec
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x0600C45E RID: 50270 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C45F RID: 50271 RVA: 0x00002050 File Offset: 0x00000250
		public float NextBornTime
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

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x0600C460 RID: 50272 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C461 RID: 50273 RVA: 0x00002050 File Offset: 0x00000250
		public int CorePointId
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

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x0600C462 RID: 50274 RVA: 0x00002050 File Offset: 0x00000250
		public ISpawnPointCollider Collider
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C463 RID: 50275 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool ISpawnPointCollider.Contains(Vector3 point)
		{
			throw null;
		}

		// Token: 0x0600C464 RID: 50276 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string DebugInfo()
		{
			throw null;
		}

		// Token: 0x0600C465 RID: 50277 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0400C605 RID: 50693
		public static readonly SpawnSystemClass.Class2219 Instance;

		// Token: 0x0400C606 RID: 50694
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x0400C607 RID: 50695
		[CompilerGenerated]
		private readonly string string_1;

		// Token: 0x0400C608 RID: 50696
		[CompilerGenerated]
		private readonly Vector3 vector3_0;

		// Token: 0x0400C609 RID: 50697
		[CompilerGenerated]
		private readonly Quaternion quaternion_0;

		// Token: 0x0400C60A RID: 50698
		[CompilerGenerated]
		private readonly EPlayerSideMask eplayerSideMask_0;

		// Token: 0x0400C60B RID: 50699
		[CompilerGenerated]
		private readonly ESpawnCategoryMask espawnCategoryMask_0;

		// Token: 0x0400C60C RID: 50700
		[CompilerGenerated]
		private readonly string string_2;

		// Token: 0x0400C60D RID: 50701
		[CompilerGenerated]
		private readonly string string_3;

		// Token: 0x0400C60E RID: 50702
		[CompilerGenerated]
		private readonly bool bool_0;

		// Token: 0x0400C60F RID: 50703
		[CompilerGenerated]
		private readonly float float_0;

		// Token: 0x0400C610 RID: 50704
		[CompilerGenerated]
		private float float_1;

		// Token: 0x0400C611 RID: 50705
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400C612 RID: 50706
		[CompilerGenerated]
		private readonly ISpawnPointCollider ispawnPointCollider_0;
	}

	// Token: 0x020026B3 RID: 9907
	internal sealed class Class353 : LoggerClass
	{
		// Token: 0x0600C466 RID: 50278 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("DEBUG")]
		[Conditional("CONSOLE")]
		[Conditional("SERVER")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(IReadOnlyCollection<ISpawnPoint> spawnPoints, string sourceName = null)
		{
			throw null;
		}

		// Token: 0x0600C467 RID: 50279 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("DEBUG")]
		[Conditional("SERVER")]
		[Conditional("CONSOLE")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_4(IReadOnlyCollection<ISpawnPoint> spawnPoints, string sourceName = null, params ValueTuple<object, object>[] args)
		{
			throw null;
		}

		// Token: 0x0600C468 RID: 50280 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("CONSOLE")]
		[Conditional("DEBUG")]
		[Conditional("SERVER")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_5(IReadOnlyCollection<IPlayer> persons, string sourceName = null)
		{
			throw null;
		}

		// Token: 0x0600C469 RID: 50281 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("SERVER")]
		[Conditional("CONSOLE")]
		[Conditional("DEBUG")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_6(IReadOnlyCollection<IPlayer> persons, string sourceName = null, params ValueTuple<object, object>[] args)
		{
			throw null;
		}

		// Token: 0x0600C46A RID: 50282 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_7(string message = null)
		{
			throw null;
		}

		// Token: 0x0600C46B RID: 50283 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("DEBUG")]
		[Conditional("SERVER")]
		[Conditional("CONSOLE")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_8(ISpawnPoint spawnPoint, float currentTime, bool isPlayer = false)
		{
			throw null;
		}

		// Token: 0x0600C46C RID: 50284 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsTraceEnable()
		{
			throw null;
		}

		// Token: 0x0600C46D RID: 50285 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TraceSpawnTime(ISpawnPoint spawnPoint, float time, bool isValid)
		{
			throw null;
		}

		// Token: 0x0600C46E RID: 50286 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TraceSpawnSide(ISpawnPoint spawnPoint, EPlayerSide? profileDataSide, bool isValid)
		{
			throw null;
		}

		// Token: 0x0600C46F RID: 50287 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TraceSpawnIsNotCollided(ISpawnPoint spawnPoint, IPlayer[] exceptAIPlayers, bool isValid)
		{
			throw null;
		}

		// Token: 0x0400C613 RID: 50707
		private const string string_0 = "spawnsystem";

		// Token: 0x0400C614 RID: 50708
		private readonly SpawnSystemClass class2218_0;
	}

	// Token: 0x020026B4 RID: 9908
	private class Class2220
	{
		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x0600C470 RID: 50288 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C471 RID: 50289 RVA: 0x00002050 File Offset: 0x00000250
		public int ValidPointsCount
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

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x0600C472 RID: 50290 RVA: 0x00002050 File Offset: 0x00000250
		public IReadOnlyList<ISpawnPoint> AllPoints
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x0600C473 RID: 50291 RVA: 0x00002050 File Offset: 0x00000250
		public IReadOnlyList<ISpawnPoint> ValidPointsAlloc
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C474 RID: 50292 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Insert(ISpawnPoint point)
		{
			throw null;
		}

		// Token: 0x0600C475 RID: 50293 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InsertRange(IEnumerable<ISpawnPoint> points)
		{
			throw null;
		}

		// Token: 0x0600C476 RID: 50294 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyFilter(Func<ISpawnPoint, bool> predicate)
		{
			throw null;
		}

		// Token: 0x0600C477 RID: 50295 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplySorting<TKey>(Func<ISpawnPoint, TKey> comparer)
		{
			throw null;
		}

		// Token: 0x0600C478 RID: 50296 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplySortingToNonValid<TKey>(Func<ISpawnPoint, TKey> comparer)
		{
			throw null;
		}

		// Token: 0x0600C479 RID: 50297 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClampPointsCountToMaximum(int maxCount)
		{
			throw null;
		}

		// Token: 0x0600C47A RID: 50298 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetAllToValid()
		{
			throw null;
		}

		// Token: 0x0600C47B RID: 50299 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MultiplicatePointOnIndex(int index, int times)
		{
			throw null;
		}

		// Token: 0x0600C47C RID: 50300 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0400C615 RID: 50709
		private readonly List<ISpawnPoint> list_0;

		// Token: 0x0400C616 RID: 50710
		private readonly List<ISpawnPoint> list_1;

		// Token: 0x0400C617 RID: 50711
		[CompilerGenerated]
		private int int_0;
	}

	// Token: 0x020026B5 RID: 9909
	[CompilerGenerated]
	private sealed class Class2221
	{
		// Token: 0x0600C47D RID: 50301 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ISpawnPoint method_0(IReadOnlyList<ISpawnPoint> list)
		{
			throw null;
		}

		// Token: 0x0600C47E RID: 50302 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(ISpawnPoint spawnPoint)
		{
			throw null;
		}

		// Token: 0x0600C47F RID: 50303 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(ISpawnPoint spawnPoint)
		{
			throw null;
		}

		// Token: 0x0600C480 RID: 50304 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(ISpawnPoint spawnPoint)
		{
			throw null;
		}

		// Token: 0x0400C618 RID: 50712
		public IPlayer[] noneGroupPlayers;

		// Token: 0x0400C619 RID: 50713
		public ESpawnCategory category;

		// Token: 0x0400C61A RID: 50714
		public EPlayerSide side;

		// Token: 0x0400C61B RID: 50715
		public string infiltration;
	}

	// Token: 0x020026B6 RID: 9910
	[CompilerGenerated]
	private sealed class Class2222
	{
		// Token: 0x0600C481 RID: 50305 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ISpawnPoint method_0(ISpawnPoint spawnPoint)
		{
			throw null;
		}

		// Token: 0x0400C61C RID: 50716
		public float currentTime;
	}

	// Token: 0x020026B7 RID: 9911
	[CompilerGenerated]
	private sealed class Class2223
	{
		// Token: 0x0600C482 RID: 50306 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ISpawnPoint sp)
		{
			throw null;
		}

		// Token: 0x0600C483 RID: 50307 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(ISpawnPoint sp)
		{
			throw null;
		}

		// Token: 0x0600C484 RID: 50308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(ISpawnPoint sp)
		{
			throw null;
		}

		// Token: 0x0600C485 RID: 50309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(ISpawnPoint sp)
		{
			throw null;
		}

		// Token: 0x0600C486 RID: 50310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_4(ISpawnPoint spawnPoint)
		{
			throw null;
		}

		// Token: 0x0600C487 RID: 50311 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_5(ISpawnPoint sp)
		{
			throw null;
		}

		// Token: 0x0400C61D RID: 50717
		public float time;

		// Token: 0x0400C61E RID: 50718
		public GClass588 profileData;

		// Token: 0x0400C61F RID: 50719
		public IPlayer[] exceptAIPlayers;

		// Token: 0x0400C620 RID: 50720
		public GClass603 debugCollector;

		// Token: 0x0400C621 RID: 50721
		public IPlayer[] allPlayers;
	}

	// Token: 0x020026B8 RID: 9912
	[CompilerGenerated]
	private sealed class Class2224
	{
		// Token: 0x0600C488 RID: 50312 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(ISpawnPoint sp)
		{
			throw null;
		}

		// Token: 0x0400C622 RID: 50722
		public Vector3? position;
	}

	// Token: 0x020026B9 RID: 9913
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2225
	{
		// Token: 0x0600C489 RID: 50313 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ISpawnPoint spawnPoint)
		{
			throw null;
		}

		// Token: 0x0400C623 RID: 50723
		public static readonly SpawnSystemClass.Class2225 class2225_0;

		// Token: 0x0400C624 RID: 50724
		public static Func<ISpawnPoint, bool> func_0;
	}

	// Token: 0x020026BA RID: 9914
	[CompilerGenerated]
	private sealed class Class2226
	{
		// Token: 0x0600C48A RID: 50314 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ISpawnPoint sp)
		{
			throw null;
		}

		// Token: 0x0600C48B RID: 50315 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(ISpawnPoint sp)
		{
			throw null;
		}

		// Token: 0x0400C625 RID: 50725
		public GClass603 debugLoggerCollector;

		// Token: 0x0400C626 RID: 50726
		public float time;

		// Token: 0x0400C627 RID: 50727
		public IGetProfileData profileData;

		// Token: 0x0400C628 RID: 50728
		public IReadOnlyCollection<IPlayer> carePlayers;

		// Token: 0x0400C629 RID: 50729
		public float distanceSqr;
	}

	// Token: 0x020026BB RID: 9915
	[CompilerGenerated]
	private sealed class Class2227
	{
		// Token: 0x0600C48C RID: 50316 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(ISpawnPoint sp)
		{
			throw null;
		}

		// Token: 0x0400C62A RID: 50730
		public Vector3 playersCenter;
	}
}
