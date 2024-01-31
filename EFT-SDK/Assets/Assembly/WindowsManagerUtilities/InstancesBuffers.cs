using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace WindowsManagerUtilities
{
	// Token: 0x02000C1B RID: 3099
	[Serializable]
	internal class InstancesBuffers
	{
		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x0600438A RID: 17290 RVA: 0x00002050 File Offset: 0x00000250
		public List<TexturesOffsets> TexturesOffsetsList
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x0600438B RID: 17291 RVA: 0x00002050 File Offset: 0x00000250
		public int TexturesOffsetsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddTextureOffsets(TexturesOffsets offsets)
		{
			throw null;
		}

		// Token: 0x04004CF5 RID: 19701
		public List<Matrix4x4> _allTransforms;

		// Token: 0x04004CF6 RID: 19702
		public List<Vector3> _allBounds;

		// Token: 0x04004CF7 RID: 19703
		public List<int> _meshIndex;

		// Token: 0x04004CF8 RID: 19704
		[SerializeField]
		private List<TexturesOffsets> _texturesOffsets;

		// Token: 0x04004CF9 RID: 19705
		[SerializeField]
		private int _texturesOffsetsCount;
	}
}
