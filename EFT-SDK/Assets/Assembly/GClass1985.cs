using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CDD RID: 7389
public sealed class GClass1985 : NotificationClass
{
	// Token: 0x1700179B RID: 6043
	// (get) Token: 0x060099AF RID: 39343 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A105 RID: 41221
	[JsonProperty("aid")]
	public string PlayerAid;

	// Token: 0x0400A106 RID: 41222
	[JsonProperty("nickname")]
	public string Nickname;
}
