using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020009E9 RID: 2537
public class LightSwitcherOverkill : CameraLightSwitcher
{
	// Token: 0x06003841 RID: 14401 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnPreCull()
	{
		throw null;
	}

	// Token: 0x06003842 RID: 14402 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnPostRender()
	{
		throw null;
	}

	// Token: 0x040039FE RID: 14846
	private readonly List<Light> list_0;
}
