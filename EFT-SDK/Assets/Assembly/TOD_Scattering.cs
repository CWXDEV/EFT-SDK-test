using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000BF RID: 191
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Time of Day/Camera Scattering")]
public class TOD_Scattering : TOD_ImageEffect
{
	// Token: 0x17000160 RID: 352
	// (get) Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
	public bool MBOIT
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

	// Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Start()
	{
		throw null;
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(ref Material mat)
	{
		throw null;
	}

	// Token: 0x060003CC RID: 972 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnDestroy()
	{
		throw null;
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00002050 File Offset: 0x00000250
	[ImageEffectOpaque]
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnRenderImageNormalMode(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(bool enable)
	{
		throw null;
	}

	// Token: 0x04000455 RID: 1109
	public bool Lighten;

	// Token: 0x04000456 RID: 1110
	public bool FromLevelSettings;

	// Token: 0x04000457 RID: 1111
	public Shader ScatteringShader;

	// Token: 0x04000458 RID: 1112
	public Texture2D DitheringTexture;

	// Token: 0x04000459 RID: 1113
	[Range(0f, 0.2f)]
	public float GlobalDensity;

	// Token: 0x0400045A RID: 1114
	[Range(0f, 1f)]
	public float HeightFalloff;

	// Token: 0x0400045B RID: 1115
	[Range(0.95f, 1f)]
	public float SunrizeGlow;

	// Token: 0x0400045C RID: 1116
	[SerializeField]
	private bool _mboit;

	// Token: 0x0400045D RID: 1117
	public float ZeroLevel;

	// Token: 0x0400045E RID: 1118
	private Material material_0;

	// Token: 0x0400045F RID: 1119
	private static readonly int int_1;

	// Token: 0x04000460 RID: 1120
	private static readonly int int_2;

	// Token: 0x04000461 RID: 1121
	private static readonly int int_3;

	// Token: 0x04000462 RID: 1122
	private static readonly int int_4;

	// Token: 0x04000463 RID: 1123
	private Mesh mesh_0;

	// Token: 0x04000464 RID: 1124
	private MBOIT_Scattering mboit_Scattering_0;

	// Token: 0x04000465 RID: 1125
	private bool bool_2;
}
