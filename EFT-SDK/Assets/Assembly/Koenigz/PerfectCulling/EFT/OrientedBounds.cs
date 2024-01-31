using System;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E24 RID: 3620
	[Serializable]
	public struct OrientedBounds : IBinarySerializable
	{
		// Token: 0x06004B90 RID: 19344 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 ClosestPointOriented(Vector3 p, out bool isPointInside)
		{
			throw null;
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06004B91 RID: 19345 RVA: 0x00002050 File Offset: 0x00000250
		public Bounds AABB
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(Vector3 worldPosition)
		{
			throw null;
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Read(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float SqrDistance(Vector3 point)
		{
			throw null;
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float Distance(Vector3 point)
		{
			throw null;
		}

		// Token: 0x04005696 RID: 22166
		public Bounds bounds;

		// Token: 0x04005697 RID: 22167
		public Quaternion rotation;
	}
}
