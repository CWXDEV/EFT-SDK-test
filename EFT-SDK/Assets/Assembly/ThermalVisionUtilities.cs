using System;
using System.Collections.Generic;
using EFT.InventoryLogic;

// Token: 0x02000B2F RID: 2863
[Serializable]
public class ThermalVisionUtilities
{
	// Token: 0x04004509 RID: 17673
	public ThermalVisionComponent.SelectablePalette CurrentRampPalette;

	// Token: 0x0400450A RID: 17674
	public float DepthFade;

	// Token: 0x0400450B RID: 17675
	public List<RampTexPalletteConnector> RampTexPalletteConnectors;

	// Token: 0x0400450C RID: 17676
	public ValuesCoefs ValuesCoefs;

	// Token: 0x0400450D RID: 17677
	public Noise NoiseParameters;

	// Token: 0x0400450E RID: 17678
	public MaskDescription MaskDescription;
}
