using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B75 RID: 2933
[ExecuteInEditMode]
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public class RainControllerOld : MonoBehaviour
{
	// Token: 0x06003FA4 RID: 16292 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTriggerEnter(Collider col)
	{
		throw null;
	}

	// Token: 0x06003FA5 RID: 16293 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTriggerExit(Collider col)
	{
		throw null;
	}

	// Token: 0x06003FA6 RID: 16294 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x040047B6 RID: 18358
	[SerializeField]
	private AudioSource _waterAudio;

	// Token: 0x040047B7 RID: 18359
	[SerializeField]
	private float _maxAudioVolume;

	// Token: 0x040047B8 RID: 18360
	[SerializeField]
	private float _minAudioVolume;

	// Token: 0x040047B9 RID: 18361
	[SerializeField]
	private AnimationCurve _fadeCurve;

	// Token: 0x040047BA RID: 18362
	[SerializeField]
	private float _evaluationTime;

	// Token: 0x040047BB RID: 18363
	private float float_0;

	// Token: 0x040047BC RID: 18364
	private int int_0;
}
