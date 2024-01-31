using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001AB1 RID: 6833
	public sealed class HideoutAudioBackground : MonoBehaviour
	{
		// Token: 0x06008FEF RID: 36847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06008FF0 RID: 36848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x06008FF1 RID: 36849 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Play()
		{
			throw null;
		}

		// Token: 0x06008FF2 RID: 36850 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitArea(AreaData areaData)
		{
			throw null;
		}

		// Token: 0x06008FF3 RID: 36851 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(AreaData areaData)
		{
			throw null;
		}

		// Token: 0x06008FF4 RID: 36852 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06008FF5 RID: 36853 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x04009727 RID: 38695
		[SerializeField]
		private AudioSource _hollowAudioSource;

		// Token: 0x04009728 RID: 38696
		[SerializeField]
		private List<AudioSource> _inhabitedAudioSources;

		// Token: 0x04009729 RID: 38697
		[SerializeField]
		private AudioClip _hollowAmbiance;

		// Token: 0x0400972A RID: 38698
		[SerializeField]
		[Range(0f, 1f)]
		private float _masterVolume;

		// Token: 0x0400972B RID: 38699
		private float float_0;

		// Token: 0x0400972C RID: 38700
		private float float_1;

		// Token: 0x0400972D RID: 38701
		private float float_2;

		// Token: 0x0400972E RID: 38702
		private float float_3;

		// Token: 0x0400972F RID: 38703
		private readonly Dictionary<EAreaType, float> dictionary_0;

		// Token: 0x04009730 RID: 38704
		private readonly List<Action> list_0;

		// Token: 0x04009731 RID: 38705
		private bool bool_0;

		// Token: 0x02001AB2 RID: 6834
		[CompilerGenerated]
		private sealed class Class1600
		{
			// Token: 0x06008FF6 RID: 36854 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009732 RID: 38706
			public HideoutAudioBackground hideoutAudioBackground_0;

			// Token: 0x04009733 RID: 38707
			public AreaData areaData;
		}
	}
}
