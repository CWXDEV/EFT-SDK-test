using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200007B RID: 123
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Lookup Filter (Color Grading)")]
public class CC_LookupFilter : CC_Base
{
	// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000235 RID: 565
	public Texture lookupTexture;

	// Token: 0x04000236 RID: 566
	[Range(0f, 1f)]
	public float amount;

	// Token: 0x04000237 RID: 567
	private static readonly int int_0;

	// Token: 0x04000238 RID: 568
	private static readonly int int_1;
}
