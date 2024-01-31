using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling
{
	// Token: 0x02000D9B RID: 3483
	[CreateAssetMenu]
	public class PerfectCullingColorTable : ScriptableObject
	{
		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x060049A7 RID: 18855 RVA: 0x00002050 File Offset: 0x00000250
		public static PerfectCullingColorTable Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x060049A8 RID: 18856 RVA: 0x00002050 File Offset: 0x00000250
		public Color32[] Colors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Generate")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x040054DD RID: 21725
		[SerializeField]
		[HideInInspector]
		private Color32[] m_colors;
	}
}
