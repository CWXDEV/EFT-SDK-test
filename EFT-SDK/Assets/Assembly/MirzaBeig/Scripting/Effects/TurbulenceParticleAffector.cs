using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	// Token: 0x02000ED9 RID: 3801
	public class TurbulenceParticleAffector : ParticleAffector
	{
		// Token: 0x06004F6B RID: 20331 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Update()
		{
			throw null;
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Vector3 GetForce()
		{
			throw null;
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x04005C1E RID: 23582
		[Header("Affector Controls")]
		public float speed;

		// Token: 0x04005C1F RID: 23583
		[Range(0f, 8f)]
		public float frequency;

		// Token: 0x04005C20 RID: 23584
		public TurbulenceParticleAffector.NoiseType noiseType;

		// Token: 0x04005C21 RID: 23585
		[Header("Octave Variant-Only Controls")]
		[Range(1f, 8f)]
		public int octaves;

		// Token: 0x04005C22 RID: 23586
		[Range(0f, 4f)]
		public float lacunarity;

		// Token: 0x04005C23 RID: 23587
		[Range(0f, 1f)]
		public float persistence;

		// Token: 0x04005C24 RID: 23588
		private float float_4;

		// Token: 0x04005C25 RID: 23589
		private float float_5;

		// Token: 0x04005C26 RID: 23590
		private float float_6;

		// Token: 0x04005C27 RID: 23591
		private float float_7;

		// Token: 0x04005C28 RID: 23592
		private float float_8;

		// Token: 0x04005C29 RID: 23593
		private float float_9;

		// Token: 0x04005C2A RID: 23594
		private float float_10;

		// Token: 0x02000EDA RID: 3802
		public enum NoiseType
		{
			// Token: 0x04005C2C RID: 23596
			PseudoPerlin,
			// Token: 0x04005C2D RID: 23597
			Perlin,
			// Token: 0x04005C2E RID: 23598
			Simplex,
			// Token: 0x04005C2F RID: 23599
			OctavePerlin,
			// Token: 0x04005C30 RID: 23600
			OctaveSimplex
		}
	}
}
