using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x0200043C RID: 1084
public abstract class AReserveWayAction : MonoBehaviour
{
	// Token: 0x170004B5 RID: 1205
	// (get) Token: 0x06001A1A RID: 6682
	public abstract Vector3 GoTo { get; }

	// Token: 0x170004B6 RID: 1206
	// (get) Token: 0x06001A1B RID: 6683
	public abstract Vector3 LookShootTo { get; }

	// Token: 0x06001A1C RID: 6684
	public abstract ReserveWayResult ManualUpdate(BotOwner owner);

	// Token: 0x06001A1D RID: 6685
	public abstract void RefreshData();

	// Token: 0x06001A1E RID: 6686
	public abstract void RefreshBot();

	// Token: 0x06001A1F RID: 6687
	public abstract void DrawGizmos();

	// Token: 0x06001A20 RID: 6688 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentUser(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetFree()
	{
		throw null;
	}

	// Token: 0x06001A22 RID: 6690
	public abstract void AutoFix();

	// Token: 0x06001A23 RID: 6691
	public abstract void ComeTo(BotOwner bot);

	// Token: 0x06001A24 RID: 6692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float TimeToUse(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetLeaveUser(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool CheckDist(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CheckPoint(Vector3 point, string data)
	{
		throw null;
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CheckWayFromParent(string nameInfo, Vector3 from)
	{
		throw null;
	}

	// Token: 0x04001669 RID: 5737
	protected ReserveWayResult _cuResult;

	// Token: 0x0400166A RID: 5738
	private float _nextCheckClose;

	// Token: 0x0400166B RID: 5739
	private bool _lastDesicion;
}
