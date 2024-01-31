using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Game.Spawning;
using UnityEngine;

// Token: 0x02000649 RID: 1609
public sealed class SpawnMarker : MonoBehaviour
{
	// Token: 0x060024E5 RID: 9445 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SpawnMarker Create(SpawnPointMarker spawnPointMarker, ESpawnCategory category, EPlayerSide side, string groupId, string infiltration, string botZoneName)
	{
		throw null;
	}

	// Token: 0x060024E6 RID: 9446 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SpawnMarker Create(ISpawnPoint spawnPoint, ESpawnCategory category, EPlayerSide side, string groupId, string infiltration, string botZoneName)
	{
		throw null;
	}

	// Token: 0x060024E7 RID: 9447 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x040023D4 RID: 9172
	public ESpawnCategory Category;

	// Token: 0x040023D5 RID: 9173
	public EPlayerSide Side;

	// Token: 0x040023D6 RID: 9174
	public string GroupId;

	// Token: 0x040023D7 RID: 9175
	public string Infiltration;

	// Token: 0x040023D8 RID: 9176
	public string BotZoneName;

	// Token: 0x040023D9 RID: 9177
	public SpawnPointMarker SpawnPointMarker;
}
