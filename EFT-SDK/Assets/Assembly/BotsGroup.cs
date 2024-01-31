using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02000495 RID: 1173
public class BotsGroup
{
	// Token: 0x170004F1 RID: 1265
	// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001C2B RID: 7211 RVA: 0x00002050 File Offset: 0x00000250
	public bool Locked
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

	// Token: 0x14000038 RID: 56
	// (add) Token: 0x06001C2C RID: 7212 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001C2D RID: 7213 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IPlayer, EBotEnemyCause> OnEnemyAdd
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

	// Token: 0x14000039 RID: 57
	// (add) Token: 0x06001C2E RID: 7214 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001C2F RID: 7215 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IPlayer> OnEnemyRemove
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

	// Token: 0x1400003A RID: 58
	// (add) Token: 0x06001C30 RID: 7216 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001C31 RID: 7217 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IPlayer> OnAddNeutral
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

	// Token: 0x1400003B RID: 59
	// (add) Token: 0x06001C32 RID: 7218 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001C33 RID: 7219 RVA: 0x00002050 File Offset: 0x00000250
	public event GDelegate5 OnReportEnemy
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

	// Token: 0x1400003C RID: 60
	// (add) Token: 0x06001C34 RID: 7220 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001C35 RID: 7221 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotOwner> OnBossSetted
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

	// Token: 0x1400003D RID: 61
	// (add) Token: 0x06001C36 RID: 7222 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001C37 RID: 7223 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotOwner> OnMemberRemove
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

	// Token: 0x1400003E RID: 62
	// (add) Token: 0x06001C38 RID: 7224 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001C39 RID: 7225 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotOwner> OnMemberAdd
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

	// Token: 0x170004F2 RID: 1266
	// (get) Token: 0x06001C3A RID: 7226 RVA: 0x00002050 File Offset: 0x00000250
	public WildSpawnType InitialBotType
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004F3 RID: 1267
	// (get) Token: 0x06001C3B RID: 7227 RVA: 0x00002050 File Offset: 0x00000250
	public BotDifficulty InitialBotDifficulty
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004F4 RID: 1268
	// (get) Token: 0x06001C3C RID: 7228 RVA: 0x00002050 File Offset: 0x00000250
	public BotSettingsComponents InitialFileSettings
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004F5 RID: 1269
	// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00002050 File Offset: 0x00000250
	public List<IPlayer> Allies
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004F6 RID: 1270
	// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001C3F RID: 7231 RVA: 0x00002050 File Offset: 0x00000250
	public BossGroup BossGroup
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

	// Token: 0x170004F7 RID: 1271
	// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00002050 File Offset: 0x00000250
	public int DangerAreasCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004F8 RID: 1272
	// (get) Token: 0x06001C41 RID: 7233 RVA: 0x00002050 File Offset: 0x00000250
	public int AssaultGroupsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004F9 RID: 1273
	// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001C43 RID: 7235 RVA: 0x00002050 File Offset: 0x00000250
	public float EnemyLastSeenTimeSence
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

	// Token: 0x170004FA RID: 1274
	// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001C45 RID: 7237 RVA: 0x00002050 File Offset: 0x00000250
	public float EnemyLastSeenTimeReal
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

	// Token: 0x170004FB RID: 1275
	// (get) Token: 0x06001C46 RID: 7238 RVA: 0x00002050 File Offset: 0x00000250
	public BotsGroupGrenade GroupGrenade
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004FC RID: 1276
	// (get) Token: 0x06001C47 RID: 7239 RVA: 0x00002050 File Offset: 0x00000250
	public BotsGroupLaying GroupLaying
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004FD RID: 1277
	// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00002050 File Offset: 0x00000250
	public BotGroupTalk GroupTalk
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004FE RID: 1278
	// (get) Token: 0x06001C49 RID: 7241 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001C4A RID: 7242 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 EnemyLastSeenPositionReal
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

	// Token: 0x170004FF RID: 1279
	// (get) Token: 0x06001C4B RID: 7243 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001C4C RID: 7244 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 EnemyLastSeenPositionSence
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

	// Token: 0x17000500 RID: 1280
	// (get) Token: 0x06001C4D RID: 7245 RVA: 0x00002050 File Offset: 0x00000250
	public LastSoundsController LastSoundsController
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000501 RID: 1281
	// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00002050 File Offset: 0x00000250
	public CoverPointMaster CoverPointMaster
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000502 RID: 1282
	// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00002050 File Offset: 0x00000250
	public BotZone BotZone
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000503 RID: 1283
	// (get) Token: 0x06001C50 RID: 7248 RVA: 0x00002050 File Offset: 0x00000250
	public DeadBodiesController DeadBodiesController
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000504 RID: 1284
	// (get) Token: 0x06001C51 RID: 7249 RVA: 0x00002050 File Offset: 0x00000250
	public string Name
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000505 RID: 1285
	// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00002050 File Offset: 0x00000250
	public int Id
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000506 RID: 1286
	// (get) Token: 0x06001C53 RID: 7251 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001C54 RID: 7252 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsLastPositionOld
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

