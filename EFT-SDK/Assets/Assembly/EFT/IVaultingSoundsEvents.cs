using System;
using AnimationEventSystem;

namespace EFT
{
	// Token: 0x02001596 RID: 5526
	public interface IVaultingSoundsEvents
	{
		// Token: 0x1400014B RID: 331
		// (add) Token: 0x060076A3 RID: 30371
		// (remove) Token: 0x060076A4 RID: 30372
		event Action<IAnimatorEventParameter> OnStartEvent;

		// Token: 0x1400014C RID: 332
		// (add) Token: 0x060076A5 RID: 30373
		// (remove) Token: 0x060076A6 RID: 30374
		event Action<IAnimatorEventParameter> OnEndEvent;

		// Token: 0x1400014D RID: 333
		// (add) Token: 0x060076A7 RID: 30375
		// (remove) Token: 0x060076A8 RID: 30376
		event Action<IAnimatorEventParameter> OnGrabEvent;

		// Token: 0x1400014E RID: 334
		// (add) Token: 0x060076A9 RID: 30377
		// (remove) Token: 0x060076AA RID: 30378
		event Action<IAnimatorEventParameter> OnSlideEvent;
	}
}
