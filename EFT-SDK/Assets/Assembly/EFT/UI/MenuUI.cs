using System;
using System.Runtime.CompilerServices;
using EFT.UI.Matchmaker;
using UI.Hideout;

namespace EFT.UI
{
	// Token: 0x02002A83 RID: 10883
	public sealed class MenuUI : MonoBehaviourSingleton<MenuUI>
	{
		// Token: 0x0600D840 RID: 55360 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D841 RID: 55361 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400DAF7 RID: 56055
		public TraderScreensGroup TraderScreensGroup;

		// Token: 0x0400DAF8 RID: 56056
		public TradingScreen TradingScreen;

		// Token: 0x0400DAF9 RID: 56057
		public MatchMakerSideSelectionScreen MatchMakerSideSelectionScreen;

		// Token: 0x0400DAFA RID: 56058
		public MatchMakerSelectionLocationScreen MatchMakerSelectionLocationScreen;

		// Token: 0x0400DAFB RID: 56059
		public MatchmakerKeyAccessScreen MatchmakerKeyAccessScreen;

		// Token: 0x0400DAFC RID: 56060
		public MatchmakerMapPointsScreen MatchmakerMapPoints;

		// Token: 0x0400DAFD RID: 56061
		public MatchMakerAcceptScreen MatchMakerAcceptScreen;

		// Token: 0x0400DAFE RID: 56062
		public MatchmakerInsuranceScreen MatchmakerInsuranceScreen;

		// Token: 0x0400DAFF RID: 56063
		public MatchmakerTimeHasCome MatchmakerTimeHasCome;

		// Token: 0x0400DB00 RID: 56064
		public MatchmakerOfflineRaidScreen MatchmakerOfflineRaidScreen;

		// Token: 0x0400DB01 RID: 56065
		public MatchmakerFinalCountdown MatchmakerFinalCountdown;

		// Token: 0x0400DB02 RID: 56066
		public OperationQueueIndicator OperationQueueIndicator;

		// Token: 0x0400DB03 RID: 56067
		public HideoutAreaTransferItemsScreen HideoutAreaTransferItemsScreen;

		// Token: 0x0400DB04 RID: 56068
		public EquipmentBuildsScreen EquipmentBuildsScreen;

		// Token: 0x0400DB05 RID: 56069
		public OtherPlayerProfileScreen OtherPlayerProfileScreen;
	}
}
