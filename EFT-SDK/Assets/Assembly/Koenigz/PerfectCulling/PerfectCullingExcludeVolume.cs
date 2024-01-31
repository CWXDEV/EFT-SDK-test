using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling
{
	// Token: 0x02000DBB RID: 3515
	public class PerfectCullingExcludeVolume : MonoBehaviour, GClass775.GInterface29
	{
		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06004A28 RID: 18984 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A29 RID: 18985 RVA: 0x00002050 File Offset: 0x00000250
		public Bounds volumeExcludeBounds
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

		// Token: 0x06004A2A RID: 18986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos)
		{
			throw null;
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A2C RID: 18988 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 HandleSized
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

		// Token: 0x0400554B RID: 21835
		private static readonly Bounds bounds_0;

		// Token: 0x0400554C RID: 21836
		[SerializeField]
		public Vector3 volumeSize;

		// Token: 0x0400554D RID: 21837
		[SerializeField]
		public PerfectCullingBakingBehaviour[] restrictToBehaviours;
	}
}
