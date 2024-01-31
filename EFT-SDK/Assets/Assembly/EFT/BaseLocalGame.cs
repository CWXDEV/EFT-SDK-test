using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Comfort.Common;
using CommonAssets.Scripts.Game;
using EFT.Bots;
using EFT.Interactive;
using EFT.InventoryLogic;
using EFT.UI;
using JsonType;
using UnityEngine;
using UnityEngine.LowLevel;

namespace EFT
{
	// Token: 0x02001851 RID: 6225
	internal class BaseLocalGame<TPlayerOwner> : AbstractGame, EndByExitTrigerScenario.GInterface87, GInterface100, EndByTimerScenario.Interface4 where TPlayerOwner : GamePlayerOwner
	{
		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06008554 RID: 34132 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008555 RID: 34133 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x06008556 RID: 34134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static T smethod_0<T>(GInterface155 inputTree, Profile profile, GameDateTime backendDateTime, InsuranceCompanyClass insurance, MenuUI menuUI, CommonUI commonUI, PreloaderUI preloaderUI, GameUI gameUI, LocationSettingsClass.Location location, TimeAndWeatherSettings timeAndWeather, WavesSettings wavesSettings, EDateTime dateTime, Callback<ExitStatus, TimeSpan, MetricsClass> callback, float fixedDeltaTime, EUpdateQueue updateQueue, ISession backEndSession, TimeSpan? sessionTime) where T : BaseLocalGame<TPlayerOwner>
		{
			throw null;
		}

		// Token: 0x06008557 RID: 34135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1<T>(LocationSettingsClass.Location location, WavesSettings wavesSettings) where T : BaseLocalGame<TPlayerOwner>
		{
			throw null;
		}

		// Token: 0x06008558 RID: 34136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06008559 RID: 34137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void vmethod_0()
		{
			throw null;
		}

