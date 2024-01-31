using System;
using System.Runtime.CompilerServices;
using ChatShared;
using Newtonsoft.Json;

// Token: 0x02001CEA RID: 7402
public sealed class GClass1998 : NotificationClass
{
	// Token: 0x170017AE RID: 6062
	// (get) Token: 0x060099C3 RID: 39363 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A11E RID: 41246
	[JsonProperty("profile")]
	public UpdatableChatMember Profile;
}
