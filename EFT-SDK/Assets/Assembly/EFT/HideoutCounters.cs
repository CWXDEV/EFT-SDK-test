using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT
{
	// Token: 0x02001602 RID: 5634
	[Serializable]
	public class HideoutCounters
	{
		// Token: 0x06007A8A RID: 31370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetCounter(EAreaType areaType)
		{
			throw null;
		}

		// Token: 0x04007FA1 RID: 32673
		[JsonProperty("fuelCounter")]
		public float FuelCounter;

		// Token: 0x04007FA2 RID: 32674
		[JsonProperty("airFilterCounter")]
		public float AirFilterCounter;

		// Token: 0x04007FA3 RID: 32675
		[JsonProperty("waterFilterCounter")]
		public float WaterFilterCounter;

		// Token: 0x04007FA4 RID: 32676
		[JsonProperty("craftingTimeCounter")]
		public float CraftingTimeCounter;
	}
}
