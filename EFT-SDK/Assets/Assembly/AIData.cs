using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.EnvironmentEffect;
using EFT.Interactive;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020004B0 RID: 1200
public class AIData
{
	// Token: 0x06001D14 RID: 7444 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static float smethod_0(float p)
	{
		throw null;
	}

	// Token: 0x17000531 RID: 1329
	// (get) Token: 0x06001D15 RID: 7445 RVA: 0x00002050 File Offset: 0x00000250
	public HashSet<AIPlaceInfo> CurrentZones
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1400003F RID: 63
	// (add) Token: 0x06001D16 RID: 7446 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001D17 RID: 7447 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Weapon> OnStationaryTaken
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

	// Token: 0x14000040 RID: 64
	// (add) Token: 0x06001D18 RID: 7448 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001D19 RID: 7449 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<AIData> OnBecomeScavAttacker
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

	// Token: 0x14000041 RID: 65
	// (add) Token: 0x06001D1A RID: 7450 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001D1B RID: 7451 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<AIData> OnTiltDone
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

	// Token: 0x14000042 RID: 66
	// (add) Token: 0x06001D1C RID: 7452 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001D1D RID: 7453 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<AIPlaceInfo> OnComeToPlace
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

	// Token: 0x14000043 RID: 67
	// (add) Token: 0x06001D1E RID: 7454 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001D1F RID: 7455 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<AIPlaceInfo> OnLeavePlace
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

	// Token: 0x17000532 RID: 1330
	// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00002050 File Offset: 0x00000250
	public bool ShallPursuit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000533 RID: 1331
	// (get) Token: 0x06001D21 RID: 7457 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D22 RID: 7458 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsAxe
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

	// Token: 0x17000534 RID: 1332
	// (get) Token: 0x06001D23 RID: 7459 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInside
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000535 RID: 1333
	// (get) Token: 0x06001D24 RID: 7460 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsScavAttacker
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000536 RID: 1334
	// (get) Token: 0x06001D25 RID: 7461 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D26 RID: 7462 RVA: 0x00002050 File Offset: 0x00000250
	public int EnvironmentId
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

	// Token: 0x17000537 RID: 1335
	// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D28 RID: 7464 RVA: 0x00002050 File Offset: 0x00000250
	public AIPlaceInfo PlaceInfo
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

	// Token: 0x17000538 RID: 1336
	// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00002050 File Offset: 0x00000250
	public AIDataRequestController AskRequests
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000539 RID: 1337
	// (get) Token: 0x06001D2A RID: 7466 RVA: 0x00002050 File Offset: 0x00000250
	public AIBossPlayer AIBossPlayer
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700053A RID: 1338
	// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D2C RID: 7468 RVA: 0x00002050 File Offset: 0x00000250
	public bool GetFlare
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

	// Token: 0x1700053B RID: 1339
	// (get) Token: 0x06001D2D RID: 7469 RVA: 0x00002050 File Offset: 0x00000250
	public bool IAmBoss
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700053C RID: 1340
	// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D2F RID: 7471 RVA: 0x00002050 File Offset: 0x00000250
	public bool UsingLight
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

	// Token: 0x1700053D RID: 1341
	// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00002050 File Offset: 0x00000250
	public Player Player
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700053E RID: 1342
	// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D32 RID: 7474 RVA: 0x00002050 File Offset: 0x00000250
	public float PowerOfEquipment
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

	// Token: 0x1700053F RID: 1343
	// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D34 RID: 7476 RVA: 0x00002050 File Offset: 0x00000250
	public float LastResetPlaceInfo
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

	// Token: 0x17000540 RID: 1344
	// (get) Token: 0x06001D35 RID: 7477 RVA: 0x00002050 File Offset: 0x00000250
	public float FlarePower
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000541 RID: 1345
	// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D37 RID: 7479 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsAI
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

	// Token: 0x17000542 RID: 1346
	// (get) Token: 0x06001D38 RID: 7480 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D39 RID: 7481 RVA: 0x00002050 File Offset: 0x00000250
	public BotOwner BotOwner
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

