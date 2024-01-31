using System;

// Token: 0x02000304 RID: 772
public class WeaponAIPreset
{
	// Token: 0x04000F93 RID: 3987
	public float BaseShift;

	// Token: 0x04000F94 RID: 3988
	public float XZ_COEF;

	// Token: 0x04000F95 RID: 3989
	public Func<float> TriggerDownTime;

	// Token: 0x04000F96 RID: 3990
	public Func<float> HoldTriggerUpTime;

	// Token: 0x04000F97 RID: 3991
	public EWeaponAIPresetType WeaponAIPresetType;
}
