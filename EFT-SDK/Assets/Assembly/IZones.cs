using System;
using System.Collections.Generic;
using EFT.Game.Spawning;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x0200268E RID: 9870
public interface IZones
{
	// Token: 0x0600C3B7 RID: 50103
	[NotNull]
	IEnumerable<string> ZoneNames(bool canBeSnipe = false);

	// Token: 0x0600C3B8 RID: 50104
	[NotNull]
	ISpawnPoint[] ZoneSpawnPoints(string zoneName);

	// Token: 0x0600C3B9 RID: 50105
	[NotNull]
	ISpawnPoint[] AllZonesSpawnPoints(bool canBeSnipe = false);

	// Token: 0x0600C3BA RID: 50106
	[CanBeNull]
	Vector3? GetBossPosition(BotZone zone, Vector3? closestBossPos = null);
}
