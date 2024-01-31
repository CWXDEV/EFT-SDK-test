using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;

// Token: 0x020021B6 RID: 8630
public sealed class GClass2457
{
	// Token: 0x17001DAA RID: 7594
	// (get) Token: 0x0600B13F RID: 45375 RVA: 0x00002050 File Offset: 0x00000250
	public bool Critical
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1400027A RID: 634
	// (add) Token: 0x0600B140 RID: 45376 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600B141 RID: 45377 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnBuffsUpdated
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

	// Token: 0x17001DAB RID: 7595
	// (get) Token: 0x0600B142 RID: 45378 RVA: 0x00002050 File Offset: 0x00000250
	public float TimeLeft
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B143 RID: 45379 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(GClass2456 description)
	{
		throw null;
	}

	// Token: 0x0600B144 RID: 45380 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Replace(List<GClass2455> newBuffs)
	{
		throw null;
	}

	// Token: 0x0600B145 RID: 45381 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(string name)
	{
		throw null;
	}

	// Token: 0x0600B146 RID: 45382 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InvokeInternalBuffChange()
	{
		throw null;
	}

	// Token: 0x0400B605 RID: 46597
	public Type Type;

	// Token: 0x0400B606 RID: 46598
	public List<GClass2455> Buffs;

	// Token: 0x0400B607 RID: 46599
	public float OverallDuration;

	// Token: 0x0400B608 RID: 46600
	public Func<float> WholeTime;

	// Token: 0x0400B609 RID: 46601
	public Func<EEffectState> EffectState;

	// Token: 0x0400B60A RID: 46602
	public GClass2457.EBuffType BuffType;

	// Token: 0x0400B60B RID: 46603
	public bool ExactTime;

	// Token: 0x0400B60C RID: 46604
	public Type[] HiddenByOtherEffectsAllOverBodyPart;

	// Token: 0x0400B60D RID: 46605
	[CompilerGenerated]
	private readonly bool bool_0;

	// Token: 0x0400B60E RID: 46606
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x020021B7 RID: 8631
	public enum EBuffType
	{
		// Token: 0x0400B610 RID: 46608
		Regular,
		// Token: 0x0400B611 RID: 46609
		Stackable,
		// Token: 0x0400B612 RID: 46610
		Stimulant
	}

	// Token: 0x020021B8 RID: 8632
	[CompilerGenerated]
	private sealed class Class1913
	{
		// Token: 0x0600B147 RID: 45383 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0()
		{
			throw null;
		}

		// Token: 0x0600B148 RID: 45384 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EEffectState method_1()
		{
			throw null;
		}

		// Token: 0x0400B613 RID: 46611
		public IEffect effect;
	}

	// Token: 0x020021B9 RID: 8633
	[CompilerGenerated]
	private sealed class Class1914
	{
		// Token: 0x0600B149 RID: 45385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0()
		{
			throw null;
		}

		// Token: 0x0600B14A RID: 45386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EEffectState method_1()
		{
			throw null;
		}

		// Token: 0x0400B614 RID: 46612
		public GInterface276 stimulator;
	}

	// Token: 0x020021BA RID: 8634
	[CompilerGenerated]
	private sealed class Class1915
	{
		// Token: 0x0600B14B RID: 45387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2455 x)
		{
			throw null;
		}

		// Token: 0x0400B615 RID: 46613
		public GClass2456 description;
	}

	// Token: 0x020021BB RID: 8635
	[CompilerGenerated]
	private sealed class Class1916
	{
		// Token: 0x0600B14C RID: 45388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2455 x)
		{
			throw null;
		}

		// Token: 0x0400B616 RID: 46614
		public string name;
	}
}
