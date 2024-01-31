using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B9A RID: 2970
internal class Class608
{
	// Token: 0x17000A70 RID: 2672
	// (get) Token: 0x06004075 RID: 16501 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004076 RID: 16502 RVA: 0x00002050 File Offset: 0x00000250
	public bool On
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

	// Token: 0x17000A71 RID: 2673
	// (get) Token: 0x06004077 RID: 16503 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004078 RID: 16504 RVA: 0x00002050 File Offset: 0x00000250
	public bool InProcess
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

	// Token: 0x17000A72 RID: 2674
	// (get) Token: 0x06004079 RID: 16505 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600407A RID: 16506 RVA: 0x00002050 File Offset: 0x00000250
	public float Value
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

	// Token: 0x17000A73 RID: 2675
	// (get) Token: 0x0600407B RID: 16507 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600407C RID: 16508 RVA: 0x00002050 File Offset: 0x00000250
	public AnimationCurve SwitchingOn
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

	// Token: 0x17000A74 RID: 2676
	// (get) Token: 0x0600407D RID: 16509 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600407E RID: 16510 RVA: 0x00002050 File Offset: 0x00000250
	public AnimationCurve SwitchingOff
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

	// Token: 0x0600407F RID: 16511 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Process(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06004080 RID: 16512 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Switch(bool on)
	{
		throw null;
	}

	// Token: 0x06004081 RID: 16513 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForceSwitch(bool on)
	{
		throw null;
	}

	// Token: 0x06004082 RID: 16514 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCase(float time, Action stateChangedCallback, bool switchingOn)
	{
		throw null;
	}

	// Token: 0x06004083 RID: 16515 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private SortedList<float, Action> method_0(bool on)
	{
		throw null;
	}

	// Token: 0x06004084 RID: 16516 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x04004957 RID: 18775
	private AnimationCurve animationCurve_0;

	// Token: 0x04004958 RID: 18776
	private AnimationCurve animationCurve_1;

	// Token: 0x04004959 RID: 18777
	private float float_0;

	// Token: 0x0400495A RID: 18778
	private float float_1;

	// Token: 0x0400495B RID: 18779
	private float float_2;

	// Token: 0x0400495C RID: 18780
	private SortedList<float, Action> sortedList_0;

	// Token: 0x0400495D RID: 18781
	private SortedList<float, Action> sortedList_1;

	// Token: 0x0400495E RID: 18782
	private IEnumerator<KeyValuePair<float, Action>> ienumerator_0;

	// Token: 0x0400495F RID: 18783
	private float float_3;

	// Token: 0x04004960 RID: 18784
	private Class608.EState estate_0;

	// Token: 0x04004961 RID: 18785
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04004962 RID: 18786
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x04004963 RID: 18787
	[CompilerGenerated]
	private float float_4;

	// Token: 0x02000B9B RID: 2971
	private enum EState
	{
		// Token: 0x04004965 RID: 18789
		Off,
		// Token: 0x04004966 RID: 18790
		On,
		// Token: 0x04004967 RID: 18791
		SwitchingOff = 3,
		// Token: 0x04004968 RID: 18792
		SwitchingOn = 2
	}
}
