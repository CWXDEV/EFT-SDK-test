using System;
using System.Runtime.CompilerServices;
using EFT.HandBook;
using EFT.Hideout;
using EFT.UI.Chat;
using EFT.UI.Settings;
using EFT.UI.WeaponModding;

namespace EFT.UI
{
	// Token: 0x020028DE RID: 10462
	public sealed class CommonUI : MonoBehaviourSingleton<CommonUI>
	{
		// Token: 0x0600D0DE RID: 53470 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D0DF RID: 53471 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400D1B9 RID: 53689
		public MenuScreen MenuScreen;

		// Token: 0x0400D1BA RID: 53690
		public ReconnectionScreen ReconnectionScreen;

		// Token: 0x0400D1BB RID: 53691
		public TransferItemsScreen TransferItemsScreen;

		// Token: 0x0400D1BC RID: 53692
		public InventoryScreen InventoryScreen;

		// Token: 0x0400D1BD RID: 53693
		public ScavengerInventoryScreen ScavengerInventoryScreen;

		// Token: 0x0400D1BE RID: 53694
		public WeaponModdingScreen WeaponModdingScreen;

		// Token: 0x0400D1BF RID: 53695
		public EditBuildScreen EditBuildScreen;

		// Token: 0x0400D1C0 RID: 53696
		public SettingsScreen SettingsScreen;

		// Token: 0x0400D1C1 RID: 53697
		public HandbookScreen HandbookScreen;

		// Token: 0x0400D1C2 RID: 53698
		public ChatScreen ChatScreen;

		// Token: 0x0400D1C3 RID: 53699
		public HideoutScreenRear HideoutScreenRear;

		// Token: 0x0400D1C4 RID: 53700
		public HideoutScreenOverlay HideoutScreenOverlay;

		// Token: 0x0400D1C5 RID: 53701
		public TraderDialogScreen TraderDialogScreen;

		// Token: 0x0400D1C6 RID: 53702
		public TransferItemsInRaidScreen TransferItemsInRaidScreen;
	}
}
