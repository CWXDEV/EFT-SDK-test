using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E1F RID: 3615
	[PreferBinarySerialization]
	[Serializable]
	public sealed class CullingGroupData : IBinarySerializable
	{
		// Token: 0x06004B75 RID: 19317 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Read(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x0400567D RID: 22141
		public ushort[] Indices;

		// Token: 0x0400567E RID: 22142
		public ushort RuntimeCullingGroupIdx;

		// Token: 0x0400567F RID: 22143
		public HashSet<ushort> BuildTimeIndices;
	}
}
