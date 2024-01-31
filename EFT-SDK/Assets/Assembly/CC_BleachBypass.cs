using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000063 RID: 99
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Bleach Bypass")]
public class CC_BleachBypass : CC_Base
{
	// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImageImpl(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000162 RID: 354
	[Range(0f, 1f)]
	public float amount;

	// Token: 0x04000163 RID: 355
	private static readonly int int_0;
}
