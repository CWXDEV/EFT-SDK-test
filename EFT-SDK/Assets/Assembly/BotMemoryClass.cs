using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x0200118C RID: 4492
public class BotMemoryClass
{
	// Token: 0x14000105 RID: 261
	// (add) Token: 0x06005ED3 RID: 24275 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005ED4 RID: 24276 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IPlayer> OnAddEnemy
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

	// Token: 0x14000106 RID: 262
	// (add) Token: 0x06005ED5 RID: 24277 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005ED6 RID: 24278 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotOwner> OnGoalEnemyChanged
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

	// Token: 0x14000107 RID: 263
	// (add) Token: 0x06005ED7 RID: 24279 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005ED8 RID: 24280 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnInCoverChange
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

	// Token: 0x14000108 RID: 264
	// (add) Token: 0x06005ED9 RID: 24281 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005EDA RID: 24282 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnPeaceChange
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

	// Token: 0x14000109 RID: 265
	// (add) Token: 0x06005EDB RID: 24283 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005EDC RID: 24284 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Vector3?> OnSpottedByHit
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

	// Token: 0x1400010A RID: 266
	// (add) Token: 0x06005EDD RID: 24285 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005EDE RID: 24286 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotOwner, IPlayer> OnBulletNear
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

	// Token: 0x17000EAE RID: 3758
	// (get) Token: 0x06005EDF RID: 24287 RVA: 0x00002050 File Offset: 0x00000250
	public CustomNavigationPoint CurCustomCoverPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000EAF RID: 3759
	// (get) Token: 0x06005EE0 RID: 24288 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EE1 RID: 24289 RVA: 0x00002050 File Offset: 0x00000250
	public GClass496 LastDamageData
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

	// Token: 0x17000EB0 RID: 3760
	// (get) Token: 0x06005EE2 RID: 24290 RVA: 0x00002050 File Offset: 0x00000250
	public bool LastDamageDataActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000EB1 RID: 3761
	// (get) Token: 0x06005EE3 RID: 24291 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsDamaged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000EB2 RID: 3762
	// (get) Token: 0x06005EE4 RID: 24292 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EE5 RID: 24293 RVA: 0x00002050 File Offset: 0x00000250
	public float ComeToCoverTime
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

	// Token: 0x17000EB3 RID: 3763
	// (get) Token: 0x06005EE6 RID: 24294 RVA: 0x00002050 File Offset: 0x00000250
	public float LeaveCoverTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000EB4 RID: 3764
	// (get) Token: 0x06005EE7 RID: 24295 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EE8 RID: 24296 RVA: 0x00002050 File Offset: 0x00000250
	public float LastTimeHit
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

	// Token: 0x17000EB5 RID: 3765
	// (get) Token: 0x06005EE9 RID: 24297 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EEA RID: 24298 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 LastHitPos
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

	// Token: 0x17000EB6 RID: 3766
	// (get) Token: 0x06005EEB RID: 24299 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EEC RID: 24300 RVA: 0x00002050 File Offset: 0x00000250
	public float EnemySetTime
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

	// Token: 0x17000EB7 RID: 3767
	// (get) Token: 0x06005EED RID: 24301 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EEE RID: 24302 RVA: 0x00002050 File Offset: 0x00000250
	public bool ShallRunIfNoAmmo
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

	// Token: 0x17000EB8 RID: 3768
	// (get) Token: 0x06005EEF RID: 24303 RVA: 0x00002050 File Offset: 0x00000250
	public bool ShallChangeCoverToFindEnemy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000EB9 RID: 3769
	// (get) Token: 0x06005EF0 RID: 24304 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EF1 RID: 24305 RVA: 0x00002050 File Offset: 0x00000250
	public EnemyInfo LastEnemy
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

	// Token: 0x17000EBA RID: 3770
	// (get) Token: 0x06005EF2 RID: 24306 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EF3 RID: 24307 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInCover
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

	// Token: 0x17000EBB RID: 3771
	// (get) Token: 0x06005EF4 RID: 24308 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EF5 RID: 24309 RVA: 0x00002050 File Offset: 0x00000250
	public EnemyInfo GoalEnemy
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

	// Token: 0x17000EBC RID: 3772
	// (get) Token: 0x06005EF6 RID: 24310 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EF7 RID: 24311 RVA: 0x00002050 File Offset: 0x00000250
	public float LastEnemyTimeSeen
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

