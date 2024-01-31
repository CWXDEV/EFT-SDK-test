using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020026EA RID: 9962
public class GClass2933 : GClass2932
{
	// Token: 0x1700234D RID: 9037
	// (get) Token: 0x0600C575 RID: 50549 RVA: 0x00002050 File Offset: 0x00000250
	public virtual IEnumerable<ResourceKey> AllResources
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C576 RID: 50550 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400C755 RID: 51029
	public EBodyModelPart BodyPart;

	// Token: 0x0400C756 RID: 51030
	public ResourceKey Prefab;

	// Token: 0x0400C757 RID: 51031
	public ResourceKey WatchPrefab;

	// Token: 0x0400C758 RID: 51032
	public Vector3 WatchPosition;

	// Token: 0x0400C759 RID: 51033
	public Vector3 WatchRotation;

	// Token: 0x0400C75A RID: 51034
	public bool IntegratedArmorVest;
}
