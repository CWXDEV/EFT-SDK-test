using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000097 RID: 151
[AddComponentMenu("Image Effects/Screen")]
[ExecuteInEditMode]
public class ScreenEffect
{
	// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000303 RID: 771
	public float desaturateAmount;

	// Token: 0x04000304 RID: 772
	public Texture textureRamp;

	// Token: 0x04000305 RID: 773
	public float rampOffsetR;

	// Token: 0x04000306 RID: 774
	public float rampOffsetG;

	// Token: 0x04000307 RID: 775
	public float rampOffsetB;

	// Token: 0x04000308 RID: 776
	private static readonly int int_0;

	// Token: 0x04000309 RID: 777
	private static readonly int int_1;

	// Token: 0x0400030A RID: 778
	private static readonly int int_2;
}
