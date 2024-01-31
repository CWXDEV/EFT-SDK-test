using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001696 RID: 5782
	[Serializable]
	public class SceneResourceKey : ResourceKey, ISceneResource
	{
		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06007D1C RID: 32028 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007D1D RID: 32029 RVA: 0x00002050 File Offset: 0x00000250
		public bool onlyOffline
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

		// Token: 0x06007D1E RID: 32030 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool Equals(SceneResourceKey other)
		{
			throw null;
		}

		// Token: 0x06007D1F RID: 32031 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x040083DF RID: 33759
		[SerializeField]
		private bool _onlyOffline;
	}
}
