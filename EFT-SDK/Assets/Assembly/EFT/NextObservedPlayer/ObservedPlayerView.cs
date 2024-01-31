using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.CameraControl;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using EFT.PrefabSettings;
using RootMotion.FinalIK;
using UnityEngine;

namespace EFT.NextObservedPlayer
{
	// Token: 0x02002046 RID: 8262
	public class ObservedPlayerView : MonoBehaviour, IPlayer
	{
		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x0600AB56 RID: 43862 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB57 RID: 43863 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerSide Side
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

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x0600AB58 RID: 43864 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB59 RID: 43865 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x0600AB5A RID: 43866 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB5B RID: 43867 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x0600AB5C RID: 43868 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB5D RID: 43869 RVA: 0x00002050 File Offset: 0x00000250
		public float RemoteTime
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

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x0600AB5E RID: 43870 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB5F RID: 43871 RVA: 0x00002050 File Offset: 0x00000250
		public string GroupId
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

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x0600AB60 RID: 43872 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB61 RID: 43873 RVA: 0x00002050 File Offset: 0x00000250
		public string TeamId
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

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x0600AB62 RID: 43874 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 LookDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x0600AB63 RID: 43875 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB64 RID: 43876 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x0600AB65 RID: 43877 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform Transform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x0600AB66 RID: 43878 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform WeaponRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x0600AB67 RID: 43879 RVA: 0x00002050 File Offset: 0x00000250
		public IHealthController HealthController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x0600AB68 RID: 43880 RVA: 0x00002050 File Offset: 0x00000250
		public Profile Profile
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x0600AB69 RID: 43881 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB6A RID: 43882 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x0600AB6B RID: 43883 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB6C RID: 43884 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x0600AB6D RID: 43885 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAI
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x0600AB6E RID: 43886 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB6F RID: 43887 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x0600AB70 RID: 43888 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB71 RID: 43889 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x0600AB72 RID: 43890 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB73 RID: 43891 RVA: 0x00002050 File Offset: 0x00000250
		public string NickName
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

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x0600AB74 RID: 43892 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB75 RID: 43893 RVA: 0x00002050 File Offset: 0x00000250
		public string AccountId
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

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x0600AB76 RID: 43894 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB77 RID: 43895 RVA: 0x00002050 File Offset: 0x00000250
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
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x0600AB78 RID: 43896 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsYourPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x0600AB79 RID: 43897 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB7A RID: 43898 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerBody PlayerBody
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

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x0600AB7B RID: 43899 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsVisible
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x0600AB7C RID: 43900 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB7D RID: 43901 RVA: 0x00002050 File Offset: 0x00000250
		public ICharacterController CharacterController
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

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x0600AB7E RID: 43902 RVA: 0x00002050 File Offset: 0x00000250
		public byte ChannelIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600AB7F RID: 43903 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeserializeFromServer(byte channelId, GInterface76 reader)
		{
			throw null;
		}

		// Token: 0x0600AB80 RID: 43904 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RadioTransmitterRecodableComponent FindRadioTransmitter()
		{
			throw null;
		}

		// Token: 0x0600AB81 RID: 43905 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass2712 FindCultistAmulet()
		{
			throw null;
		}

		// Token: 0x0600AB82 RID: 43906 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IAnimator GetBodyAnimatorCommon()
		{
			throw null;
		}

		// Token: 0x0600AB83 RID: 43907 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IAnimator GetArmsAnimatorCommon()
		{
			throw null;
		}

