using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E1E RID: 3614
	[Serializable]
	public sealed class CullingCellData : IBinarySerializable, ISpatialItem
	{
		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06004B71 RID: 19313 RVA: 0x00002050 File Offset: 0x00000250
		public Bounds SpatialItemBounds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 ClosestPointOriented(Vector3 p, out bool isPointInside)
		{
			throw null;
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Read(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x04005677 RID: 22135
		public OrientedBounds CellBounds;

		// Token: 0x04005678 RID: 22136
		public List<CullingGroupData> CullingData;

		// Token: 0x04005679 RID: 22137
		public List<Vector3> IndividualSampleProbes;

		// Token: 0x0400567A RID: 22138
		public bool UserModified;

		// Token: 0x0400567B RID: 22139
		public bool Ignored;

		// Token: 0x0400567C RID: 22140
		[NonSerialized]
		public int RuntimeCellId;
	}
}
