using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000066 RID: 102
[AddComponentMenu("Colorful/Channel Clamper")]
[ExecuteInEditMode]
public class CC_ChannelClamper : CC_Base
{
	// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000171 RID: 369
	public Vector2 red;

	// Token: 0x04000172 RID: 370
	public Vector2 green;

	// Token: 0x04000173 RID: 371
	public Vector2 blue;

	// Token: 0x04000174 RID: 372
	private static readonly int int_0;

	// Token: 0x04000175 RID: 373
	private static readonly int int_1;

	// Token: 0x04000176 RID: 374
	private static readonly int int_2;
}