	// Token: 0x17000EBD RID: 3773
	// (get) Token: 0x06005EF8 RID: 24312 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EF9 RID: 24313 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsPeace
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

	// Token: 0x17000EBE RID: 3774
	// (get) Token: 0x06005EFA RID: 24314 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EFB RID: 24315 RVA: 0x00002050 File Offset: 0x00000250
	public bool AttackImmediately
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

	// Token: 0x17000EBF RID: 3775
	// (get) Token: 0x06005EFC RID: 24316 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005EFD RID: 24317 RVA: 0x00002050 File Offset: 0x00000250
	public float UnderFireTime
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

	// Token: 0x17000EC0 RID: 3776
	// (get) Token: 0x06005EFE RID: 24318 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsUnderFire
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000EC1 RID: 3777
	// (get) Token: 0x06005EFF RID: 24319 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveEnemy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000EC2 RID: 3778
	// (get) Token: 0x06005F00 RID: 24320 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveGoal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06005F01 RID: 24321 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(IEffect obj)
	{
		throw null;
	}

	// Token: 0x06005F02 RID: 24322 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Spotted(bool byHit, Vector3? from = null, float? secToBeSpotted = null)
	{
		throw null;
	}

	// Token: 0x06005F03 RID: 24323 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool LastEnemyVisionOld(float delta)
	{
		throw null;
	}

	// Token: 0x06005F04 RID: 24324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCoverPoints(CustomNavigationPoint value, string debugdata = "")
	{
		throw null;
	}

	// Token: 0x06005F05 RID: 24325 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoseVisionCurrentEnemy()
	{
		throw null;
	}

	// Token: 0x06005F06 RID: 24326 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckIsInCover2()
	{
		throw null;
	}

	// Token: 0x06005F07 RID: 24327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06005F08 RID: 24328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06005F09 RID: 24329 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteInfoAboutEnemy(IPlayer gamePerson)
	{
		throw null;
	}

	// Token: 0x06005F0A RID: 24330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEnemy([NotNull] IPlayer enemy, BotSettingsClass groupInfo, bool onActivation)
	{
		throw null;
	}

	// Token: 0x06005F0B RID: 24331 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string MessageInfo(bool withN = true)
	{
		throw null;
	}

	// Token: 0x06005F0C RID: 24332 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLastTimeSeeEnemy()
	{
		throw null;
	}

	// Token: 0x06005F0D RID: 24333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemovePlaceForCheck(List<PlaceForCheck> list)
	{
		throw null;
	}

	// Token: 0x06005F0E RID: 24334 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06005F0F RID: 24335 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ComeToPoint()
	{
		throw null;
	}

	// Token: 0x06005F10 RID: 24336 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetHit(DamageInfo damageInfo)
	{
		throw null;
	}

	// Token: 0x06005F11 RID: 24337 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPanicPoint(PlaceForCheck placeForCheck, bool realDanger)
	{
		throw null;
	}

	// Token: 0x06005F12 RID: 24338 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryGetInCoverSay()
	{
		throw null;
	}

	// Token: 0x06005F13 RID: 24339 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BodyFound(GClass320 body)
	{
		throw null;
	}

	// Token: 0x06005F14 RID: 24340 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckIsPeace()
	{
		throw null;
	}

	// Token: 0x06005F15 RID: 24341 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUnderFire(IPlayer source)
	{
		throw null;
	}

	// Token: 0x06005F16 RID: 24342 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UseDogFightOut()
	{
		throw null;
	}

	// Token: 0x06005F17 RID: 24343 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(bool toChange)
	{
		throw null;
	}

	// Token: 0x06005F18 RID: 24344 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(DamageInfo damageInfo, EBodyPart eBodyPart, float val)
	{
		throw null;
	}

	// Token: 0x06005F19 RID: 24345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06005F1A RID: 24346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06005F1B RID: 24347 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06005F1C RID: 24348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(DamageInfo damageInfo)
	{
		throw null;
	}

	// Token: 0x06005F1D RID: 24349 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04006935 RID: 26933
	public const float SDIST_TO_AFFECT_CLOSE_ENEMY = 625f;

