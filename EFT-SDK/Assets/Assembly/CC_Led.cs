using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000079 RID: 121
[ExecuteInEditMode]
[AddComponentMenu("Colorful/LED")]
public class CC_Led : CC_Base
{
	// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Start()
	{
		throw null;
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000210 RID: 528
	[Range(1f, 255f)]
	public float scale;

	// Token: 0x04000211 RID: 529
	[Range(0f, 10f)]
	public float brightness;

	// Token: 0x04000212 RID: 530
	public bool automaticRatio;

	// Token: 0x04000213 RID: 531
	public float ratio;

	// Token: 0x04000214 RID: 532
	public int mode;

	// Token: 0x04000215 RID: 533
	protected Camera m_Camera;

	// Token: 0x04000216 RID: 534
	private static readonly int int_0;

	// Token: 0x04000217 RID: 535
	private static readonly int int_1;

	// Token: 0x04000218 RID: 536
	private static readonly int int_2;
}
