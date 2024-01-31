using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.AssetsManager;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.AI;

namespace EFT.Interactive
{
	// Token: 0x020027A6 RID: 10150
	public class WorldInteractiveObject : InteractableObject, GInterface352
	{
		// Token: 0x140002D9 RID: 729
		// (add) Token: 0x0600CB4E RID: 52046 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600CB4F RID: 52047 RVA: 0x00002050 File Offset: 0x00000250
		public event GDelegate73 OnDoorStateChanged
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

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x0600CB50 RID: 52048 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CB51 RID: 52049 RVA: 0x00002050 File Offset: 0x00000250
		public IPlayer InteractingPlayer
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

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x0600CB52 RID: 52050 RVA: 0x00002050 File Offset: 0x00000250
		public bool ForceLocalInteraction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x0600CB53 RID: 52051 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CB54 RID: 52052 RVA: 0x00002050 File Offset: 0x00000250
		string GInterface352.IdEditable
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

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x0600CB55 RID: 52053 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CB56 RID: 52054 RVA: 0x00002050 File Offset: 0x00000250
		public int NetId
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

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x0600CB57 RID: 52055 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CB58 RID: 52056 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float CurrentAngle
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

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x0600CB59 RID: 52057 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CB5A RID: 52058 RVA: 0x00002050 File Offset: 0x00000250
		public virtual EDoorState DoorState
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

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x0600CB5B RID: 52059 RVA: 0x00002050 File Offset: 0x00000250
		GameObject GInterface352.GameObject
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x0600CB5C RID: 52060 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float AngleSyncForSync
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x0600CB5D RID: 52061 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float MaxAllowedAngleDesync
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x0600CB5E RID: 52062 RVA: 0x00002050 File Offset: 0x00000250
		public virtual string TypeKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x0600CB5F RID: 52063 RVA: 0x00002050 File Offset: 0x00000250
		public virtual AnimationCurve ProgressCurve
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x0600CB60 RID: 52064 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float LockDistance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x0600CB61 RID: 52065 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CB62 RID: 52066 RVA: 0x00002050 File Offset: 0x00000250
		public Collider Collider
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

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x0600CB63 RID: 52067 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CB64 RID: 52068 RVA: 0x00002050 File Offset: 0x00000250
		public EDoorState FallbackState
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

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x0600CB65 RID: 52069 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CB66 RID: 52070 RVA: 0x00002050 File Offset: 0x00000250
		public EDoorState InitialDoorState
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

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x0600CB67 RID: 52071 RVA: 0x00002050 File Offset: 0x00000250
		public Transform Handle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CB68 RID: 52072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600CB69 RID: 52073 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void DoorStateChanged(EDoorState newState)
		{
			throw null;
		}

		// Token: 0x0600CB6A RID: 52074 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnReturnToPool(AssetPoolObject assetPoolObject)
		{
			throw null;
		}

		// Token: 0x0600CB6B RID: 52075 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual GripPose GetClosestGrip(Vector3 yourPosition)
		{
			throw null;
		}

		// Token: 0x0600CB6C RID: 52076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Vector3 GetInteractionPosition(Vector3 yourPosition)
		{
			throw null;
		}

		// Token: 0x0600CB6D RID: 52077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LockForInteraction()
		{
			throw null;
		}

		// Token: 0x0600CB6E RID: 52078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetInitialSyncState(WorldInteractiveObject.GStruct384 info)
		{
			throw null;
		}

		// Token: 0x0600CB6F RID: 52079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SyncInteractState(WorldInteractiveObject.GStruct384 info)
		{
			throw null;
		}

		// Token: 0x0600CB70 RID: 52080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(float syncAngle, EDoorState state)
		{
			throw null;
		}

		// Token: 0x0600CB71 RID: 52081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool CanStartInteraction(EDoorState state, bool logFalse = false)
		{
			throw null;
		}

		// Token: 0x0600CB72 RID: 52082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(EDoorState state, bool force = false)
		{
			throw null;
		}

