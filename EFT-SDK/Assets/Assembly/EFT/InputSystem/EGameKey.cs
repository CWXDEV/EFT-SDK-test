using System;

namespace EFT.InputSystem
{
	// Token: 0x02001A2D RID: 6701
	public enum EGameKey
	{
		// Token: 0x04009469 RID: 37993
		None,
		// Token: 0x0400946A RID: 37994
		Shoot,
		// Token: 0x0400946B RID: 37995
		Aim,
		// Token: 0x0400946C RID: 37996
		WeaponPunch,
		// Token: 0x0400946D RID: 37997
		Next,
		// Token: 0x0400946E RID: 37998
		Previous,
		// Token: 0x0400946F RID: 37999
		Interact,
		// Token: 0x04009470 RID: 38000
		ThrowGrenade,
		// Token: 0x04009471 RID: 38001
		ReloadWeapon,
		// Token: 0x04009472 RID: 38002
		ShootingMode,
		// Token: 0x04009473 RID: 38003
		Prone,
		// Token: 0x04009474 RID: 38004
		Sprint,
		// Token: 0x04009475 RID: 38005
		Duck,
		// Token: 0x04009476 RID: 38006
		ExamineWeapon = 14,
		// Token: 0x04009477 RID: 38007
		Inventory,
		// Token: 0x04009478 RID: 38008
		Knife,
		// Token: 0x04009479 RID: 38009
		DropItem,
		// Token: 0x0400947A RID: 38010
		Jump = 19,
		// Token: 0x0400947B RID: 38011
		PrimaryWeaponFirst,
		// Token: 0x0400947C RID: 38012
		PrimaryWeaponSecond,
		// Token: 0x0400947D RID: 38013
		SecondaryWeapon,
		// Token: 0x0400947E RID: 38014
		ChangePointOfView,
		// Token: 0x0400947F RID: 38015
		Escape,
		// Token: 0x04009480 RID: 38016
		CheckAmmo,
		// Token: 0x04009481 RID: 38017
		Slot4,
		// Token: 0x04009482 RID: 38018
		Slot5,
		// Token: 0x04009483 RID: 38019
		Slot6,
		// Token: 0x04009484 RID: 38020
		Slot7,
		// Token: 0x04009485 RID: 38021
		Slot8,
		// Token: 0x04009486 RID: 38022
		Slot9,
		// Token: 0x04009487 RID: 38023
		Slot0,
		// Token: 0x04009488 RID: 38024
		QuickKnife,
		// Token: 0x04009489 RID: 38025
		ToggleLauncher,
		// Token: 0x0400948A RID: 38026
		WatchTime,
		// Token: 0x0400948B RID: 38027
		ToggleGoggles,
		// Token: 0x0400948C RID: 38028
		LeanLockLeft,
		// Token: 0x0400948D RID: 38029
		LeanLockRight,
		// Token: 0x0400948E RID: 38030
		CheckChamber,
		// Token: 0x0400948F RID: 38031
		Mumble,
		// Token: 0x04009490 RID: 38032
		Walk,
		// Token: 0x04009491 RID: 38033
		Tactical,
		// Token: 0x04009492 RID: 38034
		Nidnod,
		// Token: 0x04009493 RID: 38035
		F1,
		// Token: 0x04009494 RID: 38036
		F2,
		// Token: 0x04009495 RID: 38037
		F3,
		// Token: 0x04009496 RID: 38038
		F4,
		// Token: 0x04009497 RID: 38039
		F5,
		// Token: 0x04009498 RID: 38040
		F6,
		// Token: 0x04009499 RID: 38041
		F7,
		// Token: 0x0400949A RID: 38042
		F8,
		// Token: 0x0400949B RID: 38043
		F9,
		// Token: 0x0400949C RID: 38044
		F10,
		// Token: 0x0400949D RID: 38045
		F11,
		// Token: 0x0400949E RID: 38046
		F12,
		// Token: 0x0400949F RID: 38047
		OpticCalibrationSwitchUp,
		// Token: 0x040094A0 RID: 38048
		OpticCalibrationSwitchDown,
		// Token: 0x040094A1 RID: 38049
		ChangeAimScope,
		// Token: 0x040094A2 RID: 38050
		ChangeAimScopeMagnification,
		// Token: 0x040094A3 RID: 38051
		NextWalkPose,
		// Token: 0x040094A4 RID: 38052
		PreviousWalkPose,
		// Token: 0x040094A5 RID: 38053
		NextMagazine,
		// Token: 0x040094A6 RID: 38054
		PreviousMagazine,
		// Token: 0x040094A7 RID: 38055
		SpecialInteraction,
		// Token: 0x040094A8 RID: 38056
		NextGrenadeStage,
		// Token: 0x040094A9 RID: 38057
		QuickReloadWeapon,
		// Token: 0x040094AA RID: 38058
		CheckFireMode,
		// Token: 0x040094AB RID: 38059
		WatchTimerAndExits,
		// Token: 0x040094AC RID: 38060
		MumbleDropdown,
		// Token: 0x040094AD RID: 38061
		MumbleQuick,
		// Token: 0x040094AE RID: 38062
		NextTacticalDevice,
		// Token: 0x040094AF RID: 38063
		FoldStock,
		// Token: 0x040094B0 RID: 38064
		StepRight,
		// Token: 0x040094B1 RID: 38065
		StepLeft,
		// Token: 0x040094B2 RID: 38066
		BlindShootAbove,
		// Token: 0x040094B3 RID: 38067
		BlindShootRight,
		// Token: 0x040094B4 RID: 38068
		MakeScreenshot,
		// Token: 0x040094B5 RID: 38069
		Console,
		// Token: 0x040094B6 RID: 38070
		ThrowItem,
		// Token: 0x040094B7 RID: 38071
		Breath,
		// Token: 0x040094B8 RID: 38072
		Enter,
		// Token: 0x040094B9 RID: 38073
		ToggleInfo,
		// Token: 0x040094BA RID: 38074
		DropBackpack = 84,
		// Token: 0x040094BB RID: 38075
		ChamberUnload,
		// Token: 0x040094BC RID: 38076
		UnloadMagazine,
		// Token: 0x040094BD RID: 38077
		DoubleF1,
		// Token: 0x040094BE RID: 38078
		DoubleF2,
		// Token: 0x040094BF RID: 38079
		DoubleF3,
		// Token: 0x040094C0 RID: 38080
		DoubleF4,
		// Token: 0x040094C1 RID: 38081
		DoubleF5,
		// Token: 0x040094C2 RID: 38082
		DoubleF6,
		// Token: 0x040094C3 RID: 38083
		DoubleF7,
		// Token: 0x040094C4 RID: 38084
		DoubleF8,
		// Token: 0x040094C5 RID: 38085
		DoubleF9,
		// Token: 0x040094C6 RID: 38086
		DoubleF10,
		// Token: 0x040094C7 RID: 38087
		DoubleF11,
		// Token: 0x040094C8 RID: 38088
		DoubleF12,
		// Token: 0x040094C9 RID: 38089
		HighThrow,
		// Token: 0x040094CA RID: 38090
		LowThrow,
		// Token: 0x040094CB RID: 38091
		ForceAutoWeaponMode,
		// Token: 0x040094CC RID: 38092
		PushToTalk,
		// Token: 0x040094CD RID: 38093
		ToggleVoip,
		// Token: 0x040094CE RID: 38094
		PressSlot4,
		// Token: 0x040094CF RID: 38095
		PressSlot5,
		// Token: 0x040094D0 RID: 38096
		PressSlot6,
		// Token: 0x040094D1 RID: 38097
		PressSlot7,
		// Token: 0x040094D2 RID: 38098
		PressSlot8,
		// Token: 0x040094D3 RID: 38099
		PressSlot9,
		// Token: 0x040094D4 RID: 38100
		PressSlot0,
		// Token: 0x040094D5 RID: 38101
		ToggleHeadLight,
		// Token: 0x040094D6 RID: 38102
		SwitchHeadLight,
		// Token: 0x040094D7 RID: 38103
		QuickSecondaryWeapon,
		// Token: 0x040094D8 RID: 38104
		AnimBlindFireAbove,
		// Token: 0x040094D9 RID: 38105
		AnimBlindFireRight,
		// Token: 0x040094DA RID: 38106
		LeftStance,
		// Token: 0x040094DB RID: 38107
		Vaulting
	}
}
