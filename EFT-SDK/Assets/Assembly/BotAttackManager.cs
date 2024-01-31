using System;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x0200029B RID: 667
public class BotAttackManager
{
	// Token: 0x17000369 RID: 873
	// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D97 RID: 3479 RVA: 0x00002050 File Offset: 0x00000250
	public float LastFailSearch
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

	// Token: 0x06000D98 RID: 3480 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryPointGetting(bool withShoot, CoverSearchType searchType, ShootPointClass shoot2point, float deistStartSearchSqr, Action<CustomNavigationPoint> OnFind, Action OnFail = null, bool checkCurrent = true)
	{
		throw null;
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryPointGetting(CoverShootType coverShootType, CoverSearchType searchType, ShootPointClass shoot2point, float deistStartSearchSqr, Action<CustomNavigationPoint> OnFind, Action OnFail = null, bool checkCurrent = true, bool canChange = true)
	{
		throw null;
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryPointGetting(Vector3 centerPos, bool withShoot, float distStart2SerachSqr, CoverSearchType searchType, ShootPointClass shoot2point, Action<CustomNavigationPoint> OnFind, Action OnFail = null, bool checkCurrent = true)
	{
		throw null;
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryPointGetting(CoverSearchData searchData, Action<CustomNavigationPoint> OnFind, Action OnFail)
	{
		throw null;
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryPointGetting(Vector3 centerPos, CoverShootType coverShootType, float distStart2SerachSqr, CoverSearchType searchType, ShootPointClass shoot2point, Action<CustomNavigationPoint> OnFind, Action OnFail, bool checkCurrent = true, bool recalcNoTimer = false, bool useFightLogic = true, int? placeInfo = null)
	{
		throw null;
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PointAndPathDetecting()
	{
		throw null;
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateNextTick()
	{
		throw null;
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint PointToGo()
	{
		throw null;
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint CheckDestinations()
	{
		throw null;
	}

	// Token: 0x04000D64 RID: 3428
	private const float UPDATE_TIME = 1f;

	// Token: 0x04000D65 RID: 3429
	private readonly BotOwner _owner;

	// Token: 0x04000D66 RID: 3430
	private float _updatePointTimer;
}
