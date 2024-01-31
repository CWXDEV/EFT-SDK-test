using System;
using UnityEngine;

namespace EFT.Game.Spawning
{
	// Token: 0x02002692 RID: 9874
	public interface ISpawnPointCollider
	{
		// Token: 0x0600C3CD RID: 50125
		bool Contains(Vector3 point);

		// Token: 0x0600C3CE RID: 50126
		string DebugInfo();
	}
}
