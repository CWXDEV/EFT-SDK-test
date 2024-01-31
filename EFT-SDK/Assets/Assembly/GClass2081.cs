using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Quests;
using EFT.Trading;

// Token: 0x02001D7C RID: 7548
public abstract class GClass2081 : GClass2069
{
	// Token: 0x140001DC RID: 476
	// (add) Token: 0x06009B9D RID: 39837 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009B9E RID: 39838 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GStruct243, EQuestActionType, GClass1246, ConditionItem, DialogDataStruct> OnExecuteQuest
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

	// Token: 0x06009B9F RID: 39839 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InitLine(GClass2053 line)
	{
		throw null;
	}

	// Token: 0x06009BA0 RID: 39840 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(GStruct243 data, EQuestActionType result, GClass1246 quest, ConditionItem condition, DialogDataStruct lineConstructor)
	{
		throw null;
	}

	// Token: 0x0400A2F2 RID: 41714
	[CompilerGenerated]
	private Action<GStruct243, EQuestActionType, GClass1246, ConditionItem, DialogDataStruct> action_4;

	// Token: 0x0400A2F3 RID: 41715
	protected readonly Profile.TraderInfo traderInfo_0;

	// Token: 0x0400A2F4 RID: 41716
	protected readonly AbstractQuestControllerClass gclass3203_0;

	// Token: 0x02001D7D RID: 7549
	[CompilerGenerated]
	private sealed class Class1757
	{
		// Token: 0x06009BA1 RID: 39841 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400A2F5 RID: 41717
		public GClass2059 questLine;

		// Token: 0x0400A2F6 RID: 41718
		public GClass2081 gclass2081_0;

		// Token: 0x0400A2F7 RID: 41719
		public GClass2053 line;
	}
}
