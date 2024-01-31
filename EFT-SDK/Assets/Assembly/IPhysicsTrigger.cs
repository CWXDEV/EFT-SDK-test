using System;
using UnityEngine;

// Token: 0x020006AA RID: 1706
public interface IPhysicsTrigger
{
	// Token: 0x060026A7 RID: 9895
	void OnTriggerEnter(Collider collider);

	// Token: 0x060026A8 RID: 9896
	void OnTriggerExit(Collider collider);

	// Token: 0x170006F6 RID: 1782
	// (get) Token: 0x060026A9 RID: 9897
	// (set) Token: 0x060026AA RID: 9898
	bool enabled { get; set; }

	// Token: 0x170006F7 RID: 1783
	// (get) Token: 0x060026AB RID: 9899
	string Description { get; }
}
