using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using EFT.Quests;

// Token: 0x0200300F RID: 12303
public abstract class QuestControllerClass<T> where T : GInterface381
{
	// Token: 0x0600F20F RID: 61967 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ConnectCondition(T conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F210 RID: 61968 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManageConditionsConnections(T conditional)
	{
		throw null;
	}

	// Token: 0x0600F211 RID: 61969 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0(T quest, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F212 RID: 61970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ConnectConditionQuestTime(T conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F213 RID: 61971 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F214 RID: 61972 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_2(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F215 RID: 61973 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_3(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F216 RID: 61974 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_4(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F217 RID: 61975 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_5(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F218 RID: 61976 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_6<U>(GInterface381 conditional, EQuestStatus status, Condition condition) where U : ConditionZone
	{
		throw null;
	}

	// Token: 0x0600F219 RID: 61977 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_7(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F21A RID: 61978 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_8(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F21B RID: 61979 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_9(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F21C RID: 61980 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_10(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F21D RID: 61981 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_11(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F21E RID: 61982 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_12(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F21F RID: 61983 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_13(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F220 RID: 61984 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_14(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F221 RID: 61985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_15(GInterface381 conditional, EQuestStatus status, Condition condition)
	{
		throw null;
	}

	// Token: 0x0600F222 RID: 61986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual int GetFindItemConditionCount(GInterface381 conditional, ConditionFindItem condition)
	{
		throw null;
	}

	// Token: 0x0600F223 RID: 61987 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual int GetItemsForConditionCount(Inventory inventory, ConditionFindItem condition)
	{
		throw null;
	}

	// Token: 0x0600F224 RID: 61988 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetItemsForConditionIEnumerable(Inventory inventory, ConditionItem condition)
	{
		throw null;
	}

	// Token: 0x0600F225 RID: 61989 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_0(Item item, ConditionItem condition, GClass2881 handbook)
	{
		throw null;
	}

	// Token: 0x0600F226 RID: 61990 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_1(Inventory inventory, ConditionItem condition, Item currentItem)
	{
		throw null;
	}

	// Token: 0x0600F227 RID: 61991 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_2(Item item, ConditionItem condition)
	{
		throw null;
	}

	// Token: 0x0600F228 RID: 61992 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_3(Item item)
	{
		throw null;
	}

	// Token: 0x0600F229 RID: 61993 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_4(Item item, ConditionItem conditionItem)
	{
		throw null;
	}

	// Token: 0x0600F22A RID: 61994 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_16(GInterface381 conditional, Condition exceptCondition)
	{
		throw null;
	}

	// Token: 0x0600F22B RID: 61995 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearConditions(GInterface381 conditional)
	{
		throw null;
	}

	// Token: 0x0400F83F RID: 63551
	public Action<GInterface381, EQuestStatus, Condition, bool> OnConditionValueChanged;

	// Token: 0x0400F840 RID: 63552
	protected readonly Profile profile_0;

	// Token: 0x0400F841 RID: 63553
	private readonly GClass3358<T> gclass3358_0;

	// Token: 0x0400F842 RID: 63554
	private readonly InventoryControllerClass gclass2757_0;

	// Token: 0x0400F843 RID: 63555
	protected Dictionary<Type, Action<T, EQuestStatus, Condition>> dictionary_0;

	// Token: 0x0400F844 RID: 63556
	private Dictionary<string, List<T>> dictionary_1;

	// Token: 0x02003010 RID: 12304
	[CompilerGenerated]
	private sealed class Class3070
	{
		// Token: 0x0600F22C RID: 61996 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(T data)
		{
			throw null;
		}

		// Token: 0x0400F845 RID: 63557
		public T conditional;

		// Token: 0x0400F846 RID: 63558
		public Predicate<T> predicate_0;
	}

	// Token: 0x02003011 RID: 12305
	[CompilerGenerated]
	private sealed class Class3071
	{
		// Token: 0x0600F22D RID: 61997 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F22E RID: 61998 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass1246 _, bool __)
		{
			throw null;
		}

		// Token: 0x0600F22F RID: 61999 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_2(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F230 RID: 62000 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3()
		{
			throw null;
		}

		// Token: 0x0400F847 RID: 63559
		public GClass1246 conditionQuest;

		// Token: 0x0400F848 RID: 63560
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F849 RID: 63561
		public T quest;

		// Token: 0x0400F84A RID: 63562
		public EQuestStatus status;

		// Token: 0x0400F84B RID: 63563
		public Condition condition;

		// Token: 0x0400F84C RID: 63564
		public ConditionQuest conditionCasted;

