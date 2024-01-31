using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x0200177C RID: 6012
	[Serializable]
	public class SoundBank : ScriptableObject
	{
		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x0600806D RID: 32877 RVA: 0x00002050 File Offset: 0x00000250
		public float RandomVolume
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x0600806E RID: 32878 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600806F RID: 32879 RVA: 0x00002050 File Offset: 0x00000250
		public float ClipLength
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

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x06008070 RID: 32880 RVA: 0x00002050 File Offset: 0x00000250
		public float[] BlendValues
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008071 RID: 32881 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Shuffle(byte ln)
		{
			throw null;
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetRandomClipIndex(int ln)
		{
			throw null;
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioClip PickSingleClip(int environment)
		{
			throw null;
		}

		// Token: 0x06008074 RID: 32884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PickClipsByDistance(ref AudioClip clip1, ref AudioClip clip2, ref float proportions, int environment, float distance)
		{
			throw null;
		}

		// Token: 0x06008075 RID: 32885 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(DistanceVarity clips, ref AudioClip clip)
		{
			throw null;
		}

		// Token: 0x06008076 RID: 32886 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float PlayOn(BetterSource source, EnvironmentType pos = EnvironmentType.Outdoor, float distance = 0f, float volume = 1f, bool forceStereo = false)
		{
			throw null;
		}

		// Token: 0x06008077 RID: 32887 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float PlayWithConstantRolloffDistance(BetterSource source, EnvironmentType pos = EnvironmentType.Outdoor, float distance = 0f, float volume = 1f, float blendParameter = 0f, bool forceStereo = false)
		{
			throw null;
		}

		// Token: 0x06008078 RID: 32888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float PlayWithCustomRolloffDistance(BetterSource source, EnvironmentType pos = EnvironmentType.Outdoor, float distance = 0f, float volume = 1f, float blendParameter = 0f, bool forceStereo = false, float customRolloff = 120f)
		{
			throw null;
		}

		// Token: 0x06008079 RID: 32889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float PlayOnScheduled(BetterSource source, double time, EnvironmentType pos = EnvironmentType.Outdoor, float distance = 0f, float volume = 1f)
		{
			throw null;
		}

		// Token: 0x0600807A RID: 32890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float PickClips(float distance, ref AudioClip clip1, ref AudioClip clip2, ref float proportions, EnvironmentType pos = EnvironmentType.Outdoor)
		{
			throw null;
		}

		// Token: 0x0600807B RID: 32891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(BetterSource source, float d)
		{
			throw null;
		}

		// Token: 0x0600807C RID: 32892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_2(AudioClip audioClip)
		{
			throw null;
		}

		// Token: 0x04008919 RID: 35097
		public float CustomLength;

		// Token: 0x0400891A RID: 35098
		public float BaseVolume;

		// Token: 0x0400891B RID: 35099
		public float DeltaVolume;

		// Token: 0x0400891C RID: 35100
		public float Rolloff;

		// Token: 0x0400891D RID: 35101
		public bool IgnoreOcclusion;

		// Token: 0x0400891E RID: 35102
		public bool Physical;

		// Token: 0x0400891F RID: 35103
		public bool _noEnvironment;

		// Token: 0x04008920 RID: 35104
		public BetterAudio.AudioSourceGroupType SourceType;

		// Token: 0x04008921 RID: 35105
		[SerializeField]
		private float _clipLiength;

		// Token: 0x04008922 RID: 35106
		public EnvironmentVariety[] Environments;

		// Token: 0x04008923 RID: 35107
		public DistanceBlendOptions BlendOptions;

		// Token: 0x04008924 RID: 35108
		private byte[] _shuffle;

		// Token: 0x04008925 RID: 35109
		private byte _shuffleIndex;
	}
}
