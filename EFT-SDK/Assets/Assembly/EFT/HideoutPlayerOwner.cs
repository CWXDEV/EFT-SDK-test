using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.HealthSystem;
using EFT.Hideout;
using EFT.InputSystem;
using EFT.UI;
using JetBrains.Annotations;
using UI.Hideout;
using UnityEngine;

namespace EFT
{
	// Token: 0x020018FA RID: 6394
	public sealed class HideoutPlayerOwner : GamePlayerOwner
	{
		// Token: 0x14000194 RID: 404
		// (add) Token: 0x0600899C RID: 35228 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600899D RID: 35229 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool> OnShootingRangeStatusChange
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

		// Token: 0x14000195 RID: 405
		// (add) Token: 0x0600899E RID: 35230 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600899F RID: 35231 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<HideoutArea> OnSelectArea
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

		// Token: 0x14000196 RID: 406
		// (add) Token: 0x060089A0 RID: 35232 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060089A1 RID: 35233 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<HideoutArea> OnSpecialAreaActionSelection
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

		// Token: 0x14000197 RID: 407
		// (add) Token: 0x060089A2 RID: 35234 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060089A3 RID: 35235 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnToggleInfoIcons
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

		// Token: 0x14000198 RID: 408
		// (add) Token: 0x060089A4 RID: 35236 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060089A5 RID: 35237 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnExitQte
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

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x060089A6 RID: 35238 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060089A7 RID: 35239 RVA: 0x00002050 File Offset: 0x00000250
		public bool FirstPersonMode
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

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x060089A8 RID: 35240 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060089A9 RID: 35241 RVA: 0x00002050 File Offset: 0x00000250
		public HideoutPlayer HideoutPlayer
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

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x060089AA RID: 35242 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060089AB RID: 35243 RVA: 0x00002050 File Offset: 0x00000250
		public bool InShootingRange
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

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x060089AC RID: 35244 RVA: 0x00002050 File Offset: 0x00000250
		public bool AvailableForInteractions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x060089AD RID: 35245 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060089AE RID: 35246 RVA: 0x00002050 File Offset: 0x00000250
		public bool FlashLightState
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

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x060089AF RID: 35247 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060089B0 RID: 35248 RVA: 0x00002050 File Offset: 0x00000250
		public HideoutArea HideoutArea
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

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x060089B1 RID: 35249 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool SetItemInHandsImmediately
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x060089B2 RID: 35250 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060089B3 RID: 35251 RVA: 0x00002050 File Offset: 0x00000250
		public override GInterface149 PlayerInputTranslator
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

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x060089B4 RID: 35252 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060089B5 RID: 35253 RVA: 0x00002050 File Offset: 0x00000250
		public override GInterface150 HandsInputTranslator
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

		// Token: 0x060089B6 RID: 35254 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnterShootingRange()
		{
			throw null;
		}

		// Token: 0x060089B7 RID: 35255 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task ExitShootingRange()
		{
			throw null;
		}

		// Token: 0x060089B8 RID: 35256 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPointOfView(bool firstPerson)
		{
			throw null;
		}

		// Token: 0x060089B9 RID: 35257 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DecidePatrolStatus(bool force = false)
		{
			throw null;
		}

		// Token: 0x060089BA RID: 35258 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectArea(HideoutArea area)
		{
			throw null;
		}

		// Token: 0x060089BB RID: 35259 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectSpecialAreaAction(HideoutArea area)
		{
			throw null;
		}

		// Token: 0x060089BC RID: 35260 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExitQte()
		{
			throw null;
		}

		// Token: 0x060089BD RID: 35261 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideoutAreaInteraction([CanBeNull] HideoutArea area, bool inSight)
		{
			throw null;
		}

		// Token: 0x060089BE RID: 35262 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void vmethod_1()
		{
			throw null;
		}

		// Token: 0x060089BF RID: 35263 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Init()
		{
			throw null;
		}

		// Token: 0x060089C0 RID: 35264 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void InitBattleUIScreen()
		{
			throw null;
		}

		// Token: 0x060089C1 RID: 35265 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ShowBattleUIScreen()
		{
			throw null;
		}

		// Token: 0x060089C2 RID: 35266 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void InteractionsChangedHandler()
		{
			throw null;
		}

		// Token: 0x060089C3 RID: 35267 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x060089C4 RID: 35268 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool TranslateInventoryScreenInput(ECommand command)
		{
			throw null;
		}

