using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000088 RID: 136
[AddComponentMenu("Colorful/White Balance")]
[ExecuteInEditMode]
public class CC_WhiteBalance : CC_Base
{
	// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Reset()
	{
		throw null;
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040002A0 RID: 672
	public Color white;

	// Token: 0x040002A1 RID: 673
	public int mode;

	// Token: 0x040002A2 RID: 674
	private static readonly int int_0;
}
