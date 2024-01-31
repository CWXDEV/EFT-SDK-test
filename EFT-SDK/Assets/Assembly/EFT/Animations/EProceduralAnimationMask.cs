using System;

namespace EFT.Animations
{
	// Token: 0x02001EFE RID: 7934
	[Flags]
	public enum EProceduralAnimationMask
	{
		// Token: 0x0400AB68 RID: 43880
		Breathing = 1,
		// Token: 0x0400AB69 RID: 43881
		Walking = 2,
		// Token: 0x0400AB6A RID: 43882
		MotionReaction = 4,
		// Token: 0x0400AB6B RID: 43883
		ForceReaction = 8,
		// Token: 0x0400AB6C RID: 43884
		Shooting = 16,
		// Token: 0x0400AB6D RID: 43885
		DrawDown = 32,
		// Token: 0x0400AB6E RID: 43886
		Aiming = 64,
		// Token: 0x0400AB6F RID: 43887
		HandShake = 128
	}
}
