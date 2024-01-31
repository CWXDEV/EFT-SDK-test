using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DEB RID: 3563
	public sealed class MultisceneSharedOccluder : MonoBehaviour
	{
		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06004ACA RID: 19146 RVA: 0x00002050 File Offset: 0x00000250
		public EOccludeMode OccludeMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06004ACB RID: 19147 RVA: 0x00002050 File Offset: 0x00000250
		public ESharedOccluderLODMode SharedOccluderLODMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06004ACC RID: 19148 RVA: 0x00002050 File Offset: 0x00000250
		public EShadowMode ShadowMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06004ACD RID: 19149 RVA: 0x00002050 File Offset: 0x00000250
		public ETransparencyMode TransparencyMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400560A RID: 22026
		[SerializeField]
		[Tooltip("Culling type.\n\nSharedOccluder\n-> not culled\n-> occludes in other scenes\n\nSharedOccludeeOccluder\n-> culled in volume\n-> occludes in other scenes\n\nOccludee\n-> culled in volume\n-> doesnt occlude in other scenes")]
		private EOccludeMode _occludeMode;

		// Token: 0x0400560B RID: 22027
		[SerializeField]
		[Tooltip("Which LOD to select when generating multiscene shared occluder")]
		private ESharedOccluderLODMode _LODMode;

		// Token: 0x0400560C RID: 22028
		[SerializeField]
		[Tooltip("Shadow culling mode on runtime")]
		private EShadowMode _shadowMode;

		// Token: 0x0400560D RID: 22029
		[Tooltip("How to treat transprent materials when generating shared occluder")]
		[SerializeField]
		private ETransparencyMode _transparencyMode;
	}
}
