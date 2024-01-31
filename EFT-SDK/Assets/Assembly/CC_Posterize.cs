using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200007F RID: 127
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Posterize")]
public class CC_Posterize : CC_Base
{
	// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000246 RID: 582
	[Range(2f, 255f)]
	public int levels;

	// Token: 0x04000247 RID: 583
	private static readonly int int_0;
}
