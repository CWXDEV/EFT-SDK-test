using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000990 RID: 2448
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class RoadSolidMarkGenerator : MonoBehaviour
{
	// Token: 0x060036F0 RID: 14064 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060036F1 RID: 14065 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x060036F2 RID: 14066 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060036F3 RID: 14067 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Vector3[] points, int parts, float cullingRate)
	{
		throw null;
	}

	// Token: 0x060036F4 RID: 14068 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 FixOnGround(Vector3 point)
	{
		throw null;
	}

	// Token: 0x060036F5 RID: 14069 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Mesh method_2(Vector3[] points, Vector3[] forwards, ref float uvY, Mesh mesh = null)
	{
		throw null;
	}

	// Token: 0x060036F6 RID: 14070 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(Vector3[] points, Vector3[] forwards, int parts, out Vector3[][] lodsPoints, out Vector3[][] lodsForwards)
	{
		throw null;
	}

	// Token: 0x060036F7 RID: 14071 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1(Vector3[] points, Vector3[] forwards, int[] tris, Vector3[] verts, Vector3[] normals, Vector4[] tangents, Vector2[] uv, Rect uvRect, float width, ref float uvY, Color[] colors, Color[] oldColors, bool copyColorsInReverseOrder)
	{
		throw null;
	}

	// Token: 0x060036F8 RID: 14072 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3[] GeneratePoints(Vector3[] positions, float start, float end, float shift)
	{
		throw null;
	}

	// Token: 0x060036F9 RID: 14073 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3[] GetForwards(Vector3[] points)
	{
		throw null;
	}

	// Token: 0x060036FA RID: 14074 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 Lerp(Vector3 from, Vector3 to, float t)
	{
		throw null;
	}

	// Token: 0x04003838 RID: 14392
	public RoadSplineGenerator Parent;

	// Token: 0x04003839 RID: 14393
	public int Road;

	// Token: 0x0400383A RID: 14394
	public float Shift;

	// Token: 0x0400383B RID: 14395
	public float Width;

	// Token: 0x0400383C RID: 14396
	[Range(0f, 1f)]
	public float Start;

	// Token: 0x0400383D RID: 14397
	[Range(0f, 1f)]
	public float End;

	// Token: 0x0400383E RID: 14398
	public Rect UvRect;

	// Token: 0x0400383F RID: 14399
	public float RoadOffset;

	// Token: 0x04003840 RID: 14400
	public int LodParts;

	// Token: 0x04003841 RID: 14401
	[Range(0f, 100f)]
	public float CullingRate;

	// Token: 0x04003842 RID: 14402
	private MeshFilter meshFilter_0;

	// Token: 0x04003843 RID: 14403
	private float float_0;

	// Token: 0x04003844 RID: 14404
	public string Culled;

	// Token: 0x04003845 RID: 14405
	public LayerMask Mask;

	// Token: 0x04003846 RID: 14406
	private float float_1;

	// Token: 0x04003847 RID: 14407
	private bool bool_0;
}
