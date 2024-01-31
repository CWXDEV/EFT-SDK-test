using System;
using System.Collections.Generic;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.Animations.Recoil
{
	// Token: 0x02001F13 RID: 7955
	public interface IRecoilShotEffect
	{
		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x0600A4A0 RID: 42144
		RotationRecoilProcessBase HandRotationRecoilEffect { get; }

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x0600A4A1 RID: 42145
		RecoilProcessBase HandPositionRecoilEffect { get; }

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x0600A4A2 RID: 42146
		RecoilProcessBase CameraRotationRecoilEffect { get; }

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x0600A4A3 RID: 42147
		// (set) Token: 0x0600A4A4 RID: 42148
		Vector3 SeparateIntensityFactors { get; set; }

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x0600A4A5 RID: 42149
		// (set) Token: 0x0600A4A6 RID: 42150
		Vector2 RecoilRotationStrength { get; set; }

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x0600A4A7 RID: 42151
		// (set) Token: 0x0600A4A8 RID: 42152
		Vector2 DegreeRecoil { get; set; }

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x0600A4A9 RID: 42153
		// (set) Token: 0x0600A4AA RID: 42154
		Vector2 RecoilRadian { get; set; }

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x0600A4AB RID: 42155
		// (set) Token: 0x0600A4AC RID: 42156
		ShotEffector.RecoilShotVal[] RecoilProcessValues { get; set; }

		// Token: 0x0600A4AD RID: 42157
		void FixedUpdate(float deltaTime);

		// Token: 0x0600A4AE RID: 42158
		void AddRecoilForce(float incomingForce);

		// Token: 0x0600A4AF RID: 42159
		void CalculateBaseRecoilParameters(float recoilSuspensionY, float weaponRecoilAngle, float weaponRecoilDispersion, List<ShotsGroupSettings> shotsGroupSettingsList);

		// Token: 0x0600A4B0 RID: 42160
		void RecalculateRecoilParamsOnChangeWeapon(WeaponTemplate template, BackendConfigSettingsClass.AimingConfiguration AimingConfig, Player.FirearmController firearmController, float recoilSuppressionX, float recoilSuppressionY, float recoilSuppressionFactor, float modsFactorRecoil);

		// Token: 0x0600A4B1 RID: 42161
		Vector3 GetHandRotationRecoil();

		// Token: 0x0600A4B2 RID: 42162
		Vector3 GetHandPositionRecoil();

		// Token: 0x0600A4B3 RID: 42163
		Vector3 GetCameraRotationRecoil();
	}
}
