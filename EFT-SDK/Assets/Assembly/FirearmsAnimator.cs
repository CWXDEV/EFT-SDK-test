using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;

// Token: 0x020006E0 RID: 1760
public class FirearmsAnimator : ObjectInHandsAnimator
{
	// Token: 0x14000077 RID: 119
	// (add) Token: 0x06002902 RID: 10498 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002903 RID: 10499 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> SetPatronInWeaponVisibleEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x06002904 RID: 10500 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHammerArmed(bool isTriggerArmed)
	{
		throw null;
	}

	// Token: 0x06002905 RID: 10501 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPatronInWeaponVisible(bool visible)
	{
		throw null;
	}

	// Token: 0x17000728 RID: 1832
	// (get) Token: 0x06002906 RID: 10502 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002907 RID: 10503 RVA: 0x00002050 File Offset: 0x00000250
	public string FullFireStateName
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000729 RID: 1833
	// (get) Token: 0x06002908 RID: 10504 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002909 RID: 10505 RVA: 0x00002050 File Offset: 0x00000250
	public string FullSemiFireStateName
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700072A RID: 1834
	// (get) Token: 0x0600290A RID: 10506 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600290B RID: 10507 RVA: 0x00002050 File Offset: 0x00000250
	public string FullDoubleActionFireStateName
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700072B RID: 1835
	// (get) Token: 0x0600290C RID: 10508 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600290D RID: 10509 RVA: 0x00002050 File Offset: 0x00000250
	public string FullIdleStateName
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x0600290E RID: 10510 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetAnimatorGetter(Func<IAnimator> getter)
	{
		throw null;
	}

	// Token: 0x0600290F RID: 10511 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Reload(int currentMagType, int nextMagType, bool isFast)
	{
		throw null;
	}

	// Token: 0x06002910 RID: 10512 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsIdling()
	{
		throw null;
	}

	// Token: 0x06002911 RID: 10513 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsHandsProcessing()
	{
		throw null;
	}

	// Token: 0x06002912 RID: 10514 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetSpeedParameters(float reload = 1f, float draw = 1f)
	{
		throw null;
	}

	// Token: 0x06002913 RID: 10515 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetMalfRepairSpeed(float fix = 1f)
	{
		throw null;
	}

	// Token: 0x06002914 RID: 10516 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Idle()
	{
		throw null;
	}

	// Token: 0x06002915 RID: 10517 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIsExternalMag(bool isExternalMag)
	{
		throw null;
	}

	// Token: 0x06002916 RID: 10518 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetMagFull(bool b)
	{
		throw null;
	}

	// Token: 0x06002917 RID: 10519 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFire(bool fire)
	{
		throw null;
	}

	// Token: 0x06002918 RID: 10520 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSprint(bool sprint)
	{
		throw null;
	}

	// Token: 0x06002919 RID: 10521 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGrenadeFire(FirearmsAnimator.EGrenadeFire fire)
	{
		throw null;
	}

	// Token: 0x0600291A RID: 10522 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAlternativeFire(bool fire)
	{
		throw null;
	}

	// Token: 0x0600291B RID: 10523 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGrenadeAltFire(FirearmsAnimator.EGrenadeFire fire)
	{
		throw null;
	}

	// Token: 0x0600291C RID: 10524 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMagInWeapon(bool ok)
	{
		throw null;
	}

	// Token: 0x0600291D RID: 10525 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBoltActionReload(bool boltActionReload)
	{
		throw null;
	}

	// Token: 0x0600291E RID: 10526 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBoltCatch(bool active)
	{
		throw null;
	}

	// Token: 0x0600291F RID: 10527 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetBoltCatch()
	{
		throw null;
	}

	// Token: 0x06002920 RID: 10528 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCanReload(bool canReload)
	{
		throw null;
	}

	// Token: 0x06002921 RID: 10529 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAimAngle(float playerPitch)
	{
		throw null;
	}

	// Token: 0x06002922 RID: 10530 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAiming(bool isAiming)
	{
		throw null;
	}

	// Token: 0x06002923 RID: 10531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAimingIn(bool aimingIn)
	{
		throw null;
	}

	// Token: 0x06002924 RID: 10532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAimingOut(bool aimingOut)
	{
		throw null;
	}

	// Token: 0x06002925 RID: 10533 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPrevAimingFloat(bool isAiming)
	{
		throw null;
	}

	// Token: 0x06002926 RID: 10534 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Malfunction(int val)
	{
		throw null;
	}

	// Token: 0x06002927 RID: 10535 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MalfunctionRepair(bool val)
	{
		throw null;
	}

	// Token: 0x06002928 RID: 10536 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MisfireSlideUnknown(bool val)
	{
		throw null;
	}

	// Token: 0x06002929 RID: 10537 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Rechamber(bool val)
	{
		throw null;
	}

