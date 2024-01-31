using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.NPC
{
	// Token: 0x02001C89 RID: 7305
	public class NPCFootStepsSoundPlayer : MonoBehaviour
	{
		// Token: 0x060098B4 RID: 39092 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060098B5 RID: 39093 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060098B6 RID: 39094 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x060098B7 RID: 39095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_1()
		{
			throw null;
		}

		// Token: 0x04009FE8 RID: 40936
		[SerializeField]
		private Animator _npcAnimator;

		// Token: 0x04009FE9 RID: 40937
		[SerializeField]
		private AudioSource _stepAudioSource;

		// Token: 0x04009FEA RID: 40938
		[SerializeField]
		private List<AudioClip> _footstepClips;

		// Token: 0x04009FEB RID: 40939
		private bool bool_0;

		// Token: 0x04009FEC RID: 40940
		private Coroutine coroutine_0;
	}
}
