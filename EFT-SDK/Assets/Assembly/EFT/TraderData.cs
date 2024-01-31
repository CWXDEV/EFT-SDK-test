using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT
{
	// Token: 0x0200184A RID: 6218
	[Serializable]
	public sealed class TraderData
	{
		// Token: 0x06008552 RID: 34130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Apply(Profile.TraderInfo traderInfo)
		{
			throw null;
		}

		// Token: 0x04008C13 RID: 35859
		[JsonProperty("salesSum")]
		private long? _salesSum;

		// Token: 0x04008C14 RID: 35860
		[JsonProperty("standing")]
		private double? _standing;

		// Token: 0x04008C15 RID: 35861
		[JsonProperty("loyalty")]
		private float? _loyaltyLevel;

		// Token: 0x04008C16 RID: 35862
		[JsonProperty("unlocked")]
		private bool? _unlocked;

		// Token: 0x04008C17 RID: 35863
		[JsonProperty("disabled")]
		private bool? _disabled;
	}
}
