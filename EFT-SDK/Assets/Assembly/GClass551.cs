using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000549 RID: 1353
public class GClass551
{
	// Token: 0x060020D3 RID: 8403 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass551.GInterface13 MakeTimer(float endTime, float duration, bool isLopped = false)
	{
		throw null;
	}

	// Token: 0x060020D4 RID: 8404 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass551.GInterface13 MakeTimer(TimeSpan duration, bool isLopped = false)
	{
		throw null;
	}

	// Token: 0x060020D5 RID: 8405 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x060020D6 RID: 8406 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GClass551.Class256 timer)
	{
		throw null;
	}

	// Token: 0x060020D7 RID: 8407 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopAllTimers()
	{
		throw null;
	}

	// Token: 0x04001F5F RID: 8031
	private LinkedList<GClass551.Class256> linkedList_0;

	// Token: 0x0200054A RID: 1354
	public interface GInterface13
	{
		// Token: 0x1400004D RID: 77
		// (add) Token: 0x060020D8 RID: 8408
		// (remove) Token: 0x060020D9 RID: 8409
		event Action OnTimer;

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060020DA RID: 8410
		float Duration { get; }

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060020DB RID: 8411
		float StartTime { get; }

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060020DC RID: 8412
		float EndTime { get; }

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060020DD RID: 8413
		float TimeLeft { get; }

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060020DE RID: 8414
		bool IsLoopped { get; }

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060020DF RID: 8415
		bool IsActive { get; }

		// Token: 0x060020E0 RID: 8416
		void Stop(bool shallFire = false);

		// Token: 0x060020E1 RID: 8417
		void Restart(float endTime);
	}

	// Token: 0x0200054B RID: 1355
	private class Class256 : GClass551.GInterface13
	{
		// Token: 0x1400004E RID: 78
		// (add) Token: 0x060020E2 RID: 8418 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060020E3 RID: 8419 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnTimer
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

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020E5 RID: 8421 RVA: 0x00002050 File Offset: 0x00000250
		public float EndTime
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

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x00002050 File Offset: 0x00000250
		public float Duration
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

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x00002050 File Offset: 0x00000250
		public float TimeLeft
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x00002050 File Offset: 0x00000250
		public float StartTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020EB RID: 8427 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsLoopped
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

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020ED RID: 8429 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsActive
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

		// Token: 0x060020EE RID: 8430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Action onStop, Action onStart)
		{
			throw null;
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start(float endTime, float duration, bool isLopped = false)
		{
			throw null;
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop(bool shallFire = false)
		{
			throw null;
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Fire()
		{
			throw null;
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Restart(float endTime)
		{
			throw null;
		}

		// Token: 0x04001F60 RID: 8032
		private Action action_0;

		// Token: 0x04001F61 RID: 8033
		private Action action_1;

		// Token: 0x04001F62 RID: 8034
		[CompilerGenerated]
		private Action action_2;

		// Token: 0x04001F63 RID: 8035
		[CompilerGenerated]
		private float float_0;

		// Token: 0x04001F64 RID: 8036
		[CompilerGenerated]
		private float float_1;

		// Token: 0x04001F65 RID: 8037
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04001F66 RID: 8038
		[CompilerGenerated]
		private bool bool_1;
	}

	// Token: 0x0200054C RID: 1356
	[CompilerGenerated]
	private sealed class Class257
	{
		// Token: 0x060020F3 RID: 8435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x04001F67 RID: 8039
		public GClass551 gclass551_0;

		// Token: 0x04001F68 RID: 8040
		public GClass551.Class256 timer;
	}
}
