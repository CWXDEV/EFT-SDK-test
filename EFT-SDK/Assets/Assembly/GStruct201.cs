using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020015DE RID: 5598
[StructLayout(LayoutKind.Auto)]
public struct GStruct201
{
	// Token: 0x06007A53 RID: 31315 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct201 Create(ICharacterController characterController)
	{
		throw null;
	}

	// Token: 0x04007EDF RID: 32479
	public bool isEnabled;

	// Token: 0x04007EE0 RID: 32480
	public Vector3 center;

	// Token: 0x04007EE1 RID: 32481
	public bool detectCollisions;

	// Token: 0x04007EE2 RID: 32482
	public float height;

	// Token: 0x04007EE3 RID: 32483
	public float skinWidth;

	// Token: 0x04007EE4 RID: 32484
	public float radius;

	// Token: 0x04007EE5 RID: 32485
	public float slopeLimit;

	// Token: 0x04007EE6 RID: 32486
	public float stepOffset;

	// Token: 0x04007EE7 RID: 32487
	public float contactOffset;
}
