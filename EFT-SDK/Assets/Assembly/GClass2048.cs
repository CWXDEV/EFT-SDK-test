using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using EFT.Counters;
using EFT.InputSystem;
using EFT.Quests;
using EFT.Trading;

// Token: 0x02001D3D RID: 7485
public abstract class GClass2048 : IDisposable, GInterface179
{
	// Token: 0x140001D1 RID: 465
	// (add) Token: 0x06009ACC RID: 39628 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009ACD RID: 39629 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass2069> OnDialogChanged
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

	// Token: 0x140001D2 RID: 466
	// (add) Token: 0x06009ACE RID: 39630 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009ACF RID: 39631 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass2069> OnActionFinished
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

	// Token: 0x140001D3 RID: 467
	// (add) Token: 0x06009AD0 RID: 39632 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009AD1 RID: 39633 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnBlockDialog
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

	// Token: 0x17001812 RID: 6162
	// (get) Token: 0x06009AD2 RID: 39634 RVA: 0x00002050 File Offset: 0x00000250
	public ETraderDialogType LastDialogType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001813 RID: 6163
	// (get) Token: 0x06009AD3 RID: 39635 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009AD4 RID: 39636 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2069 CurrentDialog
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x06009AD5 RID: 39637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06009AD6 RID: 39638
	protected abstract void SetUp();

	// Token: 0x06009AD7 RID: 39639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ServiceUpdateHandler()
	{
		throw null;
	}

	// Token: 0x06009AD8 RID: 39640
	protected abstract GClass2069 CreateDialogList(GStruct243 source);

	// Token: 0x06009AD9 RID: 39641 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1(GStruct246.GStruct247 saveData)
	{
		throw null;
	}

	// Token: 0x06009ADA RID: 39642 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06009ADB RID: 39643 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(GStruct243 source, DialogDataStruct lineConstructor)
	{
		throw null;
	}

	// Token: 0x06009ADC RID: 39644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_4(GStruct243 source)
	{
		throw null;
	}

	// Token: 0x06009ADD RID: 39645 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(GStruct243 source, EQuestActionType result, GClass1246 quest, ConditionItem condition, DialogDataStruct lineConstructor)
	{
		throw null;
	}

	// Token: 0x06009ADE RID: 39646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(GStruct243 source, EServiceActionType result, DialogDataStruct lineConstructor, IEnumerable<MongoID> handoverItems, bool anyReward)
	{
		throw null;
	}

	// Token: 0x06009ADF RID: 39647 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_7(GClass2069 dialogList, Task<string> animationTask)
	{
		throw null;
	}

	// Token: 0x06009AE0 RID: 39648 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInt(GStruct246.GStruct247 saveData)
	{
		throw null;
	}

	// Token: 0x06009AE1 RID: 39649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetInt(CounterTag tag)
	{
		throw null;
	}

	// Token: 0x06009AE2 RID: 39650 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputNode.ETranslateResult TranslateCommand(ECommand command)
	{
		throw null;
	}

	// Token: 0x06009AE3 RID: 39651 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06009AE4 RID: 39652 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8()
	{
		throw null;
	}

	// Token: 0x0400A219 RID: 41497
	[CompilerGenerated]
	private Action<GClass2069> action_0;

	// Token: 0x0400A21A RID: 41498
	[CompilerGenerated]
	private Action<GClass2069> action_1;

	// Token: 0x0400A21B RID: 41499
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x0400A21C RID: 41500
	public readonly Profile.TraderInfo Trader;

	// Token: 0x0400A21D RID: 41501
	protected readonly Profile profile_0;

	// Token: 0x0400A21E RID: 41502
	protected readonly AbstractQuestControllerClass gclass3203_0;

	// Token: 0x0400A21F RID: 41503
	protected readonly InventoryControllerClass gclass2757_0;

	// Token: 0x0400A220 RID: 41504
	protected readonly GInterface180 ginterface180_0;

	// Token: 0x0400A221 RID: 41505
	private ETraderDialogType etraderDialogType_0;

	// Token: 0x0400A222 RID: 41506
	private readonly Dictionary<CounterTag, int> dictionary_0;

	// Token: 0x0400A223 RID: 41507
	private readonly Dictionary<CounterTag, int> dictionary_1;

	// Token: 0x0400A224 RID: 41508
	private GClass2069 gclass2069_0;

	// Token: 0x0400A225 RID: 41509
	private readonly GClass763 gclass763_0;

	// Token: 0x0400A226 RID: 41510
	private readonly GClass763 gclass763_1;

	// Token: 0x0400A227 RID: 41511
	public readonly GClass2052 History;

	// Token: 0x02001D3E RID: 7486
	[CompilerGenerated]
	private sealed class Class1750
	{
		// Token: 0x06009AE5 RID: 39653 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x06009AE6 RID: 39654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x0400A228 RID: 41512
		public GClass2048 gclass2048_0;

		// Token: 0x0400A229 RID: 41513
		public GClass2069 value;
	}

	// Token: 0x02001D3F RID: 7487
	[CompilerGenerated]
	private sealed class Class1751
	{
		// Token: 0x06009AE7 RID: 39655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x06009AE8 RID: 39656 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x0400A22A RID: 41514
		public GClass2081 questDialog;

		// Token: 0x0400A22B RID: 41515
		public GClass2078 serviceDialogDeal;

		// Token: 0x0400A22C RID: 41516
		public GClass2048.Class1750 class1750_0;
	}
}
