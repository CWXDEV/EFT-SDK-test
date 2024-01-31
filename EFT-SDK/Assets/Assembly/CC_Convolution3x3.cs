using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200006A RID: 106
[AddComponentMenu("Colorful/Convolution Matrix 3x3")]
[ExecuteInEditMode]
public class CC_Convolution3x3 : CC_Base
{
	// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0400019A RID: 410
	public Vector3 kernelTop;

	// Token: 0x0400019B RID: 411
	public Vector3 kernelMiddle;

	// Token: 0x0400019C RID: 412
	public Vector3 kernelBottom;

	// Token: 0x0400019D RID: 413
	public float divisor;

	// Token: 0x0400019E RID: 414
	[Range(0f, 1f)]
	public float amount;

	// Token: 0x0400019F RID: 415
	private static readonly int int_0;

	// Token: 0x040001A0 RID: 416
	private static readonly int int_1;

	// Token: 0x040001A1 RID: 417
	private static readonly int int_2;

	// Token: 0x040001A2 RID: 418
	private static readonly int int_3;

	// Token: 0x040001A3 RID: 419
	private static readonly int int_4;

	// Token: 0x040001A4 RID: 420
	private static readonly int int_5;
}
