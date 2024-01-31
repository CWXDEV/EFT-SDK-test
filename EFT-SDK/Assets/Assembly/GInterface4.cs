using System;
using UnityEngine;

// Token: 0x02000213 RID: 531
public interface GInterface4
{
	// Token: 0x170002BE RID: 702
	// (get) Token: 0x060009B3 RID: 2483
	Vector3 Position { get; }

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x060009B4 RID: 2484
	int Id { get; }

	// Token: 0x060009B5 RID: 2485
	void AddWay(int id, GInterface4 wayTo);

	// Token: 0x060009B6 RID: 2486
	void ClearConnections();
}
