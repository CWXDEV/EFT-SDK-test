using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000B59 RID: 2905
public class WaterForSSR : MonoBehaviour
{
	// Token: 0x140000CD RID: 205
	// (add) Token: 0x06003EDC RID: 16092 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06003EDD RID: 16093 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action<WaterForSSR> OnAdd
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140000CE RID: 206
	// (add) Token: 0x06003EDE RID: 16094 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06003EDF RID: 16095 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action<WaterForSSR> OnRemove
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x06003EE0 RID: 16096 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003EE1 RID: 16097 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003EE2 RID: 16098 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003EE3 RID: 16099 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003EE4 RID: 16100 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003EE5 RID: 16101 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003EE6 RID: 16102 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003EE7 RID: 16103 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitBuffer(CommandBuffer buffer, Camera currentCamera)
	{
		throw null;
	}

	// Token: 0x06003EE8 RID: 16104 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Camera currentCamera)
	{
		throw null;
	}

	// Token: 0x06003EE9 RID: 16105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RenderBuffer(CommandBuffer buffer, Camera currentCamera)
	{
		throw null;
	}

	// Token: 0x06003EEA RID: 16106 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCorrectLayer(int cullingMask)
	{
		throw null;
	}

	// Token: 0x06003EEB RID: 16107 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06003EEC RID: 16108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06003EED RID: 16109 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x04004655 RID: 18005
	[CompilerGenerated]
	private static Action<WaterForSSR> action_0;

	// Token: 0x04004656 RID: 18006
	[CompilerGenerated]
	private static Action<WaterForSSR> action_1;

	// Token: 0x04004657 RID: 18007
	public Shader WaterShader;

	// Token: 0x04004658 RID: 18008
	public Texture2D RippleTexture;

	// Token: 0x04004659 RID: 18009
	[Header("Textures")]
	[Space]
	public Texture Normals;

	// Token: 0x0400465A RID: 18010
	public Texture NormalsDetails;

	// Token: 0x0400465B RID: 18011
	public float NormalsDetailsMipMapBias;

	// Token: 0x0400465C RID: 18012
	public Texture Foam;

	// Token: 0x0400465D RID: 18013
	[Header("Layers Settings")]
	[Space(32f)]
	public WaterForSSR.TextureBlendSetting NormalsA;

	// Token: 0x0400465E RID: 18014
	public WaterForSSR.TextureBlendSetting NormalsB;

	// Token: 0x0400465F RID: 18015
	public WaterForSSR.TextureBlendSetting NormalsDetails0;

	// Token: 0x04004660 RID: 18016
	[Space]
	public WaterForSSR.TextureBlendSetting FoamA;

	// Token: 0x04004661 RID: 18017
	public WaterForSSR.TextureBlendSetting FoamB;

	// Token: 0x04004662 RID: 18018
	[Space(32f)]
	[Header("Depth Settings")]
	public float BorderFade;

	// Token: 0x04004663 RID: 18019
	public float BorderFadeDistStart;

	// Token: 0x04004664 RID: 18020
	public float BorderFadeDistRange;

	// Token: 0x04004665 RID: 18021
	public float DepthFade;

	// Token: 0x04004666 RID: 18022
	public float DepthColorFade;

	// Token: 0x04004667 RID: 18023
	public float DepthRefractions;

	// Token: 0x04004668 RID: 18024
	[ColorUsage(false)]
	public Color DepthColorDeep;

	// Token: 0x04004669 RID: 18025
	[ColorUsage(false)]
	public Color DepthColorShallow;

	// Token: 0x0400466A RID: 18026
	[Header("Other")]
	[Space(32f)]
	public float Bumpiness;

	// Token: 0x0400466B RID: 18027
	[Space]
	public float RippleScale;

	// Token: 0x0400466C RID: 18028
	public float RippleBumpness;

	// Token: 0x0400466D RID: 18029
	[Space]
	public float FoamSize;

	// Token: 0x0400466E RID: 18030
	public float FoamIntensity;

