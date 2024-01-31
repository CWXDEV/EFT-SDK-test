using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EFT.NextObservedPlayer;
using UnityEngine;

namespace EFT.Vehicle
{
	// Token: 0x0200265D RID: 9821
	[DefaultExecutionOrder(1)]
	public class BTRSide : MonoBehaviour, GInterface102
	{
		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x0600C2BD RID: 49853 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C2BE RID: 49854 RVA: 0x00002050 File Offset: 0x00000250
		public BTRSide.EState State
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

		// Token: 0x140002C3 RID: 707
		// (add) Token: 0x0600C2BF RID: 49855 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C2C0 RID: 49856 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<BTRSide.EState, BTRSide.EState> OnStateChanged
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

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x0600C2C1 RID: 49857 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C2C2 RID: 49858 RVA: 0x00002050 File Offset: 0x00000250
		public BTRView BtrView
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

		// Token: 0x0600C2C3 RID: 49859 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(BTRView btrView)
		{
			throw null;
		}

		// Token: 0x0600C2C4 RID: 49860 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SyncStateFromServer(byte state, byte place0State, byte place1State)
		{
			throw null;
		}

		// Token: 0x0600C2C5 RID: 49861 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool[] SideInfo()
		{
			throw null;
		}

		// Token: 0x0600C2C6 RID: 49862 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetPlace(out byte placeId)
		{
			throw null;
		}

		// Token: 0x0600C2C7 RID: 49863 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetCachedPlace(out byte placeId)
		{
			throw null;
		}

		// Token: 0x0600C2C8 RID: 49864 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DistanceCheck(Vector3 position)
		{
			throw null;
		}

		// Token: 0x0600C2C9 RID: 49865 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerInteractPacket GetInteractWithBtrPacket(byte placeId, EInteractionType interaction)
		{
			throw null;
		}

		// Token: 0x0600C2CA RID: 49866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0(Player player, out GClass1683 approachState)
		{
			throw null;
		}

		// Token: 0x0600C2CB RID: 49867 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task ProcessApproach(Player player, Vector3 start, Vector3 target)
		{
			throw null;
		}

		// Token: 0x0600C2CC RID: 49868 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600C2CD RID: 49869 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600C2CE RID: 49870 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool open)
		{
			throw null;
		}

		// Token: 0x0600C2CF RID: 49871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsPlayerInRange(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600C2D0 RID: 49872 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(bool subscribe)
		{
			throw null;
		}

		// Token: 0x0600C2D1 RID: 49873 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool subscribe)
		{
			throw null;
		}

		// Token: 0x0600C2D2 RID: 49874 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(BTRSide.EState previousState, BTRSide.EState newState)
		{
			throw null;
		}

		// Token: 0x0600C2D3 RID: 49875 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600C2D4 RID: 49876 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPassenger(Player player, int placeId)
		{
			throw null;
		}

		// Token: 0x0600C2D5 RID: 49877 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPassenger(ObservedPlayerView player, int placeId)
		{
			throw null;
		}

		// Token: 0x0600C2D6 RID: 49878 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600C2D7 RID: 49879 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemovePassenger(Player player)
		{
			throw null;
		}

		// Token: 0x0600C2D8 RID: 49880 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemovePassenger(ObservedPlayerView player)
		{
			throw null;
		}

		// Token: 0x0600C2D9 RID: 49881 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600C2DA RID: 49882 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600C2DB RID: 49883 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600C2DC RID: 49884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600C2DD RID: 49885 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600C2DE RID: 49886 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyPlayerRotation(MovementContext movementContext, Vector3 start, Vector3 target)
		{
			throw null;
		}

		// Token: 0x0600C2DF RID: 49887 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600C2E0 RID: 49888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_11(int placeId)
		{
			throw null;
		}

		// Token: 0x0600C2E1 RID: 49889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueTuple<Vector3, Vector3> GoInPoints()
		{
			throw null;
		}

		// Token: 0x0600C2E2 RID: 49890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueTuple<Vector3, Vector3> GoOutPoints()
		{
			throw null;
		}

		// Token: 0x0600C2E3 RID: 49891 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(Vector3 targetPosition)
		{
			throw null;
		}

		// Token: 0x0600C2E4 RID: 49892 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(Vector3 targetPosition)
		{
			throw null;
		}

		// Token: 0x0600C2E5 RID: 49893 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x0600C2E6 RID: 49894 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15()
		{
			throw null;
		}

		// Token: 0x0600C2E7 RID: 49895 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(Vector3 targetPosition, ref BTRSide.Struct753 struct753_0)
		{
			throw null;
		}

		// Token: 0x0600C2E8 RID: 49896 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(Vector3 targetPosition, ref BTRSide.Struct753 struct753_0)
		{
			throw null;
		}

		// Token: 0x0400C489 RID: 50313
		private const int MAX_PLACES = 2;

		// Token: 0x0400C48A RID: 50314
		private const float PLACE_MOVE_MLP = 0.8f;

		// Token: 0x0400C48B RID: 50315
		private const float TP_POSITION_DISTANCE_SQR = 1f;

		// Token: 0x0400C48C RID: 50316
		private const float PLAYER_IN_RANGE_DISTANCE_SQR = 3f;

		// Token: 0x0400C48D RID: 50317
		private const float MAX_CAMERA_SHAKE = 0.1f;

		// Token: 0x0400C48E RID: 50318
		[SerializeField]
		private float _interactionDistanceSqr;

		// Token: 0x0400C48F RID: 50319
		[SerializeField]
		private Transform _startPoint;

		// Token: 0x0400C490 RID: 50320
		[SerializeField]
		private Transform _goInPoint;

		// Token: 0x0400C491 RID: 50321
		[SerializeField]
		private Transform _goOutPoint;

		// Token: 0x0400C492 RID: 50322
		[SerializeField]
		private BTRPlace[] _btrPlaces;

		// Token: 0x0400C493 RID: 50323
		[SerializeField]
		private BTRDoor[] _doors;

		// Token: 0x0400C494 RID: 50324
		private BTRSide.EState _state;

		// Token: 0x0400C497 RID: 50327
		private ValueTuple<Player, int> _localPassenger;

		// Token: 0x0400C498 RID: 50328
		private readonly List<ValueTuple<ObservedPlayerView, int>> _observedPassengers;

		// Token: 0x0200265E RID: 9822
		public enum EState : byte
		{
			// Token: 0x0400C49A RID: 50330
			Free,
			// Token: 0x0400C49B RID: 50331
			Busy
		}

		// Token: 0x02002660 RID: 9824
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		public struct Struct753
		{
			// Token: 0x0400C4A4 RID: 50340
			public ValueTuple<ObservedPlayerView, int> passenger;
		}
	}
}
