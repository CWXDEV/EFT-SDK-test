using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x020025A6 RID: 9638
public abstract class GClass2834 : GClass2833
{
	// Token: 0x17002241 RID: 8769
	// (get) Token: 0x0600C02C RID: 49196
	public abstract Item Item { get; }

	// Token: 0x17002242 RID: 8770
	// (get) Token: 0x0600C02D RID: 49197
	public abstract bool DestroysMainItem { get; }

	// Token: 0x17002243 RID: 8771
	// (get) Token: 0x0600C02E RID: 49198 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	public IEnumerable<GStruct368> DestroyedItems
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400C224 RID: 49700
	[CompilerGenerated]
	private readonly IEnumerable<GStruct368> ienumerable_0;
}
