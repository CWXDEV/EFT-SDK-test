using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CDE RID: 7390
public sealed class GClass1986 : NotificationClass
{
	// Token: 0x1700179C RID: 6044
	// (get) Token: 0x060099B0 RID: 39344 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A107 RID: 41223
	[JsonProperty("aid")]
	public string PlayerAid;

	// Token: 0x0400A108 RID: 41224
	[JsonProperty("nickname")]
	public string Nickname;
}
