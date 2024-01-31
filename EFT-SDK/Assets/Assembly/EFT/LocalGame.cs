using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.Bots;
using EFT.UI;
using EFT.Weather;
using JetBrains.Annotations;
using JsonType;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001866 RID: 6246
	internal sealed class LocalGame : BaseLocalGame<GamePlayerOwner>, IBotGame
	{
		// Token: 0x060085C9 RID: 34249 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LocalGame smethod_6(GInterface155 inputTree, Profile profile, GameDateTime backendDateTime, InsuranceCompanyClass insurance, MenuUI menuUI, CommonUI commonUI, PreloaderUI preloaderUI, GameUI gameUI, LocationSettingsClass.Location location, TimeAndWeatherSettings timeAndWeather, WavesSettings wavesSettings, EDateTime dateTime, Callback<ExitStatus, TimeSpan, MetricsClass> callback, float fixedDeltaTime, EUpdateQueue updateQueue, ISession backEndSession, TimeSpan sessionTime)
		{
			throw null;
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x060085CA RID: 34250 RVA: 0x00002050 File Offset: 0x00000250
		BotsController IBotGame.BotsController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x060085CB RID: 34251 RVA: 0x00002050 File Offset: 0x00000250
		public IWeatherCurve WeatherCurve
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060085CC RID: 34252 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerator vmethod_4(float startDelay, BotControllerSettings controllerSettings, ISpawnSystem spawnSystem, Callback runCallback)
		{
			throw null;
		}

		// Token: 0x060085CD RID: 34253 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static WildSpawnWave[] smethod_7(WavesSettings wavesSettings, WildSpawnWave[] waves)
		{
			throw null;
		}

		// Token: 0x060085CE RID: 34254 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static BossLocationSpawn[] smethod_8(WavesSettings wavesSettings, BossLocationSpawn[] bossLocationSpawn)
		{
			throw null;
		}

		// Token: 0x060085CF RID: 34255 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<LocalPlayer> method_17(Profile profile, Vector3 position)
		{
			throw null;
		}

		// Token: 0x060085D0 RID: 34256 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void vmethod_0()
		{
			throw null;
		}

		// Token: 0x060085D1 RID: 34257 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Stop(string profileId, ExitStatus exitStatus, string exitName, float delay = 0f)
		{
			throw null;
		}

		// Token: 0x060085D2 RID: 34258 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void CleanUp()
		{
			throw null;
		}

		// Token: 0x060085D3 RID: 34259 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_18(float startDelay, BotControllerSettings controllerSettings, ISpawnSystem spawnSystem, Callback runCallback)
		{
			throw null;
		}

		// Token: 0x04008CBA RID: 36026
		private GClass576 gclass576_0;

		// Token: 0x04008CBB RID: 36027
		private WavesSpawnScenario wavesSpawnScenario_0;

		// Token: 0x04008CBC RID: 36028
		private NonWavesSpawnScenario nonWavesSpawnScenario_0;

		// Token: 0x04008CBD RID: 36029
		private readonly Dictionary<string, Player> dictionary_2;

		// Token: 0x02001867 RID: 6247
		[CompilerGenerated]
		private sealed class Class1368
		{
			// Token: 0x060085D4 RID: 34260 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(BotWaveDataClass wave)
			{
				throw null;
			}

			// Token: 0x060085D5 RID: 34261 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(BossLocationSpawn bossWave)
			{
				throw null;
			}

			// Token: 0x04008CBE RID: 36030
			public LocalGame game;
		}

		// Token: 0x02001869 RID: 6249
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1370
		{
			// Token: 0x060085DA RID: 34266 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(int x)
			{
				throw null;
			}

			// Token: 0x060085DB RID: 34267 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_1(int x)
			{
				throw null;
			}

			// Token: 0x060085DC RID: 34268 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_2(int x)
			{
				throw null;
			}

			// Token: 0x060085DD RID: 34269 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_3(int x)
			{
				throw null;
			}

			// Token: 0x060085DE RID: 34270 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_4()
			{
				throw null;
			}

			// Token: 0x060085DF RID: 34271 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_5()
			{
				throw null;
			}

			// Token: 0x04008CC6 RID: 36038
			public static readonly LocalGame.Class1370 class1370_0;

			// Token: 0x04008CC7 RID: 36039
			public static Func<int, int> func_0;

			// Token: 0x04008CC8 RID: 36040
			public static Func<int, int> func_1;

			// Token: 0x04008CC9 RID: 36041
			public static Func<int, int> func_2;

			// Token: 0x04008CCA RID: 36042
			public static Func<int, int> func_3;

			// Token: 0x04008CCB RID: 36043
			public static Func<float> func_4;

			// Token: 0x04008CCC RID: 36044
			public static Func<float> func_5;
		}
	}
}
