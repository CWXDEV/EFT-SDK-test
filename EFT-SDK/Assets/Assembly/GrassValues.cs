using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A85 RID: 2693
[Serializable]
public class GrassValues
{
	// Token: 0x06003B59 RID: 15193 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Lerp(GrassValues from, GrassValues to, float t)
	{
		throw null;
	}

	// Token: 0x04003FBF RID: 16319
	public float AngleInRads;

	// Token: 0x04003FC0 RID: 16320
	public float TailLength;

	// Token: 0x04003FC1 RID: 16321
	[Range(0.01f, 16f)]
	public float Radius;

	// Token: 0x04003FC2 RID: 16322
	[Range(0.01f, 16f)]
	public float PressedRadius;

	// Token: 0x04003FC3 RID: 16323
	public float ReturnTime;
}
