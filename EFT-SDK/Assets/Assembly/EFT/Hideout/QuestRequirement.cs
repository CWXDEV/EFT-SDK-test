using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001BCB RID: 7115
	[Serializable]
	public sealed class QuestRequirement : Requirement
	{
		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x0600955F RID: 38239 RVA: 0x00002050 File Offset: 0x00000250
		public override ERequirementType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04009C1D RID: 39965
		[JsonProperty("questId")]
		public string QuestId;
	}
}
