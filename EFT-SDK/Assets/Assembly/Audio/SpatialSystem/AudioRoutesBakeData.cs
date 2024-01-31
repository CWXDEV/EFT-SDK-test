using System;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D2A RID: 3370
	[Serializable]
	public sealed class AudioRoutesBakeData : ScriptableObject
	{
		// Token: 0x0400529F RID: 21151
		public AudioRoutesBakeData.RoomPairItem[] RoomPairsItems;

		// Token: 0x040052A0 RID: 21152
		public AudioRoutesBakeData.RoutesAwareRoomItem[] RoutesAwareRoomItems;

		// Token: 0x040052A1 RID: 21153
		public uint MaxPropagationDepth;

		// Token: 0x040052A2 RID: 21154
		public float MaxDistanceDetails;

		// Token: 0x02000D2B RID: 3371
		[Serializable]
		public struct RoomPairItem
		{
			// Token: 0x040052A3 RID: 21155
			public uint Key;

			// Token: 0x040052A4 RID: 21156
			public RoomPair Value;
		}

		// Token: 0x02000D2C RID: 3372
		[Serializable]
		public struct RoutesAwareRoomItem
		{
			// Token: 0x040052A5 RID: 21157
			public int Key;

			// Token: 0x040052A6 RID: 21158
			public uint[] Value;
		}
	}
}