	// Token: 0x17000543 RID: 1347
	// (get) Token: 0x06001D3A RID: 7482 RVA: 0x00002050 File Offset: 0x00000250
	public float VisibilityCoef
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000544 RID: 1348
	// (set) Token: 0x06001D3B RID: 7483 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000545 RID: 1349
	// (get) Token: 0x06001D3C RID: 7484 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveHelmet
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

	// Token: 0x17000546 RID: 1350
	// (get) Token: 0x06001D3E RID: 7486 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInTree
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000547 RID: 1351
	// (get) Token: 0x06001D3F RID: 7487 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D40 RID: 7488 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsNoOffsetShooting
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

	// Token: 0x06001D41 RID: 7489 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBossOrFollowerRequireRevenge()
	{
		throw null;
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KillEnemy(Player victim)
	{
		throw null;
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoMove()
	{
		throw null;
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAttackByLoyalityScav()
	{
		throw null;
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LeavePlace([NotNull] AIPlaceInfo place)
	{
		throw null;
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPlaceInfo([NotNull] AIPlaceInfo place)
	{
		throw null;
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalcPower()
	{
		throw null;
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryPlayShootSound(Player getPlayer, Vector3 position, AISoundType soundType)
	{
		throw null;
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TacticalModeChange(bool siActive)
	{
		throw null;
	}

	// Token: 0x06001D4B RID: 7499 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStationaryWeapon(Weapon stationaryWeaponItem)
	{
		throw null;
	}

	// Token: 0x06001D4C RID: 7500 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnterTree(TreeInteractive treeInteractive)
	{
		throw null;
	}

	// Token: 0x06001D4D RID: 7501 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExitTree(TreeInteractive treeInteractive)
	{
		throw null;
	}

	// Token: 0x06001D4E RID: 7502 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAim(bool value)
	{
		throw null;
	}

	// Token: 0x06001D4F RID: 7503 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPosToVoxel(Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06001D50 RID: 7504 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmosSelectedVoxel()
	{
		throw null;
	}

	// Token: 0x06001D51 RID: 7505 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(CollisionFlags obj)
	{
		throw null;
	}

	// Token: 0x06001D52 RID: 7506 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06001D53 RID: 7507 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(float tiltSide)
	{
		throw null;
	}

	// Token: 0x06001D54 RID: 7508 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06001D55 RID: 7509 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06001D56 RID: 7510 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_5()
	{
		throw null;
	}

	// Token: 0x06001D57 RID: 7511 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_6(Player Player)
	{
		throw null;
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_7()
	{
		throw null;
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEnvironment(IndoorTrigger trigger)
	{
		throw null;
	}

	// Token: 0x040018B3 RID: 6323
	public const float TILT_VALUE = 5f;

	// Token: 0x040018B4 RID: 6324
	private float _nextShootTime;

	// Token: 0x040018B5 RID: 6325
	private float _endFlareTime;

	// Token: 0x040018B6 RID: 6326
	private float _endMoveTime;

	// Token: 0x040018B7 RID: 6327
	private bool useMove;

	// Token: 0x040018B8 RID: 6328
	private readonly MovementContext _movementContext;

	// Token: 0x040018B9 RID: 6329
	private BotOwner _botOwner;

	// Token: 0x040018BA RID: 6330
	private TreeInteractive _treeInteractive;

	// Token: 0x040018BB RID: 6331
	private int _kills;

	// Token: 0x040018BC RID: 6332
	private float _lastTiltTime;

	// Token: 0x040018BD RID: 6333
	private float _lastTiltSide;

	// Token: 0x040018BE RID: 6334
	private readonly HashSet<AIPlaceInfo> _currentZones;

	// Token: 0x040018BF RID: 6335
	private Vector3 _oldPos;

	// Token: 0x040018C0 RID: 6336
	private float _nextCheckTime;

	// Token: 0x040018C1 RID: 6337
	private GInterface9 _voxelChecker;

	// Token: 0x040018C2 RID: 6338
	private float _scavAttackerEndPeriod;

	// Token: 0x040018CA RID: 6346
	private bool _cachedHaveArmoredGroup;

	// Token: 0x040018CB RID: 6347
	private float _prevArmoredGroupCalc;

	// Token: 0x040018CC RID: 6348
	private const float ARMORED_GROUP_RECALC_PERIOD = 25f;
}
