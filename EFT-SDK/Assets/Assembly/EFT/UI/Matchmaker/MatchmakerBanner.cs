using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002D7E RID: 11646
	public sealed class MatchmakerBanner : UIElement
	{
		// Token: 0x0600E4FF RID: 58623 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(string bannerName, string description, Sprite sprite)
		{
			throw null;
		}

		// Token: 0x0600E500 RID: 58624 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected(bool value)
		{
			throw null;
		}

		// Token: 0x0600E501 RID: 58625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E502 RID: 58626 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0400EA36 RID: 59958
		[SerializeField]
		private Image _bannerImage;

		// Token: 0x0400EA37 RID: 59959
		[SerializeField]
		private CanvasGroup _imageCanvasGroup;

		// Token: 0x0400EA38 RID: 59960
		[SerializeField]
		private CanvasGroup _bannerCanvasGroup;

		// Token: 0x0400EA39 RID: 59961
		[HideInInspector]
		public string BannerName;

		// Token: 0x0400EA3A RID: 59962
		[HideInInspector]
		public string BannerDescription;

		// Token: 0x0400EA3B RID: 59963
		private const float float_0 = 2f;

		// Token: 0x0400EA3C RID: 59964
		private bool bool_0;

		// Token: 0x0400EA3D RID: 59965
		private Coroutine coroutine_0;
	}
}
