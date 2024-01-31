using System;
using System.Runtime.CompilerServices;
using ChatShared;
using Newtonsoft.Json;

// Token: 0x02001CE8 RID: 7400
public sealed class GClass1996 : NotificationClass
{
	// Token: 0x170017AC RID: 6060
	// (get) Token: 0x060099C1 RID: 39361 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A11B RID: 41243
	[JsonProperty("profile")]
	public UpdatableChatMember Profile;
}
