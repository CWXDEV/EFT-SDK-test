using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000064 RID: 100
[AddComponentMenu("Colorful/Blend")]
[ExecuteInEditMode]
public class CC_Blend : CC_Base
{
	// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000164 RID: 356
	public Texture texture;

	// Token: 0x04000165 RID: 357
	[Range(0f, 1f)]
	public float amount;

	// Token: 0x04000166 RID: 358
	public int mode;

	// Token: 0x04000167 RID: 359
	private static readonly int int_0;

	// Token: 0x04000168 RID: 360
	private static readonly int int_1;
}
