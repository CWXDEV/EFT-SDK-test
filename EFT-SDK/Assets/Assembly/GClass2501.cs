using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;

// Token: 0x020022D0 RID: 8912
public class GClass2501 : ISerializer<GClass2495>
{
	// Token: 0x0600B505 RID: 46341 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2495 Deserialize()
	{
		throw null;
	}

	// Token: 0x0600B506 RID: 46342 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(GClass2495 grid)
	{
		throw null;
	}

	// Token: 0x0400B8C1 RID: 47297
	public string _name;

	// Token: 0x0400B8C2 RID: 47298
	public GClass2501.GClass2502 _props;

	// Token: 0x020022D1 RID: 8913
	public class GClass2502
	{
		// Token: 0x0400B8C3 RID: 47299
		public int cellsH;

		// Token: 0x0400B8C4 RID: 47300
		public int cellsV;

		// Token: 0x0400B8C5 RID: 47301
		public int maxCount;

		// Token: 0x0400B8C6 RID: 47302
		public int maxWeight;

		// Token: 0x0400B8C7 RID: 47303
		public ItemFilter[] filters;
	}
}
