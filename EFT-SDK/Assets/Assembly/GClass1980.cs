using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CD8 RID: 7384
public sealed class GClass1980 : NotificationClass
{
	// Token: 0x17001792 RID: 6034
	// (get) Token: 0x060099A6 RID: 39334 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ShowNotification
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001793 RID: 6035
	// (get) Token: 0x060099A7 RID: 39335 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A0FC RID: 41212
	[JsonProperty("groupId")]
	public string GroupId;

	// Token: 0x0400A0FD RID: 41213
	[JsonProperty("uid")]
	public string PlayerId;

	// Token: 0x0400A0FE RID: 41214
	[JsonProperty("Nickname")]
	public string Name;
}
