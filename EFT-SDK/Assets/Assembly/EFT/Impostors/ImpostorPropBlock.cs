using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Impostors
{
	// Token: 0x02001DBD RID: 7613
	[Serializable]
	public struct ImpostorPropBlock
	{
		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06009CD5 RID: 40149 RVA: 0x00002050 File Offset: 0x00000250
		public static int Stride
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400A476 RID: 42102
		public uint _Index;

		// Token: 0x0400A477 RID: 42103
		public float _Frames;

		// Token: 0x0400A478 RID: 42104
		public float _ImpostorSize;

		// Token: 0x0400A479 RID: 42105
		public float _TextureBias;

		// Token: 0x0400A47A RID: 42106
		public float _Parallax;

		// Token: 0x0400A47B RID: 42107
		public float _DepthSize;

		// Token: 0x0400A47C RID: 42108
		public float _ClipMask;

		// Token: 0x0400A47D RID: 42109
		public float _AI_ShadowBias;

		// Token: 0x0400A47E RID: 42110
		public float _AI_ShadowView;

		// Token: 0x0400A47F RID: 42111
		public float _Hemi;

		// Token: 0x0400A480 RID: 42112
		public Vector4 _Offset;

		// Token: 0x0400A481 RID: 42113
		public Vector4 _AI_SizeOffset;

		// Token: 0x0400A482 RID: 42114
		public Vector2 padding;
	}
}
