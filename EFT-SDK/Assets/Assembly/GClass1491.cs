using System;
using System.Collections.Generic;

// Token: 0x02001344 RID: 4932
public sealed class GClass1491
{
	// Token: 0x04007202 RID: 29186
	public byte Malfunction;

	// Token: 0x04007203 RID: 29187
	public float LastShotOverheat;

	// Token: 0x04007204 RID: 29188
	public float LastShotTime;

	// Token: 0x04007205 RID: 29189
	public bool SlideOnOverheatReached;

	// Token: 0x04007206 RID: 29190
	public List<string> PlayersWhoKnowAboutMalfunction;

	// Token: 0x04007207 RID: 29191
	public List<string> PlayersWhoKnowMalfType;

	// Token: 0x04007208 RID: 29192
	public Dictionary<string, byte> PlayersReducedMalfChances;

	// Token: 0x04007209 RID: 29193
	public string AmmoToFireTemplateId;

	// Token: 0x0400720A RID: 29194
	public string AmmoWillBeLoadedToChamberTemplateId;

	// Token: 0x0400720B RID: 29195
	public string AmmoMalfunctionedTemplateId;
}
