using System;
using EFT;

// Token: 0x02000D2F RID: 3375
public sealed class GEventArgs0 : EventArgs
{
	// Token: 0x040052BB RID: 21179
	public GEventArgs0.ETriggerEventType TriggerEventType;

	// Token: 0x040052BC RID: 21180
	public IPlayer Player;

	// Token: 0x02000D30 RID: 3376
	public enum ETriggerEventType
	{
		// Token: 0x040052BE RID: 21182
		TriggerEnter,
		// Token: 0x040052BF RID: 21183
		TriggerExit
	}
}
