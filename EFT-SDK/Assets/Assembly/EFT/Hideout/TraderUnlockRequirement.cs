using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001BC9 RID: 7113
	[Serializable]
	public sealed class TraderUnlockRequirement : GClass1931
	{
		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06009559 RID: 38233 RVA: 0x00002050 File Offset: 0x00000250
		public override ERequirementType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600955A RID: 38234 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Test(IEnumerable<Profile.TraderInfo> value)
		{
			throw null;
		}

		// Token: 0x0600955B RID: 38235 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0(Profile.TraderInfo traderInfo)
		{
			throw null;
		}

		// Token: 0x04009C1A RID: 39962
		[JsonProperty("traderId")]
		public string TraderId;
	}
}
