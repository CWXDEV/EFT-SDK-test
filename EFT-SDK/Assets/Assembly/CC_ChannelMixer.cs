using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000067 RID: 103
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Channel Mixer")]
public class CC_ChannelMixer : CC_Base
{
	// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000177 RID: 375
	[Range(-200f, 200f)]
	public float redR;

	// Token: 0x04000178 RID: 376
	[Range(-200f, 200f)]
	public float redG;

	// Token: 0x04000179 RID: 377
	[Range(-200f, 200f)]
	public float redB;

	// Token: 0x0400017A RID: 378
	[Range(-200f, 200f)]
	public float greenR;

	// Token: 0x0400017B RID: 379
	[Range(-200f, 200f)]
	public float greenG;

	// Token: 0x0400017C RID: 380
	[Range(-200f, 200f)]
	public float greenB;

	// Token: 0x0400017D RID: 381
	[Range(-200f, 200f)]
	public float blueR;

	// Token: 0x0400017E RID: 382
	[Range(-200f, 200f)]
	public float blueG;

	// Token: 0x0400017F RID: 383
	[Range(-200f, 200f)]
	public float blueB;

	// Token: 0x04000180 RID: 384
	[Range(-200f, 200f)]
	public float constantR;

	// Token: 0x04000181 RID: 385
	[Range(-200f, 200f)]
	public float constantG;

	// Token: 0x04000182 RID: 386
	[Range(-200f, 200f)]
	public float constantB;

	// Token: 0x04000183 RID: 387
	public int currentChannel;

	// Token: 0x04000184 RID: 388
	private static readonly int int_0;

	// Token: 0x04000185 RID: 389
	private static readonly int int_1;

	// Token: 0x04000186 RID: 390
	private static readonly int int_2;

	// Token: 0x04000187 RID: 391
	private static readonly int int_3;
}
