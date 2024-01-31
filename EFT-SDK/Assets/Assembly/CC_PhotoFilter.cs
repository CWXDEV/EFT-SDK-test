using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200007D RID: 125
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Photo Filter")]
public class CC_PhotoFilter : CC_Base
{
	// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0400023B RID: 571
	public Color color;

	// Token: 0x0400023C RID: 572
	[Range(0f, 1f)]
	public float density;

	// Token: 0x0400023D RID: 573
	private static readonly int int_0;

	// Token: 0x0400023E RID: 574
	private static readonly int int_1;
}
