using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E1A RID: 3610
	[PreferBinarySerialization]
	public sealed class StreamingVolumeBakeDataIndex : ScriptableObject
	{
		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06004B6B RID: 19307 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsValid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06004B6C RID: 19308 RVA: 0x00002050 File Offset: 0x00000250
		public int IndexSizeBytes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetStreamingDataFilePath(PerfectCullingCrossSceneVolume vol, PerfectCullingCrossSceneVolume.BakeDescriptor desc, bool isIndexFile = false)
		{
			throw null;
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static StreamingVolumeBakeDataIndex Convert(PerfectCullingCrossSceneVolume vol, PerfectCullingCrossSceneVolume.BakeDescriptor desc, PerfectCullingVolumeBakeData data)
		{
			throw null;
		}

		// Token: 0x04005669 RID: 22121
		public string volumeGuid;

		// Token: 0x0400566A RID: 22122
		public string groupGuid;

		// Token: 0x0400566B RID: 22123
		public Vector3 cellCount;

		// Token: 0x0400566C RID: 22124
		public Vector3 cellSize;

		// Token: 0x0400566D RID: 22125
		public Vector3 originalCellSize;

		// Token: 0x0400566E RID: 22126
		public Quaternion orientation;

		// Token: 0x0400566F RID: 22127
		public bool bakeCompleted;

		// Token: 0x04005670 RID: 22128
		public int bakeHash;

		// Token: 0x04005671 RID: 22129
		public int bakeDataVersion;

		// Token: 0x04005672 RID: 22130
		public VisibilitySetIndex[] indices;

		// Token: 0x04005673 RID: 22131
		public const string StreamingIndexFilePostfix = "_index";

		// Token: 0x04005674 RID: 22132
		public const string StreamingRawDataFilePostfix = "_cull";

		// Token: 0x04005675 RID: 22133
		public const string PlayerBuildCullingDataFolder = "Culling_Data";
	}
}
