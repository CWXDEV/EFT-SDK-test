using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.SamplingProviders
{
	// Token: 0x02000DC3 RID: 3523
	[RequireComponent(typeof(PerfectCullingBakingBehaviour))]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class ExcludeFloatingSamplingProvider : SamplingProviderBase
	{
		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06004A3F RID: 19007 RVA: 0x00002050 File Offset: 0x00000250
		public LayerMask CollisionMask
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06004A40 RID: 19008 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A41 RID: 19009 RVA: 0x00002050 File Offset: 0x00000250
		public bool UseTerrainVerticalCheck
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

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06004A42 RID: 19010 RVA: 0x00002050 File Offset: 0x00000250
		public override string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitializeSamplingProvider()
		{
			throw null;
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsSamplingPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos)
		{
			throw null;
		}

		// Token: 0x0400556D RID: 21869
		[SerializeField]
		[Tooltip("Which layers will be used as colliders")]
		private LayerMask layerMask;

		// Token: 0x0400556E RID: 21870
		[SerializeField]
		[Tooltip("Box XZ half size\nShould equal to max jump distance in horizontal plane from infinite height")]
		private float areaSize;

		// Token: 0x0400556F RID: 21871
		[SerializeField]
		[Tooltip("Player height")]
		private float playerHeight;

		// Token: 0x04005570 RID: 21872
		[SerializeField]
		private bool terrainVerticalCheck;

		// Token: 0x04005571 RID: 21873
		[SerializeField]
		private float nearSurfaceCheckRadius;

		// Token: 0x04005572 RID: 21874
		[SerializeField]
		[HideInInspector]
		private Vector3 boxSize;

		// Token: 0x04005573 RID: 21875
		[SerializeField]
		private float _verticalVoidCheckDistance;

		// Token: 0x04005574 RID: 21876
		private TerrainCollider[] terrainCollider_0;

		// Token: 0x04005575 RID: 21877
		private const float float_0 = 400f;
	}
}
