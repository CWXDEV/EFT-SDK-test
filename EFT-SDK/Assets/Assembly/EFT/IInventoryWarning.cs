using System;

namespace EFT
{
	// Token: 0x0200180F RID: 6159
	public interface IInventoryWarning
	{
		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x060083C9 RID: 33737
		int ErrorCode { get; }

		// Token: 0x060083CA RID: 33738
		bool TryGetMessage(out string header, out string description);
	}
}
