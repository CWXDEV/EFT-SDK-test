using System;
using EFT;

// Token: 0x02000417 RID: 1047
public interface GInterface6 : IPositionPoint
{
	// Token: 0x06001972 RID: 6514
	bool IsSame(GInterface6 point);

	// Token: 0x06001973 RID: 6515
	void BotCome(BotOwner owner);
}
