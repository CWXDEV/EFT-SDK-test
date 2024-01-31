using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200007E RID: 126
[AddComponentMenu("Colorful/Pixelate")]
[ExecuteInEditMode]
public class CC_Pixelate : CC_Base
{
	// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Start()
	{
		throw null;
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0400023F RID: 575
	[Range(1f, 1024f)]
	public float scale;

	// Token: 0x04000240 RID: 576
	public bool automaticRatio;

	// Token: 0x04000241 RID: 577
	public float ratio;

	// Token: 0x04000242 RID: 578
	public int mode;

	// Token: 0x04000243 RID: 579
	protected Camera m_Camera;

	// Token: 0x04000244 RID: 580
	private static readonly int int_0;

	// Token: 0x04000245 RID: 581
	private static readonly int int_1;
}
