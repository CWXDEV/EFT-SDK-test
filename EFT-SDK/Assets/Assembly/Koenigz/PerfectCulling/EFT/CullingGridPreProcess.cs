using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DFB RID: 3579
	public sealed class CullingGridPreProcess : PerfectCullingCrossSceneGroupPreProcess
	{
		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x00002050 File Offset: 0x00000250
		public Bounds[] VisibilityCells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06004AF7 RID: 19191 RVA: 0x00002050 File Offset: 0x00000250
		public GuidReference[] CullingGridContent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetBakeHash()
		{
			throw null;
		}

		// Token: 0x04005628 RID: 22056
		[SerializeField]
		private PerfectCullingAdaptiveGrid _grid;

		// Token: 0x04005629 RID: 22057
		[SerializeField]
		[HideInInspector]
		private Bounds[] _visibilityCells;

		// Token: 0x0400562A RID: 22058
		[SerializeField]
		private GuidReference[] _cullingGridContent;
	}
}
