using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Game.Spawning;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000481 RID: 1153
public class BotZone : MonoBehaviour
{
	// Token: 0x170004E7 RID: 1255
	// (get) Token: 0x06001BCB RID: 7115 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001BCC RID: 7116 RVA: 0x00002050 File Offset: 0x00000250
	public int MaxPersonsOnPatrol
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

	// Token: 0x170004E8 RID: 1256
	// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00002050 File Offset: 0x00000250
	public ISpawnPoint[] SpawnPoints
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004E9 RID: 1257
	// (get) Token: 0x06001BCE RID: 7118 RVA: 0x00002050 File Offset: 0x00000250
	public string NameZone
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004EA RID: 1258
	// (get) Token: 0x06001BCF RID: 7119 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x00002050 File Offset: 0x00000250
	public BotZoneDangerAreas ZoneDangerAreas
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

	// Token: 0x170004EB RID: 1259
	// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x00002050 File Offset: 0x00000250
	public string ShortName
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

	// Token: 0x06001BD3 RID: 7123 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06001BD4 RID: 7124 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BotLocationModifier modifier, BotsController botsController)
	{
		throw null;
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_0(Vector3 position)
	{
		throw null;
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06001BD7 RID: 7127 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GameObject obj)
	{
		throw null;
	}

	// Token: 0x06001BD8 RID: 7128 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValid()
	{
		throw null;
	}

	// Token: 0x06001BD9 RID: 7129 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06001BDA RID: 7130 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearPools()
	{
		throw null;
	}

	// Token: 0x040017A1 RID: 6049
	public float DistanceCoef;

	// Token: 0x040017A2 RID: 6050
	public int Id;

	// Token: 0x040017A3 RID: 6051
	[SerializeField]
	[FormerlySerializedAs("MaxPersonsOnPatrol")]
	private int _maxPersonsOnPatrol;

	// Token: 0x040017A4 RID: 6052
	public bool CanSpawnBoss;

	// Token: 0x040017A5 RID: 6053
	public bool SnipeZone;

	// Token: 0x040017A6 RID: 6054
	public PatrolWay[] PatrolWays;

	// Token: 0x040017A7 RID: 6055
	public List<SpawnPointMarker> SpawnPointMarkers;

	// Token: 0x040017A8 RID: 6056
	public UnspawnPoint[] UnSpawnPoints;

	// Token: 0x040017A9 RID: 6057
	private ISpawnPoint[] _spawnPoints;

	// Token: 0x040017AA RID: 6058
	public BotLocationModifier Modifier;

	// Token: 0x040017AB RID: 6059
	public BotZoneNavMeshCutter ZoneNavMeshCutters;

	// Token: 0x040017AE RID: 6062
	public List<BotPointOfInterest> PointsOfInterest;

	// Token: 0x040017AF RID: 6063
	[HideInInspector]
	public string CoverPointCreatorPresetName;

	// Token: 0x02000482 RID: 1154
	[CompilerGenerated]
	[Serializable]
	private sealed class Class231
	{
		// Token: 0x06001BDB RID: 7131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ISpawnPoint method_0(SpawnPointMarker marker)
		{
			throw null;
		}

		// Token: 0x040017B0 RID: 6064
		public static readonly BotZone.Class231 class231_0;

		// Token: 0x040017B1 RID: 6065
		public static Func<SpawnPointMarker, ISpawnPoint> func_0;
	}
}
