using System;
using System.Runtime.CompilerServices;

namespace EFT.Interactive
{
	// Token: 0x02002747 RID: 10055
	public class SharedExfiltrationPoint : ScavExfiltrationPoint
	{
		// Token: 0x0600C92F RID: 51503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool InfiltrationMatch(Player player)
		{
			throw null;
		}

		// Token: 0x0400C93B RID: 51515
		public bool IsMandatoryForScavs;
	}
}
