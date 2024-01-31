using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E73 RID: 3699
	public abstract class GPUInstancerTerrainManager : GPUInstancerManager
	{
		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06004D63 RID: 19811 RVA: 0x00002050 File Offset: 0x00000250
		public Terrain terrain
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06004D64 RID: 19812 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool isCulled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetupManagerWithTerrain(Terrain terrain, bool isOptic = false)
		{
			throw null;
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GPUInstancerTerrainProxy AddProxyToTerrain()
		{
			throw null;
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_2(GPUInstancerTerrainSettings terrainSettings)
		{
			throw null;
		}

		// Token: 0x04005901 RID: 22785
		[SerializeField]
		private Terrain _terrain;

		// Token: 0x04005902 RID: 22786
		protected bool replacingInstances;

		// Token: 0x04005903 RID: 22787
		protected bool initalizingInstances;
	}
}
