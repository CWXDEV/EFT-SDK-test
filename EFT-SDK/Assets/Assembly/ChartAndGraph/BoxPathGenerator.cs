using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x02003184 RID: 12676
	[RequireComponent(typeof(MeshRenderer))]
	[RequireComponent(typeof(MeshFilter))]
	public class BoxPathGenerator : SmoothPathGenerator
	{
		// Token: 0x0600F9D9 RID: 63961 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_1(float thickness, Quaternion rotation, Vector3 center, float u)
		{
			throw null;
		}

		// Token: 0x0600F9DA RID: 63962 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(List<int> tringles, int from, int to)
		{
			throw null;
		}

		// Token: 0x0600F9DB RID: 63963 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Generator(Vector3[] path, float thickness, bool closed)
		{
			throw null;
		}

		// Token: 0x0400FDFD RID: 65021
		[Range(0f, 10f)]
		public float HeightRatio;

		// Token: 0x0400FDFE RID: 65022
		private List<int> list_1;

		// Token: 0x0400FDFF RID: 65023
		private List<Vector2> list_2;

		// Token: 0x0400FE00 RID: 65024
		private List<Vector3> list_3;
	}
}
