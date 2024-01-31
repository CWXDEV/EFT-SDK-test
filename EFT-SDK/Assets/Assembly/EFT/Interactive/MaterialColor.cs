using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002786 RID: 10118
	[Serializable]
	public sealed class MaterialColor : MaterialData
	{
		// Token: 0x0600CAAF RID: 51887 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void TurnLights(bool on)
		{
			throw null;
		}

		// Token: 0x0600CAB0 RID: 51888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetIntensity(float intensity)
		{
			throw null;
		}

		// Token: 0x0400CAC2 RID: 51906
		public string ParemeterName;

		// Token: 0x0400CAC3 RID: 51907
		[ColorUsage(true, true)]
		public Color ColorOn;

		// Token: 0x0400CAC4 RID: 51908
		[ColorUsage(true, true)]
		public Color ColorOff;
	}
}
