using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using EFT.Quests;
using Newtonsoft.Json;
using UnityEngine;

// Token: 0x0200303D RID: 12349
public class GClass1246 : QuestClass<GClass1246>
{
	// Token: 0x170029A9 RID: 10665
	// (get) Token: 0x0600F2C8 RID: 62152 RVA: 0x00002050 File Offset: 0x00000250
	protected override Dictionary<EQuestStatus, EQuestStatus[]> StatusTransition
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029AA RID: 10666
	// (get) Token: 0x0600F2C9 RID: 62153 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F2CA RID: 62154 RVA: 0x00002050 File Offset: 0x00000250
	public int StartTime
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

	// Token: 0x170029AB RID: 10667
	// (get) Token: 0x0600F2CB RID: 62155 RVA: 0x00002050 File Offset: 0x00000250
	public override Dictionary<EQuestStatus, List<GClass3244>> Rewards
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029AC RID: 10668
	// (get) Token: 0x0600F2CC RID: 62156 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<Condition> NecessaryConditions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029AD RID: 10669
	// (get) Token: 0x0600F2CD RID: 62157 RVA: 0x00002050 File Offset: 0x00000250
	public override ETaskPlayerSide PlayerSide
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029AE RID: 10670
	// (get) Token: 0x0600F2CE RID: 62158 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029AF RID: 10671
	// (get) Token: 0x0600F2CF RID: 62159 RVA: 0x00002050 File Offset: 0x00000250
	public override string Image
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029B0 RID: 10672
	// (get) Token: 0x0600F2D0 RID: 62160 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F2D1 RID: 62161 RVA: 0x00002050 File Offset: 0x00000250
	public override Sprite Sprite
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170029B1 RID: 10673
	// (get) Token: 0x0600F2D2 RID: 62162 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F2D3 RID: 62163 RVA: 0x00002050 File Offset: 0x00000250
	public RawQuestClass Template
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170029B2 RID: 10674
	// (get) Token: 0x0600F2D4 RID: 62164 RVA: 0x00002050 File Offset: 0x00000250
	public ValueTuple<float, float> Progress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029B3 RID: 10675
	// (get) Token: 0x0600F2D5 RID: 62165 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsChangeAllowed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029B4 RID: 10676
	// (get) Token: 0x0600F2D6 RID: 62166 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ReadyToFail
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029B5 RID: 10677
	// (get) Token: 0x0600F2D7 RID: 62167 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ServerOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029B6 RID: 10678
	// (get) Token: 0x0600F2D8 RID: 62168 RVA: 0x00002050 File Offset: 0x00000250
	public override bool InstantComplete
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029B7 RID: 10679
	// (get) Token: 0x0600F2D9 RID: 62169 RVA: 0x00002050 File Offset: 0x00000250
	public override int FailTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029B8 RID: 10680
	// (get) Token: 0x0600F2DA RID: 62170 RVA: 0x00002050 File Offset: 0x00000250
	public virtual EQuestIconType IconType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029B9 RID: 10681
	// (get) Token: 0x0600F2DB RID: 62171 RVA: 0x00002050 File Offset: 0x00000250
	public virtual string QuestTypeName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029BA RID: 10682
	// (get) Token: 0x0600F2DC RID: 62172 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F2DD RID: 62173 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsVisible
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

	// Token: 0x170029BB RID: 10683
	// (get) Token: 0x0600F2DE RID: 62174 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F2DF RID: 62175 RVA: 0x00002050 File Offset: 0x00000250
	public Task<bool> IsVisibleTask
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

	// Token: 0x170029BC RID: 10684
	// (get) Token: 0x0600F2E0 RID: 62176 RVA: 0x00002050 File Offset: 0x00000250
	public override GClass3220 Conditions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029BD RID: 10685
	// (get) Token: 0x0600F2E1 RID: 62177 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F2E2 RID: 62178 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public bool IsViewed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x0600F2E3 RID: 62179 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<bool> method_8()
	{
		throw null;
	}

	// Token: 0x0600F2E4 RID: 62180 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_9(QuestDataClass questStatusData)
	{
		throw null;
	}

	// Token: 0x0600F2E5 RID: 62181 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private TimeSpan method_10(QuestDataClass questStatusData)
	{
		throw null;
	}

	// Token: 0x0600F2E6 RID: 62182 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CheckForStatusChange(EQuestStatus status, bool notify, bool fromServer, bool canFail, Action<GInterface381> onFailed = null)
	{
		throw null;
	}

	// Token: 0x0600F2E7 RID: 62183 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsDone()
	{
		throw null;
	}

	// Token: 0x0600F2E8 RID: 62184 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public sealed override void SetStatus(EQuestStatus status, bool notify, bool fromServer)
	{
		throw null;
	}

	// Token: 0x0600F2E9 RID: 62185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400F8D9 RID: 63705
	[CompilerGenerated]
	private readonly Dictionary<EQuestStatus, EQuestStatus[]> dictionary_2;

	// Token: 0x0400F8DA RID: 63706
	public readonly Dictionary<EQuestStatus, double> StatusStartTimestamps;

	// Token: 0x0400F8DB RID: 63707
	private readonly QuestDataClass gclass3245_0;

	// Token: 0x0400F8DC RID: 63708
	private RawQuestClass gclass3246_0;

	// Token: 0x0400F8DD RID: 63709
	[CompilerGenerated]
	private int int_0;

	// Token: 0x0400F8DE RID: 63710
	[CompilerGenerated]
	private Sprite sprite_0;

	// Token: 0x0400F8DF RID: 63711
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400F8E0 RID: 63712
	[CompilerGenerated]
	private Task<bool> task_0;

	// Token: 0x0400F8E1 RID: 63713
	private bool? nullable_0;

	// Token: 0x0400F8E2 RID: 63714
	private const string string_1 = "quest_{0}_isViewed";

	// Token: 0x0200303E RID: 12350
	[CompilerGenerated]
	[Serializable]
	private sealed class Class3100
	{
		// Token: 0x0600F2EA RID: 62186 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition x)
		{
			throw null;
		}

		// Token: 0x0400F8E3 RID: 63715
		public static readonly GClass1246.Class3100 class3100_0;

		// Token: 0x0400F8E4 RID: 63716
		public static Func<Condition, bool> func_0;
	}
}
