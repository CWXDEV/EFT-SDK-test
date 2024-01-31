using System;
using System.Runtime.CompilerServices;
using EFT.NextObservedPlayer;

// Token: 0x02001FA9 RID: 8105
public abstract class GClass2309<T, U> : GInterface222, GInterface223 where U : GInterface221
{
	// Token: 0x17001B8B RID: 7051
	// (get) Token: 0x0600A7E5 RID: 42981 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2308 Callbacks
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001B8C RID: 7052
	// (get) Token: 0x0600A7E6 RID: 42982 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool CanFastForward
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A7E7 RID: 42983
	public abstract U Start(T input);

	// Token: 0x0600A7E8 RID: 42984 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetController(BaseAnimationHandsController controller)
	{
		throw null;
	}

	// Token: 0x0600A7E9 RID: 42985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Entry(GInterface223 from)
	{
		throw null;
	}

	// Token: 0x0600A7EA RID: 42986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Transition(Type toOperation, GInterface223 operation)
	{
		throw null;
	}

	// Token: 0x0600A7EB RID: 42987 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Exit(GInterface223 to)
	{
		throw null;
	}

	// Token: 0x0600A7EC RID: 42988
	public abstract void FastForward();

	// Token: 0x0600A7ED RID: 42989 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CheckAbort(CommandMessageType messageType)
	{
		throw null;
	}

	// Token: 0x0400AEBB RID: 44731
	protected BaseAnimationHandsController baseAnimationHandsController_0;

	// Token: 0x0400AEBC RID: 44732
	[CompilerGenerated]
	private readonly GClass2308 gclass2308_0;
}