		// Token: 0x0600CB73 RID: 52083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InitializeSmoothOpenInteraction(EDoorState state, bool confirmed = false)
		{
			throw null;
		}

		// Token: 0x0600CB74 RID: 52084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600CB75 RID: 52085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Quaternion GetDoorRotation(float currentAngle)
		{
			throw null;
		}

		// Token: 0x0600CB76 RID: 52086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 GetRotationAxis(WorldInteractiveObject.EDoorAxis doorAxis, Transform objectTransform)
		{
			throw null;
		}

		// Token: 0x0600CB77 RID: 52087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void PlaySound(EDoorState state)
		{
			throw null;
		}

		// Token: 0x0600CB78 RID: 52088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1f)
		{
			throw null;
		}

		// Token: 0x0600CB79 RID: 52089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void PlayShut()
		{
			throw null;
		}

		// Token: 0x0600CB7A RID: 52090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual float GetAngle(EDoorState state)
		{
			throw null;
		}

		// Token: 0x0600CB7B RID: 52091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetInitAngle(EDoorState state)
		{
			throw null;
		}

		// Token: 0x0600CB7C RID: 52092 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x0600CB7D RID: 52093 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual WorldInteractiveObject.GStruct385 GetInteractionParameters(Vector3 yourPosition)
		{
			throw null;
		}

		// Token: 0x0600CB7E RID: 52094 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetUser(Player player)
		{
			throw null;
		}

		// Token: 0x0600CB7F RID: 52095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Interact(InteractionResult interactionResult)
		{
			throw null;
		}

		// Token: 0x0600CB80 RID: 52096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Lock()
		{
			throw null;
		}

		// Token: 0x0600CB81 RID: 52097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Unlock()
		{
			throw null;
		}

		// Token: 0x0600CB82 RID: 52098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual IEnumerator UnlockCoroutine()
		{
			throw null;
		}

		// Token: 0x0600CB83 RID: 52099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Open()
		{
			throw null;
		}

		// Token: 0x0600CB84 RID: 52100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Close()
		{
			throw null;
		}

		// Token: 0x0600CB85 RID: 52101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ForceCloseLocalDoor(bool playSound)
		{
			throw null;
		}

		// Token: 0x0600CB86 RID: 52102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Vector3 GetViewDirection(Vector3 position)
		{
			throw null;
		}

		// Token: 0x0600CB87 RID: 52103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFromStatusInfo(WorldInteractiveObject.GStruct384 info)
		{
			throw null;
		}

		// Token: 0x0600CB88 RID: 52104 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsInteractionSuitsCurrentState(EInteractionType interaction)
		{
			throw null;
		}

		// Token: 0x0600CB89 RID: 52105 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual WorldInteractiveObject.GStruct384 GetStatusInfo(bool solidState = false)
		{
			throw null;
		}

		// Token: 0x0600CB8A RID: 52106 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual GStruct415<GClass2964> UnlockOperation(KeyComponent key, Player player)
		{
			throw null;
		}

		// Token: 0x0400CB6C RID: 52076
		public static bool InteractionShouldBeConfirmed;

		// Token: 0x0400CB6D RID: 52077
		private static int NextNetId;

		// Token: 0x0400CB6E RID: 52078
		private const float MAX_APPROPRIATE_STATE_CHANGE_DELTA = 1f;

		// Token: 0x0400CB6F RID: 52079
		private const float MAX_ALLOWED_ANGLE_DESYNC = 20f;

		// Token: 0x0400CB70 RID: 52080
		private const float ANGLE_SYNC_FOR_SYNC = 30f;

		// Token: 0x0400CB71 RID: 52081
		private const int MAX_SMOOTH_INTERACT_STEPS = 1000;

		// Token: 0x0400CB72 RID: 52082
		private const float LOCK_DISTANCE = 0.8f;

		// Token: 0x0400CB73 RID: 52083
		private const float PIVOT_2_LOCK = 0.1f;

