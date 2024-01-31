using System;

// Token: 0x020006DB RID: 1755
public interface GInterface24
{
	// Token: 0x060027D1 RID: 10193
	void OnAddAmmoInChamber();

	// Token: 0x060027D2 RID: 10194
	void OnAddAmmoInMag();

	// Token: 0x060027D3 RID: 10195
	void OnArm();

	// Token: 0x060027D4 RID: 10196
	void OnCook();

	// Token: 0x060027D5 RID: 10197
	void OnDelAmmoChamber();

	// Token: 0x060027D6 RID: 10198
	void OnDelAmmoFromMag();

	// Token: 0x060027D7 RID: 10199
	void OnDisarm();

	// Token: 0x060027D8 RID: 10200
	void OnFireEnd();

	// Token: 0x060027D9 RID: 10201
	void OnFiringBullet();

	// Token: 0x060027DA RID: 10202
	void OnFoldOff();

	// Token: 0x060027DB RID: 10203
	void OnFoldOn();

	// Token: 0x060027DC RID: 10204
	void OnIdleStart();

	// Token: 0x060027DD RID: 10205
	void OnLauncherAppeared();

	// Token: 0x060027DE RID: 10206
	void OnLauncherDisappeared();

	// Token: 0x060027DF RID: 10207
	void OnMagHide();

	// Token: 0x060027E0 RID: 10208
	void OnMagIn();

	// Token: 0x060027E1 RID: 10209
	void OnMagOut();

	// Token: 0x060027E2 RID: 10210
	void OnMagShow();

	// Token: 0x060027E3 RID: 10211
	void OnMessageName();

	// Token: 0x060027E4 RID: 10212
	void OnMalfunctionOff();

	// Token: 0x060027E5 RID: 10213
	void OnModChanged();

	// Token: 0x060027E6 RID: 10214
	void OnOffBoltCatch();

	// Token: 0x060027E7 RID: 10215
	void OnOnBoltCatch();

	// Token: 0x060027E8 RID: 10216
	void OnPutMagToRig();

	// Token: 0x060027E9 RID: 10217
	void OnRemoveShell();

	// Token: 0x060027EA RID: 10218
	void OnReplaceSecondMag();

	// Token: 0x060027EB RID: 10219
	void OnShellEject();

	// Token: 0x060027EC RID: 10220
	void OnShowAmmo(bool BoolParam);

	// Token: 0x060027ED RID: 10221
	void OnShowMag();

	// Token: 0x060027EE RID: 10222
	void OnSliderOut();

	// Token: 0x060027EF RID: 10223
	void OnSound(string StringParam);

	// Token: 0x060027F0 RID: 10224
	void OnSoundAtPoint(string StringParam);

	// Token: 0x060027F1 RID: 10225
	void OnStartUtilityOperation();

	// Token: 0x060027F2 RID: 10226
	void OnThirdAction(int IntParam);

	// Token: 0x060027F3 RID: 10227
	void OnUseProp(bool BoolParam);

	// Token: 0x060027F4 RID: 10228
	void OnUseSecondMagForReload();

	// Token: 0x060027F5 RID: 10229
	void OnWeapIn();

	// Token: 0x060027F6 RID: 10230
	void OnWeapOut();

	// Token: 0x060027F7 RID: 10231
	void OnBackpackDrop();

	// Token: 0x060027F8 RID: 10232
	void OnComboPlanning();

	// Token: 0x060027F9 RID: 10233
	void OnCurrentAnimStateEnded();

	// Token: 0x060027FA RID: 10234
	void OnSetActiveObject(int objectID);

	// Token: 0x060027FB RID: 10235
	void OnDeactivateObject(int objectID);
}
