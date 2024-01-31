using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Audio.Vehicles.BTR;
using Comfort.Common;
using EFT.Ballistics;
using EFT.NextObservedPlayer;
using EFT.Vehicle.Vehicles;
using UnityEngine;

namespace EFT.Vehicle
{
	// Token: 0x02002663 RID: 9827
	public sealed class BTRView : MonoBehaviour
	{
		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x0600C2F0 RID: 49904 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C2F1 RID: 49905 RVA: 0x00002050 File Offset: 0x00000250
		public float CurrentSpeed
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

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x0600C2F2 RID: 49906 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C2F3 RID: 49907 RVA: 0x00002050 File Offset: 0x00000250
		public float MoveSpeed
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

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x0600C2F4 RID: 49908 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C2F5 RID: 49909 RVA: 0x00002050 File Offset: 0x00000250
		public int TimeToEndPause
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

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x0600C2F6 RID: 49910 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C2F7 RID: 49911 RVA: 0x00002050 File Offset: 0x00000250
		public bool PlaceUpdated
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

		// Token: 0x140002C5 RID: 709
		// (add) Token: 0x0600C2F8 RID: 49912 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C2F9 RID: 49913 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<EBtrState> OnStateChanged
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

		// Token: 0x140002C6 RID: 710
		// (add) Token: 0x0600C2FA RID: 49914 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C2FB RID: 49915 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnCautionState
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

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x0600C2FC RID: 49916 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C2FD RID: 49917 RVA: 0x00002050 File Offset: 0x00000250
		public EBtrState BtrState
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

		// Token: 0x0600C2FE RID: 49918 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600C2FF RID: 49919 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600C300 RID: 49920 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x0600C301 RID: 49921 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600C302 RID: 49922 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600C303 RID: 49923 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x0600C304 RID: 49924 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600C305 RID: 49925 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitWheelsData(BackendConfigSettingsClass.BTRGlobalSettings btrGlobalSettings)
		{
			throw null;
		}

		// Token: 0x0600C306 RID: 49926 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600C307 RID: 49927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600C308 RID: 49928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Player player)
		{
			throw null;
		}

		// Token: 0x0600C309 RID: 49929 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600C30A RID: 49930 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(bool inRange)
		{
			throw null;
		}

		// Token: 0x0600C30B RID: 49931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SyncViewFromServer(BTRDataPacket packet)
		{
			throw null;
		}

		// Token: 0x0600C30C RID: 49932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenTransferItemsScreen()
		{
			throw null;
		}

		// Token: 0x0600C30D RID: 49933 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool[][] method_7()
		{
			throw null;
		}

		// Token: 0x0600C30E RID: 49934 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool[][] method_8(BTRSide relativeSide)
		{
			throw null;
		}

		// Token: 0x0600C30F RID: 49935 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private BTRSide method_9(byte sideId)
		{
			throw null;
		}

		// Token: 0x0600C310 RID: 49936 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte GetSideId(BTRSide side)
		{
			throw null;
		}

		// Token: 0x0600C311 RID: 49937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Interaction(Player player, PlayerInteractPacket packet)
		{
			throw null;
		}

		// Token: 0x0600C312 RID: 49938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Interaction(ObservedPlayerView player, GClass2218 interaction)
		{
			throw null;
		}

		// Token: 0x0600C313 RID: 49939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Interaction(ObservedPlayerView player, GClass2219 interaction)
		{
			throw null;
		}

		// Token: 0x0600C314 RID: 49940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private CancellationToken method_10(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600C315 RID: 49941 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_11(Player player, BTRSide side, byte placeId, bool fast)
		{
			throw null;
		}

		// Token: 0x0600C316 RID: 49942 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_12(ObservedPlayerView player, BTRSide side, byte placeId, bool fast)
		{
			throw null;
		}

		// Token: 0x0600C317 RID: 49943 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_13(Player player, BTRSide side, byte placeId, bool fast)
		{
			throw null;
		}

		// Token: 0x0600C318 RID: 49944 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_14(ObservedPlayerView player, BTRSide side, byte placeId, bool fast)
		{
			throw null;
		}

		// Token: 0x0600C319 RID: 49945 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_15(PlayerAnimator animator, bool fast, bool observed, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x0600C31A RID: 49946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_16(PlayerAnimator animator, bool fast, bool observed, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x0600C31B RID: 49947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_17(Player player)
		{
			throw null;
		}

		// Token: 0x0600C31C RID: 49948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(Player player)
		{
			throw null;
		}

		// Token: 0x0600C31D RID: 49949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19(Player player)
		{
			throw null;
		}

