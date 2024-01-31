using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Timeline;

namespace Cutscene
{
	// Token: 0x02000CB6 RID: 3254
	public class CutsceneDirectorBlender : MonoBehaviour
	{
		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsTimelinePlaying
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060045F5 RID: 17909 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060045F6 RID: 17910 RVA: 0x00002050 File Offset: 0x00000250
		public BlendingDirector Current
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Play(TimelineAsset timeline, bool playImmediately = true, float transitionTime = 0.5f)
		{
			throw null;
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Play(List<TimelineAsset> timelineSequence, bool playImmediately = true, float transitionTime = 0.5f)
		{
			throw null;
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0(TimelineAsset t)
		{
			throw null;
		}

		// Token: 0x040050CD RID: 20685
		[SerializeField]
		private List<BlendingDirector> _blendingDirectors;

		// Token: 0x040050CE RID: 20686
		[SerializeField]
		[Header("Debug test loop blending")]
		private bool _playAll;

		// Token: 0x040050CF RID: 20687
		[CompilerGenerated]
		private BlendingDirector blendingDirector_0;

		// Token: 0x040050D0 RID: 20688
		private Dictionary<TimelineAsset, BlendingDirector> dictionary_0;

		// Token: 0x040050D1 RID: 20689
		private Queue<BlendingDirector> queue_0;

		// Token: 0x02000CB7 RID: 3255
		[CompilerGenerated]
		[Serializable]
		private sealed class Class652
		{
			// Token: 0x060045FC RID: 17916 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BlendingDirector d)
			{
				throw null;
			}

			// Token: 0x040050D2 RID: 20690
			public static readonly CutsceneDirectorBlender.Class652 class652_0;

			// Token: 0x040050D3 RID: 20691
			public static Func<BlendingDirector, bool> func_0;
		}
	}
}
