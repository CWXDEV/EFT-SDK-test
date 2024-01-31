using System;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;

// Token: 0x02001D85 RID: 7557
public interface GInterface181
{
	// Token: 0x17001868 RID: 6248
	// (get) Token: 0x06009BC7 RID: 39879
	GClass2087 RepairController { get; }

	// Token: 0x06009BC8 RID: 39880
	Task<IResult> RepairItemsByRepairKit(RepairItem[] repairKitsInfo, string targetItemId);
}
