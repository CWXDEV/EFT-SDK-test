using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Quests
{
	// Token: 0x02002FFC RID: 12284
	public sealed class ConditionQuest : ConditionOneTarget
	{
		// Token: 0x0600F200 RID: 61952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override List<object> IdentityFields()
		{
			throw null;
		}

		// Token: 0x0400F821 RID: 63521
		[JsonProperty("status")]
		public EQuestStatus[] statuses;

		// Token: 0x0400F822 RID: 63522
		public string name;

		// Token: 0x0400F823 RID: 63523
		public int availableAfter;
	}
}
