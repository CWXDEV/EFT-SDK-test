using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000A2B RID: 2603
[ExecuteInEditMode]
public class FogLight : LightOverride
{
	// Token: 0x1700098C RID: 2444
	// (get) Token: 0x06003937 RID: 14647 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003938 RID: 14648 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06003939 RID: 14649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDirectionalShadowmap()
	{
		throw null;
	}

	// Token: 0x0600393A RID: 14650 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600393B RID: 14651 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetUpDirectionalShadowmapForSampling(bool shadows, ComputeShader cs, int kernel)
	{
		throw null;
	}

	// Token: 0x0600393C RID: 14652 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(ref RenderTexture rt)
	{
		throw null;
	}

	// Token: 0x0600393D RID: 14653 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool GetForceOn()
	{
		throw null;
	}

	// Token: 0x0600393E RID: 14654 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x0600393F RID: 14655 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003940 RID: 14656 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003941 RID: 14657 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x04003B66 RID: 15206
	private CommandBuffer commandBuffer_0;

	// Token: 0x04003B67 RID: 15207
	private CommandBuffer commandBuffer_1;

	// Token: 0x04003B68 RID: 15208
	private RenderTexture renderTexture_0;

	// Token: 0x04003B69 RID: 15209
	private ComputeBuffer computeBuffer_0;

	// Token: 0x04003B6A RID: 15210
	public Shader m_BlurShadowmapShader;

	// Token: 0x04003B6B RID: 15211
	private Material material_0;

	// Token: 0x04003B6C RID: 15212
	public Shader m_CopyShadowParamsShader;

	// Token: 0x04003B6D RID: 15213
	private Material material_1;

	// Token: 0x04003B6E RID: 15214
	private int[] int_0;

	// Token: 0x04003B6F RID: 15215
	public bool m_ForceOnForFog;

	// Token: 0x04003B70 RID: 15216
	[Header("Shadows")]
	[Tooltip("Only one shadowed fog AreaLight at a time.")]
	public bool m_Shadows;

	// Token: 0x04003B71 RID: 15217
	[Tooltip("Always at most half the res of the AreaLight's shadowmap.")]
	public FogLight.TextureSize m_ShadowmapRes;

	// Token: 0x04003B72 RID: 15218
	[Range(0f, 3f)]
	public int m_BlurIterations;

	// Token: 0x04003B73 RID: 15219
	public float m_BlurSize;

	// Token: 0x04003B74 RID: 15220
	public float m_ESMExponent;

	// Token: 0x04003B75 RID: 15221
	public bool m_Bounded;

	// Token: 0x04003B76 RID: 15222
	private bool bool_1;

	// Token: 0x04003B77 RID: 15223
	private AreaLight areaLight_1;

	// Token: 0x02000A2C RID: 2604
	public enum TextureSize
	{
		// Token: 0x04003B79 RID: 15225
		x256 = 256,
		// Token: 0x04003B7A RID: 15226
		x512 = 512,
		// Token: 0x04003B7B RID: 15227
		x1024 = 1024
	}
}
