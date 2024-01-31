using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000E86 RID: 3718
public class GClass1062
{
	// Token: 0x17000C6C RID: 3180
	// (get) Token: 0x06004D8A RID: 19850 RVA: 0x00002050 File Offset: 0x00000250
	public int argsBufferOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04005A28 RID: 23080
	public List<GClass1063> renderers;

	// Token: 0x04005A29 RID: 23081
	public ComputeBuffer transformationMatrixAppendBuffer;

	// Token: 0x04005A2A RID: 23082
	public ComputeBuffer shadowAppendBuffer;

	// Token: 0x04005A2B RID: 23083
	public bool excludeBounds;

	// Token: 0x04005A2C RID: 23084
	public RenderTexture transformationMatrixAppendTexture;

	// Token: 0x04005A2D RID: 23085
	public RenderTexture shadowAppendTexture;
}
