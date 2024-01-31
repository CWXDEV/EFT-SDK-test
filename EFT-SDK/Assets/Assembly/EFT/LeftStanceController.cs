using System;
using System.Runtime.CompilerServices;

namespace EFT
{
	// Token: 0x020015A5 RID: 5541
	public class LeftStanceController
	{
		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x060076E3 RID: 30435 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060076E4 RID: 30436 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool LeftStance
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

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x060076E5 RID: 30437 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060076E6 RID: 30438 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool LastAnimValue
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

		// Token: 0x060076E7 RID: 30439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleLeftStance()
		{
			throw null;
		}

		// Token: 0x060076E8 RID: 30440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLeftStanceForce(bool value)
		{
			throw null;
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableLeftStanceAnimFromBodyAction()
		{
			throw null;
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableLeftStanceAnimFromHandsAction()
		{
			throw null;
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableLeftStanceAnimFromOpenInventory()
		{
			throw null;
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnblockChangeAnimationFromBodyAction()
		{
			throw null;
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BlockChangeAnimationFromBodyAction()
		{
			throw null;
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimatorLeftStanceToCacheFromBodyAction(bool forceInOneFrame = false)
		{
			throw null;
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimatorLeftStanceToCacheFromCloseInventory()
		{
			throw null;
		}

		// Token: 0x060076F0 RID: 30448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimatorLeftStanceToCacheFromHandsAction()
		{
			throw null;
		}

		// Token: 0x060076F1 RID: 30449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x04007CDE RID: 31966
		private Action<bool> _setLeftStanceInPlayerAnimator;

		// Token: 0x04007CDF RID: 31967
		private Action _setLeftStanceInOneFrameInPlayerAnimator;

		// Token: 0x04007CE0 RID: 31968
		private Func<bool> _canSetAnimatorLeftStanceToCacheValue;

		// Token: 0x04007CE1 RID: 31969
		private LeftStanceController.ELeftStanceBodyActionType _lastBodyActionTypeRequest;

		// Token: 0x04007CE2 RID: 31970
		private bool _allowBodyChangeAnim;

		// Token: 0x04007CE3 RID: 31971
		private bool _allowBodyChangeAnimOnUnblockFromBodyAction;

		// Token: 0x04007CE4 RID: 31972
		private bool _blockingLeftStanceOperationInProcess;

		// Token: 0x04007CE5 RID: 31973
		private bool _blockChangeToLeftStanceFromBodyAction;

		// Token: 0x020015A6 RID: 5542
		public enum ELeftStanceBodyActionType
		{
			// Token: 0x04007CE8 RID: 31976
			None,
			// Token: 0x04007CE9 RID: 31977
			DisableAnimLeftStance,
			// Token: 0x04007CEA RID: 31978
			SetToCacheValue
		}
	}
}
