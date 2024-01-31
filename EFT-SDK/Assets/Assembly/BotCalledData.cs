using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000306 RID: 774
public class BotCalledData : GClass362
{
	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x06001096 RID: 4246 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001097 RID: 4247 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3? Target
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

	// Token: 0x170003FC RID: 1020
	// (get) Token: 0x06001098 RID: 4248 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 CallerPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003FD RID: 1021
	// (get) Token: 0x06001099 RID: 4249 RVA: 0x00002050 File Offset: 0x00000250
	public bool MayUse
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003FE RID: 1022
	// (get) Token: 0x0600109A RID: 4250 RVA: 0x00002050 File Offset: 0x00000250
	public bool CallerGroupHaveEnemy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetPriorityEnemyPosition(out Vector3 position)
	{
		throw null;
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryCall(Vector3? trg, BotOwner caller, bool helpOnlyWithEnemy = true)
	{
		throw null;
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(IPlayer callerEnemy, EBotEnemyCause cause)
	{
		throw null;
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOff()
	{
		throw null;
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(EBotState obj)
	{
		throw null;
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(BotOwner mem)
	{
		throw null;
	}

	// Token: 0x04000FA0 RID: 4000
	private bool _called;

	// Token: 0x04000FA1 RID: 4001
	private BotOwner _caller;

	// Token: 0x04000FA2 RID: 4002
	private bool _helpOnlyWithEnemy;
}
