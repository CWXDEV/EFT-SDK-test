using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002315 RID: 8981
public sealed class GClass3320 : InventoryError
{
	// Token: 0x0600B5D3 RID: 46547 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0600B5D4 RID: 46548 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetLocalizedDescription()
	{
		throw null;
	}

	// Token: 0x0400B963 RID: 47459
	public readonly Item Item;

	// Token: 0x0400B964 RID: 47460
	public readonly StackSlot StackSlot;

	// Token: 0x02002316 RID: 8982
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1993
	{
		// Token: 0x0600B5D5 RID: 46549 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<string> method_0(ItemFilter x)
		{
			throw null;
		}

		// Token: 0x0600B5D6 RID: 46550 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(string x)
		{
			throw null;
		}

		// Token: 0x0400B965 RID: 47461
		public static readonly GClass3320.Class1993 class1993_0;

		// Token: 0x0400B966 RID: 47462
		public static Func<ItemFilter, IEnumerable<string>> func_0;

		// Token: 0x0400B967 RID: 47463
		public static Func<string, string> func_1;
	}
}
