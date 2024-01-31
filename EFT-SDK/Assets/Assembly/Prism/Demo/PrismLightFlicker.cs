using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prism.Demo
{
	// Token: 0x02000D73 RID: 3443
	[RequireComponent(typeof(Light))]
	public class PrismLightFlicker : MonoBehaviour
	{
		// Token: 0x06004919 RID: 18713 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float smethod_0(float start, float end, float t)
		{
			throw null;
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x040053FD RID: 21501
		[Range(-2f, 2f)]
		public float offset;

		// Token: 0x040053FE RID: 21502
		[Range(0f, 1f)]
		public float flickerChance;

		// Token: 0x040053FF RID: 21503
		[Range(0f, 5f)]
		public float minAliveTime;

		// Token: 0x04005400 RID: 21504
		[Range(0f, 5f)]
		public float maxAliveTime;

		// Token: 0x04005401 RID: 21505
		[Range(0f, 5f)]
		public float flickerSpeed;

		// Token: 0x04005402 RID: 21506
		private float float_0;

		// Token: 0x04005403 RID: 21507
		private Light light_0;

		// Token: 0x04005404 RID: 21508
		private float float_1;

		// Token: 0x04005405 RID: 21509
		private float float_2;

		// Token: 0x04005406 RID: 21510
		private float float_3;
	}
}
