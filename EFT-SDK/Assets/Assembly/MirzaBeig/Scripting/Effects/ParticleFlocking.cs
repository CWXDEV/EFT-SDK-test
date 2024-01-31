using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	// Token: 0x02000EDC RID: 3804
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticleFlocking : MonoBehaviour
	{
		// Token: 0x06004F79 RID: 20345 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBecameVisible()
		{
			throw null;
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBecameInvisible()
		{
			throw null;
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x04005C33 RID: 23603
		[Header("N^2 Mode Settings")]
		public float maxDistance;

		// Token: 0x04005C34 RID: 23604
		[Header("Forces")]
		public float cohesion;

		// Token: 0x04005C35 RID: 23605
		public float separation;

		// Token: 0x04005C36 RID: 23606
		[Header("Voxel Mode Settings")]
		public bool useVoxels;

		// Token: 0x04005C37 RID: 23607
		public bool voxelLocalCenterFromBounds;

		// Token: 0x04005C38 RID: 23608
		public float voxelVolume;

		// Token: 0x04005C39 RID: 23609
		public int voxelsPerAxis;

		// Token: 0x04005C3A RID: 23610
		private int int_0;

		// Token: 0x04005C3B RID: 23611
		private ParticleFlocking.GStruct83[] gstruct83_0;

		// Token: 0x04005C3C RID: 23612
		private ParticleSystem particleSystem_0;

		// Token: 0x04005C3D RID: 23613
		private ParticleSystem.Particle[] particle_0;

		// Token: 0x04005C3E RID: 23614
		private Vector3[] vector3_0;

		// Token: 0x04005C3F RID: 23615
		private ParticleSystem.MainModule mainModule_0;

		// Token: 0x04005C40 RID: 23616
		[Header("General Performance Settings")]
		[Range(0f, 1f)]
		public float delay;

		// Token: 0x04005C41 RID: 23617
		private float float_0;

		// Token: 0x04005C42 RID: 23618
		public bool alwaysUpdate;

		// Token: 0x04005C43 RID: 23619
		private bool bool_0;

		// Token: 0x02000EDD RID: 3805
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct83
		{
			// Token: 0x04005C44 RID: 23620
			public Bounds bounds;

			// Token: 0x04005C45 RID: 23621
			public int[] particles;

			// Token: 0x04005C46 RID: 23622
			public int particleCount;
		}
	}
}
