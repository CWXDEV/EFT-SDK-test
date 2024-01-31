using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CF2 RID: 7410
public sealed class GClass2006 : NotificationClass
{
	// Token: 0x170017B9 RID: 6073
	// (get) Token: 0x060099CE RID: 39374 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A124 RID: 41252
	[JsonProperty("owner")]
	public string OwnerAid;
}
