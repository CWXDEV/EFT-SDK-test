using System;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BFA RID: 7162
	[Serializable]
	public class QuickTimeEvent
	{
		// Token: 0x04009D2E RID: 40238
		public EQteType Type;

		// Token: 0x04009D2F RID: 40239
		public Vector2 Position;

		// Token: 0x04009D30 RID: 40240
		public float StartDelay;

		// Token: 0x04009D31 RID: 40241
		public float EndDelay;

		// Token: 0x04009D32 RID: 40242
		public float Speed;

		// Token: 0x04009D33 RID: 40243
		public Vector2 SuccessRange;

		// Token: 0x04009D34 RID: 40244
		public KeyCode Key;
	}
}
