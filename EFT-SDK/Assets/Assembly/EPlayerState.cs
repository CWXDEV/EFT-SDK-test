using System;

// Token: 0x020006E6 RID: 1766
public enum EPlayerState : byte
{
	// Token: 0x04002790 RID: 10128
	None,
	// Token: 0x04002791 RID: 10129
	Idle,
	// Token: 0x04002792 RID: 10130
	ProneIdle,
	// Token: 0x04002793 RID: 10131
	ProneMove,
	// Token: 0x04002794 RID: 10132
	Run,
	// Token: 0x04002795 RID: 10133
	Sprint,
	// Token: 0x04002796 RID: 10134
	Jump,
	// Token: 0x04002797 RID: 10135
	FallDown,
	// Token: 0x04002798 RID: 10136
	Transition,
	// Token: 0x04002799 RID: 10137
	BreachDoor,
	// Token: 0x0400279A RID: 10138
	Loot,
	// Token: 0x0400279B RID: 10139
	Pickup,
	// Token: 0x0400279C RID: 10140
	Open,
	// Token: 0x0400279D RID: 10141
	Close,
	// Token: 0x0400279E RID: 10142
	Unlock,
	// Token: 0x0400279F RID: 10143
	Sidestep,
	// Token: 0x040027A0 RID: 10144
	DoorInteraction,
	// Token: 0x040027A1 RID: 10145
	Approach,
	// Token: 0x040027A2 RID: 10146
	Prone2Stand,
	// Token: 0x040027A3 RID: 10147
	Transit2Prone,
	// Token: 0x040027A4 RID: 10148
	Plant,
	// Token: 0x040027A5 RID: 10149
	Stationary,
	// Token: 0x040027A6 RID: 10150
	Roll,
	// Token: 0x040027A7 RID: 10151
	JumpLanding,
	// Token: 0x040027A8 RID: 10152
	ClimbOver,
	// Token: 0x040027A9 RID: 10153
	ClimbUp,
	// Token: 0x040027AA RID: 10154
	VaultingFallDown,
	// Token: 0x040027AB RID: 10155
	VaultingLanding,
	// Token: 0x040027AC RID: 10156
	BlindFire
}
