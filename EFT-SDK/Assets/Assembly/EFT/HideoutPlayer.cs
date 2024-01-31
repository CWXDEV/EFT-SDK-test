using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT
{
	// Token: 0x020018EB RID: 6379
	public class HideoutPlayer : LocalPlayer
	{
		// Token: 0x0600895D RID: 35165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateBreathStatus()
		{
			throw null;
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x0600895E RID: 35166 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600895F RID: 35167 RVA: 0x00002050 File Offset: 0x00000250
		public InventoryControllerClass OriginalInventory
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

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06008960 RID: 35168 RVA: 0x00002050 File Offset: 0x00000250
		public InventoryControllerClass ShootingRangeInventory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06008961 RID: 35169 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008962 RID: 35170 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsInPatrol
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

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06008963 RID: 35171 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008964 RID: 35172 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsUpdateHideoutPlayerInventoryInProgress
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

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06008965 RID: 35173 RVA: 0x00002050 File Offset: 0x00000250
		public bool NightVisionActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06008966 RID: 35174 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008967 RID: 35175 RVA: 0x00002050 File Offset: 0x00000250
		public override EPointOfView PointOfView
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

		// Token: 0x17001511 RID: 5393
		// (set) Token: 0x06008968 RID: 35176 RVA: 0x00002050 File Offset: 0x00000250
		public bool VisorVisibility
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06008969 RID: 35177 RVA: 0x00002050 File Offset: 0x00000250
		internal override InventoryControllerClass GClass2757_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600896A RID: 35178 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<HideoutPlayer> Create(int playerId, Vector3 position, Quaternion rotation, string layerName, string prefix, EPointOfView pointOfView, Profile profile, bool aiControl, EUpdateQueue updateQueue, Player.EUpdateMode armsUpdateMode, Player.EUpdateMode bodyUpdateMode, CharacterControllerSpawner.Mode characterControllerMode, Func<float> getSensitivity, Func<float> getAimingSensitivity, IStatisticsManager statisticsManager, AbstractQuestControllerClass questController, AbstractAchievementControllerClass achievementsController, IHealthController healthController, GClass2760 inventoryController)
		{
			throw null;
		}

		// Token: 0x0600896B RID: 35179 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CreateSlotObservers()
		{
			throw null;
		}

		// Token: 0x0600896C RID: 35180 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_128()
		{
			throw null;
		}

		// Token: 0x0600896D RID: 35181 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_129()
		{
			throw null;
		}

		// Token: 0x0600896E RID: 35182 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleNightVision()
		{
			throw null;
		}

		// Token: 0x0600896F RID: 35183 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnGameSessionEnd(ExitStatus exitStatus, float pastTime, string locationId, string exitName)
		{
			throw null;
		}

		// Token: 0x06008970 RID: 35184 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task UpdateHideoutPlayerInventory()
		{
			throw null;
		}

		// Token: 0x06008971 RID: 35185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task ReleaseShootingRangeInventory()
		{
			throw null;
		}

		// Token: 0x06008972 RID: 35186 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPatrol(bool patrol)
		{
			throw null;
		}

		// Token: 0x06008973 RID: 35187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_130()
		{
			throw null;
		}

		// Token: 0x06008974 RID: 35188 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Task smethod_2(Profile profile, GDelegate77 yield)
		{
			throw null;
		}

		// Token: 0x06008975 RID: 35189 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ExecuteSkill(Action action)
		{
			throw null;
		}

		// Token: 0x06008976 RID: 35190 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ExecuteShotSkill(Item weapon)
		{
			throw null;
		}

		// Token: 0x06008977 RID: 35191 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnSkillLevelChanged(GClass1763 skill)
		{
			throw null;
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnWeaponMastered(GClass1764 masterSkill)
		{
			throw null;
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("DEBUG")]
		[Conditional("CONSOLE")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_131()
		{
			throw null;
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_132(Result<GInterface123> result)
		{
			throw null;
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_133(Result<GInterface123> result)
		{
			throw null;
		}

		// Token: 0x04008F25 RID: 36645
		private readonly NightVisionComponent nightVisionComponent_0;

		// Token: 0x04008F26 RID: 36646
		private bool bool_0;

		// Token: 0x04008F27 RID: 36647
		private InventoryControllerClass gclass2757_0;

		// Token: 0x04008F28 RID: 36648
		private Action action_0;

		// Token: 0x04008F29 RID: 36649
		private NightVisionComponent nightVisionComponent_1;

		// Token: 0x04008F2A RID: 36650
		[CompilerGenerated]
		private InventoryControllerClass gclass2757_1;

		// Token: 0x04008F2B RID: 36651
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04008F2C RID: 36652
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x020018EC RID: 6380
		private sealed class Class1063<T> : Player.GClass1628<T> where T : class, ITogglableComponentContainer<TogglableComponent>
		{
			// Token: 0x17001513 RID: 5395
			// (get) Token: 0x0600897C RID: 35196 RVA: 0x00002050 File Offset: 0x00000250
			public override T Component
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04008F2D RID: 36653
			private readonly Func<T, T> func_1;
		}

		// Token: 0x020018ED RID: 6381
		public class GClass1854 : GInterface298
		{
			// Token: 0x17001514 RID: 5396
			// (get) Token: 0x0600897D RID: 35197 RVA: 0x00002050 File Offset: 0x00000250
			public float Intensity
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001515 RID: 5397
			// (get) Token: 0x0600897E RID: 35198 RVA: 0x00002050 File Offset: 0x00000250
			public NightVisionComponent.EMask Mask
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001516 RID: 5398
			// (get) Token: 0x0600897F RID: 35199 RVA: 0x00002050 File Offset: 0x00000250
			public float MaskSize
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001517 RID: 5399
			// (get) Token: 0x06008980 RID: 35200 RVA: 0x00002050 File Offset: 0x00000250
			public float NoiseIntensity
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001518 RID: 5400
			// (get) Token: 0x06008981 RID: 35201 RVA: 0x00002050 File Offset: 0x00000250
			public float NoiseScale
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001519 RID: 5401
			// (get) Token: 0x06008982 RID: 35202 RVA: 0x00002050 File Offset: 0x00000250
			public Color32 Color
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700151A RID: 5402
			// (get) Token: 0x06008983 RID: 35203 RVA: 0x00002050 File Offset: 0x00000250
			public float DiffuseIntensity
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		// Token: 0x020018EE RID: 6382
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1439
		{
			// Token: 0x06008984 RID: 35204 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x06008985 RID: 35205 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Action method_1(ThermalVisionComponent tv, Action handler)
			{
				throw null;
			}

			// Token: 0x06008986 RID: 35206 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Action method_2(NightVisionComponent nv, Action handler)
			{
				throw null;
			}

			// Token: 0x06008987 RID: 35207 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Action method_3(FaceShieldComponent fs, Action handler)
			{
				throw null;
			}

			// Token: 0x06008988 RID: 35208 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Action method_4(FaceShieldComponent fs, Action handler)
			{
				throw null;
			}

			// Token: 0x04008F2E RID: 36654
			public static readonly HideoutPlayer.Class1439 class1439_0;

			// Token: 0x04008F2F RID: 36655
			public static Action action_0;

			// Token: 0x04008F30 RID: 36656
			public static Func<ThermalVisionComponent, Action, Action> func_0;

			// Token: 0x04008F31 RID: 36657
			public static Func<NightVisionComponent, Action, Action> func_1;

			// Token: 0x04008F32 RID: 36658
			public static Func<FaceShieldComponent, Action, Action> func_2;

			// Token: 0x04008F33 RID: 36659
			public static Func<FaceShieldComponent, Action, Action> func_3;
		}

		// Token: 0x020018F0 RID: 6384
		[CompilerGenerated]
		private sealed class Class1440
		{
			// Token: 0x0600898B RID: 35211 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ThermalVisionComponent method_0(ThermalVisionComponent originalThermalComponent)
			{
				throw null;
			}

			// Token: 0x0600898C RID: 35212 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal NightVisionComponent method_1(NightVisionComponent originalNVComponent)
			{
				throw null;
			}

			// Token: 0x0600898D RID: 35213 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x04008F4B RID: 36683
			public HideoutPlayer hideoutPlayer_0;

			// Token: 0x04008F4C RID: 36684
			public Action nvUnsub;

			// Token: 0x04008F4D RID: 36685
			public Action tvUnsub;
		}

		// Token: 0x020018F1 RID: 6385
		[CompilerGenerated]
		private sealed class Class1441
		{
			// Token: 0x0600898E RID: 35214 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008F4E RID: 36686
			public Action togglableSub;

			// Token: 0x04008F4F RID: 36687
			public Action hitSub;
		}

		// Token: 0x020018F2 RID: 6386
		[CompilerGenerated]
		private sealed class Class1442
		{
			// Token: 0x0600898F RID: 35215 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008F50 RID: 36688
			public Action togglableSub;

			// Token: 0x04008F51 RID: 36689
			public Action hitSub;
		}

		// Token: 0x020018F3 RID: 6387
		[CompilerGenerated]
		private sealed class Class1443
		{
			// Token: 0x06008990 RID: 35216 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Slot slot)
			{
				throw null;
			}

			// Token: 0x04008F52 RID: 36690
			public Slot playerSlot;
		}

		// Token: 0x020018F5 RID: 6389
		[CompilerGenerated]
		private sealed class Class1444
		{
			// Token: 0x06008993 RID: 35219 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface125> setEmptyHandsResult)
			{
				throw null;
			}

			// Token: 0x04008F5C RID: 36700
			public bool handsAreEmpty;
		}
	}
}
