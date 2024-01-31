using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020003D2 RID: 978
public class EnemyInfo
{
	// Token: 0x17000438 RID: 1080
	// (get) Token: 0x06001773 RID: 6003 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveSeenPersonal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000439 RID: 1081
	// (get) Token: 0x06001774 RID: 6004 RVA: 0x00002050 File Offset: 0x00000250
	public virtual EEnemyPartVisibleType VisibleOnlyBySense
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700043A RID: 1082
	// (get) Token: 0x06001775 RID: 6005 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool CanShoot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700043B RID: 1083
	// (get) Token: 0x06001776 RID: 6006 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001777 RID: 6007 RVA: 0x00002050 File Offset: 0x00000250
	public int SearchIndex
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

	// Token: 0x1700043C RID: 1084
	// (get) Token: 0x06001778 RID: 6008 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001779 RID: 6009 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool IsVisible
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

	// Token: 0x1700043D RID: 1085
	// (get) Token: 0x0600177A RID: 6010 RVA: 0x00002050 File Offset: 0x00000250
	public IPlayer Person
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700043E RID: 1086
	// (get) Token: 0x0600177B RID: 6011 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<EnemyPart, EnemyPartData> AllActiveParts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700043F RID: 1087
	// (get) Token: 0x0600177C RID: 6012 RVA: 0x00002050 File Offset: 0x00000250
	public BotsGroup GroupOwner
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000440 RID: 1088
	// (get) Token: 0x0600177D RID: 6013 RVA: 0x00002050 File Offset: 0x00000250
	public float TimeLastSeen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000441 RID: 1089
	// (get) Token: 0x0600177E RID: 6014 RVA: 0x00002050 File Offset: 0x00000250
	public float TimeLastSeenReal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x0600177F RID: 6015 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001780 RID: 6016 RVA: 0x00002050 File Offset: 0x00000250
	public float LastChangeVisionTypeTime
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

	// Token: 0x17000443 RID: 1091
	// (get) Token: 0x06001781 RID: 6017 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001782 RID: 6018 RVA: 0x00002050 File Offset: 0x00000250
	public float PersonalSeenTime
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

	// Token: 0x17000444 RID: 1092
	// (get) Token: 0x06001783 RID: 6019 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001784 RID: 6020 RVA: 0x00002050 File Offset: 0x00000250
	public float PersonalLastSeenTime
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

	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x06001785 RID: 6021 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001786 RID: 6022 RVA: 0x00002050 File Offset: 0x00000250
	public float PersonalLastShootTime
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

	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x06001787 RID: 6023 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001788 RID: 6024 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 PersonalLastPos
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

	// Token: 0x17000447 RID: 1095
	// (get) Token: 0x06001789 RID: 6025 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600178A RID: 6026 RVA: 0x00002050 File Offset: 0x00000250
	public float FirstTimeSeen
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

	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x0600178B RID: 6027 RVA: 0x00002050 File Offset: 0x00000250
	public float AddTime
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x0600178C RID: 6028 RVA: 0x00002050 File Offset: 0x00000250
	public string ProfileId
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700044A RID: 1098
	// (get) Token: 0x0600178D RID: 6029 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600178E RID: 6030 RVA: 0x00002050 File Offset: 0x00000250
	public EnemyPart LastPart
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

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x0600178F RID: 6031 RVA: 0x00002050 File Offset: 0x00000250
	public EnemyPart BodyPart
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700044C RID: 1100
	// (get) Token: 0x06001790 RID: 6032 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001791 RID: 6033 RVA: 0x00002050 File Offset: 0x00000250
	public float Distance
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

	// Token: 0x1700044D RID: 1101
	// (get) Token: 0x06001792 RID: 6034 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 CurrPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700044E RID: 1102
	// (get) Token: 0x06001793 RID: 6035 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001794 RID: 6036 RVA: 0x00002050 File Offset: 0x00000250
	public int PriorityIndex
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