		// Token: 0x0600C31E RID: 49950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_20()
		{
			throw null;
		}

		// Token: 0x0400C4AB RID: 50347
		private const int MAX_SIDES = 2;

		// Token: 0x0400C4AC RID: 50348
		private const int APPROACH_DURATION_MS = 300;

		// Token: 0x0400C4AD RID: 50349
		private const float PLAYER_IN_RANGE_DISTANCE_SQR = 64f;

		// Token: 0x0400C4AE RID: 50350
		private const int TIME_TO_SHOW_TIMER_ON_STOP = 10;

		// Token: 0x0400C4AF RID: 50351
		private const int OBSERVED_SYNC_PERIOD_MS = 300;

		// Token: 0x0400C4B0 RID: 50352
		[SerializeField]
		private BTRSide[] _btrSides;

		// Token: 0x0400C4B1 RID: 50353
		[SerializeField]
		[Range(1f, 2f)]
		private float _goInLookElevation;

		// Token: 0x0400C4B2 RID: 50354
		[SerializeField]
		[Range(1f, 2f)]
		private float _goOutLookElevation;

		// Token: 0x0400C4B3 RID: 50355
		[SerializeField]
		private int _goInDurationMs;

		// Token: 0x0400C4B4 RID: 50356
		[SerializeField]
		private int _goOutDurationMs;

		// Token: 0x0400C4B5 RID: 50357
		[SerializeField]
		private BtrSoundController _soundController;

		// Token: 0x0400C4B6 RID: 50358
		[SerializeField]
		private BallisticColliderComposer _ballisticCollider;

		// Token: 0x0400C4B7 RID: 50359
		private GClass2986 _hitReactor;

		// Token: 0x0400C4B8 RID: 50360
		private readonly Dictionary<IPlayer, CancellationTokenSource> _playerTokenSources;

		// Token: 0x0400C4B9 RID: 50361
		public BTRTurretView turret;

		// Token: 0x0400C4BF RID: 50367
		public float moveLerpValue;

		// Token: 0x0400C4C0 RID: 50368
		private EBtrState _btrState;

		// Token: 0x0400C4C1 RID: 50369
		private bool _isPlayerInRange;

		// Token: 0x0400C4C2 RID: 50370
		private EBtrState _lastBtrStateInRange;

		// Token: 0x0400C4C3 RID: 50371
		private EPlayerBtrState _lastPlayerStateInRange;

		// Token: 0x0400C4C4 RID: 50372
		private BTRSide _lastRangedSide;

		// Token: 0x0400C4C5 RID: 50373
		public EVehicleRouteState RouteState;

		// Token: 0x0400C4C6 RID: 50374
		public EVehicleMoveDirection VehicleMoveDirection;

		// Token: 0x0400C4C7 RID: 50375
		private Vector3 _targetPosition;

		// Token: 0x0400C4C8 RID: 50376
		private Quaternion _targetRotation;

		// Token: 0x0400C4C9 RID: 50377
		private Vector3 _previousPosition;

		// Token: 0x0400C4CA RID: 50378
		public float moveFactorTrashold;

		// Token: 0x0400C4CB RID: 50379
		private Transform _cachedTransform;

		// Token: 0x0400C4CC RID: 50380
		private int _timeToEndPause;

		// Token: 0x0400C4CD RID: 50381
		private bool _needToNotify;

		// Token: 0x0400C4CE RID: 50382
		private int? _btrBotId;

		// Token: 0x0400C4CF RID: 50383
		public VehicleWheelsBase leftWheel1;

		// Token: 0x0400C4D0 RID: 50384
		public VehicleWheelsBase leftWheel2;

		// Token: 0x0400C4D1 RID: 50385
		public VehicleWheelsBase leftWheel3;

		// Token: 0x0400C4D2 RID: 50386
		public VehicleWheelsBase leftWheel4;

		// Token: 0x0400C4D3 RID: 50387
		public VehicleWheelsBase rightWheel1;

		// Token: 0x0400C4D4 RID: 50388
		public VehicleWheelsBase rightWheel2;

		// Token: 0x0400C4D5 RID: 50389
		public VehicleWheelsBase rightWheel3;

		// Token: 0x0400C4D6 RID: 50390
		public VehicleWheelsBase rightWheel4;

		// Token: 0x0200266B RID: 9835
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2198
		{
			// Token: 0x0600C32D RID: 49965 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface125> result)
			{
				throw null;
			}

			// Token: 0x0400C50B RID: 50443
			public static readonly BTRView.Class2198 class2198_0;

			// Token: 0x0400C50C RID: 50444
			public static Callback<GInterface125> callback_0;
		}
	}
}
