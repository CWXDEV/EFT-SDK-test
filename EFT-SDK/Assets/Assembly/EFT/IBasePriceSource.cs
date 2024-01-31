using System;

namespace EFT
{
	// Token: 0x02001849 RID: 6217
	public interface IBasePriceSource
	{
		// Token: 0x06008551 RID: 34129
		double GetBasePrice(string itemId);
	}
}
