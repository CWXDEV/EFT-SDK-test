using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x0200053A RID: 1338
public class PatrolWayWithName : PatrolWay
{
	// Token: 0x06002092 RID: 8338 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Suitable(BotOwner bot, IGetProfileData data)
	{
		throw null;
	}

	// Token: 0x06002093 RID: 8339 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string SuitableData()
	{
		throw null;
	}

	// Token: 0x04001F22 RID: 7970
	public string NameId;
}
