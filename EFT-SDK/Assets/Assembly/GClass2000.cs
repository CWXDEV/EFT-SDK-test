using System;
using System.Runtime.CompilerServices;
using ChatShared;
using Newtonsoft.Json;

// Token: 0x02001CEC RID: 7404
public sealed class GClass2000 : NotificationClass
{
	// Token: 0x170017B0 RID: 6064
	// (get) Token: 0x060099C5 RID: 39365 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A120 RID: 41248
	[JsonProperty("profile")]
	public UpdatableChatMember Profile;
}
