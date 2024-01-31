using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000B5D RID: 2909
public class WaterForSSRv2 : MonoBehaviour
{
	// Token: 0x140000CF RID: 207
	// (add) Token: 0x06003EF0 RID: 16112 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06003EF1 RID: 16113 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action<WaterForSSRv2> OnAdd
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

	// Token: 0x140000D0 RID: 208
	// (add) Token: 0x06003EF2 RID: 16114 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06003EF3 RID: 16115 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action<WaterForSSRv2> OnRemove
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

	// Token: 0x06003EF4 RID: 16116 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003EF5 RID: 16117 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003EF6 RID: 16118 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003EF7 RID: 16119 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003EF8 RID: 16120 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003EF9 RID: 16121 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003EFA RID: 16122 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003EFB RID: 16123 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitBuffer(CommandBuffer buffer, Camera currentCamera)
	{
		throw null;
	}

	// Token: 0x06003EFC RID: 16124 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Camera currentCamera)
	{
		throw null;
	}

	// Token: 0x06003EFD RID: 16125 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RenderBuffer(CommandBuffer buffer, Camera currentCamera)
	{
		throw null;
	}

	// Token: 0x06003EFE RID: 16126 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCorrectLayer(int cullingMask)
	{
		throw null;
	}

	// Token: 0x06003EFF RID: 16127 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06003F00 RID: 16128 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06003F01 RID: 16129 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x0400469B RID: 18075
	[CompilerGenerated]
	private static Action<WaterForSSRv2> action_0;

	// Token: 0x0400469C RID: 18076
	[CompilerGenerated]
	private static Action<WaterForSSRv2> action_1;

	// Token: 0x0400469D RID: 18077
	public Shader WaterShader;

	// Token: 0x0400469E RID: 18078
	public Texture2D RippleTexture;

	// Token: 0x0400469F RID: 18079
	[Space]
	[Header("Textures")]
	public Texture Normals;

	// Token: 0x040046A0 RID: 18080
	public Texture NormalsDetails;

	// Token: 0x040046A1 RID: 18081
	public float NormalsDetailsMipMapBias;

	// Token: 0x040046A2 RID: 18082
	public Texture Foam;

	// Token: 0x040046A3 RID: 18083
	[Header("Layers Settings")]
	[Space(32f)]
	public WaterForSSRv2.TextureBlendSetting NormalsA;

	// Token: 0x040046A4 RID: 18084
	public WaterForSSRv2.TextureBlendSetting NormalsB;

	// Token: 0x040046A5 RID: 18085
	public WaterForSSRv2.TextureBlendSetting NormalsDetails0;

	// Token: 0x040046A6 RID: 18086
	[Space]
	public WaterForSSRv2.TextureBlendSetting FoamA;

	// Token: 0x040046A7 RID: 18087
	public WaterForSSRv2.TextureBlendSetting FoamB;

	// Token: 0x040046A8 RID: 18088
	[Space(32f)]
	[Header("Depth Settings")]
	public float BorderFade;

	// Token: 0x040046A9 RID: 18089
	public float BorderFadeDistStart;

	// Token: 0x040046AA RID: 18090
	public float BorderFadeDistRange;

	// Token: 0x040046AB RID: 18091
	public float DepthFade;

	// Token: 0x040046AC RID: 18092
	public float DepthColorFade;

	// Token: 0x040046AD RID: 18093
	public float DepthRefractions;

	// Token: 0x040046AE RID: 18094
	[ColorUsage(false)]
	public Color DepthColorDeep;

	// Token: 0x040046AF RID: 18095
	[ColorUsage(false)]
	public Color DepthColorShallow;

	// Token: 0x040046B0 RID: 18096
	[Space(32f)]
	[Header("Other")]
	public float Bumpiness;

	// Token: 0x040046B1 RID: 18097
	[Space]
	public float RippleScale;

	// Token: 0x040046B2 RID: 18098
	public float RippleBumpness;

	// Token: 0x040046B3 RID: 18099
	[Space]
	public float FoamSize;

	// Token: 0x040046B4 RID: 18100
	public float FoamIntensity;

