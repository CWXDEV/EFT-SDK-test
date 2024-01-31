using System;
using UnityEngine;

namespace EFT.Game.Spawning
{
	// Token: 0x02002690 RID: 9872
	public interface ISpawnPoint : IPositionPoint
	{
		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x0600C3BD RID: 50109
		string Id { get; }

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x0600C3BE RID: 50110
		string Name { get; }

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x0600C3BF RID: 50111
		Vector3 Position { get; }

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x0600C3C0 RID: 50112
		Quaternion Rotation { get; }

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x0600C3C1 RID: 50113
		EPlayerSideMask Sides { get; }

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x0600C3C2 RID: 50114
		ESpawnCategoryMask Categories { get; }

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x0600C3C3 RID: 50115
		string Infiltration { get; }

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x0600C3C4 RID: 50116
		string BotZoneName { get; }

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x0600C3C5 RID: 50117
		bool IsSnipeZone { get; }

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x0600C3C6 RID: 50118
		float DelayToCanSpawnSec { get; }

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x0600C3C7 RID: 50119
		// (set) Token: 0x0600C3C8 RID: 50120
		float NextBornTime { get; set; }

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x0600C3C9 RID: 50121
		// (set) Token: 0x0600C3CA RID: 50122
		int CorePointId { get; set; }

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x0600C3CB RID: 50123
		ISpawnPointCollider Collider { get; }

		// Token: 0x0600C3CC RID: 50124
		void Dispose();
	}
}