	// Token: 0x1700044F RID: 1103
	// (get) Token: 0x06001795 RID: 6037 RVA: 0x00002050 File Offset: 0x00000250
	public BotOwner Owner
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000450 RID: 1104
	// (get) Token: 0x06001796 RID: 6038 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveSeen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000451 RID: 1105
	// (get) Token: 0x06001797 RID: 6039 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 EnemyLastPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000452 RID: 1106
	// (get) Token: 0x06001798 RID: 6040 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 EnemyLastPositionReal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000453 RID: 1107
	// (get) Token: 0x06001799 RID: 6041 RVA: 0x00002050 File Offset: 0x00000250
	public bool EnemyLastPositionCheck
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000454 RID: 1108
	// (get) Token: 0x0600179A RID: 6042 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 EnemyWeaponRootLastPos
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000455 RID: 1109
	// (get) Token: 0x0600179B RID: 6043 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600179C RID: 6044 RVA: 0x00002050 File Offset: 0x00000250
	public bool IgnoreUntilAggression
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

	// Token: 0x17000456 RID: 1110
	// (get) Token: 0x0600179D RID: 6045 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600179E RID: 6046 RVA: 0x00002050 File Offset: 0x00000250
	public float LastHitTime
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

	// Token: 0x17000457 RID: 1111
	// (get) Token: 0x0600179F RID: 6047 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060017A0 RID: 6048 RVA: 0x00002050 File Offset: 0x00000250
	public float FirstTimeShoot
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