	// Token: 0x17000507 RID: 1287
	// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00002050 File Offset: 0x00000250
	public BotGroupRequestController RequestsController
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000508 RID: 1288
	// (get) Token: 0x06001C56 RID: 7254 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001C57 RID: 7255 RVA: 0x00002050 File Offset: 0x00000250
	public bool ForcedAggressiveForNewPlayers
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

	// Token: 0x17000509 RID: 1289
	// (get) Token: 0x06001C58 RID: 7256 RVA: 0x00002050 File Offset: 0x00000250
	public float GroupPower
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700050A RID: 1290
	// (get) Token: 0x06001C59 RID: 7257 RVA: 0x00002050 File Offset: 0x00000250
	private float Single_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700050B RID: 1291
	// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00002050 File Offset: 0x00000250
	public int MembersCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700050C RID: 1292
	// (get) Token: 0x06001C5B RID: 7259 RVA: 0x00002050 File Offset: 0x00000250
	public int AllyCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700050D RID: 1293
	// (get) Token: 0x06001C5C RID: 7260 RVA: 0x00002050 File Offset: 0x00000250
	public List<PlaceForCheck> PlacesForCheck
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700050E RID: 1294
	// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001C5E RID: 7262 RVA: 0x00002050 File Offset: 0x00000250
	public bool AnyBodyShootImmediately
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

	// Token: 0x1700050F RID: 1295
	// (get) Token: 0x06001C5F RID: 7263 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001C60 RID: 7264 RVA: 0x00002050 File Offset: 0x00000250
	public int TargetMembersCount
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

	// Token: 0x17000510 RID: 1296
	// (get) Token: 0x06001C61 RID: 7265 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001C62 RID: 7266 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsFull
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

	// Token: 0x06001C63 RID: 7267 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Lock()
	{
		throw null;
	}

	// Token: 0x06001C64 RID: 7268 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPlayerEnemy(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06001C65 RID: 7269 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsAlly(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06001C66 RID: 7270 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPlayerEnemyByRole(WildSpawnType role)
	{
		throw null;
	}

	// Token: 0x06001C67 RID: 7271 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAggressiveToAllNewPlayers(bool state)
	{
		throw null;
	}

	// Token: 0x06001C68 RID: 7272 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveMemberWithRole(WildSpawnType type)
	{
		throw null;
	}

	// Token: 0x06001C69 RID: 7273 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEnemyGroupIfAllowed(string playerGroupId, EPlayerSide playerSide)
	{
		throw null;
	}

	// Token: 0x06001C6A RID: 7274 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BotOwner Member(int i)
	{
		throw null;
	}

	// Token: 0x06001C6B RID: 7275 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(BotOwner member)
	{
		throw null;
	}

	// Token: 0x06001C6C RID: 7276 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalcGoalForBot(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06001C6D RID: 7277 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlaceForCheck YoungestFastPlace(BotOwner owner, float distRestriction, float timeOld)
	{
		throw null;
	}

	// Token: 0x06001C6E RID: 7278 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlaceForCheck YoungestPlace(BotOwner owner, float distRestriction, bool priorityDanger)
	{
		throw null;
	}

	// Token: 0x06001C6F RID: 7279 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddAlly(Player ally)
	{
		throw null;
	}

	// Token: 0x06001C70 RID: 7280 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAlly(BotOwner ally)
	{
		throw null;
	}

	// Token: 0x06001C71 RID: 7281 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReportAboutEnemy([NotNull] IPlayer enemy, EEnemyPartVisibleType isVisibleOnlyBySence)
	{
		throw null;
	}

	// Token: 0x06001C72 RID: 7282 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInSmoke(Vector3 p)
	{
		throw null;
	}

	// Token: 0x06001C73 RID: 7283 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSmokePlace(Vector3 pos, float duration, float radius, Vector3 throwPos)
	{
		throw null;
	}

	// Token: 0x06001C74 RID: 7284 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlaceForCheck AddPointToSearch(Vector3 suspectedPoint, float power, BotOwner owner, bool baseReacheble = true, bool canUseCovers = true)
	{
		throw null;
	}

	// Token: 0x06001C75 RID: 7285 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveInfo(IPlayer person)
	{
		throw null;
	}

	// Token: 0x06001C76 RID: 7286 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AddEnemy(IPlayer person, EBotEnemyCause cause)
	{
		throw null;
	}

