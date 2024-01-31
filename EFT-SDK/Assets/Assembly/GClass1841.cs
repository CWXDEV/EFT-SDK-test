using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using Newtonsoft.Json;

// Token: 0x02001843 RID: 6211
public sealed class GClass1841
{
	// Token: 0x1700148A RID: 5258
	// (get) Token: 0x0600854F RID: 34127 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public int IntCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04008C06 RID: 35846
	public string _tpl;

	// Token: 0x04008C07 RID: 35847
	public double count;

	// Token: 0x04008C08 RID: 35848
	public int level;

	// Token: 0x04008C09 RID: 35849
	public EDogtagExchangeSide side;

	// Token: 0x04008C0A RID: 35850
	public bool onlyFunctional;
}
