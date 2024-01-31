using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.UI.Tutorial;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DDF RID: 11743
	public sealed class MatchmakerBannersPanel : UIElement
	{
		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x0600E6EE RID: 59118 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E6EF RID: 59119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(LocationSettingsClass.Location location, ESideType side, ProfileStats stats, Action<string, Callback<Texture2D>> textureLoader)
		{
			throw null;
		}

		// Token: 0x0600E6F0 RID: 59120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Sprite method_0(LocationSettingsClass.Location location)
		{
			throw null;
		}

		// Token: 0x0600E6F1 RID: 59121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600E6F2 RID: 59122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(string bannerName, string description, [CanBeNull] Texture2D texture, bool selected)
		{
			throw null;
		}

		// Token: 0x0600E6F3 RID: 59123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private MatchmakerBanner method_2(string bannerName, string description, Sprite sprite, bool selected)
		{
			throw null;
		}

		// Token: 0x0600E6F4 RID: 59124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GClass3168 bannerWithToggle, bool visible)
		{
			throw null;
		}

		// Token: 0x0600E6F5 RID: 59125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400EC0B RID: 60427
		private const float float_0 = 10f;

		// Token: 0x0400EC0C RID: 60428
		public KeyBannerGenerator KeyBannerGenerator;

		// Token: 0x0400EC0D RID: 60429
		[SerializeField]
		private ToggleGroup _toggleGroup;

		// Token: 0x0400EC0E RID: 60430
		[SerializeField]
		private MatchmakerBanner _bannerImageTemplate;

		// Token: 0x0400EC0F RID: 60431
		[SerializeField]
		private BannerPageToggle _bannerPageTemplate;

		// Token: 0x0400EC10 RID: 60432
		[SerializeField]
		private Sprite _defaultImage;

		// Token: 0x0400EC11 RID: 60433
		[SerializeField]
		private Sprite _savageSprite;

		// Token: 0x0400EC12 RID: 60434
		[SerializeField]
		private CustomTextMeshProUGUI _bannerHeader;

		// Token: 0x0400EC13 RID: 60435
		[SerializeField]
		private CustomTextMeshProUGUI _bannerDescription;

		// Token: 0x0400EC14 RID: 60436
		[SerializeField]
		private RectTransform _bannerPagesPlaceholder;

		// Token: 0x0400EC15 RID: 60437
		[SerializeField]
		private RectTransform _bannerImagesPlaceholder;

		// Token: 0x0400EC16 RID: 60438
		private readonly List<GClass3168> list_0;

		// Token: 0x0400EC17 RID: 60439
		private bool bool_0;

		// Token: 0x0400EC18 RID: 60440
		private bool bool_1;

		// Token: 0x0400EC19 RID: 60441
		private float float_1;

		// Token: 0x0400EC1A RID: 60442
		private int int_0;

		// Token: 0x02002DE0 RID: 11744
		[CompilerGenerated]
		private sealed class Class2862
		{
			// Token: 0x0600E6F6 RID: 59126 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<Texture2D> result)
			{
				throw null;
			}

			// Token: 0x0400EC1B RID: 60443
			public LocationSettingsClass.Location.GClass1219 banner;

			// Token: 0x0400EC1C RID: 60444
			public MatchmakerBannersPanel matchmakerBannersPanel_0;
		}

		// Token: 0x02002DE1 RID: 11745
		[CompilerGenerated]
		private sealed class Class2863
		{
			// Token: 0x0600E6F7 RID: 59127 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400EC1D RID: 60445
			public Sprite sprite;
		}

		// Token: 0x02002DE2 RID: 11746
		[CompilerGenerated]
		private sealed class Class2864
		{
			// Token: 0x0600E6F8 RID: 59128 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool visible)
			{
				throw null;
			}

			// Token: 0x0600E6F9 RID: 59129 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400EC1E RID: 60446
			public MatchmakerBannersPanel matchmakerBannersPanel_0;

			// Token: 0x0400EC1F RID: 60447
			public GClass3168 currentBanner;

			// Token: 0x0400EC20 RID: 60448
			public MatchmakerBanner bannerImage;

			// Token: 0x0400EC21 RID: 60449
			public BannerPageToggle bannerButton;
		}
	}
}
