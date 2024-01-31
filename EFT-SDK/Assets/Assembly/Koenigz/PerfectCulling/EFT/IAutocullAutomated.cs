using System;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DE0 RID: 3552
	public interface IAutocullAutomated
	{
		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06004AC2 RID: 19138
		// (set) Token: 0x06004AC3 RID: 19139
		bool IsAutocullVisible { get; set; }

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06004AC4 RID: 19140
		Bounds AutocullObjectBounds { get; }

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06004AC5 RID: 19141
		bool IsDynamicCullingObject { get; }
	}
}
