using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Game.Spawning;
using JsonType;
using UnityEngine;

// Token: 0x02000FE8 RID: 4072
public class LocationSettingsClass
{
	// Token: 0x04006128 RID: 24872
	private const float float_0 = 1000f;

	// Token: 0x04006129 RID: 24873
	public Dictionary<string, LocationSettingsClass.Location> locations;

	// Token: 0x0400612A RID: 24874
	public LocationSettingsClass.GClass1220[] paths;

	// Token: 0x02000FE9 RID: 4073
	public class GClass1214
	{
		// Token: 0x0400612B RID: 24875
		public string BackendUrl;

		// Token: 0x0400612C RID: 24876
		public GClass748 Location;

		// Token: 0x0400612D RID: 24877
		public uint crc;
	}

	// Token: 0x02000FEA RID: 4074
	public class Location
	{
		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06005559 RID: 21849 RVA: 0x00002050 File Offset: 0x00000250
		public static IEnumerable<string> NightTimeAllowedLocations
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600555A RID: 21850 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 RelativeMapPos
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x0600555B RID: 21851 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsHideout
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400612E RID: 24878
		public const string FACTORY_DAY_ID = "factory4_day";

		// Token: 0x0400612F RID: 24879
		public const string FACTORY_NIGHT_ID = "factory4_night";

		// Token: 0x04006130 RID: 24880
		public const string LABORATORY_ID = "laboratory";

		// Token: 0x04006131 RID: 24881
		private const string HIDEOUT_ID = "hideout";

		// Token: 0x04006132 RID: 24882
		public static readonly string[] AvailableMaps;

		// Token: 0x04006133 RID: 24883
		public bool IsSecret;

		// Token: 0x04006134 RID: 24884
		public float IconX;

		// Token: 0x04006135 RID: 24885
		public float IconY;

		// Token: 0x04006136 RID: 24886
		public string _Id;

		// Token: 0x04006137 RID: 24887
		public string Id;

		// Token: 0x04006138 RID: 24888
		public bool Enabled;

		// Token: 0x04006139 RID: 24889
		public bool EnableCoop;

		// Token: 0x0400613A RID: 24890
		public bool Locked;

		// Token: 0x0400613B RID: 24891
		public string Name;

		// Token: 0x0400613C RID: 24892
		public ResourceKey Scene;

		// Token: 0x0400613D RID: 24893
		public string Description;

		// Token: 0x0400613E RID: 24894
		public float Area;

		// Token: 0x0400613F RID: 24895
		public int RequiredPlayerLevelMin;

		// Token: 0x04006140 RID: 24896
		public int RequiredPlayerLevelMax;

		// Token: 0x04006141 RID: 24897
		public int matching_min_seconds;

		// Token: 0x04006142 RID: 24898
		public int users_gather_seconds;

		// Token: 0x04006143 RID: 24899
		public int users_spawn_seconds_n;

		// Token: 0x04006144 RID: 24900
		public int users_spawn_seconds_n2;

		// Token: 0x04006145 RID: 24901
		public int users_summon_seconds;

		// Token: 0x04006146 RID: 24902
		public int sav_summon_seconds;

		// Token: 0x04006147 RID: 24903
		public int session_duration_minutes;

		// Token: 0x04006148 RID: 24904
		public int exit_count;

		// Token: 0x04006149 RID: 24905
		public int exit_access_time;

		// Token: 0x0400614A RID: 24906
		public int exit_time;

		// Token: 0x0400614B RID: 24907
		public int EscapeTimeLimit;

		// Token: 0x0400614C RID: 24908
		public int EscapeTimeLimitCoop;

		// Token: 0x0400614D RID: 24909
		public int MinDistToExitPoint;

		// Token: 0x0400614E RID: 24910
		public int MaxBotPerZone;

		// Token: 0x0400614F RID: 24911
		public int MaxDistToFreePoint;

		// Token: 0x04006150 RID: 24912
		public int MinDistToFreePoint;

