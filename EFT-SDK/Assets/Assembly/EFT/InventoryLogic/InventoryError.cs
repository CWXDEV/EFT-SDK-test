using System;
using System.Runtime.CompilerServices;
using Comfort.Common;

namespace EFT.InventoryLogic
{
	// Token: 0x020022E3 RID: 8931
	public abstract class InventoryError : GClass3283
	{
		// Token: 0x0600B533 RID: 46387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0600B534 RID: 46388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IResult ToResult()
		{
			throw null;
		}

		// Token: 0x0400B8DC RID: 47324
		public const string PLAYER_IS_BUSY_ERROR = "Inventory/PlayerIsBusy";
	}
}
