using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000535 RID: 1333
[Serializable]
public class PatrolPoint : MonoBehaviour, IPositionPoint, IAICorePointLink
{
	// Token: 0x170005E2 RID: 1506
	// (get) Token: 0x06002061 RID: 8289 RVA: 0x00002050 File Offset: 0x00000250
	public int IdPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170005E3 RID: 1507
	// (get) Token: 0x06002062 RID: 8290 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002063 RID: 8291 RVA: 0x00002050 File Offset: 0x00000250
	public BotOwner Owner
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

	// Token: 0x170005E4 RID: 1508
	// (get) Token: 0x06002064 RID: 8292 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170005E5 RID: 1509
	// (get) Token: 0x06002065 RID: 8293 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170005E6 RID: 1510
	// (get) Token: 0x06002066 RID: 8294 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveLookSide
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170005E7 RID: 1511
	// (get) Token: 0x06002067 RID: 8295 RVA: 0x00002050 File Offset: 0x00000250
	public int LookIndexes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170005E8 RID: 1512
	// (get) Token: 0x06002068 RID: 8296 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002069 RID: 8297 RVA: 0x00002050 File Offset: 0x00000250
	public AICorePoint CorePointInGame
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

	// Token: 0x170005E9 RID: 1513
	// (get) Token: 0x0600206A RID: 8298 RVA: 0x00002050 File Offset: 0x00000250
	public int SubPointsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600206B RID: 8299 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x0600206C RID: 8300 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 PositionForTest()
	{
		throw null;
	}

	// Token: 0x0600206D RID: 8301 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 LookDir(int index)
	{
		throw null;
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOwner(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetOwnerId()
	{
		throw null;
	}

	// Token: 0x06002070 RID: 8304 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateSubPoints(PatrolWay way)
	{
		throw null;
	}

	// Token: 0x06002071 RID: 8305 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3? GetLookDirection(int index, bool wasCutted)
	{
		throw null;
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWay(PatrolWay patrolWay)
	{
		throw null;
	}

	// Token: 0x06002073 RID: 8307 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckData(PatrolWay way)
	{
		throw null;
	}

	// Token: 0x06002074 RID: 8308 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFreeFor(BotOwner botOwner = null)
	{
		throw null;
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryAutoFixActionData()
	{
		throw null;
	}

	// Token: 0x06002076 RID: 8310 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PatrolPoint GetSubPoint(int index)
	{
		throw null;
	}

	// Token: 0x06002077 RID: 8311 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCorePoint(AICorePoint point)
	{
		throw null;
	}

	// Token: 0x06002078 RID: 8312 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Restore(AICorePointHolder holder)
	{
		throw null;
	}

	// Token: 0x06002079 RID: 8313 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<PatrolPoint> method_0()
	{
		throw null;
	}

	// Token: 0x0600207A RID: 8314 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600207B RID: 8315 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(float offset, float yOffset = 0f)
	{
		throw null;
	}

	// Token: 0x0600207C RID: 8316 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x0600207D RID: 8317 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x0600207E RID: 8318 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x0600207F RID: 8319 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06002080 RID: 8320 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06002081 RID: 8321 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x04001F08 RID: 7944
	[SerializeField]
	private int _corePointId;

	// Token: 0x04001F09 RID: 7945
	public int Id;

	// Token: 0x04001F0A RID: 7946
	public bool CanUseByBoss;

	// Token: 0x04001F0B RID: 7947
	public PatrolWay PatrolWay;

	// Token: 0x04001F0C RID: 7948
	public bool ShallSit;

	// Token: 0x04001F0D RID: 7949
	public PatrolPointType PatrolPointType;

	// Token: 0x04001F0E RID: 7950
	public AReserveWayAction ActionData;

	// Token: 0x04001F0F RID: 7951
	public PointWithLookSides PointWithLookSides;

	// Token: 0x04001F10 RID: 7952
	public bool SubManual;

	// Token: 0x04001F11 RID: 7953
	[SerializeField]
	private List<PatrolPoint> subPoints;

	// Token: 0x04001F12 RID: 7954
	private bool _errorPrinted;
}