	// Token: 0x0400466F RID: 18031
	[ColorUsage(false)]
	public Color FoamColor;

	// Token: 0x04004670 RID: 18032
	[Space]
	[Range(0f, 1f)]
	public float FresnelIntensity;

	// Token: 0x04004671 RID: 18033
	public float FresnelPower;

	// Token: 0x04004672 RID: 18034
	[Space]
	public float AdditionalCubemapReflectionMinWetting;

	// Token: 0x04004673 RID: 18035
	public float AdditionalCubemapReflectionMaxWetting;

	// Token: 0x04004674 RID: 18036
	public AnimationCurve ReflectionWettingFunc;

	// Token: 0x04004675 RID: 18037
	public Color ReflectionColor;

	// Token: 0x04004676 RID: 18038
	public Color DiffuseColor;

	// Token: 0x04004677 RID: 18039
	public MeshFilter[] WaterPlanes;

	// Token: 0x04004678 RID: 18040
	private List<WaterForSSR.GClass867> list_0;

	// Token: 0x04004679 RID: 18041
	private Material material_0;

	// Token: 0x0400467A RID: 18042
	private float float_0;

	// Token: 0x0400467B RID: 18043
	private float float_1;

	// Token: 0x0400467C RID: 18044
	private RenderTargetIdentifier[] renderTargetIdentifier_0;

	// Token: 0x0400467D RID: 18045
	private int int_0;

	// Token: 0x0400467E RID: 18046
	private int int_1;

	// Token: 0x0400467F RID: 18047
	private int int_2;

	// Token: 0x04004680 RID: 18048
	private int int_3;

	// Token: 0x04004681 RID: 18049
	private int int_4;

	// Token: 0x04004682 RID: 18050
	private int int_5;

	// Token: 0x04004683 RID: 18051
	private int int_6;

	// Token: 0x04004684 RID: 18052
	private int int_7;

	// Token: 0x04004685 RID: 18053
	private int int_8;

	// Token: 0x04004686 RID: 18054
	private int int_9;

	// Token: 0x04004687 RID: 18055
	private int int_10;

	// Token: 0x04004688 RID: 18056
	private int int_11;

	// Token: 0x04004689 RID: 18057
	private int int_12;

	// Token: 0x0400468A RID: 18058
	private int int_13;

	// Token: 0x0400468B RID: 18059
	private int int_14;

	// Token: 0x0400468C RID: 18060
	private int int_15;

	// Token: 0x0400468D RID: 18061
	private int int_16;

	// Token: 0x0400468E RID: 18062
	private int int_17;

	// Token: 0x0400468F RID: 18063
	private int int_18;

	// Token: 0x04004690 RID: 18064
	private int int_19;

	// Token: 0x04004691 RID: 18065
	private int int_20;

	// Token: 0x04004692 RID: 18066
	private int int_21;

	// Token: 0x04004693 RID: 18067
	private int int_22;

	// Token: 0x02000B5A RID: 2906
	public class GClass867
	{
		// Token: 0x04004694 RID: 18068
		public Mesh Mesh;

		// Token: 0x04004695 RID: 18069
		public Matrix4x4 Matrix;
	}

	// Token: 0x02000B5B RID: 2907
	[Serializable]
	public class TextureBlendSetting
	{
		// Token: 0x06003EEE RID: 16110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector4 GetVals()
		{
			throw null;
		}

		// Token: 0x04004696 RID: 18070
		public float Scale;

		// Token: 0x04004697 RID: 18071
		public Vector2 MovementDirection;

		// Token: 0x04004698 RID: 18072
		[Range(0f, 1f)]
		public float Blend;
	}

	// Token: 0x02000B5C RID: 2908
	[CompilerGenerated]
	private sealed class Class597
	{
		// Token: 0x06003EEF RID: 16111 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(WaterForSSR.GClass867 x)
		{
			throw null;
		}

		// Token: 0x04004699 RID: 18073
		public int i;

		// Token: 0x0400469A RID: 18074
		public WaterForSSR waterForSSR_0;
	}
}
