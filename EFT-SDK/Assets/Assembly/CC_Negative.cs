using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200007C RID: 124
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Negative")]
public class CC_Negative : CC_Base
{
	// Token: 0x060002E2 RID: 738 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000239 RID: 569
	[Range(0f, 1f)]
	public float amount;

	// Token: 0x0400023A RID: 570
	private static readonly int int_0;
}
