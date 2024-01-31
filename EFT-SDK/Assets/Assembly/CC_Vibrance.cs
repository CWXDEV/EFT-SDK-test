using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000085 RID: 133
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Vibrance")]
public class CC_Vibrance : CC_Base
{
	// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0400027A RID: 634
	[Range(-100f, 100f)]
	public float amount;

	// Token: 0x0400027B RID: 635
	[Range(-5f, 5f)]
	public float redChannel;

	// Token: 0x0400027C RID: 636
	[Range(-5f, 5f)]
	public float greenChannel;

	// Token: 0x0400027D RID: 637
	[Range(-5f, 5f)]
	public float blueChannel;

	// Token: 0x0400027E RID: 638
	public bool advanced;

	// Token: 0x0400027F RID: 639
	private static readonly int int_0;

	// Token: 0x04000280 RID: 640
	private static readonly int int_1;
}
