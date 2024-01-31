using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Video;

namespace EFT.Hideout
{
	// Token: 0x02001A91 RID: 6801
	[RequireComponent(typeof(VideoPlayer))]
	public sealed class VideoAmbiance : InteractiveAmbianceObject<VideoAmbiance.VideoPlaybackSettings>
	{
		// Token: 0x06008F3A RID: 36666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06008F3B RID: 36667 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06008F3C RID: 36668 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x06008F3D RID: 36669 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(VideoClip lastClip)
		{
			throw null;
		}

		// Token: 0x06008F3E RID: 36670 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void videoPlayer_0_loopPointReached(VideoPlayer source)
		{
			throw null;
		}

		// Token: 0x06008F3F RID: 36671 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task<bool> PerformInteraction(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x06008F40 RID: 36672 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06008F41 RID: 36673 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_2(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x04009679 RID: 38521
		private VideoPlayer videoPlayer_0;

		// Token: 0x0400967A RID: 38522
		private Stopwatch stopwatch_0;

		// Token: 0x0400967B RID: 38523
		private Dictionary<ELightStatus, VideoAmbiance.Class1594> dictionary_1;

		// Token: 0x02001A92 RID: 6802
		private sealed class Class1594
		{
			// Token: 0x0400967C RID: 38524
			public VideoClip VideoClip;

			// Token: 0x0400967D RID: 38525
			public float CurrentTime;
		}

		// Token: 0x02001A93 RID: 6803
		[Serializable]
		public sealed class VideoPlaybackSettings
		{
			// Token: 0x06008F42 RID: 36674 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public VideoClip GetRandomClip(VideoClip lastClip)
			{
				throw null;
			}

			// Token: 0x0400967E RID: 38526
			public List<VideoClip> VideoClips;

			// Token: 0x0400967F RID: 38527
			public bool PlayerEnabled;
		}
	}
}
