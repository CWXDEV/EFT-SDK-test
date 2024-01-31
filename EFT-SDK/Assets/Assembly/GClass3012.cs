using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Token: 0x02002928 RID: 10536
public abstract class GClass3012 : IDisposable
{
	// Token: 0x17002575 RID: 9589
	// (get) Token: 0x0600D264 RID: 53860 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600D265 RID: 53861 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool StateReady
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x140002E3 RID: 739
	// (add) Token: 0x0600D266 RID: 53862 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600D267 RID: 53863 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnStateReady
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

	// Token: 0x17002576 RID: 9590
	// (get) Token: 0x0600D268 RID: 53864 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual float TransitionDuration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002577 RID: 9591
	// (get) Token: 0x0600D269 RID: 53865 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual float PreviewAnimationDuration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600D26A RID: 53866 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task ShowState()
	{
		throw null;
	}

	// Token: 0x0600D26B RID: 53867 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task HideState()
	{
		throw null;
	}

	// Token: 0x0600D26C RID: 53868 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0(bool enabled)
	{
		throw null;
	}

	// Token: 0x0600D26D RID: 53869 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Close()
	{
		throw null;
	}

	// Token: 0x0600D26E RID: 53870 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400D3C1 RID: 54209
	[SerializeField]
	private CanvasGroup _stateCanvasGroup;

	// Token: 0x0400D3C2 RID: 54210
	private bool bool_0;

	// Token: 0x0400D3C3 RID: 54211
	protected readonly GClass763 gclass763_0;

	// Token: 0x0400D3C4 RID: 54212
	[CompilerGenerated]
	private Action<bool> action_0;
}
