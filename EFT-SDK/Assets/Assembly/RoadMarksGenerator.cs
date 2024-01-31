using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200098F RID: 2447
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class RoadMarksGenerator : MonoBehaviour
{
	// Token: 0x060036E5 RID: 14053 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060036E6 RID: 14054 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x060036E7 RID: 14055 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060036E8 RID: 14056 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Vector3[] marksPos, int parts, float cullingRate)
	{
		throw null;
	}

	// Token: 0x060036E9 RID: 14057 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 FixOnGround(Vector3 point)
	{
		throw null;
	}

	// Token: 0x060036EA RID: 14058 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Mesh method_2(Vector3[] marksPos, Mesh mesh = null)
	{
		throw null;
	}

	// Token: 0x060036EB RID: 14059 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3[][] method_3(Vector3[] marksPos, int parts)
	{
		throw null;
	}

	// Token: 0x060036EC RID: 14060 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(Vector3[] marksPos, int[] tris, Vector3[] verts, Vector3[] normals, Vector4[] tangents, Vector2[] uv, Rect uvRect, float width, Color[] colors, Color[] oldColors, bool copyColorsInReverseOrder)
	{
		throw null;
	}

	// Token: 0x060036ED RID: 14061 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector3[] smethod_0(RoadSplineGenerator.Road road, float shift, float markLength, float markDist, float start, float end)
	{
		throw null;
	}

	// Token: 0x060036EE RID: 14062 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 Lerp(Vector3 from, Vector3 to, float t)
	{
		throw null;
	}

	// Token: 0x060036EF RID: 14063 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GeneratePoints(Vector3[] positions, float[] lengths, float shift)
	{
		throw null;
	}

	// Token: 0x04003826 RID: 14374
	public RoadSplineGenerator Parent;

	// Token: 0x04003827 RID: 14375
	public int Road;

	// Token: 0x04003828 RID: 14376
	public float Shift;

	// Token: 0x04003829 RID: 14377
	public float Width;

	// Token: 0x0400382A RID: 14378
	public float MarkLength;

	// Token: 0x0400382B RID: 14379
	public float MarkDist;

	// Token: 0x0400382C RID: 14380
	[Range(0f, 1f)]
	public float Start;

	// Token: 0x0400382D RID: 14381
	[Range(0f, 1f)]
	public float End;

	// Token: 0x0400382E RID: 14382
	public Rect UvRect;

	// Token: 0x0400382F RID: 14383
	public float RoadOffset;

	// Token: 0x04003830 RID: 14384
	public int LodParts;

	// Token: 0x04003831 RID: 14385
	[Range(0f, 100f)]
	public float CullingRate;

	// Token: 0x04003832 RID: 14386
	private MeshFilter meshFilter_0;

	// Token: 0x04003833 RID: 14387
	private float float_0;

	// Token: 0x04003834 RID: 14388
	public string Culled;

	// Token: 0x04003835 RID: 14389
	public LayerMask Mask;

	// Token: 0x04003836 RID: 14390
	private float float_1;

	// Token: 0x04003837 RID: 14391
	private bool bool_0;
}
