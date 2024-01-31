using System;
using UnityEngine;

// Token: 0x02000256 RID: 598
[Serializable]
public abstract class NavGraphVoxelBase
{
	// Token: 0x04000C0A RID: 3082
	public const float SIZE = 10f;

	// Token: 0x04000C0B RID: 3083
	public const float SIZE_Y = 5f;

	// Token: 0x04000C0C RID: 3084
	public Vector3 Position;

	// Token: 0x04000C0D RID: 3085
	public ushort IndexX;

	// Token: 0x04000C0E RID: 3086
	public ushort IndexZ;

	// Token: 0x04000C0F RID: 3087
	public ushort IndexY;

	// Token: 0x04000C10 RID: 3088
	public ushort Id;
}
