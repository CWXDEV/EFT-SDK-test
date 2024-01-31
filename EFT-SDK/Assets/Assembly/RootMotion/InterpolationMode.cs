using System;

namespace RootMotion
{
	// Token: 0x02001072 RID: 4210
	[Serializable]
	public enum InterpolationMode
	{
		// Token: 0x04006389 RID: 25481
		None,
		// Token: 0x0400638A RID: 25482
		InOutCubic,
		// Token: 0x0400638B RID: 25483
		InOutQuintic,
		// Token: 0x0400638C RID: 25484
		InOutSine,
		// Token: 0x0400638D RID: 25485
		InQuintic,
		// Token: 0x0400638E RID: 25486
		InQuartic,
		// Token: 0x0400638F RID: 25487
		InCubic,
		// Token: 0x04006390 RID: 25488
		InQuadratic,
		// Token: 0x04006391 RID: 25489
		InElastic,
		// Token: 0x04006392 RID: 25490
		InElasticSmall,
		// Token: 0x04006393 RID: 25491
		InElasticBig,
		// Token: 0x04006394 RID: 25492
		InSine,
		// Token: 0x04006395 RID: 25493
		InBack,
		// Token: 0x04006396 RID: 25494
		OutQuintic,
		// Token: 0x04006397 RID: 25495
		OutQuartic,
		// Token: 0x04006398 RID: 25496
		OutCubic,
		// Token: 0x04006399 RID: 25497
		OutInCubic,
		// Token: 0x0400639A RID: 25498
		OutInQuartic,
		// Token: 0x0400639B RID: 25499
		OutElastic,
		// Token: 0x0400639C RID: 25500
		OutElasticSmall,
		// Token: 0x0400639D RID: 25501
		OutElasticBig,
		// Token: 0x0400639E RID: 25502
		OutSine,
		// Token: 0x0400639F RID: 25503
		OutBack,
		// Token: 0x040063A0 RID: 25504
		OutBackCubic,
		// Token: 0x040063A1 RID: 25505
		OutBackQuartic,
		// Token: 0x040063A2 RID: 25506
		BackInCubic,
		// Token: 0x040063A3 RID: 25507
		BackInQuartic
	}
}