		// Token: 0x0400CB74 RID: 52084
		public EDoorState Snap;

		// Token: 0x0400CB75 RID: 52085
		public string KeyId;

		// Token: 0x0400CB76 RID: 52086
		public string Id;

		// Token: 0x0400CB77 RID: 52087
		[SerializeField]
		protected float _currentAngle;

		// Token: 0x0400CB78 RID: 52088
		public Vector3 interactPosition1;

		// Token: 0x0400CB79 RID: 52089
		public Vector3 interactPosition2;

		// Token: 0x0400CB7A RID: 52090
		public Vector3 viewTarget1;

		// Token: 0x0400CB7B RID: 52091
		public DoorHandle LockHandle;

		// Token: 0x0400CB7C RID: 52092
		public float OpenAngle;

		// Token: 0x0400CB7D RID: 52093
		public float CloseAngle;

		// Token: 0x0400CB7E RID: 52094
		public WorldInteractiveObject.EDoorAxis DoorAxis;

		// Token: 0x0400CB7F RID: 52095
		public WorldInteractiveObject.EDoorAxis DoorForward;

		// Token: 0x0400CB80 RID: 52096
		[Header("Animations")]
		public bool interactWithoutAnimation;

		// Token: 0x0400CB81 RID: 52097
		public int PushID;

		// Token: 0x0400CB82 RID: 52098
		public int CloseID;

		// Token: 0x0400CB83 RID: 52099
		public AudioClip[] ShutSound;

		// Token: 0x0400CB84 RID: 52100
		public AudioClip[] SqueakSound;

		// Token: 0x0400CB85 RID: 52101
		public AudioClip[] OpenSound;

		// Token: 0x0400CB86 RID: 52102
		public float ShutShift;

		// Token: 0x0400CB87 RID: 52103
		public NavMeshObstacle Obstacle;

		// Token: 0x0400CB88 RID: 52104
		[SerializeField]
		protected EDoorState _doorState;

		// Token: 0x0400CB89 RID: 52105
		protected WorldInteractiveObject.InteractionState _interaction;

		// Token: 0x0400CB8A RID: 52106
		protected WorldInteractiveObject.InteractionState _previousInteraction;

		// Token: 0x0400CB8B RID: 52107
		[SerializeField]
		protected DoorHandle _handle;

		// Token: 0x0400CB8C RID: 52108
		protected GripPose[] Grips;

		// Token: 0x0400CB8D RID: 52109
		[SerializeField]
		private bool _forceLocalInteraction;

		// Token: 0x0400CB8E RID: 52110
		[Space(10f)]
		[Header("Actions")]
		public bool Operatable;

		// Token: 0x0400CB8F RID: 52111
		private int _netId;

		// Token: 0x0400CB90 RID: 52112
		protected bool _forceSync;

		// Token: 0x0400CB91 RID: 52113
		private bool _currentAngleChanged;

		// Token: 0x0400CB92 RID: 52114
		private EDoorState _syncState;

		// Token: 0x0400CB93 RID: 52115
		private float _syncAngle;

		// Token: 0x0400CB94 RID: 52116
		protected bool _shutPlayed;

		// Token: 0x020027A7 RID: 10151
		protected class InteractionState
		{
			// Token: 0x17002444 RID: 9284
			// (get) Token: 0x0600CB8B RID: 52107 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600CB8C RID: 52108 RVA: 0x00002050 File Offset: 0x00000250
			public EDoorState ResultState
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

			// Token: 0x17002445 RID: 9285
			// (get) Token: 0x0600CB8D RID: 52109 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600CB8E RID: 52110 RVA: 0x00002050 File Offset: 0x00000250
			public bool Break
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

			// Token: 0x17002446 RID: 9286
			// (get) Token: 0x0600CB8F RID: 52111 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600CB90 RID: 52112 RVA: 0x00002050 File Offset: 0x00000250
			public float ResultAngle
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

			// Token: 0x17002447 RID: 9287
			// (get) Token: 0x0600CB91 RID: 52113 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600CB92 RID: 52114 RVA: 0x00002050 File Offset: 0x00000250
			public float ProgressTime
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

