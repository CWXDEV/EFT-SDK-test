using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Audio.Data
{
	// Token: 0x02000D68 RID: 3432
	[CreateAssetMenu(menuName = "Scriptable objects/Audio/SoundBankWithSettings", fileName = "SoundBankWithSettings")]
	[Serializable]
	public class SoundBankWithSettings : ScriptableObject
	{
		// Token: 0x060048F7 RID: 18679 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetRandomClip(out AudioClip clip, bool ignoreExcluded = false)
		{
			throw null;
		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private AudioClip method_0()
		{
			throw null;
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private AudioClip method_1()
		{
			throw null;
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x040053D7 RID: 21463
		[SerializeField]
		private List<AudioClip> Clips;

		// Token: 0x040053D8 RID: 21464
		[Range(0f, 5f)]
		public int Importance;

		// Token: 0x040053D9 RID: 21465
		[Range(0f, 1f)]
		public float BaseVolume;

		// Token: 0x040053DA RID: 21466
		[Range(0f, 1000f)]
		public float Rolloff;

		// Token: 0x040053DB RID: 21467
		private List<AudioClip> _excludedClips;

		// Token: 0x040053DC RID: 21468
		private List<AudioClip> _includedClips;
	}
}
