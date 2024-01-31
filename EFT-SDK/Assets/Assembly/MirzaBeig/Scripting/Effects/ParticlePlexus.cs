using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	// Token: 0x02000EE6 RID: 3814
	[RequireComponent(typeof(ParticleSystem))]
	[AddComponentMenu("Effects/Particle Plexus")]
	public class ParticlePlexus : MonoBehaviour
	{
		// Token: 0x06004FAD RID: 20397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004FAE RID: 20398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x06004FAF RID: 20399 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBecameVisible()
		{
			throw null;
		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBecameInvisible()
		{
			throw null;
		}

		// Token: 0x06004FB1 RID: 20401 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x04005C81 RID: 23681
		public float maxDistance;

		// Token: 0x04005C82 RID: 23682
		public int maxConnections;

		// Token: 0x04005C83 RID: 23683
		public int maxLineRenderers;

		// Token: 0x04005C84 RID: 23684
		[Range(0f, 1f)]
		public float widthFromParticle;

		// Token: 0x04005C85 RID: 23685
		[Range(0f, 1f)]
		public float colourFromParticle;

		// Token: 0x04005C86 RID: 23686
		[Range(0f, 1f)]
		public float alphaFromParticle;

		// Token: 0x04005C87 RID: 23687
		private ParticleSystem particleSystem_0;

		// Token: 0x04005C88 RID: 23688
		private ParticleSystem.Particle[] particle_0;

		// Token: 0x04005C89 RID: 23689
		private Vector3[] vector3_0;

		// Token: 0x04005C8A RID: 23690
		private Color[] color_0;

		// Token: 0x04005C8B RID: 23691
		private float[] float_0;

		// Token: 0x04005C8C RID: 23692
		private ParticleSystem.MainModule mainModule_0;

		// Token: 0x04005C8D RID: 23693
		public LineRenderer lineRendererTemplate;

		// Token: 0x04005C8E RID: 23694
		private List<LineRenderer> list_0;

		// Token: 0x04005C8F RID: 23695
		private Transform transform_0;

		// Token: 0x04005C90 RID: 23696
		[Range(0f, 1f)]
		[Header("General Performance Settings")]
		public float delay;

		// Token: 0x04005C91 RID: 23697
		private float float_1;

		// Token: 0x04005C92 RID: 23698
		public bool alwaysUpdate;

		// Token: 0x04005C93 RID: 23699
		private bool bool_0;
	}
}
