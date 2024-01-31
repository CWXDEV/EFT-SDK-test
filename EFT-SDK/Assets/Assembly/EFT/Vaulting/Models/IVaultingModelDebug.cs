using System;

namespace EFT.Vaulting.Models
{
	// Token: 0x02001ECE RID: 7886
	public interface IVaultingModelDebug
	{
		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x0600A30D RID: 41741
		IGridPointsModelDebug GridPointsModelDebug { get; }

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x0600A30E RID: 41742
		IGridSettingsModelDebug GridSettingsModelDebug { get; }

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x0600A30F RID: 41743
		IVaultingRestrictionsModelDebug VaultingRestrictionsModelDebug { get; }

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x0600A310 RID: 41744
		IVaultingStateModelDebug VaultingStateModelDebug { get; }

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x0600A311 RID: 41745
		IGridRootMoverModelDebug GridRootModelDebug { get; }

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x0600A312 RID: 41746
		IObstacleCalculatorModelDebug ObstacleCalculatorModelDebug { get; }

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x0600A313 RID: 41747
		IAutomaticVaultingModelDebug AutomaticVaultingModelDebug { get; }

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x0600A314 RID: 41748
		ISurfaceApproximatorModelDebug SurfaceApproximatorModelDebug { get; }
	}
}
