using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.NPC
{
	// Token: 0x02001C85 RID: 7301
	public class NPCAdditionalSoundPlayer : MonoBehaviour
	{
		// Token: 0x0600987B RID: 39035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600987C RID: 39036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600987D RID: 39037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(string soundID)
		{
			throw null;
		}

		// Token: 0x04009FDA RID: 40922
		[SerializeField]
		private NPCAnimationsEventReceiver _animationsEventReceiver;

		// Token: 0x04009FDB RID: 40923
		[SerializeField]
		private Transform _transformForPlaySounds;

		// Token: 0x04009FDC RID: 40924
		[SerializeField]
		private List<NPCAdditionalSoundPlayer.AudioClipWithID> _clips;

		// Token: 0x04009FDD RID: 40925
		private Dictionary<string, AudioClip> dictionary_0;

		// Token: 0x02001C86 RID: 7302
		[Serializable]
		public struct AudioClipWithID
		{
			// Token: 0x04009FDE RID: 40926
			public string ID;

			// Token: 0x04009FDF RID: 40927
			public AudioClip clip;
		}
	}
}
