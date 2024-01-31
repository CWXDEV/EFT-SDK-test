using System;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001BA5 RID: 7077
	public abstract class RelatedData
	{
		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x060094D7 RID: 38103
		[JsonIgnore]
		public abstract bool IsActive { get; }

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x060094D8 RID: 38104
		[JsonIgnore]
		public abstract EPanelType Type { get; }

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x060094D9 RID: 38105
		[JsonIgnore]
		public abstract object Value { get; }
	}
}