	// Token: 0x06001C77 RID: 7287 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlaceChecked(PlaceForCheck currentPlaceForCheck)
	{
		throw null;
	}

	// Token: 0x06001C78 RID: 7288 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveEnemy(IPlayer player, EBotEnemyCause cause = EBotEnemyCause.initial)
	{
		throw null;
	}

	// Token: 0x06001C79 RID: 7289 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeletePlayerCauseDead(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06001C7A RID: 7290 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PointChecked(PlaceForCheck place)
	{
		throw null;
	}

	// Token: 0x06001C7B RID: 7291 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoseVision(IPlayer target)
	{
		throw null;
	}

	// Token: 0x06001C7C RID: 7292 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetVision()
	{
		throw null;
	}

	// Token: 0x06001C7D RID: 7293 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string MessageInfoWide()
	{
		throw null;
	}

	// Token: 0x06001C7E RID: 7294 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string MessageInfo()
	{
		throw null;
	}

	// Token: 0x06001C7F RID: 7295 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckAndAddEnemy(IPlayer player, bool ignoreAI = false)
	{
		throw null;
	}

	// Token: 0x06001C80 RID: 7296 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNeutral(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06001C81 RID: 7297 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEnemy(IPlayer requester)
	{
		throw null;
	}

	// Token: 0x06001C82 RID: 7298 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLastVisionEnemyTimeSence(float enemyLastSeenTime, Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06001C83 RID: 7299 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLastVisionEnemyTimeReal(float enemyLastSeenTime, Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06001C84 RID: 7300 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BossAppear(BotOwner botBoss)
	{
		throw null;
	}

	// Token: 0x06001C85 RID: 7301 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsEnemy(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06001C86 RID: 7302 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSuitable(WildSpawnType tested)
	{
		throw null;
	}

	// Token: 0x06001C87 RID: 7303 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEnemyPos(IPlayer enemy, Vector3 enemyPos, Vector3 weaponRootLast, EEnemyPartVisibleType isVisibleOnlyBySense)
	{
		throw null;
	}

	// Token: 0x06001C88 RID: 7304 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BotOwner ClosestMemberToPoint(Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06001C89 RID: 7305 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06001C8A RID: 7306 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(BotOwner member)
	{
		throw null;
	}

	// Token: 0x06001C8B RID: 7307 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddMember(BotOwner ally, bool onActivation)
	{
		throw null;
	}

	// Token: 0x06001C8C RID: 7308 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06001C8D RID: 7309 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06001C8E RID: 7310 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_4(float newestPosition)
	{
		throw null;
	}

	// Token: 0x06001C8F RID: 7311 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_5(Vector3 pos, PlaceForCheck place2check)
	{
		throw null;
	}

	// Token: 0x06001C90 RID: 7312 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_6(PlaceForCheck place2check)
	{
		throw null;
	}

	// Token: 0x06001C91 RID: 7313 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x06001C92 RID: 7314 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(bool checkEnemiesOnDead)
	{
		throw null;
	}

	// Token: 0x06001C93 RID: 7315 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9()
	{
		throw null;
	}

	// Token: 0x06001C94 RID: 7316 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10(PlaceForCheck placeForCheck)
	{
		throw null;
	}

	// Token: 0x06001C95 RID: 7317 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11()
	{
		throw null;
	}

	// Token: 0x06001C96 RID: 7318 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12()
	{
		throw null;
	}

	// Token: 0x06001C97 RID: 7319 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private PlaceForCheck method_13(BotOwner owner, Vector3 suspectedPoint, PlaceForCheckType type, bool canUseCovrPoints = true)
	{
		throw null;
	}

	// Token: 0x06001C98 RID: 7320 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<PlaceForCheck> method_14(Vector3 pos, PlaceForCheck pfc = null)
	{
		throw null;
	}

	// Token: 0x06001C99 RID: 7321 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BotSettingsClass> GetLastSeenPositions()
	{
		throw null;
	}

	// Token: 0x06001C9A RID: 7322 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_15(PlaceForCheck place)
	{
		throw null;
	}

	// Token: 0x06001C9B RID: 7323 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_16()
	{
		throw null;
	}

	// Token: 0x06001C9C RID: 7324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_17(BotOwner botOwner, BotsGroup.BotCurrentTactic globalCurrentTactic)
	{
		throw null;
	}

	// Token: 0x06001C9D RID: 7325 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06001C9E RID: 7326 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallRevengeFor(IPlayer target)
	{
		throw null;
	}

	// Token: 0x06001C9F RID: 7327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveBoss(out BotOwner botBoss)
	{
		throw null;
	}

