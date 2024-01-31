using System;
using System.Runtime.CompilerServices;
using Prism.Utils;
using UnityEngine;

// Token: 0x02000843 RID: 2115
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class PrismAmbientObscurance : MonoBehaviour
{
	// Token: 0x17000850 RID: 2128
	// (get) Token: 0x06003029 RID: 12329 RVA: 0x00002050 File Offset: 0x00000250
	private RenderTextureFormat RenderTextureFormat_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000851 RID: 2129
	// (get) Token: 0x0600302A RID: 12330 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600302B RID: 12331 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17000852 RID: 2130
	// (get) Token: 0x0600302C RID: 12332 RVA: 0x00002050 File Offset: 0x00000250
	public bool UsingTerrain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000853 RID: 2131
	// (get) Token: 0x0600302D RID: 12333 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsGBufferAvailable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600302E RID: 12334 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Camera GetPrismCamera()
	{
		throw null;
	}

	// Token: 0x0600302F RID: 12335 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003030 RID: 12336 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003031 RID: 12337 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material method_0(Shader shader)
	{
		throw null;
	}

	// Token: 0x06003032 RID: 12338 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x06003033 RID: 12339 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1()
	{
		throw null;
	}

	// Token: 0x06003034 RID: 12340 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateShaderValues()
	{
		throw null;
	}

	// Token: 0x06003035 RID: 12341 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(Material aoMaterial)
	{
		throw null;
	}

	// Token: 0x06003036 RID: 12342 RVA: 0x00002050 File Offset: 0x00000250
	[ImageEffectOpaque]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04002F61 RID: 12129
	public Material m_Material;

	// Token: 0x04002F62 RID: 12130
	public Shader m_Shader;

	// Token: 0x04002F63 RID: 12131
	public Material m_AOMaterial;

	// Token: 0x04002F64 RID: 12132
	public Shader m_AOShader;

	// Token: 0x04002F65 RID: 12133
	private Camera camera_0;

	// Token: 0x04002F66 RID: 12134
	private SSAA ssaa_0;

	// Token: 0x04002F67 RID: 12135
	public bool useAmbientObscurance;

	// Token: 0x04002F68 RID: 12136
	public SampleCount aoSampleCount;

	// Token: 0x04002F69 RID: 12137
	public bool useAODistanceCutoff;

	// Token: 0x04002F6A RID: 12138
	public float aoDistanceCutoffLength;

	// Token: 0x04002F6B RID: 12139
	public float aoDistanceCutoffStart;

	// Token: 0x04002F6C RID: 12140
	public float aoIntensity;

	// Token: 0x04002F6D RID: 12141
	public float aoMinIntensity;

	// Token: 0x04002F6E RID: 12142
	public float aoRadius;

	// Token: 0x04002F6F RID: 12143
	public bool aoDownsample;

	// Token: 0x04002F70 RID: 12144
	public AOBlurType aoBlurType;

	// Token: 0x04002F71 RID: 12145
	[Range(0f, 3f)]
	public int aoBlurIterations;

	// Token: 0x04002F72 RID: 12146
	public float aoBias;

	// Token: 0x04002F73 RID: 12147
	public float aoBlurFilterDistance;

	// Token: 0x04002F74 RID: 12148
	public float aoLightingContribution;

	// Token: 0x04002F75 RID: 12149
	public bool aoShowDebug;

	// Token: 0x04002F76 RID: 12150
	public bool advancedAO;

	// Token: 0x04002F77 RID: 12151
	private static readonly int int_0;

	// Token: 0x04002F78 RID: 12152
	private static readonly int int_1;

	// Token: 0x04002F79 RID: 12153
	private static readonly int int_2;

	// Token: 0x04002F7A RID: 12154
	private static readonly int int_3;

	// Token: 0x04002F7B RID: 12155
	private static readonly int int_4;

	// Token: 0x04002F7C RID: 12156
	private static readonly int int_5;

	// Token: 0x04002F7D RID: 12157
	private static readonly int int_6;

	// Token: 0x04002F7E RID: 12158
	private static readonly int int_7;

	// Token: 0x04002F7F RID: 12159
	private static readonly int int_8;

	// Token: 0x04002F80 RID: 12160
	private static readonly int int_9;

	// Token: 0x04002F81 RID: 12161
	private static readonly int int_10;

	// Token: 0x04002F82 RID: 12162
	private static readonly int int_11;

	// Token: 0x04002F83 RID: 12163
	private static readonly int int_12;

	// Token: 0x04002F84 RID: 12164
	private static readonly int int_13;
}
