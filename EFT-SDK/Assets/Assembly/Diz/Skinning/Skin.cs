using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Diz.Skinning
{
	// Token: 0x020030A6 RID: 12454
	public class Skin : AbstractSkin
	{
		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x0600F488 RID: 62600 RVA: 0x00002050 File Offset: 0x00000250
		public override SkinnedMeshRenderer SkinnedMeshRenderer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F489 RID: 62601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Skeleton skeleton)
		{
			throw null;
		}

		// Token: 0x0600F48A RID: 62602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ApplySkin()
		{
			throw null;
		}

		// Token: 0x0600F48B RID: 62603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Unskin()
		{
			throw null;
		}

		// Token: 0x0400FA98 RID: 64152
		[SerializeField]
		[HideInInspector]
		private SkinnedMeshRenderer _skinnedMeshRenderer;

		// Token: 0x0400FA99 RID: 64153
		[HideInInspector]
		[SerializeField]
		private string[] _bonePaths;

		// Token: 0x0400FA9A RID: 64154
		[HideInInspector]
		[SerializeField]
		private string _rootBonePath;

		// Token: 0x0400FA9B RID: 64155
		private Skeleton skeleton_0;
	}
}
