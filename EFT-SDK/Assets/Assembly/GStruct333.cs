using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020020BC RID: 8380
[StructLayout(LayoutKind.Auto)]
public struct GStruct333
{
	// Token: 0x0600AD47 RID: 44359 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400B3B8 RID: 46008
	public Vector3 StartPosition;

	// Token: 0x0400B3B9 RID: 46009
	public Vector3 StartVelocity;

	// Token: 0x0400B3BA RID: 46010
	public float BulletMassGram;

	// Token: 0x0400B3BB RID: 46011
	public float BulletDiameterMilimeters;

	// Token: 0x0400B3BC RID: 46012
	public float BallisticCoefficient;

	// Token: 0x0400B3BD RID: 46013
	public float Duration;

	// Token: 0x0400B3BE RID: 46014
	public bool HitObstacleAtTheEnd;
}
