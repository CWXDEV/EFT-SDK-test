using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.CameraControl;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using EFT.PrefabSettings;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;

namespace EFT
{
	// Token: 0x020014DA RID: 5338
	public sealed class BotOwner : MonoBehaviour, IPlayer
	{
		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06007222 RID: 29218 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007223 RID: 29219 RVA: 0x00002050 File Offset: 0x00000250
		public StandartBotBrain Brain
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

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06007224 RID: 29220 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007225 RID: 29221 RVA: 0x00002050 File Offset: 0x00000250
		public float ENEMY_LOOK_AT_ME
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

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06007226 RID: 29222 RVA: 0x00002050 File Offset: 0x00000250
		public float ActivateTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06007227 RID: 29223 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007228 RID: 29224 RVA: 0x00002050 File Offset: 0x00000250
		public LookSensor LookSensor
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

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06007229 RID: 29225 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600722A RID: 29226 RVA: 0x00002050 File Offset: 0x00000250
		public DeadBodyData DeadBodyData
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

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x0600722B RID: 29227 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600722C RID: 29228 RVA: 0x00002050 File Offset: 0x00000250
		public BotLay BotLay
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

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x0600722D RID: 29229 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600722E RID: 29230 RVA: 0x00002050 File Offset: 0x00000250
		public BotTilt Tilt
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

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x0600722F RID: 29231 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007230 RID: 29232 RVA: 0x00002050 File Offset: 0x00000250
		public BotCalcGoal GoalCulculator
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

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06007231 RID: 29233 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007232 RID: 29234 RVA: 0x00002050 File Offset: 0x00000250
		public BotGoToPointData GoToSomePointData
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

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06007233 RID: 29235 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007234 RID: 29236 RVA: 0x00002050 File Offset: 0x00000250
		public LookData LookData
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

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06007235 RID: 29237 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007236 RID: 29238 RVA: 0x00002050 File Offset: 0x00000250
		public BotLight BotLight
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

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06007237 RID: 29239 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007238 RID: 29240 RVA: 0x00002050 File Offset: 0x00000250
		public BotTurnAwayLight BotTurnAwayLight
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

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06007239 RID: 29241 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600723A RID: 29242 RVA: 0x00002050 File Offset: 0x00000250
		public BotCoverSearchInfo CoverSearchInfo
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

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x0600723B RID: 29243 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600723C RID: 29244 RVA: 0x00002050 File Offset: 0x00000250
		public BotBoss Boss
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

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x0600723D RID: 29245 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600723E RID: 29246 RVA: 0x00002050 File Offset: 0x00000250
		public BotLeaveData LeaveData
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

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x0600723F RID: 29247 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007240 RID: 29248 RVA: 0x00002050 File Offset: 0x00000250
		public BotFollower BotFollower
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

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06007241 RID: 29249 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007242 RID: 29250 RVA: 0x00002050 File Offset: 0x00000250
		public BotNightVisionData NightVision
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

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06007243 RID: 29251 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007244 RID: 29252 RVA: 0x00002050 File Offset: 0x00000250
		public BotLoyaltyData LoyaltyData
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

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06007245 RID: 29253 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007246 RID: 29254 RVA: 0x00002050 File Offset: 0x00000250
		public BotVoxelesPersonalData VoxelesPersonalData
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

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06007247 RID: 29255 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007248 RID: 29256 RVA: 0x00002050 File Offset: 0x00000250
		public BotAssaultBuildingData AssaultBuildingData
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

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06007249 RID: 29257 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600724A RID: 29258 RVA: 0x00002050 File Offset: 0x00000250
		public BotRun BotRun
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

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x0600724B RID: 29259 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600724C RID: 29260 RVA: 0x00002050 File Offset: 0x00000250
		public BotSteering Steering
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

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x0600724D RID: 29261 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600724E RID: 29262 RVA: 0x00002050 File Offset: 0x00000250
		public BotEnemyLookData EnemyLookData
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

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x0600724F RID: 29263 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007250 RID: 29264 RVA: 0x00002050 File Offset: 0x00000250
		public FindPlaceToShootManager FindPlaceToShoot
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

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06007251 RID: 29265 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007252 RID: 29266 RVA: 0x00002050 File Offset: 0x00000250
		public BotHealAnotherTarget HealAnotherTarget
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

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06007253 RID: 29267 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007254 RID: 29268 RVA: 0x00002050 File Offset: 0x00000250
		public BotCellData CellData
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

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06007255 RID: 29269 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007256 RID: 29270 RVA: 0x00002050 File Offset: 0x00000250
		public BotRandomPlanItemDropper RandomPlanItemDropper
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

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06007257 RID: 29271 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007258 RID: 29272 RVA: 0x00002050 File Offset: 0x00000250
		public BotPeaceHardAim PeaceHardAim
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

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06007259 RID: 29273 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600725A RID: 29274 RVA: 0x00002050 File Offset: 0x00000250
		public BotPeaceLook PeaceLook
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

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x0600725B RID: 29275 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600725C RID: 29276 RVA: 0x00002050 File Offset: 0x00000250
		public BotUnityEditorRunChecker UnityEditorRunChecker
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

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x0600725D RID: 29277 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600725E RID: 29278 RVA: 0x00002050 File Offset: 0x00000250
		public BotDogFight DogFight
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

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x0600725F RID: 29279 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007260 RID: 29280 RVA: 0x00002050 File Offset: 0x00000250
		public BotPriorityAxeTarget PriorityAxeTarget
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

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06007261 RID: 29281 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007262 RID: 29282 RVA: 0x00002050 File Offset: 0x00000250
		public BotFriendChecker FriendChecker
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

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06007263 RID: 29283 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007264 RID: 29284 RVA: 0x00002050 File Offset: 0x00000250
		public BotNavMeshCutterController NavMeshCutterController
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

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06007265 RID: 29285 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007266 RID: 29286 RVA: 0x00002050 File Offset: 0x00000250
		public BotBewareGrenade BewareGrenade
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

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06007267 RID: 29287 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007268 RID: 29288 RVA: 0x00002050 File Offset: 0x00000250
		public BotBewareBTR BewareBTR
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

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06007269 RID: 29289 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600726A RID: 29290 RVA: 0x00002050 File Offset: 0x00000250
		public BotPlayerFollowData PlayerFollowData
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

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x0600726B RID: 29291 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600726C RID: 29292 RVA: 0x00002050 File Offset: 0x00000250
		public BotMoveToEnemyData MoveToEnemyData
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

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x0600726D RID: 29293 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600726E RID: 29294 RVA: 0x00002050 File Offset: 0x00000250
		public ArtilleryDangerPlace ArtilleryDangerPlace
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

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x0600726F RID: 29295 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007270 RID: 29296 RVA: 0x00002050 File Offset: 0x00000250
		public BotFlashGrenade FlashGrenade
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

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06007271 RID: 29297 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007272 RID: 29298 RVA: 0x00002050 File Offset: 0x00000250
		public GrenadeSuicideBotData GrenadeSuicide
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

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06007273 RID: 29299 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007274 RID: 29300 RVA: 0x00002050 File Offset: 0x00000250
		public BotHealingBySomebody HealingBySomebody
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

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06007275 RID: 29301 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007276 RID: 29302 RVA: 0x00002050 File Offset: 0x00000250
		public BotPeacefulActions PeacefulActions
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

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06007277 RID: 29303 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007278 RID: 29304 RVA: 0x00002050 File Offset: 0x00000250
		public BotDeadBodyWork DeadBodyWork
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

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06007279 RID: 29305 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600727A RID: 29306 RVA: 0x00002050 File Offset: 0x00000250
		public BotMagazineChecker MagazineChecker
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

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x0600727B RID: 29307 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600727C RID: 29308 RVA: 0x00002050 File Offset: 0x00000250
		public BotSmokeGrenade SmokeGrenade
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

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x0600727D RID: 29309 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600727E RID: 29310 RVA: 0x00002050 File Offset: 0x00000250
		public BotSuppressShoot SuppressShoot
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

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x0600727F RID: 29311 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007280 RID: 29312 RVA: 0x00002050 File Offset: 0x00000250
		public BotSuppressStationary SuppressStationary
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

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06007281 RID: 29313 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007282 RID: 29314 RVA: 0x00002050 File Offset: 0x00000250
		public BotEnemyChooser EnemyChooser
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

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06007283 RID: 29315 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007284 RID: 29316 RVA: 0x00002050 File Offset: 0x00000250
		public BotGiftData GiftData
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

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06007285 RID: 29317 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007286 RID: 29318 RVA: 0x00002050 File Offset: 0x00000250
		public BotDangerPointsData DangerPointsData
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

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06007287 RID: 29319 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007288 RID: 29320 RVA: 0x00002050 File Offset: 0x00000250
		public BotSuppressGrenade SuppressGrenade
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

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06007289 RID: 29321 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600728A RID: 29322 RVA: 0x00002050 File Offset: 0x00000250
		public BotBtrData BotBtrData
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

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x0600728B RID: 29323 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600728C RID: 29324 RVA: 0x00002050 File Offset: 0x00000250
		public ShootData ShootData
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

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x0600728D RID: 29325 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600728E RID: 29326 RVA: 0x00002050 File Offset: 0x00000250
		public BotEnemiesController EnemiesController
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

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x0600728F RID: 29327 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007290 RID: 29328 RVA: 0x00002050 File Offset: 0x00000250
		public IBotAiming AimingData
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

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06007291 RID: 29329 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007292 RID: 29330 RVA: 0x00002050 File Offset: 0x00000250
		public BotPlanDropItem PlanDropItem
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

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x06007293 RID: 29331 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007294 RID: 29332 RVA: 0x00002050 File Offset: 0x00000250
		public BotStandBy StandBy
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

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06007295 RID: 29333 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007296 RID: 29334 RVA: 0x00002050 File Offset: 0x00000250
		public BotHeadData HeadData
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

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06007297 RID: 29335 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007298 RID: 29336 RVA: 0x00002050 File Offset: 0x00000250
		public BotEatDrinkData EatDrinkData
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

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06007299 RID: 29337 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600729A RID: 29338 RVA: 0x00002050 File Offset: 0x00000250
		public BotSecondWeaponData SecondWeaponData
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

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x0600729B RID: 29339 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600729C RID: 29340 RVA: 0x00002050 File Offset: 0x00000250
		public BotMedecine Medecine
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

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x0600729D RID: 29341 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600729E RID: 29342 RVA: 0x00002050 File Offset: 0x00000250
		public RecoilData RecoilData
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

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x0600729F RID: 29343 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072A0 RID: 29344 RVA: 0x00002050 File Offset: 0x00000250
		public BotCallForHelp CallForHelp
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

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x060072A1 RID: 29345 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072A2 RID: 29346 RVA: 0x00002050 File Offset: 0x00000250
		public BotCalledData CalledData
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

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x060072A3 RID: 29347 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072A4 RID: 29348 RVA: 0x00002050 File Offset: 0x00000250
		public BotAmbushData Ambush
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

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060072A5 RID: 29349 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072A6 RID: 29350 RVA: 0x00002050 File Offset: 0x00000250
		public BotFriendlyTilt FriendlyTilt
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

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060072A7 RID: 29351 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072A8 RID: 29352 RVA: 0x00002050 File Offset: 0x00000250
		public BotLootOpener LootOpener
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

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060072A9 RID: 29353 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072AA RID: 29354 RVA: 0x00002050 File Offset: 0x00000250
		public BotCoversData Covers
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

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x060072AB RID: 29355 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072AC RID: 29356 RVA: 0x00002050 File Offset: 0x00000250
		public BotWeaponManager WeaponManager
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

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x060072AD RID: 29357 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072AE RID: 29358 RVA: 0x00002050 File Offset: 0x00000250
		public BotTacticData Tactic
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

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x060072AF RID: 29359 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072B0 RID: 29360 RVA: 0x00002050 File Offset: 0x00000250
		public BotDoorOpener DoorOpener
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

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x060072B1 RID: 29361 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072B2 RID: 29362 RVA: 0x00002050 File Offset: 0x00000250
		public BotGesture Gesture
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

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x060072B3 RID: 29363 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072B4 RID: 29364 RVA: 0x00002050 File Offset: 0x00000250
		public BotDangerArea DangerArea
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

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x060072B5 RID: 29365 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072B6 RID: 29366 RVA: 0x00002050 File Offset: 0x00000250
		public BotAssaultDangerArea AssaultDangerArea
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

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x060072B7 RID: 29367 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072B8 RID: 29368 RVA: 0x00002050 File Offset: 0x00000250
		public BotReceiver Receiver
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

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x060072B9 RID: 29369 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072BA RID: 29370 RVA: 0x00002050 File Offset: 0x00000250
		public BotItemTaker ItemTaker
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

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x060072BB RID: 29371 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072BC RID: 29372 RVA: 0x00002050 File Offset: 0x00000250
		public BotExternalItemsController ExternalItemsController
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

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x060072BD RID: 29373 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072BE RID: 29374 RVA: 0x00002050 File Offset: 0x00000250
		public BotItemDropper ItemDropper
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

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x060072BF RID: 29375 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072C0 RID: 29376 RVA: 0x00002050 File Offset: 0x00000250
		public BotSearchData SearchData
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

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x060072C1 RID: 29377 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072C2 RID: 29378 RVA: 0x00002050 File Offset: 0x00000250
		public BotPersonalStats BotPersonalStats
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

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x060072C3 RID: 29379 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072C4 RID: 29380 RVA: 0x00002050 File Offset: 0x00000250
		public BotShootFromPlace ShootFromPlace
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

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x060072C5 RID: 29381 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072C6 RID: 29382 RVA: 0x00002050 File Offset: 0x00000250
		public BotHearingSensor HearingSensor
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

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x060072C7 RID: 29383 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072C8 RID: 29384 RVA: 0x00002050 File Offset: 0x00000250
		public BotRequestController BotRequestController
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

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x060072C9 RID: 29385 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072CA RID: 29386 RVA: 0x00002050 File Offset: 0x00000250
		public BotsController BotsController
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

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x060072CB RID: 29387 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072CC RID: 29388 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform MyHead
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

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x060072CD RID: 29389 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072CE RID: 29390 RVA: 0x00002050 File Offset: 0x00000250
		public DecisionQueue DecisionQueue
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

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x060072CF RID: 29391 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072D0 RID: 29392 RVA: 0x00002050 File Offset: 0x00000250
		public BotGameEventsData GameEventsData
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

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x060072D1 RID: 29393 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072D2 RID: 29394 RVA: 0x00002050 File Offset: 0x00000250
		public AICorePoint StartCorePoint
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

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x060072D3 RID: 29395 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072D4 RID: 29396 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060072D5 RID: 29397 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072D6 RID: 29398 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 Lean
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

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060072D7 RID: 29399 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3? Destination
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x060072D8 RID: 29400 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072D9 RID: 29401 RVA: 0x00002050 File Offset: 0x00000250
		public BotAttackManager BotAttackManager
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

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x060072DA RID: 29402 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072DB RID: 29403 RVA: 0x00002050 File Offset: 0x00000250
		public BotMover Mover
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

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x060072DC RID: 29404 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072DD RID: 29405 RVA: 0x00002050 File Offset: 0x00000250
		public BotTalk BotTalk
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

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060072DE RID: 29406 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072DF RID: 29407 RVA: 0x00002050 File Offset: 0x00000250
		public IGetProfileData SpawnProfileData
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

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x060072E0 RID: 29408 RVA: 0x00002050 File Offset: 0x00000250
		public AITaskManager AITaskManager
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1400013A RID: 314
		// (add) Token: 0x060072E1 RID: 29409 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060072E2 RID: 29410 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<EBotState> OnBotStateChange
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

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x060072E3 RID: 29411 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072E4 RID: 29412 RVA: 0x00002050 File Offset: 0x00000250
		public BotsGroup BotsGroup
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

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060072E5 RID: 29413 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072E6 RID: 29414 RVA: 0x00002050 File Offset: 0x00000250
		public EBotState BotState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060072E7 RID: 29415 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform Fireport
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060072E8 RID: 29416 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanSprintPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060072E9 RID: 29417 RVA: 0x00002050 File Offset: 0x00000250
		[Obsolete("Use Player.Transform instead!", true)]
		public new Transform transform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060072EA RID: 29418 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072EB RID: 29419 RVA: 0x00002050 File Offset: 0x00000250
		public PatrollingData PatrollingData
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

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060072EC RID: 29420 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060072ED RID: 29421 RVA: 0x00002050 File Offset: 0x00000250
		public string GroupId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060072EE RID: 29422 RVA: 0x00002050 File Offset: 0x00000250
		public string TeamId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060072EF RID: 29423 RVA: 0x00002050 File Offset: 0x00000250
		public string Infiltration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060072F0 RID: 29424 RVA: 0x00002050 File Offset: 0x00000250
		public string AccountId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060072F1 RID: 29425 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072F2 RID: 29426 RVA: 0x00002050 File Offset: 0x00000250
		public string ProfileId
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

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060072F3 RID: 29427 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072F4 RID: 29428 RVA: 0x00002050 File Offset: 0x00000250
		public int Id
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

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060072F5 RID: 29429 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerSide Side
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060072F6 RID: 29430 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform Transform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060072F7 RID: 29431 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform WeaponRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060072F8 RID: 29432 RVA: 0x00002050 File Offset: 0x00000250
		public IHealthController HealthController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060072F9 RID: 29433 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerBones PlayerBones
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060072FA RID: 29434 RVA: 0x00002050 File Offset: 0x00000250
		public Profile Profile
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060072FB RID: 29435 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060072FC RID: 29436 RVA: 0x00002050 File Offset: 0x00000250
		public Player GetPlayer
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

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060072FD RID: 29437 RVA: 0x00002050 File Offset: 0x00000250
		public AIData AIData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060072FE RID: 29438 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAI
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060072FF RID: 29439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeserializeFromServer(byte channelId, GInterface76 reader)
		{
			throw null;
		}

