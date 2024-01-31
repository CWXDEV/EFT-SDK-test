using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000080 RID: 128
[AddComponentMenu("Colorful/RGB Split")]
[ExecuteInEditMode]
public class CC_RGBSplit : CC_Base
{
	// Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000248 RID: 584
	public float amount;

	// Token: 0x04000249 RID: 585
	public float angle;

	// Token: 0x0400024A RID: 586
	private static readonly int int_0;

	// Token: 0x0400024B RID: 587
	private static readonly int int_1;

	// Token: 0x0400024C RID: 588
	private static readonly int int_2;
}
