using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InventoryLogic;
using EFT.Quests;

// Token: 0x0200304C RID: 12364
public abstract class AbstractQuestControllerClass : GClass3202<GClass1246>
{
	// Token: 0x1400036D RID: 877
	// (add) Token: 0x0600F312 RID: 62226 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F313 RID: 62227 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass1246> OnNewQuestsAdded
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

	// Token: 0x170029BE RID: 10686
	// (get) Token: 0x0600F314 RID: 62228 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F315 RID: 62229 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3359 Quests
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

	// Token: 0x0600F316 RID: 62230 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void CreateConditionalList()
	{
		throw null;
	}

	// Token: 0x0600F317 RID: 62231
	public abstract Task<IResult> AcceptQuest(GClass1246 quest, bool runNetworkTransaction);

	// Token: 0x0600F318 RID: 62232
	public abstract Task<GStruct413<GStruct373>> FinishQuest(GClass1246 quest, bool runNetworkTransaction);

	// Token: 0x0600F319 RID: 62233
	public abstract Task<IResult> HandoverItem(GClass1246 quest, ConditionItem condition, Item[] items, bool runNetworkTransaction);

	// Token: 0x0600F31A RID: 62234 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool TryExecuteTransition(GClass1246 quest, EQuestStatus nextStatus)
	{
		throw null;
	}

	// Token: 0x0600F31B RID: 62235 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsQuestForCurrentProfile(GClass1246 quest)
	{
		throw null;
	}

	// Token: 0x0600F31C RID: 62236 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<GClass1246> NewQuests(string traderId = null)
	{
		throw null;
	}

	// Token: 0x0600F31D RID: 62237 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ManageConditional(GClass1246 conditional)
	{
		throw null;
	}

	// Token: 0x0600F31E RID: 62238 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x0400F907 RID: 63751
	[CompilerGenerated]
	private Action<GClass1246> action_2;

	// Token: 0x0400F908 RID: 63752
	public readonly bool FromServer;

	// Token: 0x0400F909 RID: 63753
	[CompilerGenerated]
	private GClass3359 gclass3359_0;
}
