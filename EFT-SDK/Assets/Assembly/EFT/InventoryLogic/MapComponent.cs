using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x02002295 RID: 8853
	public class MapComponent : GClass2750
	{
		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x0600B418 RID: 46104 RVA: 0x00002050 File Offset: 0x00000250
		public string ConfigPathStr
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x0600B419 RID: 46105 RVA: 0x00002050 File Offset: 0x00000250
		public int MaxMarkersCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x0600B41A RID: 46106 RVA: 0x00002050 File Offset: 0x00000250
		public float ScaleMin
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x0600B41B RID: 46107 RVA: 0x00002050 File Offset: 0x00000250
		public float ScaleMax
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B41C RID: 46108 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMarker GetMarker(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600B41D RID: 46109 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct413<GStruct377> CreateMarker(MapMarker marker, bool simulate)
		{
			throw null;
		}

		// Token: 0x0600B41E RID: 46110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct413<GClass2802> DeleteMarker(int x, int y, bool simulate)
		{
			throw null;
		}

		// Token: 0x0600B41F RID: 46111 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct413<GClass2801> EditMarker(MapMarker marker, int x, int y, bool simulate)
		{
			throw null;
		}

		// Token: 0x0400B83A RID: 47162
		public List<MapMarker> Markers;

		// Token: 0x0400B83B RID: 47163
		private readonly GInterface295 ginterface295_0;
	}
}