	// Token: 0x06001CA0 RID: 7328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveFollowTarget(IPlayer aggressor)
	{
		throw null;
	}

	// Token: 0x06001CA1 RID: 7329 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BotOwner GetRandomMember()
	{
		throw null;
	}

	// Token: 0x04001800 RID: 6144
	public readonly IBotGame BotGame;

	// Token: 0x04001801 RID: 6145
	public Dictionary<IPlayer, BotSettingsClass> Enemies;

	// Token: 0x04001802 RID: 6146
	public Dictionary<IPlayer, BotSettingsClass> Neutrals;

	// Token: 0x04001803 RID: 6147
	public EPlayerSide Side;

	// Token: 0x04001805 RID: 6149
	public BotCurrentEnemiesClass CurrentEnemies;

	// Token: 0x04001806 RID: 6150
	private readonly List<BotOwner> _members;

	// Token: 0x04001807 RID: 6151
	private readonly List<GClass495> _grenadeSmokePlaces;

	// Token: 0x04001808 RID: 6152
	private float _nextGetGoalTime;

	// Token: 0x04001809 RID: 6153
	private readonly GClass490 GroupDangerAreas;

	// Token: 0x0400180A RID: 6154
	private readonly WildSpawnType _defWildSpawnType;

	// Token: 0x0400180B RID: 6155
	private readonly BotGlobalsMindSettings _initialBotMindSettings;

	// Token: 0x0400180C RID: 6156
	private readonly List<string> _enemyPlayerGroups;

	// Token: 0x0400180D RID: 6157
	private readonly bool _enemyByGroupsPmcPlayers;

	// Token: 0x0400180E RID: 6158
	private readonly bool _enemyByGroupsSavagePlayers;

	// Token: 0x0400180F RID: 6159
	private BotOwner _initialBot;

	// Token: 0x04001810 RID: 6160
	private bool _isFirstMemberAdded;

	// Token: 0x04001811 RID: 6161
	private readonly List<IPlayer> _recheckPersonsAfterInit;

	// Token: 0x04001832 RID: 6194
	private static int _groupsIds;

	// Token: 0x02000496 RID: 1174
	public enum BotCurrentTactic
	{
		// Token: 0x04001834 RID: 6196
		Attack,
		// Token: 0x04001835 RID: 6197
		Ambush,
		// Token: 0x04001836 RID: 6198
		Protect
	}

	// Token: 0x02000497 RID: 1175
	[CompilerGenerated]
	[Serializable]
	private sealed class Class236
	{
		// Token: 0x06001CA2 RID: 7330 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<IPlayer, BotSettingsClass> player)
		{
			throw null;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_1(KeyValuePair<IPlayer, BotSettingsClass> player)
		{
			throw null;
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_2(EnemyInfo info)
		{
			throw null;
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(PlaceForCheck placeForCheck)
		{
			throw null;
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_4(KeyValuePair<IPlayer, BotSettingsClass> x)
		{
			throw null;
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal BotSettingsClass method_5(KeyValuePair<IPlayer, BotSettingsClass> x)
		{
			throw null;
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_6(BotOwner x)
		{
			throw null;
		}

		// Token: 0x04001837 RID: 6199
		public static readonly BotsGroup.Class236 class236_0;

		// Token: 0x04001838 RID: 6200
		public static Func<KeyValuePair<IPlayer, BotSettingsClass>, bool> func_0;

		// Token: 0x04001839 RID: 6201
		public static Func<KeyValuePair<IPlayer, BotSettingsClass>, float> func_1;

		// Token: 0x0400183A RID: 6202
		public static Func<EnemyInfo, float> func_2;

		// Token: 0x0400183B RID: 6203
		public static Predicate<PlaceForCheck> predicate_0;

		// Token: 0x0400183C RID: 6204
		public static Func<KeyValuePair<IPlayer, BotSettingsClass>, bool> func_3;

		// Token: 0x0400183D RID: 6205
		public static Func<KeyValuePair<IPlayer, BotSettingsClass>, BotSettingsClass> func_4;

		// Token: 0x0400183E RID: 6206
		public static Func<BotOwner, float> func_5;
	}

	// Token: 0x02000498 RID: 1176
	[CompilerGenerated]
	private sealed class Class237
	{
		// Token: 0x06001CA9 RID: 7337 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400183F RID: 6207
		public BotsGroup botsGroup_0;

		// Token: 0x04001840 RID: 6208
		public GClass495 place;
	}

	// Token: 0x02000499 RID: 1177
	[CompilerGenerated]
	private sealed class Class238
	{
		// Token: 0x06001CAA RID: 7338 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(PlaceForCheck check)
		{
			throw null;
		}

		// Token: 0x04001841 RID: 6209
		public PlaceForCheck place;
	}
}
