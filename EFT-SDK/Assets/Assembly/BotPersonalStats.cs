using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200050C RID: 1292
public class BotPersonalStats
{
	// Token: 0x06001FBC RID: 8124 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetIndex(float d)
	{
		throw null;
	}

	// Token: 0x14000049 RID: 73
	// (add) Token: 0x06001FBD RID: 8125 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001FBE RID: 8126 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<string, DamageInfo> OnKillTarget
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

	// Token: 0x1400004A RID: 74
	// (add) Token: 0x06001FBF RID: 8127 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001FC0 RID: 8128 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IPlayer, DamageInfo, EBodyPart> OnHitTarget
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

	// Token: 0x170005CD RID: 1485
	// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsEnable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001FC2 RID: 8130 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BotOwner owner, string Zone)
	{
		throw null;
	}

	// Token: 0x06001FC3 RID: 8131 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Enable(bool val = true)
	{
		throw null;
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWeapon(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetShootByTarget(EnemyInfo person)
	{
		throw null;
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShootToTarget(EnemyInfo person, Vector3? pos = null)
	{
		throw null;
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KillTarget(string killer, DamageInfo info)
	{
		throw null;
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HitTarget(IPlayer person, DamageInfo damageInfo, EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GrendateThrow(Vector3? trg)
	{
		throw null;
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Death(EDamageType damageType)
	{
		throw null;
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CoverTaken()
	{
		throw null;
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LeaveCover()
	{
		throw null;
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetHit(DamageInfo damageInfo, EBodyPart bodyType)
	{
		throw null;
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddGetVision(BotOwner owner, EnemyInfo enemyInfo)
	{
		throw null;
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Aim(Vector3 to, float time)
	{
		throw null;
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStandByState(BotStandByType prevByType)
	{
		throw null;
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04001E2A RID: 7722
	public const float DIST1 = 13f;

	// Token: 0x04001E2B RID: 7723
	public const float DIST2 = 27f;

	// Token: 0x04001E2C RID: 7724
	public const float DIST3 = 43f;

	// Token: 0x04001E2D RID: 7725
	public const float DIST4 = 60f;

	// Token: 0x04001E2E RID: 7726
	public const float DIST5 = 86f;

	// Token: 0x04001E2F RID: 7727
	public const float DIST6 = 120f;

	// Token: 0x04001E30 RID: 7728
	public const float DIST7 = 160f;

	// Token: 0x04001E31 RID: 7729
	private const string NULL_ID = "Null_id";

	// Token: 0x04001E32 RID: 7730
	public static float[] DISTANCES;

	// Token: 0x04001E33 RID: 7731
	public static int STAT_INDEX;

	// Token: 0x04001E34 RID: 7732
	public float LifeTime;

	// Token: 0x04001E35 RID: 7733
	public int CoverPointsTaken;

	// Token: 0x04001E36 RID: 7734
	public bool IsDead;

	// Token: 0x04001E37 RID: 7735
	public float TotaTimeInCover;

	// Token: 0x04001E38 RID: 7736
	public float middleGrendaThrowDist;

	// Token: 0x04001E39 RID: 7737
	public float MiddleTimeInCover;

	// Token: 0x04001E3A RID: 7738
	public string WeaponType;

	// Token: 0x04001E3B RID: 7739
	public string Zone;

	// Token: 0x04001E3C RID: 7740
	public string MySide;

	// Token: 0x04001E3D RID: 7741
	public string ProfileId;

	// Token: 0x04001E3E RID: 7742
	public string Difficulty;

	// Token: 0x04001E3F RID: 7743
	public float TotalDamage;

	// Token: 0x04001E40 RID: 7744
	public float BornTime;

	// Token: 0x04001E41 RID: 7745
	public int HaveGrenadesStart;

	// Token: 0x04001E42 RID: 7746
	public int GrenadeTrowed;

	// Token: 0x04001E43 RID: 7747
	public int KilledByGrenade;

	// Token: 0x04001E44 RID: 7748
	public Dictionary<string, GClass544> targetStats;

	// Token: 0x04001E45 RID: 7749
	public Dictionary<string, GClass544> HitsGain;

	// Token: 0x04001E46 RID: 7750
	public Dictionary<string, GClass538> Frags;

	// Token: 0x04001E47 RID: 7751
	public Dictionary<BotStandByType, float> StandByTimes;

	// Token: 0x04001E48 RID: 7752
	public GClass541 gainSightStats;

	// Token: 0x04001E49 RID: 7753
	public GClass536 AimingStats;

	// Token: 0x04001E4A RID: 7754
	private float TimeComeToCover;

	// Token: 0x04001E4B RID: 7755
	private BotOwner _owner;

	// Token: 0x04001E4C RID: 7756
	private bool isWritten;

	// Token: 0x04001E4D RID: 7757
	private float curStandByTime;

	// Token: 0x04001E4E RID: 7758
	public string WildType;

	// Token: 0x04001E51 RID: 7761
	private bool isEnable;
}
