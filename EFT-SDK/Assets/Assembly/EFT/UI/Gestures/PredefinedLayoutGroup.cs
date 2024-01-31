using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Gestures
{
	// Token: 0x02002EBA RID: 11962
	[RequireComponent(typeof(RectTransform))]
	[ExecuteAlways]
	public sealed class PredefinedLayoutGroup : LayoutGroup
	{
		// Token: 0x0600EC39 RID: 60473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void CalculateLayoutInputVertical()
		{
			throw null;
		}

		// Token: 0x0600EC3A RID: 60474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetLayoutHorizontal()
		{
			throw null;
		}

		// Token: 0x0600EC3B RID: 60475 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetLayoutVertical()
		{
			throw null;
		}

		// Token: 0x0600EC3C RID: 60476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600EC3D RID: 60477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(RectTransform child, Vector2 anchoredPosition)
		{
			throw null;
		}

		// Token: 0x0400F144 RID: 61764
		private static readonly Vector2 vector2_0;

		// Token: 0x0400F145 RID: 61765
		[SerializeField]
		private Vector2[] PositionsToCenter;

		// Token: 0x0400F146 RID: 61766
		[SerializeField]
		private bool UpdateSideAlignment;

		// Token: 0x02002EBB RID: 11963
		public interface GInterface378
		{
			// Token: 0x0600EC3E RID: 60478
			void AlignToCenter();

			// Token: 0x0600EC3F RID: 60479
			void AlignToLeft();

			// Token: 0x0600EC40 RID: 60480
			void AlignToRight();
		}
	}
}
