using System;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InventoryLogic;

// Token: 0x0200244D RID: 9293
public interface GInterface313
{
	// Token: 0x17002150 RID: 8528
	// (get) Token: 0x0600BAAC RID: 47788
	Inventory Inventory { get; }

	// Token: 0x14000295 RID: 661
	// (add) Token: 0x0600BAAD RID: 47789
	// (remove) Token: 0x0600BAAE RID: 47790
	event Action<GEventArgs6> ExamineEvent;

	// Token: 0x14000296 RID: 662
	// (add) Token: 0x0600BAAF RID: 47791
	// (remove) Token: 0x0600BAB0 RID: 47792
	event Action<Weapon> OnChamberCheck;

	// Token: 0x14000297 RID: 663
	// (add) Token: 0x0600BAB1 RID: 47793
	// (remove) Token: 0x0600BAB2 RID: 47794
	event Action<Item> OnItemFound;

	// Token: 0x0600BAB3 RID: 47795
	Task<IResult> TryRunNetworkTransaction(GStruct412 operationResult, Callback callback = null);

	// Token: 0x0600BAB4 RID: 47796
	void Add(Item item, ItemAddress to, Callback callback = null);

	// Token: 0x0600BAB5 RID: 47797
	bool Examined(Item item);

	// Token: 0x0600BAB6 RID: 47798
	void StopProcesses();
}
