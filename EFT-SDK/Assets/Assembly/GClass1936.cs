using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x02001C50 RID: 7248
public class GClass1936
{
	// Token: 0x17001744 RID: 5956
	// (get) Token: 0x06009778 RID: 38776 RVA: 0x00002050 File Offset: 0x00000250
	public bool Enabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001745 RID: 5957
	// (get) Token: 0x06009779 RID: 38777 RVA: 0x00002050 File Offset: 0x00000250
	public bool Disabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600977A RID: 38778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task Start(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600977B RID: 38779 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task Complete(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600977C RID: 38780 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Cancel()
	{
		throw null;
	}

	// Token: 0x0600977D RID: 38781 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStart(Action callback)
	{
		throw null;
	}

	// Token: 0x0600977E RID: 38782 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnComplete(Action callback)
	{
		throw null;
	}

	// Token: 0x0600977F RID: 38783 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCancel(Action callback)
	{
		throw null;
	}

	// Token: 0x04009EDF RID: 40671
	private Action action_0;

	// Token: 0x04009EE0 RID: 40672
	private Action action_1;

	// Token: 0x04009EE1 RID: 40673
	private Action action_2;

	// Token: 0x04009EE2 RID: 40674
	private bool bool_0;
}
