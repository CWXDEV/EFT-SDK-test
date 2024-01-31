using System;

// Token: 0x02000207 RID: 519
public enum EDecisionMethod
{
	// Token: 0x04000A9E RID: 2718
	HaveTargetLogic = 1,
	// Token: 0x04000A9F RID: 2719
	GetLogic,
	// Token: 0x04000AA0 RID: 2720
	InFightLogic,
	// Token: 0x04000AA1 RID: 2721
	VisibleEnemyDecision,
	// Token: 0x04000AA2 RID: 2722
	FightAtZone,
	// Token: 0x04000AA3 RID: 2723
	FightAtFree,
	// Token: 0x04000AA4 RID: 2724
	DefenceMode,
	// Token: 0x04000AA5 RID: 2725
	ShootFromPlaceOrGo,
	// Token: 0x04000AA6 RID: 2726
	RunIfCantShoot,
	// Token: 0x04000AA7 RID: 2727
	CloseDist,
	// Token: 0x04000AA8 RID: 2728
	MidDist,
	// Token: 0x04000AA9 RID: 2729
	FarDist,
	// Token: 0x04000AAA RID: 2730
	FarestDist,
	// Token: 0x04000AAB RID: 2731
	ManyEnemiesAttackLogic,
	// Token: 0x04000AAC RID: 2732
	FewEnemiesAttackLogic,
	// Token: 0x04000AAD RID: 2733
	RunOrStrike,
	// Token: 0x04000AAE RID: 2734
	AssaultMode,
	// Token: 0x04000AAF RID: 2735
	Suppress,
	// Token: 0x04000AB0 RID: 2736
	HaveEnemyLogic,
	// Token: 0x04000AB1 RID: 2737
	GoToNextCover,
	// Token: 0x04000AB2 RID: 2738
	Unknown = 999
}
