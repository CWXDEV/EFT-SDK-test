using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	// Token: 0x02000EE2 RID: 3810
	[AddComponentMenu("Effects/Particle Force Fields/Turbulence Particle Force Field")]
	public class TurbulenceParticleForceField : ParticleForceField
	{
		// Token: 0x06004F9B RID: 20379 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Update()
		{
			throw null;
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Vector3 GetForce()
		{
			throw null;
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x04005C64 RID: 23652
		[Tooltip("Noise texture mutation speed.")]
		[Header("ForceField Controls")]
		public float scrollSpeed;

		// Token: 0x04005C65 RID: 23653
		[Tooltip("Noise texture detail amplifier.")]
		[Range(0f, 8f)]
		public float frequency;

		// Token: 0x04005C66 RID: 23654
		public TurbulenceParticleForceField.NoiseType noiseType;

		// Token: 0x04005C67 RID: 23655
		[Range(1f, 8f)]
		[Tooltip("Overlapping noise iterations. 1 = no additional iterations.")]
		[Header("Octave Variant-Only Controls")]
		public int octaves;

		// Token: 0x04005C68 RID: 23656
		[Tooltip("Frequency scale per-octave. Can be used to change the overlap every iteration.")]
		[Range(0f, 4f)]
		public float octaveMultiplier;

		// Token: 0x04005C69 RID: 23657
		[Range(0f, 1f)]
		[Tooltip("Amplitude scale per-octave. Can be used to change the overlap every iteration.")]
		public float octaveScale;

		// Token: 0x04005C6A RID: 23658
		private float float_4;

		// Token: 0x04005C6B RID: 23659
		private float float_5;

		// Token: 0x04005C6C RID: 23660
		private float float_6;

		// Token: 0x04005C6D RID: 23661
		private float float_7;

		// Token: 0x04005C6E RID: 23662
		private float float_8;

		// Token: 0x04005C6F RID: 23663
		private float float_9;

		// Token: 0x04005C70 RID: 23664
		private float float_10;

		// Token: 0x02000EE3 RID: 3811
		public enum NoiseType
		{
			// Token: 0x04005C72 RID: 23666
			PseudoPerlin,
			// Token: 0x04005C73 RID: 23667
			Perlin,
			// Token: 0x04005C74 RID: 23668
			Simplex,
			// Token: 0x04005C75 RID: 23669
			OctavePerlin,
			// Token: 0x04005C76 RID: 23670
			OctaveSimplex
		}
	}
}
