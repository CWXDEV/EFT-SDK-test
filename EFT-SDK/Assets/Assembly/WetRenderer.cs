using System;
using System.Runtime.CompilerServices;
using EFT.UI.Screens;
using UnityEngine;

// Token: 0x02000B84 RID: 2948
[ExecuteInEditMode]
public sealed class WetRenderer : MonoBehaviour
{
	// Token: 0x06003FF9 RID: 16377 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003FFA RID: 16378 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003FFB RID: 16379 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0()
	{
		throw null;
	}

	// Token: 0x06003FFC RID: 16380 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003FFD RID: 16381 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003FFE RID: 16382 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(EEftScreenType screenType)
	{
		throw null;
	}

	// Token: 0x06003FFF RID: 16383 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1()
	{
		throw null;
	}

	// Token: 0x06004000 RID: 16384 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06004001 RID: 16385 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06004002 RID: 16386 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06004003 RID: 16387 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(Camera currentCamera)
	{
		throw null;
	}

	// Token: 0x06004004 RID: 16388 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(in Struct119 data)
	{
		throw null;
	}

	// Token: 0x06004005 RID: 16389 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(in Struct119 data)
	{
		throw null;
	}

	// Token: 0x06004006 RID: 16390 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDebugRain(bool debug)
	{
		throw null;
	}

	// Token: 0x06004007 RID: 16391 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material method_6()
	{
		throw null;
	}

	// Token: 0x06004008 RID: 16392 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Mesh smethod_2()
	{
		throw null;
	}

	// Token: 0x06004009 RID: 16393 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x0600400A RID: 16394 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Mesh smethod_3(int count)
	{
		throw null;
	}

	// Token: 0x04004868 RID: 18536
	public Shader WetShader;

	// Token: 0x04004869 RID: 18537
	[Range(0f, 1f)]
	public float Wetting;

	// Token: 0x0400486A RID: 18538
	public Color DiffuseColor;

	// Token: 0x0400486B RID: 18539
	public Color SpecColor;

	// Token: 0x0400486C RID: 18540
	public float WetFactor;

	// Token: 0x0400486D RID: 18541
	public float WetBias;

	// Token: 0x0400486E RID: 18542
	public float Opaqueness;

	// Token: 0x0400486F RID: 18543
	public Material _wetMaterial;

	// Token: 0x04004870 RID: 18544
	public Material _snowCopyMaterial;

	// Token: 0x04004871 RID: 18545
	public Mesh _wetMesh;

	// Token: 0x04004872 RID: 18546
	public Material _snowSparkling;

	// Token: 0x04004873 RID: 18547
	public int SparklingsCount;

	// Token: 0x04004874 RID: 18548
	private const string string_0 = "SNOW_GLITTERS";

	// Token: 0x04004875 RID: 18549
	private static readonly int int_0;

	// Token: 0x04004876 RID: 18550
	private static readonly int int_1;

	// Token: 0x04004877 RID: 18551
	private static readonly int int_2;

	// Token: 0x04004878 RID: 18552
	private static readonly int int_3;

	// Token: 0x04004879 RID: 18553
	private static readonly int int_4;

	// Token: 0x0400487A RID: 18554
	private static readonly int int_5;

	// Token: 0x0400487B RID: 18555
	private static readonly int int_6;

	// Token: 0x0400487C RID: 18556
	private static readonly int int_7;

	// Token: 0x0400487D RID: 18557
	private static readonly int int_8;

	// Token: 0x0400487E RID: 18558
	private static readonly int int_9;

	// Token: 0x0400487F RID: 18559
	private static readonly int int_10;

	// Token: 0x04004880 RID: 18560
	private static readonly int int_11;

	// Token: 0x04004881 RID: 18561
	private static readonly int int_12;

	// Token: 0x04004882 RID: 18562
	private static readonly int int_13;

	// Token: 0x04004883 RID: 18563
	private static readonly int int_14;

	// Token: 0x04004884 RID: 18564
	private static readonly int int_15;

	// Token: 0x04004885 RID: 18565
	private static readonly int int_16;

	// Token: 0x04004886 RID: 18566
	private static readonly int int_17;

	// Token: 0x04004887 RID: 18567
	private static readonly int int_18;

	// Token: 0x04004888 RID: 18568
	private static readonly int int_19;

	// Token: 0x04004889 RID: 18569
	private static readonly int int_20;

	// Token: 0x0400488A RID: 18570
	private static readonly int int_21;

	// Token: 0x0400488B RID: 18571
	private static readonly int int_22;

	// Token: 0x0400488C RID: 18572
	private static readonly int int_23;

	// Token: 0x0400488D RID: 18573
	private static readonly int int_24;

	// Token: 0x0400488E RID: 18574
	private static readonly int int_25;

	// Token: 0x0400488F RID: 18575
	private static readonly int int_26;

	// Token: 0x04004890 RID: 18576
	private static readonly int int_27;

	// Token: 0x04004891 RID: 18577
	private static readonly int int_28;

	// Token: 0x04004892 RID: 18578
	private static readonly int int_29;

	// Token: 0x04004893 RID: 18579
	private readonly GClass884 gclass884_0;

	// Token: 0x04004894 RID: 18580
	private readonly GClass884 gclass884_1;

	// Token: 0x04004895 RID: 18581
	public bool StormEnabled;

	// Token: 0x04004896 RID: 18582
	public float WetAngleMin;

	// Token: 0x04004897 RID: 18583
	public float WetAngleMax;

	// Token: 0x04004898 RID: 18584
	public float SnowTransition;

	// Token: 0x04004899 RID: 18585
	[HideInInspector]
	[SerializeField]
	private Vector2 _textureTilingFactor;

	// Token: 0x0400489A RID: 18586
	[HideInInspector]
	[SerializeField]
	private Vector2 _noiseTilingFactor;

	// Token: 0x0400489B RID: 18587
	private Vector2 vector2_0;

	// Token: 0x0400489C RID: 18588
	private Vector2 vector2_1;

	// Token: 0x0400489D RID: 18589
	private Vector3 vector3_0;

	// Token: 0x0400489E RID: 18590
	private Vector3 vector3_1;

	// Token: 0x0400489F RID: 18591
	private float float_0;

	// Token: 0x040048A0 RID: 18592
	private LevelSettings levelSettings_0;

	// Token: 0x040048A1 RID: 18593
	public float _DampingDistance;

	// Token: 0x040048A2 RID: 18594
	private const float float_1 = 4f;

	// Token: 0x040048A3 RID: 18595
	public Texture2D AlbedoTex;

	// Token: 0x040048A4 RID: 18596
	public Texture2D SpecularMap;

	// Token: 0x040048A5 RID: 18597
	public Texture2D BumpMap;

	// Token: 0x040048A6 RID: 18598
	public Texture2D NoiseMap;

	// Token: 0x040048A7 RID: 18599
	public Vector2 ScreenNoiseTiling;

	// Token: 0x040048A8 RID: 18600
	public float Glossness;

	// Token: 0x040048A9 RID: 18601
	public Vector4 SnowSpecularFactor;

	// Token: 0x040048AA RID: 18602
	[Range(0f, 1f)]
	public float GlitterThreshold;

	// Token: 0x040048AB RID: 18603
	[Range(0f, 10f)]
	public float GlitterIntensity;
}
