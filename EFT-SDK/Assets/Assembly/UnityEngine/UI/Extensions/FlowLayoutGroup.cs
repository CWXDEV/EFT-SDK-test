using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200309B RID: 12443
	[AddComponentMenu("Layout/Extensions/Flow Layout Group")]
	public class FlowLayoutGroup : LayoutGroup
	{
		// Token: 0x0600F407 RID: 62471 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void CalculateLayoutInputHorizontal()
		{
			throw null;
		}

		// Token: 0x0600F408 RID: 62472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetLayoutHorizontal()
		{
			throw null;
		}

		// Token: 0x0600F409 RID: 62473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetLayoutVertical()
		{
			throw null;
		}

		// Token: 0x0600F40A RID: 62474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void CalculateLayoutInputVertical()
		{
			throw null;
		}

		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x0600F40B RID: 62475 RVA: 0x00002050 File Offset: 0x00000250
		protected bool IsCenterAlign
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x0600F40C RID: 62476 RVA: 0x00002050 File Offset: 0x00000250
		protected bool IsRightAlign
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x0600F40D RID: 62477 RVA: 0x00002050 File Offset: 0x00000250
		protected bool IsMiddleAlign
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x0600F40E RID: 62478 RVA: 0x00002050 File Offset: 0x00000250
		protected bool IsLowerAlign
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F40F RID: 62479 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float SetLayout(float width, int axis, bool layoutInput)
		{
			throw null;
		}

		// Token: 0x0600F410 RID: 62480 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0(float groupHeight, float yOffset, float currentRowHeight)
		{
			throw null;
		}

		// Token: 0x0600F411 RID: 62481 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis)
		{
			throw null;
		}

		// Token: 0x0600F412 RID: 62482 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetGreatestMinimumChildWidth()
		{
			throw null;
		}

		// Token: 0x0400FA32 RID: 64050
		public float SpacingX;

		// Token: 0x0400FA33 RID: 64051
		public float SpacingY;

		// Token: 0x0400FA34 RID: 64052
		public bool ExpandHorizontalSpacing;

		// Token: 0x0400FA35 RID: 64053
		public bool ChildForceExpandWidth;

		// Token: 0x0400FA36 RID: 64054
		public bool ChildForceExpandHeight;

		// Token: 0x0400FA37 RID: 64055
		private float float_0;

		// Token: 0x0400FA38 RID: 64056
		private readonly IList<RectTransform> ilist_0;
	}
}
