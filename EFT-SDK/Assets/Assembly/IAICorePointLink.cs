using System;
using UnityEngine;

// Token: 0x02000212 RID: 530
public interface IAICorePointLink
{
	// Token: 0x170002BC RID: 700
	// (get) Token: 0x060009B1 RID: 2481
	AICorePoint CorePointInGame { get; }

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x060009B2 RID: 2482
	Vector3 Position { get; }
}
