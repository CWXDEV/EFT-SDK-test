using System;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200229E RID: 8862
public interface GInterface298
{
	// Token: 0x17001E92 RID: 7826
	// (get) Token: 0x0600B42C RID: 46124
	float Intensity { get; }

	// Token: 0x17001E93 RID: 7827
	// (get) Token: 0x0600B42D RID: 46125
	NightVisionComponent.EMask Mask { get; }

	// Token: 0x17001E94 RID: 7828
	// (get) Token: 0x0600B42E RID: 46126
	float MaskSize { get; }

	// Token: 0x17001E95 RID: 7829
	// (get) Token: 0x0600B42F RID: 46127
	float NoiseIntensity { get; }

	// Token: 0x17001E96 RID: 7830
	// (get) Token: 0x0600B430 RID: 46128
	float NoiseScale { get; }

	// Token: 0x17001E97 RID: 7831
	// (get) Token: 0x0600B431 RID: 46129
	Color32 Color { get; }

	// Token: 0x17001E98 RID: 7832
	// (get) Token: 0x0600B432 RID: 46130
	float DiffuseIntensity { get; }
}