		// Token: 0x0400F84D RID: 63565
		public GClass3231 conditionHandler;
	}

	// Token: 0x02003012 RID: 12306
	[CompilerGenerated]
	private sealed class Class3072
	{
		// Token: 0x0600F231 RID: 62001 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass3231 t)
		{
			throw null;
		}

		// Token: 0x0400F84E RID: 63566
		public IEnumerator timer;
	}

	// Token: 0x02003013 RID: 12307
	[CompilerGenerated]
	[Serializable]
	private sealed class Class3073
	{
		// Token: 0x0600F232 RID: 62002 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F233 RID: 62003 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F234 RID: 62004 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_2(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F235 RID: 62005 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(GInterface381 x)
		{
			throw null;
		}

		// Token: 0x0600F236 RID: 62006 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<KeyValuePair<EQuestStatus, GClass3365>> method_4(GInterface381 x)
		{
			throw null;
		}

		// Token: 0x0600F237 RID: 62007 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Condition> method_5(KeyValuePair<EQuestStatus, GClass3365> x)
		{
			throw null;
		}

		// Token: 0x0400F850 RID: 63568
		public static Func<GClass3231, float> func_0;

		// Token: 0x0400F851 RID: 63569
		public static Func<GClass3231, float> func_1;

		// Token: 0x0400F852 RID: 63570
		public static Func<GClass3231, float> func_2;

		// Token: 0x0400F853 RID: 63571
		public static Func<GInterface381, bool> func_3;

		// Token: 0x0400F854 RID: 63572
		public static Func<GInterface381, IEnumerable<KeyValuePair<EQuestStatus, GClass3365>>> func_4;

		// Token: 0x0400F855 RID: 63573
		public static Func<KeyValuePair<EQuestStatus, GClass3365>, IEnumerable<Condition>> func_5;
	}

	// Token: 0x02003014 RID: 12308
	[CompilerGenerated]
	private sealed class Class3074
	{
		// Token: 0x0600F238 RID: 62008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F239 RID: 62009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x0400F856 RID: 63574
		public GClass1246 quest;

		// Token: 0x0400F857 RID: 63575
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F858 RID: 63576
		public EQuestStatus status;

		// Token: 0x0400F859 RID: 63577
		public Condition condition;
	}

	// Token: 0x02003015 RID: 12309
	[CompilerGenerated]
	private sealed class Class3075
	{
		// Token: 0x0600F23A RID: 62010 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0400F85A RID: 63578
		public IEnumerator timer;
	}

	// Token: 0x02003016 RID: 12310
	[CompilerGenerated]
	private sealed class Class3076
	{
		// Token: 0x0600F23B RID: 62011 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F23C RID: 62012 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F23D RID: 62013 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(SessionCountersClass.GClass1784 counter)
		{
			throw null;
		}

		// Token: 0x0400F85B RID: 63579
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F85C RID: 63580
		public ConditionVisitPlace conditionCasted;

		// Token: 0x0400F85D RID: 63581
		public GInterface381 conditional;

		// Token: 0x0400F85E RID: 63582
		public EQuestStatus status;

		// Token: 0x0400F85F RID: 63583
		public Condition condition;
	}

	// Token: 0x02003017 RID: 12311
	[CompilerGenerated]
	private sealed class Class3077
	{
		// Token: 0x0600F23E RID: 62014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F23F RID: 62015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F240 RID: 62016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(SessionCountersClass.GClass1784 counter)
		{
			throw null;
		}

		// Token: 0x0400F860 RID: 63584
		public ConditionStatistic conditionCasted;

		// Token: 0x0400F861 RID: 63585
		public SessionCountersClass countersCollection;

		// Token: 0x0400F862 RID: 63586
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F863 RID: 63587
		public GInterface381 conditional;

		// Token: 0x0400F864 RID: 63588
		public EQuestStatus status;

		// Token: 0x0400F865 RID: 63589
		public Condition condition;
	}

	// Token: 0x02003018 RID: 12312
	[CompilerGenerated]
	private sealed class Class3078
	{
		// Token: 0x0600F241 RID: 62017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0400F866 RID: 63590
		public GInterface381 conditional;

		// Token: 0x0400F867 RID: 63591
		public ConditionCompleteCondition conditionCasted;
	}

	// Token: 0x02003019 RID: 12313
	[CompilerGenerated]
	private sealed class Class3079
	{
		// Token: 0x0600F242 RID: 62018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0400F868 RID: 63592
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F869 RID: 63593
		public ConditionExamineItem conditionCasted;
	}

