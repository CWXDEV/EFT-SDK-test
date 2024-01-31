using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000074 RID: 116
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Grayscale")]
public class CC_Grayscale : CC_Base
{
	// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040001DD RID: 477
	[Range(0f, 1f)]
	public float redLuminance;

	// Token: 0x040001DE RID: 478
	[Range(0f, 1f)]
	public float greenLuminance;

	// Token: 0x040001DF RID: 479
	[Range(0f, 1f)]
	public float blueLuminance;

	// Token: 0x040001E0 RID: 480
	[Range(0f, 1f)]
	public float amount;

	// Token: 0x040001E1 RID: 481
	private static readonly int int_0;
}
