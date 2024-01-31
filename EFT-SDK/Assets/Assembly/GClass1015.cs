using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000DAB RID: 3499
public static class GClass1015
{
	// Token: 0x0400551F RID: 21791
	public const int MaxRenderers = 65535;

	// Token: 0x04005520 RID: 21792
	public const int SampleBatchCount = 2048;

	// Token: 0x04005521 RID: 21793
	public const int CamBakeLayer = 30;

	// Token: 0x04005522 RID: 21794
	public const bool SafetyChecks = true;

	// Token: 0x04005523 RID: 21795
	public static readonly HashSet<Type> SupportedRendererTypes;

	// Token: 0x04005524 RID: 21796
	public static Color ClearColor;

	// Token: 0x04005525 RID: 21797
	public static bool AllowSceneReload;

	// Token: 0x04005526 RID: 21798
	public static bool EFTSceneBakeMode;

	// Token: 0x04005527 RID: 21799
	public static readonly string MultiSceneTempPath;

	// Token: 0x04005528 RID: 21800
	public static readonly string ResourcesFolder;
}
