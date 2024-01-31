using System;
using System.Runtime.CompilerServices;

namespace EFT.Quests
{
	// Token: 0x02003009 RID: 12297
	public sealed class ConditionWeaponAssembly : ConditionItem, GInterface380
	{
		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x0600F209 RID: 61961 RVA: 0x00002050 File Offset: 0x00000250
		public override string FormattedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400F82D RID: 63533
		public GClass3219 durability;

		// Token: 0x0400F82E RID: 63534
		public GClass3219 ergonomics;

		// Token: 0x0400F82F RID: 63535
		public GClass3219 baseAccuracy;

		// Token: 0x0400F830 RID: 63536
		public GClass3219 recoil;

		// Token: 0x0400F831 RID: 63537
		public GClass3219 muzzleVelocity;

		// Token: 0x0400F832 RID: 63538
		public GClass3219 height;

		// Token: 0x0400F833 RID: 63539
		public GClass3219 magazineCapacity;

		// Token: 0x0400F834 RID: 63540
		public GClass3219 width;

		// Token: 0x0400F835 RID: 63541
		public GClass3219 weight;

		// Token: 0x0400F836 RID: 63542
		public GClass3219 effectiveDistance;

		// Token: 0x0400F837 RID: 63543
		public GClass3219 emptyTacticalSlot;

		// Token: 0x0400F838 RID: 63544
		public string[] hasItemFromCategory;

		// Token: 0x0400F839 RID: 63545
		public string[] containsItems;
	}
}
