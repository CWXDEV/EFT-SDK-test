using System;
using EFT.InventoryLogic;

namespace EFT
{
	// Token: 0x0200195D RID: 6493
	public interface IExchangeRequirement
	{
		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06008B6B RID: 35691
		Item Item { get; }

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06008B6C RID: 35692
		string TemplateId { get; }

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06008B6D RID: 35693
		string ItemName { get; }

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06008B6E RID: 35694
		int IntCount { get; }

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06008B6F RID: 35695
		double PreciseCount { get; }

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06008B70 RID: 35696
		bool OnlyFunctional { get; }

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06008B71 RID: 35697
		bool IsEncoded { get; }
	}
}
