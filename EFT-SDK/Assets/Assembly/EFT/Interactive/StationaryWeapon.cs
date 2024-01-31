using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.Animations;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.Serialization;

namespace EFT.Interactive
{
	// Token: 0x02002799 RID: 10137
	public class StationaryWeapon : InteractableObject, GInterface26, GInterface352
	{
		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x0600CAED RID: 51949 RVA: 0x00002050 File Offset: 0x00000250
		public string OperatorId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x0600CAEE RID: 51950 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CAEF RID: 51951 RVA: 0x00002050 File Offset: 0x00000250
		public string IdEditable
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

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x0600CAF0 RID: 51952 RVA: 0x00002050 File Offset: 0x00000250
		public GameObject GameObject
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x0600CAF1 RID: 51953 RVA: 0x00002050 File Offset: 0x00000250
		public string TypeKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x0600CAF2 RID: 51954 RVA: 0x00002050 File Offset: 0x00000250
		public string Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x0600CAF3 RID: 51955 RVA: 0x00002050 File Offset: 0x00000250
		public Item Item
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x0600CAF4 RID: 51956 RVA: 0x00002050 File Offset: 0x00000250
		public float Pitch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x0600CAF5 RID: 51957 RVA: 0x00002050 File Offset: 0x00000250
		public float Yaw
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x0600CAF6 RID: 51958 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 Orientation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x0600CAF7 RID: 51959 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 PitchLimit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x0600CAF8 RID: 51960 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 YawLimit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x0600CAF9 RID: 51961 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 OperatorPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x0600CAFA RID: 51962 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CAFB RID: 51963 RVA: 0x00002050 File Offset: 0x00000250
		public int ObserverMagazineAmmoCount
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

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x0600CAFC RID: 51964 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CAFD RID: 51965 RVA: 0x00002050 File Offset: 0x00000250
		public bool Locked
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

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x0600CAFE RID: 51966 RVA: 0x00002050 File Offset: 0x00000250
		public EDoorState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CAFF RID: 51967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LootPointParameters AsLootPointParameters()
		{
			throw null;
		}

		// Token: 0x0600CB00 RID: 51968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(TraderControllerClass itemController)
		{
			throw null;
		}

		// Token: 0x0600CB01 RID: 51969 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualUpdate(Vector3 position, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x0600CB02 RID: 51970 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateJoints()
		{
			throw null;
		}

		// Token: 0x0600CB03 RID: 51971 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600CB04 RID: 51972 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600CB05 RID: 51973 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600CB06 RID: 51974 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool isVisible)
		{
			throw null;
		}

		// Token: 0x0600CB07 RID: 51975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WorldInteractiveObject.GStruct385 GetInteractionParameters()
		{
			throw null;
		}

		// Token: 0x0600CB08 RID: 51976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide(bool isAI)
		{
			throw null;
		}

		// Token: 0x0600CB09 RID: 51977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			throw null;
		}

		// Token: 0x0600CB0A RID: 51978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_2()
		{
			throw null;
		}

		// Token: 0x0600CB0B RID: 51979 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Align to ground")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AlignToGround()
		{
			throw null;
		}

		// Token: 0x0600CB0C RID: 51980 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ObservedShot()
		{
			throw null;
		}

		// Token: 0x0600CB0D RID: 51981 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitMagazine()
		{
			throw null;
		}

		// Token: 0x0600CB0E RID: 51982 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Shot()
		{
			throw null;
		}

		// Token: 0x0600CB0F RID: 51983 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Unlock(string profileId)
		{
			throw null;
		}

		// Token: 0x0600CB10 RID: 51984 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOperator(string visitorId, bool isAI = false)
		{
			throw null;
		}

		// Token: 0x0600CB11 RID: 51985 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsOperator(string profileId)
		{
			throw null;
		}

		// Token: 0x0600CB12 RID: 51986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsAvailable(string profileId)
		{
			throw null;
		}

		// Token: 0x0600CB13 RID: 51987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x0600CB14 RID: 51988 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPivots(TransformLinks hierarchy)
		{
			throw null;
		}