		// Token: 0x0600AB84 RID: 43908 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetArmsAnimatorCommon(IAnimator animator)
		{
			throw null;
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x0600AB85 RID: 43909 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB86 RID: 43910 RVA: 0x00002050 File Offset: 0x00000250
		public FirearmsAnimator FirearmsAnimator
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

		// Token: 0x14000230 RID: 560
		// (add) Token: 0x0600AB87 RID: 43911 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600AB88 RID: 43912 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x0600AB89 RID: 43913 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB8A RID: 43914 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x0600AB8B RID: 43915 RVA: 0x00002050 File Offset: 0x00000250
		public bool StateIsSuitableForHandInput
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600AB8C RID: 43916 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInteractInHands(bool isInteracting, int animationId = 1)
		{
			throw null;
		}

		// Token: 0x0600AB8D RID: 43917 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlantItemLocalOnly(Item item, string zone)
		{
			throw null;
		}

		// Token: 0x0600AB8E RID: 43918 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateInteractionCast()
		{
			throw null;
		}

		// Token: 0x0600AB8F RID: 43919 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleFlareSuccessEvent(Vector3 position, FlareEventType eventType)
		{
			throw null;
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x0600AB90 RID: 43920 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 Rotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600AB91 RID: 43921 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight)
		{
			throw null;
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x0600AB92 RID: 43922 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Velocity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x0600AB93 RID: 43923 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB94 RID: 43924 RVA: 0x00002050 File Offset: 0x00000250
		public GClass2358 ObservedPlayerController
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

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x0600AB95 RID: 43925 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 PlayerColliderCenter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x0600AB96 RID: 43926 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB97 RID: 43927 RVA: 0x00002050 File Offset: 0x00000250
		public string Voice
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

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x0600AB98 RID: 43928 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB99 RID: 43929 RVA: 0x00002050 File Offset: 0x00000250
		public IAnimator BodyAnimator
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

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x0600AB9A RID: 43930 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB9B RID: 43931 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerAnimator PlayerAnimator
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

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x0600AB9C RID: 43932 RVA: 0x00002050 File Offset: 0x00000250
		public Ray InteractionRay
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x0600AB9D RID: 43933 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB9E RID: 43934 RVA: 0x00002050 File Offset: 0x00000250
		public Collider[] Colliders
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

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x0600AB9F RID: 43935 RVA: 0x00002050 File Offset: 0x00000250
		public HitReaction HitReaction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x0600ABA0 RID: 43936 RVA: 0x00002050 File Offset: 0x00000250
		public GClass2355 BundleAnimationBones
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x0600ABA1 RID: 43937 RVA: 0x00002050 File Offset: 0x00000250
		public Player.EUpdateMode ArmsUpdateMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x0600ABA2 RID: 43938 RVA: 0x00002050 File Offset: 0x00000250
		public EUpdateQueue ArmsUpdateQueue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x0600ABA3 RID: 43939 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ABA4 RID: 43940 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x0600ABA5 RID: 43941 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ABA6 RID: 43942 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x0600ABA7 RID: 43943 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TObservedPlayerView Create<TObservedPlayerView>(int playerId, GStruct275 message) where TObservedPlayerView : ObservedPlayerView
		{
			throw null;
		}

		// Token: 0x0600ABA8 RID: 43944 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initialization(GStruct275 message)
		{
			throw null;
		}

		// Token: 0x0600ABA9 RID: 43945 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetController(GClass2358 controller)
		{
			throw null;
		}

		// Token: 0x0600ABAA RID: 43946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600ABAB RID: 43947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateWeaponRoot()
		{
			throw null;
		}

		// Token: 0x0600ABAC RID: 43948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetWeaponRoot(Transform targetTransform)
		{
			throw null;
		}

		// Token: 0x0600ABAD RID: 43949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(float distance)
		{
			throw null;
		}

		// Token: 0x0600ABAE RID: 43950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute(GInterface218 command)
		{
			throw null;
		}

		// Token: 0x0600ABAF RID: 43951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GClass2216 command)
		{
			throw null;
		}

		// Token: 0x0600ABB0 RID: 43952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass2217 command)
		{
			throw null;
		}

		// Token: 0x0600ABB1 RID: 43953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMakingShot(GInterface320 weapon, Vector3 shotPosition)
		{
			throw null;
		}

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyDeath()
		{
			throw null;
		}

		// Token: 0x0600ABB3 RID: 43955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600ABB4 RID: 43956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(BodyPartCollider bodyPartCollider, bool includeChild)
		{
			throw null;
		}

		// Token: 0x0600ABB5 RID: 43957 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Animator animator)
		{
			throw null;
		}

		// Token: 0x0600ABB6 RID: 43958 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(WildSpawnType role)
		{
			throw null;
		}

		// Token: 0x0600ABB7 RID: 43959 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReactionOnShot(DamageInfo shot, EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Teleport(Vector3 position, bool onServerToo = false)
		{
			throw null;
		}

		// Token: 0x0600ABBA RID: 43962 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(GClass2242 setLeftStanceCommandMessage)
		{
			throw null;
		}

		// Token: 0x0600ABBB RID: 43963 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(GClass2243 setStationaryWeaponCommandMessage)
		{
			throw null;
		}

		// Token: 0x0600ABBC RID: 43964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_9(float cullingDistance)
		{
			throw null;
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x0600ABBD RID: 43965 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600ABBE RID: 43966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600ABBF RID: 43967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnregisterCulling()
		{
			throw null;
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAutocullVisibility(bool value)
		{
			throw null;
		}

		// Token: 0x0600ABC1 RID: 43969 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Transform method_11()
		{
			throw null;
		}

		// Token: 0x0400B234 RID: 45620
		[CompilerGenerated]
		private EPlayerSide eplayerSide_0;

		// Token: 0x0400B235 RID: 45621
		[CompilerGenerated]
		private EPlayerBtrState eplayerBtrState_0;

		// Token: 0x0400B236 RID: 45622
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400B237 RID: 45623
		[CompilerGenerated]
		private float float_0;

		// Token: 0x0400B238 RID: 45624
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400B239 RID: 45625
		[CompilerGenerated]
		private string string_1;

		// Token: 0x0400B23A RID: 45626
		[CompilerGenerated]
		private AIData aidata_0;

		// Token: 0x0400B23B RID: 45627
		[CompilerGenerated]
		private PlayerLoyaltyData playerLoyaltyData_0;

		// Token: 0x0400B23C RID: 45628
		[CompilerGenerated]
		private Dictionary<BodyPartType, EnemyPart> dictionary_0;

		// Token: 0x0400B23D RID: 45629
		[CompilerGenerated]
		private string string_2;

		// Token: 0x0400B23E RID: 45630
		[CompilerGenerated]
		private string string_3;

		// Token: 0x0400B23F RID: 45631
		[CompilerGenerated]
		private string string_4;

		// Token: 0x0400B240 RID: 45632
		[CompilerGenerated]
		private PlayerBones playerBones_0;

		// Token: 0x0400B241 RID: 45633
		[CompilerGenerated]
		private PlayerBody playerBody_0;

		// Token: 0x0400B242 RID: 45634
		[CompilerGenerated]
		private ICharacterController icharacterController_0;

		// Token: 0x0400B243 RID: 45635
		[CompilerGenerated]
		private FirearmsAnimator firearmsAnimator_0;

		// Token: 0x0400B244 RID: 45636
		[CompilerGenerated]
		private Action<IPlayer> action_0;

		// Token: 0x0400B245 RID: 45637
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400B246 RID: 45638
		[CompilerGenerated]
		private readonly bool bool_1;

		// Token: 0x0400B247 RID: 45639
		[CompilerGenerated]
		private GClass2358 gclass2358_0;

		// Token: 0x0400B248 RID: 45640
		[CompilerGenerated]
		private string string_5;

		// Token: 0x0400B249 RID: 45641
		[CompilerGenerated]
		private IAnimator ianimator_0;

		// Token: 0x0400B24A RID: 45642
		[CompilerGenerated]
		private PlayerAnimator playerAnimator_0;

		// Token: 0x0400B24B RID: 45643
		[CompilerGenerated]
		private Collider[] collider_0;

		// Token: 0x0400B24C RID: 45644
		[CompilerGenerated]
		private ECameraType ecameraType_0;

		// Token: 0x0400B24D RID: 45645
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x0400B24E RID: 45646
		private Transform transform_0;

		// Token: 0x0400B24F RID: 45647
		private bool bool_3;

		// Token: 0x0400B250 RID: 45648
		private byte byte_0;

		// Token: 0x0400B251 RID: 45649
		private IAnimator[] ianimator_1;

		// Token: 0x0400B252 RID: 45650
		private readonly List<GStruct53> list_0;

		// Token: 0x0400B253 RID: 45651
		private HitReaction hitReaction_0;

		// Token: 0x0400B254 RID: 45652
		private FullBodyBipedIK fullBodyBipedIK_0;

		// Token: 0x0400B255 RID: 45653
		private float float_1;

		// Token: 0x0400B256 RID: 45654
		private GClass2355 gclass2355_0;

		// Token: 0x0400B257 RID: 45655
		private bool bool_4;

		// Token: 0x0400B258 RID: 45656
		public GClass678 Physical;

		// Token: 0x0400B259 RID: 45657
		private const float float_2 = 0.6f;

		// Token: 0x0400B25A RID: 45658
		private const int int_1 = 3;

		// Token: 0x0400B25B RID: 45659
		private const int int_2 = 3;

		// Token: 0x0400B25C RID: 45660
		private FollowerCullingObject followerCullingObject_0;

		// Token: 0x0400B25D RID: 45661
		private List<DisablerCullingObject> list_1;

		// Token: 0x0400B25E RID: 45662
		private bool bool_5;
	}
}
