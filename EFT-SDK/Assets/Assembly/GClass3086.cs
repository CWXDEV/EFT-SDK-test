using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Token: 0x02002C83 RID: 11395
public abstract class GClass3086<T> : GClass3085
{
	// Token: 0x14000316 RID: 790
	// (add) Token: 0x0600E077 RID: 57463 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E078 RID: 57464 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnAccept
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

	// Token: 0x14000317 RID: 791
	// (add) Token: 0x0600E079 RID: 57465 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E07A RID: 57466 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnDecline
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

	// Token: 0x14000318 RID: 792
	// (add) Token: 0x0600E07B RID: 57467 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E07C RID: 57468 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnCloseSilent
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

	// Token: 0x1700272B RID: 10027
	// (get) Token: 0x0600E07D RID: 57469 RVA: 0x00002050 File Offset: 0x00000250
	public Task<T> AcceptResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700272C RID: 10028
	// (get) Token: 0x0600E07E RID: 57470 RVA: 0x00002050 File Offset: 0x00000250
	public Task<T> WindowResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700272D RID: 10029
	// (get) Token: 0x0600E07F RID: 57471 RVA: 0x00002050 File Offset: 0x00000250
	private TaskCompletionSource<T> TaskCompletionSource_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700272E RID: 10030
	// (get) Token: 0x0600E080 RID: 57472 RVA: 0x00002050 File Offset: 0x00000250
	private TaskCompletionSource<T> TaskCompletionSource_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600E081 RID: 57473 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0(T value)
	{
		throw null;
	}

	// Token: 0x0600E082 RID: 57474 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1(T value)
	{
		throw null;
	}

	// Token: 0x0600E083 RID: 57475 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Decline()
	{
		throw null;
	}

	// Token: 0x0600E084 RID: 57476 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseSilent()
	{
		throw null;
	}

	// Token: 0x0600E085 RID: 57477 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Close()
	{
		throw null;
	}

	// Token: 0x0600E086 RID: 57478 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(T result)
	{
		throw null;
	}

	// Token: 0x0400E52C RID: 58668
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400E52D RID: 58669
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x0400E52E RID: 58670
	[CompilerGenerated]
	private Action action_3;

	// Token: 0x0400E52F RID: 58671
	private TaskCompletionSource<T> taskCompletionSource_0;

	// Token: 0x0400E530 RID: 58672
	private bool bool_0;

	// Token: 0x0400E531 RID: 58673
	private T gparam_0;

	// Token: 0x0400E532 RID: 58674
	private TaskCompletionSource<T> taskCompletionSource_1;
}
