using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000069 RID: 105
[AddComponentMenu("Colorful/Contrast Vignette")]
[ExecuteInEditMode]
public class CC_ContrastVignette : CC_Base
{
	// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0400018F RID: 399
	public Vector2 center;

	// Token: 0x04000190 RID: 400
	[Range(-100f, 100f)]
	public float sharpness;

	// Token: 0x04000191 RID: 401
	[Range(0f, 100f)]
	public float darkness;

	// Token: 0x04000192 RID: 402
	[Range(0f, 200f)]
	public float contrast;

	// Token: 0x04000193 RID: 403
	[Range(0f, 1f)]
	public float redCoeff;

	// Token: 0x04000194 RID: 404
	[Range(0f, 1f)]
	public float greenCoeff;

	// Token: 0x04000195 RID: 405
	[Range(0f, 1f)]
	public float blueCoeff;

	// Token: 0x04000196 RID: 406
	[Range(0f, 200f)]
	public float edge;

	// Token: 0x04000197 RID: 407
	private static readonly int int_0;

	// Token: 0x04000198 RID: 408
	private static readonly int int_1;

	// Token: 0x04000199 RID: 409
	private static readonly int int_2;
}
