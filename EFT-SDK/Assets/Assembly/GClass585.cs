using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT;

// Token: 0x02000615 RID: 1557
public abstract class GClass585 : GInterface18
{
	// Token: 0x0600238F RID: 9103 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass535<WildSpawnType, BotDifficulty, GClass584> CurCacheddProfilesCount()
	{
		throw null;
	}

	// Token: 0x06002390 RID: 9104 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreateProfile(EPlayerSide side, WildSpawnType type, BotDifficulty botDifficulty, Action<Profile> callback, bool withDelete)
	{
		throw null;
	}

	// Token: 0x06002391 RID: 9105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task<Profile> CreateProfile(GClass588 data, CancellationToken cancellationToken, bool withDelete)
	{
		throw null;
	}

	// Token: 0x17000683 RID: 1667
	// (get) Token: 0x06002392 RID: 9106 RVA: 0x00002050 File Offset: 0x00000250
	public bool StartProfilesLoaded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000684 RID: 1668
	// (get) Token: 0x06002393 RID: 9107
	public abstract int BundlesLoading { get; }

	// Token: 0x06002394 RID: 9108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FillBackupProfilesData(GClass340 resultCache)
	{
		throw null;
	}

	// Token: 0x06002395 RID: 9109 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Profile GetNewProfile()
	{
		throw null;
	}

	// Token: 0x06002396 RID: 9110 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Profile GetNewProfile(GClass588 data, bool withDelete)
	{
		throw null;
	}

	// Token: 0x0400231A RID: 8986
	protected List<Profile> list_0;

	// Token: 0x0400231B RID: 8987
	protected bool bool_0;
}
