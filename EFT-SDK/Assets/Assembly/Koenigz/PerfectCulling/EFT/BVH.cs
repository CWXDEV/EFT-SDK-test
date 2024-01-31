using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DC7 RID: 3527
	[Serializable]
	public class BVH<T> where T : class, ISpatialItem
	{
		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06004A57 RID: 19031 RVA: 0x00002050 File Offset: 0x00000250
		public int NodeCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06004A58 RID: 19032 RVA: 0x00002050 File Offset: 0x00000250
		public int NodeCapacity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(int capacity)
		{
			throw null;
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int Add(T obj)
		{
			throw null;
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int OverlapNoAlloc(Bounds bounds, T[] outputArray)
		{
			throw null;
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<T> EnumerateOverlappingLeafNodes(Bounds bounds)
		{
			throw null;
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public T QueryNearest(Vector3 point, float radius)
		{
			throw null;
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Query(Vector3 point)
		{
			throw null;
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_0()
		{
			throw null;
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(int key)
		{
			throw null;
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(int leaf)
		{
			throw null;
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_3(int iA)
		{
			throw null;
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_4(int nodeId)
		{
			throw null;
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(int index)
		{
			throw null;
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(int index)
		{
			throw null;
		}

		// Token: 0x04005580 RID: 21888
		private const int EMPTY = -1;

		// Token: 0x04005581 RID: 21889
		private const float MARGIN = 0f;

		// Token: 0x04005582 RID: 21890
		private int _root;

		// Token: 0x04005583 RID: 21891
		private BVH<T>.Node[] _nodes;

		// Token: 0x04005584 RID: 21892
		private int _nodeCount;

		// Token: 0x04005585 RID: 21893
		private int _nodeCapacity;

		// Token: 0x04005586 RID: 21894
		private int _freeList;

		// Token: 0x04005587 RID: 21895
		private int _inCnt;

		// Token: 0x04005588 RID: 21896
		private readonly Stack<int> _growableStack;

		// Token: 0x02000DC8 RID: 3528
		[Serializable]
		private struct Node
		{
			// Token: 0x17000BCD RID: 3021
			// (get) Token: 0x06004A66 RID: 19046 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsLeaf
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04005589 RID: 21897
			public int Child1;

			// Token: 0x0400558A RID: 21898
			public int Child2;

			// Token: 0x0400558B RID: 21899
			public int Height;

			// Token: 0x0400558C RID: 21900
			public int Parent;

			// Token: 0x0400558D RID: 21901
			public int Next;

			// Token: 0x0400558E RID: 21902
			public Bounds AABB;

			// Token: 0x0400558F RID: 21903
			public T Object;
		}
	}
}
