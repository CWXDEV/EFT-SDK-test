using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;

// Token: 0x02000FD4 RID: 4052
public sealed class GClass1201 : ISerializer<GClass1200>
{
	// Token: 0x0600552D RID: 21805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1200 Deserialize()
	{
		throw null;
	}

	// Token: 0x0600552E RID: 21806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(GClass1200 t)
	{
		throw null;
	}

	// Token: 0x040060CF RID: 24783
	public string _id;

	// Token: 0x040060D0 RID: 24784
	public GClass1186[] _items;

	// Token: 0x040060D1 RID: 24785
	public string _name;

	// Token: 0x040060D2 RID: 24786
	public string _parent;

	// Token: 0x040060D3 RID: 24787
	public string _encyclopedia;

	// Token: 0x040060D4 RID: 24788
	public bool _changeWeaponName;

	// Token: 0x040060D5 RID: 24789
	public NodeType _type;

	// Token: 0x02000FD5 RID: 4053
	[CompilerGenerated]
	[Serializable]
	private sealed class Class785
	{
		// Token: 0x0600552F RID: 21807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item x)
		{
			throw null;
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(Item x)
		{
			throw null;
		}

		// Token: 0x040060D6 RID: 24790
		public static readonly GClass1201.Class785 class785_0;

		// Token: 0x040060D7 RID: 24791
		public static Func<Item, bool> func_0;

		// Token: 0x040060D8 RID: 24792
		public static Func<Item, string> func_1;
	}
}
