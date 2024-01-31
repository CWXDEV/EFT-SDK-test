using System;
using Comfort.Common;
using EFT.InventoryLogic;
using JetBrains.Annotations;

namespace EFT
{
	// Token: 0x02001505 RID: 5381
	public interface IFirearmHandsController : GInterface123, GInterface124, GInterface126
	{
		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x0600739F RID: 29599
		bool IsOverlap { get; }

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x060073A0 RID: 29600
		Weapon Item { get; }

		// Token: 0x060073A1 RID: 29601
		void SetTriggerPressed(bool pressed);

		// Token: 0x060073A2 RID: 29602
		bool ChangeFireMode(Weapon.EFireMode fireMode);

		// Token: 0x060073A3 RID: 29603
		bool CheckFireMode();

		// Token: 0x060073A4 RID: 29604
		void ChangeAimingMode();

		// Token: 0x060073A5 RID: 29605
		void ToggleAim();

		// Token: 0x060073A6 RID: 29606
		void SetAim(bool value);

		// Token: 0x060073A7 RID: 29607
		void ReloadMag(MagazineClass foundItem, [CanBeNull] GClass2765 gridItemAddress, [CanBeNull] Callback callback);

		// Token: 0x060073A8 RID: 29608
		bool ExamineWeapon();

		// Token: 0x060073A9 RID: 29609
		void RollCylinder(bool rollToZeroCamora);

		// Token: 0x060073AA RID: 29610
		void QuickReloadMag(MagazineClass foundItem, [CanBeNull] Callback callback);

		// Token: 0x060073AB RID: 29611
		void ReloadWithAmmo(GClass2491 foundItem, [CanBeNull] Callback callback);

		// Token: 0x060073AC RID: 29612
		void ReloadCylinderMagazine(GClass2491 ammoPack, [CanBeNull] Callback callback, bool quickReload);

		// Token: 0x060073AD RID: 29613
		void ReloadBarrels(GClass2491 ammoPack, GClass2765 placeToPutContainedAmmoMagazine, [CanBeNull] Callback callback);

		// Token: 0x060073AE RID: 29614
		void ReloadGrenadeLauncher(GClass2491 foundItem, [CanBeNull] Callback callback);

		// Token: 0x060073AF RID: 29615
		bool CheckAmmo();

		// Token: 0x060073B0 RID: 29616
		bool CheckChamber();

		// Token: 0x060073B1 RID: 29617
		void SetLightsState(GStruct162[] lightsStates, bool force = false);

		// Token: 0x060073B2 RID: 29618
		bool ToggleLauncher();

		// Token: 0x060073B3 RID: 29619
		bool CanStartReload();

		// Token: 0x060073B4 RID: 29620
		bool ShouldForceQuickReload();

		// Token: 0x060073B5 RID: 29621
		bool CanPressTrigger();

		// Token: 0x060073B6 RID: 29622
		bool IsInLauncherMode();

		// Token: 0x060073B7 RID: 29623
		void SetScopeMode(GStruct163[] scopeStates);

		// Token: 0x060073B8 RID: 29624
		void ReloadMagNotFound();

		// Token: 0x060073B9 RID: 29625
		void OpticCalibrationSwitchUp(GStruct163[] scopeStates);

		// Token: 0x060073BA RID: 29626
		void OpticCalibrationSwitchDown(GStruct163[] scopeStates);

		// Token: 0x060073BB RID: 29627
		void UnderbarrelSightingRangeUp();

		// Token: 0x060073BC RID: 29628
		void UnderbarrelSightingRangeDown();

		// Token: 0x060073BD RID: 29629
		bool HasScopeAimBone(SightComponent sightComp);

		// Token: 0x060073BE RID: 29630
		void ChangeLeftStance();
	}
}
