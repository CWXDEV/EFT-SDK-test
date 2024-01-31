using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000B69 RID: 2921
public class LightningController : MonoBehaviour
{
	// Token: 0x06003F5C RID: 16220 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003F5D RID: 16221 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003F5E RID: 16222 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SummonLightning(int seed)
	{
		throw null;
	}

	// Token: 0x06003F5F RID: 16223 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SummonThunder(int seed)
	{
		throw null;
	}

	// Token: 0x06003F60 RID: 16224 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static LightningController.Class599 smethod_0(int segments, Vector3 position, Vector3 direction, float rndVal, float segmentLength)
	{
		throw null;
	}

	// Token: 0x06003F61 RID: 16225 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static LightningController.Class599 smethod_1(int segments, Vector3 position, Vector3 direction, float rndVal, float segmentLength, float y, float attraction, float damping)
	{
		throw null;
	}

	// Token: 0x06003F62 RID: 16226 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static LightningController.Class599 smethod_2(int segmentsPow2, Vector3 start, Vector3 end, float rndVal)
	{
		throw null;
	}

	// Token: 0x06003F63 RID: 16227 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<LightningController.Class599> smethod_3(Vector3 start, float size, int mainSegmentsPow2, float mainRndVal, float branchRndVal, int iterations, float branchesProbobility, float branchDirectionality, float y, float attraction, float damping)
	{
		throw null;
	}

	// Token: 0x06003F64 RID: 16228 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<LightningController.Class599> smethod_4(Vector3 start, float size, int mainSegmentsPow2, float mainRndVal, float branchRndVal, int iterations, float branchesProbobility, float branchDirectionality, float y, float attraction, float damping)
	{
		throw null;
	}

	// Token: 0x06003F65 RID: 16229 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<LightningController.Class599> smethod_5(Vector3 start, Vector3 end, int mainSegmentsPow2, float mainRndVal, float branchRndVal, int iterations, float branchesProbobility, float branchDirectionality)
	{
		throw null;
	}

	// Token: 0x06003F66 RID: 16230 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<LightningController.Class599> method_0(Vector3 start, Vector3 end)
	{
		throw null;
	}

	// Token: 0x06003F67 RID: 16231 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Mesh mesh, List<LightningController.Class599> lines)
	{
		throw null;
	}

	// Token: 0x06003F68 RID: 16232 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(ref RenderTexture rt, Mesh mesh, float mapSize, int texSize, Vector2 position)
	{
		throw null;
	}

	// Token: 0x06003F69 RID: 16233 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_6(Mesh mesh, Material mat, RenderTexture dest)
	{
		throw null;
	}

	// Token: 0x06003F6A RID: 16234 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x0400472E RID: 18222
	public Material LightningLightOnClouds;

	// Token: 0x0400472F RID: 18223
	public Light LightSource;

	// Token: 0x04004730 RID: 18224
	[Range(0f, 1f)]
	public float LightningToThunderRelation;

	// Token: 0x04004731 RID: 18225
	public Vector2 MinMaxShotDelta;

	// Token: 0x04004732 RID: 18226
	[Space(16f)]
	public SoundBank SoundBank;

	// Token: 0x04004733 RID: 18227
	[Space(32f)]
	[Header("Generation", order = 2)]
	public float MapSize;

	// Token: 0x04004734 RID: 18228
	public int MainSegmentsPow2;

	// Token: 0x04004735 RID: 18229
	public float MainRndVal;

	// Token: 0x04004736 RID: 18230
	public float BranchRndVal;

	// Token: 0x04004737 RID: 18231
	public int Iterations;

	// Token: 0x04004738 RID: 18232
	public float Probobility;

	// Token: 0x04004739 RID: 18233
	public float BranchDirectionality;

	// Token: 0x0400473A RID: 18234
	public float CloudYLevel;

	// Token: 0x0400473B RID: 18235
	public float CloudAttraction;

	// Token: 0x0400473C RID: 18236
	public float CloudWidthByYLevel;

	// Token: 0x0400473D RID: 18237
	public float Damping;

	// Token: 0x0400473E RID: 18238
	public float UntouchingLightninigSize;

	// Token: 0x0400473F RID: 18239
	[Header("Rendering", order = 2)]
	[Space(32f)]
	public float CloudBlursIntensity;

	// Token: 0x04004740 RID: 18240
	public float[] CloudBlurs;

	// Token: 0x04004741 RID: 18241
	[Space(16f)]
	public float LightningIntensity;

	// Token: 0x04004742 RID: 18242
	public float CloudScaterredLightIntensity;

	// Token: 0x04004743 RID: 18243
	public float CloudForwardLightIntensity;

	// Token: 0x04004744 RID: 18244
	public float LightIntensity;

	// Token: 0x04004745 RID: 18245
	public float BlinkingSpeed;

	// Token: 0x04004746 RID: 18246
	public Vector2 LightningDuration;

	// Token: 0x04004747 RID: 18247
	public long TimeFactor;

	// Token: 0x04004748 RID: 18248
	private CloudsController.CloudLayer cloudLayer_0;

	// Token: 0x04004749 RID: 18249
	private static readonly GClass2103.GClass2105 gclass2105_0;

	// Token: 0x0400474A RID: 18250
	private Mesh mesh_0;

	// Token: 0x0400474B RID: 18251
	private MeshRenderer meshRenderer_0;

	// Token: 0x0400474C RID: 18252
	private RenderTexture renderTexture_0;

	// Token: 0x0400474D RID: 18253
	private MaterialPropertyBlock materialPropertyBlock_0;

	// Token: 0x0400474E RID: 18254
	private Color color_0;

	// Token: 0x0400474F RID: 18255
	private float float_0;

	// Token: 0x04004750 RID: 18256
	private float float_1;

	// Token: 0x04004751 RID: 18257
	private Vector2 vector2_0;

	// Token: 0x04004752 RID: 18258
	private float float_2;

	// Token: 0x04004753 RID: 18259
	private static readonly int int_0;

	// Token: 0x04004754 RID: 18260
	private static readonly int int_1;

	// Token: 0x04004755 RID: 18261
	private static readonly int int_2;

	// Token: 0x02000B6A RID: 2922
	private class Class599
	{
		// Token: 0x06003F6B RID: 16235 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int VerticesCount()
		{
			throw null;
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int TrianglesCount()
		{
			throw null;
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Fill(int vI, int tI, int[] triangles, Vector3[] positions, Vector3[] directions, Vector2[] uv, Vector4[] values)
		{
			throw null;
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GenerateValues()
		{
			throw null;
		}

		// Token: 0x04004756 RID: 18262
		public bool Strong;

		// Token: 0x04004757 RID: 18263
		public float Power;

		// Token: 0x04004758 RID: 18264
		public float UVStartY;

		// Token: 0x04004759 RID: 18265
		public Vector3[] Points;

		// Token: 0x0400475A RID: 18266
		public Vector3[] NormalizedDirections;

		// Token: 0x0400475B RID: 18267
		public float[] Ys;
	}
}
