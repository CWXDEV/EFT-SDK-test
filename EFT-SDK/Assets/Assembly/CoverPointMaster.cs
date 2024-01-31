using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02000139 RID: 313
public class CoverPointMaster
{
	// Token: 0x060006AA RID: 1706 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CoverPointMaster Create(BotZone zone)
	{
		throw null;
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CustomNavigationPoint GetNearPoint(CustomNavigationPoint[] coverPointGroups, Vector3 playerPos, out float sDist)
	{
		throw null;
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static HashSet<CustomNavigationPoint> smethod_0(CustomNavigationPoint[] coverPointGroups, CoverSearchData data, int recursionLevel)
	{
		throw null;
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Func<Tuple<float, float>> smethod_1(int recursionLevel)
	{
		throw null;
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x060006AE RID: 1710 RVA: 0x00002050 File Offset: 0x00000250
	public BotZone BotZone
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint GetFreeClosePoint(Vector3 pos, BotCoversData bot, float minSDistToEnemy)
	{
		throw null;
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint GetCoverPointMain(CoverSearchData data, bool checkCurrent)
	{
		throw null;
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCurrentPointGood(CoverSearchType searchType, CoverSearchData data, out CustomNavigationPoint point)
	{
		throw null;
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CustomNavigationPoint> GetClosePoints(Vector3 pos, BotOwner bot, float dist)
	{
		throw null;
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint ClosestGreenPoint(Vector3 point, BotOwner bot, CoverPointMaster.GStruct10? friendCover, int? placeId, out float sDist)
	{
		throw null;
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint ClosestGreenPoint(Vector3 point, BotOwner bot, CoverPointMaster.GStruct10? friendCover, int? placeId, CoverLevel minCoverLevel, out float sDist)
	{
		throw null;
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint ClosestGreenPoint(Vector3 point, BotOwner bot, float minDistToTarget, Vector3 trg, CoverPointMaster.GStruct10? friendCover, out float sDist)
	{
		throw null;
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private CustomNavigationPoint method_0(CoverSearchData data)
	{
		throw null;
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000767 RID: 1895
	public const float LOWEST_ANG_COVER = 0.1736482f;

	// Token: 0x04000768 RID: 1896
	private static readonly GClass325 _nearCoverGroupsCache;

	// Token: 0x04000769 RID: 1897
	private GClass314 _finderByGraph;

	// Token: 0x0400076A RID: 1898
	private bool canDraw;

	// Token: 0x0400076B RID: 1899
	private readonly List<CustomNavigationPoint> _listToDel;

	// Token: 0x0400076C RID: 1900
	private HashSet<CustomNavigationPoint> _nearGroups;

	// Token: 0x0400076D RID: 1901
	private HashSet<CustomNavigationPoint> _nearGroupByPlace;

	// Token: 0x0200013A RID: 314
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct10
	{
		// Token: 0x0400076F RID: 1903
		public Vector3 CoverPos;

		// Token: 0x04000770 RID: 1904
		public float MinDistToFriend;
	}

	// Token: 0x0200013B RID: 315
	[CompilerGenerated]
	private sealed class Class103
	{
		// Token: 0x060006B8 RID: 1720 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Tuple<float, float> method_0()
		{
			throw null;
		}

		// Token: 0x04000771 RID: 1905
		public int recursionLevel;
	}
}
