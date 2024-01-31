using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001A77 RID: 6775
	public sealed class ColorAmbiance : AmbianceObject<Color>
	{
		// Token: 0x06008EE2 RID: 36578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task<bool> PerformInteraction(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x06008EE3 RID: 36579 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_0(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x04009626 RID: 38438
		[SerializeField]
		private Light[] _lights;
	}
}
