using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.Quests
{
	// Token: 0x02002FFA RID: 12282
	public abstract class ConditionOneTarget : Condition
	{
		// Token: 0x0600F1FD RID: 61949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override List<object> IdentityFields()
		{
			throw null;
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x0600F1FE RID: 61950 RVA: 0x00002050 File Offset: 0x00000250
		public override string FormattedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400F81F RID: 63519
		public string target;
	}
}
