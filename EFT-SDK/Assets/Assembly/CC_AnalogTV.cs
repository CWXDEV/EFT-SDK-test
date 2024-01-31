using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000061 RID: 97
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Analog TV")]
public class CC_AnalogTV : CC_Base
{
	// Token: 0x060002B1 RID: 689 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update()
	{
		throw null;
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0400014D RID: 333
	public bool autoPhase;

	// Token: 0x0400014E RID: 334
	public float phase;

	// Token: 0x0400014F RID: 335
	public bool grayscale;

	// Token: 0x04000150 RID: 336
	[Range(0f, 1f)]
	public float noiseIntensity;

	// Token: 0x04000151 RID: 337
	[Range(0f, 10f)]
	public float scanlinesIntensity;

	// Token: 0x04000152 RID: 338
	[Range(0f, 4096f)]
	public float scanlinesCount;

	// Token: 0x04000153 RID: 339
	public float scanlinesOffset;

	// Token: 0x04000154 RID: 340
	[Range(-2f, 2f)]
	public float distortion;

	// Token: 0x04000155 RID: 341
	[Range(-2f, 2f)]
	public float cubicDistortion;

	// Token: 0x04000156 RID: 342
	[Range(0.01f, 2f)]
	public float scale;

	// Token: 0x04000157 RID: 343
	private static readonly int int_0;

	// Token: 0x04000158 RID: 344
	private static readonly int int_1;

	// Token: 0x04000159 RID: 345
	private static readonly int int_2;

	// Token: 0x0400015A RID: 346
	private static readonly int int_3;

	// Token: 0x0400015B RID: 347
	private static readonly int int_4;

	// Token: 0x0400015C RID: 348
	private static readonly int int_5;

	// Token: 0x0400015D RID: 349
	private static readonly int int_6;

	// Token: 0x0400015E RID: 350
	private static readonly int int_7;
}
