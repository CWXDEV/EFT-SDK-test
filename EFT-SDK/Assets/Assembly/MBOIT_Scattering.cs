using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000098 RID: 152
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Time of Day/Camera MBOIT Scattering")]
public class MBOIT_Scattering : TOD_ImageEffect
{
	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
	public int SLICES_COUNT
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
	public float SlicesFarDistance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
	public float SlicesDistributionExponent
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

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsDataUpdated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Start()
	{
		throw null;
	}

	// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnDestroy()
	{
		throw null;
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnPreCull()
	{
		throw null;
	}

	// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSlicesCount(int count, float distributionExp, float farDistance)
	{
		throw null;
	}

	// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(int width, int height)
	{
		throw null;
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnRenderImageMBOITMode(ComputeBuffer scatteringParameters)
	{
		throw null;
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RenderMoments(CommandBuffer cmd, RenderTexture depthBuffer, RenderTexture moments0UAV, RenderTexture moments1UAV)
	{
		throw null;
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RenderWithMBOIT(CommandBuffer cmd, RenderTexture moments0UAV, RenderTexture moments1UAV, RenderTexture momentsRcp, RenderTexture resultTexture)
	{
		throw null;
	}

	// Token: 0x0400030B RID: 779
	public bool Lighten;

	// Token: 0x0400030C RID: 780
	public bool FromLevelSettings;

	// Token: 0x0400030D RID: 781
	public ComputeShader ScatteringSlicesComputeShader;

	// Token: 0x0400030E RID: 782
	public ComputeShader ScatteringMBOITComputeShader;

	// Token: 0x0400030F RID: 783
	public ComputeShader ScatteringMBOITRCPComputeShader;

	// Token: 0x04000310 RID: 784
	public ComputeShader ScatteringMBOITFinalPassComputeShader;

	// Token: 0x04000311 RID: 785
	public Color ScatterColorMultiplier;

	// Token: 0x04000312 RID: 786
	public float ScatterGreyscale;

	// Token: 0x04000313 RID: 787
	public float ScatterDensityMultiplier;

	// Token: 0x04000314 RID: 788
	public float ScatterDensityPower;

	// Token: 0x04000315 RID: 789
	public float ScatterDensityBias;

	// Token: 0x04000316 RID: 790
	public float SOFT_SCALE;

	// Token: 0x04000317 RID: 791
	public float SOFT_CONTRAST_POWER;

	// Token: 0x04000318 RID: 792
	public Texture2D DitheringTexture;

	// Token: 0x04000319 RID: 793
	[Range(0f, 0.2f)]
	public float GlobalDensity;

	// Token: 0x0400031A RID: 794
	[Range(0f, 1f)]
	public float HeightFalloff;

	// Token: 0x0400031B RID: 795
	[Range(0.95f, 1f)]
	public float SunrizeGlow;

	// Token: 0x0400031C RID: 796
	[NonSerialized]
	public bool ThermalVisionIsEnabled;

	// Token: 0x0400031D RID: 797
	public float MBOITDitherScale;

	// Token: 0x0400031E RID: 798
	private int int_1;

	// Token: 0x0400031F RID: 799
	private float float_0;

	// Token: 0x04000320 RID: 800
	private float float_1;

	// Token: 0x04000321 RID: 801
	private bool bool_2;

	// Token: 0x04000322 RID: 802
	private bool bool_3;

	// Token: 0x04000323 RID: 803
	public float ZeroLevel;

	// Token: 0x04000324 RID: 804
	private static readonly int int_2;

	// Token: 0x04000325 RID: 805
	private static readonly int int_3;

	// Token: 0x04000326 RID: 806
	private static readonly int int_4;

	// Token: 0x04000327 RID: 807
	private static readonly int int_5;

	// Token: 0x04000328 RID: 808
	private ComputeBuffer computeBuffer_0;

	// Token: 0x04000329 RID: 809
	private RenderTexture renderTexture_0;

	// Token: 0x0400032A RID: 810
	private RenderTexture renderTexture_1;

	// Token: 0x0400032B RID: 811
	private RenderTexture renderTexture_2;

	// Token: 0x0400032C RID: 812
	private Mesh mesh_0;

	// Token: 0x0400032D RID: 813
	private CommandBuffer commandBuffer_0;

	// Token: 0x0400032E RID: 814
	private SSAA ssaa_0;

	// Token: 0x0400032F RID: 815
	private Camera camera_0;

	// Token: 0x04000330 RID: 816
	private bool bool_4;

	// Token: 0x04000331 RID: 817
	private ComputeBuffer computeBuffer_1;

	// Token: 0x04000332 RID: 818
	private MBOIT_Scattering.Struct0[] struct0_0;

	// Token: 0x02000099 RID: 153
	[StructLayout(LayoutKind.Auto)]
	public struct Struct0
	{
		// Token: 0x04000333 RID: 819
		public float ColorMultiplierRed;

		// Token: 0x04000334 RID: 820
		public float ColorMultiplierGreen;

		// Token: 0x04000335 RID: 821
		public float ColorMultiplierBlue;

		// Token: 0x04000336 RID: 822
		public float ScatterDensityMultiplier;

		// Token: 0x04000337 RID: 823
		public float ScatterDensityPower;

		// Token: 0x04000338 RID: 824
		public float ScatterDensityBias;

		// Token: 0x04000339 RID: 825
		public float ScatterGreyscale;
	}
}
