using System;

namespace EFT.InputSystem
{
	// Token: 0x02001A2E RID: 6702
	public enum ECommand
	{
		// Token: 0x040094DD RID: 38109
		None,
		// Token: 0x040094DE RID: 38110
		ToggleShooting,
		// Token: 0x040094DF RID: 38111
		EndShooting,
		// Token: 0x040094E0 RID: 38112
		ToggleAlternativeShooting,
		// Token: 0x040094E1 RID: 38113
		ToggleSpeed,
		// Token: 0x040094E2 RID: 38114
		ChangeScope,
		// Token: 0x040094E3 RID: 38115
		ChangeScopeMagnification,
		// Token: 0x040094E4 RID: 38116
		CheckFireMode,
		// Token: 0x040094E5 RID: 38117
		DecreaseWalkSpeed,
		// Token: 0x040094E6 RID: 38118
		BeginInteracting,
		// Token: 0x040094E7 RID: 38119
		EndInteracting,
		// Token: 0x040094E8 RID: 38120
		BeginSpecialInteracting,
		// Token: 0x040094E9 RID: 38121
		EndSpecialInteracting,
		// Token: 0x040094EA RID: 38122
		ThrowGrenade,
		// Token: 0x040094EB RID: 38123
		NextGrenadeStage,
		// Token: 0x040094EC RID: 38124
		ReloadWeapon,
		// Token: 0x040094ED RID: 38125
		NextMagazine,
		// Token: 0x040094EE RID: 38126
		PreviousMagazine,
		// Token: 0x040094EF RID: 38127
		QuickReloadWeapon,
		// Token: 0x040094F0 RID: 38128
		ChangeWeaponMode,
		// Token: 0x040094F1 RID: 38129
		ForceAutoWeaponMode,
		// Token: 0x040094F2 RID: 38130
		ToggleDuck,
		// Token: 0x040094F3 RID: 38131
		ToggleSprinting,
		// Token: 0x040094F4 RID: 38132
		EndSprinting,
		// Token: 0x040094F5 RID: 38133
		ToggleBreathing,
		// Token: 0x040094F6 RID: 38134
		EndBreathing,
		// Token: 0x040094F7 RID: 38135
		ToggleProne,
		// Token: 0x040094F8 RID: 38136
		ResetLookDirection,
		// Token: 0x040094F9 RID: 38137
		NextWalkPose,
		// Token: 0x040094FA RID: 38138
		PreviousWalkPose,
		// Token: 0x040094FB RID: 38139
		ToggleStepLeft,
		// Token: 0x040094FC RID: 38140
		ToggleStepRight,
		// Token: 0x040094FD RID: 38141
		ReturnFromLeftStep,
		// Token: 0x040094FE RID: 38142
		ReturnFromRightStep,
		// Token: 0x040094FF RID: 38143
		ExamineWeapon,
		// Token: 0x04009500 RID: 38144
		ToggleInventory,
		// Token: 0x04009501 RID: 38145
		SelectKnife,
		// Token: 0x04009502 RID: 38146
		ToggleTacticalDevice,
		// Token: 0x04009503 RID: 38147
		Jump,
		// Token: 0x04009504 RID: 38148
		SelectFirstPrimaryWeapon,
		// Token: 0x04009505 RID: 38149
		SelectSecondPrimaryWeapon,
		// Token: 0x04009506 RID: 38150
		SelectSecondaryWeapon,
		// Token: 0x04009507 RID: 38151
		QuickSelectSecondaryWeapon,
		// Token: 0x04009508 RID: 38152
		LeftStanceToggle,
		// Token: 0x04009509 RID: 38153
		SetLeftStance,
		// Token: 0x0400950A RID: 38154
		SelectFastSlot4,
		// Token: 0x0400950B RID: 38155
		SelectFastSlot5,
		// Token: 0x0400950C RID: 38156
		SelectFastSlot6,
		// Token: 0x0400950D RID: 38157
		SelectFastSlot7,
		// Token: 0x0400950E RID: 38158
		SelectFastSlot8,
		// Token: 0x0400950F RID: 38159
		SelectFastSlot9,
		// Token: 0x04009510 RID: 38160
		SelectFastSlot0,
		// Token: 0x04009511 RID: 38161
		FoldStock,
		// Token: 0x04009512 RID: 38162
		ChangePointOfView,
		// Token: 0x04009513 RID: 38163
		Escape,
		// Token: 0x04009514 RID: 38164
		Enter,
		// Token: 0x04009515 RID: 38165
		CheckAmmo,
		// Token: 0x04009516 RID: 38166
		EndAlternativeShooting,
		// Token: 0x04009517 RID: 38167
		NextTacticalDevice,
		// Token: 0x04009518 RID: 38168
		QuickKnifeKick,
		// Token: 0x04009519 RID: 38169
		MumbleEnd,
		// Token: 0x0400951A RID: 38170
		DisplayTimer,
		// Token: 0x0400951B RID: 38171
		DisplayTimerAndExits,
		// Token: 0x0400951C RID: 38172
		ToggleGoggles,
		// Token: 0x0400951D RID: 38173
		ToggleLeanRight,
		// Token: 0x0400951E RID: 38174
		ToggleLeanLeft,
		// Token: 0x0400951F RID: 38175
		ToggleAnimBlindFireAbove,
		// Token: 0x04009520 RID: 38176
		ToggleAnimBlindFireRight,
		// Token: 0x04009521 RID: 38177
		EndAnimBlindFireAbove,
		// Token: 0x04009522 RID: 38178
		EndAnimBlindFireRight,
		// Token: 0x04009523 RID: 38179
		BlindShootEnd,
		// Token: 0x04009524 RID: 38180
		LeanLeftSlow,
		// Token: 0x04009525 RID: 38181
		CheckChamber,
		// Token: 0x04009526 RID: 38182
		MumbleToggle,
		// Token: 0x04009527 RID: 38183
		ToggleMumbleDropdown,
		// Token: 0x04009528 RID: 38184
		MumbleDropdownHide,
		// Token: 0x04009529 RID: 38185
		QuickMumbleStart,
		// Token: 0x0400952A RID: 38186
		ScrollNext,
		// Token: 0x0400952B RID: 38187
		ScrollPrevious,
		// Token: 0x0400952C RID: 38188
		ToggleWalk,
		// Token: 0x0400952D RID: 38189
		EndWalk,
		// Token: 0x0400952E RID: 38190
		EndLeanLeft,
		// Token: 0x0400952F RID: 38191
		EndLeanRight,
		// Token: 0x04009530 RID: 38192
		RestorePose,
		// Token: 0x04009531 RID: 38193
		OpticCalibrationSwitchUp,
		// Token: 0x04009532 RID: 38194
		OpticCalibrationSwitchDown,
		// Token: 0x04009533 RID: 38195
		MakeScreenshot,
		// Token: 0x04009534 RID: 38196
		ShowConsole,
		// Token: 0x04009535 RID: 38197
		ThrowItem,
		// Token: 0x04009536 RID: 38198
		ToggleInfo,
		// Token: 0x04009537 RID: 38199
		DropBackpack,
		// Token: 0x04009538 RID: 38200
		ChamberUnload,
		// Token: 0x04009539 RID: 38201
		UnloadMagazine,
		// Token: 0x0400953A RID: 38202
		TryHighThrow,
		// Token: 0x0400953B RID: 38203
		FinishHighThrow,
		// Token: 0x0400953C RID: 38204
		TryLowThrow,
		// Token: 0x0400953D RID: 38205
		FinishLowThrow,
		// Token: 0x0400953E RID: 38206
		F1,
		// Token: 0x0400953F RID: 38207
		F2,
		// Token: 0x04009540 RID: 38208
		F3,
		// Token: 0x04009541 RID: 38209
		F4,
		// Token: 0x04009542 RID: 38210
		F5,
		// Token: 0x04009543 RID: 38211
		F6,
		// Token: 0x04009544 RID: 38212
		F7,
		// Token: 0x04009545 RID: 38213
		F8,
		// Token: 0x04009546 RID: 38214
		F9,
		// Token: 0x04009547 RID: 38215
		F10,
		// Token: 0x04009548 RID: 38216
		F11,
		// Token: 0x04009549 RID: 38217
		F12,
		// Token: 0x0400954A RID: 38218
		DoubleF1,
		// Token: 0x0400954B RID: 38219
		DoubleF2,
		// Token: 0x0400954C RID: 38220
		DoubleF3,
		// Token: 0x0400954D RID: 38221
		DoubleF4,
		// Token: 0x0400954E RID: 38222
		DoubleF5,
		// Token: 0x0400954F RID: 38223
		DoubleF6,
		// Token: 0x04009550 RID: 38224
		DoubleF7,
		// Token: 0x04009551 RID: 38225
		DoubleF8,
		// Token: 0x04009552 RID: 38226
		DoubleF9,
		// Token: 0x04009553 RID: 38227
		DoubleF10,
		// Token: 0x04009554 RID: 38228
		DoubleF11,
		// Token: 0x04009555 RID: 38229
		DoubleF12,
		// Token: 0x04009556 RID: 38230
		ToggleTalk,
		// Token: 0x04009557 RID: 38231
		StopTalk,
		// Token: 0x04009558 RID: 38232
		ToggleVoip,
		// Token: 0x04009559 RID: 38233
		Vaulting,
		// Token: 0x0400955A RID: 38234
		VaultingEnd,
		// Token: 0x0400955B RID: 38235
		PressSlot4,
		// Token: 0x0400955C RID: 38236
		PressSlot5,
		// Token: 0x0400955D RID: 38237
		PressSlot6,
		// Token: 0x0400955E RID: 38238
		PressSlot7,
		// Token: 0x0400955F RID: 38239
		PressSlot8,
		// Token: 0x04009560 RID: 38240
		PressSlot9,
		// Token: 0x04009561 RID: 38241
		PressSlot0,
		// Token: 0x04009562 RID: 38242
		ToggleHeadLight,
		// Token: 0x04009563 RID: 38243
		SwitchHeadLight,
		// Token: 0x04009564 RID: 38244
		ToggleBlindAbove,
		// Token: 0x04009565 RID: 38245
		ToggleBlindRight
	}
}
