using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	// Token: 0x02000EE0 RID: 3808
	public abstract class ParticleForceField : MonoBehaviour
	{
		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06004F90 RID: 20368 RVA: 0x00002050 File Offset: 0x00000250
		public float scaledRadius
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void PerParticleSystemSetup()
		{
			throw null;
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Vector3 GetForce()
		{
			throw null;
		}

		// Token: 0x06004F95 RID: 20373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x06004F96 RID: 20374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddParticleSystem(ParticleSystem particleSystem)
		{
			throw null;
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveParticleSystem(ParticleSystem particleSystem)
		{
			throw null;
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationQuit()
		{
			throw null;
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x04005C4E RID: 23630
		[Header("Common Controls")]
		[Tooltip("Force field spherical range.")]
		public float radius;

		// Token: 0x04005C4F RID: 23631
		[Tooltip("Maximum baseline force.")]
		public float force;

		// Token: 0x04005C50 RID: 23632
		[Tooltip("Internal force field position offset.")]
		public Vector3 center;

		// Token: 0x04005C51 RID: 23633
		private float float_0;

		// Token: 0x04005C52 RID: 23634
		private float float_1;

		// Token: 0x04005C53 RID: 23635
		private float float_2;

		// Token: 0x04005C54 RID: 23636
		private Vector3 vector3_0;

		// Token: 0x04005C55 RID: 23637
		private float[] float_3;

		// Token: 0x04005C56 RID: 23638
		[Tooltip("Force scale as determined by distance to individual particles.")]
		public AnimationCurve forceOverDistance;

		// Token: 0x04005C57 RID: 23639
		private ParticleSystem particleSystem_0;

		// Token: 0x04005C58 RID: 23640
		[Tooltip("If nothing no particle systems are assigned, this force field will operate globally on ALL particle systems in the scene (NOT recommended).\n\nIf attached to a particle system, the force field will operate only on that system.\n\nIf specific particle systems are assigned, then the force field will operate on those systems only, even if attached to a particle system.")]
		public List<ParticleSystem> _particleSystems;

		// Token: 0x04005C59 RID: 23641
		private int int_0;

		// Token: 0x04005C5A RID: 23642
		private List<ParticleSystem> list_0;

		// Token: 0x04005C5B RID: 23643
		private ParticleSystem.Particle[][] particle_0;

		// Token: 0x04005C5C RID: 23644
		private ParticleSystem.MainModule[] mainModule_0;

		// Token: 0x04005C5D RID: 23645
		private Renderer[] renderer_0;

		// Token: 0x04005C5E RID: 23646
		protected ParticleSystem currentParticleSystem;

		// Token: 0x04005C5F RID: 23647
		protected ParticleForceField.GetForceParameters parameters;

		// Token: 0x04005C60 RID: 23648
		[Tooltip("If TRUE, update even if target particle system(s) are invisible/offscreen.\n\nIf FALSE, update only if particles of the target system(s) are visible/onscreen.")]
		public bool alwaysUpdate;

		// Token: 0x02000EE1 RID: 3809
		protected struct GetForceParameters
		{
			// Token: 0x04005C61 RID: 23649
			public float distanceToForceFieldCenterSqr;

			// Token: 0x04005C62 RID: 23650
			public Vector3 scaledDirectionToForceFieldCenter;

			// Token: 0x04005C63 RID: 23651
			public Vector3 particlePosition;
		}
	}
}
