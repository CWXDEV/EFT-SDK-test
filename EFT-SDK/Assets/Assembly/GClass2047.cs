using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using EFT.Counters;
using EFT.Quests;
using EFT.Trading;

// Token: 0x02001D30 RID: 7472
public sealed class GClass2047 : IDisposable, GInterface180
{
	// Token: 0x17001811 RID: 6161
	// (get) Token: 0x06009AAF RID: 39599 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009AB0 RID: 39600 RVA: 0x00002050 File Offset: 0x00000250
	public string InitialDescriptionKey
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06009AB1 RID: 39601 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06009AB2 RID: 39602 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GClass2908 firedEvent)
	{
		throw null;
	}

	// Token: 0x06009AB3 RID: 39603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveDialogState(CounterTag tag, int value)
	{
		throw null;
	}

	// Token: 0x06009AB4 RID: 39604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnGreetingsComplete(string initialDescriptionKey)
	{
		throw null;
	}

	// Token: 0x06009AB5 RID: 39605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> ExecuteDialogOption(GStruct243 dialogData)
	{
		throw null;
	}

	// Token: 0x06009AB6 RID: 39606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> ExecuteQuestAction(GStruct243 dialogData, EQuestActionType actionType, GClass1246 completedQuest, ConditionItem condition)
	{
		throw null;
	}

	// Token: 0x06009AB7 RID: 39607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> ExecuteServiceAction(GStruct243 dialogData, IEnumerable<MongoID> handoverItems, bool anyReward)
	{
		throw null;
	}

	// Token: 0x06009AB8 RID: 39608 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass2910.EDialogState method_1(ConditionItem conditionItem)
	{
		throw null;
	}

	// Token: 0x06009AB9 RID: 39609 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass2910.EDialogState method_2(GClass1246 completedQuest)
	{
		throw null;
	}

	// Token: 0x06009ABA RID: 39610 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass2910.EDialogState method_3(IEnumerable<MongoID> rewards)
	{
		throw null;
	}

	// Token: 0x06009ABB RID: 39611 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GClass2908 firedEvent)
	{
		throw null;
	}

	// Token: 0x0400A1D4 RID: 41428
	private Dictionary<string, GClass2910.EDialogState> dictionary_0;

	// Token: 0x0400A1D5 RID: 41429
	private Profile.TraderInfo traderInfo_0;

	// Token: 0x0400A1D6 RID: 41430
	private AbstractQuestControllerClass gclass3203_0;

	// Token: 0x0400A1D7 RID: 41431
	private bool bool_0;

	// Token: 0x0400A1D8 RID: 41432
	private string string_0;

	// Token: 0x0400A1D9 RID: 41433
	private Action action_0;

	// Token: 0x0400A1DA RID: 41434
	[CompilerGenerated]
	private string string_1;

	// Token: 0x02001D31 RID: 7473
	[CompilerGenerated]
	private sealed class Class1747
	{
		// Token: 0x06009ABC RID: 39612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(string dialogDescriptionKey)
		{
			throw null;
		}

		// Token: 0x06009ABD RID: 39613 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(string s)
		{
			throw null;
		}

		// Token: 0x06009ABE RID: 39614 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(string s)
		{
			throw null;
		}

		// Token: 0x0400A1DB RID: 41435
		public bool waitForReaction;

		// Token: 0x0400A1DC RID: 41436
		public string descriptionKey;
	}

	// Token: 0x02001D33 RID: 7475
	[CompilerGenerated]
	private sealed class Class1748
	{
		// Token: 0x06009AC1 RID: 39617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(string s)
		{
			throw null;
		}

		// Token: 0x06009AC2 RID: 39618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(string s)
		{
			throw null;
		}

		// Token: 0x06009AC3 RID: 39619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(string s)
		{
			throw null;
		}

		// Token: 0x06009AC4 RID: 39620 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(string ss)
		{
			throw null;
		}

		// Token: 0x0400A1E4 RID: 41444
		public bool waitForReaction;

		// Token: 0x0400A1E5 RID: 41445
		public string descriptionKey;

		// Token: 0x0400A1E6 RID: 41446
		public Action<string> action_0;
	}

	// Token: 0x02001D35 RID: 7477
	[CompilerGenerated]
	private sealed class Class1749
	{
		// Token: 0x06009AC7 RID: 39623 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(string _)
		{
			throw null;
		}

		// Token: 0x06009AC8 RID: 39624 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(string s)
		{
			throw null;
		}

		// Token: 0x06009AC9 RID: 39625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(string ss)
		{
			throw null;
		}

		// Token: 0x0400A1EF RID: 41455
		public bool anyReward;

		// Token: 0x0400A1F0 RID: 41456
		public string descriptionKey;

		// Token: 0x0400A1F1 RID: 41457
		public bool waitForReaction;

		// Token: 0x0400A1F2 RID: 41458
		public Action<string> action_0;

		// Token: 0x0400A1F3 RID: 41459
		public Action<string> action_1;
	}
}
