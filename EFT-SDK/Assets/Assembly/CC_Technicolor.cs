using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000083 RID: 131
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Technicolor")]
public class CC_Technicolor : CC_Base
{
	// Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0400026F RID: 623
	[Range(0f, 8f)]
	public float exposure;

	// Token: 0x04000270 RID: 624
	public Vector3 balance;

	// Token: 0x04000271 RID: 625
	[Range(0f, 1f)]
	public float amount;

	// Token: 0x04000272 RID: 626
	private static readonly int int_0;

	// Token: 0x04000273 RID: 627
	private static readonly int int_1;

	// Token: 0x04000274 RID: 628
	private static readonly int int_2;
}