	// Token: 0x0600292A RID: 10538 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAmmoOnMag(int count)
	{
		throw null;
	}

	// Token: 0x0600292B RID: 10539 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMasteringReloadAborted(bool value)
	{
		throw null;
	}

	// Token: 0x0600292C RID: 10540 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAmmoCountForRemove(int count)
	{
		throw null;
	}

	// Token: 0x0600292D RID: 10541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCamoraIndex(int camoraIndex)
	{
		throw null;
	}

	// Token: 0x0600292E RID: 10542 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCamoraFireIndex(int camoraFireIndex)
	{
		throw null;
	}

	// Token: 0x0600292F RID: 10543 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDoubleAction(float doubleAction)
	{
		throw null;
	}

	// Token: 0x06002930 RID: 10544 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCamoraIndexForLoadAmmo(int camoraIndex)
	{
		throw null;
	}

	// Token: 0x06002931 RID: 10545 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCamoraIndexWithShellForRemove(int camoraIdnex)
	{
		throw null;
	}

	// Token: 0x06002932 RID: 10546 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCamoraIndexForUnloadAmmo(int camoraIndex)
	{
		throw null;
	}

	// Token: 0x06002933 RID: 10547 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAmmoInChamber(float count)
	{
		throw null;
	}

	// Token: 0x06002934 RID: 10548 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetShellsInWeapon(int count)
	{
		throw null;
	}

	// Token: 0x06002935 RID: 10549 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUnderbarrelSightingRange(float value)
	{
		throw null;
	}

	// Token: 0x06002936 RID: 10550 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetSightingRange()
	{
		throw null;
	}

	// Token: 0x06002937 RID: 10551 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFireMode(Weapon.EFireMode fireMode, bool skipAnimation = false)
	{
		throw null;
	}

	// Token: 0x06002938 RID: 10552 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TriggerFiremodeCheck()
	{
		throw null;
	}

	// Token: 0x06002939 RID: 10553 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMagTypeCurrent(int magType)
	{
		throw null;
	}

	// Token: 0x0600293A RID: 10554 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUniqueAnimationModId(int id)
	{
		throw null;
	}

	// Token: 0x0600293B RID: 10555 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMagTypeNew(int magType)
	{
		throw null;
	}

	// Token: 0x0600293C RID: 10556 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWeaponLevel(float weaponLevel)
	{
		throw null;
	}

	// Token: 0x0600293D RID: 10557 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPickup(bool p)
	{
		throw null;
	}

	// Token: 0x0600293E RID: 10558 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInteract(bool p, int actionIndex)
	{
		throw null;
	}

	// Token: 0x0600293F RID: 10559 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void WatchClock(EPlayerSide playerSide)
	{
		throw null;
	}

	// Token: 0x06002940 RID: 10560 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fold(bool folded)
	{
		throw null;
	}

	// Token: 0x06002941 RID: 10561 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAmmoCompatible(bool compatible)
	{
		throw null;
	}

	// Token: 0x06002942 RID: 10562 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAnimationVariant(int animationVariant)
	{
		throw null;
	}

	// Token: 0x06002943 RID: 10563 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUseTimeMultiplier(float speed)
	{
		throw null;
	}

	// Token: 0x06002944 RID: 10564 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLooting(bool b)
	{
		throw null;
	}

	// Token: 0x06002945 RID: 10565 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReloadFast(bool b)
	{
		throw null;
	}

	// Token: 0x06002946 RID: 10566 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollToZeroCamora(bool roll)
	{
		throw null;
	}

	// Token: 0x06002947 RID: 10567 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRollCylinder(bool roll)
	{
		throw null;
	}

	// Token: 0x06002948 RID: 10568 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadOneTrigger(bool loadOne)
	{
		throw null;
	}

	// Token: 0x06002949 RID: 10569 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HammerArmed()
	{
		throw null;
	}

	// Token: 0x0600294A RID: 10570 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetChamberIndexForLoadUnloadAmmo(float chamberIndex)
	{
		throw null;
	}

	// Token: 0x0600294B RID: 10571 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetChamberIndexWithShell(float chamberIndex)
	{
		throw null;
	}

	// Token: 0x0600294C RID: 10572 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reload(bool b)
	{
		throw null;
	}

	// Token: 0x0600294D RID: 10573 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetReload()
	{
		throw null;
	}

	// Token: 0x0600294E RID: 10574 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetButterFingers()
	{
		throw null;
	}

	// Token: 0x0600294F RID: 10575 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TriggerFold()
	{
		throw null;
	}

	// Token: 0x06002950 RID: 10576 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookTrigger()
	{
		throw null;
	}

	// Token: 0x06002951 RID: 10577 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertMagInInventoryMode()
	{
		throw null;
	}

	// Token: 0x06002952 RID: 10578 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetInsertMagInInventoryMode()
	{
		throw null;
	}