	// Token: 0x17000458 RID: 1112
	// (get) Token: 0x060017A1 RID: 6049 RVA: 0x00002050 File Offset: 0x00000250
	public string Nickname
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060017A2 RID: 6050 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIgnoreState(bool state = true)
	{
		throw null;
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVisible(bool value)
	{
		throw null;
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFullDissapear(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFullDissapearGreen(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallKnowEnemy()
	{
		throw null;
	}

	// Token: 0x060017A7 RID: 6055 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallKnowEnemyLate()
	{
		throw null;
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetPositionForSearch()
	{
		throw null;
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSuppressEndTime(float SupressedEndTime)
	{
		throw null;
	}

	// Token: 0x060017AA RID: 6058 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSuppressed()
	{
		throw null;
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallISuppress()
	{
		throw null;
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeyValuePair<EnemyPart, EnemyPartData> BodyData()
	{
		throw null;
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFarParts()
	{
		throw null;
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMiddleParts()
	{
		throw null;
	}

	// Token: 0x060017AF RID: 6063 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCloseParts()
	{
		throw null;
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetCenterPart()
	{
		throw null;
	}

	// Token: 0x060017B1 RID: 6065 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetPartToShoot()
	{
		throw null;
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdatePartsByPriority()
	{
		throw null;
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrevIsVisible(bool p0)
	{
		throw null;
	}

	// Token: 0x060017B5 RID: 6069 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveNightVision()
	{
		throw null;
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(EEnemyPartVisibleType totalCheckOnlySense)
	{
		throw null;
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCanShoot(bool can)
	{
		throw null;
	}

	// Token: 0x060017B8 RID: 6072 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetDebugInfo()
	{
		throw null;
	}

	// Token: 0x060017B9 RID: 6073 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckLookEnemy(GClass522 lookAll)
	{
		throw null;
	}

	// Token: 0x060017BA RID: 6074 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual GClass521 CheckVisibilityPart(KeyValuePair<EnemyPart, EnemyPartData> enemyPart, bool onSense, bool onSenceGreen, float addVisibility)
	{
		throw null;
	}

	// Token: 0x060017BB RID: 6075 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool CheckVisibleAng(Vector3 position, EnemyPartData data)
	{
		throw null;
	}

	// Token: 0x060017BC RID: 6076 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool CheckVisibility(KeyValuePair<EnemyPart, EnemyPartData> part, float seenCoef, bool onSense, bool onSenceGreen, float addVisibility)
	{
		throw null;
	}

	// Token: 0x060017BD RID: 6077 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CheckCanShoot(KeyValuePair<EnemyPart, EnemyPartData> part)
	{
		throw null;
	}

	// Token: 0x060017BE RID: 6078 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Dictionary<EnemyPart, EnemyPartData> from, Dictionary<EnemyPart, EnemyPartData> to, BodyPartType type)
	{
		throw null;
	}

	// Token: 0x060017BF RID: 6079 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 method_2()
	{
		throw null;
	}

	// Token: 0x060017C0 RID: 6080 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 method_3()
	{
		throw null;
	}

	// Token: 0x060017C1 RID: 6081 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GClass521 visionCheck, GClass521 result)
	{
		throw null;
	}

	// Token: 0x060017C2 RID: 6082 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_5(BifacialTransform BotTransform, BifacialTransform enemy, BotDifficultySettingsClass settings, AIData aiData, float personalLastSeenTime, Vector3 personalLastSeenPos)
	{
		throw null;
	}

	// Token: 0x060017C3 RID: 6083 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_6(float dist, bool flare, ref bool freeLook)
	{
		throw null;
	}

	// Token: 0x060017C4 RID: 6084 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(bool withLegs, bool canBehead)
	{
		throw null;
	}

	// Token: 0x060017C5 RID: 6085 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x060017C6 RID: 6086 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLastShootTime()
	{
		throw null;
	}

	// Token: 0x0400147D RID: 5245
	public int _priorityIndex;

	// Token: 0x0400147E RID: 5246
	public Vector3 Direction;

	// Token: 0x0400147F RID: 5247
	public float _nextPartRndTime;

	// Token: 0x04001480 RID: 5248
	public bool CanISearch;

	// Token: 0x04001481 RID: 5249
	protected bool _haveSeenPersonal;

	// Token: 0x04001482 RID: 5250
	private bool _checkHeadWithBody;

	// Token: 0x04001483 RID: 5251
	public BotSettingsClass GroupInfo;

	// Token: 0x04001484 RID: 5252
	public float LastChangeVisionTime;

	// Token: 0x04001485 RID: 5253
	public float SeenCoef;

	// Token: 0x04001486 RID: 5254
	public readonly float VISIBLE_ANGLE;

	// Token: 0x04001487 RID: 5255
	public readonly float VISIBLE_ANGLE_LIGHT;

	// Token: 0x04001488 RID: 5256
	public readonly float VISIBLE_ANGLE_NIGHTVISION;

	// Token: 0x04001489 RID: 5257
	protected EEnemyPartVisibleType _visibleOnlyBySense;

	// Token: 0x0400148A RID: 5258
	protected bool _canShoot;

	// Token: 0x0400148B RID: 5259
	private EnemyPriority _priority;

	// Token: 0x0400148C RID: 5260
	private KeyValuePair<EnemyPart, EnemyPartData> _bodyPart;

	// Token: 0x0400148D RID: 5261
	private KeyValuePair<EnemyPart, EnemyPartData> _headPart;

	// Token: 0x0400148E RID: 5262
	private readonly Dictionary<EnemyPart, EnemyPartData> _maxparts;

	// Token: 0x0400148F RID: 5263
	private readonly Dictionary<EnemyPart, EnemyPartData> _middleParts;

	// Token: 0x04001490 RID: 5264
	private readonly Dictionary<EnemyPart, EnemyPartData> farParts;

	// Token: 0x04001491 RID: 5265
	private readonly Dictionary<BodyPartType, int> _shootsCount;

	// Token: 0x04001492 RID: 5266
	private float _distance;

	// Token: 0x04001493 RID: 5267
	private Dictionary<EnemyPart, EnemyPartData> _activeParts;

	// Token: 0x04001494 RID: 5268
	private readonly Dictionary<EnemyPart, EnemyPartData> _allParts;

	// Token: 0x04001495 RID: 5269
	private bool _lastCheckVision;

	// Token: 0x04001496 RID: 5270
	private readonly GClass521 totalCheck;

	// Token: 0x020003D3 RID: 979
	[CompilerGenerated]
	[Serializable]
	private sealed class Class203
	{
		// Token: 0x060017C7 RID: 6087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(EnemyPart x)
		{
			throw null;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(EnemyPart x)
		{
			throw null;
		}

		// Token: 0x040014A9 RID: 5289
		public static readonly EnemyInfo.Class203 class203_0;

		// Token: 0x040014AA RID: 5290
		public static Func<EnemyPart, bool> func_0;

		// Token: 0x040014AB RID: 5291
		public static Func<EnemyPart, bool> func_1;
	}

	// Token: 0x020003D4 RID: 980
	[CompilerGenerated]
	private sealed class Class204
	{
		// Token: 0x060017C9 RID: 6089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(EnemyPart x)
		{
			throw null;
		}

		// Token: 0x040014AC RID: 5292
		public BodyPartType type;
	}
}
