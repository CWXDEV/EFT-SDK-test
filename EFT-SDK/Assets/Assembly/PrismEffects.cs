using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Prism.Utils;
using UnityEngine;

// Token: 0x02000844 RID: 2116
[AddComponentMenu("PRISM/Prism Effects")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class PrismEffects : MonoBehaviour
{
	// Token: 0x17000854 RID: 2132
	// (get) Token: 0x06003037 RID: 12343 RVA: 0x00002050 File Offset: 0x00000250
	public bool forceSecondChromaticPass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000855 RID: 2133
	// (get) Token: 0x06003038 RID: 12344 RVA: 0x00002050 File Offset: 0x00000250
	public RenderTexture AdaptationTexture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000856 RID: 2134
	// (get) Token: 0x06003039 RID: 12345 RVA: 0x00002050 File Offset: 0x00000250
	public bool useMedianDoF
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000857 RID: 2135
	// (get) Token: 0x0600303A RID: 12346 RVA: 0x00002050 File Offset: 0x00000250
	private RenderTextureFormat RenderTextureFormat_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000858 RID: 2136
	// (get) Token: 0x0600303B RID: 12347 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600303C RID: 12348 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17000859 RID: 2137
	// (get) Token: 0x0600303D RID: 12349 RVA: 0x00002050 File Offset: 0x00000250
	public bool UsingTerrain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700085A RID: 2138
	// (get) Token: 0x0600303E RID: 12350 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsGBufferAvailable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600303F RID: 12351 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003040 RID: 12352 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DontRenderPrismThisFrame()
	{
		throw null;
	}

	// Token: 0x06003041 RID: 12353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Camera GetPrismCamera()
	{
		throw null;
	}

	// Token: 0x06003042 RID: 12354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetToneParamsRomB()
	{
		throw null;
	}

	// Token: 0x06003043 RID: 12355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetToneParamsFilmic()
	{
		throw null;
	}

	// Token: 0x06003044 RID: 12356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetToneParamsACES()
	{
		throw null;
	}

	// Token: 0x06003045 RID: 12357 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGamma(float value)
	{
		throw null;
	}

	// Token: 0x06003046 RID: 12358 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetChromaticIntensity(float value)
	{
		throw null;
	}

	// Token: 0x06003047 RID: 12359 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNoiseIntensity(float value)
	{
		throw null;
	}

	// Token: 0x06003048 RID: 12360 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVignetteStrength(float value)
	{
		throw null;
	}

	// Token: 0x06003049 RID: 12361 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPrimaryLutStrength(float value)
	{
		throw null;
	}

	// Token: 0x0600304A RID: 12362 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSecondaryLutStrength(float value)
	{
		throw null;
	}

	// Token: 0x0600304B RID: 12363 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPrismPreset(PrismPreset preset)
	{
		throw null;
	}

	// Token: 0x0600304C RID: 12364 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LerpToPreset(PrismPreset preset, float t)
	{
		throw null;
	}

	// Token: 0x0600304D RID: 12365 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x0600304E RID: 12366 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("DontRenderDepthTexture")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600304F RID: 12367 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003050 RID: 12368 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003051 RID: 12369 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material method_1(Shader shader)
	{
		throw null;
	}

	// Token: 0x06003052 RID: 12370 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x06003053 RID: 12371 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2()
	{
		throw null;
	}

	// Token: 0x06003054 RID: 12372 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateShaderValues()
	{
		throw null;
	}

	// Token: 0x06003055 RID: 12373 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06003056 RID: 12374 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(Material raysMaterial)
	{
		throw null;
	}

	// Token: 0x06003057 RID: 12375 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(Material fogMaterial)
	{
		throw null;
	}

	// Token: 0x06003058 RID: 12376 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(Material aoMaterial)
	{
		throw null;
	}

	// Token: 0x06003059 RID: 12377 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x0600305A RID: 12378 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8()
	{
		throw null;
	}

	// Token: 0x0600305B RID: 12379 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDofTransform(Transform target)
	{
		throw null;
	}

	// Token: 0x0600305C RID: 12380 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDofPoint(Vector3 point)
	{
		throw null;
	}

	// Token: 0x0600305D RID: 12381 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetDofTransform()
	{
		throw null;
	}

	// Token: 0x0600305E RID: 12382 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9(Material targetMat)
	{
		throw null;
	}

	// Token: 0x0600305F RID: 12383 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10(RenderTexture source, RenderTextureFormat rtFormat)
	{
		throw null;
	}

	// Token: 0x06003060 RID: 12384 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private RenderTexture method_11(RenderTexture tex, int iterations = 1)
	{
		throw null;
	}

	// Token: 0x06003061 RID: 12385 RVA: 0x00002050 File Offset: 0x00000250
	[ImageEffectTransformsToLDR]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003062 RID: 12386 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003063 RID: 12387 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13(RenderTexture quarterResMain)
	{
		throw null;
	}

	// Token: 0x06003064 RID: 12388 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIdentityLut(bool secondary = false)
	{
		throw null;
	}

	// Token: 0x06003065 RID: 12389 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ValidDimensions(Texture2D tex2d)
	{
		throw null;
	}

	// Token: 0x06003066 RID: 12390 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDependantEffectExposure(PrismEffects pe)
	{
		throw null;
	}

	// Token: 0x06003067 RID: 12391 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Convert(Texture2D temp2DTex, bool secondaryLut = false)
	{
		throw null;
	}

	// Token: 0x04002F85 RID: 12165
	public PrismPreset currentPrismPreset;

	// Token: 0x04002F86 RID: 12166
	private bool bool_0;

	// Token: 0x04002F87 RID: 12167
	public bool isParentPrism;

	// Token: 0x04002F88 RID: 12168
	public bool isChildPrism;

	// Token: 0x04002F89 RID: 12169
	private RenderTexture renderTexture_0;

	// Token: 0x04002F8A RID: 12170
	public Material m_Material;

	// Token: 0x04002F8B RID: 12171
	public Shader m_Shader;

	// Token: 0x04002F8C RID: 12172
	public Material m_Material2;

	// Token: 0x04002F8D RID: 12173
	public Shader m_Shader2;

	// Token: 0x04002F8E RID: 12174
	public PrismEffects m_MasterEffectExposure;

	// Token: 0x04002F8F RID: 12175
	private List<PrismEffects> list_0;

	// Token: 0x04002F90 RID: 12176
	public Material m_AOMaterial;

	// Token: 0x04002F91 RID: 12177
	public Shader m_AOShader;

	// Token: 0x04002F92 RID: 12178
	public Material m_Material3;

	// Token: 0x04002F93 RID: 12179
	public Shader m_Shader3;

	// Token: 0x04002F94 RID: 12180
	private Camera camera_0;

	// Token: 0x04002F95 RID: 12181
	private SSAA ssaa_0;

	// Token: 0x04002F96 RID: 12182
	public bool doBigPass;

	// Token: 0x04002F97 RID: 12183
	public bool useSeparableBlur;

	// Token: 0x04002F98 RID: 12184
	public Texture2D lensDirtTexture;

	// Token: 0x04002F99 RID: 12185
	public bool useLensDirt;

	// Token: 0x04002F9A RID: 12186
	[Space(10f)]
	public bool useBloom;

	// Token: 0x04002F9B RID: 12187
	public bool bloomUseScreenBlend;

	// Token: 0x04002F9C RID: 12188
	public BloomType bloomType;

	// Token: 0x04002F9D RID: 12189
	public bool debugBloomTex;

	// Token: 0x04002F9E RID: 12190
	[Range(1f, 12f)]
	public int bloomDownsample;

	// Token: 0x04002F9F RID: 12191
	[Range(0f, 12f)]
	public int bloomBlurPasses;

	// Token: 0x04002FA0 RID: 12192
	public float bloomIntensity;

	// Token: 0x04002FA1 RID: 12193
	[Range(-2f, 2f)]
	public float bloomThreshold;

	// Token: 0x04002FA2 RID: 12194
	public float dirtIntensity;

	// Token: 0x04002FA3 RID: 12195
	public bool useBloomStability;

	// Token: 0x04002FA4 RID: 12196
	private RenderTexture renderTexture_1;

	// Token: 0x04002FA5 RID: 12197
	public bool useUIBlur;

	// Token: 0x04002FA6 RID: 12198
	public int uiBlurGrabTextureFromPassNumber;

	// Token: 0x04002FA7 RID: 12199
	private RenderTexture renderTexture_2;

	// Token: 0x04002FA8 RID: 12200
	[Space(10f)]
	public bool useVignette;

	// Token: 0x04002FA9 RID: 12201
	public float vignetteStart;

	// Token: 0x04002FAA RID: 12202
	public float vignetteEnd;

	// Token: 0x04002FAB RID: 12203
	public float vignetteStrength;

	// Token: 0x04002FAC RID: 12204
	public Color vignetteColor;

	// Token: 0x04002FAD RID: 12205
	[Space(10f)]
	public bool useNightVision;

	// Token: 0x04002FAE RID: 12206
	[Tooltip("The main color of the NV effect")]
	[SerializeField]
	public Color m_NVColor;

	// Token: 0x04002FAF RID: 12207
	[SerializeField]
	[Tooltip("The color that the NV effect will 'bleach' towards (white = default)")]
	public Color m_TargetBleachColor;

	// Token: 0x04002FB0 RID: 12208
	[Range(0f, 0.1f)]
	[Tooltip("How much base lighting does the NV effect pick up")]
	public float m_baseLightingContribution;

	// Token: 0x04002FB1 RID: 12209
	[Tooltip("The higher this value, the more bright areas will get 'bleached out'")]
	[Range(0f, 128f)]
	public float m_LightSensitivityMultiplier;

	// Token: 0x04002FB2 RID: 12210
	[Space(10f)]
	public bool useNoise;

	// Token: 0x04002FB3 RID: 12211
	public Texture2D noiseTexture;

	// Token: 0x04002FB4 RID: 12212
	public float noiseScale;

	// Token: 0x04002FB5 RID: 12213
	public float noiseIntensity;

	// Token: 0x04002FB6 RID: 12214
	public NoiseType noiseType;

	// Token: 0x04002FB7 RID: 12215
	[Space(10f)]
	public bool useChromaticAberration;

	// Token: 0x04002FB8 RID: 12216
	public AberrationType aberrationType;

	// Token: 0x04002FB9 RID: 12217
	[Range(0f, 1f)]
	public float chromaticDistanceOne;

	// Token: 0x04002FBA RID: 12218
	[Range(0f, 1f)]
	public float chromaticDistanceTwo;

	// Token: 0x04002FBB RID: 12219
	public float chromaticIntensity;

	// Token: 0x04002FBC RID: 12220
	public float chromaticBlurWidth;

	// Token: 0x04002FBD RID: 12221
	public bool useChromaticBlur;

	// Token: 0x04002FBE RID: 12222
	[Space(10f)]
	public bool useTonemap;

	// Token: 0x04002FBF RID: 12223
	public TonemapType tonemapType;

	// Token: 0x04002FC0 RID: 12224
	public Vector3 toneValues;

	// Token: 0x04002FC1 RID: 12225
	public Vector3 secondaryToneValues;

	// Token: 0x04002FC2 RID: 12226
	public bool useExposure;

	// Token: 0x04002FC3 RID: 12227
	public bool debugViewExposure;

	// Token: 0x04002FC4 RID: 12228
	private RenderTexture renderTexture_3;

	// Token: 0x04002FC5 RID: 12229
	public float exposureMiddleGrey;

	// Token: 0x04002FC6 RID: 12230
	public float exposureLowerLimit;

	// Token: 0x04002FC7 RID: 12231
	public float exposureUpperLimit;

	// Token: 0x04002FC8 RID: 12232
	public float exposureSpeed;

	// Token: 0x04002FC9 RID: 12233
	public int histWidth;

	// Token: 0x04002FCA RID: 12234
	public int histHeight;

	// Token: 0x04002FCB RID: 12235
	private bool bool_1;

	// Token: 0x04002FCC RID: 12236
	public bool useGammaCorrection;

	// Token: 0x04002FCD RID: 12237
	public float gammaValue;

	// Token: 0x04002FCE RID: 12238
	[Space(10f)]
	public bool useDof;

	// Token: 0x04002FCF RID: 12239
	public bool dofForceEnableMedian;

	// Token: 0x04002FD0 RID: 12240
	public bool useNearDofBlur;

	// Token: 0x04002FD1 RID: 12241
	public bool useFullScreenBlur;

	// Token: 0x04002FD2 RID: 12242
	public float dofNearFocusDistance;

	// Token: 0x04002FD3 RID: 12243
	public float dofFocusPoint;

	// Token: 0x04002FD4 RID: 12244
	public float dofFocusDistance;

	// Token: 0x04002FD5 RID: 12245
	public float dofRadius;

	// Token: 0x04002FD6 RID: 12246
	public float dofBokehFactor;

	// Token: 0x04002FD7 RID: 12247
	public DoFSamples dofSampleAmount;

	// Token: 0x04002FD8 RID: 12248
	public bool dofBlurSkybox;

	// Token: 0x04002FD9 RID: 12249
	public bool debugDofPass;

	// Token: 0x04002FDA RID: 12250
	public Transform dofFocusTransform;

	// Token: 0x04002FDB RID: 12251
	[Space(10f)]
	public bool useLut;

	// Token: 0x04002FDC RID: 12252
	public Texture2D twoDLookupTex;

	// Token: 0x04002FDD RID: 12253
	public Texture3D threeDLookupTex;

	// Token: 0x04002FDE RID: 12254
	public string basedOnTempTex;

	// Token: 0x04002FDF RID: 12255
	public float lutLerpAmount;

	// Token: 0x04002FE0 RID: 12256
	public bool useSecondLut;

	// Token: 0x04002FE1 RID: 12257
	public Texture2D secondaryTwoDLookupTex;

	// Token: 0x04002FE2 RID: 12258
	public Texture3D secondaryThreeDLookupTex;

	// Token: 0x04002FE3 RID: 12259
	public string secondaryBasedOnTempTex;

	// Token: 0x04002FE4 RID: 12260
	public float secondaryLutLerpAmount;

	// Token: 0x04002FE5 RID: 12261
	[Space(10f)]
	public bool useSharpen;

	// Token: 0x04002FE6 RID: 12262
	public float sharpenAmount;

	// Token: 0x04002FE7 RID: 12263
	public bool useFog;

	// Token: 0x04002FE8 RID: 12264
	public bool fogAffectSkybox;

	// Token: 0x04002FE9 RID: 12265
	public float fogIntensity;

	// Token: 0x04002FEA RID: 12266
	public float fogStartPoint;

	// Token: 0x04002FEB RID: 12267
	public float fogDistance;

	// Token: 0x04002FEC RID: 12268
	public Color fogColor;

	// Token: 0x04002FED RID: 12269
	public Color fogEndColor;

	// Token: 0x04002FEE RID: 12270
	public float fogHeight;

	// Token: 0x04002FEF RID: 12271
	public bool useAmbientObscurance;

	// Token: 0x04002FF0 RID: 12272
	public SampleCount aoSampleCount;

	// Token: 0x04002FF1 RID: 12273
	public bool useAODistanceCutoff;

	// Token: 0x04002FF2 RID: 12274
	public float aoDistanceCutoffLength;

	// Token: 0x04002FF3 RID: 12275
	public float aoDistanceCutoffStart;

	// Token: 0x04002FF4 RID: 12276
	public float aoIntensity;

	// Token: 0x04002FF5 RID: 12277
	public float aoMinIntensity;

	// Token: 0x04002FF6 RID: 12278
	public float aoRadius;

	// Token: 0x04002FF7 RID: 12279
	public bool aoDownsample;

	// Token: 0x04002FF8 RID: 12280
	public AOBlurType aoBlurType;

	// Token: 0x04002FF9 RID: 12281
	[Range(0f, 3f)]
	public int aoBlurIterations;

	// Token: 0x04002FFA RID: 12282
	public float aoBias;

	// Token: 0x04002FFB RID: 12283
	public float aoBlurFilterDistance;

	// Token: 0x04002FFC RID: 12284
	public float aoLightingContribution;

	// Token: 0x04002FFD RID: 12285
	public bool aoShowDebug;

	// Token: 0x04002FFE RID: 12286
	public bool useRays;

	// Token: 0x04002FFF RID: 12287
	public Transform rayTransform;

	// Token: 0x04003000 RID: 12288
	public float rayWeight;

	// Token: 0x04003001 RID: 12289
	public Color rayColor;

	// Token: 0x04003002 RID: 12290
	public Color rayThreshold;

	// Token: 0x04003003 RID: 12291
	public bool raysShowDebug;

	// Token: 0x04003004 RID: 12292
	[Space(10f)]
	public bool advancedVignette;

	// Token: 0x04003005 RID: 12293
	public bool advancedAO;

	// Token: 0x04003006 RID: 12294
	private static readonly int int_0;

	// Token: 0x04003007 RID: 12295
	private static readonly int int_1;

	// Token: 0x04003008 RID: 12296
	private static readonly int int_2;

	// Token: 0x04003009 RID: 12297
	private static readonly int int_3;

	// Token: 0x0400300A RID: 12298
	private static readonly int int_4;

	// Token: 0x0400300B RID: 12299
	private static readonly int int_5;

	// Token: 0x0400300C RID: 12300
	private static readonly int int_6;

	// Token: 0x0400300D RID: 12301
	private static readonly int int_7;

	// Token: 0x0400300E RID: 12302
	private static readonly int int_8;

	// Token: 0x0400300F RID: 12303
	private static readonly int int_9;

	// Token: 0x04003010 RID: 12304
	private static readonly int int_10;

	// Token: 0x04003011 RID: 12305
	private static readonly int int_11;

	// Token: 0x04003012 RID: 12306
	private static readonly int int_12;

	// Token: 0x04003013 RID: 12307
	private static readonly int int_13;

	// Token: 0x04003014 RID: 12308
	private static readonly int int_14;

	// Token: 0x04003015 RID: 12309
	private static readonly int int_15;

	// Token: 0x04003016 RID: 12310
	private static readonly int int_16;

	// Token: 0x04003017 RID: 12311
	private static readonly int int_17;

	// Token: 0x04003018 RID: 12312
	private static readonly int int_18;

	// Token: 0x04003019 RID: 12313
	private static readonly int int_19;

	// Token: 0x0400301A RID: 12314
	private static readonly int int_20;

	// Token: 0x0400301B RID: 12315
	private static readonly int int_21;

	// Token: 0x0400301C RID: 12316
	private static readonly int int_22;

	// Token: 0x0400301D RID: 12317
	private static readonly int int_23;

	// Token: 0x0400301E RID: 12318
	private static readonly int int_24;

	// Token: 0x0400301F RID: 12319
	private static readonly int int_25;

	// Token: 0x04003020 RID: 12320
	private static readonly int int_26;

	// Token: 0x04003021 RID: 12321
	private static readonly int int_27;

	// Token: 0x04003022 RID: 12322
	private static readonly int int_28;

	// Token: 0x04003023 RID: 12323
	private static readonly int int_29;

	// Token: 0x04003024 RID: 12324
	private static readonly int int_30;

	// Token: 0x04003025 RID: 12325
	private static readonly int int_31;

	// Token: 0x04003026 RID: 12326
	private static readonly int int_32;

	// Token: 0x04003027 RID: 12327
	private static readonly int int_33;

	// Token: 0x04003028 RID: 12328
	private static readonly int int_34;

	// Token: 0x04003029 RID: 12329
	private static readonly int int_35;

	// Token: 0x0400302A RID: 12330
	private static readonly int int_36;

	// Token: 0x0400302B RID: 12331
	private static readonly int int_37;

	// Token: 0x0400302C RID: 12332
	private static readonly int int_38;

	// Token: 0x0400302D RID: 12333
	private static readonly int int_39;

	// Token: 0x0400302E RID: 12334
	private static readonly int int_40;

	// Token: 0x0400302F RID: 12335
	private static readonly int int_41;

	// Token: 0x04003030 RID: 12336
	private static readonly int int_42;

	// Token: 0x04003031 RID: 12337
	private static readonly int int_43;

	// Token: 0x04003032 RID: 12338
	private static readonly int int_44;

	// Token: 0x04003033 RID: 12339
	private static readonly int int_45;

	// Token: 0x04003034 RID: 12340
	private static readonly int int_46;

	// Token: 0x04003035 RID: 12341
	private static readonly int int_47;

	// Token: 0x04003036 RID: 12342
	private static readonly int int_48;

	// Token: 0x04003037 RID: 12343
	private static readonly int int_49;

	// Token: 0x04003038 RID: 12344
	private static readonly int int_50;

	// Token: 0x04003039 RID: 12345
	private static readonly int int_51;

	// Token: 0x0400303A RID: 12346
	private static readonly int int_52;

	// Token: 0x0400303B RID: 12347
	private static readonly int int_53;

	// Token: 0x0400303C RID: 12348
	private static readonly int int_54;

	// Token: 0x0400303D RID: 12349
	private static readonly int int_55;

	// Token: 0x0400303E RID: 12350
	private static readonly int int_56;

	// Token: 0x0400303F RID: 12351
	private static readonly int int_57;

	// Token: 0x04003040 RID: 12352
	private static readonly int int_58;

	// Token: 0x04003041 RID: 12353
	private static readonly int int_59;

	// Token: 0x04003042 RID: 12354
	private static readonly int int_60;

	// Token: 0x04003043 RID: 12355
	private static readonly int int_61;

	// Token: 0x04003044 RID: 12356
	private static readonly int int_62;

	// Token: 0x04003045 RID: 12357
	private static readonly int int_63;

	// Token: 0x04003046 RID: 12358
	private static readonly int int_64;

	// Token: 0x04003047 RID: 12359
	private static readonly int int_65;

	// Token: 0x04003048 RID: 12360
	private static readonly int int_66;

	// Token: 0x04003049 RID: 12361
	private static readonly int int_67;

	// Token: 0x0400304A RID: 12362
	private static readonly int int_68;

	// Token: 0x0400304B RID: 12363
	private static readonly int int_69;

	// Token: 0x0400304C RID: 12364
	private static readonly int int_70;

	// Token: 0x0400304D RID: 12365
	private static readonly int int_71;

	// Token: 0x0400304E RID: 12366
	private static readonly int int_72;

	// Token: 0x0400304F RID: 12367
	private static readonly int int_73;

	// Token: 0x04003050 RID: 12368
	private static readonly int int_74;

	// Token: 0x04003051 RID: 12369
	private static readonly int int_75;

	// Token: 0x04003052 RID: 12370
	private static readonly int int_76;

	// Token: 0x04003053 RID: 12371
	private static readonly int int_77;

	// Token: 0x04003054 RID: 12372
	private static readonly int int_78;

	// Token: 0x04003055 RID: 12373
	private static readonly int int_79;

	// Token: 0x04003056 RID: 12374
	private bool bool_2;

	// Token: 0x04003057 RID: 12375
	private SSAAPropagator ssaapropagator_0;
}
