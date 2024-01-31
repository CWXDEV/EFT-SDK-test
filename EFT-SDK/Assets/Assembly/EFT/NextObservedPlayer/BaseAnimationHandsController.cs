using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AnimationEventSystem;
using UnityEngine;

namespace EFT.NextObservedPlayer
{
	// Token: 0x02001FA2 RID: 8098
	public abstract class BaseAnimationHandsController : MonoBehaviour, GInterface24
	{
		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x0600A79B RID: 42907 RVA: 0x00002050 File Offset: 0x00000250
		protected GClass2308 CurrentHandsOperationCallbacks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x0600A79C RID: 42908 RVA: 0x00002050 File Offset: 0x00000250
		public IAnimator BodyAnimator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x0600A79D RID: 42909 RVA: 0x00002050 File Offset: 0x00000250
		public FirearmsAnimator HandsAnimator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x0600A79E RID: 42910 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A79F RID: 42911 RVA: 0x00002050 File Offset: 0x00000250
		public AnimationEventsEmitter AnimationEventsEmitter
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

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Setup(IAnimator bodyAnimator, FirearmsAnimator handsAnimator, AnimationEventsEmitter animationEventsEmitter, EHandsControllerType controllerType, GClass2355 bundleAnimationBones, Func<bool> NeedFastForward, Func<bool> isPlayerCulled)
		{
			throw null;
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHandsAnimator(FirearmsAnimator firearmsAnimator)
		{
			throw null;
		}

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Spawn(float animationSpeed)
		{
			throw null;
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Unspawn(GClass2346.GStruct308 input)
		{
			throw null;
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Complete()
		{
			throw null;
		}

		// Token: 0x0600A7A5 RID: 42917 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Destroy()
		{
			throw null;
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TO InitiateOperation<TCreateOperation, TI, TO>(TI input) where TCreateOperation : GClass2309<TI, TO> where TO : GInterface221
		{
			throw null;
		}

		// Token: 0x0600A7A7 RID: 42919 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600A7A8 RID: 42920 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FastForwardCurrentOperation(bool ignoreAllAndForce = false)
		{
			throw null;
		}

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckAbortCurrentOperation(CommandMessageType messageType)
		{
			throw null;
		}

		// Token: 0x0600A7AA RID: 42922 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0600A7AB RID: 42923 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetAimingAnimationsFlags()
		{
			throw null;
		}

		// Token: 0x0600A7AC RID: 42924 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAimingInAnimator(bool isAiming)
		{
			throw null;
		}

		// Token: 0x0600A7AD RID: 42925 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnAddAmmoInChamber()
		{
			throw null;
		}

		// Token: 0x0600A7AE RID: 42926 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnAddAmmoInMag()
		{
			throw null;
		}

		// Token: 0x0600A7AF RID: 42927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnCook()
		{
			throw null;
		}

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDelAmmoChamber()
		{
			throw null;
		}

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDelAmmoFromMag()
		{
			throw null;
		}

		// Token: 0x0600A7B2 RID: 42930 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnArm()
		{
			throw null;
		}

		// Token: 0x0600A7B3 RID: 42931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDisarm()
		{
			throw null;
		}

		// Token: 0x0600A7B4 RID: 42932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnFireEnd()
		{
			throw null;
		}

		// Token: 0x0600A7B5 RID: 42933 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnFiringBullet()
		{
			throw null;
		}

		// Token: 0x0600A7B6 RID: 42934 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnFoldOff()
		{
			throw null;
		}

		// Token: 0x0600A7B7 RID: 42935 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnFoldOn()
		{
			throw null;
		}

		// Token: 0x0600A7B8 RID: 42936 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnIdleStart()
		{
			throw null;
		}

		// Token: 0x0600A7B9 RID: 42937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnLauncherAppeared()
		{
			throw null;
		}

		// Token: 0x0600A7BA RID: 42938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnLauncherDisappeared()
		{
			throw null;
		}

		// Token: 0x0600A7BB RID: 42939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnMagHide()
		{
			throw null;
		}

		// Token: 0x0600A7BC RID: 42940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnMagIn()
		{
			throw null;
		}

		// Token: 0x0600A7BD RID: 42941 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnMagOut()
		{
			throw null;
		}

		// Token: 0x0600A7BE RID: 42942 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnMagShow()
		{
			throw null;
		}

		// Token: 0x0600A7BF RID: 42943 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnMessageName()
		{
			throw null;
		}

		// Token: 0x0600A7C0 RID: 42944 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnMalfunctionOff()
		{
			throw null;
		}

		// Token: 0x0600A7C1 RID: 42945 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnModChanged()
		{
			throw null;
		}

		// Token: 0x0600A7C2 RID: 42946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnOffBoltCatch()
		{
			throw null;
		}

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnOnBoltCatch()
		{
			throw null;
		}

		// Token: 0x0600A7C4 RID: 42948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPutMagToRig()
		{
			throw null;
		}

		// Token: 0x0600A7C5 RID: 42949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnRemoveShell()
		{
			throw null;
		}

		// Token: 0x0600A7C6 RID: 42950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnReplaceSecondMag()
		{
			throw null;
		}

		// Token: 0x0600A7C7 RID: 42951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnShellEject()
		{
			throw null;
		}

		// Token: 0x0600A7C8 RID: 42952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnShowAmmo(bool BoolParam)
		{
			throw null;
		}

		// Token: 0x0600A7C9 RID: 42953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnShowMag()
		{
			throw null;
		}

		// Token: 0x0600A7CA RID: 42954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnSliderOut()
		{
			throw null;
		}

		// Token: 0x0600A7CB RID: 42955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnSound(string StringParam)
		{
			throw null;
		}

		// Token: 0x0600A7CC RID: 42956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnSoundAtPoint(string StringParam)
		{
			throw null;
		}

		// Token: 0x0600A7CD RID: 42957 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnStartUtilityOperation()
		{
			throw null;
		}

		// Token: 0x0600A7CE RID: 42958 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnThirdAction(int IntParam)
		{
			throw null;
		}

		// Token: 0x0600A7CF RID: 42959 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnUseProp(bool BoolParam)
		{
			throw null;
		}

		// Token: 0x0600A7D0 RID: 42960 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnUseSecondMagForReload()
		{
			throw null;
		}

		// Token: 0x0600A7D1 RID: 42961 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnWeapIn()
		{
			throw null;
		}

		// Token: 0x0600A7D2 RID: 42962 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnWeapOut()
		{
			throw null;
		}

		// Token: 0x0600A7D3 RID: 42963 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnBackpackDrop()
		{
			throw null;
		}

		// Token: 0x0600A7D4 RID: 42964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnComboPlanning()
		{
			throw null;
		}

		// Token: 0x0600A7D5 RID: 42965 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnCurrentAnimStateEnded()
		{
			throw null;
		}

		// Token: 0x0600A7D6 RID: 42966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnSetActiveObject(int objectID)
		{
			throw null;
		}

		// Token: 0x0600A7D7 RID: 42967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDeactivateObject(int objectID)
		{
			throw null;
		}

		// Token: 0x0600A7D8 RID: 42968 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600A7D9 RID: 42969 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass2903 raisedEvent)
		{
			throw null;
		}

		// Token: 0x0400AE97 RID: 44695
		protected EHandsControllerType _handsControllerType;

		// Token: 0x0400AE98 RID: 44696
		private IAnimator ianimator_0;

		// Token: 0x0400AE99 RID: 44697
		private FirearmsAnimator firearmsAnimator_0;

		// Token: 0x0400AE9A RID: 44698
		private AnimationEventsEmitter animationEventsEmitter_0;

		// Token: 0x0400AE9B RID: 44699
		private Func<bool> func_0;

		// Token: 0x0400AE9C RID: 44700
		private Func<bool> func_1;

		// Token: 0x0400AE9D RID: 44701
		private Action action_0;

		// Token: 0x0400AE9E RID: 44702
		private GClass2355 gclass2355_0;

		// Token: 0x0400AE9F RID: 44703
		private GClass2308 gclass2308_0;

		// Token: 0x0400AEA0 RID: 44704
		private readonly GClass763 gclass763_0;

		// Token: 0x0400AEA1 RID: 44705
		protected GInterface223 _currentHandsOperation;

		// Token: 0x0400AEA2 RID: 44706
		public bool IsCompleted;
	}
}
