using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Vehicle
{
	// Token: 0x02002676 RID: 9846
	[ExecuteInEditMode]
	[Serializable]
	public class MapPathConfig : MonoBehaviour
	{
		// Token: 0x0600C365 RID: 50021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeletePartSpline(PathSpline pathSpline)
		{
			throw null;
		}

		// Token: 0x0600C366 RID: 50022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PathSpline CreateNewPathSpline()
		{
			throw null;
		}

		// Token: 0x0600C367 RID: 50023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PathSpline AddNewPartSpline()
		{
			throw null;
		}

		// Token: 0x0600C368 RID: 50024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeletePathDestination(PathDestination pathDestination)
		{
			throw null;
		}

		// Token: 0x0600C369 RID: 50025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PathDestination AddNewPathDestination()
		{
			throw null;
		}

		// Token: 0x0600C36A RID: 50026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, PathPartBase> GetPathParts(List<string> partsID)
		{
			throw null;
		}

		// Token: 0x0600C36B RID: 50027 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PathPartBase GetPartPathByID(string id)
		{
			throw null;
		}

		// Token: 0x0600C36C RID: 50028 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PathSpline GetPathSplineByPoints(string currentDestinationPointID, string targetDestinationPointID)
		{
			throw null;
		}

		// Token: 0x0600C36D RID: 50029 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string MakePathSplineIDByPoints(string p1ID, string p2ID)
		{
			throw null;
		}

		// Token: 0x0600C36E RID: 50030 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMapPathConfigsFromServerData(BTRMapPath pathConfig)
		{
			throw null;
		}

		// Token: 0x0400C534 RID: 50484
		public BTRMapPath PathsConfiguration;

		// Token: 0x0400C535 RID: 50485
		public List<PathSpline> PathSplines;

		// Token: 0x0400C536 RID: 50486
		public List<PathDestination> PathDestinations;

		// Token: 0x0400C537 RID: 50487
		public Vector3 DepotPosition;
	}
}
