using System;
using EFT.Animations;

// Token: 0x02000911 RID: 2321
[Serializable]
public class Val
{
	// Token: 0x04003520 RID: 13600
	public global::Val.Source From;

	// Token: 0x04003521 RID: 13601
	public Target To;

	// Token: 0x04003522 RID: 13602
	public ComponentType Component;

	// Token: 0x04003523 RID: 13603
	public float Intensity;

	// Token: 0x02000912 RID: 2322
	public enum Source
	{
		// Token: 0x04003525 RID: 13605
		MouseXVel,
		// Token: 0x04003526 RID: 13606
		MouseXAcc,
		// Token: 0x04003527 RID: 13607
		MouseYVel,
		// Token: 0x04003528 RID: 13608
		MouseYAcc,
		// Token: 0x04003529 RID: 13609
		MoveXVel,
		// Token: 0x0400352A RID: 13610
		MoveYVel,
		// Token: 0x0400352B RID: 13611
		MoveZVel,
		// Token: 0x0400352C RID: 13612
		MoveXAcc,
		// Token: 0x0400352D RID: 13613
		MoveYAcc,
		// Token: 0x0400352E RID: 13614
		MoveZAcc
	}
}