		// Token: 0x060089C5 RID: 35269 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ShowInventoryScreen(Action exitAction, IHealthController healthController, InventoryControllerClass controller, AbstractQuestControllerClass questController, AbstractAchievementControllerClass achievementsController, LootItemClass lootItem, InventoryScreen.EInventoryTab tab, bool showAsGridContent = false)
		{
			throw null;
		}

		// Token: 0x060089C6 RID: 35270 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowAreaItemsTransferScreen(EAreaType areaType, Action exitAction)
		{
			throw null;
		}

		// Token: 0x060089C7 RID: 35271 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool TranslateExitScreenInput(ECommand command)
		{
			throw null;
		}

		// Token: 0x060089C8 RID: 35272 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_12(bool status, bool forced = false)
		{
			throw null;
		}

		// Token: 0x060089C9 RID: 35273 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x060089CA RID: 35274 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x060089CB RID: 35275 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_15()
		{
			throw null;
		}

		// Token: 0x060089CC RID: 35276 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(bool hide)
		{
			throw null;
		}

		// Token: 0x060089CD RID: 35277 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrepareWorkout(RuntimeAnimatorController animatorController, Vector3 playerPosition, Vector3 playerRotation, Transform lDumbbell, Transform rDumbbell, QteHandleData.PropsData leftDumbbellData, QteHandleData.PropsData rightDumbbellData)
		{
			throw null;
		}

		// Token: 0x060089CE RID: 35278 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopWorkout()
		{
			throw null;
		}

		// Token: 0x060089CF RID: 35279 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17()
		{
			throw null;
		}

		// Token: 0x060089D0 RID: 35280 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void smethod_4(Transform dumbbell, Transform parent, QteHandleData.PropsData transformData)
		{
			throw null;
		}

		// Token: 0x04008F71 RID: 36721
		private const int int_0 = 50;

		// Token: 0x04008F72 RID: 36722
		[CompilerGenerated]
		private Action<bool> action_2;

		// Token: 0x04008F73 RID: 36723
		[CompilerGenerated]
		private Action<HideoutArea> action_3;

		// Token: 0x04008F74 RID: 36724
		[CompilerGenerated]
		private Action<HideoutArea> action_4;

		// Token: 0x04008F75 RID: 36725
		[CompilerGenerated]
		private Action action_5;

		// Token: 0x04008F76 RID: 36726
		[CompilerGenerated]
		private Action action_6;

		// Token: 0x04008F77 RID: 36727
		private bool bool_5;

		// Token: 0x04008F78 RID: 36728
		private GInterface150 ginterface150_1;

		// Token: 0x04008F79 RID: 36729
		private GInterface149 ginterface149_1;

		// Token: 0x04008F7A RID: 36730
		private bool bool_6;

		// Token: 0x04008F7B RID: 36731
		private readonly Vector3 vector3_0;

		// Token: 0x04008F7C RID: 36732
		private Vector3 vector3_1;

		// Token: 0x04008F7D RID: 36733
		private RuntimeAnimatorController runtimeAnimatorController_0;

		// Token: 0x04008F7E RID: 36734
		[CompilerGenerated]
		private bool bool_7;

		// Token: 0x04008F7F RID: 36735
		[CompilerGenerated]
		private HideoutPlayer hideoutPlayer_0;

		// Token: 0x04008F80 RID: 36736
		[CompilerGenerated]
		private bool bool_8;

		// Token: 0x04008F81 RID: 36737
		[CompilerGenerated]
		private bool bool_9;

		// Token: 0x04008F82 RID: 36738
		[CompilerGenerated]
		private HideoutArea hideoutArea_0;

		// Token: 0x020018FC RID: 6396
		[CompilerGenerated]
		private sealed class Class1445
		{
			// Token: 0x060089D3 RID: 35283 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008F88 RID: 36744
			public HideoutPlayerOwner hideoutPlayerOwner_0;

			// Token: 0x04008F89 RID: 36745
			public Action exitAction;
		}

		// Token: 0x020018FD RID: 6397
		[CompilerGenerated]
		private sealed class Class1446
		{
			// Token: 0x060089D4 RID: 35284 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008F8A RID: 36746
			public HideoutPlayerOwner hideoutPlayerOwner_0;

			// Token: 0x04008F8B RID: 36747
			public Action exitAction;
		}
	}
}
