using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x020002FE RID: 766
public class BotWeaponManager : GClass362
{
	// Token: 0x170003DC RID: 988
	// (get) Token: 0x0600103A RID: 4154 RVA: 0x00002050 File Offset: 0x00000250
	public WeaponAIPreset WeaponAIPreset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003DE RID: 990
	// (get) Token: 0x0600103B RID: 4155 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600103C RID: 4156 RVA: 0x00002050 File Offset: 0x00000250
	public BotMeleeWeaponData Melee
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

	// Token: 0x170003DF RID: 991
	// (get) Token: 0x0600103D RID: 4157 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600103E RID: 4158 RVA: 0x00002050 File Offset: 0x00000250
	public BotStationaryWeaponData Stationary
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

	// Token: 0x170003E0 RID: 992
	// (get) Token: 0x0600103F RID: 4159 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001040 RID: 4160 RVA: 0x00002050 File Offset: 0x00000250
	public BotGrenadeController Grenades
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

	// Token: 0x170003E1 RID: 993
	// (get) Token: 0x06001041 RID: 4161 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001042 RID: 4162 RVA: 0x00002050 File Offset: 0x00000250
	public BotMalfunctionData Malfunctions
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

	// Token: 0x170003E2 RID: 994
	// (get) Token: 0x06001043 RID: 4163 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsMelee
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003E3 RID: 995
	// (get) Token: 0x06001044 RID: 4164 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001045 RID: 4165 RVA: 0x00002050 File Offset: 0x00000250
	public IFirearmHandsController ShootController
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

	// Token: 0x170003E4 RID: 996
	// (get) Token: 0x06001046 RID: 4166 RVA: 0x00002050 File Offset: 0x00000250
	public BotReload Reload
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003E5 RID: 997
	// (get) Token: 0x06001047 RID: 4167 RVA: 0x00002050 File Offset: 0x00000250
	public BotWeaponInfo PistolWeaponInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003E6 RID: 998
	// (get) Token: 0x06001048 RID: 4168 RVA: 0x00002050 File Offset: 0x00000250
	public BotWeaponInfo MainWeaponInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003E7 RID: 999
	// (get) Token: 0x06001049 RID: 4169 RVA: 0x00002050 File Offset: 0x00000250
	public BotWeaponInfo SecondWeaponInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003E8 RID: 1000
	// (get) Token: 0x0600104A RID: 4170 RVA: 0x00002050 File Offset: 0x00000250
	public BotWeaponInfo MeleeWeaponInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003E9 RID: 1001
	// (get) Token: 0x0600104B RID: 4171 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600104C RID: 4172 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsReady
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

	// Token: 0x170003EA RID: 1002
	// (get) Token: 0x0600104D RID: 4173 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveBullets
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003EB RID: 1003
	// (get) Token: 0x0600104E RID: 4174 RVA: 0x00002050 File Offset: 0x00000250
	public Weapon CurrentWeapon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(EquipmentSlot slot)
	{
		throw null;
	}

	// Token: 0x170003EC RID: 1004
	// (get) Token: 0x06001050 RID: 4176 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsNowAutomatic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003ED RID: 1005
	// (get) Token: 0x06001051 RID: 4177 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001052 RID: 4178 RVA: 0x00002050 File Offset: 0x00000250
	public float AmbushDistance
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

	// Token: 0x170003EE RID: 1006
	// (get) Token: 0x06001053 RID: 4179 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001054 RID: 4180 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsCloseWeapon
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

	// Token: 0x170003EF RID: 1007
	// (get) Token: 0x06001055 RID: 4181 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsWeaponReady
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Activate()
	{
		throw null;
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PreActivate()
	{
		throw null;
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StationaryTaken(IFirearmHandsController fireArms, StationaryWeapon stationaryWeapon)
	{
		throw null;
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckCurMainWeapon()
	{
		throw null;
	}

	// Token: 0x0600105B RID: 4187 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateWeaponsList()
	{
		throw null;
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckWeaponReady()
	{
		throw null;
	}

	// Token: 0x0600105D RID: 4189 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InIdleState()
	{
		throw null;
	}

	// Token: 0x0600105E RID: 4190 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateHandsController(GInterface123 handsController, out bool allFine)
	{
		throw null;
	}

	// Token: 0x0600105F RID: 4191 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(IFirearmHandsController firearmHandsController, [CanBeNull] StationaryWeapon stationaryWeapon)
	{
		throw null;
	}

	// Token: 0x06001060 RID: 4192 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000F62 RID: 3938
	private readonly GClass396 _presetCollection;

	// Token: 0x04000F63 RID: 3939
	private Dictionary<EquipmentSlot, BotWeaponInfo> info;

	// Token: 0x04000F64 RID: 3940
	private BotWeaponInfo _currentWeaponInfo;

	// Token: 0x04000F6A RID: 3946
	private bool _canBeAutomatic;

	// Token: 0x04000F6D RID: 3949
	public float CriticalBulletCount;

	// Token: 0x04000F6E RID: 3950
	private bool _disposed;
}
