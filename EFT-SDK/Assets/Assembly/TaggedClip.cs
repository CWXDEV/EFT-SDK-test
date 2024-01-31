using System;
using UnityEngine;

// Token: 0x02000770 RID: 1904
[Serializable]
public class TaggedClip
{
	// Token: 0x04002B5F RID: 11103
	public AudioClip Clip;

	// Token: 0x04002B60 RID: 11104
	public int Mask;

	// Token: 0x04002B61 RID: 11105
	public float Volume;

	// Token: 0x04002B62 RID: 11106
	public int Falloff;

	// Token: 0x04002B63 RID: 11107
	public int NetId;

	// Token: 0x04002B64 RID: 11108
	public float Length;

	// Token: 0x04002B65 RID: 11109
	[NonSerialized]
	public bool Exclude;
}
