using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000403 RID: 1027
public abstract class BotMover : GClass362
{
	// Token: 0x1400002B RID: 43
	// (add) Token: 0x060018AB RID: 6315 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060018AC RID: 6316 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<float> OnPoseChange
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

	// Token: 0x17000481 RID: 1153
	// (get) Token: 0x060018AD RID: 6317 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018AE RID: 6318 RVA: 0x00002050 File Offset: 0x00000250
	public bool Sprinting
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

	// Token: 0x17000482 RID: 1154
	// (get) Token: 0x060018AF RID: 6319 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018B0 RID: 6320 RVA: 0x00002050 File Offset: 0x00000250
	public float TargetPose
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

	// Token: 0x17000483 RID: 1155
	// (get) Token: 0x060018B1 RID: 6321 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018B2 RID: 6322 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsMoving
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

	// Token: 0x17000484 RID: 1156
	// (get) Token: 0x060018B3 RID: 6323 RVA: 0x00002050 File Offset: 0x00000250
	public bool HavePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000485 RID: 1157
	// (get) Token: 0x060018B4 RID: 6324 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3? TargetPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000486 RID: 1158
	// (get) Token: 0x060018B5 RID: 6325 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasPathAndNoComplete
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000487 RID: 1159
	// (get) Token: 0x060018B6 RID: 6326 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 DirCurPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000488 RID: 1160
	// (get) Token: 0x060018B7 RID: 6327 RVA: 0x00002050 File Offset: 0x00000250
	public float DistDestination
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000489 RID: 1161
	// (get) Token: 0x060018B8 RID: 6328 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018B9 RID: 6329 RVA: 0x00002050 File Offset: 0x00000250
	public float SDistDestination
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

	// Token: 0x1700048A RID: 1162
	// (get) Token: 0x060018BA RID: 6330 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018BB RID: 6331 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 NormDirCurPoint
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

	// Token: 0x1700048B RID: 1163
	// (get) Token: 0x060018BC RID: 6332 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 RealDestPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700048C RID: 1164
	// (get) Token: 0x060018BD RID: 6333 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018BE RID: 6334 RVA: 0x00002050 File Offset: 0x00000250
	public bool Pause
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

	// Token: 0x1700048D RID: 1165
	// (get) Token: 0x060018BF RID: 6335 RVA: 0x00002050 File Offset: 0x00000250
	public float RemainPause
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700048E RID: 1166
	// (get) Token: 0x060018C0 RID: 6336 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018C1 RID: 6337 RVA: 0x00002050 File Offset: 0x00000250
	public float DestMoveSpeed
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

	// Token: 0x1700048F RID: 1167
	// (get) Token: 0x060018C2 RID: 6338 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool IsImpostorWorks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000490 RID: 1168
	// (get) Token: 0x060018C3 RID: 6339 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool Blocked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000491 RID: 1169
	// (get) Token: 0x060018C4 RID: 6340 RVA: 0x00002050 File Offset: 0x00000250
	public bool NoSprint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000492 RID: 1170
	// (get) Token: 0x060018C5 RID: 6341 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 CurPathLastPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000493 RID: 1171
	// (get) Token: 0x060018C6 RID: 6342 RVA: 0x00002050 File Offset: 0x00000250
	public bool ShallSlowAtStart
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000494 RID: 1172
	// (get) Token: 0x060018C7 RID: 6343 RVA: 0x00002050 File Offset: 0x00000250
	public bool FirstTurnComplete
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000495 RID: 1173
	// (get) Token: 0x060018C8 RID: 6344 RVA: 0x00002050 File Offset: 0x00000250
	public bool FirstTurnBigSpeed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000496 RID: 1174
	// (get) Token: 0x060018C9 RID: 6345 RVA: 0x00002050 File Offset: 0x00000250
	public float LastPathSetTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060018CA RID: 6346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BotMover Create(BotOwner owner, AICoversData covers)
	{
		throw null;
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 LastDestination()
	{
		throw null;
	}

	// Token: 0x060018CC RID: 6348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsComeTo(float dist2check, bool onCover)
	{
		throw null;
	}

	// Token: 0x060018CD RID: 6349 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPointOnWay(Vector3[] way, Vector3 point, float maxDist)
	{
		throw null;
	}

	// Token: 0x060018CE RID: 6350 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Activate()
	{
		throw null;
	}

	// Token: 0x060018CF RID: 6351 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x060018D0 RID: 6352 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualFixedUpdate()
	{
		throw null;
	}

	// Token: 0x060018D1 RID: 6353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LateFixedUpdate()
	{
		throw null;
	}

	// Token: 0x060018D2 RID: 6354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GoToPointNoWay(Vector3? v)
	{
		throw null;
	}

	// Token: 0x060018D3 RID: 6355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GoToByWay(Vector3[] way, float reachDist)
	{
		throw null;
	}

	// Token: 0x060018D4 RID: 6356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoProne(bool val)
	{
		throw null;
	}

	// Token: 0x060018D5 RID: 6357 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MovementPause(float pauseTime, bool pauseOnlyIfNot = true)
	{
		throw null;
	}

	// Token: 0x060018D6 RID: 6358 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MovementResume()
	{
		throw null;
	}

	// Token: 0x060018D7 RID: 6359 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		throw null;
	}

	// Token: 0x060018D8 RID: 6360 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SprintPause(float period)
	{
		throw null;
	}

	// Token: 0x060018D9 RID: 6361 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float ComputePathLengthToPoint(Vector3 targetPoint)
	{
		throw null;
	}

