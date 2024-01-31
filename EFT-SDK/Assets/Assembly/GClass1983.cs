using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CDB RID: 7387
public sealed class GClass1983 : NotificationClass
{
	// Token: 0x17001798 RID: 6040
	// (get) Token: 0x060099AC RID: 39340 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A101 RID: 41217
	[JsonProperty("tid")]
	public string TraderId;
}
