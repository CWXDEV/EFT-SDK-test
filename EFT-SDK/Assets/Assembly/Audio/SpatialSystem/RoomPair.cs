using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D43 RID: 3395
	[Serializable]
	public class RoomPair : IEquatable<RoomPair>
	{
		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x00002050 File Offset: 0x00000250
		public int FirstRoomID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06004835 RID: 18485 RVA: 0x00002050 File Offset: 0x00000250
		public int SecondRoomID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsMatch(SpatialAudioRoom firstRoom, SpatialAudioRoom secondRoom)
		{
			throw null;
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(RoomPair other)
		{
			throw null;
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x040052FF RID: 21247
		[SerializeField]
		private int _firstRoomID;

		// Token: 0x04005300 RID: 21248
		[SerializeField]
		private int SecondRoom;

		// Token: 0x04005301 RID: 21249
		public RoomPair.Route[] RoutesIdGroups;

		// Token: 0x02000D44 RID: 3396
		[Serializable]
		public struct Route
		{
			// Token: 0x04005302 RID: 21250
			public int[] IDs;

			// Token: 0x04005303 RID: 21251
			public float EstimatedTotalCost;

			// Token: 0x04005304 RID: 21252
			public float TraverseDistance;
		}
	}
}