		// Token: 0x0600CB15 RID: 51989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRotation()
		{
			throw null;
		}

		// Token: 0x0600CB16 RID: 51990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetMagazineCount()
		{
			throw null;
		}

		// Token: 0x0600CB17 RID: 51991 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Transform method_3()
		{
			throw null;
		}

		// Token: 0x0400CB08 RID: 51976
		private const int BREAK_CHAIN_AMOUNT = 20;

		// Token: 0x0400CB09 RID: 51977
		[SerializeField]
		private string _id;

		// Token: 0x0400CB0A RID: 51978
		[SerializeField]
		private GameObject[] _gameObjectsWithRenderers;

		// Token: 0x0400CB0B RID: 51979
		[FormerlySerializedAs("BeltPivotChamber")]
		[SerializeField]
		private Transform _beltPivotChamber;

		// Token: 0x0400CB0C RID: 51980
		[FormerlySerializedAs("BetlPivotMagazine")]
		[SerializeField]
		private Transform _beltPivotMagazine;

		// Token: 0x0400CB0D RID: 51981
		[SerializeField]
		private Transform _beltEmptyPivotChamber;

		// Token: 0x0400CB0E RID: 51982
		[SerializeField]
		private Vector2 _initialOrientation;

		// Token: 0x0400CB0F RID: 51983
		[SerializeField]
		private Vector2 _pitchLimit;

		// Token: 0x0400CB10 RID: 51984
		[SerializeField]
		private Vector2 _yawLimit;

		// Token: 0x0400CB11 RID: 51985
		[SerializeField]
		private MagVisualController _magController;

		// Token: 0x0400CB12 RID: 51986
		[SerializeField]
		private Transform _debugViews;

		// Token: 0x0400CB13 RID: 51987
		[SerializeField]
		private Transform _collidersToCut;

		// Token: 0x0400CB14 RID: 51988
		public string Template;

		// Token: 0x0400CB15 RID: 51989
		public StationaryWeapon.EStationaryAnimationType Animation;

		// Token: 0x0400CB16 RID: 51990
		public Transform OperatorTransform;

		// Token: 0x0400CB17 RID: 51991
		public Transform Hinge;

		// Token: 0x0400CB18 RID: 51992
		public Transform TripodView;

		// Token: 0x0400CB19 RID: 51993
		public Transform TripodAnchor;

		// Token: 0x0400CB1A RID: 51994
		public Transform WeaponTransform;

		// Token: 0x0400CB1B RID: 51995
		public float PitchToleranceUp;

		// Token: 0x0400CB1C RID: 51996
		public float PitchToleranceDown;

		// Token: 0x0400CB1D RID: 51997
		public float YawTolerance;

		// Token: 0x0400CB1E RID: 51998
		public TraderControllerClass ItemController;

		// Token: 0x0400CB1F RID: 51999
		public WeaponMachinery Machinery;

		// Token: 0x0400CB20 RID: 52000
		public MgBelt Belt;

		// Token: 0x0400CB21 RID: 52001
		public MgBelt BeltEmpty;

		// Token: 0x0400CB22 RID: 52002
		private Coroutine _resetCoroutine;

		// Token: 0x0400CB23 RID: 52003
		private Transform _cachedTransform;

		// Token: 0x0400CB24 RID: 52004
		[SerializeField]
		private FollowerCullingObject _cullingObject;

		// Token: 0x0400CB25 RID: 52005
		private string _operatorId;

		// Token: 0x0400CB26 RID: 52006
		private Vector3 _initialWeaponPosition;

		// Token: 0x0400CB27 RID: 52007
		private Quaternion _initialWeaponRotation;

		// Token: 0x0200279A RID: 10138
		public enum EStationaryAnimationType
		{
			// Token: 0x0400CB2B RID: 52011
			UtesSit,
			// Token: 0x0400CB2C RID: 52012
			UtesStand,
			// Token: 0x0400CB2D RID: 52013
			AGS_17
		}
	}
}
