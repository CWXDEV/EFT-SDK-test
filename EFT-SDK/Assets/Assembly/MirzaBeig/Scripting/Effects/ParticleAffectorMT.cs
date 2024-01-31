using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	// Token: 0x02000ED4 RID: 3796
	[Serializable]
	public class ParticleAffectorMT : MonoBehaviour
	{
		// Token: 0x06004F49 RID: 20297 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004F4A RID: 20298 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004F4B RID: 20299 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x06004F4E RID: 20302 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationQuit()
		{
			throw null;
		}

		// Token: 0x04005BE7 RID: 23527
		public float force;

		// Token: 0x04005BE8 RID: 23528
		public float speed;

		// Token: 0x04005BE9 RID: 23529
		private ParticleSystem particleSystem;

		// Token: 0x04005BEA RID: 23530
		private ParticleSystem.Particle[] particles;

		// Token: 0x04005BEB RID: 23531
		private float randomX;

		// Token: 0x04005BEC RID: 23532
		private float randomY;

		// Token: 0x04005BED RID: 23533
		private float randomZ;

		// Token: 0x04005BEE RID: 23534
		private float offsetX;

		// Token: 0x04005BEF RID: 23535
		private float offsetY;

		// Token: 0x04005BF0 RID: 23536
		private float offsetZ;

		// Token: 0x04005BF1 RID: 23537
		private float deltaTime;

		// Token: 0x04005BF2 RID: 23538
		private Thread t;

		// Token: 0x04005BF3 RID: 23539
		private readonly object locker;

		// Token: 0x04005BF4 RID: 23540
		private bool processing;

		// Token: 0x04005BF5 RID: 23541
		private bool isDoneAssigning;
	}
}
