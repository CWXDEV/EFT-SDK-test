using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200006E RID: 110
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Frost")]
public class CC_Frost : CC_Base
{
	// Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040001B8 RID: 440
	[Range(0f, 16f)]
	public float scale;

	// Token: 0x040001B9 RID: 441
	[Range(-100f, 100f)]
	public float sharpness;

	// Token: 0x040001BA RID: 442
	[Range(0f, 100f)]
	public float darkness;

	// Token: 0x040001BB RID: 443
	public bool enableVignette;

	// Token: 0x040001BC RID: 444
	private static readonly int int_0;

	// Token: 0x040001BD RID: 445
	private static readonly int int_1;

	// Token: 0x040001BE RID: 446
	private static readonly int int_2;
}
