using System;
using System.Runtime.CompilerServices;
using Diz.Binding;
using EFT;

// Token: 0x0200163A RID: 5690
public abstract class GClass1763
{
	// Token: 0x17001378 RID: 4984
	// (get) Token: 0x06007B8B RID: 31627 RVA: 0x00002050 File Offset: 0x00000250
	public SkillManager.GClass1777[] Actions
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001379 RID: 4985
	// (get) Token: 0x06007B8C RID: 31628 RVA: 0x00002050 File Offset: 0x00000250
	public int Level
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700137A RID: 4986
	// (get) Token: 0x06007B8D RID: 31629 RVA: 0x00002050 File Offset: 0x00000250
	public int SummaryLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700137B RID: 4987
	// (get) Token: 0x06007B8E RID: 31630 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007B8F RID: 31631 RVA: 0x00002050 File Offset: 0x00000250
	public virtual int Buff
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

	// Token: 0x06007B90 RID: 31632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetLevelForValue(float value)
	{
		throw null;
	}

	// Token: 0x1700137C RID: 4988
	// (get) Token: 0x06007B91 RID: 31633 RVA: 0x00002050 File Offset: 0x00000250
	public virtual float PointsEarned
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700137D RID: 4989
	// (get) Token: 0x06007B92 RID: 31634 RVA: 0x00002050 File Offset: 0x00000250
	public virtual float Effectiveness
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700137E RID: 4990
	// (get) Token: 0x06007B93 RID: 31635 RVA: 0x00002050 File Offset: 0x00000250
	public virtual float LevelProgress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06007B94 RID: 31636 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnTrigger(SkillManager.GClass1777 skillAction, float val)
	{
		throw null;
	}

	// Token: 0x06007B95 RID: 31637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetPointsEarnedInSession(float fatigue, bool updateEffectiveness = true)
	{
		throw null;
	}

	// Token: 0x06007B96 RID: 31638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_0(float value)
	{
		throw null;
	}

	// Token: 0x06007B97 RID: 31639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetCurrent(float value, bool silent = false)
	{
		throw null;
	}

	// Token: 0x06007B98 RID: 31640 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void LevelChanged()
	{
		throw null;
	}

	// Token: 0x06007B99 RID: 31641 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Unsubscribe()
	{
		throw null;
	}

	// Token: 0x06007B9A RID: 31642 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFromAnother(GClass1763 skill)
	{
		throw null;
	}

	// Token: 0x0400809A RID: 32922
	protected const float float_0 = 100f;

	// Token: 0x0400809B RID: 32923
	public const int MAX_LEVEL_W_BUFF = 60;

	// Token: 0x0400809C RID: 32924
	public ESkillId Id;

	// Token: 0x0400809D RID: 32925
	[NonSerialized]
	public readonly BindableEvent SkillLevelChanged;

	// Token: 0x0400809E RID: 32926
	[NonSerialized]
	public readonly BindableEvent SkillExperienceChanged;

	// Token: 0x0400809F RID: 32927
	public float Current;

	// Token: 0x040080A0 RID: 32928
	public DateTime LastCall;

	// Token: 0x040080A1 RID: 32929
	protected int int_0;

	// Token: 0x040080A2 RID: 32930
	[CompilerGenerated]
	private readonly SkillManager.GClass1777[] gclass1777_0;
}