	// Token: 0x04006936 RID: 26934
	public const float SDIST_CLOSE_COVER = 1.6f;

	// Token: 0x04006937 RID: 26935
	public PlaceForCheck CurrentPlaceForCheck;

	// Token: 0x04006938 RID: 26936
	public GClass458 DangerData;

	// Token: 0x04006939 RID: 26937
	public GClass357 BotCurrentCoverInfo;

	// Token: 0x0400693A RID: 26938
	public Vector3 ActivatedPos;

	// Token: 0x0400693B RID: 26939
	public GClass424 botObserveData;

	// Token: 0x0400693C RID: 26940
	public GClass389 GoalTarget;

	// Token: 0x0400693D RID: 26941
	private readonly BotsGroup botsGroup_0;

	// Token: 0x0400693E RID: 26942
	private readonly BotOwner botOwner_0;

	// Token: 0x0400693F RID: 26943
	private bool bool_0;

	// Token: 0x04006940 RID: 26944
	private EnemyInfo enemyInfo_0;

	// Token: 0x04006941 RID: 26945
	private PlaceForCheck placeForCheck_0;

	// Token: 0x04006942 RID: 26946
	private float float_0;

	// Token: 0x04006943 RID: 26947
	private float float_1;

	// Token: 0x04006944 RID: 26948
	private float float_2;

	// Token: 0x04006945 RID: 26949
	private float float_3;

	// Token: 0x04006946 RID: 26950
	private readonly bool bool_1;

	// Token: 0x04006947 RID: 26951
	private GClass527 gclass527_0;

	// Token: 0x04006948 RID: 26952
	private float float_4;

	// Token: 0x04006949 RID: 26953
	private float float_5;

	// Token: 0x0400694A RID: 26954
	[CompilerGenerated]
	private Action<IPlayer> action_0;

	// Token: 0x0400694B RID: 26955
	[CompilerGenerated]
	private Action<BotOwner> action_1;

	// Token: 0x0400694C RID: 26956
	[CompilerGenerated]
	private Action<bool> action_2;

	// Token: 0x0400694D RID: 26957
	[CompilerGenerated]
	private Action<bool> action_3;

	// Token: 0x0400694E RID: 26958
	[CompilerGenerated]
	private Action<Vector3?> action_4;

	// Token: 0x0400694F RID: 26959
	[CompilerGenerated]
	private Action<BotOwner, IPlayer> action_5;

	// Token: 0x04006950 RID: 26960
	public float nextTryMoveToEnemyLogTime;

	// Token: 0x04006951 RID: 26961
	[CompilerGenerated]
	private GClass496 gclass496_0;

	// Token: 0x04006952 RID: 26962
	[CompilerGenerated]
	private float float_6;

	// Token: 0x04006953 RID: 26963
	[CompilerGenerated]
	private float float_7;

	// Token: 0x04006954 RID: 26964
	[CompilerGenerated]
	private Vector3 vector3_0;

	// Token: 0x04006955 RID: 26965
	[CompilerGenerated]
	private float float_8;

	// Token: 0x04006956 RID: 26966
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x04006957 RID: 26967
	[CompilerGenerated]
	private EnemyInfo enemyInfo_1;

	// Token: 0x04006958 RID: 26968
	[CompilerGenerated]
	private float float_9;

	// Token: 0x04006959 RID: 26969
	[CompilerGenerated]
	private bool bool_3;

	// Token: 0x0400695A RID: 26970
	[CompilerGenerated]
	private bool bool_4;

	// Token: 0x0400695B RID: 26971
	[CompilerGenerated]
	private float float_10;

	// Token: 0x0200118D RID: 4493
	[CompilerGenerated]
	private sealed class Class871
	{
		// Token: 0x06005F1E RID: 24350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(EDamageType health)
		{
			throw null;
		}

		// Token: 0x0400695C RID: 26972
		public BotMemoryClass gclass1298_0;

		// Token: 0x0400695D RID: 26973
		public IPlayer enemy;
	}

	// Token: 0x0200118E RID: 4494
	[CompilerGenerated]
	private sealed class Class872
	{
		// Token: 0x06005F1F RID: 24351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400695E RID: 26974
		public BotMemoryClass gclass1298_0;

		// Token: 0x0400695F RID: 26975
		public DamageInfo damageInfo;
	}
}
