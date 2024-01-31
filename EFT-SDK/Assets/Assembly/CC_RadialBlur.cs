using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000081 RID: 129
[AddComponentMenu("Colorful/Radial Blur")]
[ExecuteInEditMode]
public class CC_RadialBlur : CC_Base
{
	// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0400024D RID: 589
	[Range(0f, 1f)]
	public float amount;

	// Token: 0x0400024E RID: 590
	[Range(2f, 24f)]
	public int samples;

	// Token: 0x0400024F RID: 591
	public Vector2 center;

	// Token: 0x04000250 RID: 592
	public int quality;

	// Token: 0x04000251 RID: 593
	private static readonly int int_0;

	// Token: 0x04000252 RID: 594
	private static readonly int int_1;

	// Token: 0x04000253 RID: 595
	private static readonly int int_2;
}
