using System;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.InventoryLogic;

namespace EFT.Interactive
{
	// Token: 0x02002731 RID: 10033
	public sealed class TransferItemRequirement : ExfiltrationRequirement
	{
		// Token: 0x0600C8F7 RID: 51447 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Met(Player player, ExfiltrationPoint point)
		{
			throw null;
		}

		// Token: 0x0600C8F8 RID: 51448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Start(ExfiltrationPoint point)
		{
			throw null;
		}

		// Token: 0x0600C8F9 RID: 51449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedTip(string profileId)
		{
			throw null;
		}

		// Token: 0x0600C8FA RID: 51450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TransferExitItem(Player player, Item item)
		{
			throw null;
		}

		// Token: 0x0600C8FB RID: 51451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400C91D RID: 51485
		private TraderControllerClass _itemController;

		// Token: 0x02002732 RID: 10034
		[CompilerGenerated]
		private sealed class Class2255
		{
			// Token: 0x0600C8FC RID: 51452 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GEventArgs2 addItemEventArgs)
			{
				throw null;
			}

			// Token: 0x0400C91E RID: 51486
			public TransferItemRequirement transferItemRequirement_0;

			// Token: 0x0400C91F RID: 51487
			public ExfiltrationPoint point;
		}

		// Token: 0x02002733 RID: 10035
		[CompilerGenerated]
		private sealed class Class2256
		{
			// Token: 0x0600C8FD RID: 51453 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(IPlayer x)
			{
				throw null;
			}

			// Token: 0x0400C920 RID: 51488
			public string profileId;
		}

		// Token: 0x02002734 RID: 10036
		[CompilerGenerated]
		private sealed class Class2257
		{
			// Token: 0x0600C8FE RID: 51454 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IResult error)
			{
				throw null;
			}

			// Token: 0x0600C8FF RID: 51455 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(IResult error)
			{
				throw null;
			}

			// Token: 0x0400C921 RID: 51489
			public Player player;
		}
	}
}
