using System;
using System.Collections.Generic;
using EFT.HealthSystem;
using EFT.InventoryLogic;

// Token: 0x0200227C RID: 8828
public interface GInterface290 : GInterface289
{
	// Token: 0x17001E5F RID: 7775
	// (get) Token: 0x0600B3CD RID: 46029
	float UseTime { get; }

	// Token: 0x17001E60 RID: 7776
	// (get) Token: 0x0600B3CE RID: 46030
	KeyValuePair<EBodyPart, float>[] BodyPartTimeMults { get; }

	// Token: 0x17001E61 RID: 7777
	// (get) Token: 0x0600B3CF RID: 46031
	Dictionary<EHealthFactorType, GClass1233> HealthEffects { get; }

	// Token: 0x17001E62 RID: 7778
	// (get) Token: 0x0600B3D0 RID: 46032
	Dictionary<EDamageEffectType, GClass1232> DamageEffects { get; }
}
