using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CDA RID: 7386
public sealed class GClass1982 : NotificationClass
{
	// Token: 0x17001796 RID: 6038
	// (get) Token: 0x060099AA RID: 39338 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ShowNotification
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001797 RID: 6039
	// (get) Token: 0x060099AB RID: 39339 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A100 RID: 41216
	[JsonProperty("message")]
	public string Message;
}
