using System;
using System.Runtime.CompilerServices;

// Token: 0x02002652 RID: 9810
public class GClass2910 : GClass2885
{
	// Token: 0x0600C2A4 RID: 49828 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Invoke(Enum dialogOption)
	{
		throw null;
	}

	// Token: 0x0600C2A5 RID: 49829 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x0400C444 RID: 50244
	public Enum invokedDialogOption;

	// Token: 0x02002653 RID: 9811
	public enum EDialogState
	{
		// Token: 0x0400C446 RID: 50246
		None,
		// Token: 0x0400C447 RID: 50247
		NoQuests,
		// Token: 0x0400C448 RID: 50248
		TakeQuest,
		// Token: 0x0400C449 RID: 50249
		CompleteQuest,
		// Token: 0x0400C44A RID: 50250
		GiveReward,
		// Token: 0x0400C44B RID: 50251
		CantGiveReward,
		// Token: 0x0400C44C RID: 50252
		CommonFarewell,
		// Token: 0x0400C44D RID: 50253
		ZryachiyKilled,
		// Token: 0x0400C44E RID: 50254
		PlayerWithAccessKilled,
		// Token: 0x0400C44F RID: 50255
		TimeEndedFarewell,
		// Token: 0x0400C450 RID: 50256
		TimeEndingWarning,
		// Token: 0x0400C451 RID: 50257
		FirstTimeGreetingsIdle,
		// Token: 0x0400C452 RID: 50258
		FirstTimeGreetings,
		// Token: 0x0400C453 RID: 50259
		CommonGreetigs,
		// Token: 0x0400C454 RID: 50260
		DialogClosed,
		// Token: 0x0400C455 RID: 50261
		TakeItem,
		// Token: 0x0400C456 RID: 50262
		GiveItem,
		// Token: 0x0400C457 RID: 50263
		QuestAvailable,
		// Token: 0x0400C458 RID: 50264
		NextDialogState,
		// Token: 0x0400C459 RID: 50265
		PreviousDialogState,
		// Token: 0x0400C45A RID: 50266
		AvailableServices,
		// Token: 0x0400C45B RID: 50267
		AcceptService,
		// Token: 0x0400C45C RID: 50268
		News = 21,
		// Token: 0x0400C45D RID: 50269
		SetIntelItem = 50,
		// Token: 0x0400C45E RID: 50270
		SetSmallCaseItem,
		// Token: 0x0400C45F RID: 50271
		SetParcelItem,
		// Token: 0x0400C460 RID: 50272
		SetPistolCaseItem,
		// Token: 0x0400C461 RID: 50273
		SetMoneyCaseItem,
		// Token: 0x0400C462 RID: 50274
		WhoAreYou1 = 100,
		// Token: 0x0400C463 RID: 50275
		WhoAreYou2,
		// Token: 0x0400C464 RID: 50276
		WhoAreYou3,
		// Token: 0x0400C465 RID: 50277
		WhoAreYou4,
		// Token: 0x0400C466 RID: 50278
		WhoAreYou5,
		// Token: 0x0400C467 RID: 50279
		WhoAreYou6,
		// Token: 0x0400C468 RID: 50280
		WhoAreYou7,
		// Token: 0x0400C469 RID: 50281
		WhoAreYou8,
		// Token: 0x0400C46A RID: 50282
		WhoAreYou9,
		// Token: 0x0400C46B RID: 50283
		WhoAreYou10,
		// Token: 0x0400C46C RID: 50284
		WhoAreYou11
	}

	// Token: 0x02002654 RID: 9812
	public enum EBtrNewsDialogState
	{
		// Token: 0x0400C46E RID: 50286
		News1 = 200,
		// Token: 0x0400C46F RID: 50287
		News2,
		// Token: 0x0400C470 RID: 50288
		News3,
		// Token: 0x0400C471 RID: 50289
		News4,
		// Token: 0x0400C472 RID: 50290
		News5
	}
}