			// Token: 0x17002448 RID: 9288
			// (get) Token: 0x0600CB93 RID: 52115 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600CB94 RID: 52116 RVA: 0x00002050 File Offset: 0x00000250
			public float Duration
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

			// Token: 0x17002449 RID: 9289
			// (get) Token: 0x0600CB95 RID: 52117 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600CB96 RID: 52118 RVA: 0x00002050 File Offset: 0x00000250
			public float Speed
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

			// Token: 0x1700244A RID: 9290
			// (get) Token: 0x0600CB97 RID: 52119 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600CB98 RID: 52120 RVA: 0x00002050 File Offset: 0x00000250
			public float StartTime
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

			// Token: 0x1700244B RID: 9291
			// (get) Token: 0x0600CB99 RID: 52121 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600CB9A RID: 52122 RVA: 0x00002050 File Offset: 0x00000250
			public float EndTime
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

			// Token: 0x1700244C RID: 9292
			// (get) Token: 0x0600CB9B RID: 52123 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600CB9C RID: 52124 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsConfirmed
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

			// Token: 0x1700244D RID: 9293
			// (get) Token: 0x0600CB9D RID: 52125 RVA: 0x00002050 File Offset: 0x00000250
			public bool TimeIsOver
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700244E RID: 9294
			// (get) Token: 0x0600CB9E RID: 52126 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsInProgress
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700244F RID: 9295
			// (get) Token: 0x0600CB9F RID: 52127 RVA: 0x00002050 File Offset: 0x00000250
			public float CurrentAngle
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002450 RID: 9296
			// (get) Token: 0x0600CBA0 RID: 52128 RVA: 0x00002050 File Offset: 0x00000250
			public bool NearToResult
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002451 RID: 9297
			// (get) Token: 0x0600CBA1 RID: 52129 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600CBA2 RID: 52130 RVA: 0x00002050 File Offset: 0x00000250
			public AnimationCurve ProgressCurve
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

			// Token: 0x0600CBA3 RID: 52131 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateTime(float deltaTime)
			{
				throw null;
			}

			// Token: 0x0600CBA4 RID: 52132 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SyncAngle(float angle)
			{
				throw null;
			}

			// Token: 0x0600CBA5 RID: 52133 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void InitSmoothOpen(EDoorState state, float initAngle, float resultAngle, AnimationCurve progressCurve = null, bool confirmed = false)
			{
				throw null;
			}

			// Token: 0x0600CBA6 RID: 52134 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetEndData(EDoorState state, AnimationCurve curve)
			{
				throw null;
			}

			// Token: 0x0600CBA7 RID: 52135 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetEndData(WorldInteractiveObject.InteractionState otherState)
			{
				throw null;
			}

			// Token: 0x0600CBA8 RID: 52136 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0400CB99 RID: 52121
			private float float_0;

			// Token: 0x0400CB9A RID: 52122
			private float float_1;

			// Token: 0x0400CB9B RID: 52123
			private AnimationCurve animationCurve_0;

			// Token: 0x0400CB9C RID: 52124
			[CompilerGenerated]
			private EDoorState edoorState_0;

			// Token: 0x0400CB9D RID: 52125
			[CompilerGenerated]
			private bool bool_0;

			// Token: 0x0400CB9E RID: 52126
			[CompilerGenerated]
			private float float_2;

			// Token: 0x0400CB9F RID: 52127
			[CompilerGenerated]
			private float float_3;

			// Token: 0x0400CBA0 RID: 52128
			[CompilerGenerated]
			private float float_4;

			// Token: 0x0400CBA1 RID: 52129
			[CompilerGenerated]
			private float float_5;

			// Token: 0x0400CBA2 RID: 52130
			[CompilerGenerated]
			private float float_6;

			// Token: 0x0400CBA3 RID: 52131
			[CompilerGenerated]
			private float float_7;

