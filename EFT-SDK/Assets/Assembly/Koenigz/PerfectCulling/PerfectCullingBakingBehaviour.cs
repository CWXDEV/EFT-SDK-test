using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling
{
	// Token: 0x02000D99 RID: 3481
	public abstract class PerfectCullingBakingBehaviour : MonoBehaviour, GInterface59
	{
		// Token: 0x0600498A RID: 18826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddSamplingProvider(GInterface63 samplingProvider)
		{
			throw null;
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveSamplingProvider(GInterface63 samplingProvider)
		{
			throw null;
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeAllSamplingProviders()
		{
			throw null;
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SamplingProvidersIsPositionActive(Vector3 pos)
		{
			throw null;
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x0600498E RID: 18830 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600498F RID: 18831 RVA: 0x00002050 File Offset: 0x00000250
		public virtual PerfectCullingBakeGroup[] bakeGroups
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

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06004990 RID: 18832 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004991 RID: 18833 RVA: 0x00002050 File Offset: 0x00000250
		public virtual List<Renderer> additionalOccluders
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

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06004992 RID: 18834 RVA: 0x00002050 File Offset: 0x00000250
		public virtual PerfectCullingBakeData BakeData
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Start()
		{
			throw null;
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleAllRenderers(bool state, bool forceNullCheck = false)
		{
			throw null;
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetBakeData(PerfectCullingBakeData bakeData)
		{
			throw null;
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual List<Vector3> GetSamplingPositions(Space space = Space.Self)
		{
			throw null;
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Vector3 GetWorldPositionForIndex(int index)
		{
			throw null;
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void GetIndicesForWorldPos(Vector3 worldPos, List<ushort> indices)
		{
			throw null;
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int GetIndexForWorldPos(Vector3 worldPos, out bool isOutOfBounds)
		{
			throw null;
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void GetIndicesForIndex(int index, List<ushort> indices)
		{
			throw null;
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool PreBake()
		{
			throw null;
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PostBake()
		{
			throw null;
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int GetBakeHash()
		{
			throw null;
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CullAdditionalOccluders(ref HashSet<Renderer> additionalOccluders)
		{
			throw null;
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void InitializeBake()
		{
			throw null;
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PostProcessBakeData(PerfectCullingBakeData data)
		{
			throw null;
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060049A1 RID: 18849 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060049A2 RID: 18850 RVA: 0x00002050 File Offset: 0x00000250
		public static bool IsBakeActive
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x040054D3 RID: 21715
		private static GInterface63 ginterface63_0;

		// Token: 0x040054D4 RID: 21716
		public HashSet<GInterface63> SamplingProviders;

		// Token: 0x040054D5 RID: 21717
		[SerializeField]
		[HideInInspector]
		public PerfectCullingBakeGroup[] _bakeGroups;

		// Token: 0x040054D6 RID: 21718
		[SerializeField]
		public List<Renderer> _additionalOccluders;

		// Token: 0x040054D7 RID: 21719
		[CompilerGenerated]
		private readonly PerfectCullingBakeData perfectCullingBakeData_0;

		// Token: 0x040054D8 RID: 21720
		[NonSerialized]
		public int TotalVertexCount;

		// Token: 0x040054D9 RID: 21721
		[CompilerGenerated]
		private static bool bool_0;
	}
}
