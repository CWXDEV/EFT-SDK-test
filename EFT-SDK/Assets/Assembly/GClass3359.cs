using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Quests;

// Token: 0x02003040 RID: 12352
public sealed class GClass3359 : GClass3358<GClass1246>, IDisposable
{
	// Token: 0x1400036C RID: 876
	// (add) Token: 0x0600F2ED RID: 62189 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F2EE RID: 62190 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass1247> OnQuestExpired
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

	// Token: 0x0600F2EF RID: 62191 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTemplates(IEnumerable<RawQuestClass> templates)
	{
		throw null;
	}

	// Token: 0x0600F2F0 RID: 62192 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task InitRepeatableQuests(ISession session)
	{
		throw null;
	}

	// Token: 0x0600F2F1 RID: 62193 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveQuestTemplate(RawQuestClass template)
	{
		throw null;
	}

	// Token: 0x0600F2F2 RID: 62194 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDailyQuests(IEnumerable<DailyQuestClass> questsRanges, bool notify = false)
	{
		throw null;
	}

	// Token: 0x0600F2F3 RID: 62195 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(GClass3247 newQuest)
	{
		throw null;
	}

	// Token: 0x0600F2F4 RID: 62196 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetQuestStatusData(QuestDataClass[] questStatusData)
	{
		throw null;
	}

	// Token: 0x0600F2F5 RID: 62197 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load()
	{
		throw null;
	}

	// Token: 0x0600F2F6 RID: 62198 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void LoadAll()
	{
		throw null;
	}

	// Token: 0x0600F2F7 RID: 62199 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RemoveConditionalsWithoutTemplate()
	{
		throw null;
	}

	// Token: 0x0600F2F8 RID: 62200 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(RawQuestClass template)
	{
		throw null;
	}

	// Token: 0x0600F2F9 RID: 62201 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_9(GClass1246 quest)
	{
		throw null;
	}

	// Token: 0x0600F2FA RID: 62202 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<GClass3231> GetConditionHandlersByZone<T>(string zoneId) where T : ConditionZone
	{
		throw null;
	}

	// Token: 0x0600F2FB RID: 62203 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetQuestsCount(string traderId, EQuestStatus status)
	{
		throw null;
	}

	// Token: 0x0600F2FC RID: 62204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetQuestsSuccessCount(string traderId)
	{
		throw null;
	}

	// Token: 0x0600F2FD RID: 62205 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetQuestsCount(string traderId)
	{
		throw null;
	}

	// Token: 0x0600F2FE RID: 62206 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<GClass1246> method_10(string traderId)
	{
		throw null;
	}

	// Token: 0x0600F2FF RID: 62207 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0600F300 RID: 62208 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11()
	{
		throw null;
	}

	// Token: 0x0400F8E9 RID: 63721
	[CompilerGenerated]
	private Action<GClass1247> action_6;

	// Token: 0x0400F8EA RID: 63722
	private readonly List<QuestDataClass> list_1;

	// Token: 0x0400F8EB RID: 63723
	private readonly bool bool_2;

	// Token: 0x0400F8EC RID: 63724
	private GClass763 gclass763_0;

	// Token: 0x0400F8ED RID: 63725
	private GClass3253 gclass3253_0;

	// Token: 0x02003042 RID: 12354
	[CompilerGenerated]
	[Serializable]
	private sealed class Class3101
	{
		// Token: 0x0600F303 RID: 62211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GClass3247> method_0(DailyQuestClass questRange)
		{
			throw null;
		}

		// Token: 0x0400F8F3 RID: 63731
		public static readonly GClass3359.Class3101 class3101_0;

		// Token: 0x0400F8F4 RID: 63732
		public static Func<DailyQuestClass, IEnumerable<GClass3247>> func_0;
	}

	// Token: 0x02003043 RID: 12355
	[CompilerGenerated]
	private sealed class Class3102
	{
		// Token: 0x0600F304 RID: 62212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1246 quest)
		{
			throw null;
		}

		// Token: 0x0600F305 RID: 62213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(QuestDataClass quest)
		{
			throw null;
		}

		// Token: 0x0400F8F5 RID: 63733
		public QuestDataClass statusData;
	}

	// Token: 0x02003044 RID: 12356
	[CompilerGenerated]
	private sealed class Class3103
	{
		// Token: 0x0600F306 RID: 62214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(RawQuestClass x)
		{
			throw null;
		}

		// Token: 0x0400F8F6 RID: 63734
		public int i;

		// Token: 0x0400F8F7 RID: 63735
		public GClass3359 gclass3359_0;
	}

	// Token: 0x02003045 RID: 12357
	[CompilerGenerated]
	private sealed class Class3104
	{
		// Token: 0x0600F307 RID: 62215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1246 existingQuest)
		{
			throw null;
		}

		// Token: 0x0600F308 RID: 62216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(QuestDataClass existingQuestData)
		{
			throw null;
		}

		// Token: 0x0600F309 RID: 62217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2()
		{
			throw null;
		}

		// Token: 0x0400F8F8 RID: 63736
		public RawQuestClass template;

		// Token: 0x0400F8F9 RID: 63737
		public GClass3359 gclass3359_0;

		// Token: 0x0400F8FA RID: 63738
		public GClass1247 dailyQuest;
	}

	// Token: 0x02003047 RID: 12359
	[CompilerGenerated]
	private sealed class Class3105<T> where T : ConditionZone
	{
		// Token: 0x0600F30C RID: 62220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GClass3231> method_0(GClass1246 quest)
		{
			throw null;
		}

		// Token: 0x0400F900 RID: 63744
		public string zoneId;
	}

	// Token: 0x02003048 RID: 12360
	[CompilerGenerated]
	private sealed class Class3106<T> where T : ConditionZone
	{
		// Token: 0x0600F30D RID: 62221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(T conditionZone)
		{
			throw null;
		}

		// Token: 0x0600F30E RID: 62222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass3231 method_1(T x)
		{
			throw null;
		}

		// Token: 0x0400F901 RID: 63745
		public GClass1246 quest;

		// Token: 0x0400F902 RID: 63746
		public GClass3359.Class3105<T> class3105_0;
	}

	// Token: 0x02003049 RID: 12361
	[CompilerGenerated]
	[Serializable]
	private sealed class Class3107<T> where T : ConditionZone
	{
		// Token: 0x0600F30F RID: 62223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1246 quest)
		{
			throw null;
		}

		// Token: 0x0400F903 RID: 63747
		public static readonly GClass3359.Class3107<T> class3107_0;

		// Token: 0x0400F904 RID: 63748
		public static Func<GClass1246, bool> func_0;
	}

	// Token: 0x0200304A RID: 12362
	[CompilerGenerated]
	private sealed class Class3108
	{
		// Token: 0x0600F310 RID: 62224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1246 quest)
		{
			throw null;
		}

		// Token: 0x0400F905 RID: 63749
		public EQuestStatus status;
	}

	// Token: 0x0200304B RID: 12363
	[CompilerGenerated]
	private sealed class Class3109
	{
		// Token: 0x0600F311 RID: 62225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1246 quest)
		{
			throw null;
		}

		// Token: 0x0400F906 RID: 63750
		public string traderId;
	}
}
