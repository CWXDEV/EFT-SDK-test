using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.CameraControl
{
	// Token: 0x02002704 RID: 9988
	public class PlayerCameraController : MonoBehaviour
	{
		// Token: 0x140002CF RID: 719
		// (add) Token: 0x0600C623 RID: 50723 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C624 RID: 50724 RVA: 0x00002050 File Offset: 0x00000250
		public static event Action<PlayerCameraController, Camera> OnPlayerCameraControllerCreated
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

		// Token: 0x140002D0 RID: 720
		// (add) Token: 0x0600C625 RID: 50725 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C626 RID: 50726 RVA: 0x00002050 File Offset: 0x00000250
		public static event Action OnPlayerCameraControllerDestroyed
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

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x0600C627 RID: 50727 RVA: 0x00002050 File Offset: 0x00000250
		public Camera Camera
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x0600C628 RID: 50728 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C629 RID: 50729 RVA: 0x00002050 File Offset: 0x00000250
		public Player Player
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

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x0600C62A RID: 50730 RVA: 0x00002050 File Offset: 0x00000250
		private CameraClass GClass2943_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C62B RID: 50731 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PlayerCameraController Create(Player player)
		{
			throw null;
		}

		// Token: 0x0600C62C RID: 50732 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PlayerCameraController method_0(Player player)
		{
			throw null;
		}

		// Token: 0x0600C62D RID: 50733 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600C62E RID: 50734 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600C62F RID: 50735 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(FaceShieldComponent faceShield)
		{
			throw null;
		}

		// Token: 0x0600C630 RID: 50736 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600C631 RID: 50737 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600C632 RID: 50738 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitiateOperation<TCreateOperation>() where TCreateOperation : GClass2945
		{
			throw null;
		}

		// Token: 0x0600C633 RID: 50739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Dictionary<Type, PlayerCameraController.Delegate14> method_6()
		{
			throw null;
		}

		// Token: 0x0600C634 RID: 50740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePointOfView()
		{
			throw null;
		}

		// Token: 0x0600C635 RID: 50741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600C636 RID: 50742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x0600C637 RID: 50743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600C638 RID: 50744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400C7F3 RID: 51187
		[SerializeField]
		private EUpdateQueue _playerUpdateQueue;

		// Token: 0x0400C7F4 RID: 51188
		[CompilerGenerated]
		private static Action<PlayerCameraController, Camera> action_0;

		// Token: 0x0400C7F5 RID: 51189
		[CompilerGenerated]
		private static Action action_1;

		// Token: 0x0400C7F6 RID: 51190
		[CompilerGenerated]
		private Player player_0;

		// Token: 0x0400C7F7 RID: 51191
		private GClass2945 gclass2945_0;

		// Token: 0x0400C7F8 RID: 51192
		private readonly Dictionary<Type, GClass2945> dictionary_0;

		// Token: 0x0400C7F9 RID: 51193
		private Dictionary<Type, PlayerCameraController.Delegate14> dictionary_1;

		// Token: 0x0400C7FA RID: 51194
		private VisorEffect visorEffect_0;

		// Token: 0x0400C7FB RID: 51195
		private Action action_2;

		// Token: 0x0400C7FC RID: 51196
		private bool bool_0;

		// Token: 0x0400C7FD RID: 51197
		private Action action_3;

		// Token: 0x0400C7FE RID: 51198
		private Action action_4;

		// Token: 0x0400C7FF RID: 51199
		private Action action_5;

		// Token: 0x0400C800 RID: 51200
		private Action action_6;

		// Token: 0x0400C801 RID: 51201
		private HysteresisFilter hysteresisFilter_0;

		// Token: 0x02002705 RID: 9989
		// (Invoke) Token: 0x0600C639 RID: 50745
		private delegate GClass2945 Delegate14(PlayerCameraController playerCameraController);

		// Token: 0x02002706 RID: 9990
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2244
		{
			// Token: 0x0600C63C RID: 50748 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass2945 method_0(PlayerCameraController playerCamera)
			{
				throw null;
			}

			// Token: 0x0600C63D RID: 50749 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass2945 method_1(PlayerCameraController playerCamera)
			{
				throw null;
			}

			// Token: 0x0400C802 RID: 51202
			public static readonly PlayerCameraController.Class2244 class2244_0;

			// Token: 0x0400C803 RID: 51203
			public static PlayerCameraController.Delegate14 delegate14_0;

			// Token: 0x0400C804 RID: 51204
			public static PlayerCameraController.Delegate14 delegate14_1;
		}
	}
}
