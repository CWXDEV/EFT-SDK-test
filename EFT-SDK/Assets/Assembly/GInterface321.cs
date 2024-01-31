using System;
using EFT.InventoryLogic;

// Token: 0x02002511 RID: 9489
public interface GInterface321 : IRollback
{
	// Token: 0x0600BE49 RID: 48713
	void RaiseEvents(TraderControllerClass controller, CommandStatus status);

	// Token: 0x0600BE4A RID: 48714
	bool CanExecute(TraderControllerClass itemController);
}
