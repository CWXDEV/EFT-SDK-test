using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000076 RID: 118
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Hue Focus")]
public class CC_HueFocus : CC_Base
{
	// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
	[ImageEffectTransformsToLDR]
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040001E9 RID: 489
	[Range(0f, 360f)]
	public float hue;

	// Token: 0x040001EA RID: 490
	[Range(1f, 180f)]
	public float range;

	// Token: 0x040001EB RID: 491
	[Range(0f, 1f)]
	public float boost;

	// Token: 0x040001EC RID: 492
	[Range(0f, 1f)]
	public float amount;

	// Token: 0x040001ED RID: 493
	private static readonly int int_0;

	// Token: 0x040001EE RID: 494
	private static readonly int int_1;
}
