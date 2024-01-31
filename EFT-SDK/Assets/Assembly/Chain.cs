using System;

// Token: 0x02000771 RID: 1905
[Serializable]
public class Chain
{
	// Token: 0x04002B66 RID: 11110
	public EPhraseTrigger Event;

	// Token: 0x04002B67 RID: 11111
	public int Probability;

	// Token: 0x04002B68 RID: 11112
	public Chain.ESpeaker Who;

	// Token: 0x02000772 RID: 1906
	public enum ESpeaker
	{
		// Token: 0x04002B6A RID: 11114
		Self,
		// Token: 0x04002B6B RID: 11115
		Group,
		// Token: 0x04002B6C RID: 11116
		Other
	}
}
