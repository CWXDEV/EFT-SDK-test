using System;

// Token: 0x020022AE RID: 8878
public interface GInterface301
{
	// Token: 0x17001EAB RID: 7851
	// (get) Token: 0x0600B466 RID: 46182
	int ScopesCount { get; }

	// Token: 0x17001EAC RID: 7852
	// (get) Token: 0x0600B467 RID: 46183
	int[] ModesCount { get; }

	// Token: 0x17001EAD RID: 7853
	// (get) Token: 0x0600B468 RID: 46184
	float[][] Zooms { get; }

	// Token: 0x17001EAE RID: 7854
	// (get) Token: 0x0600B469 RID: 46185
	float[][] AimSensitivity { get; }

	// Token: 0x17001EAF RID: 7855
	// (get) Token: 0x0600B46A RID: 46186
	int[][] CalibrationDistances { get; }

	// Token: 0x17001EB0 RID: 7856
	// (get) Token: 0x0600B46B RID: 46187
	string CustomAimPlane { get; }
}
