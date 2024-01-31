using System;
using UnityEngine;

// Token: 0x0200228B RID: 8843
public interface GInterface292
{
	// Token: 0x17001E6D RID: 7789
	// (get) Token: 0x0600B3EB RID: 46059
	float KnifeHitDelay { get; }

	// Token: 0x17001E6E RID: 7790
	// (get) Token: 0x0600B3EC RID: 46060
	float KnifeHitSlashRate { get; }

	// Token: 0x17001E6F RID: 7791
	// (get) Token: 0x0600B3ED RID: 46061
	float KnifeHitStabRate { get; }

	// Token: 0x17001E70 RID: 7792
	// (get) Token: 0x0600B3EE RID: 46062
	float KnifeHitRadius { get; }

	// Token: 0x17001E71 RID: 7793
	// (get) Token: 0x0600B3EF RID: 46063
	int KnifeHitSlashDam { get; }

	// Token: 0x17001E72 RID: 7794
	// (get) Token: 0x0600B3F0 RID: 46064
	int KnifeHitStabDam { get; }

	// Token: 0x17001E73 RID: 7795
	// (get) Token: 0x0600B3F1 RID: 46065
	float PrimaryDistance { get; }

	// Token: 0x17001E74 RID: 7796
	// (get) Token: 0x0600B3F2 RID: 46066
	float SecondaryDistance { get; }

	// Token: 0x17001E75 RID: 7797
	// (get) Token: 0x0600B3F3 RID: 46067
	int StabPenetration { get; }

	// Token: 0x17001E76 RID: 7798
	// (get) Token: 0x0600B3F4 RID: 46068
	int SlashPenetration { get; }

	// Token: 0x17001E77 RID: 7799
	// (get) Token: 0x0600B3F5 RID: 46069
	float PrimaryConsumption { get; }

	// Token: 0x17001E78 RID: 7800
	// (get) Token: 0x0600B3F6 RID: 46070
	float SecondaryConsumption { get; }

	// Token: 0x17001E79 RID: 7801
	// (get) Token: 0x0600B3F7 RID: 46071
	float DeflectionConsumption { get; }

	// Token: 0x17001E7A RID: 7802
	// (get) Token: 0x0600B3F8 RID: 46072
	Vector2 AppliedTrunkRotation { get; }

	// Token: 0x17001E7B RID: 7803
	// (get) Token: 0x0600B3F9 RID: 46073
	Vector2 AppliedHeadRotation { get; }

	// Token: 0x17001E7C RID: 7804
	// (get) Token: 0x0600B3FA RID: 46074
	bool DisplayOnModel { get; }

	// Token: 0x17001E7D RID: 7805
	// (get) Token: 0x0600B3FB RID: 46075
	int AdditionalAnimationLayer { get; }

	// Token: 0x17001E7E RID: 7806
	// (get) Token: 0x0600B3FC RID: 46076
	float StaminaBurnRate { get; }

	// Token: 0x17001E7F RID: 7807
	// (get) Token: 0x0600B3FD RID: 46077
	Vector3 ColliderScaleMultiplier { get; }
}
