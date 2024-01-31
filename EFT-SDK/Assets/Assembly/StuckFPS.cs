using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B1E RID: 2846
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class StuckFPS : MonoBehaviour
{
	// Token: 0x06003DC7 RID: 15815 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003DC8 RID: 15816 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x04004437 RID: 17463
	[SerializeField]
	private int _minFramerate;

	// Token: 0x04004438 RID: 17464
	[SerializeField]
	private int _maxFramerate;

	// Token: 0x04004439 RID: 17465
	private RenderTexture renderTexture_0;

	// Token: 0x0400443A RID: 17466
	private float float_0;
}
