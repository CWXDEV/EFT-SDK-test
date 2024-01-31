using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F48 RID: 3912
public abstract class GClass1112 : GClass1105, GInterface69
{
	// Token: 0x17000CBF RID: 3263
	// (get) Token: 0x060051FB RID: 20987
	public abstract bool Loop { get; }

	// Token: 0x060051FC RID: 20988 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ResetCache()
	{
		throw null;
	}

	// Token: 0x17000CC0 RID: 3264
	// (get) Token: 0x060051FD RID: 20989 RVA: 0x00002050 File Offset: 0x00000250
	public int OutTransitionsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060051FE RID: 20990 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1111 GetOutTransition(int outTransitionIndex)
	{
		throw null;
	}

	// Token: 0x17000CC1 RID: 3265
	// (get) Token: 0x060051FF RID: 20991
	protected abstract float RealMotionDuration { get; }

	// Token: 0x17000CC2 RID: 3266
	// (get) Token: 0x06005200 RID: 20992 RVA: 0x00002050 File Offset: 0x00000250
	public float Real
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000CC3 RID: 3267
	// (get) Token: 0x06005201 RID: 20993 RVA: 0x00002050 File Offset: 0x00000250
	public float MotionDuration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000CC4 RID: 3268
	// (get) Token: 0x06005202 RID: 20994 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1106 ParentStateMachine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06005203 RID: 20995 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<GClass1111> GetOutTransitions()
	{
		throw null;
	}

	// Token: 0x06005204 RID: 20996 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStateEnter(GClass1134 fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x06005205 RID: 20997 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStateUpdate(GClass1134 fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x06005206 RID: 20998 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStateExit(GClass1134 fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x06005207 RID: 20999 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStateMove(GClass1134 fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x06005208 RID: 21000 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x06005209 RID: 21001 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnParameterValueChanged()
	{
		throw null;
	}

	// Token: 0x0600520A RID: 21002 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1111 GetInterruptedTriggeredTransition(GClass1112 current, GClass1112 next, float currentStateAbsTime, float nextStateAbsTime, float dt, GClass1111 currentTransition)
	{
		throw null;
	}

	// Token: 0x0600520B RID: 21003 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1111 GetTriggeredTransition(float absoluteStartFrameTime, float absoluteEndFrameTime)
	{
		throw null;
	}

	// Token: 0x0600520C RID: 21004 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(GClass1111 currentTransition, GClass1111 transition)
	{
		throw null;
	}

	// Token: 0x0600520D RID: 21005 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
		throw null;
	}

	// Token: 0x0600520E RID: 21006 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkDependentParameterDirty()
	{
		throw null;
	}

	// Token: 0x0600520F RID: 21007 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkTransitionDirty()
	{
		throw null;
	}

	// Token: 0x04005DBE RID: 23998
	internal GClass1106 gclass1106_0;

	// Token: 0x04005DBF RID: 23999
	internal List<GClass1111> list_0;

	// Token: 0x04005DC0 RID: 24000
	internal readonly float float_0;

	// Token: 0x04005DC1 RID: 24001
	internal readonly GClass1118 gclass1118_0;

	// Token: 0x04005DC2 RID: 24002
	public List<GClass1111> _outTransitions__WITH_EXIT_TIME;

	// Token: 0x04005DC3 RID: 24003
	private bool bool_0;

	// Token: 0x04005DC4 RID: 24004
	public List<GClass1111> _outTransitions__NO_EXIT_TIME;

	// Token: 0x04005DC5 RID: 24005
	private bool bool_1;

	// Token: 0x04005DC6 RID: 24006
	private bool bool_2;

	// Token: 0x04005DC7 RID: 24007
	private bool bool_3;

	// Token: 0x04005DC8 RID: 24008
	private float float_1;
}
