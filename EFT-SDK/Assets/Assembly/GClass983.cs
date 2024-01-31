using System;
using System.Collections.Generic;
using Audio.SpatialSystem;

// Token: 0x02000D4F RID: 3407
public sealed class GClass983
{
	// Token: 0x04005348 RID: 21320
	public readonly HashSet<SpatialAudioRoom> VisitedRooms;

	// Token: 0x04005349 RID: 21321
	public readonly List<SpatialAudioPortal> RoutePortals;

	// Token: 0x0400534A RID: 21322
	public SpatialAudioRoom NewestFoundRoom;
}
