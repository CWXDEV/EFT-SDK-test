using System;
using System.Collections;
using System.Collections.Generic;
using EFT.Game.Spawning;

// Token: 0x02002693 RID: 9875
public interface ISpawnPoints : IEnumerable, IEnumerable<ISpawnPoint>, IReadOnlyCollection<ISpawnPoint>
{
	// Token: 0x0600C3CF RID: 50127
	ISpawnPoint CreateSpawnPoint(SpawnPointParams @params);

	// Token: 0x0600C3D0 RID: 50128
	void DestroySpawnPoint(ISpawnPoint spawnPoint);

	// Token: 0x0600C3D1 RID: 50129
	void Validate();
}
