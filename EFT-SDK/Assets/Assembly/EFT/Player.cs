using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AnimationEventSystem;
using Audio.Data;
using Comfort.Common;
using Dissonance;
using Diz.Binding;
using Diz.LanguageExtensions;
using EFT.Animations;
using EFT.AssetsManager;
using EFT.Ballistics;
using EFT.CameraControl;
using EFT.ClientItems.ClientSpecItems;
using EFT.Game.Spawning;
using EFT.GameRandoms;
using EFT.HealthSystem;
using EFT.Interactive;
using EFT.InventoryLogic;
using EFT.MovingPlatforms;
using EFT.PrefabSettings;
using EFT.Vaulting;
using EFT.Vehicle;
using JetBrains.Annotations;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace EFT
{
	// Token: 0x02001392 RID: 5010
	public class Player : MonoBehaviour, IDissonancePlayer, IPlayer, GInterface104, GInterface105, GInterface106, GInterface117, MovingPlatform.GInterface347
	{
		// Token: 0x06006602 RID: 26114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GStruct415<ItemAddress> ToItemAddress(GClass1522 descriptor)
		{
			throw null;
		}

		// Token: 0x06006603 RID: 26115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct415<TraderControllerClass> FindControllerById(string id)
		{
			throw null;
		}

		// Token: 0x06006604 RID: 26116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GStruct415<IEnumerable<GStruct368>> method_0(IEnumerable<GClass1528> itemsData)
		{
			throw null;
		}

		// Token: 0x06006605 RID: 26117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct415<Item> FindItemById(string itemId, bool checkDistance = true, bool checkOwnership = true)
		{
			throw null;
		}

		// Token: 0x06006606 RID: 26118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsOwnerCandidateValid(string itemId, IItemOwner ownerCandidate, out Error error)
		{
			throw null;
		}

		// Token: 0x06006607 RID: 26119 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static LootItem GetLootItem(string itemId, Vector3 position)
		{
			throw null;
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2844> ToCreateItemsOperation(GClass1569 descriptor)
		{
			throw null;
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2862> ToPurchaseTraderServiceOperation(GClass1570 descriptor)
		{
			throw null;
		}

		// Token: 0x0600660A RID: 26122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2839> ToAddOperation(GClass1530 descriptor)
		{
			throw null;
		}

		// Token: 0x0600660B RID: 26123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2858> ToLoadMagOperation(GClass1532 descriptor)
		{
			throw null;
		}

		// Token: 0x0600660C RID: 26124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2859> ToUnloadMagOperation(GClass1533 descriptor)
		{
			throw null;
		}

		// Token: 0x0600660D RID: 26125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2864> ToRemoveOperation(GClass1534 descriptor)
		{
			throw null;
		}

		// Token: 0x0600660E RID: 26126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2835> ToMoveOperation(GClass1542 descriptor)
		{
			throw null;
		}

		// Token: 0x0600660F RID: 26127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2861> ToMoveAllOperation(GClass1543 descriptor)
		{
			throw null;
		}

		// Token: 0x06006610 RID: 26128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2868> ToSplitOperation(GClass1544 descriptor)
		{
			throw null;
		}

		// Token: 0x06006611 RID: 26129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2860> ToMergeOperation(GClass1545 descriptor)
		{
			throw null;
		}

		// Token: 0x06006612 RID: 26130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2872> ToTransferOperation(GClass1546 descriptor)
		{
			throw null;
		}

		// Token: 0x06006613 RID: 26131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2836> ToSwapOperation(GClass1547 descriptor)
		{
			throw null;
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2837> ToThrowOperation(GClass1548 descriptor)
		{
			throw null;
		}

		// Token: 0x06006615 RID: 26133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2871> ToToggleOperation(GClass1549 descriptor)
		{
			throw null;
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2854> ToFoldOperation(GClass1550 descriptor)
		{
			throw null;
		}

		// Token: 0x06006617 RID: 26135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2867> ToShotOperation(GClass1551 descriptor)
		{
			throw null;
		}

		// Token: 0x06006618 RID: 26136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2866> ToSetupItemOperation(GClass1552 descriptor)
		{
			throw null;
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2870> ToTagOperation(GClass1561 descriptor)
		{
			throw null;
		}

		// Token: 0x0600661A RID: 26138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2869> ToStationaryOperation(GClass1562 descriptor)
		{
			throw null;
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2874> ToWeaponRechamberOperation(GClass1563 descriptor)
		{
			throw null;
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2841> ToApplyKeyOperation(GClass1553 descriptor)
		{
			throw null;
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2845> ToCreateMapMarkerOperation(GClass1555 descriptor)
		{
			throw null;
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2849> ToEditMapMarkerOperation(GClass1556 descriptor)
		{
			throw null;
		}

		// Token: 0x0600661F RID: 26143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2846> ToDeleteMapMarkerOperation(GClass1557 descriptor)
		{
			throw null;
		}

		// Token: 0x06006620 RID: 26144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2838> ToAddNoteOperation(GClass1558 descriptor)
		{
			throw null;
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2850> ToEditNoteOperation(GClass1559 descriptor)
		{
			throw null;
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2847> ToDeleteNoteOperation(GClass1560 descriptor)
		{
			throw null;
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2853> ToExamineOperation(GClass1535 descriptor)
		{
			throw null;
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2876> ToQuestAcceptOperation(GClass1566 descriptor)
		{
			throw null;
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2877> ToQuestFinishOperation(GClass1567 descriptor)
		{
			throw null;
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2878> ToQuestHandoverOperation(GClass1568 descriptor)
		{
			throw null;
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2852> ToExamineMalfunctionOperation(GClass1536 descriptor)
		{
			throw null;
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2851> ToExamineMalfTypeOperation(GClass1537 descriptor)
		{
			throw null;
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct411<GClass2843> ToCheckMagazineOperation(GClass1538 descriptor)
		{
			throw null;
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GStruct411<GClass2842> method_1(GClass1539 descriptor)
		{
			throw null;
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GStruct411<GClass2873> method_2(GClass1540 descriptor)
		{
			throw null;
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GStruct411<GClass2856> method_3(GClass1541 descriptor)
		{
			throw null;
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct410 ToInventoryOperation(GClass1529 descriptor)
		{
			throw null;
		}

		// Token: 0x14000120 RID: 288
		// (add) Token: 0x0600662E RID: 26158 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600662F RID: 26159 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<float, float, int> OnSpeedChangedEvent
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

		// Token: 0x14000121 RID: 289
		// (add) Token: 0x06006630 RID: 26160 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006631 RID: 26161 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<SightComponent> OnSightChangedEvent
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

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06006632 RID: 26162 RVA: 0x00002050 File Offset: 0x00000250
		public IAnimator BodyAnimatorCommon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IAnimator GetBodyAnimatorCommon()
		{
			throw null;
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06006634 RID: 26164 RVA: 0x00002050 File Offset: 0x00000250
		public IAnimator ArmsAnimatorCommon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06006635 RID: 26165 RVA: 0x00002050 File Offset: 0x00000250
		public IAnimator UnderbarrelWeaponArmsAnimator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IAnimator GetArmsAnimatorCommon()
		{
			throw null;
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetArmsAnimatorCommon(IAnimator animator)
		{
			throw null;
		}

		// Token: 0x06006638 RID: 26168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RuntimeAnimatorController GetArmsAnimatorControllerCommon()
		{
			throw null;
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06006639 RID: 26169 RVA: 0x00002050 File Offset: 0x00000250
		public ICharacterController CharacterController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ICharacterController GetCharacterControllerCommon()
		{
			throw null;
		}

		// Token: 0x0600663B RID: 26171 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TriggerColliderSearcher GetTriggerColliderSearcher()
		{
			throw null;
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x0600663C RID: 26172 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600663D RID: 26173 RVA: 0x00002050 File Offset: 0x00000250
		public MovementContext MovementContext
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x0600663E RID: 26174 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsResettingLook
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x0600663F RID: 26175 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsLooking
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06006640 RID: 26176 RVA: 0x00002050 File Offset: 0x00000250
		public bool MouseLookControl
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06006641 RID: 26177 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerPose Pose
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06006642 RID: 26178 RVA: 0x00002050 File Offset: 0x00000250
		public float PoseLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06006643 RID: 26179 RVA: 0x00002050 File Offset: 0x00000250
		public float Speed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06006644 RID: 26180 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006645 RID: 26181 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 Rotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06006646 RID: 26182 RVA: 0x00002050 File Offset: 0x00000250
		public float Yaw
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06006647 RID: 26183 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsInPronePose
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06006648 RID: 26184 RVA: 0x00002050 File Offset: 0x00000250
		public float Pitch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06006649 RID: 26185 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Velocity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x0600664A RID: 26186 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Motion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddMouseSensitivityModifier(Player.EMouseSensitivityModifier type, float value)
		{
			throw null;
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveMouseSensitivityModifier(Player.EMouseSensitivityModifier type)
		{
			throw null;
		}

		// Token: 0x0600664D RID: 26189 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600664E RID: 26190 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetRotationMultiplier()
		{
			throw null;
		}

		// Token: 0x0600664F RID: 26191 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetCharacterSpeedMultiplier()
		{
			throw null;
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06006650 RID: 26192 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006651 RID: 26193 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 RotationPitchLimit
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

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06006652 RID: 26194 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006653 RID: 26195 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 InputDirection
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

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06006654 RID: 26196 RVA: 0x00002050 File Offset: 0x00000250
		public BaseMovementState CurrentState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06006655 RID: 26197 RVA: 0x00002050 File Offset: 0x00000250
		public MovementState CurrentManagedState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06006656 RID: 26198 RVA: 0x00002050 File Offset: 0x00000250
		public int CurrentAnimatorStateIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06006657 RID: 26199 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006658 RID: 26200 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Position
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

		// Token: 0x06006659 RID: 26201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CreateMovementContext()
		{
			throw null;
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x0600665B RID: 26203 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x0600665C RID: 26204 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsForwardInputDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x0600665D RID: 26205 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsSprintEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_6(float dir)
		{
			throw null;
		}

		// Token: 0x0600665F RID: 26207 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_7(float fromDir)
		{
			throw null;
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(float dir)
		{
			throw null;
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SlowLean(float x)
		{
			throw null;
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleBlindFire(float blindFireValue)
		{
			throw null;
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopBlindFire()
		{
			throw null;
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleStep(int direction)
		{
			throw null;
		}

		// Token: 0x06006665 RID: 26213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReturnFromStep(int direction)
		{
			throw null;
		}

		// Token: 0x06006666 RID: 26214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(float fallHeight, float jumpHeight)
		{
			throw null;
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06006667 RID: 26215 RVA: 0x00002050 File Offset: 0x00000250
		private EFTHardSettings EFTHardSettings_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void LandingAdjustments(float d)
		{
			throw null;
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Move(Vector2 direction)
		{
			throw null;
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangePose(float poseDelta)
		{
			throw null;
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_10()
		{
			throw null;
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_11()
		{
			throw null;
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSpeed(float speedDelta)
		{
			throw null;
		}

		// Token: 0x0600666E RID: 26222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RaiseChangeSpeedEvent()
		{
			throw null;
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RaiseSightChangedEvent(SightComponent sightComp)
		{
			throw null;
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AddStateSpeedLimit(float speedDelta, Player.ESpeedLimit cause)
		{
			throw null;
		}

		// Token: 0x06006671 RID: 26225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateSpeedLimit(float speedDelta, Player.ESpeedLimit cause)
		{
			throw null;
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateSpeedLimit(float speedDelta, Player.ESpeedLimit cause, float duration)
		{
			throw null;
		}

		// Token: 0x06006673 RID: 26227 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RemoveStateSpeedLimit(Player.ESpeedLimit cause)
		{
			throw null;
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_12()
		{
			throw null;
		}

		// Token: 0x06006675 RID: 26229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_13()
		{
			throw null;
		}

		// Token: 0x06006676 RID: 26230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false)
		{
			throw null;
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06006677 RID: 26231 RVA: 0x00002050 File Offset: 0x00000250
		public float MovementIdlingTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06006678 RID: 26232 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Look(float deltaLookY, float deltaLookX, bool withReturn = true)
		{
			throw null;
		}

		// Token: 0x06006679 RID: 26233 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetLookDirection()
		{
			throw null;
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600667A RID: 26234 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsVaultingPressed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Jump()
		{
			throw null;
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Vaulting()
		{
			throw null;
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x0600667E RID: 26238 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableSprint(bool enable)
		{
			throw null;
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleSprint()
		{
			throw null;
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleHoldingBreath()
		{
			throw null;
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopHoldingBreath()
		{
			throw null;
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(float deltaTime)
		{
			throw null;
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HeightInterpolation(float timeDeltatime)
		{
			throw null;
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16()
		{
			throw null;
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ToggleProne()
		{
			throw null;
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_17()
		{
			throw null;
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_0(WorldInteractiveObject interactiveObject, InteractionResult interactionResult, Action callback)
		{
			throw null;
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_1(WorldInteractiveObject door, InteractionResult interactionResult)
		{
			throw null;
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void BtrInteraction(BTRSide btr, byte placeId, EInteractionType interaction)
		{
			throw null;
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_2(string itemId, string zoneId, bool successful)
		{
			throw null;
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void PlantItem(string itemId, string zoneId, bool successful)
		{
			throw null;
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlantItemLocalOnly(Item item, string zone)
		{
			throw null;
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x0600668D RID: 26253 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool OnHisWayToOperateStationaryWeapon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OperateStationaryWeapon(StationaryWeapon stationaryWeapon, GStruct168.EStationaryCommand command)
		{
			throw null;
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FastForwardToStationaryWeapon(Item item, Vector2 stationaryRotation, Quaternion playerRotation, Quaternion stationaryPlayerRotation)
		{
			throw null;
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Crutch_FinalizeStationaryWeapState(GStruct168 swPacket)
		{
			throw null;
		}

		// Token: 0x14000122 RID: 290
		// (add) Token: 0x06006691 RID: 26257 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006692 RID: 26258 RVA: 0x00002050 File Offset: 0x00000250
		public event Player.GDelegate55 OnDamageReceived
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

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06006693 RID: 26259 RVA: 0x00002050 File Offset: 0x00000250
		public bool OnScreen
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06006694 RID: 26260 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerBody PlayerBody
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06006695 RID: 26261 RVA: 0x00002050 File Offset: 0x00000250
		protected float HandsToBodyAngle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06006696 RID: 26262 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006697 RID: 26263 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasGamePlayerOwner
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

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06006698 RID: 26264 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006699 RID: 26265 RVA: 0x00002050 File Offset: 0x00000250
		public virtual EPointOfView PointOfView
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

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x0600669A RID: 26266 RVA: 0x00002050 File Offset: 0x00000250
		public bool FirstPersonPointOfView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x0600669B RID: 26267 RVA: 0x00002050 File Offset: 0x00000250
		public BindableEvent PointOfViewChanged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000123 RID: 291
		// (add) Token: 0x0600669C RID: 26268 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600669D RID: 26269 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<DamageInfo, EBodyPart, float> BeingHitAction
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

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x0600669E RID: 26270 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600669F RID: 26271 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 BeaconPosition
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

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x060066A0 RID: 26272 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066A1 RID: 26273 RVA: 0x00002050 File Offset: 0x00000250
		public Quaternion BeaconRotation
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

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x060066A2 RID: 26274 RVA: 0x00002050 File Offset: 0x00000250
		public float ErgonomicsPenalty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x060066A3 RID: 26275 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066A4 RID: 26276 RVA: 0x00002050 File Offset: 0x00000250
		public ObjectInHandsAnimator HandsAnimator
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

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x060066A5 RID: 26277 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066A6 RID: 26278 RVA: 0x00002050 File Offset: 0x00000250
		public GameObject CameraContainer
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

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x060066A7 RID: 26279 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066A8 RID: 26280 RVA: 0x00002050 File Offset: 0x00000250
		public Transform CameraPosition
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

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x060066A9 RID: 26281 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066AA RID: 26282 RVA: 0x00002050 File Offset: 0x00000250
		public ProceduralWeaponAnimation ProceduralWeaponAnimation
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

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x060066AB RID: 26283 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066AC RID: 26284 RVA: 0x00002050 File Offset: 0x00000250
		public bool AllowToPlantBeacon
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

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x060066AD RID: 26285 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 LookDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRadioTransmitterView(RadioTransmitterView rtView)
		{
			throw null;
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ReceiveDamage(float damage, EBodyPart part, EDamageType type, float absorbed, MaterialType special)
		{
			throw null;
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VisualPass()
		{
			throw null;
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void LateUpdate()
		{
			throw null;
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PropUpdate()
		{
			throw null;
		}

		// Token: 0x060066B3 RID: 26291 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateScaleValueByFov(float fov)
		{
			throw null;
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RestoreRibcageScale()
		{
			throw null;
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCompensationScale(bool force = false)
		{
			throw null;
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMakingShot([NotNull] GInterface320 weapon, Vector3 force)
		{
			throw null;
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator HitDelay(Action callback)
		{
			throw null;
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ShotReactions(DamageInfo shot, EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(EPointOfView pointOfView)
		{
			throw null;
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19(EPlayerState previousState, EPlayerState nextState)
		{
			throw null;
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnFovUpdatedEvent(int fov)
		{
			throw null;
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnHealthEffectVisualAdded(IEffect effect)
		{
			throw null;
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnHealthEffectVisualRemoved(IEffect effect)
		{
			throw null;
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnPlayerVisualDied(EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SubscribeVisualEvents()
		{
			throw null;
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnsubscribeVisualEvents()
		{
			throw null;
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x060066C1 RID: 26305 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform WeaponRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x060066C2 RID: 26306 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform Fireport
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x060066C3 RID: 26307 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform[] MultiBarrelFireports
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x060066C4 RID: 26308 RVA: 0x00002050 File Offset: 0x00000250
		public Quaternion HandsRotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchHeadLightsAnimation()
		{
			throw null;
		}

		// Token: 0x060066C6 RID: 26310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void MouseLook(bool forceApplyToOriginalRibcage = false)
		{
			throw null;
		}

		// Token: 0x060066C7 RID: 26311 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20()
		{
			throw null;
		}

		// Token: 0x060066C8 RID: 26312 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateLauncherBones(bool launcherEnable, WeaponPrefab weaponPrefab)
		{
			throw null;
		}

		// Token: 0x060066C9 RID: 26313 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFirstPersonGrip(GripPose.EGripType type = GripPose.EGripType.Common, TransformLinks transforms = null)
		{
			throw null;
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBonesOnWeaponChange(TransformLinks links)
		{
			throw null;
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FBBIKUpdate(float distance)
		{
			throw null;
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21(float d)
		{
			throw null;
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 ProjectLocalPosition(Vector3 position)
		{
			throw null;
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DropItemDead(Item item, GameObject prefab)
		{
			throw null;
		}

		// Token: 0x060066CF RID: 26319 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveAttachment(RigidbodySpawner spawner)
		{
			throw null;
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseHand()
		{
			throw null;
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SpawnInHands(Item item, string parentBone)
		{
			throw null;
		}

		// Token: 0x060066D2 RID: 26322 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameObject CreateBeacon(Item item, Vector3 position)
		{
			throw null;
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyBeacon()
		{
			throw null;
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearHands()
		{
			throw null;
		}

		// Token: 0x060066D5 RID: 26325 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RestoreIKPos()
		{
			throw null;
		}

		// Token: 0x060066D6 RID: 26326 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IkStoreRaw()
		{
			throw null;
		}

		// Token: 0x060066D7 RID: 26327 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22(float distance2Camera)
		{
			throw null;
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected RuntimeAnimatorController CreateAnimatorController()
		{
			throw null;
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_23()
		{
			throw null;
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_24()
		{
			throw null;
		}

		// Token: 0x060066DB RID: 26331 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool UpdateGrenadeAnimatorDuePoV()
		{
			throw null;
		}

		// Token: 0x060066DC RID: 26332 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnvironment(string profileID, EnvironmentType environmentType)
		{
			throw null;
		}

		// Token: 0x060066DD RID: 26333 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_25(float distance)
		{
			throw null;
		}

		// Token: 0x060066DE RID: 26334 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_26(float curveWeight)
		{
			throw null;
		}

		// Token: 0x060066DF RID: 26335 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_27(int hash)
		{
			throw null;
		}

		// Token: 0x060066E0 RID: 26336 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_28()
		{
			throw null;
		}

		// Token: 0x060066E1 RID: 26337 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreateCompass()
		{
			throw null;
		}

		// Token: 0x060066E2 RID: 26338 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_29(GameObject obj)
		{
			throw null;
		}

		// Token: 0x060066E3 RID: 26339 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPropVisibility(bool isVisible)
		{
			throw null;
		}

		// Token: 0x060066E4 RID: 26340 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRadiolocationZoneEnter()
		{
			throw null;
		}

		// Token: 0x060066E5 RID: 26341 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRadiolocationZoneExit()
		{
			throw null;
		}

		// Token: 0x060066E6 RID: 26342 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool IsVisibleByCullingObject(float cullingDistance)
		{
			throw null;
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x060066E7 RID: 26343 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066E8 RID: 26344 RVA: 0x00002050 File Offset: 0x00000250
		public EnvironmentType Environment
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

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x060066E9 RID: 26345 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual float LandingThreshold
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x060066EA RID: 26346 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066EB RID: 26347 RVA: 0x00002050 File Offset: 0x00000250
		public AudioSource VoipAudioSource
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

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x060066EC RID: 26348 RVA: 0x00002050 File Offset: 0x00000250
		public ETagStatus Fraction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x060066ED RID: 26349 RVA: 0x00002050 File Offset: 0x00000250
		public float SinceLastStep
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x060066EE RID: 26350 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float ProtagonistHearing
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x060066EF RID: 26351 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual float Distance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x060066F0 RID: 26352 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066F1 RID: 26353 RVA: 0x00002050 File Offset: 0x00000250
		protected BetterSource SpeechSource
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

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x060066F2 RID: 26354 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsUnderRoof
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InitAudioController()
		{
			throw null;
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_30()
		{
			throw null;
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitVaultingAudioControllers(IVaultingParameters vaultingParams)
		{
			throw null;
		}

		// Token: 0x060066F6 RID: 26358 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_31()
		{
			throw null;
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void PlayToggleSound(ref bool previousState, bool isOn, AudioClip toggleOn, AudioClip toggleOff)
		{
			throw null;
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlaySwitchHeadlightSound()
		{
			throw null;
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayFaceShieldSound()
		{
			throw null;
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayNightVisionSound()
		{
			throw null;
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayThermalVisionSound()
		{
			throw null;
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetAudioProtagonist()
		{
			throw null;
		}

		// Token: 0x060066FD RID: 26365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddVolume(BetterPropagationVolume volume)
		{
			throw null;
		}

		// Token: 0x060066FE RID: 26366 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveVolume(BetterPropagationVolume volume)
		{
			throw null;
		}

		// Token: 0x060066FF RID: 26367 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BetterPropagationVolume> GetPropagationVolume()
		{
			throw null;
		}

		// Token: 0x06006700 RID: 26368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleMuteSpeechSource(bool muteSpeech)
		{
			throw null;
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlaySpeechFromTime(TaggedClip clip, float time)
		{
			throw null;
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_32(TaggedClip clip)
		{
			throw null;
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateOcclusion()
		{
			throw null;
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool CheckSurface()
		{
			throw null;
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_33()
		{
			throw null;
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_34()
		{
			throw null;
		}

		// Token: 0x06006707 RID: 26375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateBreathStatus()
		{
			throw null;
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnSpeakerRelease(bool force)
		{
			throw null;
		}

		// Token: 0x06006709 RID: 26377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_35()
		{
			throw null;
		}

		// Token: 0x0600670A RID: 26378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_36()
		{
			throw null;
		}

		// Token: 0x0600670B RID: 26379 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_37()
		{
			throw null;
		}

		// Token: 0x0600670C RID: 26380 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_38(FaceShieldComponent fs, EquipmentSlot equipmentSlot)
		{
			throw null;
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SendVoiceMuffledState(bool isMuffled)
		{
			throw null;
		}

		// Token: 0x0600670E RID: 26382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InitAudioSources()
		{
			throw null;
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CreateNestedSource()
		{
			throw null;
		}

		// Token: 0x06006710 RID: 26384 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CreateSpeechSource()
		{
			throw null;
		}

		// Token: 0x06006711 RID: 26385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateStepSoundRolloff()
		{
			throw null;
		}

		// Token: 0x06006712 RID: 26386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator SupportAudioSourceCoroutine()
		{
			throw null;
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_39(int count)
		{
			throw null;
		}

		// Token: 0x06006714 RID: 26388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private BetterSource method_40(AudioClip clip)
		{
			throw null;
		}

		// Token: 0x06006715 RID: 26389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseSearchSource()
		{
			throw null;
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void PlayGroundedSound(float fallHeight, float jumpHeight)
		{
			throw null;
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_41()
		{
			throw null;
		}

		// Token: 0x06006718 RID: 26392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_42()
		{
			throw null;
		}

		// Token: 0x06006719 RID: 26393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_43(EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_44(EPlayerState previousState, EPlayerState nextstate)
		{
			throw null;
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DefaultPlay(SoundBank bank, float volume = 1f, string signature = "", EAudioMovementState movementState = EAudioMovementState.None)
		{
			throw null;
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayStepSound()
		{
			throw null;
		}

		// Token: 0x0600671D RID: 26397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_45()
		{
			throw null;
		}

		// Token: 0x0600671E RID: 26398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_46(float volume = 1f)
		{
			throw null;
		}

		// Token: 0x0600671F RID: 26399 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_47(float speed = 55f)
		{
			throw null;
		}

		// Token: 0x06006720 RID: 26400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlaySoundBank(string soundBank)
		{
			throw null;
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_48(float v = 1f)
		{
			throw null;
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_49()
		{
			throw null;
		}

		// Token: 0x06006723 RID: 26403 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_50()
		{
			throw null;
		}

		// Token: 0x06006724 RID: 26404 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_51()
		{
			throw null;
		}

		// Token: 0x06006725 RID: 26405 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_52(EBodyPart bodyPart, float damage, DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x06006726 RID: 26406 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ValueTuple<bool, BaseBallistic.ESurfaceSound> method_53()
		{
			throw null;
		}

		// Token: 0x06006727 RID: 26407 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_54(bool hit, BaseBallistic.ESurfaceSound surfaceSound)
		{
			throw null;
		}

		// Token: 0x06006728 RID: 26408 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SendUnderRoofStatus(bool isUnderRoof)
		{
			throw null;
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06006729 RID: 26409 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600672A RID: 26410 RVA: 0x00002050 File Offset: 0x00000250
		public bool IgnoreCameraCollider
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

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x0600672B RID: 26411 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600672C RID: 26412 RVA: 0x00002050 File Offset: 0x00000250
		public BTRSide BtrInteractionSide
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

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x0600672D RID: 26413 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600672E RID: 26414 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerBtrState BtrState
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

		// Token: 0x14000124 RID: 292
		// (add) Token: 0x0600672F RID: 26415 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006730 RID: 26416 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<EPlayerBtrState> OnBtrStateChanged
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

		// Token: 0x06006731 RID: 26417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void BtrInteraction()
		{
			throw null;
		}

		// Token: 0x06006732 RID: 26418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_55()
		{
			throw null;
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06006733 RID: 26419 RVA: 0x00002050 File Offset: 0x00000250
		string IDissonancePlayer.PlayerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06006734 RID: 26420 RVA: 0x00002050 File Offset: 0x00000250
		Vector3 IDissonancePlayer.Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06006735 RID: 26421 RVA: 0x00002050 File Offset: 0x00000250
		Quaternion IDissonancePlayer.Rotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06006736 RID: 26422 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006737 RID: 26423 RVA: 0x00002050 File Offset: 0x00000250
		public IPlayerVoipController VoipController
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06006738 RID: 26424 RVA: 0x00002050 File Offset: 0x00000250
		NetworkPlayerType IDissonancePlayer.Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06006739 RID: 26425 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsTracking
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x0600673A RID: 26426 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600673B RID: 26427 RVA: 0x00002050 File Offset: 0x00000250
		private DissonanceComms DissonanceComms
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

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x0600673C RID: 26428 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600673D RID: 26429 RVA: 0x00002050 File Offset: 0x00000250
		protected DateTime HearingDateTime
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

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x0600673E RID: 26430 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600673F RID: 26431 RVA: 0x00002050 File Offset: 0x00000250
		protected Player.EVoipState VoipState
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

		// Token: 0x06006740 RID: 26432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InitVoip(Player.EVoipState voipState)
		{
			throw null;
		}

		// Token: 0x06006741 RID: 26433 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_56()
		{
			throw null;
		}

		// Token: 0x06006742 RID: 26434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TrackPlayerPosition()
		{
			throw null;
		}

		// Token: 0x06006743 RID: 26435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueTuple<bool, bool> IsHeard(in Vector3 voicePos, float sqrDistance)
		{
			throw null;
		}

		// Token: 0x06006744 RID: 26436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_57(in Vector3 voicePos, float sqrDistance)
		{
			throw null;
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06006745 RID: 26437 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool CanBeSnapped
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06006746 RID: 26438 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006747 RID: 26439 RVA: 0x00002050 File Offset: 0x00000250
		public Player.EProcessStatus ProcessStatus
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

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06006748 RID: 26440 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006749 RID: 26441 RVA: 0x00002050 File Offset: 0x00000250
		private Player.AbstractProcess AbstractProcess_0
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

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x0600674A RID: 26442 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600674B RID: 26443 RVA: 0x00002050 File Offset: 0x00000250
		public Slot ActiveSlot
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

		// Token: 0x14000125 RID: 293
		// (add) Token: 0x0600674C RID: 26444 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600674D RID: 26445 RVA: 0x00002050 File Offset: 0x00000250
		public event Action HandsChangingEvent
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

		// Token: 0x14000126 RID: 294
		// (add) Token: 0x0600674E RID: 26446 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600674F RID: 26447 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<GInterface123> HandsChangedEvent
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

		// Token: 0x06006750 RID: 26448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_58()
		{
			throw null;
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06006751 RID: 26449 RVA: 0x00002050 File Offset: 0x00000250
		public bool StateIsSuitableForHandInput
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06006752 RID: 26450 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006753 RID: 26451 RVA: 0x00002050 File Offset: 0x00000250
		public Item LastEquippedWeaponOrKnifeItem
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

		// Token: 0x06006754 RID: 26452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_59(GInterface123 controller)
		{
			throw null;
		}

		// Token: 0x06006755 RID: 26453 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task SpawnController(Player.AbstractHandsController controller, Action callback = null)
		{
			throw null;
		}

		// Token: 0x06006756 RID: 26454 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FastForwardCurrentOperations()
		{
			throw null;
		}

		// Token: 0x06006757 RID: 26455 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void DestroyController()
		{
			throw null;
		}

		// Token: 0x06006758 RID: 26456 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void DropCurrentController(Action callback, bool fastDrop, Item nextControllerItem = null)
		{
			throw null;
		}

		// Token: 0x06006759 RID: 26457 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TrySaveLastItemInHands()
		{
			throw null;
		}

		// Token: 0x0600675A RID: 26458 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmptyHands(Callback<GInterface125> callback)
		{
			throw null;
		}

		// Token: 0x0600675B RID: 26459 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStationaryWeapon(Weapon weapon)
		{
			throw null;
		}

		// Token: 0x0600675C RID: 26460 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInHands(Weapon weapon, Callback<IFirearmHandsController> callback)
		{
			throw null;
		}

		// Token: 0x0600675D RID: 26461 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInHands(GrenadeClass throwWeap, Callback<IHandsController> callback)
		{
			throw null;
		}

		// Token: 0x0600675E RID: 26462 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInHands(MedsClass meds, EBodyPart bodyPart, int animationVariant, Callback<GInterface130> callback)
		{
			throw null;
		}

		// Token: 0x0600675F RID: 26463 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInHands(FoodClass foodDrink, float amount, int animationVariant, Callback<GInterface130> callback)
		{
			throw null;
		}

		// Token: 0x06006760 RID: 26464 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInHands(KnifeComponent knife, Callback<IKnifeController> callback)
		{
			throw null;
		}

		// Token: 0x06006761 RID: 26465 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInHandsUsableItem(Item item, Callback<GInterface129> callback)
		{
			throw null;
		}

		// Token: 0x06006762 RID: 26466 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInHandsForQuickUse(Item quickUseItem, Callback<GInterface135> callback)
		{
			throw null;
		}

		// Token: 0x06006763 RID: 26467 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInHandsForQuickUse(GrenadeClass throwWeap, Callback<IGrenadeController> callback)
		{
			throw null;
		}

		// Token: 0x06006764 RID: 26468 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInHandsForQuickUse(KnifeComponent knife, Callback<GInterface134> callback)
		{
			throw null;
		}

		// Token: 0x06006765 RID: 26469 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_60(bool enable)
		{
			throw null;
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TrySetLastEquippedWeapon(bool equipFirstAvaliableOnFail = true)
		{
			throw null;
		}

		// Token: 0x06006767 RID: 26471 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFirstAvailableItem(Callback<GInterface123> completeCallback)
		{
			throw null;
		}

		// Token: 0x06006768 RID: 26472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_61(Item itemToCheck)
		{
			throw null;
		}

		// Token: 0x06006769 RID: 26473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInHands(Item item, Callback<GInterface123> callback)
		{
			throw null;
		}

		// Token: 0x0600676A RID: 26474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetQuickSlotItem(EBoundItem quickSlot, Callback<GInterface123> callback)
		{
			throw null;
		}

		// Token: 0x0600676B RID: 26475 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotItem(EquipmentSlot equipmentSlot, Callback<GInterface123> callback)
		{
			throw null;
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DropBackpack()
		{
			throw null;
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetItemInHands(Item item, Callback<GInterface123> callback)
		{
			throw null;
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_62(EquipmentSlot slot)
		{
			throw null;
		}

		// Token: 0x0600676F RID: 26479 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_63(EBoundItem slot)
		{
			throw null;
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Interact(IItemOwner loot, Callback callback)
		{
			throw null;
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Proceed(bool withNetwork, Callback<GInterface125> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Proceed(Weapon weapon, Callback<IFirearmHandsController> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Proceed(GrenadeClass throwWeap, Callback<IHandsController> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x06006774 RID: 26484 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Proceed(MedsClass meds, EBodyPart bodyPart, Callback<GInterface130> callback, int animationVariant, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Proceed(FoodClass foodDrink, float amount, Callback<GInterface130> callback, int animationVariant, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Proceed(KnifeComponent knife, Callback<IKnifeController> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x06006777 RID: 26487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void Proceed<T>(Item item, Callback<GInterface129> callback, bool scheduled = true) where T : Player.UsableItemController
		{
			throw null;
		}

		// Token: 0x06006778 RID: 26488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Proceed(Item item, Callback<GInterface135> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Proceed(GrenadeClass throwWeap, Callback<IGrenadeController> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x0600677A RID: 26490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Proceed(KnifeComponent knife, Callback<GInterface134> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TryProceed(Item item, Callback<GInterface123> completeCallback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_64(GClass2729 item, Callback<GInterface123> completeCallback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_65(RecodableItemClass item, Callback<GInterface123> completeCallback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0<T>(Result<T> result, Callback<GInterface123> callback) where T : GInterface123
		{
			throw null;
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_66(Item item)
		{
			throw null;
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool CanPerformAnimatedOperation(Item item, GClass2833 operation)
		{
			throw null;
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TryRemoveFromHands(Item item, GInterface336 abstractOperation, Callback callback)
		{
			throw null;
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetControllerInsteadRemovedOne(Item removingItem, Callback callback)
		{
			throw null;
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TrySetInHands(Item item, ItemAddress to, GInterface336 operation, Callback originalCallback)
		{
			throw null;
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator FakeCallbackCoroutine()
		{
			throw null;
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void FaceshieldMarkOperation(FaceShieldComponent armor, bool hasServerOrigin)
		{
			throw null;
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected IContainer FindContainer(GStruct366 containerId, IItemOwner owner = null)
		{
			throw null;
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06006787 RID: 26503 RVA: 0x00002050 File Offset: 0x00000250
		protected string VisitorId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Player.Class1058 method_67(Item item)
		{
			throw null;
		}

		// Token: 0x06006789 RID: 26505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Player.Class1059 method_68(Item item)
		{
			throw null;
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct413<Player.GClass1627> ThrowGrenade(GrenadeClass grenade, bool lowThrow, bool simulate)
		{
			throw null;
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x0600678B RID: 26507 RVA: 0x00002050 File Offset: 0x00000250
		public static NetworkHash128 NetworkTypeId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x0600678C RID: 26508 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600678D RID: 26509 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000127 RID: 295
		// (add) Token: 0x0600678E RID: 26510 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600678F RID: 26511 RVA: 0x00002050 File Offset: 0x00000250
		public event GDelegate61 OnPlayerDead
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

		// Token: 0x14000128 RID: 296
		// (add) Token: 0x06006790 RID: 26512 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006791 RID: 26513 RVA: 0x00002050 File Offset: 0x00000250
		public static event Action<Player, IPlayer, DamageInfo, EBodyPart> OnPlayerDeadStatic
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

		// Token: 0x14000129 RID: 297
		// (add) Token: 0x06006792 RID: 26514 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006793 RID: 26515 RVA: 0x00002050 File Offset: 0x00000250
		public event GDelegate62 OnPlayerDeadOrUnspawn
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

		// Token: 0x1400012A RID: 298
		// (add) Token: 0x06006794 RID: 26516 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006795 RID: 26517 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool> OnSenseChanged
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

		// Token: 0x1400012B RID: 299
		// (add) Token: 0x06006796 RID: 26518 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006797 RID: 26519 RVA: 0x00002050 File Offset: 0x00000250
		public event Action PossibleInteractionsChanged
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

		// Token: 0x1400012C RID: 300
		// (add) Token: 0x06006798 RID: 26520 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006799 RID: 26521 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<EPhraseTrigger, int> PhraseSituation
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

		// Token: 0x1400012D RID: 301
		// (add) Token: 0x0600679A RID: 26522 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600679B RID: 26523 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool> OnGlassesChanged
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

		// Token: 0x1400012E RID: 302
		// (add) Token: 0x0600679C RID: 26524 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600679D RID: 26525 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Player, bool> OnInventoryOpened
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

		// Token: 0x1400012F RID: 303
		// (add) Token: 0x0600679E RID: 26526 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600679F RID: 26527 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnStartQuickdrawPistol
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

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x060067A0 RID: 26528 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067A1 RID: 26529 RVA: 0x00002050 File Offset: 0x00000250
		public GenericEventTranslator EventTranslator
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

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x060067A2 RID: 26530 RVA: 0x00002050 File Offset: 0x00000250
		public IVaultingComponent VaultingComponent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x060067A3 RID: 26531 RVA: 0x00002050 File Offset: 0x00000250
		public IVaultingComponentDebug VaultingComponentDebug
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x060067A4 RID: 26532 RVA: 0x00002050 File Offset: 0x00000250
		public IVaultingParameters VaultingParameters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x060067A5 RID: 26533 RVA: 0x00002050 File Offset: 0x00000250
		public IVaultingGameplayRestrictions VaultingGameplayRestrictions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x060067A6 RID: 26534 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsEnableVaulting
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x060067A7 RID: 26535 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067A8 RID: 26536 RVA: 0x00002050 File Offset: 0x00000250
		public Player.GClass1628<NightVisionComponent> NightVisionObserver
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x060067A9 RID: 26537 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067AA RID: 26538 RVA: 0x00002050 File Offset: 0x00000250
		public Player.GClass1628<ThermalVisionComponent> ThermalVisionObserver
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x060067AB RID: 26539 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067AC RID: 26540 RVA: 0x00002050 File Offset: 0x00000250
		public Player.GClass1628<FaceShieldComponent> FaceShieldObserver
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x060067AD RID: 26541 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067AE RID: 26542 RVA: 0x00002050 File Offset: 0x00000250
		public Player.GClass1628<FaceShieldComponent> FaceCoverObserver
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x060067AF RID: 26543 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067B0 RID: 26544 RVA: 0x00002050 File Offset: 0x00000250
		public string Location
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

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x060067B1 RID: 26545 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067B2 RID: 26546 RVA: 0x00002050 File Offset: 0x00000250
		public ISpawnPoint SpawnPoint
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

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x060067B3 RID: 26547 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067B4 RID: 26548 RVA: 0x00002050 File Offset: 0x00000250
		public float RayLength
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

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x060067B5 RID: 26549 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067B6 RID: 26550 RVA: 0x00002050 File Offset: 0x00000250
		public InteractableObject InteractableObject
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

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x060067B7 RID: 26551 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067B8 RID: 26552 RVA: 0x00002050 File Offset: 0x00000250
		public bool InteractableObjectIsProxy
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

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x060067B9 RID: 26553 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067BA RID: 26554 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAgressorInLighthouseTraderZone
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

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x060067BB RID: 26555 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067BC RID: 26556 RVA: 0x00002050 File Offset: 0x00000250
		public Player InteractablePlayer
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

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x060067BD RID: 26557 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067BE RID: 26558 RVA: 0x00002050 File Offset: 0x00000250
		public PlaceItemTrigger PlaceItemZone
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

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x060067BF RID: 26559 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067C0 RID: 26560 RVA: 0x00002050 File Offset: 0x00000250
		public ExfiltrationPoint ExfiltrationPoint
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

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x060067C1 RID: 26561 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067C2 RID: 26562 RVA: 0x00002050 File Offset: 0x00000250
		public bool ExitTriggerZone
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

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x060067C3 RID: 26563 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067C4 RID: 26564 RVA: 0x00002050 File Offset: 0x00000250
		public MalfunctionRandom MalfRandoms
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x060067C5 RID: 26565 RVA: 0x00002050 File Offset: 0x00000250
		public string Infiltration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x060067C6 RID: 26566 RVA: 0x00002050 File Offset: 0x00000250
		public string GroupId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x060067C7 RID: 26567 RVA: 0x00002050 File Offset: 0x00000250
		public string TeamId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x060067C8 RID: 26568 RVA: 0x00002050 File Offset: 0x00000250
		public float CarryingWeightRelativeModifier
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x060067C9 RID: 26569 RVA: 0x00002050 File Offset: 0x00000250
		public float CarryingWeightAbsoluteModifier
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x060067CA RID: 26570 RVA: 0x00002050 File Offset: 0x00000250
		protected Inventory Inventory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x060067CB RID: 26571 RVA: 0x00002050 File Offset: 0x00000250
		protected EquipmentClass Equipment
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x060067CC RID: 26572 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsInventoryOpened
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x060067CD RID: 26573 RVA: 0x00002050 File Offset: 0x00000250
		public RecodableItemsHandler RecodableItemsHandler
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x060067CE RID: 26574 RVA: 0x00002050 File Offset: 0x00000250
		public float BlindnessDuration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x060067CF RID: 26575 RVA: 0x00002050 File Offset: 0x00000250
		public int CurrentHour
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x060067D1 RID: 26577 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067D0 RID: 26576 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
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

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x060067D2 RID: 26578 RVA: 0x00002050 File Offset: 0x00000250
		public string KillerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x060067D3 RID: 26579 RVA: 0x00002050 File Offset: 0x00000250
		public string KillerAccountId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x060067D4 RID: 26580 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasGlasses
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x060067D5 RID: 26581 RVA: 0x00002050 File Offset: 0x00000250
		public bool HandsIsEmpty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x060067D6 RID: 26582 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsWeaponOrKnifeInHands
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static TPlayer Create<TPlayer>(ResourceKey assetName, int playerId, Vector3 position, EUpdateQueue updateQueue, Player.EUpdateMode armsUpdateMode, Player.EUpdateMode bodyUpdateMode, CharacterControllerSpawner.Mode characterControllerMode, Func<float> getSensitivity, Func<float> getAimingSensitivity, string prefix, bool isThirdPerson) where TPlayer : Player
		{
			throw null;
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static T smethod_1<T>(GameObject poolObject, Animator animator, int playerId, Vector3 position, EUpdateQueue updateQueue, Player.EUpdateMode armsUpdateMode, Player.EUpdateMode bodyUpdateMode, CharacterControllerSpawner.Mode characterControllerMode, Func<float> getSensitivity, Func<float> getAimingSensitivity, bool isThirdPerson) where T : Player
		{
			throw null;
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual GClass678 CreatePhysical()
		{
			throw null;
		}

		// Token: 0x060067DA RID: 26586 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void CreateBodyAnimator(Animator animator, EUpdateQueue updateQueue)
		{
			throw null;
		}

		// Token: 0x060067DB RID: 26587 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_69()
		{
			throw null;
		}

		// Token: 0x060067DC RID: 26588 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task Init(Quaternion rotation, string layerName, EPointOfView pointOfView, Profile profile, InventoryControllerClass inventoryController, IHealthController healthController, IStatisticsManager statisticsManager, AbstractQuestControllerClass questController, AbstractAchievementControllerClass achievementsController, GInterface99 filter, Player.EVoipState voipState, bool aiControlled = false, bool async = true)
		{
			throw null;
		}

		// Token: 0x060067DD RID: 26589 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_70()
		{
			throw null;
		}

		// Token: 0x060067DE RID: 26590 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CreateSlotObservers()
		{
			throw null;
		}

		// Token: 0x060067DF RID: 26591 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InitialProfileExamineAll()
		{
			throw null;
		}

		// Token: 0x060067E0 RID: 26592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_71(EBodyPart arg1, ValueStruct arg2)
		{
			throw null;
		}

		// Token: 0x060067E1 RID: 26593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_72(EBodyPart arg1, EDamageType arg2)
		{
			throw null;
		}

		// Token: 0x060067E2 RID: 26594 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BindSlotViewChangedAction(EquipmentSlot slot, Action<GameObject> action)
		{
			throw null;
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_73(GameObject _)
		{
			throw null;
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Say(EPhraseTrigger @event, bool demand = false, float delay = 0f, ETagStatus mask = (ETagStatus)0, int probability = 100, bool aggressive = false)
		{
			throw null;
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void NeedRepairMalfPhraseSituation(Weapon.EMalfunctionState malfState, bool isKnown)
		{
			throw null;
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x060067E6 RID: 26598 RVA: 0x00002050 File Offset: 0x00000250
		public virtual Vector3 LocalShotDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnPhraseTold(EPhraseTrigger @event, TaggedClip clip, TagBank bank, GClass1804 speaker)
		{
			throw null;
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x060067E8 RID: 26600 RVA: 0x00002050 File Offset: 0x00000250
		public ETagStatus HealthStatus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
			throw null;
		}

		// Token: 0x060067EA RID: 26602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060067EB RID: 26603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void TraderStandingHandler(Profile.TraderInfo traderInfo)
		{
			throw null;
		}

		// Token: 0x060067EC RID: 26604 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnInteractWithLightHouseTraderZone(GStruct383[] AllowedPlayers, GStruct383[] UnallowedPlayers)
		{
			throw null;
		}

		// Token: 0x060067ED RID: 26605 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnLighthouseTraderZoneDebugToolSwitch(bool active)
		{
			throw null;
		}

		// Token: 0x060067EE RID: 26606 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ShowStringNotification(string message)
		{
			throw null;
		}

		// Token: 0x060067EF RID: 26607 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_74(EBodyPart bodyPart, float diff, DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateArmsCondition()
		{
			throw null;
		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnChangeRadioTransmitterState(bool isEncoded, RadioTransmitterStatus status, bool isAgressor)
		{
			throw null;
		}

		// Token: 0x060067F2 RID: 26610 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnHealthEffectAdded(IEffect effect)
		{
			throw null;
		}

		// Token: 0x060067F3 RID: 26611 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnHealthEffectRemoved(IEffect effect)
		{
			throw null;
		}

		// Token: 0x060067F4 RID: 26612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateSpeedLimitByHealth()
		{
			throw null;
		}

		// Token: 0x060067F5 RID: 26613 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemRemoved(GEventArgs3 eventArgs)
		{
			throw null;
		}

		// Token: 0x060067F6 RID: 26614 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSetInHands(GEventArgs10 eventArgs)
		{
			throw null;
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemAdded(GEventArgs2 eventArgs)
		{
			throw null;
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchHeadLights(bool togglesActive, bool changesState)
		{
			throw null;
		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SendHeadlightsPacket(bool isSilent)
		{
			throw null;
		}

		// Token: 0x060067FA RID: 26618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SendWeaponLightPacket()
		{
			throw null;
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdatePhonesReally()
		{
			throw null;
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdatePhones()
		{
			throw null;
		}

		// Token: 0x060067FD RID: 26621 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnItemAddedOrRemoved(Item item, ItemAddress location, bool added)
		{
			throw null;
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x060067FE RID: 26622 RVA: 0x00002050 File Offset: 0x00000250
		public string TryGetId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x060067FF RID: 26623 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006800 RID: 26624 RVA: 0x00002050 File Offset: 0x00000250
		public int PlayerId
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

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06006801 RID: 26625 RVA: 0x00002050 File Offset: 0x00000250
		public string ProfileId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06006802 RID: 26626 RVA: 0x00002050 File Offset: 0x00000250
		public string AccountId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06006803 RID: 26627 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006804 RID: 26628 RVA: 0x00002050 File Offset: 0x00000250
		public Profile Profile
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

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06006805 RID: 26629 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006806 RID: 26630 RVA: 0x00002050 File Offset: 0x00000250
		public IStatisticsManager StatisticsManager
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06006807 RID: 26631 RVA: 0x00002050 File Offset: 0x00000250
		public SkillManager Skills
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000130 RID: 304
		// (add) Token: 0x06006808 RID: 26632 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006809 RID: 26633 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<string, int> OnSpecialPlaceVisited
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

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x0600680A RID: 26634 RVA: 0x00002050 File Offset: 0x00000250
		public EUpdateQueue UpdateQueue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x0600680B RID: 26635 RVA: 0x00002050 File Offset: 0x00000250
		public EUpdateQueue ArmsUpdateQueue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x0600680C RID: 26636 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600680D RID: 26637 RVA: 0x00002050 File Offset: 0x00000250
		public ECameraType VisibleToCameraType
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

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x0600680E RID: 26638 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600680F RID: 26639 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsVisibleToCamera
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

		// Token: 0x06006810 RID: 26640 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ECameraType GetVisibleToCamera(IPlayer player)
		{
			throw null;
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06006811 RID: 26641 RVA: 0x00002050 File Offset: 0x00000250
		public EUpdateQueue PhysicalUpdateQueue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06006812 RID: 26642 RVA: 0x00002050 File Offset: 0x00000250
		public Player.EUpdateMode ArmsUpdateMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06006813 RID: 26643 RVA: 0x00002050 File Offset: 0x00000250
		public Player.EUpdateMode BodyUpdateMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06006814 RID: 26644 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TItem TryGetItemInHands<TItem>() where TItem : Item
		{
			throw null;
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06006815 RID: 26645 RVA: 0x00002050 File Offset: 0x00000250
		public Player GetPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06006816 RID: 26646 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006817 RID: 26647 RVA: 0x00002050 File Offset: 0x00000250
		public AIData AIData
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06006818 RID: 26648 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006819 RID: 26649 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerLoyaltyData Loyalty
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x0600681A RID: 26650 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAI
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDeserializeFromServer(byte channelId, GInterface76 reader)
		{
			throw null;
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RadioTransmitterRecodableComponent FindRadioTransmitter()
		{
			throw null;
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass2712 FindCultistAmulet()
		{
			throw null;
		}

		// Token: 0x14000131 RID: 305
		// (add) Token: 0x0600681E RID: 26654 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600681F RID: 26655 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06006820 RID: 26656 RVA: 0x00002050 File Offset: 0x00000250
		public virtual byte ChannelIndex
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06006821 RID: 26657 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006822 RID: 26658 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x14000132 RID: 306
		// (add) Token: 0x06006823 RID: 26659 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006824 RID: 26660 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Player.AbstractHandsController, Player.AbstractHandsController> OnHandsControllerChanged
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

		// Token: 0x06006825 RID: 26661 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasFirearmInHands()
		{
			throw null;
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06006826 RID: 26662 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006827 RID: 26663 RVA: 0x00002050 File Offset: 0x00000250
		public virtual Player.AbstractHandsController HandsController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PlayerAnimator.EWeaponAnimationType GetWeaponAnimationType(Player.AbstractHandsController handsController)
		{
			throw null;
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06006829 RID: 26665 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerState CurrentStateName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x0600682A RID: 26666 RVA: 0x00002050 File Offset: 0x00000250
		internal virtual InventoryControllerClass GClass2757_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x0600682B RID: 26667 RVA: 0x00002050 File Offset: 0x00000250
		internal AbstractQuestControllerClass GClass3203_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x0600682C RID: 26668 RVA: 0x00002050 File Offset: 0x00000250
		internal AbstractAchievementControllerClass GClass3207_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x0600682D RID: 26669 RVA: 0x00002050 File Offset: 0x00000250
		public int Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x0600682E RID: 26670 RVA: 0x00002050 File Offset: 0x00000250
		public string FullIdInfoClean
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x0600682F RID: 26671 RVA: 0x00002050 File Offset: 0x00000250
		public virtual string FullIdInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06006830 RID: 26672 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerSide Side
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06006831 RID: 26673 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform Transform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06006832 RID: 26674 RVA: 0x00002050 File Offset: 0x00000250
		public IHealthController HealthController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06006833 RID: 26675 RVA: 0x00002050 File Offset: 0x00000250
		public ActiveHealthController ActiveHealthController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06006834 RID: 26676 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerHealthController PlayerHealthController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06006835 RID: 26677 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006836 RID: 26678 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float Awareness
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

		// Token: 0x06006837 RID: 26679 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDeltaTimeDelegate(Player.GDelegate56 deltaTimeDelegate)
		{
			throw null;
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06006838 RID: 26680 RVA: 0x00002050 File Offset: 0x00000250
		public float DeltaTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void FixedUpdateTick()
		{
			throw null;
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AfterMainTick()
		{
			throw null;
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateTick()
		{
			throw null;
		}

		// Token: 0x0600683D RID: 26685 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_75()
		{
			throw null;
		}

		// Token: 0x14000133 RID: 307
		// (add) Token: 0x0600683E RID: 26686 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600683F RID: 26687 RVA: 0x00002050 File Offset: 0x00000250
		public event Action UpdateEvent
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

		// Token: 0x14000134 RID: 308
		// (add) Token: 0x06006840 RID: 26688 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006841 RID: 26689 RVA: 0x00002050 File Offset: 0x00000250
		public event Action FixedUpdateEvent
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

		// Token: 0x06006842 RID: 26690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ComplexUpdate(EUpdateQueue queue, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ComplexLateUpdate(EUpdateQueue queue, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ArmsUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void BodyUpdate(float deltaTime, int loop = 1)
		{
			throw null;
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ManualUpdate(float deltaTime, float? platformDeltaTime = null, int loop = 1)
		{
			throw null;
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void HealthControllerUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateTriggerColliderSearcher(float deltaTime, bool isCloseToCamera = true)
		{
			throw null;
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_76(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOwnerToAIData(BotOwner bot)
		{
			throw null;
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x0600684B RID: 26699 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual Ray InteractionRay
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x0600684C RID: 26700 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600684D RID: 26701 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 InteractionRayOriginOnStartOperation
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

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x0600684E RID: 26702 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600684F RID: 26703 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 InteractionRayDirectionOnStartOperation
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

		// Token: 0x06006850 RID: 26704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveInteractionRayInfo()
		{
			throw null;
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void InteractionRaycast()
		{
			throw null;
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PauseAllEffectsOnPlayer()
		{
			throw null;
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UnpauseAllEffectsOnPlayer()
		{
			throw null;
		}

		// Token: 0x06006854 RID: 26708 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ShowHelloNotification(string sender)
		{
			throw null;
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetInteractionRaycast(GInterface12 @object)
		{
			throw null;
		}

		// Token: 0x06006856 RID: 26710 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPlaceItemTriggerChanged([CanBeNull] PlaceItemTrigger zone)
		{
			throw null;
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddTriggerZone(TriggerWithId zone)
		{
			throw null;
		}

		// Token: 0x06006858 RID: 26712 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveTriggerZone(TriggerWithId zone)
		{
			throw null;
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06006859 RID: 26713 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600685A RID: 26714 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
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

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x0600685B RID: 26715 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600685C RID: 26716 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool IsVisible
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

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x0600685D RID: 26717 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float SqrCameraDistance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600685E RID: 26718 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInteractInHands(bool isInteracting, int animationId = 1)
		{
			throw null;
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateInteractionCast()
		{
			throw null;
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight)
		{
			throw null;
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06006861 RID: 26721 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006862 RID: 26722 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerBones PlayerBones
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

		// Token: 0x06006863 RID: 26723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetupHitColliders()
		{
			throw null;
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_77(BodyPartCollider bodyPartCollider, bool includeChild)
		{
			throw null;
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetInventoryOpened(bool opened)
		{
			throw null;
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InventoryOpenRaiseAction(bool opened)
		{
			throw null;
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ExecuteShotSkill(Item weapon)
		{
			throw null;
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ManageAggressor(DamageInfo damageInfo, EBodyPart bodyPart, EBodyPartColliderType colliderType)
		{
			throw null;
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_78(DamageInfo damageInfo, EBodyPart bodyPart, Player aggressor)
		{
			throw null;
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ApplyExplosionDamageToArmor(Dictionary<GStruct196, float> armorDamage, DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsShotDeflectedByHeavyArmor(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, int shotSeed)
		{
			throw null;
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_79(EBodyPartColliderType colliderType)
		{
			throw null;
		}

		// Token: 0x0600686D RID: 26733 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_80(float armorDamage, ArmorComponent armorComponent)
		{
			throw null;
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected List<ArmorComponent> ProceedDamageThroughArmor(ref DamageInfo damageInfo, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, bool damageInfoIsLocal = true)
		{
			throw null;
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDogtagInfo(GStruct314 deathPacket)
		{
			throw null;
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_81(DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnArmorPointsChanged(ArmorComponent armor, bool children = false)
		{
			throw null;
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnSideEffectApplied(SideEffectComponent sideEffect)
		{
			throw null;
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RecalculateEquipmentParams()
		{
			throw null;
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ApplyHitDebuff(float damage, float staminaBurnRate, EBodyPart bodyPartType, EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool SetShotStatus(BodyPartCollider bodypart, GClass2988 shot, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection)
		{
			throw null;
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckArmorHitByDirection(BodyPartCollider bodypart)
		{
			throw null;
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual GClass1673 ApplyShot(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, GStruct389 shotId)
		{
			throw null;
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ApplyDamageInfo(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, float absorbed)
		{
			throw null;
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AddDetailedHitInfo(EDamageType damageType, int d, int absorbed, int staminaLoss, EBodyPart part, MaterialType special)
		{
			throw null;
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x0600687A RID: 26746 RVA: 0x00002050 File Offset: 0x00000250
		public int OwnerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool ShouldVocalizeDeath(EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnBeenKilledByAggressor(IPlayer aggressor, DamageInfo damageInfo, EBodyPart bodyPart, EDamageType lethalDamageType)
		{
			throw null;
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDead(EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_82()
		{
			throw null;
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Corpse CreateCorpse()
		{
			throw null;
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected T CreateCorpse<T>(Vector3 velocity) where T : Corpse
		{
			throw null;
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ApplyCorpseImpulse()
		{
			throw null;
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MumbleToggle()
		{
			throw null;
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MumbleEnd()
		{
			throw null;
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void QuickMumbleStart()
		{
			throw null;
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleMumbleDropdown()
		{
			throw null;
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseMumbleDropdown()
		{
			throw null;
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_83(bool value)
		{
			throw null;
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExitTriggerStatusChanged(bool status)
		{
			throw null;
		}

		// Token: 0x14000135 RID: 309
		// (add) Token: 0x06006889 RID: 26761 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600688A RID: 26762 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<ExfiltrationPoint, bool> OnEpInteraction
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

		// Token: 0x0600688B RID: 26763 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetExfiltrationPoint(ExfiltrationPoint point, bool entered)
		{
			throw null;
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SearchForInteractions()
		{
			throw null;
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MakeBindAction(int index, bool aggressive)
		{
			throw null;
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayPhraseOrGesture(int actionId, bool aggressive)
		{
			throw null;
		}

		// Token: 0x0600688F RID: 26767 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_3(EGesture gesture)
		{
			throw null;
		}

		// Token: 0x06006890 RID: 26768 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void TriggerPhraseCommand(EPhraseTrigger phrase, int netPhraseId)
		{
			throw null;
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06006891 RID: 26769 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006892 RID: 26770 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x06006893 RID: 26771 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddAlly(IPlayer enemy)
		{
			throw null;
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGroup(BotsGroup newBotsGroup)
		{
			throw null;
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void KillMe(EBodyPartColliderType colliderType, float damage)
		{
			throw null;
		}

		// Token: 0x06006896 RID: 26774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DevelopResetDiscardLimits()
		{
			throw null;
		}

		// Token: 0x06006897 RID: 26775 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DevelopSetEncodedRadioTransmitter(bool value)
		{
			throw null;
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DevelopSetActiveLighthouseTraderZoneDebug(bool value)
		{
			throw null;
		}

		// Token: 0x06006899 RID: 26777 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void GetRadioTransmitterStatusFromServer()
		{
			throw null;
		}

		// Token: 0x0600689A RID: 26778 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void KillAIs()
		{
			throw null;
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetEventState(EEventState value)
		{
			throw null;
		}

		// Token: 0x0600689C RID: 26780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SpawnAI(int count)
		{
			throw null;
		}

		// Token: 0x0600689D RID: 26781 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DevelopUnlockDoors(bool openDoors)
		{
			throw null;
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Heal(EBodyPart bodyPart, float value)
		{
			throw null;
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DebugSnapshotAllPlayers()
		{
			throw null;
		}

		// Token: 0x060068A0 RID: 26784 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DebugSpawnAirdrop(bool spawnNearPlayer, Vector3 playerPosition)
		{
			throw null;
		}

		// Token: 0x060068A1 RID: 26785 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCallbackForInteraction(Action<Action> cb)
		{
			throw null;
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void TryInteractionCallback(LootableContainer container)
		{
			throw null;
		}

		// Token: 0x060068A3 RID: 26787 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnGameSessionBegin()
		{
			throw null;
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Item GetCultistAmulet()
		{
			throw null;
		}

		// Token: 0x060068A5 RID: 26789 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnGameSessionEnd(ExitStatus exitStatus, float pastTime, string locationId, string exitName)
		{
			throw null;
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ConnectSkillManager()
		{
			throw null;
		}

		// Token: 0x060068A7 RID: 26791 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_84(bool result)
		{
			throw null;
		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_85(IEffect obj)
		{
			throw null;
		}

		// Token: 0x060068A9 RID: 26793 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_86(IEffect obj)
		{
			throw null;
		}

		// Token: 0x060068AA RID: 26794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_87(GInterface226 buff)
		{
			throw null;
		}

		// Token: 0x060068AB RID: 26795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_88(float tempCelsio)
		{
			throw null;
		}

		// Token: 0x060068AC RID: 26796 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SearchOperationsOnItemRemoved(GClass2865 obj)
		{
			throw null;
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void IfItemFullySearched(SearchableItemClass item)
		{
			throw null;
		}

		// Token: 0x060068AE RID: 26798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_89(Item item)
		{
			throw null;
		}

		// Token: 0x060068AF RID: 26799 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_90(int count)
		{
			throw null;
		}

		// Token: 0x060068B0 RID: 26800 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_91(int count)
		{
			throw null;
		}

		// Token: 0x060068B1 RID: 26801 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_92()
		{
			throw null;
		}

		// Token: 0x060068B2 RID: 26802 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_93()
		{
			throw null;
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_94(float diff)
		{
			throw null;
		}

		// Token: 0x060068B4 RID: 26804 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_95(EBodyPart bodyPart, float damage, DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x060068B5 RID: 26805 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_96(IEffect healthEffect)
		{
			throw null;
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_97(GClass2895 flareEvent)
		{
			throw null;
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_98(float diff)
		{
			throw null;
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ExecuteSkill(Action action)
		{
			throw null;
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ExecuteSkill(Action<float> action)
		{
			throw null;
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task ManageGameQuests()
		{
			throw null;
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeRecodableItemHandlers()
		{
			throw null;
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void StartInflictSelfDamageCoroutine()
		{
			throw null;
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator InflictSelfDamage()
		{
			throw null;
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_99(EPlayerState previousState, EPlayerState nextState)
		{
			throw null;
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SendHandsInteractionStateChanged(bool value, int animationId)
		{
			throw null;
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetCompassState(bool value)
		{
			throw null;
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetLauncherState(bool value)
		{
			throw null;
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetAnimatorLayerWeight(int layer, int weight)
		{
			throw null;
		}

		// Token: 0x060068C3 RID: 26819 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnSkillLevelChanged(GClass1763 skill)
		{
			throw null;
		}

		// Token: 0x060068C4 RID: 26820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnSkillExperienceChanged(GClass1763 skill)
		{
			throw null;
		}

		// Token: 0x060068C5 RID: 26821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnWeaponMastered(GClass1764 masterSkill)
		{
			throw null;
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnMasteringExperienceChanged(GClass1764 masterSkill)
		{
			throw null;
		}

		// Token: 0x060068C7 RID: 26823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SpecialPlaceVisited(string id, int experience)
		{
			throw null;
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x060068C8 RID: 26824 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060068C9 RID: 26825 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsYourPlayer
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_100()
		{
			throw null;
		}

		// Token: 0x060068CB RID: 26827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchRenderer(bool @switch)
		{
			throw null;
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x060068CC RID: 26828 RVA: 0x00002050 File Offset: 0x00000250
		[Obsolete("Use Player.Transform instead!", true)]
		public new Transform transform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Teleport(Vector3 position, bool onServerToo = false)
		{
			throw null;
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IncreaseAwareness(float aware = 5f)
		{
			throw null;
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Sleep(bool value)
		{
			throw null;
		}

		// Token: 0x060068D0 RID: 26832 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasBodyPartCollider(Collider collider)
		{
			throw null;
		}

		// Token: 0x060068D1 RID: 26833 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Dispose()
		{
			throw null;
		}

		// Token: 0x060068D2 RID: 26834 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_101()
		{
			throw null;
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Board(MovingPlatform platform)
		{
			throw null;
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetOff(MovingPlatform platform)
		{
			throw null;
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleFlareSuccessEvent(Vector3 position, FlareEventType eventType)
		{
			throw null;
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_102()
		{
			throw null;
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_103(int i)
		{
			throw null;
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_104()
		{
			throw null;
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_105(bool enable)
		{
			throw null;
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_106()
		{
			throw null;
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_107()
		{
			throw null;
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_108(Result<GInterface125> result)
		{
			throw null;
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Player.EmptyHandsController method_109()
		{
			throw null;
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_110()
		{
			throw null;
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_111()
		{
			throw null;
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_112()
		{
			throw null;
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_113()
		{
			throw null;
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_114()
		{
			throw null;
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_115()
		{
			throw null;
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_116()
		{
			throw null;
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_117(EPhraseTrigger x)
		{
			throw null;
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_118()
		{
			throw null;
		}

		// Token: 0x060068E7 RID: 26855 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_119()
		{
			throw null;
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_120()
		{
			throw null;
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_121(GClass2895 invokedEvent)
		{
			throw null;
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_122()
		{
			throw null;
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_123()
		{
			throw null;
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_124()
		{
			throw null;
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_125()
		{
			throw null;
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_126()
		{
			throw null;
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_127()
		{
			throw null;
		}

		// Token: 0x040072B5 RID: 29365
		public ICharacterController _characterController;

		// Token: 0x040072B6 RID: 29366
		protected TriggerColliderSearcher _triggerColliderSearcher;

		// Token: 0x040072B7 RID: 29367
		private bool _doorKick;

		// Token: 0x040072B8 RID: 29368
		private WorldInteractiveObject _currentInteractor;

		// Token: 0x040072BA RID: 29370
		private float _horizontal;

		// Token: 0x040072BB RID: 29371
		private float _vertical;

		// Token: 0x040072BC RID: 29372
		private bool _resetLook;

		// Token: 0x040072BD RID: 29373
		private bool _mouseLookControl;

		// Token: 0x040072BE RID: 29374
		private bool _isResettingLook;

		// Token: 0x040072BF RID: 29375
		private bool _setResetedLookNextFrame;

		// Token: 0x040072C0 RID: 29376
		private bool _isLooking;

		// Token: 0x040072C1 RID: 29377
		public GClass1655 Pedometer;

		// Token: 0x040072C2 RID: 29378
		public Vector3 HeadRotation;

		// Token: 0x040072C3 RID: 29379
		protected float _mouseSensitivityModifier;

		// Token: 0x040072C4 RID: 29380
		protected readonly Dictionary<Player.EMouseSensitivityModifier, float> _mouseSensitivityModifiers;

		// Token: 0x040072C5 RID: 29381
		private Vector2 _rotationPitchLimit;

		// Token: 0x040072C6 RID: 29382
		private Vector2 _targetRotationPitch;

		// Token: 0x040072C8 RID: 29384
		public float TrunkRotationLimit;

		// Token: 0x040072C9 RID: 29385
		public float PoseMemo;

		// Token: 0x040072CA RID: 29386
		private float _leanMemo;

		// Token: 0x040072CB RID: 29387
		private float _speedMemo;

		// Token: 0x040072CC RID: 29388
		private float _lastSlowLeanDirection;

		// Token: 0x040072CD RID: 29389
		public Player.LeanType CurrentLeanType;

		// Token: 0x040072CE RID: 29390
		private float _lastMovement;

		// Token: 0x040072CF RID: 29391
		private bool _cachedMouseLookControl;

		// Token: 0x040072D0 RID: 29392
		private bool _isVaultingPressed;

		// Token: 0x040072D1 RID: 29393
		private float _vaultingTiming;

		// Token: 0x040072D2 RID: 29394
		protected float _prevHeight;

		// Token: 0x040072D3 RID: 29395
		public float HeightSmoothTime;

		// Token: 0x040072D4 RID: 29396
		private float _dampVelocity;

		// Token: 0x040072D5 RID: 29397
		private float _currentSmoothSpeed;

		// Token: 0x040072D6 RID: 29398
		private float _previousY;

		// Token: 0x040072D7 RID: 29399
		private const float ClampDeltaHeight = 0.2f;

		// Token: 0x040072D8 RID: 29400
		public const int GRIP_CULL_DISTANCE = 40;

		// Token: 0x040072D9 RID: 29401
		public const int IK_CULL_DISTANCE = 70;

		// Token: 0x040072DA RID: 29402
		public const int MAX_IK_CULL_DISTANCE = 300;

		// Token: 0x040072DB RID: 29403
		private const string COMPASS_RESOURCE_PATH = "assets/content/weapons/additional_hands/item_compass.bundle";

		// Token: 0x040072DD RID: 29405
		public GripPose LeftHandInteractionTarget;

		// Token: 0x040072DE RID: 29406
		public GrounderFBBIK Grounder;

		// Token: 0x040072DF RID: 29407
		public HitReaction HitReaction;

		// Token: 0x040072E0 RID: 29408
		public float RibcageScaleCurrent;

		// Token: 0x040072E1 RID: 29409
		public float RibcageScaleCurrentTarget;

		// Token: 0x040072E2 RID: 29410
		public Transform[] _elbowBends;

		// Token: 0x040072E3 RID: 29411
		public HandPoser[] HandPosers;

		// Token: 0x040072E4 RID: 29412
		public Vector2 UtilityLayerRange;

		// Token: 0x040072E5 RID: 29413
		public float UtilityLayerLerpSpeed;

		// Token: 0x040072E6 RID: 29414
		public Player.ValueBlender LMarkerRawBlender;

		// Token: 0x040072E7 RID: 29415
		public Player.ValueBlender LayerWeight;

		// Token: 0x040072E8 RID: 29416
		public readonly Player.BetterValueBlender ThirdIkWeight;

		// Token: 0x040072E9 RID: 29417
		public bool GripAutoAdjust;

		// Token: 0x040072EA RID: 29418
		public bool CustomAnimationsAreProcessing;

		// Token: 0x040072EB RID: 29419
		protected FullBodyBipedIK _fbbik;

		// Token: 0x040072EC RID: 29420
		protected PlayerBody _playerBody;

		// Token: 0x040072ED RID: 29421
		protected float ThirdPersonWeaponRootAuthority;

		// Token: 0x040072EE RID: 29422
		public const float HAND_ANIMATION_BLEND_THRESHOLD = 0.1f;

		// Token: 0x040072EF RID: 29423
		private float _ribcageScaleCompensated;

		// Token: 0x040072F0 RID: 29424
		private float _shoulderVel;

		// Token: 0x040072F1 RID: 29425
		private float _fbbikCooldown;

		// Token: 0x040072F2 RID: 29426
		private float _turnOffFbbikAt;

		// Token: 0x040072F3 RID: 29427
		private float _firstPersonRightHand;

		// Token: 0x040072F4 RID: 29428
		private float _firstPersonLeftHand;

		// Token: 0x040072F5 RID: 29429
		private float _utilityLayerWeight;

		// Token: 0x040072F6 RID: 29430
		private float _smoothLW;

		// Token: 0x040072F7 RID: 29431
		private float _rawWeight;

		// Token: 0x040072F8 RID: 29432
		private float _rawDampVelocity;

		// Token: 0x040072F9 RID: 29433
		private float _interactionLayerWeight;

		// Token: 0x040072FA RID: 29434
		private bool _stored;

		// Token: 0x040072FB RID: 29435
		private bool _hasGamePlayerOwner;

		// Token: 0x040072FC RID: 29436
		private bool _pointOfViewUndecided;

		// Token: 0x040072FD RID: 29437
		private bool _hasAnimatorPropBones;

		// Token: 0x040072FE RID: 29438
		private bool _hasProp;

		// Token: 0x040072FF RID: 29439
		private bool _propActive;

		// Token: 0x04007300 RID: 29440
		private bool _compassInstantiated;

		// Token: 0x04007301 RID: 29441
		private bool _radioTransmitterInstantiated;

		// Token: 0x04007302 RID: 29442
		private Vector3[] _ribcageChildPositions;

		// Token: 0x04007303 RID: 29443
		private Vector3 _ikPosition;

		// Token: 0x04007304 RID: 29444
		private Vector3 _lMarkerRawPosition;

		// Token: 0x04007305 RID: 29445
		private Vector3 _lElbowRawPosition;

		// Token: 0x04007306 RID: 29446
		private Vector3 _rElbowRawPosition;

		// Token: 0x04007307 RID: 29447
		private Vector3 _propRawPosition;

		// Token: 0x04007308 RID: 29448
		private Quaternion _lMarkerRawRotation;

		// Token: 0x04007309 RID: 29449
		private Quaternion _propRawRotation;

		// Token: 0x0400730A RID: 29450
		private Quaternion _ikRotation;

		// Token: 0x0400730B RID: 29451
		private Quaternion[] _ribcageChildRotations;

		// Token: 0x0400730C RID: 29452
		private readonly Transform[] _markers;

		// Token: 0x0400730D RID: 29453
		private readonly Transform[] _gripReferences;

		// Token: 0x0400730E RID: 29454
		private Transform[] _ikTargets;

		// Token: 0x0400730F RID: 29455
		private Transform _vestMarker;

		// Token: 0x04007310 RID: 29456
		private Transform _shoulderEffector;

		// Token: 0x04007311 RID: 29457
		private Transform _propBone;

		// Token: 0x04007312 RID: 29458
		private TwistRelax[] _twistBones;

		// Token: 0x04007313 RID: 29459
		private LimbIK[] _limbs;

		// Token: 0x04007314 RID: 29460
		private GameObject _beaconDummy;

		// Token: 0x04007315 RID: 29461
		private Action _createBeaconAction;

		// Token: 0x04007316 RID: 29462
		private PreviewMaterialSetter _beaconMaterialSetter;

		// Token: 0x04007317 RID: 29463
		private BeaconPlacer _beaconPlacer;

		// Token: 0x04007318 RID: 29464
		private FirearmsEffects _thirdWeaponEffects;

		// Token: 0x04007319 RID: 29465
		private FirearmsEffects _firstWeaponEffects;

		// Token: 0x0400731A RID: 29466
		private CompassArrow _compassArrow;

		// Token: 0x0400731B RID: 29467
		private RadioTransmitterView _radioTransmitterView;

		// Token: 0x0400731C RID: 29468
		private Transform[] _animatorPropTransforms;

		// Token: 0x0400731D RID: 29469
		private Transform[] _propTransforms;

		// Token: 0x0400731E RID: 29470
		private readonly List<GStruct53> _preAllocatedRenderersList;

		// Token: 0x04007320 RID: 29472
		public readonly Player.ValueBlender AuthorityBlender;

		// Token: 0x04007321 RID: 29473
		public readonly Player.ValueBlender GrounderBlender;

		// Token: 0x04007322 RID: 29474
		private float _ergonomicsPenalty;

		// Token: 0x04007323 RID: 29475
		private float _shotTime;

		// Token: 0x04007324 RID: 29476
		protected bool _isDeadAlready;

		// Token: 0x04007325 RID: 29477
		private bool _isGrenadeOrKnife;

		// Token: 0x04007326 RID: 29478
		private ObjectInHandsAnimator _handsAnimator;

		// Token: 0x04007327 RID: 29479
		private GameObject _spawnedKey;

		// Token: 0x04007328 RID: 29480
		private Action _cacheBonesDelegate;

		// Token: 0x04007330 RID: 29488
		protected bool IsHeadLightsAnimationActive;

		// Token: 0x04007331 RID: 29489
		private Player.GClass1572 _garbage;

		// Token: 0x04007332 RID: 29490
		public Text DebugText;

		// Token: 0x04007333 RID: 29491
		public BaseBallistic.ESurfaceSound CurrentSurface;

		// Token: 0x04007334 RID: 29492
		private LayerMask _stepLayerMask;

		// Token: 0x04007335 RID: 29493
		private const float TIME_BETWEEN_PRONE_SWEEPS = 0.5f;

		// Token: 0x04007336 RID: 29494
		public const float DEFAULT_ROLL_OFF = 60f;

		// Token: 0x04007337 RID: 29495
		private const float MIN_ALLOWED_MOVEMENT_SPEED = 0f;

		// Token: 0x04007338 RID: 29496
		private const float MAX_STEP_SOUND_SPEED_FACTOR = 1f;

		// Token: 0x04007339 RID: 29497
		private const float SURFACE_CHECK_RAYCAST_OFFSET = 0.5f;

		// Token: 0x0400733A RID: 29498
		private const int USUAL_AUDIO_SOURCE_PRIORITY = 64;

		// Token: 0x0400733B RID: 29499
		private const int LOW_AUDIO_SOURCE_PRIORITY = 200;

		// Token: 0x0400733D RID: 29501
		public bool HeavyBreath;

		// Token: 0x0400733E RID: 29502
		public bool Muffled;

		// Token: 0x0400733F RID: 29503
		protected BetterSource NestedStepSoundSource;

		// Token: 0x04007340 RID: 29504
		protected BetterSource _speechSource;

		// Token: 0x04007341 RID: 29505
		protected bool OcclusionDirty;

		// Token: 0x04007342 RID: 29506
		protected bool DistanceDirty;

		// Token: 0x04007343 RID: 29507
		protected AudioClip FractureSound;

		// Token: 0x04007344 RID: 29508
		public BaseSoundPlayer.SoundElement PropIn;

		// Token: 0x04007345 RID: 29509
		public BaseSoundPlayer.SoundElement PropOut;

		// Token: 0x04007346 RID: 29510
		protected bool PreviousFaceShield;

		// Token: 0x04007347 RID: 29511
		protected bool PreviousNightVision;

		// Token: 0x04007348 RID: 29512
		protected bool PreviousThermalVision;

		// Token: 0x04007349 RID: 29513
		protected readonly Vector3 SpeechLocalPosition;

		// Token: 0x0400734A RID: 29514
		protected AudioClip FaceshieldOn;

		// Token: 0x0400734B RID: 29515
		protected AudioClip FaceshieldOff;

		// Token: 0x0400734C RID: 29516
		protected AudioClip NightVisionOn;

		// Token: 0x0400734D RID: 29517
		protected AudioClip SwitchHeadlights;

		// Token: 0x0400734E RID: 29518
		protected AudioClip NightVisionOff;

		// Token: 0x0400734F RID: 29519
		protected AudioClip ThermalVisionOn;

		// Token: 0x04007350 RID: 29520
		protected AudioClip ThermalVisionOff;

		// Token: 0x04007351 RID: 29521
		private AudioClip _tinnitus;

		// Token: 0x04007352 RID: 29522
		private Dictionary<BaseBallistic.ESurfaceSound, SurfaceSet> _soundBySurface;

		// Token: 0x04007353 RID: 29523
		private SurfaceSet _currentSet;

		// Token: 0x04007354 RID: 29524
		private SoundBank _gearSoundBank;

		// Token: 0x04007355 RID: 29525
		private SoundBank _gearFastSoundBank;

		// Token: 0x04007356 RID: 29526
		private Coroutine _idleCoroutine;

		// Token: 0x04007357 RID: 29527
		private Coroutine _runCoroutine;

		// Token: 0x04007358 RID: 29528
		private Coroutine _sprintCoroutine;

		// Token: 0x04007359 RID: 29529
		private Coroutine _gearDelay;

		// Token: 0x0400735A RID: 29530
		private Coroutine _outOfRangeSpeakingCoroutine;

		// Token: 0x0400735B RID: 29531
		private Coroutine _currentSourceCoroutine;

		// Token: 0x0400735C RID: 29532
		private bool _playedAtLeastOneStep;

		// Token: 0x0400735D RID: 29533
		private float _nextJumpAfter;

		// Token: 0x0400735E RID: 29534
		private BetterSource _searchSource;

		// Token: 0x0400735F RID: 29535
		private float _searchCount;

		// Token: 0x04007360 RID: 29536
		private AudioClip _lastClip;

		// Token: 0x04007361 RID: 29537
		private const int ROLLOFF = 14;

		// Token: 0x04007362 RID: 29538
		private readonly List<BetterPropagationVolume> _soundPropagationVolumes;

		// Token: 0x04007363 RID: 29539
		private readonly List<BetterPropagationVolume> _volumesBuffer;

		// Token: 0x04007364 RID: 29540
		private BetterPropagationVolume _mutuallyExclusive;

		// Token: 0x04007365 RID: 29541
		private bool _exhaustionIsAudible;

		// Token: 0x04007366 RID: 29542
		private Action _exhaustionAudibilityUnsub;

		// Token: 0x04007367 RID: 29543
		private float _sprintSurfaceCheck;

		// Token: 0x04007368 RID: 29544
		private float _runSurfaceCheck;

		// Token: 0x04007369 RID: 29545
		private float _landSurfaceCheck;

		// Token: 0x0400736A RID: 29546
		private float _proneSurfaceCheck;

		// Token: 0x0400736B RID: 29547
		private float _sign;

		// Token: 0x0400736C RID: 29548
		private float _lastStepTime;

		// Token: 0x0400736D RID: 29549
		private float _lastTimeTurnSound;

		// Token: 0x0400736E RID: 29550
		private float maxLengthTurnSound;

		// Token: 0x0400736F RID: 29551
		private float _nextSurfaceCheck;

		// Token: 0x04007370 RID: 29552
		private float _distance;

		// Token: 0x04007371 RID: 29553
		private bool _enqueuedForRelease;

		// Token: 0x04007372 RID: 29554
		private float _maxAllowedMovementSpeed;

		// Token: 0x04007373 RID: 29555
		private GClass2156 _vaultAudioController;

		// Token: 0x04007374 RID: 29556
		private GClass2156 _sprintVaultAudioController;

		// Token: 0x04007375 RID: 29557
		private GClass2156 _climbAudioController;

		// Token: 0x04007376 RID: 29558
		private AudioSource _voipAudioSource;

		// Token: 0x04007377 RID: 29559
		private GInterface58 _specificStepAudioController;

		// Token: 0x04007378 RID: 29560
		private Action _voipSourceBinding;

		// Token: 0x04007379 RID: 29561
		private BaseBallistic.ESurfaceSound _currentVaultingSurface;

		// Token: 0x0400737A RID: 29562
		private GInterface138 _customHandRotator;

		// Token: 0x0400737E RID: 29566
		private EPlayerBtrState _btrState;

		// Token: 0x0400737F RID: 29567
		private EPlayerBtrState _lastBtrStateInteractionCheck;

		// Token: 0x04007380 RID: 29568
		private EBtrState _lastBtrStateCheck;

		// Token: 0x04007381 RID: 29569
		private bool _lastBtrCastResult;

		// Token: 0x04007384 RID: 29572
		protected static readonly TimeSpan HearingDetectionTime;

		// Token: 0x04007387 RID: 29575
		private Player.EProcessStatus _processStatus;

		// Token: 0x0400738C RID: 29580
		private Item _lastEquippedWeaponOrKnifeItem;

		// Token: 0x0400738D RID: 29581
		private readonly EquipmentSlot[] _slotPriority;

		// Token: 0x0400738E RID: 29582
		protected Callback _removeFromHandsCallback;

		// Token: 0x0400738F RID: 29583
		private Callback _setInHandsCallback;

		// Token: 0x04007390 RID: 29584
		private float _lastFaceshieldOperationTime;

		// Token: 0x04007391 RID: 29585
		private int _faceshieldNumOperations;

		// Token: 0x04007392 RID: 29586
		private const int MaxFaceshieldOperationsPerFrame = 3;

		// Token: 0x04007393 RID: 29587
		public const Player.EAnimatorMask EnabledAnimatorsPlayerDefault = Player.EAnimatorMask.Thirdperson | Player.EAnimatorMask.Arms | Player.EAnimatorMask.Procedural | Player.EAnimatorMask.FBBIK | Player.EAnimatorMask.IK;

		// Token: 0x04007394 RID: 29588
		public const Player.EAnimatorMask FastAnimatorMask = Player.EAnimatorMask.Thirdperson | Player.EAnimatorMask.Arms | Player.EAnimatorMask.FBBIK | Player.EAnimatorMask.IK;

		// Token: 0x04007395 RID: 29589
		public const Player.EAnimatorMask EnabledAnimatorsSpiritDefault = Player.EAnimatorMask.Thirdperson | Player.EAnimatorMask.Arms;

		// Token: 0x04007396 RID: 29590
		private const int SPRINT_DAMAGE = 2;

		// Token: 0x04007397 RID: 29591
		protected const int JUMP_DAMAGE = 3;

		// Token: 0x04007398 RID: 29592
		public const string LAYER_NAME_PLAYER = "Player";

		// Token: 0x04007399 RID: 29593
		public PlayerOverlapManager POM;

		// Token: 0x0400739A RID: 29594
		public List<string> TriggerZones;

		// Token: 0x0400739B RID: 29595
		[NonSerialized]
		public BindableEvent OnExitTriggerVisited;

		// Token: 0x0400739C RID: 29596
		public BindableState<bool> InteractingWithExfiltrationPoint;

		// Token: 0x0400739D RID: 29597
		public EDamageType LastDamageType;

		// Token: 0x0400739E RID: 29598
		public EBodyPart LastDamagedBodyPart;

		// Token: 0x0400739F RID: 29599
		public bool Destroyed;

		// Token: 0x040073A0 RID: 29600
		public bool QuickdrawWeaponFast;

		// Token: 0x040073A1 RID: 29601
		public bool FastSlotSelection;

		// Token: 0x040073A2 RID: 29602
		public bool PreviousWeaponAimState;

		// Token: 0x040073A3 RID: 29603
		public float QuickdrawTime;

		// Token: 0x040073A5 RID: 29605
		public bool CanManipulateWithHandsInBufferZone;

		// Token: 0x040073A6 RID: 29606
		public IAnimator[] _animators;

		// Token: 0x040073A7 RID: 29607
		public IAnimator _underbarrelFastAnimator;

		// Token: 0x040073A8 RID: 29608
		public GClass1804 Speaker;

		// Token: 0x040073AC RID: 29612
		public PlayerSpirit Spirit;

		// Token: 0x040073AD RID: 29613
		public Player.EAnimatorMask EnabledAnimators;

		// Token: 0x040073AE RID: 29614
		protected Player.GClass625 Logger;

		// Token: 0x040073AF RID: 29615
		protected Corpse Corpse;

		// Token: 0x040073B0 RID: 29616
		protected IPlayer LastAggressor;

		// Token: 0x040073B1 RID: 29617
		protected DamageInfo LastDamageInfo;

		// Token: 0x040073B2 RID: 29618
		protected EBodyPart LastBodyPart;

		// Token: 0x040073B3 RID: 29619
		protected float _corpseAppliedForce;

		// Token: 0x040073B4 RID: 29620
		protected Func<float> GetSensitivity;

		// Token: 0x040073B5 RID: 29621
		protected Func<float> GetAimingSensitivity;

		// Token: 0x040073B6 RID: 29622
		protected Action<Action> _openAction;

		// Token: 0x040073B7 RID: 29623
		protected RecodableItemsHandler recodableItemsHandler;

		// Token: 0x040073B8 RID: 29624
		private float _countdownToSprintDamage;

		// Token: 0x040073B9 RID: 29625
		private float _lastHitTime;

		// Token: 0x040073BA RID: 29626
		private int _lastHitDebuffFrame;

		// Token: 0x040073BB RID: 29627
		private float _accumulatedDebuffDamage;

		// Token: 0x040073BC RID: 29628
		private int _negativeBuffsCount;

		// Token: 0x040073BD RID: 29629
		private bool _sense;

		// Token: 0x040073BE RID: 29630
		private bool _isInventoryOpened;

		// Token: 0x040073BF RID: 29631
		private bool _displaySense;

		// Token: 0x040073C0 RID: 29632
		private IEffect Fatigue;

		// Token: 0x040073C1 RID: 29633
		private Renderer[] _renderers;

		// Token: 0x040073C2 RID: 29634
		private Camera _camera;

		// Token: 0x040073C3 RID: 29635
		private Coroutine _dropdownCoroutine;

		// Token: 0x040073C4 RID: 29636
		private Coroutine _selfDamage;

		// Token: 0x040073C5 RID: 29637
		private readonly BindableState<Item> _itemInHands;

		// Token: 0x040073C6 RID: 29638
		protected readonly GClass763 CompositeDisposable;

		// Token: 0x040073C7 RID: 29639
		private GClass2981 _heavyVestsDeflectRandoms;

		// Token: 0x040073C8 RID: 29640
		private Action _unsubscribeOnEndSession;

		// Token: 0x040073C9 RID: 29641
		private readonly List<Item> _searchedItems;

		// Token: 0x040073CA RID: 29642
		protected IEnumerable<TacticalComboVisualController> _helmetLightControllers;

		// Token: 0x040073CB RID: 29643
		private bool _quickMumbleAvailable;

		// Token: 0x040073CC RID: 29644
		private Animator _createdAnimator;

		// Token: 0x040073CD RID: 29645
		private RuntimeAnimatorController _createdRuntimeAnimatorController;

		// Token: 0x040073CE RID: 29646
		private IVaultingComponent _vaultingComponent;

		// Token: 0x040073CF RID: 29647
		private IVaultingComponentDebug _vaultingComponentDebug;

		// Token: 0x040073D0 RID: 29648
		private IVaultingParameters _vaultingParameters;

		// Token: 0x040073D1 RID: 29649
		private IVaultingGameplayRestrictions _vaultingGameplayRestrictions;

		// Token: 0x040073EB RID: 29675
		public GClass678 Physical;

		// Token: 0x040073ED RID: 29677
		[SerializeField]
		private EUpdateQueue _updateQueue;

		// Token: 0x040073EE RID: 29678
		[SerializeField]
		protected EUpdateQueue _armsUpdateQueue;

		// Token: 0x040073F1 RID: 29681
		[SerializeField]
		protected Player.EUpdateMode _armsUpdateMode;

		// Token: 0x040073F2 RID: 29682
		[SerializeField]
		protected Player.EUpdateMode _bodyUpdateMode;

		// Token: 0x040073F8 RID: 29688
		protected IHealthController _healthController;

		// Token: 0x040073F9 RID: 29689
		protected BodyPartCollider[] _hitColliders;

		// Token: 0x040073FA RID: 29690
		protected ArmorPlateCollider[] _armorPlateColliders;

		// Token: 0x040073FB RID: 29691
		protected InventoryControllerClass _inventoryController;

		// Token: 0x040073FC RID: 29692
		protected Player.AbstractHandsController _handsController;

		// Token: 0x040073FD RID: 29693
		protected AbstractQuestControllerClass _questController;

		// Token: 0x040073FE RID: 29694
		protected AbstractAchievementControllerClass _achievementsController;

		// Token: 0x04007400 RID: 29696
		private string _fullIdInfo;

		// Token: 0x04007401 RID: 29697
		public Transform Tracking;

		// Token: 0x04007402 RID: 29698
		private float _awareness;

		// Token: 0x04007403 RID: 29699
		protected bool _armsupdated;

		// Token: 0x04007404 RID: 29700
		protected float _armsTime;

		// Token: 0x04007405 RID: 29701
		protected bool _bodyupdated;

		// Token: 0x04007406 RID: 29702
		protected float _bodyTime;

		// Token: 0x04007407 RID: 29703
		protected int _nFixedFrames;

		// Token: 0x04007408 RID: 29704
		protected float _fixedTime;

		// Token: 0x04007409 RID: 29705
		private static readonly Player.GDelegate56 _defaultDeltaTimeDelegate;

		// Token: 0x0400740A RID: 29706
		private Player.GDelegate56 _deltaTimeDelegate;

		// Token: 0x0400740B RID: 29707
		private WaitForFixedUpdate _waitForFixedUpdate;

		// Token: 0x0400740E RID: 29710
		protected float LastDeltaTime;

		// Token: 0x0400740F RID: 29711
		protected bool _manuallyUpdated;

		// Token: 0x04007410 RID: 29712
		protected Transform _playerLookRaycastTransform;

		// Token: 0x04007411 RID: 29713
		private EDoorState _lastInteractionState;

		// Token: 0x04007414 RID: 29716
		private bool _nextCastHasForceEvent;

		// Token: 0x04007415 RID: 29717
		private float _lastStateUpdateTime;

		// Token: 0x04007417 RID: 29719
		protected readonly List<ArmorComponent> _preAllocatedArmorComponents;

		// Token: 0x04007418 RID: 29720
		protected EquipmentPenaltyComponent _preAllocatedBackpackPenaltyComponent;

		// Token: 0x0400741B RID: 29723
		private bool _gameSessionEndWasCalled;

		// Token: 0x0400741C RID: 29724
		protected Action ExfilUnsubscribe;

		// Token: 0x0400741D RID: 29725
		protected List<Action> SessionEndUnsubscribe;

		// Token: 0x0400741E RID: 29726
		protected bool AggressorFound;

		// Token: 0x04007420 RID: 29728
		[SerializeField]
		public float MyHandsToBodyAngle;

		// Token: 0x04007421 RID: 29729
		public byte MovementIteration;

		// Token: 0x02001393 RID: 5011
		public class GClass3277 : Error
		{
		}

		// Token: 0x02001394 RID: 5012
		public class GClass3278 : Player.GClass3277
		{
			// Token: 0x060068F0 RID: 26864 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04007422 RID: 29730
			public readonly string ItemControllerId;
		}

		// Token: 0x02001395 RID: 5013
		public class GClass3279 : Error
		{
			// Token: 0x060068F1 RID: 26865 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04007423 RID: 29731
			public readonly Item Item;

			// Token: 0x04007424 RID: 29732
			public readonly Type ComponentType;
		}

		// Token: 0x02001396 RID: 5014
		public class GClass3280 : Error
		{
			// Token: 0x060068F2 RID: 26866 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04007425 RID: 29733
			public readonly Item Item;

			// Token: 0x04007426 RID: 29734
			public readonly ItemAddress ItemAddress;
		}

		// Token: 0x02001397 RID: 5015
		public class GClass3281 : Error
		{
			// Token: 0x060068F3 RID: 26867 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04007427 RID: 29735
			public readonly GClass2750 Component;

			// Token: 0x04007428 RID: 29736
			public readonly bool Value;
		}

		// Token: 0x02001398 RID: 5016
		protected internal class PlayerInventoryController : InventoryControllerClass, GInterface314
		{
			// Token: 0x170010F7 RID: 4343
			// (get) Token: 0x060068F4 RID: 26868 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060068F5 RID: 26869 RVA: 0x00002050 File Offset: 0x00000250
			private Dictionary<string, int> DiscardLimits
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

			// Token: 0x170010F8 RID: 4344
			// (get) Token: 0x060068F6 RID: 26870 RVA: 0x00002050 File Offset: 0x00000250
			protected virtual bool HasDiscardLimits
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170010F9 RID: 4345
			// (get) Token: 0x060068F7 RID: 26871 RVA: 0x00002050 File Offset: 0x00000250
			public new Profile Profile
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060068F8 RID: 26872 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override Task<IResult> TryRunNetworkTransaction(GStruct412 operationResult, Callback callback = null)
			{
				throw null;
			}

			// Token: 0x170010FA RID: 4346
			// (get) Token: 0x060068F9 RID: 26873 RVA: 0x00002050 File Offset: 0x00000250
			public override Item ItemInHands
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170010FB RID: 4347
			// (get) Token: 0x060068FA RID: 26874 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060068FB RID: 26875 RVA: 0x00002050 File Offset: 0x00000250
			public override bool Locked
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

			// Token: 0x060068FC RID: 26876 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool HasDiscardLimit(Item item, out int limit)
			{
				throw null;
			}

			// Token: 0x060068FD RID: 26877 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ResetDiscardLimits()
			{
				throw null;
			}

			// Token: 0x060068FE RID: 26878 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual IEnumerable<GStruct368> GetItemsOverDiscardLimit(Item item)
			{
				throw null;
			}

			// Token: 0x060068FF RID: 26879 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_31(Item item, out GStruct368 overLimit)
			{
				throw null;
			}

			// Token: 0x06006900 RID: 26880 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_32(Item item, bool ignoreRestrictions)
			{
				throw null;
			}

			// Token: 0x06006901 RID: 26881 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SubtractFromDiscardLimits(Item rootItem, IEnumerable<GStruct368> destroyedItems)
			{
				throw null;
			}

			// Token: 0x06006902 RID: 26882 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void LogDiscardLimitsChange(ItemTemplate template, int delta)
			{
				throw null;
			}

			// Token: 0x06006903 RID: 26883 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void AddDiscardLimits(Item rootItem, IEnumerable<GStruct368> destroyedItems)
			{
				throw null;
			}

			// Token: 0x06006904 RID: 26884 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OutProcess(TraderControllerClass executor, Item item, ItemAddress from, ItemAddress to, GInterface336 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006905 RID: 26885 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void InProcess(TraderControllerClass executor, Item item, ItemAddress to, bool succeed, GInterface336 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006906 RID: 26886 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetNextProcessLocked(bool status)
			{
				throw null;
			}

			// Token: 0x06006907 RID: 26887 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void InventoryCheckMagazine(MagazineClass magazine, bool notify)
			{
				throw null;
			}

			// Token: 0x06006908 RID: 26888 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override Task<IResult> LoadMultiBarrelWeapon(Weapon weapon, BulletClass ammo, int ammoCount)
			{
				throw null;
			}

			// Token: 0x06006909 RID: 26889 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override Task<IResult> LoadWeaponWithAmmo(Weapon weapon, BulletClass ammo, int ammoCount)
			{
				throw null;
			}

			// Token: 0x0600690A RID: 26890 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void StrictCheckMagazine(MagazineClass magazine, bool status, int skill = 0, bool notify = false, bool useOperation = true)
			{
				throw null;
			}

			// Token: 0x0600690B RID: 26891 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Task<IResult> LoadMagazine(BulletClass sourceAmmo, MagazineClass magazine, int loadCount, bool ignoreRestrictions)
			{
				throw null;
			}

			// Token: 0x0600690C RID: 26892 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override Task<IResult> UnloadMagazine(MagazineClass magazine)
			{
				throw null;
			}

			// Token: 0x0600690D RID: 26893 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<IResult> method_33()
			{
				throw null;
			}

			// Token: 0x0600690E RID: 26894 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void StopProcesses()
			{
				throw null;
			}

			// Token: 0x0600690F RID: 26895 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_34(Item magazineOrAmmo)
			{
				throw null;
			}

			// Token: 0x06006910 RID: 26896 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_35(MagazineClass magazine)
			{
				throw null;
			}

			// Token: 0x06006911 RID: 26897 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ThrowItem(Item item, IEnumerable<GStruct368> destroyedItems, Callback callback = null, bool downDirection = false)
			{
				throw null;
			}

			// Token: 0x06006912 RID: 26898 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override GClass2871 ToggleItem(TogglableComponent togglable)
			{
				throw null;
			}

			// Token: 0x06006913 RID: 26899 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetupItem(Item item, string zone, Vector3 position, Quaternion rotation, float setupTime, Callback callback = null)
			{
				throw null;
			}

			// Token: 0x06006914 RID: 26900 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void CheckMagazineAmmoDepend(MagazineClass magazine, Action callback, bool useOperation, bool allowUncheck = false)
			{
				throw null;
			}

			// Token: 0x06006915 RID: 26901 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CheckItemAction(Item item, ItemAddress location)
			{
				throw null;
			}

			// Token: 0x06006916 RID: 26902 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_36(Item item, ItemAddress to, GInterface336 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006917 RID: 26903 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_37(Item item, ItemAddress to, GInterface336 abstractOperation, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006918 RID: 26904 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal override bool vmethod_0(GClass2833 operation)
			{
				throw null;
			}

			// Token: 0x06006919 RID: 26905 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Item method_38(Item item, ItemAddress to)
			{
				throw null;
			}

			// Token: 0x0600691A RID: 26906 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<IResult> method_39(Weapon weapon, BulletClass ammo, int ammoCount)
			{
				throw null;
			}

			// Token: 0x0600691B RID: 26907 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<IResult> method_40(Weapon weapon, BulletClass ammo, int ammoCount)
			{
				throw null;
			}

			// Token: 0x0600691C RID: 26908 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_41()
			{
				throw null;
			}

			// Token: 0x04007429 RID: 29737
			internal readonly Player player_0;

			// Token: 0x0400742A RID: 29738
			private Interface16 interface16_0;

			// Token: 0x0400742B RID: 29739
			private Player.PlayerInventoryController.Class953 class953_0;

			// Token: 0x0400742C RID: 29740
			private bool bool_4;

			// Token: 0x0400742D RID: 29741
			private readonly Dictionary<string, int> dictionary_1;

			// Token: 0x0400742E RID: 29742
			private readonly List<Item> list_2;

			// Token: 0x0400742F RID: 29743
			[CompilerGenerated]
			private Dictionary<string, int> dictionary_2;

			// Token: 0x04007430 RID: 29744
			[CompilerGenerated]
			private readonly Profile profile_0;

			// Token: 0x02001399 RID: 5017
			private sealed class Class953
			{
				// Token: 0x0600691D RID: 26909 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Proceed()
				{
					throw null;
				}

				// Token: 0x0600691E RID: 26910 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void TryProceedForItem(MagazineClass magazine)
				{
					throw null;
				}

				// Token: 0x0600691F RID: 26911 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private IEnumerator method_0()
				{
					throw null;
				}

				// Token: 0x04007431 RID: 29745
				private readonly MagazineClass gclass2665_0;

				// Token: 0x04007432 RID: 29746
				private readonly float float_0;

				// Token: 0x04007433 RID: 29747
				private readonly Callback callback_0;

				// Token: 0x04007434 RID: 29748
				private bool bool_0;

				// Token: 0x04007435 RID: 29749
				private Coroutine coroutine_0;
			}

			// Token: 0x0200139B RID: 5019
			private sealed class Class955 : Interface16
			{
				// Token: 0x170010FE RID: 4350
				// (get) Token: 0x06006924 RID: 26916 RVA: 0x00002050 File Offset: 0x00000250
				private bool Boolean_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06006925 RID: 26917 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Task<IResult> Start()
				{
					throw null;
				}

				// Token: 0x06006926 RID: 26918 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Proceed(bool success = true)
				{
					throw null;
				}

				// Token: 0x06006927 RID: 26919 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_0()
				{
					throw null;
				}

				// Token: 0x06006928 RID: 26920 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void TryProceedForItem(Item item)
				{
					throw null;
				}

				// Token: 0x06006929 RID: 26921 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_1(CommandStatus status)
				{
					throw null;
				}

				// Token: 0x0600692A RID: 26922 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private Task<IResult> method_2()
				{
					throw null;
				}

				// Token: 0x0600692B RID: 26923 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_3(bool refreshIcon = false)
				{
					throw null;
				}

				// Token: 0x0600692C RID: 26924 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_4()
				{
					throw null;
				}

				// Token: 0x0600692D RID: 26925 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private Task method_5()
				{
					throw null;
				}

				// Token: 0x04007439 RID: 29753
				private readonly InventoryControllerClass gclass2757_0;

				// Token: 0x0400743A RID: 29754
				private readonly MagazineClass gclass2665_0;

				// Token: 0x0400743B RID: 29755
				private readonly BulletClass gclass2732_0;

				// Token: 0x0400743C RID: 29756
				private readonly int int_0;

				// Token: 0x0400743D RID: 29757
				private readonly bool bool_0;

				// Token: 0x0400743E RID: 29758
				private readonly float float_0;

				// Token: 0x0400743F RID: 29759
				private readonly IItemOwner iitemOwner_0;

				// Token: 0x04007440 RID: 29760
				private readonly IItemOwner iitemOwner_1;

				// Token: 0x04007441 RID: 29761
				private CancellationTokenSource cancellationTokenSource_0;

				// Token: 0x04007442 RID: 29762
				private float float_1;

				// Token: 0x0200139C RID: 5020
				[CompilerGenerated]
				private sealed class Class956
				{
					// Token: 0x0600692E RID: 26926 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x04007443 RID: 29763
					public TaskCompletionSource<IResult> cancellationHandlerSource;
				}

				// Token: 0x0200139E RID: 5022
				[CompilerGenerated]
				private sealed class Class957
				{
					// Token: 0x06006931 RID: 26929 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0(IResult res)
					{
						throw null;
					}

					// Token: 0x04007448 RID: 29768
					public TaskCompletionSource<IResult> executionSource;
				}
			}

			// Token: 0x020013A0 RID: 5024
			private sealed class Class958 : Interface16
			{
				// Token: 0x170010FF RID: 4351
				// (get) Token: 0x06006934 RID: 26932 RVA: 0x00002050 File Offset: 0x00000250
				private bool Boolean_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06006935 RID: 26933 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Task<IResult> Start()
				{
					throw null;
				}

				// Token: 0x06006936 RID: 26934 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_0()
				{
					throw null;
				}

				// Token: 0x06006937 RID: 26935 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Proceed(bool success)
				{
					throw null;
				}

				// Token: 0x06006938 RID: 26936 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void TryProceedForItem(Item item)
				{
					throw null;
				}

				// Token: 0x06006939 RID: 26937 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_1()
				{
					throw null;
				}

				// Token: 0x0600693A RID: 26938 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private Task<IResult> method_2()
				{
					throw null;
				}

				// Token: 0x0600693B RID: 26939 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_3(CommandStatus status)
				{
					throw null;
				}

				// Token: 0x0600693C RID: 26940 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private Task method_4()
				{
					throw null;
				}

				// Token: 0x04007451 RID: 29777
				private readonly InventoryControllerClass gclass2757_0;

				// Token: 0x04007452 RID: 29778
				private readonly MagazineClass gclass2665_0;

				// Token: 0x04007453 RID: 29779
				private readonly bool bool_0;

				// Token: 0x04007454 RID: 29780
				private readonly float float_0;

				// Token: 0x04007455 RID: 29781
				private readonly int int_0;

				// Token: 0x04007456 RID: 29782
				private float float_1;

				// Token: 0x04007457 RID: 29783
				private int int_1;

				// Token: 0x04007458 RID: 29784
				private CancellationTokenSource cancellationTokenSource_0;

				// Token: 0x04007459 RID: 29785
				private Item item_0;

				// Token: 0x0400745A RID: 29786
				private Item item_1;

				// Token: 0x020013A1 RID: 5025
				[CompilerGenerated]
				[Serializable]
				private sealed class Class959
				{
					// Token: 0x0600693D RID: 26941 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal int method_0(Item item)
					{
						throw null;
					}

					// Token: 0x0400745B RID: 29787
					public static readonly Player.PlayerInventoryController.Class958.Class959 class959_0;

					// Token: 0x0400745C RID: 29788
					public static Func<Item, int> func_0;
				}

				// Token: 0x020013A2 RID: 5026
				[CompilerGenerated]
				private sealed class Class960
				{
					// Token: 0x0600693E RID: 26942 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x0400745D RID: 29789
					public TaskCompletionSource<IResult> cancellationHandlerSource;
				}

				// Token: 0x020013A4 RID: 5028
				[CompilerGenerated]
				private sealed class Class961
				{
					// Token: 0x06006941 RID: 26945 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0(IResult executeResult)
					{
						throw null;
					}

					// Token: 0x04007462 RID: 29794
					public TaskCompletionSource<IResult> executionSource;
				}
			}

			// Token: 0x020013A6 RID: 5030
			[CompilerGenerated]
			private sealed class Class962
			{
				// Token: 0x06006944 RID: 26948 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_0(ContainerCollection localItem)
				{
					throw null;
				}

				// Token: 0x0400746B RID: 29803
				public Player.PlayerInventoryController playerInventoryController_0;

				// Token: 0x0400746C RID: 29804
				public bool ignoreRestrictions;
			}

			// Token: 0x020013A8 RID: 5032
			[CompilerGenerated]
			private sealed class Class964
			{
				// Token: 0x0600694B RID: 26955 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(Item itemToSubtract)
				{
					throw null;
				}

				// Token: 0x0600694C RID: 26956 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_1(Item localItem, out int preservedNumber)
				{
					throw null;
				}

				// Token: 0x0600694D RID: 26957 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_2(Item localItem)
				{
					throw null;
				}

				// Token: 0x04007475 RID: 29813
				public Player.PlayerInventoryController playerInventoryController_0;

				// Token: 0x04007476 RID: 29814
				public IEnumerable<GStruct368> destroyedItems;
			}

			// Token: 0x020013A9 RID: 5033
			[CompilerGenerated]
			private sealed class Class965
			{
				// Token: 0x0600694E RID: 26958 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(Item itemToAdd)
				{
					throw null;
				}

				// Token: 0x0600694F RID: 26959 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_1(Item localItem)
				{
					throw null;
				}

				// Token: 0x04007477 RID: 29815
				public IEnumerable<GStruct368> destroyedItems;

				// Token: 0x04007478 RID: 29816
				public Player.PlayerInventoryController playerInventoryController_0;
			}

			// Token: 0x020013AA RID: 5034
			[CompilerGenerated]
			private sealed class Class966
			{
				// Token: 0x06006950 RID: 26960 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(IResult result)
				{
					throw null;
				}

				// Token: 0x04007479 RID: 29817
				public MagazineClass magazine;

				// Token: 0x0400747A RID: 29818
				public Player.PlayerInventoryController playerInventoryController_0;

				// Token: 0x0400747B RID: 29819
				public bool notify;

				// Token: 0x0400747C RID: 29820
				public float speed;
			}

			// Token: 0x020013AB RID: 5035
			[CompilerGenerated]
			private sealed class Class967
			{
				// Token: 0x06006951 RID: 26961 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal GClass2765 method_0(GClass2495 grid)
				{
					throw null;
				}

				// Token: 0x06006952 RID: 26962 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_1(IResult result)
				{
					throw null;
				}

				// Token: 0x0400747D RID: 29821
				public BulletClass containedAmmo;

				// Token: 0x0400747E RID: 29822
				public TaskCompletionSource<IResult> taskSource;
			}

			// Token: 0x020013AC RID: 5036
			[CompilerGenerated]
			[Serializable]
			private sealed class Class968
			{
				// Token: 0x06006953 RID: 26963 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_0(GClass2765 g)
				{
					throw null;
				}

				// Token: 0x06006954 RID: 26964 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal int method_1(GClass2765 g)
				{
					throw null;
				}

				// Token: 0x06006955 RID: 26965 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_2(GClass2765 x)
				{
					throw null;
				}

				// Token: 0x06006956 RID: 26966 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal IEnumerable<Item> method_3(IContainer x)
				{
					throw null;
				}

				// Token: 0x06006957 RID: 26967 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_4(Slot x)
				{
					throw null;
				}

				// Token: 0x06006958 RID: 26968 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Item method_5(Slot x)
				{
					throw null;
				}

				// Token: 0x0400747F RID: 29823
				public static readonly Player.PlayerInventoryController.Class968 class968_0;

				// Token: 0x04007480 RID: 29824
				public static Func<GClass2765, bool> func_0;

				// Token: 0x04007481 RID: 29825
				public static Func<GClass2765, int> func_1;

				// Token: 0x04007482 RID: 29826
				public static Func<GClass2765, bool> func_2;

				// Token: 0x04007483 RID: 29827
				public static Func<IContainer, IEnumerable<Item>> func_3;

				// Token: 0x04007484 RID: 29828
				public static Func<Slot, bool> func_4;

				// Token: 0x04007485 RID: 29829
				public static Func<Slot, Item> func_5;
			}

			// Token: 0x020013AE RID: 5038
			[CompilerGenerated]
			private sealed class Class969
			{
				// Token: 0x0600695B RID: 26971 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(IResult result)
				{
					throw null;
				}

				// Token: 0x0600695C RID: 26972 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_1(IResult result)
				{
					throw null;
				}

				// Token: 0x0400748D RID: 29837
				public TaskCompletionSource<IResult> taskSource;
			}

			// Token: 0x020013B3 RID: 5043
			[CompilerGenerated]
			private sealed class Class970
			{
				// Token: 0x06006965 RID: 26981 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(IResult result)
				{
					throw null;
				}

				// Token: 0x040074A8 RID: 29864
				public Callback callback;
			}

			// Token: 0x020013B4 RID: 5044
			[CompilerGenerated]
			private sealed class Class971
			{
				// Token: 0x06006966 RID: 26982 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_0(Item x)
				{
					throw null;
				}

				// Token: 0x06006967 RID: 26983 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_1(Item y)
				{
					throw null;
				}

				// Token: 0x06006968 RID: 26984 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_2(Slot x)
				{
					throw null;
				}

				// Token: 0x040074A9 RID: 29865
				public Player.PlayerInventoryController playerInventoryController_0;

				// Token: 0x040074AA RID: 29866
				public Item item;

				// Token: 0x040074AB RID: 29867
				public ItemAddress to;
			}
		}

		// Token: 0x020013B5 RID: 5045
		public static class GClass1571
		{
			// Token: 0x040074AC RID: 29868
			public const float SPEED_MIN = 0f;

			// Token: 0x040074AD RID: 29869
			public const float SPEED_MAX = 0.7f;

			// Token: 0x040074AE RID: 29870
			public const float MAX_SPRINTING_SPEED = 2f;

			// Token: 0x040074AF RID: 29871
			public const float SPEED_MAX_DELTA = 0.3f;

			// Token: 0x040074B0 RID: 29872
			public static readonly int FIRST_PERSON_ACTION;

			// Token: 0x040074B1 RID: 29873
			public static readonly Vector2 STAND_POSE_ROTATION_PITCH_RANGE;

			// Token: 0x040074B2 RID: 29874
			public static readonly Vector2 PRONE_POSE_ROTATION_PITCH_RANGE;

			// Token: 0x040074B3 RID: 29875
			public static readonly Vector2 ROLL_POSE_ROTATION_PITCH_RANGE;

			// Token: 0x040074B4 RID: 29876
			public static readonly Vector2 FULL_YAW_RANGE;

			// Token: 0x040074B5 RID: 29877
			public const float POSE_RANGE_MIN = 0f;

			// Token: 0x040074B6 RID: 29878
			public const float POSE_RANGE_MAX = 1f;

			// Token: 0x040074B7 RID: 29879
			public const float POSE_THRESHOLD = 0.5f;

			// Token: 0x040074B8 RID: 29880
			public const float TILT_RANGE_MIN = -5f;

			// Token: 0x040074B9 RID: 29881
			public const float TILT_RANGE_MAX = 5f;

			// Token: 0x040074BA RID: 29882
			public const int STEP_RANGE_MIN = -1;

			// Token: 0x040074BB RID: 29883
			public const int STEP_RANGE_MAX = 1;

			// Token: 0x040074BC RID: 29884
			public const float LEAN_SPEED = 5f;

			// Token: 0x040074BD RID: 29885
			public const float SLOW_LEEN_SPEED = 0.1f;
		}

		// Token: 0x020013B6 RID: 5046
		public enum EMouseSensitivityModifier
		{
			// Token: 0x040074BF RID: 29887
			Armor
		}

		// Token: 0x020013B7 RID: 5047
		public enum LeanType
		{
			// Token: 0x040074C1 RID: 29889
			NormalLean,
			// Token: 0x040074C2 RID: 29890
			SlowLean
		}

		// Token: 0x020013B8 RID: 5048
		public enum ESpeedLimit
		{
			// Token: 0x040074C4 RID: 29892
			BarbedWire,
			// Token: 0x040074C5 RID: 29893
			HealthCondition,
			// Token: 0x040074C6 RID: 29894
			Aiming,
			// Token: 0x040074C7 RID: 29895
			Weight,
			// Token: 0x040074C8 RID: 29896
			SurfaceNormal,
			// Token: 0x040074C9 RID: 29897
			Swamp,
			// Token: 0x040074CA RID: 29898
			Shot,
			// Token: 0x040074CB RID: 29899
			Armor,
			// Token: 0x040074CC RID: 29900
			Fall
		}

		// Token: 0x020013B9 RID: 5049
		[Serializable]
		public class ValueBlender
		{
			// Token: 0x17001102 RID: 4354
			// (get) Token: 0x06006969 RID: 26985 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600696A RID: 26986 RVA: 0x00002050 File Offset: 0x00000250
			public virtual float Target
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

			// Token: 0x17001103 RID: 4355
			// (get) Token: 0x0600696B RID: 26987 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600696C RID: 26988 RVA: 0x00002050 File Offset: 0x00000250
			public virtual float Value
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

			// Token: 0x040074CD RID: 29901
			protected float _target;

			// Token: 0x040074CE RID: 29902
			protected float _startTime;

			// Token: 0x040074CF RID: 29903
			protected float _startValue;

			// Token: 0x040074D0 RID: 29904
			public float Speed;
		}

		// Token: 0x020013BA RID: 5050
		[Serializable]
		public class BetterValueBlender : Player.ValueBlender
		{
			// Token: 0x17001104 RID: 4356
			// (get) Token: 0x0600696D RID: 26989 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600696E RID: 26990 RVA: 0x00002050 File Offset: 0x00000250
			public override float Value
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

			// Token: 0x0600696F RID: 26991 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ChangeValue(float value, float delay)
			{
				throw null;
			}
		}

		// Token: 0x020013BB RID: 5051
		[Serializable]
		public class ValueBlenderDelay : Player.ValueBlender
		{
			// Token: 0x17001105 RID: 4357
			// (get) Token: 0x06006970 RID: 26992 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06006971 RID: 26993 RVA: 0x00002050 File Offset: 0x00000250
			public override float Target
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

			// Token: 0x040074D1 RID: 29905
			public float Delay;
		}

		// Token: 0x020013BC RID: 5052
		// (Invoke) Token: 0x06006972 RID: 26994
		public delegate void GDelegate55(float damage, EBodyPart part, EDamageType type, float absorbed, MaterialType special);

		// Token: 0x020013BD RID: 5053
		public class GClass1572
		{
			// Token: 0x06006975 RID: 26997 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RemovePhysics()
			{
				throw null;
			}

			// Token: 0x06006976 RID: 26998 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RestoreShift()
			{
				throw null;
			}

			// Token: 0x06006977 RID: 26999 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Destroy()
			{
				throw null;
			}

			// Token: 0x040074D2 RID: 29906
			public Vector3 Shift;

			// Token: 0x040074D3 RID: 29907
			public Transform Transform;

			// Token: 0x040074D4 RID: 29908
			public CommonTransportee Transportee;
		}

		// Token: 0x020013BE RID: 5054
		internal class EmptyHandsController : Player.ItemHandsController, GInterface123, GInterface124, GInterface125
		{
			// Token: 0x17001106 RID: 4358
			// (get) Token: 0x06006978 RID: 27000 RVA: 0x00002050 File Offset: 0x00000250
			protected Player.EmptyHandsController.Class1008 Class1008_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001107 RID: 4359
			// (get) Token: 0x06006979 RID: 27001 RVA: 0x00002050 File Offset: 0x00000250
			protected virtual bool Boolean_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001108 RID: 4360
			// (get) Token: 0x0600697A RID: 27002 RVA: 0x00002050 File Offset: 0x00000250
			public override FirearmsAnimator FirearmsAnimator
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001109 RID: 4361
			// (get) Token: 0x0600697B RID: 27003 RVA: 0x00002050 File Offset: 0x00000250
			public override string LoggerDistinctId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700110A RID: 4362
			// (get) Token: 0x0600697C RID: 27004 RVA: 0x00002050 File Offset: 0x00000250
			public new GClass2736 Item
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600697D RID: 27005 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override float GetAnimatorFloatParam(int hash)
			{
				throw null;
			}

			// Token: 0x0600697E RID: 27006 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool SupportPickup()
			{
				throw null;
			}

			// Token: 0x0600697F RID: 27007 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Pickup(bool p)
			{
				throw null;
			}

			// Token: 0x06006980 RID: 27008 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Interact(bool isInteracting, int actionIndex)
			{
				throw null;
			}

			// Token: 0x06006981 RID: 27009 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetInventoryOpened(bool opened)
			{
				throw null;
			}

			// Token: 0x06006982 RID: 27010 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Loot(bool p)
			{
				throw null;
			}

			// Token: 0x06006983 RID: 27011 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInInteraction()
			{
				throw null;
			}

			// Token: 0x06006984 RID: 27012 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInInteractionStrictCheck()
			{
				throw null;
			}

			// Token: 0x06006985 RID: 27013 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Destroy()
			{
				throw null;
			}

			// Token: 0x06006986 RID: 27014 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanExecute(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06006987 RID: 27015 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Execute(GInterface336 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006988 RID: 27016 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ExamineWeapon()
			{
				throw null;
			}

			// Token: 0x06006989 RID: 27017 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetCompassState(bool active)
			{
				throw null;
			}

			// Token: 0x0600698A RID: 27018 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanRemove()
			{
				throw null;
			}

			// Token: 0x0600698B RID: 27019 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ShowGesture(EGesture gesture)
			{
				throw null;
			}

			// Token: 0x0600698C RID: 27020 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_5<T>(Player player) where T : Player.EmptyHandsController
			{
				throw null;
			}

			// Token: 0x0600698D RID: 27021 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Task<T> smethod_6<T>(Player player) where T : Player.EmptyHandsController
			{
				throw null;
			}

			// Token: 0x0600698E RID: 27022 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static void smethod_7<T>(T controller, Player player) where T : Player.EmptyHandsController
			{
				throw null;
			}

			// Token: 0x0600698F RID: 27023 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapIn()
			{
				throw null;
			}

			// Token: 0x06006990 RID: 27024 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapOut()
			{
				throw null;
			}

			// Token: 0x06006991 RID: 27025 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnThirdAction(int intParam)
			{
				throw null;
			}

			// Token: 0x06006992 RID: 27026 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsOnBackpackDrop()
			{
				throw null;
			}

			// Token: 0x06006993 RID: 27027 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnOnUseProp(bool boolParam)
			{
				throw null;
			}

			// Token: 0x06006994 RID: 27028 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInventoryOpen()
			{
				throw null;
			}

			// Token: 0x06006995 RID: 27029 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void FastForwardCurrentState()
			{
				throw null;
			}

			// Token: 0x06006996 RID: 27030 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0()
			{
				throw null;
			}

			// Token: 0x06006997 RID: 27031 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_1()
			{
				throw null;
			}

			// Token: 0x06006998 RID: 27032 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_2()
			{
				throw null;
			}

			// Token: 0x06006999 RID: 27033 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Spawn(float animationSpeed, Action callback)
			{
				throw null;
			}

			// Token: 0x0600699A RID: 27034 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ManualUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600699B RID: 27035 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null)
			{
				throw null;
			}

			// Token: 0x0600699C RID: 27036 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private IEnumerator method_3(Action callback)
			{
				throw null;
			}

			// Token: 0x0600699D RID: 27037 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_4()
			{
				throw null;
			}

			// Token: 0x0600699E RID: 27038 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_5()
			{
				throw null;
			}

			// Token: 0x0600699F RID: 27039 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_6()
			{
				throw null;
			}

			// Token: 0x060069A0 RID: 27040 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_7()
			{
				throw null;
			}

			// Token: 0x040074D5 RID: 29909
			private GClass1664 gclass1664_0;

			// Token: 0x040074D6 RID: 29910
			private FirearmsAnimator firearmsAnimator_0;

			// Token: 0x040074D7 RID: 29911
			private bool bool_0;

			// Token: 0x020013BF RID: 5055
			public class Class1009 : Player.EmptyHandsController.Class1008
			{
				// Token: 0x060069A1 RID: 27041 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x060069A2 RID: 27042 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x060069A3 RID: 27043 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnBackpackDrop()
				{
					throw null;
				}

				// Token: 0x060069A4 RID: 27044 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x040074D8 RID: 29912
				private Callback callback_0;
			}

			// Token: 0x020013C0 RID: 5056
			public abstract class Class1008 : Player.GClass1580
			{
				// Token: 0x060069A5 RID: 27045 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public new void Start()
				{
					throw null;
				}

				// Token: 0x060069A6 RID: 27046 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void HideWeaponComplete()
				{
					throw null;
				}

				// Token: 0x060069A7 RID: 27047 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void WeaponAppeared()
				{
					throw null;
				}

				// Token: 0x060069A8 RID: 27048 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnBackpackDrop()
				{
					throw null;
				}

				// Token: 0x060069A9 RID: 27049 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void HideWeapon(Action onHidden)
				{
					throw null;
				}

				// Token: 0x060069AA RID: 27050 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x060069AB RID: 27051 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetEmptyHandsCompassState(bool active)
				{
					throw null;
				}

				// Token: 0x060069AC RID: 27052 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void FastForward()
				{
					throw null;
				}

				// Token: 0x060069AD RID: 27053 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x060069AE RID: 27054 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool CanExecute(GInterface336 operation)
				{
					throw null;
				}

				// Token: 0x060069AF RID: 27055 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Execute(GInterface336 operation, Callback callback)
				{
					throw null;
				}

				// Token: 0x040074D9 RID: 29913
				protected readonly Player player_0;

				// Token: 0x040074DA RID: 29914
				protected readonly Player.EmptyHandsController emptyHandsController_0;
			}

			// Token: 0x020013C1 RID: 5057
			public class Class1011 : Player.EmptyHandsController.Class1008
			{
				// Token: 0x060069B0 RID: 27056 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public new void Start()
				{
					throw null;
				}

				// Token: 0x060069B1 RID: 27057 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x060069B2 RID: 27058 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden)
				{
					throw null;
				}

				// Token: 0x060069B3 RID: 27059 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnEnd()
				{
					throw null;
				}

				// Token: 0x060069B4 RID: 27060 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanExecute(GInterface336 operation)
				{
					throw null;
				}

				// Token: 0x060069B5 RID: 27061 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Execute(GInterface336 operation, Callback callback)
				{
					throw null;
				}

				// Token: 0x060069B6 RID: 27062 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x060069B7 RID: 27063 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x060069B8 RID: 27064 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetEmptyHandsCompassState(bool active)
				{
					throw null;
				}

				// Token: 0x040074DB RID: 29915
				private const float float_0 = 300f;

				// Token: 0x040074DC RID: 29916
				private float float_1;
			}

			// Token: 0x020013C2 RID: 5058
			private sealed class Class1012 : Player.EmptyHandsController.Class1008
			{
				// Token: 0x060069B9 RID: 27065 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Action onHidden)
				{
					throw null;
				}

				// Token: 0x060069BA RID: 27066 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x060069BB RID: 27067 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanExecute(GInterface336 operation)
				{
					throw null;
				}

				// Token: 0x060069BC RID: 27068 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Execute(GInterface336 operation, Callback callback)
				{
					throw null;
				}

				// Token: 0x060069BD RID: 27069 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeaponComplete()
				{
					throw null;
				}

				// Token: 0x060069BE RID: 27070 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden)
				{
					throw null;
				}

				// Token: 0x060069BF RID: 27071 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x040074DD RID: 29917
				private Action action_0;
			}

			// Token: 0x020013C3 RID: 5059
			public sealed class Class1010 : Player.EmptyHandsController.Class1009
			{
				// Token: 0x060069C0 RID: 27072 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x060069C1 RID: 27073 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x060069C2 RID: 27074 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x040074DE RID: 29918
				private const float float_0 = 0.01f;

				// Token: 0x040074DF RID: 29919
				private float float_1;

				// Token: 0x040074E0 RID: 29920
				private bool bool_0;
			}

			// Token: 0x020013C4 RID: 5060
			public sealed class Class1013 : Player.EmptyHandsController.Class1008
			{
				// Token: 0x060069C3 RID: 27075 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Action callback)
				{
					throw null;
				}

				// Token: 0x060069C4 RID: 27076 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x060069C5 RID: 27077 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void WeaponAppeared()
				{
					throw null;
				}

				// Token: 0x060069C6 RID: 27078 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden)
				{
					throw null;
				}

				// Token: 0x060069C7 RID: 27079 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x060069C8 RID: 27080 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x040074E1 RID: 29921
				private Action action_0;

				// Token: 0x040074E2 RID: 29922
				private bool bool_0;

				// Token: 0x040074E3 RID: 29923
				private Action action_1;
			}

			// Token: 0x020013C6 RID: 5062
			[CompilerGenerated]
			private sealed class Class972<T> where T : Player.EmptyHandsController
			{
				// Token: 0x060069CB RID: 27083 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x040074E8 RID: 29928
				public T controller;
			}

			// Token: 0x020013C7 RID: 5063
			[CompilerGenerated]
			private sealed class Class973
			{
				// Token: 0x060069CC RID: 27084 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x040074E9 RID: 29929
				public Player.EmptyHandsController emptyHandsController_0;

				// Token: 0x040074EA RID: 29930
				public Action callback;
			}

			// Token: 0x020013C8 RID: 5064
			[CompilerGenerated]
			private sealed class Class974
			{
				// Token: 0x060069CD RID: 27085 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x040074EB RID: 29931
				public Action callback;
			}
		}

		// Token: 0x020013CA RID: 5066
		public class FirearmController : Player.ItemHandsController, GInterface123, GInterface124, GInterface126, GInterface127, IFirearmHandsController
		{
			// Token: 0x060069D2 RID: 27090 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public float GetTotalMalfunctionChance(BulletClass ammoToFire, float overheat, out double durabilityMalfChance, out float magMalfChance, out float ammoMalfChance, out float overheatMalfChance, out float weaponDurability)
			{
				throw null;
			}

			// Token: 0x060069D3 RID: 27091 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public float GetNextMalfunctionRandom()
			{
				throw null;
			}

			// Token: 0x060069D4 RID: 27092 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void GetMalfunctionSources(List<GClass722<Weapon.EMalfunctionSource>.GStruct42<float, Weapon.EMalfunctionSource>> result, double durabilityMalfChance, float magMalfChance, float ammoMalfChance, float overheatMalfChance, bool hasAmmoInMag, bool isMagazineInserted)
			{
				throw null;
			}

			// Token: 0x060069D5 RID: 27093 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void GetSpecificMalfunctionVariants(List<GClass722<Weapon.EMalfunctionState>.GStruct42<float, Weapon.EMalfunctionState>> result, BulletClass ammo, Weapon.EMalfunctionSource malfunctionSource, float weaponDurability, bool hasAmmoInMag, bool isMagazineInserted, bool shouldCheckJam)
			{
				throw null;
			}

			// Token: 0x060069D6 RID: 27094 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Weapon.EMalfunctionState GetMalfunctionState(BulletClass ammoToFire, bool hasAmmoInMag, bool doesWeaponHaveBoltCatch, bool isMagazineInserted, float overheat, float fixSlideOverheat, out Weapon.EMalfunctionSource malfunctionSource)
			{
				throw null;
			}

			// Token: 0x14000136 RID: 310
			// (add) Token: 0x060069D7 RID: 27095 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x060069D8 RID: 27096 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnShot
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

			// Token: 0x14000137 RID: 311
			// (add) Token: 0x060069D9 RID: 27097 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x060069DA RID: 27098 RVA: 0x00002050 File Offset: 0x00000250
			public event Action<Player.FirearmController> OnReadyToOperate
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

			// Token: 0x14000138 RID: 312
			// (add) Token: 0x060069DB RID: 27099 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x060069DC RID: 27100 RVA: 0x00002050 File Offset: 0x00000250
			public event Action BreakLoop
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

			// Token: 0x1700110D RID: 4365
			// (get) Token: 0x060069DD RID: 27101 RVA: 0x00002050 File Offset: 0x00000250
			public new Weapon Item
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700110E RID: 4366
			// (get) Token: 0x060069DE RID: 27102 RVA: 0x00002050 File Offset: 0x00000250
			public override FirearmsAnimator FirearmsAnimator
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700110F RID: 4367
			// (get) Token: 0x060069DF RID: 27103 RVA: 0x00002050 File Offset: 0x00000250
			public override string LoggerDistinctId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001110 RID: 4368
			// (get) Token: 0x060069E0 RID: 27104 RVA: 0x00002050 File Offset: 0x00000250
			public SkillManager.GClass1768 BuffInfo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001111 RID: 4369
			// (get) Token: 0x060069E1 RID: 27105 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsOverlap
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001112 RID: 4370
			// (get) Token: 0x060069E2 RID: 27106 RVA: 0x00002050 File Offset: 0x00000250
			public float OverlapValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001113 RID: 4371
			// (get) Token: 0x060069E3 RID: 27107 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060069E4 RID: 27108 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsSilenced
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

			// Token: 0x17001114 RID: 4372
			// (get) Token: 0x060069E5 RID: 27109 RVA: 0x00002050 File Offset: 0x00000250
			public int CurrentMasteringLevel
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001115 RID: 4373
			// (get) Token: 0x060069E6 RID: 27110 RVA: 0x00002050 File Offset: 0x00000250
			public float TotalErgonomics
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001116 RID: 4374
			// (get) Token: 0x060069E7 RID: 27111 RVA: 0x00002050 File Offset: 0x00000250
			public float ErgonomicWeight
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001117 RID: 4375
			// (get) Token: 0x060069E8 RID: 27112 RVA: 0x00002050 File Offset: 0x00000250
			public BifacialTransform CurrentFireport
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001118 RID: 4376
			// (get) Token: 0x060069E9 RID: 27113 RVA: 0x00002050 File Offset: 0x00000250
			public override float AimingSensitivity
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001119 RID: 4377
			// (get) Token: 0x060069EA RID: 27114 RVA: 0x00002050 File Offset: 0x00000250
			public virtual Vector3 WeaponDirection
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700111A RID: 4378
			// (get) Token: 0x060069EB RID: 27115 RVA: 0x00002050 File Offset: 0x00000250
			public Weapon Weapon
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700111B RID: 4379
			// (get) Token: 0x060069EC RID: 27116 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 FireportPosition
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700111C RID: 4380
			// (get) Token: 0x060069ED RID: 27117 RVA: 0x00002050 File Offset: 0x00000250
			public bool MouseLookControl
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700111D RID: 4381
			// (get) Token: 0x060069EE RID: 27118 RVA: 0x00002050 File Offset: 0x00000250
			public WeaponSoundPlayer WeaponSoundPlayer
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700111E RID: 4382
			// (get) Token: 0x060069EF RID: 27119 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060069F0 RID: 27120 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsBirstOf2Start
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

			// Token: 0x1700111F RID: 4383
			// (get) Token: 0x060069F1 RID: 27121 RVA: 0x00002050 File Offset: 0x00000250
			protected bool IsStationaryWeapon
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001120 RID: 4384
			// (get) Token: 0x060069F2 RID: 27122 RVA: 0x00002050 File Offset: 0x00000250
			protected Player.FirearmController.GClass1581 CurrentOperation
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001121 RID: 4385
			// (get) Token: 0x060069F3 RID: 27123 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060069F4 RID: 27124 RVA: 0x00002050 File Offset: 0x00000250
			protected internal virtual bool IsTriggerPressed
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

			// Token: 0x17001122 RID: 4386
			// (get) Token: 0x060069F5 RID: 27125 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060069F6 RID: 27126 RVA: 0x00002050 File Offset: 0x00000250
			public override bool IsAiming
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected set
				{
					throw null;
				}
			}

			// Token: 0x17001123 RID: 4387
			// (get) Token: 0x060069F7 RID: 27127 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060069F8 RID: 27128 RVA: 0x00002050 File Offset: 0x00000250
			public bool Malfunction
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

			// Token: 0x17001124 RID: 4388
			// (get) Token: 0x060069F9 RID: 27129 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060069FA RID: 27130 RVA: 0x00002050 File Offset: 0x00000250
			public bool InventoryOpened
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

			// Token: 0x17001125 RID: 4389
			// (get) Token: 0x060069FB RID: 27131 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060069FC RID: 27132 RVA: 0x00002050 File Offset: 0x00000250
			public bool Blindfire
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

			// Token: 0x060069FD RID: 27133 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_5<T>(Player player, Weapon weapon) where T : Player.FirearmController
			{
				throw null;
			}

			// Token: 0x060069FE RID: 27134 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Task<T> smethod_6<T>(Player player, Weapon weapon) where T : Player.FirearmController
			{
				throw null;
			}

			// Token: 0x060069FF RID: 27135 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static Task smethod_7<T>(T controller, Player player, Weapon weapon, bool async = true) where T : Player.FirearmController
			{
				throw null;
			}

			// Token: 0x06006A02 RID: 27138 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_1(EPhysicalCondition condition, EPhysicalCondition full)
			{
				throw null;
			}

			// Token: 0x06006A03 RID: 27139 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void OnCurrentWeaponBeingMastered(GClass1764 m)
			{
				throw null;
			}

			// Token: 0x06006A04 RID: 27140 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public float GetWeaponDrawSpeedMultiplier(Weapon weapon, bool useFastDropAnimationSpeed)
			{
				throw null;
			}

			// Token: 0x06006A05 RID: 27141 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool CheckForFastWeaponSwitch(Item nextControllerItem)
			{
				throw null;
			}

			// Token: 0x06006A06 RID: 27142 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetAnimatorAndProceduralValues()
			{
				throw null;
			}

			// Token: 0x06006A07 RID: 27143 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SyncWithCharacterSkills()
			{
				throw null;
			}

			// Token: 0x06006A08 RID: 27144 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_2()
			{
				throw null;
			}

			// Token: 0x06006A09 RID: 27145 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateSensitivity()
			{
				throw null;
			}

			// Token: 0x06006A0A RID: 27146 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_3()
			{
				throw null;
			}

			// Token: 0x06006A0B RID: 27147 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_4(GClass2664 underbarrelWeapon, GameObject _weaponPrefab)
			{
				throw null;
			}

			// Token: 0x06006A0C RID: 27148 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_5()
			{
				throw null;
			}

			// Token: 0x06006A0D RID: 27149 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_6()
			{
				throw null;
			}

			// Token: 0x06006A0E RID: 27150 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_7()
			{
				throw null;
			}

			// Token: 0x06006A0F RID: 27151 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_8(Vector3 origin, float ln, ref bool overlapsWithPlayer, Vector3? weaponUp = null)
			{
				throw null;
			}

			// Token: 0x06006A10 RID: 27152 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_9()
			{
				throw null;
			}

			// Token: 0x06006A11 RID: 27153 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_10()
			{
				throw null;
			}

			// Token: 0x06006A12 RID: 27154 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ReloadMagNotFound()
			{
				throw null;
			}

			// Token: 0x06006A13 RID: 27155 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_11()
			{
				throw null;
			}

			// Token: 0x06006A14 RID: 27156 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateHipInaccuracy()
			{
				throw null;
			}

			// Token: 0x06006A15 RID: 27157 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetUnderbarrelWeapon()
			{
				throw null;
			}

			// Token: 0x06006A16 RID: 27158 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void WeaponModified()
			{
				throw null;
			}

			// Token: 0x06006A17 RID: 27159 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RecalculateErgonomic()
			{
				throw null;
			}

			// Token: 0x06006A18 RID: 27160 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetMaxUniqueAnimationModId()
			{
				throw null;
			}

			// Token: 0x06006A19 RID: 27161 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override float GetAnimatorFloatParam(int hash)
			{
				throw null;
			}

			// Token: 0x06006A1A RID: 27162 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_12(RaycastHit overlapHit)
			{
				throw null;
			}

			// Token: 0x17001126 RID: 4390
			// (get) Token: 0x06006A1B RID: 27163 RVA: 0x00002050 File Offset: 0x00000250
			public bool DisableLeftStanceByOverlap
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006A1C RID: 27164 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void WeaponOverlapping()
			{
				throw null;
			}

			// Token: 0x06006A1D RID: 27165 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_13(bool value)
			{
				throw null;
			}

			// Token: 0x06006A1E RID: 27166 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_14(EPlayerState previousstate, EPlayerState nextstate)
			{
				throw null;
			}

			// Token: 0x06006A1F RID: 27167 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool AudioDelegate()
			{
				throw null;
			}

			// Token: 0x06006A20 RID: 27168 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void InitBallisticCalculator()
			{
				throw null;
			}

			// Token: 0x06006A21 RID: 27169 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetWeaponOverlapValue(float overlap)
			{
				throw null;
			}

			// Token: 0x06006A22 RID: 27170 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void WeaponOverlapView()
			{
				throw null;
			}

			// Token: 0x06006A23 RID: 27171 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_15()
			{
				throw null;
			}

			// Token: 0x06006A24 RID: 27172 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapIn()
			{
				throw null;
			}

			// Token: 0x06006A25 RID: 27173 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapOut()
			{
				throw null;
			}

			// Token: 0x06006A26 RID: 27174 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnThirdAction(int intParam)
			{
				throw null;
			}

			// Token: 0x06006A27 RID: 27175 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnAddAmmoInChamber()
			{
				throw null;
			}

			// Token: 0x06006A28 RID: 27176 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnRemoveShell()
			{
				throw null;
			}

			// Token: 0x06006A29 RID: 27177 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnShellEject()
			{
				throw null;
			}

			// Token: 0x06006A2A RID: 27178 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnAddAmmoInMag()
			{
				throw null;
			}

			// Token: 0x06006A2B RID: 27179 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnDelAmmoFromMag()
			{
				throw null;
			}

			// Token: 0x06006A2C RID: 27180 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnShowAmmo(bool boolParam)
			{
				throw null;
			}

			// Token: 0x06006A2D RID: 27181 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnDelAmmoChamber()
			{
				throw null;
			}

			// Token: 0x06006A2E RID: 27182 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnMagIn()
			{
				throw null;
			}

			// Token: 0x06006A2F RID: 27183 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnMagOut()
			{
				throw null;
			}

			// Token: 0x06006A30 RID: 27184 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnMagShow()
			{
				throw null;
			}

			// Token: 0x06006A31 RID: 27185 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnMagHide()
			{
				throw null;
			}

			// Token: 0x06006A32 RID: 27186 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnOffBoltCatch()
			{
				throw null;
			}

			// Token: 0x06006A33 RID: 27187 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnOnBoltCatch()
			{
				throw null;
			}

			// Token: 0x06006A34 RID: 27188 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnMalfunctionOff()
			{
				throw null;
			}

			// Token: 0x06006A35 RID: 27189 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnFiringBullet()
			{
				throw null;
			}

			// Token: 0x06006A36 RID: 27190 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnFireEnd()
			{
				throw null;
			}

			// Token: 0x06006A37 RID: 27191 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnIdleStart()
			{
				throw null;
			}

			// Token: 0x06006A38 RID: 27192 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnUseSecondMagForReload()
			{
				throw null;
			}

			// Token: 0x06006A39 RID: 27193 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnReplaceSecondMag()
			{
				throw null;
			}

			// Token: 0x06006A3A RID: 27194 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnPutMagToRig()
			{
				throw null;
			}

			// Token: 0x06006A3B RID: 27195 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnModChanged()
			{
				throw null;
			}

			// Token: 0x06006A3C RID: 27196 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnLauncherAppeared()
			{
				throw null;
			}

			// Token: 0x06006A3D RID: 27197 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnLauncherDisappeared()
			{
				throw null;
			}

			// Token: 0x06006A3E RID: 27198 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnArm()
			{
				throw null;
			}

			// Token: 0x06006A3F RID: 27199 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnDisarm()
			{
				throw null;
			}

			// Token: 0x06006A40 RID: 27200 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnFoldOn()
			{
				throw null;
			}

			// Token: 0x06006A41 RID: 27201 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnFoldOff()
			{
				throw null;
			}

			// Token: 0x06006A42 RID: 27202 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsOnBackpackDrop()
			{
				throw null;
			}

			// Token: 0x06006A43 RID: 27203 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnStartUtilityOperation()
			{
				throw null;
			}

			// Token: 0x06006A44 RID: 27204 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnOnUseProp(bool boolParam)
			{
				throw null;
			}

			// Token: 0x06006A45 RID: 27205 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_16(bool b)
			{
				throw null;
			}

			// Token: 0x06006A46 RID: 27206 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanExecute(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06006A47 RID: 27207 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_17(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06006A48 RID: 27208 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Execute(GInterface336 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006A49 RID: 27209 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_18(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06006A4A RID: 27210 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_19()
			{
				throw null;
			}

			// Token: 0x06006A4B RID: 27211 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_20()
			{
				throw null;
			}

			// Token: 0x06006A4C RID: 27212 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_21()
			{
				throw null;
			}

			// Token: 0x06006A4D RID: 27213 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_22()
			{
				throw null;
			}

			// Token: 0x06006A4E RID: 27214 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_23()
			{
				throw null;
			}

			// Token: 0x06006A4F RID: 27215 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_24()
			{
				throw null;
			}

			// Token: 0x06006A50 RID: 27216 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_25()
			{
				throw null;
			}

			// Token: 0x06006A51 RID: 27217 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_26()
			{
				throw null;
			}

			// Token: 0x06006A52 RID: 27218 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_27()
			{
				throw null;
			}

			// Token: 0x06006A53 RID: 27219 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_28()
			{
				throw null;
			}

			// Token: 0x06006A54 RID: 27220 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_29()
			{
				throw null;
			}

			// Token: 0x06006A55 RID: 27221 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_30()
			{
				throw null;
			}

			// Token: 0x06006A56 RID: 27222 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_31()
			{
				throw null;
			}

			// Token: 0x06006A57 RID: 27223 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_32()
			{
				throw null;
			}

			// Token: 0x06006A58 RID: 27224 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_33()
			{
				throw null;
			}

			// Token: 0x06006A59 RID: 27225 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_34()
			{
				throw null;
			}

			// Token: 0x06006A5A RID: 27226 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_35()
			{
				throw null;
			}

			// Token: 0x06006A5B RID: 27227 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_36(bool b)
			{
				throw null;
			}

			// Token: 0x06006A5C RID: 27228 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_37(bool isCatched)
			{
				throw null;
			}

			// Token: 0x06006A5D RID: 27229 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_38()
			{
				throw null;
			}

			// Token: 0x06006A5E RID: 27230 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_39()
			{
				throw null;
			}

			// Token: 0x06006A5F RID: 27231 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_40()
			{
				throw null;
			}

			// Token: 0x06006A60 RID: 27232 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_41()
			{
				throw null;
			}

			// Token: 0x06006A61 RID: 27233 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_42()
			{
				throw null;
			}

			// Token: 0x06006A62 RID: 27234 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_43()
			{
				throw null;
			}

			// Token: 0x06006A63 RID: 27235 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_44()
			{
				throw null;
			}

			// Token: 0x06006A64 RID: 27236 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_45()
			{
				throw null;
			}

			// Token: 0x06006A65 RID: 27237 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_46()
			{
				throw null;
			}

			// Token: 0x06006A66 RID: 27238 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_47()
			{
				throw null;
			}

			// Token: 0x06006A67 RID: 27239 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_48(bool armed)
			{
				throw null;
			}

			// Token: 0x06006A68 RID: 27240 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Spawn(float animationSpeed, Action callback)
			{
				throw null;
			}

			// Token: 0x06006A69 RID: 27241 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null)
			{
				throw null;
			}

			// Token: 0x06006A6A RID: 27242 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void RemoveBallisticCalculator()
			{
				throw null;
			}

			// Token: 0x06006A6B RID: 27243 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Destroy()
			{
				throw null;
			}

			// Token: 0x06006A6C RID: 27244 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool SupportPickup()
			{
				throw null;
			}

			// Token: 0x06006A6D RID: 27245 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Pickup(bool p)
			{
				throw null;
			}

			// Token: 0x06006A6E RID: 27246 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Interact(bool isInteracting, int actionIndex)
			{
				throw null;
			}

			// Token: 0x06006A6F RID: 27247 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanInteract()
			{
				throw null;
			}

			// Token: 0x06006A70 RID: 27248 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool InCanNotBeInterruptedOperation()
			{
				throw null;
			}

			// Token: 0x06006A71 RID: 27249 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Loot(bool p)
			{
				throw null;
			}

			// Token: 0x06006A72 RID: 27250 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInInteraction()
			{
				throw null;
			}

			// Token: 0x06006A73 RID: 27251 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInInteractionStrictCheck()
			{
				throw null;
			}

			// Token: 0x06006A74 RID: 27252 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void UnderbarrelSightingRangeDown()
			{
				throw null;
			}

			// Token: 0x06006A75 RID: 27253 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void UnderbarrelSightingRangeUp()
			{
				throw null;
			}

			// Token: 0x06006A76 RID: 27254 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool IsInLauncherMode()
			{
				throw null;
			}

			// Token: 0x06006A77 RID: 27255 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool ToggleLauncher()
			{
				throw null;
			}

			// Token: 0x06006A78 RID: 27256 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ChangeLeftStance()
			{
				throw null;
			}

			// Token: 0x06006A79 RID: 27257 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetTriggerPressed(bool pressed)
			{
				throw null;
			}

			// Token: 0x06006A7A RID: 27258 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_49()
			{
				throw null;
			}

			// Token: 0x06006A7B RID: 27259 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool CanPressTrigger()
			{
				throw null;
			}

			// Token: 0x06006A7C RID: 27260 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ToggleAim()
			{
				throw null;
			}

			// Token: 0x06006A7D RID: 27261 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetAim(int scopeIndex)
			{
				throw null;
			}

			// Token: 0x06006A7E RID: 27262 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetAim(bool value)
			{
				throw null;
			}

			// Token: 0x06006A7F RID: 27263 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetInventoryOpened(bool opened)
			{
				throw null;
			}

			// Token: 0x06006A80 RID: 27264 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInventoryOpen()
			{
				throw null;
			}

			// Token: 0x06006A81 RID: 27265 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ChangeAimingMode()
			{
				throw null;
			}

			// Token: 0x06006A82 RID: 27266 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool ChangeFireMode(Weapon.EFireMode fireMode)
			{
				throw null;
			}

			// Token: 0x06006A83 RID: 27267 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool CheckFireMode()
			{
				throw null;
			}

			// Token: 0x06006A84 RID: 27268 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool ExamineWeapon()
			{
				throw null;
			}

			// Token: 0x06006A85 RID: 27269 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void RollCylinder(bool rollToZeroCamora)
			{
				throw null;
			}

			// Token: 0x06006A86 RID: 27270 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool CheckAmmo()
			{
				throw null;
			}

			// Token: 0x06006A87 RID: 27271 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool CheckChamber()
			{
				throw null;
			}

			// Token: 0x06006A88 RID: 27272 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ReloadMag(MagazineClass magazine, GClass2765 gridItemAddress, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006A89 RID: 27273 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void QuickReloadMag(MagazineClass magazine, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006A8A RID: 27274 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ReloadGrenadeLauncher(GClass2491 foundItem, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006A8B RID: 27275 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ReloadCylinderMagazine(GClass2491 ammoPack, Callback callback, bool quickReload = false)
			{
				throw null;
			}

			// Token: 0x06006A8C RID: 27276 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ReloadWithAmmo(GClass2491 ammoPack, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006A8D RID: 27277 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ReloadBarrels(GClass2491 ammoPack, GClass2765 placeToPutContainedAmmoMagazine, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006A8E RID: 27278 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool CanStartReload()
			{
				throw null;
			}

			// Token: 0x06006A8F RID: 27279 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool ShouldForceQuickReload()
			{
				throw null;
			}

			// Token: 0x06006A90 RID: 27280 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ManualUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x06006A91 RID: 27281 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Dictionary<string, LightComponent> GetCurrentLightStatus()
			{
				throw null;
			}

			// Token: 0x06006A92 RID: 27282 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Dictionary<string, SightComponent> GetCurrentScopesStatus()
			{
				throw null;
			}

			// Token: 0x06006A93 RID: 27283 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetLightsState(GStruct162[] lightsStates, bool force = false)
			{
				throw null;
			}

			// Token: 0x06006A94 RID: 27284 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanRemove()
			{
				throw null;
			}

			// Token: 0x06006A95 RID: 27285 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetScopeMode(GStruct163[] scopeStates)
			{
				throw null;
			}

			// Token: 0x06006A96 RID: 27286 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsHandsProcessing()
			{
				throw null;
			}

			// Token: 0x06006A97 RID: 27287 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ShowGesture(EGesture gesture)
			{
				throw null;
			}

			// Token: 0x06006A98 RID: 27288 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void BlindFire(int b)
			{
				throw null;
			}

			// Token: 0x17001127 RID: 4391
			// (get) Token: 0x06006A99 RID: 27289 RVA: 0x00002050 File Offset: 0x00000250
			public bool CanSetBlindFire
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006A9A RID: 27290 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_50(Weapon weapon)
			{
				throw null;
			}

			// Token: 0x06006A9B RID: 27291 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected List<LightComponent> GetAllLightMods()
			{
				throw null;
			}

			// Token: 0x06006A9C RID: 27292 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_51(BulletClass flareItem)
			{
				throw null;
			}

			// Token: 0x06006A9D RID: 27293 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void InitiateFlare(BulletClass flareItem, Vector3 shotPosition, Vector3 forward)
			{
				throw null;
			}

			// Token: 0x06006A9E RID: 27294 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_52(GClass2664 launcher, BulletClass ammo)
			{
				throw null;
			}

			// Token: 0x06006A9F RID: 27295 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_53(Weapon weapon, BulletClass ammo, int chamberIndex, bool multiShot = false)
			{
				throw null;
			}

			// Token: 0x06006AA0 RID: 27296 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_54(WeaponSoundPlayer weaponSoundPlayer, BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection, bool multiShot)
			{
				throw null;
			}

			// Token: 0x06006AA1 RID: 27297 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_55()
			{
				throw null;
			}

			// Token: 0x06006AA2 RID: 27298 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected internal virtual void DryShot(int chamberIndex = 0, bool underbarrelShot = false)
			{
				throw null;
			}

			// Token: 0x06006AA3 RID: 27299 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void ShotMisfired(BulletClass ammo, Weapon.EMalfunctionState malfunctionState, float overheat)
			{
				throw null;
			}

			// Token: 0x06006AA4 RID: 27300 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void RegisterShot(Item weapon, GClass2988 shot)
			{
				throw null;
			}

			// Token: 0x06006AA5 RID: 27301 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void InitiateShot(GInterface320 weapon, BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection, Vector3 fireportPosition, int chamberIndex, float overheat)
			{
				throw null;
			}

			// Token: 0x06006AA6 RID: 27302 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void SendStartOneShotFire()
			{
				throw null;
			}

			// Token: 0x06006AA7 RID: 27303 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void CreateFlareShot(BulletClass flareItem, Vector3 shotPosition, Vector3 forward)
			{
				throw null;
			}

			// Token: 0x06006AA8 RID: 27304 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ManualLateUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x06006AA9 RID: 27305 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void OnPlayerDead()
			{
				throw null;
			}

			// Token: 0x06006AAA RID: 27306 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void FastForwardCurrentState()
			{
				throw null;
			}

			// Token: 0x06006AAB RID: 27307 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsInSpawnOperation()
			{
				throw null;
			}

			// Token: 0x06006AAC RID: 27308 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsInReloadOperation()
			{
				throw null;
			}

			// Token: 0x06006AAD RID: 27309 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OpticCalibrationSwitchUp(GStruct163[] scopeStates)
			{
				throw null;
			}

			// Token: 0x06006AAE RID: 27310 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OpticCalibrationSwitchDown(GStruct163[] scopeStates)
			{
				throw null;
			}

			// Token: 0x06006AAF RID: 27311 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool HasScopeAimBone(SightComponent sightComp)
			{
				throw null;
			}

			// Token: 0x06006AB0 RID: 27312 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetCompassState(bool active)
			{
				throw null;
			}

			// Token: 0x06006AB1 RID: 27313 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected List<BulletClass> FindAmmoByIds(string[] ammoIds)
			{
				throw null;
			}

			// Token: 0x06006AB2 RID: 27314 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_56(Vector3 point, Vector3 direction)
			{
				throw null;
			}

			// Token: 0x06006AB3 RID: 27315 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_57(bool isAiming)
			{
				throw null;
			}

			// Token: 0x06006AB4 RID: 27316 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_58()
			{
				throw null;
			}

			// Token: 0x06006AB5 RID: 27317 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void LightAndSoundShot(Vector3 point, Vector3 direction, AmmoTemplate ammoTemplate)
			{
				throw null;
			}

			// Token: 0x06006AB6 RID: 27318 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_59()
			{
				throw null;
			}

			// Token: 0x06006AB7 RID: 27319 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_60()
			{
				throw null;
			}

			// Token: 0x06006AB8 RID: 27320 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_61()
			{
				throw null;
			}

			// Token: 0x06006AB9 RID: 27321 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_62()
			{
				throw null;
			}

			// Token: 0x06006ABA RID: 27322 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_63()
			{
				throw null;
			}

			// Token: 0x06006ABB RID: 27323 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_64()
			{
				throw null;
			}

			// Token: 0x06006ABC RID: 27324 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_65()
			{
				throw null;
			}

			// Token: 0x06006ABD RID: 27325 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_66()
			{
				throw null;
			}

			// Token: 0x06006ABE RID: 27326 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_67()
			{
				throw null;
			}

			// Token: 0x06006ABF RID: 27327 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_68()
			{
				throw null;
			}

			// Token: 0x06006AC0 RID: 27328 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_69()
			{
				throw null;
			}

			// Token: 0x06006AC1 RID: 27329 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_70()
			{
				throw null;
			}

			// Token: 0x06006AC2 RID: 27330 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_71()
			{
				throw null;
			}

			// Token: 0x06006AC3 RID: 27331 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_72()
			{
				throw null;
			}

			// Token: 0x06006AC4 RID: 27332 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_73()
			{
				throw null;
			}

			// Token: 0x06006AC5 RID: 27333 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_74()
			{
				throw null;
			}

			// Token: 0x06006AC6 RID: 27334 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_75()
			{
				throw null;
			}

			// Token: 0x06006AD0 RID: 27344 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_85()
			{
				throw null;
			}

			// Token: 0x06006AD1 RID: 27345 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_86()
			{
				throw null;
			}

			// Token: 0x06006AD2 RID: 27346 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_87()
			{
				throw null;
			}

			// Token: 0x06006AD3 RID: 27347 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_88()
			{
				throw null;
			}

			// Token: 0x06006AD4 RID: 27348 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_89()
			{
				throw null;
			}

			// Token: 0x06006AD5 RID: 27349 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_90()
			{
				throw null;
			}

			// Token: 0x06006AD6 RID: 27350 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_91()
			{
				throw null;
			}

			// Token: 0x06006AD7 RID: 27351 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_92()
			{
				throw null;
			}

			// Token: 0x040074F0 RID: 29936
			private List<GClass722<Weapon.EMalfunctionSource>.GStruct42<float, Weapon.EMalfunctionSource>> list_0;

			// Token: 0x040074F1 RID: 29937
			private List<GClass722<Weapon.EMalfunctionState>.GStruct42<float, Weapon.EMalfunctionState>> list_1;

			// Token: 0x040074F2 RID: 29938
			public const int CALCULATOR_SEED = 1;

			// Token: 0x040074F3 RID: 29939
			private const string string_0 = "Cant StartReload";

			// Token: 0x040074F4 RID: 29940
			private const float float_0 = 1.5f;

			// Token: 0x040074F5 RID: 29941
			public const float OFFSET_FOR_OVERLAP_RAY_ON_LEFT_SHOULDER = 0.2f;

			// Token: 0x040074F6 RID: 29942
			public const float ADDITIONAL_LEFTSTANCE_OVERLAP_RAY_LENGTH = 0.2f;

			// Token: 0x040074F7 RID: 29943
			private const float float_1 = 0.5f;

			// Token: 0x040074F8 RID: 29944
			[CompilerGenerated]
			private Action action_0;

			// Token: 0x040074F9 RID: 29945
			[CompilerGenerated]
			private Action<Player.FirearmController> action_1;

			// Token: 0x040074FA RID: 29946
			[CompilerGenerated]
			private Action action_2;

			// Token: 0x040074FB RID: 29947
			protected static readonly List<BulletClass> _preallocatedAmmoList;

			// Token: 0x040074FC RID: 29948
			private static readonly List<GClass2988> list_2;

			// Token: 0x040074FD RID: 29949
			private static readonly RaycastHit[] raycastHit_0;

			// Token: 0x040074FE RID: 29950
			public GClass671 CCV;

			// Token: 0x040074FF RID: 29951
			public Transform GunBaseTransform;

			// Token: 0x04007500 RID: 29952
			public BifacialTransform Fireport;

			// Token: 0x04007501 RID: 29953
			public BifacialTransform[] MultiBarrelsFireports;

			// Token: 0x04007502 RID: 29954
			public bool _blindfire;

			// Token: 0x04007503 RID: 29955
			public int CurrentChamberIndex;

			// Token: 0x04007504 RID: 29956
			public float HipInaccuracy;

			// Token: 0x04007505 RID: 29957
			public GClass2646[] AimingDevices;

			// Token: 0x04007506 RID: 29958
			public int AmmoInChamberOnSpawn;

			// Token: 0x04007507 RID: 29959
			public bool autoFireOn;

			// Token: 0x04007508 RID: 29960
			internal Func<bool> func_0;

			// Token: 0x04007509 RID: 29961
			internal Func<bool> func_1;

			// Token: 0x0400750A RID: 29962
			internal GClass1665 gclass1665_0;

			// Token: 0x0400750B RID: 29963
			internal FirearmsAnimator firearmsAnimator_0;

			// Token: 0x0400750C RID: 29964
			protected float WeaponLn;

			// Token: 0x0400750D RID: 29965
			protected bool AimingInterruptedByOverlap;

			// Token: 0x0400750E RID: 29966
			protected bool _isAiming;

			// Token: 0x0400750F RID: 29967
			private bool bool_0;

			// Token: 0x04007510 RID: 29968
			private bool bool_1;

			// Token: 0x04007511 RID: 29969
			protected float _aimingSens;

			// Token: 0x04007512 RID: 29970
			protected GInterface355 BallisticsCalculator;

			// Token: 0x04007513 RID: 29971
			private WeaponPrefab weaponPrefab_0;

			// Token: 0x04007514 RID: 29972
			private MalfunctionRandom malfunctionRandom_0;

			// Token: 0x04007515 RID: 29973
			private bool bool_2;

			// Token: 0x04007516 RID: 29974
			private bool bool_3;

			// Token: 0x04007517 RID: 29975
			private float float_2;

			// Token: 0x04007518 RID: 29976
			private float float_3;

			// Token: 0x04007519 RID: 29977
			private float float_4;

			// Token: 0x0400751A RID: 29978
			private SkillManager.GClass1768 gclass1768_0;

			// Token: 0x0400751B RID: 29979
			private bool bool_4;

			// Token: 0x0400751C RID: 29980
			private bool bool_5;

			// Token: 0x0400751D RID: 29981
			private bool bool_6;

			// Token: 0x0400751E RID: 29982
			private int int_0;

			// Token: 0x0400751F RID: 29983
			private GClass751<float> gclass751_0;

			// Token: 0x04007520 RID: 29984
			private GClass751<float> gclass751_1;

			// Token: 0x04007521 RID: 29985
			private Func<RaycastHit, bool> func_2;

			// Token: 0x04007522 RID: 29986
			private OneOffWeaponSettings oneOffWeaponSettings_0;

			// Token: 0x04007523 RID: 29987
			private bool bool_7;

			// Token: 0x04007524 RID: 29988
			private float float_5;

			// Token: 0x04007525 RID: 29989
			private WeaponSoundPlayer weaponSoundPlayer_0;

			// Token: 0x04007526 RID: 29990
			private int int_1;

			// Token: 0x04007527 RID: 29991
			private Player.FirearmController.GClass1579 gclass1579_0;

			// Token: 0x04007528 RID: 29992
			public GClass2664 UnderbarrelWeapon;

			// Token: 0x04007529 RID: 29993
			[CompilerGenerated]
			private bool bool_8;

			// Token: 0x0400752A RID: 29994
			[CompilerGenerated]
			private bool bool_9;

			// Token: 0x0400752B RID: 29995
			private bool bool_10;

			// Token: 0x0400752C RID: 29996
			private bool bool_11;

			// Token: 0x0400752D RID: 29997
			private float float_6;

			// Token: 0x0400752E RID: 29998
			private float float_7;

			// Token: 0x020013CB RID: 5067
			public class GClass1582 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006AD8 RID: 27352 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(BulletClass item, int camoraIndex, ItemAddress itemAddress, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006AD9 RID: 27353 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006ADA RID: 27354 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006ADB RID: 27355 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006ADC RID: 27356 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagAppeared()
				{
					throw null;
				}

				// Token: 0x06006ADD RID: 27357 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagPuttedToRig()
				{
					throw null;
				}

				// Token: 0x06006ADE RID: 27358 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x06006ADF RID: 27359 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x0400752F RID: 29999
				private BulletClass gclass2732_0;

				// Token: 0x04007530 RID: 30000
				private ItemAddress itemAddress_0;

				// Token: 0x04007531 RID: 30001
				private Callback callback_0;

				// Token: 0x04007532 RID: 30002
				private bool bool_0;

				// Token: 0x04007533 RID: 30003
				private bool bool_1;

				// Token: 0x04007534 RID: 30004
				private int int_0;
			}

			// Token: 0x020013CC RID: 5068
			private sealed class Class1014 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006AE0 RID: 27360 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Item item, Slot slot, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006AE1 RID: 27361 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006AE2 RID: 27362 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006AE3 RID: 27363 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06006AE4 RID: 27364 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnModChanged()
				{
					throw null;
				}

				// Token: 0x06006AE5 RID: 27365 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5(GameObject createdItem)
				{
					throw null;
				}

				// Token: 0x06006AE6 RID: 27366 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006AE7 RID: 27367 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanChangeLightState(GStruct162[] lightsStates)
				{
					throw null;
				}

				// Token: 0x04007535 RID: 30005
				private Item item_0;

				// Token: 0x04007536 RID: 30006
				private Slot slot_0;

				// Token: 0x04007537 RID: 30007
				private Callback callback_0;

				// Token: 0x04007538 RID: 30008
				private bool bool_0;
			}

			// Token: 0x020013CD RID: 5069
			public class GClass1597 : Player.FirearmController.GClass1596
			{
				// Token: 0x17001128 RID: 4392
				// (get) Token: 0x06006AE8 RID: 27368 RVA: 0x00002050 File Offset: 0x00000250
				public float ShotsTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06006AE9 RID: 27369 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public new virtual void Start()
				{
					throw null;
				}

				// Token: 0x06006AEA RID: 27370 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006AEB RID: 27371 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006AEC RID: 27372 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEvent()
				{
					throw null;
				}

				// Token: 0x06006AED RID: 27373 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006AEE RID: 27374 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_10(float normalizedStartFrameTime, float normalizedEndFrameTime)
				{
					throw null;
				}

				// Token: 0x06006AEF RID: 27375 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void InternalOnFireEvent()
				{
					throw null;
				}

				// Token: 0x06006AF0 RID: 27376 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void InternalOnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x06006AF1 RID: 27377 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x06006AF2 RID: 27378 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006AF3 RID: 27379 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006AF4 RID: 27380 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCaught)
				{
					throw null;
				}

				// Token: 0x06006AF5 RID: 27381 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void InternalRemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006AF6 RID: 27382 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void InternalOnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006AF7 RID: 27383 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void InternalOnFireEndEvent()
				{
					throw null;
				}

				// Token: 0x06006AF8 RID: 27384 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006AF9 RID: 27385 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_11()
				{
					throw null;
				}

				// Token: 0x06006AFA RID: 27386 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_12()
				{
					throw null;
				}

				// Token: 0x06006AFB RID: 27387 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06006AFC RID: 27388 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_13()
				{
					throw null;
				}

				// Token: 0x04007539 RID: 30009
				private const float float_0 = 0f;

				// Token: 0x0400753A RID: 30010
				private const float float_1 = 0.25f;

				// Token: 0x0400753B RID: 30011
				private const float float_2 = 0.75f;

				// Token: 0x0400753C RID: 30012
				private const float float_3 = 0.75f;

				// Token: 0x0400753D RID: 30013
				private const float float_4 = 0.99f;

				// Token: 0x0400753E RID: 30014
				protected const int int_0 = 3;

				// Token: 0x0400753F RID: 30015
				protected int int_1;

				// Token: 0x04007540 RID: 30016
				protected float float_5;

				// Token: 0x04007541 RID: 30017
				protected float float_6;

				// Token: 0x04007542 RID: 30018
				protected float float_7;

				// Token: 0x04007543 RID: 30019
				protected Player.FirearmController.GClass1596.SingleShotData singleShotData_0;

				// Token: 0x04007544 RID: 30020
				private bool bool_1;

				// Token: 0x04007545 RID: 30021
				private int int_2;

				// Token: 0x04007546 RID: 30022
				protected float float_8;
			}

			// Token: 0x020013CE RID: 5070
			public abstract class GClass1583 : Player.FirearmController.GClass1581
			{
				// Token: 0x17001129 RID: 4393
				// (get) Token: 0x06006AFD RID: 27389 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x06006AFE RID: 27390 RVA: 0x00002050 File Offset: 0x00000250
				private Slot Slot_0
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

				// Token: 0x06006AFF RID: 27391 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_5(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06006B00 RID: 27392 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void Start([CanBeNull] Callback callback)
				{
					throw null;
				}

				// Token: 0x1700112A RID: 4394
				// (get) Token: 0x06006B01 RID: 27393 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x06006B02 RID: 27394 RVA: 0x00002050 File Offset: 0x00000250
				public override Player.EOperationState State
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					protected set
					{
						throw null;
					}
				}

				// Token: 0x06006B03 RID: 27395 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006B04 RID: 27396 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006B05 RID: 27397 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_6()
				{
					throw null;
				}

				// Token: 0x06006B06 RID: 27398 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006B07 RID: 27399 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_7()
				{
					throw null;
				}

				// Token: 0x06006B08 RID: 27400 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_8()
				{
					throw null;
				}

				// Token: 0x04007547 RID: 30023
				protected bool bool_0;

				// Token: 0x04007548 RID: 30024
				protected Action action_0;

				// Token: 0x04007549 RID: 30025
				private Callback callback_0;

				// Token: 0x0400754A RID: 30026
				[CompilerGenerated]
				private Slot slot_0;
			}

			// Token: 0x020013CF RID: 5071
			public class GClass1599 : Player.FirearmController.GClass1598
			{
				// Token: 0x06006B09 RID: 27401 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start()
				{
					throw null;
				}

				// Token: 0x06006B0A RID: 27402 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006B0B RID: 27403 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006B0C RID: 27404 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadMag(MagazineClass magazine, GClass2765 gridItemAddress, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006B0D RID: 27405 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void QuickReloadMag(MagazineClass magazine, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006B0E RID: 27406 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadWithAmmo(GClass2491 ammoPack, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006B0F RID: 27407 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadCylinderMagazine(GClass2491 ammoPack, Callback finishCallback, Callback startCallback, bool quickReload = false)
				{
					throw null;
				}

				// Token: 0x06006B10 RID: 27408 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006B11 RID: 27409 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAimingDisabled()
				{
					throw null;
				}
			}

			// Token: 0x020013D0 RID: 5072
			public class GClass1591 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006B12 RID: 27410 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(BulletClass item, int camoraIndex, ItemAddress itemAddress, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006B13 RID: 27411 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006B14 RID: 27412 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006B15 RID: 27413 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagAppeared()
				{
					throw null;
				}

				// Token: 0x06006B16 RID: 27414 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagPuttedToRig()
				{
					throw null;
				}

				// Token: 0x06006B17 RID: 27415 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x06006B18 RID: 27416 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006B19 RID: 27417 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_6()
				{
					throw null;
				}

				// Token: 0x0400754B RID: 30027
				private BulletClass gclass2732_0;

				// Token: 0x0400754C RID: 30028
				private CylinderMagazineClass gclass2666_0;

				// Token: 0x0400754D RID: 30029
				private ItemAddress itemAddress_0;

				// Token: 0x0400754E RID: 30030
				private Callback callback_0;

				// Token: 0x0400754F RID: 30031
				private bool bool_0;

				// Token: 0x04007550 RID: 30032
				private bool bool_1;

				// Token: 0x04007551 RID: 30033
				private int int_0;
			}

			// Token: 0x020013D1 RID: 5073
			public class GClass1593 : Player.FirearmController.GClass1592
			{
				// Token: 0x06006B1A RID: 27418 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006B1B RID: 27419 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagPuttedToRig()
				{
					throw null;
				}
			}

			// Token: 0x020013D2 RID: 5074
			public class GClass1592 : Player.FirearmController.GClass1581
			{
				// Token: 0x1700112B RID: 4395
				// (get) Token: 0x06006B1C RID: 27420 RVA: 0x00002050 File Offset: 0x00000250
				protected bool Boolean_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06006B1D RID: 27421 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal virtual void Start(BulletClass ammo, int chamberIndex, ItemAddress destinationAddress, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006B1E RID: 27422 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006B1F RID: 27423 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006B20 RID: 27424 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagPuttedToRig()
				{
					throw null;
				}

				// Token: 0x06006B21 RID: 27425 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006B22 RID: 27426 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x04007552 RID: 30034
				protected Callback callback_0;

				// Token: 0x04007553 RID: 30035
				protected bool bool_0;

				// Token: 0x04007554 RID: 30036
				protected bool bool_1;

				// Token: 0x04007555 RID: 30037
				protected int int_0;

				// Token: 0x04007556 RID: 30038
				private ItemAddress itemAddress_0;
			}

			// Token: 0x020013D3 RID: 5075
			public class GClass1594 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006B23 RID: 27427 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006B24 RID: 27428 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006B25 RID: 27429 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06006B26 RID: 27430 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006B27 RID: 27431 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnBackpackDropEvent()
				{
					throw null;
				}

				// Token: 0x06006B28 RID: 27432 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006B29 RID: 27433 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanChangeLightState(GStruct162[] lightsStates)
				{
					throw null;
				}

				// Token: 0x04007557 RID: 30039
				private Callback callback_0;

				// Token: 0x04007558 RID: 30040
				private bool bool_0;
			}

			// Token: 0x020013D4 RID: 5076
			public sealed class GClass1615 : Player.FirearmController.GClass1614
			{
				// Token: 0x06006B2A RID: 27434 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public new void Start()
				{
					throw null;
				}

				// Token: 0x06006B2B RID: 27435 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006B2C RID: 27436 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMalfunctionOffEvent()
				{
					throw null;
				}

				// Token: 0x06006B2D RID: 27437 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x04007559 RID: 30041
				private bool bool_0;
			}

			// Token: 0x020013D5 RID: 5077
			public class GClass1600 : Player.FirearmController.GClass1598
			{
				// Token: 0x06006B2E RID: 27438 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start()
				{
					throw null;
				}

				// Token: 0x06006B2F RID: 27439 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_14()
				{
					throw null;
				}

				// Token: 0x06006B30 RID: 27440 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006B31 RID: 27441 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEvent()
				{
					throw null;
				}

				// Token: 0x06006B32 RID: 27442 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006B33 RID: 27443 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006B34 RID: 27444 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006B35 RID: 27445 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEndEvent()
				{
					throw null;
				}

				// Token: 0x06006B36 RID: 27446 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnIdleStartEvent()
				{
					throw null;
				}

				// Token: 0x06006B37 RID: 27447 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x06006B38 RID: 27448 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006B39 RID: 27449 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void PrepareShot()
				{
					throw null;
				}

				// Token: 0x06006B3A RID: 27450 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_15()
				{
					throw null;
				}

				// Token: 0x06006B3B RID: 27451 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_16()
				{
					throw null;
				}

				// Token: 0x06006B3C RID: 27452 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_17()
				{
					throw null;
				}

				// Token: 0x0400755A RID: 30042
				private CylinderMagazineClass gclass2666_0;

				// Token: 0x0400755B RID: 30043
				private int int_0;

				// Token: 0x0400755C RID: 30044
				protected bool bool_5;
			}

			// Token: 0x020013D6 RID: 5078
			public class GClass1601 : Player.FirearmController.GClass1598
			{
				// Token: 0x06006B3D RID: 27453 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void PrepareShot()
				{
					throw null;
				}

				// Token: 0x06006B3E RID: 27454 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_14()
				{
					throw null;
				}

				// Token: 0x06006B3F RID: 27455 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_15(int chamberIndex)
				{
					throw null;
				}

				// Token: 0x06006B40 RID: 27456 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006B41 RID: 27457 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006B42 RID: 27458 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006B43 RID: 27459 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEvent()
				{
					throw null;
				}

				// Token: 0x0400755D RID: 30045
				private List<int> list_0;

				// Token: 0x0400755E RID: 30046
				private List<Player.FirearmController.GClass1596.SingleShotData> list_1;

				// Token: 0x0400755F RID: 30047
				private int int_0;
			}

			// Token: 0x020013D7 RID: 5079
			public class GClass1598 : Player.FirearmController.GClass1596
			{
				// Token: 0x06006B44 RID: 27460 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public new virtual void Start()
				{
					throw null;
				}

				// Token: 0x06006B45 RID: 27461 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void StartFireAnimation()
				{
					throw null;
				}

				// Token: 0x06006B46 RID: 27462 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006B47 RID: 27463 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEvent()
				{
					throw null;
				}

				// Token: 0x06006B48 RID: 27464 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void PrepareShot()
				{
					throw null;
				}

				// Token: 0x06006B49 RID: 27465 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006B4A RID: 27466 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006B4B RID: 27467 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x06006B4C RID: 27468 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006B4D RID: 27469 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006B4E RID: 27470 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEndEvent()
				{
					throw null;
				}

				// Token: 0x06006B4F RID: 27471 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnIdleStartEvent()
				{
					throw null;
				}

				// Token: 0x06006B50 RID: 27472 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_10()
				{
					throw null;
				}

				// Token: 0x06006B51 RID: 27473 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_11()
				{
					throw null;
				}

				// Token: 0x06006B52 RID: 27474 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_12()
				{
					throw null;
				}

				// Token: 0x06006B53 RID: 27475 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_13()
				{
					throw null;
				}

				// Token: 0x06006B54 RID: 27476 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x04007560 RID: 30048
				protected Player.FirearmController.GClass1596.SingleShotData singleShotData_0;

				// Token: 0x04007561 RID: 30049
				protected bool bool_1;

				// Token: 0x04007562 RID: 30050
				private float float_0;

				// Token: 0x04007563 RID: 30051
				private bool bool_2;

				// Token: 0x04007564 RID: 30052
				private bool bool_3;

				// Token: 0x04007565 RID: 30053
				private bool bool_4;
			}

			// Token: 0x020013D8 RID: 5080
			public class GClass1596 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006B55 RID: 27477 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x06006B56 RID: 27478 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected Player.FirearmController.GClass1596.SingleShotData method_5(out Weapon.EMalfunctionState malfState, out Weapon.EMalfunctionSource malfSource)
				{
					throw null;
				}

				// Token: 0x06006B57 RID: 27479 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_6(out BulletClass ammoToFire, out BulletClass ammoToChamber, out int ammoCountInMagBeforeShot)
				{
					throw null;
				}

				// Token: 0x06006B58 RID: 27480 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected Player.FirearmController.GClass1596.SingleShotData method_7(Weapon.EMalfunctionState malfState)
				{
					throw null;
				}

				// Token: 0x06006B59 RID: 27481 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void BlindFire(int b)
				{
					throw null;
				}

				// Token: 0x06006B5A RID: 27482 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006B5B RID: 27483 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06006B5C RID: 27484 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadMag(MagazineClass magazine, GClass2765 gridItemAddress, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006B5D RID: 27485 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadCylinderMagazine(GClass2491 ammoPack, Callback finishCallback, Callback startCallback, bool quickReload = false)
				{
					throw null;
				}

				// Token: 0x06006B5E RID: 27486 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadWithAmmo(GClass2491 ammoPack, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006B61 RID: 27489 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006B62 RID: 27490 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCaught)
				{
					throw null;
				}

				// Token: 0x06006B63 RID: 27491 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006B64 RID: 27492 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_8()
				{
					throw null;
				}

				// Token: 0x06006B65 RID: 27493 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void MakeMultiBarrelShot(List<Player.FirearmController.GClass1596.SingleShotData> singleShotDatas, List<int> chambersForFire)
				{
					throw null;
				}

				// Token: 0x06006B66 RID: 27494 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void MakeShot(BulletClass ammo, int chamberIndex = 0, bool multiBarrelShot = false)
				{
					throw null;
				}

				// Token: 0x06006B67 RID: 27495 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void UncheckOnShot()
				{
					throw null;
				}

				// Token: 0x06006B68 RID: 27496 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_9()
				{
					throw null;
				}

				// Token: 0x04007566 RID: 30054
				protected bool bool_0;

				// Token: 0x04007567 RID: 30055
				protected Action action_0;

				// Token: 0x020013D9 RID: 5081
				protected struct SingleShotData
				{
					// Token: 0x04007568 RID: 30056
					public BulletClass AmmoToFire;

					// Token: 0x04007569 RID: 30057
					[CanBeNull]
					public BulletClass AmmoWillBeLoadedToChamber;

					// Token: 0x0400756A RID: 30058
					public BulletClass FedAmmo;

					// Token: 0x0400756B RID: 30059
					public int AmmoCountInChamberBeforeShot;

					// Token: 0x0400756C RID: 30060
					public int AmmoCountInChamberAfterShot;

					// Token: 0x0400756D RID: 30061
					public int AmmoCountInMagBeforeShot;

					// Token: 0x0400756E RID: 30062
					public int AmmoCountInMagAfterShot;

					// Token: 0x0400756F RID: 30063
					public bool IsAmmoCompatible;
				}

				// Token: 0x020013DA RID: 5082
				[CompilerGenerated]
				private sealed class Class976
				{
					// Token: 0x06006B69 RID: 27497 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x04007570 RID: 30064
					public Player.FirearmController.GClass1596 gclass1596_0;

					// Token: 0x04007571 RID: 30065
					public MagazineClass magazine;

					// Token: 0x04007572 RID: 30066
					public GClass2765 gridItemAddress;

					// Token: 0x04007573 RID: 30067
					public Callback finishCallback;

					// Token: 0x04007574 RID: 30068
					public Callback startCallback;
				}

				// Token: 0x020013DB RID: 5083
				[CompilerGenerated]
				private sealed class Class977
				{
					// Token: 0x06006B6A RID: 27498 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x04007575 RID: 30069
					public Player.FirearmController.GClass1596 gclass1596_0;

					// Token: 0x04007576 RID: 30070
					public GClass2491 ammoPack;

					// Token: 0x04007577 RID: 30071
					public Callback finishCallback;

					// Token: 0x04007578 RID: 30072
					public bool quickReload;

					// Token: 0x04007579 RID: 30073
					public Callback startCallback;
				}

				// Token: 0x020013DC RID: 5084
				[CompilerGenerated]
				private sealed class Class978
				{
					// Token: 0x06006B6B RID: 27499 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x0400757A RID: 30074
					public Player.FirearmController.GClass1596 gclass1596_0;

					// Token: 0x0400757B RID: 30075
					public GClass2491 ammoPack;

					// Token: 0x0400757C RID: 30076
					public Callback finishCallback;

					// Token: 0x0400757D RID: 30077
					public Callback startCallback;
				}

				// Token: 0x020013DD RID: 5085
				[CompilerGenerated]
				private sealed class Class979
				{
					// Token: 0x06006B6C RID: 27500 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x0400757E RID: 30078
					public Player.FirearmController.GClass1596 gclass1596_0;

					// Token: 0x0400757F RID: 30079
					public MagazineClass magazine;

					// Token: 0x04007580 RID: 30080
					public Callback finishCallback;

					// Token: 0x04007581 RID: 30081
					public Callback startCallback;
				}

				// Token: 0x020013DE RID: 5086
				[CompilerGenerated]
				private sealed class Class980
				{
					// Token: 0x06006B6D RID: 27501 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x04007582 RID: 30082
					public Player.FirearmController.GClass1596 gclass1596_0;

					// Token: 0x04007583 RID: 30083
					public Action onHidden;

					// Token: 0x04007584 RID: 30084
					public bool fastDrop;

					// Token: 0x04007585 RID: 30085
					public Item nextControllerItem;
				}
			}

			// Token: 0x020013DF RID: 5087
			public abstract class GClass1581 : Player.GClass1580
			{
				// Token: 0x06006B6E RID: 27502 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool CanChangeLightState(GStruct162[] lightsStates)
				{
					throw null;
				}

				// Token: 0x06006B6F RID: 27503 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void SetLightsState(GStruct162[] lightsStates, bool force = false)
				{
					throw null;
				}

				// Token: 0x06006B70 RID: 27504 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x06006B71 RID: 27505 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_2()
				{
					throw null;
				}

				// Token: 0x06006B72 RID: 27506 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_3()
				{
					throw null;
				}

				// Token: 0x06006B73 RID: 27507 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void SetScopeMode(GStruct163[] scopeStates)
				{
					throw null;
				}

				// Token: 0x06006B74 RID: 27508 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool CanRemove()
				{
					throw null;
				}

				// Token: 0x06006B75 RID: 27509 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ShowGesture(EGesture gesture)
				{
					throw null;
				}

				// Token: 0x06006B76 RID: 27510 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void BlindFire(int b)
				{
					throw null;
				}

				// Token: 0x06006B77 RID: 27511 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnFold(bool b)
				{
					throw null;
				}

				// Token: 0x06006B78 RID: 27512 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void BlindFire_Internal(int b)
				{
					throw null;
				}

				// Token: 0x06006B79 RID: 27513 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void FastForward()
				{
					throw null;
				}

				// Token: 0x06006B7A RID: 27514 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool CanChangeScopeStates(GStruct163[] scopeStates)
				{
					throw null;
				}

				// Token: 0x06006B7B RID: 27515 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetFirearmCompassState(bool active)
				{
					throw null;
				}

				// Token: 0x06006B7C RID: 27516 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnMagPulledOutFromWeapon()
				{
					throw null;
				}

				// Token: 0x06006B7D RID: 27517 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnMagPuttedToRig()
				{
					throw null;
				}

				// Token: 0x06006B7E RID: 27518 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnMagAppeared()
				{
					throw null;
				}

				// Token: 0x06006B7F RID: 27519 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnMagInsertedToWeapon()
				{
					throw null;
				}

				// Token: 0x06006B80 RID: 27520 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnModChanged()
				{
					throw null;
				}

				// Token: 0x06006B81 RID: 27521 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006B82 RID: 27522 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006B83 RID: 27523 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnOnOffBoltCatchEvent(bool isCaught)
				{
					throw null;
				}

				// Token: 0x06006B84 RID: 27524 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnBackpackDropEvent()
				{
					throw null;
				}

				// Token: 0x06006B85 RID: 27525 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnFireEvent()
				{
					throw null;
				}

				// Token: 0x06006B86 RID: 27526 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnFireEndEvent()
				{
					throw null;
				}

				// Token: 0x06006B87 RID: 27527 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnIdleStartEvent()
				{
					throw null;
				}

				// Token: 0x06006B88 RID: 27528 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnUtilityOperationStartEvent()
				{
					throw null;
				}

				// Token: 0x06006B89 RID: 27529 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006B8A RID: 27530 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ShowUncompatibleNotification()
				{
					throw null;
				}

				// Token: 0x06006B8B RID: 27531 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006B8C RID: 27532 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06006B8D RID: 27533 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool ChangeFireMode(Weapon.EFireMode fireMode)
				{
					throw null;
				}

				// Token: 0x06006B8E RID: 27534 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool CheckFireMode()
				{
					throw null;
				}

				// Token: 0x06006B8F RID: 27535 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnSprintFinished()
				{
					throw null;
				}

				// Token: 0x06006B90 RID: 27536 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnSprintStart()
				{
					throw null;
				}

				// Token: 0x06006B91 RID: 27537 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnJumpOrFall()
				{
					throw null;
				}

				// Token: 0x06006B92 RID: 27538 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnAimingDisabled()
				{
					throw null;
				}

				// Token: 0x06006B93 RID: 27539 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x06006B94 RID: 27540 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void RollCylinder(Callback callback, bool rollToZeroCamora)
				{
					throw null;
				}

				// Token: 0x06006B95 RID: 27541 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Execute(GInterface336 operation, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006B96 RID: 27542 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ReloadMag(MagazineClass magazine, [CanBeNull] GClass2765 gridItemAddress, [CanBeNull] Callback finishCallback, [CanBeNull] Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006B97 RID: 27543 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void QuickReloadMag(MagazineClass magazine, [CanBeNull] Callback finishCallback, [CanBeNull] Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006B98 RID: 27544 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ReloadGrenadeLauncher(GClass2491 ammoPack, [CanBeNull] Callback callback)
				{
					throw null;
				}

				// Token: 0x06006B99 RID: 27545 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ReloadWithAmmo(GClass2491 ammoPack, [CanBeNull] Callback finishCallback, [CanBeNull] Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006B9A RID: 27546 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ReloadCylinderMagazine(GClass2491 ammoPack, [CanBeNull] Callback finishCallback, [CanBeNull] Callback startCallback, bool quickReload = false)
				{
					throw null;
				}

				// Token: 0x06006B9B RID: 27547 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ReloadBarrels(GClass2491 ammoPack, GClass2765 placeToPutContainedAmmoMagazine, [CanBeNull] Callback finishCallback, [CanBeNull] Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006B9C RID: 27548 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool CanStartReload()
				{
					throw null;
				}

				// Token: 0x06006B9D RID: 27549 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnRemoveShellEvent()
				{
					throw null;
				}

				// Token: 0x06006B9E RID: 27550 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x06006B9F RID: 27551 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006BA0 RID: 27552 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void AddAmmoToMag()
				{
					throw null;
				}

				// Token: 0x06006BA1 RID: 27553 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnShowAmmo(bool value)
				{
					throw null;
				}

				// Token: 0x06006BA2 RID: 27554 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void WeaponAppeared()
				{
					throw null;
				}

				// Token: 0x06006BA3 RID: 27555 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006BA4 RID: 27556 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void HideWeaponComplete()
				{
					throw null;
				}

				// Token: 0x06006BA5 RID: 27557 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool CheckAmmo()
				{
					throw null;
				}

				// Token: 0x06006BA6 RID: 27558 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool CheckChamber()
				{
					throw null;
				}

				// Token: 0x06006BA7 RID: 27559 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnMalfunctionOffEvent()
				{
					throw null;
				}

				// Token: 0x06006BA8 RID: 27560 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Pickup(bool p)
				{
					throw null;
				}

				// Token: 0x06006BA9 RID: 27561 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Interact(bool isInteracting, int actionIndex)
				{
					throw null;
				}

				// Token: 0x06006BAA RID: 27562 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Loot(bool p)
				{
					throw null;
				}

				// Token: 0x06006BAB RID: 27563 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void UnderbarrelSightingRangeUp()
				{
					throw null;
				}

				// Token: 0x06006BAC RID: 27564 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ForceSetUnderbarrelRangeIndex(int rangeIndex)
				{
					throw null;
				}

				// Token: 0x06006BAD RID: 27565 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void UnderbarrelSightingRangeDown()
				{
					throw null;
				}

				// Token: 0x06006BAE RID: 27566 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void UseSecondMagForReload()
				{
					throw null;
				}

				// Token: 0x06006BAF RID: 27567 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ReplaceSecondMag()
				{
					throw null;
				}

				// Token: 0x06006BB0 RID: 27568 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void PutMagToRig()
				{
					throw null;
				}

				// Token: 0x06006BB1 RID: 27569 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool ToggleLauncher()
				{
					throw null;
				}

				// Token: 0x06006BB2 RID: 27570 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ToggleLeftStance()
				{
					throw null;
				}

				// Token: 0x06006BB3 RID: 27571 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool CanNotBeInterrupted()
				{
					throw null;
				}

				// Token: 0x06006BB4 RID: 27572 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void LauncherAppeared()
				{
					throw null;
				}

				// Token: 0x06006BB5 RID: 27573 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void LauncherDisappeared()
				{
					throw null;
				}

				// Token: 0x06006BB6 RID: 27574 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void LauncherInventoryUnchamberFromMainWeapon(BulletClass ammo, int camoraIndex, ItemAddress itemAddress, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006BB7 RID: 27575 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void LoadLauncherFromMainWeapon(BulletClass ammo, int camoraIndex, ItemAddress itemAddress, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006BB8 RID: 27576 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void DropBackpackOperationInvoke(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006BB9 RID: 27577 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SprintStateChanged(bool value)
				{
					throw null;
				}

				// Token: 0x06006BBA RID: 27578 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_4()
				{
					throw null;
				}

				// Token: 0x04007586 RID: 30086
				protected readonly Player.FirearmController firearmController_0;

				// Token: 0x04007587 RID: 30087
				protected Player player_0;

				// Token: 0x04007588 RID: 30088
				protected readonly FirearmsAnimator firearmsAnimator_0;

				// Token: 0x04007589 RID: 30089
				protected readonly GClass1665 gclass1665_0;

				// Token: 0x0400758A RID: 30090
				protected readonly Weapon weapon_0;
			}

			// Token: 0x020013E0 RID: 5088
			public class GClass1602 : Player.FirearmController.GClass1598
			{
				// Token: 0x06006BBB RID: 27579 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start()
				{
					throw null;
				}

				// Token: 0x06006BBC RID: 27580 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006BBD RID: 27581 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void PrepareShot()
				{
					throw null;
				}

				// Token: 0x06006BBE RID: 27582 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEvent()
				{
					throw null;
				}

				// Token: 0x06006BBF RID: 27583 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006BC0 RID: 27584 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEndEvent()
				{
					throw null;
				}

				// Token: 0x06006BC1 RID: 27585 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanNotBeInterrupted()
				{
					throw null;
				}

				// Token: 0x0400758B RID: 30091
				protected BulletClass gclass2732_0;
			}

			// Token: 0x020013E1 RID: 5089
			private sealed class Class1019 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006BC2 RID: 27586 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(GClass2854 foldOperation, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006BC3 RID: 27587 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFold(bool b)
				{
					throw null;
				}

				// Token: 0x06006BC4 RID: 27588 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006BC5 RID: 27589 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x06006BC6 RID: 27590 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006BC7 RID: 27591 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x0400758C RID: 30092
				private Callback callback_0;

				// Token: 0x0400758D RID: 30093
				private GClass2854 gclass2854_0;

				// Token: 0x0400758E RID: 30094
				private bool bool_0;

				// Token: 0x0400758F RID: 30095
				private Action action_0;

				// Token: 0x04007590 RID: 30096
				private bool bool_1;
			}

			// Token: 0x020013E2 RID: 5090
			public class GClass1605 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006BC8 RID: 27592 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void BlindFire(int b)
				{
					throw null;
				}

				// Token: 0x06006BC9 RID: 27593 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(Action callback = null)
				{
					throw null;
				}

				// Token: 0x06006BCA RID: 27594 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x06006BCB RID: 27595 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_6()
				{
					throw null;
				}

				// Token: 0x06006BCC RID: 27596 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnIdleStartEvent()
				{
					throw null;
				}

				// Token: 0x06006BCD RID: 27597 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnEnd()
				{
					throw null;
				}

				// Token: 0x06006BCE RID: 27598 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006BCF RID: 27599 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void ProcessRemoveOneOffWeapon()
				{
					throw null;
				}

				// Token: 0x06006BD0 RID: 27600 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_7()
				{
					throw null;
				}

				// Token: 0x06006BD1 RID: 27601 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void ProcessAutoshot()
				{
					throw null;
				}

				// Token: 0x06006BD2 RID: 27602 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnSprintStart()
				{
					throw null;
				}

				// Token: 0x06006BD3 RID: 27603 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnSprintFinished()
				{
					throw null;
				}

				// Token: 0x06006BD4 RID: 27604 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAimingDisabled()
				{
					throw null;
				}

				// Token: 0x06006BD5 RID: 27605 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnJumpOrFall()
				{
					throw null;
				}

				// Token: 0x06006BD6 RID: 27606 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void DisableAimingOnReload()
				{
					throw null;
				}

				// Token: 0x06006BD7 RID: 27607 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06006BD8 RID: 27608 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006BD9 RID: 27609 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006BDA RID: 27610 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ShowUncompatibleNotification()
				{
					throw null;
				}

				// Token: 0x06006BDB RID: 27611 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool ChangeFireMode(Weapon.EFireMode fireMode)
				{
					throw null;
				}

				// Token: 0x06006BDC RID: 27612 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_8(Weapon.EFireMode fireMode)
				{
					throw null;
				}

				// Token: 0x06006BDD RID: 27613 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CheckFireMode()
				{
					throw null;
				}

				// Token: 0x06006BDE RID: 27614 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_9()
				{
					throw null;
				}

				// Token: 0x06006BDF RID: 27615 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ShowGesture(EGesture gesture)
				{
					throw null;
				}

				// Token: 0x06006BE0 RID: 27616 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetFirearmCompassState(bool active)
				{
					throw null;
				}

				// Token: 0x06006BE1 RID: 27617 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x06006BE2 RID: 27618 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RollCylinder(Callback finishCallback, bool rollToZeroCamora)
				{
					throw null;
				}

				// Token: 0x06006BE3 RID: 27619 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006BE4 RID: 27620 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanRemove()
				{
					throw null;
				}

				// Token: 0x06006BE5 RID: 27621 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadMag(MagazineClass magazine, GClass2765 gridItemAddress, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006BE6 RID: 27622 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void QuickReloadMag(MagazineClass magazine, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006BE7 RID: 27623 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadWithAmmo(GClass2491 ammoPack, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006BE8 RID: 27624 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadCylinderMagazine(GClass2491 ammoPack, Callback finishCallback, Callback startCallback, bool quickReload = false)
				{
					throw null;
				}

				// Token: 0x06006BE9 RID: 27625 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadBarrels(GClass2491 ammoPack, GClass2765 placeToPutContainedAmmoMagazine, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006BEA RID: 27626 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CheckAmmo()
				{
					throw null;
				}

				// Token: 0x06006BEB RID: 27627 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CheckChamber()
				{
					throw null;
				}

				// Token: 0x06006BEC RID: 27628 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanStartReload()
				{
					throw null;
				}

				// Token: 0x06006BED RID: 27629 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void RunUtilityOperation(Player.FirearmController.GClass1606.EUtilityType utilityType)
				{
					throw null;
				}

				// Token: 0x06006BEE RID: 27630 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Execute(GInterface336 operation, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006BEF RID: 27631 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_10(GInterface337 oneItemOperation, BulletClass ammo, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006BF0 RID: 27632 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_11(GInterface337 oneItemOperation, BulletClass ammo, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006BF1 RID: 27633 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x06006BF2 RID: 27634 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool ToggleLauncher()
				{
					throw null;
				}

				// Token: 0x06006BF3 RID: 27635 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCatched)
				{
					throw null;
				}

				// Token: 0x06006BF4 RID: 27636 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void DropBackpackOperationInvoke(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006BF5 RID: 27637 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ToggleLeftStance()
				{
					throw null;
				}

				// Token: 0x06006BF6 RID: 27638 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_12()
				{
					throw null;
				}

				// Token: 0x06006BF7 RID: 27639 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_13()
				{
					throw null;
				}

				// Token: 0x06006BF8 RID: 27640 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_14()
				{
					throw null;
				}

				// Token: 0x06006BF9 RID: 27641 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_15()
				{
					throw null;
				}

				// Token: 0x04007591 RID: 30097
				private float float_0;

				// Token: 0x04007592 RID: 30098
				private bool bool_0;

				// Token: 0x04007593 RID: 30099
				private float float_1;

				// Token: 0x04007594 RID: 30100
				private Action action_0;

				// Token: 0x04007595 RID: 30101
				private Action action_1;

				// Token: 0x04007596 RID: 30102
				private float float_2;

				// Token: 0x020013E3 RID: 5091
				[CompilerGenerated]
				private sealed class Class981
				{
					// Token: 0x06006BFA RID: 27642 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x06006BFB RID: 27643 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_1()
					{
						throw null;
					}

					// Token: 0x06006BFC RID: 27644 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_2()
					{
						throw null;
					}

					// Token: 0x06006BFD RID: 27645 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_3()
					{
						throw null;
					}

					// Token: 0x04007597 RID: 30103
					public Player.FirearmController.GClass1605 gclass1605_0;

					// Token: 0x04007598 RID: 30104
					public BulletClass ammo;

					// Token: 0x04007599 RID: 30105
					public GInterface337 oneItemOperation;

					// Token: 0x0400759A RID: 30106
					public Callback callback;

					// Token: 0x0400759B RID: 30107
					public Action action_0;

					// Token: 0x0400759C RID: 30108
					public Action action_1;
				}
			}

			// Token: 0x020013E4 RID: 5092
			public class GClass1607 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006BFE RID: 27646 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(Player.FirearmController.GClass1573 insertMagResult, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006BFF RID: 27647 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006C00 RID: 27648 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagAppeared()
				{
					throw null;
				}

				// Token: 0x06006C01 RID: 27649 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagInsertedToWeapon()
				{
					throw null;
				}

				// Token: 0x06006C02 RID: 27650 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCaught)
				{
					throw null;
				}

				// Token: 0x06006C03 RID: 27651 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006C04 RID: 27652 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006C05 RID: 27653 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x06006C06 RID: 27654 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanChangeLightState(GStruct162[] lightsStates)
				{
					throw null;
				}

				// Token: 0x06006C07 RID: 27655 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006C08 RID: 27656 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x0400759D RID: 30109
				private Callback callback_0;

				// Token: 0x0400759E RID: 30110
				private Player.FirearmController.GClass1573 gclass1573_0;

				// Token: 0x0400759F RID: 30111
				private bool bool_0;

				// Token: 0x040075A0 RID: 30112
				private bool bool_1;

				// Token: 0x040075A1 RID: 30113
				private bool bool_2;
			}

			// Token: 0x020013E5 RID: 5093
			public class GClass1573 : IRollback, GInterface321
			{
				// Token: 0x06006C09 RID: 27657 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RollBack()
				{
					throw null;
				}

				// Token: 0x06006C0A RID: 27658 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
				{
					throw null;
				}

				// Token: 0x06006C0B RID: 27659 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public static GStruct415<Player.FirearmController.GClass1573> Run(InventoryControllerClass inventoryController, Weapon weapon, string playerId)
				{
					throw null;
				}

				// Token: 0x06006C0C RID: 27660 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GStruct412 Replay()
				{
					throw null;
				}

				// Token: 0x06006C0D RID: 27661 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool CanExecute(TraderControllerClass itemController)
				{
					throw null;
				}

				// Token: 0x040075A2 RID: 30114
				public readonly Weapon Weapon;

				// Token: 0x040075A3 RID: 30115
				public readonly MagazineClass Magazine;

				// Token: 0x040075A4 RID: 30116
				public readonly int MagazineAmmoCount;

				// Token: 0x040075A5 RID: 30117
				public readonly GClass2763 MagazineSlot;

				// Token: 0x040075A6 RID: 30118
				public readonly bool AmmoCompatible;

				// Token: 0x040075A7 RID: 30119
				[CanBeNull]
				public readonly GClass2781 RemoveOldAmmoResult;

				// Token: 0x040075A8 RID: 30120
				[CanBeNull]
				public readonly GInterface322 AddNewAmmoResult;
			}

			// Token: 0x020013E6 RID: 5094
			public class GClass1603 : Player.FirearmController.GClass1598
			{
				// Token: 0x06006C0E RID: 27662 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public new void Start()
				{
					throw null;
				}

				// Token: 0x06006C0F RID: 27663 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void PrepareShot()
				{
					throw null;
				}

				// Token: 0x06006C10 RID: 27664 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006C11 RID: 27665 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_14()
				{
					throw null;
				}

				// Token: 0x06006C12 RID: 27666 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEndEvent()
				{
					throw null;
				}

				// Token: 0x06006C13 RID: 27667 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006C14 RID: 27668 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEvent()
				{
					throw null;
				}

				// Token: 0x040075A9 RID: 30121
				private bool bool_5;
			}

			// Token: 0x020013E7 RID: 5095
			public class GClass1608 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006C15 RID: 27669 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Action callback = null)
				{
					throw null;
				}

				// Token: 0x06006C16 RID: 27670 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x06006C17 RID: 27671 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool ToggleLauncher()
				{
					throw null;
				}

				// Token: 0x06006C18 RID: 27672 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x06006C19 RID: 27673 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_6()
				{
					throw null;
				}

				// Token: 0x06006C1A RID: 27674 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ForceSetUnderbarrelRangeIndex(int rangeIndex)
				{
					throw null;
				}

				// Token: 0x06006C1B RID: 27675 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void UnderbarrelSightingRangeDown()
				{
					throw null;
				}

				// Token: 0x06006C1C RID: 27676 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void UnderbarrelSightingRangeUp()
				{
					throw null;
				}

				// Token: 0x06006C1D RID: 27677 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_7()
				{
					throw null;
				}

				// Token: 0x06006C1E RID: 27678 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SprintStateChanged(bool value)
				{
					throw null;
				}

				// Token: 0x06006C1F RID: 27679 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006C20 RID: 27680 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void SetSightingRange(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006C21 RID: 27681 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006C22 RID: 27682 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x06006C23 RID: 27683 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnIdleStartEvent()
				{
					throw null;
				}

				// Token: 0x06006C24 RID: 27684 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadGrenadeLauncher(GClass2491 ammoPack, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C25 RID: 27685 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006C26 RID: 27686 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanStartReload()
				{
					throw null;
				}

				// Token: 0x06006C27 RID: 27687 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06006C28 RID: 27688 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Interact(bool isInteracting, int actionIndex)
				{
					throw null;
				}

				// Token: 0x06006C29 RID: 27689 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Pickup(bool pickup)
				{
					throw null;
				}

				// Token: 0x06006C2A RID: 27690 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ShowGesture(EGesture gesture)
				{
					throw null;
				}

				// Token: 0x06006C2B RID: 27691 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void LoadLauncherFromMainWeapon(BulletClass ammo, int camoraIndex, ItemAddress itemAddress, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C2C RID: 27692 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void LauncherInventoryUnchamberFromMainWeapon(BulletClass ammo, int camoraIndex, ItemAddress itemAddress, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C2D RID: 27693 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_8(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006C2E RID: 27694 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void DropBackpackOperationInvoke(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C2F RID: 27695 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006C30 RID: 27696 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_9(GInterface337 oneItemOperation, BulletClass ammo, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C31 RID: 27697 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CheckChamber()
				{
					throw null;
				}

				// Token: 0x06006C32 RID: 27698 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void RunUtilityOperation(Player.FirearmController.GClass1606.EUtilityType utilityType)
				{
					throw null;
				}

				// Token: 0x06006C33 RID: 27699 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Execute(GInterface336 operation, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C34 RID: 27700 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ToggleLeftStance()
				{
					throw null;
				}

				// Token: 0x06006C35 RID: 27701 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_10()
				{
					throw null;
				}

				// Token: 0x06006C36 RID: 27702 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_11()
				{
					throw null;
				}

				// Token: 0x040075AA RID: 30122
				protected GClass2664 gclass2664_0;

				// Token: 0x040075AB RID: 30123
				private Action action_0;

				// Token: 0x040075AC RID: 30124
				private bool bool_0;

				// Token: 0x020013E8 RID: 5096
				[CompilerGenerated]
				private sealed class Class982
				{
					// Token: 0x06006C37 RID: 27703 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x040075AD RID: 30125
					public Player.FirearmController.GClass1608 gclass1608_0;

					// Token: 0x040075AE RID: 30126
					public Item item;

					// Token: 0x040075AF RID: 30127
					public Callback callback;
				}

				// Token: 0x020013E9 RID: 5097
				[CompilerGenerated]
				private sealed class Class983
				{
					// Token: 0x06006C38 RID: 27704 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x040075B0 RID: 30128
					public Player.FirearmController.GClass1608 gclass1608_0;

					// Token: 0x040075B1 RID: 30129
					public Action onHidden;

					// Token: 0x040075B2 RID: 30130
					public bool fastDrop;

					// Token: 0x040075B3 RID: 30131
					public Item nextControllerItem;
				}
			}

			// Token: 0x020013EA RID: 5098
			public class GClass1610 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006C39 RID: 27705 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(GClass2491 ammoPack, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C3A RID: 27706 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006C3B RID: 27707 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006C3C RID: 27708 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagAppeared()
				{
					throw null;
				}

				// Token: 0x06006C3D RID: 27709 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006C3E RID: 27710 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006C3F RID: 27711 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x06006C40 RID: 27712 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x040075B4 RID: 30132
				private Callback callback_0;

				// Token: 0x040075B5 RID: 30133
				private GClass2491 gclass2491_0;

				// Token: 0x040075B6 RID: 30134
				private bool bool_0;

				// Token: 0x040075B7 RID: 30135
				protected BulletClass gclass2732_0;

				// Token: 0x040075B8 RID: 30136
				protected bool bool_1;

				// Token: 0x040075B9 RID: 30137
				protected Action action_0;
			}

			// Token: 0x020013EB RID: 5099
			public class GClass1609 : Player.FirearmController.GClass1608
			{
				// Token: 0x06006C41 RID: 27713 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Player.FirearmController.GClass1606.EUtilityType utilityType, GClass2664 launcher)
				{
					throw null;
				}

				// Token: 0x06006C42 RID: 27714 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnIdleStartEvent()
				{
					throw null;
				}

				// Token: 0x06006C43 RID: 27715 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnUtilityOperationStartEvent()
				{
					throw null;
				}

				// Token: 0x06006C44 RID: 27716 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanStartReload()
				{
					throw null;
				}

				// Token: 0x06006C45 RID: 27717 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006C46 RID: 27718 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CheckAmmo()
				{
					throw null;
				}

				// Token: 0x06006C47 RID: 27719 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CheckChamber()
				{
					throw null;
				}

				// Token: 0x06006C48 RID: 27720 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CheckFireMode()
				{
					throw null;
				}

				// Token: 0x06006C49 RID: 27721 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadMag(MagazineClass magazine, GClass2765 gridItemAddress, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006C4A RID: 27722 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadWithAmmo(GClass2491 ammoPack, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006C4B RID: 27723 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadCylinderMagazine(GClass2491 ammoPack, Callback finishCallback, Callback startCallback, bool quickReload = false)
				{
					throw null;
				}

				// Token: 0x06006C4C RID: 27724 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void QuickReloadMag(MagazineClass magazine, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006C4D RID: 27725 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadGrenadeLauncher(GClass2491 ammoPack, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C4E RID: 27726 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006C4F RID: 27727 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006C50 RID: 27728 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006C51 RID: 27729 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetSightingRange(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006C52 RID: 27730 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06006C53 RID: 27731 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x06006C54 RID: 27732 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x040075BA RID: 30138
				private const float float_0 = 2.5f;

				// Token: 0x040075BB RID: 30139
				private float float_1;

				// Token: 0x040075BC RID: 30140
				private bool bool_1;

				// Token: 0x040075BD RID: 30141
				private Player.FirearmController.GClass1606.EUtilityType eutilityType_0;

				// Token: 0x040075BE RID: 30142
				private GClass2664 gclass2664_1;
			}

			// Token: 0x020013EC RID: 5100
			public class GClass1611 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006C55 RID: 27733 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(BulletClass ammo, int chamberIndex, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C56 RID: 27734 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006C57 RID: 27735 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagAppeared()
				{
					throw null;
				}

				// Token: 0x06006C58 RID: 27736 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnRemoveShellEvent()
				{
					throw null;
				}

				// Token: 0x06006C59 RID: 27737 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006C5A RID: 27738 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCaught)
				{
					throw null;
				}

				// Token: 0x06006C5B RID: 27739 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x040075BF RID: 30143
				private BulletClass gclass2732_0;

				// Token: 0x040075C0 RID: 30144
				private int int_0;

				// Token: 0x040075C1 RID: 30145
				private Callback callback_0;
			}

			// Token: 0x020013ED RID: 5101
			public class GClass1612 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006C5C RID: 27740 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(BulletClass ammo, int camoraIndex, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C5D RID: 27741 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006C5E RID: 27742 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006C5F RID: 27743 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagPuttedToRig()
				{
					throw null;
				}

				// Token: 0x06006C60 RID: 27744 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnRemoveShellEvent()
				{
					throw null;
				}

				// Token: 0x06006C61 RID: 27745 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006C62 RID: 27746 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void AddAmmoToMag()
				{
					throw null;
				}

				// Token: 0x06006C63 RID: 27747 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCaught)
				{
					throw null;
				}

				// Token: 0x06006C64 RID: 27748 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006C65 RID: 27749 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void SwitchToIdle()
				{
					throw null;
				}

				// Token: 0x06006C66 RID: 27750 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x040075C2 RID: 30146
				private BulletClass gclass2732_0;

				// Token: 0x040075C3 RID: 30147
				protected int int_0;

				// Token: 0x040075C4 RID: 30148
				private CylinderMagazineClass gclass2666_0;

				// Token: 0x040075C5 RID: 30149
				private Callback callback_0;
			}

			// Token: 0x020013EE RID: 5102
			public class GClass1613 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006C67 RID: 27751 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(BulletClass ammo, int chamberIndex, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C68 RID: 27752 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006C69 RID: 27753 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnRemoveShellEvent()
				{
					throw null;
				}

				// Token: 0x06006C6A RID: 27754 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagAppeared()
				{
					throw null;
				}

				// Token: 0x06006C6B RID: 27755 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006C6C RID: 27756 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCaught)
				{
					throw null;
				}

				// Token: 0x06006C6D RID: 27757 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006C6E RID: 27758 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void SwitchToIdle()
				{
					throw null;
				}

				// Token: 0x06006C6F RID: 27759 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006C70 RID: 27760 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x040075C6 RID: 30150
				private BulletClass gclass2732_0;

				// Token: 0x040075C7 RID: 30151
				private int int_0;

				// Token: 0x040075C8 RID: 30152
				private Callback callback_0;
			}

			// Token: 0x020013EF RID: 5103
			public abstract class GClass1614 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006C71 RID: 27761 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public new virtual void Start()
				{
					throw null;
				}

				// Token: 0x06006C72 RID: 27762 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006C73 RID: 27763 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006C74 RID: 27764 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_5()
				{
					throw null;
				}

				// Token: 0x06006C75 RID: 27765 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006C76 RID: 27766 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x040075C9 RID: 30153
				protected BulletClass gclass2732_0;

				// Token: 0x040075CA RID: 30154
				protected BulletClass gclass2732_1;

				// Token: 0x040075CB RID: 30155
				private Action action_0;

				// Token: 0x020013F0 RID: 5104
				[CompilerGenerated]
				private sealed class Class984
				{
					// Token: 0x06006C77 RID: 27767 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x040075CC RID: 30156
					public Player.FirearmController.GClass1614 gclass1614_0;

					// Token: 0x040075CD RID: 30157
					public Action onHidden;

					// Token: 0x040075CE RID: 30158
					public bool fastDrop;

					// Token: 0x040075CF RID: 30159
					public Item nextControllerItem;
				}
			}

			// Token: 0x020013F1 RID: 5105
			public class GClass1604 : Player.FirearmController.GClass1598
			{
				// Token: 0x06006C78 RID: 27768 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start()
				{
					throw null;
				}

				// Token: 0x06006C79 RID: 27769 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void StartFireAnimation()
				{
					throw null;
				}

				// Token: 0x06006C7A RID: 27770 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006C7B RID: 27771 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void PrepareShot()
				{
					throw null;
				}

				// Token: 0x06006C7C RID: 27772 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEvent()
				{
					throw null;
				}

				// Token: 0x06006C7D RID: 27773 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006C7E RID: 27774 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEndEvent()
				{
					throw null;
				}

				// Token: 0x06006C7F RID: 27775 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006C80 RID: 27776 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanNotBeInterrupted()
				{
					throw null;
				}

				// Token: 0x040075D0 RID: 30160
				protected BulletClass gclass2732_0;
			}

			// Token: 0x020013F2 RID: 5106
			public class GClass1618 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006C81 RID: 27777 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(MagazineClass magazine, Slot from, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C82 RID: 27778 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006C83 RID: 27779 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagPulledOutFromWeapon()
				{
					throw null;
				}

				// Token: 0x06006C84 RID: 27780 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagPuttedToRig()
				{
					throw null;
				}

				// Token: 0x06006C85 RID: 27781 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006C86 RID: 27782 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x06006C87 RID: 27783 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006C88 RID: 27784 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCaught)
				{
					throw null;
				}

				// Token: 0x06006C89 RID: 27785 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanChangeLightState(GStruct162[] lightsStates)
				{
					throw null;
				}

				// Token: 0x06006C8A RID: 27786 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x040075D1 RID: 30161
				private Slot slot_0;

				// Token: 0x040075D2 RID: 30162
				private Callback callback_0;

				// Token: 0x040075D3 RID: 30163
				private bool bool_0;

				// Token: 0x040075D4 RID: 30164
				private bool bool_1;

				// Token: 0x040075D5 RID: 30165
				private bool bool_2;

				// Token: 0x040075D6 RID: 30166
				private bool bool_3;

				// Token: 0x040075D7 RID: 30167
				private bool bool_4;
			}

			// Token: 0x020013F3 RID: 5107
			public class GClass1619 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006C8B RID: 27787 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(BulletClass ammo, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006C8C RID: 27788 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006C8D RID: 27789 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006C8E RID: 27790 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCatched)
				{
					throw null;
				}

				// Token: 0x06006C8F RID: 27791 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006C90 RID: 27792 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x06006C91 RID: 27793 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006C92 RID: 27794 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006C93 RID: 27795 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void SwitchToIdle()
				{
					throw null;
				}

				// Token: 0x06006C94 RID: 27796 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x040075D8 RID: 30168
				protected Item item_0;

				// Token: 0x040075D9 RID: 30169
				protected Item item_1;

				// Token: 0x040075DA RID: 30170
				private Action action_0;

				// Token: 0x040075DB RID: 30171
				private Callback callback_0;

				// Token: 0x040075DC RID: 30172
				private bool bool_0;

				// Token: 0x040075DD RID: 30173
				private bool bool_1;

				// Token: 0x040075DE RID: 30174
				private bool bool_2;

				// Token: 0x020013F4 RID: 5108
				[CompilerGenerated]
				private sealed class Class985
				{
					// Token: 0x06006C95 RID: 27797 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x040075DF RID: 30175
					public Player.FirearmController.GClass1619 gclass1619_0;

					// Token: 0x040075E0 RID: 30176
					public Action onHidden;

					// Token: 0x040075E1 RID: 30177
					public bool fastDrop;

					// Token: 0x040075E2 RID: 30178
					public Item nextControllerItem;
				}
			}

			// Token: 0x020013F5 RID: 5109
			public class GClass1586 : Player.FirearmController.GClass1585
			{
				// Token: 0x06006C96 RID: 27798 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(GClass2491 ammoPack, Callback callback, bool quickReload = false)
				{
					throw null;
				}

				// Token: 0x06006C97 RID: 27799 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagPuttedToRig()
				{
					throw null;
				}

				// Token: 0x06006C98 RID: 27800 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006C99 RID: 27801 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_9()
				{
					throw null;
				}

				// Token: 0x06006C9A RID: 27802 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCatched)
				{
					throw null;
				}

				// Token: 0x06006C9B RID: 27803 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagAppeared()
				{
					throw null;
				}

				// Token: 0x06006C9C RID: 27804 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_10()
				{
					throw null;
				}

				// Token: 0x06006C9D RID: 27805 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_11()
				{
					throw null;
				}

				// Token: 0x06006C9E RID: 27806 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006C9F RID: 27807 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnRemoveShellEvent()
				{
					throw null;
				}

				// Token: 0x06006CA0 RID: 27808 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x06006CA1 RID: 27809 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006CA2 RID: 27810 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_12()
				{
					throw null;
				}

				// Token: 0x06006CA3 RID: 27811 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void AddAmmoToMag()
				{
					throw null;
				}

				// Token: 0x06006CA4 RID: 27812 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private static void smethod_0(int ammoToLoadIntoMag, GClass2491 ammoPack, Player player, CylinderMagazineClass magazine, Weapon weapon, List<int> camorasIndexesForLoadAmmo)
				{
					throw null;
				}

				// Token: 0x06006CA5 RID: 27813 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006CA6 RID: 27814 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006CA7 RID: 27815 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_13()
				{
					throw null;
				}

				// Token: 0x06006CA8 RID: 27816 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void SwitchToIdle()
				{
					throw null;
				}

				// Token: 0x06006CA9 RID: 27817 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_14()
				{
					throw null;
				}

				// Token: 0x06006CAA RID: 27818 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_15()
				{
					throw null;
				}

				// Token: 0x06006CAB RID: 27819 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void SendReloadCommand()
				{
					throw null;
				}

				// Token: 0x06006CAC RID: 27820 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_16()
				{
					throw null;
				}

				// Token: 0x06006CAD RID: 27821 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override bool CanReload()
				{
					throw null;
				}

				// Token: 0x06006CAE RID: 27822 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_17()
				{
					throw null;
				}

				// Token: 0x06006CAF RID: 27823 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_18()
				{
					throw null;
				}

				// Token: 0x06006CB0 RID: 27824 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_19()
				{
					throw null;
				}

				// Token: 0x06006CB1 RID: 27825 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_20()
				{
					throw null;
				}

				// Token: 0x040075E3 RID: 30179
				protected bool bool_3;

				// Token: 0x040075E4 RID: 30180
				protected CylinderMagazineClass gclass2666_0;

				// Token: 0x040075E5 RID: 30181
				protected List<int> list_0;

				// Token: 0x040075E6 RID: 30182
				protected List<int> list_1;

				// Token: 0x040075E7 RID: 30183
				protected int int_1;

				// Token: 0x040075E8 RID: 30184
				protected bool bool_4;

				// Token: 0x040075E9 RID: 30185
				protected int int_2;

				// Token: 0x040075EA RID: 30186
				protected bool bool_5;
			}

			// Token: 0x020013F6 RID: 5110
			public class GClass1584 : Player.FirearmController.GClass1583
			{
				// Token: 0x06006CB2 RID: 27826 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06006CB3 RID: 27827 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(Player.FirearmController.GClass1574 reloadExternalMagResult, [CanBeNull] Callback callback)
				{
					throw null;
				}

				// Token: 0x06006CB4 RID: 27828 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006CB5 RID: 27829 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void UseSecondMagForReload()
				{
					throw null;
				}

				// Token: 0x06006CB8 RID: 27832 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagPulledOutFromWeapon()
				{
					throw null;
				}

				// Token: 0x06006CB9 RID: 27833 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagPuttedToRig()
				{
					throw null;
				}

				// Token: 0x06006CBA RID: 27834 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnDropMag(MagazineClass droppedMagazine)
				{
					throw null;
				}

				// Token: 0x06006CBB RID: 27835 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagAppeared()
				{
					throw null;
				}

				// Token: 0x06006CBC RID: 27836 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagInsertedToWeapon()
				{
					throw null;
				}

				// Token: 0x06006CBD RID: 27837 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCatched)
				{
					throw null;
				}

				// Token: 0x06006CBE RID: 27838 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006CBF RID: 27839 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006CC0 RID: 27840 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void SwitchToIdlingState()
				{
					throw null;
				}

				// Token: 0x06006CC1 RID: 27841 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_9()
				{
					throw null;
				}

				// Token: 0x06006CC2 RID: 27842 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnIdleStartEvent()
				{
					throw null;
				}

				// Token: 0x06006CC3 RID: 27843 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x040075EB RID: 30187
				protected Callback callback_1;

				// Token: 0x040075EC RID: 30188
				private bool bool_1;

				// Token: 0x040075ED RID: 30189
				private bool bool_2;

				// Token: 0x040075EE RID: 30190
				private bool bool_3;

				// Token: 0x040075EF RID: 30191
				private bool bool_4;

				// Token: 0x040075F0 RID: 30192
				private bool bool_5;

				// Token: 0x040075F1 RID: 30193
				private bool bool_6;

				// Token: 0x040075F2 RID: 30194
				private bool bool_7;

				// Token: 0x040075F3 RID: 30195
				private bool bool_8;

				// Token: 0x040075F4 RID: 30196
				protected Player.FirearmController.GClass1574 gclass1574_0;
			}

			// Token: 0x020013F7 RID: 5111
			public sealed class GClass1574 : IRollback, GInterface321
			{
				// Token: 0x06006CC4 RID: 27844 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RollBack()
				{
					throw null;
				}

				// Token: 0x06006CC5 RID: 27845 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
				{
					throw null;
				}

				// Token: 0x06006CC6 RID: 27846 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public static GStruct413<Player.FirearmController.GClass1574> Run(TraderControllerClass itemController, Weapon weapon, MagazineClass nextMagazine, bool quickReload, bool isKnownMalfunction, [CanBeNull] GClass2765 vestTargetAddress)
				{
					throw null;
				}

				// Token: 0x06006CC7 RID: 27847 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GStruct412 Replay()
				{
					throw null;
				}

				// Token: 0x06006CC8 RID: 27848 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool CanExecute(TraderControllerClass itemController)
				{
					throw null;
				}

				// Token: 0x040075F5 RID: 30197
				public readonly TraderControllerClass ItemController;

				// Token: 0x040075F6 RID: 30198
				public readonly Weapon Weapon;

				// Token: 0x040075F7 RID: 30199
				public readonly bool AmmoCompatible;

				// Token: 0x040075F8 RID: 30200
				[CanBeNull]
				public readonly MagazineClass OldMagazine;

				// Token: 0x040075F9 RID: 30201
				public readonly MagazineClass NextMagazine;

				// Token: 0x040075FA RID: 30202
				public readonly Slot MagazineSlot;

				// Token: 0x040075FB RID: 30203
				public readonly bool QuickReload;

				// Token: 0x040075FC RID: 30204
				public readonly bool IsKnownMalfunction;

				// Token: 0x040075FD RID: 30205
				[CanBeNull]
				public readonly GClass2781 RemoveFromChamberResult;

				// Token: 0x040075FE RID: 30206
				[CanBeNull]
				public readonly GClass2781 RemoveOldMagResult;

				// Token: 0x040075FF RID: 30207
				[CanBeNull]
				public readonly GClass2782 MoveOldMagResult;

				// Token: 0x04007600 RID: 30208
				public readonly GClass2782 InsertNextMagResult;

				// Token: 0x04007601 RID: 30209
				[CanBeNull]
				public readonly GInterface322 PopNewAmmoResult;
			}

			// Token: 0x020013F8 RID: 5112
			public class GClass1585 : Player.FirearmController.GClass1583
			{
				// Token: 0x1700112C RID: 4396
				// (get) Token: 0x06006CC9 RID: 27849 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x06006CCA RID: 27850 RVA: 0x00002050 File Offset: 0x00000250
				protected bool Boolean_0
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

				// Token: 0x06006CCB RID: 27851 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(GClass2491 ammoPack, [CanBeNull] Callback callback)
				{
					throw null;
				}

				// Token: 0x06006CCC RID: 27852 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006CCD RID: 27853 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual bool CanReload()
				{
					throw null;
				}

				// Token: 0x06006CCE RID: 27854 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006CCF RID: 27855 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x04007602 RID: 30210
				protected GClass2491 gclass2491_0;

				// Token: 0x04007603 RID: 30211
				protected MagazineClass gclass2665_0;

				// Token: 0x04007604 RID: 30212
				protected bool bool_1;

				// Token: 0x04007605 RID: 30213
				protected int int_0;

				// Token: 0x04007606 RID: 30214
				private bool bool_2;
			}

			// Token: 0x020013F9 RID: 5113
			public class GClass1587 : Player.FirearmController.GClass1585
			{
				// Token: 0x06006CD0 RID: 27856 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start(GClass2491 ammoPack, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006CD1 RID: 27857 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_9()
				{
					throw null;
				}

				// Token: 0x06006CD2 RID: 27858 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006CD3 RID: 27859 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagAppeared()
				{
					throw null;
				}

				// Token: 0x06006CD4 RID: 27860 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006CD5 RID: 27861 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCatched)
				{
					throw null;
				}

				// Token: 0x06006CD6 RID: 27862 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void AddAmmoToMag()
				{
					throw null;
				}

				// Token: 0x06006CD7 RID: 27863 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void SwitchToIdle()
				{
					throw null;
				}

				// Token: 0x06006CD8 RID: 27864 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_10()
				{
					throw null;
				}

				// Token: 0x06006CD9 RID: 27865 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public static void CommitReloadWithAmmo(int ammoToLoadIntoMag, GClass2491 ammoPack, Player player, MagazineClass magazine, Weapon weapon)
				{
					throw null;
				}

				// Token: 0x06006CDA RID: 27866 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006CDB RID: 27867 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006CDC RID: 27868 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_11()
				{
					throw null;
				}

				// Token: 0x06006CDD RID: 27869 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_12()
				{
					throw null;
				}

				// Token: 0x04007607 RID: 30215
				private BulletClass gclass2732_0;

				// Token: 0x04007608 RID: 30216
				private bool bool_3;

				// Token: 0x020013FA RID: 5114
				[CompilerGenerated]
				private sealed class Class986
				{
					// Token: 0x06006CDE RID: 27870 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x04007609 RID: 30217
					public Player player;

					// Token: 0x0400760A RID: 30218
					public Weapon weapon;

					// Token: 0x0400760B RID: 30219
					public Action action_0;
				}
			}

			// Token: 0x020013FB RID: 5115
			public class GClass1588 : Player.FirearmController.GClass1585
			{
				// Token: 0x06006CDF RID: 27871 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start(GClass2491 ammoPack, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006CE0 RID: 27872 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006CE1 RID: 27873 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_9()
				{
					throw null;
				}

				// Token: 0x06006CE2 RID: 27874 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006CE3 RID: 27875 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCatched)
				{
					throw null;
				}

				// Token: 0x06006CE4 RID: 27876 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void AddAmmoToMag()
				{
					throw null;
				}

				// Token: 0x06006CE5 RID: 27877 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006CE6 RID: 27878 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void SwitchToIdle()
				{
					throw null;
				}

				// Token: 0x06006CE7 RID: 27879 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public static void CommitReloadWithAmmo(int ammoToLoadIntoMag, GClass2491 ammoPack, Player player, MagazineClass magazine, Weapon weapon)
				{
					throw null;
				}

				// Token: 0x06006CE8 RID: 27880 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006CE9 RID: 27881 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShowAmmo(bool value)
				{
					throw null;
				}

				// Token: 0x06006CEA RID: 27882 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006CEB RID: 27883 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_10()
				{
					throw null;
				}

				// Token: 0x0400760C RID: 30220
				private Item item_0;

				// Token: 0x0400760D RID: 30221
				private bool bool_3;

				// Token: 0x0400760E RID: 30222
				private bool bool_4;

				// Token: 0x020013FC RID: 5116
				[CompilerGenerated]
				private sealed class Class987
				{
					// Token: 0x06006CEC RID: 27884 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x06006CED RID: 27885 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_1()
					{
						throw null;
					}

					// Token: 0x0400760F RID: 30223
					public Player player;

					// Token: 0x04007610 RID: 30224
					public Weapon weapon;

					// Token: 0x04007611 RID: 30225
					public Action action_0;
				}
			}

			// Token: 0x020013FD RID: 5117
			public class GClass1589 : Player.FirearmController.GClass1583
			{
				// Token: 0x06006CEE RID: 27886 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(Player.FirearmController.GClass1576 reloadMultiBarrelResult, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006CEF RID: 27887 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_9()
				{
					throw null;
				}

				// Token: 0x06006CF0 RID: 27888 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006CF1 RID: 27889 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006CF2 RID: 27890 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006CF3 RID: 27891 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnRemoveShellEvent()
				{
					throw null;
				}

				// Token: 0x06006CF4 RID: 27892 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x06006CF5 RID: 27893 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006CF6 RID: 27894 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void AddAmmoToMag()
				{
					throw null;
				}

				// Token: 0x06006CF7 RID: 27895 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagAppeared()
				{
					throw null;
				}

				// Token: 0x06006CF8 RID: 27896 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x04007612 RID: 30226
				private Player.FirearmController.GClass1576 gclass1576_0;

				// Token: 0x04007613 RID: 30227
				private bool bool_1;

				// Token: 0x04007614 RID: 30228
				private bool bool_2;

				// Token: 0x04007615 RID: 30229
				private int int_0;
			}

			// Token: 0x020013FE RID: 5118
			public sealed class GClass1575
			{
				// Token: 0x06006CF9 RID: 27897 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
				{
					throw null;
				}

				// Token: 0x06006CFA RID: 27898 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool CheckAction()
				{
					throw null;
				}

				// Token: 0x06006CFB RID: 27899 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RollBack()
				{
					throw null;
				}

				// Token: 0x04007616 RID: 30230
				public readonly int ChamberIndex;

				// Token: 0x04007617 RID: 30231
				public readonly GInterface322 OldAmmoResult;

				// Token: 0x04007618 RID: 30232
				public readonly GInterface322 InsertResult;
			}

			// Token: 0x020013FF RID: 5119
			public sealed class GClass1576 : IRollback, GInterface321
			{
				// Token: 0x06006CFC RID: 27900 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public static GStruct413<Player.FirearmController.GClass1576> Run(GInterface319 idGenerator, TraderControllerClass itemController, Weapon weapon, GClass2491 ammoPack, GClass2765 placeToPutContainedAmmo)
				{
					throw null;
				}

				// Token: 0x06006CFD RID: 27901 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RollBack()
				{
					throw null;
				}

				// Token: 0x06006CFE RID: 27902 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
				{
					throw null;
				}

				// Token: 0x06006CFF RID: 27903 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GStruct412 Replay()
				{
					throw null;
				}

				// Token: 0x06006D00 RID: 27904 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool CanExecute(TraderControllerClass itemController)
				{
					throw null;
				}

				// Token: 0x04007619 RID: 30233
				public readonly TraderControllerClass ItemController;

				// Token: 0x0400761A RID: 30234
				private readonly GInterface319 ginterface319_0;

				// Token: 0x0400761B RID: 30235
				public readonly GClass2491 AmmoPackToLoad;

				// Token: 0x0400761C RID: 30236
				public readonly Weapon Weapon;

				// Token: 0x0400761D RID: 30237
				public readonly GClass2765 PlaceToPutContainedAmmo;

				// Token: 0x0400761E RID: 30238
				public readonly IReadOnlyCollection<Player.FirearmController.GClass1575> ChambersForReloading;

				// Token: 0x0400761F RID: 30239
				public readonly int ChambersInWeaponTotal;

				// Token: 0x04007620 RID: 30240
				public readonly bool DiscardOldAmmo;
			}

			// Token: 0x02001400 RID: 5120
			public class GClass1590 : Player.FirearmController.GClass1583
			{
				// Token: 0x06006D01 RID: 27905 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(Player.FirearmController.GClass1577 reloadSingleBarrelResult, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006D02 RID: 27906 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006D03 RID: 27907 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006D04 RID: 27908 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnRemoveShellEvent()
				{
					throw null;
				}

				// Token: 0x06006D05 RID: 27909 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x06006D06 RID: 27910 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006D07 RID: 27911 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagAppeared()
				{
					throw null;
				}

				// Token: 0x06006D08 RID: 27912 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006D09 RID: 27913 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x04007621 RID: 30241
				protected Player.FirearmController.GClass1577 gclass1577_0;
			}

			// Token: 0x02001401 RID: 5121
			public sealed class GClass1577 : IRollback, GInterface321
			{
				// Token: 0x1700112D RID: 4397
				// (get) Token: 0x06006D0A RID: 27914 RVA: 0x00002050 File Offset: 0x00000250
				public bool DiscardOldAmmoToInventory
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x1700112E RID: 4398
				// (get) Token: 0x06006D0B RID: 27915 RVA: 0x00002050 File Offset: 0x00000250
				public bool HasOldAmmoInChamber
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x1700112F RID: 4399
				// (get) Token: 0x06006D0C RID: 27916 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x06006D0D RID: 27917 RVA: 0x00002050 File Offset: 0x00000250
				public string AmmoToLoadTemplateId
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

				// Token: 0x17001130 RID: 4400
				// (get) Token: 0x06006D0E RID: 27918 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x06006D0F RID: 27919 RVA: 0x00002050 File Offset: 0x00000250
				public string AmmoToUnloadTemplateId
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

				// Token: 0x06006D10 RID: 27920 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public static GStruct413<Player.FirearmController.GClass1577> Run(GInterface319 idGenerator, TraderControllerClass itemController, Weapon weapon, BulletClass ammo, GClass2765 placeToPutContainedAmmoMagazine)
				{
					throw null;
				}

				// Token: 0x06006D11 RID: 27921 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RollBack()
				{
					throw null;
				}

				// Token: 0x06006D12 RID: 27922 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
				{
					throw null;
				}

				// Token: 0x06006D13 RID: 27923 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GStruct412 Replay()
				{
					throw null;
				}

				// Token: 0x06006D14 RID: 27924 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool CanExecute(TraderControllerClass itemController)
				{
					throw null;
				}

				// Token: 0x04007622 RID: 30242
				[CanBeNull]
				public readonly GInterface322 OldAmmoResult;

				// Token: 0x04007623 RID: 30243
				[NotNull]
				public readonly GInterface322 InsertNewAmmoResult;

				// Token: 0x04007624 RID: 30244
				public readonly GClass2765 PlaceToPutContainedAmmoMagazine;

				// Token: 0x04007625 RID: 30245
				private readonly TraderControllerClass gclass2754_0;

				// Token: 0x04007626 RID: 30246
				private readonly GInterface319 ginterface319_0;

				// Token: 0x04007627 RID: 30247
				private readonly Weapon weapon_0;

				// Token: 0x04007628 RID: 30248
				private readonly BulletClass gclass2732_0;

				// Token: 0x04007629 RID: 30249
				[CompilerGenerated]
				private string string_0;

				// Token: 0x0400762A RID: 30250
				[CompilerGenerated]
				private string string_1;
			}

			// Token: 0x02001402 RID: 5122
			public sealed class GClass1620 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006D15 RID: 27925 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Item item, Slot slot, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006D16 RID: 27926 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006D17 RID: 27927 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006D18 RID: 27928 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06006D19 RID: 27929 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnModChanged()
				{
					throw null;
				}

				// Token: 0x06006D1A RID: 27930 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x06006D1B RID: 27931 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006D1C RID: 27932 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanChangeLightState(GStruct162[] lightsStates)
				{
					throw null;
				}

				// Token: 0x0400762B RID: 30251
				private Slot slot_0;

				// Token: 0x0400762C RID: 30252
				private Callback callback_0;

				// Token: 0x0400762D RID: 30253
				private bool bool_0;
			}

			// Token: 0x02001403 RID: 5123
			public sealed class GClass1621 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006D1D RID: 27933 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Action onHidden, bool fastDrop = false, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006D1E RID: 27934 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x06006D1F RID: 27935 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006D20 RID: 27936 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeaponComplete()
				{
					throw null;
				}

				// Token: 0x06006D21 RID: 27937 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006D22 RID: 27938 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006D23 RID: 27939 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanChangeLightState(GStruct162[] lightsStates)
				{
					throw null;
				}

				// Token: 0x06006D24 RID: 27940 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void BlindFire(int b)
				{
					throw null;
				}

				// Token: 0x0400762E RID: 30254
				private Action action_0;
			}

			// Token: 0x02001404 RID: 5124
			public sealed class GClass1578 : IRollback, GInterface321
			{
				// Token: 0x06006D25 RID: 27941 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RollBack()
				{
					throw null;
				}

				// Token: 0x06006D26 RID: 27942 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
				{
					throw null;
				}

				// Token: 0x06006D27 RID: 27943 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public static GStruct413<Player.FirearmController.GClass1578> Run(TraderControllerClass itemController, Weapon weapon)
				{
					throw null;
				}

				// Token: 0x06006D28 RID: 27944 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GStruct412 Replay()
				{
					throw null;
				}

				// Token: 0x06006D29 RID: 27945 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool CanExecute(TraderControllerClass itemController)
				{
					throw null;
				}

				// Token: 0x0400762F RID: 30255
				public readonly TraderControllerClass ItemController;

				// Token: 0x04007630 RID: 30256
				public readonly Weapon Weapon;

				// Token: 0x04007631 RID: 30257
				public readonly bool AmmoCompatible;

				// Token: 0x04007632 RID: 30258
				public readonly GInterface322 PopNewAmmoResult;
			}

			// Token: 0x02001405 RID: 5125
			public class GClass1616 : Player.FirearmController.GClass1614
			{
				// Token: 0x06006D2A RID: 27946 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start()
				{
					throw null;
				}

				// Token: 0x06006D2B RID: 27947 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006D2C RID: 27948 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006D2D RID: 27949 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006D2E RID: 27950 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnOnOffBoltCatchEvent(bool isCatched)
				{
					throw null;
				}

				// Token: 0x06006D2F RID: 27951 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void RemoveAmmoFromChamber()
				{
					throw null;
				}

				// Token: 0x06006D30 RID: 27952 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006D31 RID: 27953 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMalfunctionOffEvent()
				{
					throw null;
				}

				// Token: 0x06006D32 RID: 27954 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x06006D33 RID: 27955 RVA: 0x00002050 File Offset: 0x00000250
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_6()
				{
					throw null;
				}

				// Token: 0x04007633 RID: 30259
				private bool bool_0;

				// Token: 0x04007634 RID: 30260
				private bool bool_1;

				// Token: 0x04007635 RID: 30261
				private Weapon.EMalfunctionState emalfunctionState_0;
			}

			// Token: 0x02001406 RID: 5126
			public class GClass1622 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006D34 RID: 27956 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal virtual void Start(Callback finishCallback, bool rollToZeroCamora)
				{
					throw null;
				}

				// Token: 0x06006D35 RID: 27957 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006D36 RID: 27958 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006D37 RID: 27959 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMagPuttedToRig()
				{
					throw null;
				}

				// Token: 0x06006D38 RID: 27960 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x04007636 RID: 30262
				protected CylinderMagazineClass gclass2666_0;

				// Token: 0x04007637 RID: 30263
				private bool bool_0;

				// Token: 0x04007638 RID: 30264
				private Callback callback_0;

				// Token: 0x04007639 RID: 30265
				private bool bool_1;
			}

			// Token: 0x02001407 RID: 5127
			public sealed class GClass1595 : Player.FirearmController.GClass1594
			{
				// Token: 0x06006D39 RID: 27961 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006D3A RID: 27962 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006D3B RID: 27963 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x0400763A RID: 30266
				private const float float_0 = 0.35f;

				// Token: 0x0400763B RID: 30267
				private float float_1;

				// Token: 0x0400763C RID: 30268
				private bool bool_1;
			}

			// Token: 0x02001408 RID: 5128
			public class GClass1623 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006D3C RID: 27964 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(Action onWeaponAppear)
				{
					throw null;
				}

				// Token: 0x06006D3D RID: 27965 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x06006D3E RID: 27966 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006D3F RID: 27967 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAddAmmoInChamber()
				{
					throw null;
				}

				// Token: 0x06006D40 RID: 27968 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void WeaponAppeared()
				{
					throw null;
				}

				// Token: 0x06006D41 RID: 27969 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnIdleStartEvent()
				{
					throw null;
				}

				// Token: 0x06006D42 RID: 27970 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006D43 RID: 27971 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006D44 RID: 27972 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006D45 RID: 27973 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanChangeLightState(GStruct162[] lightsStates)
				{
					throw null;
				}

				// Token: 0x0400763D RID: 30269
				private Action action_0;

				// Token: 0x0400763E RID: 30270
				private Action action_1;

				// Token: 0x0400763F RID: 30271
				private bool bool_0;

				// Token: 0x04007640 RID: 30272
				private BulletClass gclass2732_0;

				// Token: 0x04007641 RID: 30273
				private MagazineClass gclass2665_0;

				// Token: 0x04007642 RID: 30274
				private bool bool_1;
			}

			// Token: 0x02001409 RID: 5129
			public sealed class GClass1617 : Player.FirearmController.GClass1614
			{
				// Token: 0x06006D46 RID: 27974 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start()
				{
					throw null;
				}

				// Token: 0x06006D47 RID: 27975 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x06006D48 RID: 27976 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006D49 RID: 27977 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnMalfunctionOffEvent()
				{
					throw null;
				}
			}

			// Token: 0x0200140A RID: 5130
			public class GClass1624 : Player.FirearmController.GClass1581
			{
				// Token: 0x06006D4A RID: 27978 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(bool isLauncherEnabled, Action callback = null)
				{
					throw null;
				}

				// Token: 0x06006D4B RID: 27979 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x06006D4C RID: 27980 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006D4D RID: 27981 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006D4E RID: 27982 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null)
				{
					throw null;
				}

				// Token: 0x06006D4F RID: 27983 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void LauncherAppeared()
				{
					throw null;
				}

				// Token: 0x06006D50 RID: 27984 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnEnd()
				{
					throw null;
				}

				// Token: 0x06006D51 RID: 27985 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void LauncherDisappeared()
				{
					throw null;
				}

				// Token: 0x06006D52 RID: 27986 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006D53 RID: 27987 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x06006D54 RID: 27988 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_6(bool val)
				{
					throw null;
				}

				// Token: 0x04007643 RID: 30275
				private Action action_0;

				// Token: 0x04007644 RID: 30276
				private WeaponPrefab weaponPrefab_0;

				// Token: 0x04007645 RID: 30277
				private bool bool_0;

				// Token: 0x04007646 RID: 30278
				private bool bool_1;

				// Token: 0x04007647 RID: 30279
				private Action action_1;
			}

			// Token: 0x0200140B RID: 5131
			public class GClass1579 : GInterface137
			{
				// Token: 0x17001131 RID: 4401
				// (get) Token: 0x06006D55 RID: 27989 RVA: 0x00002050 File Offset: 0x00000250
				public FirearmsEffects FirearmsEffects
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x17001132 RID: 4402
				// (get) Token: 0x06006D56 RID: 27990 RVA: 0x00002050 File Offset: 0x00000250
				public WeaponSoundPlayer WeaponSoundPlayer
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x17001133 RID: 4403
				// (get) Token: 0x06006D57 RID: 27991 RVA: 0x00002050 File Offset: 0x00000250
				private static WeaponSounds WeaponSounds_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x17001134 RID: 4404
				// (get) Token: 0x06006D58 RID: 27992 RVA: 0x00002050 File Offset: 0x00000250
				public BifacialTransform Fireport
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x17001135 RID: 4405
				// (get) Token: 0x06006D59 RID: 27993 RVA: 0x00002050 File Offset: 0x00000250
				public WeaponPrefab LauncherWeaponPrefab
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06006D5A RID: 27994 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Init(Player player, Player.FirearmController controller, GClass2664 launcher)
				{
					throw null;
				}

				// Token: 0x06006D5B RID: 27995 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Init(Player player, Player.FirearmController controller, GClass2664 launcher, GameObject underbarrelPrefab)
				{
					throw null;
				}

				// Token: 0x06006D5C RID: 27996 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void InitWeaponSoundPlayer()
				{
					throw null;
				}

				// Token: 0x06006D5D RID: 27997 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_0(Player player, Player.FirearmController controller, GClass2664 launcher)
				{
					throw null;
				}

				// Token: 0x06006D5E RID: 27998 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_1()
				{
					throw null;
				}

				// Token: 0x06006D5F RID: 27999 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_2()
				{
					throw null;
				}

				// Token: 0x06006D60 RID: 28000 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_3()
				{
					throw null;
				}

				// Token: 0x06006D61 RID: 28001 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void StartSpawnShell(Vector3 playerVelocity, int shellPortIndex = 0)
				{
					throw null;
				}

				// Token: 0x06006D62 RID: 28002 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_4()
				{
					throw null;
				}

				// Token: 0x06006D63 RID: 28003 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_5()
				{
					throw null;
				}

				// Token: 0x06006D64 RID: 28004 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private bool method_6()
				{
					throw null;
				}

				// Token: 0x06006D65 RID: 28005 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private bool method_7()
				{
					throw null;
				}

				// Token: 0x06006D66 RID: 28006 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MoveAmmoFromChamberToShellPort(bool ammoIsUsed, int chamberIndex = 0)
				{
					throw null;
				}

				// Token: 0x06006D67 RID: 28007 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void SetRoundIntoWeapon(BulletClass ammo)
				{
					throw null;
				}

				// Token: 0x06006D68 RID: 28008 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void SetPatronInShellPort(AmmoPoolObject ammoObject, int shellTransformIndex = 0)
				{
					throw null;
				}

				// Token: 0x06006D69 RID: 28009 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool DestroyPatronInWeapon()
				{
					throw null;
				}

				// Token: 0x06006D6A RID: 28010 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void RemoveShellInWeapon()
				{
					throw null;
				}

				// Token: 0x06006D6B RID: 28011 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_8()
				{
					throw null;
				}

				// Token: 0x06006D6C RID: 28012 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool HasPatronInWeapon()
				{
					throw null;
				}

				// Token: 0x06006D6D RID: 28013 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool HasShellInWeapon()
				{
					throw null;
				}

				// Token: 0x06006D6E RID: 28014 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private static AmmoPoolObject smethod_0(Item ammo)
				{
					throw null;
				}

				// Token: 0x06006D6F RID: 28015 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public static void ParentAmmoOrShellToTransform(GameObject shell, Transform shellParent)
				{
					throw null;
				}

				// Token: 0x06006D70 RID: 28016 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private AmmoPoolObject method_9(Vector3 playerVelocity, AmmoPoolObject shell)
				{
					throw null;
				}

				// Token: 0x06006D71 RID: 28017 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_10(Vector3 force, Vector3 torque, AmmoPoolObject shell, Vector3 parentForce)
				{
					throw null;
				}

				// Token: 0x06006D72 RID: 28018 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private IEnumerator method_11(Vector3 playerVelocity, int shellPortIndex = 0)
				{
					throw null;
				}

				// Token: 0x06006D73 RID: 28019 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_12(Vector3 position, BaseBallistic.ESurfaceSound material, ECaliber caliber)
				{
					throw null;
				}

				// Token: 0x06006D74 RID: 28020 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void InvokeShellCollision(Vector3 position, BaseBallistic.ESurfaceSound material, ECaliber caliber)
				{
					throw null;
				}

				// Token: 0x06006D75 RID: 28021 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Clear()
				{
					throw null;
				}

				// Token: 0x04007648 RID: 30280
				public const string SHELLPORT_TRANSFORM_NAME = "shellport";

				// Token: 0x04007649 RID: 30281
				public const string PATRON_IN_WEAPON_TRANSFORM_NAME = "patron_in_weapon";

				// Token: 0x0400764A RID: 30282
				private Player player_0;

				// Token: 0x0400764B RID: 30283
				private Player.FirearmController firearmController_0;

				// Token: 0x0400764C RID: 30284
				private WeaponPrefab weaponPrefab_0;

				// Token: 0x0400764D RID: 30285
				private GClass2664 gclass2664_0;

				// Token: 0x0400764E RID: 30286
				private bool bool_0;

				// Token: 0x0400764F RID: 30287
				private FirearmsEffects firearmsEffects_0;

				// Token: 0x04007650 RID: 30288
				private WeaponSoundPlayer weaponSoundPlayer_0;

				// Token: 0x04007651 RID: 30289
				private Transform transform_0;

				// Token: 0x04007652 RID: 30290
				private Vector3 vector3_0;

				// Token: 0x04007653 RID: 30291
				private Transform transform_1;

				// Token: 0x04007654 RID: 30292
				private AmmoPoolObject ammoPoolObject_0;

				// Token: 0x04007655 RID: 30293
				private AmmoPoolObject ammoPoolObject_1;

				// Token: 0x04007656 RID: 30294
				private ShellExtractionData shellExtractionData_0;

				// Token: 0x04007657 RID: 30295
				private BifacialTransform bifacialTransform_0;

				// Token: 0x04007658 RID: 30296
				private WaitForEndOfFrame waitForEndOfFrame_0;
			}

			// Token: 0x0200140D RID: 5133
			public class GClass1606 : Player.FirearmController.GClass1605
			{
				// Token: 0x06006D7A RID: 28026 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Player.FirearmController.GClass1606.EUtilityType utilityType)
				{
					throw null;
				}

				// Token: 0x06006D7B RID: 28027 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x06006D7C RID: 28028 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnIdleStartEvent()
				{
					throw null;
				}

				// Token: 0x06006D7D RID: 28029 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnUtilityOperationStartEvent()
				{
					throw null;
				}

				// Token: 0x06006D7E RID: 28030 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanStartReload()
				{
					throw null;
				}

				// Token: 0x06006D7F RID: 28031 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006D80 RID: 28032 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CheckAmmo()
				{
					throw null;
				}

				// Token: 0x06006D81 RID: 28033 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CheckChamber()
				{
					throw null;
				}

				// Token: 0x06006D82 RID: 28034 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CheckFireMode()
				{
					throw null;
				}

				// Token: 0x06006D83 RID: 28035 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadMag(MagazineClass magazine, GClass2765 gridItemAddress, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006D84 RID: 28036 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadWithAmmo(GClass2491 ammoPack, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006D85 RID: 28037 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadCylinderMagazine(GClass2491 ammoPack, Callback finishCallback, Callback startCallback, bool quickReload = false)
				{
					throw null;
				}

				// Token: 0x06006D86 RID: 28038 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void QuickReloadMag(MagazineClass magazine, Callback finishCallback, Callback startCallback)
				{
					throw null;
				}

				// Token: 0x06006D87 RID: 28039 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ReloadGrenadeLauncher(GClass2491 ammoPack, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006D88 RID: 28040 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetTriggerPressed(bool pressed)
				{
					throw null;
				}

				// Token: 0x06006D89 RID: 28041 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006D8A RID: 28042 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006D8B RID: 28043 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06006D8C RID: 28044 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x06006D8D RID: 28045 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnShellEjectEvent()
				{
					throw null;
				}

				// Token: 0x0400765E RID: 30302
				private const float float_3 = 2.5f;

				// Token: 0x0400765F RID: 30303
				private float float_4;

				// Token: 0x04007660 RID: 30304
				private bool bool_1;

				// Token: 0x04007661 RID: 30305
				private Player.FirearmController.GClass1606.EUtilityType eutilityType_0;

				// Token: 0x0200140E RID: 5134
				public enum EUtilityType
				{
					// Token: 0x04007663 RID: 30307
					None,
					// Token: 0x04007664 RID: 30308
					ExamineWeapon,
					// Token: 0x04007665 RID: 30309
					CheckChamber,
					// Token: 0x04007666 RID: 30310
					CheckMagazine,
					// Token: 0x04007667 RID: 30311
					CheckFireMode
				}
			}

			// Token: 0x02001410 RID: 5136
			[CompilerGenerated]
			private sealed class Class989<T> where T : Player.FirearmController
			{
				// Token: 0x06006D90 RID: 28048 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_0()
				{
					throw null;
				}

				// Token: 0x06006D91 RID: 28049 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_1()
				{
					throw null;
				}

				// Token: 0x06006D92 RID: 28050 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_2()
				{
					throw null;
				}

				// Token: 0x06006D93 RID: 28051 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_3()
				{
					throw null;
				}

				// Token: 0x06006D94 RID: 28052 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_4(bool visible)
				{
					throw null;
				}

				// Token: 0x06006D95 RID: 28053 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_5()
				{
					throw null;
				}

				// Token: 0x06006D96 RID: 28054 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_6()
				{
					throw null;
				}

				// Token: 0x0400766F RID: 30319
				public Player player;

				// Token: 0x04007670 RID: 30320
				public T controller;
			}

			// Token: 0x02001411 RID: 5137
			[CompilerGenerated]
			[Serializable]
			private sealed class Class990<T> where T : Player.FirearmController
			{
				// Token: 0x06006D97 RID: 28055 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_0(Slot slot)
				{
					throw null;
				}

				// Token: 0x06006D98 RID: 28056 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal GClass2646 method_1(Slot x)
				{
					throw null;
				}

				// Token: 0x04007671 RID: 30321
				public static readonly Player.FirearmController.Class990<T> class990_0;

				// Token: 0x04007672 RID: 30322
				public static Func<Slot, bool> func_0;

				// Token: 0x04007673 RID: 30323
				public static Func<Slot, GClass2646> func_1;
			}

			// Token: 0x02001413 RID: 5139
			[CompilerGenerated]
			[Serializable]
			private sealed class Class991
			{
				// Token: 0x06006D9B RID: 28059 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_0(GClass2646 x)
				{
					throw null;
				}

				// Token: 0x06006D9C RID: 28060 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_1(Slot slot)
				{
					throw null;
				}

				// Token: 0x06006D9D RID: 28061 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal GClass2646 method_2(Slot x)
				{
					throw null;
				}

				// Token: 0x06006D9E RID: 28062 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_3(Slot slot)
				{
					throw null;
				}

				// Token: 0x06006D9F RID: 28063 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Mod method_4(Slot slot)
				{
					throw null;
				}

				// Token: 0x06006DA0 RID: 28064 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal int method_5(Mod mod)
				{
					throw null;
				}

				// Token: 0x06006DA1 RID: 28065 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Item method_6(Slot x)
				{
					throw null;
				}

				// Token: 0x06006DA2 RID: 28066 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string method_7(LightComponent x)
				{
					throw null;
				}

				// Token: 0x06006DA3 RID: 28067 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal LightComponent method_8(LightComponent x)
				{
					throw null;
				}

				// Token: 0x06006DA4 RID: 28068 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Item method_9(Slot x)
				{
					throw null;
				}

				// Token: 0x06006DA5 RID: 28069 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string method_10(SightComponent x)
				{
					throw null;
				}

				// Token: 0x06006DA6 RID: 28070 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal SightComponent method_11(SightComponent x)
				{
					throw null;
				}

				// Token: 0x06006DA7 RID: 28071 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_12(KeyValuePair<string, LightComponent> x)
				{
					throw null;
				}

				// Token: 0x06006DA8 RID: 28072 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Item method_13(Slot slot)
				{
					throw null;
				}

				// Token: 0x0400767D RID: 30333
				public static readonly Player.FirearmController.Class991 class991_0;

				// Token: 0x0400767E RID: 30334
				public static Func<GClass2646, bool> func_0;

				// Token: 0x0400767F RID: 30335
				public static Func<Slot, bool> func_1;

				// Token: 0x04007680 RID: 30336
				public static Func<Slot, GClass2646> func_2;

				// Token: 0x04007681 RID: 30337
				public static Func<Slot, bool> func_3;

				// Token: 0x04007682 RID: 30338
				public static Func<Slot, Mod> func_4;

				// Token: 0x04007683 RID: 30339
				public static Func<Mod, int> func_5;

				// Token: 0x04007684 RID: 30340
				public static Func<Slot, Item> func_6;

				// Token: 0x04007685 RID: 30341
				public static Func<LightComponent, string> func_7;

				// Token: 0x04007686 RID: 30342
				public static Func<LightComponent, LightComponent> func_8;

				// Token: 0x04007687 RID: 30343
				public static Func<Slot, Item> func_9;

				// Token: 0x04007688 RID: 30344
				public static Func<SightComponent, string> func_10;

				// Token: 0x04007689 RID: 30345
				public static Func<SightComponent, SightComponent> func_11;

				// Token: 0x0400768A RID: 30346
				public static Func<KeyValuePair<string, LightComponent>, bool> func_12;

				// Token: 0x0400768B RID: 30347
				public static Func<Slot, Item> func_13;
			}

			// Token: 0x02001414 RID: 5140
			[CompilerGenerated]
			private sealed class Class992
			{
				// Token: 0x06006DA9 RID: 28073 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x0400768C RID: 30348
				public Action callback;

				// Token: 0x0400768D RID: 30349
				public Player.FirearmController firearmController_0;
			}

			// Token: 0x02001415 RID: 5141
			[CompilerGenerated]
			private sealed class Class993
			{
				// Token: 0x06006DAA RID: 28074 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x0400768E RID: 30350
				public Player.Class1059 inventoryOperation;

				// Token: 0x0400768F RID: 30351
				public Action callback;
			}
		}

		// Token: 0x02001416 RID: 5142
		public interface GInterface120
		{
			// Token: 0x06006DAB RID: 28075
			void OnDrawCompleteAction();

			// Token: 0x06006DAC RID: 28076
			void OnHideCompleteActionAction();

			// Token: 0x06006DAD RID: 28077
			void OnDropGrenadeAction();

			// Token: 0x06006DAE RID: 28078
			void OnDropFinishedAction();

			// Token: 0x06006DAF RID: 28079
			void StartCountdown();

			// Token: 0x06006DB0 RID: 28080
			void HideGrenade(Action onHidden, bool fastHide);

			// Token: 0x06006DB1 RID: 28081
			void PutGrenadeBack();

			// Token: 0x06006DB2 RID: 28082
			void ShowGesture(EGesture gesture);

			// Token: 0x06006DB3 RID: 28083
			bool CanRemove();

			// Token: 0x06006DB4 RID: 28084
			void FastForward();

			// Token: 0x06006DB5 RID: 28085
			void OnBackpackDrop();

			// Token: 0x06006DB6 RID: 28086
			void Execute(GInterface336 operation, Callback callback);
		}

		// Token: 0x02001417 RID: 5143
		internal abstract class BaseGrenadeController : Player.ItemHandsController
		{
			// Token: 0x17001138 RID: 4408
			// (get) Token: 0x06006DB7 RID: 28087 RVA: 0x00002050 File Offset: 0x00000250
			public new GrenadeClass Item
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001139 RID: 4409
			// (get) Token: 0x06006DB8 RID: 28088 RVA: 0x00002050 File Offset: 0x00000250
			public override FirearmsAnimator FirearmsAnimator
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700113A RID: 4410
			// (get) Token: 0x06006DB9 RID: 28089 RVA: 0x00002050 File Offset: 0x00000250
			protected Player.GInterface120 GInterface120_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006DBA RID: 28090 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_5<T>(Player player, GrenadeClass item, bool setQuickThrowParameters) where T : Player.BaseGrenadeController
			{
				throw null;
			}

			// Token: 0x06006DBB RID: 28091 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Task<T> smethod_6<T>(Player player, GrenadeClass item, bool setQuickThrowParameters) where T : Player.BaseGrenadeController
			{
				throw null;
			}

			// Token: 0x06006DBC RID: 28092 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static void smethod_7<T>(T controller, Player player, bool setQuickThrowParameters) where T : Player.BaseGrenadeController
			{
				throw null;
			}

			// Token: 0x06006DBD RID: 28093 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapIn()
			{
				throw null;
			}

			// Token: 0x06006DBE RID: 28094 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapOut()
			{
				throw null;
			}

			// Token: 0x06006DBF RID: 28095 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnFiringBullet()
			{
				throw null;
			}

			// Token: 0x06006DC0 RID: 28096 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnFireEnd()
			{
				throw null;
			}

			// Token: 0x06006DC1 RID: 28097 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnAddAmmoInChamber()
			{
				throw null;
			}

			// Token: 0x06006DC2 RID: 28098 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnDelAmmoChamber()
			{
				throw null;
			}

			// Token: 0x06006DC3 RID: 28099 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnThirdAction(int intParam)
			{
				throw null;
			}

			// Token: 0x06006DC4 RID: 28100 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnCook()
			{
				throw null;
			}

			// Token: 0x06006DC5 RID: 28101 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsOnBackpackDrop()
			{
				throw null;
			}

			// Token: 0x06006DC6 RID: 28102 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool SupportPickup()
			{
				throw null;
			}

			// Token: 0x06006DC7 RID: 28103 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnOnUseProp(bool boolParam)
			{
				throw null;
			}

			// Token: 0x06006DC8 RID: 28104 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Pickup(bool p)
			{
				throw null;
			}

			// Token: 0x06006DC9 RID: 28105 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Interact(bool isInteracting, int actionIndex)
			{
				throw null;
			}

			// Token: 0x06006DCA RID: 28106 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanInteract()
			{
				throw null;
			}

			// Token: 0x06006DCB RID: 28107 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Loot(bool p)
			{
				throw null;
			}

			// Token: 0x06006DCC RID: 28108 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override float GetAnimatorFloatParam(int hash)
			{
				throw null;
			}

			// Token: 0x06006DCD RID: 28109 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInInteraction()
			{
				throw null;
			}

			// Token: 0x06006DCE RID: 28110 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInInteractionStrictCheck()
			{
				throw null;
			}

			// Token: 0x06006DCF RID: 28111 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Spawn(float animationSpeed, Action callback)
			{
				throw null;
			}

			// Token: 0x06006DD0 RID: 28112 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null)
			{
				throw null;
			}

			// Token: 0x06006DD1 RID: 28113 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ActualDrop(Result<IHandsController> controller, float animationSpeed, Action callback, bool fastDrop)
			{
				throw null;
			}

			// Token: 0x06006DD2 RID: 28114 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Destroy()
			{
				throw null;
			}

			// Token: 0x06006DD3 RID: 28115 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void method_0()
			{
				throw null;
			}

			// Token: 0x06006DD4 RID: 28116 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void vmethod_0()
			{
				throw null;
			}

			// Token: 0x06006DD5 RID: 28117 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void method_1()
			{
				throw null;
			}

			// Token: 0x06006DD6 RID: 28118 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void method_2()
			{
				throw null;
			}

			// Token: 0x06006DD7 RID: 28119 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void method_3()
			{
				throw null;
			}

			// Token: 0x06006DD8 RID: 28120 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void method_4()
			{
				throw null;
			}

			// Token: 0x06006DD9 RID: 28121 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanExecute(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06006DDA RID: 28122 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Execute(GInterface336 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006DDB RID: 28123 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ShowGesture(EGesture gesture)
			{
				throw null;
			}

			// Token: 0x06006DDC RID: 28124 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_5()
			{
				throw null;
			}

			// Token: 0x06006DDD RID: 28125 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_6()
			{
				throw null;
			}

			// Token: 0x06006DDE RID: 28126 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void vmethod_1(float timeSinceSafetyLevelRemoved, bool low = false)
			{
				throw null;
			}

			// Token: 0x06006DDF RID: 28127 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_7(float timeSinceSafetyLevelRemoved, float lowHighThrow, Vector3 direction, float forcePower, bool lowThrow)
			{
				throw null;
			}

			// Token: 0x06006DE0 RID: 28128 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static bool CheckHandsToBodyObstacles(Player player, Vector3 point, out RaycastHit hit, out Vector3 correctedPoint)
			{
				throw null;
			}

			// Token: 0x06006DE1 RID: 28129 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Grenade method_8(Vector3 position, Quaternion rotation, Vector3 force, float prewarm = 0f)
			{
				throw null;
			}

			// Token: 0x06006DE2 RID: 28130 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void vmethod_2(float timeSinceSafetyLevelRemoved, Vector3 position, Quaternion rotation, Vector3 force, bool lowThrow)
			{
				throw null;
			}

			// Token: 0x06006DE3 RID: 28131 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void FastForwardCurrentState()
			{
				throw null;
			}

			// Token: 0x06006DE4 RID: 28132 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_9()
			{
				throw null;
			}

			// Token: 0x04007690 RID: 30352
			protected FirearmsAnimator firearmsAnimator_0;

			// Token: 0x04007691 RID: 30353
			private const string string_0 = "fireport";

			// Token: 0x04007692 RID: 30354
			protected Transform transform_0;

			// Token: 0x04007693 RID: 30355
			protected Transform transform_1;

			// Token: 0x04007694 RID: 30356
			protected Transform[] transform_2;

			// Token: 0x04007695 RID: 30357
			protected GrenadePrefab grenadePrefab_0;

			// Token: 0x04007696 RID: 30358
			protected GrenadeEmission grenadeEmission_0;

			// Token: 0x04007697 RID: 30359
			private static readonly RaycastHit[] raycastHit_0;

			// Token: 0x04007698 RID: 30360
			private static Func<RaycastHit, bool> func_0;

			// Token: 0x02001419 RID: 5145
			[CompilerGenerated]
			private sealed class Class994<T> where T : Player.BaseGrenadeController
			{
				// Token: 0x06006DE7 RID: 28135 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x06006DE8 RID: 28136 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Transform method_1(string x)
				{
					throw null;
				}

				// Token: 0x0400769F RID: 30367
				public T controller;

				// Token: 0x040076A0 RID: 30368
				public Player player;
			}

			// Token: 0x0200141A RID: 5146
			[CompilerGenerated]
			private sealed class Class995
			{
				// Token: 0x06006DE9 RID: 28137 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(Result<IHandsController> result)
				{
					throw null;
				}

				// Token: 0x040076A1 RID: 30369
				public Player.BaseGrenadeController baseGrenadeController_0;

				// Token: 0x040076A2 RID: 30370
				public float animationSpeed;

				// Token: 0x040076A3 RID: 30371
				public Action callback;

				// Token: 0x040076A4 RID: 30372
				public bool fastDrop;
			}

			// Token: 0x0200141B RID: 5147
			[CompilerGenerated]
			private sealed class Class996
			{
				// Token: 0x06006DEA RID: 28138 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x040076A5 RID: 30373
				public Player.Class1059 inventoryOperation;

				// Token: 0x040076A6 RID: 30374
				public Action callback;
			}

			// Token: 0x0200141C RID: 5148
			[CompilerGenerated]
			[Serializable]
			private sealed class Class997
			{
				// Token: 0x06006DEB RID: 28139 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_0(RaycastHit raycastHit)
				{
					throw null;
				}

				// Token: 0x040076A7 RID: 30375
				public static readonly Player.BaseGrenadeController.Class997 class997_0;
			}
		}

		// Token: 0x0200141D RID: 5149
		internal class GrenadeController : Player.BaseGrenadeController, GInterface123, GInterface124, GInterface126, IHandsController
		{
			// Token: 0x1700113B RID: 4411
			// (get) Token: 0x06006DEC RID: 28140 RVA: 0x00002050 File Offset: 0x00000250
			public new GrenadeClass Item
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006DED RID: 28141 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_8<T>(Player player, GrenadeClass item) where T : Player.GrenadeController
			{
				throw null;
			}

			// Token: 0x06006DEE RID: 28142 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Task<T> smethod_9<T>(Player player, GrenadeClass item) where T : Player.GrenadeController
			{
				throw null;
			}

			// Token: 0x1700113C RID: 4412
			// (get) Token: 0x06006DEF RID: 28143 RVA: 0x00002050 File Offset: 0x00000250
			protected internal Player.GrenadeController.Class1021 Class1021_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006DF0 RID: 28144 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanExecute(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06006DF1 RID: 28145 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Execute(GInterface336 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006DF2 RID: 28146 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Spawn(float animationSpeed, Action callback)
			{
				throw null;
			}

			// Token: 0x06006DF3 RID: 28147 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ExamineWeapon()
			{
				throw null;
			}

			// Token: 0x1700113D RID: 4413
			// (get) Token: 0x06006DF4 RID: 28148 RVA: 0x00002050 File Offset: 0x00000250
			public bool WaitingForHighThrow
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006DF5 RID: 28149 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void PullRingForHighThrow()
			{
				throw null;
			}

			// Token: 0x06006DF6 RID: 28150 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void HighThrow()
			{
				throw null;
			}

			// Token: 0x1700113E RID: 4414
			// (get) Token: 0x06006DF7 RID: 28151 RVA: 0x00002050 File Offset: 0x00000250
			public bool WaitingForLowThrow
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006DF8 RID: 28152 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void PullRingForLowThrow()
			{
				throw null;
			}

			// Token: 0x06006DF9 RID: 28153 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void LowThrow()
			{
				throw null;
			}

			// Token: 0x06006DFA RID: 28154 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetOnUsedCallback(Callback<IHandsController> callback)
			{
				throw null;
			}

			// Token: 0x06006DFB RID: 28155 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetInventoryOpened(bool opened)
			{
				throw null;
			}

			// Token: 0x06006DFC RID: 28156 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInventoryOpen()
			{
				throw null;
			}

			// Token: 0x06006DFD RID: 28157 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanRemove()
			{
				throw null;
			}

			// Token: 0x06006DFE RID: 28158 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void vmethod_3()
			{
				throw null;
			}

			// Token: 0x06006DFF RID: 28159 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool CanThrow()
			{
				throw null;
			}

			// Token: 0x06006E00 RID: 28160 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetCompassState(bool active)
			{
				throw null;
			}

			// Token: 0x06006E01 RID: 28161 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_10()
			{
				throw null;
			}

			// Token: 0x06006E02 RID: 28162 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_11()
			{
				throw null;
			}

			// Token: 0x06006E03 RID: 28163 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_12()
			{
				throw null;
			}

			// Token: 0x06006E04 RID: 28164 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_13()
			{
				throw null;
			}

			// Token: 0x06006E05 RID: 28165 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_14()
			{
				throw null;
			}

			// Token: 0x06006E06 RID: 28166 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_15()
			{
				throw null;
			}

			// Token: 0x040076A8 RID: 30376
			private bool bool_0;

			// Token: 0x040076A9 RID: 30377
			private Callback<IHandsController> callback_0;

			// Token: 0x0200141E RID: 5150
			public class Class1022 : Player.GrenadeController.Class1021
			{
				// Token: 0x06006E07 RID: 28167 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006E08 RID: 28168 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006E09 RID: 28169 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnBackpackDrop()
				{
					throw null;
				}

				// Token: 0x06006E0A RID: 28170 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x040076AA RID: 30378
				private Callback callback_0;
			}

			// Token: 0x0200141F RID: 5151
			public abstract class Class1021 : Player.Class1020<Player.GrenadeController>
			{
				// Token: 0x06006E0B RID: 28171 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x06006E0C RID: 28172 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void PullRingForHighThrow()
				{
					throw null;
				}

				// Token: 0x06006E0D RID: 28173 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void HighThrow()
				{
					throw null;
				}

				// Token: 0x06006E0E RID: 28174 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void PullRingForLowThrow()
				{
					throw null;
				}

				// Token: 0x06006E0F RID: 28175 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void LowThrow()
				{
					throw null;
				}

				// Token: 0x06006E10 RID: 28176 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006E11 RID: 28177 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetGrenadeCompassState(bool active)
				{
					throw null;
				}
			}

			// Token: 0x02001420 RID: 5152
			protected class Class1024 : Player.GrenadeController.Class1021
			{
				// Token: 0x1700113F RID: 4415
				// (get) Token: 0x06006E12 RID: 28178 RVA: 0x00002050 File Offset: 0x00000250
				public virtual bool WaitingHighThrow
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06006E13 RID: 28179 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public new void Start()
				{
					throw null;
				}

				// Token: 0x06006E14 RID: 28180 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006E15 RID: 28181 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void vmethod_0()
				{
					throw null;
				}

				// Token: 0x06006E16 RID: 28182 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HighThrow()
				{
					throw null;
				}

				// Token: 0x06006E17 RID: 28183 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnDropGrenadeAction()
				{
					throw null;
				}

				// Token: 0x06006E18 RID: 28184 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_2(bool low = false)
				{
					throw null;
				}

				// Token: 0x06006E19 RID: 28185 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnDropFinishedAction()
				{
					throw null;
				}

				// Token: 0x06006E1A RID: 28186 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideGrenade(Action onHidden, bool fastHide)
				{
					throw null;
				}

				// Token: 0x06006E1B RID: 28187 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006E1C RID: 28188 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected void method_3()
				{
					throw null;
				}

				// Token: 0x06006E1D RID: 28189 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanRemove()
				{
					throw null;
				}

				// Token: 0x06006E1E RID: 28190 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void PutGrenadeBack()
				{
					throw null;
				}

				// Token: 0x06006E1F RID: 28191 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x040076AB RID: 30379
				protected Player.GrenadeController.Class1024.EThrowState ethrowState_0;

				// Token: 0x040076AC RID: 30380
				private Action action_0;

				// Token: 0x02001421 RID: 5153
				protected enum EThrowState
				{
					// Token: 0x040076AE RID: 30382
					None,
					// Token: 0x040076AF RID: 30383
					Idling,
					// Token: 0x040076B0 RID: 30384
					Throwing,
					// Token: 0x040076B1 RID: 30385
					Threw
				}
			}

			// Token: 0x02001422 RID: 5154
			protected class Class1026 : Player.GrenadeController.Class1021
			{
				// Token: 0x06006E20 RID: 28192 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public new void Start()
				{
					throw null;
				}

				// Token: 0x06006E21 RID: 28193 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideGrenade(Action onHidden, bool fastHide)
				{
					throw null;
				}

				// Token: 0x06006E22 RID: 28194 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanRemove()
				{
					throw null;
				}

				// Token: 0x06006E23 RID: 28195 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnEnd()
				{
					throw null;
				}

				// Token: 0x06006E24 RID: 28196 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x06006E25 RID: 28197 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void PullRingForHighThrow()
				{
					throw null;
				}

				// Token: 0x06006E26 RID: 28198 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void PullRingForLowThrow()
				{
					throw null;
				}

				// Token: 0x06006E27 RID: 28199 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void LowThrow()
				{
					throw null;
				}

				// Token: 0x06006E28 RID: 28200 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HighThrow()
				{
					throw null;
				}

				// Token: 0x06006E29 RID: 28201 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetGrenadeCompassState(bool active)
				{
					throw null;
				}

				// Token: 0x06006E2A RID: 28202 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Execute(GInterface336 operation, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006E2B RID: 28203 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006E2C RID: 28204 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ShowGesture(EGesture gesture)
				{
					throw null;
				}
			}

			// Token: 0x02001423 RID: 5155
			protected class Class1025 : Player.GrenadeController.Class1024
			{
				// Token: 0x17001140 RID: 4416
				// (get) Token: 0x06006E2D RID: 28205 RVA: 0x00002050 File Offset: 0x00000250
				public override bool WaitingHighThrow
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x17001141 RID: 4417
				// (get) Token: 0x06006E2E RID: 28206 RVA: 0x00002050 File Offset: 0x00000250
				public bool WaitingLowThrow
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06006E2F RID: 28207 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void vmethod_0()
				{
					throw null;
				}

				// Token: 0x06006E30 RID: 28208 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HighThrow()
				{
					throw null;
				}

				// Token: 0x06006E31 RID: 28209 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void LowThrow()
				{
					throw null;
				}

				// Token: 0x06006E32 RID: 28210 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnDropGrenadeAction()
				{
					throw null;
				}
			}

			// Token: 0x02001424 RID: 5156
			protected class Class1027 : Player.GrenadeController.Class1021
			{
				// Token: 0x06006E33 RID: 28211 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Action callback)
				{
					throw null;
				}

				// Token: 0x06006E34 RID: 28212 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006E35 RID: 28213 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnHideCompleteActionAction()
				{
					throw null;
				}

				// Token: 0x06006E36 RID: 28214 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideGrenade(Action onHidden, bool fastHide)
				{
					throw null;
				}

				// Token: 0x06006E37 RID: 28215 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x040076B2 RID: 30386
				private Action action_0;
			}

			// Token: 0x02001425 RID: 5157
			public sealed class Class1023 : Player.GrenadeController.Class1022
			{
				// Token: 0x06006E38 RID: 28216 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006E39 RID: 28217 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006E3A RID: 28218 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x040076B3 RID: 30387
				private const float float_0 = 0.25f;

				// Token: 0x040076B4 RID: 30388
				private float float_1;

				// Token: 0x040076B5 RID: 30389
				private bool bool_0;
			}

			// Token: 0x02001426 RID: 5158
			private class Class1028 : Player.GrenadeController.Class1021
			{
				// Token: 0x06006E3B RID: 28219 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Action callback)
				{
					throw null;
				}

				// Token: 0x06006E3C RID: 28220 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006E3D RID: 28221 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnDrawCompleteAction()
				{
					throw null;
				}

				// Token: 0x06006E3E RID: 28222 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006E3F RID: 28223 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideGrenade(Action onHidden, bool fastHide)
				{
					throw null;
				}

				// Token: 0x06006E40 RID: 28224 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006E41 RID: 28225 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x040076B6 RID: 30390
				private Action action_0;

				// Token: 0x040076B7 RID: 30391
				private Action action_1;
			}
		}

		// Token: 0x02001427 RID: 5159
		internal abstract class Class1020<T> : Player.GClass1580, Player.GInterface120 where T : Player.BaseGrenadeController
		{
			// Token: 0x06006E42 RID: 28226 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnDrawCompleteAction()
			{
				throw null;
			}

			// Token: 0x06006E43 RID: 28227 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnHideCompleteActionAction()
			{
				throw null;
			}

			// Token: 0x06006E44 RID: 28228 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnDropGrenadeAction()
			{
				throw null;
			}

			// Token: 0x06006E45 RID: 28229 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnDropFinishedAction()
			{
				throw null;
			}

			// Token: 0x06006E46 RID: 28230 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void StartCountdown()
			{
				throw null;
			}

			// Token: 0x06006E47 RID: 28231 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void HideGrenade(Action onHidden, bool fastHide)
			{
				throw null;
			}

			// Token: 0x06006E48 RID: 28232 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void PutGrenadeBack()
			{
				throw null;
			}

			// Token: 0x06006E49 RID: 28233 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ShowGesture(EGesture gesture)
			{
				throw null;
			}

			// Token: 0x06006E4A RID: 28234 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool CanRemove()
			{
				throw null;
			}

			// Token: 0x06006E4B RID: 28235 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void FastForward()
			{
				throw null;
			}

			// Token: 0x06006E4C RID: 28236 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnBackpackDrop()
			{
				throw null;
			}

			// Token: 0x06006E4D RID: 28237 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void Execute(GInterface336 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x040076B8 RID: 30392
			protected readonly T gparam_0;
		}

		// Token: 0x02001428 RID: 5160
		internal class QuickGrenadeThrowController : Player.BaseGrenadeController, GInterface132<GrenadeClass>, GInterface123, GInterface131, IGrenadeController
		{
			// Token: 0x06006E4E RID: 28238 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_8<T>(Player player, GrenadeClass item) where T : Player.QuickGrenadeThrowController
			{
				throw null;
			}

			// Token: 0x06006E4F RID: 28239 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Task<T> smethod_9<T>(Player player, GrenadeClass item) where T : Player.QuickGrenadeThrowController
			{
				throw null;
			}

			// Token: 0x17001142 RID: 4418
			// (get) Token: 0x06006E50 RID: 28240 RVA: 0x00002050 File Offset: 0x00000250
			protected Player.QuickGrenadeThrowController.Class1029 Class1029_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006E51 RID: 28241 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetOnUsedCallback(Callback<GInterface132<GrenadeClass>> callback)
			{
				throw null;
			}

			// Token: 0x06006E52 RID: 28242 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Spawn(float animationSpeed, Action callback)
			{
				throw null;
			}

			// Token: 0x06006E53 RID: 28243 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanExecute(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06006E54 RID: 28244 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanRemove()
			{
				throw null;
			}

			// Token: 0x06006E55 RID: 28245 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_10()
			{
				throw null;
			}

			// Token: 0x02001429 RID: 5161
			public class Class1029 : Player.Class1020<Player.QuickGrenadeThrowController>
			{
				// Token: 0x06006E56 RID: 28246 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Action callback)
				{
					throw null;
				}

				// Token: 0x06006E57 RID: 28247 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void SetOnUsedCallback(Callback<GInterface132<GrenadeClass>> callback)
				{
					throw null;
				}

				// Token: 0x06006E58 RID: 28248 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnDropGrenadeAction()
				{
					throw null;
				}

				// Token: 0x06006E59 RID: 28249 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnDropFinishedAction()
				{
					throw null;
				}

				// Token: 0x06006E5A RID: 28250 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnDrawCompleteAction()
				{
					throw null;
				}

				// Token: 0x06006E5B RID: 28251 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideGrenade(Action onHidden, bool fastHide = false)
				{
					throw null;
				}

				// Token: 0x06006E5C RID: 28252 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void StartCountdown()
				{
					throw null;
				}

				// Token: 0x06006E5D RID: 28253 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006E5E RID: 28254 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006E5F RID: 28255 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006E60 RID: 28256 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x040076B9 RID: 30393
				private Action action_0;

				// Token: 0x040076BA RID: 30394
				private Action action_1;

				// Token: 0x040076BB RID: 30395
				private Callback<GInterface132<GrenadeClass>> callback_0;

				// Token: 0x040076BC RID: 30396
				private bool bool_0;

				// Token: 0x040076BD RID: 30397
				private bool bool_1;

				// Token: 0x040076BE RID: 30398
				private float float_0;
			}

			// Token: 0x0200142A RID: 5162
			[CompilerGenerated]
			private sealed class Class998
			{
				// Token: 0x06006E61 RID: 28257 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x040076BF RID: 30399
				public Action callback;
			}
		}

		// Token: 0x0200142B RID: 5163
		private interface Interface5
		{
			// Token: 0x06006E62 RID: 28258
			void OnDrawCompleteAction();

			// Token: 0x06006E63 RID: 28259
			void OnHideCompleteActionAction();

			// Token: 0x06006E64 RID: 28260
			void OnUseAction();

			// Token: 0x06006E65 RID: 28261
			void HideController(Action onHidden, bool fastHide);
		}

		// Token: 0x0200142C RID: 5164
		public class QuickUseItemController : Player.ItemHandsController, GInterface123, GInterface135
		{
			// Token: 0x17001143 RID: 4419
			// (get) Token: 0x06006E66 RID: 28262 RVA: 0x00002050 File Offset: 0x00000250
			public override FirearmsAnimator FirearmsAnimator
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001144 RID: 4420
			// (get) Token: 0x06006E67 RID: 28263 RVA: 0x00002050 File Offset: 0x00000250
			public override string LoggerDistinctId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006E68 RID: 28264 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_5<T>(Player player, Item item) where T : Player.QuickUseItemController
			{
				throw null;
			}

			// Token: 0x06006E69 RID: 28265 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapIn()
			{
				throw null;
			}

			// Token: 0x06006E6A RID: 28266 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapOut()
			{
				throw null;
			}

			// Token: 0x06006E6B RID: 28267 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnFiringBullet()
			{
				throw null;
			}

			// Token: 0x06006E6C RID: 28268 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnThirdAction(int i)
			{
				throw null;
			}

			// Token: 0x17001145 RID: 4421
			// (get) Token: 0x06006E6D RID: 28269 RVA: 0x00002050 File Offset: 0x00000250
			protected Player.QuickUseItemController.GClass1626 CurrentOperation
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006E6E RID: 28270 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Spawn(float animationSpeed, Action callback)
			{
				throw null;
			}

			// Token: 0x06006E6F RID: 28271 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null)
			{
				throw null;
			}

			// Token: 0x06006E70 RID: 28272 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Destroy()
			{
				throw null;
			}

			// Token: 0x06006E71 RID: 28273 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanExecute(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06006E72 RID: 28274 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Execute(GInterface336 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006E73 RID: 28275 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanRemove()
			{
				throw null;
			}

			// Token: 0x06006E74 RID: 28276 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanInteract()
			{
				throw null;
			}

			// Token: 0x06006E75 RID: 28277 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Interact(bool isInteracting, int actionIndex)
			{
				throw null;
			}

			// Token: 0x06006E76 RID: 28278 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetOnUsedCallback(Callback<GInterface135> callback)
			{
				throw null;
			}

			// Token: 0x06006E77 RID: 28279 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Callback<GInterface135> GetOnUsedCallback()
			{
				throw null;
			}

			// Token: 0x06006E78 RID: 28280 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0()
			{
				throw null;
			}

			// Token: 0x06006E79 RID: 28281 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_1()
			{
				throw null;
			}

			// Token: 0x06006E7A RID: 28282 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_2()
			{
				throw null;
			}

			// Token: 0x06006E7B RID: 28283 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_3()
			{
				throw null;
			}

			// Token: 0x06006E7C RID: 28284 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ShowGesture(EGesture gesture)
			{
				throw null;
			}

			// Token: 0x06006E7D RID: 28285 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void FastForwardCurrentState()
			{
				throw null;
			}

			// Token: 0x06006E7E RID: 28286 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_4()
			{
				throw null;
			}

			// Token: 0x040076C0 RID: 30400
			protected GameObject _usableItemGameObject;

			// Token: 0x040076C1 RID: 30401
			protected new FirearmsAnimator _objectInHandsAnimator;

			// Token: 0x0200142D RID: 5165
			public abstract class GClass1625 : Player.GClass1580, Player.Interface5
			{
				// Token: 0x06006E7F RID: 28287 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnDrawCompleteAction()
				{
					throw null;
				}

				// Token: 0x06006E80 RID: 28288 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnHideCompleteActionAction()
				{
					throw null;
				}

				// Token: 0x06006E81 RID: 28289 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnUseAction()
				{
					throw null;
				}

				// Token: 0x06006E82 RID: 28290 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void HideController(Action onHidden, bool fastHide)
				{
					throw null;
				}

				// Token: 0x040076C2 RID: 30402
				protected readonly Player.QuickUseItemController quickUseItemController_0;
			}

			// Token: 0x0200142E RID: 5166
			public class GClass1626 : Player.QuickUseItemController.GClass1625
			{
				// Token: 0x06006E83 RID: 28291 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Action callback)
				{
					throw null;
				}

				// Token: 0x06006E84 RID: 28292 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void SetOnUsedCallback(Callback<GInterface135> callback)
				{
					throw null;
				}

				// Token: 0x06006E85 RID: 28293 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Callback<GInterface135> GetOnUsedCallback()
				{
					throw null;
				}

				// Token: 0x06006E86 RID: 28294 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnUseAction()
				{
					throw null;
				}

				// Token: 0x06006E87 RID: 28295 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnDrawCompleteAction()
				{
					throw null;
				}

				// Token: 0x06006E88 RID: 28296 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006E89 RID: 28297 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void FastForward()
				{
					throw null;
				}

				// Token: 0x040076C3 RID: 30403
				private Action action_0;

				// Token: 0x040076C4 RID: 30404
				private Action action_1;

				// Token: 0x040076C5 RID: 30405
				private Callback<GInterface135> callback_0;
			}

			// Token: 0x0200142F RID: 5167
			[CompilerGenerated]
			private sealed class Class999<T> where T : Player.QuickUseItemController
			{
				// Token: 0x06006E8A RID: 28298 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x040076C6 RID: 30406
				public T controller;
			}

			// Token: 0x02001430 RID: 5168
			[CompilerGenerated]
			private sealed class Class1000
			{
				// Token: 0x06006E8B RID: 28299 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x040076C7 RID: 30407
				public Action callback;
			}

			// Token: 0x02001431 RID: 5169
			[CompilerGenerated]
			private sealed class Class1001
			{
				// Token: 0x06006E8C RID: 28300 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x040076C8 RID: 30408
				public Action callback;
			}
		}

		// Token: 0x02001432 RID: 5170
		public enum EOperationState
		{
			// Token: 0x040076CA RID: 30410
			Ready,
			// Token: 0x040076CB RID: 30411
			Executing,
			// Token: 0x040076CC RID: 30412
			Finished
		}

		// Token: 0x02001433 RID: 5171
		public abstract class ItemHandsController : Player.AbstractHandsController, GInterface123
		{
			// Token: 0x17001146 RID: 4422
			// (get) Token: 0x06006E8D RID: 28301 RVA: 0x00002050 File Offset: 0x00000250
			public override FirearmsAnimator FirearmsAnimator
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001147 RID: 4423
			// (get) Token: 0x06006E8E RID: 28302 RVA: 0x00002050 File Offset: 0x00000250
			public bool SuitableForHandInput
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001148 RID: 4424
			// (get) Token: 0x06006E8F RID: 28303 RVA: 0x00002050 File Offset: 0x00000250
			public bool CurrentCompassState
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001149 RID: 4425
			// (get) Token: 0x06006E90 RID: 28304 RVA: 0x00002050 File Offset: 0x00000250
			public bool CurrentRadioTransmitterState
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700114A RID: 4426
			// (get) Token: 0x06006E91 RID: 28305 RVA: 0x00002050 File Offset: 0x00000250
			public override GameObject ControllerGameObject
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700114B RID: 4427
			// (get) Token: 0x06006E92 RID: 28306 RVA: 0x00002050 File Offset: 0x00000250
			public override float AimingSensitivity
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700114C RID: 4428
			// (get) Token: 0x06006E93 RID: 28307 RVA: 0x00002050 File Offset: 0x00000250
			public override TransformLinks HandsHierarchy
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700114D RID: 4429
			// (get) Token: 0x06006E94 RID: 28308 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06006E95 RID: 28309 RVA: 0x00002050 File Offset: 0x00000250
			public Player.GClass1580 CurrentHandsOperation
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

			// Token: 0x1700114E RID: 4430
			// (get) Token: 0x06006E96 RID: 28310 RVA: 0x00002050 File Offset: 0x00000250
			public string CurrentHandsOperationName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700114F RID: 4431
			// (get) Token: 0x06006E97 RID: 28311 RVA: 0x00002050 File Offset: 0x00000250
			Item GInterface123.Item
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006E98 RID: 28312 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void BlindFire(int b)
			{
				throw null;
			}

			// Token: 0x06006E99 RID: 28313 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Item GetItem()
			{
				throw null;
			}

			// Token: 0x06006E9A RID: 28314 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_0<T>(Player player, Item item) where T : Player.ItemHandsController
			{
				throw null;
			}

			// Token: 0x06006E9B RID: 28315 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_1<T>(Player player, Item item, Player.ItemHandsController.Delegate8 itemObjectFactoryDelegate) where T : Player.ItemHandsController
			{
				throw null;
			}

			// Token: 0x06006E9C RID: 28316 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Task<T> smethod_2<T>(Player player, Item item) where T : Player.ItemHandsController
			{
				throw null;
			}

			// Token: 0x06006E9D RID: 28317 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Task<T> smethod_3<T>(Player player, Item item, Player.ItemHandsController.Delegate9 itemObjectAsyncFactoryDelegate) where T : Player.ItemHandsController
			{
				throw null;
			}

			// Token: 0x06006E9E RID: 28318 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static void smethod_4<T>(T controller, Player player, Item item) where T : Player.ItemHandsController
			{
				throw null;
			}

			// Token: 0x06006E9F RID: 28319 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void TranslateAnimatorParameter(int actionIndex)
			{
				throw null;
			}

			// Token: 0x06006EA0 RID: 28320 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsPlacingBeacon()
			{
				throw null;
			}

			// Token: 0x06006EA1 RID: 28321 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void SetupProp()
			{
				throw null;
			}

			// Token: 0x06006EA2 RID: 28322 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void OnCanUsePropChanged(bool canUse)
			{
				throw null;
			}

			// Token: 0x06006EA3 RID: 28323 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void SetPropVisibility(bool isVisible)
			{
				throw null;
			}

			// Token: 0x06006EA4 RID: 28324 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ManualUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x06006EA5 RID: 28325 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ToggleCompassState()
			{
				throw null;
			}

			// Token: 0x06006EA6 RID: 28326 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetCompassState(bool active)
			{
				throw null;
			}

			// Token: 0x06006EA7 RID: 28327 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ApplyCompassPacket(GStruct313 packet)
			{
				throw null;
			}

			// Token: 0x06006EA8 RID: 28328 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual bool CanChangeCompassState(bool newState)
			{
				throw null;
			}

			// Token: 0x06006EA9 RID: 28329 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void CompassStateHandler(bool isActive)
			{
				throw null;
			}

			// Token: 0x06006EAA RID: 28330 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void BallisticUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x06006EAB RID: 28331 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void EmitEvents()
			{
				throw null;
			}

			// Token: 0x06006EAC RID: 28332 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected internal void ClearPreWarmOperationsDict()
			{
				throw null;
			}

			// Token: 0x06006EAD RID: 28333 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected internal TCreateOperation InitiateOperation<TCreateOperation>() where TCreateOperation : Player.GClass1580
			{
				throw null;
			}

			// Token: 0x06006EAE RID: 28334 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x040076CD RID: 30413
			protected FirearmsAnimator _objectInHandsAnimator;

			// Token: 0x040076CE RID: 30414
			private readonly Dictionary<Type, Player.GClass1580> dictionary_0;

			// Token: 0x040076CF RID: 30415
			protected GameObject _controllerObject;

			// Token: 0x040076D0 RID: 30416
			protected TransformLinks _handsHierarchy;

			// Token: 0x040076D1 RID: 30417
			private Item item_0;

			// Token: 0x040076D2 RID: 30418
			private Dictionary<Type, Player.ItemHandsController.OperationFactoryDelegate> dictionary_1;

			// Token: 0x040076D3 RID: 30419
			protected internal Player _player;

			// Token: 0x040076D4 RID: 30420
			protected BindableState<bool> CompassState;

			// Token: 0x040076D5 RID: 30421
			protected BindableState<bool> RadioTransmitterState;

			// Token: 0x040076D6 RID: 30422
			protected Player.ItemHandsController.HandsControllerLogger Logger;

			// Token: 0x040076D7 RID: 30423
			[CompilerGenerated]
			private Player.GClass1580 gclass1580_0;

			// Token: 0x02001434 RID: 5172
			// (Invoke) Token: 0x06006EAF RID: 28335
			internal delegate GameObject Delegate8(Item item, Player player);

			// Token: 0x02001435 RID: 5173
			// (Invoke) Token: 0x06006EB2 RID: 28338
			internal delegate Task<GameObject> Delegate9(Item item, Player player);

			// Token: 0x02001436 RID: 5174
			// (Invoke) Token: 0x06006EB5 RID: 28341
			protected delegate Player.GClass1580 OperationFactoryDelegate();

			// Token: 0x02001437 RID: 5175
			protected class HandsControllerLogger : LoggerClass
			{
				// Token: 0x06006EB8 RID: 28344 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void TraceStateChange(Player.GClass1580 currentOperation, Player.GClass1580 nextOperation)
				{
					throw null;
				}

				// Token: 0x06006EB9 RID: 28345 RVA: 0x00002050 File Offset: 0x00000250
				[Conditional("UNITY_EDITOR")]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void TraceMethodCall()
				{
					throw null;
				}

				// Token: 0x06006EBA RID: 28346 RVA: 0x00002050 File Offset: 0x00000250
				[Conditional("UNITY_EDITOR")]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void TraceMethodCall<T>(string argName, T argument1)
				{
					throw null;
				}

				// Token: 0x040076D8 RID: 30424
				private readonly string string_0;
			}

			// Token: 0x02001438 RID: 5176
			[CompilerGenerated]
			[Serializable]
			private sealed class Class1002<T> where T : Player.ItemHandsController
			{
				// Token: 0x06006EBB RID: 28347 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal GameObject method_0(Item item1, Player player1)
				{
					throw null;
				}

				// Token: 0x040076D9 RID: 30425
				public static readonly Player.ItemHandsController.Class1002<T> class1002_0;

				// Token: 0x040076DA RID: 30426
				public static Player.ItemHandsController.Delegate8 delegate8_0;
			}

			// Token: 0x02001439 RID: 5177
			[CompilerGenerated]
			[Serializable]
			private sealed class Class1003<T> where T : Player.ItemHandsController
			{
				// Token: 0x06006EBC RID: 28348 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Task<GameObject> method_0(Item item1, Player player1)
				{
					throw null;
				}

				// Token: 0x040076DB RID: 30427
				public static readonly Player.ItemHandsController.Class1003<T> class1003_0;

				// Token: 0x040076DC RID: 30428
				public static Player.ItemHandsController.Delegate9 delegate9_0;
			}
		}

		// Token: 0x0200143B RID: 5179
		internal abstract class BaseKnifeController : Player.ItemHandsController
		{
			// Token: 0x17001150 RID: 4432
			// (get) Token: 0x06006EBF RID: 28351 RVA: 0x00002050 File Offset: 0x00000250
			public KnifeComponent Knife
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001151 RID: 4433
			// (get) Token: 0x06006EC0 RID: 28352 RVA: 0x00002050 File Offset: 0x00000250
			public override string LoggerDistinctId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006EC1 RID: 28353 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected Task method_0()
			{
				throw null;
			}

			// Token: 0x06006EC2 RID: 28354 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override float GetAnimatorFloatParam(int hash)
			{
				throw null;
			}

			// Token: 0x06006EC3 RID: 28355 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool SupportPickup()
			{
				throw null;
			}

			// Token: 0x06006EC4 RID: 28356 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Pickup(bool p)
			{
				throw null;
			}

			// Token: 0x06006EC5 RID: 28357 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Interact(bool isInteracting, int actionIndex)
			{
				throw null;
			}

			// Token: 0x06006EC6 RID: 28358 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Loot(bool p)
			{
				throw null;
			}

			// Token: 0x06006EC7 RID: 28359 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanInteract()
			{
				throw null;
			}

			// Token: 0x06006EC8 RID: 28360 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInInteraction()
			{
				throw null;
			}

			// Token: 0x06006EC9 RID: 28361 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInInteractionStrictCheck()
			{
				throw null;
			}

			// Token: 0x06006ECA RID: 28362 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector3 GetPlayerOrientation()
			{
				throw null;
			}

			// Token: 0x06006ECB RID: 28363 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector3 GetPlayerCastOrigin()
			{
				throw null;
			}

			// Token: 0x06006ECC RID: 28364 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ShowGesture(EGesture gesture)
			{
				throw null;
			}

			// Token: 0x17001152 RID: 4434
			// (get) Token: 0x06006ECD RID: 28365 RVA: 0x00002050 File Offset: 0x00000250
			protected Player.Interface6 Interface6_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001153 RID: 4435
			// (get) Token: 0x06006ECE RID: 28366 RVA: 0x00002050 File Offset: 0x00000250
			public override FirearmsAnimator FirearmsAnimator
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006ECF RID: 28367 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_5<T>(Player player, KnifeComponent knife) where T : Player.BaseKnifeController
			{
				throw null;
			}

			// Token: 0x06006ED0 RID: 28368 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Task<T> smethod_6<T>(Player player, KnifeComponent knife) where T : Player.BaseKnifeController
			{
				throw null;
			}

			// Token: 0x06006ED1 RID: 28369 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static void smethod_7<T>(T controller, Player player) where T : Player.BaseKnifeController
			{
				throw null;
			}

			// Token: 0x06006ED2 RID: 28370 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnOnUseProp(bool boolParam)
			{
				throw null;
			}

			// Token: 0x06006ED3 RID: 28371 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapIn()
			{
				throw null;
			}

			// Token: 0x06006ED4 RID: 28372 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapOut()
			{
				throw null;
			}

			// Token: 0x06006ED5 RID: 28373 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnThirdAction(int intParam)
			{
				throw null;
			}

			// Token: 0x06006ED6 RID: 28374 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnFireEnd()
			{
				throw null;
			}

			// Token: 0x06006ED7 RID: 28375 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnIdleStart()
			{
				throw null;
			}

			// Token: 0x06006ED8 RID: 28376 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnComboPlanning()
			{
				throw null;
			}

			// Token: 0x06006ED9 RID: 28377 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnFiringBullet()
			{
				throw null;
			}

			// Token: 0x06006EDA RID: 28378 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsOnBackpackDrop()
			{
				throw null;
			}

			// Token: 0x06006EDB RID: 28379 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null)
			{
				throw null;
			}

			// Token: 0x06006EDC RID: 28380 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Destroy()
			{
				throw null;
			}

			// Token: 0x06006EDD RID: 28381 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_1()
			{
				throw null;
			}

			// Token: 0x06006EDE RID: 28382 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnFireEnd()
			{
				throw null;
			}

			// Token: 0x06006EDF RID: 28383 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void OnComboPlanning()
			{
				throw null;
			}

			// Token: 0x06006EE0 RID: 28384 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_2()
			{
				throw null;
			}

			// Token: 0x06006EE1 RID: 28385 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_3()
			{
				throw null;
			}

			// Token: 0x06006EE2 RID: 28386 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_4()
			{
				throw null;
			}

			// Token: 0x06006EE3 RID: 28387 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanExecute(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06006EE4 RID: 28388 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Execute(GInterface336 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006EE5 RID: 28389 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void method_5(Player.GStruct134 other)
			{
				throw null;
			}

			// Token: 0x06006EE6 RID: 28390 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetDeflected(bool deflected)
			{
				throw null;
			}

			// Token: 0x06006EE7 RID: 28391 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetMeleeSpeed(float speed)
			{
				throw null;
			}

			// Token: 0x06006EE8 RID: 28392 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_6(out RaycastHit hitInfo, int layerMask)
			{
				throw null;
			}

			// Token: 0x06006EE9 RID: 28393 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual GClass1673 vmethod_0(Player.GStruct134 hit, BallisticCollider ballisticCollider)
			{
				throw null;
			}

			// Token: 0x06006EEA RID: 28394 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void FastForwardCurrentState()
			{
				throw null;
			}

			// Token: 0x06006EEB RID: 28395 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_7()
			{
				throw null;
			}

			// Token: 0x040076E4 RID: 30436
			public Player.EKickType LastKickType;

			// Token: 0x040076E5 RID: 30437
			private float float_0;

			// Token: 0x040076E6 RID: 30438
			protected Vector3 vector3_0;

			// Token: 0x040076E7 RID: 30439
			protected Vector3 vector3_1;

			// Token: 0x040076E8 RID: 30440
			public const float LERP_DIRECTION_T = 0.9f;

			// Token: 0x040076E9 RID: 30441
			private Action action_0;

			// Token: 0x040076EA RID: 30442
			protected bool bool_0;

			// Token: 0x040076EB RID: 30443
			protected int int_0;

			// Token: 0x040076EC RID: 30444
			protected GClass1664 gclass1664_0;

			// Token: 0x040076ED RID: 30445
			protected FirearmsAnimator firearmsAnimator_0;

			// Token: 0x040076EE RID: 30446
			protected Transform transform_0;

			// Token: 0x040076EF RID: 30447
			protected KnifeCollider knifeCollider_0;

			// Token: 0x040076F0 RID: 30448
			private int int_1;

			// Token: 0x040076F1 RID: 30449
			private int int_2;

			// Token: 0x040076F2 RID: 30450
			private int int_3;

			// Token: 0x0200143E RID: 5182
			[CompilerGenerated]
			private sealed class Class1004<T> where T : Player.BaseKnifeController
			{
				// Token: 0x06006EF0 RID: 28400 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal PlayerBones method_0()
				{
					throw null;
				}

				// Token: 0x06006EF1 RID: 28401 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_1()
				{
					throw null;
				}

				// Token: 0x06006EF2 RID: 28402 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_2()
				{
					throw null;
				}

				// Token: 0x040076FC RID: 30460
				public T controller;

				// Token: 0x040076FD RID: 30461
				public KnifeComponent knife;
			}

			// Token: 0x0200143F RID: 5183
			[CompilerGenerated]
			private sealed class Class1005
			{
				// Token: 0x06006EF3 RID: 28403 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x040076FE RID: 30462
				public Player.BaseKnifeController baseKnifeController_0;

				// Token: 0x040076FF RID: 30463
				public Player.Class1059 inventoryOperation;

				// Token: 0x04007700 RID: 30464
				public Action callback;
			}
		}

		// Token: 0x02001440 RID: 5184
		internal interface Interface6
		{
			// Token: 0x06006EF4 RID: 28404
			void HideWeaponComplete();

			// Token: 0x06006EF5 RID: 28405
			void WeaponAppeared();

			// Token: 0x06006EF6 RID: 28406
			void HideWeapon(Action onHidden, bool fastDrop);

			// Token: 0x06006EF7 RID: 28407
			void OnFireEnd();

			// Token: 0x06006EF8 RID: 28408
			void OnFire();

			// Token: 0x06006EF9 RID: 28409
			void OnBackpackDrop();

			// Token: 0x06006EFA RID: 28410
			void Execute<TInventoryOperation>(TInventoryOperation operation, Callback callback) where TInventoryOperation : GInterface336;

			// Token: 0x06006EFB RID: 28411
			void FastForward();

			// Token: 0x06006EFC RID: 28412
			void OnIdleStart();
		}

		// Token: 0x02001441 RID: 5185
		internal abstract class Class1030<T> : Player.GClass1580, Player.Interface6 where T : Player.BaseKnifeController
		{
			// Token: 0x06006EFD RID: 28413 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void HideWeaponComplete()
			{
				throw null;
			}

			// Token: 0x06006EFE RID: 28414 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void WeaponAppeared()
			{
				throw null;
			}

			// Token: 0x06006EFF RID: 28415 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnBackpackDrop()
			{
				throw null;
			}

			// Token: 0x06006F00 RID: 28416 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void Execute<TInventoryOperation>(TInventoryOperation operation, Callback callback) where TInventoryOperation : GInterface336
			{
				throw null;
			}

			// Token: 0x06006F01 RID: 28417 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void HideWeapon(Action onHidden, bool fastDrop)
			{
				throw null;
			}

			// Token: 0x06006F02 RID: 28418 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnFireEnd()
			{
				throw null;
			}

			// Token: 0x06006F03 RID: 28419 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnFire()
			{
				throw null;
			}

			// Token: 0x06006F04 RID: 28420 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void FastForward()
			{
				throw null;
			}

			// Token: 0x06006F05 RID: 28421 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnIdleStart()
			{
				throw null;
			}

			// Token: 0x04007701 RID: 30465
			protected readonly T gparam_0;
		}

		// Token: 0x02001442 RID: 5186
		internal class KnifeController : Player.BaseKnifeController, GInterface123, GInterface124, GInterface126, IKnifeController
		{
			// Token: 0x17001154 RID: 4436
			// (get) Token: 0x06006F06 RID: 28422 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06006F07 RID: 28423 RVA: 0x00002050 File Offset: 0x00000250
			public Action ComboPlanning
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

			// Token: 0x17001155 RID: 4437
			// (get) Token: 0x06006F08 RID: 28424 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06006F09 RID: 28425 RVA: 0x00002050 File Offset: 0x00000250
			public Action OnAttackEnd
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

			// Token: 0x06006F0A RID: 28426 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_8<T>(Player player, KnifeComponent knife) where T : Player.KnifeController
			{
				throw null;
			}

			// Token: 0x06006F0B RID: 28427 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Task<T> smethod_9<T>(Player player, KnifeComponent knife) where T : Player.KnifeController
			{
				throw null;
			}

			// Token: 0x17001156 RID: 4438
			// (get) Token: 0x06006F0C RID: 28428 RVA: 0x00002050 File Offset: 0x00000250
			public new KnifeComponent Knife
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001157 RID: 4439
			// (get) Token: 0x06006F0D RID: 28429 RVA: 0x00002050 File Offset: 0x00000250
			protected Player.KnifeController.Class1031 Class1031_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006F0E RID: 28430 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ExamineWeapon()
			{
				throw null;
			}

			// Token: 0x06006F0F RID: 28431 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool MakeKnifeKick()
			{
				throw null;
			}

			// Token: 0x06006F10 RID: 28432 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnComboPlanning()
			{
				throw null;
			}

			// Token: 0x06006F11 RID: 28433 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void OnFireEnd()
			{
				throw null;
			}

			// Token: 0x06006F12 RID: 28434 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool MakeAlternativeKick()
			{
				throw null;
			}

			// Token: 0x06006F13 RID: 28435 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void BrakeCombo()
			{
				throw null;
			}

			// Token: 0x06006F14 RID: 28436 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ContinueCombo()
			{
				throw null;
			}

			// Token: 0x06006F15 RID: 28437 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetCompassState(bool active)
			{
				throw null;
			}

			// Token: 0x06006F16 RID: 28438 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanRemove()
			{
				throw null;
			}

			// Token: 0x06006F17 RID: 28439 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Spawn(float animationSpeed, Action callback)
			{
				throw null;
			}

			// Token: 0x06006F18 RID: 28440 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetInventoryOpened(bool opened)
			{
				throw null;
			}

			// Token: 0x06006F19 RID: 28441 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInventoryOpen()
			{
				throw null;
			}

			// Token: 0x06006F1A RID: 28442 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanExecute(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06006F1B RID: 28443 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetBotParameters()
			{
				throw null;
			}

			// Token: 0x06006F1C RID: 28444 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_8()
			{
				throw null;
			}

			// Token: 0x06006F1D RID: 28445 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_9()
			{
				throw null;
			}

			// Token: 0x06006F1E RID: 28446 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_10()
			{
				throw null;
			}

			// Token: 0x06006F1F RID: 28447 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_11()
			{
				throw null;
			}

			// Token: 0x06006F20 RID: 28448 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_12()
			{
				throw null;
			}

			// Token: 0x04007702 RID: 30466
			protected bool bool_1;

			// Token: 0x04007703 RID: 30467
			[CompilerGenerated]
			private Action action_1;

			// Token: 0x04007704 RID: 30468
			[CompilerGenerated]
			private Action action_2;

			// Token: 0x02001443 RID: 5187
			public class Class1032 : Player.KnifeController.Class1031
			{
				// Token: 0x06006F21 RID: 28449 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006F22 RID: 28450 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006F23 RID: 28451 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnBackpackDrop()
				{
					throw null;
				}

				// Token: 0x06006F24 RID: 28452 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x04007705 RID: 30469
				private Callback callback_0;
			}

			// Token: 0x02001444 RID: 5188
			public class Class1034 : Player.KnifeController.Class1031
			{
				// Token: 0x06006F25 RID: 28453 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public new void Start()
				{
					throw null;
				}

				// Token: 0x06006F26 RID: 28454 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006F27 RID: 28455 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop)
				{
					throw null;
				}

				// Token: 0x06006F28 RID: 28456 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanRemove()
				{
					throw null;
				}

				// Token: 0x06006F29 RID: 28457 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Execute<TInventoryOperation>(TInventoryOperation operation, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006F2A RID: 28458 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006F2B RID: 28459 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x06006F2C RID: 28460 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006F2D RID: 28461 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool MakeKnifeKick()
				{
					throw null;
				}

				// Token: 0x06006F2E RID: 28462 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnEnd()
				{
					throw null;
				}

				// Token: 0x06006F2F RID: 28463 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetKnifeCompassState(bool active)
				{
					throw null;
				}

				// Token: 0x06006F30 RID: 28464 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool MakeAlternativeKick()
				{
					throw null;
				}

				// Token: 0x06006F31 RID: 28465 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void StopKnifeKick()
				{
					throw null;
				}

				// Token: 0x06006F32 RID: 28466 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void StopAlternativeKick()
				{
					throw null;
				}

				// Token: 0x04007706 RID: 30470
				private const float float_0 = 300f;

				// Token: 0x04007707 RID: 30471
				private float float_1;
			}

			// Token: 0x02001445 RID: 5189
			protected class Class1035 : Player.KnifeController.Class1031
			{
				// Token: 0x06006F33 RID: 28467 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Player.EKickType eKickType)
				{
					throw null;
				}

				// Token: 0x06006F34 RID: 28468 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006F35 RID: 28469 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006F36 RID: 28470 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnComboPlanning()
				{
					throw null;
				}

				// Token: 0x06006F37 RID: 28471 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ContinueCombo()
				{
					throw null;
				}

				// Token: 0x06006F38 RID: 28472 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void BrakeCombo()
				{
					throw null;
				}

				// Token: 0x06006F39 RID: 28473 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnIdleStart()
				{
					throw null;
				}

				// Token: 0x06006F3A RID: 28474 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void StopKnifeKick()
				{
					throw null;
				}

				// Token: 0x06006F3B RID: 28475 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void StopAlternativeKick()
				{
					throw null;
				}

				// Token: 0x06006F3C RID: 28476 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEnd()
				{
					throw null;
				}

				// Token: 0x06006F3D RID: 28477 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFire()
				{
					throw null;
				}

				// Token: 0x06006F3E RID: 28478 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop)
				{
					throw null;
				}

				// Token: 0x06006F3F RID: 28479 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_2()
				{
					throw null;
				}

				// Token: 0x06006F40 RID: 28480 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_3()
				{
					throw null;
				}

				// Token: 0x04007708 RID: 30472
				private Action action_0;

				// Token: 0x04007709 RID: 30473
				private bool bool_0;

				// Token: 0x02001446 RID: 5190
				[CompilerGenerated]
				private sealed class Class1006
				{
					// Token: 0x06006F41 RID: 28481 RVA: 0x00002050 File Offset: 0x00000250
					[MethodImpl(MethodImplOptions.NoInlining)]
					internal void method_0()
					{
						throw null;
					}

					// Token: 0x0400770A RID: 30474
					public Player.KnifeController.Class1035 class1035_0;

					// Token: 0x0400770B RID: 30475
					public Action onHidden;

					// Token: 0x0400770C RID: 30476
					public bool fastDrop;
				}
			}

			// Token: 0x02001447 RID: 5191
			public abstract class Class1031 : Player.Class1030<Player.KnifeController>
			{
				// Token: 0x06006F42 RID: 28482 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x06006F43 RID: 28483 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06006F44 RID: 28484 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool MakeKnifeKick()
				{
					throw null;
				}

				// Token: 0x06006F45 RID: 28485 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnComboPlanning()
				{
					throw null;
				}

				// Token: 0x06006F46 RID: 28486 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void BrakeCombo()
				{
					throw null;
				}

				// Token: 0x06006F47 RID: 28487 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ContinueCombo()
				{
					throw null;
				}

				// Token: 0x06006F48 RID: 28488 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void StopKnifeKick()
				{
					throw null;
				}

				// Token: 0x06006F49 RID: 28489 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool CanRemove()
				{
					throw null;
				}

				// Token: 0x06006F4A RID: 28490 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool MakeAlternativeKick()
				{
					throw null;
				}

				// Token: 0x06006F4B RID: 28491 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void StopAlternativeKick()
				{
					throw null;
				}

				// Token: 0x06006F4C RID: 28492 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetKnifeCompassState(bool active)
				{
					throw null;
				}

				// Token: 0x0400770D RID: 30477
				protected readonly Player player_0;
			}

			// Token: 0x02001448 RID: 5192
			private class Class1036 : Player.KnifeController.Class1031
			{
				// Token: 0x06006F4D RID: 28493 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Action onHidden, bool fastDrop)
				{
					throw null;
				}

				// Token: 0x06006F4E RID: 28494 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006F4F RID: 28495 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeaponComplete()
				{
					throw null;
				}

				// Token: 0x06006F50 RID: 28496 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop)
				{
					throw null;
				}

				// Token: 0x06006F51 RID: 28497 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x0400770E RID: 30478
				private Action action_0;
			}

			// Token: 0x02001449 RID: 5193
			public sealed class Class1033 : Player.KnifeController.Class1032
			{
				// Token: 0x06006F52 RID: 28498 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x06006F53 RID: 28499 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006F54 RID: 28500 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x0400770F RID: 30479
				private const float float_0 = 0.25f;

				// Token: 0x04007710 RID: 30480
				private float float_1;

				// Token: 0x04007711 RID: 30481
				private bool bool_0;
			}

			// Token: 0x0200144A RID: 5194
			public class Class1037 : Player.KnifeController.Class1031
			{
				// Token: 0x06006F55 RID: 28501 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Action callback)
				{
					throw null;
				}

				// Token: 0x06006F56 RID: 28502 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006F57 RID: 28503 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void WeaponAppeared()
				{
					throw null;
				}

				// Token: 0x06006F58 RID: 28504 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop)
				{
					throw null;
				}

				// Token: 0x06006F59 RID: 28505 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06006F5A RID: 28506 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x04007712 RID: 30482
				private Action action_0;

				// Token: 0x04007713 RID: 30483
				private Action action_1;

				// Token: 0x04007714 RID: 30484
				private bool bool_0;
			}
		}

		// Token: 0x0200144B RID: 5195
		public enum EKickType : byte
		{
			// Token: 0x04007716 RID: 30486
			Slash,
			// Token: 0x04007717 RID: 30487
			Stab
		}

		// Token: 0x0200144C RID: 5196
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct134
		{
			// Token: 0x04007718 RID: 30488
			public Collider collider;

			// Token: 0x04007719 RID: 30489
			public Vector3 point;

			// Token: 0x0400771A RID: 30490
			public Vector3 normal;
		}

		// Token: 0x0200144D RID: 5197
		internal class QuickKnifeKickController : Player.BaseKnifeController, GInterface132<KnifeClass>, GInterface123, GInterface131, GInterface134
		{
			// Token: 0x17001158 RID: 4440
			// (get) Token: 0x06006F5B RID: 28507 RVA: 0x00002050 File Offset: 0x00000250
			public new KnifeClass Item
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006F5C RID: 28508 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_8<T>(Player player, KnifeComponent knife) where T : Player.QuickKnifeKickController
			{
				throw null;
			}

			// Token: 0x06006F5D RID: 28509 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Task<T> smethod_9<T>(Player player, KnifeComponent knife) where T : Player.QuickKnifeKickController
			{
				throw null;
			}

			// Token: 0x17001159 RID: 4441
			// (get) Token: 0x06006F5E RID: 28510 RVA: 0x00002050 File Offset: 0x00000250
			protected Player.QuickKnifeKickController.Class1038 Class1038_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006F5F RID: 28511 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetOnUsedCallback(Callback<GInterface132<KnifeClass>> callback)
			{
				throw null;
			}

			// Token: 0x06006F60 RID: 28512 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Spawn(float animationSpeed, Action callback)
			{
				throw null;
			}

			// Token: 0x06006F61 RID: 28513 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanExecute(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06006F62 RID: 28514 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanRemove()
			{
				throw null;
			}

			// Token: 0x06006F63 RID: 28515 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_8()
			{
				throw null;
			}

			// Token: 0x0200144E RID: 5198
			public class Class1038 : Player.Class1030<Player.QuickKnifeKickController>
			{
				// Token: 0x06006F64 RID: 28516 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Action callback)
				{
					throw null;
				}

				// Token: 0x06006F65 RID: 28517 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void WeaponAppeared()
				{
					throw null;
				}

				// Token: 0x06006F66 RID: 28518 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastHide)
				{
					throw null;
				}

				// Token: 0x06006F67 RID: 28519 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void SetOnUsedCallback(Callback<GInterface132<KnifeClass>> callback)
				{
					throw null;
				}

				// Token: 0x06006F68 RID: 28520 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFireEnd()
				{
					throw null;
				}

				// Token: 0x06006F69 RID: 28521 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnFire()
				{
					throw null;
				}

				// Token: 0x06006F6A RID: 28522 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06006F6B RID: 28523 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x0400771B RID: 30491
				private Action action_0;

				// Token: 0x0400771C RID: 30492
				private Action action_1;

				// Token: 0x0400771D RID: 30493
				private Callback<GInterface132<KnifeClass>> callback_0;

				// Token: 0x0400771E RID: 30494
				private bool bool_0;
			}
		}

		// Token: 0x0200144F RID: 5199
		internal class MedsController : Player.ItemHandsController, GInterface123, GInterface130, GInterface135
		{
			// Token: 0x1700115A RID: 4442
			// (get) Token: 0x06006F6C RID: 28524 RVA: 0x00002050 File Offset: 0x00000250
			public override int AnimationVariant
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700115B RID: 4443
			// (get) Token: 0x06006F6D RID: 28525 RVA: 0x00002050 File Offset: 0x00000250
			private Player.MedsController.Class1039 Class1039_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700115C RID: 4444
			// (get) Token: 0x06006F6E RID: 28526 RVA: 0x00002050 File Offset: 0x00000250
			public override FirearmsAnimator FirearmsAnimator
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700115D RID: 4445
			// (get) Token: 0x06006F6F RID: 28527 RVA: 0x00002050 File Offset: 0x00000250
			public override string LoggerDistinctId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700115E RID: 4446
			// (get) Token: 0x06006F70 RID: 28528 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06006F71 RID: 28529 RVA: 0x00002050 File Offset: 0x00000250
			public bool FailedToApply
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

			// Token: 0x06006F72 RID: 28530 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ShowGesture(EGesture gesture)
			{
				throw null;
			}

			// Token: 0x06006F73 RID: 28531 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Destroy()
			{
				throw null;
			}

			// Token: 0x06006F74 RID: 28532 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetOnUsedCallback(Callback<GInterface135> callback)
			{
				throw null;
			}

			// Token: 0x06006F75 RID: 28533 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Callback<GInterface135> GetOnUsedCallback()
			{
				throw null;
			}

			// Token: 0x06006F76 RID: 28534 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Remove()
			{
				throw null;
			}

			// Token: 0x06006F77 RID: 28535 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanExecute(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06006F78 RID: 28536 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Execute(GInterface336 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x06006F79 RID: 28537 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Pickup(bool p)
			{
				throw null;
			}

			// Token: 0x06006F7A RID: 28538 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Loot(bool p)
			{
				throw null;
			}

			// Token: 0x06006F7B RID: 28539 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Interact(bool isInteracting, int actionIndex)
			{
				throw null;
			}

			// Token: 0x06006F7C RID: 28540 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanInteract()
			{
				throw null;
			}

			// Token: 0x06006F7D RID: 28541 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanRemove()
			{
				throw null;
			}

			// Token: 0x06006F7E RID: 28542 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_5<T>(Player player, Item item, EBodyPart bodyPart, float amount, int animationVariant) where T : Player.MedsController
			{
				throw null;
			}

			// Token: 0x06006F7F RID: 28543 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Task<T> smethod_6<T>(Player player, Item item, EBodyPart bodyPart, float amount, int animationVariant) where T : Player.MedsController
			{
				throw null;
			}

			// Token: 0x06006F80 RID: 28544 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static void smethod_7<T>(T controller, Player player, Item item, int animationVariant) where T : Player.MedsController
			{
				throw null;
			}

			// Token: 0x06006F81 RID: 28545 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ManualUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x06006F82 RID: 28546 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapOut()
			{
				throw null;
			}

			// Token: 0x06006F83 RID: 28547 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnThirdAction(int IntParam)
			{
				throw null;
			}

			// Token: 0x06006F84 RID: 28548 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Spawn(float animationSpeed, Action callback)
			{
				throw null;
			}

			// Token: 0x06006F85 RID: 28549 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Drop(float animationSpeed, Action callback, bool fastDrop = false, Item nextControllerItem = null)
			{
				throw null;
			}

			// Token: 0x06006F86 RID: 28550 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void FastForwardCurrentState()
			{
				throw null;
			}

			// Token: 0x06006F87 RID: 28551 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_0()
			{
				throw null;
			}

			// Token: 0x0400771F RID: 30495
			private float float_0;

			// Token: 0x04007720 RID: 30496
			private int int_0;

			// Token: 0x04007721 RID: 30497
			private EBodyPart ebodyPart_0;

			// Token: 0x04007722 RID: 30498
			private FirearmsAnimator firearmsAnimator_0;

			// Token: 0x04007723 RID: 30499
			[CompilerGenerated]
			private bool bool_0;

			// Token: 0x02001450 RID: 5200
			private sealed class Class1039 : Player.GClass1580
			{
				// Token: 0x06006F88 RID: 28552 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06006F89 RID: 28553 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(EBodyPart bodyPart, float amount, Action callback)
				{
					throw null;
				}

				// Token: 0x06006F8A RID: 28554 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void SetOnUsedCallback(Callback<GInterface135> callback)
				{
					throw null;
				}

				// Token: 0x06006F8B RID: 28555 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Callback<GInterface135> GetOnUsedCallback()
				{
					throw null;
				}

				// Token: 0x06006F8C RID: 28556 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Remove()
				{
					throw null;
				}

				// Token: 0x06006F8D RID: 28557 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_2(IEffect effect)
				{
					throw null;
				}

				// Token: 0x06006F8E RID: 28558 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void HideWeapon(Action onHiddenCallback)
				{
					throw null;
				}

				// Token: 0x06006F8F RID: 28559 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void HideWeaponComplete()
				{
					throw null;
				}

				// Token: 0x06006F90 RID: 28560 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void FastForward()
				{
					throw null;
				}

				// Token: 0x06006F91 RID: 28561 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x04007724 RID: 30500
				private readonly Player.MedsController medsController_0;

				// Token: 0x04007725 RID: 30501
				private Action action_0;

				// Token: 0x04007726 RID: 30502
				private Callback<GInterface135> callback_0;
			}

			// Token: 0x02001452 RID: 5202
			[CompilerGenerated]
			private sealed class Class1007<T> where T : Player.MedsController
			{
				// Token: 0x06006F94 RID: 28564 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x0400772F RID: 30511
				public T controller;
			}
		}

		// Token: 0x02001453 RID: 5203
		public abstract class AbstractHandsController : MonoBehaviour, GInterface24, GInterface123
		{
			// Token: 0x14000139 RID: 313
			// (add) Token: 0x06006F95 RID: 28565 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06006F96 RID: 28566 RVA: 0x00002050 File Offset: 0x00000250
			public event Action<bool> OnAimingChanged
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

			// Token: 0x1700115F RID: 4447
			// (get) Token: 0x06006F97 RID: 28567 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06006F98 RID: 28568 RVA: 0x00002050 File Offset: 0x00000250
			public Transform WeaponRoot
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

			// Token: 0x17001160 RID: 4448
			// (get) Token: 0x06006F99 RID: 28569
			public abstract GameObject ControllerGameObject { get; }

			// Token: 0x17001161 RID: 4449
			// (get) Token: 0x06006F9A RID: 28570 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06006F9B RID: 28571 RVA: 0x00002050 File Offset: 0x00000250
			public bool Destroyed
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected set
				{
					throw null;
				}
			}

			// Token: 0x17001162 RID: 4450
			// (get) Token: 0x06006F9C RID: 28572
			public abstract TransformLinks HandsHierarchy { get; }

			// Token: 0x17001163 RID: 4451
			// (get) Token: 0x06006F9D RID: 28573
			public abstract FirearmsAnimator FirearmsAnimator { get; }

			// Token: 0x17001164 RID: 4452
			// (get) Token: 0x06006F9E RID: 28574 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06006F9F RID: 28575 RVA: 0x00002050 File Offset: 0x00000250
			public AnimationEventsEmitter AnimationEventsEmitter
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected set
				{
					throw null;
				}
			}

			// Token: 0x17001165 RID: 4453
			// (get) Token: 0x06006FA0 RID: 28576 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06006FA1 RID: 28577 RVA: 0x00002050 File Offset: 0x00000250
			public virtual bool IsAiming
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected set
				{
					throw null;
				}
			}

			// Token: 0x17001166 RID: 4454
			// (get) Token: 0x06006FA2 RID: 28578 RVA: 0x00002050 File Offset: 0x00000250
			public virtual float AimingSensitivity
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006FA3 RID: 28579 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ManualLateUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x17001167 RID: 4455
			// (get) Token: 0x06006FA4 RID: 28580 RVA: 0x00002050 File Offset: 0x00000250
			public virtual string LoggerDistinctId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001168 RID: 4456
			// (get) Token: 0x06006FA5 RID: 28581 RVA: 0x00002050 File Offset: 0x00000250
			public Item Item
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001169 RID: 4457
			// (get) Token: 0x06006FA6 RID: 28582 RVA: 0x00002050 File Offset: 0x00000250
			public virtual int AnimationVariant
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06006FA7 RID: 28583 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void Destroy()
			{
				throw null;
			}

			// Token: 0x06006FA8 RID: 28584
			public abstract bool CanExecute(GInterface336 operation);

			// Token: 0x06006FA9 RID: 28585
			public abstract void Execute(GInterface336 operation, Callback callback);

			// Token: 0x06006FAA RID: 28586
			public abstract bool CanRemove();

			// Token: 0x06006FAB RID: 28587 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool IsHandsProcessing()
			{
				throw null;
			}

			// Token: 0x06006FAC RID: 28588 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool IsPlacingBeacon()
			{
				throw null;
			}

			// Token: 0x06006FAD RID: 28589 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool CanInteract()
			{
				throw null;
			}

			// Token: 0x06006FAE RID: 28590 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool InCanNotBeInterruptedOperation()
			{
				throw null;
			}

			// Token: 0x06006FAF RID: 28591
			public abstract void ShowGesture(EGesture gesture);

			// Token: 0x06006FB0 RID: 28592
			public abstract void BlindFire(int b);

			// Token: 0x06006FB1 RID: 28593 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool IsInInteraction()
			{
				throw null;
			}

			// Token: 0x06006FB2 RID: 28594 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool IsInInteractionStrictCheck()
			{
				throw null;
			}

			// Token: 0x06006FB3 RID: 28595 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual float GetAnimatorFloatParam(int hash)
			{
				throw null;
			}

			// Token: 0x06006FB4 RID: 28596 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool SupportPickup()
			{
				throw null;
			}

			// Token: 0x06006FB5 RID: 28597 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void Pickup(bool p)
			{
				throw null;
			}

			// Token: 0x06006FB6 RID: 28598 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void Interact(bool isInteracting, int actionIndex)
			{
				throw null;
			}

			// Token: 0x06006FB7 RID: 28599 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void Loot(bool p)
			{
				throw null;
			}

			// Token: 0x06006FB8 RID: 28600 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetInventoryOpened(bool opened)
			{
				throw null;
			}

			// Token: 0x06006FB9 RID: 28601 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool IsInventoryOpen()
			{
				throw null;
			}

			// Token: 0x06006FBA RID: 28602 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnPlayerDead()
			{
				throw null;
			}

			// Token: 0x06006FBB RID: 28603 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnGameSessionEnd()
			{
				throw null;
			}

			// Token: 0x06006FBC RID: 28604
			protected abstract Item GetItem();

			// Token: 0x06006FBD RID: 28605
			public abstract void ManualUpdate(float deltaTime);

			// Token: 0x06006FBE RID: 28606
			public abstract void BallisticUpdate(float deltaTime);

			// Token: 0x06006FBF RID: 28607
			public abstract void EmitEvents();

			// Token: 0x06006FC0 RID: 28608
			public abstract void Spawn(float animationSpeed, Action callback);

			// Token: 0x06006FC1 RID: 28609
			public abstract void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null);

			// Token: 0x06006FC2 RID: 28610 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void FastForwardCurrentState()
			{
				throw null;
			}

			// Token: 0x06006FC3 RID: 28611 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void AimingChanged(bool newValue)
			{
				throw null;
			}

			// Token: 0x06006FC4 RID: 28612 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnAddAmmoInChamber()
			{
				throw null;
			}

			// Token: 0x06006FC5 RID: 28613 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnAddAmmoInChamber()
			{
				throw null;
			}

			// Token: 0x06006FC6 RID: 28614 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnAddAmmoInMag()
			{
				throw null;
			}

			// Token: 0x06006FC7 RID: 28615 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnAddAmmoInMag()
			{
				throw null;
			}

			// Token: 0x06006FC8 RID: 28616 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnArm()
			{
				throw null;
			}

			// Token: 0x06006FC9 RID: 28617 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnArm()
			{
				throw null;
			}

			// Token: 0x06006FCA RID: 28618 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnCook()
			{
				throw null;
			}

			// Token: 0x06006FCB RID: 28619 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnCook()
			{
				throw null;
			}

			// Token: 0x06006FCC RID: 28620 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnDelAmmoChamber()
			{
				throw null;
			}

			// Token: 0x06006FCD RID: 28621 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnDelAmmoChamber()
			{
				throw null;
			}

			// Token: 0x06006FCE RID: 28622 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnDelAmmoFromMag()
			{
				throw null;
			}

			// Token: 0x06006FCF RID: 28623 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnDelAmmoFromMag()
			{
				throw null;
			}

			// Token: 0x06006FD0 RID: 28624 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnDisarm()
			{
				throw null;
			}

			// Token: 0x06006FD1 RID: 28625 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnDisarm()
			{
				throw null;
			}

			// Token: 0x06006FD2 RID: 28626 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnFireEnd()
			{
				throw null;
			}

			// Token: 0x06006FD3 RID: 28627 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnFireEnd()
			{
				throw null;
			}

			// Token: 0x06006FD4 RID: 28628 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnComboPlanning()
			{
				throw null;
			}

			// Token: 0x06006FD5 RID: 28629 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnComboPlanning()
			{
				throw null;
			}

			// Token: 0x06006FD6 RID: 28630 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnFiringBullet()
			{
				throw null;
			}

			// Token: 0x06006FD7 RID: 28631 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnFiringBullet()
			{
				throw null;
			}

			// Token: 0x06006FD8 RID: 28632 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnFoldOff()
			{
				throw null;
			}

			// Token: 0x06006FD9 RID: 28633 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnFoldOff()
			{
				throw null;
			}

			// Token: 0x06006FDA RID: 28634 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnFoldOn()
			{
				throw null;
			}

			// Token: 0x06006FDB RID: 28635 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnFoldOn()
			{
				throw null;
			}

			// Token: 0x06006FDC RID: 28636 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnIdleStart()
			{
				throw null;
			}

			// Token: 0x06006FDD RID: 28637 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnIdleStart()
			{
				throw null;
			}

			// Token: 0x06006FDE RID: 28638 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnLauncherAppeared()
			{
				throw null;
			}

			// Token: 0x06006FDF RID: 28639 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnLauncherAppeared()
			{
				throw null;
			}

			// Token: 0x06006FE0 RID: 28640 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnLauncherDisappeared()
			{
				throw null;
			}

			// Token: 0x06006FE1 RID: 28641 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnLauncherDisappeared()
			{
				throw null;
			}

			// Token: 0x06006FE2 RID: 28642 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnMagHide()
			{
				throw null;
			}

			// Token: 0x06006FE3 RID: 28643 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnMagHide()
			{
				throw null;
			}

			// Token: 0x06006FE4 RID: 28644 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnMagIn()
			{
				throw null;
			}

			// Token: 0x06006FE5 RID: 28645 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnMagIn()
			{
				throw null;
			}

			// Token: 0x06006FE6 RID: 28646 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnMagOut()
			{
				throw null;
			}

			// Token: 0x06006FE7 RID: 28647 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnMagOut()
			{
				throw null;
			}

			// Token: 0x06006FE8 RID: 28648 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnMagShow()
			{
				throw null;
			}

			// Token: 0x06006FE9 RID: 28649 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnMagShow()
			{
				throw null;
			}

			// Token: 0x06006FEA RID: 28650 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnMessageName()
			{
				throw null;
			}

			// Token: 0x06006FEB RID: 28651 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnMessageName()
			{
				throw null;
			}

			// Token: 0x06006FEC RID: 28652 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnMalfunctionOff()
			{
				throw null;
			}

			// Token: 0x06006FED RID: 28653 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnMalfunctionOff()
			{
				throw null;
			}

			// Token: 0x06006FEE RID: 28654 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnModChanged()
			{
				throw null;
			}

			// Token: 0x06006FEF RID: 28655 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnModChanged()
			{
				throw null;
			}

			// Token: 0x06006FF0 RID: 28656 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnOffBoltCatch()
			{
				throw null;
			}

			// Token: 0x06006FF1 RID: 28657 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnOffBoltCatch()
			{
				throw null;
			}

			// Token: 0x06006FF2 RID: 28658 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnOnBoltCatch()
			{
				throw null;
			}

			// Token: 0x06006FF3 RID: 28659 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnOnBoltCatch()
			{
				throw null;
			}

			// Token: 0x06006FF4 RID: 28660 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnPutMagToRig()
			{
				throw null;
			}

			// Token: 0x06006FF5 RID: 28661 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnPutMagToRig()
			{
				throw null;
			}

			// Token: 0x06006FF6 RID: 28662 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnRemoveShell()
			{
				throw null;
			}

			// Token: 0x06006FF7 RID: 28663 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnRemoveShell()
			{
				throw null;
			}

			// Token: 0x06006FF8 RID: 28664 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnReplaceSecondMag()
			{
				throw null;
			}

			// Token: 0x06006FF9 RID: 28665 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnReplaceSecondMag()
			{
				throw null;
			}

			// Token: 0x06006FFA RID: 28666 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnShellEject()
			{
				throw null;
			}

			// Token: 0x06006FFB RID: 28667 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnShellEject()
			{
				throw null;
			}

			// Token: 0x06006FFC RID: 28668 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnShowAmmo(bool BoolParam)
			{
				throw null;
			}

			// Token: 0x06006FFD RID: 28669 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnShowAmmo(bool BoolParam)
			{
				throw null;
			}

			// Token: 0x06006FFE RID: 28670 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnShowMag()
			{
				throw null;
			}

			// Token: 0x06006FFF RID: 28671 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnSliderOut()
			{
				throw null;
			}

			// Token: 0x06007000 RID: 28672 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnShowMag()
			{
				throw null;
			}

			// Token: 0x06007001 RID: 28673 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnSound(string StringParam)
			{
				throw null;
			}

			// Token: 0x06007002 RID: 28674 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnSound(string StringParam)
			{
				throw null;
			}

			// Token: 0x06007003 RID: 28675 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void OnSoundAtPoint(string StringParam)
			{
				throw null;
			}

			// Token: 0x06007004 RID: 28676 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnSoundAtPoint(string StringParam)
			{
				throw null;
			}

			// Token: 0x06007005 RID: 28677 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnStartUtilityOperation()
			{
				throw null;
			}

			// Token: 0x06007006 RID: 28678 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnStartUtilityOperation()
			{
				throw null;
			}

			// Token: 0x06007007 RID: 28679 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnThirdAction(int IntParam)
			{
				throw null;
			}

			// Token: 0x06007008 RID: 28680 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnThirdAction(int IntParam)
			{
				throw null;
			}

			// Token: 0x06007009 RID: 28681 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void OnUseProp(bool BoolParam)
			{
				throw null;
			}

			// Token: 0x0600700A RID: 28682 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnOnUseProp(bool BoolParam)
			{
				throw null;
			}

			// Token: 0x0600700B RID: 28683 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnUseSecondMagForReload()
			{
				throw null;
			}

			// Token: 0x0600700C RID: 28684 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnUseSecondMagForReload()
			{
				throw null;
			}

			// Token: 0x0600700D RID: 28685 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnWeapIn()
			{
				throw null;
			}

			// Token: 0x0600700E RID: 28686 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnWeapIn()
			{
				throw null;
			}

			// Token: 0x0600700F RID: 28687 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnWeapOut()
			{
				throw null;
			}

			// Token: 0x06007010 RID: 28688 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsConsumerOnWeapOut()
			{
				throw null;
			}

			// Token: 0x06007011 RID: 28689 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void OnBackpackDrop()
			{
				throw null;
			}

			// Token: 0x06007012 RID: 28690 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void IEventsOnBackpackDrop()
			{
				throw null;
			}

			// Token: 0x06007013 RID: 28691 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnCurrentAnimStateEnded()
			{
				throw null;
			}

			// Token: 0x06007014 RID: 28692 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnSetActiveObject(int objectID)
			{
				throw null;
			}

			// Token: 0x06007015 RID: 28693 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void GInterface24.OnDeactivateObject(int objectID)
			{
				throw null;
			}

			// Token: 0x04007731 RID: 30513
			protected readonly GClass763 CompositeDisposable;
		}

		// Token: 0x02001454 RID: 5204
		public abstract class GClass1580
		{
			// Token: 0x1700116A RID: 4458
			// (get) Token: 0x06007016 RID: 28694 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007017 RID: 28695 RVA: 0x00002050 File Offset: 0x00000250
			public virtual Player.EOperationState State
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected set
				{
					throw null;
				}
			}

			// Token: 0x06007018 RID: 28696 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateLoggerController(Player.AbstractHandsController handsController)
			{
				throw null;
			}

			// Token: 0x06007019 RID: 28697 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void Start()
			{
				throw null;
			}

			// Token: 0x0600701A RID: 28698 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void Reset()
			{
				throw null;
			}

			// Token: 0x0600701B RID: 28699 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void Update(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600701C RID: 28700 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void method_0()
			{
				throw null;
			}

			// Token: 0x0600701D RID: 28701 RVA: 0x00002050 File Offset: 0x00000250
			[Conditional("UNITY_EDITOR")]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void method_1()
			{
				throw null;
			}

			// Token: 0x0600701E RID: 28702 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void OnEnd()
			{
				throw null;
			}

			// Token: 0x0600701F RID: 28703 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void SetLeftStanceAnimOnStartOperation()
			{
				throw null;
			}

			// Token: 0x04007732 RID: 30514
			private readonly Player.GClass1580.HandsControllerOperationLogger handsControllerOperationLogger_0;

			// Token: 0x04007733 RID: 30515
			[CompilerGenerated]
			private Player.EOperationState eoperationState_0;

			// Token: 0x02001455 RID: 5205
			protected class HandsControllerOperationLogger : LoggerClass
			{
				// Token: 0x06007020 RID: 28704 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void SetHandsController(Player.AbstractHandsController controller)
				{
					throw null;
				}

				// Token: 0x06007021 RID: 28705 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void TraceProhibitedCall()
				{
					throw null;
				}

				// Token: 0x06007022 RID: 28706 RVA: 0x00002050 File Offset: 0x00000250
				[Conditional("UNITY_EDITOR")]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void TraceMethodCall()
				{
					throw null;
				}

				// Token: 0x06007023 RID: 28707 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void OperationStart()
				{
					throw null;
				}

				// Token: 0x04007734 RID: 30516
				private Player.AbstractHandsController abstractHandsController_0;

				// Token: 0x04007735 RID: 30517
				private readonly Player.GClass1580 gclass1580_0;
			}
		}

		// Token: 0x02001456 RID: 5206
		internal class UsableItemController : Player.ItemHandsController, GInterface123, GInterface124, GInterface126, GInterface129
		{
			// Token: 0x1700116B RID: 4459
			// (get) Token: 0x06007024 RID: 28708 RVA: 0x00002050 File Offset: 0x00000250
			protected Player.Interface7 Interface7_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700116C RID: 4460
			// (get) Token: 0x06007025 RID: 28709 RVA: 0x00002050 File Offset: 0x00000250
			public override FirearmsAnimator FirearmsAnimator
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700116D RID: 4461
			// (get) Token: 0x06007026 RID: 28710 RVA: 0x00002050 File Offset: 0x00000250
			public override string LoggerDistinctId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700116E RID: 4462
			// (get) Token: 0x06007027 RID: 28711 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007028 RID: 28712 RVA: 0x00002050 File Offset: 0x00000250
			public override bool IsAiming
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected set
				{
					throw null;
				}
			}

			// Token: 0x06007029 RID: 28713 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static T smethod_5<T>(Player player, Item item) where T : Player.UsableItemController
			{
				throw null;
			}

			// Token: 0x0600702A RID: 28714 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Task<T> smethod_6<T>(Player player, Item item) where T : Player.UsableItemController
			{
				throw null;
			}

			// Token: 0x0600702B RID: 28715 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static void smethod_7<T>(T controller, Player player) where T : Player.UsableItemController
			{
				throw null;
			}

			// Token: 0x0600702C RID: 28716 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static WeaponPrefab smethod_8<T>(T controller) where T : Player.UsableItemController
			{
				throw null;
			}

			// Token: 0x0600702D RID: 28717 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void vmethod_0(Player player, WeaponPrefab weaponPrefab)
			{
				throw null;
			}

			// Token: 0x0600702E RID: 28718 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapIn()
			{
				throw null;
			}

			// Token: 0x0600702F RID: 28719 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnWeapOut()
			{
				throw null;
			}

			// Token: 0x06007030 RID: 28720 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnThirdAction(int intParam)
			{
				throw null;
			}

			// Token: 0x06007031 RID: 28721 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsOnBackpackDrop()
			{
				throw null;
			}

			// Token: 0x06007032 RID: 28722 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnIdleStart()
			{
				throw null;
			}

			// Token: 0x06007033 RID: 28723 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ManualLateUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x06007034 RID: 28724 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ManualUpdate(float deltaTime)
			{
				throw null;
			}

			// Token: 0x06007035 RID: 28725 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void IEventsConsumerOnOnUseProp(bool boolParam)
			{
				throw null;
			}

			// Token: 0x06007036 RID: 28726 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool SupportPickup()
			{
				throw null;
			}

			// Token: 0x06007037 RID: 28727 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInventoryOpen()
			{
				throw null;
			}

			// Token: 0x06007038 RID: 28728 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetInventoryOpened(bool opened)
			{
				throw null;
			}

			// Token: 0x06007039 RID: 28729 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Pickup(bool p)
			{
				throw null;
			}

			// Token: 0x0600703A RID: 28730 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Interact(bool isInteracting, int actionIndex)
			{
				throw null;
			}

			// Token: 0x0600703B RID: 28731 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Loot(bool p)
			{
				throw null;
			}

			// Token: 0x0600703C RID: 28732 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanRemove()
			{
				throw null;
			}

			// Token: 0x0600703D RID: 28733 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanInteract()
			{
				throw null;
			}

			// Token: 0x0600703E RID: 28734 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ShowGesture(EGesture gesture)
			{
				throw null;
			}

			// Token: 0x0600703F RID: 28735 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool ExamineWeapon()
			{
				throw null;
			}

			// Token: 0x06007040 RID: 28736 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInInteraction()
			{
				throw null;
			}

			// Token: 0x06007041 RID: 28737 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void ToggleAim()
			{
				throw null;
			}

			// Token: 0x06007042 RID: 28738 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void SetAim(bool value)
			{
				throw null;
			}

			// Token: 0x06007043 RID: 28739 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void Hide()
			{
				throw null;
			}

			// Token: 0x06007044 RID: 28740 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsInInteractionStrictCheck()
			{
				throw null;
			}

			// Token: 0x06007045 RID: 28741 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Spawn(float animationSpeed, Action callback)
			{
				throw null;
			}

			// Token: 0x06007046 RID: 28742 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null)
			{
				throw null;
			}

			// Token: 0x06007047 RID: 28743 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Destroy()
			{
				throw null;
			}

			// Token: 0x06007048 RID: 28744 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void vmethod_1(Action callback)
			{
				throw null;
			}

			// Token: 0x06007049 RID: 28745 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0()
			{
				throw null;
			}

			// Token: 0x0600704A RID: 28746 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_1()
			{
				throw null;
			}

			// Token: 0x0600704B RID: 28747 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_2()
			{
				throw null;
			}

			// Token: 0x0600704C RID: 28748 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_3(bool obj)
			{
				throw null;
			}

			// Token: 0x0600704D RID: 28749 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void vmethod_2(EPlayerState previousstate, EPlayerState nextstate)
			{
				throw null;
			}

			// Token: 0x0600704E RID: 28750 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_4()
			{
				throw null;
			}

			// Token: 0x0600704F RID: 28751 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool CanExecute(GInterface336 operation)
			{
				throw null;
			}

			// Token: 0x06007050 RID: 28752 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Execute(GInterface336 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x06007051 RID: 28753 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void FastForwardCurrentState()
			{
				throw null;
			}

			// Token: 0x06007052 RID: 28754 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void method_5()
			{
				throw null;
			}

			// Token: 0x06007053 RID: 28755 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_6(Vector3 origin, float ln, ref bool overlapsWithPlayer)
			{
				throw null;
			}

			// Token: 0x06007054 RID: 28756 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected bool method_7(RaycastHit overlapHit)
			{
				throw null;
			}

			// Token: 0x06007055 RID: 28757 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_8()
			{
				throw null;
			}

			// Token: 0x06007056 RID: 28758 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_9()
			{
				throw null;
			}

			// Token: 0x06007057 RID: 28759 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_10()
			{
				throw null;
			}

			// Token: 0x06007058 RID: 28760 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_11()
			{
				throw null;
			}

			// Token: 0x06007059 RID: 28761 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Player.GClass1580 method_12()
			{
				throw null;
			}

			// Token: 0x0600705A RID: 28762 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_13()
			{
				throw null;
			}

			// Token: 0x04007736 RID: 30518
			private const float float_0 = 0.5f;

			// Token: 0x04007737 RID: 30519
			private static readonly RaycastHit[] raycastHit_0;

			// Token: 0x04007738 RID: 30520
			private int int_0;

			// Token: 0x04007739 RID: 30521
			private bool bool_0;

			// Token: 0x0400773A RID: 30522
			private bool bool_1;

			// Token: 0x0400773B RID: 30523
			protected float float_1;

			// Token: 0x0400773C RID: 30524
			protected GClass1664 gclass1664_0;

			// Token: 0x0400773D RID: 30525
			protected FirearmsAnimator firearmsAnimator_0;

			// Token: 0x0400773E RID: 30526
			protected Func<RaycastHit, bool> func_0;

			// Token: 0x0400773F RID: 30527
			protected bool bool_2;

			// Token: 0x04007740 RID: 30528
			protected float float_2;

			// Token: 0x04007741 RID: 30529
			protected bool bool_3;

			// Token: 0x02001457 RID: 5207
			internal abstract class Class1040 : Player.GClass1580, Player.Interface7
			{
				// Token: 0x0600705B RID: 28763 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual bool CanRemove()
				{
					throw null;
				}

				// Token: 0x0600705C RID: 28764 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void HideWeaponComplete()
				{
					throw null;
				}

				// Token: 0x0600705D RID: 28765 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void WeaponAppeared()
				{
					throw null;
				}

				// Token: 0x0600705E RID: 28766 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x0600705F RID: 28767 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnBackpackDrop()
				{
					throw null;
				}

				// Token: 0x06007060 RID: 28768 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x06007061 RID: 28769 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Execute(GInterface336 operation, Callback callback)
				{
					throw null;
				}

				// Token: 0x06007062 RID: 28770 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void HideWeapon(Action onHidden, bool fastDrop)
				{
					throw null;
				}

				// Token: 0x06007063 RID: 28771 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06007064 RID: 28772 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void FastForward()
				{
					throw null;
				}

				// Token: 0x06007065 RID: 28773 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnAimingDisabled()
				{
					throw null;
				}

				// Token: 0x06007066 RID: 28774 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void SetCompassState(bool active)
				{
					throw null;
				}

				// Token: 0x06007067 RID: 28775 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void OnIdleStart()
				{
					throw null;
				}

				// Token: 0x04007742 RID: 30530
				protected readonly Player.UsableItemController usableItemController_0;

				// Token: 0x04007743 RID: 30531
				protected readonly Player player_0;
			}

			// Token: 0x02001458 RID: 5208
			internal class Class1041 : Player.UsableItemController.Class1040
			{
				// Token: 0x06007068 RID: 28776 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x06007069 RID: 28777 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x0600706A RID: 28778 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnBackpackDrop()
				{
					throw null;
				}

				// Token: 0x0600706B RID: 28779 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x0600706C RID: 28780 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x0600706D RID: 28781 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void vmethod_0()
				{
					throw null;
				}

				// Token: 0x04007744 RID: 30532
				private Callback callback_0;
			}

			// Token: 0x02001459 RID: 5209
			public class Class1042 : Player.UsableItemController.Class1041
			{
				// Token: 0x0600706E RID: 28782 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Start(Item item, Callback callback)
				{
					throw null;
				}

				// Token: 0x0600706F RID: 28783 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06007070 RID: 28784 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x04007745 RID: 30533
				protected const float float_0 = 0.25f;

				// Token: 0x04007746 RID: 30534
				protected float float_1;

				// Token: 0x04007747 RID: 30535
				protected bool bool_0;
			}

			// Token: 0x0200145A RID: 5210
			internal class Class1047 : Player.UsableItemController.Class1040
			{
				// Token: 0x06007071 RID: 28785 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public new void Start()
				{
					throw null;
				}

				// Token: 0x06007072 RID: 28786 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06007073 RID: 28787 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop)
				{
					throw null;
				}

				// Token: 0x06007074 RID: 28788 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool CanRemove()
				{
					throw null;
				}

				// Token: 0x06007075 RID: 28789 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Execute(GInterface336 operation, Callback callback)
				{
					throw null;
				}

				// Token: 0x06007076 RID: 28790 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Update(float deltaTime)
				{
					throw null;
				}

				// Token: 0x06007077 RID: 28791 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetAiming(bool isAiming)
				{
					throw null;
				}

				// Token: 0x06007078 RID: 28792 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void ExamineWeapon()
				{
					throw null;
				}

				// Token: 0x06007079 RID: 28793 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnAimingDisabled()
				{
					throw null;
				}

				// Token: 0x0600707A RID: 28794 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetInventoryOpened(bool opened)
				{
					throw null;
				}

				// Token: 0x0600707B RID: 28795 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void OnEnd()
				{
					throw null;
				}

				// Token: 0x0600707C RID: 28796 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void SetCompassState(bool active)
				{
					throw null;
				}

				// Token: 0x0600707D RID: 28797 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void vmethod_0(GInterface337 oneItemOperation, Callback callback)
				{
					throw null;
				}

				// Token: 0x04007748 RID: 30536
				private const float float_0 = 300f;

				// Token: 0x04007749 RID: 30537
				private float float_1;
			}

			// Token: 0x0200145B RID: 5211
			internal class Class1050 : Player.UsableItemController.Class1040
			{
				// Token: 0x0600707E RID: 28798 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public virtual void Start(Action onHidden, bool fastDrop)
				{
					throw null;
				}

				// Token: 0x0600707F RID: 28799 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06007080 RID: 28800 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeaponComplete()
				{
					throw null;
				}

				// Token: 0x06007081 RID: 28801 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop)
				{
					throw null;
				}

				// Token: 0x06007082 RID: 28802 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x0400774A RID: 30538
				protected Action action_0;
			}

			// Token: 0x0200145C RID: 5212
			internal class Class1053 : Player.UsableItemController.Class1040
			{
				// Token: 0x06007083 RID: 28803 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Start(Action callback)
				{
					throw null;
				}

				// Token: 0x06007084 RID: 28804 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void Reset()
				{
					throw null;
				}

				// Token: 0x06007085 RID: 28805 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void WeaponAppeared()
				{
					throw null;
				}

				// Token: 0x06007086 RID: 28806 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void HideWeapon(Action onHidden, bool fastDrop)
				{
					throw null;
				}

				// Token: 0x06007087 RID: 28807 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override void FastForward()
				{
					throw null;
				}

				// Token: 0x06007088 RID: 28808 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected virtual void vmethod_0()
				{
					throw null;
				}

				// Token: 0x06007089 RID: 28809 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected override void SetLeftStanceAnimOnStartOperation()
				{
					throw null;
				}

				// Token: 0x0400774B RID: 30539
				protected Action action_0;

				// Token: 0x0400774C RID: 30540
				protected Action action_1;

				// Token: 0x0400774D RID: 30541
				protected bool bool_0;
			}

			// Token: 0x0200145E RID: 5214
			[CompilerGenerated]
			private sealed class Class1056
			{
				// Token: 0x0600708C RID: 28812 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x04007753 RID: 30547
				public Player.UsableItemController usableItemController_0;

				// Token: 0x04007754 RID: 30548
				public Player.Class1059 inventoryOperation;

				// Token: 0x04007755 RID: 30549
				public Action callback;
			}
		}

		// Token: 0x0200145F RID: 5215
		internal interface Interface7
		{
			// Token: 0x0600708D RID: 28813
			void HideWeaponComplete();

			// Token: 0x0600708E RID: 28814
			void WeaponAppeared();

			// Token: 0x0600708F RID: 28815
			void HideWeapon(Action onHidden, bool fastDrop);

			// Token: 0x06007090 RID: 28816
			void OnBackpackDrop();

			// Token: 0x06007091 RID: 28817
			void SetAiming(bool isAiming);

			// Token: 0x06007092 RID: 28818
			void Execute(GInterface336 operation, Callback callback);

			// Token: 0x06007093 RID: 28819
			void ExamineWeapon();

			// Token: 0x06007094 RID: 28820
			void FastForward();

			// Token: 0x06007095 RID: 28821
			void OnIdleStart();

			// Token: 0x06007096 RID: 28822
			void OnAimingDisabled();

			// Token: 0x06007097 RID: 28823
			void SetInventoryOpened(bool opened);
		}

		// Token: 0x02001460 RID: 5216
		public enum EVoipState : byte
		{
			// Token: 0x04007757 RID: 30551
			NotAvailable,
			// Token: 0x04007758 RID: 30552
			Available,
			// Token: 0x04007759 RID: 30553
			Off,
			// Token: 0x0400775A RID: 30554
			Banned,
			// Token: 0x0400775B RID: 30555
			MicrophoneFail
		}

		// Token: 0x02001461 RID: 5217
		public enum EProcessStatus
		{
			// Token: 0x0400775D RID: 30557
			None,
			// Token: 0x0400775E RID: 30558
			Scheduled,
			// Token: 0x0400775F RID: 30559
			Internal
		}

		// Token: 0x02001462 RID: 5218
		public class GClass1627 : IRollback, GInterface321
		{
			// Token: 0x06007098 RID: 28824 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RollBack()
			{
				throw null;
			}

			// Token: 0x06007099 RID: 28825 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
			{
				throw null;
			}

			// Token: 0x0600709A RID: 28826 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public GStruct412 Replay()
			{
				throw null;
			}

			// Token: 0x0600709B RID: 28827 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool CanExecute(TraderControllerClass itemController)
			{
				throw null;
			}

			// Token: 0x04007760 RID: 30560
			public GClass2779 DiscardResult;

			// Token: 0x04007761 RID: 30561
			public Player Player;

			// Token: 0x04007762 RID: 30562
			public GrenadeClass Grenade;

			// Token: 0x04007763 RID: 30563
			public bool LowThrow;
		}

		// Token: 0x02001463 RID: 5219
		internal abstract class Class1057 : IDisposable
		{
			// Token: 0x1700116F RID: 4463
			// (get) Token: 0x0600709C RID: 28828 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600709D RID: 28829 RVA: 0x00002050 File Offset: 0x00000250
			private Player Player_0
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

			// Token: 0x17001170 RID: 4464
			// (get) Token: 0x0600709E RID: 28830 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600709F RID: 28831 RVA: 0x00002050 File Offset: 0x00000250
			protected Player.Class1057.InternalState InternalState_0
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

			// Token: 0x17001171 RID: 4465
			// (get) Token: 0x060070A0 RID: 28832 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060070A1 RID: 28833 RVA: 0x00002050 File Offset: 0x00000250
			public CommandStatus Status
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected set
				{
					throw null;
				}
			}

			// Token: 0x17001172 RID: 4466
			// (get) Token: 0x060070A2 RID: 28834 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060070A3 RID: 28835 RVA: 0x00002050 File Offset: 0x00000250
			internal Item Item_0
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

			// Token: 0x060070A4 RID: 28836 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void Finalize()
			{
				throw null;
			}

			// Token: 0x060070A5 RID: 28837 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Execute()
			{
				throw null;
			}

			// Token: 0x060070A6 RID: 28838 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Confirm(bool succeed = true)
			{
				throw null;
			}

			// Token: 0x060070A7 RID: 28839
			protected abstract void vmethod_0();

			// Token: 0x060070A8 RID: 28840
			protected abstract void vmethod_1(bool succeed);

			// Token: 0x17001173 RID: 4467
			// (get) Token: 0x060070A9 RID: 28841 RVA: 0x00002050 File Offset: 0x00000250
			public bool Disposed
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060070AA RID: 28842 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x060070AB RID: 28843 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void Dispose(bool disposing)
			{
				throw null;
			}

			// Token: 0x04007764 RID: 30564
			[CompilerGenerated]
			private Player player_0;

			// Token: 0x04007765 RID: 30565
			[CompilerGenerated]
			private Player.Class1057.InternalState internalState_0;

			// Token: 0x04007766 RID: 30566
			[CompilerGenerated]
			private CommandStatus commandStatus_0;

			// Token: 0x04007767 RID: 30567
			[CompilerGenerated]
			private Item item_0;

			// Token: 0x02001464 RID: 5220
			protected enum InternalState
			{
				// Token: 0x04007769 RID: 30569
				Creating,
				// Token: 0x0400776A RID: 30570
				Executed,
				// Token: 0x0400776B RID: 30571
				Confirmed,
				// Token: 0x0400776C RID: 30572
				Disposed
			}
		}

		// Token: 0x02001465 RID: 5221
		internal sealed class Class1058 : Player.Class1057
		{
			// Token: 0x060070AC RID: 28844 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void vmethod_0()
			{
				throw null;
			}

			// Token: 0x060070AD RID: 28845 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void vmethod_1(bool succeed)
			{
				throw null;
			}
		}

		// Token: 0x02001466 RID: 5222
		private sealed class Class1059 : Player.Class1057
		{
			// Token: 0x060070AE RID: 28846 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void vmethod_0()
			{
				throw null;
			}

			// Token: 0x060070AF RID: 28847 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void vmethod_1(bool succeed)
			{
				throw null;
			}
		}

		// Token: 0x02001467 RID: 5223
		protected abstract class AbstractProcess
		{
			// Token: 0x060070B0 RID: 28848 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected static void Execute(Player.AbstractProcess process)
			{
				throw null;
			}

			// Token: 0x060070B1 RID: 28849
			protected abstract void Execute();

			// Token: 0x060070B2 RID: 28850 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected static bool TrySkip(Player.AbstractProcess process)
			{
				throw null;
			}

			// Token: 0x060070B3 RID: 28851
			protected abstract bool TrySkip();

			// Token: 0x060070B4 RID: 28852
			protected abstract void CreateController();

			// Token: 0x060070B5 RID: 28853
			protected abstract void Skip(string error);

			// Token: 0x060070B6 RID: 28854
			protected abstract void SkipToNext(string error);

			// Token: 0x060070B7 RID: 28855
			protected abstract void Begin(string error = null);

			// Token: 0x060070B8 RID: 28856
			protected abstract void Complete();

			// Token: 0x060070B9 RID: 28857
			protected abstract void Complete(string error);

			// Token: 0x060070BA RID: 28858
			protected abstract void Abort();

			// Token: 0x060070BB RID: 28859
			protected abstract void AbortAfterCompletion();

			// Token: 0x060070BC RID: 28860
			protected abstract void ExecuteNext();

			// Token: 0x02001468 RID: 5224
			internal enum Completion
			{
				// Token: 0x0400776E RID: 30574
				Sync,
				// Token: 0x0400776F RID: 30575
				Async
			}

			// Token: 0x02001469 RID: 5225
			internal enum Confirmation
			{
				// Token: 0x04007771 RID: 30577
				Unknown,
				// Token: 0x04007772 RID: 30578
				Succeed,
				// Token: 0x04007773 RID: 30579
				Failed
			}
		}

		// Token: 0x0200146A RID: 5226
		protected sealed class Process<TController, TResult> : Player.AbstractProcess where TController : Player.AbstractHandsController, TResult
		{
			// Token: 0x060070BD RID: 28861 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0([CanBeNull] Callback beginCallback, [CanBeNull] Callback<TResult> completeCallback, bool scheduled)
			{
				throw null;
			}

			// Token: 0x060070BE RID: 28862 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Execute()
			{
				throw null;
			}

			// Token: 0x060070BF RID: 28863 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void CreateController()
			{
				throw null;
			}

			// Token: 0x060070C0 RID: 28864 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(bool succeed)
			{
				throw null;
			}

			// Token: 0x060070C1 RID: 28865 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override bool TrySkip()
			{
				throw null;
			}

			// Token: 0x060070C2 RID: 28866 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Skip(string error)
			{
				throw null;
			}

			// Token: 0x060070C3 RID: 28867 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void SkipToNext(string error)
			{
				throw null;
			}

			// Token: 0x060070C4 RID: 28868 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Begin(string error = null)
			{
				throw null;
			}

			// Token: 0x060070C5 RID: 28869 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Complete()
			{
				throw null;
			}

			// Token: 0x060070C6 RID: 28870 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Complete([CanBeNull] string error)
			{
				throw null;
			}

			// Token: 0x060070C7 RID: 28871 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Abort()
			{
				throw null;
			}

			// Token: 0x060070C8 RID: 28872 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void AbortAfterCompletion()
			{
				throw null;
			}

			// Token: 0x060070C9 RID: 28873 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void ExecuteNext()
			{
				throw null;
			}

			// Token: 0x060070CA RID: 28874 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_2(Result<GInterface125> callback)
			{
				throw null;
			}

			// Token: 0x04007774 RID: 30580
			private readonly Player player_0;

			// Token: 0x04007775 RID: 30581
			private readonly Func<TController> func_0;

			// Token: 0x04007776 RID: 30582
			[CanBeNull]
			private readonly Item item_0;

			// Token: 0x04007777 RID: 30583
			private readonly Player.AbstractProcess.Completion completion_0;

			// Token: 0x04007778 RID: 30584
			private Player.AbstractProcess.Confirmation confirmation_0;

			// Token: 0x04007779 RID: 30585
			private bool bool_0;

			// Token: 0x0400777A RID: 30586
			private bool bool_1;

			// Token: 0x0400777B RID: 30587
			private Callback callback_0;

			// Token: 0x0400777C RID: 30588
			private Callback<TResult> callback_1;

			// Token: 0x0400777D RID: 30589
			private TController gparam_0;

			// Token: 0x0400777E RID: 30590
			private bool bool_2;

			// Token: 0x0400777F RID: 30591
			private bool bool_3;

			// Token: 0x0200146B RID: 5227
			[CompilerGenerated]
			[Serializable]
			private sealed class Class1060
			{
				// Token: 0x060070CB RID: 28875 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(IResult result)
				{
					throw null;
				}

				// Token: 0x060070CC RID: 28876 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_1(Result<TResult> result)
				{
					throw null;
				}

				// Token: 0x04007780 RID: 30592
				public static readonly Player.Process<TController, TResult>.Class1060 class1060_0;

				// Token: 0x04007781 RID: 30593
				public static Callback callback_0;

				// Token: 0x04007782 RID: 30594
				public static Callback<TResult> callback_1;
			}

			// Token: 0x0200146C RID: 5228
			[CompilerGenerated]
			private sealed class Class1061
			{
				// Token: 0x060070CD RID: 28877 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x060070CE RID: 28878 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_1()
				{
					throw null;
				}

				// Token: 0x04007784 RID: 30596
				public Action execute;
			}

			// Token: 0x0200146D RID: 5229
			[CompilerGenerated]
			private sealed class Class1062
			{
				// Token: 0x060070CF RID: 28879 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x04007786 RID: 30598
				public Player.Class1058 setInHandsOperation;
			}
		}

		// Token: 0x0200146E RID: 5230
		[Flags]
		public enum EAnimatorMask
		{
			// Token: 0x04007788 RID: 30600
			Thirdperson = 1,
			// Token: 0x04007789 RID: 30601
			Arms = 2,
			// Token: 0x0400778A RID: 30602
			Procedural = 4,
			// Token: 0x0400778B RID: 30603
			FBBIK = 8,
			// Token: 0x0400778C RID: 30604
			IK = 16
		}

		// Token: 0x0200146F RID: 5231
		public class GClass625 : LoggerClass
		{
		}

		// Token: 0x02001470 RID: 5232
		public class GClass1628<T> where T : class, IItemComponent
		{
			// Token: 0x17001174 RID: 4468
			// (get) Token: 0x060070D0 RID: 28880 RVA: 0x00002050 File Offset: 0x00000250
			[CanBeNull]
			public virtual T Component
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060070D1 RID: 28881 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Update()
			{
				throw null;
			}

			// Token: 0x060070D2 RID: 28882 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Set([CanBeNull] T value)
			{
				throw null;
			}

			// Token: 0x060070D3 RID: 28883 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public T GetItemComponent()
			{
				throw null;
			}

			// Token: 0x060070D4 RID: 28884 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0()
			{
				throw null;
			}

			// Token: 0x060070D5 RID: 28885 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void Dispose()
			{
				throw null;
			}

			// Token: 0x0400778D RID: 30605
			public readonly BindableEvent Changed;

			// Token: 0x0400778E RID: 30606
			[CanBeNull]
			protected T gparam_0;

			// Token: 0x0400778F RID: 30607
			private readonly Slot slot_0;

			// Token: 0x04007790 RID: 30608
			private readonly Func<T, Action, Action> func_0;

			// Token: 0x04007791 RID: 30609
			private Action action_0;
		}

		// Token: 0x02001471 RID: 5233
		public enum EUpdateMode
		{
			// Token: 0x04007793 RID: 30611
			Auto,
			// Token: 0x04007794 RID: 30612
			Manual,
			// Token: 0x04007795 RID: 30613
			None
		}

		// Token: 0x02001472 RID: 5234
		// (Invoke) Token: 0x060070D6 RID: 28886
		public delegate float GDelegate56();

		// Token: 0x02001473 RID: 5235
		protected internal abstract class PlayerOwnerInventoryController : Player.PlayerInventoryController
		{
			// Token: 0x060070D9 RID: 28889 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ExamineMalfunction(Weapon weapon, bool clearRest = false)
			{
				throw null;
			}

			// Token: 0x060070DA RID: 28890 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task method_42(Weapon weapon, int delayInMilliseconds)
			{
				throw null;
			}

			// Token: 0x060070DB RID: 28891 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ExamineMalfunctionType(Weapon weapon)
			{
				throw null;
			}

			// Token: 0x060070DC RID: 28892 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void CallUnknownMalfunctionStartRepair(Weapon weapon)
			{
				throw null;
			}

			// Token: 0x060070DD RID: 28893 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void CallMalfunctionRepaired(Weapon weapon)
			{
				throw null;
			}

			// Token: 0x060070DE RID: 28894 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_43()
			{
				throw null;
			}

			// Token: 0x060070DF RID: 28895 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override GStruct415<bool> TryThrowItem(Item item, Callback callback = null, bool silent = false)
			{
				throw null;
			}

			// Token: 0x060070E0 RID: 28896 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ProcessFastWeaponSwitchAvailability()
			{
				throw null;
			}

			// Token: 0x060070E1 RID: 28897 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task method_44(int delayInMilliseconds)
			{
				throw null;
			}
		}

		// Token: 0x02001476 RID: 5238
		protected sealed class SinglePlayerInventoryController : Player.PlayerOwnerInventoryController
		{
			// Token: 0x060070E6 RID: 28902 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal override void Execute(GClass2833 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x060070E7 RID: 28903 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task method_45(GClass2833 operation, [CanBeNull] Callback callback)
			{
				throw null;
			}

			// Token: 0x060070E8 RID: 28904 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_46(GClass2833 operation, Callback callback)
			{
				throw null;
			}
		}

		// Token: 0x02001478 RID: 5240
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1064
		{
			// Token: 0x060070EB RID: 28907 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface123> result)
			{
				throw null;
			}

			// Token: 0x060070EC RID: 28908 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Result<GInterface123> result)
			{
				throw null;
			}

			// Token: 0x060070ED RID: 28909 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(TacticalComboVisualController x)
			{
				throw null;
			}

			// Token: 0x060070EE RID: 28910 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(GripPose x)
			{
				throw null;
			}

			// Token: 0x060070EF RID: 28911 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(GripPose x)
			{
				throw null;
			}

			// Token: 0x060070F0 RID: 28912 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_5(GripPose x)
			{
				throw null;
			}

			// Token: 0x060070F1 RID: 28913 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_6(BetterPropagationVolume x)
			{
				throw null;
			}

			// Token: 0x060070F2 RID: 28914 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<EBodyPartColliderType> method_7(CompositeArmorComponent x)
			{
				throw null;
			}

			// Token: 0x060070F3 RID: 28915 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_8(Result<IFirearmHandsController> result)
			{
				throw null;
			}

			// Token: 0x060070F4 RID: 28916 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_9(Result<GInterface123> result)
			{
				throw null;
			}

			// Token: 0x060070F5 RID: 28917 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_10(Result<GInterface123> result)
			{
				throw null;
			}

			// Token: 0x060070F6 RID: 28918 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Action method_11(NightVisionComponent nv, Action handler)
			{
				throw null;
			}

			// Token: 0x060070F7 RID: 28919 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Action method_12(ThermalVisionComponent tv, Action handler)
			{
				throw null;
			}

			// Token: 0x060070F8 RID: 28920 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Action method_13(FaceShieldComponent fs, Action handler)
			{
				throw null;
			}

			// Token: 0x060070F9 RID: 28921 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Action method_14(FaceShieldComponent fs, Action handler)
			{
				throw null;
			}

			// Token: 0x060070FA RID: 28922 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EDeafStrength method_15(CompositeArmorComponent x)
			{
				throw null;
			}

			// Token: 0x060070FB RID: 28923 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_16(EDeafStrength d)
			{
				throw null;
			}

			// Token: 0x060070FC RID: 28924 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EDeafStrength method_17(CompositeArmorComponent x)
			{
				throw null;
			}

			// Token: 0x060070FD RID: 28925 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_18(EDeafStrength d)
			{
				throw null;
			}

			// Token: 0x060070FE RID: 28926 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_19()
			{
				throw null;
			}

			// Token: 0x060070FF RID: 28927 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_20(Renderer x)
			{
				throw null;
			}

			// Token: 0x06007100 RID: 28928 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_21()
			{
				throw null;
			}

			// Token: 0x040077A7 RID: 30631
			public static readonly Player.Class1064 class1064_0;

			// Token: 0x040077A8 RID: 30632
			public static Callback<GInterface123> callback_0;

			// Token: 0x040077A9 RID: 30633
			public static Callback<GInterface123> callback_1;

			// Token: 0x040077AA RID: 30634
			public static Func<TacticalComboVisualController, bool> func_0;

			// Token: 0x040077AB RID: 30635
			public static Func<GripPose, bool> func_1;

			// Token: 0x040077AC RID: 30636
			public static Func<GripPose, bool> func_2;

			// Token: 0x040077AD RID: 30637
			public static Func<GripPose, bool> func_3;

			// Token: 0x040077AE RID: 30638
			public static Func<BetterPropagationVolume, bool> func_4;

			// Token: 0x040077AF RID: 30639
			public static Func<CompositeArmorComponent, IEnumerable<EBodyPartColliderType>> func_5;

			// Token: 0x040077B0 RID: 30640
			public static Callback<IFirearmHandsController> callback_2;

			// Token: 0x040077B1 RID: 30641
			public static Callback<GInterface123> callback_3;

			// Token: 0x040077B2 RID: 30642
			public static Callback<GInterface123> callback_4;

			// Token: 0x040077B3 RID: 30643
			public static Func<NightVisionComponent, Action, Action> func_6;

			// Token: 0x040077B4 RID: 30644
			public static Func<ThermalVisionComponent, Action, Action> func_7;

			// Token: 0x040077B5 RID: 30645
			public static Func<FaceShieldComponent, Action, Action> func_8;

			// Token: 0x040077B6 RID: 30646
			public static Func<FaceShieldComponent, Action, Action> func_9;

			// Token: 0x040077B7 RID: 30647
			public static Func<CompositeArmorComponent, EDeafStrength> func_10;

			// Token: 0x040077B8 RID: 30648
			public static Func<EDeafStrength, int> func_11;

			// Token: 0x040077B9 RID: 30649
			public static Func<CompositeArmorComponent, EDeafStrength> func_12;

			// Token: 0x040077BA RID: 30650
			public static Func<EDeafStrength, int> func_13;

			// Token: 0x040077BB RID: 30651
			public static Action action_0;

			// Token: 0x040077BC RID: 30652
			public static Func<Renderer, bool> func_14;
		}

		// Token: 0x02001479 RID: 5241
		[CompilerGenerated]
		private sealed class Class1065
		{
			// Token: 0x06007101 RID: 28929 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x040077BD RID: 30653
			public Player player_0;

			// Token: 0x040077BE RID: 30654
			public GInterface320 weapon;
		}

		// Token: 0x0200147B RID: 5243
		[CompilerGenerated]
		private sealed class Class1067
		{
			// Token: 0x06007106 RID: 28934 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GripPose x)
			{
				throw null;
			}

			// Token: 0x06007107 RID: 28935 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_1(GripPose x)
			{
				throw null;
			}

			// Token: 0x06007108 RID: 28936 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_2(GripPose x)
			{
				throw null;
			}

			// Token: 0x040077C2 RID: 30658
			public GripPose.EGripType type;

			// Token: 0x040077C3 RID: 30659
			public Player player_0;
		}

		// Token: 0x02001481 RID: 5249
		[CompilerGenerated]
		private sealed class Class1073
		{
			// Token: 0x0600711D RID: 28957 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(int value)
			{
				throw null;
			}

			// Token: 0x040077D4 RID: 30676
			public VoiceBroadcastTrigger broadcastTrigger;
		}

		// Token: 0x02001482 RID: 5250
		[CompilerGenerated]
		private sealed class Class1074
		{
			// Token: 0x0600711E RID: 28958 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x040077D5 RID: 30677
			public Player player_0;

			// Token: 0x040077D6 RID: 30678
			public Player.AbstractHandsController controller;

			// Token: 0x040077D7 RID: 30679
			public Action callback;

			// Token: 0x040077D8 RID: 30680
			public TaskCompletionSource onControllerAppeared;
		}

		// Token: 0x02001483 RID: 5251
		[CompilerGenerated]
		private sealed class Class1075
		{
			// Token: 0x0600711F RID: 28959 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_0(EquipmentSlot x)
			{
				throw null;
			}

			// Token: 0x06007120 RID: 28960 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Item x)
			{
				throw null;
			}

			// Token: 0x06007121 RID: 28961 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(Result<GInterface125> result)
			{
				throw null;
			}

			// Token: 0x040077D9 RID: 30681
			public Player player_0;

			// Token: 0x040077DA RID: 30682
			public Callback<GInterface123> completeCallback;
		}

		// Token: 0x02001484 RID: 5252
		[CompilerGenerated]
		private sealed class Class1076
		{
			// Token: 0x06007122 RID: 28962 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface125> result)
			{
				throw null;
			}

			// Token: 0x040077DB RID: 30683
			public Callback<GInterface123> callback;
		}

		// Token: 0x02001485 RID: 5253
		[CompilerGenerated]
		private sealed class Class1077
		{
			// Token: 0x06007123 RID: 28963 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal AIFirearmController method_0()
			{
				throw null;
			}

			// Token: 0x06007124 RID: 28964 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.FirearmController method_1()
			{
				throw null;
			}

			// Token: 0x040077DC RID: 30684
			public Player player_0;

			// Token: 0x040077DD RID: 30685
			public Weapon weapon;
		}

		// Token: 0x02001486 RID: 5254
		[CompilerGenerated]
		private sealed class Class1078
		{
			// Token: 0x06007125 RID: 28965 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.GrenadeController method_0()
			{
				throw null;
			}

			// Token: 0x040077DE RID: 30686
			public Player player_0;

			// Token: 0x040077DF RID: 30687
			public GrenadeClass throwWeap;
		}

		// Token: 0x02001487 RID: 5255
		[CompilerGenerated]
		private sealed class Class1079
		{
			// Token: 0x06007126 RID: 28966 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.MedsController method_0()
			{
				throw null;
			}

			// Token: 0x040077E0 RID: 30688
			public Player player_0;

			// Token: 0x040077E1 RID: 30689
			public MedsClass meds;

			// Token: 0x040077E2 RID: 30690
			public EBodyPart bodyPart;

			// Token: 0x040077E3 RID: 30691
			public int animationVariant;
		}

		// Token: 0x02001488 RID: 5256
		[CompilerGenerated]
		private sealed class Class1080
		{
			// Token: 0x06007127 RID: 28967 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.MedsController method_0()
			{
				throw null;
			}

			// Token: 0x040077E4 RID: 30692
			public Player player_0;

			// Token: 0x040077E5 RID: 30693
			public FoodClass foodDrink;

			// Token: 0x040077E6 RID: 30694
			public float amount;

			// Token: 0x040077E7 RID: 30695
			public int animationVariant;
		}

		// Token: 0x02001489 RID: 5257
		[CompilerGenerated]
		private sealed class Class1081
		{
			// Token: 0x06007128 RID: 28968 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.KnifeController method_0()
			{
				throw null;
			}

			// Token: 0x040077E8 RID: 30696
			public Player player_0;

			// Token: 0x040077E9 RID: 30697
			public KnifeComponent knife;
		}

		// Token: 0x0200148A RID: 5258
		[CompilerGenerated]
		private sealed class Class1082<T> where T : Player.UsableItemController
		{
			// Token: 0x06007129 RID: 28969 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal T method_0()
			{
				throw null;
			}

			// Token: 0x040077EA RID: 30698
			public Player player_0;

			// Token: 0x040077EB RID: 30699
			public Item item;
		}

		// Token: 0x0200148B RID: 5259
		[CompilerGenerated]
		private sealed class Class1083
		{
			// Token: 0x0600712A RID: 28970 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.QuickUseItemController method_0()
			{
				throw null;
			}

			// Token: 0x040077EC RID: 30700
			public Player player_0;

			// Token: 0x040077ED RID: 30701
			public Item item;
		}

		// Token: 0x0200148C RID: 5260
		[CompilerGenerated]
		private sealed class Class1084
		{
			// Token: 0x0600712B RID: 28971 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.QuickGrenadeThrowController method_0()
			{
				throw null;
			}

			// Token: 0x040077EE RID: 30702
			public Player player_0;

			// Token: 0x040077EF RID: 30703
			public GrenadeClass throwWeap;
		}

		// Token: 0x0200148D RID: 5261
		[CompilerGenerated]
		private sealed class Class1085
		{
			// Token: 0x0600712C RID: 28972 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.QuickKnifeKickController method_0()
			{
				throw null;
			}

			// Token: 0x040077F0 RID: 30704
			public Player player_0;

			// Token: 0x040077F1 RID: 30705
			public KnifeComponent knife;
		}

		// Token: 0x0200148E RID: 5262
		[CompilerGenerated]
		private sealed class Class1086
		{
			// Token: 0x0600712D RID: 28973 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600712E RID: 28974 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Result<IHandsController> result)
			{
				throw null;
			}

			// Token: 0x0600712F RID: 28975 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(Result<GInterface130> result)
			{
				throw null;
			}

			// Token: 0x06007130 RID: 28976 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(Result<GInterface130> result)
			{
				throw null;
			}

			// Token: 0x06007131 RID: 28977 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4(Result<IKnifeController> result)
			{
				throw null;
			}

			// Token: 0x06007132 RID: 28978 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_5(Result<GInterface135> result)
			{
				throw null;
			}

			// Token: 0x040077F2 RID: 30706
			public Callback<GInterface123> completeCallback;

			// Token: 0x040077F3 RID: 30707
			public Player player_0;
		}

		// Token: 0x0200148F RID: 5263
		[CompilerGenerated]
		private sealed class Class1087
		{
			// Token: 0x06007133 RID: 28979 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<IFirearmHandsController> result)
			{
				throw null;
			}

			// Token: 0x040077F4 RID: 30708
			public Player.Class1086 class1086_0;
		}

		// Token: 0x02001490 RID: 5264
		[CompilerGenerated]
		private sealed class Class1088
		{
			// Token: 0x06007134 RID: 28980 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface129> result)
			{
				throw null;
			}

			// Token: 0x06007135 RID: 28981 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Result<GInterface129> result)
			{
				throw null;
			}

			// Token: 0x040077F5 RID: 30709
			public Callback<GInterface123> completeCallback;
		}

		// Token: 0x02001491 RID: 5265
		[CompilerGenerated]
		private sealed class Class1089
		{
			// Token: 0x06007136 RID: 28982 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface129> result)
			{
				throw null;
			}

			// Token: 0x06007137 RID: 28983 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Result<GInterface129> result)
			{
				throw null;
			}

			// Token: 0x040077F6 RID: 30710
			public Callback<GInterface123> completeCallback;
		}

		// Token: 0x02001492 RID: 5266
		[CompilerGenerated]
		private sealed class Class1090
		{
			// Token: 0x06007138 RID: 28984 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IResult result)
			{
				throw null;
			}

			// Token: 0x040077F7 RID: 30711
			public Player player_0;

			// Token: 0x040077F8 RID: 30712
			public Callback callback;
		}

		// Token: 0x02001493 RID: 5267
		[CompilerGenerated]
		private sealed class Class1091
		{
			// Token: 0x06007139 RID: 28985 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<IKnifeController> result)
			{
				throw null;
			}

			// Token: 0x0600713A RID: 28986 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Result<GInterface129> result)
			{
				throw null;
			}

			// Token: 0x0600713B RID: 28987 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(Result<GInterface129> result)
			{
				throw null;
			}

			// Token: 0x0600713C RID: 28988 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(Result<GInterface125> result)
			{
				throw null;
			}

			// Token: 0x040077F9 RID: 30713
			public Player player_0;

			// Token: 0x040077FA RID: 30714
			public Callback callback;
		}

		// Token: 0x02001494 RID: 5268
		[CompilerGenerated]
		private sealed class Class1092
		{
			// Token: 0x0600713D RID: 28989 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface123> result)
			{
				throw null;
			}

			// Token: 0x0600713E RID: 28990 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(IResult error)
			{
				throw null;
			}

			// Token: 0x040077FB RID: 30715
			public Player player_0;

			// Token: 0x040077FC RID: 30716
			public Callback callback;
		}

		// Token: 0x02001496 RID: 5270
		[CompilerGenerated]
		private sealed class Class1094
		{
			// Token: 0x06007143 RID: 28995 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool _)
			{
				throw null;
			}

			// Token: 0x06007144 RID: 28996 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(EPlayerState prevState, EPlayerState nextState)
			{
				throw null;
			}

			// Token: 0x04007800 RID: 30720
			public Player player_0;

			// Token: 0x04007801 RID: 30721
			public EPointOfView pointOfView;
		}

		// Token: 0x02001498 RID: 5272
		[CompilerGenerated]
		private sealed class Class1095
		{
			// Token: 0x06007147 RID: 28999 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04007815 RID: 30741
			public Action togglableSub;

			// Token: 0x04007816 RID: 30742
			public Action hitSub;
		}

		// Token: 0x02001499 RID: 5273
		[CompilerGenerated]
		private sealed class Class1096
		{
			// Token: 0x06007148 RID: 29000 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04007817 RID: 30743
			public Action togglableSub;

			// Token: 0x04007818 RID: 30744
			public Action hitSub;
		}

		// Token: 0x0200149A RID: 5274
		[CompilerGenerated]
		private sealed class Class1097
		{
			// Token: 0x06007149 RID: 29001 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600714A RID: 29002 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x04007819 RID: 30745
			public Player player_0;

			// Token: 0x0400781A RID: 30746
			public IEffect effect;
		}

		// Token: 0x0200149B RID: 5275
		[CompilerGenerated]
		private sealed class Class1098
		{
			// Token: 0x0600714B RID: 29003 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemAddress loc)
			{
				throw null;
			}

			// Token: 0x0600714C RID: 29004 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(ItemAddress loc)
			{
				throw null;
			}

			// Token: 0x0400781B RID: 30747
			public Slot[] headSlots;

			// Token: 0x0400781C RID: 30748
			public Slot[] armorSlots;
		}

		// Token: 0x0200149D RID: 5277
		[CompilerGenerated]
		private sealed class Class1100
		{
			// Token: 0x06007151 RID: 29009 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x06007152 RID: 29010 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x04007820 RID: 30752
			public Player player_0;

			// Token: 0x04007821 RID: 30753
			public float armorDamage;
		}

		// Token: 0x0200149F RID: 5279
		[CompilerGenerated]
		private sealed class Class1102
		{
			// Token: 0x06007157 RID: 29015 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BodyPartCollider hitCollider)
			{
				throw null;
			}

			// Token: 0x04007825 RID: 30757
			public EBodyPartColliderType colliderType;
		}

		// Token: 0x020014A0 RID: 5280
		[CompilerGenerated]
		private sealed class Class1103
		{
			// Token: 0x06007158 RID: 29016 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04007826 RID: 30758
			public LootableContainer container;

			// Token: 0x04007827 RID: 30759
			public Player player_0;
		}

		// Token: 0x020014A1 RID: 5281
		[CompilerGenerated]
		private sealed class Class1104
		{
			// Token: 0x06007159 RID: 29017 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04007828 RID: 30760
			public Player player_0;

			// Token: 0x04007829 RID: 30761
			public bool onCorpse;
		}

		// Token: 0x020014A2 RID: 5282
		[CompilerGenerated]
		private sealed class Class1105
		{
			// Token: 0x0600715A RID: 29018 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400782A RID: 30762
			public Player player_0;

			// Token: 0x0400782B RID: 30763
			public int count;
		}

		// Token: 0x020014A3 RID: 5283
		[CompilerGenerated]
		private sealed class Class1106
		{
			// Token: 0x0600715B RID: 29019 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400782C RID: 30764
			public Player player_0;

			// Token: 0x0400782D RID: 30765
			public int count;
		}

		// Token: 0x020014A4 RID: 5284
		[CompilerGenerated]
		private sealed class Class1107
		{
			// Token: 0x0600715C RID: 29020 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400782E RID: 30766
			public Player player_0;

			// Token: 0x0400782F RID: 30767
			public float diff;
		}

		// Token: 0x020014A5 RID: 5285
		[CompilerGenerated]
		private sealed class Class1108
		{
			// Token: 0x0600715D RID: 29021 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04007830 RID: 30768
			public Player player_0;

			// Token: 0x04007831 RID: 30769
			public float damage;
		}

		// Token: 0x020014A6 RID: 5286
		[CompilerGenerated]
		private sealed class Class1109
		{
			// Token: 0x0600715E RID: 29022 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04007832 RID: 30770
			public Player player_0;

			// Token: 0x04007833 RID: 30771
			public float diff;
		}

		// Token: 0x020014A8 RID: 5288
		[CompilerGenerated]
		private sealed class Class1111
		{
			// Token: 0x06007163 RID: 29027 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04007837 RID: 30775
			public float distance;

			// Token: 0x04007838 RID: 30776
			public Player player_0;
		}

		// Token: 0x020014A9 RID: 5289
		[CompilerGenerated]
		private sealed class Class1112
		{
			// Token: 0x06007164 RID: 29028 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04007839 RID: 30777
			public float distance;

			// Token: 0x0400783A RID: 30778
			public Player player_0;
		}
	}
}
