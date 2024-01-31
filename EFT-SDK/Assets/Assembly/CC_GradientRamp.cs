using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000073 RID: 115
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Gradient Ramp")]
public class CC_GradientRamp : CC_Base
{
	// Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040001D9 RID: 473
	public Texture rampTexture;

	// Token: 0x040001DA RID: 474
	[Range(0f, 1f)]
	public float amount;

	// Token: 0x040001DB RID: 475
	private static readonly int int_0;

	// Token: 0x040001DC RID: 476
	private static readonly int int_1;
}
