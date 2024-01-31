using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020002FB RID: 763
public class BotStationaryWeaponData : GClass362
{
	// Token: 0x170003D4 RID: 980
	// (get) Token: 0x0600100F RID: 4111 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001010 RID: 4112 RVA: 0x00002050 File Offset: 0x00000250
	public bool WantToTake
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

	// Token: 0x170003D5 RID: 981
	// (get) Token: 0x06001011 RID: 4113 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001012 RID: 4114 RVA: 0x00002050 File Offset: 0x00000250
	public bool Taken
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

	// Token: 0x170003D6 RID: 982
	// (get) Token: 0x06001013 RID: 4115 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001014 RID: 4116 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanLeave
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

	// Token: 0x170003D7 RID: 983
	// (get) Token: 0x06001015 RID: 4117 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003D8 RID: 984
	// (get) Token: 0x06001016 RID: 4118 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001017 RID: 4119 RVA: 0x00002050 File Offset: 0x00000250
	public StationaryWeaponLink CurLink
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

	// Token: 0x170003D9 RID: 985
	// (get) Token: 0x06001018 RID: 4120 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001019 RID: 4121 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInSpawnState
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

	// Token: 0x170003DA RID: 986
	// (get) Token: 0x0600101A RID: 4122 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600101B RID: 4123 RVA: 0x00002050 File Offset: 0x00000250
	public float LastDistToWeapon
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

	// Token: 0x14000025 RID: 37
	// (add) Token: 0x0600101C RID: 4124 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600101D RID: 4125 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<StationaryWeaponLink> OnLinkedWeaponChange
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

	// Token: 0x0600101E RID: 4126 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartMove()
	{
		throw null;
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StationaryWeaponLink CheckWantTakeStationary(float maxRadius, bool igoneEnemy = false, float delatAfterDeathPeriod = -1f, bool needStraightShoot = false)
	{
		throw null;
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(float magnitude, StationaryWeaponLink stationary)
	{
		throw null;
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1()
	{
		throw null;
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryFindClosests(Vector3 pos, bool withSetTarget, out StationaryWeaponLink closest)
	{
		throw null;
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTargetStationary(StationaryWeaponLink link)
	{
		throw null;
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DropCurWeapon(bool withDelay, bool withLeavingAsPlayer = true)
	{
		throw null;
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(StationaryWeaponLink link)
	{
		throw null;
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Take()
	{
		throw null;
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BotLogicDecision? GetCurrentDecision()
	{
		throw null;
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsClose()
	{
		throw null;
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Spotted()
	{
		throw null;
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckEndShootFromStationary()
	{
		throw null;
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckAmmonProcess()
	{
		throw null;
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckIsCloseToTarget()
	{
		throw null;
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DeltaSitTime()
	{
		throw null;
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool LeaveCauseNoAmmo()
	{
		throw null;
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetAmmoInfo()
	{
		throw null;
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallEndShootFromCurrent()
	{
		throw null;
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float CurDistToLeave()
	{
		throw null;
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(Player.AbstractHandsController arg1, Player.AbstractHandsController arg2)
	{
		throw null;
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(Player.FirearmController fireArms)
	{
		throw null;
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_5()
	{
		throw null;
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000F48 RID: 3912
	private const float MAX_STATIONARY_SDIST = 22500f;

	// Token: 0x04000F49 RID: 3913
	private const float AFTER_DROP_SEARCH_DELAY = 15f;

	// Token: 0x04000F4A RID: 3914
	private const float SIMPLE_SEARCH_DELAY = 3f;

	// Token: 0x04000F4B RID: 3915
	private AIStationaryController _curStationaryWeapons;

	// Token: 0x04000F4C RID: 3916
	private GClass551.GInterface13 _stationaryBlockVisionTimer;

	// Token: 0x04000F4D RID: 3917
	private float _lastSpottedTime;

	// Token: 0x04000F4E RID: 3918
	private float _nextPosibleSearchTime;

	// Token: 0x04000F4F RID: 3919
	private float _nextPosibleStartUseTime;

	// Token: 0x04000F50 RID: 3920
	private float _sitTime;

	// Token: 0x04000F51 RID: 3921
	private float _comeCloseTime;

	// Token: 0x04000F52 RID: 3922
	private float _shallEndShootFromCover;

	// Token: 0x04000F53 RID: 3923
	private float _cosToLeave;

	// Token: 0x04000F54 RID: 3924
	private int _spottedTimes;

	// Token: 0x04000F55 RID: 3925
	private float _dropTime;

	// Token: 0x020002FC RID: 764
	[CompilerGenerated]
	private sealed class Class177
	{
		// Token: 0x06001037 RID: 4151 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Player.FirearmController controller)
		{
			throw null;
		}

		// Token: 0x04000F5D RID: 3933
		public Player.FirearmController fireArms;

		// Token: 0x04000F5E RID: 3934
		public BotStationaryWeaponData botStationaryWeaponData_0;
	}
}
