using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000078 RID: 120
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Kuwahara")]
public class CC_Kuwahara : CC_Base
{
	// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Start()
	{
		throw null;
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0400020D RID: 525
	[Range(1f, 4f)]
	public int radius;

	// Token: 0x0400020E RID: 526
	protected Camera m_Camera;

	// Token: 0x0400020F RID: 527
	private static readonly int int_0;
}
