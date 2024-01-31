using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02002642 RID: 9794
public class GClass2898 : GClass2885
{
	// Token: 0x170022B4 RID: 8884
	// (get) Token: 0x0600C263 RID: 49763 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2898.EInteractState InteractState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170022B5 RID: 8885
	// (get) Token: 0x0600C264 RID: 49764 RVA: 0x00002050 File Offset: 0x00000250
	public Player InteractingPlayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C265 RID: 49765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Invoke(Player interactingPlayer, GClass2898.EInteractState state)
	{
		throw null;
	}

	// Token: 0x0600C266 RID: 49766 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x0400C419 RID: 50201
	private GClass2898.EInteractState einteractState_0;

	// Token: 0x0400C41A RID: 50202
	private Player player_0;

	// Token: 0x02002643 RID: 9795
	public enum EInteractState
	{
		// Token: 0x0400C41C RID: 50204
		None,
		// Token: 0x0400C41D RID: 50205
		IsEntering,
		// Token: 0x0400C41E RID: 50206
		Entered,
		// Token: 0x0400C41F RID: 50207
		IsExiting,
		// Token: 0x0400C420 RID: 50208
		Exited
	}
}
