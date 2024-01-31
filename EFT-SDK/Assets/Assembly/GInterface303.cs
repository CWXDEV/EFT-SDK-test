using System;
using EFT.InventoryLogic;

// Token: 0x020022B4 RID: 8884
public interface GInterface303
{
	// Token: 0x17001EBC RID: 7868
	// (get) Token: 0x0600B487 RID: 46215
	ThermalVisionComponent.SelectablePalette RampPalette { get; }

	// Token: 0x17001EBD RID: 7869
	// (get) Token: 0x0600B488 RID: 46216
	float DepthFade { get; }

	// Token: 0x17001EBE RID: 7870
	// (get) Token: 0x0600B489 RID: 46217
	float MainTexColorCoef { get; }

	// Token: 0x17001EBF RID: 7871
	// (get) Token: 0x0600B48A RID: 46218
	float MinimumTemperatureValue { get; }

	// Token: 0x17001EC0 RID: 7872
	// (get) Token: 0x0600B48B RID: 46219
	float RampShift { get; }

	// Token: 0x17001EC1 RID: 7873
	// (get) Token: 0x0600B48C RID: 46220
	float HeatMin { get; }

	// Token: 0x17001EC2 RID: 7874
	// (get) Token: 0x0600B48D RID: 46221
	float ColdMax { get; }

	// Token: 0x17001EC3 RID: 7875
	// (get) Token: 0x0600B48E RID: 46222
	bool IsNoisy { get; }

	// Token: 0x17001EC4 RID: 7876
	// (get) Token: 0x0600B48F RID: 46223
	float NoiseInstensity { get; }

	// Token: 0x17001EC5 RID: 7877
	// (get) Token: 0x0600B490 RID: 46224
	bool IsFpsStuck { get; }

	// Token: 0x17001EC6 RID: 7878
	// (get) Token: 0x0600B491 RID: 46225
	bool IsGlitch { get; }

	// Token: 0x17001EC7 RID: 7879
	// (get) Token: 0x0600B492 RID: 46226
	bool IsMotionBlurred { get; }

	// Token: 0x17001EC8 RID: 7880
	// (get) Token: 0x0600B493 RID: 46227
	NightVisionComponent.EMask Mask { get; }

	// Token: 0x17001EC9 RID: 7881
	// (get) Token: 0x0600B494 RID: 46228
	float MaskSize { get; }

	// Token: 0x17001ECA RID: 7882
	// (get) Token: 0x0600B495 RID: 46229
	bool IsPixelated { get; }

	// Token: 0x17001ECB RID: 7883
	// (get) Token: 0x0600B496 RID: 46230
	int PixelationBlockCount { get; }
}
