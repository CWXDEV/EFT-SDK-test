using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001BEF RID: 7151
	public sealed class LoadingScreen : UIScreen
	{
		// Token: 0x0600964B RID: 38475 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			throw null;
		}

		// Token: 0x0600964C RID: 38476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadComplete()
		{
			throw null;
		}

		// Token: 0x0600964D RID: 38477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600964E RID: 38478 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600964F RID: 38479 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x04009D00 RID: 40192
		[SerializeField]
		private float _rotationAngle;

		// Token: 0x04009D01 RID: 40193
		[SerializeField]
		private float _rotationSpeed;

		// Token: 0x04009D02 RID: 40194
		[SerializeField]
		private Image _hideoutImage;

		// Token: 0x04009D03 RID: 40195
		[SerializeField]
		private RectTransform _hideoutIcon;

		// Token: 0x04009D04 RID: 40196
		[SerializeField]
		private Image _background;

		// Token: 0x04009D05 RID: 40197
		[SerializeField]
		private Animation _hideoutLogoAnimation;

		// Token: 0x04009D06 RID: 40198
		[SerializeField]
		private CanvasGroup _centerLogo;

		// Token: 0x04009D07 RID: 40199
		[SerializeField]
		private CanvasGroup _topLeftLogo;

		// Token: 0x04009D08 RID: 40200
		private Coroutine coroutine_2;
	}
}
