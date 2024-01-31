using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.HealthSystem;
using EFT.UI;
using JsonType;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001862 RID: 6242
	internal sealed class HideoutGame : BaseLocalGame<HideoutPlayerOwner>
	{
		// Token: 0x060085BF RID: 34239 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HideoutGame smethod_6(GInterface155 inputTree, Profile profile, GClass2760 originalInventory, GameDateTime backendDateTime, InsuranceCompanyClass insurance, MenuUI menuUI, CommonUI commonUI, PreloaderUI preloaderUI, GameUI gameUI, LocationSettingsClass.Location location, TimeAndWeatherSettings timeAndWeather, WavesSettings wavesSettings, EDateTime dateTime, Callback<ExitStatus, TimeSpan, MetricsClass> callback, float fixedDeltaTime, EUpdateQueue updateQueue, ISession backEndSession, IHealthController healthController)
		{
			throw null;
		}

		// Token: 0x060085C0 RID: 34240 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task<LocalPlayer> vmethod_2(int playerId, Vector3 position, Quaternion rotation, string layerName, string prefix, EPointOfView pointOfView, Profile profile, bool aiControl, EUpdateQueue updateQueue, Player.EUpdateMode armsUpdateMode, Player.EUpdateMode bodyUpdateMode, CharacterControllerSpawner.Mode characterControllerMode, Func<float> getSensitivity, Func<float> getAimingSensitivity, IStatisticsManager statisticsManager, AbstractQuestControllerClass questController = null, AbstractAchievementControllerClass achievementsController = null)
		{
			throw null;
		}

		// Token: 0x060085C1 RID: 34241 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void vmethod_1(float timeBeforeDeploy)
		{
			throw null;
		}

		// Token: 0x060085C2 RID: 34242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void vmethod_5()
		{
			throw null;
		}

		// Token: 0x060085C3 RID: 34243 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void vmethod_3()
		{
			throw null;
		}

		// Token: 0x060085C4 RID: 34244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x04008CA7 RID: 36007
		private GClass2760 gclass2760_0;

		// Token: 0x04008CA8 RID: 36008
		private IHealthController ihealthController_0;

		// Token: 0x02001863 RID: 6243
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1367
		{
			// Token: 0x060085C5 RID: 34245 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0()
			{
				throw null;
			}

			// Token: 0x060085C6 RID: 34246 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_1()
			{
				throw null;
			}

			// Token: 0x04008CA9 RID: 36009
			public static readonly HideoutGame.Class1367 class1367_0;

			// Token: 0x04008CAA RID: 36010
			public static Func<float> func_0;

			// Token: 0x04008CAB RID: 36011
			public static Func<float> func_1;
		}
	}
}
