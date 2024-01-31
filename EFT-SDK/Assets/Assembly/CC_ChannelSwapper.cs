using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000068 RID: 104
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Channel Swapper")]
public class CC_ChannelSwapper : CC_Base
{
	// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000188 RID: 392
	public int red;

	// Token: 0x04000189 RID: 393
	public int green;

	// Token: 0x0400018A RID: 394
	public int blue;

	// Token: 0x0400018B RID: 395
	private static Vector4[] vector4_0;

	// Token: 0x0400018C RID: 396
	private static readonly int int_0;

	// Token: 0x0400018D RID: 397
	private static readonly int int_1;

	// Token: 0x0400018E RID: 398
	private static readonly int int_2;
}