		// Token: 0x06007300 RID: 29440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RadioTransmitterRecodableComponent FindRadioTransmitter()
		{
			throw null;
		}

		// Token: 0x06007301 RID: 29441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass2712 FindCultistAmulet()
		{
			throw null;
		}

		// Token: 0x1400013B RID: 315
		// (add) Token: 0x06007302 RID: 29442 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007303 RID: 29443 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<IPlayer> OnIPlayerDeadOrUnspawn
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

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x06007304 RID: 29444 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007305 RID: 29445 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsInBufferZone
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

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06007306 RID: 29446 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007307 RID: 29447 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerBtrState BtrState
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

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x06007308 RID: 29448 RVA: 0x00002050 File Offset: 0x00000250
		public bool StateIsSuitableForHandInput
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007309 RID: 29449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInteractInHands(bool isInteracting, int animationId = 1)
		{
			throw null;
		}

		// Token: 0x0600730A RID: 29450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlantItemLocalOnly(Item item, string zone)
		{
			throw null;
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateInteractionCast()
		{
			throw null;
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleFlareSuccessEvent(Vector3 position, FlareEventType eventType)
		{
			throw null;
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x0600730D RID: 29453 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 Rotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600730E RID: 29454 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight)
		{
			throw null;
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x0600730F RID: 29455 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Velocity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06007310 RID: 29456 RVA: 0x00002050 File Offset: 0x00000250
		public byte ChannelIndex
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06007311 RID: 29457 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsYourPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06007312 RID: 29458 RVA: 0x00002050 File Offset: 0x00000250
		public ICharacterController CharacterController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06007313 RID: 29459 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerBody PlayerBody
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06007314 RID: 29460 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerLoyaltyData Loyalty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06007315 RID: 29461 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007316 RID: 29462 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<BodyPartType, EnemyPart> MainParts
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

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06007317 RID: 29463 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 LookDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06007318 RID: 29464 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007319 RID: 29465 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsDead
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

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x0600731A RID: 29466 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasPathAndNotComplete
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x0600731B RID: 29467 RVA: 0x00002050 File Offset: 0x00000250
		public Player.EUpdateMode ArmsUpdateMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x0600731C RID: 29468 RVA: 0x00002050 File Offset: 0x00000250
		public EUpdateQueue ArmsUpdateQueue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x0600731D RID: 29469 RVA: 0x00002050 File Offset: 0x00000250
		public ECameraType VisibleToCameraType
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x0600731E RID: 29470 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsVisibleToCamera
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SayGroupAboutEnemy(IPlayer person, Vector3? partPos = null)
		{
			throw null;
		}

		// Token: 0x06007320 RID: 29472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NavMeshPathStatus GoToPoint(PatrolPointContainer targetPoint)
		{
			throw null;
		}

		// Token: 0x06007321 RID: 29473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GoToPoint(CustomNavigationPoint targetPoint)
		{
			throw null;
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BotOwner Create(Player player, GameObject behaviourTreePrefab, GameDateTime gameDataTime, BotsController botsController, bool isLocalGame, AICorePoint corePointId)
		{
			throw null;
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PreActivate(BotZone zone, GameDateTime time, BotsGroup group, AICoversData covers, bool autoActivate = true)
		{
			throw null;
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PostActivate()
		{
			throw null;
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06007326 RID: 29478 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShootPointClass CurrentEnemyTargetPosition(bool sensPosition)
		{
			throw null;
		}

		// Token: 0x06007327 RID: 29479 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Func<int, bool> condition, IPlayer person)
		{
			throw null;
		}

		// Token: 0x06007328 RID: 29480 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Sprint(bool val, bool withDebugCallback = true)
		{
			throw null;
		}

		// Token: 0x06007329 RID: 29481 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600732A RID: 29482 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Player player, IPlayer lastAggressor, DamageInfo lastDamageInfo, EBodyPart lastBodyPart)
		{
			throw null;
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600732C RID: 29484 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Vector3 obj)
		{
			throw null;
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsRole(WildSpawnType role)
		{
			throw null;
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsFollower()
		{
			throw null;
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float DistTo(Vector3 v)
		{
			throw null;
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float SDistTo(Vector3 v)
		{
			throw null;
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(EBodyPart bodyPart, float damage, DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x06007334 RID: 29492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEnemyLookingAtMe(EnemyInfo goalEnemy)
		{
			throw null;
		}

		// Token: 0x06007335 RID: 29493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEnemyLookingAtMe(IPlayer gamePerson)
		{
			throw null;
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x06007337 RID: 29495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(DamageInfo damageInfo, EBodyPart bodyType, float damageReducedByArmor)
		{
			throw null;
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600733A RID: 29498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disable()
		{
			throw null;
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateManual()
		{
			throw null;
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactivate()
		{
			throw null;
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalcGoal()
		{
			throw null;
		}

		// Token: 0x0600733E RID: 29502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x0600733F RID: 29503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLean(Vector2 lean)
		{
			throw null;
		}

		// Token: 0x06007340 RID: 29504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetYAngle(float angle)
		{
			throw null;
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopMove()
		{
			throw null;
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTargetMoveSpeed(float speed)
		{
			throw null;
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MovementResume()
		{
			throw null;
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPose(float targetPose)
		{
			throw null;
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MovementPause(float pauseTime)
		{
			throw null;
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDieCallback(Action<BotOwner> botDied)
		{
			throw null;
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GoToByWay(Vector3[] way, float reachDist = -1f)
		{
			throw null;
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NavMeshPathStatus GoToPoint(Vector3 position, bool slowAtTheEnd = true, float reachDist = -1f, bool getUpWithCheck = false, bool mustHaveWay = true, bool mustGetUp = true, bool onlyShortTrie = false)
		{
			throw null;
		}

		// Token: 0x06007349 RID: 29513 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x0600734A RID: 29514 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHandle(string toString)
		{
			throw null;
		}

		// Token: 0x0600734C RID: 29516 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HashSet<Vector3> CarePositions()
		{
			throw null;
		}

		// Token: 0x0600734D RID: 29517 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IAnimator GetArmsAnimatorCommon()
		{
			throw null;
		}

		// Token: 0x0600734E RID: 29518 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetArmsAnimatorCommon(IAnimator animator)
		{
			throw null;
		}

		// Token: 0x040078D8 RID: 30936
		public const float DIST_CHECK_NAVMESH = 0.6f;

		// Token: 0x040078D9 RID: 30937
		public static readonly Vector3 STAY_HEIGHT;

		// Token: 0x040078DA RID: 30938
		public static readonly Vector3 SIT_HEIGHT;

		// Token: 0x040078DB RID: 30939
		public const string PATH_TO_AI = "AI";

		// Token: 0x040078DC RID: 30940
		public const string PATH_TO_AI_DEBUG = "AIDebug";

		// Token: 0x040078DD RID: 30941
		public static int BotCount;

		// Token: 0x040078DE RID: 30942
		private Action<BotOwner> _botDiedCallback;

		// Token: 0x040078DF RID: 30943
		private EBotState _botState;

		// Token: 0x040078E0 RID: 30944
		private bool _lastHitEvent;

		// Token: 0x040078E1 RID: 30945
		private float _nextGetGoalTime;

		// Token: 0x040078E2 RID: 30946
		private float _preActivateTime;

		// Token: 0x040078E3 RID: 30947
		private float _activateTime;

		// Token: 0x040078E4 RID: 30948
		private float _nextTimeCheckBorn;

		// Token: 0x040078E5 RID: 30949
		public GClass344 DecisionProxy;

		// Token: 0x040078E6 RID: 30950
		public GClass336 DebugMemory;

		// Token: 0x040078E7 RID: 30951
		public Transform LookedTransform;

		// Token: 0x040078E8 RID: 30952
		public BotMemoryClass Memory;

		// Token: 0x040078E9 RID: 30953
		public BotDifficultySettingsClass Settings;

		// Token: 0x040078EA RID: 30954
		private bool _isLocalGame;
	}
}
