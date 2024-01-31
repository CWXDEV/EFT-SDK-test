using System;

namespace EFT.ObstacleCollision
{
	// Token: 0x02001EE6 RID: 7910
	public interface IObstacleCollisionFacade
	{
		// Token: 0x0600A36D RID: 41837
		bool CanMove();

		// Token: 0x0600A36E RID: 41838
		void RecalculateCollision(float velocityThreshold);

		// Token: 0x0600A36F RID: 41839
		void Tick();

		// Token: 0x0600A370 RID: 41840
		void Reset();

		// Token: 0x0600A371 RID: 41841
		void Dispose();
	}
}
