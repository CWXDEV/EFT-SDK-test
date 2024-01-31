using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimationEventSystem;
using UnityEngine;

namespace EFT.NPC
{
	// Token: 0x02001C87 RID: 7303
	public class NPCAnimationsEventReceiver : MonoBehaviour, GInterface24
	{
		// Token: 0x140001C7 RID: 455
		// (add) Token: 0x0600987E RID: 39038 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600987F RID: 39039 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnCurrentAnimationEnded
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

		// Token: 0x140001C8 RID: 456
		// (add) Token: 0x06009880 RID: 39040 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009881 RID: 39041 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<int, bool> OnNeedChangeObjectVisibility
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

		// Token: 0x140001C9 RID: 457
		// (add) Token: 0x06009882 RID: 39042 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009883 RID: 39043 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<string> OnNeedToPlaySomeSound
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

		// Token: 0x06009884 RID: 39044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(Animator npcAnimator)
		{
			throw null;
		}

		// Token: 0x06009885 RID: 39045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int functionHashName, AnimationEventParameter parameters)
		{
			throw null;
		}

		// Token: 0x06009886 RID: 39046 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnCurrentAnimStateEnded()
		{
			throw null;
		}

		// Token: 0x06009887 RID: 39047 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnSetActiveObject(int objectID)
		{
			throw null;
		}

		// Token: 0x06009888 RID: 39048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnDeactivateObject(int objectID)
		{
			throw null;
		}

		// Token: 0x06009889 RID: 39049 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnSound(string StringParam)
		{
			throw null;
		}

		// Token: 0x0600988A RID: 39050 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnAddAmmoInChamber()
		{
			throw null;
		}

		// Token: 0x0600988B RID: 39051 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnAddAmmoInMag()
		{
			throw null;
		}

		// Token: 0x0600988C RID: 39052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnArm()
		{
			throw null;
		}

		// Token: 0x0600988D RID: 39053 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnCook()
		{
			throw null;
		}

		// Token: 0x0600988E RID: 39054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnDelAmmoChamber()
		{
			throw null;
		}

		// Token: 0x0600988F RID: 39055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnDelAmmoFromMag()
		{
			throw null;
		}

		// Token: 0x06009890 RID: 39056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnDisarm()
		{
			throw null;
		}

		// Token: 0x06009891 RID: 39057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnFireEnd()
		{
			throw null;
		}

		// Token: 0x06009892 RID: 39058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnFiringBullet()
		{
			throw null;
		}

		// Token: 0x06009893 RID: 39059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnFoldOff()
		{
			throw null;
		}

		// Token: 0x06009894 RID: 39060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnFoldOn()
		{
			throw null;
		}

		// Token: 0x06009895 RID: 39061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnIdleStart()
		{
			throw null;
		}

		// Token: 0x06009896 RID: 39062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnMagHide()
		{
			throw null;
		}

		// Token: 0x06009897 RID: 39063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnMagIn()
		{
			throw null;
		}

		// Token: 0x06009898 RID: 39064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnMagOut()
		{
			throw null;
		}

		// Token: 0x06009899 RID: 39065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnMagShow()
		{
			throw null;
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnMessageName()
		{
			throw null;
		}

		// Token: 0x0600989B RID: 39067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnMalfunctionOff()
		{
			throw null;
		}

		// Token: 0x0600989C RID: 39068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnModChanged()
		{
			throw null;
		}

		// Token: 0x0600989D RID: 39069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnOffBoltCatch()
		{
			throw null;
		}

		// Token: 0x0600989E RID: 39070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnOnBoltCatch()
		{
			throw null;
		}

		// Token: 0x0600989F RID: 39071 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnPutMagToRig()
		{
			throw null;
		}

		// Token: 0x060098A0 RID: 39072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnRemoveShell()
		{
			throw null;
		}

		// Token: 0x060098A1 RID: 39073 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnReplaceSecondMag()
		{
			throw null;
		}

		// Token: 0x060098A2 RID: 39074 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnShellEject()
		{
			throw null;
		}

		// Token: 0x060098A3 RID: 39075 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnShowAmmo(bool BoolParam)
		{
			throw null;
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnSoundAtPoint(string StringParam)
		{
			throw null;
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnStartUtilityOperation()
		{
			throw null;
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnUseSecondMagForReload()
		{
			throw null;
		}

		// Token: 0x060098A7 RID: 39079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnWeapIn()
		{
			throw null;
		}

		// Token: 0x060098A8 RID: 39080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnWeapOut()
		{
			throw null;
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnLauncherAppeared()
		{
			throw null;
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnLauncherDisappeared()
		{
			throw null;
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnShowMag()
		{
			throw null;
		}

		// Token: 0x060098AC RID: 39084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnSliderOut()
		{
			throw null;
		}

		// Token: 0x060098AD RID: 39085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnUseProp(bool BoolParam)
		{
			throw null;
		}

		// Token: 0x060098AE RID: 39086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnBackpackDrop()
		{
			throw null;
		}

		// Token: 0x060098AF RID: 39087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnComboPlanning()
		{
			throw null;
		}

		// Token: 0x060098B0 RID: 39088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface24.OnThirdAction(int objectID)
		{
			throw null;
		}

		// Token: 0x04009FE0 RID: 40928
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x04009FE1 RID: 40929
		[CompilerGenerated]
		private Action<int, bool> action_1;

		// Token: 0x04009FE2 RID: 40930
		[CompilerGenerated]
		private Action<string> action_2;

		// Token: 0x04009FE3 RID: 40931
		private AnimationEventsEmitter animationEventsEmitter_0;

		// Token: 0x04009FE4 RID: 40932
		private IAnimator ianimator_0;

		// Token: 0x04009FE5 RID: 40933
		private List<GInterface24> list_0;
	}
}
