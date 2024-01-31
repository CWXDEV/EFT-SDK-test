using System;
using EFT;
using UnityEngine;

// Token: 0x02000534 RID: 1332
public interface GInterface11
{
	// Token: 0x170005DF RID: 1503
	// (get) Token: 0x0600205B RID: 8283
	Vector3 Position { get; }

	// Token: 0x170005E0 RID: 1504
	// (get) Token: 0x0600205C RID: 8284
	bool HaveLookSide { get; }

	// Token: 0x170005E1 RID: 1505
	// (get) Token: 0x0600205D RID: 8285
	int LookIndexes { get; }

	// Token: 0x0600205E RID: 8286
	Vector3 LookDir(int index);

	// Token: 0x0600205F RID: 8287
	void SetOwner(BotOwner owner);

	// Token: 0x06002060 RID: 8288
	int GetOwnerId();
}
