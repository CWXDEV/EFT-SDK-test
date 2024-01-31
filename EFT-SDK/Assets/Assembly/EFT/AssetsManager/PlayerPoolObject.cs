using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using RootMotion.FinalIK;
using UnityEngine;

namespace EFT.AssetsManager
{
	// Token: 0x02002865 RID: 10341
	[DisallowMultipleComponent]
	public class PlayerPoolObject : AssetPoolObject
	{
		// Token: 0x0600CE81 RID: 52865 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnCreatePoolRoleModel()
		{
			throw null;
		}

		// Token: 0x0600CE82 RID: 52866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<PlayerRigidbodySleepHierarchy> CreatePlayerRigidbodySleepHierarchy(RigidbodySpawner[] rigidbodySpawners)
		{
			throw null;
		}

		// Token: 0x0600CE83 RID: 52867 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_3(List<PlayerRigidbodySleepHierarchy> playerRigidbodySleepHierarchy, EBodyPartColliderType parent, EBodyPartColliderType child)
		{
			throw null;
		}

		// Token: 0x0600CE84 RID: 52868 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnCreatePoolObject<TAssetPoolObject>([CanBeNull] GClass3001<TAssetPoolObject> assetsPoolParent)
		{
			throw null;
		}

		// Token: 0x0600CE85 RID: 52869 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600CE86 RID: 52870 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetupAnimator()
		{
			throw null;
		}

		// Token: 0x0600CE87 RID: 52871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnGetFromPool()
		{
			throw null;
		}

		// Token: 0x0600CE88 RID: 52872 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ReturnToPool()
		{
			throw null;
		}

		// Token: 0x0600CE89 RID: 52873 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0400CF3A RID: 53050
		public GrounderFBBIK GrounderFbbik;

		// Token: 0x0400CF3B RID: 53051
		public FullBodyBipedIK FullBodyBipedIk;

		// Token: 0x0400CF3C RID: 53052
		public HitReaction HitReaction;

		// Token: 0x0400CF3D RID: 53053
		public LimbIK[] LimbIks;

		// Token: 0x0400CF3E RID: 53054
		public Animator Animator;

		// Token: 0x0400CF3F RID: 53055
		public CharacterControllerSpawner CharacterControllerSpawner;

		// Token: 0x0400CF40 RID: 53056
		public PlayerBones PlayerBones;

		// Token: 0x0400CF41 RID: 53057
		public PlayerOverlapManager PlayerOverlapManager;

		// Token: 0x0400CF42 RID: 53058
		public AnimatorDefaultStateCache AnimatorDefaultStateCache;

		// Token: 0x0400CF43 RID: 53059
		public RigidbodySpawner[] RigidbodySpawners;

		// Token: 0x0400CF44 RID: 53060
		public CharacterJointSpawner[] JointSpawners;

		// Token: 0x0400CF45 RID: 53061
		public List<PlayerRigidbodySleepHierarchy> PlayerRigidbodySleepHierarchy;

		// Token: 0x02002866 RID: 10342
		[CompilerGenerated]
		private sealed class Class2346
		{
			// Token: 0x0600CE8A RID: 52874 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(PlayerRigidbodySleepHierarchy hierarchy)
			{
				throw null;
			}

			// Token: 0x0600CE8B RID: 52875 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(PlayerRigidbodySleepHierarchy hierarchy)
			{
				throw null;
			}

			// Token: 0x0400CF46 RID: 53062
			public EBodyPartColliderType parent;

			// Token: 0x0400CF47 RID: 53063
			public EBodyPartColliderType child;
		}
	}
}
