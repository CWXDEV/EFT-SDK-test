using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200006B RID: 107
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Cross Stitch")]
public class CC_CrossStitch : CC_Base
{
	// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Start()
	{
		throw null;
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040001A5 RID: 421
	[Range(1f, 128f)]
	public int size;

	// Token: 0x040001A6 RID: 422
	public float brightness;

	// Token: 0x040001A7 RID: 423
	public bool invert;

	// Token: 0x040001A8 RID: 424
	public bool pixelize;

	// Token: 0x040001A9 RID: 425
	protected Camera m_Camera;

	// Token: 0x040001AA RID: 426
	protected SSAA m_SSAA;

	// Token: 0x040001AB RID: 427
	private static readonly int int_0;

	// Token: 0x040001AC RID: 428
	private static readonly int int_1;

	// Token: 0x040001AD RID: 429
	private static readonly int int_2;

	// Token: 0x040001AE RID: 430
	private static readonly int int_3;
}
