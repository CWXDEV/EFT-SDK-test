using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CE0 RID: 7392
public sealed class GClass1988 : NotificationClass
{
	// Token: 0x1700179E RID: 6046
	// (get) Token: 0x060099B2 RID: 39346 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A10E RID: 41230
	[JsonProperty("aid")]
	public string PlayerAid;

	// Token: 0x0400A10F RID: 41231
	[JsonProperty("Nickname")]
	public string Name;
}
