using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200006C RID: 108
[AddComponentMenu("Colorful/Double Vision")]
[ExecuteInEditMode]
public class CC_DoubleVision : CC_Base
{
	// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040001AF RID: 431
	public Vector2 displace;

	// Token: 0x040001B0 RID: 432
	[Range(0f, 1f)]
	public float amount;

	// Token: 0x040001B1 RID: 433
	private static readonly int int_0;

	// Token: 0x040001B2 RID: 434
	private static readonly int int_1;
}
