using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Quests;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02001039 RID: 4153
public abstract class QuestClass<T> : IDisposable, GInterface381 where T : GInterface381
{
	// Token: 0x140000F6 RID: 246
	// (add) Token: 0x060056AF RID: 22191 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060056B0 RID: 22192 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<T, bool> OnStatusChanged
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

	// Token: 0x140000F7 RID: 247
	// (add) Token: 0x060056B1 RID: 22193 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060056B2 RID: 22194 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<T> OnConditionChanged
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

	// Token: 0x17000DAD RID: 3501
	// (get) Token: 0x060056B3 RID: 22195 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060056B4 RID: 22196 RVA: 0x00002050 File Offset: 0x00000250
	public string Id
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17000DAE RID: 3502
	// (get) Token: 0x060056B5 RID: 22197 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060056B6 RID: 22198 RVA: 0x00002050 File Offset: 0x00000250
	public virtual GClass3220 Conditions
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17000DAF RID: 3503
	// (get) Token: 0x060056B7 RID: 22199 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060056B8 RID: 22200 RVA: 0x00002050 File Offset: 0x00000250
	public ConditionCounterManager ConditionCountersManager
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17000DB0 RID: 3504
	// (get) Token: 0x060056B9 RID: 22201 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<Condition, GClass3231> ProgressCheckers
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000DB1 RID: 3505
	// (get) Token: 0x060056BA RID: 22202 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060056BB RID: 22203 RVA: 0x00002050 File Offset: 0x00000250
	public HashSet<string> CompletedConditions
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17000DB2 RID: 3506
	// (get) Token: 0x060056BC RID: 22204 RVA: 0x00002050 File Offset: 0x00000250
	public virtual ETaskPlayerSide PlayerSide
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000DB3 RID: 3507
	// (get) Token: 0x060056BD RID: 22205 RVA: 0x00002050 File Offset: 0x00000250
	public virtual Dictionary<EQuestStatus, List<GClass3244>> Rewards
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000DB4 RID: 3508
	// (get) Token: 0x060056BE RID: 22206
	public abstract bool ReadyToFail { get; }

	// Token: 0x17000DB5 RID: 3509
	// (get) Token: 0x060056BF RID: 22207
	public abstract bool ServerOnly { get; }

	// Token: 0x17000DB6 RID: 3510
	// (get) Token: 0x060056C0 RID: 22208
	public abstract bool InstantComplete { get; }

	// Token: 0x17000DB7 RID: 3511
	// (get) Token: 0x060056C1 RID: 22209 RVA: 0x00002050 File Offset: 0x00000250
	public virtual int FailTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000DB8 RID: 3512
	// (get) Token: 0x060056C2 RID: 22210 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060056C3 RID: 22211 RVA: 0x00002050 File Offset: 0x00000250
	public EQuestStatus QuestStatus
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17000DB9 RID: 3513
	// (get) Token: 0x060056C4 RID: 22212
	protected abstract Dictionary<EQuestStatus, EQuestStatus[]> StatusTransition { get; }

	// Token: 0x17000DBA RID: 3514
	// (get) Token: 0x060056C5 RID: 22213 RVA: 0x00002050 File Offset: 0x00000250
	public virtual EQuestStatus[] CurrentStatusTransitions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000DBB RID: 3515
	// (get) Token: 0x060056C6 RID: 22214 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3365 AvailableForFinishConditions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000DBC RID: 3516
	// (get) Token: 0x060056C7 RID: 22215
	public abstract string Description { get; }

	// Token: 0x17000DBD RID: 3517
	// (get) Token: 0x060056C8 RID: 22216
	public abstract string Image { get; }

	// Token: 0x17000DBE RID: 3518
	// (get) Token: 0x060056C9 RID: 22217
	// (set) Token: 0x060056CA RID: 22218
	public abstract Sprite Sprite { get; set; }

	// Token: 0x060056CB RID: 22219 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsDone()
	{
		throw null;
	}

	// Token: 0x060056CC RID: 22220
	public abstract void SetStatus(EQuestStatus status, bool notify, bool fromServer);

	// Token: 0x060056CD RID: 22221
	public abstract void CheckForStatusChange(EQuestStatus status, bool notify, bool fromServer, bool canFail, Action<GInterface381> onFailed = null);

	// Token: 0x060056CE RID: 22222 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0(T conditional, bool notify)
	{
		throw null;
	}

	// Token: 0x060056CF RID: 22223 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1(T conditional)
	{
		throw null;
	}

	// Token: 0x060056D0 RID: 22224 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_2(bool fromServer, bool canFail)
	{
		throw null;
	}

	// Token: 0x060056D1 RID: 22225 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<TCondition> GetConditions<TCondition>(EQuestStatus status) where TCondition : Condition
	{
		throw null;
	}

	// Token: 0x060056D2 RID: 22226 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Condition GetCondition(string conditionId)
	{
		throw null;
	}

	// Token: 0x060056D3 RID: 22227 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected U method_3<U>(EQuestStatus status) where U : Condition
	{
		throw null;
	}

	// Token: 0x060056D4 RID: 22228 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Condition GetCondition(int conditionId)
	{
		throw null;
	}

	// Token: 0x060056D5 RID: 22229 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Condition GetVisibilityCondition(string conditionId)
	{
		throw null;
	}

	// Token: 0x060056D6 RID: 22230 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Condition GetVisibilityCondition(int conditionId)
	{
		throw null;
	}

	// Token: 0x060056D7 RID: 22231 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckForStatusChange(bool fromServer, bool canFail)
	{
		throw null;
	}

