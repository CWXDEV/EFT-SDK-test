using System;
using System.Runtime.CompilerServices;

// Token: 0x0200045C RID: 1116
public class BotFriendChecker : GClass362
{
	// Token: 0x06001AF5 RID: 6901 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x0400170B RID: 5899
	private const float DIST_TO_AIM = 50f;

	// Token: 0x0400170C RID: 5900
	private const float DIST_TO_LOOK = 50f;

	// Token: 0x0400170D RID: 5901
	private const float DIST_TO_EAT = 50f;

	// Token: 0x0400170E RID: 5902
	private const float DIST_TO_GESTUS = 20f;

	// Token: 0x0400170F RID: 5903
	private const float DIST_TO_TILT = 50f;

	// Token: 0x04001710 RID: 5904
	private const float DIST_TO_WATCH_WEAPON = 50f;

	// Token: 0x04001711 RID: 5905
	private readonly float _distToBeClose;

	// Token: 0x04001712 RID: 5906
	private readonly GClass345 _botsConnections;

	// Token: 0x04001713 RID: 5907
	private float _nextTimeCheck;

	// Token: 0x04001714 RID: 5908
	private readonly GClass1463<EBotFriendAction> _chancesNoEat;

	// Token: 0x04001715 RID: 5909
	private readonly GClass1463<EBotFriendAction> _chancesTotal;
}
