using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Audio;

namespace EFT.UI
{
	// Token: 0x0200298C RID: 10636
	public sealed class GUISounds : MonoBehaviour
	{
		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x0600D388 RID: 54152 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D389 RID: 54153 RVA: 0x00002050 File Offset: 0x00000250
		public AudioMixer MasterMixer
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

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x0600D38A RID: 54154 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D38B RID: 54155 RVA: 0x00002050 File Offset: 0x00000250
		public bool BackgroundMusicActive
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

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x0600D38C RID: 54156 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D38D RID: 54157 RVA: 0x00002050 File Offset: 0x00000250
		public bool HideoutSoundActive
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

		// Token: 0x0600D38E RID: 54158 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_0(AudioSource audioSource)
		{
			throw null;
		}

		// Token: 0x0600D38F RID: 54159 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x0600D390 RID: 54160 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlaySound(AudioClip clip, bool single = false, bool commonUiSound = false)
		{
			throw null;
		}

		// Token: 0x0600D391 RID: 54161 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task ForcePlaySound(AudioClip clip)
		{
			throw null;
		}

		// Token: 0x0600D392 RID: 54162 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayItemSound(string soundGroup, EInventorySoundType soundType, bool single = false)
		{
			throw null;
		}

		// Token: 0x0600D393 RID: 54163 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PlayItemSound(EModClass itemClass)
		{
			throw null;
		}

		// Token: 0x0600D394 RID: 54164 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(ExitStatus exitStatus)
		{
			throw null;
		}

		// Token: 0x0600D395 RID: 54165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3()
		{
			throw null;
		}

		// Token: 0x0600D396 RID: 54166 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_4()
		{
			throw null;
		}

		// Token: 0x0600D397 RID: 54167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopMenuBackgroundMusicWithDelay(float transitionTime = 1f)
		{
			throw null;
		}

		// Token: 0x0600D398 RID: 54168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D399 RID: 54169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_6(bool isActive)
		{
			throw null;
		}

		// Token: 0x0600D39A RID: 54170 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_7(bool active)
		{
			throw null;
		}

		// Token: 0x0600D39B RID: 54171 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioClip GetItemClip(string soundGroup, EInventorySoundType soundType)
		{
			throw null;
		}

		// Token: 0x0600D39C RID: 54172 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioClip GetLootingClip(string fileName)
		{
			throw null;
		}

		// Token: 0x0600D39D RID: 54173 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayUILoadSound()
		{
			throw null;
		}

		// Token: 0x0600D39E RID: 54174 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayUIUnloadSound()
		{
			throw null;
		}

		// Token: 0x0600D39F RID: 54175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayUISound(EUISoundType soundType)
		{
			throw null;
		}

		// Token: 0x0600D3A0 RID: 54176 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayChatSound(ESocialNetworkSoundType soundType)
		{
			throw null;
		}

		// Token: 0x0600D3A1 RID: 54177 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayEndGameSound(EEndGameSoundType soundType)
		{
			throw null;
		}

		// Token: 0x0600D3A2 RID: 54178 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayNotificationSound()
		{
			throw null;
		}

		// Token: 0x0600D3A3 RID: 54179 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private AudioMixerGroup method_8()
		{
			throw null;
		}

		// Token: 0x0600D3A4 RID: 54180 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_9()
		{
			throw null;
		}

		// Token: 0x0600D3A5 RID: 54181 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0400D5D7 RID: 54743
		private const float float_0 = 0.15f;

		// Token: 0x0400D5D8 RID: 54744
		private AudioSource audioSource_0;

		// Token: 0x0400D5D9 RID: 54745
		private AudioSource audioSource_1;

		// Token: 0x0400D5DA RID: 54746
		private AudioSource audioSource_2;

		// Token: 0x0400D5DB RID: 54747
		private AudioSource audioSource_3;

		// Token: 0x0400D5DC RID: 54748
		private AudioSource audioSource_4;

		// Token: 0x0400D5DD RID: 54749
		private AudioMixer audioMixer_0;

		// Token: 0x0400D5DE RID: 54750
		private Coroutine coroutine_0;

		// Token: 0x0400D5DF RID: 54751
		private const string string_0 = "Audio/Music/";

		// Token: 0x0400D5E0 RID: 54752
		private AudioClip[] audioClip_0;

		// Token: 0x0400D5E1 RID: 54753
		private int int_0;

		// Token: 0x0400D5E2 RID: 54754
		private ItemSounds itemSounds_0;

		// Token: 0x0400D5E3 RID: 54755
		private UISoundsWrapper uisoundsWrapper_0;

		// Token: 0x0400D5E4 RID: 54756
		private CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x0400D5E5 RID: 54757
		private AudioMixerGroup audioMixerGroup_0;

		// Token: 0x0400D5E6 RID: 54758
		private AudioMixerGroup audioMixerGroup_1;

		// Token: 0x0400D5E7 RID: 54759
		[CompilerGenerated]
		private AudioMixer audioMixer_1;

		// Token: 0x0400D5E8 RID: 54760
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400D5E9 RID: 54761
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x0200298F RID: 10639
		[CompilerGenerated]
		private sealed class Class2433
		{
			// Token: 0x0600D3AA RID: 54186 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(AudioClip x)
			{
				throw null;
			}

			// Token: 0x0400D5FA RID: 54778
			public string fileName;
		}
	}
}
