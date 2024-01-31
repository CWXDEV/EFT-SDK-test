using System;
using System.Runtime.CompilerServices;
using Prism.Utils;
using UnityEngine;

// Token: 0x02000845 RID: 2117
[RequireComponent(typeof(Camera))]
[AddComponentMenu("PRISM/Prism Effects SSAO")]
[ExecuteInEditMode]
public class PrismSSAO : MonoBehaviour
{
	// Token: 0x1700085B RID: 2139
	// (get) Token: 0x06003068 RID: 12392 RVA: 0x00002050 File Offset: 0x00000250
	private RenderTextureFormat RenderTextureFormat_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700085C RID: 2140
	// (get) Token: 0x06003069 RID: 12393 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600306A RID: 12394 RVA: 0x00002050 File Offset: 0x00000250
	public int aoSampleCountValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700085D RID: 2141
	// (get) Token: 0x0600306B RID: 12395 RVA: 0x00002050 File Offset: 0x00000250
	public bool UsingTerrain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700085E RID: 2142
	// (get) Token: 0x0600306C RID: 12396 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsGBufferAvailable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600306E RID: 12398 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPrismPreset(PrismPreset preset)
	{
		throw null;
	}

	// Token: 0x0600306F RID: 12399 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003070 RID: 12400 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("DontRenderDepthTexture")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003071 RID: 12401 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003072 RID: 12402 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003073 RID: 12403 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material method_1(Shader shader)
	{
		throw null;
	}

	// Token: 0x06003074 RID: 12404 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x06003075 RID: 12405 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2()
	{
		throw null;
	}

	// Token: 0x06003076 RID: 12406 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateShaderValues()
	{
		throw null;
	}

	// Token: 0x06003077 RID: 12407 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(Material aoMaterial)
	{
		throw null;
	}

	// Token: 0x06003078 RID: 12408 RVA: 0x00002050 File Offset: 0x00000250
	[ImageEffectOpaque]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04003058 RID: 12376
	public PrismPreset currentPrismPreset;

	// Token: 0x04003059 RID: 12377
	private bool bool_0;

	// Token: 0x0400305A RID: 12378
	public bool isParentPrism;

	// Token: 0x0400305B RID: 12379
	public bool isChildPrism;

	// Token: 0x0400305C RID: 12380
	private RenderTexture renderTexture_0;

	// Token: 0x0400305D RID: 12381
	public Material m_Material;

	// Token: 0x0400305E RID: 12382
	public Shader m_Shader;

	// Token: 0x0400305F RID: 12383
	public Material m_Material2;

	// Token: 0x04003060 RID: 12384
	public Shader m_Shader2;

	// Token: 0x04003061 RID: 12385
	public Material m_AOMaterial;

	// Token: 0x04003062 RID: 12386
	public Shader m_AOShader;

	// Token: 0x04003063 RID: 12387
	public Material m_Material3;

	// Token: 0x04003064 RID: 12388
	public Shader m_Shader3;

	// Token: 0x04003065 RID: 12389
	private Camera camera_0;

	// Token: 0x04003066 RID: 12390
	private SSAA ssaa_0;

	// Token: 0x04003067 RID: 12391
	public Texture2D lensDirtTexture;

	// Token: 0x04003068 RID: 12392
	public bool useLensDirt;

	// Token: 0x04003069 RID: 12393
	public bool useAmbientObscurance;

	// Token: 0x0400306A RID: 12394
	public SampleCount aoSampleCount;

	// Token: 0x0400306B RID: 12395
	public bool useAODistanceCutoff;

	// Token: 0x0400306C RID: 12396
	public float aoDistanceCutoffLength;

	// Token: 0x0400306D RID: 12397
	public float aoDistanceCutoffStart;

	// Token: 0x0400306E RID: 12398
	public float aoIntensity;

	// Token: 0x0400306F RID: 12399
	public float aoMinIntensity;

	// Token: 0x04003070 RID: 12400
	public float aoRadius;

	// Token: 0x04003071 RID: 12401
	public bool aoDownsample;

	// Token: 0x04003072 RID: 12402
	public AOBlurType aoBlurType;

	// Token: 0x04003073 RID: 12403
	[Range(0f, 3f)]
	public int aoBlurIterations;

	// Token: 0x04003074 RID: 12404
	public float aoBias;

	// Token: 0x04003075 RID: 12405
	public float aoBlurFilterDistance;

	// Token: 0x04003076 RID: 12406
	public float aoLightingContribution;

	// Token: 0x04003077 RID: 12407
	public bool aoShowDebug;

	// Token: 0x04003078 RID: 12408
	[Space(10f)]
	public bool advancedVignette;

	// Token: 0x04003079 RID: 12409
	public bool advancedAO;

	// Token: 0x0400307A RID: 12410
	private static readonly int int_0;

	// Token: 0x0400307B RID: 12411
	private static readonly int int_1;

	// Token: 0x0400307C RID: 12412
	private static readonly int int_2;

	// Token: 0x0400307D RID: 12413
	private static readonly int int_3;

	// Token: 0x0400307E RID: 12414
	private static readonly int int_4;

	// Token: 0x0400307F RID: 12415
	private static readonly int int_5;

	// Token: 0x04003080 RID: 12416
	private static readonly int int_6;

	// Token: 0x04003081 RID: 12417
	private static readonly int int_7;

	// Token: 0x04003082 RID: 12418
	private static readonly int int_8;

	// Token: 0x04003083 RID: 12419
	private static readonly int int_9;

	// Token: 0x04003084 RID: 12420
	private static readonly int int_10;

	// Token: 0x04003085 RID: 12421
	private static readonly int int_11;

	// Token: 0x04003086 RID: 12422
	private static readonly int int_12;

	// Token: 0x04003087 RID: 12423
	private static readonly int int_13;

	// Token: 0x04003088 RID: 12424
	private static readonly int int_14;

	// Token: 0x04003089 RID: 12425
	private static readonly int int_15;

	// Token: 0x0400308A RID: 12426
	private static readonly int int_16;

	// Token: 0x0400308B RID: 12427
	private static readonly int int_17;

	// Token: 0x0400308C RID: 12428
	private static readonly int int_18;

	// Token: 0x0400308D RID: 12429
	private static readonly int int_19;

	// Token: 0x0400308E RID: 12430
	private static readonly int int_20;

	// Token: 0x0400308F RID: 12431
	private static readonly int int_21;

	// Token: 0x04003090 RID: 12432
	private static readonly int int_22;
}
