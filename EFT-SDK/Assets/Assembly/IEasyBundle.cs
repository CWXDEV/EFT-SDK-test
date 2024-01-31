using System;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02003112 RID: 12562
public interface IEasyBundle : GInterface395
{
	// Token: 0x17002A56 RID: 10838
	// (get) Token: 0x0600F658 RID: 63064
	[CanBeNull]
	UnityEngine.Object[] Assets { get; }

	// Token: 0x17002A57 RID: 10839
	// (get) Token: 0x0600F659 RID: 63065
	[CanBeNull]
	UnityEngine.Object SameNameAsset { get; }
}
