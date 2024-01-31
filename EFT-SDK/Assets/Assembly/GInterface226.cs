using System;
using EFT;

// Token: 0x0200218A RID: 8586
public interface GInterface226 : GInterface225
{
	// Token: 0x17001D98 RID: 7576
	// (get) Token: 0x0600B10E RID: 45326
	bool Active { get; }

	// Token: 0x17001D99 RID: 7577
	// (get) Token: 0x0600B10F RID: 45327
	float Value { get; }

	// Token: 0x17001D9A RID: 7578
	// (get) Token: 0x0600B110 RID: 45328
	GClass2420.GClass2445.GClass2446 Settings { get; }

	// Token: 0x17001D9B RID: 7579
	// (get) Token: 0x0600B111 RID: 45329
	EBodyPart BodyPart { get; }

	// Token: 0x17001D9C RID: 7580
	// (get) Token: 0x0600B112 RID: 45330
	Type BuffType { get; }

	// Token: 0x17001D9D RID: 7581
	// (get) Token: 0x0600B113 RID: 45331
	string BuffName { get; }

	// Token: 0x17001D9E RID: 7582
	// (get) Token: 0x0600B114 RID: 45332
	// (set) Token: 0x0600B115 RID: 45333
	float WholeTime { get; set; }

	// Token: 0x0600B116 RID: 45334
	void IncreaseBySameBuff(float curStimulatorTime, float strength, SkillManager skills);
}
