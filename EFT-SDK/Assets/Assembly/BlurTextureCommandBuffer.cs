using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000A42 RID: 2626
[ExecuteInEditMode]
public class BlurTextureCommandBuffer : MonoBehaviour
{
	// Token: 0x0600399F RID: 14751 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060039A0 RID: 14752 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnable()
	{
		throw null;
	}

	// Token: 0x060039A1 RID: 14753 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDisable()
	{
		throw null;
	}

	// Token: 0x060039A2 RID: 14754 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		throw null;
	}

	// Token: 0x04003C99 RID: 15513
	public Shader BlurShader;

	// Token: 0x04003C9A RID: 15514
	private Material material_0;

	// Token: 0x04003C9B RID: 15515
	private Camera camera_0;

	// Token: 0x04003C9C RID: 15516
	private CommandBuffer commandBuffer_0;
}
