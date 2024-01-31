using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x02003186 RID: 12678
	public class FillPathGenerator : SmoothPathGenerator
	{
		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x0600F9E0 RID: 63968 RVA: 0x00002050 File Offset: 0x00000250
		protected override float JointSizeLink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x0600F9E1 RID: 63969 RVA: 0x00002050 File Offset: 0x00000250
		protected override int JointSmoothingLink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F9E2 RID: 63970 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLineSmoothing(bool hasParent, int jointSmoothing, float jointSize)
		{
			throw null;
		}

		// Token: 0x0600F9E3 RID: 63971 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStrechFill(bool strech)
		{
			throw null;
		}

		// Token: 0x0600F9E4 RID: 63972 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGraphBounds(float bottom, float top)
		{
			throw null;
		}

		// Token: 0x0600F9E5 RID: 63973 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_1(Vector3 position, float thickness, float u)
		{
			throw null;
		}

		// Token: 0x0600F9E6 RID: 63974 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(List<int> tringles, int from, int to)
		{
			throw null;
		}

		// Token: 0x0600F9E7 RID: 63975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Generator(Vector3[] path, float thickness, bool closed)
		{
			throw null;
		}

		// Token: 0x0400FE08 RID: 65032
		public bool WithTop;

		// Token: 0x0400FE09 RID: 65033
		public bool MatchLine;

		// Token: 0x0400FE0A RID: 65034
		private float float_0;

		// Token: 0x0400FE0B RID: 65035
		private float float_1;

		// Token: 0x0400FE0C RID: 65036
		private bool bool_0;

		// Token: 0x0400FE0D RID: 65037
		private List<int> list_1;

		// Token: 0x0400FE0E RID: 65038
		private List<Vector2> list_2;

		// Token: 0x0400FE0F RID: 65039
		private List<Vector3> list_3;

		// Token: 0x0400FE10 RID: 65040
		private bool bool_1;

		// Token: 0x0400FE11 RID: 65041
		private int int_0;

		// Token: 0x0400FE12 RID: 65042
		private float float_2;
	}
}
