using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	// Token: 0x02000ED5 RID: 3797
	[Serializable]
	public class TurbulenceParticleAffectorMT : MonoBehaviour
	{
		// Token: 0x06004F4F RID: 20303 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004F50 RID: 20304 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004F51 RID: 20305 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004F52 RID: 20306 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationQuit()
		{
			throw null;
		}

		// Token: 0x04005BF6 RID: 23542
		public float force;

		// Token: 0x04005BF7 RID: 23543
		public float speed;

		// Token: 0x04005BF8 RID: 23544
		private ParticleSystem particleSystem;

		// Token: 0x04005BF9 RID: 23545
		private ParticleSystem.Particle[] particles;

		// Token: 0x04005BFA RID: 23546
		private float randomX;

		// Token: 0x04005BFB RID: 23547
		private float randomY;

		// Token: 0x04005BFC RID: 23548
		private float randomZ;

		// Token: 0x04005BFD RID: 23549
		private float offsetX;

		// Token: 0x04005BFE RID: 23550
		private float offsetY;

		// Token: 0x04005BFF RID: 23551
		private float offsetZ;

		// Token: 0x04005C00 RID: 23552
		private float deltaTime;

		// Token: 0x04005C01 RID: 23553
		private Thread t;

		// Token: 0x04005C02 RID: 23554
		private readonly object locker;

		// Token: 0x04005C03 RID: 23555
		private bool processing;

		// Token: 0x04005C04 RID: 23556
		private bool isDoneAssigning;
	}
}
