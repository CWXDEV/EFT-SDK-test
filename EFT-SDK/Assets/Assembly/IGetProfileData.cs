using System;
using System.Collections.Generic;
using EFT;
using JetBrains.Annotations;

// Token: 0x02000624 RID: 1572
public interface IGetProfileData
{
	// Token: 0x060023EF RID: 9199
	bool TryGetRole(out WildSpawnType role, out BotDifficulty difficulty);

	// Token: 0x060023F0 RID: 9200
	[CanBeNull]
	Profile ChooseProfile(List<Profile> profiles2Select, bool withDelete);

	// Token: 0x060023F1 RID: 9201
	WaveInfo[] PrepareToLoadBackend(int count);

	// Token: 0x060023F2 RID: 9202
	bool IsValidSpawnType(WildSpawnType wildSpawnType);

	// Token: 0x17000694 RID: 1684
	// (get) Token: 0x060023F3 RID: 9203
	EPlayerSide? Side { get; }

	// Token: 0x060023F4 RID: 9204
	string GetDebugLocalName();

	// Token: 0x17000695 RID: 1685
	// (get) Token: 0x060023F5 RID: 9205
	// (set) Token: 0x060023F6 RID: 9206
	BotSpawnParams SpawnParams { get; set; }

	// Token: 0x060023F7 RID: 9207
	string GetDebugData();

	// Token: 0x060023F8 RID: 9208
	bool ShallChooseByData();

	// Token: 0x060023F9 RID: 9209
	bool IsBossOrFollowerByTime();

	// Token: 0x060023FA RID: 9210
	bool IsZeroWave();

	// Token: 0x060023FB RID: 9211
	bool IsBossOrFollower();

	// Token: 0x060023FC RID: 9212
	bool IsSpawnOnStart();

	// Token: 0x060023FD RID: 9213
	bool CanAtZoneByType(BotZone botZone, ZoneLeaveControllerClass botsControllerZonesLeaveController);
}
