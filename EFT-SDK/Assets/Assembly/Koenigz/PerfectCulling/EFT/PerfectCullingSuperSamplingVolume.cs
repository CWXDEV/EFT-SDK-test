using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E47 RID: 3655
	public sealed class PerfectCullingSuperSamplingVolume : MonoBehaviour, GClass775.GInterface29
	{
		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06004C5C RID: 19548 RVA: 0x00002050 File Offset: 0x00000250
		public GuidReference CrossGroupReference
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06004C5D RID: 19549 RVA: 0x00002050 File Offset: 0x00000250
		public PerfectCullingCrossSceneGroup CrossGroup
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PerfectCullingSuperSamplingVolume Create(PerfectCullingCrossSceneVolume volume, PerfectCullingCrossSceneGroup group, int cellSizeType)
		{
			throw null;
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06004C5F RID: 19551 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004C60 RID: 19552 RVA: 0x00002050 File Offset: 0x00000250
		public int CellSize
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

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06004C61 RID: 19553 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 VolumeSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06004C62 RID: 19554 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004C63 RID: 19555 RVA: 0x00002050 File Offset: 0x00000250
		public Bounds VolumeBakeBounds
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

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06004C64 RID: 19556 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 BakeCellSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06004C65 RID: 19557 RVA: 0x00002050 File Offset: 0x00000250
		public int CellCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Vector3> GetSamplingPositions(Space space = Space.Self)
		{
			throw null;
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_0(int index, Vector3 cellSize, Space space = Space.Self)
		{
			throw null;
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_1(int index, Vector3 gridSize, Vector3 cellSize, Space space = Space.Self)
		{
			throw null;
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06004C69 RID: 19561 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004C6A RID: 19562 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x06004C6B RID: 19563 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixVolumeSize()
		{
			throw null;
		}

		// Token: 0x04005758 RID: 22360
		public static readonly Color GIZMO_VOLUME_COLOR;

		// Token: 0x04005759 RID: 22361
		[SerializeField]
		private GuidReference _crossGroupReference;

		// Token: 0x0400575A RID: 22362
		[SerializeField]
		private int _cellSize;

		// Token: 0x0400575B RID: 22363
		[SerializeField]
		private Vector3 _volumeSize;
	}
}
