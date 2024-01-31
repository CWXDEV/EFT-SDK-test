using System;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A9F RID: 10911
	public sealed class NonDrawingGraphic : Graphic
	{
		// Token: 0x0600D8ED RID: 55533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetMaterialDirty()
		{
			throw null;
		}

		// Token: 0x0600D8EE RID: 55534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetVerticesDirty()
		{
			throw null;
		}

		// Token: 0x0600D8EF RID: 55535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
			throw null;
		}
	}
}
