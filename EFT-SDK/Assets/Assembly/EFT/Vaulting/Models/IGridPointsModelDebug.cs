using System;
using System.Collections.Generic;
using UnityEngine;

namespace EFT.Vaulting.Models
{
	// Token: 0x02001EBC RID: 7868
	public interface IGridPointsModelDebug : GInterface204
	{
		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x0600A298 RID: 41624
		Vector3 GridRootPosition { get; }

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x0600A299 RID: 41625
		List<Vector3> FrontFromPositions { get; }

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x0600A29A RID: 41626
		List<Vector3> TopFromPositions { get; }
	}
}
