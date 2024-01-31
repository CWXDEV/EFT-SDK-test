using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002313 RID: 8979
public sealed class GClass3318 : InventoryError
{
	// Token: 0x0600B5D0 RID: 46544 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetLocalizedDescription()
	{
		throw null;
	}

	// Token: 0x0600B5D1 RID: 46545 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFullLocalizedDescription(IEnumerable<GStruct368> limitedItems)
	{
		throw null;
	}

	// Token: 0x0400B95A RID: 47450
	public const string SHORT_WARNING = "InventoryWarning/ItemsToBeDestroyed";

	// Token: 0x0400B95B RID: 47451
	private const string string_0 = "InventoryError/DiscardLimitReached{0}";

	// Token: 0x0400B95C RID: 47452
	private const string string_1 = "InventoryError/DiscardLimitForContentReached{0}";

	// Token: 0x0400B95D RID: 47453
	private const string string_2 = "InventoryError/DiscardLimitForStackReached";

	// Token: 0x0400B95E RID: 47454
	private const string string_3 = "InventoryWarning/ItemsWillBeDestroyed";

	// Token: 0x0400B95F RID: 47455
	public readonly Item Item;

	// Token: 0x0400B960 RID: 47456
	public readonly IEnumerable<GStruct368> LimitedItems;
}
