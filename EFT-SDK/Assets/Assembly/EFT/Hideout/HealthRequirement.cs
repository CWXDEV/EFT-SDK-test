using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001BCC RID: 7116
	[Serializable]
	public sealed class HealthRequirement : Requirement
	{
		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06009560 RID: 38240 RVA: 0x00002050 File Offset: 0x00000250
		public override ERequirementType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06009561 RID: 38241 RVA: 0x00002050 File Offset: 0x00000250
		public override bool Fulfilled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06009562 RID: 38242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Test(HealthControllerClass healthController)
		{
			throw null;
		}

		// Token: 0x04009C1E RID: 39966
		[JsonProperty("Energy")]
		private int _energyValue;

		// Token: 0x04009C1F RID: 39967
		[JsonProperty("Hydration")]
		private int _hydrationValue;

		// Token: 0x04009C20 RID: 39968
		private HealthControllerClass _healthController;
	}
}
