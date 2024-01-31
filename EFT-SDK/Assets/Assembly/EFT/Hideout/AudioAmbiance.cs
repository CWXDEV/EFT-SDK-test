using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001A70 RID: 6768
	[RequireComponent(typeof(AudioArray))]
	public sealed class AudioAmbiance : InteractiveAmbianceObject<IAudioPlaybackSettings>
	{
		// Token: 0x06008ED1 RID: 36561 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06008ED2 RID: 36562 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06008ED3 RID: 36563 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task<bool> PerformInteraction(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x06008ED4 RID: 36564 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06008ED5 RID: 36565 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_1(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x04009616 RID: 38422
		private AudioArray audioArray_0;

		// Token: 0x02001A71 RID: 6769
		[Serializable]
		public sealed class MuteSettings : IAudioPlaybackSettings
		{
			// Token: 0x06008ED6 RID: 36566 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Play(AudioArray audioArray, ELightStatus status, bool firstStart)
			{
				throw null;
			}

			// Token: 0x06008ED7 RID: 36567 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Pause(AudioArray audioArray)
			{
				throw null;
			}
		}

		// Token: 0x02001A72 RID: 6770
		[Serializable]
		public sealed class SimpleAudioSettings : IAudioPlaybackSettings
		{
			// Token: 0x06008ED8 RID: 36568 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Play(AudioArray audioArray, ELightStatus status, bool firstStart)
			{
				throw null;
			}

			// Token: 0x06008ED9 RID: 36569 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Pause(AudioArray audioArray)
			{
				throw null;
			}

			// Token: 0x04009617 RID: 38423
			[SerializeField]
			private AudioClip _audioClip;

			// Token: 0x04009618 RID: 38424
			[SerializeField]
			private bool _loop;
		}

		// Token: 0x02001A73 RID: 6771
		[Serializable]
		public sealed class PlaybackSettings : IAudioPlaybackSettings
		{
			// Token: 0x170015A0 RID: 5536
			// (get) Token: 0x06008EDA RID: 36570 RVA: 0x00002050 File Offset: 0x00000250
			public AudioSequence AudioSequence
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06008EDB RID: 36571 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Play(AudioArray audioArray, ELightStatus status, bool firstStart)
			{
				throw null;
			}

			// Token: 0x06008EDC RID: 36572 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Pause(AudioArray audioArray)
			{
				throw null;
			}

			// Token: 0x04009619 RID: 38425
			[SerializeField]
			private AudioSequence _audioSequence;
		}

		// Token: 0x02001A74 RID: 6772
		[Serializable]
		public sealed class ContinuingPlaybackSettings : IAudioPlaybackSettings
		{
			// Token: 0x06008EDD RID: 36573 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Pause(AudioArray audioArray)
			{
				throw null;
			}

			// Token: 0x06008EDE RID: 36574 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Play(AudioArray audioArray, ELightStatus status, bool firstStart)
			{
				throw null;
			}

			// Token: 0x0400961A RID: 38426
			public List<AudioClip> TrackList;

			// Token: 0x0400961B RID: 38427
			private float _currentTime;

			// Token: 0x0400961C RID: 38428
			private Stopwatch _stopwatch;

			// Token: 0x0400961D RID: 38429
			private AudioClip _currentClip;

			// Token: 0x02001A75 RID: 6773
			[CompilerGenerated]
			private sealed class Class1593
			{
				// Token: 0x06008EDF RID: 36575 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x0400961E RID: 38430
				public AudioAmbiance.ContinuingPlaybackSettings continuingPlaybackSettings_0;

				// Token: 0x0400961F RID: 38431
				public AudioArray audioArray;

				// Token: 0x04009620 RID: 38432
				public ELightStatus status;
			}
		}
	}
}
