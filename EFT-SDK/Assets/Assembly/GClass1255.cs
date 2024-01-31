using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001054 RID: 4180
public class GClass1255
{
	// Token: 0x140000F9 RID: 249
	// (add) Token: 0x0600572F RID: 22319 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005730 RID: 22320 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Enum, float> OnStartState
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

	// Token: 0x17000DC5 RID: 3525
	// (get) Token: 0x06005731 RID: 22321 RVA: 0x00002050 File Offset: 0x00000250
	public Enum CurrentState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06005732 RID: 22322 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06005733 RID: 22323 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoEvent(Enum @event)
	{
		throw null;
	}

	// Token: 0x06005734 RID: 22324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNextState(Enum state)
	{
		throw null;
	}

	// Token: 0x06005735 RID: 22325 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStateImmediate(Enum state)
	{
		throw null;
	}

	// Token: 0x06005736 RID: 22326 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddState(Enum state, float duration, Enum onTimeEndState, GClass1255.GDelegate36 action = null)
	{
		throw null;
	}

	// Token: 0x06005737 RID: 22327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddState(Enum state, GClass1255.GDelegate36 action = null)
	{
		throw null;
	}

	// Token: 0x06005738 RID: 22328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTransition(Enum fromState, Enum @event, Func<Enum> action)
	{
		throw null;
	}

	// Token: 0x06005739 RID: 22329 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTransition(Enum fromState, Enum @event, Func<bool> action, Enum toState)
	{
		throw null;
	}

	// Token: 0x0600573A RID: 22330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTransition(Enum fromState, Enum @event, Enum toState)
	{
		throw null;
	}

	// Token: 0x0600573B RID: 22331 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Enum fromState, Enum @event, Enum toState, Func<bool> action)
	{
		throw null;
	}

	// Token: 0x0600573C RID: 22332 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Enum state, float duration)
	{
		throw null;
	}

	// Token: 0x0600573D RID: 22333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FixCurrentStateDuration(float newDuration)
	{
		throw null;
	}

	// Token: 0x0600573E RID: 22334 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStateDuration(Enum state, float newDuration)
	{
		throw null;
	}

	// Token: 0x0600573F RID: 22335 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2()
	{
		throw null;
	}

	// Token: 0x040062FB RID: 25339
	private GClass1255.Class808[] class808_0;

	// Token: 0x040062FC RID: 25340
	[CompilerGenerated]
	private Action<Enum, float> action_0;

	// Token: 0x040062FD RID: 25341
	private GClass1255.Class808 class808_1;

	// Token: 0x040062FE RID: 25342
	private GClass1255.Class808 class808_2;

	// Token: 0x040062FF RID: 25343
	private GClass1255.Class808 class808_3;

	// Token: 0x04006300 RID: 25344
	private float float_0;

	// Token: 0x02001055 RID: 4181
	private class Class808
	{
		// Token: 0x06005740 RID: 22336 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(Enum my, GClass1255.GDelegate36 action, float duration, int onTimeEndState)
		{
			throw null;
		}

		// Token: 0x04006301 RID: 25345
		public Enum My;

		// Token: 0x04006302 RID: 25346
		public GClass1255.GDelegate36 Action;

		// Token: 0x04006303 RID: 25347
		public float Duration;

		// Token: 0x04006304 RID: 25348
		public Dictionary<int, GClass1255.Class810> Events;

		// Token: 0x04006305 RID: 25349
		public int OnTimeEndState;

		// Token: 0x04006306 RID: 25350
		private static readonly GClass1255.GDelegate36 gdelegate36_0;

		// Token: 0x02001056 RID: 4182
		[CompilerGenerated]
		[Serializable]
		private sealed class Class809
		{
			// Token: 0x06005741 RID: 22337 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool s, bool e)
			{
				throw null;
			}

			// Token: 0x04006307 RID: 25351
			public static readonly GClass1255.Class808.Class809 class809_0;
		}
	}

	// Token: 0x02001057 RID: 4183
	private class Class810
	{
		// Token: 0x06005742 RID: 22338 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetNextState()
		{
			throw null;
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddCase(Func<bool> action, int state)
		{
			throw null;
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFunc(Func<Enum> func)
		{
			throw null;
		}

		// Token: 0x04006308 RID: 25352
		private List<GClass1255.Class810.Class811> list_0;

		// Token: 0x04006309 RID: 25353
		private Func<Enum> func_0;

		// Token: 0x0400630A RID: 25354
		public int DefaultState;

		// Token: 0x02001058 RID: 4184
		private class Class811
		{
			// Token: 0x0400630B RID: 25355
			public Func<bool> _action;

			// Token: 0x0400630C RID: 25356
			public int _state;
		}
	}

	// Token: 0x02001059 RID: 4185
	// (Invoke) Token: 0x06005745 RID: 22341
	public delegate void GDelegate36(bool start, bool end);

	// Token: 0x0200105A RID: 4186
	[CompilerGenerated]
	[Serializable]
	private sealed class Class812
	{
		// Token: 0x06005748 RID: 22344 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Enum e, float f)
		{
			throw null;
		}

		// Token: 0x0400630D RID: 25357
		public static readonly GClass1255.Class812 class812_0;

		// Token: 0x0400630E RID: 25358
		public static Action<Enum, float> action_0;
	}
}
