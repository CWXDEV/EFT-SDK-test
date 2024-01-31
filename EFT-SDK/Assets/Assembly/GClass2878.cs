using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.InventoryLogic;
using EFT.Quests;

// Token: 0x020025FA RID: 9722
public sealed class GClass2878 : GClass2875
{
	// Token: 0x0600C10E RID: 49422 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override void vmethod_0(Callback callback, bool requiresExternalFinalization = false)
	{
		throw null;
	}

	// Token: 0x0600C10F RID: 49423 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct411<GClass2878> FromDescriptor(GClass1568 descriptor, TraderControllerClass itemController, AbstractQuestControllerClass questController)
	{
		throw null;
	}

	// Token: 0x0600C110 RID: 49424 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass1529 ToDescriptor()
	{
		throw null;
	}

	// Token: 0x0600C111 RID: 49425 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x0400C332 RID: 49970
	private readonly ConditionItem conditionItem_0;

	// Token: 0x0400C333 RID: 49971
	private readonly Item[] item_0;

	// Token: 0x020025FB RID: 9723
	[CompilerGenerated]
	private sealed class Class2183
	{
		// Token: 0x0600C112 RID: 49426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Task<IResult> handoverTask)
		{
			throw null;
		}

		// Token: 0x0400C334 RID: 49972
		public Callback callback;

		// Token: 0x0400C335 RID: 49973
		public bool requiresExternalFinalization;

		// Token: 0x0400C336 RID: 49974
		public GClass2878 gclass2878_0;
	}

	// Token: 0x020025FC RID: 9724
	[CompilerGenerated]
	private sealed class Class2184
	{
		// Token: 0x0600C113 RID: 49427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400C337 RID: 49975
		public Task<IResult> handoverTask;

		// Token: 0x0400C338 RID: 49976
		public GClass2878.Class2183 class2183_0;
	}

	// Token: 0x020025FD RID: 9725
	[CompilerGenerated]
	private sealed class Class2185
	{
		// Token: 0x0600C114 RID: 49428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1246 q)
		{
			throw null;
		}

		// Token: 0x0600C115 RID: 49429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_1(MongoID id)
		{
			throw null;
		}

		// Token: 0x0400C339 RID: 49977
		public GClass1568 descriptor;

		// Token: 0x0400C33A RID: 49978
		public TraderControllerClass itemController;
	}

	// Token: 0x020025FE RID: 9726
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2186
	{
		// Token: 0x0600C116 RID: 49430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal MongoID method_0(Item item)
		{
			throw null;
		}

		// Token: 0x0400C33B RID: 49979
		public static readonly GClass2878.Class2186 class2186_0;

		// Token: 0x0400C33C RID: 49980
		public static Func<Item, MongoID> func_0;
	}
}
