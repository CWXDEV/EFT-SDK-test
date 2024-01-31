using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CDC RID: 7388
public sealed class GClass1984 : NotificationClass
{
	// Token: 0x17001799 RID: 6041
	// (get) Token: 0x060099AD RID: 39341 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ShowNotification
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700179A RID: 6042
	// (get) Token: 0x060099AE RID: 39342 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A102 RID: 41218
	[JsonProperty("requestId")]
	public string RequestId;

	// Token: 0x0400A103 RID: 41219
	[JsonProperty("from")]
	public string Aid;

	// Token: 0x0400A104 RID: 41220
	[JsonProperty("members")]
	public GClass1206[] Members;
}
