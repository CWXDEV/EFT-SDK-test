using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000810 RID: 2064
public class ParticleForceFieldsDemo_CameraRig : MonoBehaviour
{
	// Token: 0x06002F86 RID: 12166 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06002F87 RID: 12167 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x04002EA3 RID: 11939
	public Transform pivot;

	// Token: 0x04002EA4 RID: 11940
	private Vector3 vector3_0;

	// Token: 0x04002EA5 RID: 11941
	[Range(0f, 90f)]
	public float rotationLimit;

	// Token: 0x04002EA6 RID: 11942
	public float rotationSpeed;

	// Token: 0x04002EA7 RID: 11943
	public float rotationLerpSpeed;

	// Token: 0x04002EA8 RID: 11944
	private Vector3 vector3_1;
}
