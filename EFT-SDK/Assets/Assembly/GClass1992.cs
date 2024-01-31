using System;
using System.Runtime.CompilerServices;
using ChatShared;
using Newtonsoft.Json;

// Token: 0x02001CE4 RID: 7396
public sealed class GClass1992 : NotificationClass
{
	// Token: 0x170017A3 RID: 6051
	// (get) Token: 0x060099B7 RID: 39351 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A115 RID: 41237
	[JsonProperty("profile")]
	public UpdatableChatMember Profile;
}
