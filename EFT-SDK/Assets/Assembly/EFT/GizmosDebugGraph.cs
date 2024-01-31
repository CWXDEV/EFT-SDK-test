using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x020014BD RID: 5309
	public class GizmosDebugGraph : MonoBehaviour
	{
		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x060071CF RID: 29135 RVA: 0x00002050 File Offset: 0x00000250
		public static GizmosDebugGraph Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060071D0 RID: 29136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddValue(int value, Color color, Vector3 position, Vector2 size)
		{
			throw null;
		}

		// Token: 0x060071D1 RID: 29137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddValue(int value, Color color, Vector3 position, Vector2 size, int min, int max)
		{
			throw null;
		}

		// Token: 0x060071D2 RID: 29138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x04007867 RID: 30823
		private static GizmosDebugGraph gizmosDebugGraph_0;

		// Token: 0x04007868 RID: 30824
		private GClass1093<ValueTuple<int, Color>> gclass1093_0;

		// Token: 0x04007869 RID: 30825
		private List<ValueTuple<Vector3, Color>> list_0;

		// Token: 0x0400786A RID: 30826
		private Vector3 vector3_0;

		// Token: 0x0400786B RID: 30827
		private Vector2 vector2_0;

		// Token: 0x0400786C RID: 30828
		private Color color_0;

		// Token: 0x0400786D RID: 30829
		private int int_0;

		// Token: 0x0400786E RID: 30830
		private int int_1;

		// Token: 0x020014BE RID: 5310
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1117
		{
			// Token: 0x060071D3 RID: 29139 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(ValueTuple<int, Color> v)
			{
				throw null;
			}

			// Token: 0x060071D4 RID: 29140 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_1(ValueTuple<int, Color> v)
			{
				throw null;
			}

			// Token: 0x0400786F RID: 30831
			public static readonly GizmosDebugGraph.Class1117 class1117_0;

			// Token: 0x04007870 RID: 30832
			public static Func<ValueTuple<int, Color>, int> func_0;

			// Token: 0x04007871 RID: 30833
			public static Func<ValueTuple<int, Color>, int> func_1;
		}
	}
}
