using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001C06 RID: 7174
	public class ComplementaryButton : UIElement
	{
		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x0600967E RID: 38526 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600967F RID: 38527 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsUnlocked
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06009680 RID: 38528 RVA: 0x00002050 File Offset: 0x00000250
		public Sprite Icon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06009681 RID: 38529 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06009682 RID: 38530 RVA: 0x00002050 File Offset: 0x00000250
		private string String_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06009683 RID: 38531 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show([CanBeNull] Action<bool> onClick, Action<PointerEventData> onHoverStart = null, Action onHoverEnd = null, bool unlocked = true, int refreshCooldown = 0)
		{
			throw null;
		}

		// Token: 0x06009684 RID: 38532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTooltipMessages(Func<string> hoverOnEnabled, [CanBeNull] Func<string> hoverOnDisabled)
		{
			throw null;
		}

		// Token: 0x06009685 RID: 38533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06009686 RID: 38534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x06009687 RID: 38535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x06009688 RID: 38536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PointerExit()
		{
			throw null;
		}

		// Token: 0x06009689 RID: 38537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PointerClick(bool value)
		{
			throw null;
		}

		// Token: 0x0600968A RID: 38538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseTooltip()
		{
			throw null;
		}

		// Token: 0x0600968B RID: 38539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600968C RID: 38540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetSelectedStatus(bool selected)
		{
			throw null;
		}

		// Token: 0x0600968D RID: 38541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetIcon(Sprite sprite)
		{
			throw null;
		}

		// Token: 0x0600968E RID: 38542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnlockStatus(bool isUnlocked)
		{
			throw null;
		}

		// Token: 0x0600968F RID: 38543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06009690 RID: 38544 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x06009691 RID: 38545 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x04009D72 RID: 40306
		private const string string_0 = "{0} seconds left";

		// Token: 0x04009D73 RID: 40307
		[SerializeField]
		private HoverTrigger _hoverTrigger;

		// Token: 0x04009D74 RID: 40308
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04009D75 RID: 40309
		[SerializeField]
		private Image _background;

		// Token: 0x04009D76 RID: 40310
		[SerializeField]
		private GameObject _hoverObject;

		// Token: 0x04009D77 RID: 40311
		[SerializeField]
		private Image _icon;

		// Token: 0x04009D78 RID: 40312
		[SerializeField]
		private Sprite _defaultBackground;

		// Token: 0x04009D79 RID: 40313
		[SerializeField]
		private Sprite _selectedBackground;

		// Token: 0x04009D7A RID: 40314
		[SerializeField]
		private Sprite _defaultIcon;

		// Token: 0x04009D7B RID: 40315
		[SerializeField]
		private Sprite _selectedIcon;

		// Token: 0x04009D7C RID: 40316
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x04009D7D RID: 40317
		private Action<PointerEventData> action_0;

		// Token: 0x04009D7E RID: 40318
		private Action action_1;

		// Token: 0x04009D7F RID: 40319
		private Action<bool> action_2;

		// Token: 0x04009D80 RID: 40320
		private bool bool_0;

		// Token: 0x04009D81 RID: 40321
		private int int_0;

		// Token: 0x04009D82 RID: 40322
		private float float_0;

		// Token: 0x04009D83 RID: 40323
		private double double_0;

		// Token: 0x04009D84 RID: 40324
		private bool bool_1;

		// Token: 0x04009D85 RID: 40325
		private Func<string> func_0;

		// Token: 0x04009D86 RID: 40326
		private Func<string> func_1;

		// Token: 0x04009D87 RID: 40327
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x02001C07 RID: 7175
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1692
		{
			// Token: 0x06009692 RID: 38546 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0()
			{
				throw null;
			}

			// Token: 0x06009693 RID: 38547 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1()
			{
				throw null;
			}

			// Token: 0x04009D88 RID: 40328
			public static readonly ComplementaryButton.Class1692 class1692_0;

			// Token: 0x04009D89 RID: 40329
			public static Func<string> func_0;

			// Token: 0x04009D8A RID: 40330
			public static Func<string> func_1;
		}
	}
}
