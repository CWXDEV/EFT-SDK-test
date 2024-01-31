using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000673 RID: 1651
[Serializable]
public struct InitialPosition
{
	// Token: 0x060025D7 RID: 9687 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x040024E0 RID: 9440
	public Transform Transform;

	// Token: 0x040024E1 RID: 9441
	public Rigidbody Rigidbody;

	// Token: 0x040024E2 RID: 9442
	public Vector3 Positioin;

	// Token: 0x040024E3 RID: 9443
	public Quaternion Rotation;

	// Token: 0x040024E4 RID: 9444
	public bool IsKinematic;
}
