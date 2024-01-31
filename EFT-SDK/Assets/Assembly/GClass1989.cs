using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CE1 RID: 7393
public sealed class GClass1989 : NotificationClass
{
	// Token: 0x1700179F RID: 6047
	// (get) Token: 0x060099B3 RID: 39347 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A110 RID: 41232
	[JsonProperty("aid")]
	public string PlayerAid;

	// Token: 0x0400A111 RID: 41233
	[JsonProperty("Nickname")]
	public string Name;
}
