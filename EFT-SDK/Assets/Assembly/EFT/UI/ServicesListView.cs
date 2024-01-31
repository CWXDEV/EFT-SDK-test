using System;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002BAA RID: 11178
	public class ServicesListView : UIElement
	{
		// Token: 0x0600DC82 RID: 56450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(TraderClass trader, Profile profile, InventoryControllerClass inventoryController, IHealthController healthController, GClass3359 quests, ItemUiContext context, ISession session)
		{
			throw null;
		}

		// Token: 0x0600DC83 RID: 56451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckAvailableServices(TraderClass trader)
		{
			throw null;
		}

		// Token: 0x0600DC84 RID: 56452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(ServiceListItem serviceItem)
		{
			throw null;
		}

		// Token: 0x0600DC85 RID: 56453 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400E0C1 RID: 57537
		[SerializeField]
		private RectTransform _serviceListContainer;

		// Token: 0x0400E0C2 RID: 57538
		[SerializeField]
		private ServiceListItem _serviceItemTemplate;

		// Token: 0x0400E0C3 RID: 57539
		[SerializeField]
		private ServicesListView.ServiceInfo[] _possibleServices;

		// Token: 0x0400E0C4 RID: 57540
		private ServiceListItem serviceListItem_0;

		// Token: 0x0400E0C5 RID: 57541
		private TraderClass gclass2046_0;

		// Token: 0x0400E0C6 RID: 57542
		private Profile profile_0;

		// Token: 0x0400E0C7 RID: 57543
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400E0C8 RID: 57544
		private IHealthController ihealthController_0;

		// Token: 0x0400E0C9 RID: 57545
		private GClass3359 gclass3359_0;

		// Token: 0x0400E0CA RID: 57546
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400E0CB RID: 57547
		private ISession ginterface145_0;

		// Token: 0x02002BAB RID: 11179
		[Serializable]
		public class ServiceInfo
		{
			// Token: 0x0400E0CC RID: 57548
			public string Name;

			// Token: 0x0400E0CD RID: 57549
			public Sprite IconBackground;

			// Token: 0x0400E0CE RID: 57550
			public Sprite Icon;

			// Token: 0x0400E0CF RID: 57551
			public ServiceView ServiceView;
		}

		// Token: 0x02002BAC RID: 11180
		[CompilerGenerated]
		private sealed class Class2650
		{
			// Token: 0x0600DC86 RID: 56454 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ServicesListView.ServiceInfo info)
			{
				throw null;
			}

			// Token: 0x0600DC87 RID: 56455 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(ServicesListView.ServiceInfo service, ServiceListItem serviceView)
			{
				throw null;
			}

			// Token: 0x0400E0D0 RID: 57552
			public TraderClass trader;

			// Token: 0x0400E0D1 RID: 57553
			public ServicesListView servicesListView_0;
		}

		// Token: 0x02002BAD RID: 11181
		[CompilerGenerated]
		private sealed class Class2651
		{
			// Token: 0x0600DC88 RID: 56456 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ServicesListView.ServiceInfo info)
			{
				throw null;
			}

			// Token: 0x0400E0D2 RID: 57554
			public TraderClass trader;
		}
	}
}
