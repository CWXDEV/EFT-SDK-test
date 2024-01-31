using System;
using UnityEngine;

// Token: 0x02000B29 RID: 2857
[Serializable]
public class PixelationUtilities
{
	// Token: 0x040044A8 RID: 17576
	public GClass863.PixelationMode Mode;

	// Token: 0x040044A9 RID: 17577
	public Shader PixelationShader;

	// Token: 0x040044AA RID: 17578
	[Range(2f, 2048f)]
	public float BlockCount;

	// Token: 0x040044AB RID: 17579
	[Range(0f, 1f)]
	public float Alpha;

	// Token: 0x040044AC RID: 17580
	public Texture PixelationMask;
}
