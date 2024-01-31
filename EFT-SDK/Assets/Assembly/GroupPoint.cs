using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200015A RID: 346
[Serializable]
public class GroupPoint : GInterface2, IPositionPoint, IAICorePointLink
{
	// Token: 0x1700021F RID: 543
	// (get) Token: 0x0600076D RID: 1901 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x0600076E RID: 1902 RVA: 0x00002050 File Offset: 0x00000250
	public float DefenceLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x0600076F RID: 1903 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000770 RID: 1904 RVA: 0x00002050 File Offset: 0x00000250
	public float MagnitudeForSort
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x06000771 RID: 1905 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000772 RID: 1906 RVA: 0x00002050 File Offset: 0x00000250
	public int CounterId
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x06000773 RID: 1907 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsSpotted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
	public int HideLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06000775 RID: 1909 RVA: 0x00002050 File Offset: 0x00000250
	public int OwnerInGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06000776 RID: 1910 RVA: 0x00002050 File Offset: 0x00000250
	public AICorePoint CorePointInGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitLightBorders()
	{
		throw null;
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSameMeaning(GInterface2 p1, float sDist, out GInterface2 worst)
	{
		throw null;
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint CreateCustomNavigationPoint(int botOwnerId)
	{
		throw null;
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitForGame(AICorePointHolder corePointHolder)
	{
		throw null;
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalcDefenceLevel()
	{
		throw null;
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmos(bool withEdges, bool withCore, float upRay = -1f)
	{
		throw null;
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPosition(Vector3 position)
	{
		throw null;
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint GetById(int botId)
	{
		throw null;
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddConnectedGroupPoint(GroupPointWay way)
	{
		throw null;
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFreeById(int botId)
	{
		throw null;
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Spotted(float period)
	{
		throw null;
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Block()
	{
		throw null;
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unblock()
	{
		throw null;
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveWay(GroupPointWay target)
	{
		throw null;
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOwner(int owner)
	{
		throw null;
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(Vector3? sidePos)
	{
		throw null;
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x04000825 RID: 2085
	public const float GROUP_POINT_NAV_SAMPLE_DIST = 1f;

	// Token: 0x04000826 RID: 2086
	public const int BASE_HIDE_VAL = 51;

	// Token: 0x04000827 RID: 2087
	public const float CHECK_CAN_HIDE_STAY = 1.272f;

	// Token: 0x04000828 RID: 2088
	public const float LIGHT_WALL_ANG = 57f;

	// Token: 0x04000829 RID: 2089
	[SerializeField]
	public Vector3 FirePosition;

	// Token: 0x0400082A RID: 2090
	[SerializeField]
	public int Index;

	// Token: 0x0400082B RID: 2091
	[SerializeField]
	public PointWithNeighborType PointWithNeighborType;

	// Token: 0x0400082C RID: 2092
	[SerializeField]
	private Vector3 _position;

	// Token: 0x0400082D RID: 2093
	public bool AlwaysGood;

	// Token: 0x0400082E RID: 2094
	public CoverLevel CoverLevel;

	// Token: 0x0400082F RID: 2095
	public int Id;

	// Token: 0x04000830 RID: 2096
	public CoverPointDefenceInfo DefenceInfo;

	// Token: 0x04000831 RID: 2097
	public Vector3? AltPosition;

	// Token: 0x04000832 RID: 2098
	public Vector3 WallDirection;

	// Token: 0x04000833 RID: 2099
	public CoverType CoverType;

	// Token: 0x04000834 RID: 2100
	public ECoverPointSpecial Special;

	// Token: 0x04000835 RID: 2101
	public EnvironmentType EnvironmentType;

	// Token: 0x04000836 RID: 2102
	public int IdEnvironment;

	// Token: 0x04000837 RID: 2103
	public int ConnectionGroup;

	// Token: 0x04000838 RID: 2104
	public bool CanLookLeft;

	// Token: 0x04000839 RID: 2105
	public bool CanLookRight;

	// Token: 0x0400083A RID: 2106
	public bool BordersLightHave;

	// Token: 0x0400083B RID: 2107
	public Vector3 LeftBorderLight;

	// Token: 0x0400083C RID: 2108
	public Vector3 RightBorderLight;

	// Token: 0x0400083D RID: 2109
	public BotTiltType TiltType;

	// Token: 0x0400083E RID: 2110
	public bool IsGoodInsideBuilding;

	// Token: 0x0400083F RID: 2111
	public List<GroupPointWay> NeighbourhoodsWays;

	// Token: 0x04000840 RID: 2112
	public List<int> NeighbourhoodsWaysIds;

	// Token: 0x04000841 RID: 2113
	public int ParentNavPoint;

	// Token: 0x04000842 RID: 2114
	public int CorePointId;

	// Token: 0x04000843 RID: 2115
	private Dictionary<int, CustomNavigationPoint> _childs;

	// Token: 0x04000844 RID: 2116
	private GClass327 _inGame;

	// Token: 0x04000845 RID: 2117
	public int PlaceId;

	// Token: 0x04000848 RID: 2120
	private AICorePoint _corePoint;
}
