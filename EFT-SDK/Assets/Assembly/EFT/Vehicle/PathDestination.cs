using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.Vehicle
{
	// Token: 0x02002678 RID: 9848
	[Serializable]
	public class PathDestination : PathPartBase
	{
		// Token: 0x0600C36F RID: 50031 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ConnectPathSplines()
		{
			throw null;
		}

		// Token: 0x0600C370 RID: 50032 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FindPaths()
		{
			throw null;
		}

		// Token: 0x0600C371 RID: 50033 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisconnectPathSplines()
		{
			throw null;
		}

		// Token: 0x0400C53A RID: 50490
		public List<PathSpline> connectedPaths;

		// Token: 0x0400C53B RID: 50491
		public PathReverseData frontReverseData;

		// Token: 0x0400C53C RID: 50492
		public PathReverseData backReverseData;

		// Token: 0x0400C53D RID: 50493
		public bool useReverse;

		// Token: 0x0400C53E RID: 50494
		public PathDestination.GDelegate69 SelectedPathDestinationEvent;

		// Token: 0x0400C53F RID: 50495
		public PathDestination.GDelegate70 DeselectedPathDestinationEvent;

		// Token: 0x02002679 RID: 9849
		// (Invoke) Token: 0x0600C372 RID: 50034
		public delegate void GDelegate69(PathDestination part);

		// Token: 0x0200267A RID: 9850
		// (Invoke) Token: 0x0600C375 RID: 50037
		public delegate void GDelegate70(PathDestination part);
	}
}
