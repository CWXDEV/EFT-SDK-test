using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	// Token: 0x02000EE4 RID: 3812
	[AddComponentMenu("Effects/Particle Force Fields/Vortex Particle Force Field")]
	public class VortexParticleForceField : ParticleForceField
	{
		// Token: 0x06004FA1 RID: 20385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Update()
		{
			throw null;
		}

		// Token: 0x06004FA4 RID: 20388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void PerParticleSystemSetup()
		{
			throw null;
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Vector3 GetForce()
		{
			throw null;
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x04005C77 RID: 23671
		private Vector3 vector3_1;

		// Token: 0x04005C78 RID: 23672
		[Tooltip("Internal offset for the axis of rotation.\n\nUseful if the force field and particle system are on the same game object, and you need a seperate rotation for the system, and the affector, but don't want to make the two different game objects.")]
		[Header("ForceField Controls")]
		public Vector3 axisOfRotationOffset;
	}
}
