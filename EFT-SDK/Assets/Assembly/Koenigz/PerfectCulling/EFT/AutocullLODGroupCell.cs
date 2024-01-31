using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DCE RID: 3534
	[Serializable]
	public sealed class AutocullLODGroupCell : IAutocullAutomated
	{
		// Token: 0x06004A70 RID: 19056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Union(AutocullLODGroupCell other)
		{
			throw null;
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06004A72 RID: 19058 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A73 RID: 19059 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAutocullVisible
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06004A74 RID: 19060 RVA: 0x00002050 File Offset: 0x00000250
		public Bounds AutocullObjectBounds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06004A75 RID: 19061 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsDynamicCullingObject
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040055A9 RID: 21929
		[SerializeField]
		private List<LODGroup> _lodGroups;

		// Token: 0x040055AA RID: 21930
		[SerializeField]
		private Bounds _bounds;

		// Token: 0x040055AB RID: 21931
		private bool _isAutocullVisible;
	}
}
