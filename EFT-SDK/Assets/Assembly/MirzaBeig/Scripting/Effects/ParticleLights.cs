using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MirzaBeig.Scripting.Effects
{
	// Token: 0x02000EE5 RID: 3813
	[RequireComponent(typeof(ParticleSystem))]
	[Serializable]
	public class ParticleLights : MonoBehaviour
	{
		// Token: 0x06004FA9 RID: 20393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x04005C79 RID: 23673
		private ParticleSystem ps;

		// Token: 0x04005C7A RID: 23674
		private List<Light> lights;

		// Token: 0x04005C7B RID: 23675
		public float scale;

		// Token: 0x04005C7C RID: 23676
		[Range(0f, 8f)]
		public float intensity;

		// Token: 0x04005C7D RID: 23677
		public Color colour;

		// Token: 0x04005C7E RID: 23678
		[Range(0f, 1f)]
		public float colourFromParticle;

		// Token: 0x04005C7F RID: 23679
		public LightShadows shadows;

		// Token: 0x04005C80 RID: 23680
		private GameObject template;
	}
}
