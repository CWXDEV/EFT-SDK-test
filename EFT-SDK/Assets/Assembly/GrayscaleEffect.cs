using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000094 RID: 148
[AddComponentMenu("Image Effects/Grayscale")]
[ExecuteInEditMode]
public class GrayscaleEffect
{
	// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040002EB RID: 747
	public float intensity;

	// Token: 0x040002EC RID: 748
	public Texture textureRamp;

	// Token: 0x040002ED RID: 749
	public float rampOffsetR;

	// Token: 0x040002EE RID: 750
	public float rampOffsetG;

	// Token: 0x040002EF RID: 751
	public float rampOffsetB;

	// Token: 0x040002F0 RID: 752
	private static readonly int int_0;

	// Token: 0x040002F1 RID: 753
	private static readonly int int_1;

	// Token: 0x040002F2 RID: 754
	private static readonly int int_2;
}
