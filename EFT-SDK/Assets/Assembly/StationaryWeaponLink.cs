using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200025E RID: 606
public class StationaryWeaponLink : MonoBehaviour, IAICorePointLink
{
	// Token: 0x17000307 RID: 775
	// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00002050 File Offset: 0x00000250
	public int CurOwnerId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000308 RID: 776
	// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00002050 File Offset: 0x00000250
	public bool BadLoad
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

	// Token: 0x06000B63 RID: 2915 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Init()
	{
		throw null;
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsGrenade()
	{
		throw null;
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFree(int id)
	{
		throw null;
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearOwner()
	{
		throw null;
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOwner(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveAmmo()
	{
		throw null;
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string AmmoInfo()
	{
		throw null;
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCorePoint(AICorePoint core)
	{
		throw null;
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Restore(AICorePointHolder holder)
	{
		throw null;
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanTakeByPrevDeath(float needPeriod)
	{
		throw null;
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeathAtStationary()
	{
		throw null;
	}

	// Token: 0x17000309 RID: 777
	// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00002050 File Offset: 0x00000250
	public AICorePoint CorePointInGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700030A RID: 778
	// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04000C36 RID: 3126
	public StationaryWeapon Weapon;

	// Token: 0x04000C37 RID: 3127
	public Vector3 InitialDir;

	// Token: 0x04000C38 RID: 3128
	public float CosAngleBase;

	// Token: 0x04000C39 RID: 3129
	private Weapon _weaponItem;

	// Token: 0x04000C3A RID: 3130
	private BotOwner _curOwner;

	// Token: 0x04000C3B RID: 3131
	private int _curOwnerId;

	// Token: 0x04000C3C RID: 3132
	private float _lastDeathAtStationary;

	// Token: 0x04000C3E RID: 3134
	[SerializeField]
	private int _corePointId;

	// Token: 0x04000C3F RID: 3135
	[SerializeField]
	private AICorePoint _corePoint;

	// Token: 0x0200025F RID: 607
	[CompilerGenerated]
	private sealed class Class141
	{
		// Token: 0x06000B71 RID: 2929 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StationaryWeapon method_0(StationaryWeapon x1, StationaryWeapon x2)
		{
			throw null;
		}

		// Token: 0x04000C40 RID: 3136
		public Vector3 pos;
	}
}
