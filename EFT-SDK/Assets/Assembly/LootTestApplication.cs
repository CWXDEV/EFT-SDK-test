using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using EFT.InventoryLogic;

// Token: 0x02000876 RID: 2166
public class LootTestApplication : ClientApplication<BackendDummyClass.GClass1828>
{
	// Token: 0x06003114 RID: 12564 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Task Start()
	{
		throw null;
	}

	// Token: 0x06003115 RID: 12565 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[DebuggerHidden]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_1()
	{
		throw null;
	}

	// Token: 0x02000877 RID: 2167
	[CompilerGenerated]
	[Serializable]
	private sealed class Class443
	{
		// Token: 0x06003116 RID: 12566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<string, ItemTemplate> x)
		{
			throw null;
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_2(ResourceKey x)
		{
			throw null;
		}

		// Token: 0x040031DE RID: 12766
		public static readonly LootTestApplication.Class443 class443_0;

		// Token: 0x040031DF RID: 12767
		public static Func<KeyValuePair<string, ItemTemplate>, bool> func_0;

		// Token: 0x040031E0 RID: 12768
		public static Func<KeyValuePair<string, ItemTemplate>, IEnumerable<ResourceKey>> func_1;

		// Token: 0x040031E1 RID: 12769
		public static Func<ResourceKey, string> func_2;
	}
}
