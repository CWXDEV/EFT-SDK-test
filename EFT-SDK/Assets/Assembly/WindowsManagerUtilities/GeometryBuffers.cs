using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace WindowsManagerUtilities
{
	// Token: 0x02000C1A RID: 3098
	[Serializable]
	internal class GeometryBuffers
	{
		// Token: 0x06004389 RID: 17289 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x04004CF3 RID: 19699
		public List<WindowVertex> _allVertices;

		// Token: 0x04004CF4 RID: 19700
		public List<int> _allTriangles;
	}
}
