using System;

namespace EFT.Vaulting
{
	// Token: 0x02001E5D RID: 7773
	public interface IVaultingRestrictions
	{
		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06009F5C RID: 40796
		bool IsActive { get; }

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06009F5D RID: 40797
		float MinDistantToInteract { get; }

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06009F5E RID: 40798
		float MinHeight { get; }

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06009F5F RID: 40799
		float MaxHeight { get; }

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06009F60 RID: 40800
		float MinLength { get; }

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06009F61 RID: 40801
		float MaxLength { get; }
	}
}
