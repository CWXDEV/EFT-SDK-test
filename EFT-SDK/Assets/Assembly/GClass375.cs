using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000282 RID: 642
public abstract class GClass375<T, U> : ABossLogic, GInterface8 where T : GClass291 where U : GClass291
{
	// Token: 0x14000017 RID: 23
	// (add) Token: 0x06000CB4 RID: 3252
	// (remove) Token: 0x06000CB5 RID: 3253
	public abstract event Action OnPositionsRecalculated;

	// Token: 0x17000339 RID: 825
	// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
	public bool EnoughtHaveGoodCovers
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

	// Token: 0x1700033A RID: 826
	// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3? PointForBoss
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

	// Token: 0x06000CBA RID: 3258 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHaveGoodCover(BotOwner id, bool noGoodCover)
	{
		throw null;
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<BotOwner, Vector3> FollowersPositions()
	{
		throw null;
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFollowersPositions()
	{
		throw null;
	}

	// Token: 0x06000CBE RID: 3262
	public abstract Vector3 GetTargetToLook();

	// Token: 0x06000CBF RID: 3263
	protected abstract void SetLogicToFollower(T followerLogic);

	// Token: 0x06000CC0 RID: 3264
	protected abstract void FindPositionsForFollowers(bool b);

	// Token: 0x06000CC1 RID: 3265 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void SubAddFollower(BotOwner botOwner)
	{
		throw null;
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void SubRemoveFollower(BotOwner botOwner)
	{
		throw null;
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(BotOwner botFollower, FollowerStatusChange arg2)
	{
		throw null;
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x04000D15 RID: 3349
	protected Dictionary<BotOwner, Vector3> dictionary_0;

	// Token: 0x04000D16 RID: 3350
	protected readonly List<T> list_0;

	// Token: 0x04000D17 RID: 3351
	private readonly Dictionary<BotOwner, bool> dictionary_1;

	// Token: 0x04000D18 RID: 3352
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04000D19 RID: 3353
	[CompilerGenerated]
	private Vector3? nullable_0;
}
