using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000089 RID: 137
[AddComponentMenu("Colorful/Wiggle")]
[ExecuteInEditMode]
public class CC_Wiggle : CC_Base
{
	// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update()
	{
		throw null;
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040002A3 RID: 675
	public float timer;

	// Token: 0x040002A4 RID: 676
	public float speed;

	// Token: 0x040002A5 RID: 677
	public float scale;

	// Token: 0x040002A6 RID: 678
	public float str;

	// Token: 0x040002A7 RID: 679
	public bool autoTimer;

	// Token: 0x040002A8 RID: 680
	private static readonly int int_0;

	// Token: 0x040002A9 RID: 681
	private static readonly int int_1;

	// Token: 0x040002AA RID: 682
	private static readonly int int_2;
}
