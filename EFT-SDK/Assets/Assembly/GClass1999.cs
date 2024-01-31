using System;
using System.Runtime.CompilerServices;
using ChatShared;
using Newtonsoft.Json;

// Token: 0x02001CEB RID: 7403
public sealed class GClass1999 : NotificationClass
{
	// Token: 0x170017AF RID: 6063
	// (get) Token: 0x060099C4 RID: 39364 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A11F RID: 41247
	[JsonProperty("profile")]
	public UpdatableChatMember Profile;
}
