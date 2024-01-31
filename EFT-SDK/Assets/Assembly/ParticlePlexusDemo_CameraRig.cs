using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000811 RID: 2065
public class ParticlePlexusDemo_CameraRig : MonoBehaviour
{
	// Token: 0x06002F88 RID: 12168 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06002F89 RID: 12169 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x04002EA9 RID: 11945
	public Transform pivot;

	// Token: 0x04002EAA RID: 11946
	private Vector3 vector3_0;

	// Token: 0x04002EAB RID: 11947
	[Range(0f, 90f)]
	public float rotationLimit;

	// Token: 0x04002EAC RID: 11948
	public float rotationSpeed;

	// Token: 0x04002EAD RID: 11949
	public float rotationLerpSpeed;

	// Token: 0x04002EAE RID: 11950
	private Vector3 vector3_1;
}
