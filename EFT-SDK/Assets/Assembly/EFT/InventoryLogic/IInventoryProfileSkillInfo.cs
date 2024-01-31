using System;

namespace EFT.InventoryLogic
{
	// Token: 0x0200244C RID: 9292
	public interface IInventoryProfileSkillInfo
	{
		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x0600BAA4 RID: 47780
		bool IsSearchDouble { get; }

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x0600BAA5 RID: 47781
		float AttentionExamineValue { get; }

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x0600BAA6 RID: 47782
		float AttentionEliteLuckySearchValue { get; }

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x0600BAA7 RID: 47783
		float AttentionLootSpeedValue { get; }

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x0600BAA8 RID: 47784
		float SearchBuffSpeedValue { get; }

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x0600BAA9 RID: 47785
		bool IsTroubleFixingExamineMalfElite { get; }

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x0600BAAA RID: 47786
		bool IsMagDrillsInstantCheck { get; }

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x0600BAAB RID: 47787
		int MagDrillsLevel { get; }
	}
}
