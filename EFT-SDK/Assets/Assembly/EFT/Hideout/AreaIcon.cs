using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using EFT.InventoryLogic;
using EFT.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001B92 RID: 7058
	public class AreaIcon : UIElement
	{
		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x0600946D RID: 37997 RVA: 0x00002050 File Offset: 0x00000250
		protected Image BackgroundImage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x0600946E RID: 37998 RVA: 0x00002050 File Offset: 0x00000250
		protected Sprite DefaultSprite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x0600946F RID: 37999 RVA: 0x00002050 File Offset: 0x00000250
		protected Sprite ErrorSprite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06009470 RID: 38000 RVA: 0x00002050 File Offset: 0x00000250
		protected GameObject LockedIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06009471 RID: 38001 RVA: 0x00002050 File Offset: 0x00000250
		protected GameObject UnlockedIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06009472 RID: 38002 RVA: 0x00002050 File Offset: 0x00000250
		protected GameObject ReadyToUpgradeIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06009473 RID: 38003 RVA: 0x00002050 File Offset: 0x00000250
		protected GameObject ConstructingIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06009474 RID: 38004 RVA: 0x00002050 File Offset: 0x00000250
		protected GameObject UpgradingIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06009475 RID: 38005 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009476 RID: 38006 RVA: 0x00002050 File Offset: 0x00000250
		private AreaData AreaData_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06009477 RID: 38007 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(AreaData data)
		{
			throw null;
		}

		// Token: 0x06009478 RID: 38008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GInterface160 generator, bool value)
		{
			throw null;
		}

		// Token: 0x06009479 RID: 38009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetData(AreaData data)
		{
			throw null;
		}

		// Token: 0x0600947A RID: 38010 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600947B RID: 38011 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass1918 item)
		{
			throw null;
		}

		// Token: 0x0600947C RID: 38012 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Item[] items, GClass1918 producingItem)
		{
			throw null;
		}

		// Token: 0x0600947D RID: 38013 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(IEnumerable<Item> obj)
		{
			throw null;
		}

		// Token: 0x06009480 RID: 38016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(ELightStatus lightStatus)
		{
			throw null;
		}

		// Token: 0x06009481 RID: 38017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(bool value)
		{
			throw null;
		}

		// Token: 0x06009482 RID: 38018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(bool value)
		{
			throw null;
		}

		// Token: 0x06009483 RID: 38019 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetLevel()
		{
			throw null;
		}

		// Token: 0x06009484 RID: 38020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetLevel(int level)
		{
			throw null;
		}

		// Token: 0x06009485 RID: 38021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetStatus()
		{
			throw null;
		}

		// Token: 0x06009486 RID: 38022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x06009487 RID: 38023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06009488 RID: 38024 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x06009489 RID: 38025 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x04009B3F RID: 39743
		private const float float_0 = 0.3f;

		// Token: 0x04009B40 RID: 39744
		private const float float_1 = 1f;

		// Token: 0x04009B41 RID: 39745
		private const float float_2 = 0.65f;

		// Token: 0x04009B42 RID: 39746
		[SerializeField]
		private TextMeshProUGUI _currentAreaLevel;

		// Token: 0x04009B43 RID: 39747
		[SerializeField]
		private TextMeshProUGUI _nextAreaLevel;

		// Token: 0x04009B44 RID: 39748
		[SerializeField]
		private CanvasGroup _iconCanvasGroup;

		// Token: 0x04009B45 RID: 39749
		[SerializeField]
		private Image _selectedBorder;

		// Token: 0x04009B46 RID: 39750
		[SerializeField]
		private Image _hoverBorder;

		// Token: 0x04009B47 RID: 39751
		[SerializeField]
		private Image _areaIconImage;

		// Token: 0x04009B48 RID: 39752
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x04009B49 RID: 39753
		[SerializeField]
		private Image _constructingImage;

		// Token: 0x04009B4A RID: 39754
		[SerializeField]
		private Image _producingImage;

		// Token: 0x04009B4B RID: 39755
		[SerializeField]
		private GameObject _lockedIcon;

		// Token: 0x04009B4C RID: 39756
		[SerializeField]
		private GameObject _unlockedIcon;

		// Token: 0x04009B4D RID: 39757
		[SerializeField]
		private GameObject _readyToUpgradeIcon;

		// Token: 0x04009B4E RID: 39758
		[SerializeField]
		private GameObject _constructingIcon;

		// Token: 0x04009B4F RID: 39759
		[SerializeField]
		private GameObject _upgradingIcon;

		// Token: 0x04009B50 RID: 39760
		[SerializeField]
		private GameObject _producingIcon;

		// Token: 0x04009B51 RID: 39761
		[SerializeField]
		private GameObject _outOfFuelIcon;

		// Token: 0x04009B52 RID: 39762
		[SerializeField]
		private Image _eliteBackgroundImage;

		// Token: 0x04009B53 RID: 39763
		[SerializeField]
		private Sprite _defaultSprite;

		// Token: 0x04009B54 RID: 39764
		[SerializeField]
		private Sprite _readyToPerformSprite;

		// Token: 0x04009B55 RID: 39765
		[SerializeField]
		private Sprite _errorSprite;

		// Token: 0x04009B56 RID: 39766
		[SerializeField]
		private GameObject _producingProgressState;

		// Token: 0x04009B57 RID: 39767
		[SerializeField]
		private GameObject _producingReadyState;

		// Token: 0x04009B58 RID: 39768
		protected TweenerCore<Color, Color, ColorOptions> BackImageFade;

		// Token: 0x04009B59 RID: 39769
		private List<Tweener> list_0;

		// Token: 0x04009B5A RID: 39770
		private TweenerCore<Color, Color, ColorOptions> tweenerCore_0;

		// Token: 0x04009B5B RID: 39771
		private TweenerCore<float, float, FloatOptions> tweenerCore_1;

		// Token: 0x04009B5C RID: 39772
		private TweenerCore<Color, Color, ColorOptions> tweenerCore_2;

		// Token: 0x04009B5D RID: 39773
		[CompilerGenerated]
		private AreaData areaData_0;

		// Token: 0x02001B93 RID: 7059
		[CompilerGenerated]
		private sealed class Class1669
		{
			// Token: 0x0600948A RID: 38026 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600948B RID: 38027 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600948C RID: 38028 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0600948D RID: 38029 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x0600948E RID: 38030 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4()
			{
				throw null;
			}

			// Token: 0x0600948F RID: 38031 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_5()
			{
				throw null;
			}

			// Token: 0x04009B5E RID: 39774
			public GeneratorBehaviour generatorBehaviour;

			// Token: 0x04009B5F RID: 39775
			public AreaIcon areaIcon_0;

			// Token: 0x04009B60 RID: 39776
			public GClass1912 producer;
		}
	}
}
