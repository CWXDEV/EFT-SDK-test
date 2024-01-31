using System;
using System.Runtime.CompilerServices;
using Diz.Binding;
using EFT;

// Token: 0x0200165E RID: 5726
public class GClass1765 : GClass1763
{
	// Token: 0x17001392 RID: 5010
	// (get) Token: 0x06007C22 RID: 31778 RVA: 0x00002050 File Offset: 0x00000250
	public SkillManager SkillManager
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001393 RID: 5011
	// (get) Token: 0x06007C23 RID: 31779 RVA: 0x00002050 File Offset: 0x00000250
	public int LevelExp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001394 RID: 5012
	// (get) Token: 0x06007C24 RID: 31780 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsEliteLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001395 RID: 5013
	// (get) Token: 0x06007C25 RID: 31781 RVA: 0x00002050 File Offset: 0x00000250
	public override float PointsEarned
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001396 RID: 5014
	// (get) Token: 0x06007C26 RID: 31782 RVA: 0x00002050 File Offset: 0x00000250
	public override float Effectiveness
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06007C27 RID: 31783 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFromServer(GStruct207 skillPacket, bool silent = false)
	{
		throw null;
	}

	// Token: 0x06007C28 RID: 31784 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFromInfo(GClass1780.GClass1781 skillInfo)
	{
		throw null;
	}

	// Token: 0x06007C29 RID: 31785 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetPointsEarnedInSession(float fatigue, bool updateEffectiveness = true)
	{
		throw null;
	}

	// Token: 0x06007C2A RID: 31786 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float CalculateExpOnFirstLevels(float val)
	{
		throw null;
	}

	// Token: 0x06007C2B RID: 31787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_1(int level)
	{
		throw null;
	}

	// Token: 0x06007C2C RID: 31788 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_2(float input)
	{
		throw null;
	}

	// Token: 0x06007C2D RID: 31789 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LevelChanged()
	{
		throw null;
	}

	// Token: 0x06007C2E RID: 31790 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06007C2F RID: 31791 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnTrigger(SkillManager.GClass1777 skillAction, float val)
	{
		throw null;
	}

	// Token: 0x17001397 RID: 5015
	// (get) Token: 0x06007C30 RID: 31792 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007C31 RID: 31793 RVA: 0x00002050 File Offset: 0x00000250
	public override int Buff
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

	// Token: 0x06007C32 RID: 31794 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLevel(int level)
	{
		throw null;
	}

	// Token: 0x04008279 RID: 33401
	public const int MAX_LEVEL = 50;

	// Token: 0x0400827A RID: 33402
	public const int DEFAULT_EXP_LEVEL = 9;

	// Token: 0x0400827B RID: 33403
	public const int ADDITIONAL_EXP_PER_LEVEL = 10;

	// Token: 0x0400827C RID: 33404
	public readonly SkillManager.GClass1770[] Buffs;

	// Token: 0x0400827D RID: 33405
	public readonly ESkillClass Class;

	// Token: 0x0400827E RID: 33406
	private float float_1;

	// Token: 0x0400827F RID: 33407
	private float float_2;

	// Token: 0x04008280 RID: 33408
	private float float_3;

	// Token: 0x04008281 RID: 33409
	public readonly BindableEvent OnLevelUp;

	// Token: 0x04008282 RID: 33410
	[CompilerGenerated]
	private readonly SkillManager skillManager_0;

	// Token: 0x04008283 RID: 33411
	public readonly bool Locked;
}
