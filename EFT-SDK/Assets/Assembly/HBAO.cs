using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000A92 RID: 2706
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/HBAO")]
[RequireComponent(typeof(Camera))]
public class HBAO : HBAO_Core
{
	// Token: 0x06003B83 RID: 15235 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003B84 RID: 15236 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003B85 RID: 15237 RVA: 0x00002050 File Offset: 0x00000250
	[ImageEffectOpaque]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003B86 RID: 15238 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2()
	{
		throw null;
	}

	// Token: 0x06003B87 RID: 15239 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06003B88 RID: 15240 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003B89 RID: 15241 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003B8A RID: 15242 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04004014 RID: 16404
	private RenderTexture[] renderTexture_0;

	// Token: 0x04004015 RID: 16405
	private RenderTexture[] renderTexture_1;

	// Token: 0x04004016 RID: 16406
	private RenderTexture[] renderTexture_2;

	// Token: 0x04004017 RID: 16407
	private RenderBuffer[][] renderBuffer_0;

	// Token: 0x04004018 RID: 16408
	private RenderBuffer[][] renderBuffer_1;

	// Token: 0x04004019 RID: 16409
	private RenderTexture renderTexture_3;

	// Token: 0x0400401A RID: 16410
	private RenderTexture renderTexture_4;

	// Token: 0x0400401B RID: 16411
	private CommandBuffer commandBuffer_0;

	// Token: 0x0400401C RID: 16412
	public bool useTriangleBlit;
}
