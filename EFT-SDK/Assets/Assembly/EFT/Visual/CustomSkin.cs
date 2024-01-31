using System;
using System.Runtime.CompilerServices;
using Diz.Skinning;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x02001A11 RID: 6673
	public class CustomSkin<TSkin> : AbstractSkin
	{
		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06008DAA RID: 36266 RVA: 0x00002050 File Offset: 0x00000250
		public override SkinnedMeshRenderer SkinnedMeshRenderer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008DAB RID: 36267 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ApplySkin()
		{
			throw null;
		}

		// Token: 0x06008DAC RID: 36268 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Unskin()
		{
			throw null;
		}

		// Token: 0x04009407 RID: 37895
		public Skin Skin;

		// Token: 0x04009408 RID: 37896
		public TSkin Data;
	}
}
