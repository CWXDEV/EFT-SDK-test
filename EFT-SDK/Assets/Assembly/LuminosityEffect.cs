using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000096 RID: 150
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Luminosity")]
public class LuminosityEffect
{
	// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040002FB RID: 763
	public float desaturateAmount;

	// Token: 0x040002FC RID: 764
	public Texture textureRamp;

	// Token: 0x040002FD RID: 765
	public float rampOffsetR;

	// Token: 0x040002FE RID: 766
	public float rampOffsetG;

	// Token: 0x040002FF RID: 767
	public float rampOffsetB;

	// Token: 0x04000300 RID: 768
	private static readonly int int_0;

	// Token: 0x04000301 RID: 769
	private static readonly int int_1;

	// Token: 0x04000302 RID: 770
	private static readonly int int_2;
}
