using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000AA7 RID: 2727
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/HBAO Integrated")]
[ExecuteInEditMode]
public class HBAO_Integrated : HBAO_Core
{
	// Token: 0x06003BAA RID: 15274 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003BAB RID: 15275 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003BAC RID: 15276 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void CheckParameters()
	{
		throw null;
	}

	// Token: 0x06003BAD RID: 15277 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPreRender()
	{
		throw null;
	}

	// Token: 0x06003BAE RID: 15278 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(CameraEvent cameraEvent)
	{
		throw null;
	}

	// Token: 0x06003BAF RID: 15279 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(CameraEvent cameraEvent)
	{
		throw null;
	}

	// Token: 0x06003BB0 RID: 15280 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(CameraEvent cameraEvent)
	{
		throw null;
	}

	// Token: 0x06003BB1 RID: 15281 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(CameraEvent cameraEvent)
	{
		throw null;
	}

	// Token: 0x06003BB2 RID: 15282 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06003BB3 RID: 15283 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private CameraEvent method_7()
	{
		throw null;
	}

	// Token: 0x040040D6 RID: 16598
	private CommandBuffer commandBuffer_0;

	// Token: 0x040040D7 RID: 16599
	private HBAO_Core.IntegrationStage integrationStage_0;

	// Token: 0x040040D8 RID: 16600
	private HBAO_Core.Resolution resolution_0;

	// Token: 0x040040D9 RID: 16601
	private HBAO_Core.DisplayMode displayMode_0;

	// Token: 0x040040DA RID: 16602
	private RenderingPath renderingPath_0;

	// Token: 0x040040DB RID: 16603
	private bool bool_0;

	// Token: 0x040040DC RID: 16604
	private int int_2;

	// Token: 0x040040DD RID: 16605
	private int int_3;

	// Token: 0x040040DE RID: 16606
	private HBAO_Core.Quality quality_1;

	// Token: 0x040040DF RID: 16607
	private HBAO_Core.Deinterleaving deinterleaving_0;

	// Token: 0x040040E0 RID: 16608
	private bool bool_1;

	// Token: 0x040040E1 RID: 16609
	private bool bool_2;

	// Token: 0x040040E2 RID: 16610
	private HBAO_Core.Blur blur_0;

	// Token: 0x040040E3 RID: 16611
	private bool bool_3;
}
