using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AbsolutDecals;
using UnityEngine;

// Token: 0x02000C55 RID: 3157
public class DecalMeshClass
{
	// Token: 0x17000AF9 RID: 2809
	// (get) Token: 0x060044CB RID: 17611 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060044CC RID: 17612 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsFromStatic
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000AFA RID: 2810
	// (get) Token: 0x060044CD RID: 17613 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060044CE RID: 17614 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3[] Vertices
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000AFB RID: 2811
	// (get) Token: 0x060044CF RID: 17615 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060044D0 RID: 17616 RVA: 0x00002050 File Offset: 0x00000250
	public int VertexCount
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x060044D1 RID: 17617 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DecalMeshClass MakeMesh(List<Vector3> verticesList, List<Vector3> projectorVertsList, Vector3 normal, DecalProjector.ProjectionDirections projectionDirection, Vector3 projectionDirectionVector, Vector2[] decalUv, float offset, bool isInProjectorSpace, List<BoneWeight> boneWeights = null, Transform relativeTransform = null)
	{
		throw null;
	}

	// Token: 0x060044D2 RID: 17618 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2 GetUv(Vector3 projectorLocalVertices, DecalProjector.ProjectionDirections direction, Vector2[] decalUv)
	{
		throw null;
	}

	// Token: 0x060044D3 RID: 17619 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DecalMeshClass TerrainToMesh(TerrainData terrain, Transform terrainTransform, int terrainResolutionPow = 3)
	{
		throw null;
	}

	// Token: 0x060044D4 RID: 17620 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mesh ToMesh()
	{
		throw null;
	}

	// Token: 0x04004EC3 RID: 20163
	public Vector3[] _vertices;

	// Token: 0x04004EC4 RID: 20164
	public int[] Triangles;

	// Token: 0x04004EC5 RID: 20165
	public Vector3[] Normals;

	// Token: 0x04004EC6 RID: 20166
	public Vector2[] UV;

	// Token: 0x04004EC7 RID: 20167
	public bool IsSkinned;

	// Token: 0x04004EC8 RID: 20168
	public Matrix4x4[] BindPoses;

	// Token: 0x04004EC9 RID: 20169
	public BoneWeight[] BoneWeights;

	// Token: 0x04004ECA RID: 20170
	private static readonly Vector2 vector2_0;

	// Token: 0x04004ECB RID: 20171
	public Transform[] Bones;

	// Token: 0x04004ECC RID: 20172
	public Transform DecalTransform;

	// Token: 0x04004ECD RID: 20173
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04004ECE RID: 20174
	public Vector3[] WorldVertices;

	// Token: 0x04004ECF RID: 20175
	public Vector3[] WorldNormals;

	// Token: 0x04004ED0 RID: 20176
	[CompilerGenerated]
	private int int_0;

	// Token: 0x02000C56 RID: 3158
	[CompilerGenerated]
	[Serializable]
	private sealed class Class634
	{
		// Token: 0x060044D5 RID: 17621 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(GStruct65 x, GStruct65 y)
		{
			throw null;
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_1(GStruct65 x, GStruct65 y)
		{
			throw null;
		}

		// Token: 0x04004ED1 RID: 20177
		public static readonly DecalMeshClass.Class634 class634_0;

		// Token: 0x04004ED2 RID: 20178
		public static Comparison<GStruct65> comparison_0;

		// Token: 0x04004ED3 RID: 20179
		public static Comparison<GStruct65> comparison_1;
	}
}
