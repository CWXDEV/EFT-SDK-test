using System;

namespace EFT.Interactive
{
	// Token: 0x02002745 RID: 10053
	public interface IExfiltrationRequirement
	{
		// Token: 0x0600C929 RID: 51497
		bool Met(Player player, ExfiltrationPoint point);

		// Token: 0x0600C92A RID: 51498
		void Enter(Player player, ExfiltrationPoint point);

		// Token: 0x0600C92B RID: 51499
		void Exit(Player player, ExfiltrationPoint point);

		// Token: 0x0600C92C RID: 51500
		void Start(ExfiltrationPoint point);

		// Token: 0x0600C92D RID: 51501
		void OnDestroy();
	}
}
