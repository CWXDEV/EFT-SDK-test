using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001BCA RID: 7114
	[Serializable]
	public sealed class TraderLoyaltyRequirement : GClass1931
	{
		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x0600955C RID: 38236 RVA: 0x00002050 File Offset: 0x00000250
		public override ERequirementType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600955D RID: 38237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Test(IEnumerable<Profile.TraderInfo> value)
		{
			throw null;
		}

		// Token: 0x0600955E RID: 38238 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0(Profile.TraderInfo traderInfo)
		{
			throw null;
		}

		// Token: 0x04009C1B RID: 39963
		[JsonProperty("loyaltyLevel")]
		public int LoyaltyLevel;

		// Token: 0x04009C1C RID: 39964
		[JsonProperty("traderId")]
		public string TraderId;
	}
}
