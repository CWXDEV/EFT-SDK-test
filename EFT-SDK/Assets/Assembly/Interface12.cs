using System;
using UnityEngine;

// Token: 0x02001DC3 RID: 7619
internal interface Interface12 : IDisposable
{
	// Token: 0x170018A2 RID: 6306
	// (get) Token: 0x06009CDC RID: 40156
	Camera Camera { get; }

	// Token: 0x06009CDD RID: 40157
	void OnPreCull();
}
