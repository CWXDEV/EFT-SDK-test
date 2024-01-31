using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Hideout;
using Newtonsoft.Json;

// Token: 0x02001BC3 RID: 7107
public abstract class GClass1931 : Requirement
{
	// Token: 0x170016F8 RID: 5880
	// (get) Token: 0x06009537 RID: 38199 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009538 RID: 38200 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public Profile.TraderInfo Trader
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x06009539 RID: 38201
	public abstract void Test(IEnumerable<Profile.TraderInfo> tradersList);

	// Token: 0x04009C07 RID: 39943
	[CompilerGenerated]
	private Profile.TraderInfo traderInfo_0;
}
