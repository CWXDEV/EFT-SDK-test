using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020015DB RID: 5595
[StructLayout(LayoutKind.Auto)]
public struct GStruct198 : IDisposable
{
	// Token: 0x06007A4B RID: 31307 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct198 Create(IAnimator bodyAnimator, IAnimator armsAnimator, ICharacterController characterController, Vector3 position, Quaternion rotation, Vector3 animatedPosition, Quaternion animatedRotation, Vector2 lookRotation, Vector2 previousLookRotation)
	{
		throw null;
	}

	// Token: 0x06007A4C RID: 31308 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04007ED0 RID: 32464
	public ulong frameIndex;

	// Token: 0x04007ED1 RID: 32465
	public GStruct199 bodyAnimator;

	// Token: 0x04007ED2 RID: 32466
	public GStruct199 armsAnimator;

	// Token: 0x04007ED3 RID: 32467
	public GStruct201 characterController;

	// Token: 0x04007ED4 RID: 32468
	public Vector3 position;

	// Token: 0x04007ED5 RID: 32469
	public Quaternion rotation;

	// Token: 0x04007ED6 RID: 32470
	public Vector3 animatedPosition;

	// Token: 0x04007ED7 RID: 32471
	public Quaternion animatedRotation;

	// Token: 0x04007ED8 RID: 32472
	public Vector2 lookRotation;

	// Token: 0x04007ED9 RID: 32473
	public Vector2 previousLookRotation;
}