	// Token: 0x060018DA RID: 6362 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetPose(float targetPose)
	{
		throw null;
	}

	// Token: 0x060018DB RID: 6363 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Sprint(bool val, bool withDebugCallback = true)
	{
		throw null;
	}

	// Token: 0x060018DC RID: 6364 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTargetMoveSpeed(float target)
	{
		throw null;
	}

	// Token: 0x060018DD RID: 6365 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3[] CalcPath(Vector3 position)
	{
		throw null;
	}

	// Token: 0x060018DE RID: 6366 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDrawGizmosPrevWay()
	{
		throw null;
	}

	// Token: 0x060018DF RID: 6367 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawVisionLines()
	{
		throw null;
	}

	// Token: 0x060018E0 RID: 6368 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavMeshPathStatus GoToPoint(CustomNavigationPoint targetPoint, bool slowAtTheEnd = false, bool getUpWithCheck = false)
	{
		throw null;
	}

	// Token: 0x060018E1 RID: 6369 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavMeshPathStatus GoToPoint(Vector3 pos, bool slowAtTheEnd, float reachDist, bool getUpWithCheck = false, bool mustHaveWay = true, bool onlyShortTrie = false)
	{
		throw null;
	}

	// Token: 0x060018E2 RID: 6370 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 LastTargetPoint(float distCoef)
	{
		throw null;
	}

	// Token: 0x060018E3 RID: 6371 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawSelectedGizmosWay()
	{
		throw null;
	}

	// Token: 0x060018E4 RID: 6372 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugDrawLastPath()
	{
		throw null;
	}

	// Token: 0x060018E5 RID: 6373 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecalcWay()
	{
		throw null;
	}

	// Token: 0x060018E6 RID: 6374 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void CantFindWayErrorTraceLog()
	{
		throw null;
	}

	// Token: 0x060018E7 RID: 6375
	protected abstract bool CheckCornerIndexByReachDist(float distCur, Vector3 position);

	// Token: 0x060018E8 RID: 6376
	protected abstract void SetLastContex(float remainDist, Vector3 targetPos);

	// Token: 0x060018E9 RID: 6377
	protected abstract bool CheckIsOnPoint(Vector3 position);

	// Token: 0x060018EA RID: 6378 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected int SetPlayerToNavMesh(Vector3 curPos, Vector3 castPoint)
	{
		throw null;
	}

	// Token: 0x060018EB RID: 6379 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected float UseFuncAcceleration(float x)
	{
		throw null;
	}

	// Token: 0x060018EC RID: 6380 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060018ED RID: 6381 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x060018EE RID: 6382 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x060018EF RID: 6383 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(float val)
	{
		throw null;
	}

	// Token: 0x060018F0 RID: 6384 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x060018F1 RID: 6385 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2 method_5()
	{
		throw null;
	}

	// Token: 0x060018F2 RID: 6386 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x060018F3 RID: 6387 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x060018F4 RID: 6388 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x04001564 RID: 5476
	public const float MaxSprintSpeed = 2f;

	// Token: 0x04001565 RID: 5477
	public const float SlowEndDist = 0.5f;

	// Token: 0x04001566 RID: 5478
	public const float SlowPeriod = 0.5f;

	// Token: 0x04001567 RID: 5479
	public const float SlowStartDist = 0.75f;

	// Token: 0x04001568 RID: 5480
	private const int FAIL_CALC_PATH_TIMES = 10;

	// Token: 0x04001569 RID: 5481
	private const float MAX_DIST_OUT_OF_NAVMESH = 7f;

	// Token: 0x0400156A RID: 5482
	private const float MAX_Y_DELTA_PER_STEP = 0.5f;

	// Token: 0x0400156B RID: 5483
	private const float SAMPLE_RADIUS = 2f;

	// Token: 0x0400156C RID: 5484
	protected readonly Player _player;

	// Token: 0x0400156D RID: 5485
	protected Vector3 _dirCurPoint;

	// Token: 0x0400156E RID: 5486
	protected Vector3 _realDestPoint;

	// Token: 0x0400156F RID: 5487
	protected float _endSlowTime;

	// Token: 0x04001570 RID: 5488
	protected float _setPathTime;

	// Token: 0x04001571 RID: 5489
	protected bool _startSlowActivated;

	// Token: 0x04001572 RID: 5490
	protected bool _firstTurnComplete;

	// Token: 0x04001573 RID: 5491
	protected bool _firstTurnBigSpeed;

	// Token: 0x04001574 RID: 5492
	protected GClass422 _pathController;

	// Token: 0x04001575 RID: 5493
	protected GClass421 _debuger;

	// Token: 0x04001576 RID: 5494
	private readonly Vector3 _offsetCastDown;

	// Token: 0x04001577 RID: 5495
	private readonly Vector3 _offsetCastUp;

	// Token: 0x04001578 RID: 5496
	private bool _onlyVertical;

	// Token: 0x04001579 RID: 5497
	private readonly float _poseSpeedChangeFactor;

	// Token: 0x0400157A RID: 5498
	private float _pauseEndTime;

	// Token: 0x0400157B RID: 5499
	private float _sprintStopEnd;

	// Token: 0x0400157C RID: 5500
	private float _nextCheckVoxel;

	// Token: 0x0400157D RID: 5501
	private readonly GClass423 _pathFinder;

	// Token: 0x0400157E RID: 5502
	private Vector3 _prevLinkPos;
}
