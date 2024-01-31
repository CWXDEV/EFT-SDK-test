using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Diz.Skinning
{
	// Token: 0x020030A3 RID: 12451
	public abstract class AbstractSkin : MonoBehaviour
	{
		// Token: 0x0600F480 RID: 62592
		public abstract void ApplySkin();

		// Token: 0x0600F481 RID: 62593
		public abstract void Unskin();

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x0600F482 RID: 62594
		public abstract SkinnedMeshRenderer SkinnedMeshRenderer { get; }

		// Token: 0x0600F483 RID: 62595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Unsubscribe()
		{
			throw null;
		}

		// Token: 0x0400FA93 RID: 64147
		protected Action _unsubscribe;
	}
}