	// Token: 0x0200301A RID: 12314
	[CompilerGenerated]
	private sealed class Class3080
	{
		// Token: 0x0600F243 RID: 62019 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0400F86A RID: 63594
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F86B RID: 63595
		public ConditionLaunchFlare conditionCasted;
	}

	// Token: 0x0200301B RID: 12315
	[CompilerGenerated]
	private sealed class Class3081<U> where U : ConditionZone
	{
		// Token: 0x0600F244 RID: 62020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F245 RID: 62021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(DroppedItem x)
		{
			throw null;
		}

		// Token: 0x0600F246 RID: 62022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(string item, string zone)
		{
			throw null;
		}

		// Token: 0x0600F247 RID: 62023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F248 RID: 62024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_4(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F249 RID: 62025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_5(DroppedItem x)
		{
			throw null;
		}

		// Token: 0x0400F86C RID: 63596
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F86D RID: 63597
		public U conditionCasted;

		// Token: 0x0400F86E RID: 63598
		public GInterface381 conditional;

		// Token: 0x0400F86F RID: 63599
		public EQuestStatus status;

		// Token: 0x0400F870 RID: 63600
		public Condition condition;

		// Token: 0x0400F871 RID: 63601
		public Func<DroppedItem, bool> func_0;

		// Token: 0x0400F872 RID: 63602
		public Predicate<DroppedItem> predicate_0;
	}

	// Token: 0x0200301C RID: 12316
	[CompilerGenerated]
	private sealed class Class3082
	{
		// Token: 0x0600F24A RID: 62026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F24B RID: 62027 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F24C RID: 62028 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(Profile.TraderInfo traderInfo)
		{
			throw null;
		}

		// Token: 0x0400F873 RID: 63603
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F874 RID: 63604
		public ConditionTraderStanding conditionCasted;

		// Token: 0x0400F875 RID: 63605
		public GInterface381 conditional;

		// Token: 0x0400F876 RID: 63606
		public EQuestStatus status;

		// Token: 0x0400F877 RID: 63607
		public Condition condition;
	}

	// Token: 0x0200301D RID: 12317
	[CompilerGenerated]
	private sealed class Class3083
	{
		// Token: 0x0600F24D RID: 62029 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F24E RID: 62030 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F24F RID: 62031 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(Profile.TraderInfo traderInfo)
		{
			throw null;
		}

		// Token: 0x0400F878 RID: 63608
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F879 RID: 63609
		public ConditionTraderLoyalty conditionCasted;

		// Token: 0x0400F87A RID: 63610
		public GInterface381 conditional;

		// Token: 0x0400F87B RID: 63611
		public EQuestStatus status;

		// Token: 0x0400F87C RID: 63612
		public Condition condition;
	}

	// Token: 0x0200301E RID: 12318
	[CompilerGenerated]
	private sealed class Class3084
	{
		// Token: 0x0600F250 RID: 62032 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F251 RID: 62033 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F252 RID: 62034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(GClass3218 taskConditionCounter)
		{
			throw null;
		}

		// Token: 0x0400F87D RID: 63613
		public GClass3218 counter;

		// Token: 0x0400F87E RID: 63614
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F87F RID: 63615
		public GInterface381 conditional;

		// Token: 0x0400F880 RID: 63616
		public EQuestStatus status;

		// Token: 0x0400F881 RID: 63617
		public Condition condition;
	}

	// Token: 0x0200301F RID: 12319
	[CompilerGenerated]
	private sealed class Class3085
	{
		// Token: 0x0600F253 RID: 62035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F254 RID: 62036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F255 RID: 62037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(GClass3218 _)
		{
			throw null;
		}

		// Token: 0x0400F882 RID: 63618
		public GClass3218 counter;

		// Token: 0x0400F883 RID: 63619
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F884 RID: 63620
		public GInterface381 conditional;

		// Token: 0x0400F885 RID: 63621
		public EQuestStatus status;

		// Token: 0x0400F886 RID: 63622
		public Condition condition;
	}

	// Token: 0x02003020 RID: 12320
	[CompilerGenerated]
	private sealed class Class3086
	{
		// Token: 0x0600F256 RID: 62038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F257 RID: 62039 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F258 RID: 62040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(GClass1763 skill)
		{
			throw null;
		}

		// Token: 0x0400F887 RID: 63623
		public GClass1765 skillCasted;

		// Token: 0x0400F888 RID: 63624
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F889 RID: 63625
		public GInterface381 conditional;

		// Token: 0x0400F88A RID: 63626
		public EQuestStatus status;

		// Token: 0x0400F88B RID: 63627
		public Condition condition;
	}

