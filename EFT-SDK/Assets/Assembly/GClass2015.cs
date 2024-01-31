using System;
using System.Runtime.CompilerServices;
using EFT;
using Newtonsoft.Json;

// Token: 0x02001CF9 RID: 7417
public sealed class GClass2015 : NotificationClass
{
	// Token: 0x170017C4 RID: 6084
	// (get) Token: 0x060099DA RID: 39386 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A12B RID: 41259
	[JsonProperty("banType")]
	public EBanType BanType;
}
