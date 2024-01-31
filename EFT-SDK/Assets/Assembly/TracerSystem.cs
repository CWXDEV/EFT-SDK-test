using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AF5 RID: 2805
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class TracerSystem : MonoBehaviour
{
	// Token: 0x06003D08 RID: 15624 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003D09 RID: 15625 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06003D0A RID: 15626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(Vector3 start, Vector3 end, Color32 color)
	{
		throw null;
	}

	// Token: 0x06003D0B RID: 15627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(Vector3 start, Vector3 end, Color32 color, float size, float time = 1f)
	{
		throw null;
	}

	// Token: 0x06003D0C RID: 15628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Vector3 position)
	{
		throw null;
	}

	// Token: 0x04004320 RID: 17184
	public int Count;

	// Token: 0x04004321 RID: 17185
	public float Size;

	// Token: 0x04004322 RID: 17186
	private int int_0;

	// Token: 0x04004323 RID: 17187
	private LinkedList<TracerSystem.Class564> linkedList_0;

	// Token: 0x04004324 RID: 17188
	private TracerSystem.Class564[] class564_0;

	// Token: 0x04004325 RID: 17189
	private int int_1;

	// Token: 0x04004326 RID: 17190
	private Vector3[] vector3_0;

	// Token: 0x04004327 RID: 17191
	private Vector3[] vector3_1;

	// Token: 0x04004328 RID: 17192
	private Vector4[] vector4_0;

	// Token: 0x04004329 RID: 17193
	private Vector2[] vector2_0;

	// Token: 0x0400432A RID: 17194
	private Vector2[] vector2_1;

	// Token: 0x0400432B RID: 17195
	private Color32[] color32_0;

	// Token: 0x0400432C RID: 17196
	private int[] int_2;

	// Token: 0x0400432D RID: 17197
	private Mesh mesh_0;

	// Token: 0x0400432E RID: 17198
	private Vector3 vector3_2;

	// Token: 0x0400432F RID: 17199
	private Vector3 vector3_3;

	// Token: 0x02000AF6 RID: 2806
	private class Class564
	{
		// Token: 0x06003D0D RID: 15629 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Calc(Vector3 start, Vector3 end, float size, float time, Color32 color)
		{
			throw null;
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(Vector3[] vertices, Vector2[] uv2, Color32[] colors)
		{
			throw null;
		}

		// Token: 0x04004330 RID: 17200
		public int Pos4;

		// Token: 0x04004331 RID: 17201
		public Vector3[] Vertices;

		// Token: 0x04004332 RID: 17202
		public Vector2 Uv2Val;

		// Token: 0x04004333 RID: 17203
		public Color32 Color;
	}
}
