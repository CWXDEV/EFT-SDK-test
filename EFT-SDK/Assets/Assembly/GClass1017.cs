using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x02000DAD RID: 3501
public class GClass1017
{
	// Token: 0x060049EB RID: 18923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Mesh> Split(Mesh mesh, Matrix4x4 transformMatrix)
	{
		throw null;
	}

	// Token: 0x060049EC RID: 18924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<GClass1017.Class691> smethod_0(List<GClass1017.Class692> triangles, int splitCount)
	{
		throw null;
	}

	// Token: 0x060049ED RID: 18925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GClass1017.Class691 smethod_1(Mesh mesh, Matrix4x4 transformMat)
	{
		throw null;
	}

	// Token: 0x060049EE RID: 18926 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_2(ref GClass1017.Struct155 struct155_0)
	{
		throw null;
	}

	// Token: 0x060049EF RID: 18927 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_3(Vector3 pos, Color col, ref GClass1017.Struct155 struct155_0)
	{
		throw null;
	}

	// Token: 0x04005529 RID: 21801
	private const int int_0 = 8000;

	// Token: 0x0400552A RID: 21802
	private static GClass1017.Class693 class693_0;

	// Token: 0x02000DAE RID: 3502
	private class Class691
	{
		// Token: 0x060049F0 RID: 18928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Mesh CreateMesh()
		{
			throw null;
		}

		// Token: 0x0400552B RID: 21803
		public List<int> indices;

		// Token: 0x0400552C RID: 21804
		public List<Vector3> verts;

		// Token: 0x0400552D RID: 21805
		public List<Color> colors;

		// Token: 0x0400552E RID: 21806
		public List<GClass1017.Class692> tris;
	}

	// Token: 0x02000DAF RID: 3503
	private class Class692
	{
		// Token: 0x0400552F RID: 21807
		public Vector3 posA;

		// Token: 0x04005530 RID: 21808
		public Vector3 posB;

		// Token: 0x04005531 RID: 21809
		public Vector3 posC;

		// Token: 0x04005532 RID: 21810
		public Color colA;

		// Token: 0x04005533 RID: 21811
		public Vector3 center;
	}

	// Token: 0x02000DB0 RID: 3504
	private class Class693 : IEqualityComparer<ValueTuple<Vector3, Color>>
	{
		// Token: 0x060049F1 RID: 18929 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ValueTuple<Vector3, Color> x, ValueTuple<Vector3, Color> y)
		{
			throw null;
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetHashCode(ValueTuple<Vector3, Color> obj)
		{
			throw null;
		}
	}

	// Token: 0x02000DB1 RID: 3505
	[CompilerGenerated]
	[Serializable]
	private sealed class Class694
	{
		// Token: 0x060049F3 RID: 18931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(GClass1017.Class692 a, GClass1017.Class692 b)
		{
			throw null;
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_1(GClass1017.Class692 a, GClass1017.Class692 b)
		{
			throw null;
		}

		// Token: 0x04005534 RID: 21812
		public static readonly GClass1017.Class694 class694_0;

		// Token: 0x04005535 RID: 21813
		public static Comparison<GClass1017.Class692> comparison_0;

		// Token: 0x04005536 RID: 21814
		public static Comparison<GClass1017.Class692> comparison_1;
	}

	// Token: 0x02000DB2 RID: 3506
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct155
	{
		// Token: 0x04005539 RID: 21817
		public Dictionary<ValueTuple<Vector3, Color>, int> spV;

		// Token: 0x0400553A RID: 21818
		public int cIndex;
	}
}
