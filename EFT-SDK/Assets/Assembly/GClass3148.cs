using System;
using System.Runtime.CompilerServices;
using EFT.UI.Screens;

// Token: 0x02002CFA RID: 11514
public abstract class GClass3148<T, U> : GClass3142<T, U> where T : GClass3148<T, U> where U : EftScreen<T, U>
{
	// Token: 0x14000324 RID: 804
	// (add) Token: 0x0600E263 RID: 57955 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E264 RID: 57956 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnShowReadyScreen
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

	// Token: 0x0600E265 RID: 57957 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void CloseAction(bool moveForward)
	{
		throw null;
	}

	// Token: 0x0600E266 RID: 57958 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_10()
	{
		throw null;
	}

	// Token: 0x0600E267 RID: 57959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11()
	{
		throw null;
	}

	// Token: 0x0400E763 RID: 59235
	private static readonly EEftScreenType[] eeftScreenType_0;

	// Token: 0x0400E764 RID: 59236
	[CompilerGenerated]
	private Action action_3;

	// Token: 0x0400E765 RID: 59237
	public readonly GClass3166 MatchmakerPlayersController;
}
