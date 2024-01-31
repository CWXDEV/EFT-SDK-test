using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DFC RID: 3580
	public abstract class PerfectCullingCrossSceneContent : MonoBehaviour, GInterface64
	{
		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06004AF9 RID: 19193 RVA: 0x00002050 File Offset: 0x00000250
		public int ContentGroupId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06004AFA RID: 19194 RVA: 0x00002050 File Offset: 0x00000250
		public int ContentHash
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06004AFB RID: 19195 RVA: 0x00002050 File Offset: 0x00000250
		public PerfectCullingBakeGroup[] BakeGroups
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06004AFC RID: 19196 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2Int IndexSpan
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06004AFD RID: 19197 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004AFE RID: 19198 RVA: 0x00002050 File Offset: 0x00000250
		public PerfectCullingCrossSceneGroup RuntimeCullingGroup
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

		// Token: 0x06004AFF RID: 19199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnBakedLODVisbilityChanged(ScreenDistanceSwitcher bakeLOD, bool isVisible)
		{
			throw null;
		}

		// Token: 0x0400562B RID: 22059
		public const int INVALID_CONTENT_GROUP_ID = -2147483648;

		// Token: 0x0400562C RID: 22060
		[HideInInspector]
		[SerializeField]
		protected int _contentGroupId;

		// Token: 0x0400562D RID: 22061
		[HideInInspector]
		[SerializeField]
		protected int _contentHash;

		// Token: 0x0400562E RID: 22062
		[SerializeField]
		protected PerfectCullingBakeGroup[] _bakeGroups;

		// Token: 0x0400562F RID: 22063
		[SerializeField]
		protected Vector2Int _indexSpan;

		// Token: 0x04005630 RID: 22064
		[CompilerGenerated]
		private PerfectCullingCrossSceneGroup perfectCullingCrossSceneGroup_0;
	}
}
