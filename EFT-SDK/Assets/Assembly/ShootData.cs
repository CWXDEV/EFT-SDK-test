using System;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020004D3 RID: 1235
public class ShootData
{
	// Token: 0x14000048 RID: 72
	// (add) Token: 0x06001ECE RID: 7886 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001ECF RID: 7887 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnTriggerPressed
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

	// Token: 0x17000591 RID: 1425
	// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 WeaponRootOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000592 RID: 1426
	// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x00002050 File Offset: 0x00000250
	public float LastTriggerPressd
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

	// Token: 0x17000593 RID: 1427
	// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x00002050 File Offset: 0x00000250
	public IFirearmHandsController ShootController
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000594 RID: 1428
	// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001ED5 RID: 7893 RVA: 0x00002050 File Offset: 0x00000250
	public bool Shooting
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

	// Token: 0x17000595 RID: 1429
	// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x00002050 File Offset: 0x00000250
	private BotGlobalAimingSettings BotGlobalAimingSettings_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001ED7 RID: 7895 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001ED8 RID: 7896 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCanShootByState(bool state)
	{
		throw null;
	}

	// Token: 0x06001ED9 RID: 7897 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x17000596 RID: 1430
	// (get) Token: 0x06001EDA RID: 7898 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001EDB RID: 7899 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanShootByState
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

	// Token: 0x06001EDC RID: 7900 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(EPlayerState previousstate, EPlayerState nextstate)
	{
		throw null;
	}

	// Token: 0x06001EDD RID: 7901 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NullShootsBetween()
	{
		throw null;
	}

	// Token: 0x06001EDE RID: 7902 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001EDF RID: 7903 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckFriendlyFire(Vector3 from, Vector3 to)
	{
		throw null;
	}

	// Token: 0x06001EE0 RID: 7904 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Shoot()
	{
		throw null;
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShootDoneWeapon()
	{
		throw null;
	}

	// Token: 0x06001EE2 RID: 7906 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndShoot()
	{
		throw null;
	}

	// Token: 0x06001EE3 RID: 7907 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsManySHootsOnAttack()
	{
		throw null;
	}

	// Token: 0x06001EE4 RID: 7908 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Player method_3(Vector3 weaponRootPos, Vector3 aimTo)
	{
		throw null;
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Player method_4(Collider collider)
	{
		throw null;
	}

	// Token: 0x06001EE7 RID: 7911 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BlockFor(float period)
	{
		throw null;
	}

	// Token: 0x040019BC RID: 6588
	private readonly BotOwner _owner;

	// Token: 0x040019BD RID: 6589
	private readonly Player _player;

	// Token: 0x040019BE RID: 6590
	private float nextFingerUpTime;

	// Token: 0x040019BF RID: 6591
	private float timeFingerDown;

	// Token: 0x040019C0 RID: 6592
	private readonly float _triggersTimeToRun;

	// Token: 0x040019C1 RID: 6593
	private float _triggersDownBetweenStops;

	// Token: 0x040019C2 RID: 6594
	private float nextFingerDownCan;

	// Token: 0x040019C3 RID: 6595
	private readonly RecoilData _recoilData;

	// Token: 0x040019C4 RID: 6596
	private readonly GameWorld _gameWorld;

	// Token: 0x040019C6 RID: 6598
	private Vector3 _weaponRootOffset;
}
