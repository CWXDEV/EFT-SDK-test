using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002787 RID: 10119
	[Serializable]
	public sealed class MaterialEmission : MaterialData
	{
		// Token: 0x0600CAB1 RID: 51889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			throw null;
		}

		// Token: 0x0600CAB2 RID: 51890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void TurnLights(bool on)
		{
			throw null;
		}

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetIntensity(float intensity)
		{
			throw null;
		}

		// Token: 0x0600CAB4 RID: 51892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMaxEmissionVisibility(float value)
		{
			throw null;
		}

		// Token: 0x0400CAC5 RID: 51909
		[SerializeField]
		private float _maxEmissionVisibility;

		// Token: 0x0400CAC6 RID: 51910
		private static readonly int _emissionVisibility;
	}
}
