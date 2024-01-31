using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.Interactive;
using UnityEngine;
using UnityEngine.Networking;

namespace EFT.BufferZone
{
	// Token: 0x0200270D RID: 9997
	public class BufferInnerZone : MonoBehaviour
	{
		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x0600C65A RID: 50778 RVA: 0x00002050 File Offset: 0x00000250
		public BackendConfigSettingsClass.GClass1371 Settings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x0600C65B RID: 50779 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasCustomer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x0600C65C RID: 50780 RVA: 0x00002050 File Offset: 0x00000250
		public float CurrentPlayerRemainingUsageTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x0600C65D RID: 50781 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C65E RID: 50782 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsZoneAvailableForInteractions
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

		// Token: 0x140002D1 RID: 721
		// (add) Token: 0x0600C65F RID: 50783 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C660 RID: 50784 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<string, bool> OnPlayerInZoneStatusChanged
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

		// Token: 0x0600C661 RID: 50785 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600C662 RID: 50786 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600C663 RID: 50787 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600C664 RID: 50788 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUpReferences(BufferZoneContainer bufferZoneContainer)
		{
			throw null;
		}

		// Token: 0x0600C665 RID: 50789 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600C666 RID: 50790 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsPlayerHaveAccess(string profileID)
		{
			throw null;
		}

		// Token: 0x0600C667 RID: 50791 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangePlayerAccessStatus(string profileID, bool status)
		{
			throw null;
		}

		// Token: 0x0600C668 RID: 50792 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(Player player)
		{
			throw null;
		}

		// Token: 0x0600C669 RID: 50793 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(WorldInteractiveObject gates, EDoorState stateBefore, EDoorState stateAfter)
		{
			throw null;
		}

		// Token: 0x0600C66A RID: 50794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(EInteractionType interactionType, bool isOuterGateSwitcher, IPlayer interactingPlayer)
		{
			throw null;
		}

		// Token: 0x0600C66B RID: 50795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C66C RID: 50796 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsPlayerInZone(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600C66D RID: 50797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsPlayerDyingInZone(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600C66E RID: 50798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AllowCustomerPassFilter(IPlayer iPlayer, bool allow = true)
		{
			throw null;
		}

		// Token: 0x0600C66F RID: 50799 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnallowAllCustomersToPassFilter()
		{
			throw null;
		}

		// Token: 0x0600C670 RID: 50800 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeZoneInteractionAvailability(bool isAvailable, EBufferZoneData changesDataType)
		{
			throw null;
		}

		// Token: 0x0600C671 RID: 50801 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetUserRemainingUsageTime(string playerProfileID)
		{
			throw null;
		}

		// Token: 0x0600C672 RID: 50802 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(string playerProfileID, float time)
		{
			throw null;
		}

		// Token: 0x0600C673 RID: 50803 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600C674 RID: 50804 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x0600C675 RID: 50805 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task HandlePlayerReconnected(bool isInBufferZone, IPlayer player, int bufferZoneUsageTimeLeft, Task onCurrentHandsControllerSpawned)
		{
			throw null;
		}

		// Token: 0x0600C676 RID: 50806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C677 RID: 50807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C678 RID: 50808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_9(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600C679 RID: 50809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(Player player)
		{
			throw null;
		}

		// Token: 0x0600C67A RID: 50810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandlePlayerLeftZoneFromServer(string profileID)
		{
			throw null;
		}

		// Token: 0x0600C67B RID: 50811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600C67C RID: 50812 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_12(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0400C827 RID: 51239
		[SerializeField]
		private LampController availabilityShowingLamp;

		// Token: 0x0400C828 RID: 51240
		[SerializeField]
		private Collider _customerFilterCollider;

		// Token: 0x0400C829 RID: 51241
		[SerializeField]
		private PhysicsTriggerHandler enterZoneTriggerHandler;

		// Token: 0x0400C82A RID: 51242
		[SerializeField]
		private PhysicsTriggerHandler exitZoneTriggerHandler;

		// Token: 0x0400C82B RID: 51243
		[SerializeField]
		private List<PhysicsTriggerHandler> nearBufferZoneEntranceTriggerHandlers;

		// Token: 0x0400C82C RID: 51244
		private const int int_0 = 60;

		// Token: 0x0400C82D RID: 51245
		private const int int_1 = 180;

		// Token: 0x0400C82E RID: 51246
		private const int int_2 = 105;

		// Token: 0x0400C82F RID: 51247
		private readonly GClass3357<IPlayer> gclass3357_0;

		// Token: 0x0400C830 RID: 51248
		private readonly GClass3357<IPlayer> gclass3357_1;

		// Token: 0x0400C831 RID: 51249
		private Dictionary<string, float> dictionary_0;

		// Token: 0x0400C832 RID: 51250
		private float float_0;

		// Token: 0x0400C833 RID: 51251
		private bool bool_0;

		// Token: 0x0400C834 RID: 51252
		private bool bool_1;

		// Token: 0x0400C835 RID: 51253
		private bool bool_2;

		// Token: 0x0400C836 RID: 51254
		private bool bool_3;

		// Token: 0x0400C837 RID: 51255
		private BufferOuterBattleZone bufferOuterBattleZone_0;

		// Token: 0x0400C838 RID: 51256
		private BufferGateSwitcher bufferGateSwitcher_0;

		// Token: 0x0400C839 RID: 51257
		private BufferGateSwitcher bufferGateSwitcher_1;

		// Token: 0x0400C83A RID: 51258
		private BufferGates bufferGates_0;

		// Token: 0x0400C83B RID: 51259
		private CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x0400C83C RID: 51260
		private Dictionary<string, bool> dictionary_1;

		// Token: 0x0400C83D RID: 51261
		private Dictionary<string, bool> dictionary_2;

		// Token: 0x0400C83E RID: 51262
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x0400C83F RID: 51263
		[CompilerGenerated]
		private Action<string, bool> action_0;

		// Token: 0x02002710 RID: 10000
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2247
		{
			// Token: 0x0600C681 RID: 50817 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface125> result)
			{
				throw null;
			}

			// Token: 0x0400C84E RID: 51278
			public static readonly BufferInnerZone.Class2247 class2247_0;

			// Token: 0x0400C84F RID: 51279
			public static Callback<GInterface125> callback_0;
		}
	}
}
