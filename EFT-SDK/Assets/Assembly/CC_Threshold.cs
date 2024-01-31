using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000084 RID: 132
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Threshold")]
public class CC_Threshold : CC_Base
{
	// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000275 RID: 629
	[Range(1f, 255f)]
	public float threshold;

	// Token: 0x04000276 RID: 630
	[Range(0f, 128f)]
	public float noiseRange;

	// Token: 0x04000277 RID: 631
	public bool useNoise;

	// Token: 0x04000278 RID: 632
	private static readonly int int_0;

	// Token: 0x04000279 RID: 633
	private static readonly int int_1;
}