		// Token: 0x04006151 RID: 24913
		public int SpawnSafeDistanceMeters;

		// Token: 0x04006152 RID: 24914
		public ResourceKey Preview;

		// Token: 0x04006153 RID: 24915
		public string[] filter_ex;

		// Token: 0x04006154 RID: 24916
		public WildSpawnWave[] waves;

		// Token: 0x04006155 RID: 24917
		public MinMaxBots[] MinMaxBots;

		// Token: 0x04006156 RID: 24918
		public BotLocationModifier BotLocationModifier;

		// Token: 0x04006157 RID: 24919
		public NonWaveGroupScenarioData NonWaveGroupScenario;

		// Token: 0x04006158 RID: 24920
		public BossLocationSpawn[] BossLocationSpawn;

		// Token: 0x04006159 RID: 24921
		public LocationSettingsClass.Location.GClass1215[] limits;

		// Token: 0x0400615A RID: 24922
		public Dictionary<string, LocationSettingsClass.Location.GClass1216> containers;

		// Token: 0x0400615B RID: 24923
		public LocationSettingsClass.Location.GClass1219[] Banners;

		// Token: 0x0400615C RID: 24924
		public LocationSettingsClass.Location.GClass1218[] airdropParameters;

		// Token: 0x0400615D RID: 24925
		public int PmcMaxPlayersInGroup;

		// Token: 0x0400615E RID: 24926
		public int ScavMaxPlayersInGroup;

		// Token: 0x0400615F RID: 24927
		public int MinGroupSize;

		// Token: 0x04006160 RID: 24928
		public int MinPlayers;

		// Token: 0x04006161 RID: 24929
		public int MaxPlayers;

		// Token: 0x04006162 RID: 24930
		public int PlayersRequestCount;

		// Token: 0x04006163 RID: 24931
		public int MaxCoopGroup;

		// Token: 0x04006164 RID: 24932
		public int AveragePlayerLevel;

		// Token: 0x04006165 RID: 24933
		public int AveragePlayTime;

		// Token: 0x04006166 RID: 24934
		public LocationSettingsClass.Location.LocationRules Rules;

		// Token: 0x04006167 RID: 24935
		public long UnixDateTime;

		// Token: 0x04006168 RID: 24936
		public SpawnPointParams[] SpawnPointParams;

		// Token: 0x04006169 RID: 24937
		public GClass1222[] exits;

		// Token: 0x0400616A RID: 24938
		public GClass1199 Loot;

		// Token: 0x0400616B RID: 24939
		public string OpenZones;

		// Token: 0x0400616C RID: 24940
		public bool OcculsionCullingEnabled;

		// Token: 0x0400616D RID: 24941
		public bool DisabledForScav;

		// Token: 0x0400616E RID: 24942
		public bool OldSpawn;

		// Token: 0x0400616F RID: 24943
		public bool OfflineOldSpawn;

		// Token: 0x04006170 RID: 24944
		public bool NewSpawn;

		// Token: 0x04006171 RID: 24945
		public bool OfflineNewSpawn;

		// Token: 0x04006172 RID: 24946
		public int BotMax;

		// Token: 0x04006173 RID: 24947
		public int BotMaxPlayer;

		// Token: 0x04006174 RID: 24948
		public int BotMaxTimePlayer;

		// Token: 0x04006175 RID: 24949
		public int BotStart;

		// Token: 0x04006176 RID: 24950
		public int BotStartPlayer;

		// Token: 0x04006177 RID: 24951
		public int BotStop;

		// Token: 0x04006178 RID: 24952
		public int BotSpawnPeriodCheck;

		// Token: 0x04006179 RID: 24953
		public int BotSpawnCountStep;

		// Token: 0x0400617A RID: 24954
		public int BotSpawnTimeOnMin;

		// Token: 0x0400617B RID: 24955
		public int BotSpawnTimeOnMax;

		// Token: 0x0400617C RID: 24956
		public int BotSpawnTimeOffMin;

