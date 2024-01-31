using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x02003185 RID: 12677
	[RequireComponent(typeof(MeshFilter))]
	[RequireComponent(typeof(MeshRenderer))]
	public class CylinderPathGenerator : SmoothPathGenerator
	{
		// Token: 0x0600F9DC RID: 63964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600F9DD RID: 63965 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_2(float thickness, Quaternion angle, Vector3 center, float u)
		{
			throw null;
		}

		// Token: 0x0600F9DE RID: 63966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(List<int> tringles, int from, int to)
		{
			throw null;
		}

		// Token: 0x0600F9DF RID: 63967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Generator(Vector3[] path, float thickness, bool closed)
		{
			throw null;
		}

		// Token: 0x0400FE01 RID: 65025
		public int CircleVertices;

		// Token: 0x0400FE02 RID: 65026
		[Range(0.01f, 10f)]
		public float HeightRatio;

		// Token: 0x0400FE03 RID: 65027
		private Vector3[] vector3_0;

		// Token: 0x0400FE04 RID: 65028
		private Vector3[] vector3_1;

		// Token: 0x0400FE05 RID: 65029
		private List<int> list_1;

		// Token: 0x0400FE06 RID: 65030
		private List<Vector2> list_2;

		// Token: 0x0400FE07 RID: 65031
		private List<Vector3> list_3;
	}
}
