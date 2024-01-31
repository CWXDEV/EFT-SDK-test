using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio.Data;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.NextObservedPlayer
{
	// Token: 0x02001FBF RID: 8127
	public class ObservedPlayerAudioController : MonoBehaviour
	{
		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x0600A854 RID: 43092 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A855 RID: 43093 RVA: 0x00002050 File Offset: 0x00000250
		public EnvironmentType Environment
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

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x0600A856 RID: 43094 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A857 RID: 43095 RVA: 0x00002050 File Offset: 0x00000250
		public BaseSoundPlayer.SoundElement PropIn
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

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x0600A858 RID: 43096 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A859 RID: 43097 RVA: 0x00002050 File Offset: 0x00000250
		public BaseSoundPlayer.SoundElement PropOut
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

		// Token: 0x14000229 RID: 553
		// (add) Token: 0x0600A85A RID: 43098 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600A85B RID: 43099 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<EPhraseTrigger, int> PhraseSituation
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

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x0600A85C RID: 43100 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x0600A85D RID: 43101 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x0600A85E RID: 43102 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x0600A85F RID: 43103 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x0600A860 RID: 43104 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_4
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x0600A861 RID: 43105 RVA: 0x00002050 File Offset: 0x00000250
		private GClass2383 GClass2383_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x0600A862 RID: 43106 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A863 RID: 43107 RVA: 0x00002050 File Offset: 0x00000250
		private BetterSource BetterSource_0
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

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x0600A864 RID: 43108 RVA: 0x00002050 File Offset: 0x00000250
		private BetterSource BetterSource_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600A865 RID: 43109 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(ObservedPlayerView observedPlayer)
		{
			throw null;
		}

		// Token: 0x0600A866 RID: 43110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitVaultingAudioControllers(ObservedPlayerView observedPlayer)
		{
			throw null;
		}

		// Token: 0x0600A867 RID: 43111 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600A868 RID: 43112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600A869 RID: 43113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyMovementModel(GStruct287 nextModel)
		{
			throw null;
		}

		// Token: 0x0600A86A RID: 43114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute(GInterface218 command)
		{
			throw null;
		}

		// Token: 0x0600A86B RID: 43115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600A86C RID: 43116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GClass2227 effectOnPlayerStatusCommandMessage)
		{
			throw null;
		}

		// Token: 0x0600A86D RID: 43117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass2230 headDeviceStatusCommandMessage)
		{
			throw null;
		}

		// Token: 0x0600A86E RID: 43118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GClass2253 takeDamageCommandMessage)
		{
			throw null;
		}

		// Token: 0x0600A86F RID: 43119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GClass2223 deathCommand)
		{
			throw null;
		}

		// Token: 0x0600A870 RID: 43120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GClass2237 physicalParametersCommandMessage)
		{
			throw null;
		}

		// Token: 0x0600A871 RID: 43121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(GClass2247 skillsParamsCommandMessage)
		{
			throw null;
		}

		// Token: 0x0600A872 RID: 43122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(GClass2245 voiceMuffledStatusMessage)
		{
			throw null;
		}

		// Token: 0x0600A873 RID: 43123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600A874 RID: 43124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(GClass2244 underRoofStatusMessage)
		{
			throw null;
		}

		// Token: 0x0600A875 RID: 43125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayFaceShieldSound(bool isOn)
		{
			throw null;
		}

		// Token: 0x0600A876 RID: 43126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayNightVisionSound(bool isOn)
		{
			throw null;
		}

		// Token: 0x0600A877 RID: 43127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlaySwitchHeadlightsSound()
		{
			throw null;
		}

		// Token: 0x0600A878 RID: 43128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayThermalVisionSound(bool isOn)
		{
			throw null;
		}

		// Token: 0x0600A879 RID: 43129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayFractureSound()
		{
			throw null;
		}

		// Token: 0x0600A87A RID: 43130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(bool isOn, AudioClip toggleOn, AudioClip toggleOff)
		{
			throw null;
		}

		// Token: 0x0600A87B RID: 43131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(AudioClip clip)
		{
			throw null;
		}

		// Token: 0x0600A87C RID: 43132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualUpdate()
		{
			throw null;
		}

		// Token: 0x0600A87D RID: 43133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayPhraseFromCommand(GClass2236 phraseCommandMessage)
		{
			throw null;
		}

		// Token: 0x0600A87E RID: 43134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(string soundBank)
		{
			throw null;
		}

		// Token: 0x0600A87F RID: 43135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPlayerGetDamage(float damage, EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x0600A880 RID: 43136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPlayerDeath(EBodyPart lastDamagedBodyPart, EDamageType lastDamageType)
		{
			throw null;
		}

		// Token: 0x0600A881 RID: 43137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(EPhraseTrigger @event, TaggedClip clip, TagBank bank, GClass1804 speaker)
		{
			throw null;
		}

		// Token: 0x0600A882 RID: 43138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(float speed, bool force = false)
		{
			throw null;
		}

		// Token: 0x0600A883 RID: 43139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(EPlayerState previousState, EPlayerState nextstate)
		{
			throw null;
		}

		// Token: 0x0600A884 RID: 43140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_16()
		{
			throw null;
		}

		// Token: 0x0600A885 RID: 43141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_17()
		{
			throw null;
		}

		// Token: 0x0600A886 RID: 43142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_18()
		{
			throw null;
		}

		// Token: 0x0600A887 RID: 43143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_19(float distance)
		{
			throw null;
		}

		// Token: 0x0600A888 RID: 43144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20()
		{
			throw null;
		}

		// Token: 0x0600A889 RID: 43145 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleMuteSpeechSource(bool muteSpeech)
		{
			throw null;
		}

		// Token: 0x0600A88A RID: 43146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21(TaggedClip clip, float time)
		{
			throw null;
		}

		// Token: 0x0600A88B RID: 43147 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22(TaggedClip clip)
		{
			throw null;
		}

		// Token: 0x0600A88C RID: 43148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_23(float spreadRange, bool buffer = true)
		{
			throw null;
		}

		// Token: 0x0600A88D RID: 43149 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_24(float spreadRange, bool buffer = true)
		{
			throw null;
		}

		// Token: 0x0600A88E RID: 43150 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_25()
		{
			throw null;
		}

		// Token: 0x0600A88F RID: 43151 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_26(float range, float delayToNextCheck = 0.1f)
		{
			throw null;
		}

		// Token: 0x0600A890 RID: 43152 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_27(bool isHeavyBreathing, bool breathIsAudible)
		{
			throw null;
		}

		// Token: 0x0600A891 RID: 43153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_28(bool isHeavyBreathing, bool force = false)
		{
			throw null;
		}

		// Token: 0x0600A892 RID: 43154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_29(bool force)
		{
			throw null;
		}

		// Token: 0x0600A893 RID: 43155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_30()
		{
			throw null;
		}

		// Token: 0x0600A894 RID: 43156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_31()
		{
			throw null;
		}

		// Token: 0x0600A895 RID: 43157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_32(bool onDeadPlayer = false)
		{
			throw null;
		}

		// Token: 0x0600A896 RID: 43158 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_33(GClass2248 contentMessage)
		{
			throw null;
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseSearchSource()
		{
			throw null;
		}

		// Token: 0x0600A898 RID: 43160 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_34()
		{
			throw null;
		}

		// Token: 0x0600A899 RID: 43161 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_35(float fallHeight, float jumpHeight)
		{
			throw null;
		}

		// Token: 0x0600A89A RID: 43162 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_36()
		{
			throw null;
		}

		// Token: 0x0600A89B RID: 43163 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_37()
		{
			throw null;
		}

		// Token: 0x0600A89C RID: 43164 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_38(EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x0600A89D RID: 43165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DefaultPlay(SoundBank bank, float volume = 1f, string signature = "", EAudioMovementState movementState = EAudioMovementState.None)
		{
			throw null;
		}

		// Token: 0x0600A89E RID: 43166 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_39()
		{
			throw null;
		}

		// Token: 0x0600A89F RID: 43167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_40()
		{
			throw null;
		}

		// Token: 0x0600A8A0 RID: 43168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_41()
		{
			throw null;
		}

		// Token: 0x0600A8A1 RID: 43169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_42(float volume = 1f)
		{
			throw null;
		}

		// Token: 0x0600A8A2 RID: 43170 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_43(float speed = 55f)
		{
			throw null;
		}

		// Token: 0x0600A8A3 RID: 43171 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_44()
		{
			throw null;
		}

		// Token: 0x0600A8A4 RID: 43172 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_45()
		{
			throw null;
		}

		// Token: 0x0600A8A5 RID: 43173 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_46()
		{
			throw null;
		}

		// Token: 0x0600A8A6 RID: 43174 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_47(EPhraseTrigger phraseTrigger, bool demand = false, float delay = 0f, ETagStatus mask = (ETagStatus)0, bool aggressive = false)
		{
			throw null;
		}

		// Token: 0x0600A8A7 RID: 43175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IncreaseAwareness(float aware = 5f)
		{
			throw null;
		}

		// Token: 0x0600A8A8 RID: 43176 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ValueTuple<bool, BaseBallistic.ESurfaceSound> method_48()
		{
			throw null;
		}

		// Token: 0x0600A8A9 RID: 43177 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_49(bool hit, BaseBallistic.ESurfaceSound surfaceSound)
		{
			throw null;
		}

		// Token: 0x0600A8AA RID: 43178 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_50(string profileID, EnvironmentType environmentType)
		{
			throw null;
		}

		// Token: 0x0600A8AB RID: 43179 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetPitchOnShot(Weapon shotWeapon)
		{
			throw null;
		}

		// Token: 0x0600A8AC RID: 43180 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_51()
		{
			throw null;
		}

		// Token: 0x0600A8AD RID: 43181 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_52(GClass2897 headphonesUpdateEvent)
		{
			throw null;
		}

		// Token: 0x0600A8AE RID: 43182 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_53()
		{
			throw null;
		}

		// Token: 0x0600A8AF RID: 43183 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_54()
		{
			throw null;
		}

		// Token: 0x0600A8B0 RID: 43184 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600A8B1 RID: 43185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_55()
		{
			throw null;
		}

		// Token: 0x0600A8B2 RID: 43186 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_56(Coroutine coroutine)
		{
			throw null;
		}

		// Token: 0x0600A8B3 RID: 43187 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_57()
		{
			throw null;
		}

		// Token: 0x0400AF18 RID: 44824
		[CompilerGenerated]
		private EnvironmentType environmentType_0;

		// Token: 0x0400AF19 RID: 44825
		[CompilerGenerated]
		private BaseSoundPlayer.SoundElement soundElement_0;

		// Token: 0x0400AF1A RID: 44826
		[CompilerGenerated]
		private BaseSoundPlayer.SoundElement soundElement_1;

		// Token: 0x0400AF1B RID: 44827
		[CompilerGenerated]
		private Action<EPhraseTrigger, int> action_0;

		// Token: 0x0400AF1C RID: 44828
		private static readonly EPhraseTrigger[] ephraseTrigger_0;

		// Token: 0x0400AF1D RID: 44829
		private const float float_0 = 60f;

		// Token: 0x0400AF1E RID: 44830
		private const int int_0 = 2;

		// Token: 0x0400AF1F RID: 44831
		private const float float_1 = 5f;

		// Token: 0x0400AF20 RID: 44832
		private const float float_2 = 0f;

		// Token: 0x0400AF21 RID: 44833
		private const float float_3 = 1f;

		// Token: 0x0400AF22 RID: 44834
		private const float float_4 = 0.4f;

		// Token: 0x0400AF23 RID: 44835
		private const float float_5 = 0.2f;

		// Token: 0x0400AF24 RID: 44836
		private const float float_6 = 0.14f;

		// Token: 0x0400AF25 RID: 44837
		private const float float_7 = 0.6f;

		// Token: 0x0400AF26 RID: 44838
		private const float float_8 = 0.5f;

		// Token: 0x0400AF27 RID: 44839
		private const float float_9 = 2.5f;

		// Token: 0x0400AF28 RID: 44840
		private const float float_10 = 0.35f;

		// Token: 0x0400AF29 RID: 44841
		private const float float_11 = 196f;

		// Token: 0x0400AF2A RID: 44842
		private const float float_12 = 4f;

		// Token: 0x0400AF2B RID: 44843
		private const float float_13 = 1f;

		// Token: 0x0400AF2C RID: 44844
		private const float float_14 = 0.5f;

		// Token: 0x0400AF2D RID: 44845
		private readonly Vector3 vector3_0;

		// Token: 0x0400AF2E RID: 44846
		private ObservedPlayerView observedPlayerView_0;

		// Token: 0x0400AF2F RID: 44847
		private bool bool_0;

		// Token: 0x0400AF30 RID: 44848
		private float float_15;

		// Token: 0x0400AF31 RID: 44849
		private float float_16;

		// Token: 0x0400AF32 RID: 44850
		private BaseBallistic.ESurfaceSound esurfaceSound_0;

		// Token: 0x0400AF33 RID: 44851
		private LayerMask layerMask_0;

		// Token: 0x0400AF34 RID: 44852
		private GClass1804 gclass1804_0;

		// Token: 0x0400AF35 RID: 44853
		private float float_17;

		// Token: 0x0400AF36 RID: 44854
		private bool bool_1;

		// Token: 0x0400AF37 RID: 44855
		private bool bool_2;

		// Token: 0x0400AF38 RID: 44856
		private BetterSource betterSource_0;

		// Token: 0x0400AF39 RID: 44857
		private BetterSource betterSource_1;

		// Token: 0x0400AF3A RID: 44858
		private BetterSource betterSource_2;

		// Token: 0x0400AF3B RID: 44859
		private bool bool_3;

		// Token: 0x0400AF3C RID: 44860
		private AudioClip audioClip_0;

		// Token: 0x0400AF3D RID: 44861
		private bool bool_4;

		// Token: 0x0400AF3E RID: 44862
		private bool bool_5;

		// Token: 0x0400AF3F RID: 44863
		private bool bool_6;

		// Token: 0x0400AF40 RID: 44864
		private AudioClip audioClip_1;

		// Token: 0x0400AF41 RID: 44865
		private AudioClip audioClip_2;

		// Token: 0x0400AF42 RID: 44866
		private AudioClip audioClip_3;

		// Token: 0x0400AF43 RID: 44867
		private AudioClip audioClip_4;

		// Token: 0x0400AF44 RID: 44868
		private AudioClip audioClip_5;

		// Token: 0x0400AF45 RID: 44869
		private AudioClip audioClip_6;

		// Token: 0x0400AF46 RID: 44870
		private AudioClip audioClip_7;

		// Token: 0x0400AF47 RID: 44871
		private Dictionary<BaseBallistic.ESurfaceSound, SurfaceSet> dictionary_0;

		// Token: 0x0400AF48 RID: 44872
		private SurfaceSet surfaceSet_0;

		// Token: 0x0400AF49 RID: 44873
		private SoundBank soundBank_0;

		// Token: 0x0400AF4A RID: 44874
		private SoundBank soundBank_1;

		// Token: 0x0400AF4B RID: 44875
		private Coroutine coroutine_0;

		// Token: 0x0400AF4C RID: 44876
		private Coroutine coroutine_1;

		// Token: 0x0400AF4D RID: 44877
		private Coroutine coroutine_2;

		// Token: 0x0400AF4E RID: 44878
		private Coroutine coroutine_3;

		// Token: 0x0400AF4F RID: 44879
		private bool bool_7;

		// Token: 0x0400AF50 RID: 44880
		private float float_18;

		// Token: 0x0400AF51 RID: 44881
		private bool bool_8;

		// Token: 0x0400AF52 RID: 44882
		private float float_19;

		// Token: 0x0400AF53 RID: 44883
		private float float_20;

		// Token: 0x0400AF54 RID: 44884
		private float float_21;

		// Token: 0x0400AF55 RID: 44885
		private float float_22;

		// Token: 0x0400AF56 RID: 44886
		private float float_23;

		// Token: 0x0400AF57 RID: 44887
		private float float_24;

		// Token: 0x0400AF58 RID: 44888
		private float float_25;

		// Token: 0x0400AF59 RID: 44889
		private Dictionary<GClass2230.EHeadDeviceType, bool> dictionary_1;

		// Token: 0x0400AF5A RID: 44890
		private float float_26;

		// Token: 0x0400AF5B RID: 44891
		private float float_27;

		// Token: 0x0400AF5C RID: 44892
		private bool bool_9;

		// Token: 0x0400AF5D RID: 44893
		private Action action_1;

		// Token: 0x0400AF5E RID: 44894
		private ETagStatus etagStatus_0;

		// Token: 0x0400AF5F RID: 44895
		private float float_28;

		// Token: 0x0400AF60 RID: 44896
		private bool bool_10;

		// Token: 0x0400AF61 RID: 44897
		private float float_29;

		// Token: 0x0400AF62 RID: 44898
		private float float_30;

		// Token: 0x0400AF63 RID: 44899
		private float float_31;

		// Token: 0x0400AF64 RID: 44900
		private float float_32;

		// Token: 0x0400AF65 RID: 44901
		private bool bool_11;

		// Token: 0x0400AF66 RID: 44902
		private float float_33;

		// Token: 0x0400AF67 RID: 44903
		private GenericEventTranslator genericEventTranslator_0;

		// Token: 0x0400AF68 RID: 44904
		private bool bool_12;

		// Token: 0x0400AF69 RID: 44905
		private float float_34;

		// Token: 0x0400AF6A RID: 44906
		private float float_35;

		// Token: 0x0400AF6B RID: 44907
		private float float_36;

		// Token: 0x0400AF6C RID: 44908
		private float float_37;

		// Token: 0x0400AF6D RID: 44909
		private float float_38;

		// Token: 0x0400AF6E RID: 44910
		private float float_39;

		// Token: 0x0400AF6F RID: 44911
		private float float_40;

		// Token: 0x0400AF70 RID: 44912
		private GClass2384 gclass2384_0;

		// Token: 0x0400AF71 RID: 44913
		private bool bool_13;

		// Token: 0x0400AF72 RID: 44914
		private GInterface58 ginterface58_0;

		// Token: 0x0400AF73 RID: 44915
		private GClass2156 gclass2156_0;

		// Token: 0x0400AF74 RID: 44916
		private GClass2156 gclass2156_1;

		// Token: 0x0400AF75 RID: 44917
		private GClass2156 gclass2156_2;

		// Token: 0x0400AF76 RID: 44918
		private Action action_2;

		// Token: 0x02001FC0 RID: 8128
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1830
		{
			// Token: 0x0600A8B4 RID: 43188 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400AF77 RID: 44919
			public static readonly ObservedPlayerAudioController.Class1830 class1830_0;

			// Token: 0x0400AF78 RID: 44920
			public static Action action_0;
		}
	}
}
