using System;
using System.Runtime.CompilerServices;
using EFT.UI;

namespace EFT
{
	// Token: 0x02001970 RID: 6512
	public abstract class ServiceView : UIElement
	{
		// Token: 0x06008BA8 RID: 35752
		public abstract bool CheckAvailable(TraderClass trader);

		// Token: 0x06008BA9 RID: 35753
		public abstract void Show(TraderClass trader, Profile profile, InventoryControllerClass controller, HealthControllerClass healthController, GClass3359 quests, ItemUiContext context, ISession session);

		// Token: 0x06008BAA RID: 35754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}
	}
}
