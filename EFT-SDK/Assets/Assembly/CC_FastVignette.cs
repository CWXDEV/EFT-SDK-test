using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200006D RID: 109
[AddComponentMenu("Colorful/Fast Vignette")]
[ExecuteInEditMode]
public class CC_FastVignette : CC_Base
{
	// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040001B3 RID: 435
	public Vector2 center;

	// Token: 0x040001B4 RID: 436
	[Range(-100f, 100f)]
	public float sharpness;

	// Token: 0x040001B5 RID: 437
	[Range(0f, 100f)]
	public float darkness;

	// Token: 0x040001B6 RID: 438
	public bool desaturate;

	// Token: 0x040001B7 RID: 439
	private static readonly int int_0;
}
