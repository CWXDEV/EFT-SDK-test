using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000095 RID: 149
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Lighten")]
public class LightenEffect
{
	// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040002F3 RID: 755
	public float desaturateAmount;

	// Token: 0x040002F4 RID: 756
	public Texture textureRamp;

	// Token: 0x040002F5 RID: 757
	public float rampOffsetR;

	// Token: 0x040002F6 RID: 758
	public float rampOffsetG;

	// Token: 0x040002F7 RID: 759
	public float rampOffsetB;

	// Token: 0x040002F8 RID: 760
	private static readonly int _rampTex;

	// Token: 0x040002F9 RID: 761
	private static readonly int _desat;

	// Token: 0x040002FA RID: 762
	private static readonly int _rampOffset;
}
