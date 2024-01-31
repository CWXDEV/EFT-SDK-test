using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A18 RID: 10776
	public class StretchArea : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler
	{
		// Token: 0x0600D63B RID: 54843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(StretchArea.EStretchAreaType areaType, RectTransform rootTransform, LayoutElement stretchableObject, Vector2 maxSize)
		{
			throw null;
		}

		// Token: 0x0600D63C RID: 54844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrag([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D63D RID: 54845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D63E RID: 54846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUp([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D63F RID: 54847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D640 RID: 54848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400D889 RID: 55433
		[NonSerialized]
		public readonly GClass3355<ECursorType?> OnCursorChange;

		// Token: 0x0400D88A RID: 55434
		[NonSerialized]
		public readonly GClass3355<ECursorType?> OnForcedCursorChange;

		// Token: 0x0400D88B RID: 55435
		private StretchArea.EStretchAreaType estretchAreaType_0;

		// Token: 0x0400D88C RID: 55436
		private LayoutElement layoutElement_0;

		// Token: 0x0400D88D RID: 55437
		private RectTransform rectTransform_0;

		// Token: 0x0400D88E RID: 55438
		private RectTransform rectTransform_1;

		// Token: 0x0400D88F RID: 55439
		private Vector2 vector2_0;

		// Token: 0x0400D890 RID: 55440
		private ECursorType ecursorType_0;

		// Token: 0x0400D891 RID: 55441
		private ECursorType ecursorType_1;

		// Token: 0x0400D892 RID: 55442
		private bool bool_0;

		// Token: 0x0400D893 RID: 55443
		private bool bool_1;

		// Token: 0x0400D894 RID: 55444
		private Vector2 vector2_1;

		// Token: 0x0400D895 RID: 55445
		private Vector2 vector2_2;

		// Token: 0x0400D896 RID: 55446
		private Vector2 vector2_3;

		// Token: 0x02002A19 RID: 10777
		[Flags]
		public enum EStretchAreaType
		{
			// Token: 0x0400D898 RID: 55448
			Top = 1,
			// Token: 0x0400D899 RID: 55449
			Bottom = 2,
			// Token: 0x0400D89A RID: 55450
			Left = 4,
			// Token: 0x0400D89B RID: 55451
			Right = 8,
			// Token: 0x0400D89C RID: 55452
			TopLeft = 5,
			// Token: 0x0400D89D RID: 55453
			TopRight = 9,
			// Token: 0x0400D89E RID: 55454
			BottomLeft = 6,
			// Token: 0x0400D89F RID: 55455
			BottomRight = 10
		}
	}
}
