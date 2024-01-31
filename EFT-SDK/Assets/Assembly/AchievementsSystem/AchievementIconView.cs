using System;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace AchievementsSystem
{
	// Token: 0x02000D71 RID: 3441
	public sealed class AchievementIconView : UIElement
	{
		// Token: 0x06004913 RID: 18707 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Sprite sprite, bool unlocked, GClass3255 template, ISession session, Action<PointerEventData> onHoverStart = null, Action<PointerEventData> onHoverEnd = null)
		{
			throw null;
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Sprite sprite, bool unlocked, GClass3255 template, GInterface144 session)
		{
			throw null;
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GClass3255 template, GInterface144 session)
		{
			throw null;
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Result<Sprite> res)
		{
			throw null;
		}

		// Token: 0x040053EC RID: 21484
		[SerializeField]
		private Sprite _commonIconBorder;

		// Token: 0x040053ED RID: 21485
		[SerializeField]
		private Sprite _rareIconBorder;

		// Token: 0x040053EE RID: 21486
		[SerializeField]
		private Sprite _legendaryIconBorder;

		// Token: 0x040053EF RID: 21487
		[SerializeField]
		private Sprite _commonIconBackground;

		// Token: 0x040053F0 RID: 21488
		[SerializeField]
		private Sprite _rareIconBackground;

		// Token: 0x040053F1 RID: 21489
		[SerializeField]
		private Sprite _legendaryIconBackground;

		// Token: 0x040053F2 RID: 21490
		[SerializeField]
		private HoverTrigger _iconHoverTrigger;

		// Token: 0x040053F3 RID: 21491
		[SerializeField]
		private Image _iconImage;

		// Token: 0x040053F4 RID: 21492
		[SerializeField]
		private Image _iconBorder;

		// Token: 0x040053F5 RID: 21493
		[SerializeField]
		private Image _iconBackground;

		// Token: 0x040053F6 RID: 21494
		[SerializeField]
		private CanvasGroup _iconCanvasGroup;

		// Token: 0x040053F7 RID: 21495
		[SerializeField]
		[Space]
		private float _notCompletedAlpha;
	}
}
