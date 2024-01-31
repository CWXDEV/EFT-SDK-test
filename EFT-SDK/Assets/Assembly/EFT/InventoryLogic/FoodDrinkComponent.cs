using System;
using System.Runtime.CompilerServices;

namespace EFT.InventoryLogic
{
	// Token: 0x02002277 RID: 8823
	public sealed class FoodDrinkComponent : GClass2750, IItemComponent, IRelativeComponent
	{
		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x0600B3C9 RID: 46025 RVA: 0x00002050 File Offset: 0x00000250
		public float MaxResource
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x0600B3CA RID: 46026 RVA: 0x00002050 File Offset: 0x00000250
		public float RelativeValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400B805 RID: 47109
		public float HpPercent;

		// Token: 0x0400B806 RID: 47110
		private readonly GInterface287 ginterface287_0;
	}
}
