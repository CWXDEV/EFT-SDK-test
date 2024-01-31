using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000ABD RID: 2749
public class MaskAndShadow : MonoBehaviour
{
	// Token: 0x06003C2C RID: 15404 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material method_0()
	{
		throw null;
	}

	// Token: 0x06003C2D RID: 15405 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003C2E RID: 15406 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003C2F RID: 15407 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06003C30 RID: 15408 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_2(CommandBuffer buffer, Material mat, int blurTex)
	{
		throw null;
	}

	// Token: 0x040041AA RID: 16810
	public Shader Shader;

	// Token: 0x040041AB RID: 16811
	public Texture2D Mask;

	// Token: 0x040041AC RID: 16812
	[Header("Shadow")]
	public Vector2 ShadowShift;

	// Token: 0x040041AD RID: 16813
	public int ShadowBlurIterations;

	// Token: 0x040041AE RID: 16814
	public float ShadowBlurStrength;

	// Token: 0x040041AF RID: 16815
	[Range(0f, 1f)]
	public float ShadowStrength;

	// Token: 0x040041B0 RID: 16816
	private Camera camera_0;

	// Token: 0x040041B1 RID: 16817
	private Material material_0;

	// Token: 0x040041B2 RID: 16818
	private CommandBuffer commandBuffer_0;

	// Token: 0x040041B3 RID: 16819
	private static readonly int int_0;
}
