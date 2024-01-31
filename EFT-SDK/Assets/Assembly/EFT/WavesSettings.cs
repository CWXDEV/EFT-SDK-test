using System;
using EFT.Bots;
using Newtonsoft.Json;

namespace EFT
{
	// Token: 0x02001309 RID: 4873
	[Serializable]
	public struct WavesSettings
	{
		// Token: 0x04007169 RID: 29033
		[JsonProperty("botAmount")]
		public EBotAmount BotAmount;

		// Token: 0x0400716A RID: 29034
		[JsonProperty("botDifficulty")]
		public EBotDifficulty BotDifficulty;

		// Token: 0x0400716B RID: 29035
		[JsonProperty("isBosses")]
		public bool IsBosses;

		// Token: 0x0400716C RID: 29036
		[JsonProperty("isTaggedAndCursed")]
		public bool IsTaggedAndCursed;
	}
}
