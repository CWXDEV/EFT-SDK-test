using System;
using System.Runtime.CompilerServices;

// Token: 0x0200010F RID: 271
public abstract class AICoreLayerClass<T>
{
	// Token: 0x14000008 RID: 8
	// (add) Token: 0x060005C2 RID: 1474 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060005C3 RID: 1475 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<AICoreActionEndStruct> OnEndCurDecision
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

	// Token: 0x14000009 RID: 9
	// (add) Token: 0x060005C4 RID: 1476 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<AICoreActionResultStruct<T>> OnStartCurDecision
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

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x060005C6 RID: 1478
	public abstract int Priority { get; }

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x060005C9 RID: 1481
	public abstract AICoreActionResultStruct<T> GetDecision();

	// Token: 0x060005CA RID: 1482
	public abstract AICoreActionEndStruct ShallEndCurrentDecision(AICoreActionResultStruct<T> curDecision);

	// Token: 0x060005CB RID: 1483
	public abstract bool ShallUseNow();

	// Token: 0x060005CC RID: 1484 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetCustomData()
	{
		throw null;
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AICoreActionResultStruct<T>? Update(AICoreActionResultStruct<T>? prevDecision)
	{
		throw null;
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DecisionChanged(AICoreActionResultStruct<T>? prevDecision, AICoreActionResultStruct<T> nextDecision)
	{
		throw null;
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnActivate()
	{
		throw null;
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x060005D2 RID: 1490
	public abstract string Name();

	// Token: 0x060005D3 RID: 1491 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x040006CB RID: 1739
	[CompilerGenerated]
	private Action<AICoreActionEndStruct> action_0;

	// Token: 0x040006CC RID: 1740
	[CompilerGenerated]
	private Action<AICoreActionResultStruct<T>> action_1;

	// Token: 0x040006CD RID: 1741
	[CompilerGenerated]
	private bool bool_0;
}
