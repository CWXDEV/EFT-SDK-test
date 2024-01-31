using System;

namespace EFT.Vaulting
{
	// Token: 0x02001E5A RID: 7770
	public interface IBaseMoveSettings
	{
		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x06009F57 RID: 40791
		bool IsActive { get; }

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06009F58 RID: 40792
		float MaxWithoutHandHeight { get; }

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x06009F59 RID: 40793
		IMoveRestrictions MoveRestrictions { get; }

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x06009F5A RID: 40794
		IAutoMoveRestrictions AutoMoveRestrictions { get; }
	}
}
