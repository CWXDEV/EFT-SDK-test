using System;
using System.Runtime.CompilerServices;
using EFT;
using Newtonsoft.Json;

// Token: 0x02001CEE RID: 7406
public sealed class GClass2002 : NotificationClass
{
	// Token: 0x170017B2 RID: 6066
	// (get) Token: 0x060099C7 RID: 39367 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ShowNotification
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017B3 RID: 6067
	// (get) Token: 0x060099C8 RID: 39368 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A121 RID: 41249
	[JsonProperty("raidSettings")]
	public RaidSettings RaidSettings;
}