			// Token: 0x0400CBA4 RID: 52132
			[CompilerGenerated]
			private bool bool_1;
		}

		// Token: 0x020027A8 RID: 10152
		public enum EDoorAxis
		{
			// Token: 0x0400CBA6 RID: 52134
			X,
			// Token: 0x0400CBA7 RID: 52135
			Y,
			// Token: 0x0400CBA8 RID: 52136
			Z,
			// Token: 0x0400CBA9 RID: 52137
			XNegative,
			// Token: 0x0400CBAA RID: 52138
			YNegative,
			// Token: 0x0400CBAB RID: 52139
			ZNegative
		}

		// Token: 0x020027A9 RID: 10153
		public enum EInteractionAction
		{
			// Token: 0x0400CBAD RID: 52141
			Pull,
			// Token: 0x0400CBAE RID: 52142
			Push
		}

		// Token: 0x020027AA RID: 10154
		public enum ERotationInterpolationMode
		{
			// Token: 0x0400CBB0 RID: 52144
			ViewTarget,
			// Token: 0x0400CBB1 RID: 52145
			ViewTargetWithZeroPitch,
			// Token: 0x0400CBB2 RID: 52146
			ViewTargetAsOrientation
		}

		// Token: 0x020027AB RID: 10155
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct384
		{
			// Token: 0x17002452 RID: 9298
			// (get) Token: 0x0600CBA9 RID: 52137 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600CBAA RID: 52138 RVA: 0x00002050 File Offset: 0x00000250
			public int NetId
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

			// Token: 0x0400CBB3 RID: 52147
			public string Id;

			// Token: 0x0400CBB4 RID: 52148
			public byte State;

			// Token: 0x0400CBB5 RID: 52149
			public int Angle;

			// Token: 0x0400CBB6 RID: 52150
			public bool Updated;

			// Token: 0x0400CBB7 RID: 52151
			public bool IsBroken;

			// Token: 0x0400CBB8 RID: 52152
			[CompilerGenerated]
			private int int_0;
		}

		// Token: 0x020027AC RID: 10156
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct385
		{
			// Token: 0x0400CBB9 RID: 52153
			public EDoorState InitialState;

			// Token: 0x0400CBBA RID: 52154
			public WorldInteractiveObject.EInteractionAction Action;

			// Token: 0x0400CBBB RID: 52155
			public Vector3 ViewTarget;

			// Token: 0x0400CBBC RID: 52156
			public Vector3 InteractionPosition;

			// Token: 0x0400CBBD RID: 52157
			public GripPose Grip;

			// Token: 0x0400CBBE RID: 52158
			public int AnimationId;

			// Token: 0x0400CBBF RID: 52159
			public bool Snap;

			// Token: 0x0400CBC0 RID: 52160
			public bool Sit;

			// Token: 0x0400CBC1 RID: 52161
			public WorldInteractiveObject.ERotationInterpolationMode RotationMode;

			// Token: 0x0400CBC2 RID: 52162
			public bool BlockChangePosLevel;
		}

		// Token: 0x020027AD RID: 10157
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2292
		{
			// Token: 0x0600CBAB RID: 52139 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Collider c)
			{
				throw null;
			}

			// Token: 0x0600CBAC RID: 52140 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Keyframe k)
			{
				throw null;
			}

			// Token: 0x0400CBC3 RID: 52163
			public static readonly WorldInteractiveObject.Class2292 class2292_0;

			// Token: 0x0400CBC4 RID: 52164
			public static Func<Collider, bool> func_0;

			// Token: 0x0400CBC5 RID: 52165
			public static Func<Keyframe, bool> func_1;
		}

		// Token: 0x020027AF RID: 10159
		[CompilerGenerated]
		private sealed class Class2294
		{
			// Token: 0x0600CBB1 RID: 52145 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400CBCB RID: 52171
			public InteractionResult interactionResult;

			// Token: 0x0400CBCC RID: 52172
			public WorldInteractiveObject worldInteractiveObject_0;
		}
	}
}