	// Token: 0x040046B5 RID: 18101
	[ColorUsage(false)]
	public Color FoamColor;

	// Token: 0x040046B6 RID: 18102
	[Space]
	[Range(0f, 1f)]
	public float FresnelIntensity;

	// Token: 0x040046B7 RID: 18103
	public float FresnelPower;

	// Token: 0x040046B8 RID: 18104
	[Space]
	public float AdditionalCubemapReflectionMinWetting;

	// Token: 0x040046B9 RID: 18105
	public float AdditionalCubemapReflectionMaxWetting;

	// Token: 0x040046BA RID: 18106
	public AnimationCurve ReflectionWettingFunc;

	// Token: 0x040046BB RID: 18107
	public Color ReflectionColor;

	// Token: 0x040046BC RID: 18108
	public Color DiffuseColor;

	// Token: 0x040046BD RID: 18109
	public MeshFilter[] WaterPlanes;

	// Token: 0x040046BE RID: 18110
	private List<WaterForSSRv2.GClass868> list_0;

	// Token: 0x040046BF RID: 18111
	private Material material_0;

	// Token: 0x040046C0 RID: 18112
	private float float_0;

	// Token: 0x040046C1 RID: 18113
	private float float_1;

	// Token: 0x040046C2 RID: 18114
	private RenderTargetIdentifier[] renderTargetIdentifier_0;

	// Token: 0x040046C3 RID: 18115
	private int int_0;

	// Token: 0x040046C4 RID: 18116
	private int int_1;

	// Token: 0x040046C5 RID: 18117
	private int int_2;

	// Token: 0x040046C6 RID: 18118
	private int int_3;

	// Token: 0x040046C7 RID: 18119
	private int int_4;

	// Token: 0x040046C8 RID: 18120
	private int int_5;

	// Token: 0x040046C9 RID: 18121
	private int int_6;

	// Token: 0x040046CA RID: 18122
	private int int_7;

	// Token: 0x040046CB RID: 18123
	private int int_8;

	// Token: 0x040046CC RID: 18124
	private int int_9;

	// Token: 0x040046CD RID: 18125
	private int int_10;

	// Token: 0x040046CE RID: 18126
	private int int_11;

	// Token: 0x040046CF RID: 18127
	private int int_12;

	// Token: 0x040046D0 RID: 18128
	private int int_13;

	// Token: 0x040046D1 RID: 18129
	private int int_14;

	// Token: 0x040046D2 RID: 18130
	private int int_15;

	// Token: 0x040046D3 RID: 18131
	private int int_16;

	// Token: 0x040046D4 RID: 18132
	private int int_17;

	// Token: 0x040046D5 RID: 18133
	private int int_18;

	// Token: 0x040046D6 RID: 18134
	private int int_19;

	// Token: 0x040046D7 RID: 18135
	private int int_20;

	// Token: 0x040046D8 RID: 18136
	private int int_21;

	// Token: 0x040046D9 RID: 18137
	private int int_22;

	// Token: 0x040046DA RID: 18138
	private int int_23;

	// Token: 0x02000B5E RID: 2910
	public class GClass868
	{
		// Token: 0x040046DB RID: 18139
		public Mesh Mesh;

		// Token: 0x040046DC RID: 18140
		public Matrix4x4 Matrix;
	}

	// Token: 0x02000B5F RID: 2911
	[Serializable]
	public class TextureBlendSetting
	{
		// Token: 0x06003F02 RID: 16130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector4 GetVals()
		{
			throw null;
		}

		// Token: 0x040046DD RID: 18141
		public float Scale;

		// Token: 0x040046DE RID: 18142
		public Vector2 MovementDirection;

		// Token: 0x040046DF RID: 18143
		[Range(0f, 1f)]
		public float Blend;
	}

	// Token: 0x02000B60 RID: 2912
	[CompilerGenerated]
	private sealed class Class598
	{
		// Token: 0x06003F03 RID: 16131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(WaterForSSRv2.GClass868 x)
		{
			throw null;
		}

		// Token: 0x040046E0 RID: 18144
		public int i;

		// Token: 0x040046E1 RID: 18145
		public WaterForSSRv2 waterForSSRv2_0;
	}
}