		// Token: 0x0600855A RID: 34138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(TimeAndWeatherSettings timeAndWeather)
		{
			throw null;
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x0600855B RID: 34139 RVA: 0x00002050 File Offset: 0x00000250
		public TPlayerOwner PlayerOwner
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x0600855C RID: 34140 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600855D RID: 34141 RVA: 0x00002050 File Offset: 0x00000250
		private MenuUI MenuUI_0
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

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x0600855E RID: 34142 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600855F RID: 34143 RVA: 0x00002050 File Offset: 0x00000250
		private Profile Profile_0
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

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06008560 RID: 34144 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008561 RID: 34145 RVA: 0x00002050 File Offset: 0x00000250
		private LocationSettingsClass.Location Location_0
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

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06008562 RID: 34146 RVA: 0x00002050 File Offset: 0x00000250
		public override string LocationObjectId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06008563 RID: 34147 RVA: 0x00002050 File Offset: 0x00000250
		protected override GameUI GameUi
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06008564 RID: 34148 RVA: 0x00002050 File Offset: 0x00000250
		protected override string ProfileId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008565 RID: 34149 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_4(BotControllerSettings botsSettings, string backendUrl, InventoryControllerClass inventoryController, Callback runCallback)
		{
			throw null;
		}

		// Token: 0x06008566 RID: 34150 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(BotControllerSettings botsSettings, ISpawnSystem spawnSystem, Callback runCallback)
		{
			throw null;
		}

		// Token: 0x06008567 RID: 34151 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void vmethod_1(float timeBeforeDeploy)
		{
			throw null;
		}

		// Token: 0x06008568 RID: 34152 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task<LocalPlayer> vmethod_2(int playerId, Vector3 position, Quaternion rotation, string layerName, string prefix, EPointOfView pointOfView, Profile profile, bool aiControl, EUpdateQueue updateQueue, Player.EUpdateMode armsUpdateMode, Player.EUpdateMode bodyUpdateMode, CharacterControllerSpawner.Mode characterControllerMode, Func<float> getSensitivity, Func<float> getAimingSensitivity, IStatisticsManager statisticsManager, AbstractQuestControllerClass questController, AbstractAchievementControllerClass achievementsController)
		{
			throw null;
		}

		// Token: 0x06008569 RID: 34153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(string backendUrl, string locationId, int variantId)
		{
			throw null;
		}

		// Token: 0x0600856A RID: 34154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<LocationSettingsClass.Location> method_7(string backendUrl)
		{
			throw null;
		}

		// Token: 0x0600856B RID: 34155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(ExfiltrationPoint point, EExfiltrationStatus prevStatus)
		{
			throw null;
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void vmethod_3()
		{
			throw null;
		}

		// Token: 0x0600856D RID: 34157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual IEnumerator vmethod_4(float startDelay, BotControllerSettings controllerSettings, ISpawnSystem spawnSystem, Callback runCallback)
		{
			throw null;
		}

		// Token: 0x1400018B RID: 395
		// (add) Token: 0x0600856E RID: 34158 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600856F RID: 34159 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06008570 RID: 34160 RVA: 0x00002050 File Offset: 0x00000250
		public List<Player> AllPlayers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void vmethod_5()
		{
			throw null;
		}

		// Token: 0x06008572 RID: 34162 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void method_9()
		{
			throw null;
		}

		// Token: 0x06008573 RID: 34163 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x06008574 RID: 34164 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_2<T>(ref PlayerLoopSystem system, PlayerLoopSystem replacement)
		{
			throw null;
		}

		// Token: 0x06008575 RID: 34165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_3()
		{
			throw null;
		}

		// Token: 0x06008576 RID: 34166 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_11(LocationSettingsClass.Location location, Action callback)
		{
			throw null;
		}

		// Token: 0x06008577 RID: 34167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void EndByTimerScenario.Interface4.StopGame()
		{
			throw null;
		}

		// Token: 0x06008578 RID: 34168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ItemPlaced(DroppedItem droppedItem, string profileId)
		{
			throw null;
		}

		// Token: 0x06008579 RID: 34169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BotUnspawn(BotOwner botOwner)
		{
			throw null;
		}

		// Token: 0x0600857A RID: 34170 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ItemRemoved(DroppedItem droppedItem)
		{
			throw null;
		}

		// Token: 0x0600857B RID: 34171 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void EndByExitTrigerScenario.GInterface87.StopSession(string profileId, ExitStatus exitStatus, string exitName)
		{
			throw null;
		}

		// Token: 0x0600857C RID: 34172 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Stop(string profileId, ExitStatus exitStatus, string exitName, float delay = 0f)
		{
			throw null;
		}

		// Token: 0x0600857D RID: 34173 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void CleanUp()
		{
			throw null;
		}

		// Token: 0x0600857E RID: 34174 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void smethod_4(IDictionary<string, Player> players)
		{
			throw null;
		}

		// Token: 0x0600857F RID: 34175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected int method_12()
		{
			throw null;
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06008580 RID: 34176 RVA: 0x00002050 File Offset: 0x00000250
		GameObject GInterface100.gameObject
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008581 RID: 34177 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Task<LocationSettingsClass.Location> smethod_5(GClass748 unparsedData)
		{
			throw null;
		}

		// Token: 0x06008582 RID: 34178 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_13(Player x)
		{
			throw null;
		}

		// Token: 0x06008583 RID: 34179 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x06008584 RID: 34180 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(EDamageType controller)
		{
			throw null;
		}

		// Token: 0x06008585 RID: 34181 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(GStruct117 p)
		{
			throw null;
		}

		// Token: 0x04008C2F RID: 35887
		private bool bool_2;

		// Token: 0x04008C30 RID: 35888
		[CompilerGenerated]
		private GameDateTime gameDateTime_0;

		// Token: 0x04008C31 RID: 35889
		protected DateTime dateTime_0;

		// Token: 0x04008C32 RID: 35890
		private GameDateTime gameDateTime_1;

		// Token: 0x04008C33 RID: 35891
		private GameUI gameUI_0;

		// Token: 0x04008C34 RID: 35892
		protected ISession ginterface145_0;

		// Token: 0x04008C35 RID: 35893
		private Callback<ExitStatus, TimeSpan, MetricsClass> callback_0;

		// Token: 0x04008C36 RID: 35894
		private EndByExitTrigerScenario endByExitTrigerScenario_0;

		// Token: 0x04008C37 RID: 35895
		private EndByTimerScenario endByTimerScenario_0;

		// Token: 0x04008C38 RID: 35896
		private Func<Task<Player>> func_0;

		// Token: 0x04008C39 RID: 35897
		private Func<Player, TPlayerOwner> func_1;

		// Token: 0x04008C3A RID: 35898
		protected TPlayerOwner gparam_0;

		// Token: 0x04008C3B RID: 35899
		private Action action_0;

		// Token: 0x04008C3C RID: 35900
		private DateTime dateTime_1;

		// Token: 0x04008C3D RID: 35901
		private EDateTime edateTime_0;

		// Token: 0x04008C3E RID: 35902
		private string string_0;

		// Token: 0x04008C3F RID: 35903
		protected readonly Dictionary<string, Player> dictionary_0;

		// Token: 0x04008C40 RID: 35904
		protected GClass624 gclass624_0;

		// Token: 0x04008C41 RID: 35905
		private int int_0;

		// Token: 0x04008C42 RID: 35906
		private readonly Dictionary<string, DateTime> dictionary_1;

		// Token: 0x04008C43 RID: 35907
		protected readonly BotsController botsController_0;

		// Token: 0x04008C44 RID: 35908
		[CompilerGenerated]
		private MenuUI menuUI_0;

		// Token: 0x04008C45 RID: 35909
		[CompilerGenerated]
		private Profile profile_0;

		// Token: 0x04008C46 RID: 35910
		[CompilerGenerated]
		private LocationSettingsClass.Location location_0;

		// Token: 0x04008C47 RID: 35911
		[CompilerGenerated]
		private Action action_1;

		// Token: 0x02001852 RID: 6226
		private class Class1360
		{
		}

		// Token: 0x02001853 RID: 6227
		[CompilerGenerated]
		private sealed class Class1361<U> where U : BaseLocalGame<TPlayerOwner>
		{

			// Token: 0x04008C48 RID: 35912
			public GInterface155 inputTree;

			// Token: 0x04008C49 RID: 35913
			public InsuranceCompanyClass insurance;

			// Token: 0x04008C4A RID: 35914
			public ISession backEndSession;

			// Token: 0x04008C4B RID: 35915
			public CommonUI commonUI;

			// Token: 0x04008C4C RID: 35916
			public PreloaderUI preloaderUI;

			// Token: 0x04008C4D RID: 35917
			public GameUI gameUI;

			// Token: 0x04008C4E RID: 35918
			public U game;

			// Token: 0x04008C4F RID: 35919
			public LocationSettingsClass.Location location;
		}

		// Token: 0x02001854 RID: 6228
		[CompilerGenerated]
		private sealed class Class1362
		{
			// Token: 0x06008587 RID: 34183 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task<Player> method_0()
			{
				throw null;
			}

			// Token: 0x06008588 RID: 34184 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x04008C50 RID: 35920
			public ISpawnSystem spawnSystem;

			// Token: 0x04008C52 RID: 35922
			public InventoryControllerClass inventoryController;

			// Token: 0x04008C53 RID: 35923
			public BotControllerSettings botsSettings;

			// Token: 0x04008C54 RID: 35924
			public Callback runCallback;

			// Token: 0x02001855 RID: 6229
			[StructLayout(LayoutKind.Auto)]
			public struct Struct400 : IAsyncStateMachine
			{
				// Token: 0x06008589 RID: 34185 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x0600858A RID: 34186 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x04008C55 RID: 35925
				public int int_0;

				// Token: 0x04008C56 RID: 35926
				public AsyncTaskMethodBuilder<Player> asyncTaskMethodBuilder_0;

				// Token: 0x04008C58 RID: 35928
				private TaskAwaiter<LocalPlayer> taskAwaiter_0;
			}
		}

		// Token: 0x02001856 RID: 6230
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1363
		{
			// Token: 0x0600858B RID: 34187 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0()
			{
				throw null;
			}

			// Token: 0x0600858C RID: 34188 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_1()
			{
				throw null;
			}

			// Token: 0x0600858D RID: 34189 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_2()
			{
				throw null;
			}

			// Token: 0x0600858E RID: 34190 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_3()
			{
				throw null;
			}

			// Token: 0x0600858F RID: 34191 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_4()
			{
				throw null;
			}

			// Token: 0x06008590 RID: 34192 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_5(LootItemPositionClass x)
			{
				throw null;
			}

			// Token: 0x06008591 RID: 34193 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_6(LootItemPositionClass x)
			{
				throw null;
			}

			// Token: 0x06008592 RID: 34194 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_7(Item x)
			{
				throw null;
			}

			// Token: 0x06008593 RID: 34195 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<ResourceKey> method_8(Item x)
			{
				throw null;
			}

			// Token: 0x04008C59 RID: 35929
			public static readonly BaseLocalGame<TPlayerOwner>.Class1363 class1363_0;

			// Token: 0x04008C5A RID: 35930
			public static Func<float> func_0;

			// Token: 0x04008C5B RID: 35931
			public static Func<float> func_1;

			// Token: 0x04008C5C RID: 35932
			public static Func<float> func_2;

			// Token: 0x04008C5D RID: 35933
			public static Func<float> func_3;

			// Token: 0x04008C5E RID: 35934
			public static Func<float> func_4;

			// Token: 0x04008C5F RID: 35935
			public static Func<LootItemPositionClass, bool> func_5;

			// Token: 0x04008C60 RID: 35936
			public static Func<LootItemPositionClass, Item> func_6;

			// Token: 0x04008C61 RID: 35937
			public static Func<Item, bool> func_7;

			// Token: 0x04008C62 RID: 35938
			public static Func<Item, IEnumerable<ResourceKey>> func_8;
		}

		// Token: 0x0200185B RID: 6235
		[CompilerGenerated]
		private sealed class Class1365
		{
			// Token: 0x0600859E RID: 34206 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600859F RID: 34207 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x04008C8B RID: 35979
			public ExitStatus exitStatus;

			// Token: 0x04008C8C RID: 35980
			public string exitName;

			// Token: 0x04008C8D RID: 35981
			public float delay;

			// Token: 0x04008C8E RID: 35982
			public Action action_0;
		}
	}
}
