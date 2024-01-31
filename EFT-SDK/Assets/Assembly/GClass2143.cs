using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using EFT.InventoryLogic;
using UnityEngine.Networking;

// Token: 0x02001E4A RID: 7754
public class GClass2143
{
	// Token: 0x06009EF8 RID: 40696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ParseAirdropContainerData(byte[] data)
	{
		throw null;
	}

	// Token: 0x06009EF9 RID: 40697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<Item> method_0(NetworkReader reader)
	{
		throw null;
	}

	// Token: 0x02001E4C RID: 7756
	[CompilerGenerated]
	private sealed class Class1804
	{
		// Token: 0x06009EFC RID: 40700 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_0()
		{
			throw null;
		}

		// Token: 0x0400A782 RID: 42882
		public NetworkReader reader;
	}

	// Token: 0x02001E4D RID: 7757
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1805
	{
		// Token: 0x06009EFD RID: 40701 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_0(LootItemPositionClass x)
		{
			throw null;
		}

		// Token: 0x06009EFE RID: 40702 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_1(LootItemPositionClass x)
		{
			throw null;
		}

		// Token: 0x06009EFF RID: 40703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(Item x)
		{
			throw null;
		}

		// Token: 0x06009F00 RID: 40704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ResourceKey> method_3(Item x)
		{
			throw null;
		}

		// Token: 0x06009F01 RID: 40705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ResourceKey> method_4(Item x)
		{
			throw null;
		}

		// Token: 0x0400A783 RID: 42883
		public static readonly GClass2143.Class1805 class1805_0;

		// Token: 0x0400A784 RID: 42884
		public static Func<LootItemPositionClass, Item> func_0;

		// Token: 0x0400A785 RID: 42885
		public static Func<LootItemPositionClass, Item> func_1;

		// Token: 0x0400A786 RID: 42886
		public static Func<Item, bool> func_2;

		// Token: 0x0400A787 RID: 42887
		public static Func<Item, IEnumerable<ResourceKey>> func_3;

		// Token: 0x0400A788 RID: 42888
		public static Func<Item, IEnumerable<ResourceKey>> func_4;
	}
}
