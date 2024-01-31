using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000075 RID: 117
[AddComponentMenu("Colorful/Halftone")]
[ExecuteInEditMode]
public class CC_Halftone : CC_Base
{
	// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Start()
	{
		throw null;
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040001E2 RID: 482
	[Range(0f, 512f)]
	public float density;

	// Token: 0x040001E3 RID: 483
	public int mode;

	// Token: 0x040001E4 RID: 484
	public bool antialiasing;

	// Token: 0x040001E5 RID: 485
	public bool showOriginal;

	// Token: 0x040001E6 RID: 486
	protected Camera m_Camera;

	// Token: 0x040001E7 RID: 487
	private static readonly int int_0;

	// Token: 0x040001E8 RID: 488
	private static readonly int int_1;
}
