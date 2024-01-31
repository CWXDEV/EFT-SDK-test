using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.Interactive
{
	// Token: 0x02002746 RID: 10054
	public class ScavExfiltrationPoint : ExfiltrationPoint
	{
		// Token: 0x0600C92E RID: 51502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool InfiltrationMatch(Player player)
		{
			throw null;
		}

		// Token: 0x0400C93A RID: 51514
		public List<string> EligibleIds;
	}
}
