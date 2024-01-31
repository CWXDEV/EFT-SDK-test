using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Visual;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001A79 RID: 6777
	public sealed class FlickerAmbiance : AmbianceObject<AnimationCurve>
	{
		// Token: 0x06008EE6 RID: 36582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task<bool> PerformInteraction(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x06008EE7 RID: 36583 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_0(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x0400962C RID: 38444
		[SerializeField]
		private List<Flicker> _flickers;
	}
}
