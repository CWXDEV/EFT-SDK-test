using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001CEF RID: 7407
public sealed class GClass2003 : NotificationClass
{
	// Token: 0x170017B4 RID: 6068
	// (get) Token: 0x060099C9 RID: 39369 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ShowNotification
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017B5 RID: 6069
	// (get) Token: 0x060099CA RID: 39370 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A122 RID: 41250
	[JsonProperty("extendedProfile")]
	public GClass1206 GroupPlayer;
}
