using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200088B RID: 2187
public class AudioSourceCulling : MonoBehaviour
{
	// Token: 0x0600313B RID: 12603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x0600313C RID: 12604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Register(AudioSource audioSource)
	{
		throw null;
	}

	// Token: 0x0600313D RID: 12605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(AudioSource audioSource)
	{
		throw null;
	}

	// Token: 0x0600313E RID: 12606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CleanRegisteredAudioSources()
	{
		throw null;
	}

	// Token: 0x0600313F RID: 12607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_0()
	{
		throw null;
	}

	// Token: 0x04003267 RID: 12903
	private const int int_0 = 10;

	// Token: 0x04003268 RID: 12904
	private int int_1;

	// Token: 0x04003269 RID: 12905
	[SerializeField]
	private List<AudioSourceCulling.AudioSourceData> _audioSources;

	// Token: 0x0400326A RID: 12906
	private Transform transform_0;

	// Token: 0x0200088C RID: 2188
	[Serializable]
	private struct AudioSourceData
	{
		// Token: 0x0400326B RID: 12907
		public AudioSource AudioSource;

		// Token: 0x0400326C RID: 12908
		public Transform Transform;

		// Token: 0x0400326D RID: 12909
		public float SqrCullDistance;
	}
}
