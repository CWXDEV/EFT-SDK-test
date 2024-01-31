using System;
using EFT;
using EFT.Game.Spawning;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02002695 RID: 9877
public interface ISpawnSystem
{
	// Token: 0x170022EE RID: 8942
	// (get) Token: 0x0600C3D2 RID: 50130
	LoggerClass Logger { get; }

	// Token: 0x0600C3D3 RID: 50131
	[NotNull]
	ISpawnPoint SelectSpawnPoint(ESpawnCategory category, EPlayerSide side, [CanBeNull] string groupId = null, [CanBeNull] string teamId = null, [CanBeNull] IPlayer person = null, [CanBeNull] string infiltration = null);

	// Token: 0x0600C3D4 RID: 50132
	[NotNull]
	ISpawnPoint SelectPlayerSavageSpawn(ESpawnCategory category, [CanBeNull] string groupId = null, [CanBeNull] string teamId = null, [CanBeNull] IPlayer person = null, [CanBeNull] string zoneName = null);

	// Token: 0x0600C3D5 RID: 50133
	[NotNull]
	ISpawnPoint[] SelectAISpawnPoints(ESpawnCategory category, [NotNull] GClass588 profileData, [NotNull] BotZone zone, int maxCount, [CanBeNull] Vector3? closetBossPos = null, ActionIfNotEnoughPoints mode = ActionIfNotEnoughPoints.ReturnNothing);

	// Token: 0x0600C3D6 RID: 50134
	bool ValidateSpawnPosition(ref Vector3 position, [NotNull] BotZone zone, [NotNull] IPlayer person, [NotNull] GClass588 data);

	// Token: 0x0600C3D7 RID: 50135
	bool CheckFarthestFromOtherPlayers([NotNull] IPlayer player);

	// Token: 0x0600C3D8 RID: 50136
	void Dispose();

	// Token: 0x0600C3D9 RID: 50137
	void Validate();
}
