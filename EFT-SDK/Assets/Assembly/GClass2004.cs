using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CF0 RID: 7408
public sealed class GClass2004 : NotificationClass
{
	// Token: 0x170017B6 RID: 6070
	// (get) Token: 0x060099CB RID: 39371 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ShowNotification
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017B7 RID: 6071
	// (get) Token: 0x060099CC RID: 39372 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A123 RID: 41251
	[JsonProperty("aid")]
	public string PlayerAid;
}
