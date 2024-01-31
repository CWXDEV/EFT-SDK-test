using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000155 RID: 341
[Serializable]
public class CustomNavigationPoint : IPositionPoint, IAICorePointLink
{
	// Token: 0x17000200 RID: 512
	// (get) Token: 0x06000734 RID: 1844 RVA: 0x00002050 File Offset: 0x00000250
	public GroupPoint GroupPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x06000735 RID: 1845 RVA: 0x00002050 File Offset: 0x00000250
	public int Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x06000736 RID: 1846 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 AltPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveAltPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000204 RID: 516
	// (get) Token: 0x06000738 RID: 1848 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 BasePosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x06000739 RID: 1849 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 FirePosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x0600073A RID: 1850 RVA: 0x00002050 File Offset: 0x00000250
	public BotTiltType TiltType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
	public CoverLevel CoverLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x0600073C RID: 1852 RVA: 0x00002050 File Offset: 0x00000250
	public CoverPointDefenceInfo DefenceInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x0600073D RID: 1853 RVA: 0x00002050 File Offset: 0x00000250
	public bool BordersLightHave
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700020B RID: 523
	// (get) Token: 0x0600073E RID: 1854 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 LeftBorderLight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700020C RID: 524
	// (get) Token: 0x0600073F RID: 1855 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 RightBorderLight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x06000740 RID: 1856 RVA: 0x00002050 File Offset: 0x00000250
	public bool AlwaysGood
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x06000741 RID: 1857 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanLookLeft
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700020F RID: 527
	// (get) Token: 0x06000742 RID: 1858 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanLookRight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
	public int HideLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x06000744 RID: 1860 RVA: 0x00002050 File Offset: 0x00000250
	public int PlaceId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
	public int IdPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06000746 RID: 1862 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
	public EnvironmentType EnvironmentType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x06000748 RID: 1864 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsGoodInsideBuilding
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06000749 RID: 1865 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600074A RID: 1866 RVA: 0x00002050 File Offset: 0x00000250
	public float CoveringWeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x0600074B RID: 1867 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsSpotted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x0600074C RID: 1868 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600074D RID: 1869 RVA: 0x00002050 File Offset: 0x00000250
	public float BaseWeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x0600074E RID: 1870 RVA: 0x00002050 File Offset: 0x00000250
	public ECoverPointSpecial Special
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700021A RID: 538
	// (get) Token: 0x0600074F RID: 1871 RVA: 0x00002050 File Offset: 0x00000250
	public int EnvironmentId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x06000750 RID: 1872 RVA: 0x00002050 File Offset: 0x00000250
	public CoverType CoverType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x06000751 RID: 1873 RVA: 0x00002050 File Offset: 0x00000250
	public int ParentGroupPointId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x06000752 RID: 1874 RVA: 0x00002050 File Offset: 0x00000250
	public int Owner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06000753 RID: 1875 RVA: 0x00002050 File Offset: 0x00000250
	public AICorePoint CorePointInGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWeight(float v, bool withBaseWeight = true)
	{
		throw null;
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetClose()
	{
		throw null;
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLong()
	{
		throw null;
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Block()
	{
		throw null;
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unblock()
	{
		throw null;
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Spotted(float period)
	{
		throw null;
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDangerPositionFarEnough(IEnumerable<Vector3> positionsIMustCare, float minSDistToEnemy)
	{
		throw null;
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanIHide(IEnumerable<Vector3> positionsIMustCare, float minSDistToEnemy, bool useRaycast, bool useAng = true)
	{
		throw null;
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanIHideFromPos(float minSDistToEnemy, bool useRaycast, bool useAng, Vector3 pos)
	{
		throw null;
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanShootToTargetCast(BotOwner shooter, float deltaLastTimeVision)
	{
		throw null;
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDecreasedWeight(bool val)
	{
		throw null;
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmosAsAmbush(Vector3? cameraPos = null, float sDist = 0f, bool drawSides = true)
	{
		throw null;
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmosFullAsCover(Vector3? cameraPos = null, float sDist = 0f, bool drawSides = true)
	{
		throw null;
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint CopyById(int botId)
	{
		throw null;
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFreeById(int ownerId)
	{
		throw null;
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOwner(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFree()
	{
		throw null;
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsGoodForGrenade(GClass498 grenadeDangerPoint, BotOwner owner)
	{
		throw null;
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0400080D RID: 2061
	public const float MAX_DEFENCE_LEVEL_SIDE = 8f;

	// Token: 0x0400080E RID: 2062
	public const int MAX_HIDE_VAL = 100;

	// Token: 0x0400080F RID: 2063
	[HideInInspector]
	public bool CanIShootToEnemy;

	// Token: 0x04000810 RID: 2064
	[HideInInspector]
	public bool lastCanShoot;

	// Token: 0x04000811 RID: 2065
	public PointWithNeighborType StrategyType;

	// Token: 0x04000812 RID: 2066
	private float _startBaseWeight;

	// Token: 0x04000813 RID: 2067
	private Dictionary<int, CustomNavigationPoint> _copies;

	// Token: 0x04000814 RID: 2068
	private float _coveringWeight;

	// Token: 0x04000815 RID: 2069
	private float _decreasedWeightCoef;

	// Token: 0x04000816 RID: 2070
	private float _nextCheckCanShootTime;

	// Token: 0x04000817 RID: 2071
	private GroupPoint _groupPoint;
}
