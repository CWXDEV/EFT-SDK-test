using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x02003083 RID: 12419
public sealed class GClass3253
{
	// Token: 0x1400036F RID: 879
	// (add) Token: 0x0600F394 RID: 62356 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F395 RID: 62357 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEnumerable<DailyQuestClass>, bool> OnDailyQuestsUpdated
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

	// Token: 0x0600F396 RID: 62358 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Run()
	{
		throw null;
	}

	// Token: 0x0600F397 RID: 62359 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0()
	{
		throw null;
	}

	// Token: 0x0600F398 RID: 62360 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<int> method_1()
	{
		throw null;
	}

	// Token: 0x0600F399 RID: 62361 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopUpdating()
	{
		throw null;
	}

	// Token: 0x0600F39A RID: 62362 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0400F9E7 RID: 63975
	private const int int_0 = 30;

	// Token: 0x0400F9E8 RID: 63976
	[CompilerGenerated]
	private Action<IEnumerable<DailyQuestClass>, bool> action_0;

	// Token: 0x0400F9E9 RID: 63977
	private readonly ISession ginterface145_0;

	// Token: 0x0400F9EA RID: 63978
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400F9EB RID: 63979
	private readonly TaskCompletionSource<bool> taskCompletionSource_0;

	// Token: 0x02003085 RID: 12421
	[CompilerGenerated]
	[Serializable]
	private sealed class Class3127
	{
		// Token: 0x0600F39D RID: 62365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(DailyQuestClass questRange)
		{
			throw null;
		}

		// Token: 0x0400F9F1 RID: 63985
		public static readonly GClass3253.Class3127 class3127_0;

		// Token: 0x0400F9F2 RID: 63986
		public static Func<DailyQuestClass, int> func_0;
	}
}