	// Token: 0x06002953 RID: 10579 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetGestureTrigger()
	{
		throw null;
	}

	// Token: 0x06002954 RID: 10580 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetHandReadyTrigger()
	{
		throw null;
	}

	// Token: 0x06002955 RID: 10581 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PullOutMagInInventoryMode()
	{
		throw null;
	}

	// Token: 0x06002956 RID: 10582 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetupMod(bool modSet)
	{
		throw null;
	}

	// Token: 0x06002957 RID: 10583 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckAmmo()
	{
		throw null;
	}

	// Token: 0x06002958 RID: 10584 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckChamber()
	{
		throw null;
	}

	// Token: 0x06002959 RID: 10585 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCheckChamberTrigger()
	{
		throw null;
	}

	// Token: 0x0600295A RID: 10586 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLauncher(bool isLauncherEnabled)
	{
		throw null;
	}

	// Token: 0x0600295B RID: 10587 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLauncherId(int launcherId)
	{
		throw null;
	}

	// Token: 0x0600295C RID: 10588 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Discharge(bool discharge)
	{
		throw null;
	}

	// Token: 0x0600295D RID: 10589 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ModToggleTrigger()
	{
		throw null;
	}

	// Token: 0x0400275F RID: 10079
	public const string JAM_STATE_NAME = "JAM";

	// Token: 0x04002760 RID: 10080
	public const string FIRE_STATE_NAME = "FIRE";

	// Token: 0x04002761 RID: 10081
	public const string SEMIFIRE_STATE_NAME = "SA FIRE";

	// Token: 0x04002762 RID: 10082
	public const string DOUBLE_ACTION_FIRE_STATE_NAME = "DOUBLE_ACTION_FIRE";

	// Token: 0x04002763 RID: 10083
	public const string MISFIRE_STATE_NAME = "MISFIRE";

	// Token: 0x04002764 RID: 10084
	public const string SOFT_SLIDE_STATE_NAME = "SOFT_SLIDE";

	// Token: 0x04002765 RID: 10085
	public const string HARD_SLIDE_STATE_NAME = "HARD_SLIDE";

	// Token: 0x04002766 RID: 10086
	public const string FEED_STATE_NAME = "FEED";

	// Token: 0x04002767 RID: 10087
	public const string IDLE_STATE_NAME = "IDLE";

	// Token: 0x04002768 RID: 10088
	public const string IDLE_UNDERBARREL_NAME = "IDLE WEAPON";

	// Token: 0x04002769 RID: 10089
	public const string SPAWN_STATE_NAME = "SPAWN";

	// Token: 0x0400276A RID: 10090
	public const string PATROL_STATE_NAME = "PATROL";

	// Token: 0x0400276B RID: 10091
	public const string DRY_FIRE_STATE_NAME = "DRY FIRE";

	// Token: 0x0400276C RID: 10092
	public const string DRY_FIRE_DISARMED_STATE_NAME = "Hands.DRY FIRE DISARMED";

	// Token: 0x0400276D RID: 10093
	public const int HANDS_LAYER_INDEX = 1;

	// Token: 0x0400276E RID: 10094
	public const string HANDS_LAYER_NAME = "Hands";

	// Token: 0x0400276F RID: 10095
	public const string BOLT_CATCH_LAYER_NAME = "Catch";

	// Token: 0x04002770 RID: 10096
	public const string HAMMER_LAYER_NAME = "Hammer";

	// Token: 0x04002771 RID: 10097
	public const string ADDITIONAL_HANDS_LAYER_NAME = "Additional_Hands";

	// Token: 0x04002772 RID: 10098
	public const string STOCK_LAYER = "Stock";

	// Token: 0x04002773 RID: 10099
	public const string MALFUNCTION_LAYER = "Malfunction";

	// Token: 0x04002774 RID: 10100
	public const string LHANDS_LAYER = "LActions";

	// Token: 0x04002775 RID: 10101
	public int ADDITIONAL_HANDS_LAYER_INDEX;

	// Token: 0x04002776 RID: 10102
	public int BOLT_CATCH_LAYER_INDEX;

	// Token: 0x04002777 RID: 10103
	public int HAMMER_LAYER_INDEX;

	// Token: 0x04002778 RID: 10104
	public int STOCK_LAYER_INDEX;

	// Token: 0x04002779 RID: 10105
	public int MALFUNCTION_LAYER_INDEX;

	// Token: 0x0400277A RID: 10106
	public new int LACTIONS_LAYER_INDEX;

	// Token: 0x020006E1 RID: 1761
	public enum EGrenadeFire
	{
		// Token: 0x04002780 RID: 10112
		Idle,
		// Token: 0x04002781 RID: 10113
		Hold,
		// Token: 0x04002782 RID: 10114
		Throw
	}
}
