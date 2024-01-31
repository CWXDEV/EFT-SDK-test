using System;
using EFT.NextObservedPlayer;

// Token: 0x02001FA5 RID: 8101
public interface GInterface222
{
	// Token: 0x0600A7DD RID: 42973
	void Entry(GInterface223 from);

	// Token: 0x0600A7DE RID: 42974
	void Exit(GInterface223 to);

	// Token: 0x0600A7DF RID: 42975
	void FastForward();

	// Token: 0x0600A7E0 RID: 42976
	void Transition(Type toOperation, GInterface223 operation);

	// Token: 0x0600A7E1 RID: 42977
	void CheckAbort(CommandMessageType messageType);
}
