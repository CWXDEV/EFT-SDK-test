using System;
using System.Runtime.CompilerServices;
using Comfort.Common;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x0200294A RID: 10570
	public class SimpleContextMenuButton : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x0600D2D7 RID: 53975 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D2D8 RID: 53976 RVA: 0x00002050 File Offset: 0x00000250
		public bool Blocked
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600D2D9 RID: 53977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D2DA RID: 53978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Show(string caption, string imageText, Sprite sprite, Action onClicked, Action onHover, bool subMenu = false, bool hideIcon = false)
		{
			throw null;
		}

		// Token: 0x0600D2DB RID: 53979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonInteraction(IResult interactionState)
		{
			throw null;
		}

		// Token: 0x0600D2DC RID: 53980 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D2DD RID: 53981 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D2DE RID: 53982 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D2DF RID: 53983 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0400D463 RID: 54371
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400D464 RID: 54372
		[SerializeField]
		private Button _button;

		// Token: 0x0400D465 RID: 54373
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x0400D466 RID: 54374
		[SerializeField]
		private Color _defaultBackgroundColor;

		// Token: 0x0400D467 RID: 54375
		[SerializeField]
		private Color _selectedBackgroundColor;

		// Token: 0x0400D468 RID: 54376
		[SerializeField]
		private Image _subMenuArrow;

		// Token: 0x0400D469 RID: 54377
		private Action action_0;

		// Token: 0x0400D46A RID: 54378
		private Action action_1;

		// Token: 0x0400D46B RID: 54379
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400D46C RID: 54380
		private bool bool_0;

		// Token: 0x0400D46D RID: 54381
		private bool bool_1;

		// Token: 0x0400D46E RID: 54382
		private string string_0;

		// Token: 0x0400D46F RID: 54383
		private bool bool_2;

		// Token: 0x0400D470 RID: 54384
		private bool bool_3;
	}
}
