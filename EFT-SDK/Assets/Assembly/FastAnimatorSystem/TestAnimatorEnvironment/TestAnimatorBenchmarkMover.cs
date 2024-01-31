using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FastAnimatorSystem.TestAnimatorEnvironment
{
	// Token: 0x02000F60 RID: 3936
	public class TestAnimatorBenchmarkMover : MonoBehaviour
	{
		// Token: 0x060052D5 RID: 21205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int count, TestAnimatorSkeleton skeletonPrefab)
		{
			throw null;
		}

		// Token: 0x04005E3C RID: 24124
		public TestAnimatorSkeleton fastSkeletonPrefab;

		// Token: 0x04005E3D RID: 24125
		public TestAnimatorSkeleton origSkeletonPrefab;

		// Token: 0x04005E3E RID: 24126
		public float speed;

		// Token: 0x04005E3F RID: 24127
		public float deltaTreshhold;

		// Token: 0x04005E40 RID: 24128
		public float actualDelta;

		// Token: 0x04005E41 RID: 24129
		public int spawnCount;

		// Token: 0x04005E42 RID: 24130
		private int int_0;

		// Token: 0x04005E43 RID: 24131
		private int int_1;

		// Token: 0x04005E44 RID: 24132
		private int int_2;

		// Token: 0x04005E45 RID: 24133
		private int int_3;

		// Token: 0x04005E46 RID: 24134
		private List<IAnimator> list_0;

		// Token: 0x04005E47 RID: 24135
		private List<TestAnimatorSkeleton> list_1;

		// Token: 0x04005E48 RID: 24136
		private float float_0;

		// Token: 0x04005E49 RID: 24137
		private float float_1;
	}
}
