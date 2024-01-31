using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x02000B9E RID: 2974
public sealed class SnowFlakes : MonoBehaviour
{
	// Token: 0x17000A75 RID: 2677
	// (get) Token: 0x0600408B RID: 16523 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600408C RID: 16524 RVA: 0x00002050 File Offset: 0x00000250
	public float Intensity
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x0600408D RID: 16525 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x0600408E RID: 16526 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x0600408F RID: 16527 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06004090 RID: 16528 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private ComputeBuffer method_1<T>(List<T> data, int tailReserveCount)
	{
		throw null;
	}

	// Token: 0x06004091 RID: 16529 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06004092 RID: 16530 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(ref List<SnowFlakes.Struct120> props)
	{
		throw null;
	}

	// Token: 0x06004093 RID: 16531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(Material material, float sideSpeed, float rainDensity)
	{
		throw null;
	}

	// Token: 0x06004094 RID: 16532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private MeshRenderer method_5(int particlesCount, Material material, string caption)
	{
		throw null;
	}

	// Token: 0x0400496A RID: 18794
	private const int int_0 = 2000;

	// Token: 0x0400496B RID: 18795
	private const float float_0 = 0.001f;

	// Token: 0x0400496C RID: 18796
	private const int int_1 = 16383;

	// Token: 0x0400496D RID: 18797
	private const int int_2 = 8191;

	// Token: 0x0400496E RID: 18798
	private const int int_3 = 4095;

	// Token: 0x0400496F RID: 18799
	private static readonly int int_4;

	// Token: 0x04004970 RID: 18800
	private static readonly int int_5;

	// Token: 0x04004971 RID: 18801
	private static readonly int int_6;

	// Token: 0x04004972 RID: 18802
	[SerializeField]
	public Vector2 FlakesSizeMin;

	// Token: 0x04004973 RID: 18803
	[SerializeField]
	public Vector2 FlakesSizeMax;

	// Token: 0x04004974 RID: 18804
	[Range(0f, 1f)]
	public float FlakesFarSizeFactor;

	// Token: 0x04004975 RID: 18805
	[Range(0f, 1f)]
	public float StormSideSpeed;

	// Token: 0x04004976 RID: 18806
	public Vector2 MinMaxSideSpeed;

	// Token: 0x04004977 RID: 18807
	[Range(0f, 1f)]
	public float DropsAlphaClose;

	// Token: 0x04004978 RID: 18808
	[Range(0f, 1f)]
	public float MinAmbient;

	// Token: 0x04004979 RID: 18809
	[Range(0f, 1f)]
	public float MinAmbientAddition;

	// Token: 0x0400497A RID: 18810
	[Range(0f, 1f)]
	public float MinAmbientAdditionCoef;

	// Token: 0x0400497B RID: 18811
	public Material Close;

	// Token: 0x0400497C RID: 18812
	public Material Far;

	// Token: 0x0400497D RID: 18813
	private Material material_0;

	// Token: 0x0400497E RID: 18814
	private Material material_1;

	// Token: 0x0400497F RID: 18815
	private Material material_2;

	// Token: 0x04004980 RID: 18816
	private Material material_3;

	// Token: 0x04004981 RID: 18817
	private MeshRenderer[] meshRenderer_0;

	// Token: 0x04004982 RID: 18818
	private MeshRenderer[] meshRenderer_1;

	// Token: 0x04004983 RID: 18819
	private Light light_0;

	// Token: 0x04004984 RID: 18820
	private Vector3 vector3_0;

	// Token: 0x04004985 RID: 18821
	public ComputeBuffer _lightsPropertiesComputeBuffer;

	// Token: 0x04004986 RID: 18822
	[CompilerGenerated]
	private float float_1;

	// Token: 0x04004987 RID: 18823
	[CompilerGenerated]
	private float float_2;

	// Token: 0x04004988 RID: 18824
	private List<SnowFlakes.Struct120> list_0;

	// Token: 0x02000B9F RID: 2975
	[StructLayout(LayoutKind.Auto)]
	public struct Struct120
	{
		// Token: 0x04004989 RID: 18825
		public Vector4 pos;

		// Token: 0x0400498A RID: 18826
		public Vector3 dir;

		// Token: 0x0400498B RID: 18827
		public Vector3 color;

		// Token: 0x0400498C RID: 18828
		public Matrix4x4 worldToLight;
	}
}
