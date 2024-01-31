using System;
using System.Runtime.CompilerServices;

namespace EFT.Quests
{
	// Token: 0x02002FF3 RID: 12275
	public class ConditionItem : ConditionMultipleTargets
	{
		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x0600F1F4 RID: 61940 RVA: 0x00002050 File Offset: 0x00000250
		public override string FormattedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400F816 RID: 63510
		public int minDurability;

		// Token: 0x0400F817 RID: 63511
		public int maxDurability;

		// Token: 0x0400F818 RID: 63512
		public int dogtagLevel;

		// Token: 0x0400F819 RID: 63513
		public bool onlyFoundInRaid;

		// Token: 0x0400F81A RID: 63514
		public bool isEncoded;
	}
}
