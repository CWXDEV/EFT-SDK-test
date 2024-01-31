using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x0200256D RID: 9581
public abstract class GClass2809 : IDisposable
{
	// Token: 0x1700222C RID: 8748
	// (get) Token: 0x0600BF9A RID: 49050 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual IEnumerable<EItemViewComponent> ViewComponents
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700222D RID: 8749
	// (get) Token: 0x0600BF9B RID: 49051 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600BF9C RID: 49052 RVA: 0x00002050 File Offset: 0x00000250
	public virtual GClass3283 Error
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x140002B6 RID: 694
	// (add) Token: 0x0600BF9D RID: 49053 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BF9E RID: 49054 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnUpdate
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

	// Token: 0x140002B7 RID: 695
	// (add) Token: 0x0600BF9F RID: 49055 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BFA0 RID: 49056 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnCloseWindow
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

	// Token: 0x140002B8 RID: 696
	// (add) Token: 0x0600BFA1 RID: 49057 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BFA2 RID: 49058 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnDragStateChange
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

	// Token: 0x140002B9 RID: 697
	// (add) Token: 0x0600BFA3 RID: 49059 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BFA4 RID: 49060 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<InventoryError> OnInventoryError
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

	// Token: 0x140002BA RID: 698
	// (add) Token: 0x0600BFA5 RID: 49061 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BFA6 RID: 49062 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass2821> OnCheckAccept
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

	// Token: 0x140002BB RID: 699
	// (add) Token: 0x0600BFA7 RID: 49063 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BFA8 RID: 49064 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnDisposed
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

	// Token: 0x1700222E RID: 8750
	// (get) Token: 0x0600BFA9 RID: 49065 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600BFAA RID: 49066 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	private GClass2809 GClass2809_0
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

	// Token: 0x1700222F RID: 8751
	// (get) Token: 0x0600BFAB RID: 49067 RVA: 0x00002050 File Offset: 0x00000250
	private GClass2809 GClass2809_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002230 RID: 8752
	// (get) Token: 0x0600BFAC RID: 49068 RVA: 0x00002050 File Offset: 0x00000250
	public virtual ItemRotation? RotationLock
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002231 RID: 8753
	// (get) Token: 0x0600BFAD RID: 49069 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool ModificationAvailable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002232 RID: 8754
	// (get) Token: 0x0600BFAE RID: 49070 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool DragAvailable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002233 RID: 8755
	// (get) Token: 0x0600BFAF RID: 49071 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool SplitAvailable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002234 RID: 8756
	// (get) Token: 0x0600BFB0 RID: 49072 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool MergeAvailable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002235 RID: 8757
	// (set) Token: 0x0600BFB1 RID: 49073 RVA: 0x00002050 File Offset: 0x00000250
	public InventoryError InventoryError
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x0600BFB2 RID: 49074
	public abstract GClass2809 CreateChild(Item item);

	// Token: 0x17002236 RID: 8758
	// (get) Token: 0x0600BFB3 RID: 49075 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsPreviewHighlightAvailable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BFB4 RID: 49076 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GClass3021<EItemInfoButton> GetItemContextInteractions(Action closeAction)
	{
		throw null;
	}

	// Token: 0x0600BFB5 RID: 49077 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600BFB6 RID: 49078 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanQuickMoveTo(ETargetContainer targetContainer)
	{
		throw null;
	}

	// Token: 0x0600BFB7 RID: 49079 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOperationAllowed(GInterface321 operation)
	{
		throw null;
	}

	// Token: 0x0600BFB8 RID: 49080 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasViewComponent(EItemViewComponent viewComponent)
	{
		throw null;
	}

	// Token: 0x0600BFB9 RID: 49081 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DragStarted()
	{
		throw null;
	}

	// Token: 0x0600BFBA RID: 49082 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DragCancelled()
	{
		throw null;
	}

	// Token: 0x0600BFBB RID: 49083 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CheckAccept(GClass2821 itemContext)
	{
		throw null;
	}

	// Token: 0x0600BFBC RID: 49084 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateView()
	{
		throw null;
	}

	// Token: 0x0600BFBD RID: 49085 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CloseDependentWindows()
	{
		throw null;
	}

	// Token: 0x0600BFBE RID: 49086 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InventoryErrorHandler(InventoryError error)
	{
		throw null;
	}

	// Token: 0x0600BFBF RID: 49087 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void SwitchToParentsSource()
	{
		throw null;
	}

	// Token: 0x0600BFC0 RID: 49088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600BFC1 RID: 49089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0600BFC2 RID: 49090 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x0400C17E RID: 49534
	public readonly Item Item;

	// Token: 0x0400C17F RID: 49535
	public readonly EItemViewType ViewType;

	// Token: 0x0400C180 RID: 49536
	public bool Searched;

	// Token: 0x0400C181 RID: 49537
	private static EItemViewComponent[] eitemViewComponent_0;

	// Token: 0x0400C182 RID: 49538
	[CompilerGenerated]
	private GClass3283 gclass3283_0;

	// Token: 0x0400C183 RID: 49539
	private ETargetContainer etargetContainer_0;

	// Token: 0x0400C184 RID: 49540
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400C185 RID: 49541
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400C186 RID: 49542
	[CompilerGenerated]
	private Action<bool> action_2;

	// Token: 0x0400C187 RID: 49543
	[CompilerGenerated]
	private Action<InventoryError> action_3;

	// Token: 0x0400C188 RID: 49544
	[CompilerGenerated]
	private Action<GClass2821> action_4;

	// Token: 0x0400C189 RID: 49545
	[CompilerGenerated]
	private Action action_5;

	// Token: 0x0400C18A RID: 49546
	[CanBeNull]
	private GClass2809 gclass2809_0;
}
