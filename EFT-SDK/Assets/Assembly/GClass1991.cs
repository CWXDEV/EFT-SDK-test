using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CE3 RID: 7395
public sealed class GClass1991 : NotificationClass
{
	// Token: 0x170017A1 RID: 6049
	// (get) Token: 0x060099B5 RID: 39349 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ShowNotification
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017A2 RID: 6050
	// (get) Token: 0x060099B6 RID: 39350 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A112 RID: 41234
	[JsonProperty("dialogId")]
	public string DialogueId;

	// Token: 0x0400A113 RID: 41235
	[JsonProperty("message")]
	public ChatMessageClass Message;

	// Token: 0x0400A114 RID: 41236
	[JsonProperty("EventId")]
	public string EventId;
}
