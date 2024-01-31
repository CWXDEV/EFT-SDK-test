using System;

namespace EFT
{
	// Token: 0x02001612 RID: 5650
	public interface IProfileDataContainer
	{
		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06007B07 RID: 31495
		string ProfileId { get; }

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06007B08 RID: 31496
		string Nickname { get; }

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06007B09 RID: 31497
		EPlayerSide Side { get; }
	}
}
