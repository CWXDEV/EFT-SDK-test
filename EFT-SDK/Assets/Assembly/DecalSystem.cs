using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AE1 RID: 2785
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class DecalSystem : MonoBehaviour
{
	// Token: 0x06003CB0 RID: 15536 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003CB1 RID: 15537 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06003CB2 RID: 15538 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x06003CB3 RID: 15539 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(Vector3 position, Vector3 normal)
	{
		throw null;
	}

	// Token: 0x06003CB4 RID: 15540 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(Vector3 position, Vector3 normal, int tile)
	{
		throw null;
	}

	// Token: 0x06003CB5 RID: 15541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Vector3 position)
	{
		throw null;
	}

	// Token: 0x0400428C RID: 17036
	public int Count;

	// Token: 0x0400428D RID: 17037
	public float SizeMin;

	// Token: 0x0400428E RID: 17038
	public float SizeRandomRange;

	// Token: 0x0400428F RID: 17039
	private bool bool_0;

	// Token: 0x04004290 RID: 17040
	public int TileSheetRows;

	// Token: 0x04004291 RID: 17041
	public int TileSheetColumns;

	// Token: 0x04004292 RID: 17042
	private Vector2[][] vector2_0;

	// Token: 0x04004293 RID: 17043
	private int int_0;

	// Token: 0x04004294 RID: 17044
	private bool bool_1;

	// Token: 0x04004295 RID: 17045
	private LinkedList<DecalSystem.Class557> linkedList_0;

	// Token: 0x04004296 RID: 17046
	private int int_1;

	// Token: 0x04004297 RID: 17047
	private DecalSystem.Class557[] class557_0;

	// Token: 0x04004298 RID: 17048
	private Vector3[] vector3_0;

	// Token: 0x04004299 RID: 17049
	private Vector3[] vector3_1;

	// Token: 0x0400429A RID: 17050
	private Vector4[] vector4_0;

	// Token: 0x0400429B RID: 17051
	private Vector2[] vector2_1;

	// Token: 0x0400429C RID: 17052
	private Vector2[] vector2_2;

	// Token: 0x0400429D RID: 17053
	private int[] int_2;

	// Token: 0x0400429E RID: 17054
	private Mesh mesh_0;

	// Token: 0x0400429F RID: 17055
	private Vector3 vector3_2;

	// Token: 0x040042A0 RID: 17056
	private Vector3 vector3_3;

	// Token: 0x02000AE2 RID: 2786
	private class Class557
	{
		// Token: 0x06003CB6 RID: 15542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FastCalcWithoutRotation(Vector3 position, Vector3 normal, float radius)
		{
			throw null;
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Calc(Vector3 position, Vector3 normal, float radius)
		{
			throw null;
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(Vector3[] vertices, Vector3[] normals, Vector4[] tangents)
		{
			throw null;
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(Vector3[] vertices, Vector3[] normals, Vector4[] tangents, Vector2[] uv)
		{
			throw null;
		}

		// Token: 0x040042A1 RID: 17057
		public int Pos4;

		// Token: 0x040042A2 RID: 17058
		public Vector3[] Vertices;

		// Token: 0x040042A3 RID: 17059
		public Vector3 Normal;

		// Token: 0x040042A4 RID: 17060
		public Vector4 Tangent;

		// Token: 0x040042A5 RID: 17061
		public Vector2[] Uv;
	}
}
