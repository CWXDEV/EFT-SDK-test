using System;
using EFT.InventoryLogic;

// Token: 0x0200254E RID: 9550
public interface GInterface331
{
	// Token: 0x17002216 RID: 8726
	// (get) Token: 0x0600BF38 RID: 48952
	ECommandResult Result { get; }

	// Token: 0x0600BF39 RID: 48953
	void Execute();

	// Token: 0x0600BF3A RID: 48954
	void Revert();
}
