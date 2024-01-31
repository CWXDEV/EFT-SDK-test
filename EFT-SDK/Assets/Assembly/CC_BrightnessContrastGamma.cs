using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000065 RID: 101
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Brightness, Contrast, Gamma")]
public class CC_BrightnessContrastGamma : CC_Base
{
	// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImageImpl(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000169 RID: 361
	[Range(-100f, 100f)]
	public float brightness;

	// Token: 0x0400016A RID: 362
	[Range(-100f, 100f)]
	public float contrast;

	// Token: 0x0400016B RID: 363
	[Range(0f, 1f)]
	public float redCoeff;

	// Token: 0x0400016C RID: 364
	[Range(0f, 1f)]
	public float greenCoeff;

	// Token: 0x0400016D RID: 365
	[Range(0f, 1f)]
	public float blueCoeff;

	// Token: 0x0400016E RID: 366
	[Range(0.1f, 9.9f)]
	public float gamma;

	// Token: 0x0400016F RID: 367
	private static readonly int int_0;

	// Token: 0x04000170 RID: 368
	private static readonly int int_1;
}
