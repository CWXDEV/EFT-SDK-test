using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001787 RID: 6023
	public class SubtitlesEventFire : MonoBehaviour
	{
		// Token: 0x0600809F RID: 32927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0400894E RID: 35150
		public const string SUBTITLES_PREFIX = "Subtitles";

		// Token: 0x0400894F RID: 35151
		[SerializeField]
		private AudioSource _audioSource;

		// Token: 0x04008950 RID: 35152
		[SerializeField]
		private ESubtitlesSource _source;

		// Token: 0x04008951 RID: 35153
		private bool bool_0;
	}
}
