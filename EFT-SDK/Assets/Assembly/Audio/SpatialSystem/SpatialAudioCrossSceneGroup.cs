using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D46 RID: 3398
	[RequireComponent(typeof(GuidComponent))]
	public sealed class SpatialAudioCrossSceneGroup : MonoBehaviour
	{
		// Token: 0x0600483A RID: 18490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDestroy()
		{
			throw null;
		}

		// Token: 0x04005314 RID: 21268
		public static readonly List<SpatialAudioCrossSceneGroup> AllCrossGroups;

		// Token: 0x04005315 RID: 21269
		[HideInInspector]
		public GuidReference crossSceneGroup;

		// Token: 0x04005316 RID: 21270
		public List<SpatialAudioRoom> AudioRooms;

		// Token: 0x04005317 RID: 21271
		public List<SpatialAudioPortal> AudioPortals;
	}
}
