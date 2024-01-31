using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Interactive;
using EFT.Utilities;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001A7F RID: 6783
	public sealed class LampControllerAmbiance : InteractiveAmbianceObject<LampControllerAmbiance.LampControllerPattern>
	{
		// Token: 0x06008EFF RID: 36607 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task<bool> PerformInteraction(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x06008F00 RID: 36608 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_1(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x04009641 RID: 38465
		public LampController AffectedObject;

		// Token: 0x02001A80 RID: 6784
		[Serializable]
		public sealed class LampControllerPattern
		{
			// Token: 0x04009642 RID: 38466
			public bool Active;

			// Token: 0x04009643 RID: 38467
			public RandomBetweenFloats Flickering;

			// Token: 0x04009644 RID: 38468
			[Range(0f, 100f)]
			public float FlickeringChance;
		}
	}
}
