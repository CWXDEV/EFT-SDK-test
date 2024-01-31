using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Bots
{
	// Token: 0x020026DB RID: 9947
	[Serializable]
	public struct BotControllerSettings
	{
		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x0600C551 RID: 50513 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public bool IsEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400C720 RID: 50976
		[JsonProperty("isScavWars")]
		public bool IsScavWars;

		// Token: 0x0400C721 RID: 50977
		[JsonProperty("botAmount")]
		public EBotAmount BotAmount;

		// Token: 0x0400C722 RID: 50978
		[JsonIgnore]
		public EBossType BossType;
	}
}
