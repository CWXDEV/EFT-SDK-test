using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002785 RID: 10117
	[Serializable]
	public abstract class MaterialData
	{
		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x0600CAAB RID: 51883 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		protected Material Material
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CAAC RID: 51884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Init()
		{
			throw null;
		}

		// Token: 0x0600CAAD RID: 51885
		public abstract void TurnLights(bool on);

		// Token: 0x0600CAAE RID: 51886
		public abstract void SetIntensity(float intensity);

		// Token: 0x0400CABF RID: 51903
		public Renderer Renderer;

		// Token: 0x0400CAC0 RID: 51904
		public int MaterialId;

		// Token: 0x0400CAC1 RID: 51905
		protected MaterialPropertyBlock _mpb;
	}
}
