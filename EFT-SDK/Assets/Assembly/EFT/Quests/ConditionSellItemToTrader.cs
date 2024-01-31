using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.Quests
{
	// Token: 0x02002FFE RID: 12286
	public sealed class ConditionSellItemToTrader : ConditionMultipleTargets
	{
		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x0600F201 RID: 61953 RVA: 0x00002050 File Offset: 0x00000250
		public override string FormattedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F202 RID: 61954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override List<object> IdentityFields()
		{
			throw null;
		}

		// Token: 0x0400F824 RID: 63524
		public string trader;
	}
}
