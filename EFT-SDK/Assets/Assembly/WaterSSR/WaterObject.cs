using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace WaterSSR
{
	// Token: 0x02000C29 RID: 3113
	[Serializable]
	public class WaterObject
	{
		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060043E0 RID: 17376 RVA: 0x00002050 File Offset: 0x00000250
		public bool Enabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060043E1 RID: 17377 RVA: 0x00002050 File Offset: 0x00000250
		public Mesh Mesh
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060043E2 RID: 17378 RVA: 0x00002050 File Offset: 0x00000250
		public Matrix4x4 TRS
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04004D39 RID: 19769
		[SerializeField]
		public MeshFilter Filter;

		// Token: 0x04004D3A RID: 19770
		[HideInInspector]
		[SerializeField]
		public MeshRenderer Renderer;

		// Token: 0x04004D3B RID: 19771
		[SerializeField]
		[HideInInspector]
		public GameObject GameObject;
	}
}
