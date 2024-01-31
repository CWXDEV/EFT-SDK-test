using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000B19 RID: 2841
public class SpeedTreeTerrainProcessor : MonoBehaviour
{
	// Token: 0x06003DAC RID: 15788 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06003DAD RID: 15789 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static LODGroup[,][] smethod_0(Terrain terrain, IEnumerable<LODGroup> lodGroups, float cellSize)
	{
		throw null;
	}

	// Token: 0x06003DAE RID: 15790 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Dictionary<int, SpeedTreeTerrainProcessor.Class582> smethod_1(IEnumerable<LODGroup> lodGroups)
	{
		throw null;
	}

	// Token: 0x06003DAF RID: 15791 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateTreesInteractiveParts(Terrain terrain)
	{
		throw null;
	}

	// Token: 0x06003DB0 RID: 15792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_2(Terrain terrain, Transform spawnTarget)
	{
		throw null;
	}

	// Token: 0x06003DB1 RID: 15793 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Dictionary<int, List<LODGroup>> smethod_3(LODGroup[] groups)
	{
		throw null;
	}

	// Token: 0x06003DB2 RID: 15794 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(LODGroup[,][] grid, Dictionary<int, SpeedTreeTerrainProcessor.Class582> prototypes)
	{
		throw null;
	}

	// Token: 0x06003DB3 RID: 15795 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(LODGroup[] cellGroups, Dictionary<int, SpeedTreeTerrainProcessor.Class582> prototypes, string name)
	{
		throw null;
	}

	// Token: 0x06003DB4 RID: 15796 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<Renderer>[] method_2(SpeedTreeTerrainProcessor.Class582 prototype, LOD[][] lods)
	{
		throw null;
	}

	// Token: 0x06003DB5 RID: 15797 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_4(List<Renderer>[] lodsRenderersList, int lodNum, SpeedTreeTerrainProcessor.Class583 prototypeRenderer)
	{
		throw null;
	}

	// Token: 0x06003DB6 RID: 15798 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Mesh smethod_5(MeshFilter[] meshFilters, Vector3 commonPosition)
	{
		throw null;
	}

	// Token: 0x06003DB7 RID: 15799 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(List<Renderer>[] lodsRenderersList, LOD[][] lods, int lodNum, int rendererNum, SpeedTreeTerrainProcessor.Class583 prototypeRenderer)
	{
		throw null;
	}

	// Token: 0x06003DB8 RID: 15800 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_6(List<Renderer>[] lodsRenderersList, LOD[][] lods, int lodNum, int rendererNum, SpeedTreeTerrainProcessor.Class583 prototypeRenderer)
	{
		throw null;
	}

	// Token: 0x06003DB9 RID: 15801 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(List<Renderer>[] lodsRenderersList, LOD[][] lods, int lodNum, int rendererNum, SpeedTreeTerrainProcessor.Class583 prototypeRenderer)
	{
		throw null;
	}

	// Token: 0x06003DBA RID: 15802 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private MeshRenderer method_5(LinkedList<MeshFilter> meshFiltersList, SpeedTreeTerrainProcessor.Class583 prototypeRenderer)
	{
		throw null;
	}

	// Token: 0x06003DBB RID: 15803 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(List<Renderer>[] lodsRenderersList, SpeedTreeTerrainProcessor.Class582 prototype, string name)
	{
		throw null;
	}

	// Token: 0x06003DBC RID: 15804 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_7(LODGroup lodGroup, List<Renderer>[] lodsRenderersList, float[] cullingRates)
	{
		throw null;
	}

	// Token: 0x06003DBD RID: 15805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int smethod_8(LODGroup lodGroup)
	{
		throw null;
	}

	// Token: 0x04004420 RID: 17440
	public Terrain Terrain;

	// Token: 0x04004421 RID: 17441
	public Shader SpeedTreeShader;

	// Token: 0x04004422 RID: 17442
	public bool SpawnTerrainPrefabs;

	// Token: 0x04004423 RID: 17443
	public Transform SpawnTarget;

	// Token: 0x04004424 RID: 17444
	public bool CombineOrdinaryMeshes;

	// Token: 0x04004425 RID: 17445
	public float CellSize;

	// Token: 0x02000B1A RID: 2842
	private class Class582
	{
		// Token: 0x06003DBE RID: 15806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float[] smethod_0(LOD[] lods)
		{
			throw null;
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static SpeedTreeTerrainProcessor.Class583[][] smethod_1(LOD[] lods)
		{
			throw null;
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_2(SpeedTreeTerrainProcessor.Class583[][] lodsRenderers, LOD[] lods)
		{
			throw null;
		}

		// Token: 0x04004426 RID: 17446
		public SpeedTreeTerrainProcessor.Class583[][] LodsRenderers;

		// Token: 0x04004427 RID: 17447
		public float[] CullingRates;
	}

	// Token: 0x02000B1B RID: 2843
	private class Class583
	{
		// Token: 0x06003DC1 RID: 15809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Renderer renderer)
		{
			throw null;
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRendererSettings(Renderer renderer)
		{
			throw null;
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static GameObject smethod_0(Renderer renderer)
		{
			throw null;
		}

		// Token: 0x04004428 RID: 17448
		public int VertexCount;

		// Token: 0x04004429 RID: 17449
		public int SubMeshCount;

		// Token: 0x0400442A RID: 17450
		public GameObject Prefab;

		// Token: 0x0400442B RID: 17451
		public SpeedTreeTerrainProcessor.ObjType Type;

		// Token: 0x0400442C RID: 17452
		public int SameRendererLodNum;

		// Token: 0x0400442D RID: 17453
		public Material[] Materials;

		// Token: 0x0400442E RID: 17454
		private ShadowCastingMode shadowCastingMode_0;

		// Token: 0x0400442F RID: 17455
		private bool bool_0;

		// Token: 0x04004430 RID: 17456
		private LightProbeUsage lightProbeUsage_0;

		// Token: 0x04004431 RID: 17457
		private ReflectionProbeUsage reflectionProbeUsage_0;
	}

	// Token: 0x02000B1C RID: 2844
	private enum ObjType
	{
		// Token: 0x04004433 RID: 17459
		SpeedTree,
		// Token: 0x04004434 RID: 17460
		Billboard,
		// Token: 0x04004435 RID: 17461
		Mesh
	}
}
