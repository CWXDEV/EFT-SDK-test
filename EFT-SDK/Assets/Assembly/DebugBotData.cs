using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020001F3 RID: 499
public class DebugBotData : ScriptableObject
{
	// Token: 0x0600090D RID: 2317 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DebugBotData Load()
	{
		throw null;
	}

	// Token: 0x1700025A RID: 602
	// (get) Token: 0x0600090E RID: 2318 RVA: 0x00002050 File Offset: 0x00000250
	public float BadShootOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700025B RID: 603
	// (get) Token: 0x0600090F RID: 2319 RVA: 0x00002050 File Offset: 0x00000250
	public static DebugBotData Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700025C RID: 604
	// (get) Token: 0x06000910 RID: 2320 RVA: 0x00002050 File Offset: 0x00000250
	public static bool UseDebugData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartUseAutoRespawn(BotSpawner botSpawner, BotsClass bots, BotZoneGroupsDictionary groups)
	{
		throw null;
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitMessage()
	{
		throw null;
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BotZone[] botZones = null)
	{
		throw null;
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(string path = "DebugBotData.txt")
	{
		throw null;
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugActivateAllBots(bool val = true)
	{
		throw null;
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(GClass339 result)
	{
		throw null;
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<WildSpawnWave> method_0(List<DebugBotData.Class111> zonesSpace, List<WildSpawnWave> wavesToCheck)
	{
		throw null;
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0400099C RID: 2460
	private const string string_0 = "DebugBotData.txt";

	// Token: 0x0400099D RID: 2461
	private const float float_0 = 1f;

	// Token: 0x0400099E RID: 2462
	private static DebugBotData debugBotData_0;

	// Token: 0x0400099F RID: 2463
	private static bool bool_0;

	// Token: 0x040009A0 RID: 2464
	[SerializeField]
	public List<WildSpawnWave> StartWaves;

	// Token: 0x040009A1 RID: 2465
	[SerializeField]
	public List<BossLocationSpawn> BossStartWaves;

	// Token: 0x040009A2 RID: 2466
	public GizmosConfig Gizmos;

	// Token: 0x040009A3 RID: 2467
	public bool autoRespawn;

	// Token: 0x040009A4 RID: 2468
	public bool evenlyDistribute;

	// Token: 0x040009A5 RID: 2469
	public bool spawnInstantly;

	// Token: 0x040009A6 RID: 2470
	public bool localProfiles;

	// Token: 0x040009A7 RID: 2471
	public bool AnySideBornUse;

	// Token: 0x040009A8 RID: 2472
	public bool DebugBrain;

	// Token: 0x040009A9 RID: 2473
	public DebugBotDesition DebugBotDesition;

	// Token: 0x040009AA RID: 2474
	public DebugBotTactic DebugBotTactic;

	// Token: 0x040009AB RID: 2475
	public bool BadShooting;

	// Token: 0x040009AC RID: 2476
	public bool UseDebugWawes;

	// Token: 0x040009AD RID: 2477
	public int respawnCount;

	// Token: 0x040009AE RID: 2478
	public int MaxBotsCount;

	// Token: 0x040009AF RID: 2479
	public int SummonSavages;

	// Token: 0x040009B0 RID: 2480
	public bool BadVision;

	// Token: 0x040009B1 RID: 2481
	public bool BadHearing;

	// Token: 0x040009B2 RID: 2482
	public bool NoShoot;

	// Token: 0x040009B3 RID: 2483
	public bool BadShootingAsCount;

	// Token: 0x040009B4 RID: 2484
	public bool MaxAgression;

	// Token: 0x040009B5 RID: 2485
	public bool NoMinMax;

	// Token: 0x040009B6 RID: 2486
	public bool DebugCoverLogs;

	// Token: 0x040009B7 RID: 2487
	public bool NoReciol;

	// Token: 0x040009B8 RID: 2488
	public bool FreeForAll;

	// Token: 0x040009B9 RID: 2489
	public bool FreeForAllOverride;

	// Token: 0x040009BA RID: 2490
	public bool DrawColorCanShoot;

	// Token: 0x040009BB RID: 2491
	public bool DrawColorLinesWeight;

	// Token: 0x040009BC RID: 2492
	public bool NoArmorToPower;

	// Token: 0x040009BD RID: 2493
	public bool GoodShooting;

	// Token: 0x040009BE RID: 2494
	public bool NoSleepMode;

	// Token: 0x040009BF RID: 2495
	public bool LoadSettingsFromCode;

	// Token: 0x040009C0 RID: 2496
	public bool DebugMalfunctions;

	// Token: 0x040009C1 RID: 2497
	public bool AlwaysSprint;

	// Token: 0x040009C2 RID: 2498
	public bool SprintOverride;

	// Token: 0x040009C3 RID: 2499
	public float SprintSpeed;

	// Token: 0x040009C4 RID: 2500
	public bool useThisData;

	// Token: 0x040009C5 RID: 2501
	[HideInInspector]
	public List<WildSpawnWave> waves;

	// Token: 0x040009C6 RID: 2502
	[HideInInspector]
	public List<BossLocationSpawn> bossWaves;

	// Token: 0x040009C7 RID: 2503
	public bool NoZoneBlocks;

	// Token: 0x040009C8 RID: 2504
	public bool NoRoleBlocks;

	// Token: 0x040009C9 RID: 2505
	public bool NoGrenadeOffset;

	// Token: 0x040009CA RID: 2506
	public bool NoGrenadeThrow;

	// Token: 0x040009CB RID: 2507
	public bool TrueAim;

	// Token: 0x040009CC RID: 2508
	public DebugLook DebugRaysSystem;

	// Token: 0x040009CD RID: 2509
	public bool NoStopServer;

	// Token: 0x040009CE RID: 2510
	public bool AlwaysLayWhenDanger;

	// Token: 0x040009CF RID: 2511
	public bool IgnoreBotLimits;

	// Token: 0x040009D0 RID: 2512
	public bool ActivatedStatus;

	// Token: 0x040009D1 RID: 2513
	public bool PhraseRequestAlwaysGood;

	// Token: 0x040009D2 RID: 2514
	private BotSpawner botSpawner_0;

	// Token: 0x040009D3 RID: 2515
	private BotZoneGroupsDictionary botZoneGroupsDictionary_0;

	// Token: 0x040009D4 RID: 2516
	private float float_1;

	// Token: 0x040009D5 RID: 2517
	public bool StartWithNoPlayers;

	// Token: 0x020001F4 RID: 500
	private class Class111
	{
		// Token: 0x040009D6 RID: 2518
		public BotZone Zone;

		// Token: 0x040009D7 RID: 2519
		public int PosibleSlots;
	}

	// Token: 0x020001F5 RID: 501
	[CompilerGenerated]
	private sealed class Class112
	{
		// Token: 0x06000919 RID: 2329 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(DebugBotData.Class111 x)
		{
			throw null;
		}

		// Token: 0x040009D8 RID: 2520
		public BotZone botZone;
	}

	// Token: 0x020001F6 RID: 502
	[CompilerGenerated]
	[Serializable]
	private sealed class Class113
	{
		// Token: 0x0600091A RID: 2330 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(DebugBotData.Class111 x)
		{
			throw null;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_1(WildSpawnWave x)
		{
			throw null;
		}

		// Token: 0x040009D9 RID: 2521
		public static readonly DebugBotData.Class113 class113_0;

		// Token: 0x040009DA RID: 2522
		public static Func<DebugBotData.Class111, int> func_0;

		// Token: 0x040009DB RID: 2523
		public static Func<WildSpawnWave, int> func_1;
	}
}
