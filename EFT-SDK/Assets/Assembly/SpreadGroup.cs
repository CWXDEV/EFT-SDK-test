using System;
using CommonAssets.Scripts.Audio;

// Token: 0x0200076F RID: 1903
[Serializable]
public class SpreadGroup
{
	// Token: 0x04002B5B RID: 11099
	public ELoudnessType LoudnessType;

	// Token: 0x04002B5C RID: 11100
	public int Falloff;

	// Token: 0x04002B5D RID: 11101
	public float Volume;

	// Token: 0x04002B5E RID: 11102
	public TaggedClip[] Clips;
}
