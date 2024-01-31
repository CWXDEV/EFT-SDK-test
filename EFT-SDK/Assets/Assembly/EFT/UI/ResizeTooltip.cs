using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002AC5 RID: 10949
	public class ResizeTooltip : UIElement
	{
		// Token: 0x0600D9AB RID: 55723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GStruct23 oldSize, GStruct23 newSize, Vector2 tooltipOffset, RectTransform parentTooltip)
		{
			throw null;
		}

		// Token: 0x0600D9AC RID: 55724 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static GStruct23 smethod_0(GStruct23 cellSize)
		{
			throw null;
		}

		// Token: 0x0600D9AD RID: 55725 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0400DC8A RID: 56458
		[SerializeField]
		private RectTransform _oldTiles;

		// Token: 0x0400DC8B RID: 56459
		[SerializeField]
		private ColorBlinker _newTiles;

		// Token: 0x0400DC8C RID: 56460
		[SerializeField]
		private RectTransform _upArrow;

		// Token: 0x0400DC8D RID: 56461
		[SerializeField]
		private RectTransform _rightArrow;

		// Token: 0x0400DC8E RID: 56462
		private const int int_0 = 10;

		// Token: 0x0400DC8F RID: 56463
		private static readonly Color color_0;

		// Token: 0x0400DC90 RID: 56464
		private Vector2 vector2_0;

		// Token: 0x0400DC91 RID: 56465
		private RectTransform rectTransform_1;
	}
}
