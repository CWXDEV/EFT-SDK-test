using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Communications;
using Newtonsoft.Json;

// Token: 0x02001CF8 RID: 7416
public sealed class GClass2014 : NotificationClass
{
	// Token: 0x170017C2 RID: 6082
	// (get) Token: 0x060099D8 RID: 39384 RVA: 0x00002050 File Offset: 0x00000250
	public override ENotificationIconType Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017C3 RID: 6083
	// (get) Token: 0x060099D9 RID: 39385 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A129 RID: 41257
	[JsonProperty("banType")]
	public EBanType BanType;

	// Token: 0x0400A12A RID: 41258
	[JsonProperty("dateTime")]
	public long DateTime;
}
