using System;

namespace EFT.Game.Spawning
{
	// Token: 0x020026A6 RID: 9894
	public struct SpawnPointParams
	{
		// Token: 0x0400C5E4 RID: 50660
		public string Id;

		// Token: 0x0400C5E5 RID: 50661
		public ClassVector3 Position;

		// Token: 0x0400C5E6 RID: 50662
		public float Rotation;

		// Token: 0x0400C5E7 RID: 50663
		public EPlayerSideMask Sides;

		// Token: 0x0400C5E8 RID: 50664
		public ESpawnCategoryMask Categories;

		// Token: 0x0400C5E9 RID: 50665
		public string Infiltration;

		// Token: 0x0400C5EA RID: 50666
		public string BotZoneName;

		// Token: 0x0400C5EB RID: 50667
		public float DelayToCanSpawnSec;

		// Token: 0x0400C5EC RID: 50668
		public ISpawnColliderParams ColliderParams;

		// Token: 0x0400C5ED RID: 50669
		public int CorePointId;
	}
}
