using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.CameraControl;
using EFT.Game.Spawning;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using EFT.PrefabSettings;
using UnityEngine;

namespace EFT
{
	// Token: 0x0200118F RID: 4495
	public sealed class GamePerson : MonoBehaviour, IPlayer
	{
		// Token: 0x06005F20 RID: 24352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GamePerson Create(Vector3 position, Quaternion rotation, int id, string profileId, ESpawnCategory category, EPlayerSide side, string name = null, string groupId = null, string infiltration = null, string botZoneName = null)
		{
			throw null;
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GamePerson Create(GClass1299 args)
		{
			throw null;
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06005F22 RID: 24354 RVA: 0x00002050 File Offset: 0x00000250
		public int Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06005F23 RID: 24355 RVA: 0x00002050 File Offset: 0x00000250
		public string ProfileId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06005F24 RID: 24356 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005F25 RID: 24357 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerSide Side
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

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06005F26 RID: 24358 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAI
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005F27 RID: 24359 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeserializeFromServer(byte channelId, GInterface76 reader)
		{
			throw null;
		}

		// Token: 0x06005F28 RID: 24360 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RadioTransmitterRecodableComponent FindRadioTransmitter()
		{
			throw null;
		}

		// Token: 0x06005F29 RID: 24361 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass2712 FindCultistAmulet()
		{
			throw null;
		}

		// Token: 0x1400010B RID: 267
		// (add) Token: 0x06005F2A RID: 24362 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005F2B RID: 24363 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06005F2C RID: 24364 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005F2D RID: 24365 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06005F2E RID: 24366 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005F2F RID: 24367 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06005F30 RID: 24368 RVA: 0x00002050 File Offset: 0x00000250
		public bool StateIsSuitableForHandInput
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInteractInHands(bool isInteracting, int animationId = 1)
		{
			throw null;
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlantItemLocalOnly(Item item, string zone)
		{
			throw null;
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateInteractionCast()
		{
			throw null;
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleFlareSuccessEvent(Vector3 position, FlareEventType eventType)
		{
			throw null;
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06005F35 RID: 24373 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 Rotation
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005F36 RID: 24374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight)
		{
			throw null;
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06005F37 RID: 24375 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Velocity
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06005F39 RID: 24377 RVA: 0x00002050 File Offset: 0x00000250
		public byte ChannelIndex
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06005F3A RID: 24378 RVA: 0x00002050 File Offset: 0x00000250
		public ICharacterController CharacterController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06005F3B RID: 24379 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerBody PlayerBody
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06005F3C RID: 24380 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsYourPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06005F3D RID: 24381 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005F3E RID: 24382 RVA: 0x00002050 File Offset: 0x00000250
		public ESpawnCategory Category
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

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06005F3F RID: 24383 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06005F40 RID: 24384 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 LookDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06005F41 RID: 24385 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005F42 RID: 24386 RVA: 0x00002050 File Offset: 0x00000250
		public string GroupId
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

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06005F43 RID: 24387 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005F44 RID: 24388 RVA: 0x00002050 File Offset: 0x00000250
		public string TeamId
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

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06005F45 RID: 24389 RVA: 0x00002050 File Offset: 0x00000250
		public string Infiltration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06005F46 RID: 24390 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform Transform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06005F47 RID: 24391 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform WeaponRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06005F48 RID: 24392 RVA: 0x00002050 File Offset: 0x00000250
		public IHealthController HealthController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06005F49 RID: 24393 RVA: 0x00002050 File Offset: 0x00000250
		public Profile Profile
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06005F4A RID: 24394 RVA: 0x00002050 File Offset: 0x00000250
		public Player GetPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06005F4B RID: 24395 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerBones PlayerBones
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06005F4C RID: 24396 RVA: 0x00002050 File Offset: 0x00000250
		public AIData AIData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06005F4D RID: 24397 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerLoyaltyData Loyalty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06005F4E RID: 24398 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<BodyPartType, EnemyPart> MainParts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06005F4F RID: 24399 RVA: 0x00002050 File Offset: 0x00000250
		public string AccountId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06005F50 RID: 24400 RVA: 0x00002050 File Offset: 0x00000250
		public Player.EUpdateMode ArmsUpdateMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06005F51 RID: 24401 RVA: 0x00002050 File Offset: 0x00000250
		public EUpdateQueue ArmsUpdateQueue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06005F52 RID: 24402 RVA: 0x00002050 File Offset: 0x00000250
		public ECameraType VisibleToCameraType
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06005F53 RID: 24403 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsVisibleToCamera
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IAnimator GetArmsAnimatorCommon()
		{
			throw null;
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetArmsAnimatorCommon(IAnimator animator)
		{
			throw null;
		}

		// Token: 0x04006960 RID: 26976
		[SerializeField]
		private int _id;

		// Token: 0x04006961 RID: 26977
		[SerializeField]
		private string _profileId;

		// Token: 0x04006962 RID: 26978
		[SerializeField]
		private ESpawnCategory _category;

		// Token: 0x04006963 RID: 26979
		[SerializeField]
		private EPlayerSide _side;

		// Token: 0x04006964 RID: 26980
		[SerializeField]
		private string _groupId;

		// Token: 0x04006965 RID: 26981
		[SerializeField]
		private string _teamId;

		// Token: 0x04006966 RID: 26982
		[SerializeField]
		private string _infiltration;

		// Token: 0x04006967 RID: 26983
		[SerializeField]
		private string _botZoneName;

		// Token: 0x04006968 RID: 26984
		[CompilerGenerated]
		private Action<IPlayer> action_0;

		// Token: 0x04006969 RID: 26985
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400696A RID: 26986
		[CompilerGenerated]
		private EPlayerBtrState eplayerBtrState_0;

		// Token: 0x0400696B RID: 26987
		[CompilerGenerated]
		private readonly Vector2 vector2_0;

		// Token: 0x0400696C RID: 26988
		[CompilerGenerated]
		private readonly Vector3 vector3_0;

		// Token: 0x0400696D RID: 26989
		[CompilerGenerated]
		private readonly byte byte_0;

		// Token: 0x0400696E RID: 26990
		[CompilerGenerated]
		private readonly ECameraType ecameraType_0;

		// Token: 0x0400696F RID: 26991
		[CompilerGenerated]
		private readonly bool bool_1;
	}
}
