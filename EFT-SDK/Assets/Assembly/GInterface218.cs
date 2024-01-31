using System;
using EFT.NextObservedPlayer;

// Token: 0x02001F7E RID: 8062
public interface GInterface218 : IDisposable, GInterface219
{
	// Token: 0x17001B74 RID: 7028
	// (get) Token: 0x0600A6E7 RID: 42727
	CommandMessageType Type { get; }

	// Token: 0x0600A6E8 RID: 42728
	GInterface218 CloneCommand();
}
