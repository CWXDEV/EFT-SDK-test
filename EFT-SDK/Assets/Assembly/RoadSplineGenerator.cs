using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x02000991 RID: 2449
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class RoadSplineGenerator : MonoBehaviour
{
	// Token: 0x140000C2 RID: 194
	// (add) Token: 0x060036FB RID: 14075 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060036FC RID: 14076 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnGenerate
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

	// Token: 0x060036FD RID: 14077 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mesh GetMesh()
	{
		throw null;
	}

	// Token: 0x060036FE RID: 14078 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Generate()
	{
		throw null;
	}

	// Token: 0x060036FF RID: 14079 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(Vector2[] uv, int widthVerts, int count, out int[] starts, out int[] lengths)
	{
		throw null;
	}

	// Token: 0x06003700 RID: 14080 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GenerateLods(int roadI, Color32[] oldColors)
	{
		throw null;
	}

	// Token: 0x06003701 RID: 14081 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color32[] method_0(int roadI)
	{
		throw null;
	}

	// Token: 0x06003702 RID: 14082 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(int roadI, Color32[] colors, ref int i)
	{
		throw null;
	}

	// Token: 0x06003703 RID: 14083 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color32[] GetColors()
	{
		throw null;
	}

	// Token: 0x06003704 RID: 14084 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCullingRate()
	{
		throw null;
	}

	// Token: 0x06003705 RID: 14085 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 FixOnGround(Vector3 point)
	{
		throw null;
	}

	// Token: 0x06003706 RID: 14086 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3[] GetPoints(RoadSplineGenerator.Road road)
	{
		throw null;
	}

	// Token: 0x06003707 RID: 14087 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3[] GetPointsHeld(RoadSplineGenerator.Road road)
	{
		throw null;
	}

	// Token: 0x06003708 RID: 14088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float[] GetVals(RoadSplineGenerator.Road road)
	{
		throw null;
	}

	// Token: 0x06003709 RID: 14089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3[] GetPoints(Vector3 p0, Vector3 p1, Vector3 n0, Vector3 n1, int parts)
	{
		throw null;
	}

	// Token: 0x0600370A RID: 14090 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector3[] smethod_1(Vector3[] points, float error, int maxOptimization)
	{
		throw null;
	}

	// Token: 0x0600370B RID: 14091 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_2(LinkedList<Vector3> points, float error)
	{
		throw null;
	}

	// Token: 0x0600370C RID: 14092 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_3(ref Vector3[] points, ref float[] vals, float error, int maxOptimization)
	{
		throw null;
	}

	// Token: 0x0600370D RID: 14093 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_4(Vector3[] points, LinkedList<int> indices, float error)
	{
		throw null;
	}

	// Token: 0x0600370E RID: 14094 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 GetCurve(float t, Vector3 p0, Vector3 n0, Vector3 n1, Vector3 p1)
	{
		throw null;
	}

	// Token: 0x0600370F RID: 14095 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector3 smethod_5(float t, Vector3 p0, Vector3 m0, Vector3 m1, Vector3 p1)
	{
		throw null;
	}

	// Token: 0x06003710 RID: 14096 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RoadSplineGenerator.GStruct54[] GeneratePoints(Vector3[] positions, bool calcDistances = true)
	{
		throw null;
	}

	// Token: 0x06003711 RID: 14097 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 CrossUp(Vector3 lhs)
	{
		throw null;
	}

	// Token: 0x06003712 RID: 14098 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DropChilds(Transform transform)
	{
		throw null;
	}

	// Token: 0x06003713 RID: 14099 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06003714 RID: 14100 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(MeshRenderer lodMeshRenderer, Material lodMeshMaterial)
	{
		throw null;
	}

	// Token: 0x04003848 RID: 14408
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x04003849 RID: 14409
	public RoadSplineGenerator.Road[] Roads;

	// Token: 0x0400384A RID: 14410
	public float Error;

	// Token: 0x0400384B RID: 14411
	public int MaxOptimization;

	// Token: 0x0400384C RID: 14412
	public float TerrainOffset;

	// Token: 0x0400384D RID: 14413
	public LayerMask Mask;

	// Token: 0x0400384E RID: 14414
	public bool SplitForLods;

	// Token: 0x0400384F RID: 14415
	public float CullingRate;

	// Token: 0x04003850 RID: 14416
	public bool LockGeneration;

	// Token: 0x04003851 RID: 14417
	private MeshFilter meshFilter_0;

	// Token: 0x04003852 RID: 14418
	public Mesh Mesh;

	// Token: 0x02000992 RID: 2450
	[Serializable]
	public class Road
	{
		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06003715 RID: 14101 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003716 RID: 14102 RVA: 0x00002050 File Offset: 0x00000250
		public bool Hold
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

		// Token: 0x06003717 RID: 14103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GeneratePoints(float error)
		{
			throw null;
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetTrianglesCount()
		{
			throw null;
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetVerticesCount()
		{
			throw null;
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Generate(ref int vIndex, ref int tIndex, int[] triangles, Vector3[] positions, Vector4[] tangents, Vector2[] uv0, Color32[] colors, Color32[] oldColors, float error, bool lodGeneration)
		{
			throw null;
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float[] GetVals()
		{
			throw null;
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetVerticesDelta()
		{
			throw null;
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(RoadSplineGenerator.GStruct54[] points, float[] vals, ref int vIndex, ref int tIndex, int[] triangles, Vector3[] positions, Vector4[] tangents, Vector2[] uv0, Color32[] colors)
		{
			throw null;
		}

		// Token: 0x04003853 RID: 14419
		public RoadSplineGenerator Parent;

		// Token: 0x04003854 RID: 14420
		public Vector3[] Positins;

		// Token: 0x04003855 RID: 14421
		public Vector3[] Normals;

		// Token: 0x04003856 RID: 14422
		public int Parts;

		// Token: 0x04003857 RID: 14423
		public Vector3[] Optimized;

		// Token: 0x04003858 RID: 14424
		public float[] OptimizedVals;

		// Token: 0x04003859 RID: 14425
		public float Width;

		// Token: 0x0400385A RID: 14426
		public int WidthParts;

		// Token: 0x0400385B RID: 14427
		public float[] WidthVals;

		// Token: 0x0400385C RID: 14428
		public bool UseWidthVals;

		// Token: 0x0400385D RID: 14429
		public float TexDensity;

		// Token: 0x0400385E RID: 14430
		public float TexXDensity;

		// Token: 0x0400385F RID: 14431
		public Vector4 Borders;

		// Token: 0x04003860 RID: 14432
		public int LodsCount;

		// Token: 0x04003861 RID: 14433
		[SerializeField]
		private bool _hold;

		// Token: 0x04003862 RID: 14434
		public int LastVertId;

		// Token: 0x04003863 RID: 14435
		public bool UseCurve;

		// Token: 0x04003864 RID: 14436
		public AnimationCurve WidthCurve;

		// Token: 0x04003865 RID: 14437
		private int _verticesDelta;
	}

	// Token: 0x02000993 RID: 2451
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct54
	{
		// Token: 0x04003866 RID: 14438
		public Vector3 Position;

		// Token: 0x04003867 RID: 14439
		public Vector3 Right;

		// Token: 0x04003868 RID: 14440
		public float NextDist;
	}
}
