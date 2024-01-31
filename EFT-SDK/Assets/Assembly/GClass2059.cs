using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Counters;
using EFT.Quests;
using EFT.Trading;

// Token: 0x02001D62 RID: 7522
public abstract class GClass2059 : GClass2053
{
	// Token: 0x140001D7 RID: 471
	// (add) Token: 0x06009B50 RID: 39760 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009B51 RID: 39761 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17001839 RID: 6201
	// (get) Token: 0x06009B52 RID: 39762
	protected abstract EQuestActionType Result { get; }

	// Token: 0x06009B53 RID: 39763 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected sealed override void ExecuteInternal()
	{
		throw null;
	}

	// Token: 0x06009B54 RID: 39764 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<ValueTuple<GStruct243, EQuestActionType>> method_2()
	{
		throw null;
	}

	// Token: 0x06009B55 RID: 39765
	protected abstract Task ExecuteNetworkOperation();

	// Token: 0x0400A2B1 RID: 41649
	public const CounterTag HIDE_NEW_QUESTS = (CounterTag)10000;

	// Token: 0x0400A2B2 RID: 41650
	public const int KEEPER_FIRST_VISIT_STATE_THRESHOLD = 11;

	// Token: 0x0400A2B3 RID: 41651
	[CompilerGenerated]
	private Action<GStruct243, EQuestActionType, GClass1246, ConditionItem, DialogDataStruct> action_3;

	// Token: 0x0400A2B4 RID: 41652
	protected readonly AbstractQuestControllerClass gclass3203_0;

	// Token: 0x0400A2B5 RID: 41653
	protected readonly GClass1246 gclass1246_0;

	// Token: 0x0400A2B6 RID: 41654
	protected readonly ConditionItem conditionItem_0;
}
