using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.MovingPlatforms;
using UnityEngine;

namespace EFT
{
	// Token: 0x020015D5 RID: 5589
	public class PlayerSpiritBones : MonoBehaviour, MovingPlatform.GInterface347
	{
		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06007A1F RID: 31263 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Center
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06007A20 RID: 31264 RVA: 0x00002050 File Offset: 0x00000250
		public float Height
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06007A21 RID: 31265 RVA: 0x00002050 File Offset: 0x00000250
		public float Tilt
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06007A22 RID: 31266 RVA: 0x00002050 File Offset: 0x00000250
		public float Step
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06007A23 RID: 31267 RVA: 0x00002050 File Offset: 0x00000250
		public float Radius
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06007A24 RID: 31268 RVA: 0x00002050 File Offset: 0x00000250
		public float SkinWidth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06007A25 RID: 31269 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerSpiritBones.PoseType Pose
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06007A26 RID: 31270 RVA: 0x00002050 File Offset: 0x00000250
		public Transform VaultingGridRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06007A27 RID: 31271 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerSpiritBones.PoseType CurrentPose
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("AWAKE")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(PlayerSpiritBase spirit)
		{
			throw null;
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetupSimpleBones(Dictionary<PlayerBoneType, BifacialTransform> originalBones)
		{
			throw null;
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetupBone(BifacialTransform bone, PlayerBoneType boneType)
		{
			throw null;
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_1(PlayerBoneType boneType)
		{
			throw null;
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Quaternion method_2(PlayerBoneType boneType)
		{
			throw null;
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetImitatorPositionLocal(Vector3 relativePoint)
		{
			throw null;
		}

		// Token: 0x06007A30 RID: 31280 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(PlayerBoneType boneType, ref Vector3 relativePoint)
		{
			throw null;
		}

		// Token: 0x06007A31 RID: 31281 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(ref Vector3 relativePoint)
		{
			throw null;
		}

		// Token: 0x06007A32 RID: 31282 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPose(PlayerSpiritBones.PoseType poseType)
		{
			throw null;
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAimingState(bool aiming)
		{
			throw null;
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BifacialTransform GetBone(PlayerBoneType boneType)
		{
			throw null;
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPoseConfig(PlayerSpiritBones.PoseSkeleton poseSkeleton)
		{
			throw null;
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Bounds GetLocalBounds()
		{
			throw null;
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Board(MovingPlatform platform)
		{
			throw null;
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetOff(MovingPlatform platform)
		{
			throw null;
		}

		// Token: 0x04007EA5 RID: 32421
		private ICharacterController icharacterController_0;

		// Token: 0x04007EA6 RID: 32422
		public List<PlayerBoneType> SimpleBones;

		// Token: 0x04007EA7 RID: 32423
		[SerializeField]
		private PlayerSpiritBones.PoseType _currentPose;

		// Token: 0x04007EA8 RID: 32424
		[SerializeField]
		private Transform _vaultingGridRoot;

		// Token: 0x04007EA9 RID: 32425
		[SerializeField]
		private bool _isAiming;

		// Token: 0x04007EAA RID: 32426
		[SerializeField]
		private Vector3 aimingOffsetLocal;

		// Token: 0x04007EAB RID: 32427
		[SerializeField]
		private Quaternion aimingRotationLocal;

		// Token: 0x04007EAC RID: 32428
		[SerializeField]
		private PlayerSpiritBones.PoseSkeleton[] _posesConfig;

		// Token: 0x04007EAD RID: 32429
		private Dictionary<PlayerBoneType, Vector3>[] dictionary_0;

		// Token: 0x04007EAE RID: 32430
		private PlayerSpiritBase playerSpiritBase_0;

		// Token: 0x04007EAF RID: 32431
		private Quaternion quaternion_0;

		// Token: 0x04007EB0 RID: 32432
		private int int_0;

		// Token: 0x04007EB1 RID: 32433
		private readonly Dictionary<PlayerBoneType, BifacialTransform> dictionary_1;

		// Token: 0x020015D6 RID: 5590
		public enum PoseType : byte
		{
			// Token: 0x04007EB3 RID: 32435
			None,
			// Token: 0x04007EB4 RID: 32436
			Stand,
			// Token: 0x04007EB5 RID: 32437
			Crouch,
			// Token: 0x04007EB6 RID: 32438
			Prone,
			// Token: 0x04007EB7 RID: 32439
			TiltLeft,
			// Token: 0x04007EB8 RID: 32440
			TiltRight,
			// Token: 0x04007EB9 RID: 32441
			SideStepLeft,
			// Token: 0x04007EBA RID: 32442
			SideStepRight,
			// Token: 0x04007EBB RID: 32443
			ProneSideStepLeft,
			// Token: 0x04007EBC RID: 32444
			ProneSideStepRight,
			// Token: 0x04007EBD RID: 32445
			ProneTiltLeft,
			// Token: 0x04007EBE RID: 32446
			ProneTiltRight,
			// Token: 0x04007EBF RID: 32447
			CrouchTiltLeft,
			// Token: 0x04007EC0 RID: 32448
			CrouchTiltRight,
			// Token: 0x04007EC1 RID: 32449
			CrouchSideStepLeft,
			// Token: 0x04007EC2 RID: 32450
			CrouchSideStepRight
		}

		// Token: 0x020015D7 RID: 5591
		[Serializable]
		public struct BonePosition
		{
			// Token: 0x04007EC3 RID: 32451
			public PlayerBoneType type;

			// Token: 0x04007EC4 RID: 32452
			public Vector3 position;
		}

		// Token: 0x020015D8 RID: 5592
		[Serializable]
		public struct PoseSkeleton
		{
			// Token: 0x04007EC5 RID: 32453
			public PlayerSpiritBones.PoseType type;

			// Token: 0x04007EC6 RID: 32454
			public PlayerSpiritBones.BonePosition[] bones;
		}

		// Token: 0x020015D9 RID: 5593
		[CompilerGenerated]
		private sealed class Class1151
		{
			// Token: 0x06007A39 RID: 31289 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Vector3 method_0()
			{
				throw null;
			}

			// Token: 0x06007A3A RID: 31290 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Quaternion method_1()
			{
				throw null;
			}

			// Token: 0x06007A3B RID: 31291 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Vector3 method_2()
			{
				throw null;
			}

			// Token: 0x06007A3C RID: 31292 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Quaternion method_3()
			{
				throw null;
			}

			// Token: 0x06007A3D RID: 31293 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Vector3 method_4()
			{
				throw null;
			}

			// Token: 0x06007A3E RID: 31294 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Vector3 method_5()
			{
				throw null;
			}

			// Token: 0x06007A3F RID: 31295 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Vector3 method_6()
			{
				throw null;
			}

			// Token: 0x06007A40 RID: 31296 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Vector3 method_7()
			{
				throw null;
			}

			// Token: 0x06007A41 RID: 31297 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Vector3 method_8(Vector3 value)
			{
				throw null;
			}

			// Token: 0x06007A42 RID: 31298 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Vector3 method_9(Vector3 value)
			{
				throw null;
			}

			// Token: 0x06007A43 RID: 31299 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Vector3 method_10(Vector3 value)
			{
				throw null;
			}

			// Token: 0x06007A44 RID: 31300 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Vector3 method_11(Vector3 value)
			{
				throw null;
			}

			// Token: 0x04007EC7 RID: 32455
			public PlayerSpiritBones playerSpiritBones_0;

			// Token: 0x04007EC8 RID: 32456
			public PlayerBoneType boneType;
		}

		// Token: 0x020015DA RID: 5594
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1152
		{
			// Token: 0x06007A45 RID: 31301 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Vector3 value)
			{
				throw null;
			}

			// Token: 0x06007A46 RID: 31302 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Quaternion value)
			{
				throw null;
			}

			// Token: 0x06007A47 RID: 31303 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(Vector3 pos, Quaternion rot)
			{
				throw null;
			}

			// Token: 0x06007A48 RID: 31304 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(Vector3 value)
			{
				throw null;
			}

			// Token: 0x06007A49 RID: 31305 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4(Quaternion value)
			{
				throw null;
			}

			// Token: 0x06007A4A RID: 31306 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_5(Vector3 v1, Vector3 v2)
			{
				throw null;
			}

			// Token: 0x04007EC9 RID: 32457
			public static readonly PlayerSpiritBones.Class1152 class1152_0;

			// Token: 0x04007ECA RID: 32458
			public static Action<Vector3> action_0;

			// Token: 0x04007ECB RID: 32459
			public static Action<Quaternion> action_1;

			// Token: 0x04007ECC RID: 32460
			public static Action<Vector3, Quaternion> action_2;

			// Token: 0x04007ECD RID: 32461
			public static Action<Vector3> action_3;

			// Token: 0x04007ECE RID: 32462
			public static Action<Quaternion> action_4;

			// Token: 0x04007ECF RID: 32463
			public static Action<Vector3, Vector3> action_5;
		}
	}
}
