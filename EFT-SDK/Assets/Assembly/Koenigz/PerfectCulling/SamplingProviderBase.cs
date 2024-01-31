using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling
{
	// Token: 0x02000DA4 RID: 3492
	public abstract class SamplingProviderBase : MonoBehaviour, GInterface63
	{
		// Token: 0x060049C8 RID: 18888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnEnable()
		{
			throw null;
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDisable()
		{
			throw null;
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x060049CA RID: 18890
		public abstract string Name { get; }

		// Token: 0x060049CB RID: 18891
		public abstract void InitializeSamplingProvider();

		// Token: 0x060049CC RID: 18892
		public abstract bool IsSamplingPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos);

		// Token: 0x04005509 RID: 21769
		private GInterface59 ginterface59_0;
	}
}
