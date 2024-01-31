using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling
{
	// Token: 0x02000D8F RID: 3471
	public abstract class PerfectCullingBakeData : ScriptableObject
	{
		// Token: 0x06004962 RID: 18786 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual ushort[] GetRawData(int index)
		{
			throw null;
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetRawData(int index, GClass1001 indices)
		{
			throw null;
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetRawData(int index, ushort[] indices)
		{
			throw null;
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SampleAtIndex(int index, List<ushort> indices)
		{
			throw null;
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PrepareForBake(PerfectCullingBakingBehaviour bakingBehaviour)
		{
			throw null;
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void CompleteBake()
		{
			throw null;
		}

		// Token: 0x040054A1 RID: 21665
		[SerializeField]
		public int bakeDataVersion;

		// Token: 0x040054A2 RID: 21666
		[SerializeField]
		public bool bakeCompleted;

		// Token: 0x040054A3 RID: 21667
		[SerializeField]
		public int bakeHash;

		// Token: 0x040054A4 RID: 21668
		[SerializeField]
		public string strBakeDate;

		// Token: 0x040054A5 RID: 21669
		[SerializeField]
		public long bakeDurationMilliseconds;
	}
}
