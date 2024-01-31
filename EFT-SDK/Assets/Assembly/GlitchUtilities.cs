using System;
using UnityEngine;

// Token: 0x02000B24 RID: 2852
[Serializable]
public class GlitchUtilities
{
	// Token: 0x04004481 RID: 17537
	public Shader Shader;

	// Token: 0x04004482 RID: 17538
	public Texture2D DisplacementMap;

	// Token: 0x04004483 RID: 17539
	[Header("Digital Mistake")]
	[Range(0f, 1f)]
	public float DigitalMistakeIntensity;

	// Token: 0x04004484 RID: 17540
	[Range(0f, 1f)]
	public float DigitalMistakeFrequency;

	// Token: 0x04004485 RID: 17541
	[Header("Vertical Flip")]
	[Range(0f, 1f)]
	public float VerticalFlipIntensity;

	// Token: 0x04004486 RID: 17542
	[Range(0f, 1f)]
	public float VerticalFlipFrequency;

	// Token: 0x04004487 RID: 17543
	[Header("Color Switch")]
	[Range(0f, 1f)]
	public float ColorSwitchIntensity;

	// Token: 0x04004488 RID: 17544
	[Range(0f, 1f)]
	public float ColorSwitchFrequency;

	// Token: 0x04004489 RID: 17545
	[Header("Vertical Jump")]
	[Range(0f, 1f)]
	public float VerticalJumpCoef;

	// Token: 0x0400448A RID: 17546
	[Range(0f, 1f)]
	public float VerticalJumpFrequency;

	// Token: 0x0400448B RID: 17547
	public float VerticalJumpTimeScale;

	// Token: 0x0400448C RID: 17548
	[Header("Scan Line Jitter")]
	[Range(0f, 1f)]
	public float ScanLineJitterCoef;

	// Token: 0x0400448D RID: 17549
	[Range(0f, 1f)]
	public float ScanLineJitterFrequency;

	// Token: 0x0400448E RID: 17550
	[Header("Horizontal Shake")]
	[Range(0f, 1f)]
	public float HorizontalShake;

	// Token: 0x0400448F RID: 17551
	[Range(0f, 1f)]
	public float HorizontalShakeFrequency;

	// Token: 0x04004490 RID: 17552
	[Header("Color Drift")]
	[Range(0f, 1f)]
	public float ColorDriftCoef;

	// Token: 0x04004491 RID: 17553
	[Range(0f, 1f)]
	public float ColorDriftFrequency;

	// Token: 0x04004492 RID: 17554
	public float MaxColorDrift;
}
