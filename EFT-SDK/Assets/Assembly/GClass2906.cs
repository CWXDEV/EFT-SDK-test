using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x0200264C RID: 9804
public class GClass2906 : GClass2885
{
	// Token: 0x170022C5 RID: 8901
	// (get) Token: 0x0600C290 RID: 49808 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2906.EInteractState InteractState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170022C6 RID: 8902
	// (get) Token: 0x0600C291 RID: 49809 RVA: 0x00002050 File Offset: 0x00000250
	public IPlayer InteractingPlayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C292 RID: 49810 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Invoke(IPlayer interactingPlayer, bool entered)
	{
		throw null;
	}

	// Token: 0x0600C293 RID: 49811 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x0400C430 RID: 50224
	private GClass2906.EInteractState einteractState_0;

	// Token: 0x0400C431 RID: 50225
	private IPlayer iplayer_0;

	// Token: 0x0200264D RID: 9805
	public enum EInteractState
	{
		// Token: 0x0400C433 RID: 50227
		None,
		// Token: 0x0400C434 RID: 50228
		MyPlayerEntered,
		// Token: 0x0400C435 RID: 50229
		MyPlayerExited,
		// Token: 0x0400C436 RID: 50230
		PlayerEntered = 1,
		// Token: 0x0400C437 RID: 50231
		PlayerExited
	}
}
