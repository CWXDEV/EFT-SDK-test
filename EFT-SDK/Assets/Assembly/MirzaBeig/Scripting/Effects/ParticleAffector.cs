using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	// Token: 0x02000ED7 RID: 3799
	public abstract class ParticleAffector : MonoBehaviour
	{
		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06004F60 RID: 20320 RVA: 0x00002050 File Offset: 0x00000250
		public float scaledRadius
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004F61 RID: 20321 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void PerParticleSystemSetup()
		{
			throw null;
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Vector3 GetForce()
		{
			throw null;
		}

		// Token: 0x06004F65 RID: 20325 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddParticleSystem(ParticleSystem particleSystem)
		{
			throw null;
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveParticleSystem(ParticleSystem particleSystem)
		{
			throw null;
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationQuit()
		{
			throw null;
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x04005C08 RID: 23560
		[Header("Common Controls")]
		public float radius;

		// Token: 0x04005C09 RID: 23561
		public float force;

		// Token: 0x04005C0A RID: 23562
		public Vector3 offset;

		// Token: 0x04005C0B RID: 23563
		private float float_0;

		// Token: 0x04005C0C RID: 23564
		private float float_1;

		// Token: 0x04005C0D RID: 23565
		private float float_2;

		// Token: 0x04005C0E RID: 23566
		private Vector3 vector3_0;

		// Token: 0x04005C0F RID: 23567
		private float[] float_3;

		// Token: 0x04005C10 RID: 23568
		public AnimationCurve scaleForceByDistance;

		// Token: 0x04005C11 RID: 23569
		private ParticleSystem particleSystem_0;

		// Token: 0x04005C12 RID: 23570
		public List<ParticleSystem> _particleSystems;

		// Token: 0x04005C13 RID: 23571
		private int int_0;

		// Token: 0x04005C14 RID: 23572
		private List<ParticleSystem> list_0;

		// Token: 0x04005C15 RID: 23573
		private ParticleSystem.Particle[][] particle_0;

		// Token: 0x04005C16 RID: 23574
		private ParticleSystem.MainModule[] mainModule_0;

		// Token: 0x04005C17 RID: 23575
		private Renderer[] renderer_0;

		// Token: 0x04005C18 RID: 23576
		protected ParticleSystem currentParticleSystem;

		// Token: 0x04005C19 RID: 23577
		protected ParticleAffector.GetForceParameters parameters;

		// Token: 0x04005C1A RID: 23578
		public bool alwaysUpdate;

		// Token: 0x02000ED8 RID: 3800
		protected struct GetForceParameters
		{
			// Token: 0x04005C1B RID: 23579
			public float distanceToAffectorCenterSqr;

			// Token: 0x04005C1C RID: 23580
			public Vector3 scaledDirectionToAffectorCenter;

			// Token: 0x04005C1D RID: 23581
			public Vector3 particlePosition;
		}
	}
}
