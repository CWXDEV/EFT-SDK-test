using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

namespace EFT
{
	// Token: 0x0200177F RID: 6015
	public class SoundController : MonoBehaviour
	{
		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06008083 RID: 32899 RVA: 0x00002050 File Offset: 0x00000250
		public static SoundController Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008084 RID: 32900 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06008085 RID: 32901 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0()
		{
			throw null;
		}

		// Token: 0x06008086 RID: 32902 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float Distance(Vector3 target)
		{
			throw null;
		}

		// Token: 0x06008087 RID: 32903 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAudioListener(AudioListener listener)
		{
			throw null;
		}

		// Token: 0x04008928 RID: 35112
		public AudioMixerGroup OccludedGroup;

		// Token: 0x04008929 RID: 35113
		public AudioMixerGroup DirectGroup;

		// Token: 0x0400892A RID: 35114
		public AudioMixerGroup ObstructedGroup;

		// Token: 0x0400892B RID: 35115
		public Transform AudioListenerTransform;

		// Token: 0x0400892C RID: 35116
		private static SoundController soundController_0;
	}
}