	// Token: 0x060056D8 RID: 22232 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateConditionsVisibility()
	{
		throw null;
	}

	// Token: 0x060056D9 RID: 22233 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_4()
	{
		throw null;
	}

	// Token: 0x060056DA RID: 22234 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(Condition condition)
	{
		throw null;
	}

	// Token: 0x060056DB RID: 22235 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(Condition condition, GClass3231 progressChecker)
	{
		throw null;
	}

	// Token: 0x060056DC RID: 22236 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckVisibilityStatus(Condition condition)
	{
		throw null;
	}

	// Token: 0x060056DD RID: 22237 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsConditionDone(Condition condition)
	{
		throw null;
	}

	// Token: 0x060056DE RID: 22238 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TransitionStatus(EQuestStatus status, bool fromServer)
	{
		throw null;
	}

	// Token: 0x060056DF RID: 22239 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_7(EQuestStatus status)
	{
		throw null;
	}

	// Token: 0x060056E0 RID: 22240 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisconnectConditions()
	{
		throw null;
	}

	// Token: 0x060056E1 RID: 22241 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x040062BC RID: 25276
	[CompilerGenerated]
	private Action<T, bool> action_0;

	// Token: 0x040062BD RID: 25277
	[CompilerGenerated]
	private Action<T> action_1;

	// Token: 0x040062BE RID: 25278
	private List<Condition> list_0;

	// Token: 0x040062BF RID: 25279
	protected readonly GClass763 gclass763_0;

	// Token: 0x040062C0 RID: 25280
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040062C1 RID: 25281
	[CompilerGenerated]
	private GClass3220 gclass3220_0;

	// Token: 0x040062C2 RID: 25282
	[CompilerGenerated]
	private ConditionCounterManager conditionCounterManager_0;

	// Token: 0x040062C3 RID: 25283
	[CompilerGenerated]
	private readonly Dictionary<Condition, GClass3231> dictionary_0;

	// Token: 0x040062C4 RID: 25284
	[CompilerGenerated]
	private HashSet<string> hashSet_0;

	// Token: 0x040062C5 RID: 25285
	[CompilerGenerated]
	private readonly ETaskPlayerSide etaskPlayerSide_0;

	// Token: 0x040062C6 RID: 25286
	[CompilerGenerated]
	private readonly Dictionary<EQuestStatus, List<GClass3244>> dictionary_1;

	// Token: 0x040062C7 RID: 25287
	[CompilerGenerated]
	private EQuestStatus equestStatus_0;

	// Token: 0x0200103A RID: 4154
	[CompilerGenerated]
	private sealed class Class792
	{
		// Token: 0x060056E2 RID: 22242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition cond)
		{
			throw null;
		}

		// Token: 0x040062C8 RID: 25288
		public string conditionId;
	}

	// Token: 0x0200103B RID: 4155
	[CompilerGenerated]
	[Serializable]
	private sealed class Class793
	{
		// Token: 0x060056E3 RID: 22243 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Condition> method_0(KeyValuePair<EQuestStatus, GClass3365> collection)
		{
			throw null;
		}

		// Token: 0x060056E4 RID: 22244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Condition> method_1(KeyValuePair<EQuestStatus, GClass3365> collection)
		{
			throw null;
		}

		// Token: 0x060056E5 RID: 22245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Condition> method_2(KeyValuePair<EQuestStatus, GClass3365> collection)
		{
			throw null;
		}

		// Token: 0x060056E6 RID: 22246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Condition> method_3(Condition x)
		{
			throw null;
		}

		// Token: 0x060056E7 RID: 22247 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Condition> method_4(KeyValuePair<EQuestStatus, GClass3365> collection)
		{
			throw null;
		}

		// Token: 0x060056E8 RID: 22248 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Condition> method_5(Condition x)
		{
			throw null;
		}

		// Token: 0x040062CA RID: 25290
		public static Func<KeyValuePair<EQuestStatus, GClass3365>, IEnumerable<Condition>> func_0;

		// Token: 0x040062CB RID: 25291
		public static Func<KeyValuePair<EQuestStatus, GClass3365>, IEnumerable<Condition>> func_1;

		// Token: 0x040062CC RID: 25292
		public static Func<KeyValuePair<EQuestStatus, GClass3365>, IEnumerable<Condition>> func_2;

		// Token: 0x040062CD RID: 25293
		public static Func<Condition, IEnumerable<Condition>> func_3;

		// Token: 0x040062CE RID: 25294
		public static Func<KeyValuePair<EQuestStatus, GClass3365>, IEnumerable<Condition>> func_4;

		// Token: 0x040062CF RID: 25295
		public static Func<Condition, IEnumerable<Condition>> func_5;
	}

	// Token: 0x0200103C RID: 4156
	[CompilerGenerated]
	private sealed class Class794
	{
		// Token: 0x060056E9 RID: 22249 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition cond)
		{
			throw null;
		}

		// Token: 0x040062D0 RID: 25296
		public int conditionId;
	}

	// Token: 0x0200103D RID: 4157
	[CompilerGenerated]
	private sealed class Class795
	{
		// Token: 0x060056EA RID: 22250 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition cond)
		{
			throw null;
		}

		// Token: 0x040062D1 RID: 25297
		public string conditionId;
	}

	// Token: 0x0200103E RID: 4158
	[CompilerGenerated]
	private sealed class Class796
	{
		// Token: 0x060056EB RID: 22251 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition cond)
		{
			throw null;
		}

		// Token: 0x040062D2 RID: 25298
		public int conditionId;
	}
}
