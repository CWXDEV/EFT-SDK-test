using System;
using Diz.Binding;
using UnityEngine;

// Token: 0x02000969 RID: 2409
public interface GInterface35
{
	// Token: 0x17000950 RID: 2384
	// (get) Token: 0x06003674 RID: 13940
	int Hash { get; }

	// Token: 0x17000951 RID: 2385
	// (get) Token: 0x06003676 RID: 13942
	// (set) Token: 0x06003675 RID: 13941
	Sprite Sprite { get; set; }

	// Token: 0x17000952 RID: 2386
	// (get) Token: 0x06003677 RID: 13943
	BindableEvent Changed { get; }
}
