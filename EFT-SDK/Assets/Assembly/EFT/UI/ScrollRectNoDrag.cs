using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C48 RID: 11336
	public class ScrollRectNoDrag : ScrollRect, ILayoutElement
	{
		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x0600DF67 RID: 57191 RVA: 0x00002050 File Offset: 0x00000250
		public override float preferredWidth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x0600DF68 RID: 57192 RVA: 0x00002050 File Offset: 0x00000250
		public override float preferredHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x0600DF69 RID: 57193 RVA: 0x00002050 File Offset: 0x00000250
		public override int layoutPriority
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DF6A RID: 57194 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void CalculateLayoutInputHorizontal()
		{
			throw null;
		}

		// Token: 0x0600DF6B RID: 57195 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void CalculateLayoutInputVertical()
		{
			throw null;
		}

		// Token: 0x0600DF6C RID: 57196 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600DF6D RID: 57197 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnInitializePotentialDrag([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DF6E RID: 57198 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnBeginDrag([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DF6F RID: 57199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnEndDrag([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DF70 RID: 57200 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDrag([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DF71 RID: 57201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnScroll([NotNull] PointerEventData data)
		{
			throw null;
		}

		// Token: 0x0600DF72 RID: 57202 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600DF73 RID: 57203 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600DF74 RID: 57204 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetContentAnchoredPosition(Vector2 position)
		{
			throw null;
		}

		// Token: 0x0400E431 RID: 58417
		[SerializeField]
		public bool ControlSize;

		// Token: 0x0400E432 RID: 58418
		[SerializeField]
		public float MaxWidth;

		// Token: 0x0400E433 RID: 58419
		[SerializeField]
		public float MaxHeight;

		// Token: 0x0400E434 RID: 58420
		[SerializeField]
		public bool AutoZeroing;

		// Token: 0x0400E435 RID: 58421
		[SerializeField]
		public TextAnchor Alignment;

		// Token: 0x0400E436 RID: 58422
		private ScrollRect.ScrollbarVisibility scrollbarVisibility_0;

		// Token: 0x0400E437 RID: 58423
		private float float_0;

		// Token: 0x0400E438 RID: 58424
		private float float_1;

		// Token: 0x0400E439 RID: 58425
		private RectTransform rectTransform_0;
	}
}
