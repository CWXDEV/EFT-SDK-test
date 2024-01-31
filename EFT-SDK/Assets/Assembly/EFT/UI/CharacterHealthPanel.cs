using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028D3 RID: 10451
	[RequireComponent(typeof(BattleUIComponentAnimation))]
	public sealed class CharacterHealthPanel : UIElement
	{
		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x0600D0B9 RID: 53433 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D0BA RID: 53434 RVA: 0x00002050 File Offset: 0x00000250
		public bool AutoHide
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

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x0600D0BB RID: 53435 RVA: 0x00002050 File Offset: 0x00000250
		public bool AnyCriticalEffects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D0BC RID: 53436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600D0BD RID: 53437 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IHealthController healthController)
		{
			throw null;
		}

		// Token: 0x0600D0BE RID: 53438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AnimatedShow(bool autohide)
		{
			throw null;
		}

		// Token: 0x0600D0BF RID: 53439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AnimatedHide(float delaySeconds = 0f)
		{
			throw null;
		}

		// Token: 0x0600D0C0 RID: 53440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D0C1 RID: 53441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600D0C2 RID: 53442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<IEffect> method_2()
		{
			throw null;
		}

		// Token: 0x0600D0C3 RID: 53443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600D0C4 RID: 53444 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600D0C5 RID: 53445 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600D0C6 RID: 53446 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600D0C7 RID: 53447 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(GInterface226 buff)
		{
			throw null;
		}

		// Token: 0x0400D188 RID: 53640
		[SerializeField]
		private Image _background;

		// Token: 0x0400D189 RID: 53641
		[SerializeField]
		private BodyPartImage _headImage;

		// Token: 0x0400D18A RID: 53642
		[SerializeField]
		private BodyPartImage _chestImage;

		// Token: 0x0400D18B RID: 53643
		[SerializeField]
		private BodyPartImage _stomachImage;

		// Token: 0x0400D18C RID: 53644
		[SerializeField]
		private BodyPartImage _leftHandImage;

		// Token: 0x0400D18D RID: 53645
		[SerializeField]
		private BodyPartImage _rightHandImage;

		// Token: 0x0400D18E RID: 53646
		[SerializeField]
		private BodyPartImage _leftLegImage;

		// Token: 0x0400D18F RID: 53647
		[SerializeField]
		private BodyPartImage _rightLegImage;

		// Token: 0x0400D190 RID: 53648
		[SerializeField]
		private GameObject _effectsPanel;

		// Token: 0x0400D191 RID: 53649
		[SerializeField]
		private StackedEffectIcon _effectIconTemplate;

		// Token: 0x0400D192 RID: 53650
		private BattleUIComponentAnimation battleUIComponentAnimation_0;

		// Token: 0x0400D193 RID: 53651
		private IHealthController ihealthController_0;

		// Token: 0x0400D194 RID: 53652
		private GClass3357<GClass2457> gclass3357_0;

		// Token: 0x0400D195 RID: 53653
		private bool bool_0;

		// Token: 0x0400D196 RID: 53654
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x020028D4 RID: 10452
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2375
		{
			// Token: 0x0600D0C8 RID: 53448 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(IEffect effect)
			{
				throw null;
			}

			// Token: 0x0600D0C9 RID: 53449 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(GClass3381<GClass2457> effect, StackedEffectIcon icon)
			{
				throw null;
			}

			// Token: 0x0600D0CA RID: 53450 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(GClass2457 e)
			{
				throw null;
			}

			// Token: 0x0600D0CB RID: 53451 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<GClass2457> method_3(IEffect x)
			{
				throw null;
			}

			// Token: 0x0600D0CC RID: 53452 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(IEffect effect)
			{
				throw null;
			}

			// Token: 0x0400D197 RID: 53655
			public static readonly CharacterHealthPanel.Class2375 class2375_0;

			// Token: 0x0400D198 RID: 53656
			public static Func<IEffect, bool> func_0;

			// Token: 0x0400D199 RID: 53657
			public static Func<GClass2457, bool> func_1;

			// Token: 0x0400D19A RID: 53658
			public static Action<GClass3381<GClass2457>, StackedEffectIcon> action_0;

			// Token: 0x0400D19B RID: 53659
			public static Func<IEffect, IEnumerable<GClass2457>> func_2;

			// Token: 0x0400D19C RID: 53660
			public static Func<IEffect, bool> func_3;
		}

		// Token: 0x020028D5 RID: 10453
		[CompilerGenerated]
		private sealed class Class2376
		{
			// Token: 0x0600D0CD RID: 53453 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass2457 x)
			{
				throw null;
			}

			// Token: 0x0600D0CE RID: 53454 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Sprite method_1(GClass2457 x)
			{
				throw null;
			}

			// Token: 0x0400D19D RID: 53661
			public Dictionary<Type, Sprite> icons;
		}

		// Token: 0x020028D6 RID: 10454
		[CompilerGenerated]
		private sealed class Class2377
		{
			// Token: 0x0600D0CF RID: 53455 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass2457 b)
			{
				throw null;
			}

			// Token: 0x0400D19E RID: 53662
			public GClass2457 effectDescription;
		}
	}
}
