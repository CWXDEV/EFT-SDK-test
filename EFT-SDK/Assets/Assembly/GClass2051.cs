using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using EFT.Counters;
using EFT.Quests;
using EFT.Trading;
using EFT.UI;

// Token: 0x02001D48 RID: 7496
public sealed class GClass2051 : GInterface180
{
	// Token: 0x140001D4 RID: 468
	// (add) Token: 0x06009AF5 RID: 39669 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009AF6 RID: 39670 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnQuit
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

	// Token: 0x17001814 RID: 6164
	// (get) Token: 0x06009AF7 RID: 39671 RVA: 0x00002050 File Offset: 0x00000250
	string GInterface180.InitialDescriptionKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009AF8 RID: 39672 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDialogScreen(Profile profile, AbstractQuestControllerClass questController, InventoryControllerClass inventoryController, string traderId)
	{
		throw null;
	}

	// Token: 0x06009AF9 RID: 39673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> ExecuteDialogOption(GStruct243 dialogData)
	{
		throw null;
	}

	// Token: 0x06009AFA RID: 39674 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> ExecuteQuestAction(GStruct243 dialogData, EQuestActionType actionType, GClass1246 completedQuest, ConditionItem condition)
	{
		throw null;
	}

	// Token: 0x06009AFB RID: 39675 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> ExecuteServiceAction(GStruct243 dialogData, IEnumerable<MongoID> handoverItems, bool anyReward)
	{
		throw null;
	}

	// Token: 0x06009AFC RID: 39676 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0(GStruct243 dialogData)
	{
		throw null;
	}

	// Token: 0x06009AFD RID: 39677 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveDialogState(CounterTag tag, int value)
	{
		throw null;
	}

	// Token: 0x0400A255 RID: 41557
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400A256 RID: 41558
	private Profile profile_0;

	// Token: 0x02001D49 RID: 7497
	[CompilerGenerated]
	private sealed class Class1752
	{
		// Token: 0x06009AFE RID: 39678 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400A257 RID: 41559
		public GClass2051 controller;

		// Token: 0x0400A258 RID: 41560
		public TraderDialogScreen.GClass3132 dialogController;
	}
}
