using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	// Token: 0x02000EDE RID: 3806
	[AddComponentMenu("Effects/Particle Force Fields/Attraction Particle Force Field")]
	public class AttractionParticleForceField : ParticleForceField
	{
		// Token: 0x06004F7F RID: 20351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Update()
		{
			throw null;
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Vector3 GetForce()
		{
			throw null;
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x04005C47 RID: 23623
		[Header("ForceField Controls")]
		[Tooltip("Tether force based on linear inverse particle distance to force field center.")]
		public float arrivalRadius;

		// Token: 0x04005C48 RID: 23624
		[Tooltip("Dead zone from force field center in which no additional force is applied.")]
		public float arrivedRadius;

		// Token: 0x04005C49 RID: 23625
		private float float_4;

		// Token: 0x04005C4A RID: 23626
		private float float_5;
	}
}
