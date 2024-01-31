using System;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002BE2 RID: 11234
	public class ServicesScreen : UIElement
	{
		// Token: 0x0600DD75 RID: 56693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(TraderClass trader, Profile profile, InventoryControllerClass inventoryController, IHealthController healthController, GClass3359 quests, ItemUiContext context, ISession session)
		{
			throw null;
		}

		// Token: 0x0600DD76 RID: 56694 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckAvailableServices(TraderClass trader)
		{
			throw null;
		}

		// Token: 0x0600DD77 RID: 56695 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400E1FC RID: 57852
		[SerializeField]
		private ServicesListView _servicesListView;
	}
}
