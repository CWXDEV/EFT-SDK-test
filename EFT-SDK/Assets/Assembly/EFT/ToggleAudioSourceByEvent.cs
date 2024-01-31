using System;
using System.Runtime.CompilerServices;
using EFT.GlobalEvents;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001789 RID: 6025
	public class ToggleAudioSourceByEvent : MonoBehaviour
	{
		// Token: 0x060080A1 RID: 32929 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060080A2 RID: 32930 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060080A3 RID: 32931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(BaseEventFilter eventFilter, GClass2885 invokedEvent)
		{
			throw null;
		}

		// Token: 0x060080A4 RID: 32932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(BaseEventFilter eventFilter, GClass2885 invokedEvent)
		{
			throw null;
		}

		// Token: 0x04008955 RID: 35157
		[SerializeField]
		private AudioSource _audioSource;

		// Token: 0x04008956 RID: 35158
		[SerializeField]
		private BaseEventFilter _enableAudioByFilter;

		// Token: 0x04008957 RID: 35159
		[SerializeField]
		private BaseEventFilter _disableAudioByFilter;
	}
}