	// Token: 0x02003021 RID: 12321
	[CompilerGenerated]
	private sealed class Class3087
	{
		// Token: 0x0600F259 RID: 62041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F25A RID: 62042 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F25B RID: 62043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(int level, int diff)
		{
			throw null;
		}

		// Token: 0x0400F88C RID: 63628
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F88D RID: 63629
		public GInterface381 conditional;

		// Token: 0x0400F88E RID: 63630
		public EQuestStatus status;

		// Token: 0x0400F88F RID: 63631
		public Condition condition;
	}

	// Token: 0x02003022 RID: 12322
	[CompilerGenerated]
	private sealed class Class3088
	{
		// Token: 0x0600F25C RID: 62044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F25D RID: 62045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F25E RID: 62046 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(GClass3218 taskConditionCounter)
		{
			throw null;
		}

		// Token: 0x0400F890 RID: 63632
		public GClass3218 counter;

		// Token: 0x0400F891 RID: 63633
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F892 RID: 63634
		public GInterface381 conditional;

		// Token: 0x0400F893 RID: 63635
		public EQuestStatus status;

		// Token: 0x0400F894 RID: 63636
		public Condition condition;
	}

	// Token: 0x02003023 RID: 12323
	[CompilerGenerated]
	private sealed class Class3089
	{
		// Token: 0x0600F25F RID: 62047 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F260 RID: 62048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F261 RID: 62049 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(GEventArgs2 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600F262 RID: 62050 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(GEventArgs3 eventArgs)
		{
			throw null;
		}

		// Token: 0x0400F895 RID: 63637
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F896 RID: 63638
		public GInterface381 conditional;

		// Token: 0x0400F897 RID: 63639
		public ConditionFindItem conditionCasted;

		// Token: 0x0400F898 RID: 63640
		public EQuestStatus status;

		// Token: 0x0400F899 RID: 63641
		public Condition condition;
	}

	// Token: 0x02003024 RID: 12324
	[CompilerGenerated]
	private sealed class Class3090
	{
		// Token: 0x0600F263 RID: 62051 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F264 RID: 62052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GClass3231 _)
		{
			throw null;
		}

		// Token: 0x0600F265 RID: 62053 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(GClass3218 taskConditionCounter)
		{
			throw null;
		}

		// Token: 0x0400F89A RID: 63642
		public GClass3218 counter;

		// Token: 0x0400F89B RID: 63643
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F89C RID: 63644
		public GInterface381 conditional;

		// Token: 0x0400F89D RID: 63645
		public EQuestStatus status;

		// Token: 0x0400F89E RID: 63646
		public Condition condition;
	}

	// Token: 0x02003025 RID: 12325
	[CompilerGenerated]
	private sealed class Class3091
	{
		// Token: 0x0600F266 RID: 62054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GInterface381 method_0(ConditionQuest x)
		{
			throw null;
		}

		// Token: 0x0600F267 RID: 62055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ConditionMultipleTargets> method_1(KeyValuePair<EQuestStatus, GClass3365> x)
		{
			throw null;
		}

		// Token: 0x0600F268 RID: 62056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(ConditionMultipleTargets questCondition)
		{
			throw null;
		}

		// Token: 0x0400F89F RID: 63647
		public QuestControllerClass<T> gclass3222_0;

		// Token: 0x0400F8A0 RID: 63648
		public ConditionFindItem condition;

		// Token: 0x0400F8A1 RID: 63649
		public Func<ConditionQuest, GInterface381> func_0;

		// Token: 0x0400F8A2 RID: 63650
		public Func<ConditionMultipleTargets, bool> func_1;

		// Token: 0x0400F8A3 RID: 63651
		public Func<KeyValuePair<EQuestStatus, GClass3365>, IEnumerable<ConditionMultipleTargets>> func_2;
	}

	// Token: 0x02003027 RID: 12327
	[CompilerGenerated]
	private sealed class Class3093
	{
		// Token: 0x0600F26F RID: 62063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(string t)
		{
			throw null;
		}

		// Token: 0x0600F270 RID: 62064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(string t)
		{
			throw null;
		}

		// Token: 0x0400F8AD RID: 63661
		public GClass2881 handbook;

		// Token: 0x0400F8AE RID: 63662
		public Item item;
	}

	// Token: 0x02003028 RID: 12328
	[CompilerGenerated]
	private sealed class Class3094
	{
		// Token: 0x0600F271 RID: 62065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition x)
		{
			throw null;
		}

		// Token: 0x0600F272 RID: 62066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Condition condition)
		{
			throw null;
		}

		// Token: 0x0400F8AF RID: 63663
		public Condition exceptCondition;

		// Token: 0x0400F8B0 RID: 63664
		public GInterface381 conditional;
	}
}
