using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Gestures
{
	// Token: 0x02002EA6 RID: 11942
	public abstract class GesturesBindAlignment : MonoBehaviour, PredefinedLayoutGroup.GInterface378
	{
		// Token: 0x0600EBA9 RID: 60329 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AlignToCenter()
		{
			throw null;
		}

		// Token: 0x0600EBAA RID: 60330 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AlignToLeft()
		{
			throw null;
		}

		// Token: 0x0600EBAB RID: 60331 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AlignToRight()
		{
			throw null;
		}

		// Token: 0x0600EBAC RID: 60332 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600EBAD RID: 60333 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600EBAE RID: 60334 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_0(RectTransform rectTransform)
		{
			throw null;
		}

		// Token: 0x0600EBAF RID: 60335 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1(RectTransform rectTransform)
		{
			throw null;
		}

		// Token: 0x0400F0C7 RID: 61639
		[SerializeField]
		protected RectTransform BindRoot;

		// Token: 0x0400F0C8 RID: 61640
		[SerializeField]
		protected Image HotkeyImage;

		// Token: 0x0400F0C9 RID: 61641
		[SerializeField]
		private CustomTextMeshProUGUI _textField;

		// Token: 0x0400F0CA RID: 61642
		[SerializeField]
		private Sprite _leftHotkeySprite;

		// Token: 0x0400F0CB RID: 61643
		[SerializeField]
		private Sprite _rightHotkeySprite;
	}
}