		// Token: 0x0400617D RID: 24957
		public int BotSpawnTimeOffMax;

		// Token: 0x0400617E RID: 24958
		public int BotEasy;

		// Token: 0x0400617F RID: 24959
		public int BotNormal;

		// Token: 0x04006180 RID: 24960
		public int BotHard;

		// Token: 0x04006181 RID: 24961
		public int BotImpossible;

		// Token: 0x04006182 RID: 24962
		public int BotAssault;

		// Token: 0x04006183 RID: 24963
		public int BotMarksman;

		// Token: 0x04006184 RID: 24964
		public string DisabledScavExits;

		// Token: 0x04006185 RID: 24965
		public string[] AccessKeys;

		// Token: 0x04006186 RID: 24966
		public int MinPlayerLvlAccessKeys;

		// Token: 0x02000FEB RID: 4075
		public class GClass1215
		{
			// Token: 0x04006187 RID: 24967
			public object[] items;

			// Token: 0x04006188 RID: 24968
			public int min;

			// Token: 0x04006189 RID: 24969
			public int max;
		}

		// Token: 0x02000FEC RID: 4076
		public class GClass1216
		{
			// Token: 0x0400618A RID: 24970
			public bool enabled;

			// Token: 0x0400618B RID: 24971
			public bool @static;

			// Token: 0x0400618C RID: 24972
			public ELootRarity rarity;

			// Token: 0x0400618D RID: 24973
			public string[] filter;
		}

		// Token: 0x02000FED RID: 4077
		public class GClass1217
		{
			// Token: 0x0400618E RID: 24974
			public string name;

			// Token: 0x0400618F RID: 24975
			public string description;
		}

		// Token: 0x02000FEE RID: 4078
		public class GClass1218
		{
			// Token: 0x04006190 RID: 24976
			public int PlaneAirdropStartMin;

			// Token: 0x04006191 RID: 24977
			public int PlaneAirdropStartMax;

			// Token: 0x04006192 RID: 24978
			public int PlaneAirdropEnd;

			// Token: 0x04006193 RID: 24979
			public float PlaneAirdropChance;

			// Token: 0x04006194 RID: 24980
			public int PlaneAirdropMax;

			// Token: 0x04006195 RID: 24981
			public int PlaneAirdropCooldownMin;

			// Token: 0x04006196 RID: 24982
			public int PlaneAirdropCooldownMax;

			// Token: 0x04006197 RID: 24983
			public int AirdropPointDeactivateDistance;

			// Token: 0x04006198 RID: 24984
			public int MinPlayersCountToSpawnAirdrop;

			// Token: 0x04006199 RID: 24985
			public int UnsuccessfulTryPenalty;
		}

		// Token: 0x02000FEF RID: 4079
		public class GClass1219
		{
			// Token: 0x0400619A RID: 24986
			public string id;

			// Token: 0x0400619B RID: 24987
			public ResourceKey pic;
		}

		// Token: 0x02000FF0 RID: 4080
		public enum LocationRules
		{
			// Token: 0x0400619D RID: 24989
			Normal,
			// Token: 0x0400619E RID: 24990
			AvoidOwnPmc,
			// Token: 0x0400619F RID: 24991
			AvoidAllPmc
		}

		// Token: 0x02000FF1 RID: 4081
		[CompilerGenerated]
		[Serializable]
		private sealed class Class791
		{
			// Token: 0x0600555C RID: 21852 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(string x)
			{
				throw null;
			}

			// Token: 0x040061A0 RID: 24992
			public static readonly LocationSettingsClass.Location.Class791 class791_0;

			// Token: 0x040061A1 RID: 24993
			public static Func<string, bool> func_0;
		}
	}

	// Token: 0x02000FF2 RID: 4082
	public class GClass1220
	{
		// Token: 0x040061A2 RID: 24994
		public string Source;

		// Token: 0x040061A3 RID: 24995
		public string Destination;
	}
}
