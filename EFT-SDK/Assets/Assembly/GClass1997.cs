using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CE9 RID: 7401
public sealed class GClass1997 : NotificationClass
{
	// Token: 0x170017AD RID: 6061
	// (get) Token: 0x060099C2 RID: 39362 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A11C RID: 41244
	[JsonProperty("groupId")]
	public string GroupId;

	// Token: 0x0400A11D RID: 41245
	[JsonProperty("groupName")]
	public string GroupName;
}
