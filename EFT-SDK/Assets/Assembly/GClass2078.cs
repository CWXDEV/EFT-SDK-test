using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Trading;

// Token: 0x02001D77 RID: 7543
public abstract class GClass2078 : GClass2069
{
	// Token: 0x17001859 RID: 6233
	// (get) Token: 0x06009B8C RID: 39820
	protected abstract IReadOnlyList<string> GoBackLines { get; }

	// Token: 0x140001DB RID: 475
	// (add) Token: 0x06009B8D RID: 39821 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009B8E RID: 39822 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GStruct243, EServiceActionType, DialogDataStruct, IEnumerable<MongoID>, bool> OnExecute
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1700185A RID: 6234
	// (get) Token: 0x06009B8F RID: 39823 RVA: 0x00002050 File Offset: 0x00000250
	public override ETraderDialogType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700185B RID: 6235
	// (get) Token: 0x06009B90 RID: 39824 RVA: 0x00002050 File Offset: 0x00000250
	protected override string BaseDescriptionKey
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009B91 RID: 39825
	protected abstract GClass2053 GetAcceptServiceLine(GClass1791 dialogContextServiceAvailabilityData, string dialogContextSelectedSubServiceId, InventoryControllerClass inventoryController, AbstractQuestControllerClass questController);

	// Token: 0x06009B92 RID: 39826 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InitLine(GClass2053 line)
	{
		throw null;
	}

	// Token: 0x06009B93 RID: 39827 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_6(GStruct244 dialogContext)
	{
		throw null;
	}

	// Token: 0x06009B94 RID: 39828 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(GStruct243 data, EServiceActionType result, DialogDataStruct lineConstructor, IEnumerable<MongoID> hanoverItems, bool anyItemReward)
	{
		throw null;
	}

	// Token: 0x0400A2E1 RID: 41697
	private readonly InventoryControllerClass gclass2757_0;

	// Token: 0x0400A2E2 RID: 41698
	private readonly AbstractQuestControllerClass gclass3203_0;

	// Token: 0x0400A2E3 RID: 41699
	[CompilerGenerated]
	private Action<GStruct243, EServiceActionType, DialogDataStruct, IEnumerable<MongoID>, bool> action_4;

	// Token: 0x0400A2E4 RID: 41700
	[CompilerGenerated]
	private readonly string string_1;

	// Token: 0x02001D78 RID: 7544
	[CompilerGenerated]
	private sealed class Class1755
	{
		// Token: 0x06009B95 RID: 39829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400A2E5 RID: 41701
		public GClass2056 acceptServiceLine;

		// Token: 0x0400A2E6 RID: 41702
		public GClass2078 gclass2078_0;

		// Token: 0x0400A2E7 RID: 41703
		public GClass2053 line;
	}
}
