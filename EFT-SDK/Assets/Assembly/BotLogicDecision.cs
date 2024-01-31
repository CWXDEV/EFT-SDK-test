using System;

// Token: 0x0200030F RID: 783
public enum BotLogicDecision
{
	// Token: 0x04000FB6 RID: 4022
	doorOpen,
	// Token: 0x04000FB7 RID: 4023
	warnPlayer,
	// Token: 0x04000FB8 RID: 4024
	shootToSmoke,
	// Token: 0x04000FB9 RID: 4025
	holdPosition,
	// Token: 0x04000FBA RID: 4026
	runToCover,
	// Token: 0x04000FBB RID: 4027
	attackMoving,
	// Token: 0x04000FBC RID: 4028
	attackMovingWithSuppress,
	// Token: 0x04000FBD RID: 4029
	shootFromPlace,
	// Token: 0x04000FBE RID: 4030
	goToEnemy,
	// Token: 0x04000FBF RID: 4031
	heal,
	// Token: 0x04000FC0 RID: 4032
	goToCoverPoint,
	// Token: 0x04000FC1 RID: 4033
	repairMalfunction,
	// Token: 0x04000FC2 RID: 4034
	lay,
	// Token: 0x04000FC3 RID: 4035
	search,
	// Token: 0x04000FC4 RID: 4036
	shootFromCover,
	// Token: 0x04000FC5 RID: 4037
	dogFight,
	// Token: 0x04000FC6 RID: 4038
	turnAwayLight,
	// Token: 0x04000FC7 RID: 4039
	standBy,
	// Token: 0x04000FC8 RID: 4040
	suppressFire,
	// Token: 0x04000FC9 RID: 4041
	suppressGrenade,
	// Token: 0x04000FCA RID: 4042
	throwGrenadeFromPlace,
	// Token: 0x04000FCB RID: 4043
	runAndThrowGrenadeFromPlace,
	// Token: 0x04000FCC RID: 4044
	runToEnemy,
	// Token: 0x04000FCD RID: 4045
	runToEnemyZigZag,
	// Token: 0x04000FCE RID: 4046
	goToPoint,
	// Token: 0x04000FCF RID: 4047
	panicSitting,
	// Token: 0x04000FD0 RID: 4048
	runToStationary,
	// Token: 0x04000FD1 RID: 4049
	shootFromStationary,
	// Token: 0x04000FD2 RID: 4050
	suppressStationary,
	// Token: 0x04000FD3 RID: 4051
	healStimulators,
	// Token: 0x04000FD4 RID: 4052
	axeTarget,
	// Token: 0x04000FD5 RID: 4053
	healAnotherTarget,
	// Token: 0x04000FD6 RID: 4054
	oneMeleeAttack,
	// Token: 0x04000FD7 RID: 4055
	grenadeSuicide,
	// Token: 0x04000FD8 RID: 4056
	leaveMap,
	// Token: 0x04000FD9 RID: 4057
	deadBody,
	// Token: 0x04000FDA RID: 4058
	friendlyTilt,
	// Token: 0x04000FDB RID: 4059
	eatDrink,
	// Token: 0x04000FDC RID: 4060
	watchSecondWeapon,
	// Token: 0x04000FDD RID: 4061
	peaceHardAim,
	// Token: 0x04000FDE RID: 4062
	peaceLook,
	// Token: 0x04000FDF RID: 4063
	gesture,
	// Token: 0x04000FE0 RID: 4064
	peaceful,
	// Token: 0x04000FE1 RID: 4065
	botDropItem,
	// Token: 0x04000FE2 RID: 4066
	botTakeItem,
	// Token: 0x04000FE3 RID: 4067
	followerPatrol,
	// Token: 0x04000FE4 RID: 4068
	alternativePatrol,
	// Token: 0x04000FE5 RID: 4069
	simplePatrol,
	// Token: 0x04000FE6 RID: 4070
	runAwayGrenade,
	// Token: 0x04000FE7 RID: 4071
	runAwayBTR,
	// Token: 0x04000FE8 RID: 4072
	followMeRequest,
	// Token: 0x04000FE9 RID: 4073
	runToCoverZigZag,
	// Token: 0x04000FEA RID: 4074
	flashed,
	// Token: 0x04000FEB RID: 4075
	teleportToCover,
	// Token: 0x04000FEC RID: 4076
	crawl,
	// Token: 0x04000FED RID: 4077
	khorovodChristmasEvent,
	// Token: 0x04000FEE RID: 4078
	doGiftChristmasEvent,
	// Token: 0x04000FEF RID: 4079
	summon,
	// Token: 0x04000FF0 RID: 4080
	followPlayer,
	// Token: 0x04000FF1 RID: 4081
	debugMove,
	// Token: 0x04000FF2 RID: 4082
	debugRun,
	// Token: 0x04000FF3 RID: 4083
	debugDrop,
	// Token: 0x04000FF4 RID: 4084
	debugTake,
	// Token: 0x04000FF5 RID: 4085
	debugGestus,
	// Token: 0x04000FF6 RID: 4086
	debugMeleeChange,
	// Token: 0x04000FF7 RID: 4087
	debugGrenade,
	// Token: 0x04000FF8 RID: 4088
	debugLay,
	// Token: 0x04000FF9 RID: 4089
	debugMelee,
	// Token: 0x04000FFA RID: 4090
	debugShuttle,
	// Token: 0x04000FFB RID: 4091
	debugRotateHead,
	// Token: 0x04000FFC RID: 4092
	debugRotate,
	// Token: 0x04000FFD RID: 4093
	debugRotateLay,
	// Token: 0x04000FFE RID: 4094
	debugRunToPoint,
	// Token: 0x04000FFF RID: 4095
	debugShoot,
	// Token: 0x04001000 RID: 4096
	debugStationary,
	// Token: 0x04001001 RID: 4097
	debugWeaponChange,
	// Token: 0x04001002 RID: 4098
	debugStationaryInstantTake,
	// Token: 0x04001003 RID: 4099
	debugRunToCloseCover,
	// Token: 0x04001004 RID: 4100
	debugZigZagRunNode,
	// Token: 0x04001005 RID: 4101
	debugMeds
}
