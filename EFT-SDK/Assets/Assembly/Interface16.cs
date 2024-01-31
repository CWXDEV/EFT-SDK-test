using System;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InventoryLogic;

// Token: 0x02002549 RID: 9545
internal interface Interface16
{
	// Token: 0x0600BF2F RID: 48943
	Task<IResult> Start();

	// Token: 0x0600BF30 RID: 48944
	void Proceed(bool success = true);

	// Token: 0x0600BF31 RID: 48945
	void TryProceedForItem(Item magazine);
}
