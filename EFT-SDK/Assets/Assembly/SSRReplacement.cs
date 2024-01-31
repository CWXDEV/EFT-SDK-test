using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B11 RID: 2833
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class SSRReplacement : MonoBehaviour
{
	// Token: 0x06003D8D RID: 15757 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003D8E RID: 15758 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003D8F RID: 15759 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPostRender()
	{
		throw null;
	}

	// Token: 0x040043DD RID: 17373
	public Shader ssrReplacementShader;

	// Token: 0x040043DE RID: 17374
	public RenderTexture tex;

	// Token: 0x040043DF RID: 17375
	private GameObject gameObject_0;

	// Token: 0x040043E0 RID: 17376
	private Camera camera_0;
}
