using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02000539 RID: 1337
public class PatrolWayWithConditions : PatrolWay
{
	// Token: 0x06002091 RID: 8337 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Suitable(BotOwner bot, IGetProfileData data)
	{
		throw null;
	}

	// Token: 0x04001F20 RID: 7968
	public SpawnTriggerType TriggerType;

	// Token: 0x04001F21 RID: 7969
	public string Id;
}
