using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Cutscene
{
	// Token: 0x02000CAE RID: 3246
	[RequireComponent(typeof(PlayableDirector))]
	public class BlendingDirector : MonoBehaviour
	{
		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060045D0 RID: 17872 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsPlaying
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060045D1 RID: 17873 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060045D2 RID: 17874 RVA: 0x00002050 File Offset: 0x00000250
		public BlendingDirector.BlendType CurrentBlend
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

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060045D3 RID: 17875 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsBlending
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060045D4 RID: 17876 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsBlendingOut
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060045D5 RID: 17877 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsBlendingIn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060045D6 RID: 17878 RVA: 0x00002050 File Offset: 0x00000250
		public double TimeRemaining
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060045D7 RID: 17879 RVA: 0x00002050 File Offset: 0x00000250
		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Play(float blendInDuration = 0.5f, float blendOutDuration = 0.5f, float startTime = -1f, float endTime = -1f, Action onBlendInFinished = null, Action onFinished = null)
		{
			throw null;
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop(float blendDuration = 0.5f, Action onFinished = null)
		{
			throw null;
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Seek(float toTime, float blendDuration, Action onFinished = null)
		{
			throw null;
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_2(PlayableDirector director, AnimationPlayableOutput output, float blendTime, float fromWeight = 1f, Action onFinished = null)
		{
			throw null;
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_3(PlayableDirector director, AnimationPlayableOutput output, float blendTime, float startTime = -1f, Action onFinished = null)
		{
			throw null;
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_4(float blendTime, float startTime = -1f, Action onFinished = null)
		{
			throw null;
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x04005093 RID: 20627
		[SerializeField]
		private PlayableDirector _playableDirector;

		// Token: 0x04005094 RID: 20628
		[CompilerGenerated]
		private BlendingDirector.BlendType blendType_0;

		// Token: 0x04005095 RID: 20629
		private AnimationPlayableOutput animationPlayableOutput_0;

		// Token: 0x04005096 RID: 20630
		private Playable playable_0;

		// Token: 0x04005097 RID: 20631
		private Playable playable_1;

		// Token: 0x04005098 RID: 20632
		private AnimationMixerPlayable animationMixerPlayable_0;

		// Token: 0x04005099 RID: 20633
		private int int_0;

		// Token: 0x0400509A RID: 20634
		private int int_1;

		// Token: 0x0400509B RID: 20635
		private float float_0;

		// Token: 0x0400509C RID: 20636
		private float float_1;

		// Token: 0x0400509D RID: 20637
		private TrackAsset trackAsset_0;

		// Token: 0x0400509E RID: 20638
		private double double_0;

		// Token: 0x0400509F RID: 20639
		private Action action_0;

		// Token: 0x040050A0 RID: 20640
		private float float_2;

		// Token: 0x040050A1 RID: 20641
		private AnimationPlayableOutput animationPlayableOutput_1;

		// Token: 0x040050A2 RID: 20642
		private int int_2;

		// Token: 0x040050A3 RID: 20643
		private Stopwatch stopwatch_0;

		// Token: 0x040050A4 RID: 20644
		private static bool bool_0;

		// Token: 0x040050A5 RID: 20645
		private Coroutine coroutine_0;

		// Token: 0x040050A6 RID: 20646
		private Coroutine coroutine_1;

		// Token: 0x040050A7 RID: 20647
		private Coroutine coroutine_2;

		// Token: 0x040050A8 RID: 20648
		private string string_0;

		// Token: 0x02000CAF RID: 3247
		public enum BlendType
		{
			// Token: 0x040050AA RID: 20650
			None,
			// Token: 0x040050AB RID: 20651
			In,
			// Token: 0x040050AC RID: 20652
			Out,
			// Token: 0x040050AD RID: 20653
			Seek
		}

		// Token: 0x02000CB0 RID: 3248
		[CompilerGenerated]
		private sealed class Class646
		{
			// Token: 0x060045E5 RID: 17893 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x040050AE RID: 20654
			public Action onBlendInFinished;

			// Token: 0x040050AF RID: 20655
			public BlendingDirector blendingDirector_0;
		}

		// Token: 0x02000CB1 RID: 3249
		[CompilerGenerated]
		private sealed class Class647
		{
			// Token: 0x060045E6 RID: 17894 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x040050B0 RID: 20656
			public Action onFinished;

			// Token: 0x040050B1 RID: 20657
			public BlendingDirector blendingDirector_0;
		}

		// Token: 0x02000CB2 RID: 3250
		[CompilerGenerated]
		private sealed class Class648
		{
			// Token: 0x060045E7 RID: 17895 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x040050B2 RID: 20658
			public Action onFinished;

			// Token: 0x040050B3 RID: 20659
			public BlendingDirector blendingDirector_0;
		}
	}
}
