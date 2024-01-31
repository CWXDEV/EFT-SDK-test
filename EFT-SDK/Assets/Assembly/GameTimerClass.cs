using System;
using System.Runtime.CompilerServices;

// Token: 0x020012F9 RID: 4857
public sealed class GameTimerClass
{
	// Token: 0x1700103A RID: 4154
	// (get) Token: 0x060064B7 RID: 25783 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060064B8 RID: 25784 RVA: 0x00002050 File Offset: 0x00000250
	public GameTimerClass.EGameTimerStatus Status
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

	// Token: 0x1700103B RID: 4155
	// (get) Token: 0x060064B9 RID: 25785 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060064BA RID: 25786 RVA: 0x00002050 File Offset: 0x00000250
	public TimeSpan? SessionTime
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

	// Token: 0x1700103C RID: 4156
	// (get) Token: 0x060064BB RID: 25787 RVA: 0x00002050 File Offset: 0x00000250
	public DateTime? StartDateTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700103D RID: 4157
	// (get) Token: 0x060064BC RID: 25788 RVA: 0x00002050 File Offset: 0x00000250
	public DateTime? EscapeDateTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700103E RID: 4158
	// (get) Token: 0x060064BD RID: 25789 RVA: 0x00002050 File Offset: 0x00000250
	public TimeSpan PastTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700103F RID: 4159
	// (get) Token: 0x060064BE RID: 25790 RVA: 0x00002050 File Offset: 0x00000250
	public DateTime StopDateTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x14000118 RID: 280
	// (add) Token: 0x060064BF RID: 25791 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060064C0 RID: 25792 RVA: 0x00002050 File Offset: 0x00000250
	public event Action StartedEvent
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

	// Token: 0x14000119 RID: 281
	// (add) Token: 0x060064C1 RID: 25793 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060064C2 RID: 25794 RVA: 0x00002050 File Offset: 0x00000250
	public event Action StoppedEvent
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

	// Token: 0x1400011A RID: 282
	// (add) Token: 0x060064C3 RID: 25795 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060064C4 RID: 25796 RVA: 0x00002050 File Offset: 0x00000250
	public event Action SessionTimeChanged
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

	// Token: 0x060064C5 RID: 25797 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start(DateTime? startTime = null, TimeSpan? sessionTime = null)
	{
		throw null;
	}

	// Token: 0x060064C6 RID: 25798 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		throw null;
	}

	// Token: 0x060064C7 RID: 25799 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSessionTime(TimeSpan sessionTime)
	{
		throw null;
	}

	// Token: 0x060064C8 RID: 25800 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private TimeSpan method_0()
	{
		throw null;
	}

	// Token: 0x04007126 RID: 28966
	private DateTime? nullable_0;

	// Token: 0x04007127 RID: 28967
	private DateTime? nullable_1;

	// Token: 0x04007128 RID: 28968
	private DateTime? nullable_2;

	// Token: 0x04007129 RID: 28969
	[CompilerGenerated]
	private GameTimerClass.EGameTimerStatus egameTimerStatus_0;

	// Token: 0x0400712A RID: 28970
	[CompilerGenerated]
	private TimeSpan? nullable_3;

	// Token: 0x0400712B RID: 28971
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400712C RID: 28972
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400712D RID: 28973
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x020012FA RID: 4858
	public enum EGameTimerStatus
	{
		// Token: 0x0400712F RID: 28975
		Unknown,
		// Token: 0x04007130 RID: 28976
		Started,
		// Token: 0x04007131 RID: 28977
		Stopped
	}
}
