using System;
using System.Runtime.CompilerServices;
using AnimationSystem.RootMotionTable;
using EFT.AssetsManager;
using UnityEngine;
using UnityEngine.AI;

namespace EFT
{
	// Token: 0x020015D3 RID: 5587
	[DisallowMultipleComponent]
	public abstract class PlayerSpiritBase : AssetPoolObject
	{
		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x060079C9 RID: 31177 RVA: 0x00002050 File Offset: 0x00000250
		public virtual IAnimator BodyAnimatorWrapper
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x060079CA RID: 31178 RVA: 0x00002050 File Offset: 0x00000250
		public ICharacterController CharacterController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x060079CB RID: 31179 RVA: 0x00002050 File Offset: 0x00000250
		public TriggerColliderSearcher TriggerColliderSearcher
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x060079CC RID: 31180 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x060079CD RID: 31181 RVA: 0x00002050 File Offset: 0x00000250
		public CharacterControllerSpawner.Mode CharacterControllerMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Init(Player player, Vector3 position, bool isBodyAnimatorUpdating, CharacterControllerSpawner.Mode characterControllerMode, CharacterControllerSpawner.Mode disconnectedCharacterControllerMode)
		{
			throw null;
		}

		// Token: 0x060079CF RID: 31183 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void InitAfterPlayerInit()
		{
			throw null;
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060079D1 RID: 31185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void EnableBoneImitation(bool useImitation)
		{
			throw null;
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Vector3 NotImplementedPosition()
		{
			throw null;
		}

		// Token: 0x060079D3 RID: 31187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Quaternion NotImplementedRotation()
		{
			throw null;
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitBodyAnimator(AnimatorUpdateMode updateMode, bool useFastAnimator)
		{
			throw null;
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x060079D6 RID: 31190 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitArmsAnimator(IAnimator animator, RuntimeAnimatorController animatorController, IAnimator animatorRoleModel, bool isAnimatorEnabled)
		{
			throw null;
		}

		// Token: 0x060079D7 RID: 31191 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected GStruct198 CreateFootprint()
		{
			throw null;
		}

		// Token: 0x060079D8 RID: 31192
		public abstract void PlayerSync();

		// Token: 0x060079D9 RID: 31193 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerSync(GStruct198 footprint, bool updateAnimator = true)
		{
			throw null;
		}

		// Token: 0x060079DA RID: 31194 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void PlayerBodySync(GStruct198 footprint, bool updateAnimator = true)
		{
			throw null;
		}

		// Token: 0x060079DB RID: 31195 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void PlayerArmsSync(GStruct198 footprint, bool updateAnimator = true)
		{
			throw null;
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SyncAnimators(IAnimator animatorRecipient, GStruct199 footprint)
		{
			throw null;
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnCharacterControllerHeightChanged(float value)
		{
			throw null;
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTiltChanged(float value)
		{
			throw null;
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(int before, int after)
		{
			throw null;
		}

		// Token: 0x060079E0 RID: 31200 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ChangePose()
		{
			throw null;
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Update()
		{
			throw null;
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x060079E3 RID: 31203 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Die()
		{
			throw null;
		}

		// Token: 0x060079E4 RID: 31204 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActive(bool active)
		{
			throw null;
		}

		// Token: 0x060079E5 RID: 31205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void TranslateAnimatorState(IAnimator animatorRecipient, IAnimator animatorDonor)
		{
			throw null;
		}

		// Token: 0x060079E6 RID: 31206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Transform GetActiveTransform()
		{
			throw null;
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchToDisconnectedMode()
		{
			throw null;
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchToNormalMode()
		{
			throw null;
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(CharacterControllerSpawner.Mode characterControllerMode)
		{
			throw null;
		}

		// Token: 0x060079EA RID: 31210 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_4()
		{
			throw null;
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Vector3 value)
		{
			throw null;
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Quaternion method_6()
		{
			throw null;
		}

		// Token: 0x060079ED RID: 31213 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(Quaternion value)
		{
			throw null;
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(Vector3 pos, Quaternion rot)
		{
			throw null;
		}

		// Token: 0x060079EF RID: 31215 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_9()
		{
			throw null;
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(Vector3 value)
		{
			throw null;
		}

		// Token: 0x060079F1 RID: 31217 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Quaternion method_11()
		{
			throw null;
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(Quaternion value)
		{
			throw null;
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_13()
		{
			throw null;
		}

		// Token: 0x060079F4 RID: 31220 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_14()
		{
			throw null;
		}

		// Token: 0x060079F5 RID: 31221 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_15()
		{
			throw null;
		}

		// Token: 0x060079F6 RID: 31222 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_16()
		{
			throw null;
		}

		// Token: 0x060079F7 RID: 31223 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_17(Vector3 value)
		{
			throw null;
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_18(Vector3 value)
		{
			throw null;
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_19(Vector3 value)
		{
			throw null;
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_20(Vector3 value)
		{
			throw null;
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21(Vector3 v1, Vector3 v2)
		{
			throw null;
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_22()
		{
			throw null;
		}

		// Token: 0x060079FD RID: 31229 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_23(Vector3 value)
		{
			throw null;
		}

		// Token: 0x060079FE RID: 31230 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Quaternion method_24()
		{
			throw null;
		}

		// Token: 0x060079FF RID: 31231 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_25(Quaternion value)
		{
			throw null;
		}

		// Token: 0x06007A00 RID: 31232 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_26(Vector3 pos, Quaternion rot)
		{
			throw null;
		}

		// Token: 0x06007A01 RID: 31233 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_27()
		{
			throw null;
		}

		// Token: 0x06007A02 RID: 31234 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_28(Vector3 value)
		{
			throw null;
		}

		// Token: 0x06007A03 RID: 31235 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Quaternion method_29()
		{
			throw null;
		}

		// Token: 0x06007A04 RID: 31236 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_30(Quaternion value)
		{
			throw null;
		}

		// Token: 0x06007A05 RID: 31237 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_31()
		{
			throw null;
		}

		// Token: 0x06007A06 RID: 31238 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_32()
		{
			throw null;
		}

		// Token: 0x06007A07 RID: 31239 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_33()
		{
			throw null;
		}

		// Token: 0x06007A08 RID: 31240 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_34()
		{
			throw null;
		}

		// Token: 0x06007A09 RID: 31241 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_35(Vector3 value)
		{
			throw null;
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_36(Vector3 value)
		{
			throw null;
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_37(Vector3 value)
		{
			throw null;
		}

		// Token: 0x06007A0C RID: 31244 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_38(Vector3 value)
		{
			throw null;
		}

		// Token: 0x06007A0D RID: 31245 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_39(Vector3 v1, Vector3 v2)
		{
			throw null;
		}

		// Token: 0x06007A0E RID: 31246 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_40()
		{
			throw null;
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Quaternion method_41()
		{
			throw null;
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_42()
		{
			throw null;
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_43(Vector3 value)
		{
			throw null;
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Quaternion method_44()
		{
			throw null;
		}

		// Token: 0x06007A13 RID: 31251 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_45(Quaternion value)
		{
			throw null;
		}

		// Token: 0x06007A14 RID: 31252 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_46()
		{
			throw null;
		}

		// Token: 0x06007A15 RID: 31253 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_47()
		{
			throw null;
		}

		// Token: 0x06007A16 RID: 31254 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_48()
		{
			throw null;
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_49(Vector3 value)
		{
			throw null;
		}

		// Token: 0x06007A18 RID: 31256 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_50(Vector3 value)
		{
			throw null;
		}

		// Token: 0x06007A19 RID: 31257 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_51(Vector3 value)
		{
			throw null;
		}

		// Token: 0x06007A1A RID: 31258 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_52(Vector3 value)
		{
			throw null;
		}

		// Token: 0x06007A1B RID: 31259 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_53(Vector3 v1, Vector3 v2)
		{
			throw null;
		}

		// Token: 0x04007E87 RID: 32391
		public Animator BodyAnimator;

		// Token: 0x04007E88 RID: 32392
		private IAnimator ianimator_0;

		// Token: 0x04007E89 RID: 32393
		[HideInInspector]
		public IAnimator ArmsAnimator;

		// Token: 0x04007E8A RID: 32394
		[SerializeField]
		protected Transform _bodyTransform;

		// Token: 0x04007E8B RID: 32395
		[SerializeField]
		protected Transform _animatedTransform;

		// Token: 0x04007E8C RID: 32396
		[SerializeField]
		protected RootMotionBlendTable RootMotionTable;

		// Token: 0x04007E8D RID: 32397
		[HideInInspector]
		public Vector2 LookRotation;

		// Token: 0x04007E8E RID: 32398
		[HideInInspector]
		public Vector2 PreviousLookRotation;

		// Token: 0x04007E8F RID: 32399
		[SerializeField]
		protected CharacterControllerSpawner _characterControllerSpawner;

		// Token: 0x04007E90 RID: 32400
		protected ICharacterController _characterController;

		// Token: 0x04007E91 RID: 32401
		[SerializeField]
		public PlayerSpiritAura PlayerSpiritAura;

		// Token: 0x04007E92 RID: 32402
		public NavMeshAgent NavMeshAgent;

		// Token: 0x04007E93 RID: 32403
		public PlayerSpiritBones Bones;

		// Token: 0x04007E94 RID: 32404
		protected float _armsLength;

		// Token: 0x04007E95 RID: 32405
		public const int FOOTPRINTS_POOL_LENGTH = 300;

		// Token: 0x04007E96 RID: 32406
		public static int PLAYER_FOOTPRINTS_HISTORY_LENGTH;

		// Token: 0x04007E97 RID: 32407
		public static int BOT_FOOTPRINTS_HISTORY_LENGTH;

		// Token: 0x04007E98 RID: 32408
		[HideInInspector]
		public Player _player;

		// Token: 0x04007E99 RID: 32409
		protected bool _isActive;

		// Token: 0x04007E9A RID: 32410
		protected bool _isBodyAnimatorUpdating;

		// Token: 0x04007E9B RID: 32411
		protected bool _updateFastAnimator;

		// Token: 0x04007E9C RID: 32412
		private CharacterControllerSpawner.Mode mode_0;

		// Token: 0x04007E9D RID: 32413
		private CharacterControllerSpawner.Mode mode_1;

		// Token: 0x04007E9E RID: 32414
		private bool bool_3;

		// Token: 0x04007E9F RID: 32415
		private bool bool_4;

		// Token: 0x04007EA0 RID: 32416
		private bool bool_5;

		// Token: 0x020015D4 RID: 5588
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1150
		{
			// Token: 0x06007A1D RID: 31261 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Quaternion value)
			{
				throw null;
			}

			// Token: 0x06007A1E RID: 31262 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(Vector3 pos, Quaternion rot)
			{
				throw null;
			}

			// Token: 0x04007EA1 RID: 32417
			public static readonly PlayerSpiritBase.Class1150 class1150_0;

			// Token: 0x04007EA2 RID: 32418
			public static Action<Vector3> action_0;

			// Token: 0x04007EA3 RID: 32419
			public static Action<Quaternion> action_1;

			// Token: 0x04007EA4 RID: 32420
			public static Action<Vector3, Quaternion> action_2;
		}
	}
}
