using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.Quests
{
	// Token: 0x02002FF9 RID: 12281
	public abstract class ConditionMultipleTargets : Condition
	{
		// Token: 0x0600F1FC RID: 61948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override List<object> IdentityFields()
		{
			throw null;
		}

		// Token: 0x0400F81E RID: 63518
		public string[] target;
	}
}
