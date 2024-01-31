using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;

// Token: 0x02002311 RID: 8977
public class GClass2510 : ISerializer<StackSlot>
{
	// Token: 0x0600B5CE RID: 46542 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StackSlot Deserialize()
	{
		throw null;
	}

	// Token: 0x0600B5CF RID: 46543 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(StackSlot t)
	{
		throw null;
	}

	// Token: 0x0400B956 RID: 47446
	public string _name;

	// Token: 0x0400B957 RID: 47447
	public int _max_count;

	// Token: 0x0400B958 RID: 47448
	public GClass2510.GClass2511 _props;

	// Token: 0x02002312 RID: 8978
	public class GClass2511
	{
		// Token: 0x0400B959 RID: 47449
		public ItemFilter[] filters;
	}
}
