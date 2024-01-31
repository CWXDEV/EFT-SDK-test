using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000B0F RID: 2831
[RequireComponent(typeof(Camera))]
[DisallowMultipleComponent]
[ExecuteAlways]
public class SSAOMask : MonoBehaviour
{
	// Token: 0x06003D79 RID: 15737 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003D7A RID: 15738 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003D7B RID: 15739 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPreCull()
	{
		throw null;
	}

	// Token: 0x06003D7C RID: 15740 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003D7D RID: 15741 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh GetQuadMesh(float z = 0.1f)
	{
		throw null;
	}

	// Token: 0x040043C2 RID: 17346
	[SerializeField]
	private Shader _maskShader;

	// Token: 0x040043C3 RID: 17347
	private static Mesh mesh_0;

	// Token: 0x040043C4 RID: 17348
	private static readonly Matrix4x4 matrix4x4_0;

	// Token: 0x040043C5 RID: 17349
	private Camera camera_0;

	// Token: 0x040043C6 RID: 17350
	private SSAA ssaa_0;

	// Token: 0x040043C7 RID: 17351
	private CameraEvent cameraEvent_0;

	// Token: 0x040043C8 RID: 17352
	private CommandBuffer commandBuffer_0;

	// Token: 0x040043C9 RID: 17353
	private RenderTexture renderTexture_0;

	// Token: 0x040043CA RID: 17354
	private Material material_0;

	// Token: 0x040043CB RID: 17355
	private int int_0;

	// Token: 0x040043CC RID: 17356
	private int int_1;

	// Token: 0x040043CD RID: 17357
	private static readonly int int_2;
}
