using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;

// Token: 0x0200230E RID: 8974
public class GClass2508 : ISerializer<Slot>
{
	// Token: 0x0600B5B3 RID: 46515 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Slot Deserialize()
	{
		throw null;
	}

	// Token: 0x0600B5B4 RID: 46516 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(Slot t)
	{
		throw null;
	}

	// Token: 0x0400B949 RID: 47433
	private const string string_0 = "64479fdf9731c8fadc0642c1";

	// Token: 0x0400B94A RID: 47434
	public string _name;

	// Token: 0x0400B94B RID: 47435
	public bool _required;

	// Token: 0x0400B94C RID: 47436
	public GClass2508.GClass2509 _props;

	// Token: 0x0400B94D RID: 47437
	public bool _mergeSlotWithChildren;

	// Token: 0x0400B94E RID: 47438
	public string _proto;

	// Token: 0x0200230F RID: 8975
	public class GClass2509
	{
		// Token: 0x0400B94F RID: 47439
		public ItemFilter[] filters;
	}
}
